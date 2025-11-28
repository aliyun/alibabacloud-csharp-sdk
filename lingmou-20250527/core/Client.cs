// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.LingMou20250527.Models;

namespace AlibabaCloud.SDK.LingMou20250527
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("lingmou", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>关闭会话实例session</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CloseChatInstanceSessionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseChatInstanceSessionsResponse
        /// </returns>
        public CloseChatInstanceSessionsResponse CloseChatInstanceSessionsWithOptions(string instanceId, CloseChatInstanceSessionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CloseChatInstanceSessionsShrinkRequest request = new CloseChatInstanceSessionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SessionIds))
            {
                request.SessionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SessionIds, "sessionIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionIdsShrink))
            {
                body["sessionIds"] = request.SessionIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseChatInstanceSessions",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/chat/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sessions/close",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseChatInstanceSessionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭会话实例session</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CloseChatInstanceSessionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseChatInstanceSessionsResponse
        /// </returns>
        public async Task<CloseChatInstanceSessionsResponse> CloseChatInstanceSessionsWithOptionsAsync(string instanceId, CloseChatInstanceSessionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CloseChatInstanceSessionsShrinkRequest request = new CloseChatInstanceSessionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SessionIds))
            {
                request.SessionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SessionIds, "sessionIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionIdsShrink))
            {
                body["sessionIds"] = request.SessionIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseChatInstanceSessions",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/chat/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sessions/close",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseChatInstanceSessionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭会话实例session</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseChatInstanceSessionsRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseChatInstanceSessionsResponse
        /// </returns>
        public CloseChatInstanceSessionsResponse CloseChatInstanceSessions(string instanceId, CloseChatInstanceSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloseChatInstanceSessionsWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭会话实例session</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseChatInstanceSessionsRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseChatInstanceSessionsResponse
        /// </returns>
        public async Task<CloseChatInstanceSessionsResponse> CloseChatInstanceSessionsAsync(string instanceId, CloseChatInstanceSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloseChatInstanceSessionsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建背景素材</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBackgroundPicRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBackgroundPicResponse
        /// </returns>
        public CreateBackgroundPicResponse CreateBackgroundPicWithOptions(CreateBackgroundPicRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filename))
            {
                query["filename"] = request.Filename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["ossKey"] = request.OssKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBackgroundPic",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/chat/createBackgroundPic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBackgroundPicResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建背景素材</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBackgroundPicRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBackgroundPicResponse
        /// </returns>
        public async Task<CreateBackgroundPicResponse> CreateBackgroundPicWithOptionsAsync(CreateBackgroundPicRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filename))
            {
                query["filename"] = request.Filename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["ossKey"] = request.OssKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBackgroundPic",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/chat/createBackgroundPic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBackgroundPicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建背景素材</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBackgroundPicRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBackgroundPicResponse
        /// </returns>
        public CreateBackgroundPicResponse CreateBackgroundPic(CreateBackgroundPicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateBackgroundPicWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建背景素材</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBackgroundPicRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBackgroundPicResponse
        /// </returns>
        public async Task<CreateBackgroundPicResponse> CreateBackgroundPicAsync(CreateBackgroundPicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateBackgroundPicWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>背景配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChatConfigResponse
        /// </returns>
        public CreateChatConfigResponse CreateChatConfigWithOptions(CreateChatConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarId))
            {
                query["avatarId"] = request.AvatarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundId))
            {
                query["backgroundId"] = request.BackgroundId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChatConfig",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/chat/createChatConfig",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChatConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>背景配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChatConfigResponse
        /// </returns>
        public async Task<CreateChatConfigResponse> CreateChatConfigWithOptionsAsync(CreateChatConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarId))
            {
                query["avatarId"] = request.AvatarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundId))
            {
                query["backgroundId"] = request.BackgroundId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChatConfig",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/chat/createChatConfig",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChatConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>背景配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChatConfigResponse
        /// </returns>
        public CreateChatConfigResponse CreateChatConfig(CreateChatConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateChatConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>背景配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChatConfigResponse
        /// </returns>
        public async Task<CreateChatConfigResponse> CreateChatConfigAsync(CreateChatConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateChatConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数字人会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChatSessionResponse
        /// </returns>
        public CreateChatSessionResponse CreateChatSessionWithOptions(string id, CreateChatSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.License))
            {
                query["license"] = request.License;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["platform"] = request.Platform;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChatSession",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/chat/init/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChatSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数字人会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChatSessionResponse
        /// </returns>
        public async Task<CreateChatSessionResponse> CreateChatSessionWithOptionsAsync(string id, CreateChatSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.License))
            {
                query["license"] = request.License;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["platform"] = request.Platform;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChatSession",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/chat/init/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChatSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数字人会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChatSessionResponse
        /// </returns>
        public CreateChatSessionResponse CreateChatSession(string id, CreateChatSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateChatSessionWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数字人会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChatSessionResponse
        /// </returns>
        public async Task<CreateChatSessionResponse> CreateChatSessionAsync(string id, CreateChatSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateChatSessionWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建对话免训照片数字人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNoTrainPicAvatarRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNoTrainPicAvatarResponse
        /// </returns>
        public CreateNoTrainPicAvatarResponse CreateNoTrainPicAvatarWithOptions(CreateNoTrainPicAvatarRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expressiveness))
            {
                query["expressiveness"] = request.Expressiveness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                query["gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateAssets))
            {
                query["generateAssets"] = request.GenerateAssets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageOssPath))
            {
                query["imageOssPath"] = request.ImageOssPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["jwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Transparent))
            {
                query["transparent"] = request.Transparent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNoTrainPicAvatar",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/chat/createNoTrainPicAvatar",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNoTrainPicAvatarResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建对话免训照片数字人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNoTrainPicAvatarRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNoTrainPicAvatarResponse
        /// </returns>
        public async Task<CreateNoTrainPicAvatarResponse> CreateNoTrainPicAvatarWithOptionsAsync(CreateNoTrainPicAvatarRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expressiveness))
            {
                query["expressiveness"] = request.Expressiveness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                query["gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateAssets))
            {
                query["generateAssets"] = request.GenerateAssets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageOssPath))
            {
                query["imageOssPath"] = request.ImageOssPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["jwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Transparent))
            {
                query["transparent"] = request.Transparent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNoTrainPicAvatar",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/chat/createNoTrainPicAvatar",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNoTrainPicAvatarResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建对话免训照片数字人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNoTrainPicAvatarRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNoTrainPicAvatarResponse
        /// </returns>
        public CreateNoTrainPicAvatarResponse CreateNoTrainPicAvatar(CreateNoTrainPicAvatarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateNoTrainPicAvatarWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建对话免训照片数字人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNoTrainPicAvatarRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNoTrainPicAvatarResponse
        /// </returns>
        public async Task<CreateNoTrainPicAvatarResponse> CreateNoTrainPicAvatarAsync(CreateNoTrainPicAvatarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateNoTrainPicAvatarWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取对话免训图片素材上传凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUploadPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUploadPolicyResponse
        /// </returns>
        public GetUploadPolicyResponse GetUploadPolicyWithOptions(GetUploadPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["jwtToken"] = request.JwtToken;
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
                Action = "GetUploadPolicy",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/chat/getUploadPolicy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取对话免训图片素材上传凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUploadPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUploadPolicyResponse
        /// </returns>
        public async Task<GetUploadPolicyResponse> GetUploadPolicyWithOptionsAsync(GetUploadPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["jwtToken"] = request.JwtToken;
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
                Action = "GetUploadPolicy",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/chat/getUploadPolicy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取对话免训图片素材上传凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUploadPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUploadPolicyResponse
        /// </returns>
        public GetUploadPolicyResponse GetUploadPolicy(GetUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUploadPolicyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取对话免训图片素材上传凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUploadPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUploadPolicyResponse
        /// </returns>
        public async Task<GetUploadPolicyResponse> GetUploadPolicyAsync(GetUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUploadPolicyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会话实例session</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryChatInstanceSessionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryChatInstanceSessionsResponse
        /// </returns>
        public QueryChatInstanceSessionsResponse QueryChatInstanceSessionsWithOptions(string instanceId, QueryChatInstanceSessionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryChatInstanceSessionsShrinkRequest request = new QueryChatInstanceSessionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SessionIds))
            {
                request.SessionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SessionIds, "sessionIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionIdsShrink))
            {
                query["sessionIds"] = request.SessionIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryChatInstanceSessions",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/chat/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sessions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChatInstanceSessionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会话实例session</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryChatInstanceSessionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryChatInstanceSessionsResponse
        /// </returns>
        public async Task<QueryChatInstanceSessionsResponse> QueryChatInstanceSessionsWithOptionsAsync(string instanceId, QueryChatInstanceSessionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryChatInstanceSessionsShrinkRequest request = new QueryChatInstanceSessionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SessionIds))
            {
                request.SessionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SessionIds, "sessionIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionIdsShrink))
            {
                query["sessionIds"] = request.SessionIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryChatInstanceSessions",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/chat/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sessions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChatInstanceSessionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会话实例session</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChatInstanceSessionsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryChatInstanceSessionsResponse
        /// </returns>
        public QueryChatInstanceSessionsResponse QueryChatInstanceSessions(string instanceId, QueryChatInstanceSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryChatInstanceSessionsWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会话实例session</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChatInstanceSessionsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryChatInstanceSessionsResponse
        /// </returns>
        public async Task<QueryChatInstanceSessionsResponse> QueryChatInstanceSessionsAsync(string instanceId, QueryChatInstanceSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryChatInstanceSessionsWithOptionsAsync(instanceId, request, headers, runtime);
        }

    }
}
