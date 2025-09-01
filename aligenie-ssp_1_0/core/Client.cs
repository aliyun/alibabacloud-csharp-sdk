// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AliGeniessp_1_0.Models;

namespace AlibabaCloud.SDK.AliGeniessp_1_0
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
        /// <para>收藏/取消收藏</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddAndRemoveFavoriteContentRequest
        /// </param>
        /// <param name="headers">
        /// AddAndRemoveFavoriteContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddAndRemoveFavoriteContentResponse
        /// </returns>
        public AddAndRemoveFavoriteContentResponse AddAndRemoveFavoriteContentWithOptions(AddAndRemoveFavoriteContentRequest tmpReq, AddAndRemoveFavoriteContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddAndRemoveFavoriteContentShrinkRequest request = new AddAndRemoveFavoriteContentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenAddAndRemoveFavoriteContentRequest))
            {
                request.OpenAddAndRemoveFavoriteContentRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenAddAndRemoveFavoriteContentRequest, "OpenAddAndRemoveFavoriteContentRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenAddAndRemoveFavoriteContentRequestShrink))
            {
                body["OpenAddAndRemoveFavoriteContentRequest"] = request.OpenAddAndRemoveFavoriteContentRequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddAndRemoveFavoriteContent",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/AddAndRemoveFavoriteContent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAndRemoveFavoriteContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>收藏/取消收藏</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddAndRemoveFavoriteContentRequest
        /// </param>
        /// <param name="headers">
        /// AddAndRemoveFavoriteContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddAndRemoveFavoriteContentResponse
        /// </returns>
        public async Task<AddAndRemoveFavoriteContentResponse> AddAndRemoveFavoriteContentWithOptionsAsync(AddAndRemoveFavoriteContentRequest tmpReq, AddAndRemoveFavoriteContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddAndRemoveFavoriteContentShrinkRequest request = new AddAndRemoveFavoriteContentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenAddAndRemoveFavoriteContentRequest))
            {
                request.OpenAddAndRemoveFavoriteContentRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenAddAndRemoveFavoriteContentRequest, "OpenAddAndRemoveFavoriteContentRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenAddAndRemoveFavoriteContentRequestShrink))
            {
                body["OpenAddAndRemoveFavoriteContentRequest"] = request.OpenAddAndRemoveFavoriteContentRequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddAndRemoveFavoriteContent",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/AddAndRemoveFavoriteContent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAndRemoveFavoriteContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>收藏/取消收藏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddAndRemoveFavoriteContentRequest
        /// </param>
        /// 
        /// <returns>
        /// AddAndRemoveFavoriteContentResponse
        /// </returns>
        public AddAndRemoveFavoriteContentResponse AddAndRemoveFavoriteContent(AddAndRemoveFavoriteContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAndRemoveFavoriteContentHeaders headers = new AddAndRemoveFavoriteContentHeaders();
            return AddAndRemoveFavoriteContentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>收藏/取消收藏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddAndRemoveFavoriteContentRequest
        /// </param>
        /// 
        /// <returns>
        /// AddAndRemoveFavoriteContentResponse
        /// </returns>
        public async Task<AddAndRemoveFavoriteContentResponse> AddAndRemoveFavoriteContentAsync(AddAndRemoveFavoriteContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAndRemoveFavoriteContentHeaders headers = new AddAndRemoveFavoriteContentHeaders();
            return await AddAndRemoveFavoriteContentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增订阅</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddSubRequest
        /// </param>
        /// <param name="headers">
        /// AddSubHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddSubResponse
        /// </returns>
        public AddSubResponse AddSubWithOptions(AddSubRequest tmpReq, AddSubHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddSubShrinkRequest request = new AddSubShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AddSubscriptionInfoRequest))
            {
                request.AddSubscriptionInfoRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AddSubscriptionInfoRequest, "AddSubscriptionInfoRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddSubscriptionInfoRequestShrink))
            {
                query["AddSubscriptionInfoRequest"] = request.AddSubscriptionInfoRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSub",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/addSub",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSubResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增订阅</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddSubRequest
        /// </param>
        /// <param name="headers">
        /// AddSubHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddSubResponse
        /// </returns>
        public async Task<AddSubResponse> AddSubWithOptionsAsync(AddSubRequest tmpReq, AddSubHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddSubShrinkRequest request = new AddSubShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AddSubscriptionInfoRequest))
            {
                request.AddSubscriptionInfoRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AddSubscriptionInfoRequest, "AddSubscriptionInfoRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddSubscriptionInfoRequestShrink))
            {
                query["AddSubscriptionInfoRequest"] = request.AddSubscriptionInfoRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSub",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/addSub",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSubResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddSubRequest
        /// </param>
        /// 
        /// <returns>
        /// AddSubResponse
        /// </returns>
        public AddSubResponse AddSub(AddSubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddSubHeaders headers = new AddSubHeaders();
            return AddSubWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddSubRequest
        /// </param>
        /// 
        /// <returns>
        /// AddSubResponse
        /// </returns>
        public async Task<AddSubResponse> AddSubAsync(AddSubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddSubHeaders headers = new AddSubHeaders();
            return await AddSubWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过指定精灵账号进行授权登录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AuthLoginWithAligenieUserInfoRequest
        /// </param>
        /// <param name="headers">
        /// AuthLoginWithAligenieUserInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthLoginWithAligenieUserInfoResponse
        /// </returns>
        public AuthLoginWithAligenieUserInfoResponse AuthLoginWithAligenieUserInfoWithOptions(AuthLoginWithAligenieUserInfoRequest request, AuthLoginWithAligenieUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedAligenieUserIdentifier))
            {
                body["EncryptedAligenieUserIdentifier"] = request.EncryptedAligenieUserIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
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
                Action = "AuthLoginWithAligenieUserInfo",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/authLoginWithAligenieUserInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthLoginWithAligenieUserInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过指定精灵账号进行授权登录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AuthLoginWithAligenieUserInfoRequest
        /// </param>
        /// <param name="headers">
        /// AuthLoginWithAligenieUserInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthLoginWithAligenieUserInfoResponse
        /// </returns>
        public async Task<AuthLoginWithAligenieUserInfoResponse> AuthLoginWithAligenieUserInfoWithOptionsAsync(AuthLoginWithAligenieUserInfoRequest request, AuthLoginWithAligenieUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedAligenieUserIdentifier))
            {
                body["EncryptedAligenieUserIdentifier"] = request.EncryptedAligenieUserIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
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
                Action = "AuthLoginWithAligenieUserInfo",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/authLoginWithAligenieUserInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthLoginWithAligenieUserInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过指定精灵账号进行授权登录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AuthLoginWithAligenieUserInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthLoginWithAligenieUserInfoResponse
        /// </returns>
        public AuthLoginWithAligenieUserInfoResponse AuthLoginWithAligenieUserInfo(AuthLoginWithAligenieUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AuthLoginWithAligenieUserInfoHeaders headers = new AuthLoginWithAligenieUserInfoHeaders();
            return AuthLoginWithAligenieUserInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过指定精灵账号进行授权登录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AuthLoginWithAligenieUserInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthLoginWithAligenieUserInfoResponse
        /// </returns>
        public async Task<AuthLoginWithAligenieUserInfoResponse> AuthLoginWithAligenieUserInfoAsync(AuthLoginWithAligenieUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AuthLoginWithAligenieUserInfoHeaders headers = new AuthLoginWithAligenieUserInfoHeaders();
            return await AuthLoginWithAligenieUserInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过手机号生成精灵账号进行授权登录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberRequest
        /// </param>
        /// <param name="headers">
        /// AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberResponse
        /// </returns>
        public AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberResponse AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberWithOptions(AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberRequest request, AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
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
                Action = "AuthLoginWithAligenieUserInfoGeneratedByPhoneNumber",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/authLoginWithAligenieUserInfoGeneratedByPhoneNumber",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过手机号生成精灵账号进行授权登录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberRequest
        /// </param>
        /// <param name="headers">
        /// AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberResponse
        /// </returns>
        public async Task<AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberResponse> AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberWithOptionsAsync(AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberRequest request, AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
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
                Action = "AuthLoginWithAligenieUserInfoGeneratedByPhoneNumber",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/authLoginWithAligenieUserInfoGeneratedByPhoneNumber",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过手机号生成精灵账号进行授权登录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberResponse
        /// </returns>
        public AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberResponse AuthLoginWithAligenieUserInfoGeneratedByPhoneNumber(AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberHeaders headers = new AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberHeaders();
            return AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过手机号生成精灵账号进行授权登录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberResponse
        /// </returns>
        public async Task<AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberResponse> AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberAsync(AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberHeaders headers = new AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberHeaders();
            return await AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过指定淘宝账号进行授权登录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AuthLoginWithTaobaoUserInfoRequest
        /// </param>
        /// <param name="headers">
        /// AuthLoginWithTaobaoUserInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthLoginWithTaobaoUserInfoResponse
        /// </returns>
        public AuthLoginWithTaobaoUserInfoResponse AuthLoginWithTaobaoUserInfoWithOptions(AuthLoginWithTaobaoUserInfoRequest request, AuthLoginWithTaobaoUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedTaobaoUserIdentifier))
            {
                body["EncryptedTaobaoUserIdentifier"] = request.EncryptedTaobaoUserIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
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
                Action = "AuthLoginWithTaobaoUserInfo",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/authLoginWithTaobaoUserInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthLoginWithTaobaoUserInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过指定淘宝账号进行授权登录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AuthLoginWithTaobaoUserInfoRequest
        /// </param>
        /// <param name="headers">
        /// AuthLoginWithTaobaoUserInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthLoginWithTaobaoUserInfoResponse
        /// </returns>
        public async Task<AuthLoginWithTaobaoUserInfoResponse> AuthLoginWithTaobaoUserInfoWithOptionsAsync(AuthLoginWithTaobaoUserInfoRequest request, AuthLoginWithTaobaoUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedTaobaoUserIdentifier))
            {
                body["EncryptedTaobaoUserIdentifier"] = request.EncryptedTaobaoUserIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
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
                Action = "AuthLoginWithTaobaoUserInfo",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/authLoginWithTaobaoUserInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthLoginWithTaobaoUserInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过指定淘宝账号进行授权登录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AuthLoginWithTaobaoUserInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthLoginWithTaobaoUserInfoResponse
        /// </returns>
        public AuthLoginWithTaobaoUserInfoResponse AuthLoginWithTaobaoUserInfo(AuthLoginWithTaobaoUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AuthLoginWithTaobaoUserInfoHeaders headers = new AuthLoginWithTaobaoUserInfoHeaders();
            return AuthLoginWithTaobaoUserInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过指定淘宝账号进行授权登录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AuthLoginWithTaobaoUserInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthLoginWithTaobaoUserInfoResponse
        /// </returns>
        public async Task<AuthLoginWithTaobaoUserInfoResponse> AuthLoginWithTaobaoUserInfoAsync(AuthLoginWithTaobaoUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AuthLoginWithTaobaoUserInfoHeaders headers = new AuthLoginWithTaobaoUserInfoHeaders();
            return await AuthLoginWithTaobaoUserInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过三方用户信息进行授权登录</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AuthLoginWithThirdUserInfoRequest
        /// </param>
        /// <param name="headers">
        /// AuthLoginWithThirdUserInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthLoginWithThirdUserInfoResponse
        /// </returns>
        public AuthLoginWithThirdUserInfoResponse AuthLoginWithThirdUserInfoWithOptions(AuthLoginWithThirdUserInfoRequest tmpReq, AuthLoginWithThirdUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AuthLoginWithThirdUserInfoShrinkRequest request = new AuthLoginWithThirdUserInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                body["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdUserIdentifier))
            {
                body["ThirdUserIdentifier"] = request.ThirdUserIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdUserType))
            {
                body["ThirdUserType"] = request.ThirdUserType;
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
                Action = "AuthLoginWithThirdUserInfo",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/authLoginWithThirdUserInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthLoginWithThirdUserInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过三方用户信息进行授权登录</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AuthLoginWithThirdUserInfoRequest
        /// </param>
        /// <param name="headers">
        /// AuthLoginWithThirdUserInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthLoginWithThirdUserInfoResponse
        /// </returns>
        public async Task<AuthLoginWithThirdUserInfoResponse> AuthLoginWithThirdUserInfoWithOptionsAsync(AuthLoginWithThirdUserInfoRequest tmpReq, AuthLoginWithThirdUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AuthLoginWithThirdUserInfoShrinkRequest request = new AuthLoginWithThirdUserInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                body["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdUserIdentifier))
            {
                body["ThirdUserIdentifier"] = request.ThirdUserIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdUserType))
            {
                body["ThirdUserType"] = request.ThirdUserType;
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
                Action = "AuthLoginWithThirdUserInfo",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/authLoginWithThirdUserInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthLoginWithThirdUserInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过三方用户信息进行授权登录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AuthLoginWithThirdUserInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthLoginWithThirdUserInfoResponse
        /// </returns>
        public AuthLoginWithThirdUserInfoResponse AuthLoginWithThirdUserInfo(AuthLoginWithThirdUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AuthLoginWithThirdUserInfoHeaders headers = new AuthLoginWithThirdUserInfoHeaders();
            return AuthLoginWithThirdUserInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过三方用户信息进行授权登录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AuthLoginWithThirdUserInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthLoginWithThirdUserInfoResponse
        /// </returns>
        public async Task<AuthLoginWithThirdUserInfoResponse> AuthLoginWithThirdUserInfoAsync(AuthLoginWithThirdUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AuthLoginWithThirdUserInfoHeaders headers = new AuthLoginWithThirdUserInfoHeaders();
            return await AuthLoginWithThirdUserInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查并拨打voip电话【酒店业务】</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CheckAndDoVoipCallForHotelRequest
        /// </param>
        /// <param name="headers">
        /// CheckAndDoVoipCallForHotelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckAndDoVoipCallForHotelResponse
        /// </returns>
        public CheckAndDoVoipCallForHotelResponse CheckAndDoVoipCallForHotelWithOptions(CheckAndDoVoipCallForHotelRequest tmpReq, CheckAndDoVoipCallForHotelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CheckAndDoVoipCallForHotelShrinkRequest request = new CheckAndDoVoipCallForHotelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizData))
            {
                body["BizData"] = request.BizData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalleeNick))
            {
                body["CalleeNick"] = request.CalleeNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalleePhoneNum))
            {
                body["CalleePhoneNum"] = request.CalleePhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "CheckAndDoVoipCallForHotel",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/checkAndDoVoipCallForHotel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckAndDoVoipCallForHotelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查并拨打voip电话【酒店业务】</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CheckAndDoVoipCallForHotelRequest
        /// </param>
        /// <param name="headers">
        /// CheckAndDoVoipCallForHotelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckAndDoVoipCallForHotelResponse
        /// </returns>
        public async Task<CheckAndDoVoipCallForHotelResponse> CheckAndDoVoipCallForHotelWithOptionsAsync(CheckAndDoVoipCallForHotelRequest tmpReq, CheckAndDoVoipCallForHotelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CheckAndDoVoipCallForHotelShrinkRequest request = new CheckAndDoVoipCallForHotelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizData))
            {
                body["BizData"] = request.BizData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalleeNick))
            {
                body["CalleeNick"] = request.CalleeNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalleePhoneNum))
            {
                body["CalleePhoneNum"] = request.CalleePhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "CheckAndDoVoipCallForHotel",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/checkAndDoVoipCallForHotel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckAndDoVoipCallForHotelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查并拨打voip电话【酒店业务】</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckAndDoVoipCallForHotelRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckAndDoVoipCallForHotelResponse
        /// </returns>
        public CheckAndDoVoipCallForHotelResponse CheckAndDoVoipCallForHotel(CheckAndDoVoipCallForHotelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckAndDoVoipCallForHotelHeaders headers = new CheckAndDoVoipCallForHotelHeaders();
            return CheckAndDoVoipCallForHotelWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查并拨打voip电话【酒店业务】</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckAndDoVoipCallForHotelRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckAndDoVoipCallForHotelResponse
        /// </returns>
        public async Task<CheckAndDoVoipCallForHotelResponse> CheckAndDoVoipCallForHotelAsync(CheckAndDoVoipCallForHotelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckAndDoVoipCallForHotelHeaders headers = new CheckAndDoVoipCallForHotelHeaders();
            return await CheckAndDoVoipCallForHotelWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轮询激活绑定结果</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CheckAuthCodeBindForExtRequest
        /// </param>
        /// <param name="headers">
        /// CheckAuthCodeBindForExtHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckAuthCodeBindForExtResponse
        /// </returns>
        public CheckAuthCodeBindForExtResponse CheckAuthCodeBindForExtWithOptions(CheckAuthCodeBindForExtRequest tmpReq, CheckAuthCodeBindForExtHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CheckAuthCodeBindForExtShrinkRequest request = new CheckAuthCodeBindForExtShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeKey))
            {
                query["EncodeKey"] = request.EncodeKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeType))
            {
                query["EncodeType"] = request.EncodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckAuthCodeBindForExt",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/checkAuthCodeBindForExt",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckAuthCodeBindForExtResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轮询激活绑定结果</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CheckAuthCodeBindForExtRequest
        /// </param>
        /// <param name="headers">
        /// CheckAuthCodeBindForExtHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckAuthCodeBindForExtResponse
        /// </returns>
        public async Task<CheckAuthCodeBindForExtResponse> CheckAuthCodeBindForExtWithOptionsAsync(CheckAuthCodeBindForExtRequest tmpReq, CheckAuthCodeBindForExtHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CheckAuthCodeBindForExtShrinkRequest request = new CheckAuthCodeBindForExtShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeKey))
            {
                query["EncodeKey"] = request.EncodeKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeType))
            {
                query["EncodeType"] = request.EncodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckAuthCodeBindForExt",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/checkAuthCodeBindForExt",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckAuthCodeBindForExtResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轮询激活绑定结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckAuthCodeBindForExtRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckAuthCodeBindForExtResponse
        /// </returns>
        public CheckAuthCodeBindForExtResponse CheckAuthCodeBindForExt(CheckAuthCodeBindForExtRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckAuthCodeBindForExtHeaders headers = new CheckAuthCodeBindForExtHeaders();
            return CheckAuthCodeBindForExtWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轮询激活绑定结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckAuthCodeBindForExtRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckAuthCodeBindForExtResponse
        /// </returns>
        public async Task<CheckAuthCodeBindForExtResponse> CheckAuthCodeBindForExtAsync(CheckAuthCodeBindForExtRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckAuthCodeBindForExtHeaders headers = new CheckAuthCodeBindForExtHeaders();
            return await CheckAuthCodeBindForExtWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>云播放器：对外</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CloudPlayerRequest
        /// </param>
        /// <param name="headers">
        /// CloudPlayerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudPlayerResponse
        /// </returns>
        public CloudPlayerResponse CloudPlayerWithOptions(CloudPlayerRequest tmpReq, CloudPlayerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CloudPlayerShrinkRequest request = new CloudPlayerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SongIdList))
            {
                request.SongIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SongIdList, "SongIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurPlayIndex))
            {
                query["CurPlayIndex"] = request.CurPlayIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayMode))
            {
                query["PlayMode"] = request.PlayMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SongId))
            {
                query["SongId"] = request.SongId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SongIdListShrink))
            {
                query["SongIdList"] = request.SongIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudPlayer",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/cloud/player",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudPlayerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>云播放器：对外</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CloudPlayerRequest
        /// </param>
        /// <param name="headers">
        /// CloudPlayerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudPlayerResponse
        /// </returns>
        public async Task<CloudPlayerResponse> CloudPlayerWithOptionsAsync(CloudPlayerRequest tmpReq, CloudPlayerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CloudPlayerShrinkRequest request = new CloudPlayerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SongIdList))
            {
                request.SongIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SongIdList, "SongIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurPlayIndex))
            {
                query["CurPlayIndex"] = request.CurPlayIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayMode))
            {
                query["PlayMode"] = request.PlayMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SongId))
            {
                query["SongId"] = request.SongId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SongIdListShrink))
            {
                query["SongIdList"] = request.SongIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudPlayer",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/cloud/player",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudPlayerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>云播放器：对外</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudPlayerRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudPlayerResponse
        /// </returns>
        public CloudPlayerResponse CloudPlayer(CloudPlayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloudPlayerHeaders headers = new CloudPlayerHeaders();
            return CloudPlayerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>云播放器：对外</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudPlayerRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudPlayerResponse
        /// </returns>
        public async Task<CloudPlayerResponse> CloudPlayerAsync(CloudPlayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloudPlayerHeaders headers = new CloudPlayerHeaders();
            return await CloudPlayerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建闹钟</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAlarmRequest
        /// </param>
        /// <param name="headers">
        /// CreateAlarmHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAlarmResponse
        /// </returns>
        public CreateAlarmResponse CreateAlarmWithOptions(CreateAlarmRequest tmpReq, CreateAlarmHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAlarmShrinkRequest request = new CreateAlarmShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "CreateAlarm",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/createAlarm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAlarmResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建闹钟</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAlarmRequest
        /// </param>
        /// <param name="headers">
        /// CreateAlarmHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAlarmResponse
        /// </returns>
        public async Task<CreateAlarmResponse> CreateAlarmWithOptionsAsync(CreateAlarmRequest tmpReq, CreateAlarmHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAlarmShrinkRequest request = new CreateAlarmShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "CreateAlarm",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/createAlarm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAlarmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建闹钟</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAlarmResponse
        /// </returns>
        public CreateAlarmResponse CreateAlarm(CreateAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAlarmHeaders headers = new CreateAlarmHeaders();
            return CreateAlarmWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建闹钟</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAlarmResponse
        /// </returns>
        public async Task<CreateAlarmResponse> CreateAlarmAsync(CreateAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAlarmHeaders headers = new CreateAlarmHeaders();
            return await CreateAlarmWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>播放列表创建</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreatePlayingListRequest
        /// </param>
        /// <param name="headers">
        /// CreatePlayingListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePlayingListResponse
        /// </returns>
        public CreatePlayingListResponse CreatePlayingListWithOptions(CreatePlayingListRequest tmpReq, CreatePlayingListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePlayingListShrinkRequest request = new CreatePlayingListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenCreatePlayingListRequest))
            {
                request.OpenCreatePlayingListRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenCreatePlayingListRequest, "OpenCreatePlayingListRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenCreatePlayingListRequestShrink))
            {
                body["OpenCreatePlayingListRequest"] = request.OpenCreatePlayingListRequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePlayingList",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/CreatePlayingList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePlayingListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>播放列表创建</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreatePlayingListRequest
        /// </param>
        /// <param name="headers">
        /// CreatePlayingListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePlayingListResponse
        /// </returns>
        public async Task<CreatePlayingListResponse> CreatePlayingListWithOptionsAsync(CreatePlayingListRequest tmpReq, CreatePlayingListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePlayingListShrinkRequest request = new CreatePlayingListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenCreatePlayingListRequest))
            {
                request.OpenCreatePlayingListRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenCreatePlayingListRequest, "OpenCreatePlayingListRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenCreatePlayingListRequestShrink))
            {
                body["OpenCreatePlayingListRequest"] = request.OpenCreatePlayingListRequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePlayingList",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/CreatePlayingList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePlayingListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>播放列表创建</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePlayingListRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePlayingListResponse
        /// </returns>
        public CreatePlayingListResponse CreatePlayingList(CreatePlayingListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreatePlayingListHeaders headers = new CreatePlayingListHeaders();
            return CreatePlayingListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>播放列表创建</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePlayingListRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePlayingListResponse
        /// </returns>
        public async Task<CreatePlayingListResponse> CreatePlayingListAsync(CreatePlayingListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreatePlayingListHeaders headers = new CreatePlayingListHeaders();
            return await CreatePlayingListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>播放列表创建走OAuth2授权</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreatePlayingListOAuth2Request
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePlayingListOAuth2Response
        /// </returns>
        public CreatePlayingListOAuth2Response CreatePlayingListOAuth2WithOptions(CreatePlayingListOAuth2Request tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePlayingListOAuth2ShrinkRequest request = new CreatePlayingListOAuth2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenCreatePlayingListRequest))
            {
                request.OpenCreatePlayingListRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenCreatePlayingListRequest, "OpenCreatePlayingListRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenCreatePlayingListRequestShrink))
            {
                body["OpenCreatePlayingListRequest"] = request.OpenCreatePlayingListRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePlayingListOAuth2",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/CreatePlayingListOAuth2",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePlayingListOAuth2Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>播放列表创建走OAuth2授权</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreatePlayingListOAuth2Request
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePlayingListOAuth2Response
        /// </returns>
        public async Task<CreatePlayingListOAuth2Response> CreatePlayingListOAuth2WithOptionsAsync(CreatePlayingListOAuth2Request tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePlayingListOAuth2ShrinkRequest request = new CreatePlayingListOAuth2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenCreatePlayingListRequest))
            {
                request.OpenCreatePlayingListRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenCreatePlayingListRequest, "OpenCreatePlayingListRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenCreatePlayingListRequestShrink))
            {
                body["OpenCreatePlayingListRequest"] = request.OpenCreatePlayingListRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePlayingListOAuth2",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/CreatePlayingListOAuth2",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePlayingListOAuth2Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>播放列表创建走OAuth2授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePlayingListOAuth2Request
        /// </param>
        /// 
        /// <returns>
        /// CreatePlayingListOAuth2Response
        /// </returns>
        public CreatePlayingListOAuth2Response CreatePlayingListOAuth2(CreatePlayingListOAuth2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePlayingListOAuth2WithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>播放列表创建走OAuth2授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePlayingListOAuth2Request
        /// </param>
        /// 
        /// <returns>
        /// CreatePlayingListOAuth2Response
        /// </returns>
        public async Task<CreatePlayingListOAuth2Response> CreatePlayingListOAuth2Async(CreatePlayingListOAuth2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePlayingListOAuth2WithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建定时任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateScheduleTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateScheduleTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduleTaskResponse
        /// </returns>
        public CreateScheduleTaskResponse CreateScheduleTaskWithOptions(CreateScheduleTaskRequest tmpReq, CreateScheduleTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateScheduleTaskShrinkRequest request = new CreateScheduleTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "CreateScheduleTask",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/CreateScheduleTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduleTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建定时任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateScheduleTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateScheduleTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduleTaskResponse
        /// </returns>
        public async Task<CreateScheduleTaskResponse> CreateScheduleTaskWithOptionsAsync(CreateScheduleTaskRequest tmpReq, CreateScheduleTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateScheduleTaskShrinkRequest request = new CreateScheduleTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "CreateScheduleTask",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/CreateScheduleTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduleTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建定时任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduleTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduleTaskResponse
        /// </returns>
        public CreateScheduleTaskResponse CreateScheduleTask(CreateScheduleTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateScheduleTaskHeaders headers = new CreateScheduleTaskHeaders();
            return CreateScheduleTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建定时任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduleTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduleTaskResponse
        /// </returns>
        public async Task<CreateScheduleTaskResponse> CreateScheduleTaskAsync(CreateScheduleTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateScheduleTaskHeaders headers = new CreateScheduleTaskHeaders();
            return await CreateScheduleTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>闹钟批量删除</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteAlarmsRequest
        /// </param>
        /// <param name="headers">
        /// DeleteAlarmsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAlarmsResponse
        /// </returns>
        public DeleteAlarmsResponse DeleteAlarmsWithOptions(DeleteAlarmsRequest tmpReq, DeleteAlarmsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAlarmsShrinkRequest request = new DeleteAlarmsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "DeleteAlarms",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/deleteAlarms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAlarmsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>闹钟批量删除</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteAlarmsRequest
        /// </param>
        /// <param name="headers">
        /// DeleteAlarmsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAlarmsResponse
        /// </returns>
        public async Task<DeleteAlarmsResponse> DeleteAlarmsWithOptionsAsync(DeleteAlarmsRequest tmpReq, DeleteAlarmsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAlarmsShrinkRequest request = new DeleteAlarmsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "DeleteAlarms",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/deleteAlarms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAlarmsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>闹钟批量删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAlarmsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAlarmsResponse
        /// </returns>
        public DeleteAlarmsResponse DeleteAlarms(DeleteAlarmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAlarmsHeaders headers = new DeleteAlarmsHeaders();
            return DeleteAlarmsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>闹钟批量删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAlarmsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAlarmsResponse
        /// </returns>
        public async Task<DeleteAlarmsResponse> DeleteAlarmsAsync(DeleteAlarmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAlarmsHeaders headers = new DeleteAlarmsHeaders();
            return await DeleteAlarmsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除定时任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteScheduleTaskRequest
        /// </param>
        /// <param name="headers">
        /// DeleteScheduleTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduleTaskResponse
        /// </returns>
        public DeleteScheduleTaskResponse DeleteScheduleTaskWithOptions(DeleteScheduleTaskRequest tmpReq, DeleteScheduleTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteScheduleTaskShrinkRequest request = new DeleteScheduleTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "DeleteScheduleTask",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/DeleteScheduleTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScheduleTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除定时任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteScheduleTaskRequest
        /// </param>
        /// <param name="headers">
        /// DeleteScheduleTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduleTaskResponse
        /// </returns>
        public async Task<DeleteScheduleTaskResponse> DeleteScheduleTaskWithOptionsAsync(DeleteScheduleTaskRequest tmpReq, DeleteScheduleTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteScheduleTaskShrinkRequest request = new DeleteScheduleTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "DeleteScheduleTask",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/DeleteScheduleTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScheduleTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除定时任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScheduleTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduleTaskResponse
        /// </returns>
        public DeleteScheduleTaskResponse DeleteScheduleTask(DeleteScheduleTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteScheduleTaskHeaders headers = new DeleteScheduleTaskHeaders();
            return DeleteScheduleTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除定时任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScheduleTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduleTaskResponse
        /// </returns>
        public async Task<DeleteScheduleTaskResponse> DeleteScheduleTaskAsync(DeleteScheduleTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteScheduleTaskHeaders headers = new DeleteScheduleTaskHeaders();
            return await DeleteScheduleTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSubRequest
        /// </param>
        /// <param name="headers">
        /// DeleteSubHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSubResponse
        /// </returns>
        public DeleteSubResponse DeleteSubWithOptions(DeleteSubRequest request, DeleteSubHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubId))
            {
                query["SubId"] = request.SubId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSub",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/deleteSub",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSubResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSubRequest
        /// </param>
        /// <param name="headers">
        /// DeleteSubHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSubResponse
        /// </returns>
        public async Task<DeleteSubResponse> DeleteSubWithOptionsAsync(DeleteSubRequest request, DeleteSubHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubId))
            {
                query["SubId"] = request.SubId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSub",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/deleteSub",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSubResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSubRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSubResponse
        /// </returns>
        public DeleteSubResponse DeleteSub(DeleteSubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSubHeaders headers = new DeleteSubHeaders();
            return DeleteSubWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSubRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSubResponse
        /// </returns>
        public async Task<DeleteSubResponse> DeleteSubAsync(DeleteSubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSubHeaders headers = new DeleteSubHeaders();
            return await DeleteSubWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备控制</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeviceControlRequest
        /// </param>
        /// <param name="headers">
        /// DeviceControlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeviceControlResponse
        /// </returns>
        public DeviceControlResponse DeviceControlWithOptions(DeviceControlRequest tmpReq, DeviceControlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeviceControlShrinkRequest request = new DeviceControlShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ControlRequest))
            {
                request.ControlRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ControlRequest, "ControlRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlRequestShrink))
            {
                body["ControlRequest"] = request.ControlRequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeviceControl",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/control",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeviceControlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备控制</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeviceControlRequest
        /// </param>
        /// <param name="headers">
        /// DeviceControlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeviceControlResponse
        /// </returns>
        public async Task<DeviceControlResponse> DeviceControlWithOptionsAsync(DeviceControlRequest tmpReq, DeviceControlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeviceControlShrinkRequest request = new DeviceControlShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ControlRequest))
            {
                request.ControlRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ControlRequest, "ControlRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlRequestShrink))
            {
                body["ControlRequest"] = request.ControlRequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeviceControl",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/control",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeviceControlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备控制</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeviceControlRequest
        /// </param>
        /// 
        /// <returns>
        /// DeviceControlResponse
        /// </returns>
        public DeviceControlResponse DeviceControl(DeviceControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeviceControlHeaders headers = new DeviceControlHeaders();
            return DeviceControlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备控制</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeviceControlRequest
        /// </param>
        /// 
        /// <returns>
        /// DeviceControlResponse
        /// </returns>
        public async Task<DeviceControlResponse> DeviceControlAsync(DeviceControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeviceControlHeaders headers = new DeviceControlHeaders();
            return await DeviceControlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生态开放鉴权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EcologyOpennessAuthenticateRequest
        /// </param>
        /// <param name="headers">
        /// EcologyOpennessAuthenticateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EcologyOpennessAuthenticateResponse
        /// </returns>
        public EcologyOpennessAuthenticateResponse EcologyOpennessAuthenticateWithOptions(EcologyOpennessAuthenticateRequest request, EcologyOpennessAuthenticateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeKey))
            {
                body["EncodeKey"] = request.EncodeKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeType))
            {
                body["EncodeType"] = request.EncodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginStateAccessToken))
            {
                body["LoginStateAccessToken"] = request.LoginStateAccessToken;
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
                Action = "EcologyOpennessAuthenticate",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/ecologyOpennessAuthenticate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EcologyOpennessAuthenticateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生态开放鉴权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EcologyOpennessAuthenticateRequest
        /// </param>
        /// <param name="headers">
        /// EcologyOpennessAuthenticateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EcologyOpennessAuthenticateResponse
        /// </returns>
        public async Task<EcologyOpennessAuthenticateResponse> EcologyOpennessAuthenticateWithOptionsAsync(EcologyOpennessAuthenticateRequest request, EcologyOpennessAuthenticateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeKey))
            {
                body["EncodeKey"] = request.EncodeKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeType))
            {
                body["EncodeType"] = request.EncodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginStateAccessToken))
            {
                body["LoginStateAccessToken"] = request.LoginStateAccessToken;
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
                Action = "EcologyOpennessAuthenticate",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/ecologyOpennessAuthenticate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EcologyOpennessAuthenticateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生态开放鉴权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EcologyOpennessAuthenticateRequest
        /// </param>
        /// 
        /// <returns>
        /// EcologyOpennessAuthenticateResponse
        /// </returns>
        public EcologyOpennessAuthenticateResponse EcologyOpennessAuthenticate(EcologyOpennessAuthenticateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EcologyOpennessAuthenticateHeaders headers = new EcologyOpennessAuthenticateHeaders();
            return EcologyOpennessAuthenticateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生态开放鉴权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EcologyOpennessAuthenticateRequest
        /// </param>
        /// 
        /// <returns>
        /// EcologyOpennessAuthenticateResponse
        /// </returns>
        public async Task<EcologyOpennessAuthenticateResponse> EcologyOpennessAuthenticateAsync(EcologyOpennessAuthenticateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EcologyOpennessAuthenticateHeaders headers = new EcologyOpennessAuthenticateHeaders();
            return await EcologyOpennessAuthenticateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生态开放发送短信验证码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EcologyOpennessSendVerificationCodeRequest
        /// </param>
        /// <param name="headers">
        /// EcologyOpennessSendVerificationCodeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EcologyOpennessSendVerificationCodeResponse
        /// </returns>
        public EcologyOpennessSendVerificationCodeResponse EcologyOpennessSendVerificationCodeWithOptions(EcologyOpennessSendVerificationCodeRequest request, EcologyOpennessSendVerificationCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
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
                Action = "EcologyOpennessSendVerificationCode",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/ecologyOpennessSendVerificationCode",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EcologyOpennessSendVerificationCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生态开放发送短信验证码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EcologyOpennessSendVerificationCodeRequest
        /// </param>
        /// <param name="headers">
        /// EcologyOpennessSendVerificationCodeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EcologyOpennessSendVerificationCodeResponse
        /// </returns>
        public async Task<EcologyOpennessSendVerificationCodeResponse> EcologyOpennessSendVerificationCodeWithOptionsAsync(EcologyOpennessSendVerificationCodeRequest request, EcologyOpennessSendVerificationCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
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
                Action = "EcologyOpennessSendVerificationCode",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/ecologyOpennessSendVerificationCode",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EcologyOpennessSendVerificationCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生态开放发送短信验证码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EcologyOpennessSendVerificationCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// EcologyOpennessSendVerificationCodeResponse
        /// </returns>
        public EcologyOpennessSendVerificationCodeResponse EcologyOpennessSendVerificationCode(EcologyOpennessSendVerificationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EcologyOpennessSendVerificationCodeHeaders headers = new EcologyOpennessSendVerificationCodeHeaders();
            return EcologyOpennessSendVerificationCodeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生态开放发送短信验证码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EcologyOpennessSendVerificationCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// EcologyOpennessSendVerificationCodeResponse
        /// </returns>
        public async Task<EcologyOpennessSendVerificationCodeResponse> EcologyOpennessSendVerificationCodeAsync(EcologyOpennessSendVerificationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EcologyOpennessSendVerificationCodeHeaders headers = new EcologyOpennessSendVerificationCodeHeaders();
            return await EcologyOpennessSendVerificationCodeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过手机号寻找可授权登录的账号列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindUserlistToAuthLoginWithPhoneNumberRequest
        /// </param>
        /// <param name="headers">
        /// FindUserlistToAuthLoginWithPhoneNumberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindUserlistToAuthLoginWithPhoneNumberResponse
        /// </returns>
        public FindUserlistToAuthLoginWithPhoneNumberResponse FindUserlistToAuthLoginWithPhoneNumberWithOptions(FindUserlistToAuthLoginWithPhoneNumberRequest request, FindUserlistToAuthLoginWithPhoneNumberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindUserlistToAuthLoginWithPhoneNumber",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/findUserlistToAuthLoginWithPhoneNumber",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindUserlistToAuthLoginWithPhoneNumberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过手机号寻找可授权登录的账号列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindUserlistToAuthLoginWithPhoneNumberRequest
        /// </param>
        /// <param name="headers">
        /// FindUserlistToAuthLoginWithPhoneNumberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindUserlistToAuthLoginWithPhoneNumberResponse
        /// </returns>
        public async Task<FindUserlistToAuthLoginWithPhoneNumberResponse> FindUserlistToAuthLoginWithPhoneNumberWithOptionsAsync(FindUserlistToAuthLoginWithPhoneNumberRequest request, FindUserlistToAuthLoginWithPhoneNumberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindUserlistToAuthLoginWithPhoneNumber",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/findUserlistToAuthLoginWithPhoneNumber",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindUserlistToAuthLoginWithPhoneNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过手机号寻找可授权登录的账号列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindUserlistToAuthLoginWithPhoneNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// FindUserlistToAuthLoginWithPhoneNumberResponse
        /// </returns>
        public FindUserlistToAuthLoginWithPhoneNumberResponse FindUserlistToAuthLoginWithPhoneNumber(FindUserlistToAuthLoginWithPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FindUserlistToAuthLoginWithPhoneNumberHeaders headers = new FindUserlistToAuthLoginWithPhoneNumberHeaders();
            return FindUserlistToAuthLoginWithPhoneNumberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过手机号寻找可授权登录的账号列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindUserlistToAuthLoginWithPhoneNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// FindUserlistToAuthLoginWithPhoneNumberResponse
        /// </returns>
        public async Task<FindUserlistToAuthLoginWithPhoneNumberResponse> FindUserlistToAuthLoginWithPhoneNumberAsync(FindUserlistToAuthLoginWithPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FindUserlistToAuthLoginWithPhoneNumberHeaders headers = new FindUserlistToAuthLoginWithPhoneNumberHeaders();
            return await FindUserlistToAuthLoginWithPhoneNumberWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个闹钟</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetAlarmRequest
        /// </param>
        /// <param name="headers">
        /// GetAlarmHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlarmResponse
        /// </returns>
        public GetAlarmResponse GetAlarmWithOptions(GetAlarmRequest tmpReq, GetAlarmHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAlarmShrinkRequest request = new GetAlarmShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "GetAlarm",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getAlarm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlarmResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个闹钟</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetAlarmRequest
        /// </param>
        /// <param name="headers">
        /// GetAlarmHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlarmResponse
        /// </returns>
        public async Task<GetAlarmResponse> GetAlarmWithOptionsAsync(GetAlarmRequest tmpReq, GetAlarmHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAlarmShrinkRequest request = new GetAlarmShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "GetAlarm",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getAlarm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlarmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个闹钟</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlarmResponse
        /// </returns>
        public GetAlarmResponse GetAlarm(GetAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAlarmHeaders headers = new GetAlarmHeaders();
            return GetAlarmWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单个闹钟</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlarmResponse
        /// </returns>
        public async Task<GetAlarmResponse> GetAlarmAsync(GetAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAlarmHeaders headers = new GetAlarmHeaders();
            return await GetAlarmWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据id获取专辑信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlbumRequest
        /// </param>
        /// <param name="headers">
        /// GetAlbumHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlbumResponse
        /// </returns>
        public GetAlbumResponse GetAlbumWithOptions(GetAlbumRequest request, GetAlbumHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlbum",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/GetAlbum",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlbumResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据id获取专辑信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlbumRequest
        /// </param>
        /// <param name="headers">
        /// GetAlbumHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlbumResponse
        /// </returns>
        public async Task<GetAlbumResponse> GetAlbumWithOptionsAsync(GetAlbumRequest request, GetAlbumHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlbum",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/GetAlbum",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlbumResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据id获取专辑信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlbumRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlbumResponse
        /// </returns>
        public GetAlbumResponse GetAlbum(GetAlbumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAlbumHeaders headers = new GetAlbumHeaders();
            return GetAlbumWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据id获取专辑信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlbumRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlbumResponse
        /// </returns>
        public async Task<GetAlbumResponse> GetAlbumAsync(GetAlbumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAlbumHeaders headers = new GetAlbumHeaders();
            return await GetAlbumWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取专辑数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlbumDetailByIdRequest
        /// </param>
        /// <param name="headers">
        /// GetAlbumDetailByIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlbumDetailByIdResponse
        /// </returns>
        public GetAlbumDetailByIdResponse GetAlbumDetailByIdWithOptions(GetAlbumDetailByIdRequest request, GetAlbumDetailByIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlbumId))
            {
                query["AlbumId"] = request.AlbumId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlbumDetailById",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getAlbumDetailById",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlbumDetailByIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取专辑数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlbumDetailByIdRequest
        /// </param>
        /// <param name="headers">
        /// GetAlbumDetailByIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlbumDetailByIdResponse
        /// </returns>
        public async Task<GetAlbumDetailByIdResponse> GetAlbumDetailByIdWithOptionsAsync(GetAlbumDetailByIdRequest request, GetAlbumDetailByIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlbumId))
            {
                query["AlbumId"] = request.AlbumId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlbumDetailById",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getAlbumDetailById",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlbumDetailByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取专辑数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlbumDetailByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlbumDetailByIdResponse
        /// </returns>
        public GetAlbumDetailByIdResponse GetAlbumDetailById(GetAlbumDetailByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAlbumDetailByIdHeaders headers = new GetAlbumDetailByIdHeaders();
            return GetAlbumDetailByIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取专辑数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlbumDetailByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlbumDetailByIdResponse
        /// </returns>
        public async Task<GetAlbumDetailByIdResponse> GetAlbumDetailByIdAsync(GetAlbumDetailByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAlbumDetailByIdHeaders headers = new GetAlbumDetailByIdHeaders();
            return await GetAlbumDetailByIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取三方绑定的精灵账号信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAligenieUserInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetAligenieUserInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAligenieUserInfoResponse
        /// </returns>
        public GetAligenieUserInfoResponse GetAligenieUserInfoWithOptions(GetAligenieUserInfoRequest request, GetAligenieUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginStateAccessToken))
            {
                query["LoginStateAccessToken"] = request.LoginStateAccessToken;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAligenieUserInfo",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getAligenieUserInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAligenieUserInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取三方绑定的精灵账号信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAligenieUserInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetAligenieUserInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAligenieUserInfoResponse
        /// </returns>
        public async Task<GetAligenieUserInfoResponse> GetAligenieUserInfoWithOptionsAsync(GetAligenieUserInfoRequest request, GetAligenieUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginStateAccessToken))
            {
                query["LoginStateAccessToken"] = request.LoginStateAccessToken;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAligenieUserInfo",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getAligenieUserInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAligenieUserInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取三方绑定的精灵账号信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAligenieUserInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAligenieUserInfoResponse
        /// </returns>
        public GetAligenieUserInfoResponse GetAligenieUserInfo(GetAligenieUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAligenieUserInfoHeaders headers = new GetAligenieUserInfoHeaders();
            return GetAligenieUserInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取三方绑定的精灵账号信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAligenieUserInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAligenieUserInfoResponse
        /// </returns>
        public async Task<GetAligenieUserInfoResponse> GetAligenieUserInfoAsync(GetAligenieUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAligenieUserInfoHeaders headers = new GetAligenieUserInfoHeaders();
            return await GetAligenieUserInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取authCode</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetCodeEnhanceRequest
        /// </param>
        /// <param name="headers">
        /// GetCodeEnhanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCodeEnhanceResponse
        /// </returns>
        public GetCodeEnhanceResponse GetCodeEnhanceWithOptions(GetCodeEnhanceRequest tmpReq, GetCodeEnhanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetCodeEnhanceShrinkRequest request = new GetCodeEnhanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChannelInfo))
            {
                request.ChannelInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChannelInfo, "ChannelInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelInfoShrink))
            {
                query["ChannelInfo"] = request.ChannelInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCodeEnhance",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getCodeEnhance",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCodeEnhanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取authCode</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetCodeEnhanceRequest
        /// </param>
        /// <param name="headers">
        /// GetCodeEnhanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCodeEnhanceResponse
        /// </returns>
        public async Task<GetCodeEnhanceResponse> GetCodeEnhanceWithOptionsAsync(GetCodeEnhanceRequest tmpReq, GetCodeEnhanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetCodeEnhanceShrinkRequest request = new GetCodeEnhanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChannelInfo))
            {
                request.ChannelInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChannelInfo, "ChannelInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelInfoShrink))
            {
                query["ChannelInfo"] = request.ChannelInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCodeEnhance",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getCodeEnhance",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCodeEnhanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取authCode</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCodeEnhanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCodeEnhanceResponse
        /// </returns>
        public GetCodeEnhanceResponse GetCodeEnhance(GetCodeEnhanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCodeEnhanceHeaders headers = new GetCodeEnhanceHeaders();
            return GetCodeEnhanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取authCode</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCodeEnhanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCodeEnhanceResponse
        /// </returns>
        public async Task<GetCodeEnhanceResponse> GetCodeEnhanceAsync(GetCodeEnhanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCodeEnhanceHeaders headers = new GetCodeEnhanceHeaders();
            return await GetCodeEnhanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按照特定的id获取内容信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContentRequest
        /// </param>
        /// <param name="headers">
        /// GetContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContentResponse
        /// </returns>
        public GetContentResponse GetContentWithOptions(GetContentRequest request, GetContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContent",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/GetContent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按照特定的id获取内容信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContentRequest
        /// </param>
        /// <param name="headers">
        /// GetContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContentResponse
        /// </returns>
        public async Task<GetContentResponse> GetContentWithOptionsAsync(GetContentRequest request, GetContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContent",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/GetContent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按照特定的id获取内容信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContentResponse
        /// </returns>
        public GetContentResponse GetContent(GetContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetContentHeaders headers = new GetContentHeaders();
            return GetContentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按照特定的id获取内容信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContentResponse
        /// </returns>
        public async Task<GetContentResponse> GetContentAsync(GetContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetContentHeaders headers = new GetContentHeaders();
            return await GetContentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前播放项</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetCurrentPlayingItemRequest
        /// </param>
        /// <param name="headers">
        /// GetCurrentPlayingItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCurrentPlayingItemResponse
        /// </returns>
        public GetCurrentPlayingItemResponse GetCurrentPlayingItemWithOptions(GetCurrentPlayingItemRequest tmpReq, GetCurrentPlayingItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetCurrentPlayingItemShrinkRequest request = new GetCurrentPlayingItemShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCurrentPlayingItem",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/GetCurrentPlayingItem",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCurrentPlayingItemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前播放项</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetCurrentPlayingItemRequest
        /// </param>
        /// <param name="headers">
        /// GetCurrentPlayingItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCurrentPlayingItemResponse
        /// </returns>
        public async Task<GetCurrentPlayingItemResponse> GetCurrentPlayingItemWithOptionsAsync(GetCurrentPlayingItemRequest tmpReq, GetCurrentPlayingItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetCurrentPlayingItemShrinkRequest request = new GetCurrentPlayingItemShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCurrentPlayingItem",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/GetCurrentPlayingItem",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCurrentPlayingItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前播放项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCurrentPlayingItemRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCurrentPlayingItemResponse
        /// </returns>
        public GetCurrentPlayingItemResponse GetCurrentPlayingItem(GetCurrentPlayingItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCurrentPlayingItemHeaders headers = new GetCurrentPlayingItemHeaders();
            return GetCurrentPlayingItemWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前播放项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCurrentPlayingItemRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCurrentPlayingItemResponse
        /// </returns>
        public async Task<GetCurrentPlayingItemResponse> GetCurrentPlayingItemAsync(GetCurrentPlayingItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCurrentPlayingItemHeaders headers = new GetCurrentPlayingItemHeaders();
            return await GetCurrentPlayingItemWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前播放列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetCurrentPlayingListRequest
        /// </param>
        /// <param name="headers">
        /// GetCurrentPlayingListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCurrentPlayingListResponse
        /// </returns>
        public GetCurrentPlayingListResponse GetCurrentPlayingListWithOptions(GetCurrentPlayingListRequest tmpReq, GetCurrentPlayingListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetCurrentPlayingListShrinkRequest request = new GetCurrentPlayingListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenQueryPlayListRequest))
            {
                request.OpenQueryPlayListRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenQueryPlayListRequest, "OpenQueryPlayListRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenQueryPlayListRequestShrink))
            {
                body["OpenQueryPlayListRequest"] = request.OpenQueryPlayListRequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCurrentPlayingList",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/GetCurrentPlayingList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCurrentPlayingListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前播放列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetCurrentPlayingListRequest
        /// </param>
        /// <param name="headers">
        /// GetCurrentPlayingListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCurrentPlayingListResponse
        /// </returns>
        public async Task<GetCurrentPlayingListResponse> GetCurrentPlayingListWithOptionsAsync(GetCurrentPlayingListRequest tmpReq, GetCurrentPlayingListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetCurrentPlayingListShrinkRequest request = new GetCurrentPlayingListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenQueryPlayListRequest))
            {
                request.OpenQueryPlayListRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenQueryPlayListRequest, "OpenQueryPlayListRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenQueryPlayListRequestShrink))
            {
                body["OpenQueryPlayListRequest"] = request.OpenQueryPlayListRequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCurrentPlayingList",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/GetCurrentPlayingList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCurrentPlayingListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前播放列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCurrentPlayingListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCurrentPlayingListResponse
        /// </returns>
        public GetCurrentPlayingListResponse GetCurrentPlayingList(GetCurrentPlayingListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCurrentPlayingListHeaders headers = new GetCurrentPlayingListHeaders();
            return GetCurrentPlayingListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前播放列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCurrentPlayingListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCurrentPlayingListResponse
        /// </returns>
        public async Task<GetCurrentPlayingListResponse> GetCurrentPlayingListAsync(GetCurrentPlayingListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCurrentPlayingListHeaders headers = new GetCurrentPlayingListHeaders();
            return await GetCurrentPlayingListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备认证信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetDeviceBasicInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetDeviceBasicInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceBasicInfoResponse
        /// </returns>
        public GetDeviceBasicInfoResponse GetDeviceBasicInfoWithOptions(GetDeviceBasicInfoRequest tmpReq, GetDeviceBasicInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDeviceBasicInfoShrinkRequest request = new GetDeviceBasicInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceBasicInfo",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getDeviceBasicInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceBasicInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备认证信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetDeviceBasicInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetDeviceBasicInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceBasicInfoResponse
        /// </returns>
        public async Task<GetDeviceBasicInfoResponse> GetDeviceBasicInfoWithOptionsAsync(GetDeviceBasicInfoRequest tmpReq, GetDeviceBasicInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDeviceBasicInfoShrinkRequest request = new GetDeviceBasicInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceBasicInfo",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getDeviceBasicInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceBasicInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeviceBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceBasicInfoResponse
        /// </returns>
        public GetDeviceBasicInfoResponse GetDeviceBasicInfo(GetDeviceBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeviceBasicInfoHeaders headers = new GetDeviceBasicInfoHeaders();
            return GetDeviceBasicInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeviceBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceBasicInfoResponse
        /// </returns>
        public async Task<GetDeviceBasicInfoResponse> GetDeviceBasicInfoAsync(GetDeviceBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeviceBasicInfoHeaders headers = new GetDeviceBasicInfoHeaders();
            return await GetDeviceBasicInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeviceIdByIdentityRequest
        /// </param>
        /// <param name="headers">
        /// GetDeviceIdByIdentityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceIdByIdentityResponse
        /// </returns>
        public GetDeviceIdByIdentityResponse GetDeviceIdByIdentityWithOptions(GetDeviceIdByIdentityRequest request, GetDeviceIdByIdentityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeKey))
            {
                query["EncodeKey"] = request.EncodeKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeType))
            {
                query["EncodeType"] = request.EncodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityId))
            {
                query["IdentityId"] = request.IdentityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                query["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceIdByIdentity",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getDeviceIdByIdentity",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceIdByIdentityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeviceIdByIdentityRequest
        /// </param>
        /// <param name="headers">
        /// GetDeviceIdByIdentityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceIdByIdentityResponse
        /// </returns>
        public async Task<GetDeviceIdByIdentityResponse> GetDeviceIdByIdentityWithOptionsAsync(GetDeviceIdByIdentityRequest request, GetDeviceIdByIdentityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeKey))
            {
                query["EncodeKey"] = request.EncodeKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeType))
            {
                query["EncodeType"] = request.EncodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityId))
            {
                query["IdentityId"] = request.IdentityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                query["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceIdByIdentity",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getDeviceIdByIdentity",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceIdByIdentityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeviceIdByIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceIdByIdentityResponse
        /// </returns>
        public GetDeviceIdByIdentityResponse GetDeviceIdByIdentity(GetDeviceIdByIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeviceIdByIdentityHeaders headers = new GetDeviceIdByIdentityHeaders();
            return GetDeviceIdByIdentityWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeviceIdByIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceIdByIdentityResponse
        /// </returns>
        public async Task<GetDeviceIdByIdentityResponse> GetDeviceIdByIdentityAsync(GetDeviceIdByIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeviceIdByIdentityHeaders headers = new GetDeviceIdByIdentityHeaders();
            return await GetDeviceIdByIdentityWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备的用户设置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetDeviceSettingRequest
        /// </param>
        /// <param name="headers">
        /// GetDeviceSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceSettingResponse
        /// </returns>
        public GetDeviceSettingResponse GetDeviceSettingWithOptions(GetDeviceSettingRequest tmpReq, GetDeviceSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDeviceSettingShrinkRequest request = new GetDeviceSettingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keys))
            {
                request.KeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keys, "Keys", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeysShrink))
            {
                query["Keys"] = request.KeysShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceSetting",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getDeviceSetting",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceSettingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备的用户设置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetDeviceSettingRequest
        /// </param>
        /// <param name="headers">
        /// GetDeviceSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceSettingResponse
        /// </returns>
        public async Task<GetDeviceSettingResponse> GetDeviceSettingWithOptionsAsync(GetDeviceSettingRequest tmpReq, GetDeviceSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDeviceSettingShrinkRequest request = new GetDeviceSettingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keys))
            {
                request.KeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keys, "Keys", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeysShrink))
            {
                query["Keys"] = request.KeysShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceSetting",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getDeviceSetting",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备的用户设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeviceSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceSettingResponse
        /// </returns>
        public GetDeviceSettingResponse GetDeviceSetting(GetDeviceSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeviceSettingHeaders headers = new GetDeviceSettingHeaders();
            return GetDeviceSettingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备的用户设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeviceSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceSettingResponse
        /// </returns>
        public async Task<GetDeviceSettingResponse> GetDeviceSettingAsync(GetDeviceSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeviceSettingHeaders headers = new GetDeviceSettingHeaders();
            return await GetDeviceSettingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备状态详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetDeviceStatusDetailRequest
        /// </param>
        /// <param name="headers">
        /// GetDeviceStatusDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceStatusDetailResponse
        /// </returns>
        public GetDeviceStatusDetailResponse GetDeviceStatusDetailWithOptions(GetDeviceStatusDetailRequest tmpReq, GetDeviceStatusDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDeviceStatusDetailShrinkRequest request = new GetDeviceStatusDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keys))
            {
                request.KeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keys, "Keys", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeysShrink))
            {
                query["Keys"] = request.KeysShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceStatusDetail",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getDeviceStatusDetail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceStatusDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备状态详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetDeviceStatusDetailRequest
        /// </param>
        /// <param name="headers">
        /// GetDeviceStatusDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceStatusDetailResponse
        /// </returns>
        public async Task<GetDeviceStatusDetailResponse> GetDeviceStatusDetailWithOptionsAsync(GetDeviceStatusDetailRequest tmpReq, GetDeviceStatusDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDeviceStatusDetailShrinkRequest request = new GetDeviceStatusDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keys))
            {
                request.KeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keys, "Keys", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeysShrink))
            {
                query["Keys"] = request.KeysShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceStatusDetail",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getDeviceStatusDetail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceStatusDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备状态详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeviceStatusDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceStatusDetailResponse
        /// </returns>
        public GetDeviceStatusDetailResponse GetDeviceStatusDetail(GetDeviceStatusDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeviceStatusDetailHeaders headers = new GetDeviceStatusDetailHeaders();
            return GetDeviceStatusDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备状态详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeviceStatusDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceStatusDetailResponse
        /// </returns>
        public async Task<GetDeviceStatusDetailResponse> GetDeviceStatusDetailAsync(GetDeviceStatusDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeviceStatusDetailHeaders headers = new GetDeviceStatusDetailHeaders();
            return await GetDeviceStatusDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备状态信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetDeviceStatusInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetDeviceStatusInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceStatusInfoResponse
        /// </returns>
        public GetDeviceStatusInfoResponse GetDeviceStatusInfoWithOptions(GetDeviceStatusInfoRequest tmpReq, GetDeviceStatusInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDeviceStatusInfoShrinkRequest request = new GetDeviceStatusInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceStatusInfo",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getDeviceStatusInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceStatusInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备状态信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetDeviceStatusInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetDeviceStatusInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceStatusInfoResponse
        /// </returns>
        public async Task<GetDeviceStatusInfoResponse> GetDeviceStatusInfoWithOptionsAsync(GetDeviceStatusInfoRequest tmpReq, GetDeviceStatusInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDeviceStatusInfoShrinkRequest request = new GetDeviceStatusInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceStatusInfo",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getDeviceStatusInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceStatusInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备状态信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeviceStatusInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceStatusInfoResponse
        /// </returns>
        public GetDeviceStatusInfoResponse GetDeviceStatusInfo(GetDeviceStatusInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeviceStatusInfoHeaders headers = new GetDeviceStatusInfoHeaders();
            return GetDeviceStatusInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备状态信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeviceStatusInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceStatusInfoResponse
        /// </returns>
        public async Task<GetDeviceStatusInfoResponse> GetDeviceStatusInfoAsync(GetDeviceStatusInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeviceStatusInfoHeaders headers = new GetDeviceStatusInfoHeaders();
            return await GetDeviceStatusInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备标签</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetDeviceTagRequest
        /// </param>
        /// <param name="headers">
        /// GetDeviceTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceTagResponse
        /// </returns>
        public GetDeviceTagResponse GetDeviceTagWithOptions(GetDeviceTagRequest tmpReq, GetDeviceTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDeviceTagShrinkRequest request = new GetDeviceTagShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceTag",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getDeviceTag",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备标签</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetDeviceTagRequest
        /// </param>
        /// <param name="headers">
        /// GetDeviceTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceTagResponse
        /// </returns>
        public async Task<GetDeviceTagResponse> GetDeviceTagWithOptionsAsync(GetDeviceTagRequest tmpReq, GetDeviceTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDeviceTagShrinkRequest request = new GetDeviceTagShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceTag",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getDeviceTag",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeviceTagRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceTagResponse
        /// </returns>
        public GetDeviceTagResponse GetDeviceTag(GetDeviceTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeviceTagHeaders headers = new GetDeviceTagHeaders();
            return GetDeviceTagWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeviceTagRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceTagResponse
        /// </returns>
        public async Task<GetDeviceTagResponse> GetDeviceTagAsync(GetDeviceTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeviceTagHeaders headers = new GetDeviceTagHeaders();
            return await GetDeviceTagWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>江苏电信号百</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJiangSuTelecomDataRequest
        /// </param>
        /// <param name="headers">
        /// GetJiangSuTelecomDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJiangSuTelecomDataResponse
        /// </returns>
        public GetJiangSuTelecomDataResponse GetJiangSuTelecomDataWithOptions(GetJiangSuTelecomDataRequest request, GetJiangSuTelecomDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["Date"] = request.Date;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJiangSuTelecomData",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/GetJiangSuTelecomData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJiangSuTelecomDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>江苏电信号百</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJiangSuTelecomDataRequest
        /// </param>
        /// <param name="headers">
        /// GetJiangSuTelecomDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJiangSuTelecomDataResponse
        /// </returns>
        public async Task<GetJiangSuTelecomDataResponse> GetJiangSuTelecomDataWithOptionsAsync(GetJiangSuTelecomDataRequest request, GetJiangSuTelecomDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["Date"] = request.Date;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJiangSuTelecomData",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/GetJiangSuTelecomData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJiangSuTelecomDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>江苏电信号百</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJiangSuTelecomDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJiangSuTelecomDataResponse
        /// </returns>
        public GetJiangSuTelecomDataResponse GetJiangSuTelecomData(GetJiangSuTelecomDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJiangSuTelecomDataHeaders headers = new GetJiangSuTelecomDataHeaders();
            return GetJiangSuTelecomDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>江苏电信号百</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJiangSuTelecomDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJiangSuTelecomDataResponse
        /// </returns>
        public async Task<GetJiangSuTelecomDataResponse> GetJiangSuTelecomDataAsync(GetJiangSuTelecomDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJiangSuTelecomDataHeaders headers = new GetJiangSuTelecomDataHeaders();
            return await GetJiangSuTelecomDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询定时任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetScheduleTaskRequest
        /// </param>
        /// <param name="headers">
        /// GetScheduleTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScheduleTaskResponse
        /// </returns>
        public GetScheduleTaskResponse GetScheduleTaskWithOptions(GetScheduleTaskRequest tmpReq, GetScheduleTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetScheduleTaskShrinkRequest request = new GetScheduleTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "GetScheduleTask",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/GetScheduleTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScheduleTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询定时任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetScheduleTaskRequest
        /// </param>
        /// <param name="headers">
        /// GetScheduleTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScheduleTaskResponse
        /// </returns>
        public async Task<GetScheduleTaskResponse> GetScheduleTaskWithOptionsAsync(GetScheduleTaskRequest tmpReq, GetScheduleTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetScheduleTaskShrinkRequest request = new GetScheduleTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "GetScheduleTask",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/GetScheduleTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScheduleTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询定时任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduleTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScheduleTaskResponse
        /// </returns>
        public GetScheduleTaskResponse GetScheduleTask(GetScheduleTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetScheduleTaskHeaders headers = new GetScheduleTaskHeaders();
            return GetScheduleTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询定时任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduleTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScheduleTaskResponse
        /// </returns>
        public async Task<GetScheduleTaskResponse> GetScheduleTaskAsync(GetScheduleTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetScheduleTaskHeaders headers = new GetScheduleTaskHeaders();
            return await GetScheduleTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询未读留言数量</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetUnreadMessageCountRequest
        /// </param>
        /// <param name="headers">
        /// GetUnreadMessageCountHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUnreadMessageCountResponse
        /// </returns>
        public GetUnreadMessageCountResponse GetUnreadMessageCountWithOptions(GetUnreadMessageCountRequest tmpReq, GetUnreadMessageCountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetUnreadMessageCountShrinkRequest request = new GetUnreadMessageCountShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUnreadMessageCount",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getUnreadMessageCount",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUnreadMessageCountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询未读留言数量</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetUnreadMessageCountRequest
        /// </param>
        /// <param name="headers">
        /// GetUnreadMessageCountHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUnreadMessageCountResponse
        /// </returns>
        public async Task<GetUnreadMessageCountResponse> GetUnreadMessageCountWithOptionsAsync(GetUnreadMessageCountRequest tmpReq, GetUnreadMessageCountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetUnreadMessageCountShrinkRequest request = new GetUnreadMessageCountShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUnreadMessageCount",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getUnreadMessageCount",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUnreadMessageCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询未读留言数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUnreadMessageCountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUnreadMessageCountResponse
        /// </returns>
        public GetUnreadMessageCountResponse GetUnreadMessageCount(GetUnreadMessageCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUnreadMessageCountHeaders headers = new GetUnreadMessageCountHeaders();
            return GetUnreadMessageCountWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询未读留言数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUnreadMessageCountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUnreadMessageCountResponse
        /// </returns>
        public async Task<GetUnreadMessageCountResponse> GetUnreadMessageCountAsync(GetUnreadMessageCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUnreadMessageCountHeaders headers = new GetUnreadMessageCountHeaders();
            return await GetUnreadMessageCountWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备绑定的用户</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetUserByDeviceIdRequest
        /// </param>
        /// <param name="headers">
        /// GetUserByDeviceIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserByDeviceIdResponse
        /// </returns>
        public GetUserByDeviceIdResponse GetUserByDeviceIdWithOptions(GetUserByDeviceIdRequest tmpReq, GetUserByDeviceIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetUserByDeviceIdShrinkRequest request = new GetUserByDeviceIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserByDeviceId",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getUserByDeviceId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserByDeviceIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备绑定的用户</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetUserByDeviceIdRequest
        /// </param>
        /// <param name="headers">
        /// GetUserByDeviceIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserByDeviceIdResponse
        /// </returns>
        public async Task<GetUserByDeviceIdResponse> GetUserByDeviceIdWithOptionsAsync(GetUserByDeviceIdRequest tmpReq, GetUserByDeviceIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetUserByDeviceIdShrinkRequest request = new GetUserByDeviceIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserByDeviceId",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/getUserByDeviceId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserByDeviceIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备绑定的用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserByDeviceIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserByDeviceIdResponse
        /// </returns>
        public GetUserByDeviceIdResponse GetUserByDeviceId(GetUserByDeviceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserByDeviceIdHeaders headers = new GetUserByDeviceIdHeaders();
            return GetUserByDeviceIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备绑定的用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserByDeviceIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserByDeviceIdResponse
        /// </returns>
        public async Task<GetUserByDeviceIdResponse> GetUserByDeviceIdAsync(GetUserByDeviceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserByDeviceIdHeaders headers = new GetUserByDeviceIdHeaders();
            return await GetUserByDeviceIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询天气</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetWeatherRequest
        /// </param>
        /// <param name="headers">
        /// GetWeatherHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWeatherResponse
        /// </returns>
        public GetWeatherResponse GetWeatherWithOptions(GetWeatherRequest tmpReq, GetWeatherHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetWeatherShrinkRequest request = new GetWeatherShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "GetWeather",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/GetWeather",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWeatherResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询天气</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetWeatherRequest
        /// </param>
        /// <param name="headers">
        /// GetWeatherHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWeatherResponse
        /// </returns>
        public async Task<GetWeatherResponse> GetWeatherWithOptionsAsync(GetWeatherRequest tmpReq, GetWeatherHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetWeatherShrinkRequest request = new GetWeatherShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "GetWeather",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/GetWeather",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWeatherResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询天气</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWeatherRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWeatherResponse
        /// </returns>
        public GetWeatherResponse GetWeather(GetWeatherRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWeatherHeaders headers = new GetWeatherHeaders();
            return GetWeatherWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询天气</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWeatherRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWeatherResponse
        /// </returns>
        public async Task<GetWeatherResponse> GetWeatherAsync(GetWeatherRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWeatherHeaders headers = new GetWeatherHeaders();
            return await GetWeatherWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>播放列表点击播放</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// IndexControlPlayingListRequest
        /// </param>
        /// <param name="headers">
        /// IndexControlPlayingListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IndexControlPlayingListResponse
        /// </returns>
        public IndexControlPlayingListResponse IndexControlPlayingListWithOptions(IndexControlPlayingListRequest tmpReq, IndexControlPlayingListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            IndexControlPlayingListShrinkRequest request = new IndexControlPlayingListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenIndexControlRequest))
            {
                request.OpenIndexControlRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenIndexControlRequest, "OpenIndexControlRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenIndexControlRequestShrink))
            {
                body["OpenIndexControlRequest"] = request.OpenIndexControlRequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IndexControlPlayingList",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/IndexControlPlayingList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndexControlPlayingListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>播放列表点击播放</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// IndexControlPlayingListRequest
        /// </param>
        /// <param name="headers">
        /// IndexControlPlayingListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IndexControlPlayingListResponse
        /// </returns>
        public async Task<IndexControlPlayingListResponse> IndexControlPlayingListWithOptionsAsync(IndexControlPlayingListRequest tmpReq, IndexControlPlayingListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            IndexControlPlayingListShrinkRequest request = new IndexControlPlayingListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenIndexControlRequest))
            {
                request.OpenIndexControlRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenIndexControlRequest, "OpenIndexControlRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenIndexControlRequestShrink))
            {
                body["OpenIndexControlRequest"] = request.OpenIndexControlRequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IndexControlPlayingList",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/IndexControlPlayingList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndexControlPlayingListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>播放列表点击播放</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IndexControlPlayingListRequest
        /// </param>
        /// 
        /// <returns>
        /// IndexControlPlayingListResponse
        /// </returns>
        public IndexControlPlayingListResponse IndexControlPlayingList(IndexControlPlayingListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndexControlPlayingListHeaders headers = new IndexControlPlayingListHeaders();
            return IndexControlPlayingListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>播放列表点击播放</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IndexControlPlayingListRequest
        /// </param>
        /// 
        /// <returns>
        /// IndexControlPlayingListResponse
        /// </returns>
        public async Task<IndexControlPlayingListResponse> IndexControlPlayingListAsync(IndexControlPlayingListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndexControlPlayingListHeaders headers = new IndexControlPlayingListHeaders();
            return await IndexControlPlayingListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>失效三方应用登录态</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// InvalidateThirdPartyAppLoginStateRequest
        /// </param>
        /// <param name="headers">
        /// InvalidateThirdPartyAppLoginStateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvalidateThirdPartyAppLoginStateResponse
        /// </returns>
        public InvalidateThirdPartyAppLoginStateResponse InvalidateThirdPartyAppLoginStateWithOptions(InvalidateThirdPartyAppLoginStateRequest tmpReq, InvalidateThirdPartyAppLoginStateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InvalidateThirdPartyAppLoginStateShrinkRequest request = new InvalidateThirdPartyAppLoginStateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyAppId))
            {
                body["ThirdPartyAppId"] = request.ThirdPartyAppId;
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
                Action = "InvalidateThirdPartyAppLoginState",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/invalidateThirdPartyAppLoginState",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvalidateThirdPartyAppLoginStateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>失效三方应用登录态</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// InvalidateThirdPartyAppLoginStateRequest
        /// </param>
        /// <param name="headers">
        /// InvalidateThirdPartyAppLoginStateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvalidateThirdPartyAppLoginStateResponse
        /// </returns>
        public async Task<InvalidateThirdPartyAppLoginStateResponse> InvalidateThirdPartyAppLoginStateWithOptionsAsync(InvalidateThirdPartyAppLoginStateRequest tmpReq, InvalidateThirdPartyAppLoginStateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InvalidateThirdPartyAppLoginStateShrinkRequest request = new InvalidateThirdPartyAppLoginStateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyAppId))
            {
                body["ThirdPartyAppId"] = request.ThirdPartyAppId;
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
                Action = "InvalidateThirdPartyAppLoginState",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/invalidateThirdPartyAppLoginState",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvalidateThirdPartyAppLoginStateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>失效三方应用登录态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvalidateThirdPartyAppLoginStateRequest
        /// </param>
        /// 
        /// <returns>
        /// InvalidateThirdPartyAppLoginStateResponse
        /// </returns>
        public InvalidateThirdPartyAppLoginStateResponse InvalidateThirdPartyAppLoginState(InvalidateThirdPartyAppLoginStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvalidateThirdPartyAppLoginStateHeaders headers = new InvalidateThirdPartyAppLoginStateHeaders();
            return InvalidateThirdPartyAppLoginStateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>失效三方应用登录态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvalidateThirdPartyAppLoginStateRequest
        /// </param>
        /// 
        /// <returns>
        /// InvalidateThirdPartyAppLoginStateResponse
        /// </returns>
        public async Task<InvalidateThirdPartyAppLoginStateResponse> InvalidateThirdPartyAppLoginStateAsync(InvalidateThirdPartyAppLoginStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvalidateThirdPartyAppLoginStateHeaders headers = new InvalidateThirdPartyAppLoginStateHeaders();
            return await InvalidateThirdPartyAppLoginStateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闹钟列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAlarmsRequest
        /// </param>
        /// <param name="headers">
        /// ListAlarmsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlarmsResponse
        /// </returns>
        public ListAlarmsResponse ListAlarmsWithOptions(ListAlarmsRequest tmpReq, ListAlarmsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAlarmsShrinkRequest request = new ListAlarmsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "ListAlarms",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listAlarm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlarmsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闹钟列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAlarmsRequest
        /// </param>
        /// <param name="headers">
        /// ListAlarmsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlarmsResponse
        /// </returns>
        public async Task<ListAlarmsResponse> ListAlarmsWithOptionsAsync(ListAlarmsRequest tmpReq, ListAlarmsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAlarmsShrinkRequest request = new ListAlarmsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "ListAlarms",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listAlarm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlarmsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闹钟列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlarmsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlarmsResponse
        /// </returns>
        public ListAlarmsResponse ListAlarms(ListAlarmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAlarmsHeaders headers = new ListAlarmsHeaders();
            return ListAlarmsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询闹钟列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlarmsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlarmsResponse
        /// </returns>
        public async Task<ListAlarmsResponse> ListAlarmsAsync(ListAlarmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAlarmsHeaders headers = new ListAlarmsHeaders();
            return await ListAlarmsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音乐音频专辑里面的内容列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlbumDetailRequest
        /// </param>
        /// <param name="headers">
        /// ListAlbumDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlbumDetailResponse
        /// </returns>
        public ListAlbumDetailResponse ListAlbumDetailWithOptions(ListAlbumDetailRequest request, ListAlbumDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAlbumDetail",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/ListAlbumDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlbumDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音乐音频专辑里面的内容列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlbumDetailRequest
        /// </param>
        /// <param name="headers">
        /// ListAlbumDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlbumDetailResponse
        /// </returns>
        public async Task<ListAlbumDetailResponse> ListAlbumDetailWithOptionsAsync(ListAlbumDetailRequest request, ListAlbumDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAlbumDetail",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/ListAlbumDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlbumDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音乐音频专辑里面的内容列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlbumDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlbumDetailResponse
        /// </returns>
        public ListAlbumDetailResponse ListAlbumDetail(ListAlbumDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAlbumDetailHeaders headers = new ListAlbumDetailHeaders();
            return ListAlbumDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音乐音频专辑里面的内容列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlbumDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlbumDetailResponse
        /// </returns>
        public async Task<ListAlbumDetailResponse> ListAlbumDetailAsync(ListAlbumDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAlbumDetailHeaders headers = new ListAlbumDetailHeaders();
            return await ListAlbumDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专辑是否被订阅</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAlbumIsAddedRequest
        /// </param>
        /// <param name="headers">
        /// ListAlbumIsAddedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlbumIsAddedResponse
        /// </returns>
        public ListAlbumIsAddedResponse ListAlbumIsAddedWithOptions(ListAlbumIsAddedRequest tmpReq, ListAlbumIsAddedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAlbumIsAddedShrinkRequest request = new ListAlbumIsAddedShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AlbumIdList))
            {
                request.AlbumIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AlbumIdList, "AlbumIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlbumIdListShrink))
            {
                query["AlbumIdList"] = request.AlbumIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAlbumIsAdded",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listAlbumIsAdded",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlbumIsAddedResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专辑是否被订阅</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAlbumIsAddedRequest
        /// </param>
        /// <param name="headers">
        /// ListAlbumIsAddedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlbumIsAddedResponse
        /// </returns>
        public async Task<ListAlbumIsAddedResponse> ListAlbumIsAddedWithOptionsAsync(ListAlbumIsAddedRequest tmpReq, ListAlbumIsAddedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAlbumIsAddedShrinkRequest request = new ListAlbumIsAddedShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AlbumIdList))
            {
                request.AlbumIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AlbumIdList, "AlbumIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlbumIdListShrink))
            {
                query["AlbumIdList"] = request.AlbumIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAlbumIsAdded",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listAlbumIsAdded",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlbumIsAddedResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专辑是否被订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlbumIsAddedRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlbumIsAddedResponse
        /// </returns>
        public ListAlbumIsAddedResponse ListAlbumIsAdded(ListAlbumIsAddedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAlbumIsAddedHeaders headers = new ListAlbumIsAddedHeaders();
            return ListAlbumIsAddedWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专辑是否被订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlbumIsAddedRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlbumIsAddedResponse
        /// </returns>
        public async Task<ListAlbumIsAddedResponse> ListAlbumIsAddedAsync(ListAlbumIsAddedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAlbumIsAddedHeaders headers = new ListAlbumIsAddedHeaders();
            return await ListAlbumIsAddedWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据特定的类目,按照指定的排序顺序获取该类目下的内容.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListCateContentRequest
        /// </param>
        /// <param name="headers">
        /// ListCateContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCateContentResponse
        /// </returns>
        public ListCateContentResponse ListCateContentWithOptions(ListCateContentRequest tmpReq, ListCateContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCateContentShrinkRequest request = new ListCateContentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Request))
            {
                request.RequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Request, "Request", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestShrink))
            {
                body["Request"] = request.RequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCateContent",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/ListCateContent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCateContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据特定的类目,按照指定的排序顺序获取该类目下的内容.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListCateContentRequest
        /// </param>
        /// <param name="headers">
        /// ListCateContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCateContentResponse
        /// </returns>
        public async Task<ListCateContentResponse> ListCateContentWithOptionsAsync(ListCateContentRequest tmpReq, ListCateContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCateContentShrinkRequest request = new ListCateContentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Request))
            {
                request.RequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Request, "Request", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestShrink))
            {
                body["Request"] = request.RequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCateContent",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/ListCateContent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCateContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据特定的类目,按照指定的排序顺序获取该类目下的内容.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCateContentRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCateContentResponse
        /// </returns>
        public ListCateContentResponse ListCateContent(ListCateContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCateContentHeaders headers = new ListCateContentHeaders();
            return ListCateContentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据特定的类目,按照指定的排序顺序获取该类目下的内容.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCateContentRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCateContentResponse
        /// </returns>
        public async Task<ListCateContentResponse> ListCateContentAsync(ListCateContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCateContentHeaders headers = new ListCateContentHeaders();
            return await ListCateContentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音乐音频类目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCateInfoRequest
        /// </param>
        /// <param name="headers">
        /// ListCateInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCateInfoResponse
        /// </returns>
        public ListCateInfoResponse ListCateInfoWithOptions(ListCateInfoRequest request, ListCateInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCateInfo",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/ListCateInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCateInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音乐音频类目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCateInfoRequest
        /// </param>
        /// <param name="headers">
        /// ListCateInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCateInfoResponse
        /// </returns>
        public async Task<ListCateInfoResponse> ListCateInfoWithOptionsAsync(ListCateInfoRequest request, ListCateInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCateInfo",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/ListCateInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCateInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音乐音频类目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCateInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCateInfoResponse
        /// </returns>
        public ListCateInfoResponse ListCateInfo(ListCateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCateInfoHeaders headers = new ListCateInfoHeaders();
            return ListCateInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音乐音频类目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCateInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCateInfoResponse
        /// </returns>
        public async Task<ListCateInfoResponse> ListCateInfoAsync(ListCateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCateInfoHeaders headers = new ListCateInfoHeaders();
            return await ListCateInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音乐/音频的一级类目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCommonCateFirstFloorRequest
        /// </param>
        /// <param name="headers">
        /// ListCommonCateFirstFloorHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCommonCateFirstFloorResponse
        /// </returns>
        public ListCommonCateFirstFloorResponse ListCommonCateFirstFloorWithOptions(ListCommonCateFirstFloorRequest request, ListCommonCateFirstFloorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCommonCateFirstFloor",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/ListCommonCateFirstFloor",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCommonCateFirstFloorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音乐/音频的一级类目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCommonCateFirstFloorRequest
        /// </param>
        /// <param name="headers">
        /// ListCommonCateFirstFloorHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCommonCateFirstFloorResponse
        /// </returns>
        public async Task<ListCommonCateFirstFloorResponse> ListCommonCateFirstFloorWithOptionsAsync(ListCommonCateFirstFloorRequest request, ListCommonCateFirstFloorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCommonCateFirstFloor",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/ListCommonCateFirstFloor",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCommonCateFirstFloorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音乐/音频的一级类目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCommonCateFirstFloorRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCommonCateFirstFloorResponse
        /// </returns>
        public ListCommonCateFirstFloorResponse ListCommonCateFirstFloor(ListCommonCateFirstFloorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCommonCateFirstFloorHeaders headers = new ListCommonCateFirstFloorHeaders();
            return ListCommonCateFirstFloorWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取音乐/音频的一级类目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCommonCateFirstFloorRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCommonCateFirstFloorResponse
        /// </returns>
        public async Task<ListCommonCateFirstFloorResponse> ListCommonCateFirstFloorAsync(ListCommonCateFirstFloorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCommonCateFirstFloorHeaders headers = new ListCommonCateFirstFloorHeaders();
            return await ListCommonCateFirstFloorWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定一级类目下面的二级类目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCommonCateSecondFloorRequest
        /// </param>
        /// <param name="headers">
        /// ListCommonCateSecondFloorHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCommonCateSecondFloorResponse
        /// </returns>
        public ListCommonCateSecondFloorResponse ListCommonCateSecondFloorWithOptions(ListCommonCateSecondFloorRequest request, ListCommonCateSecondFloorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCateId))
            {
                query["ParentCateId"] = request.ParentCateId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCommonCateSecondFloor",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/ListCommonCateSecondFloor",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCommonCateSecondFloorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定一级类目下面的二级类目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCommonCateSecondFloorRequest
        /// </param>
        /// <param name="headers">
        /// ListCommonCateSecondFloorHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCommonCateSecondFloorResponse
        /// </returns>
        public async Task<ListCommonCateSecondFloorResponse> ListCommonCateSecondFloorWithOptionsAsync(ListCommonCateSecondFloorRequest request, ListCommonCateSecondFloorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCateId))
            {
                query["ParentCateId"] = request.ParentCateId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCommonCateSecondFloor",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/ListCommonCateSecondFloor",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCommonCateSecondFloorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定一级类目下面的二级类目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCommonCateSecondFloorRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCommonCateSecondFloorResponse
        /// </returns>
        public ListCommonCateSecondFloorResponse ListCommonCateSecondFloor(ListCommonCateSecondFloorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCommonCateSecondFloorHeaders headers = new ListCommonCateSecondFloorHeaders();
            return ListCommonCateSecondFloorWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定一级类目下面的二级类目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCommonCateSecondFloorRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCommonCateSecondFloorResponse
        /// </returns>
        public async Task<ListCommonCateSecondFloorResponse> ListCommonCateSecondFloorAsync(ListCommonCateSecondFloorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCommonCateSecondFloorHeaders headers = new ListCommonCateSecondFloorHeaders();
            return await ListCommonCateSecondFloorWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取设备基本信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDeviceBasicInfoRequest
        /// </param>
        /// <param name="headers">
        /// ListDeviceBasicInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceBasicInfoResponse
        /// </returns>
        public ListDeviceBasicInfoResponse ListDeviceBasicInfoWithOptions(ListDeviceBasicInfoRequest tmpReq, ListDeviceBasicInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDeviceBasicInfoShrinkRequest request = new ListDeviceBasicInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfos))
            {
                request.DeviceInfosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfos, "DeviceInfos", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfosShrink))
            {
                query["DeviceInfos"] = request.DeviceInfosShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeviceBasicInfo",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listDeviceBasicInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceBasicInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取设备基本信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDeviceBasicInfoRequest
        /// </param>
        /// <param name="headers">
        /// ListDeviceBasicInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceBasicInfoResponse
        /// </returns>
        public async Task<ListDeviceBasicInfoResponse> ListDeviceBasicInfoWithOptionsAsync(ListDeviceBasicInfoRequest tmpReq, ListDeviceBasicInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDeviceBasicInfoShrinkRequest request = new ListDeviceBasicInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfos))
            {
                request.DeviceInfosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfos, "DeviceInfos", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfosShrink))
            {
                query["DeviceInfos"] = request.DeviceInfosShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeviceBasicInfo",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listDeviceBasicInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceBasicInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取设备基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeviceBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceBasicInfoResponse
        /// </returns>
        public ListDeviceBasicInfoResponse ListDeviceBasicInfo(ListDeviceBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeviceBasicInfoHeaders headers = new ListDeviceBasicInfoHeaders();
            return ListDeviceBasicInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取设备基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeviceBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceBasicInfoResponse
        /// </returns>
        public async Task<ListDeviceBasicInfoResponse> ListDeviceBasicInfoAsync(ListDeviceBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeviceBasicInfoHeaders headers = new ListDeviceBasicInfoHeaders();
            return await ListDeviceBasicInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户名下的设备</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDeviceByUserIdRequest
        /// </param>
        /// <param name="headers">
        /// ListDeviceByUserIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceByUserIdResponse
        /// </returns>
        public ListDeviceByUserIdResponse ListDeviceByUserIdWithOptions(ListDeviceByUserIdRequest tmpReq, ListDeviceByUserIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDeviceByUserIdShrinkRequest request = new ListDeviceByUserIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeviceByUserId",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listDeviceByUserId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceByUserIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户名下的设备</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDeviceByUserIdRequest
        /// </param>
        /// <param name="headers">
        /// ListDeviceByUserIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceByUserIdResponse
        /// </returns>
        public async Task<ListDeviceByUserIdResponse> ListDeviceByUserIdWithOptionsAsync(ListDeviceByUserIdRequest tmpReq, ListDeviceByUserIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDeviceByUserIdShrinkRequest request = new ListDeviceByUserIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeviceByUserId",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listDeviceByUserId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceByUserIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户名下的设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeviceByUserIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceByUserIdResponse
        /// </returns>
        public ListDeviceByUserIdResponse ListDeviceByUserId(ListDeviceByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeviceByUserIdHeaders headers = new ListDeviceByUserIdHeaders();
            return ListDeviceByUserIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户名下的设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeviceByUserIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceByUserIdResponse
        /// </returns>
        public async Task<ListDeviceByUserIdResponse> ListDeviceByUserIdAsync(ListDeviceByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeviceByUserIdHeaders headers = new ListDeviceByUserIdHeaders();
            return await ListDeviceByUserIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定渠道的设备列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDeviceByUserIdAndChanelRequest
        /// </param>
        /// <param name="headers">
        /// ListDeviceByUserIdAndChanelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceByUserIdAndChanelResponse
        /// </returns>
        public ListDeviceByUserIdAndChanelResponse ListDeviceByUserIdAndChanelWithOptions(ListDeviceByUserIdAndChanelRequest tmpReq, ListDeviceByUserIdAndChanelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDeviceByUserIdAndChanelShrinkRequest request = new ListDeviceByUserIdAndChanelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChannelInfo))
            {
                request.ChannelInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChannelInfo, "ChannelInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelInfoShrink))
            {
                query["ChannelInfo"] = request.ChannelInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeviceByUserIdAndChanel",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listDeviceByUserIdAndChanel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceByUserIdAndChanelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定渠道的设备列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDeviceByUserIdAndChanelRequest
        /// </param>
        /// <param name="headers">
        /// ListDeviceByUserIdAndChanelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceByUserIdAndChanelResponse
        /// </returns>
        public async Task<ListDeviceByUserIdAndChanelResponse> ListDeviceByUserIdAndChanelWithOptionsAsync(ListDeviceByUserIdAndChanelRequest tmpReq, ListDeviceByUserIdAndChanelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDeviceByUserIdAndChanelShrinkRequest request = new ListDeviceByUserIdAndChanelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChannelInfo))
            {
                request.ChannelInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChannelInfo, "ChannelInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelInfoShrink))
            {
                query["ChannelInfo"] = request.ChannelInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeviceByUserIdAndChanel",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listDeviceByUserIdAndChanel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceByUserIdAndChanelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定渠道的设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeviceByUserIdAndChanelRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceByUserIdAndChanelResponse
        /// </returns>
        public ListDeviceByUserIdAndChanelResponse ListDeviceByUserIdAndChanel(ListDeviceByUserIdAndChanelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeviceByUserIdAndChanelHeaders headers = new ListDeviceByUserIdAndChanelHeaders();
            return ListDeviceByUserIdAndChanelWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定渠道的设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeviceByUserIdAndChanelRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceByUserIdAndChanelResponse
        /// </returns>
        public async Task<ListDeviceByUserIdAndChanelResponse> ListDeviceByUserIdAndChanelAsync(ListDeviceByUserIdAndChanelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeviceByUserIdAndChanelHeaders headers = new ListDeviceByUserIdAndChanelHeaders();
            return await ListDeviceByUserIdAndChanelWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取设备openId</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDeviceIdByIdentitiesRequest
        /// </param>
        /// <param name="headers">
        /// ListDeviceIdByIdentitiesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceIdByIdentitiesResponse
        /// </returns>
        public ListDeviceIdByIdentitiesResponse ListDeviceIdByIdentitiesWithOptions(ListDeviceIdByIdentitiesRequest tmpReq, ListDeviceIdByIdentitiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDeviceIdByIdentitiesShrinkRequest request = new ListDeviceIdByIdentitiesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IdentityIds))
            {
                request.IdentityIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IdentityIds, "IdentityIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeKey))
            {
                query["EncodeKey"] = request.EncodeKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeType))
            {
                query["EncodeType"] = request.EncodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityIdsShrink))
            {
                query["IdentityIds"] = request.IdentityIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                query["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeviceIdByIdentities",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listDeviceIdByIdentities",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceIdByIdentitiesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取设备openId</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDeviceIdByIdentitiesRequest
        /// </param>
        /// <param name="headers">
        /// ListDeviceIdByIdentitiesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceIdByIdentitiesResponse
        /// </returns>
        public async Task<ListDeviceIdByIdentitiesResponse> ListDeviceIdByIdentitiesWithOptionsAsync(ListDeviceIdByIdentitiesRequest tmpReq, ListDeviceIdByIdentitiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDeviceIdByIdentitiesShrinkRequest request = new ListDeviceIdByIdentitiesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IdentityIds))
            {
                request.IdentityIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IdentityIds, "IdentityIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeKey))
            {
                query["EncodeKey"] = request.EncodeKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeType))
            {
                query["EncodeType"] = request.EncodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityIdsShrink))
            {
                query["IdentityIds"] = request.IdentityIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                query["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeviceIdByIdentities",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listDeviceIdByIdentities",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceIdByIdentitiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取设备openId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeviceIdByIdentitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceIdByIdentitiesResponse
        /// </returns>
        public ListDeviceIdByIdentitiesResponse ListDeviceIdByIdentities(ListDeviceIdByIdentitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeviceIdByIdentitiesHeaders headers = new ListDeviceIdByIdentitiesHeaders();
            return ListDeviceIdByIdentitiesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取设备openId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeviceIdByIdentitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceIdByIdentitiesResponse
        /// </returns>
        public async Task<ListDeviceIdByIdentitiesResponse> ListDeviceIdByIdentitiesAsync(ListDeviceIdByIdentitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeviceIdByIdentitiesHeaders headers = new ListDeviceIdByIdentitiesHeaders();
            return await ListDeviceIdByIdentitiesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于音乐类型查询铃声列表（分页）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListMusicRequest
        /// </param>
        /// <param name="headers">
        /// ListMusicHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMusicResponse
        /// </returns>
        public ListMusicResponse ListMusicWithOptions(ListMusicRequest tmpReq, ListMusicHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListMusicShrinkRequest request = new ListMusicShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "ListMusic",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listMusic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMusicResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于音乐类型查询铃声列表（分页）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListMusicRequest
        /// </param>
        /// <param name="headers">
        /// ListMusicHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMusicResponse
        /// </returns>
        public async Task<ListMusicResponse> ListMusicWithOptionsAsync(ListMusicRequest tmpReq, ListMusicHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListMusicShrinkRequest request = new ListMusicShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "ListMusic",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listMusic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMusicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于音乐类型查询铃声列表（分页）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMusicRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMusicResponse
        /// </returns>
        public ListMusicResponse ListMusic(ListMusicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMusicHeaders headers = new ListMusicHeaders();
            return ListMusicWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于音乐类型查询铃声列表（分页）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMusicRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMusicResponse
        /// </returns>
        public async Task<ListMusicResponse> ListMusicAsync(ListMusicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMusicHeaders headers = new ListMusicHeaders();
            return await ListMusicWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户的播放历史</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListPlayHistoryRequest
        /// </param>
        /// <param name="headers">
        /// ListPlayHistoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPlayHistoryResponse
        /// </returns>
        public ListPlayHistoryResponse ListPlayHistoryWithOptions(ListPlayHistoryRequest tmpReq, ListPlayHistoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPlayHistoryShrinkRequest request = new ListPlayHistoryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Request))
            {
                request.RequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Request, "Request", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestShrink))
            {
                body["Request"] = request.RequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPlayHistory",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/ListPlayHistory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPlayHistoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户的播放历史</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListPlayHistoryRequest
        /// </param>
        /// <param name="headers">
        /// ListPlayHistoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPlayHistoryResponse
        /// </returns>
        public async Task<ListPlayHistoryResponse> ListPlayHistoryWithOptionsAsync(ListPlayHistoryRequest tmpReq, ListPlayHistoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPlayHistoryShrinkRequest request = new ListPlayHistoryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Request))
            {
                request.RequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Request, "Request", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestShrink))
            {
                body["Request"] = request.RequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPlayHistory",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/ListPlayHistory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPlayHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户的播放历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPlayHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPlayHistoryResponse
        /// </returns>
        public ListPlayHistoryResponse ListPlayHistory(ListPlayHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPlayHistoryHeaders headers = new ListPlayHistoryHeaders();
            return ListPlayHistoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户的播放历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPlayHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPlayHistoryResponse
        /// </returns>
        public async Task<ListPlayHistoryResponse> ListPlayHistoryAsync(ListPlayHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPlayHistoryHeaders headers = new ListPlayHistoryHeaders();
            return await ListPlayHistoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取每日推荐的音乐或者音频</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListRecommendContentRequest
        /// </param>
        /// <param name="headers">
        /// ListRecommendContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRecommendContentResponse
        /// </returns>
        public ListRecommendContentResponse ListRecommendContentWithOptions(ListRecommendContentRequest tmpReq, ListRecommendContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListRecommendContentShrinkRequest request = new ListRecommendContentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Request))
            {
                request.RequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Request, "Request", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestShrink))
            {
                body["Request"] = request.RequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecommendContent",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/ListRecommendContent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecommendContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取每日推荐的音乐或者音频</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListRecommendContentRequest
        /// </param>
        /// <param name="headers">
        /// ListRecommendContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRecommendContentResponse
        /// </returns>
        public async Task<ListRecommendContentResponse> ListRecommendContentWithOptionsAsync(ListRecommendContentRequest tmpReq, ListRecommendContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListRecommendContentShrinkRequest request = new ListRecommendContentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Request))
            {
                request.RequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Request, "Request", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestShrink))
            {
                body["Request"] = request.RequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecommendContent",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/ListRecommendContent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecommendContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取每日推荐的音乐或者音频</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRecommendContentRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRecommendContentResponse
        /// </returns>
        public ListRecommendContentResponse ListRecommendContent(ListRecommendContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRecommendContentHeaders headers = new ListRecommendContentHeaders();
            return ListRecommendContentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取每日推荐的音乐或者音频</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRecommendContentRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRecommendContentResponse
        /// </returns>
        public async Task<ListRecommendContentResponse> ListRecommendContentAsync(ListRecommendContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRecommendContentHeaders headers = new ListRecommendContentHeaders();
            return await ListRecommendContentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListSubRequest
        /// </param>
        /// <param name="headers">
        /// ListSubHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubResponse
        /// </returns>
        public ListSubResponse ListSubWithOptions(ListSubRequest tmpReq, ListSubHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSubShrinkRequest request = new ListSubShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Page))
            {
                request.PageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Page, "Page", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageShrink))
            {
                query["Page"] = request.PageShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSub",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listSub",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListSubRequest
        /// </param>
        /// <param name="headers">
        /// ListSubHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubResponse
        /// </returns>
        public async Task<ListSubResponse> ListSubWithOptionsAsync(ListSubRequest tmpReq, ListSubHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSubShrinkRequest request = new ListSubShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Page))
            {
                request.PageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Page, "Page", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageShrink))
            {
                query["Page"] = request.PageShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSub",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listSub",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubResponse
        /// </returns>
        public ListSubResponse ListSub(ListSubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSubHeaders headers = new ListSubHeaders();
            return ListSubWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubResponse
        /// </returns>
        public async Task<ListSubResponse> ListSubAsync(ListSubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSubHeaders headers = new ListSubHeaders();
            return await ListSubWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅专辑元数据列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListSubAlbumRequest
        /// </param>
        /// <param name="headers">
        /// ListSubAlbumHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubAlbumResponse
        /// </returns>
        public ListSubAlbumResponse ListSubAlbumWithOptions(ListSubAlbumRequest tmpReq, ListSubAlbumHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSubAlbumShrinkRequest request = new ListSubAlbumShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QuerySubscriptionAlbumRequest))
            {
                request.QuerySubscriptionAlbumRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QuerySubscriptionAlbumRequest, "QuerySubscriptionAlbumRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuerySubscriptionAlbumRequestShrink))
            {
                query["QuerySubscriptionAlbumRequest"] = request.QuerySubscriptionAlbumRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubAlbum",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listSubAlbum",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubAlbumResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅专辑元数据列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListSubAlbumRequest
        /// </param>
        /// <param name="headers">
        /// ListSubAlbumHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubAlbumResponse
        /// </returns>
        public async Task<ListSubAlbumResponse> ListSubAlbumWithOptionsAsync(ListSubAlbumRequest tmpReq, ListSubAlbumHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSubAlbumShrinkRequest request = new ListSubAlbumShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QuerySubscriptionAlbumRequest))
            {
                request.QuerySubscriptionAlbumRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QuerySubscriptionAlbumRequest, "QuerySubscriptionAlbumRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuerySubscriptionAlbumRequestShrink))
            {
                query["QuerySubscriptionAlbumRequest"] = request.QuerySubscriptionAlbumRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubAlbum",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listSubAlbum",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubAlbumResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅专辑元数据列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubAlbumRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubAlbumResponse
        /// </returns>
        public ListSubAlbumResponse ListSubAlbum(ListSubAlbumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSubAlbumHeaders headers = new ListSubAlbumHeaders();
            return ListSubAlbumWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅专辑元数据列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubAlbumRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubAlbumResponse
        /// </returns>
        public async Task<ListSubAlbumResponse> ListSubAlbumAsync(ListSubAlbumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSubAlbumHeaders headers = new ListSubAlbumHeaders();
            return await ListSubAlbumWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容订阅元数据分类</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubscriptionAlbumCategoryRequest
        /// </param>
        /// <param name="headers">
        /// ListSubscriptionAlbumCategoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubscriptionAlbumCategoryResponse
        /// </returns>
        public ListSubscriptionAlbumCategoryResponse ListSubscriptionAlbumCategoryWithOptions(ListSubscriptionAlbumCategoryRequest request, ListSubscriptionAlbumCategoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                query["CategoryName"] = request.CategoryName;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubscriptionAlbumCategory",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listSubscriptionAlbumCategory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubscriptionAlbumCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容订阅元数据分类</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubscriptionAlbumCategoryRequest
        /// </param>
        /// <param name="headers">
        /// ListSubscriptionAlbumCategoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubscriptionAlbumCategoryResponse
        /// </returns>
        public async Task<ListSubscriptionAlbumCategoryResponse> ListSubscriptionAlbumCategoryWithOptionsAsync(ListSubscriptionAlbumCategoryRequest request, ListSubscriptionAlbumCategoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                query["CategoryName"] = request.CategoryName;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubscriptionAlbumCategory",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listSubscriptionAlbumCategory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubscriptionAlbumCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容订阅元数据分类</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubscriptionAlbumCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubscriptionAlbumCategoryResponse
        /// </returns>
        public ListSubscriptionAlbumCategoryResponse ListSubscriptionAlbumCategory(ListSubscriptionAlbumCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSubscriptionAlbumCategoryHeaders headers = new ListSubscriptionAlbumCategoryHeaders();
            return ListSubscriptionAlbumCategoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容订阅元数据分类</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubscriptionAlbumCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubscriptionAlbumCategoryResponse
        /// </returns>
        public async Task<ListSubscriptionAlbumCategoryResponse> ListSubscriptionAlbumCategoryAsync(ListSubscriptionAlbumCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSubscriptionAlbumCategoryHeaders headers = new ListSubscriptionAlbumCategoryHeaders();
            return await ListSubscriptionAlbumCategoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取留言列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListUserMessageRequest
        /// </param>
        /// <param name="headers">
        /// ListUserMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserMessageResponse
        /// </returns>
        public ListUserMessageResponse ListUserMessageWithOptions(ListUserMessageRequest tmpReq, ListUserMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListUserMessageShrinkRequest request = new ListUserMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeforeTime))
            {
                query["BeforeTime"] = request.BeforeTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserMessage",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listUserMessage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取留言列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListUserMessageRequest
        /// </param>
        /// <param name="headers">
        /// ListUserMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserMessageResponse
        /// </returns>
        public async Task<ListUserMessageResponse> ListUserMessageWithOptionsAsync(ListUserMessageRequest tmpReq, ListUserMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListUserMessageShrinkRequest request = new ListUserMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeforeTime))
            {
                query["BeforeTime"] = request.BeforeTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserMessage",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/listUserMessage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取留言列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserMessageResponse
        /// </returns>
        public ListUserMessageResponse ListUserMessage(ListUserMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUserMessageHeaders headers = new ListUserMessageHeaders();
            return ListUserMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取留言列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserMessageResponse
        /// </returns>
        public async Task<ListUserMessageResponse> ListUserMessageAsync(ListUserMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUserMessageHeaders headers = new ListUserMessageHeaders();
            return await ListUserMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移动轻纳管</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// MobileRecommendRequest
        /// </param>
        /// <param name="headers">
        /// MobileRecommendHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MobileRecommendResponse
        /// </returns>
        public MobileRecommendResponse MobileRecommendWithOptions(MobileRecommendRequest tmpReq, MobileRecommendHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            MobileRecommendShrinkRequest request = new MobileRecommendShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BotId))
            {
                query["BotId"] = request.BotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["Count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Style))
            {
                query["Style"] = request.Style;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MobileRecommend",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/mobile/recommend/music",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MobileRecommendResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移动轻纳管</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// MobileRecommendRequest
        /// </param>
        /// <param name="headers">
        /// MobileRecommendHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MobileRecommendResponse
        /// </returns>
        public async Task<MobileRecommendResponse> MobileRecommendWithOptionsAsync(MobileRecommendRequest tmpReq, MobileRecommendHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            MobileRecommendShrinkRequest request = new MobileRecommendShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BotId))
            {
                query["BotId"] = request.BotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["Count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Style))
            {
                query["Style"] = request.Style;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MobileRecommend",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/mobile/recommend/music",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MobileRecommendResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移动轻纳管</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MobileRecommendRequest
        /// </param>
        /// 
        /// <returns>
        /// MobileRecommendResponse
        /// </returns>
        public MobileRecommendResponse MobileRecommend(MobileRecommendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MobileRecommendHeaders headers = new MobileRecommendHeaders();
            return MobileRecommendWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移动轻纳管</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MobileRecommendRequest
        /// </param>
        /// 
        /// <returns>
        /// MobileRecommendResponse
        /// </returns>
        public async Task<MobileRecommendResponse> MobileRecommendAsync(MobileRecommendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MobileRecommendHeaders headers = new MobileRecommendHeaders();
            return await MobileRecommendWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>播放暂停控制</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PlayAndPauseControlRequest
        /// </param>
        /// <param name="headers">
        /// PlayAndPauseControlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PlayAndPauseControlResponse
        /// </returns>
        public PlayAndPauseControlResponse PlayAndPauseControlWithOptions(PlayAndPauseControlRequest tmpReq, PlayAndPauseControlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PlayAndPauseControlShrinkRequest request = new PlayAndPauseControlShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenPlayAndPauseControlParam))
            {
                request.OpenPlayAndPauseControlParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenPlayAndPauseControlParam, "OpenPlayAndPauseControlParam", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenPlayAndPauseControlParamShrink))
            {
                body["OpenPlayAndPauseControlParam"] = request.OpenPlayAndPauseControlParamShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PlayAndPauseControl",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/PlayAndPauseControl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PlayAndPauseControlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>播放暂停控制</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PlayAndPauseControlRequest
        /// </param>
        /// <param name="headers">
        /// PlayAndPauseControlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PlayAndPauseControlResponse
        /// </returns>
        public async Task<PlayAndPauseControlResponse> PlayAndPauseControlWithOptionsAsync(PlayAndPauseControlRequest tmpReq, PlayAndPauseControlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PlayAndPauseControlShrinkRequest request = new PlayAndPauseControlShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenPlayAndPauseControlParam))
            {
                request.OpenPlayAndPauseControlParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenPlayAndPauseControlParam, "OpenPlayAndPauseControlParam", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenPlayAndPauseControlParamShrink))
            {
                body["OpenPlayAndPauseControlParam"] = request.OpenPlayAndPauseControlParamShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PlayAndPauseControl",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/PlayAndPauseControl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PlayAndPauseControlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>播放暂停控制</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PlayAndPauseControlRequest
        /// </param>
        /// 
        /// <returns>
        /// PlayAndPauseControlResponse
        /// </returns>
        public PlayAndPauseControlResponse PlayAndPauseControl(PlayAndPauseControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PlayAndPauseControlHeaders headers = new PlayAndPauseControlHeaders();
            return PlayAndPauseControlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>播放暂停控制</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PlayAndPauseControlRequest
        /// </param>
        /// 
        /// <returns>
        /// PlayAndPauseControlResponse
        /// </returns>
        public async Task<PlayAndPauseControlResponse> PlayAndPauseControlAsync(PlayAndPauseControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PlayAndPauseControlHeaders headers = new PlayAndPauseControlHeaders();
            return await PlayAndPauseControlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>播放模式切换</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PlayModeControlRequest
        /// </param>
        /// <param name="headers">
        /// PlayModeControlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PlayModeControlResponse
        /// </returns>
        public PlayModeControlResponse PlayModeControlWithOptions(PlayModeControlRequest tmpReq, PlayModeControlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PlayModeControlShrinkRequest request = new PlayModeControlShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenPlayModeControlRequest))
            {
                request.OpenPlayModeControlRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenPlayModeControlRequest, "OpenPlayModeControlRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenPlayModeControlRequestShrink))
            {
                body["OpenPlayModeControlRequest"] = request.OpenPlayModeControlRequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PlayModeControl",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/PlayModeControl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PlayModeControlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>播放模式切换</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PlayModeControlRequest
        /// </param>
        /// <param name="headers">
        /// PlayModeControlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PlayModeControlResponse
        /// </returns>
        public async Task<PlayModeControlResponse> PlayModeControlWithOptionsAsync(PlayModeControlRequest tmpReq, PlayModeControlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PlayModeControlShrinkRequest request = new PlayModeControlShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenPlayModeControlRequest))
            {
                request.OpenPlayModeControlRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenPlayModeControlRequest, "OpenPlayModeControlRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenPlayModeControlRequestShrink))
            {
                body["OpenPlayModeControlRequest"] = request.OpenPlayModeControlRequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PlayModeControl",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/PlayModeControl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PlayModeControlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>播放模式切换</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PlayModeControlRequest
        /// </param>
        /// 
        /// <returns>
        /// PlayModeControlResponse
        /// </returns>
        public PlayModeControlResponse PlayModeControl(PlayModeControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PlayModeControlHeaders headers = new PlayModeControlHeaders();
            return PlayModeControlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>播放模式切换</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PlayModeControlRequest
        /// </param>
        /// 
        /// <returns>
        /// PlayModeControlResponse
        /// </returns>
        public async Task<PlayModeControlResponse> PlayModeControlAsync(PlayModeControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PlayModeControlHeaders headers = new PlayModeControlHeaders();
            return await PlayModeControlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上下首控制</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PreviousAndNextControlRequest
        /// </param>
        /// <param name="headers">
        /// PreviousAndNextControlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreviousAndNextControlResponse
        /// </returns>
        public PreviousAndNextControlResponse PreviousAndNextControlWithOptions(PreviousAndNextControlRequest tmpReq, PreviousAndNextControlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PreviousAndNextControlShrinkRequest request = new PreviousAndNextControlShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenControlPlayingListRequest))
            {
                request.OpenControlPlayingListRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenControlPlayingListRequest, "OpenControlPlayingListRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenControlPlayingListRequestShrink))
            {
                body["OpenControlPlayingListRequest"] = request.OpenControlPlayingListRequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviousAndNextControl",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/PreviousAndNextControl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviousAndNextControlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上下首控制</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PreviousAndNextControlRequest
        /// </param>
        /// <param name="headers">
        /// PreviousAndNextControlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreviousAndNextControlResponse
        /// </returns>
        public async Task<PreviousAndNextControlResponse> PreviousAndNextControlWithOptionsAsync(PreviousAndNextControlRequest tmpReq, PreviousAndNextControlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PreviousAndNextControlShrinkRequest request = new PreviousAndNextControlShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenControlPlayingListRequest))
            {
                request.OpenControlPlayingListRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenControlPlayingListRequest, "OpenControlPlayingListRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenControlPlayingListRequestShrink))
            {
                body["OpenControlPlayingListRequest"] = request.OpenControlPlayingListRequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviousAndNextControl",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/PreviousAndNextControl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviousAndNextControlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上下首控制</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreviousAndNextControlRequest
        /// </param>
        /// 
        /// <returns>
        /// PreviousAndNextControlResponse
        /// </returns>
        public PreviousAndNextControlResponse PreviousAndNextControl(PreviousAndNextControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PreviousAndNextControlHeaders headers = new PreviousAndNextControlHeaders();
            return PreviousAndNextControlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上下首控制</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreviousAndNextControlRequest
        /// </param>
        /// 
        /// <returns>
        /// PreviousAndNextControlResponse
        /// </returns>
        public async Task<PreviousAndNextControlResponse> PreviousAndNextControlAsync(PreviousAndNextControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PreviousAndNextControlHeaders headers = new PreviousAndNextControlHeaders();
            return await PreviousAndNextControlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>进度控制</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ProgressControlRequest
        /// </param>
        /// <param name="headers">
        /// ProgressControlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProgressControlResponse
        /// </returns>
        public ProgressControlResponse ProgressControlWithOptions(ProgressControlRequest tmpReq, ProgressControlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ProgressControlShrinkRequest request = new ProgressControlShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenProgressControlRequest))
            {
                request.OpenProgressControlRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenProgressControlRequest, "OpenProgressControlRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenProgressControlRequestShrink))
            {
                body["OpenProgressControlRequest"] = request.OpenProgressControlRequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProgressControl",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/ProgressControl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProgressControlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>进度控制</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ProgressControlRequest
        /// </param>
        /// <param name="headers">
        /// ProgressControlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProgressControlResponse
        /// </returns>
        public async Task<ProgressControlResponse> ProgressControlWithOptionsAsync(ProgressControlRequest tmpReq, ProgressControlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ProgressControlShrinkRequest request = new ProgressControlShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenProgressControlRequest))
            {
                request.OpenProgressControlRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenProgressControlRequest, "OpenProgressControlRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenProgressControlRequestShrink))
            {
                body["OpenProgressControlRequest"] = request.OpenProgressControlRequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProgressControl",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/ProgressControl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProgressControlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>进度控制</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProgressControlRequest
        /// </param>
        /// 
        /// <returns>
        /// ProgressControlResponse
        /// </returns>
        public ProgressControlResponse ProgressControl(ProgressControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProgressControlHeaders headers = new ProgressControlHeaders();
            return ProgressControlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>进度控制</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProgressControlRequest
        /// </param>
        /// 
        /// <returns>
        /// ProgressControlResponse
        /// </returns>
        public async Task<ProgressControlResponse> ProgressControlAsync(ProgressControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProgressControlHeaders headers = new ProgressControlHeaders();
            return await ProgressControlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取闹钟音乐类型列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryMusicTypeRequest
        /// </param>
        /// <param name="headers">
        /// QueryMusicTypeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMusicTypeResponse
        /// </returns>
        public QueryMusicTypeResponse QueryMusicTypeWithOptions(QueryMusicTypeRequest tmpReq, QueryMusicTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryMusicTypeShrinkRequest request = new QueryMusicTypeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "QueryMusicType",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/queryMusicType",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMusicTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取闹钟音乐类型列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryMusicTypeRequest
        /// </param>
        /// <param name="headers">
        /// QueryMusicTypeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMusicTypeResponse
        /// </returns>
        public async Task<QueryMusicTypeResponse> QueryMusicTypeWithOptionsAsync(QueryMusicTypeRequest tmpReq, QueryMusicTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryMusicTypeShrinkRequest request = new QueryMusicTypeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "QueryMusicType",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/queryMusicType",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMusicTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取闹钟音乐类型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMusicTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMusicTypeResponse
        /// </returns>
        public QueryMusicTypeResponse QueryMusicType(QueryMusicTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMusicTypeHeaders headers = new QueryMusicTypeHeaders();
            return QueryMusicTypeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取闹钟音乐类型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMusicTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMusicTypeResponse
        /// </returns>
        public async Task<QueryMusicTypeResponse> QueryMusicTypeAsync(QueryMusicTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMusicTypeHeaders headers = new QueryMusicTypeHeaders();
            return await QueryMusicTypeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过tme用户id获取授权的天猫精灵用户+设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUserDeviceListByTmeUserIdRequest
        /// </param>
        /// <param name="headers">
        /// QueryUserDeviceListByTmeUserIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUserDeviceListByTmeUserIdResponse
        /// </returns>
        public QueryUserDeviceListByTmeUserIdResponse QueryUserDeviceListByTmeUserIdWithOptions(QueryUserDeviceListByTmeUserIdRequest request, QueryUserDeviceListByTmeUserIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sp))
            {
                query["Sp"] = request.Sp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmeUserId))
            {
                query["TmeUserId"] = request.TmeUserId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserDeviceListByTmeUserId",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/queryUserDeviceListByTmeUserId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserDeviceListByTmeUserIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过tme用户id获取授权的天猫精灵用户+设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUserDeviceListByTmeUserIdRequest
        /// </param>
        /// <param name="headers">
        /// QueryUserDeviceListByTmeUserIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUserDeviceListByTmeUserIdResponse
        /// </returns>
        public async Task<QueryUserDeviceListByTmeUserIdResponse> QueryUserDeviceListByTmeUserIdWithOptionsAsync(QueryUserDeviceListByTmeUserIdRequest request, QueryUserDeviceListByTmeUserIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sp))
            {
                query["Sp"] = request.Sp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmeUserId))
            {
                query["TmeUserId"] = request.TmeUserId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserDeviceListByTmeUserId",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/queryUserDeviceListByTmeUserId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserDeviceListByTmeUserIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过tme用户id获取授权的天猫精灵用户+设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUserDeviceListByTmeUserIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUserDeviceListByTmeUserIdResponse
        /// </returns>
        public QueryUserDeviceListByTmeUserIdResponse QueryUserDeviceListByTmeUserId(QueryUserDeviceListByTmeUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserDeviceListByTmeUserIdHeaders headers = new QueryUserDeviceListByTmeUserIdHeaders();
            return QueryUserDeviceListByTmeUserIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过tme用户id获取授权的天猫精灵用户+设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUserDeviceListByTmeUserIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUserDeviceListByTmeUserIdResponse
        /// </returns>
        public async Task<QueryUserDeviceListByTmeUserIdResponse> QueryUserDeviceListByTmeUserIdAsync(QueryUserDeviceListByTmeUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserDeviceListByTmeUserIdHeaders headers = new QueryUserDeviceListByTmeUserIdHeaders();
            return await QueryUserDeviceListByTmeUserIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>读取留言</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ReadMessageRequest
        /// </param>
        /// <param name="headers">
        /// ReadMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageResponse
        /// </returns>
        public ReadMessageResponse ReadMessageWithOptions(ReadMessageRequest tmpReq, ReadMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReadMessageShrinkRequest request = new ReadMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadMessage",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/readMessage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>读取留言</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ReadMessageRequest
        /// </param>
        /// <param name="headers">
        /// ReadMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageResponse
        /// </returns>
        public async Task<ReadMessageResponse> ReadMessageWithOptionsAsync(ReadMessageRequest tmpReq, ReadMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReadMessageShrinkRequest request = new ReadMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadMessage",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/readMessage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>读取留言</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageResponse
        /// </returns>
        public ReadMessageResponse ReadMessage(ReadMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReadMessageHeaders headers = new ReadMessageHeaders();
            return ReadMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>读取留言</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadMessageResponse
        /// </returns>
        public async Task<ReadMessageResponse> ReadMessageAsync(ReadMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReadMessageHeaders headers = new ReadMessageHeaders();
            return await ReadMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>扫描二维码激活绑定设备</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ScanCodeBindRequest
        /// </param>
        /// <param name="headers">
        /// ScanCodeBindHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScanCodeBindResponse
        /// </returns>
        public ScanCodeBindResponse ScanCodeBindWithOptions(ScanCodeBindRequest tmpReq, ScanCodeBindHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ScanCodeBindShrinkRequest request = new ScanCodeBindShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BindReq))
            {
                request.BindReqShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BindReq, "BindReq", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindReqShrink))
            {
                body["BindReq"] = request.BindReqShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "ScanCodeBind",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/scanCode",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScanCodeBindResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>扫描二维码激活绑定设备</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ScanCodeBindRequest
        /// </param>
        /// <param name="headers">
        /// ScanCodeBindHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScanCodeBindResponse
        /// </returns>
        public async Task<ScanCodeBindResponse> ScanCodeBindWithOptionsAsync(ScanCodeBindRequest tmpReq, ScanCodeBindHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ScanCodeBindShrinkRequest request = new ScanCodeBindShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BindReq))
            {
                request.BindReqShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BindReq, "BindReq", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindReqShrink))
            {
                body["BindReq"] = request.BindReqShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "ScanCodeBind",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/scanCode",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScanCodeBindResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>扫描二维码激活绑定设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScanCodeBindRequest
        /// </param>
        /// 
        /// <returns>
        /// ScanCodeBindResponse
        /// </returns>
        public ScanCodeBindResponse ScanCodeBind(ScanCodeBindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ScanCodeBindHeaders headers = new ScanCodeBindHeaders();
            return ScanCodeBindWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>扫描二维码激活绑定设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScanCodeBindRequest
        /// </param>
        /// 
        /// <returns>
        /// ScanCodeBindResponse
        /// </returns>
        public async Task<ScanCodeBindResponse> ScanCodeBindAsync(ScanCodeBindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ScanCodeBindHeaders headers = new ScanCodeBindHeaders();
            return await ScanCodeBindWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>选品池投放能力</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ScgSearchRequest
        /// </param>
        /// <param name="headers">
        /// ScgSearchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScgSearchResponse
        /// </returns>
        public ScgSearchResponse ScgSearchWithOptions(ScgSearchRequest tmpReq, ScgSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ScgSearchShrinkRequest request = new ScgSearchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScgFilter))
            {
                request.ScgFilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScgFilter, "ScgFilter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScgFilterShrink))
            {
                query["ScgFilter"] = request.ScgFilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicId))
            {
                query["TopicId"] = request.TopicId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScgSearch",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/scgSearch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScgSearchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>选品池投放能力</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ScgSearchRequest
        /// </param>
        /// <param name="headers">
        /// ScgSearchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScgSearchResponse
        /// </returns>
        public async Task<ScgSearchResponse> ScgSearchWithOptionsAsync(ScgSearchRequest tmpReq, ScgSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ScgSearchShrinkRequest request = new ScgSearchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScgFilter))
            {
                request.ScgFilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScgFilter, "ScgFilter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScgFilterShrink))
            {
                query["ScgFilter"] = request.ScgFilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicId))
            {
                query["TopicId"] = request.TopicId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScgSearch",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/scgSearch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScgSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>选品池投放能力</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScgSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// ScgSearchResponse
        /// </returns>
        public ScgSearchResponse ScgSearch(ScgSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ScgSearchHeaders headers = new ScgSearchHeaders();
            return ScgSearchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>选品池投放能力</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScgSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// ScgSearchResponse
        /// </returns>
        public async Task<ScgSearchResponse> ScgSearchAsync(ScgSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ScgSearchHeaders headers = new ScgSearchHeaders();
            return await ScgSearchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按照特定的搜索条件搜索</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SearchContentRequest
        /// </param>
        /// <param name="headers">
        /// SearchContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchContentResponse
        /// </returns>
        public SearchContentResponse SearchContentWithOptions(SearchContentRequest tmpReq, SearchContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchContentShrinkRequest request = new SearchContentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Request))
            {
                request.RequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Request, "Request", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestShrink))
            {
                body["Request"] = request.RequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchContent",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/SearchContent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按照特定的搜索条件搜索</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SearchContentRequest
        /// </param>
        /// <param name="headers">
        /// SearchContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchContentResponse
        /// </returns>
        public async Task<SearchContentResponse> SearchContentWithOptionsAsync(SearchContentRequest tmpReq, SearchContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchContentShrinkRequest request = new SearchContentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Request))
            {
                request.RequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Request, "Request", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestShrink))
            {
                body["Request"] = request.RequestShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchContent",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/SearchContent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按照特定的搜索条件搜索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchContentRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchContentResponse
        /// </returns>
        public SearchContentResponse SearchContent(SearchContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchContentHeaders headers = new SearchContentHeaders();
            return SearchContentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按照特定的搜索条件搜索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchContentRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchContentResponse
        /// </returns>
        public async Task<SearchContentResponse> SearchContentAsync(SearchContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchContentHeaders headers = new SearchContentHeaders();
            return await SearchContentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送留言</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SendMessageRequest
        /// </param>
        /// <param name="headers">
        /// SendMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendMessageResponse
        /// </returns>
        public SendMessageResponse SendMessageWithOptions(SendMessageRequest tmpReq, SendMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendMessageShrinkRequest request = new SendMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendMessage",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/sendMessage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送留言</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SendMessageRequest
        /// </param>
        /// <param name="headers">
        /// SendMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendMessageResponse
        /// </returns>
        public async Task<SendMessageResponse> SendMessageWithOptionsAsync(SendMessageRequest tmpReq, SendMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendMessageShrinkRequest request = new SendMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendMessage",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/sendMessage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送留言</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendMessageResponse
        /// </returns>
        public SendMessageResponse SendMessage(SendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMessageHeaders headers = new SendMessageHeaders();
            return SendMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送留言</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendMessageResponse
        /// </returns>
        public async Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMessageHeaders headers = new SendMessageHeaders();
            return await SendMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改设备设置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SetDeviceSettingRequest
        /// </param>
        /// <param name="headers">
        /// SetDeviceSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDeviceSettingResponse
        /// </returns>
        public SetDeviceSettingResponse SetDeviceSettingWithOptions(SetDeviceSettingRequest tmpReq, SetDeviceSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetDeviceSettingShrinkRequest request = new SetDeviceSettingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                body["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDeviceSetting",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/setDeviceSetting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDeviceSettingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改设备设置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SetDeviceSettingRequest
        /// </param>
        /// <param name="headers">
        /// SetDeviceSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDeviceSettingResponse
        /// </returns>
        public async Task<SetDeviceSettingResponse> SetDeviceSettingWithOptionsAsync(SetDeviceSettingRequest tmpReq, SetDeviceSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetDeviceSettingShrinkRequest request = new SetDeviceSettingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                body["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDeviceSetting",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/setDeviceSetting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDeviceSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改设备设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDeviceSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDeviceSettingResponse
        /// </returns>
        public SetDeviceSettingResponse SetDeviceSetting(SetDeviceSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetDeviceSettingHeaders headers = new SetDeviceSettingHeaders();
            return SetDeviceSettingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改设备设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDeviceSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDeviceSettingResponse
        /// </returns>
        public async Task<SetDeviceSettingResponse> SetDeviceSettingAsync(SetDeviceSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetDeviceSettingHeaders headers = new SetDeviceSettingHeaders();
            return await SetDeviceSettingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>三方即时信息数据变更事件推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ThirdImmediateMsgPushRequest
        /// </param>
        /// <param name="headers">
        /// ThirdImmediateMsgPushHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ThirdImmediateMsgPushResponse
        /// </returns>
        public ThirdImmediateMsgPushResponse ThirdImmediateMsgPushWithOptions(ThirdImmediateMsgPushRequest request, ThirdImmediateMsgPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeDetail))
            {
                query["ChangeDetail"] = request.ChangeDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PsgIds))
            {
                query["PsgIds"] = request.PsgIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficChangeType))
            {
                query["TrafficChangeType"] = request.TrafficChangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficChangeTypeDesc))
            {
                query["TrafficChangeTypeDesc"] = request.TrafficChangeTypeDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficJourneyIds))
            {
                query["TrafficJourneyIds"] = request.TrafficJourneyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficSubOrderIds))
            {
                query["TrafficSubOrderIds"] = request.TrafficSubOrderIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ThirdImmediateMsgPush",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/thirdImmediateMsgPush",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ThirdImmediateMsgPushResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>三方即时信息数据变更事件推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ThirdImmediateMsgPushRequest
        /// </param>
        /// <param name="headers">
        /// ThirdImmediateMsgPushHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ThirdImmediateMsgPushResponse
        /// </returns>
        public async Task<ThirdImmediateMsgPushResponse> ThirdImmediateMsgPushWithOptionsAsync(ThirdImmediateMsgPushRequest request, ThirdImmediateMsgPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeDetail))
            {
                query["ChangeDetail"] = request.ChangeDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PsgIds))
            {
                query["PsgIds"] = request.PsgIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficChangeType))
            {
                query["TrafficChangeType"] = request.TrafficChangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficChangeTypeDesc))
            {
                query["TrafficChangeTypeDesc"] = request.TrafficChangeTypeDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficJourneyIds))
            {
                query["TrafficJourneyIds"] = request.TrafficJourneyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficSubOrderIds))
            {
                query["TrafficSubOrderIds"] = request.TrafficSubOrderIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ThirdImmediateMsgPush",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/thirdImmediateMsgPush",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ThirdImmediateMsgPushResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>三方即时信息数据变更事件推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ThirdImmediateMsgPushRequest
        /// </param>
        /// 
        /// <returns>
        /// ThirdImmediateMsgPushResponse
        /// </returns>
        public ThirdImmediateMsgPushResponse ThirdImmediateMsgPush(ThirdImmediateMsgPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ThirdImmediateMsgPushHeaders headers = new ThirdImmediateMsgPushHeaders();
            return ThirdImmediateMsgPushWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>三方即时信息数据变更事件推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ThirdImmediateMsgPushRequest
        /// </param>
        /// 
        /// <returns>
        /// ThirdImmediateMsgPushResponse
        /// </returns>
        public async Task<ThirdImmediateMsgPushResponse> ThirdImmediateMsgPushAsync(ThirdImmediateMsgPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ThirdImmediateMsgPushHeaders headers = new ThirdImmediateMsgPushHeaders();
            return await ThirdImmediateMsgPushWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解除三方和精灵账号的关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindAligenieUserRequest
        /// </param>
        /// <param name="headers">
        /// UnbindAligenieUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindAligenieUserResponse
        /// </returns>
        public UnbindAligenieUserResponse UnbindAligenieUserWithOptions(UnbindAligenieUserRequest request, UnbindAligenieUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginStateAccessToken))
            {
                body["LoginStateAccessToken"] = request.LoginStateAccessToken;
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
                Action = "UnbindAligenieUser",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/unbindAligenieUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindAligenieUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解除三方和精灵账号的关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindAligenieUserRequest
        /// </param>
        /// <param name="headers">
        /// UnbindAligenieUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindAligenieUserResponse
        /// </returns>
        public async Task<UnbindAligenieUserResponse> UnbindAligenieUserWithOptionsAsync(UnbindAligenieUserRequest request, UnbindAligenieUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginStateAccessToken))
            {
                body["LoginStateAccessToken"] = request.LoginStateAccessToken;
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
                Action = "UnbindAligenieUser",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/unbindAligenieUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindAligenieUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解除三方和精灵账号的关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindAligenieUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindAligenieUserResponse
        /// </returns>
        public UnbindAligenieUserResponse UnbindAligenieUser(UnbindAligenieUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnbindAligenieUserHeaders headers = new UnbindAligenieUserHeaders();
            return UnbindAligenieUserWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解除三方和精灵账号的关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindAligenieUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindAligenieUserResponse
        /// </returns>
        public async Task<UnbindAligenieUserResponse> UnbindAligenieUserAsync(UnbindAligenieUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnbindAligenieUserHeaders headers = new UnbindAligenieUserHeaders();
            return await UnbindAligenieUserWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑设备</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UnbindDeviceRequest
        /// </param>
        /// <param name="headers">
        /// UnbindDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindDeviceResponse
        /// </returns>
        public UnbindDeviceResponse UnbindDeviceWithOptions(UnbindDeviceRequest tmpReq, UnbindDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UnbindDeviceShrinkRequest request = new UnbindDeviceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "UnbindDevice",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/unbindDevice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindDeviceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑设备</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UnbindDeviceRequest
        /// </param>
        /// <param name="headers">
        /// UnbindDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindDeviceResponse
        /// </returns>
        public async Task<UnbindDeviceResponse> UnbindDeviceWithOptionsAsync(UnbindDeviceRequest tmpReq, UnbindDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UnbindDeviceShrinkRequest request = new UnbindDeviceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "UnbindDevice",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/unbindDevice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindDeviceResponse
        /// </returns>
        public UnbindDeviceResponse UnbindDevice(UnbindDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnbindDeviceHeaders headers = new UnbindDeviceHeaders();
            return UnbindDeviceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindDeviceResponse
        /// </returns>
        public async Task<UnbindDeviceResponse> UnbindDeviceAsync(UnbindDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnbindDeviceHeaders headers = new UnbindDeviceHeaders();
            return await UnbindDeviceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新闹钟</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateAlarmRequest
        /// </param>
        /// <param name="headers">
        /// UpdateAlarmHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAlarmResponse
        /// </returns>
        public UpdateAlarmResponse UpdateAlarmWithOptions(UpdateAlarmRequest tmpReq, UpdateAlarmHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAlarmShrinkRequest request = new UpdateAlarmShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "UpdateAlarm",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/updateAlarm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAlarmResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新闹钟</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateAlarmRequest
        /// </param>
        /// <param name="headers">
        /// UpdateAlarmHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAlarmResponse
        /// </returns>
        public async Task<UpdateAlarmResponse> UpdateAlarmWithOptionsAsync(UpdateAlarmRequest tmpReq, UpdateAlarmHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAlarmShrinkRequest request = new UpdateAlarmShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
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
                Action = "UpdateAlarm",
                Version = "ssp_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ssp/updateAlarm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAlarmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新闹钟</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAlarmResponse
        /// </returns>
        public UpdateAlarmResponse UpdateAlarm(UpdateAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateAlarmHeaders headers = new UpdateAlarmHeaders();
            return UpdateAlarmWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新闹钟</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAlarmResponse
        /// </returns>
        public async Task<UpdateAlarmResponse> UpdateAlarmAsync(UpdateAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateAlarmHeaders headers = new UpdateAlarmHeaders();
            return await UpdateAlarmWithOptionsAsync(request, headers, runtime);
        }

    }
}
