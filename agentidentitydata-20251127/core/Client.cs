// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AgentIdentityData20251127.Models;

namespace AlibabaCloud.SDK.AgentIdentityData20251127
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("agentidentitydata", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>获取工作负载访问令牌</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssumeRoleForWorkloadIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssumeRoleForWorkloadIdentityResponse
        /// </returns>
        public AssumeRoleForWorkloadIdentityResponse AssumeRoleForWorkloadIdentityWithOptions(AssumeRoleForWorkloadIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationSeconds))
            {
                body["DurationSeconds"] = request.DurationSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                body["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleSessionName))
            {
                body["RoleSessionName"] = request.RoleSessionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkloadAccessToken))
            {
                body["WorkloadAccessToken"] = request.WorkloadAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssumeRoleForWorkloadIdentity",
                Version = "2025-11-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssumeRoleForWorkloadIdentityResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作负载访问令牌</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssumeRoleForWorkloadIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssumeRoleForWorkloadIdentityResponse
        /// </returns>
        public async Task<AssumeRoleForWorkloadIdentityResponse> AssumeRoleForWorkloadIdentityWithOptionsAsync(AssumeRoleForWorkloadIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationSeconds))
            {
                body["DurationSeconds"] = request.DurationSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                body["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleSessionName))
            {
                body["RoleSessionName"] = request.RoleSessionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkloadAccessToken))
            {
                body["WorkloadAccessToken"] = request.WorkloadAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssumeRoleForWorkloadIdentity",
                Version = "2025-11-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssumeRoleForWorkloadIdentityResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作负载访问令牌</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssumeRoleForWorkloadIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// AssumeRoleForWorkloadIdentityResponse
        /// </returns>
        public AssumeRoleForWorkloadIdentityResponse AssumeRoleForWorkloadIdentity(AssumeRoleForWorkloadIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssumeRoleForWorkloadIdentityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作负载访问令牌</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssumeRoleForWorkloadIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// AssumeRoleForWorkloadIdentityResponse
        /// </returns>
        public async Task<AssumeRoleForWorkloadIdentityResponse> AssumeRoleForWorkloadIdentityAsync(AssumeRoleForWorkloadIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssumeRoleForWorkloadIdentityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认用户授权会话已完成</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CompleteResourceTokenAuthRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CompleteResourceTokenAuthResponse
        /// </returns>
        public CompleteResourceTokenAuthResponse CompleteResourceTokenAuthWithOptions(CompleteResourceTokenAuthRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CompleteResourceTokenAuthShrinkRequest request = new CompleteResourceTokenAuthShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserIdentifier))
            {
                request.UserIdentifierShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserIdentifier, "UserIdentifier", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionURI))
            {
                body["SessionURI"] = request.SessionURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdentifierShrink))
            {
                body["UserIdentifier"] = request.UserIdentifierShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompleteResourceTokenAuth",
                Version = "2025-11-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompleteResourceTokenAuthResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认用户授权会话已完成</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CompleteResourceTokenAuthRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CompleteResourceTokenAuthResponse
        /// </returns>
        public async Task<CompleteResourceTokenAuthResponse> CompleteResourceTokenAuthWithOptionsAsync(CompleteResourceTokenAuthRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CompleteResourceTokenAuthShrinkRequest request = new CompleteResourceTokenAuthShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserIdentifier))
            {
                request.UserIdentifierShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserIdentifier, "UserIdentifier", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionURI))
            {
                body["SessionURI"] = request.SessionURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdentifierShrink))
            {
                body["UserIdentifier"] = request.UserIdentifierShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompleteResourceTokenAuth",
                Version = "2025-11-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompleteResourceTokenAuthResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认用户授权会话已完成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CompleteResourceTokenAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// CompleteResourceTokenAuthResponse
        /// </returns>
        public CompleteResourceTokenAuthResponse CompleteResourceTokenAuth(CompleteResourceTokenAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompleteResourceTokenAuthWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认用户授权会话已完成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CompleteResourceTokenAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// CompleteResourceTokenAuthResponse
        /// </returns>
        public async Task<CompleteResourceTokenAuthResponse> CompleteResourceTokenAuthAsync(CompleteResourceTokenAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompleteResourceTokenAuthWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取下游资源的 API 密钥</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceAPIKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceAPIKeyResponse
        /// </returns>
        public GetResourceAPIKeyResponse GetResourceAPIKeyWithOptions(GetResourceAPIKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceCredentialProviderName))
            {
                body["ResourceCredentialProviderName"] = request.ResourceCredentialProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkloadAccessToken))
            {
                body["WorkloadAccessToken"] = request.WorkloadAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceAPIKey",
                Version = "2025-11-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceAPIKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取下游资源的 API 密钥</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceAPIKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceAPIKeyResponse
        /// </returns>
        public async Task<GetResourceAPIKeyResponse> GetResourceAPIKeyWithOptionsAsync(GetResourceAPIKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceCredentialProviderName))
            {
                body["ResourceCredentialProviderName"] = request.ResourceCredentialProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkloadAccessToken))
            {
                body["WorkloadAccessToken"] = request.WorkloadAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceAPIKey",
                Version = "2025-11-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceAPIKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取下游资源的 API 密钥</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceAPIKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceAPIKeyResponse
        /// </returns>
        public GetResourceAPIKeyResponse GetResourceAPIKey(GetResourceAPIKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceAPIKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取下游资源的 API 密钥</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceAPIKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceAPIKeyResponse
        /// </returns>
        public async Task<GetResourceAPIKeyResponse> GetResourceAPIKeyAsync(GetResourceAPIKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceAPIKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取下游资源的 OAuth 2.0 访问令牌</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetResourceOAuth2TokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceOAuth2TokenResponse
        /// </returns>
        public GetResourceOAuth2TokenResponse GetResourceOAuth2TokenWithOptions(GetResourceOAuth2TokenRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetResourceOAuth2TokenShrinkRequest request = new GetResourceOAuth2TokenShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomParameters))
            {
                request.CustomParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomParameters, "CustomParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Scopes))
            {
                request.ScopesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Scopes, "Scopes", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomParametersShrink))
            {
                body["CustomParameters"] = request.CustomParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomState))
            {
                body["CustomState"] = request.CustomState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceAuthentication))
            {
                body["ForceAuthentication"] = request.ForceAuthentication;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OAuth2Flow))
            {
                body["OAuth2Flow"] = request.OAuth2Flow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceCredentialProviderName))
            {
                body["ResourceCredentialProviderName"] = request.ResourceCredentialProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOAuth2ReturnURL))
            {
                body["ResourceOAuth2ReturnURL"] = request.ResourceOAuth2ReturnURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopesShrink))
            {
                body["Scopes"] = request.ScopesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionURI))
            {
                body["SessionURI"] = request.SessionURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkloadAccessToken))
            {
                body["WorkloadAccessToken"] = request.WorkloadAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceOAuth2Token",
                Version = "2025-11-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceOAuth2TokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取下游资源的 OAuth 2.0 访问令牌</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetResourceOAuth2TokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceOAuth2TokenResponse
        /// </returns>
        public async Task<GetResourceOAuth2TokenResponse> GetResourceOAuth2TokenWithOptionsAsync(GetResourceOAuth2TokenRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetResourceOAuth2TokenShrinkRequest request = new GetResourceOAuth2TokenShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomParameters))
            {
                request.CustomParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomParameters, "CustomParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Scopes))
            {
                request.ScopesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Scopes, "Scopes", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomParametersShrink))
            {
                body["CustomParameters"] = request.CustomParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomState))
            {
                body["CustomState"] = request.CustomState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceAuthentication))
            {
                body["ForceAuthentication"] = request.ForceAuthentication;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OAuth2Flow))
            {
                body["OAuth2Flow"] = request.OAuth2Flow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceCredentialProviderName))
            {
                body["ResourceCredentialProviderName"] = request.ResourceCredentialProviderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOAuth2ReturnURL))
            {
                body["ResourceOAuth2ReturnURL"] = request.ResourceOAuth2ReturnURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopesShrink))
            {
                body["Scopes"] = request.ScopesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionURI))
            {
                body["SessionURI"] = request.SessionURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkloadAccessToken))
            {
                body["WorkloadAccessToken"] = request.WorkloadAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceOAuth2Token",
                Version = "2025-11-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceOAuth2TokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取下游资源的 OAuth 2.0 访问令牌</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceOAuth2TokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceOAuth2TokenResponse
        /// </returns>
        public GetResourceOAuth2TokenResponse GetResourceOAuth2Token(GetResourceOAuth2TokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceOAuth2TokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取下游资源的 OAuth 2.0 访问令牌</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceOAuth2TokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceOAuth2TokenResponse
        /// </returns>
        public async Task<GetResourceOAuth2TokenResponse> GetResourceOAuth2TokenAsync(GetResourceOAuth2TokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceOAuth2TokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作负载访问令牌</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkloadAccessTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkloadAccessTokenResponse
        /// </returns>
        public GetWorkloadAccessTokenResponse GetWorkloadAccessTokenWithOptions(GetWorkloadAccessTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetWorkloadAccessToken",
                Version = "2025-11-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkloadAccessTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作负载访问令牌</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkloadAccessTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkloadAccessTokenResponse
        /// </returns>
        public async Task<GetWorkloadAccessTokenResponse> GetWorkloadAccessTokenWithOptionsAsync(GetWorkloadAccessTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetWorkloadAccessToken",
                Version = "2025-11-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkloadAccessTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作负载访问令牌</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkloadAccessTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkloadAccessTokenResponse
        /// </returns>
        public GetWorkloadAccessTokenResponse GetWorkloadAccessToken(GetWorkloadAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkloadAccessTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作负载访问令牌</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkloadAccessTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkloadAccessTokenResponse
        /// </returns>
        public async Task<GetWorkloadAccessTokenResponse> GetWorkloadAccessTokenAsync(GetWorkloadAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkloadAccessTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作负载访问令牌</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkloadAccessTokenForJWTRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkloadAccessTokenForJWTResponse
        /// </returns>
        public GetWorkloadAccessTokenForJWTResponse GetWorkloadAccessTokenForJWTWithOptions(GetWorkloadAccessTokenForJWTRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserToken))
            {
                body["UserToken"] = request.UserToken;
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
                Action = "GetWorkloadAccessTokenForJWT",
                Version = "2025-11-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkloadAccessTokenForJWTResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作负载访问令牌</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkloadAccessTokenForJWTRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkloadAccessTokenForJWTResponse
        /// </returns>
        public async Task<GetWorkloadAccessTokenForJWTResponse> GetWorkloadAccessTokenForJWTWithOptionsAsync(GetWorkloadAccessTokenForJWTRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserToken))
            {
                body["UserToken"] = request.UserToken;
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
                Action = "GetWorkloadAccessTokenForJWT",
                Version = "2025-11-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkloadAccessTokenForJWTResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作负载访问令牌</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkloadAccessTokenForJWTRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkloadAccessTokenForJWTResponse
        /// </returns>
        public GetWorkloadAccessTokenForJWTResponse GetWorkloadAccessTokenForJWT(GetWorkloadAccessTokenForJWTRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkloadAccessTokenForJWTWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作负载访问令牌</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkloadAccessTokenForJWTRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkloadAccessTokenForJWTResponse
        /// </returns>
        public async Task<GetWorkloadAccessTokenForJWTResponse> GetWorkloadAccessTokenForJWTAsync(GetWorkloadAccessTokenForJWTRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkloadAccessTokenForJWTWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作负载访问令牌</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkloadAccessTokenForUserIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkloadAccessTokenForUserIdResponse
        /// </returns>
        public GetWorkloadAccessTokenForUserIdResponse GetWorkloadAccessTokenForUserIdWithOptions(GetWorkloadAccessTokenForUserIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
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
                Action = "GetWorkloadAccessTokenForUserId",
                Version = "2025-11-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkloadAccessTokenForUserIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作负载访问令牌</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkloadAccessTokenForUserIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkloadAccessTokenForUserIdResponse
        /// </returns>
        public async Task<GetWorkloadAccessTokenForUserIdResponse> GetWorkloadAccessTokenForUserIdWithOptionsAsync(GetWorkloadAccessTokenForUserIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
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
                Action = "GetWorkloadAccessTokenForUserId",
                Version = "2025-11-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkloadAccessTokenForUserIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作负载访问令牌</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkloadAccessTokenForUserIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkloadAccessTokenForUserIdResponse
        /// </returns>
        public GetWorkloadAccessTokenForUserIdResponse GetWorkloadAccessTokenForUserId(GetWorkloadAccessTokenForUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkloadAccessTokenForUserIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作负载访问令牌</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkloadAccessTokenForUserIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkloadAccessTokenForUserIdResponse
        /// </returns>
        public async Task<GetWorkloadAccessTokenForUserIdResponse> GetWorkloadAccessTokenForUserIdAsync(GetWorkloadAccessTokenForUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkloadAccessTokenForUserIdWithOptionsAsync(request, runtime);
        }

    }
}
