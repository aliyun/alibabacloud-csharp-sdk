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
        /// <para>用户确认</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfirmTrainPicAvatarRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfirmTrainPicAvatarResponse
        /// </returns>
        public ConfirmTrainPicAvatarResponse ConfirmTrainPicAvatarWithOptions(ConfirmTrainPicAvatarRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarId))
            {
                query["avatarId"] = request.AvatarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmTrainPicAvatar",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/train/confirmTrainPicAvatar",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmTrainPicAvatarResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户确认</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfirmTrainPicAvatarRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfirmTrainPicAvatarResponse
        /// </returns>
        public async Task<ConfirmTrainPicAvatarResponse> ConfirmTrainPicAvatarWithOptionsAsync(ConfirmTrainPicAvatarRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarId))
            {
                query["avatarId"] = request.AvatarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmTrainPicAvatar",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/train/confirmTrainPicAvatar",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmTrainPicAvatarResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户确认</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfirmTrainPicAvatarRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfirmTrainPicAvatarResponse
        /// </returns>
        public ConfirmTrainPicAvatarResponse ConfirmTrainPicAvatar(ConfirmTrainPicAvatarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ConfirmTrainPicAvatarWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户确认</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfirmTrainPicAvatarRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfirmTrainPicAvatarResponse
        /// </returns>
        public async Task<ConfirmTrainPicAvatarResponse> ConfirmTrainPicAvatarAsync(ConfirmTrainPicAvatarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ConfirmTrainPicAvatarWithOptionsAsync(request, headers, runtime);
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
        /// <para>创建播报贴图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBroadcastStickerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBroadcastStickerResponse
        /// </returns>
        public CreateBroadcastStickerResponse CreateBroadcastStickerWithOptions(CreateBroadcastStickerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                body["ossKey"] = request.OssKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBroadcastSticker",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/customer/broadcast/material/sticker/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBroadcastStickerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建播报贴图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBroadcastStickerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBroadcastStickerResponse
        /// </returns>
        public async Task<CreateBroadcastStickerResponse> CreateBroadcastStickerWithOptionsAsync(CreateBroadcastStickerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                body["ossKey"] = request.OssKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBroadcastSticker",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/customer/broadcast/material/sticker/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBroadcastStickerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建播报贴图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBroadcastStickerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBroadcastStickerResponse
        /// </returns>
        public CreateBroadcastStickerResponse CreateBroadcastSticker(CreateBroadcastStickerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateBroadcastStickerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建播报贴图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBroadcastStickerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBroadcastStickerResponse
        /// </returns>
        public async Task<CreateBroadcastStickerResponse> CreateBroadcastStickerAsync(CreateBroadcastStickerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateBroadcastStickerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于模板创建播报视频</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBroadcastVideoFromTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBroadcastVideoFromTemplateResponse
        /// </returns>
        public CreateBroadcastVideoFromTemplateResponse CreateBroadcastVideoFromTemplateWithOptions(CreateBroadcastVideoFromTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoOptions))
            {
                body["videoOptions"] = request.VideoOptions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBroadcastVideoFromTemplate",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/api/v1/amp/customer/broadcast/video/createFromTemplate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBroadcastVideoFromTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于模板创建播报视频</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBroadcastVideoFromTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBroadcastVideoFromTemplateResponse
        /// </returns>
        public async Task<CreateBroadcastVideoFromTemplateResponse> CreateBroadcastVideoFromTemplateWithOptionsAsync(CreateBroadcastVideoFromTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoOptions))
            {
                body["videoOptions"] = request.VideoOptions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBroadcastVideoFromTemplate",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/api/v1/amp/customer/broadcast/video/createFromTemplate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBroadcastVideoFromTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于模板创建播报视频</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBroadcastVideoFromTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBroadcastVideoFromTemplateResponse
        /// </returns>
        public CreateBroadcastVideoFromTemplateResponse CreateBroadcastVideoFromTemplate(CreateBroadcastVideoFromTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateBroadcastVideoFromTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于模板创建播报视频</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBroadcastVideoFromTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBroadcastVideoFromTemplateResponse
        /// </returns>
        public async Task<CreateBroadcastVideoFromTemplateResponse> CreateBroadcastVideoFromTemplateAsync(CreateBroadcastVideoFromTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateBroadcastVideoFromTemplateWithOptionsAsync(request, headers, runtime);
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
        /// <para>创建TTS音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTTSVoiceCustomRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTTSVoiceCustomResponse
        /// </returns>
        public CreateTTSVoiceCustomResponse CreateTTSVoiceCustomWithOptions(CreateTTSVoiceCustomRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                query["gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
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
                Action = "CreateTTSVoiceCustom",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/voice/createTTSVoiceCustom",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTTSVoiceCustomResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建TTS音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTTSVoiceCustomRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTTSVoiceCustomResponse
        /// </returns>
        public async Task<CreateTTSVoiceCustomResponse> CreateTTSVoiceCustomWithOptionsAsync(CreateTTSVoiceCustomRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                query["gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
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
                Action = "CreateTTSVoiceCustom",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/voice/createTTSVoiceCustom",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTTSVoiceCustomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建TTS音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTTSVoiceCustomRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTTSVoiceCustomResponse
        /// </returns>
        public CreateTTSVoiceCustomResponse CreateTTSVoiceCustom(CreateTTSVoiceCustomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTTSVoiceCustomWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建TTS音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTTSVoiceCustomRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTTSVoiceCustomResponse
        /// </returns>
        public async Task<CreateTTSVoiceCustomResponse> CreateTTSVoiceCustomAsync(CreateTTSVoiceCustomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTTSVoiceCustomWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建图片训练数字人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrainPicAvatarRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTrainPicAvatarResponse
        /// </returns>
        public CreateTrainPicAvatarResponse CreateTrainPicAvatarWithOptions(CreateTrainPicAvatarRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
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
                Action = "CreateTrainPicAvatar",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/train/createTrainPicAvatar",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrainPicAvatarResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建图片训练数字人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrainPicAvatarRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTrainPicAvatarResponse
        /// </returns>
        public async Task<CreateTrainPicAvatarResponse> CreateTrainPicAvatarWithOptionsAsync(CreateTrainPicAvatarRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
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
                Action = "CreateTrainPicAvatar",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/train/createTrainPicAvatar",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrainPicAvatarResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建图片训练数字人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrainPicAvatarRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTrainPicAvatarResponse
        /// </returns>
        public CreateTrainPicAvatarResponse CreateTrainPicAvatar(CreateTrainPicAvatarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTrainPicAvatarWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建图片训练数字人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrainPicAvatarRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTrainPicAvatarResponse
        /// </returns>
        public async Task<CreateTrainPicAvatarResponse> CreateTrainPicAvatarAsync(CreateTrainPicAvatarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTrainPicAvatarWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询播报模板详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBroadcastTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBroadcastTemplateResponse
        /// </returns>
        public GetBroadcastTemplateResponse GetBroadcastTemplateWithOptions(GetBroadcastTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBroadcastTemplate",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/customer/broadcast/template/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBroadcastTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询播报模板详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBroadcastTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBroadcastTemplateResponse
        /// </returns>
        public async Task<GetBroadcastTemplateResponse> GetBroadcastTemplateWithOptionsAsync(GetBroadcastTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBroadcastTemplate",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/customer/broadcast/template/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBroadcastTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询播报模板详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBroadcastTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBroadcastTemplateResponse
        /// </returns>
        public GetBroadcastTemplateResponse GetBroadcastTemplate(GetBroadcastTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBroadcastTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询播报模板详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBroadcastTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBroadcastTemplateResponse
        /// </returns>
        public async Task<GetBroadcastTemplateResponse> GetBroadcastTemplateAsync(GetBroadcastTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBroadcastTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID获取TTS音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTTSVoiceByIdCustomRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTTSVoiceByIdCustomResponse
        /// </returns>
        public GetTTSVoiceByIdCustomResponse GetTTSVoiceByIdCustomWithOptions(GetTTSVoiceByIdCustomRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceId))
            {
                query["voiceId"] = request.VoiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTTSVoiceByIdCustom",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/voice/getTTSVoiceById",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTTSVoiceByIdCustomResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID获取TTS音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTTSVoiceByIdCustomRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTTSVoiceByIdCustomResponse
        /// </returns>
        public async Task<GetTTSVoiceByIdCustomResponse> GetTTSVoiceByIdCustomWithOptionsAsync(GetTTSVoiceByIdCustomRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceId))
            {
                query["voiceId"] = request.VoiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTTSVoiceByIdCustom",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/voice/getTTSVoiceById",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTTSVoiceByIdCustomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID获取TTS音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTTSVoiceByIdCustomRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTTSVoiceByIdCustomResponse
        /// </returns>
        public GetTTSVoiceByIdCustomResponse GetTTSVoiceByIdCustom(GetTTSVoiceByIdCustomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTTSVoiceByIdCustomWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID获取TTS音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTTSVoiceByIdCustomRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTTSVoiceByIdCustomResponse
        /// </returns>
        public async Task<GetTTSVoiceByIdCustomResponse> GetTTSVoiceByIdCustomAsync(GetTTSVoiceByIdCustomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTTSVoiceByIdCustomWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询图片训练数字人的状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrainPicAvatarStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTrainPicAvatarStatusResponse
        /// </returns>
        public GetTrainPicAvatarStatusResponse GetTrainPicAvatarStatusWithOptions(GetTrainPicAvatarStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarId))
            {
                query["avatarId"] = request.AvatarId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrainPicAvatarStatus",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/train/getTrainPicAvatarStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrainPicAvatarStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询图片训练数字人的状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrainPicAvatarStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTrainPicAvatarStatusResponse
        /// </returns>
        public async Task<GetTrainPicAvatarStatusResponse> GetTrainPicAvatarStatusWithOptionsAsync(GetTrainPicAvatarStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarId))
            {
                query["avatarId"] = request.AvatarId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrainPicAvatarStatus",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/train/getTrainPicAvatarStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrainPicAvatarStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询图片训练数字人的状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrainPicAvatarStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTrainPicAvatarStatusResponse
        /// </returns>
        public GetTrainPicAvatarStatusResponse GetTrainPicAvatarStatus(GetTrainPicAvatarStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTrainPicAvatarStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询图片训练数字人的状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrainPicAvatarStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTrainPicAvatarStatusResponse
        /// </returns>
        public async Task<GetTrainPicAvatarStatusResponse> GetTrainPicAvatarStatusAsync(GetTrainPicAvatarStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTrainPicAvatarStatusWithOptionsAsync(request, headers, runtime);
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
        /// <para>列举播报模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBroadcastTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBroadcastTemplatesResponse
        /// </returns>
        public ListBroadcastTemplatesResponse ListBroadcastTemplatesWithOptions(ListBroadcastTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBroadcastTemplates",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/customer/broadcast/template/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBroadcastTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举播报模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBroadcastTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBroadcastTemplatesResponse
        /// </returns>
        public async Task<ListBroadcastTemplatesResponse> ListBroadcastTemplatesWithOptionsAsync(ListBroadcastTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBroadcastTemplates",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/customer/broadcast/template/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBroadcastTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举播报模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBroadcastTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBroadcastTemplatesResponse
        /// </returns>
        public ListBroadcastTemplatesResponse ListBroadcastTemplates(ListBroadcastTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListBroadcastTemplatesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举播报模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBroadcastTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBroadcastTemplatesResponse
        /// </returns>
        public async Task<ListBroadcastTemplatesResponse> ListBroadcastTemplatesAsync(ListBroadcastTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListBroadcastTemplatesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据视频id批量查询播报视频（最多查询100个）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListBroadcastVideosByIdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBroadcastVideosByIdResponse
        /// </returns>
        public ListBroadcastVideosByIdResponse ListBroadcastVideosByIdWithOptions(ListBroadcastVideosByIdRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListBroadcastVideosByIdShrinkRequest request = new ListBroadcastVideosByIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VideoIds))
            {
                request.VideoIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VideoIds, "videoIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoIdsShrink))
            {
                query["videoIds"] = request.VideoIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBroadcastVideosById",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/api/v1/amp/customer/broadcast/video/batchQuery",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBroadcastVideosByIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据视频id批量查询播报视频（最多查询100个）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListBroadcastVideosByIdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBroadcastVideosByIdResponse
        /// </returns>
        public async Task<ListBroadcastVideosByIdResponse> ListBroadcastVideosByIdWithOptionsAsync(ListBroadcastVideosByIdRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListBroadcastVideosByIdShrinkRequest request = new ListBroadcastVideosByIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VideoIds))
            {
                request.VideoIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VideoIds, "videoIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoIdsShrink))
            {
                query["videoIds"] = request.VideoIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBroadcastVideosById",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/api/v1/amp/customer/broadcast/video/batchQuery",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBroadcastVideosByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据视频id批量查询播报视频（最多查询100个）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBroadcastVideosByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBroadcastVideosByIdResponse
        /// </returns>
        public ListBroadcastVideosByIdResponse ListBroadcastVideosById(ListBroadcastVideosByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListBroadcastVideosByIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据视频id批量查询播报视频（最多查询100个）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBroadcastVideosByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBroadcastVideosByIdResponse
        /// </returns>
        public async Task<ListBroadcastVideosByIdResponse> ListBroadcastVideosByIdAsync(ListBroadcastVideosByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListBroadcastVideosByIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举私有TTS音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateTTSVoicesCustomRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateTTSVoicesCustomResponse
        /// </returns>
        public ListPrivateTTSVoicesCustomResponse ListPrivateTTSVoicesCustomWithOptions(ListPrivateTTSVoicesCustomRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
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
                Action = "ListPrivateTTSVoicesCustom",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/voice/listPrivateTTSVoicesCustom",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrivateTTSVoicesCustomResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举私有TTS音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateTTSVoicesCustomRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateTTSVoicesCustomResponse
        /// </returns>
        public async Task<ListPrivateTTSVoicesCustomResponse> ListPrivateTTSVoicesCustomWithOptionsAsync(ListPrivateTTSVoicesCustomRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
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
                Action = "ListPrivateTTSVoicesCustom",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/voice/listPrivateTTSVoicesCustom",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrivateTTSVoicesCustomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举私有TTS音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateTTSVoicesCustomRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateTTSVoicesCustomResponse
        /// </returns>
        public ListPrivateTTSVoicesCustomResponse ListPrivateTTSVoicesCustom(ListPrivateTTSVoicesCustomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPrivateTTSVoicesCustomWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举私有TTS音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateTTSVoicesCustomRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateTTSVoicesCustomResponse
        /// </returns>
        public async Task<ListPrivateTTSVoicesCustomResponse> ListPrivateTTSVoicesCustomAsync(ListPrivateTTSVoicesCustomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPrivateTTSVoicesCustomWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询底板素材</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateMaterialRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateMaterialResponse
        /// </returns>
        public ListTemplateMaterialResponse ListTemplateMaterialWithOptions(ListTemplateMaterialRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                query["templateIds"] = request.TemplateIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplateMaterial",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/train/listTemplateMaterial",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplateMaterialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询底板素材</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateMaterialRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateMaterialResponse
        /// </returns>
        public async Task<ListTemplateMaterialResponse> ListTemplateMaterialWithOptionsAsync(ListTemplateMaterialRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                query["templateIds"] = request.TemplateIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplateMaterial",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/train/listTemplateMaterial",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplateMaterialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询底板素材</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateMaterialRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateMaterialResponse
        /// </returns>
        public ListTemplateMaterialResponse ListTemplateMaterial(ListTemplateMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTemplateMaterialWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询底板素材</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateMaterialRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateMaterialResponse
        /// </returns>
        public async Task<ListTemplateMaterialResponse> ListTemplateMaterialAsync(ListTemplateMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTemplateMaterialWithOptionsAsync(request, headers, runtime);
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
