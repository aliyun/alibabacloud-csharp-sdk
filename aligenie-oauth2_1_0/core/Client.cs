// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AliGenieoauth2_1_0.Models;

namespace AlibabaCloud.SDK.AliGenieoauth2_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("aligenie", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>执行场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteSceneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSceneResponse
        /// </returns>
        public ExecuteSceneResponse ExecuteSceneWithOptions(ExecuteSceneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteScene",
                Version = "oauth2_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/oauth2/iot/scene/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteSceneResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteSceneResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteSceneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSceneResponse
        /// </returns>
        public async Task<ExecuteSceneResponse> ExecuteSceneWithOptionsAsync(ExecuteSceneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteScene",
                Version = "oauth2_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/oauth2/iot/scene/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteSceneResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteSceneResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSceneResponse
        /// </returns>
        public ExecuteSceneResponse ExecuteScene(ExecuteSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteSceneWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSceneResponse
        /// </returns>
        public async Task<ExecuteSceneResponse> ExecuteSceneAsync(ExecuteSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteSceneWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景列表</para>
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
        /// GetSceneListResponse
        /// </returns>
        public GetSceneListResponse GetSceneListWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSceneList",
                Version = "oauth2_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/oauth2/iot/scene/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetSceneListResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetSceneListResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景列表</para>
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
        /// GetSceneListResponse
        /// </returns>
        public async Task<GetSceneListResponse> GetSceneListWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSceneList",
                Version = "oauth2_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/oauth2/iot/scene/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetSceneListResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetSceneListResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSceneListResponse
        /// </returns>
        public GetSceneListResponse GetSceneList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSceneListWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSceneListResponse
        /// </returns>
        public async Task<GetSceneListResponse> GetSceneListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSceneListWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取</para>
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
        /// GetUserBasicInfoResponse
        /// </returns>
        public GetUserBasicInfoResponse GetUserBasicInfoWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserBasicInfo",
                Version = "oauth2_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/oauth2/users/basic",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetUserBasicInfoResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetUserBasicInfoResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取</para>
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
        /// GetUserBasicInfoResponse
        /// </returns>
        public async Task<GetUserBasicInfoResponse> GetUserBasicInfoWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserBasicInfo",
                Version = "oauth2_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/oauth2/users/basic",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetUserBasicInfoResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetUserBasicInfoResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetUserBasicInfoResponse
        /// </returns>
        public GetUserBasicInfoResponse GetUserBasicInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserBasicInfoWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetUserBasicInfoResponse
        /// </returns>
        public async Task<GetUserBasicInfoResponse> GetUserBasicInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserBasicInfoWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取天猫精灵用户绑定的手机号</para>
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
        /// GetUserPhoneResponse
        /// </returns>
        public GetUserPhoneResponse GetUserPhoneWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserPhone",
                Version = "oauth2_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/oauth2/user/profile/phone",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetUserPhoneResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetUserPhoneResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取天猫精灵用户绑定的手机号</para>
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
        /// GetUserPhoneResponse
        /// </returns>
        public async Task<GetUserPhoneResponse> GetUserPhoneWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserPhone",
                Version = "oauth2_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/oauth2/user/profile/phone",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetUserPhoneResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetUserPhoneResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取天猫精灵用户绑定的手机号</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetUserPhoneResponse
        /// </returns>
        public GetUserPhoneResponse GetUserPhone()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserPhoneWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取天猫精灵用户绑定的手机号</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetUserPhoneResponse
        /// </returns>
        public async Task<GetUserPhoneResponse> GetUserPhoneAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserPhoneWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>OAuth2令牌撤销端点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OAuth2RevocationEndpointRequest
        /// </param>
        /// <param name="headers">
        /// OAuth2RevocationEndpointHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OAuth2RevocationEndpointResponse
        /// </returns>
        public OAuth2RevocationEndpointResponse OAuth2RevocationEndpointWithOptions(OAuth2RevocationEndpointRequest request, OAuth2RevocationEndpointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenTypeHint))
            {
                body["TokenTypeHint"] = request.TokenTypeHint;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OAuth2RevocationEndpoint",
                Version = "oauth2_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/oauth2/revoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<OAuth2RevocationEndpointResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<OAuth2RevocationEndpointResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>OAuth2令牌撤销端点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OAuth2RevocationEndpointRequest
        /// </param>
        /// <param name="headers">
        /// OAuth2RevocationEndpointHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OAuth2RevocationEndpointResponse
        /// </returns>
        public async Task<OAuth2RevocationEndpointResponse> OAuth2RevocationEndpointWithOptionsAsync(OAuth2RevocationEndpointRequest request, OAuth2RevocationEndpointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenTypeHint))
            {
                body["TokenTypeHint"] = request.TokenTypeHint;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OAuth2RevocationEndpoint",
                Version = "oauth2_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/oauth2/revoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<OAuth2RevocationEndpointResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<OAuth2RevocationEndpointResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>OAuth2令牌撤销端点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OAuth2RevocationEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// OAuth2RevocationEndpointResponse
        /// </returns>
        public OAuth2RevocationEndpointResponse OAuth2RevocationEndpoint(OAuth2RevocationEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OAuth2RevocationEndpointHeaders headers = new OAuth2RevocationEndpointHeaders();
            return OAuth2RevocationEndpointWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>OAuth2令牌撤销端点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OAuth2RevocationEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// OAuth2RevocationEndpointResponse
        /// </returns>
        public async Task<OAuth2RevocationEndpointResponse> OAuth2RevocationEndpointAsync(OAuth2RevocationEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OAuth2RevocationEndpointHeaders headers = new OAuth2RevocationEndpointHeaders();
            return await OAuth2RevocationEndpointWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>OAuth2令牌端点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OAuth2TokenEndpointRequest
        /// </param>
        /// <param name="headers">
        /// OAuth2TokenEndpointHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OAuth2TokenEndpointResponse
        /// </returns>
        public OAuth2TokenEndpointResponse OAuth2TokenEndpointWithOptions(OAuth2TokenEndpointRequest request, OAuth2TokenEndpointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantType))
            {
                body["GrantType"] = request.GrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUri))
            {
                body["RedirectUri"] = request.RedirectUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefreshToken))
            {
                body["RefreshToken"] = request.RefreshToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OAuth2TokenEndpoint",
                Version = "oauth2_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/oauth2/token",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<OAuth2TokenEndpointResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<OAuth2TokenEndpointResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>OAuth2令牌端点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OAuth2TokenEndpointRequest
        /// </param>
        /// <param name="headers">
        /// OAuth2TokenEndpointHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OAuth2TokenEndpointResponse
        /// </returns>
        public async Task<OAuth2TokenEndpointResponse> OAuth2TokenEndpointWithOptionsAsync(OAuth2TokenEndpointRequest request, OAuth2TokenEndpointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantType))
            {
                body["GrantType"] = request.GrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUri))
            {
                body["RedirectUri"] = request.RedirectUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefreshToken))
            {
                body["RefreshToken"] = request.RefreshToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OAuth2TokenEndpoint",
                Version = "oauth2_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/oauth2/token",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<OAuth2TokenEndpointResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<OAuth2TokenEndpointResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>OAuth2令牌端点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OAuth2TokenEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// OAuth2TokenEndpointResponse
        /// </returns>
        public OAuth2TokenEndpointResponse OAuth2TokenEndpoint(OAuth2TokenEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OAuth2TokenEndpointHeaders headers = new OAuth2TokenEndpointHeaders();
            return OAuth2TokenEndpointWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>OAuth2令牌端点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OAuth2TokenEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// OAuth2TokenEndpointResponse
        /// </returns>
        public async Task<OAuth2TokenEndpointResponse> OAuth2TokenEndpointAsync(OAuth2TokenEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OAuth2TokenEndpointHeaders headers = new OAuth2TokenEndpointHeaders();
            return await OAuth2TokenEndpointWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送设备通知</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PushDeviceNotificationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushDeviceNotificationResponse
        /// </returns>
        public PushDeviceNotificationResponse PushDeviceNotificationWithOptions(PushDeviceNotificationRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushDeviceNotificationShrinkRequest request = new PushDeviceNotificationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantInfo))
            {
                request.TenantInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantInfo, "TenantInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantInfoShrink))
            {
                body["TenantInfo"] = request.TenantInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushDeviceNotification",
                Version = "oauth2_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/oauth2/device/notification/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PushDeviceNotificationResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PushDeviceNotificationResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送设备通知</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PushDeviceNotificationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushDeviceNotificationResponse
        /// </returns>
        public async Task<PushDeviceNotificationResponse> PushDeviceNotificationWithOptionsAsync(PushDeviceNotificationRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushDeviceNotificationShrinkRequest request = new PushDeviceNotificationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantInfo))
            {
                request.TenantInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantInfo, "TenantInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantInfoShrink))
            {
                body["TenantInfo"] = request.TenantInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushDeviceNotification",
                Version = "oauth2_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/oauth2/device/notification/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PushDeviceNotificationResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PushDeviceNotificationResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送设备通知</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushDeviceNotificationRequest
        /// </param>
        /// 
        /// <returns>
        /// PushDeviceNotificationResponse
        /// </returns>
        public PushDeviceNotificationResponse PushDeviceNotification(PushDeviceNotificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushDeviceNotificationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送设备通知</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushDeviceNotificationRequest
        /// </param>
        /// 
        /// <returns>
        /// PushDeviceNotificationResponse
        /// </returns>
        public async Task<PushDeviceNotificationResponse> PushDeviceNotificationAsync(PushDeviceNotificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushDeviceNotificationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备列表</para>
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
        /// QueryDeviceListResponse
        /// </returns>
        public QueryDeviceListResponse QueryDeviceListWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceList",
                Version = "oauth2_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/oauth2/device/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryDeviceListResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryDeviceListResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备列表</para>
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
        /// QueryDeviceListResponse
        /// </returns>
        public async Task<QueryDeviceListResponse> QueryDeviceListWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceList",
                Version = "oauth2_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/oauth2/device/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryDeviceListResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryDeviceListResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryDeviceListResponse
        /// </returns>
        public QueryDeviceListResponse QueryDeviceList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryDeviceListWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryDeviceListResponse
        /// </returns>
        public async Task<QueryDeviceListResponse> QueryDeviceListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryDeviceListWithOptionsAsync(headers, runtime);
        }

    }
}
