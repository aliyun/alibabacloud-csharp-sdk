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
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "agentteams.cn-beijing.aliyuncs.com"},
                {"ap-southeast-1", "agentteams.ap-southeast-1.aliyuncs.com"},
                {"cn-hangzhou", "agentteams.cn-hangzhou.aliyuncs.com"},
            };
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
        /// <para>Binds an upstream identity provider to a specified instance and triggers a synchronization task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This is an asynchronous operation that immediately returns binding task information after the call.</description></item>
        /// <item><description>Use <c>GetInstanceAsyncTask</c> to poll for the asynchronous task result. The default polling interval is 30 seconds, with a maximum of 20 attempts.</description></item>
        /// <item><description>The <c>IdpMetadata</c> parameter contains sensitive information. Ensure secure transmission.</description></item>
        /// <item><description>The default values of <c>LoginEnabled</c> and <c>SyncEnabled</c> are <c>true</c> and <c>false</c>, respectively. If not explicitly specified, the default values are used.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Binds an upstream identity provider to a specified instance and triggers a synchronization task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This is an asynchronous operation that immediately returns binding task information after the call.</description></item>
        /// <item><description>Use <c>GetInstanceAsyncTask</c> to poll for the asynchronous task result. The default polling interval is 30 seconds, with a maximum of 20 attempts.</description></item>
        /// <item><description>The <c>IdpMetadata</c> parameter contains sensitive information. Ensure secure transmission.</description></item>
        /// <item><description>The default values of <c>LoginEnabled</c> and <c>SyncEnabled</c> are <c>true</c> and <c>false</c>, respectively. If not explicitly specified, the default values are used.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Binds an upstream identity provider to a specified instance and triggers a synchronization task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This is an asynchronous operation that immediately returns binding task information after the call.</description></item>
        /// <item><description>Use <c>GetInstanceAsyncTask</c> to poll for the asynchronous task result. The default polling interval is 30 seconds, with a maximum of 20 attempts.</description></item>
        /// <item><description>The <c>IdpMetadata</c> parameter contains sensitive information. Ensure secure transmission.</description></item>
        /// <item><description>The default values of <c>LoginEnabled</c> and <c>SyncEnabled</c> are <c>true</c> and <c>false</c>, respectively. If not explicitly specified, the default values are used.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Binds an upstream identity provider to a specified instance and triggers a synchronization task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This is an asynchronous operation that immediately returns binding task information after the call.</description></item>
        /// <item><description>Use <c>GetInstanceAsyncTask</c> to poll for the asynchronous task result. The default polling interval is 30 seconds, with a maximum of 20 attempts.</description></item>
        /// <item><description>The <c>IdpMetadata</c> parameter contains sensitive information. Ensure secure transmission.</description></item>
        /// <item><description>The default values of <c>LoginEnabled</c> and <c>SyncEnabled</c> are <c>true</c> and <c>false</c>, respectively. If not explicitly specified, the default values are used.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Activates and configures an Internet NAT gateway for a specified AgentTeams instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation creates an Internet NAT gateway and automatically applies for an elastic IP address (EIP), bindS the EIP, and configures SNAT rules.</description></item>
        /// <item><description>An asynchronous task ID is returned after the call. The actual resource ID is provided in the task result.</description></item>
        /// <item><description>NAT gateway name format: <c>magic-create-for-vpc-{vpcId}</c>.</description></item>
        /// <item><description>GET and POST methods are supported.</description></item>
        /// <item><description>The <c>eipBandwidth</c> parameter ranges from 1 to 200 Mbit/s. Default value: 5 Mbit/s.</description></item>
        /// <item><description>If <c>InstanceId</c> is invalid or <c>eipBandwidth</c> is out of range, the API returns an error response.</description></item>
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
        /// <para>Activates and configures an Internet NAT gateway for a specified AgentTeams instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation creates an Internet NAT gateway and automatically applies for an elastic IP address (EIP), bindS the EIP, and configures SNAT rules.</description></item>
        /// <item><description>An asynchronous task ID is returned after the call. The actual resource ID is provided in the task result.</description></item>
        /// <item><description>NAT gateway name format: <c>magic-create-for-vpc-{vpcId}</c>.</description></item>
        /// <item><description>GET and POST methods are supported.</description></item>
        /// <item><description>The <c>eipBandwidth</c> parameter ranges from 1 to 200 Mbit/s. Default value: 5 Mbit/s.</description></item>
        /// <item><description>If <c>InstanceId</c> is invalid or <c>eipBandwidth</c> is out of range, the API returns an error response.</description></item>
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
        /// <para>Activates and configures an Internet NAT gateway for a specified AgentTeams instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation creates an Internet NAT gateway and automatically applies for an elastic IP address (EIP), bindS the EIP, and configures SNAT rules.</description></item>
        /// <item><description>An asynchronous task ID is returned after the call. The actual resource ID is provided in the task result.</description></item>
        /// <item><description>NAT gateway name format: <c>magic-create-for-vpc-{vpcId}</c>.</description></item>
        /// <item><description>GET and POST methods are supported.</description></item>
        /// <item><description>The <c>eipBandwidth</c> parameter ranges from 1 to 200 Mbit/s. Default value: 5 Mbit/s.</description></item>
        /// <item><description>If <c>InstanceId</c> is invalid or <c>eipBandwidth</c> is out of range, the API returns an error response.</description></item>
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
        /// <para>Activates and configures an Internet NAT gateway for a specified AgentTeams instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation creates an Internet NAT gateway and automatically applies for an elastic IP address (EIP), bindS the EIP, and configures SNAT rules.</description></item>
        /// <item><description>An asynchronous task ID is returned after the call. The actual resource ID is provided in the task result.</description></item>
        /// <item><description>NAT gateway name format: <c>magic-create-for-vpc-{vpcId}</c>.</description></item>
        /// <item><description>GET and POST methods are supported.</description></item>
        /// <item><description>The <c>eipBandwidth</c> parameter ranges from 1 to 200 Mbit/s. Default value: 5 Mbit/s.</description></item>
        /// <item><description>If <c>InstanceId</c> is invalid or <c>eipBandwidth</c> is out of range, the API returns an error response.</description></item>
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
        /// <para>Creates a new key-value credential under a specified AgentTeams instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><c>ApiKey</c> is a sensitive field and is not returned in plaintext.</description></item>
        /// <item><description><c>ClientToken</c> is used to ensure idempotence of the request. This parameter is optional but recommended.</description></item>
        /// <item><description>The credential name (Name) must match the regular expression <c>^[A-Z_][A-Z0-9_]*$</c>.</description></item>
        /// <item><description>If the specified credential name already exists in the specified instance, the error code <c>Credential.Name.AlreadyExists</c> is returned.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Creates a new key-value credential under a specified AgentTeams instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><c>ApiKey</c> is a sensitive field and is not returned in plaintext.</description></item>
        /// <item><description><c>ClientToken</c> is used to ensure idempotence of the request. This parameter is optional but recommended.</description></item>
        /// <item><description>The credential name (Name) must match the regular expression <c>^[A-Z_][A-Z0-9_]*$</c>.</description></item>
        /// <item><description>If the specified credential name already exists in the specified instance, the error code <c>Credential.Name.AlreadyExists</c> is returned.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Creates a new key-value credential under a specified AgentTeams instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><c>ApiKey</c> is a sensitive field and is not returned in plaintext.</description></item>
        /// <item><description><c>ClientToken</c> is used to ensure idempotence of the request. This parameter is optional but recommended.</description></item>
        /// <item><description>The credential name (Name) must match the regular expression <c>^[A-Z_][A-Z0-9_]*$</c>.</description></item>
        /// <item><description>If the specified credential name already exists in the specified instance, the error code <c>Credential.Name.AlreadyExists</c> is returned.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Creates a new key-value credential under a specified AgentTeams instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><c>ApiKey</c> is a sensitive field and is not returned in plaintext.</description></item>
        /// <item><description><c>ClientToken</c> is used to ensure idempotence of the request. This parameter is optional but recommended.</description></item>
        /// <item><description>The credential name (Name) must match the regular expression <c>^[A-Z_][A-Z0-9_]*$</c>.</description></item>
        /// <item><description>If the specified credential name already exists in the specified instance, the error code <c>Credential.Name.AlreadyExists</c> is returned.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Asynchronously creates a cluster instance with the specified configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This is an asynchronous operation. After a successful call, the instance status changes to CREATING.</description></item>
        /// <item><description>The actual resource creation is completed asynchronously in the background. Poll the creation result by calling the <c>GetInstance</c> operation.</description></item>
        /// <item><description>You can pass request information by using form parameters or query parameters.</description></item>
        /// <item><description>If optional parameters are not provided, default values are used.</description></item>
        /// <item><description>Use <c>ClientToken</c> to ensure the idempotence of the request.</description></item>
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
        /// <para>Asynchronously creates a cluster instance with the specified configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This is an asynchronous operation. After a successful call, the instance status changes to CREATING.</description></item>
        /// <item><description>The actual resource creation is completed asynchronously in the background. Poll the creation result by calling the <c>GetInstance</c> operation.</description></item>
        /// <item><description>You can pass request information by using form parameters or query parameters.</description></item>
        /// <item><description>If optional parameters are not provided, default values are used.</description></item>
        /// <item><description>Use <c>ClientToken</c> to ensure the idempotence of the request.</description></item>
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
        /// <para>Asynchronously creates a cluster instance with the specified configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This is an asynchronous operation. After a successful call, the instance status changes to CREATING.</description></item>
        /// <item><description>The actual resource creation is completed asynchronously in the background. Poll the creation result by calling the <c>GetInstance</c> operation.</description></item>
        /// <item><description>You can pass request information by using form parameters or query parameters.</description></item>
        /// <item><description>If optional parameters are not provided, default values are used.</description></item>
        /// <item><description>Use <c>ClientToken</c> to ensure the idempotence of the request.</description></item>
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
        /// <para>Asynchronously creates a cluster instance with the specified configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This is an asynchronous operation. After a successful call, the instance status changes to CREATING.</description></item>
        /// <item><description>The actual resource creation is completed asynchronously in the background. Poll the creation result by calling the <c>GetInstance</c> operation.</description></item>
        /// <item><description>You can pass request information by using form parameters or query parameters.</description></item>
        /// <item><description>If optional parameters are not provided, default values are used.</description></item>
        /// <item><description>Use <c>ClientToken</c> to ensure the idempotence of the request.</description></item>
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
        /// <para>Creates an MCP server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>You must specify the <c>InstanceId</c>, <c>Name</c>, and <c>Addresses</c> parameters when you create an MCP server.</description></item>
        /// <item><description>The <c>CreateType</c> parameter defaults to <c>DIRECT_PROXY</c>. If you select the <c>HTTP_TO_MCP</c> mode, you must also specify <c>SwaggerConfig</c>.</description></item>
        /// <item><description>Set <c>AuthEnabled</c> to enable or disable authentication. If authentication is enabled, you must specify <c>AuthConfig</c>.</description></item>
        /// <item><description>Use <c>ClientToken</c> to ensure the idempotence of the request.</description></item>
        /// <item><description>Custom protocol types are supported. The <c>streamable</c> protocol is used by default.</description></item>
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
        /// <para>Creates an MCP server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>You must specify the <c>InstanceId</c>, <c>Name</c>, and <c>Addresses</c> parameters when you create an MCP server.</description></item>
        /// <item><description>The <c>CreateType</c> parameter defaults to <c>DIRECT_PROXY</c>. If you select the <c>HTTP_TO_MCP</c> mode, you must also specify <c>SwaggerConfig</c>.</description></item>
        /// <item><description>Set <c>AuthEnabled</c> to enable or disable authentication. If authentication is enabled, you must specify <c>AuthConfig</c>.</description></item>
        /// <item><description>Use <c>ClientToken</c> to ensure the idempotence of the request.</description></item>
        /// <item><description>Custom protocol types are supported. The <c>streamable</c> protocol is used by default.</description></item>
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
        /// <para>Creates an MCP server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>You must specify the <c>InstanceId</c>, <c>Name</c>, and <c>Addresses</c> parameters when you create an MCP server.</description></item>
        /// <item><description>The <c>CreateType</c> parameter defaults to <c>DIRECT_PROXY</c>. If you select the <c>HTTP_TO_MCP</c> mode, you must also specify <c>SwaggerConfig</c>.</description></item>
        /// <item><description>Set <c>AuthEnabled</c> to enable or disable authentication. If authentication is enabled, you must specify <c>AuthConfig</c>.</description></item>
        /// <item><description>Use <c>ClientToken</c> to ensure the idempotence of the request.</description></item>
        /// <item><description>Custom protocol types are supported. The <c>streamable</c> protocol is used by default.</description></item>
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
        /// <para>Creates an MCP server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>You must specify the <c>InstanceId</c>, <c>Name</c>, and <c>Addresses</c> parameters when you create an MCP server.</description></item>
        /// <item><description>The <c>CreateType</c> parameter defaults to <c>DIRECT_PROXY</c>. If you select the <c>HTTP_TO_MCP</c> mode, you must also specify <c>SwaggerConfig</c>.</description></item>
        /// <item><description>Set <c>AuthEnabled</c> to enable or disable authentication. If authentication is enabled, you must specify <c>AuthConfig</c>.</description></item>
        /// <item><description>Use <c>ClientToken</c> to ensure the idempotence of the request.</description></item>
        /// <item><description>Custom protocol types are supported. The <c>streamable</c> protocol is used by default.</description></item>
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
        /// <para>Creates an AI model under a specified AgentTeams instance. You must specify the model name, the model provider, and the list of supported protocols.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an AI model under a specified AgentTeams instance. You must specify the model name, the model provider, and the list of supported protocols.</para>
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
        /// <para>Creates an AI model under a specified AgentTeams instance. You must specify the model name, the model provider, and the list of supported protocols.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an AI model under a specified AgentTeams instance. You must specify the model name, the model provider, and the list of supported protocols.</para>
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
        /// <para>Creates an AI model under a specified AgentTeams instance. You must specify the model name, the model provider, and the list of supported protocols.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an AI model under a specified AgentTeams instance. You must specify the model name, the model provider, and the list of supported protocols.</para>
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
        /// <para>Creates an AI model under a specified AgentTeams instance. You must specify the model name, the model provider, and the list of supported protocols.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an AI model under a specified AgentTeams instance. You must specify the model name, the model provider, and the list of supported protocols.</para>
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
        /// <para>Creates an AI model provider under a specified AgentTeams instance. You must specify the provider name, address, supported protocol list, and API keys.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an AI model provider under a specified AgentTeams instance. You must specify the provider name, address, supported protocol list, and API keys.</para>
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
        /// <para>Creates an AI model provider under a specified AgentTeams instance. You must specify the provider name, address, supported protocol list, and API keys.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an AI model provider under a specified AgentTeams instance. You must specify the provider name, address, supported protocol list, and API keys.</para>
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
        /// <para>Creates an AI model provider under a specified AgentTeams instance. You must specify the provider name, address, supported protocol list, and API keys.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an AI model provider under a specified AgentTeams instance. You must specify the provider name, address, supported protocol list, and API keys.</para>
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
        /// <para>Creates an AI model provider under a specified AgentTeams instance. You must specify the provider name, address, supported protocol list, and API keys.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an AI model provider under a specified AgentTeams instance. You must specify the provider name, address, supported protocol list, and API keys.</para>
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
        /// <para>Creates an endpoint for a specified instance. Multiple component types and gateway types are supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an endpoint for a specified instance. Multiple component types and gateway types are supported.</para>
        /// <list type="bullet">
        /// <item><description>The current controller uses standard parameter binding instead of @RequestBody, so parameters are better suited for query/form-based transmission.</description></item>
        /// <item><description>The domain field is trimmed and converted to lowercase on the server side.</description></item>
        /// <item><description>The query and headers must be in JSON object string format and cannot be arrays.</description></item>
        /// <item><description>The create operation only saves data to the database. The AI Gateway domain name synchronization logic is triggered only during an update when the conditions ELEMENT/MATRIX + AI_GATEWAY + INTERNET are met and the domain name or certificate has changed.</description></item>
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
        /// <para>Creates an endpoint for a specified instance. Multiple component types and gateway types are supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an endpoint for a specified instance. Multiple component types and gateway types are supported.</para>
        /// <list type="bullet">
        /// <item><description>The current controller uses standard parameter binding instead of @RequestBody, so parameters are better suited for query/form-based transmission.</description></item>
        /// <item><description>The domain field is trimmed and converted to lowercase on the server side.</description></item>
        /// <item><description>The query and headers must be in JSON object string format and cannot be arrays.</description></item>
        /// <item><description>The create operation only saves data to the database. The AI Gateway domain name synchronization logic is triggered only during an update when the conditions ELEMENT/MATRIX + AI_GATEWAY + INTERNET are met and the domain name or certificate has changed.</description></item>
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
        /// <para>Creates an endpoint for a specified instance. Multiple component types and gateway types are supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an endpoint for a specified instance. Multiple component types and gateway types are supported.</para>
        /// <list type="bullet">
        /// <item><description>The current controller uses standard parameter binding instead of @RequestBody, so parameters are better suited for query/form-based transmission.</description></item>
        /// <item><description>The domain field is trimmed and converted to lowercase on the server side.</description></item>
        /// <item><description>The query and headers must be in JSON object string format and cannot be arrays.</description></item>
        /// <item><description>The create operation only saves data to the database. The AI Gateway domain name synchronization logic is triggered only during an update when the conditions ELEMENT/MATRIX + AI_GATEWAY + INTERNET are met and the domain name or certificate has changed.</description></item>
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
        /// <para>Creates an endpoint for a specified instance. Multiple component types and gateway types are supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an endpoint for a specified instance. Multiple component types and gateway types are supported.</para>
        /// <list type="bullet">
        /// <item><description>The current controller uses standard parameter binding instead of @RequestBody, so parameters are better suited for query/form-based transmission.</description></item>
        /// <item><description>The domain field is trimmed and converted to lowercase on the server side.</description></item>
        /// <item><description>The query and headers must be in JSON object string format and cannot be arrays.</description></item>
        /// <item><description>The create operation only saves data to the database. The AI Gateway domain name synchronization logic is triggered only during an update when the conditions ELEMENT/MATRIX + AI_GATEWAY + INTERNET are met and the domain name or certificate has changed.</description></item>
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
        /// <para>Creates a team under a specified instance. You can set the team name, description, administrator, and initial member list.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a team under a specified instance. You can set the team name, description, administrator, and initial member list.</para>
        /// </description>
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
        /// <para>Creates a team under a specified instance. You can set the team name, description, administrator, and initial member list.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a team under a specified instance. You can set the team name, description, administrator, and initial member list.</para>
        /// </description>
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
        /// <para>Creates a team under a specified instance. You can set the team name, description, administrator, and initial member list.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a team under a specified instance. You can set the team name, description, administrator, and initial member list.</para>
        /// </description>
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
        /// <para>Creates a team under a specified instance. You can set the team name, description, administrator, and initial member list.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a team under a specified instance. You can set the team name, description, administrator, and initial member list.</para>
        /// </description>
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
        /// <para>Creates a user under a specified instance. You can set the username, display name, email address, authentication method, note, and password. If no password is specified, the system automatically generates an initial password and returns it in the response.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a user under a specified instance. You can set the username, display name, email address, authentication method, note, and password. If no password is specified, the system automatically generates an initial password and returns it in the response.</para>
        /// </description>
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
        /// <para>Creates a user under a specified instance. You can set the username, display name, email address, authentication method, note, and password. If no password is specified, the system automatically generates an initial password and returns it in the response.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a user under a specified instance. You can set the username, display name, email address, authentication method, note, and password. If no password is specified, the system automatically generates an initial password and returns it in the response.</para>
        /// </description>
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
        /// <para>Creates a user under a specified instance. You can set the username, display name, email address, authentication method, note, and password. If no password is specified, the system automatically generates an initial password and returns it in the response.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a user under a specified instance. You can set the username, display name, email address, authentication method, note, and password. If no password is specified, the system automatically generates an initial password and returns it in the response.</para>
        /// </description>
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
        /// <para>Creates a user under a specified instance. You can set the username, display name, email address, authentication method, note, and password. If no password is specified, the system automatically generates an initial password and returns it in the response.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a user under a specified instance. You can set the username, display name, email address, authentication method, note, and password. If no password is specified, the system automatically generates an initial password and returns it in the response.</para>
        /// </description>
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
        /// <para>Creates a Worker instance with specified configurations such as model, skills, template, MCP servers, and channels.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a Worker instance with specified configurations such as model, skills, template, MCP servers, and channels.</para>
        /// </description>
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
        /// <para>Creates a Worker instance with specified configurations such as model, skills, template, MCP servers, and channels.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a Worker instance with specified configurations such as model, skills, template, MCP servers, and channels.</para>
        /// </description>
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
        /// <para>Creates a Worker instance with specified configurations such as model, skills, template, MCP servers, and channels.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a Worker instance with specified configurations such as model, skills, template, MCP servers, and channels.</para>
        /// </description>
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
        /// <para>Creates a Worker instance with specified configurations such as model, skills, template, MCP servers, and channels.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a Worker instance with specified configurations such as model, skills, template, MCP servers, and channels.</para>
        /// </description>
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
        /// <para>Creates a local management bootstrap token for a Worker, with support for specifying the network type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a local management bootstrap token for a Worker, with support for specifying the network type.</para>
        /// </description>
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
        /// <para>Creates a local management bootstrap token for a Worker, with support for specifying the network type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a local management bootstrap token for a Worker, with support for specifying the network type.</para>
        /// </description>
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
        /// <para>Creates a local management bootstrap token for a Worker, with support for specifying the network type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a local management bootstrap token for a Worker, with support for specifying the network type.</para>
        /// </description>
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
        /// <para>Creates a local management bootstrap token for a Worker, with support for specifying the network type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a local management bootstrap token for a Worker, with support for specifying the network type.</para>
        /// </description>
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
        /// <para>Deletes an existing credential from a specified AgentTeams instance. The credential cannot be deleted if it is still attached to a Worker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an existing credential from a specified AgentTeams instance. The credential cannot be deleted if it is still attached to a Worker.</para>
        /// </description>
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
        /// <para>Deletes an existing credential from a specified AgentTeams instance. The credential cannot be deleted if it is still attached to a Worker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an existing credential from a specified AgentTeams instance. The credential cannot be deleted if it is still attached to a Worker.</para>
        /// </description>
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
        /// <para>Deletes an existing credential from a specified AgentTeams instance. The credential cannot be deleted if it is still attached to a Worker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an existing credential from a specified AgentTeams instance. The credential cannot be deleted if it is still attached to a Worker.</para>
        /// </description>
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
        /// <para>Deletes an existing credential from a specified AgentTeams instance. The credential cannot be deleted if it is still attached to a Worker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an existing credential from a specified AgentTeams instance. The credential cannot be deleted if it is still attached to a Worker.</para>
        /// </description>
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
        /// <para>Releases a specified AgentTeams instance and cleans up related resources. Supports GET and POST methods. After a successful call, the instance status changes to DELETING, and resource cleanup is performed asynchronously in the background.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Releases a specified AgentTeams instance and cleans up related resources. Supports GET and POST methods. After a successful call, the instance status changes to DELETING, and resource cleanup is performed asynchronously in the background.</para>
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
        /// <para>Releases a specified AgentTeams instance and cleans up related resources. Supports GET and POST methods. After a successful call, the instance status changes to DELETING, and resource cleanup is performed asynchronously in the background.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Releases a specified AgentTeams instance and cleans up related resources. Supports GET and POST methods. After a successful call, the instance status changes to DELETING, and resource cleanup is performed asynchronously in the background.</para>
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
        /// <para>Releases a specified AgentTeams instance and cleans up related resources. Supports GET and POST methods. After a successful call, the instance status changes to DELETING, and resource cleanup is performed asynchronously in the background.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Releases a specified AgentTeams instance and cleans up related resources. Supports GET and POST methods. After a successful call, the instance status changes to DELETING, and resource cleanup is performed asynchronously in the background.</para>
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
        /// <para>Releases a specified AgentTeams instance and cleans up related resources. Supports GET and POST methods. After a successful call, the instance status changes to DELETING, and resource cleanup is performed asynchronously in the background.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Releases a specified AgentTeams instance and cleans up related resources. Supports GET and POST methods. After a successful call, the instance status changes to DELETING, and resource cleanup is performed asynchronously in the background.</para>
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
        /// <para>Deletes an MCP server from a specified AgentTeams instance. The server cannot be deleted if it is associated with any Workers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an MCP server from a specified AgentTeams instance. The server cannot be deleted if it is associated with any Workers.</para>
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
        /// <para>Deletes an MCP server from a specified AgentTeams instance. The server cannot be deleted if it is associated with any Workers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an MCP server from a specified AgentTeams instance. The server cannot be deleted if it is associated with any Workers.</para>
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
        /// <para>Deletes an MCP server from a specified AgentTeams instance. The server cannot be deleted if it is associated with any Workers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an MCP server from a specified AgentTeams instance. The server cannot be deleted if it is associated with any Workers.</para>
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
        /// <para>Deletes an MCP server from a specified AgentTeams instance. The server cannot be deleted if it is associated with any Workers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an MCP server from a specified AgentTeams instance. The server cannot be deleted if it is associated with any Workers.</para>
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
        /// <para>Deletes an AI model from a specified AgentTeams instance. The model cannot be deleted if it is still associated with a Worker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an AI model from a specified AgentTeams instance. The model cannot be deleted if it is still associated with a Worker.</para>
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
        /// <para>Deletes an AI model from a specified AgentTeams instance. The model cannot be deleted if it is still associated with a Worker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an AI model from a specified AgentTeams instance. The model cannot be deleted if it is still associated with a Worker.</para>
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
        /// <para>Deletes an AI model from a specified AgentTeams instance. The model cannot be deleted if it is still associated with a Worker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an AI model from a specified AgentTeams instance. The model cannot be deleted if it is still associated with a Worker.</para>
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
        /// <para>Deletes an AI model from a specified AgentTeams instance. The model cannot be deleted if it is still associated with a Worker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an AI model from a specified AgentTeams instance. The model cannot be deleted if it is still associated with a Worker.</para>
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
        /// <para>Deletes an AI model provider from a specified AgentTeams instance. The provider cannot be deleted if it still has associated models.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an AI model provider from a specified AgentTeams instance. The provider cannot be deleted if it still has associated models.</para>
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
        /// <para>Deletes an AI model provider from a specified AgentTeams instance. The provider cannot be deleted if it still has associated models.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an AI model provider from a specified AgentTeams instance. The provider cannot be deleted if it still has associated models.</para>
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
        /// <para>Deletes an AI model provider from a specified AgentTeams instance. The provider cannot be deleted if it still has associated models.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an AI model provider from a specified AgentTeams instance. The provider cannot be deleted if it still has associated models.</para>
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
        /// <para>Deletes an AI model provider from a specified AgentTeams instance. The provider cannot be deleted if it still has associated models.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an AI model provider from a specified AgentTeams instance. The provider cannot be deleted if it still has associated models.</para>
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
        /// <para>Deletes an endpoint from a specified AgentTeams instance and cleans up related resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an endpoint from a specified AgentTeams instance and cleans up related resources.</para>
        /// <list type="bullet">
        /// <item><description>This operation supports GET or POST methods.</description></item>
        /// <item><description>If the target endpoint is of the WORKER type, the system automatically cleans up associated APIG/AI Gateway cloud resources and KubeOne worker service configurations.</description></item>
        /// <item><description>The request parameters must include instanceId and endpointId, and neither can be empty.</description></item>
        /// <item><description>A successful response returns HTTP status code 200 and a success flag. An error response returns the corresponding HTTP status code (such as 400, 404, or 409) and an error message.</description></item>
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
        /// <para>Deletes an endpoint from a specified AgentTeams instance and cleans up related resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an endpoint from a specified AgentTeams instance and cleans up related resources.</para>
        /// <list type="bullet">
        /// <item><description>This operation supports GET or POST methods.</description></item>
        /// <item><description>If the target endpoint is of the WORKER type, the system automatically cleans up associated APIG/AI Gateway cloud resources and KubeOne worker service configurations.</description></item>
        /// <item><description>The request parameters must include instanceId and endpointId, and neither can be empty.</description></item>
        /// <item><description>A successful response returns HTTP status code 200 and a success flag. An error response returns the corresponding HTTP status code (such as 400, 404, or 409) and an error message.</description></item>
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
        /// <para>Deletes an endpoint from a specified AgentTeams instance and cleans up related resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an endpoint from a specified AgentTeams instance and cleans up related resources.</para>
        /// <list type="bullet">
        /// <item><description>This operation supports GET or POST methods.</description></item>
        /// <item><description>If the target endpoint is of the WORKER type, the system automatically cleans up associated APIG/AI Gateway cloud resources and KubeOne worker service configurations.</description></item>
        /// <item><description>The request parameters must include instanceId and endpointId, and neither can be empty.</description></item>
        /// <item><description>A successful response returns HTTP status code 200 and a success flag. An error response returns the corresponding HTTP status code (such as 400, 404, or 409) and an error message.</description></item>
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
        /// <para>Deletes an endpoint from a specified AgentTeams instance and cleans up related resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an endpoint from a specified AgentTeams instance and cleans up related resources.</para>
        /// <list type="bullet">
        /// <item><description>This operation supports GET or POST methods.</description></item>
        /// <item><description>If the target endpoint is of the WORKER type, the system automatically cleans up associated APIG/AI Gateway cloud resources and KubeOne worker service configurations.</description></item>
        /// <item><description>The request parameters must include instanceId and endpointId, and neither can be empty.</description></item>
        /// <item><description>A successful response returns HTTP status code 200 and a success flag. An error response returns the corresponding HTTP status code (such as 400, 404, or 409) and an error message.</description></item>
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
        /// <para>Deletes a team under a specified instance. After deletion, the team and associated resources enter an asynchronous cleanup process.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a team under a specified instance. After deletion, the team and associated resources enter an asynchronous cleanup process.</para>
        /// </description>
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
        /// <para>Deletes a team under a specified instance. After deletion, the team and associated resources enter an asynchronous cleanup process.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a team under a specified instance. After deletion, the team and associated resources enter an asynchronous cleanup process.</para>
        /// </description>
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
        /// <para>Deletes a team under a specified instance. After deletion, the team and associated resources enter an asynchronous cleanup process.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a team under a specified instance. After deletion, the team and associated resources enter an asynchronous cleanup process.</para>
        /// </description>
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
        /// <para>Deletes a team under a specified instance. After deletion, the team and associated resources enter an asynchronous cleanup process.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a team under a specified instance. After deletion, the team and associated resources enter an asynchronous cleanup process.</para>
        /// </description>
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
        /// <para>Deletes a specified user from a specified instance. After deletion, the user cannot log on to or access instance resources. Proceed with caution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified user from a specified instance. After deletion, the user cannot log on to or access instance resources. Proceed with caution.</para>
        /// </description>
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
        /// <para>Deletes a specified user from a specified instance. After deletion, the user cannot log on to or access instance resources. Proceed with caution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified user from a specified instance. After deletion, the user cannot log on to or access instance resources. Proceed with caution.</para>
        /// </description>
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
        /// <para>Deletes a specified user from a specified instance. After deletion, the user cannot log on to or access instance resources. Proceed with caution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified user from a specified instance. After deletion, the user cannot log on to or access instance resources. Proceed with caution.</para>
        /// </description>
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
        /// <para>Deletes a specified user from a specified instance. After deletion, the user cannot log on to or access instance resources. Proceed with caution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified user from a specified instance. After deletion, the user cannot log on to or access instance resources. Proceed with caution.</para>
        /// </description>
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
        /// <para>Deletes a Worker under a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a Worker under a specified instance.</para>
        /// </description>
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
        /// <para>Deletes a Worker under a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a Worker under a specified instance.</para>
        /// </description>
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
        /// <para>Deletes a Worker under a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a Worker under a specified instance.</para>
        /// </description>
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
        /// <para>Deletes a Worker under a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a Worker under a specified instance.</para>
        /// </description>
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
        /// <para>Queries the details of a specified credential under an AgentTeams instance, including the status, description, and list of bound Workers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified credential under an AgentTeams instance, including the status, description, and list of bound Workers.</para>
        /// </description>
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
        /// <para>Queries the details of a specified credential under an AgentTeams instance, including the status, description, and list of bound Workers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified credential under an AgentTeams instance, including the status, description, and list of bound Workers.</para>
        /// </description>
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
        /// <para>Queries the details of a specified credential under an AgentTeams instance, including the status, description, and list of bound Workers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified credential under an AgentTeams instance, including the status, description, and list of bound Workers.</para>
        /// </description>
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
        /// <para>Queries the details of a specified credential under an AgentTeams instance, including the status, description, and list of bound Workers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified credential under an AgentTeams instance, including the status, description, and list of bound Workers.</para>
        /// </description>
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
        /// <para>Queries the binding details of an upstream identity provider for a specified instance and identity provider type, including the logon callback URL and metadata.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the binding details of an upstream identity provider for a specified instance and identity provider type, including the logon callback URL and metadata.</para>
        /// </description>
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
        /// <para>Queries the binding details of an upstream identity provider for a specified instance and identity provider type, including the logon callback URL and metadata.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the binding details of an upstream identity provider for a specified instance and identity provider type, including the logon callback URL and metadata.</para>
        /// </description>
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
        /// <para>Queries the binding details of an upstream identity provider for a specified instance and identity provider type, including the logon callback URL and metadata.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the binding details of an upstream identity provider for a specified instance and identity provider type, including the logon callback URL and metadata.</para>
        /// </description>
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
        /// <para>Queries the binding details of an upstream identity provider for a specified instance and identity provider type, including the logon callback URL and metadata.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the binding details of an upstream identity provider for a specified instance and identity provider type, including the logon callback URL and metadata.</para>
        /// </description>
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
        /// <para>Queries the details of a specified instance by instance ID. Supports GET and POST methods. A successful response returns the detailed configuration and status of the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified instance by instance ID. Supports GET and POST methods. A successful response returns the detailed configuration and status of the instance.</para>
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
        /// <para>Queries the details of a specified instance by instance ID. Supports GET and POST methods. A successful response returns the detailed configuration and status of the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified instance by instance ID. Supports GET and POST methods. A successful response returns the detailed configuration and status of the instance.</para>
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
        /// <para>Queries the details of a specified instance by instance ID. Supports GET and POST methods. A successful response returns the detailed configuration and status of the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified instance by instance ID. Supports GET and POST methods. A successful response returns the detailed configuration and status of the instance.</para>
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
        /// <para>Queries the details of a specified instance by instance ID. Supports GET and POST methods. A successful response returns the detailed configuration and status of the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified instance by instance ID. Supports GET and POST methods. A successful response returns the detailed configuration and status of the instance.</para>
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
        /// <para>Queries the status of asynchronous tasks associated with a specified AgentTeams instance, with pagination support.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status of asynchronous tasks associated with a specified AgentTeams instance, with paging support.</para>
        /// <list type="bullet">
        /// <item><description>This operation queries the execution status of asynchronous tasks under a specific AgentTeams instance.</description></item>
        /// <item><description>Currently, only instance creation tasks related to the instance lifecycle are supported.</description></item>
        /// <item><description>Use the taskCode parameter to specify the task type to query. The default is the instance creation task.</description></item>
        /// <item><description>Use maxResults and nextToken for result paging.</description></item>
        /// <item><description>When a task is in the PAUSED state, the response includes information about the action the user needs to take (recoveryMessage).</description></item>
        /// <item><description>Querying task status directly by taskId is not currently supported.</description></item>
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
        /// <para>Queries the status of asynchronous tasks associated with a specified AgentTeams instance, with pagination support.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status of asynchronous tasks associated with a specified AgentTeams instance, with paging support.</para>
        /// <list type="bullet">
        /// <item><description>This operation queries the execution status of asynchronous tasks under a specific AgentTeams instance.</description></item>
        /// <item><description>Currently, only instance creation tasks related to the instance lifecycle are supported.</description></item>
        /// <item><description>Use the taskCode parameter to specify the task type to query. The default is the instance creation task.</description></item>
        /// <item><description>Use maxResults and nextToken for result paging.</description></item>
        /// <item><description>When a task is in the PAUSED state, the response includes information about the action the user needs to take (recoveryMessage).</description></item>
        /// <item><description>Querying task status directly by taskId is not currently supported.</description></item>
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
        /// <para>Queries the status of asynchronous tasks associated with a specified AgentTeams instance, with pagination support.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status of asynchronous tasks associated with a specified AgentTeams instance, with paging support.</para>
        /// <list type="bullet">
        /// <item><description>This operation queries the execution status of asynchronous tasks under a specific AgentTeams instance.</description></item>
        /// <item><description>Currently, only instance creation tasks related to the instance lifecycle are supported.</description></item>
        /// <item><description>Use the taskCode parameter to specify the task type to query. The default is the instance creation task.</description></item>
        /// <item><description>Use maxResults and nextToken for result paging.</description></item>
        /// <item><description>When a task is in the PAUSED state, the response includes information about the action the user needs to take (recoveryMessage).</description></item>
        /// <item><description>Querying task status directly by taskId is not currently supported.</description></item>
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
        /// <para>Queries the status of asynchronous tasks associated with a specified AgentTeams instance, with pagination support.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status of asynchronous tasks associated with a specified AgentTeams instance, with paging support.</para>
        /// <list type="bullet">
        /// <item><description>This operation queries the execution status of asynchronous tasks under a specific AgentTeams instance.</description></item>
        /// <item><description>Currently, only instance creation tasks related to the instance lifecycle are supported.</description></item>
        /// <item><description>Use the taskCode parameter to specify the task type to query. The default is the instance creation task.</description></item>
        /// <item><description>Use maxResults and nextToken for result paging.</description></item>
        /// <item><description>When a task is in the PAUSED state, the response includes information about the action the user needs to take (recoveryMessage).</description></item>
        /// <item><description>Querying task status directly by taskId is not currently supported.</description></item>
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
        /// <para>Retrieves the RAM authorization URL required to mount OSS to ACS for an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the RAM authorization URL required to mount OSS to ACS for an instance.</para>
        /// <list type="bullet">
        /// <item><description>This operation supports GET and POST methods.</description></item>
        /// <item><description>The X-User-Id header must be included in the request to verify instance ownership.</description></item>
        /// <item><description>The InstanceId parameter is required to specify the instance. The backend generates the authorization URL based on the instance information.</description></item>
        /// <item><description>A successful response returns the RAM console authorization URL without creating a RAM role or policy.</description></item>
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
        /// <para>Retrieves the RAM authorization URL required to mount OSS to ACS for an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the RAM authorization URL required to mount OSS to ACS for an instance.</para>
        /// <list type="bullet">
        /// <item><description>This operation supports GET and POST methods.</description></item>
        /// <item><description>The X-User-Id header must be included in the request to verify instance ownership.</description></item>
        /// <item><description>The InstanceId parameter is required to specify the instance. The backend generates the authorization URL based on the instance information.</description></item>
        /// <item><description>A successful response returns the RAM console authorization URL without creating a RAM role or policy.</description></item>
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
        /// <para>Retrieves the RAM authorization URL required to mount OSS to ACS for an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the RAM authorization URL required to mount OSS to ACS for an instance.</para>
        /// <list type="bullet">
        /// <item><description>This operation supports GET and POST methods.</description></item>
        /// <item><description>The X-User-Id header must be included in the request to verify instance ownership.</description></item>
        /// <item><description>The InstanceId parameter is required to specify the instance. The backend generates the authorization URL based on the instance information.</description></item>
        /// <item><description>A successful response returns the RAM console authorization URL without creating a RAM role or policy.</description></item>
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
        /// <para>Retrieves the RAM authorization URL required to mount OSS to ACS for an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the RAM authorization URL required to mount OSS to ACS for an instance.</para>
        /// <list type="bullet">
        /// <item><description>This operation supports GET and POST methods.</description></item>
        /// <item><description>The X-User-Id header must be included in the request to verify instance ownership.</description></item>
        /// <item><description>The InstanceId parameter is required to specify the instance. The backend generates the authorization URL based on the instance information.</description></item>
        /// <item><description>A successful response returns the RAM console authorization URL without creating a RAM role or policy.</description></item>
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
        /// <para>Queries the details of a specified MCP server, including the address, authentication configuration, deployment status, and protocol.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified MCP server, including the address, authentication configuration, deployment status, and protocol.</para>
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
        /// <para>Queries the details of a specified MCP server, including the address, authentication configuration, deployment status, and protocol.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified MCP server, including the address, authentication configuration, deployment status, and protocol.</para>
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
        /// <para>Queries the details of a specified MCP server, including the address, authentication configuration, deployment status, and protocol.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified MCP server, including the address, authentication configuration, deployment status, and protocol.</para>
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
        /// <para>Queries the details of a specified MCP server, including the address, authentication configuration, deployment status, and protocol.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified MCP server, including the address, authentication configuration, deployment status, and protocol.</para>
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
        /// <para>Queries the model call summary for a specified AgentTeams instance within a specified time range, including today\&quot;s and this week\&quot;s call counts, change rates, call frequency, and provider distribution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the model call summary for a specified AgentTeams instance within a specified time range, including today\&quot;s and this week\&quot;s call counts, change rates, call frequency, and provider distribution.</para>
        /// </description>
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
        /// <para>Queries the model call summary for a specified AgentTeams instance within a specified time range, including today\&quot;s and this week\&quot;s call counts, change rates, call frequency, and provider distribution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the model call summary for a specified AgentTeams instance within a specified time range, including today\&quot;s and this week\&quot;s call counts, change rates, call frequency, and provider distribution.</para>
        /// </description>
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
        /// <para>Queries the model call summary for a specified AgentTeams instance within a specified time range, including today\&quot;s and this week\&quot;s call counts, change rates, call frequency, and provider distribution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the model call summary for a specified AgentTeams instance within a specified time range, including today\&quot;s and this week\&quot;s call counts, change rates, call frequency, and provider distribution.</para>
        /// </description>
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
        /// <para>Queries the model call summary for a specified AgentTeams instance within a specified time range, including today\&quot;s and this week\&quot;s call counts, change rates, call frequency, and provider distribution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the model call summary for a specified AgentTeams instance within a specified time range, including today\&quot;s and this week\&quot;s call counts, change rates, call frequency, and provider distribution.</para>
        /// </description>
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
        /// <para>Queries the details of a single AI model provider, including the name, address, protocol list, API keys, and deployment status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a single AI model provider, including the name, address, protocol list, API keys, and deployment status.</para>
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
        /// <para>Queries the details of a single AI model provider, including the name, address, protocol list, API keys, and deployment status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a single AI model provider, including the name, address, protocol list, API keys, and deployment status.</para>
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
        /// <para>Queries the details of a single AI model provider, including the name, address, protocol list, API keys, and deployment status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a single AI model provider, including the name, address, protocol list, API keys, and deployment status.</para>
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
        /// <para>Queries the details of a single AI model provider, including the name, address, protocol list, API keys, and deployment status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a single AI model provider, including the name, address, protocol list, API keys, and deployment status.</para>
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
        /// <para>Queries the configuration status of the NAT gateway and its SNAT rules for a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the configuration status of the NAT gateway and its SNAT rules for a specified instance.</para>
        /// <list type="bullet">
        /// <item><description>This API allows you to retrieve the NAT gateway configuration details and SNAT rule status associated with a specific instance. This operation supports GET or POST method calls and requires the instanceId as a request parameter to specify the instance to query.</description></item>
        /// <item><description>Ensure that the provided instanceId is valid and belongs to your account.</description></item>
        /// <item><description>Based on the returned status values (such as READY, NEED_CONFIGURE_NAT_GATEWAY, or NEED_CONFIGURE_SNAT_RULE), take the corresponding actions to complete the NAT gateway or SNAT rule configuration.</description></item>
        /// <item><description>When the status is NEED_CONFIGURE_NAT_GATEWAY, it indicates that no available NAT gateway exists in the current VPC. NEED_CONFIGURE_SNAT_RULE means that a NAT gateway exists but some subnet CIDRs are not covered by SNAT rules.</description></item>
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
        /// <para>Queries the configuration status of the NAT gateway and its SNAT rules for a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the configuration status of the NAT gateway and its SNAT rules for a specified instance.</para>
        /// <list type="bullet">
        /// <item><description>This API allows you to retrieve the NAT gateway configuration details and SNAT rule status associated with a specific instance. This operation supports GET or POST method calls and requires the instanceId as a request parameter to specify the instance to query.</description></item>
        /// <item><description>Ensure that the provided instanceId is valid and belongs to your account.</description></item>
        /// <item><description>Based on the returned status values (such as READY, NEED_CONFIGURE_NAT_GATEWAY, or NEED_CONFIGURE_SNAT_RULE), take the corresponding actions to complete the NAT gateway or SNAT rule configuration.</description></item>
        /// <item><description>When the status is NEED_CONFIGURE_NAT_GATEWAY, it indicates that no available NAT gateway exists in the current VPC. NEED_CONFIGURE_SNAT_RULE means that a NAT gateway exists but some subnet CIDRs are not covered by SNAT rules.</description></item>
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
        /// <para>Queries the configuration status of the NAT gateway and its SNAT rules for a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the configuration status of the NAT gateway and its SNAT rules for a specified instance.</para>
        /// <list type="bullet">
        /// <item><description>This API allows you to retrieve the NAT gateway configuration details and SNAT rule status associated with a specific instance. This operation supports GET or POST method calls and requires the instanceId as a request parameter to specify the instance to query.</description></item>
        /// <item><description>Ensure that the provided instanceId is valid and belongs to your account.</description></item>
        /// <item><description>Based on the returned status values (such as READY, NEED_CONFIGURE_NAT_GATEWAY, or NEED_CONFIGURE_SNAT_RULE), take the corresponding actions to complete the NAT gateway or SNAT rule configuration.</description></item>
        /// <item><description>When the status is NEED_CONFIGURE_NAT_GATEWAY, it indicates that no available NAT gateway exists in the current VPC. NEED_CONFIGURE_SNAT_RULE means that a NAT gateway exists but some subnet CIDRs are not covered by SNAT rules.</description></item>
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
        /// <para>Queries the configuration status of the NAT gateway and its SNAT rules for a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the configuration status of the NAT gateway and its SNAT rules for a specified instance.</para>
        /// <list type="bullet">
        /// <item><description>This API allows you to retrieve the NAT gateway configuration details and SNAT rule status associated with a specific instance. This operation supports GET or POST method calls and requires the instanceId as a request parameter to specify the instance to query.</description></item>
        /// <item><description>Ensure that the provided instanceId is valid and belongs to your account.</description></item>
        /// <item><description>Based on the returned status values (such as READY, NEED_CONFIGURE_NAT_GATEWAY, or NEED_CONFIGURE_SNAT_RULE), take the corresponding actions to complete the NAT gateway or SNAT rule configuration.</description></item>
        /// <item><description>When the status is NEED_CONFIGURE_NAT_GATEWAY, it indicates that no available NAT gateway exists in the current VPC. NEED_CONFIGURE_SNAT_RULE means that a NAT gateway exists but some subnet CIDRs are not covered by SNAT rules.</description></item>
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
        /// <para>Queries the details of an endpoint with a specified ID. You can verify the endpoint by instance ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of an endpoint with a specified ID. You can verify the endpoint by instance ID.</para>
        /// <list type="bullet">
        /// <item><description>This API operation queries the configuration and status information of a single endpoint based on the endpointId.</description></item>
        /// <item><description>The optional parameter instanceId is used to verify whether the endpoint belongs to a specific instance.</description></item>
        /// <item><description>The request supports both GET and POST methods. GET passes parameters through the query string, while POST submits parameters through form data.</description></item>
        /// <item><description>If endpointId is missing or empty, an InvalidParameter error is returned.</description></item>
        /// <item><description>If the requested endpoint does not exist, does not belong to the specified instance, or does not belong to the current user, a resource-not-found error is returned.</description></item>
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
        /// <para>Queries the details of an endpoint with a specified ID. You can verify the endpoint by instance ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of an endpoint with a specified ID. You can verify the endpoint by instance ID.</para>
        /// <list type="bullet">
        /// <item><description>This API operation queries the configuration and status information of a single endpoint based on the endpointId.</description></item>
        /// <item><description>The optional parameter instanceId is used to verify whether the endpoint belongs to a specific instance.</description></item>
        /// <item><description>The request supports both GET and POST methods. GET passes parameters through the query string, while POST submits parameters through form data.</description></item>
        /// <item><description>If endpointId is missing or empty, an InvalidParameter error is returned.</description></item>
        /// <item><description>If the requested endpoint does not exist, does not belong to the specified instance, or does not belong to the current user, a resource-not-found error is returned.</description></item>
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
        /// <para>Queries the details of an endpoint with a specified ID. You can verify the endpoint by instance ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of an endpoint with a specified ID. You can verify the endpoint by instance ID.</para>
        /// <list type="bullet">
        /// <item><description>This API operation queries the configuration and status information of a single endpoint based on the endpointId.</description></item>
        /// <item><description>The optional parameter instanceId is used to verify whether the endpoint belongs to a specific instance.</description></item>
        /// <item><description>The request supports both GET and POST methods. GET passes parameters through the query string, while POST submits parameters through form data.</description></item>
        /// <item><description>If endpointId is missing or empty, an InvalidParameter error is returned.</description></item>
        /// <item><description>If the requested endpoint does not exist, does not belong to the specified instance, or does not belong to the current user, a resource-not-found error is returned.</description></item>
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
        /// <para>Queries the details of an endpoint with a specified ID. You can verify the endpoint by instance ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of an endpoint with a specified ID. You can verify the endpoint by instance ID.</para>
        /// <list type="bullet">
        /// <item><description>This API operation queries the configuration and status information of a single endpoint based on the endpointId.</description></item>
        /// <item><description>The optional parameter instanceId is used to verify whether the endpoint belongs to a specific instance.</description></item>
        /// <item><description>The request supports both GET and POST methods. GET passes parameters through the query string, while POST submits parameters through form data.</description></item>
        /// <item><description>If endpointId is missing or empty, an InvalidParameter error is returned.</description></item>
        /// <item><description>If the requested endpoint does not exist, does not belong to the specified instance, or does not belong to the current user, a resource-not-found error is returned.</description></item>
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
        /// <para>Queries the task statistics summary of a specified AgentTeams instance within a specified time range, including total tasks, average task duration, token consumption, and status distribution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the task statistics summary of a specified AgentTeams instance within a specified time range, including total tasks, average task duration, token consumption, and status distribution.</para>
        /// </description>
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
        /// <para>Queries the task statistics summary of a specified AgentTeams instance within a specified time range, including total tasks, average task duration, token consumption, and status distribution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the task statistics summary of a specified AgentTeams instance within a specified time range, including total tasks, average task duration, token consumption, and status distribution.</para>
        /// </description>
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
        /// <para>Queries the task statistics summary of a specified AgentTeams instance within a specified time range, including total tasks, average task duration, token consumption, and status distribution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the task statistics summary of a specified AgentTeams instance within a specified time range, including total tasks, average task duration, token consumption, and status distribution.</para>
        /// </description>
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
        /// <para>Queries the task statistics summary of a specified AgentTeams instance within a specified time range, including total tasks, average task duration, token consumption, and status distribution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the task statistics summary of a specified AgentTeams instance within a specified time range, including total tasks, average task duration, token consumption, and status distribution.</para>
        /// </description>
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
        /// <para>Queries the details of a specified team under a specified instance, including the description, administrator, leader, members, associated workers, and room status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified team under a specified instance, including the description, administrator, leader, members, associated workers, and room status.</para>
        /// </description>
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
        /// <para>Queries the details of a specified team under a specified instance, including the description, administrator, leader, members, associated workers, and room status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified team under a specified instance, including the description, administrator, leader, members, associated workers, and room status.</para>
        /// </description>
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
        /// <para>Queries the details of a specified team under a specified instance, including the description, administrator, leader, members, associated workers, and room status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified team under a specified instance, including the description, administrator, leader, members, associated workers, and room status.</para>
        /// </description>
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
        /// <para>Queries the details of a specified team under a specified instance, including the description, administrator, leader, members, associated workers, and room status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified team under a specified instance, including the description, administrator, leader, members, associated workers, and room status.</para>
        /// </description>
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
        /// <para>Queries the token consumption trend of a specified AgentTeams instance within a specified time range, supports grouping by time dimension, and returns time series data that can be used for charting.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the token consumption trend of a specified AgentTeams instance within a specified time range, supports grouping by time dimension, and returns time series data that can be used for charting.</para>
        /// </description>
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
        /// <para>Queries the token consumption trend of a specified AgentTeams instance within a specified time range, supports grouping by time dimension, and returns time series data that can be used for charting.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the token consumption trend of a specified AgentTeams instance within a specified time range, supports grouping by time dimension, and returns time series data that can be used for charting.</para>
        /// </description>
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
        /// <para>Queries the token consumption trend of a specified AgentTeams instance within a specified time range, supports grouping by time dimension, and returns time series data that can be used for charting.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the token consumption trend of a specified AgentTeams instance within a specified time range, supports grouping by time dimension, and returns time series data that can be used for charting.</para>
        /// </description>
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
        /// <para>Queries the token consumption trend of a specified AgentTeams instance within a specified time range, supports grouping by time dimension, and returns time series data that can be used for charting.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the token consumption trend of a specified AgentTeams instance within a specified time range, supports grouping by time dimension, and returns time series data that can be used for charting.</para>
        /// </description>
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
        /// <para>Queries the tool calling distribution of a specified AgentTeams instance within a specified time range, and returns the number of calls for each tool and the total number of calls.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the tool calling distribution of a specified AgentTeams instance within a specified time range, and returns the number of calls for each tool and the total number of calls.</para>
        /// </description>
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
        /// <para>Queries the tool calling distribution of a specified AgentTeams instance within a specified time range, and returns the number of calls for each tool and the total number of calls.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the tool calling distribution of a specified AgentTeams instance within a specified time range, and returns the number of calls for each tool and the total number of calls.</para>
        /// </description>
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
        /// <para>Queries the tool calling distribution of a specified AgentTeams instance within a specified time range, and returns the number of calls for each tool and the total number of calls.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the tool calling distribution of a specified AgentTeams instance within a specified time range, and returns the number of calls for each tool and the total number of calls.</para>
        /// </description>
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
        /// <para>Queries the tool calling distribution of a specified AgentTeams instance within a specified time range, and returns the number of calls for each tool and the total number of calls.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the tool calling distribution of a specified AgentTeams instance within a specified time range, and returns the number of calls for each tool and the total number of calls.</para>
        /// </description>
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
        /// <para>Queries the details of a specified user under a specified instance, including the username, display name, email address, authentication method, status, and creation time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified user under a specified instance, including the username, display name, email address, authentication method, status, and creation time.</para>
        /// </description>
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
        /// <para>Queries the details of a specified user under a specified instance, including the username, display name, email address, authentication method, status, and creation time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified user under a specified instance, including the username, display name, email address, authentication method, status, and creation time.</para>
        /// </description>
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
        /// <para>Queries the details of a specified user under a specified instance, including the username, display name, email address, authentication method, status, and creation time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified user under a specified instance, including the username, display name, email address, authentication method, status, and creation time.</para>
        /// </description>
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
        /// <para>Queries the details of a specified user under a specified instance, including the username, display name, email address, authentication method, status, and creation time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified user under a specified instance, including the username, display name, email address, authentication method, status, and creation time.</para>
        /// </description>
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
        /// <para>Retrieves the initial password of a specified user under a specified instance. The initial password is generated by the system or specified by the user when the user is created.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the initial password of a specified user under a specified instance. The initial password is generated by the system or specified by the user when the user is created.</para>
        /// </description>
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
        /// <para>Retrieves the initial password of a specified user under a specified instance. The initial password is generated by the system or specified by the user when the user is created.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the initial password of a specified user under a specified instance. The initial password is generated by the system or specified by the user when the user is created.</para>
        /// </description>
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
        /// <para>Retrieves the initial password of a specified user under a specified instance. The initial password is generated by the system or specified by the user when the user is created.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the initial password of a specified user under a specified instance. The initial password is generated by the system or specified by the user when the user is created.</para>
        /// </description>
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
        /// <para>Retrieves the initial password of a specified user under a specified instance. The initial password is generated by the system or specified by the user when the user is created.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the initial password of a specified user under a specified instance. The initial password is generated by the system or specified by the user when the user is created.</para>
        /// </description>
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
        /// <para>Queries the details of a specified worker, including configurations such as model, skills, sub-agents, MCP servers, channels, and quotas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified worker, including configurations such as model, skills, sub-agents, MCP servers, channels, and quotas.</para>
        /// </description>
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
        /// <para>Queries the details of a specified worker, including configurations such as model, skills, sub-agents, MCP servers, channels, and quotas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified worker, including configurations such as model, skills, sub-agents, MCP servers, channels, and quotas.</para>
        /// </description>
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
        /// <para>Queries the details of a specified worker, including configurations such as model, skills, sub-agents, MCP servers, channels, and quotas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified worker, including configurations such as model, skills, sub-agents, MCP servers, channels, and quotas.</para>
        /// </description>
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
        /// <para>Queries the details of a specified worker, including configurations such as model, skills, sub-agents, MCP servers, channels, and quotas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified worker, including configurations such as model, skills, sub-agents, MCP servers, channels, and quotas.</para>
        /// </description>
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
        /// <para>Queries the startup options for local Worker management and returns available network types.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the startup options for local Worker management and returns available network types.</para>
        /// </description>
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
        /// <para>Queries the startup options for local Worker management and returns available network types.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the startup options for local Worker management and returns available network types.</para>
        /// </description>
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
        /// <para>Queries the startup options for local Worker management and returns available network types.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the startup options for local Worker management and returns available network types.</para>
        /// </description>
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
        /// <para>Queries the startup options for local Worker management and returns available network types.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the startup options for local Worker management and returns available network types.</para>
        /// </description>
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
        /// <para>Queries the maximum upgradable version of a worker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the maximum upgradable version of a worker.</para>
        /// </description>
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
        /// <para>Queries the maximum upgradable version of a worker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the maximum upgradable version of a worker.</para>
        /// </description>
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
        /// <para>Queries the maximum upgradable version of a worker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the maximum upgradable version of a worker.</para>
        /// </description>
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
        /// <para>Queries the maximum upgradable version of a worker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the maximum upgradable version of a worker.</para>
        /// </description>
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
        /// <para>Queries the Worker statistics summary, including the total number of workers, the number of running workers, the number of stopped workers, and more.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the Worker statistics summary, including the total number of workers, the number of running workers, the number of stopped workers, and more.</para>
        /// </description>
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
        /// <para>Queries the Worker statistics summary, including the total number of workers, the number of running workers, the number of stopped workers, and more.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the Worker statistics summary, including the total number of workers, the number of running workers, the number of stopped workers, and more.</para>
        /// </description>
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
        /// <para>Queries the Worker statistics summary, including the total number of workers, the number of running workers, the number of stopped workers, and more.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the Worker statistics summary, including the total number of workers, the number of running workers, the number of stopped workers, and more.</para>
        /// </description>
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
        /// <para>Queries the Worker statistics summary, including the total number of workers, the number of running workers, the number of stopped workers, and more.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the Worker statistics summary, including the total number of workers, the number of running workers, the number of stopped workers, and more.</para>
        /// </description>
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
        /// <para>Queries the credential list under a specified AgentTeams instance with paging, returning credential summary information and the number of Workers attached to each credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the credential list under a specified AgentTeams instance with paging, returning credential summary information and the number of Workers attached to each credential.</para>
        /// </description>
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
        /// <para>Queries the credential list under a specified AgentTeams instance with paging, returning credential summary information and the number of Workers attached to each credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the credential list under a specified AgentTeams instance with paging, returning credential summary information and the number of Workers attached to each credential.</para>
        /// </description>
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
        /// <para>Queries the credential list under a specified AgentTeams instance with paging, returning credential summary information and the number of Workers attached to each credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the credential list under a specified AgentTeams instance with paging, returning credential summary information and the number of Workers attached to each credential.</para>
        /// </description>
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
        /// <para>Queries the credential list under a specified AgentTeams instance with paging, returning credential summary information and the number of Workers attached to each credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the credential list under a specified AgentTeams instance with paging, returning credential summary information and the number of Workers attached to each credential.</para>
        /// </description>
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
        /// <para>Queries the list of upstream identity provider bindings for a specified instance, with support for paginated responses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of upstream identity provider bindings for a specified instance, with support for paginated responses.</para>
        /// </description>
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
        /// <para>Queries the list of upstream identity provider bindings for a specified instance, with support for paginated responses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of upstream identity provider bindings for a specified instance, with support for paginated responses.</para>
        /// </description>
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
        /// <para>Queries the list of upstream identity provider bindings for a specified instance, with support for paginated responses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of upstream identity provider bindings for a specified instance, with support for paginated responses.</para>
        /// </description>
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
        /// <para>Queries the list of upstream identity provider bindings for a specified instance, with support for paginated responses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of upstream identity provider bindings for a specified instance, with support for paginated responses.</para>
        /// </description>
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
        /// <para>Queries a list of instances that meet the specified conditions. Supports pagination and fuzzy match. Supports GET and POST methods. The list is returned in reverse chronological order by creation time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries a list of instances that meet the specified conditions. Supports pagination and fuzzy match. Supports GET and POST methods. The list is returned in reverse chronological order by creation time.</para>
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
        /// <para>Queries a list of instances that meet the specified conditions. Supports pagination and fuzzy match. Supports GET and POST methods. The list is returned in reverse chronological order by creation time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries a list of instances that meet the specified conditions. Supports pagination and fuzzy match. Supports GET and POST methods. The list is returned in reverse chronological order by creation time.</para>
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
        /// <para>Queries a list of instances that meet the specified conditions. Supports pagination and fuzzy match. Supports GET and POST methods. The list is returned in reverse chronological order by creation time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries a list of instances that meet the specified conditions. Supports pagination and fuzzy match. Supports GET and POST methods. The list is returned in reverse chronological order by creation time.</para>
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
        /// <para>Queries a list of instances that meet the specified conditions. Supports pagination and fuzzy match. Supports GET and POST methods. The list is returned in reverse chronological order by creation time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries a list of instances that meet the specified conditions. Supports pagination and fuzzy match. Supports GET and POST methods. The list is returned in reverse chronological order by creation time.</para>
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
        /// <para>Queries the list of tools provided by a specified MCP server, including tool names, titles, descriptions, and input schemas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of tools provided by a specified MCP server, including tool names, titles, descriptions, and input schemas.</para>
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
        /// <para>Queries the list of tools provided by a specified MCP server, including tool names, titles, descriptions, and input schemas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of tools provided by a specified MCP server, including tool names, titles, descriptions, and input schemas.</para>
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
        /// <para>Queries the list of tools provided by a specified MCP server, including tool names, titles, descriptions, and input schemas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of tools provided by a specified MCP server, including tool names, titles, descriptions, and input schemas.</para>
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
        /// <para>Queries the list of tools provided by a specified MCP server, including tool names, titles, descriptions, and input schemas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of tools provided by a specified MCP server, including tool names, titles, descriptions, and input schemas.</para>
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
        /// <para>Queries the MCP server list under a specified AgentTeams instance by using paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the MCP server list under a specified AgentTeams instance by using paging.</para>
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
        /// <para>Queries the MCP server list under a specified AgentTeams instance by using paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the MCP server list under a specified AgentTeams instance by using paging.</para>
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
        /// <para>Queries the MCP server list under a specified AgentTeams instance by using paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the MCP server list under a specified AgentTeams instance by using paging.</para>
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
        /// <para>Queries the MCP server list under a specified AgentTeams instance by using paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the MCP server list under a specified AgentTeams instance by using paging.</para>
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
        /// <para>Queries the list of AI model providers under a specified AgentTeams instance. Paging is supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of AI model providers under a specified AgentTeams instance. Paging is supported.</para>
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
        /// <para>Queries the list of AI model providers under a specified AgentTeams instance. Paging is supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of AI model providers under a specified AgentTeams instance. Paging is supported.</para>
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
        /// <para>Queries the list of AI model providers under a specified AgentTeams instance. Paging is supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of AI model providers under a specified AgentTeams instance. Paging is supported.</para>
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
        /// <para>Queries the list of AI model providers under a specified AgentTeams instance. Paging is supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of AI model providers under a specified AgentTeams instance. Paging is supported.</para>
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
        /// <para>Queries the list of AI models under a specified AgentTeams instance. You can filter results by model name or provider name, and paging is supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of AI models under a specified AgentTeams instance. You can filter results by model name or provider name, and paging is supported.</para>
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
        /// <para>Queries the list of AI models under a specified AgentTeams instance. You can filter results by model name or provider name, and paging is supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of AI models under a specified AgentTeams instance. You can filter results by model name or provider name, and paging is supported.</para>
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
        /// <para>Queries the list of AI models under a specified AgentTeams instance. You can filter results by model name or provider name, and paging is supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of AI models under a specified AgentTeams instance. You can filter results by model name or provider name, and paging is supported.</para>
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
        /// <para>Queries the list of AI models under a specified AgentTeams instance. You can filter results by model name or provider name, and paging is supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of AI models under a specified AgentTeams instance. You can filter results by model name or provider name, and paging is supported.</para>
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
        /// <para>Queries the list of AI gateway endpoints under a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API queries the list of AI gateway endpoints under a specified instance.</para>
        /// <list type="bullet">
        /// <item><description>instanceId is a required parameter that specifies the AgentTeams instance ID.</description></item>
        /// <item><description>Optional parameters include component, serviceName, networkType, and domainType, which are used to further filter the returned endpoint list.</description></item>
        /// <item><description>Filtering by the status parameter is not supported.</description></item>
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
        /// <para>Queries the list of AI gateway endpoints under a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API queries the list of AI gateway endpoints under a specified instance.</para>
        /// <list type="bullet">
        /// <item><description>instanceId is a required parameter that specifies the AgentTeams instance ID.</description></item>
        /// <item><description>Optional parameters include component, serviceName, networkType, and domainType, which are used to further filter the returned endpoint list.</description></item>
        /// <item><description>Filtering by the status parameter is not supported.</description></item>
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
        /// <para>Queries the list of AI gateway endpoints under a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API queries the list of AI gateway endpoints under a specified instance.</para>
        /// <list type="bullet">
        /// <item><description>instanceId is a required parameter that specifies the AgentTeams instance ID.</description></item>
        /// <item><description>Optional parameters include component, serviceName, networkType, and domainType, which are used to further filter the returned endpoint list.</description></item>
        /// <item><description>Filtering by the status parameter is not supported.</description></item>
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
        /// <para>Queries the list of AI gateway endpoints under a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API queries the list of AI gateway endpoints under a specified instance.</para>
        /// <list type="bullet">
        /// <item><description>instanceId is a required parameter that specifies the AgentTeams instance ID.</description></item>
        /// <item><description>Optional parameters include component, serviceName, networkType, and domainType, which are used to further filter the returned endpoint list.</description></item>
        /// <item><description>Filtering by the status parameter is not supported.</description></item>
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
        /// <para>Queries the list of SSL certificates available to the user in APIG.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of SSL certificates available to the user in APIG.</para>
        /// <list type="bullet">
        /// <item><description>This API retrieves the list of SSL certificates associated with a specified AgentTeams instance.</description></item>
        /// <item><description>The pagination parameters MaxResults and NextToken allow the client to control the number of returned results and retrieve the next page of data.</description></item>
        /// <item><description>A successful response includes the request ID, success flag, error code, next page token, total certificate count, and the certificate details list.</description></item>
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
        /// <para>Queries the list of SSL certificates available to the user in APIG.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of SSL certificates available to the user in APIG.</para>
        /// <list type="bullet">
        /// <item><description>This API retrieves the list of SSL certificates associated with a specified AgentTeams instance.</description></item>
        /// <item><description>The pagination parameters MaxResults and NextToken allow the client to control the number of returned results and retrieve the next page of data.</description></item>
        /// <item><description>A successful response includes the request ID, success flag, error code, next page token, total certificate count, and the certificate details list.</description></item>
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
        /// <para>Queries the list of SSL certificates available to the user in APIG.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of SSL certificates available to the user in APIG.</para>
        /// <list type="bullet">
        /// <item><description>This API retrieves the list of SSL certificates associated with a specified AgentTeams instance.</description></item>
        /// <item><description>The pagination parameters MaxResults and NextToken allow the client to control the number of returned results and retrieve the next page of data.</description></item>
        /// <item><description>A successful response includes the request ID, success flag, error code, next page token, total certificate count, and the certificate details list.</description></item>
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
        /// <para>Queries the list of SSL certificates available to the user in APIG.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of SSL certificates available to the user in APIG.</para>
        /// <list type="bullet">
        /// <item><description>This API retrieves the list of SSL certificates associated with a specified AgentTeams instance.</description></item>
        /// <item><description>The pagination parameters MaxResults and NextToken allow the client to control the number of returned results and retrieve the next page of data.</description></item>
        /// <item><description>A successful response includes the request ID, success flag, error code, next page token, total certificate count, and the certificate details list.</description></item>
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
        /// <para>Queries the statistical details of teams under a specified instance, including aggregate metrics such as the number of workers, number of tasks, success rate, and token usage for each team.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the statistical details of teams under a specified instance, including aggregate metrics such as the number of workers, number of tasks, success rate, and token usage for each team.</para>
        /// </description>
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
        /// <para>Queries the statistical details of teams under a specified instance, including aggregate metrics such as the number of workers, number of tasks, success rate, and token usage for each team.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the statistical details of teams under a specified instance, including aggregate metrics such as the number of workers, number of tasks, success rate, and token usage for each team.</para>
        /// </description>
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
        /// <para>Queries the statistical details of teams under a specified instance, including aggregate metrics such as the number of workers, number of tasks, success rate, and token usage for each team.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the statistical details of teams under a specified instance, including aggregate metrics such as the number of workers, number of tasks, success rate, and token usage for each team.</para>
        /// </description>
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
        /// <para>Queries the statistical details of teams under a specified instance, including aggregate metrics such as the number of workers, number of tasks, success rate, and token usage for each team.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the statistical details of teams under a specified instance, including aggregate metrics such as the number of workers, number of tasks, success rate, and token usage for each team.</para>
        /// </description>
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
        /// <para>Queries the task list of a specified team under a specified instance. The task metadata is sourced from the OSS bucket bound to the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the task list of a specified team under a specified instance. The task metadata is sourced from the OSS bucket bound to the instance.</para>
        /// </description>
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
        /// <para>Queries the task list of a specified team under a specified instance. The task metadata is sourced from the OSS bucket bound to the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the task list of a specified team under a specified instance. The task metadata is sourced from the OSS bucket bound to the instance.</para>
        /// </description>
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
        /// <para>Queries the task list of a specified team under a specified instance. The task metadata is sourced from the OSS bucket bound to the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the task list of a specified team under a specified instance. The task metadata is sourced from the OSS bucket bound to the instance.</para>
        /// </description>
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
        /// <para>Queries the task list of a specified team under a specified instance. The task metadata is sourced from the OSS bucket bound to the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the task list of a specified team under a specified instance. The task metadata is sourced from the OSS bucket bound to the instance.</para>
        /// </description>
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
        /// <para>Queries the list of teams under a specified instance, with support for fuzzy filtering by name and pagination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of teams under a specified instance, with support for fuzzy filtering by name and pagination.</para>
        /// </description>
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
        /// <para>Queries the list of teams under a specified instance, with support for fuzzy filtering by name and pagination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of teams under a specified instance, with support for fuzzy filtering by name and pagination.</para>
        /// </description>
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
        /// <para>Queries the list of teams under a specified instance, with support for fuzzy filtering by name and pagination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of teams under a specified instance, with support for fuzzy filtering by name and pagination.</para>
        /// </description>
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
        /// <para>Queries the list of teams under a specified instance, with support for fuzzy filtering by name and pagination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of teams under a specified instance, with support for fuzzy filtering by name and pagination.</para>
        /// </description>
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
        /// <para>Queries the list of users under a specified instance. Supports fuzzy match by username and paging query. The list is returned in reverse chronological order by creation time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of users under a specified instance. Supports fuzzy match by username and paging query. The list is returned in reverse chronological order by creation time.</para>
        /// </description>
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
        /// <para>Queries the list of users under a specified instance. Supports fuzzy match by username and paging query. The list is returned in reverse chronological order by creation time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of users under a specified instance. Supports fuzzy match by username and paging query. The list is returned in reverse chronological order by creation time.</para>
        /// </description>
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
        /// <para>Queries the list of users under a specified instance. Supports fuzzy match by username and paging query. The list is returned in reverse chronological order by creation time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of users under a specified instance. Supports fuzzy match by username and paging query. The list is returned in reverse chronological order by creation time.</para>
        /// </description>
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
        /// <para>Queries the list of users under a specified instance. Supports fuzzy match by username and paging query. The list is returned in reverse chronological order by creation time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of users under a specified instance. Supports fuzzy match by username and paging query. The list is returned in reverse chronological order by creation time.</para>
        /// </description>
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
        /// <para>Queries a list of Worker statistics details by paging, including task count, token usage, and LLM call count.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries a list of Worker statistics details by paging, including task count, token usage, and LLM call count.</para>
        /// </description>
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
        /// <para>Queries a list of Worker statistics details by paging, including task count, token usage, and LLM call count.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries a list of Worker statistics details by paging, including task count, token usage, and LLM call count.</para>
        /// </description>
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
        /// <para>Queries a list of Worker statistics details by paging, including task count, token usage, and LLM call count.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries a list of Worker statistics details by paging, including task count, token usage, and LLM call count.</para>
        /// </description>
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
        /// <para>Queries a list of Worker statistics details by paging, including task count, token usage, and LLM call count.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries a list of Worker statistics details by paging, including task count, token usage, and LLM call count.</para>
        /// </description>
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
        /// <para>Queries the list of Workers under a specified instance by using paging, with support for filtering by name, model, template, and other conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of Workers under a specified instance by using paging, with support for filtering by name, model, template, and other conditions.</para>
        /// </description>
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
        /// <para>Queries the list of Workers under a specified instance by using paging, with support for filtering by name, model, template, and other conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of Workers under a specified instance by using paging, with support for filtering by name, model, template, and other conditions.</para>
        /// </description>
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
        /// <para>Queries the list of Workers under a specified instance by using paging, with support for filtering by name, model, template, and other conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of Workers under a specified instance by using paging, with support for filtering by name, model, template, and other conditions.</para>
        /// </description>
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
        /// <para>Queries the list of Workers under a specified instance by using paging, with support for filtering by name, model, template, and other conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of Workers under a specified instance by using paging, with support for filtering by name, model, template, and other conditions.</para>
        /// </description>
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
        /// <para>Creates or updates a CMS workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates or updates a CMS workspace.</para>
        /// </description>
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
        /// <para>Creates or updates a CMS workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates or updates a CMS workspace.</para>
        /// </description>
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
        /// <para>Creates or updates a CMS workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates or updates a CMS workspace.</para>
        /// </description>
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
        /// <para>Creates or updates a CMS workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates or updates a CMS workspace.</para>
        /// </description>
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
        /// <para>Queries the attribute status of a specified instance, worker, team, or individual.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the feature status of a specified instance, worker, team, or individual.</para>
        /// <list type="bullet">
        /// <item><description>This operation queries the feature status of different targets (such as INSTANCE, WORKER, TEAM, or HUMAN) under a specific instanceId.</description></item>
        /// <item><description>The targetScope parameter defines the target type for the query. Depending on the targetScope value, you may need to provide an additional resourceName parameter to specify the resource name.</description></item>
        /// <item><description>If a featureCodes list is provided, the status of those specific features is returned. Otherwise, the status of all features under the specified targetScope is returned.</description></item>
        /// <item><description>When using WORKER, TEAM, or HUMAN as the targetScope, make sure to correctly specify the corresponding resourceName.</description></item>
        /// <item><description>For INSTANCE-level queries, resourceName is not required.</description></item>
        /// <item><description>Feature support is affected by factors such as the base version and worker version. The unsupportedReasonCode and unsupportedReason fields provide the specific reason why a feature is not supported.</description></item>
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
        /// <para>Queries the attribute status of a specified instance, worker, team, or individual.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the feature status of a specified instance, worker, team, or individual.</para>
        /// <list type="bullet">
        /// <item><description>This operation queries the feature status of different targets (such as INSTANCE, WORKER, TEAM, or HUMAN) under a specific instanceId.</description></item>
        /// <item><description>The targetScope parameter defines the target type for the query. Depending on the targetScope value, you may need to provide an additional resourceName parameter to specify the resource name.</description></item>
        /// <item><description>If a featureCodes list is provided, the status of those specific features is returned. Otherwise, the status of all features under the specified targetScope is returned.</description></item>
        /// <item><description>When using WORKER, TEAM, or HUMAN as the targetScope, make sure to correctly specify the corresponding resourceName.</description></item>
        /// <item><description>For INSTANCE-level queries, resourceName is not required.</description></item>
        /// <item><description>Feature support is affected by factors such as the base version and worker version. The unsupportedReasonCode and unsupportedReason fields provide the specific reason why a feature is not supported.</description></item>
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
        /// <para>Queries the attribute status of a specified instance, worker, team, or individual.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the feature status of a specified instance, worker, team, or individual.</para>
        /// <list type="bullet">
        /// <item><description>This operation queries the feature status of different targets (such as INSTANCE, WORKER, TEAM, or HUMAN) under a specific instanceId.</description></item>
        /// <item><description>The targetScope parameter defines the target type for the query. Depending on the targetScope value, you may need to provide an additional resourceName parameter to specify the resource name.</description></item>
        /// <item><description>If a featureCodes list is provided, the status of those specific features is returned. Otherwise, the status of all features under the specified targetScope is returned.</description></item>
        /// <item><description>When using WORKER, TEAM, or HUMAN as the targetScope, make sure to correctly specify the corresponding resourceName.</description></item>
        /// <item><description>For INSTANCE-level queries, resourceName is not required.</description></item>
        /// <item><description>Feature support is affected by factors such as the base version and worker version. The unsupportedReasonCode and unsupportedReason fields provide the specific reason why a feature is not supported.</description></item>
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
        /// <para>Queries the attribute status of a specified instance, worker, team, or individual.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the feature status of a specified instance, worker, team, or individual.</para>
        /// <list type="bullet">
        /// <item><description>This operation queries the feature status of different targets (such as INSTANCE, WORKER, TEAM, or HUMAN) under a specific instanceId.</description></item>
        /// <item><description>The targetScope parameter defines the target type for the query. Depending on the targetScope value, you may need to provide an additional resourceName parameter to specify the resource name.</description></item>
        /// <item><description>If a featureCodes list is provided, the status of those specific features is returned. Otherwise, the status of all features under the specified targetScope is returned.</description></item>
        /// <item><description>When using WORKER, TEAM, or HUMAN as the targetScope, make sure to correctly specify the corresponding resourceName.</description></item>
        /// <item><description>For INSTANCE-level queries, resourceName is not required.</description></item>
        /// <item><description>Feature support is affected by factors such as the base version and worker version. The unsupportedReasonCode and unsupportedReason fields provide the specific reason why a feature is not supported.</description></item>
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
        /// <para>Retrieves all zone IDs supported by the current AgentTeams Resource Pool configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves all zone IDs supported by the current AgentTeams Resource Pool configuration.</para>
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
        /// <para>Retrieves all zone IDs supported by the current AgentTeams Resource Pool configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves all zone IDs supported by the current AgentTeams Resource Pool configuration.</para>
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
        /// <para>Retrieves all zone IDs supported by the current AgentTeams Resource Pool configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves all zone IDs supported by the current AgentTeams Resource Pool configuration.</para>
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
        /// <para>Retrieves all zone IDs supported by the current AgentTeams Resource Pool configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves all zone IDs supported by the current AgentTeams Resource Pool configuration.</para>
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
        /// <para>Resets the password of a specified user under a specified instance. After the reset, the user must log on with the new password.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Resets the password of a specified user under a specified instance. After the reset, the user must log on with the new password.</para>
        /// </description>
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
        /// <para>Resets the password of a specified user under a specified instance. After the reset, the user must log on with the new password.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Resets the password of a specified user under a specified instance. After the reset, the user must log on with the new password.</para>
        /// </description>
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
        /// <para>Resets the password of a specified user under a specified instance. After the reset, the user must log on with the new password.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Resets the password of a specified user under a specified instance. After the reset, the user must log on with the new password.</para>
        /// </description>
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
        /// <para>Resets the password of a specified user under a specified instance. After the reset, the user must log on with the new password.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Resets the password of a specified user under a specified instance. After the reset, the user must log on with the new password.</para>
        /// </description>
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
        /// <para>Tests the connectivity of an AI model provider and model under a specified AgentTeams instance by sending a test prompt and returning the call result, latency, and token usage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Tests the connectivity of an AI model provider and model under a specified AgentTeams instance by sending a test prompt and returning the call result, latency, and token usage.</para>
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
        /// <para>Tests the connectivity of an AI model provider and model under a specified AgentTeams instance by sending a test prompt and returning the call result, latency, and token usage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Tests the connectivity of an AI model provider and model under a specified AgentTeams instance by sending a test prompt and returning the call result, latency, and token usage.</para>
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
        /// <para>Tests the connectivity of an AI model provider and model under a specified AgentTeams instance by sending a test prompt and returning the call result, latency, and token usage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Tests the connectivity of an AI model provider and model under a specified AgentTeams instance by sending a test prompt and returning the call result, latency, and token usage.</para>
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
        /// <para>Tests the connectivity of an AI model provider and model under a specified AgentTeams instance by sending a test prompt and returning the call result, latency, and token usage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Tests the connectivity of an AI model provider and model under a specified AgentTeams instance by sending a test prompt and returning the call result, latency, and token usage.</para>
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
        /// <para>Unbinds the upstream identity provider from a specified instance, dissociates the identity federation relationship, and cleans up associated user identities and data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Unbinds the upstream identity provider from a specified instance, dissociates the identity federation relationship, and cleans up associated user identities and data.</para>
        /// </description>
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
        /// <para>Unbinds the upstream identity provider from a specified instance, dissociates the identity federation relationship, and cleans up associated user identities and data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Unbinds the upstream identity provider from a specified instance, dissociates the identity federation relationship, and cleans up associated user identities and data.</para>
        /// </description>
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
        /// <para>Unbinds the upstream identity provider from a specified instance, dissociates the identity federation relationship, and cleans up associated user identities and data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Unbinds the upstream identity provider from a specified instance, dissociates the identity federation relationship, and cleans up associated user identities and data.</para>
        /// </description>
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
        /// <para>Unbinds the upstream identity provider from a specified instance, dissociates the identity federation relationship, and cleans up associated user identities and data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Unbinds the upstream identity provider from a specified instance, dissociates the identity federation relationship, and cleans up associated user identities and data.</para>
        /// </description>
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
        /// <para>Updates the plaintext key of an existing credential in an AgentTeams instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the plaintext key of an existing credential in an AgentTeams instance.</para>
        /// <list type="bullet">
        /// <item><description>This operation updates the plaintext key of an existing Credential in an AgentTeams instance.</description></item>
        /// <item><description>Only the key value of the APIKeyCredentialProvider with the same name in the Agent Identity TokenVault is updated. Local metadata (description, createTime, updateTime, and status) is not modified.</description></item>
        /// <item><description>The response does not contain the apiKey plaintext. To obtain Worker details, call GetCredential.</description></item>
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
        /// <para>Updates the plaintext key of an existing credential in an AgentTeams instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the plaintext key of an existing credential in an AgentTeams instance.</para>
        /// <list type="bullet">
        /// <item><description>This operation updates the plaintext key of an existing Credential in an AgentTeams instance.</description></item>
        /// <item><description>Only the key value of the APIKeyCredentialProvider with the same name in the Agent Identity TokenVault is updated. Local metadata (description, createTime, updateTime, and status) is not modified.</description></item>
        /// <item><description>The response does not contain the apiKey plaintext. To obtain Worker details, call GetCredential.</description></item>
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
        /// <para>Updates the plaintext key of an existing credential in an AgentTeams instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the plaintext key of an existing credential in an AgentTeams instance.</para>
        /// <list type="bullet">
        /// <item><description>This operation updates the plaintext key of an existing Credential in an AgentTeams instance.</description></item>
        /// <item><description>Only the key value of the APIKeyCredentialProvider with the same name in the Agent Identity TokenVault is updated. Local metadata (description, createTime, updateTime, and status) is not modified.</description></item>
        /// <item><description>The response does not contain the apiKey plaintext. To obtain Worker details, call GetCredential.</description></item>
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
        /// <para>Updates the plaintext key of an existing credential in an AgentTeams instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the plaintext key of an existing credential in an AgentTeams instance.</para>
        /// <list type="bullet">
        /// <item><description>This operation updates the plaintext key of an existing Credential in an AgentTeams instance.</description></item>
        /// <item><description>Only the key value of the APIKeyCredentialProvider with the same name in the Agent Identity TokenVault is updated. Local metadata (description, createTime, updateTime, and status) is not modified.</description></item>
        /// <item><description>The response does not contain the apiKey plaintext. To obtain Worker details, call GetCredential.</description></item>
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
        /// <para>Updates the upstream identity provider configuration bound to a specified instance. You can adjust the logon switch and user synchronization switch.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the upstream identity provider configuration bound to a specified instance. You can adjust the logon switch and user synchronization switch.</para>
        /// </description>
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
        /// <para>Updates the upstream identity provider configuration bound to a specified instance. You can adjust the logon switch and user synchronization switch.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the upstream identity provider configuration bound to a specified instance. You can adjust the logon switch and user synchronization switch.</para>
        /// </description>
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
        /// <para>Updates the upstream identity provider configuration bound to a specified instance. You can adjust the logon switch and user synchronization switch.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the upstream identity provider configuration bound to a specified instance. You can adjust the logon switch and user synchronization switch.</para>
        /// </description>
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
        /// <para>Updates the upstream identity provider configuration bound to a specified instance. You can adjust the logon switch and user synchronization switch.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the upstream identity provider configuration bound to a specified instance. You can adjust the logon switch and user synchronization switch.</para>
        /// </description>
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
        /// <para>Changes the name of a specified AgentTeams instance. This operation supports GET and POST methods. You can only modify the instance name through this operation. You cannot change the namespace through this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Changes the name of a specified AgentTeams instance. This operation supports GET and POST methods. You can only modify the instance name through this operation. You cannot change the namespace through this operation.</para>
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
        /// <para>Changes the name of a specified AgentTeams instance. This operation supports GET and POST methods. You can only modify the instance name through this operation. You cannot change the namespace through this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Changes the name of a specified AgentTeams instance. This operation supports GET and POST methods. You can only modify the instance name through this operation. You cannot change the namespace through this operation.</para>
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
        /// <para>Changes the name of a specified AgentTeams instance. This operation supports GET and POST methods. You can only modify the instance name through this operation. You cannot change the namespace through this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Changes the name of a specified AgentTeams instance. This operation supports GET and POST methods. You can only modify the instance name through this operation. You cannot change the namespace through this operation.</para>
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
        /// <para>Changes the name of a specified AgentTeams instance. This operation supports GET and POST methods. You can only modify the instance name through this operation. You cannot change the namespace through this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Changes the name of a specified AgentTeams instance. This operation supports GET and POST methods. You can only modify the instance name through this operation. You cannot change the namespace through this operation.</para>
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
        /// <para>Restarts a paused asynchronous task for creating an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Restarts a paused asynchronous task for creating an instance.</para>
        /// <list type="bullet">
        /// <item><description>This operation restarts a create-instance task that is in the paused state.</description></item>
        /// <item><description>Only tasks of the agentteams:pay-order:create type are supported.</description></item>
        /// <item><description>Ensure that the InstanceId, TaskCode, and TaskId parameters are accurate. Otherwise, the request may fail.</description></item>
        /// <item><description>If the task is not in the paused state (PAUSED), you cannot call this operation to update the task.</description></item>
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
        /// <para>Restarts a paused asynchronous task for creating an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Restarts a paused asynchronous task for creating an instance.</para>
        /// <list type="bullet">
        /// <item><description>This operation restarts a create-instance task that is in the paused state.</description></item>
        /// <item><description>Only tasks of the agentteams:pay-order:create type are supported.</description></item>
        /// <item><description>Ensure that the InstanceId, TaskCode, and TaskId parameters are accurate. Otherwise, the request may fail.</description></item>
        /// <item><description>If the task is not in the paused state (PAUSED), you cannot call this operation to update the task.</description></item>
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
        /// <para>Restarts a paused asynchronous task for creating an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Restarts a paused asynchronous task for creating an instance.</para>
        /// <list type="bullet">
        /// <item><description>This operation restarts a create-instance task that is in the paused state.</description></item>
        /// <item><description>Only tasks of the agentteams:pay-order:create type are supported.</description></item>
        /// <item><description>Ensure that the InstanceId, TaskCode, and TaskId parameters are accurate. Otherwise, the request may fail.</description></item>
        /// <item><description>If the task is not in the paused state (PAUSED), you cannot call this operation to update the task.</description></item>
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
        /// <para>Restarts a paused asynchronous task for creating an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Restarts a paused asynchronous task for creating an instance.</para>
        /// <list type="bullet">
        /// <item><description>This operation restarts a create-instance task that is in the paused state.</description></item>
        /// <item><description>Only tasks of the agentteams:pay-order:create type are supported.</description></item>
        /// <item><description>Ensure that the InstanceId, TaskCode, and TaskId parameters are accurate. Otherwise, the request may fail.</description></item>
        /// <item><description>If the task is not in the paused state (PAUSED), you cannot call this operation to update the task.</description></item>
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
        /// <para>Updates the configuration of a specified MCP server, including the address list, authentication information, and description.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified MCP server, including the address list, authentication information, and description.</para>
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
        /// <para>Updates the configuration of a specified MCP server, including the address list, authentication information, and description.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified MCP server, including the address list, authentication information, and description.</para>
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
        /// <para>Updates the configuration of a specified MCP server, including the address list, authentication information, and description.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified MCP server, including the address list, authentication information, and description.</para>
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
        /// <para>Updates the configuration of a specified MCP server, including the address list, authentication information, and description.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified MCP server, including the address list, authentication information, and description.</para>
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
        /// <para>Updates the description and other information of an AI model in a specified AgentTeams instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the description and other information of an AI model in a specified AgentTeams instance.</para>
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
        /// <para>Updates the description and other information of an AI model in a specified AgentTeams instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the description and other information of an AI model in a specified AgentTeams instance.</para>
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
        /// <para>Updates the description and other information of an AI model in a specified AgentTeams instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the description and other information of an AI model in a specified AgentTeams instance.</para>
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
        /// <para>Updates the description and other information of an AI model in a specified AgentTeams instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the description and other information of an AI model in a specified AgentTeams instance.</para>
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
        /// <para>Updates the address, protocol list, API key, and other information of an AI model provider in a specified AgentTeams instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the address, protocol list, API key, and other information of an AI model provider in a specified AgentTeams instance.</para>
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
        /// <para>Updates the address, protocol list, API key, and other information of an AI model provider in a specified AgentTeams instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the address, protocol list, API key, and other information of an AI model provider in a specified AgentTeams instance.</para>
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
        /// <para>Updates the address, protocol list, API key, and other information of an AI model provider in a specified AgentTeams instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the address, protocol list, API key, and other information of an AI model provider in a specified AgentTeams instance.</para>
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
        /// <para>Updates the address, protocol list, API key, and other information of an AI model provider in a specified AgentTeams instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the address, protocol list, API key, and other information of an AI model provider in a specified AgentTeams instance.</para>
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
        /// <para>Updates the domain name and SSL certificate information for a specified endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the domain name and SSL certificate information for a specified endpoint.</para>
        /// <list type="bullet">
        /// <item><description>This API operation supports updating endpoints of the ELEMENT or MATRIX type.</description></item>
        /// <item><description>If you attempt to update an endpoint of another type, a 400 error is returned.</description></item>
        /// <item><description>If the endpointId does not exist or does not belong to the current user instance, a 404 error is returned.</description></item>
        /// <item><description>When updating a domain name, the system creates or reuses a new HTTPS domain and binds it to the original endpoint route. The old domain is unbound but not deleted.</description></item>
        /// <item><description>If the domain or certIdentifier parameter is not specified, the existing settings are retained.</description></item>
        /// <item><description>Other fields such as component and gatewayType are not updated even if they are specified in the request.</description></item>
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
        /// <para>Updates the domain name and SSL certificate information for a specified endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the domain name and SSL certificate information for a specified endpoint.</para>
        /// <list type="bullet">
        /// <item><description>This API operation supports updating endpoints of the ELEMENT or MATRIX type.</description></item>
        /// <item><description>If you attempt to update an endpoint of another type, a 400 error is returned.</description></item>
        /// <item><description>If the endpointId does not exist or does not belong to the current user instance, a 404 error is returned.</description></item>
        /// <item><description>When updating a domain name, the system creates or reuses a new HTTPS domain and binds it to the original endpoint route. The old domain is unbound but not deleted.</description></item>
        /// <item><description>If the domain or certIdentifier parameter is not specified, the existing settings are retained.</description></item>
        /// <item><description>Other fields such as component and gatewayType are not updated even if they are specified in the request.</description></item>
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
        /// <para>Updates the domain name and SSL certificate information for a specified endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the domain name and SSL certificate information for a specified endpoint.</para>
        /// <list type="bullet">
        /// <item><description>This API operation supports updating endpoints of the ELEMENT or MATRIX type.</description></item>
        /// <item><description>If you attempt to update an endpoint of another type, a 400 error is returned.</description></item>
        /// <item><description>If the endpointId does not exist or does not belong to the current user instance, a 404 error is returned.</description></item>
        /// <item><description>When updating a domain name, the system creates or reuses a new HTTPS domain and binds it to the original endpoint route. The old domain is unbound but not deleted.</description></item>
        /// <item><description>If the domain or certIdentifier parameter is not specified, the existing settings are retained.</description></item>
        /// <item><description>Other fields such as component and gatewayType are not updated even if they are specified in the request.</description></item>
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
        /// <para>Updates the domain name and SSL certificate information for a specified endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the domain name and SSL certificate information for a specified endpoint.</para>
        /// <list type="bullet">
        /// <item><description>This API operation supports updating endpoints of the ELEMENT or MATRIX type.</description></item>
        /// <item><description>If you attempt to update an endpoint of another type, a 400 error is returned.</description></item>
        /// <item><description>If the endpointId does not exist or does not belong to the current user instance, a 404 error is returned.</description></item>
        /// <item><description>When updating a domain name, the system creates or reuses a new HTTPS domain and binds it to the original endpoint route. The old domain is unbound but not deleted.</description></item>
        /// <item><description>If the domain or certIdentifier parameter is not specified, the existing settings are retained.</description></item>
        /// <item><description>Other fields such as component and gatewayType are not updated even if they are specified in the request.</description></item>
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
        /// <para>Updates the description and member list of a team under a specified instance, and returns the latest team information after the update.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the description and member list of a team under a specified instance, and returns the latest team information after the update.</para>
        /// </description>
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
        /// <para>Updates the description and member list of a team under a specified instance, and returns the latest team information after the update.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the description and member list of a team under a specified instance, and returns the latest team information after the update.</para>
        /// </description>
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
        /// <para>Updates the description and member list of a team under a specified instance, and returns the latest team information after the update.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the description and member list of a team under a specified instance, and returns the latest team information after the update.</para>
        /// </description>
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
        /// <para>Updates the description and member list of a team under a specified instance, and returns the latest team information after the update.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the description and member list of a team under a specified instance, and returns the latest team information after the update.</para>
        /// </description>
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
        /// <para>Updates the information of a specified user under a specified instance, including the display name, email address, authentication method, and remarks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the information of a specified user under a specified instance, including the display name, email address, authentication method, and remarks.</para>
        /// </description>
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
        /// <para>Updates the information of a specified user under a specified instance, including the display name, email address, authentication method, and remarks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the information of a specified user under a specified instance, including the display name, email address, authentication method, and remarks.</para>
        /// </description>
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
        /// <para>Updates the information of a specified user under a specified instance, including the display name, email address, authentication method, and remarks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the information of a specified user under a specified instance, including the display name, email address, authentication method, and remarks.</para>
        /// </description>
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
        /// <para>Updates the information of a specified user under a specified instance, including the display name, email address, authentication method, and remarks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the information of a specified user under a specified instance, including the display name, email address, authentication method, and remarks.</para>
        /// </description>
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
        /// <para>Updates the configuration of a specified Worker, including model, skills, template, MCP servers, channels, and quotas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified Worker, including model, skills, template, MCP servers, channels, and quotas.</para>
        /// </description>
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
        /// <para>Updates the configuration of a specified Worker, including model, skills, template, MCP servers, channels, and quotas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified Worker, including model, skills, template, MCP servers, channels, and quotas.</para>
        /// </description>
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
        /// <para>Updates the configuration of a specified Worker, including model, skills, template, MCP servers, channels, and quotas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified Worker, including model, skills, template, MCP servers, channels, and quotas.</para>
        /// </description>
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
        /// <para>Updates the configuration of a specified Worker, including model, skills, template, MCP servers, channels, and quotas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified Worker, including model, skills, template, MCP servers, channels, and quotas.</para>
        /// </description>
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
