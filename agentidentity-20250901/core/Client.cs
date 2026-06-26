// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AgentIdentity20250901.Models;

namespace AlibabaCloud.SDK.AgentIdentity20250901
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("agentidentity", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddSAMLIdentityProviderCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddSAMLIdentityProviderCertificateResponse
        /// </returns>
        public AddSAMLIdentityProviderCertificateResponse AddSAMLIdentityProviderCertificateWithOptions(AddSAMLIdentityProviderCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.X509Certificate))
            {
                body["X509Certificate"] = request.X509Certificate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSAMLIdentityProviderCertificate",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSAMLIdentityProviderCertificateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddSAMLIdentityProviderCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddSAMLIdentityProviderCertificateResponse
        /// </returns>
        public async Task<AddSAMLIdentityProviderCertificateResponse> AddSAMLIdentityProviderCertificateWithOptionsAsync(AddSAMLIdentityProviderCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.X509Certificate))
            {
                body["X509Certificate"] = request.X509Certificate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSAMLIdentityProviderCertificate",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSAMLIdentityProviderCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddSAMLIdentityProviderCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// AddSAMLIdentityProviderCertificateResponse
        /// </returns>
        public AddSAMLIdentityProviderCertificateResponse AddSAMLIdentityProviderCertificate(AddSAMLIdentityProviderCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSAMLIdentityProviderCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddSAMLIdentityProviderCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// AddSAMLIdentityProviderCertificateResponse
        /// </returns>
        public async Task<AddSAMLIdentityProviderCertificateResponse> AddSAMLIdentityProviderCertificateAsync(AddSAMLIdentityProviderCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSAMLIdentityProviderCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>策略集关联网关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachPolicySetToGatewayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachPolicySetToGatewayResponse
        /// </returns>
        public AttachPolicySetToGatewayResponse AttachPolicySetToGatewayWithOptions(AttachPolicySetToGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnforcementMode))
            {
                body["EnforcementMode"] = request.EnforcementMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayArn))
            {
                body["GatewayArn"] = request.GatewayArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                body["GatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachPolicySetToGateway",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachPolicySetToGatewayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>策略集关联网关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachPolicySetToGatewayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachPolicySetToGatewayResponse
        /// </returns>
        public async Task<AttachPolicySetToGatewayResponse> AttachPolicySetToGatewayWithOptionsAsync(AttachPolicySetToGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnforcementMode))
            {
                body["EnforcementMode"] = request.EnforcementMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayArn))
            {
                body["GatewayArn"] = request.GatewayArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                body["GatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachPolicySetToGateway",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachPolicySetToGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>策略集关联网关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachPolicySetToGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachPolicySetToGatewayResponse
        /// </returns>
        public AttachPolicySetToGatewayResponse AttachPolicySetToGateway(AttachPolicySetToGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachPolicySetToGatewayWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>策略集关联网关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachPolicySetToGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachPolicySetToGatewayResponse
        /// </returns>
        public async Task<AttachPolicySetToGatewayResponse> AttachPolicySetToGatewayAsync(AttachPolicySetToGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachPolicySetToGatewayWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个 API 密钥凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAPIKeyCredentialProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAPIKeyCredentialProviderResponse
        /// </returns>
        public CreateAPIKeyCredentialProviderResponse CreateAPIKeyCredentialProviderWithOptions(CreateAPIKeyCredentialProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKey))
            {
                body["APIKey"] = request.APIKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKeyCredentialProviderName))
            {
                body["APIKeyCredentialProviderName"] = request.APIKeyCredentialProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAPIKeyCredentialProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAPIKeyCredentialProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个 API 密钥凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAPIKeyCredentialProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAPIKeyCredentialProviderResponse
        /// </returns>
        public async Task<CreateAPIKeyCredentialProviderResponse> CreateAPIKeyCredentialProviderWithOptionsAsync(CreateAPIKeyCredentialProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKey))
            {
                body["APIKey"] = request.APIKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKeyCredentialProviderName))
            {
                body["APIKeyCredentialProviderName"] = request.APIKeyCredentialProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAPIKeyCredentialProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAPIKeyCredentialProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个 API 密钥凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAPIKeyCredentialProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAPIKeyCredentialProviderResponse
        /// </returns>
        public CreateAPIKeyCredentialProviderResponse CreateAPIKeyCredentialProvider(CreateAPIKeyCredentialProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAPIKeyCredentialProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个 API 密钥凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAPIKeyCredentialProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAPIKeyCredentialProviderResponse
        /// </returns>
        public async Task<CreateAPIKeyCredentialProviderResponse> CreateAPIKeyCredentialProviderAsync(CreateAPIKeyCredentialProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAPIKeyCredentialProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateClientSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClientSecretResponse
        /// </returns>
        public CreateClientSecretResponse CreateClientSecretWithOptions(CreateClientSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientName))
            {
                body["ClientName"] = request.ClientName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClientSecret",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClientSecretResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateClientSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClientSecretResponse
        /// </returns>
        public async Task<CreateClientSecretResponse> CreateClientSecretWithOptionsAsync(CreateClientSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientName))
            {
                body["ClientName"] = request.ClientName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClientSecret",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClientSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateClientSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClientSecretResponse
        /// </returns>
        public CreateClientSecretResponse CreateClientSecret(CreateClientSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClientSecretWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateClientSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClientSecretResponse
        /// </returns>
        public async Task<CreateClientSecretResponse> CreateClientSecretAsync(CreateClientSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClientSecretWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIdentityProviderResponse
        /// </returns>
        public CreateIdentityProviderResponse CreateIdentityProviderWithOptions(CreateIdentityProviderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateIdentityProviderShrinkRequest request = new CreateIdentityProviderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AllowedAudience))
            {
                request.AllowedAudienceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AllowedAudience, "AllowedAudience", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedAudienceShrink))
            {
                body["AllowedAudience"] = request.AllowedAudienceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoveryURL))
            {
                body["DiscoveryURL"] = request.DiscoveryURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderName))
            {
                body["IdentityProviderName"] = request.IdentityProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIdentityProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIdentityProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIdentityProviderResponse
        /// </returns>
        public async Task<CreateIdentityProviderResponse> CreateIdentityProviderWithOptionsAsync(CreateIdentityProviderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateIdentityProviderShrinkRequest request = new CreateIdentityProviderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AllowedAudience))
            {
                request.AllowedAudienceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AllowedAudience, "AllowedAudience", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedAudienceShrink))
            {
                body["AllowedAudience"] = request.AllowedAudienceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoveryURL))
            {
                body["DiscoveryURL"] = request.DiscoveryURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderName))
            {
                body["IdentityProviderName"] = request.IdentityProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIdentityProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIdentityProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIdentityProviderResponse
        /// </returns>
        public CreateIdentityProviderResponse CreateIdentityProvider(CreateIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIdentityProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIdentityProviderResponse
        /// </returns>
        public async Task<CreateIdentityProviderResponse> CreateIdentityProviderAsync(CreateIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIdentityProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 OAuth2 凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateOAuth2CredentialProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOAuth2CredentialProviderResponse
        /// </returns>
        public CreateOAuth2CredentialProviderResponse CreateOAuth2CredentialProviderWithOptions(CreateOAuth2CredentialProviderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateOAuth2CredentialProviderShrinkRequest request = new CreateOAuth2CredentialProviderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OAuth2ProviderConfig))
            {
                request.OAuth2ProviderConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OAuth2ProviderConfig, "OAuth2ProviderConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackURL))
            {
                body["CallbackURL"] = request.CallbackURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialProviderVendor))
            {
                body["CredentialProviderVendor"] = request.CredentialProviderVendor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OAuth2CredentialProviderName))
            {
                body["OAuth2CredentialProviderName"] = request.OAuth2CredentialProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OAuth2ProviderConfigShrink))
            {
                body["OAuth2ProviderConfig"] = request.OAuth2ProviderConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOAuth2CredentialProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOAuth2CredentialProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 OAuth2 凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateOAuth2CredentialProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOAuth2CredentialProviderResponse
        /// </returns>
        public async Task<CreateOAuth2CredentialProviderResponse> CreateOAuth2CredentialProviderWithOptionsAsync(CreateOAuth2CredentialProviderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateOAuth2CredentialProviderShrinkRequest request = new CreateOAuth2CredentialProviderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OAuth2ProviderConfig))
            {
                request.OAuth2ProviderConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OAuth2ProviderConfig, "OAuth2ProviderConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackURL))
            {
                body["CallbackURL"] = request.CallbackURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialProviderVendor))
            {
                body["CredentialProviderVendor"] = request.CredentialProviderVendor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OAuth2CredentialProviderName))
            {
                body["OAuth2CredentialProviderName"] = request.OAuth2CredentialProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OAuth2ProviderConfigShrink))
            {
                body["OAuth2ProviderConfig"] = request.OAuth2ProviderConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOAuth2CredentialProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOAuth2CredentialProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 OAuth2 凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOAuth2CredentialProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOAuth2CredentialProviderResponse
        /// </returns>
        public CreateOAuth2CredentialProviderResponse CreateOAuth2CredentialProvider(CreateOAuth2CredentialProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOAuth2CredentialProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 OAuth2 凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOAuth2CredentialProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOAuth2CredentialProviderResponse
        /// </returns>
        public async Task<CreateOAuth2CredentialProviderResponse> CreateOAuth2CredentialProviderAsync(CreateOAuth2CredentialProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOAuth2CredentialProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个权限策略</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreatePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyResponse
        /// </returns>
        public CreatePolicyResponse CreatePolicyWithOptions(CreatePolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePolicyShrinkRequest request = new CreatePolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Definition))
            {
                request.DefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Definition, "Definition", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefinitionShrink))
            {
                body["Definition"] = request.DefinitionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                body["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicy",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个权限策略</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreatePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyResponse
        /// </returns>
        public async Task<CreatePolicyResponse> CreatePolicyWithOptionsAsync(CreatePolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePolicyShrinkRequest request = new CreatePolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Definition))
            {
                request.DefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Definition, "Definition", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefinitionShrink))
            {
                body["Definition"] = request.DefinitionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                body["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicy",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个权限策略</para>
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
            return CreatePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个权限策略</para>
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
            return await CreatePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个权限策略集合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePolicySetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicySetResponse
        /// </returns>
        public CreatePolicySetResponse CreatePolicySetWithOptions(CreatePolicySetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicySet",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicySetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个权限策略集合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePolicySetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicySetResponse
        /// </returns>
        public async Task<CreatePolicySetResponse> CreatePolicySetWithOptionsAsync(CreatePolicySetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicySet",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicySetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个权限策略集合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePolicySetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicySetResponse
        /// </returns>
        public CreatePolicySetResponse CreatePolicySet(CreatePolicySetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePolicySetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个权限策略集合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePolicySetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicySetResponse
        /// </returns>
        public async Task<CreatePolicySetResponse> CreatePolicySetAsync(CreatePolicySetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePolicySetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Role</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRoleResponse
        /// </returns>
        public CreateRoleResponse CreateRoleWithOptions(CreateRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRole",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Role</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRoleResponse
        /// </returns>
        public async Task<CreateRoleResponse> CreateRoleWithOptionsAsync(CreateRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRole",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Role</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRoleResponse
        /// </returns>
        public CreateRoleResponse CreateRole(CreateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRoleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Role</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRoleResponse
        /// </returns>
        public async Task<CreateRoleResponse> CreateRoleAsync(CreateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRoleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>策略集关联网关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRoleAssignmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRoleAssignmentResponse
        /// </returns>
        public CreateRoleAssignmentResponse CreateRoleAssignmentWithOptions(CreateRoleAssignmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                body["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalType))
            {
                body["PrincipalType"] = request.PrincipalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRoleAssignment",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRoleAssignmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>策略集关联网关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRoleAssignmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRoleAssignmentResponse
        /// </returns>
        public async Task<CreateRoleAssignmentResponse> CreateRoleAssignmentWithOptionsAsync(CreateRoleAssignmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                body["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalType))
            {
                body["PrincipalType"] = request.PrincipalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRoleAssignment",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRoleAssignmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>策略集关联网关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRoleAssignmentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRoleAssignmentResponse
        /// </returns>
        public CreateRoleAssignmentResponse CreateRoleAssignment(CreateRoleAssignmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRoleAssignmentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>策略集关联网关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRoleAssignmentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRoleAssignmentResponse
        /// </returns>
        public async Task<CreateRoleAssignmentResponse> CreateRoleAssignmentAsync(CreateRoleAssignmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRoleAssignmentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个凭证库</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateTokenVaultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTokenVaultResponse
        /// </returns>
        public CreateTokenVaultResponse CreateTokenVaultWithOptions(CreateTokenVaultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTokenVaultShrinkRequest request = new CreateTokenVaultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionConfig))
            {
                request.EncryptionConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionConfig, "EncryptionConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionConfigShrink))
            {
                body["EncryptionConfig"] = request.EncryptionConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                body["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTokenVault",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTokenVaultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个凭证库</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateTokenVaultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTokenVaultResponse
        /// </returns>
        public async Task<CreateTokenVaultResponse> CreateTokenVaultWithOptionsAsync(CreateTokenVaultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTokenVaultShrinkRequest request = new CreateTokenVaultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionConfig))
            {
                request.EncryptionConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionConfig, "EncryptionConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionConfigShrink))
            {
                body["EncryptionConfig"] = request.EncryptionConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                body["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTokenVault",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTokenVaultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个凭证库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTokenVaultRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTokenVaultResponse
        /// </returns>
        public CreateTokenVaultResponse CreateTokenVault(CreateTokenVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTokenVaultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个凭证库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTokenVaultRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTokenVaultResponse
        /// </returns>
        public async Task<CreateTokenVaultResponse> CreateTokenVaultAsync(CreateTokenVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTokenVaultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户池用户</para>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2025-09-01",
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
        /// <para>创建用户池用户</para>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2025-09-01",
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
        /// <para>创建用户池用户</para>
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
        /// <para>创建用户池用户</para>
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
        /// <para>创建UserPool</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserPoolResponse
        /// </returns>
        public CreateUserPoolResponse CreateUserPoolWithOptions(CreateUserPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserPool",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserPoolResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建UserPool</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserPoolResponse
        /// </returns>
        public async Task<CreateUserPoolResponse> CreateUserPoolWithOptionsAsync(CreateUserPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserPool",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建UserPool</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserPoolResponse
        /// </returns>
        public CreateUserPoolResponse CreateUserPool(CreateUserPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserPoolWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建UserPool</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserPoolResponse
        /// </returns>
        public async Task<CreateUserPoolResponse> CreateUserPoolAsync(CreateUserPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserPoolWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateUserPoolClientRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserPoolClientResponse
        /// </returns>
        public CreateUserPoolClientResponse CreateUserPoolClientWithOptions(CreateUserPoolClientRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateUserPoolClientShrinkRequest request = new CreateUserPoolClientShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RedirectURIs))
            {
                request.RedirectURIsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RedirectURIs, "RedirectURIs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessTokenValidity))
            {
                body["AccessTokenValidity"] = request.AccessTokenValidity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientName))
            {
                body["ClientName"] = request.ClientName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnforcePKCE))
            {
                body["EnforcePKCE"] = request.EnforcePKCE;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectURIsShrink))
            {
                body["RedirectURIs"] = request.RedirectURIsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefreshTokenValidity))
            {
                body["RefreshTokenValidity"] = request.RefreshTokenValidity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretRequired))
            {
                body["SecretRequired"] = request.SecretRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserPoolClient",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserPoolClientResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateUserPoolClientRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserPoolClientResponse
        /// </returns>
        public async Task<CreateUserPoolClientResponse> CreateUserPoolClientWithOptionsAsync(CreateUserPoolClientRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateUserPoolClientShrinkRequest request = new CreateUserPoolClientShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RedirectURIs))
            {
                request.RedirectURIsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RedirectURIs, "RedirectURIs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessTokenValidity))
            {
                body["AccessTokenValidity"] = request.AccessTokenValidity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientName))
            {
                body["ClientName"] = request.ClientName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnforcePKCE))
            {
                body["EnforcePKCE"] = request.EnforcePKCE;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectURIsShrink))
            {
                body["RedirectURIs"] = request.RedirectURIsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefreshTokenValidity))
            {
                body["RefreshTokenValidity"] = request.RefreshTokenValidity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretRequired))
            {
                body["SecretRequired"] = request.SecretRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserPoolClient",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserPoolClientResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserPoolClientRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserPoolClientResponse
        /// </returns>
        public CreateUserPoolClientResponse CreateUserPoolClient(CreateUserPoolClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserPoolClientWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserPoolClientRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserPoolClientResponse
        /// </returns>
        public async Task<CreateUserPoolClientResponse> CreateUserPoolClientAsync(CreateUserPoolClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserPoolClientWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateWorkloadIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkloadIdentityResponse
        /// </returns>
        public CreateWorkloadIdentityResponse CreateWorkloadIdentityWithOptions(CreateWorkloadIdentityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWorkloadIdentityShrinkRequest request = new CreateWorkloadIdentityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AllowedResourceOAuth2ReturnURLs))
            {
                request.AllowedResourceOAuth2ReturnURLsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AllowedResourceOAuth2ReturnURLs, "AllowedResourceOAuth2ReturnURLs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedResourceOAuth2ReturnURLsShrink))
            {
                body["AllowedResourceOAuth2ReturnURLs"] = request.AllowedResourceOAuth2ReturnURLsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateRAMRole))
            {
                body["CreateRAMRole"] = request.CreateRAMRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderName))
            {
                body["IdentityProviderName"] = request.IdentityProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                body["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionBindingEnabled))
            {
                body["SessionBindingEnabled"] = request.SessionBindingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceAgentArn))
            {
                body["SourceAgentArn"] = request.SourceAgentArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePlatform))
            {
                body["SourcePlatform"] = request.SourcePlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkloadIdentityName))
            {
                body["WorkloadIdentityName"] = request.WorkloadIdentityName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkloadIdentity",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkloadIdentityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateWorkloadIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkloadIdentityResponse
        /// </returns>
        public async Task<CreateWorkloadIdentityResponse> CreateWorkloadIdentityWithOptionsAsync(CreateWorkloadIdentityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWorkloadIdentityShrinkRequest request = new CreateWorkloadIdentityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AllowedResourceOAuth2ReturnURLs))
            {
                request.AllowedResourceOAuth2ReturnURLsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AllowedResourceOAuth2ReturnURLs, "AllowedResourceOAuth2ReturnURLs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedResourceOAuth2ReturnURLsShrink))
            {
                body["AllowedResourceOAuth2ReturnURLs"] = request.AllowedResourceOAuth2ReturnURLsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateRAMRole))
            {
                body["CreateRAMRole"] = request.CreateRAMRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderName))
            {
                body["IdentityProviderName"] = request.IdentityProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                body["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionBindingEnabled))
            {
                body["SessionBindingEnabled"] = request.SessionBindingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceAgentArn))
            {
                body["SourceAgentArn"] = request.SourceAgentArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePlatform))
            {
                body["SourcePlatform"] = request.SourcePlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkloadIdentityName))
            {
                body["WorkloadIdentityName"] = request.WorkloadIdentityName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkloadIdentity",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkloadIdentityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkloadIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkloadIdentityResponse
        /// </returns>
        public CreateWorkloadIdentityResponse CreateWorkloadIdentity(CreateWorkloadIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWorkloadIdentityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkloadIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkloadIdentityResponse
        /// </returns>
        public async Task<CreateWorkloadIdentityResponse> CreateWorkloadIdentityAsync(CreateWorkloadIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWorkloadIdentityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个 API 密钥凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAPIKeyCredentialProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAPIKeyCredentialProviderResponse
        /// </returns>
        public DeleteAPIKeyCredentialProviderResponse DeleteAPIKeyCredentialProviderWithOptions(DeleteAPIKeyCredentialProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKeyCredentialProviderName))
            {
                body["APIKeyCredentialProviderName"] = request.APIKeyCredentialProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAPIKeyCredentialProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAPIKeyCredentialProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个 API 密钥凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAPIKeyCredentialProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAPIKeyCredentialProviderResponse
        /// </returns>
        public async Task<DeleteAPIKeyCredentialProviderResponse> DeleteAPIKeyCredentialProviderWithOptionsAsync(DeleteAPIKeyCredentialProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKeyCredentialProviderName))
            {
                body["APIKeyCredentialProviderName"] = request.APIKeyCredentialProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAPIKeyCredentialProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAPIKeyCredentialProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个 API 密钥凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAPIKeyCredentialProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAPIKeyCredentialProviderResponse
        /// </returns>
        public DeleteAPIKeyCredentialProviderResponse DeleteAPIKeyCredentialProvider(DeleteAPIKeyCredentialProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAPIKeyCredentialProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个 API 密钥凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAPIKeyCredentialProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAPIKeyCredentialProviderResponse
        /// </returns>
        public async Task<DeleteAPIKeyCredentialProviderResponse> DeleteAPIKeyCredentialProviderAsync(DeleteAPIKeyCredentialProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAPIKeyCredentialProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteClientSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientSecretResponse
        /// </returns>
        public DeleteClientSecretResponse DeleteClientSecretWithOptions(DeleteClientSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientName))
            {
                body["ClientName"] = request.ClientName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSecretId))
            {
                body["ClientSecretId"] = request.ClientSecretId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClientSecret",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClientSecretResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteClientSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientSecretResponse
        /// </returns>
        public async Task<DeleteClientSecretResponse> DeleteClientSecretWithOptionsAsync(DeleteClientSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientName))
            {
                body["ClientName"] = request.ClientName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSecretId))
            {
                body["ClientSecretId"] = request.ClientSecretId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClientSecret",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClientSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteClientSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientSecretResponse
        /// </returns>
        public DeleteClientSecretResponse DeleteClientSecret(DeleteClientSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClientSecretWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteClientSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientSecretResponse
        /// </returns>
        public async Task<DeleteClientSecretResponse> DeleteClientSecretAsync(DeleteClientSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClientSecretWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIdentityProviderResponse
        /// </returns>
        public DeleteIdentityProviderResponse DeleteIdentityProviderWithOptions(DeleteIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderName))
            {
                body["IdentityProviderName"] = request.IdentityProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIdentityProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIdentityProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIdentityProviderResponse
        /// </returns>
        public async Task<DeleteIdentityProviderResponse> DeleteIdentityProviderWithOptionsAsync(DeleteIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderName))
            {
                body["IdentityProviderName"] = request.IdentityProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIdentityProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIdentityProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIdentityProviderResponse
        /// </returns>
        public DeleteIdentityProviderResponse DeleteIdentityProvider(DeleteIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIdentityProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIdentityProviderResponse
        /// </returns>
        public async Task<DeleteIdentityProviderResponse> DeleteIdentityProviderAsync(DeleteIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIdentityProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 OAuth2 凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOAuth2CredentialProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOAuth2CredentialProviderResponse
        /// </returns>
        public DeleteOAuth2CredentialProviderResponse DeleteOAuth2CredentialProviderWithOptions(DeleteOAuth2CredentialProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OAuth2CredentialProviderName))
            {
                body["OAuth2CredentialProviderName"] = request.OAuth2CredentialProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOAuth2CredentialProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOAuth2CredentialProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 OAuth2 凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOAuth2CredentialProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOAuth2CredentialProviderResponse
        /// </returns>
        public async Task<DeleteOAuth2CredentialProviderResponse> DeleteOAuth2CredentialProviderWithOptionsAsync(DeleteOAuth2CredentialProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OAuth2CredentialProviderName))
            {
                body["OAuth2CredentialProviderName"] = request.OAuth2CredentialProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOAuth2CredentialProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOAuth2CredentialProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 OAuth2 凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOAuth2CredentialProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOAuth2CredentialProviderResponse
        /// </returns>
        public DeleteOAuth2CredentialProviderResponse DeleteOAuth2CredentialProvider(DeleteOAuth2CredentialProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOAuth2CredentialProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 OAuth2 凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOAuth2CredentialProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOAuth2CredentialProviderResponse
        /// </returns>
        public async Task<DeleteOAuth2CredentialProviderResponse> DeleteOAuth2CredentialProviderAsync(DeleteOAuth2CredentialProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOAuth2CredentialProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个权限策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyResponse
        /// </returns>
        public DeletePolicyResponse DeletePolicyWithOptions(DeletePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                body["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicy",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个权限策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyResponse
        /// </returns>
        public async Task<DeletePolicyResponse> DeletePolicyWithOptionsAsync(DeletePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                body["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicy",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个权限策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyResponse
        /// </returns>
        public DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个权限策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyResponse
        /// </returns>
        public async Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个权限策略集合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePolicySetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicySetResponse
        /// </returns>
        public DeletePolicySetResponse DeletePolicySetWithOptions(DeletePolicySetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicySet",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicySetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个权限策略集合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePolicySetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicySetResponse
        /// </returns>
        public async Task<DeletePolicySetResponse> DeletePolicySetWithOptionsAsync(DeletePolicySetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicySet",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicySetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个权限策略集合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePolicySetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicySetResponse
        /// </returns>
        public DeletePolicySetResponse DeletePolicySet(DeletePolicySetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePolicySetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个权限策略集合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePolicySetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicySetResponse
        /// </returns>
        public async Task<DeletePolicySetResponse> DeletePolicySetAsync(DeletePolicySetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePolicySetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Role</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRoleResponse
        /// </returns>
        public DeleteRoleResponse DeleteRoleWithOptions(DeleteRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRole",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Role</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRoleResponse
        /// </returns>
        public async Task<DeleteRoleResponse> DeleteRoleWithOptionsAsync(DeleteRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRole",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Role</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRoleResponse
        /// </returns>
        public DeleteRoleResponse DeleteRole(DeleteRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRoleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Role</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRoleResponse
        /// </returns>
        public async Task<DeleteRoleResponse> DeleteRoleAsync(DeleteRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRoleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>网关取消关联策略集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRoleAssignmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRoleAssignmentResponse
        /// </returns>
        public DeleteRoleAssignmentResponse DeleteRoleAssignmentWithOptions(DeleteRoleAssignmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                body["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalType))
            {
                body["PrincipalType"] = request.PrincipalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRoleAssignment",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRoleAssignmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>网关取消关联策略集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRoleAssignmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRoleAssignmentResponse
        /// </returns>
        public async Task<DeleteRoleAssignmentResponse> DeleteRoleAssignmentWithOptionsAsync(DeleteRoleAssignmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                body["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalType))
            {
                body["PrincipalType"] = request.PrincipalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRoleAssignment",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRoleAssignmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>网关取消关联策略集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRoleAssignmentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRoleAssignmentResponse
        /// </returns>
        public DeleteRoleAssignmentResponse DeleteRoleAssignment(DeleteRoleAssignmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRoleAssignmentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>网关取消关联策略集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRoleAssignmentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRoleAssignmentResponse
        /// </returns>
        public async Task<DeleteRoleAssignmentResponse> DeleteRoleAssignmentAsync(DeleteRoleAssignmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRoleAssignmentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSAMLIdentityProviderCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSAMLIdentityProviderCertificateResponse
        /// </returns>
        public DeleteSAMLIdentityProviderCertificateResponse DeleteSAMLIdentityProviderCertificateWithOptions(DeleteSAMLIdentityProviderCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                body["CertificateId"] = request.CertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSAMLIdentityProviderCertificate",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSAMLIdentityProviderCertificateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSAMLIdentityProviderCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSAMLIdentityProviderCertificateResponse
        /// </returns>
        public async Task<DeleteSAMLIdentityProviderCertificateResponse> DeleteSAMLIdentityProviderCertificateWithOptionsAsync(DeleteSAMLIdentityProviderCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                body["CertificateId"] = request.CertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSAMLIdentityProviderCertificate",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSAMLIdentityProviderCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSAMLIdentityProviderCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSAMLIdentityProviderCertificateResponse
        /// </returns>
        public DeleteSAMLIdentityProviderCertificateResponse DeleteSAMLIdentityProviderCertificate(DeleteSAMLIdentityProviderCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSAMLIdentityProviderCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSAMLIdentityProviderCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSAMLIdentityProviderCertificateResponse
        /// </returns>
        public async Task<DeleteSAMLIdentityProviderCertificateResponse> DeleteSAMLIdentityProviderCertificateAsync(DeleteSAMLIdentityProviderCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSAMLIdentityProviderCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个指定的凭证库。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTokenVaultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTokenVaultResponse
        /// </returns>
        public DeleteTokenVaultResponse DeleteTokenVaultWithOptions(DeleteTokenVaultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTokenVault",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTokenVaultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个指定的凭证库。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTokenVaultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTokenVaultResponse
        /// </returns>
        public async Task<DeleteTokenVaultResponse> DeleteTokenVaultWithOptionsAsync(DeleteTokenVaultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTokenVault",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTokenVaultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个指定的凭证库。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTokenVaultRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTokenVaultResponse
        /// </returns>
        public DeleteTokenVaultResponse DeleteTokenVault(DeleteTokenVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTokenVaultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除一个指定的凭证库。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTokenVaultRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTokenVaultResponse
        /// </returns>
        public async Task<DeleteTokenVaultResponse> DeleteTokenVaultAsync(DeleteTokenVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTokenVaultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除User</para>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2025-09-01",
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
        /// <para>删除User</para>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2025-09-01",
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
        /// <para>删除User</para>
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
        /// <para>删除User</para>
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
        /// <para>删除UserPool</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserPoolResponse
        /// </returns>
        public DeleteUserPoolResponse DeleteUserPoolWithOptions(DeleteUserPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserPool",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserPoolResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除UserPool</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserPoolResponse
        /// </returns>
        public async Task<DeleteUserPoolResponse> DeleteUserPoolWithOptionsAsync(DeleteUserPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserPool",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除UserPool</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserPoolResponse
        /// </returns>
        public DeleteUserPoolResponse DeleteUserPool(DeleteUserPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserPoolWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除UserPool</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserPoolResponse
        /// </returns>
        public async Task<DeleteUserPoolResponse> DeleteUserPoolAsync(DeleteUserPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserPoolWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserPoolClientRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserPoolClientResponse
        /// </returns>
        public DeleteUserPoolClientResponse DeleteUserPoolClientWithOptions(DeleteUserPoolClientRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientName))
            {
                body["ClientName"] = request.ClientName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserPoolClient",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserPoolClientResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserPoolClientRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserPoolClientResponse
        /// </returns>
        public async Task<DeleteUserPoolClientResponse> DeleteUserPoolClientWithOptionsAsync(DeleteUserPoolClientRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientName))
            {
                body["ClientName"] = request.ClientName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserPoolClient",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserPoolClientResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserPoolClientRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserPoolClientResponse
        /// </returns>
        public DeleteUserPoolClientResponse DeleteUserPoolClient(DeleteUserPoolClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserPoolClientWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserPoolClientRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserPoolClientResponse
        /// </returns>
        public async Task<DeleteUserPoolClientResponse> DeleteUserPoolClientAsync(DeleteUserPoolClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserPoolClientWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkloadIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkloadIdentityResponse
        /// </returns>
        public DeleteWorkloadIdentityResponse DeleteWorkloadIdentityWithOptions(DeleteWorkloadIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkloadIdentityName))
            {
                body["WorkloadIdentityName"] = request.WorkloadIdentityName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkloadIdentity",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkloadIdentityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkloadIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkloadIdentityResponse
        /// </returns>
        public async Task<DeleteWorkloadIdentityResponse> DeleteWorkloadIdentityWithOptionsAsync(DeleteWorkloadIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkloadIdentityName))
            {
                body["WorkloadIdentityName"] = request.WorkloadIdentityName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkloadIdentity",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkloadIdentityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkloadIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkloadIdentityResponse
        /// </returns>
        public DeleteWorkloadIdentityResponse DeleteWorkloadIdentity(DeleteWorkloadIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWorkloadIdentityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkloadIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkloadIdentityResponse
        /// </returns>
        public async Task<DeleteWorkloadIdentityResponse> DeleteWorkloadIdentityAsync(DeleteWorkloadIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWorkloadIdentityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>网关取消关联策略集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetachPolicySetFromGatewayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachPolicySetFromGatewayResponse
        /// </returns>
        public DetachPolicySetFromGatewayResponse DetachPolicySetFromGatewayWithOptions(DetachPolicySetFromGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayArn))
            {
                body["GatewayArn"] = request.GatewayArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                body["GatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachPolicySetFromGateway",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachPolicySetFromGatewayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>网关取消关联策略集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetachPolicySetFromGatewayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachPolicySetFromGatewayResponse
        /// </returns>
        public async Task<DetachPolicySetFromGatewayResponse> DetachPolicySetFromGatewayWithOptionsAsync(DetachPolicySetFromGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayArn))
            {
                body["GatewayArn"] = request.GatewayArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                body["GatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachPolicySetFromGateway",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachPolicySetFromGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>网关取消关联策略集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetachPolicySetFromGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachPolicySetFromGatewayResponse
        /// </returns>
        public DetachPolicySetFromGatewayResponse DetachPolicySetFromGateway(DetachPolicySetFromGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachPolicySetFromGatewayWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>网关取消关联策略集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetachPolicySetFromGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachPolicySetFromGatewayResponse
        /// </returns>
        public async Task<DetachPolicySetFromGatewayResponse> DetachPolicySetFromGatewayAsync(DetachPolicySetFromGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachPolicySetFromGatewayWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一个 API 密钥凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAPIKeyCredentialProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAPIKeyCredentialProviderResponse
        /// </returns>
        public GetAPIKeyCredentialProviderResponse GetAPIKeyCredentialProviderWithOptions(GetAPIKeyCredentialProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKeyCredentialProviderName))
            {
                body["APIKeyCredentialProviderName"] = request.APIKeyCredentialProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAPIKeyCredentialProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAPIKeyCredentialProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一个 API 密钥凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAPIKeyCredentialProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAPIKeyCredentialProviderResponse
        /// </returns>
        public async Task<GetAPIKeyCredentialProviderResponse> GetAPIKeyCredentialProviderWithOptionsAsync(GetAPIKeyCredentialProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKeyCredentialProviderName))
            {
                body["APIKeyCredentialProviderName"] = request.APIKeyCredentialProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAPIKeyCredentialProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAPIKeyCredentialProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一个 API 密钥凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAPIKeyCredentialProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAPIKeyCredentialProviderResponse
        /// </returns>
        public GetAPIKeyCredentialProviderResponse GetAPIKeyCredentialProvider(GetAPIKeyCredentialProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAPIKeyCredentialProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一个 API 密钥凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAPIKeyCredentialProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAPIKeyCredentialProviderResponse
        /// </returns>
        public async Task<GetAPIKeyCredentialProviderResponse> GetAPIKeyCredentialProviderAsync(GetAPIKeyCredentialProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAPIKeyCredentialProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询网关策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGatewayPolicyConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGatewayPolicyConfigResponse
        /// </returns>
        public GetGatewayPolicyConfigResponse GetGatewayPolicyConfigWithOptions(GetGatewayPolicyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayArn))
            {
                body["GatewayArn"] = request.GatewayArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                body["GatewayType"] = request.GatewayType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGatewayPolicyConfig",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGatewayPolicyConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询网关策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGatewayPolicyConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGatewayPolicyConfigResponse
        /// </returns>
        public async Task<GetGatewayPolicyConfigResponse> GetGatewayPolicyConfigWithOptionsAsync(GetGatewayPolicyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayArn))
            {
                body["GatewayArn"] = request.GatewayArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                body["GatewayType"] = request.GatewayType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGatewayPolicyConfig",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGatewayPolicyConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询网关策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGatewayPolicyConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGatewayPolicyConfigResponse
        /// </returns>
        public GetGatewayPolicyConfigResponse GetGatewayPolicyConfig(GetGatewayPolicyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGatewayPolicyConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询网关策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGatewayPolicyConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGatewayPolicyConfigResponse
        /// </returns>
        public async Task<GetGatewayPolicyConfigResponse> GetGatewayPolicyConfigAsync(GetGatewayPolicyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGatewayPolicyConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderName))
            {
                body["IdentityProviderName"] = request.IdentityProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIdentityProvider",
                Version = "2025-09-01",
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
        /// <para>创建应用</para>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderName))
            {
                body["IdentityProviderName"] = request.IdentityProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIdentityProvider",
                Version = "2025-09-01",
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
        /// <para>创建应用</para>
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
        /// <para>创建应用</para>
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
        /// <para>获取用户池登录相关配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoginPreferenceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLoginPreferenceResponse
        /// </returns>
        public GetLoginPreferenceResponse GetLoginPreferenceWithOptions(GetLoginPreferenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLoginPreference",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoginPreferenceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户池登录相关配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoginPreferenceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLoginPreferenceResponse
        /// </returns>
        public async Task<GetLoginPreferenceResponse> GetLoginPreferenceWithOptionsAsync(GetLoginPreferenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLoginPreference",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoginPreferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户池登录相关配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoginPreferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLoginPreferenceResponse
        /// </returns>
        public GetLoginPreferenceResponse GetLoginPreference(GetLoginPreferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLoginPreferenceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户池登录相关配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoginPreferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLoginPreferenceResponse
        /// </returns>
        public async Task<GetLoginPreferenceResponse> GetLoginPreferenceAsync(GetLoginPreferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLoginPreferenceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 OAuth2 凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOAuth2CredentialProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOAuth2CredentialProviderResponse
        /// </returns>
        public GetOAuth2CredentialProviderResponse GetOAuth2CredentialProviderWithOptions(GetOAuth2CredentialProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OAuth2CredentialProviderName))
            {
                body["OAuth2CredentialProviderName"] = request.OAuth2CredentialProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOAuth2CredentialProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOAuth2CredentialProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 OAuth2 凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOAuth2CredentialProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOAuth2CredentialProviderResponse
        /// </returns>
        public async Task<GetOAuth2CredentialProviderResponse> GetOAuth2CredentialProviderWithOptionsAsync(GetOAuth2CredentialProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OAuth2CredentialProviderName))
            {
                body["OAuth2CredentialProviderName"] = request.OAuth2CredentialProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOAuth2CredentialProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOAuth2CredentialProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 OAuth2 凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOAuth2CredentialProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOAuth2CredentialProviderResponse
        /// </returns>
        public GetOAuth2CredentialProviderResponse GetOAuth2CredentialProvider(GetOAuth2CredentialProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOAuth2CredentialProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 OAuth2 凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOAuth2CredentialProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOAuth2CredentialProviderResponse
        /// </returns>
        public async Task<GetOAuth2CredentialProviderResponse> GetOAuth2CredentialProviderAsync(GetOAuth2CredentialProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOAuth2CredentialProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一个 权限策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPolicyResponse
        /// </returns>
        public GetPolicyResponse GetPolicyWithOptions(GetPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                body["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPolicy",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一个 权限策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPolicyResponse
        /// </returns>
        public async Task<GetPolicyResponse> GetPolicyWithOptionsAsync(GetPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                body["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPolicy",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一个 权限策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPolicyResponse
        /// </returns>
        public GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一个 权限策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPolicyResponse
        /// </returns>
        public async Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一个 权限策略集合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPolicySetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPolicySetResponse
        /// </returns>
        public GetPolicySetResponse GetPolicySetWithOptions(GetPolicySetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPolicySet",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPolicySetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一个 权限策略集合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPolicySetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPolicySetResponse
        /// </returns>
        public async Task<GetPolicySetResponse> GetPolicySetWithOptionsAsync(GetPolicySetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPolicySet",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPolicySetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一个 权限策略集合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPolicySetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPolicySetResponse
        /// </returns>
        public GetPolicySetResponse GetPolicySet(GetPolicySetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPolicySetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一个 权限策略集合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPolicySetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPolicySetResponse
        /// </returns>
        public async Task<GetPolicySetResponse> GetPolicySetAsync(GetPolicySetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPolicySetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Role</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRoleResponse
        /// </returns>
        public GetRoleResponse GetRoleWithOptions(GetRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRole",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Role</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRoleResponse
        /// </returns>
        public async Task<GetRoleResponse> GetRoleWithOptionsAsync(GetRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRole",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Role</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRoleResponse
        /// </returns>
        public GetRoleResponse GetRole(GetRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRoleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Role</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRoleResponse
        /// </returns>
        public async Task<GetRoleResponse> GetRoleAsync(GetRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRoleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSAMLIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSAMLIdentityProviderResponse
        /// </returns>
        public GetSAMLIdentityProviderResponse GetSAMLIdentityProviderWithOptions(GetSAMLIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSAMLIdentityProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSAMLIdentityProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSAMLIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSAMLIdentityProviderResponse
        /// </returns>
        public async Task<GetSAMLIdentityProviderResponse> GetSAMLIdentityProviderWithOptionsAsync(GetSAMLIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSAMLIdentityProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSAMLIdentityProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSAMLIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSAMLIdentityProviderResponse
        /// </returns>
        public GetSAMLIdentityProviderResponse GetSAMLIdentityProvider(GetSAMLIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSAMLIdentityProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSAMLIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSAMLIdentityProviderResponse
        /// </returns>
        public async Task<GetSAMLIdentityProviderResponse> GetSAMLIdentityProviderAsync(GetSAMLIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSAMLIdentityProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSAMLServiceProviderInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSAMLServiceProviderInfoResponse
        /// </returns>
        public GetSAMLServiceProviderInfoResponse GetSAMLServiceProviderInfoWithOptions(GetSAMLServiceProviderInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSAMLServiceProviderInfo",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSAMLServiceProviderInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSAMLServiceProviderInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSAMLServiceProviderInfoResponse
        /// </returns>
        public async Task<GetSAMLServiceProviderInfoResponse> GetSAMLServiceProviderInfoWithOptionsAsync(GetSAMLServiceProviderInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSAMLServiceProviderInfo",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSAMLServiceProviderInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSAMLServiceProviderInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSAMLServiceProviderInfoResponse
        /// </returns>
        public GetSAMLServiceProviderInfoResponse GetSAMLServiceProviderInfo(GetSAMLServiceProviderInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSAMLServiceProviderInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSAMLServiceProviderInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSAMLServiceProviderInfoResponse
        /// </returns>
        public async Task<GetSAMLServiceProviderInfoResponse> GetSAMLServiceProviderInfoAsync(GetSAMLServiceProviderInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSAMLServiceProviderInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定的身份提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpecificIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSpecificIdentityProviderResponse
        /// </returns>
        public GetSpecificIdentityProviderResponse GetSpecificIdentityProviderWithOptions(GetSpecificIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderType))
            {
                body["IdentityProviderType"] = request.IdentityProviderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSpecificIdentityProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpecificIdentityProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定的身份提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpecificIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSpecificIdentityProviderResponse
        /// </returns>
        public async Task<GetSpecificIdentityProviderResponse> GetSpecificIdentityProviderWithOptionsAsync(GetSpecificIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderType))
            {
                body["IdentityProviderType"] = request.IdentityProviderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSpecificIdentityProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpecificIdentityProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定的身份提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpecificIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSpecificIdentityProviderResponse
        /// </returns>
        public GetSpecificIdentityProviderResponse GetSpecificIdentityProvider(GetSpecificIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSpecificIdentityProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定的身份提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSpecificIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSpecificIdentityProviderResponse
        /// </returns>
        public async Task<GetSpecificIdentityProviderResponse> GetSpecificIdentityProviderAsync(GetSpecificIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSpecificIdentityProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定凭证库的详细配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenVaultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenVaultResponse
        /// </returns>
        public GetTokenVaultResponse GetTokenVaultWithOptions(GetTokenVaultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTokenVault",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenVaultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定凭证库的详细配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenVaultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenVaultResponse
        /// </returns>
        public async Task<GetTokenVaultResponse> GetTokenVaultWithOptionsAsync(GetTokenVaultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTokenVault",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenVaultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定凭证库的详细配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenVaultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenVaultResponse
        /// </returns>
        public GetTokenVaultResponse GetTokenVault(GetTokenVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTokenVaultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定凭证库的详细配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenVaultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenVaultResponse
        /// </returns>
        public async Task<GetTokenVaultResponse> GetTokenVaultAsync(GetTokenVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTokenVaultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户</para>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2025-09-01",
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
        /// <para>获取用户</para>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2025-09-01",
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
        /// <para>获取用户</para>
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
        /// <para>获取用户</para>
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
        /// <para>获取UserPool</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserPoolResponse
        /// </returns>
        public GetUserPoolResponse GetUserPoolWithOptions(GetUserPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserPool",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserPoolResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取UserPool</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserPoolResponse
        /// </returns>
        public async Task<GetUserPoolResponse> GetUserPoolWithOptionsAsync(GetUserPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserPool",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取UserPool</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserPoolResponse
        /// </returns>
        public GetUserPoolResponse GetUserPool(GetUserPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserPoolWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取UserPool</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserPoolResponse
        /// </returns>
        public async Task<GetUserPoolResponse> GetUserPoolAsync(GetUserPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserPoolWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserPoolClientRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserPoolClientResponse
        /// </returns>
        public GetUserPoolClientResponse GetUserPoolClientWithOptions(GetUserPoolClientRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientName))
            {
                body["ClientName"] = request.ClientName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserPoolClient",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserPoolClientResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserPoolClientRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserPoolClientResponse
        /// </returns>
        public async Task<GetUserPoolClientResponse> GetUserPoolClientWithOptionsAsync(GetUserPoolClientRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientName))
            {
                body["ClientName"] = request.ClientName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserPoolClient",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserPoolClientResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserPoolClientRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserPoolClientResponse
        /// </returns>
        public GetUserPoolClientResponse GetUserPoolClient(GetUserPoolClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserPoolClientWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserPoolClientRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserPoolClientResponse
        /// </returns>
        public async Task<GetUserPoolClientResponse> GetUserPoolClientAsync(GetUserPoolClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserPoolClientWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取UserPool</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserPoolSyncJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserPoolSyncJobResponse
        /// </returns>
        public GetUserPoolSyncJobResponse GetUserPoolSyncJobWithOptions(GetUserPoolSyncJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                body["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserPoolSyncJob",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserPoolSyncJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取UserPool</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserPoolSyncJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserPoolSyncJobResponse
        /// </returns>
        public async Task<GetUserPoolSyncJobResponse> GetUserPoolSyncJobWithOptionsAsync(GetUserPoolSyncJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizationJobId))
            {
                body["SynchronizationJobId"] = request.SynchronizationJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserPoolSyncJob",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserPoolSyncJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取UserPool</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserPoolSyncJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserPoolSyncJobResponse
        /// </returns>
        public GetUserPoolSyncJobResponse GetUserPoolSyncJob(GetUserPoolSyncJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserPoolSyncJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取UserPool</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserPoolSyncJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserPoolSyncJobResponse
        /// </returns>
        public async Task<GetUserPoolSyncJobResponse> GetUserPoolSyncJobAsync(GetUserPoolSyncJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserPoolSyncJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkloadIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkloadIdentityResponse
        /// </returns>
        public GetWorkloadIdentityResponse GetWorkloadIdentityWithOptions(GetWorkloadIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkloadIdentityName))
            {
                body["WorkloadIdentityName"] = request.WorkloadIdentityName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkloadIdentity",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkloadIdentityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkloadIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkloadIdentityResponse
        /// </returns>
        public async Task<GetWorkloadIdentityResponse> GetWorkloadIdentityWithOptionsAsync(GetWorkloadIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkloadIdentityName))
            {
                body["WorkloadIdentityName"] = request.WorkloadIdentityName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkloadIdentity",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkloadIdentityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkloadIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkloadIdentityResponse
        /// </returns>
        public GetWorkloadIdentityResponse GetWorkloadIdentity(GetWorkloadIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkloadIdentityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkloadIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkloadIdentityResponse
        /// </returns>
        public async Task<GetWorkloadIdentityResponse> GetWorkloadIdentityAsync(GetWorkloadIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkloadIdentityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出 API 密钥凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAPIKeyCredentialProvidersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAPIKeyCredentialProvidersResponse
        /// </returns>
        public ListAPIKeyCredentialProvidersResponse ListAPIKeyCredentialProvidersWithOptions(ListAPIKeyCredentialProvidersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAPIKeyCredentialProviders",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAPIKeyCredentialProvidersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出 API 密钥凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAPIKeyCredentialProvidersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAPIKeyCredentialProvidersResponse
        /// </returns>
        public async Task<ListAPIKeyCredentialProvidersResponse> ListAPIKeyCredentialProvidersWithOptionsAsync(ListAPIKeyCredentialProvidersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAPIKeyCredentialProviders",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAPIKeyCredentialProvidersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出 API 密钥凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAPIKeyCredentialProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAPIKeyCredentialProvidersResponse
        /// </returns>
        public ListAPIKeyCredentialProvidersResponse ListAPIKeyCredentialProviders(ListAPIKeyCredentialProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAPIKeyCredentialProvidersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出 API 密钥凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAPIKeyCredentialProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAPIKeyCredentialProvidersResponse
        /// </returns>
        public async Task<ListAPIKeyCredentialProvidersResponse> ListAPIKeyCredentialProvidersAsync(ListAPIKeyCredentialProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAPIKeyCredentialProvidersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClientSecretsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClientSecretsResponse
        /// </returns>
        public ListClientSecretsResponse ListClientSecretsWithOptions(ListClientSecretsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientName))
            {
                body["ClientName"] = request.ClientName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClientSecrets",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClientSecretsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClientSecretsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClientSecretsResponse
        /// </returns>
        public async Task<ListClientSecretsResponse> ListClientSecretsWithOptionsAsync(ListClientSecretsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientName))
            {
                body["ClientName"] = request.ClientName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClientSecrets",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClientSecretsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClientSecretsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListClientSecretsResponse
        /// </returns>
        public ListClientSecretsResponse ListClientSecrets(ListClientSecretsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClientSecretsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClientSecretsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListClientSecretsResponse
        /// </returns>
        public async Task<ListClientSecretsResponse> ListClientSecretsAsync(ListClientSecretsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClientSecretsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIdentityProviders",
                Version = "2025-09-01",
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
        /// <para>列出IdentityProvider</para>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIdentityProviders",
                Version = "2025-09-01",
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
        /// <para>列出IdentityProvider</para>
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
        /// <para>列出IdentityProvider</para>
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
        /// <para>列出 OAuth2 凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOAuth2CredentialProvidersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOAuth2CredentialProvidersResponse
        /// </returns>
        public ListOAuth2CredentialProvidersResponse ListOAuth2CredentialProvidersWithOptions(ListOAuth2CredentialProvidersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOAuth2CredentialProviders",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOAuth2CredentialProvidersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出 OAuth2 凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOAuth2CredentialProvidersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOAuth2CredentialProvidersResponse
        /// </returns>
        public async Task<ListOAuth2CredentialProvidersResponse> ListOAuth2CredentialProvidersWithOptionsAsync(ListOAuth2CredentialProvidersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOAuth2CredentialProviders",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOAuth2CredentialProvidersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出 OAuth2 凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOAuth2CredentialProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOAuth2CredentialProvidersResponse
        /// </returns>
        public ListOAuth2CredentialProvidersResponse ListOAuth2CredentialProviders(ListOAuth2CredentialProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOAuth2CredentialProvidersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出 OAuth2 凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOAuth2CredentialProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOAuth2CredentialProvidersResponse
        /// </returns>
        public async Task<ListOAuth2CredentialProvidersResponse> ListOAuth2CredentialProvidersAsync(ListOAuth2CredentialProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOAuth2CredentialProvidersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出权限策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPoliciesResponse
        /// </returns>
        public ListPoliciesResponse ListPoliciesWithOptions(ListPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicies",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPoliciesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出权限策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPoliciesResponse
        /// </returns>
        public async Task<ListPoliciesResponse> ListPoliciesWithOptionsAsync(ListPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicies",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出权限策略</para>
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
            return ListPoliciesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出权限策略</para>
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
            return await ListPoliciesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出网关策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicySetAttachedGatewaysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPolicySetAttachedGatewaysResponse
        /// </returns>
        public ListPolicySetAttachedGatewaysResponse ListPolicySetAttachedGatewaysWithOptions(ListPolicySetAttachedGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                body["GatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicySetAttachedGateways",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPolicySetAttachedGatewaysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出网关策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicySetAttachedGatewaysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPolicySetAttachedGatewaysResponse
        /// </returns>
        public async Task<ListPolicySetAttachedGatewaysResponse> ListPolicySetAttachedGatewaysWithOptionsAsync(ListPolicySetAttachedGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                body["GatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicySetAttachedGateways",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPolicySetAttachedGatewaysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出网关策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicySetAttachedGatewaysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPolicySetAttachedGatewaysResponse
        /// </returns>
        public ListPolicySetAttachedGatewaysResponse ListPolicySetAttachedGateways(ListPolicySetAttachedGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPolicySetAttachedGatewaysWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出网关策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicySetAttachedGatewaysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPolicySetAttachedGatewaysResponse
        /// </returns>
        public async Task<ListPolicySetAttachedGatewaysResponse> ListPolicySetAttachedGatewaysAsync(ListPolicySetAttachedGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPolicySetAttachedGatewaysWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出权限策略集合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicySetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPolicySetsResponse
        /// </returns>
        public ListPolicySetsResponse ListPolicySetsWithOptions(ListPolicySetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicySets",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPolicySetsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出权限策略集合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicySetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPolicySetsResponse
        /// </returns>
        public async Task<ListPolicySetsResponse> ListPolicySetsWithOptionsAsync(ListPolicySetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicySets",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPolicySetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出权限策略集合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicySetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPolicySetsResponse
        /// </returns>
        public ListPolicySetsResponse ListPolicySets(ListPolicySetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPolicySetsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出权限策略集合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicySetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPolicySetsResponse
        /// </returns>
        public async Task<ListPolicySetsResponse> ListPolicySetsAsync(ListPolicySetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPolicySetsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出网关策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRoleAssignmentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRoleAssignmentsResponse
        /// </returns>
        public ListRoleAssignmentsResponse ListRoleAssignmentsWithOptions(ListRoleAssignmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                body["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalType))
            {
                body["PrincipalType"] = request.PrincipalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoleAssignments",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRoleAssignmentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出网关策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRoleAssignmentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRoleAssignmentsResponse
        /// </returns>
        public async Task<ListRoleAssignmentsResponse> ListRoleAssignmentsWithOptionsAsync(ListRoleAssignmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                body["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalType))
            {
                body["PrincipalType"] = request.PrincipalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoleAssignments",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRoleAssignmentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出网关策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRoleAssignmentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRoleAssignmentsResponse
        /// </returns>
        public ListRoleAssignmentsResponse ListRoleAssignments(ListRoleAssignmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRoleAssignmentsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出网关策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRoleAssignmentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRoleAssignmentsResponse
        /// </returns>
        public async Task<ListRoleAssignmentsResponse> ListRoleAssignmentsAsync(ListRoleAssignmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRoleAssignmentsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出Roles</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRolesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRolesResponse
        /// </returns>
        public ListRolesResponse ListRolesWithOptions(ListRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoles",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRolesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出Roles</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRolesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRolesResponse
        /// </returns>
        public async Task<ListRolesResponse> ListRolesWithOptionsAsync(ListRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoles",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出Roles</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRolesResponse
        /// </returns>
        public ListRolesResponse ListRoles(ListRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRolesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出Roles</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRolesResponse
        /// </returns>
        public async Task<ListRolesResponse> ListRolesAsync(ListRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRolesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSAMLIdentityProviderCertificatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSAMLIdentityProviderCertificatesResponse
        /// </returns>
        public ListSAMLIdentityProviderCertificatesResponse ListSAMLIdentityProviderCertificatesWithOptions(ListSAMLIdentityProviderCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSAMLIdentityProviderCertificates",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSAMLIdentityProviderCertificatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSAMLIdentityProviderCertificatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSAMLIdentityProviderCertificatesResponse
        /// </returns>
        public async Task<ListSAMLIdentityProviderCertificatesResponse> ListSAMLIdentityProviderCertificatesWithOptionsAsync(ListSAMLIdentityProviderCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSAMLIdentityProviderCertificates",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSAMLIdentityProviderCertificatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSAMLIdentityProviderCertificatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSAMLIdentityProviderCertificatesResponse
        /// </returns>
        public ListSAMLIdentityProviderCertificatesResponse ListSAMLIdentityProviderCertificates(ListSAMLIdentityProviderCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSAMLIdentityProviderCertificatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSAMLIdentityProviderCertificatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSAMLIdentityProviderCertificatesResponse
        /// </returns>
        public async Task<ListSAMLIdentityProviderCertificatesResponse> ListSAMLIdentityProviderCertificatesAsync(ListSAMLIdentityProviderCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSAMLIdentityProviderCertificatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页列出账户下所有的 API 密钥凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTokenVaultsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTokenVaultsResponse
        /// </returns>
        public ListTokenVaultsResponse ListTokenVaultsWithOptions(ListTokenVaultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTokenVaults",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTokenVaultsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页列出账户下所有的 API 密钥凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTokenVaultsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTokenVaultsResponse
        /// </returns>
        public async Task<ListTokenVaultsResponse> ListTokenVaultsWithOptionsAsync(ListTokenVaultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTokenVaults",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTokenVaultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页列出账户下所有的 API 密钥凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTokenVaultsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTokenVaultsResponse
        /// </returns>
        public ListTokenVaultsResponse ListTokenVaults(ListTokenVaultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTokenVaultsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页列出账户下所有的 API 密钥凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTokenVaultsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTokenVaultsResponse
        /// </returns>
        public async Task<ListTokenVaultsResponse> ListTokenVaultsAsync(ListTokenVaultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTokenVaultsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserPoolClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserPoolClientsResponse
        /// </returns>
        public ListUserPoolClientsResponse ListUserPoolClientsWithOptions(ListUserPoolClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserPoolClients",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserPoolClientsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserPoolClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserPoolClientsResponse
        /// </returns>
        public async Task<ListUserPoolClientsResponse> ListUserPoolClientsWithOptionsAsync(ListUserPoolClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserPoolClients",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserPoolClientsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserPoolClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserPoolClientsResponse
        /// </returns>
        public ListUserPoolClientsResponse ListUserPoolClients(ListUserPoolClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserPoolClientsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserPoolClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserPoolClientsResponse
        /// </returns>
        public async Task<ListUserPoolClientsResponse> ListUserPoolClientsAsync(ListUserPoolClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserPoolClientsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserPoolSyncJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserPoolSyncJobsResponse
        /// </returns>
        public ListUserPoolSyncJobsResponse ListUserPoolSyncJobsWithOptions(ListUserPoolSyncJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserPoolSyncJobs",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserPoolSyncJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserPoolSyncJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserPoolSyncJobsResponse
        /// </returns>
        public async Task<ListUserPoolSyncJobsResponse> ListUserPoolSyncJobsWithOptionsAsync(ListUserPoolSyncJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserPoolSyncJobs",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserPoolSyncJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserPoolSyncJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserPoolSyncJobsResponse
        /// </returns>
        public ListUserPoolSyncJobsResponse ListUserPoolSyncJobs(ListUserPoolSyncJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserPoolSyncJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserPoolSyncJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserPoolSyncJobsResponse
        /// </returns>
        public async Task<ListUserPoolSyncJobsResponse> ListUserPoolSyncJobsAsync(ListUserPoolSyncJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserPoolSyncJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserPoolsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserPoolsResponse
        /// </returns>
        public ListUserPoolsResponse ListUserPoolsWithOptions(ListUserPoolsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserPools",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserPoolsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserPoolsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserPoolsResponse
        /// </returns>
        public async Task<ListUserPoolsResponse> ListUserPoolsWithOptionsAsync(ListUserPoolsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserPools",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserPoolsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserPoolsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserPoolsResponse
        /// </returns>
        public ListUserPoolsResponse ListUserPools(ListUserPoolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserPoolsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserPoolsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserPoolsResponse
        /// </returns>
        public async Task<ListUserPoolsResponse> ListUserPoolsAsync(ListUserPoolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserPoolsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出用户</para>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2025-09-01",
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
        /// <para>列出用户</para>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2025-09-01",
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
        /// <para>列出用户</para>
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
        /// <para>列出用户</para>
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
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkloadIdentitiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkloadIdentitiesResponse
        /// </returns>
        public ListWorkloadIdentitiesResponse ListWorkloadIdentitiesWithOptions(ListWorkloadIdentitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkloadIdentities",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkloadIdentitiesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkloadIdentitiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkloadIdentitiesResponse
        /// </returns>
        public async Task<ListWorkloadIdentitiesResponse> ListWorkloadIdentitiesWithOptionsAsync(ListWorkloadIdentitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkloadIdentities",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkloadIdentitiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkloadIdentitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkloadIdentitiesResponse
        /// </returns>
        public ListWorkloadIdentitiesResponse ListWorkloadIdentities(ListWorkloadIdentitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWorkloadIdentitiesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkloadIdentitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkloadIdentitiesResponse
        /// </returns>
        public async Task<ListWorkloadIdentitiesResponse> ListWorkloadIdentitiesAsync(ListWorkloadIdentitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWorkloadIdentitiesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建UserPool</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunUserPoolSyncJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunUserPoolSyncJobResponse
        /// </returns>
        public RunUserPoolSyncJobResponse RunUserPoolSyncJobWithOptions(RunUserPoolSyncJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderType))
            {
                body["IdentityProviderType"] = request.IdentityProviderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSyncUsers))
            {
                body["MaxSyncUsers"] = request.MaxSyncUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunUserPoolSyncJob",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunUserPoolSyncJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建UserPool</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunUserPoolSyncJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunUserPoolSyncJobResponse
        /// </returns>
        public async Task<RunUserPoolSyncJobResponse> RunUserPoolSyncJobWithOptionsAsync(RunUserPoolSyncJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderType))
            {
                body["IdentityProviderType"] = request.IdentityProviderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSyncUsers))
            {
                body["MaxSyncUsers"] = request.MaxSyncUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunUserPoolSyncJob",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunUserPoolSyncJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建UserPool</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunUserPoolSyncJobRequest
        /// </param>
        /// 
        /// <returns>
        /// RunUserPoolSyncJobResponse
        /// </returns>
        public RunUserPoolSyncJobResponse RunUserPoolSyncJob(RunUserPoolSyncJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunUserPoolSyncJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建UserPool</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunUserPoolSyncJobRequest
        /// </param>
        /// 
        /// <returns>
        /// RunUserPoolSyncJobResponse
        /// </returns>
        public async Task<RunUserPoolSyncJobResponse> RunUserPoolSyncJobAsync(RunUserPoolSyncJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunUserPoolSyncJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SetSAMLIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetSAMLIdentityProviderResponse
        /// </returns>
        public SetSAMLIdentityProviderResponse SetSAMLIdentityProviderWithOptions(SetSAMLIdentityProviderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetSAMLIdentityProviderShrinkRequest request = new SetSAMLIdentityProviderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.X509Certificates))
            {
                request.X509CertificatesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.X509Certificates, "X509Certificates", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                body["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JITProvisionStatus))
            {
                body["JITProvisionStatus"] = request.JITProvisionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JITUpdateStatus))
            {
                body["JITUpdateStatus"] = request.JITUpdateStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginURL))
            {
                body["LoginURL"] = request.LoginURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SAMLBindingType))
            {
                body["SAMLBindingType"] = request.SAMLBindingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSOStatus))
            {
                body["SSOStatus"] = request.SSOStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.X509CertificatesShrink))
            {
                body["X509Certificates"] = request.X509CertificatesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSAMLIdentityProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSAMLIdentityProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SetSAMLIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetSAMLIdentityProviderResponse
        /// </returns>
        public async Task<SetSAMLIdentityProviderResponse> SetSAMLIdentityProviderWithOptionsAsync(SetSAMLIdentityProviderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetSAMLIdentityProviderShrinkRequest request = new SetSAMLIdentityProviderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.X509Certificates))
            {
                request.X509CertificatesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.X509Certificates, "X509Certificates", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                body["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JITProvisionStatus))
            {
                body["JITProvisionStatus"] = request.JITProvisionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JITUpdateStatus))
            {
                body["JITUpdateStatus"] = request.JITUpdateStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginURL))
            {
                body["LoginURL"] = request.LoginURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SAMLBindingType))
            {
                body["SAMLBindingType"] = request.SAMLBindingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSOStatus))
            {
                body["SSOStatus"] = request.SSOStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.X509CertificatesShrink))
            {
                body["X509Certificates"] = request.X509CertificatesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSAMLIdentityProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSAMLIdentityProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSAMLIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// SetSAMLIdentityProviderResponse
        /// </returns>
        public SetSAMLIdentityProviderResponse SetSAMLIdentityProvider(SetSAMLIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetSAMLIdentityProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建WorkloadIdentity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSAMLIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// SetSAMLIdentityProviderResponse
        /// </returns>
        public async Task<SetSAMLIdentityProviderResponse> SetSAMLIdentityProviderAsync(SetSAMLIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetSAMLIdentityProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用IdP配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSpecificIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetSpecificIdentityProviderResponse
        /// </returns>
        public SetSpecificIdentityProviderResponse SetSpecificIdentityProviderWithOptions(SetSpecificIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IDPMetadata))
            {
                body["IDPMetadata"] = request.IDPMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderType))
            {
                body["IdentityProviderType"] = request.IdentityProviderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSOStatus))
            {
                body["SSOStatus"] = request.SSOStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSpecificIdentityProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSpecificIdentityProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用IdP配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSpecificIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetSpecificIdentityProviderResponse
        /// </returns>
        public async Task<SetSpecificIdentityProviderResponse> SetSpecificIdentityProviderWithOptionsAsync(SetSpecificIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IDPMetadata))
            {
                body["IDPMetadata"] = request.IDPMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderType))
            {
                body["IdentityProviderType"] = request.IdentityProviderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSOStatus))
            {
                body["SSOStatus"] = request.SSOStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSpecificIdentityProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSpecificIdentityProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用IdP配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSpecificIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// SetSpecificIdentityProviderResponse
        /// </returns>
        public SetSpecificIdentityProviderResponse SetSpecificIdentityProvider(SetSpecificIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetSpecificIdentityProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用IdP配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSpecificIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// SetSpecificIdentityProviderResponse
        /// </returns>
        public async Task<SetSpecificIdentityProviderResponse> SetSpecificIdentityProviderAsync(SetSpecificIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetSpecificIdentityProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改用户登录密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetUserPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetUserPasswordResponse
        /// </returns>
        public SetUserPasswordResponse SetUserPasswordWithOptions(SetUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateRandomPassword))
            {
                body["GenerateRandomPassword"] = request.GenerateRandomPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetUserPassword",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetUserPasswordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改用户登录密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetUserPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetUserPasswordResponse
        /// </returns>
        public async Task<SetUserPasswordResponse> SetUserPasswordWithOptionsAsync(SetUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateRandomPassword))
            {
                body["GenerateRandomPassword"] = request.GenerateRandomPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetUserPassword",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetUserPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改用户登录密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetUserPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// SetUserPasswordResponse
        /// </returns>
        public SetUserPasswordResponse SetUserPassword(SetUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetUserPasswordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改用户登录密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetUserPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// SetUserPasswordResponse
        /// </returns>
        public async Task<SetUserPasswordResponse> SetUserPasswordAsync(SetUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetUserPasswordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新一个 API 密钥凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAPIKeyCredentialProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAPIKeyCredentialProviderResponse
        /// </returns>
        public UpdateAPIKeyCredentialProviderResponse UpdateAPIKeyCredentialProviderWithOptions(UpdateAPIKeyCredentialProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKey))
            {
                body["APIKey"] = request.APIKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKeyCredentialProviderName))
            {
                body["APIKeyCredentialProviderName"] = request.APIKeyCredentialProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAPIKeyCredentialProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAPIKeyCredentialProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新一个 API 密钥凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAPIKeyCredentialProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAPIKeyCredentialProviderResponse
        /// </returns>
        public async Task<UpdateAPIKeyCredentialProviderResponse> UpdateAPIKeyCredentialProviderWithOptionsAsync(UpdateAPIKeyCredentialProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKey))
            {
                body["APIKey"] = request.APIKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKeyCredentialProviderName))
            {
                body["APIKeyCredentialProviderName"] = request.APIKeyCredentialProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAPIKeyCredentialProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAPIKeyCredentialProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新一个 API 密钥凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAPIKeyCredentialProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAPIKeyCredentialProviderResponse
        /// </returns>
        public UpdateAPIKeyCredentialProviderResponse UpdateAPIKeyCredentialProvider(UpdateAPIKeyCredentialProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAPIKeyCredentialProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新一个 API 密钥凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAPIKeyCredentialProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAPIKeyCredentialProviderResponse
        /// </returns>
        public async Task<UpdateAPIKeyCredentialProviderResponse> UpdateAPIKeyCredentialProviderAsync(UpdateAPIKeyCredentialProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAPIKeyCredentialProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询网关策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGatewayPolicyConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGatewayPolicyConfigResponse
        /// </returns>
        public UpdateGatewayPolicyConfigResponse UpdateGatewayPolicyConfigWithOptions(UpdateGatewayPolicyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnforcementMode))
            {
                body["EnforcementMode"] = request.EnforcementMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayArn))
            {
                body["GatewayArn"] = request.GatewayArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                body["GatewayType"] = request.GatewayType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGatewayPolicyConfig",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGatewayPolicyConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询网关策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGatewayPolicyConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGatewayPolicyConfigResponse
        /// </returns>
        public async Task<UpdateGatewayPolicyConfigResponse> UpdateGatewayPolicyConfigWithOptionsAsync(UpdateGatewayPolicyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnforcementMode))
            {
                body["EnforcementMode"] = request.EnforcementMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayArn))
            {
                body["GatewayArn"] = request.GatewayArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                body["GatewayType"] = request.GatewayType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGatewayPolicyConfig",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGatewayPolicyConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询网关策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGatewayPolicyConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGatewayPolicyConfigResponse
        /// </returns>
        public UpdateGatewayPolicyConfigResponse UpdateGatewayPolicyConfig(UpdateGatewayPolicyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGatewayPolicyConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询网关策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGatewayPolicyConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGatewayPolicyConfigResponse
        /// </returns>
        public async Task<UpdateGatewayPolicyConfigResponse> UpdateGatewayPolicyConfigAsync(UpdateGatewayPolicyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGatewayPolicyConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIdentityProviderResponse
        /// </returns>
        public UpdateIdentityProviderResponse UpdateIdentityProviderWithOptions(UpdateIdentityProviderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateIdentityProviderShrinkRequest request = new UpdateIdentityProviderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AllowedAudience))
            {
                request.AllowedAudienceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AllowedAudience, "AllowedAudience", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedAudienceShrink))
            {
                body["AllowedAudience"] = request.AllowedAudienceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoveryURL))
            {
                body["DiscoveryURL"] = request.DiscoveryURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderName))
            {
                body["IdentityProviderName"] = request.IdentityProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIdentityProvider",
                Version = "2025-09-01",
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
        /// <para>更新IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIdentityProviderResponse
        /// </returns>
        public async Task<UpdateIdentityProviderResponse> UpdateIdentityProviderWithOptionsAsync(UpdateIdentityProviderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateIdentityProviderShrinkRequest request = new UpdateIdentityProviderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AllowedAudience))
            {
                request.AllowedAudienceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AllowedAudience, "AllowedAudience", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedAudienceShrink))
            {
                body["AllowedAudience"] = request.AllowedAudienceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoveryURL))
            {
                body["DiscoveryURL"] = request.DiscoveryURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderName))
            {
                body["IdentityProviderName"] = request.IdentityProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIdentityProvider",
                Version = "2025-09-01",
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
        /// <para>更新IdentityProvider</para>
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
        /// <para>更新IdentityProvider</para>
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
        /// <para>更新用户池登录配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateLoginPreferenceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoginPreferenceResponse
        /// </returns>
        public UpdateLoginPreferenceResponse UpdateLoginPreferenceWithOptions(UpdateLoginPreferenceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateLoginPreferenceShrinkRequest request = new UpdateLoginPreferenceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LoginPreference))
            {
                request.LoginPreferenceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LoginPreference, "LoginPreference", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginPreferenceShrink))
            {
                query["LoginPreference"] = request.LoginPreferenceShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLoginPreference",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLoginPreferenceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新用户池登录配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateLoginPreferenceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoginPreferenceResponse
        /// </returns>
        public async Task<UpdateLoginPreferenceResponse> UpdateLoginPreferenceWithOptionsAsync(UpdateLoginPreferenceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateLoginPreferenceShrinkRequest request = new UpdateLoginPreferenceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LoginPreference))
            {
                request.LoginPreferenceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LoginPreference, "LoginPreference", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginPreferenceShrink))
            {
                query["LoginPreference"] = request.LoginPreferenceShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLoginPreference",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLoginPreferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新用户池登录配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLoginPreferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoginPreferenceResponse
        /// </returns>
        public UpdateLoginPreferenceResponse UpdateLoginPreference(UpdateLoginPreferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLoginPreferenceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新用户池登录配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLoginPreferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoginPreferenceResponse
        /// </returns>
        public async Task<UpdateLoginPreferenceResponse> UpdateLoginPreferenceAsync(UpdateLoginPreferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLoginPreferenceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改 OAuth2 凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateOAuth2CredentialProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOAuth2CredentialProviderResponse
        /// </returns>
        public UpdateOAuth2CredentialProviderResponse UpdateOAuth2CredentialProviderWithOptions(UpdateOAuth2CredentialProviderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateOAuth2CredentialProviderShrinkRequest request = new UpdateOAuth2CredentialProviderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OAuth2ProviderConfig))
            {
                request.OAuth2ProviderConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OAuth2ProviderConfig, "OAuth2ProviderConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackURL))
            {
                body["CallbackURL"] = request.CallbackURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialProviderVendor))
            {
                body["CredentialProviderVendor"] = request.CredentialProviderVendor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OAuth2CredentialProviderName))
            {
                body["OAuth2CredentialProviderName"] = request.OAuth2CredentialProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OAuth2ProviderConfigShrink))
            {
                body["OAuth2ProviderConfig"] = request.OAuth2ProviderConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOAuth2CredentialProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOAuth2CredentialProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改 OAuth2 凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateOAuth2CredentialProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOAuth2CredentialProviderResponse
        /// </returns>
        public async Task<UpdateOAuth2CredentialProviderResponse> UpdateOAuth2CredentialProviderWithOptionsAsync(UpdateOAuth2CredentialProviderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateOAuth2CredentialProviderShrinkRequest request = new UpdateOAuth2CredentialProviderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OAuth2ProviderConfig))
            {
                request.OAuth2ProviderConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OAuth2ProviderConfig, "OAuth2ProviderConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackURL))
            {
                body["CallbackURL"] = request.CallbackURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialProviderVendor))
            {
                body["CredentialProviderVendor"] = request.CredentialProviderVendor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OAuth2CredentialProviderName))
            {
                body["OAuth2CredentialProviderName"] = request.OAuth2CredentialProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OAuth2ProviderConfigShrink))
            {
                body["OAuth2ProviderConfig"] = request.OAuth2ProviderConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOAuth2CredentialProvider",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOAuth2CredentialProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改 OAuth2 凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOAuth2CredentialProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOAuth2CredentialProviderResponse
        /// </returns>
        public UpdateOAuth2CredentialProviderResponse UpdateOAuth2CredentialProvider(UpdateOAuth2CredentialProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateOAuth2CredentialProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改 OAuth2 凭证提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOAuth2CredentialProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOAuth2CredentialProviderResponse
        /// </returns>
        public async Task<UpdateOAuth2CredentialProviderResponse> UpdateOAuth2CredentialProviderAsync(UpdateOAuth2CredentialProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateOAuth2CredentialProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新一个权限策略</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdatePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyResponse
        /// </returns>
        public UpdatePolicyResponse UpdatePolicyWithOptions(UpdatePolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdatePolicyShrinkRequest request = new UpdatePolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Definition))
            {
                request.DefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Definition, "Definition", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefinitionShrink))
            {
                body["Definition"] = request.DefinitionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                body["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePolicy",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新一个权限策略</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdatePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyResponse
        /// </returns>
        public async Task<UpdatePolicyResponse> UpdatePolicyWithOptionsAsync(UpdatePolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdatePolicyShrinkRequest request = new UpdatePolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Definition))
            {
                request.DefinitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Definition, "Definition", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefinitionShrink))
            {
                body["Definition"] = request.DefinitionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                body["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePolicy",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新一个权限策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyResponse
        /// </returns>
        public UpdatePolicyResponse UpdatePolicy(UpdatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新一个权限策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyResponse
        /// </returns>
        public async Task<UpdatePolicyResponse> UpdatePolicyAsync(UpdatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新一个权限策略集合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePolicySetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicySetResponse
        /// </returns>
        public UpdatePolicySetResponse UpdatePolicySetWithOptions(UpdatePolicySetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePolicySet",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePolicySetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新一个权限策略集合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePolicySetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicySetResponse
        /// </returns>
        public async Task<UpdatePolicySetResponse> UpdatePolicySetWithOptionsAsync(UpdatePolicySetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicySetName))
            {
                body["PolicySetName"] = request.PolicySetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePolicySet",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePolicySetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新一个权限策略集合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePolicySetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicySetResponse
        /// </returns>
        public UpdatePolicySetResponse UpdatePolicySet(UpdatePolicySetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePolicySetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新一个权限策略集合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePolicySetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicySetResponse
        /// </returns>
        public async Task<UpdatePolicySetResponse> UpdatePolicySetAsync(UpdatePolicySetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePolicySetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Role</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRoleResponse
        /// </returns>
        public UpdateRoleResponse UpdateRoleWithOptions(UpdateRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRole",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Role</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRoleResponse
        /// </returns>
        public async Task<UpdateRoleResponse> UpdateRoleWithOptionsAsync(UpdateRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRole",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Role</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRoleResponse
        /// </returns>
        public UpdateRoleResponse UpdateRole(UpdateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRoleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Role</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRoleResponse
        /// </returns>
        public async Task<UpdateRoleResponse> UpdateRoleAsync(UpdateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRoleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新凭证库。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTokenVaultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTokenVaultResponse
        /// </returns>
        public UpdateTokenVaultResponse UpdateTokenVaultWithOptions(UpdateTokenVaultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                body["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTokenVault",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTokenVaultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新凭证库。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTokenVaultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTokenVaultResponse
        /// </returns>
        public async Task<UpdateTokenVaultResponse> UpdateTokenVaultWithOptionsAsync(UpdateTokenVaultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                body["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenVaultName))
            {
                body["TokenVaultName"] = request.TokenVaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTokenVault",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTokenVaultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新凭证库。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTokenVaultRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTokenVaultResponse
        /// </returns>
        public UpdateTokenVaultResponse UpdateTokenVault(UpdateTokenVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTokenVaultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新凭证库。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTokenVaultRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTokenVaultResponse
        /// </returns>
        public async Task<UpdateTokenVaultResponse> UpdateTokenVaultAsync(UpdateTokenVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTokenVaultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新用户池用户</para>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2025-09-01",
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
        /// <para>更新用户池用户</para>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2025-09-01",
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
        /// <para>更新用户池用户</para>
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
        /// <para>更新用户池用户</para>
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
        /// <para>更新IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserPoolResponse
        /// </returns>
        public UpdateUserPoolResponse UpdateUserPoolWithOptions(UpdateUserPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserPool",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserPoolResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserPoolResponse
        /// </returns>
        public async Task<UpdateUserPoolResponse> UpdateUserPoolWithOptionsAsync(UpdateUserPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserPool",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserPoolResponse
        /// </returns>
        public UpdateUserPoolResponse UpdateUserPool(UpdateUserPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserPoolWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新IdentityProvider</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserPoolResponse
        /// </returns>
        public async Task<UpdateUserPoolResponse> UpdateUserPoolAsync(UpdateUserPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserPoolWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateUserPoolClientRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserPoolClientResponse
        /// </returns>
        public UpdateUserPoolClientResponse UpdateUserPoolClientWithOptions(UpdateUserPoolClientRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateUserPoolClientShrinkRequest request = new UpdateUserPoolClientShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RedirectURIs))
            {
                request.RedirectURIsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RedirectURIs, "RedirectURIs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessTokenValidity))
            {
                body["AccessTokenValidity"] = request.AccessTokenValidity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientName))
            {
                body["ClientName"] = request.ClientName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnforcePKCE))
            {
                body["EnforcePKCE"] = request.EnforcePKCE;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectURIsShrink))
            {
                body["RedirectURIs"] = request.RedirectURIsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefreshTokenValidity))
            {
                body["RefreshTokenValidity"] = request.RefreshTokenValidity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretRequired))
            {
                body["SecretRequired"] = request.SecretRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserPoolClient",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserPoolClientResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateUserPoolClientRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserPoolClientResponse
        /// </returns>
        public async Task<UpdateUserPoolClientResponse> UpdateUserPoolClientWithOptionsAsync(UpdateUserPoolClientRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateUserPoolClientShrinkRequest request = new UpdateUserPoolClientShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RedirectURIs))
            {
                request.RedirectURIsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RedirectURIs, "RedirectURIs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessTokenValidity))
            {
                body["AccessTokenValidity"] = request.AccessTokenValidity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientName))
            {
                body["ClientName"] = request.ClientName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnforcePKCE))
            {
                body["EnforcePKCE"] = request.EnforcePKCE;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectURIsShrink))
            {
                body["RedirectURIs"] = request.RedirectURIsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefreshTokenValidity))
            {
                body["RefreshTokenValidity"] = request.RefreshTokenValidity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretRequired))
            {
                body["SecretRequired"] = request.SecretRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPoolName))
            {
                body["UserPoolName"] = request.UserPoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserPoolClient",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserPoolClientResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserPoolClientRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserPoolClientResponse
        /// </returns>
        public UpdateUserPoolClientResponse UpdateUserPoolClient(UpdateUserPoolClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserPoolClientWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserPoolClientRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserPoolClientResponse
        /// </returns>
        public async Task<UpdateUserPoolClientResponse> UpdateUserPoolClientAsync(UpdateUserPoolClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserPoolClientWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateWorkloadIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkloadIdentityResponse
        /// </returns>
        public UpdateWorkloadIdentityResponse UpdateWorkloadIdentityWithOptions(UpdateWorkloadIdentityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateWorkloadIdentityShrinkRequest request = new UpdateWorkloadIdentityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AllowedResourceOAuth2ReturnURLs))
            {
                request.AllowedResourceOAuth2ReturnURLsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AllowedResourceOAuth2ReturnURLs, "AllowedResourceOAuth2ReturnURLs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedResourceOAuth2ReturnURLsShrink))
            {
                body["AllowedResourceOAuth2ReturnURLs"] = request.AllowedResourceOAuth2ReturnURLsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderName))
            {
                body["IdentityProviderName"] = request.IdentityProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                body["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionBindingEnabled))
            {
                body["SessionBindingEnabled"] = request.SessionBindingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkloadIdentityName))
            {
                body["WorkloadIdentityName"] = request.WorkloadIdentityName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkloadIdentity",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkloadIdentityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateWorkloadIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkloadIdentityResponse
        /// </returns>
        public async Task<UpdateWorkloadIdentityResponse> UpdateWorkloadIdentityWithOptionsAsync(UpdateWorkloadIdentityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateWorkloadIdentityShrinkRequest request = new UpdateWorkloadIdentityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AllowedResourceOAuth2ReturnURLs))
            {
                request.AllowedResourceOAuth2ReturnURLsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AllowedResourceOAuth2ReturnURLs, "AllowedResourceOAuth2ReturnURLs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedResourceOAuth2ReturnURLsShrink))
            {
                body["AllowedResourceOAuth2ReturnURLs"] = request.AllowedResourceOAuth2ReturnURLsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityProviderName))
            {
                body["IdentityProviderName"] = request.IdentityProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                body["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionBindingEnabled))
            {
                body["SessionBindingEnabled"] = request.SessionBindingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkloadIdentityName))
            {
                body["WorkloadIdentityName"] = request.WorkloadIdentityName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkloadIdentity",
                Version = "2025-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkloadIdentityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkloadIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkloadIdentityResponse
        /// </returns>
        public UpdateWorkloadIdentityResponse UpdateWorkloadIdentity(UpdateWorkloadIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWorkloadIdentityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkloadIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkloadIdentityResponse
        /// </returns>
        public async Task<UpdateWorkloadIdentityResponse> UpdateWorkloadIdentityAsync(UpdateWorkloadIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWorkloadIdentityWithOptionsAsync(request, runtime);
        }

    }
}
