// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Rtc20180111.Models;

namespace AlibabaCloud.SDK.Rtc20180111
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("rtc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /**
         * @param request AddRecordTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddRecordTemplateResponse
         */
        public AddRecordTemplateResponse AddRecordTemplateWithOptions(AddRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundColor))
            {
                query["BackgroundColor"] = request.BackgroundColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Backgrounds))
            {
                query["Backgrounds"] = request.Backgrounds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClockWidgets))
            {
                query["ClockWidgets"] = request.ClockWidgets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayStopTime))
            {
                query["DelayStopTime"] = request.DelayStopTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableM3u8DateTime))
            {
                query["EnableM3u8DateTime"] = request.EnableM3u8DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSplitInterval))
            {
                query["FileSplitInterval"] = request.FileSplitInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Formats))
            {
                query["Formats"] = request.Formats;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpCallbackUrl))
            {
                query["HttpCallbackUrl"] = request.HttpCallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutIds))
            {
                query["LayoutIds"] = request.LayoutIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaEncode))
            {
                query["MediaEncode"] = request.MediaEncode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MnsQueue))
            {
                query["MnsQueue"] = request.MnsQueue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssFilePrefix))
            {
                query["OssFilePrefix"] = request.OssFilePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskProfile))
            {
                query["TaskProfile"] = request.TaskProfile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Watermarks))
            {
                query["Watermarks"] = request.Watermarks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddRecordTemplate",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRecordTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request AddRecordTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddRecordTemplateResponse
         */
        public async Task<AddRecordTemplateResponse> AddRecordTemplateWithOptionsAsync(AddRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundColor))
            {
                query["BackgroundColor"] = request.BackgroundColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Backgrounds))
            {
                query["Backgrounds"] = request.Backgrounds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClockWidgets))
            {
                query["ClockWidgets"] = request.ClockWidgets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayStopTime))
            {
                query["DelayStopTime"] = request.DelayStopTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableM3u8DateTime))
            {
                query["EnableM3u8DateTime"] = request.EnableM3u8DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSplitInterval))
            {
                query["FileSplitInterval"] = request.FileSplitInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Formats))
            {
                query["Formats"] = request.Formats;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpCallbackUrl))
            {
                query["HttpCallbackUrl"] = request.HttpCallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutIds))
            {
                query["LayoutIds"] = request.LayoutIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaEncode))
            {
                query["MediaEncode"] = request.MediaEncode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MnsQueue))
            {
                query["MnsQueue"] = request.MnsQueue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssFilePrefix))
            {
                query["OssFilePrefix"] = request.OssFilePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskProfile))
            {
                query["TaskProfile"] = request.TaskProfile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Watermarks))
            {
                query["Watermarks"] = request.Watermarks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddRecordTemplate",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRecordTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request AddRecordTemplateRequest
         * @return AddRecordTemplateResponse
         */
        public AddRecordTemplateResponse AddRecordTemplate(AddRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddRecordTemplateWithOptions(request, runtime);
        }

        /**
         * @param request AddRecordTemplateRequest
         * @return AddRecordTemplateResponse
         */
        public async Task<AddRecordTemplateResponse> AddRecordTemplateAsync(AddRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddRecordTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 增加应用录制模版
         *
         * @param tmpReq CreateAppRecordTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppRecordTemplateResponse
         */
        public CreateAppRecordTemplateResponse CreateAppRecordTemplateWithOptions(CreateAppRecordTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAppRecordTemplateShrinkRequest request = new CreateAppRecordTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RecordTemplate))
            {
                request.RecordTemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RecordTemplate, "RecordTemplate", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordTemplateShrink))
            {
                query["RecordTemplate"] = request.RecordTemplateShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppRecordTemplate",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppRecordTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 增加应用录制模版
         *
         * @param tmpReq CreateAppRecordTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppRecordTemplateResponse
         */
        public async Task<CreateAppRecordTemplateResponse> CreateAppRecordTemplateWithOptionsAsync(CreateAppRecordTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAppRecordTemplateShrinkRequest request = new CreateAppRecordTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RecordTemplate))
            {
                request.RecordTemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RecordTemplate, "RecordTemplate", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordTemplateShrink))
            {
                query["RecordTemplate"] = request.RecordTemplateShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppRecordTemplate",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppRecordTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 增加应用录制模版
         *
         * @param request CreateAppRecordTemplateRequest
         * @return CreateAppRecordTemplateResponse
         */
        public CreateAppRecordTemplateResponse CreateAppRecordTemplate(CreateAppRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppRecordTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 增加应用录制模版
         *
         * @param request CreateAppRecordTemplateRequest
         * @return CreateAppRecordTemplateResponse
         */
        public async Task<CreateAppRecordTemplateResponse> CreateAppRecordTemplateAsync(CreateAppRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppRecordTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建应用推流模版
         *
         * @param tmpReq CreateAppStreamingOutTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppStreamingOutTemplateResponse
         */
        public CreateAppStreamingOutTemplateResponse CreateAppStreamingOutTemplateWithOptions(CreateAppStreamingOutTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAppStreamingOutTemplateShrinkRequest request = new CreateAppStreamingOutTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StreamingOutTemplate))
            {
                request.StreamingOutTemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StreamingOutTemplate, "StreamingOutTemplate", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamingOutTemplateShrink))
            {
                query["StreamingOutTemplate"] = request.StreamingOutTemplateShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppStreamingOutTemplate",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppStreamingOutTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建应用推流模版
         *
         * @param tmpReq CreateAppStreamingOutTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppStreamingOutTemplateResponse
         */
        public async Task<CreateAppStreamingOutTemplateResponse> CreateAppStreamingOutTemplateWithOptionsAsync(CreateAppStreamingOutTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAppStreamingOutTemplateShrinkRequest request = new CreateAppStreamingOutTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StreamingOutTemplate))
            {
                request.StreamingOutTemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StreamingOutTemplate, "StreamingOutTemplate", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamingOutTemplateShrink))
            {
                query["StreamingOutTemplate"] = request.StreamingOutTemplateShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppStreamingOutTemplate",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppStreamingOutTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建应用推流模版
         *
         * @param request CreateAppStreamingOutTemplateRequest
         * @return CreateAppStreamingOutTemplateResponse
         */
        public CreateAppStreamingOutTemplateResponse CreateAppStreamingOutTemplate(CreateAppStreamingOutTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppStreamingOutTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 创建应用推流模版
         *
         * @param request CreateAppStreamingOutTemplateRequest
         * @return CreateAppStreamingOutTemplateResponse
         */
        public async Task<CreateAppStreamingOutTemplateResponse> CreateAppStreamingOutTemplateAsync(CreateAppStreamingOutTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppStreamingOutTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateAutoLiveStreamRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAutoLiveStreamRuleResponse
         */
        public CreateAutoLiveStreamRuleResponse CreateAutoLiveStreamRuleWithOptions(CreateAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallBack))
            {
                query["CallBack"] = request.CallBack;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelIdPrefixes))
            {
                query["ChannelIdPrefixes"] = request.ChannelIdPrefixes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelIds))
            {
                query["ChannelIds"] = request.ChannelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaEncode))
            {
                query["MediaEncode"] = request.MediaEncode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayDomain))
            {
                query["PlayDomain"] = request.PlayDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAutoLiveStreamRule",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAutoLiveStreamRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateAutoLiveStreamRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAutoLiveStreamRuleResponse
         */
        public async Task<CreateAutoLiveStreamRuleResponse> CreateAutoLiveStreamRuleWithOptionsAsync(CreateAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallBack))
            {
                query["CallBack"] = request.CallBack;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelIdPrefixes))
            {
                query["ChannelIdPrefixes"] = request.ChannelIdPrefixes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelIds))
            {
                query["ChannelIds"] = request.ChannelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaEncode))
            {
                query["MediaEncode"] = request.MediaEncode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayDomain))
            {
                query["PlayDomain"] = request.PlayDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAutoLiveStreamRule",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAutoLiveStreamRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateAutoLiveStreamRuleRequest
         * @return CreateAutoLiveStreamRuleResponse
         */
        public CreateAutoLiveStreamRuleResponse CreateAutoLiveStreamRule(CreateAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAutoLiveStreamRuleWithOptions(request, runtime);
        }

        /**
         * @param request CreateAutoLiveStreamRuleRequest
         * @return CreateAutoLiveStreamRuleResponse
         */
        public async Task<CreateAutoLiveStreamRuleResponse> CreateAutoLiveStreamRuleAsync(CreateAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateEventSubscribeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEventSubscribeResponse
         */
        public CreateEventSubscribeResponse CreateEventSubscribeWithOptions(CreateEventSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Events))
            {
                query["Events"] = request.Events;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedCallbackAuth))
            {
                query["NeedCallbackAuth"] = request.NeedCallbackAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                query["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEventSubscribe",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventSubscribeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateEventSubscribeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEventSubscribeResponse
         */
        public async Task<CreateEventSubscribeResponse> CreateEventSubscribeWithOptionsAsync(CreateEventSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Events))
            {
                query["Events"] = request.Events;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedCallbackAuth))
            {
                query["NeedCallbackAuth"] = request.NeedCallbackAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                query["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEventSubscribe",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventSubscribeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateEventSubscribeRequest
         * @return CreateEventSubscribeResponse
         */
        public CreateEventSubscribeResponse CreateEventSubscribe(CreateEventSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEventSubscribeWithOptions(request, runtime);
        }

        /**
         * @param request CreateEventSubscribeRequest
         * @return CreateEventSubscribeResponse
         */
        public async Task<CreateEventSubscribeResponse> CreateEventSubscribeAsync(CreateEventSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEventSubscribeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMPULayoutRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMPULayoutResponse
         */
        public CreateMPULayoutResponse CreateMPULayoutWithOptions(CreateMPULayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioMixCount))
            {
                query["AudioMixCount"] = request.AudioMixCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Panes))
            {
                query["Panes"] = request.Panes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMPULayout",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMPULayoutResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateMPULayoutRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMPULayoutResponse
         */
        public async Task<CreateMPULayoutResponse> CreateMPULayoutWithOptionsAsync(CreateMPULayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioMixCount))
            {
                query["AudioMixCount"] = request.AudioMixCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Panes))
            {
                query["Panes"] = request.Panes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMPULayout",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMPULayoutResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateMPULayoutRequest
         * @return CreateMPULayoutResponse
         */
        public CreateMPULayoutResponse CreateMPULayout(CreateMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMPULayoutWithOptions(request, runtime);
        }

        /**
         * @param request CreateMPULayoutRequest
         * @return CreateMPULayoutResponse
         */
        public async Task<CreateMPULayoutResponse> CreateMPULayoutAsync(CreateMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMPULayoutWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除应用录制模版
         *
         * @param tmpReq DeleteAppRecordTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppRecordTemplateResponse
         */
        public DeleteAppRecordTemplateResponse DeleteAppRecordTemplateWithOptions(DeleteAppRecordTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAppRecordTemplateShrinkRequest request = new DeleteAppRecordTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Template))
            {
                request.TemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Template, "Template", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateShrink))
            {
                query["Template"] = request.TemplateShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppRecordTemplate",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppRecordTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除应用录制模版
         *
         * @param tmpReq DeleteAppRecordTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppRecordTemplateResponse
         */
        public async Task<DeleteAppRecordTemplateResponse> DeleteAppRecordTemplateWithOptionsAsync(DeleteAppRecordTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAppRecordTemplateShrinkRequest request = new DeleteAppRecordTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Template))
            {
                request.TemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Template, "Template", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateShrink))
            {
                query["Template"] = request.TemplateShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppRecordTemplate",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppRecordTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除应用录制模版
         *
         * @param request DeleteAppRecordTemplateRequest
         * @return DeleteAppRecordTemplateResponse
         */
        public DeleteAppRecordTemplateResponse DeleteAppRecordTemplate(DeleteAppRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppRecordTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 删除应用录制模版
         *
         * @param request DeleteAppRecordTemplateRequest
         * @return DeleteAppRecordTemplateResponse
         */
        public async Task<DeleteAppRecordTemplateResponse> DeleteAppRecordTemplateAsync(DeleteAppRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppRecordTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除应用推流模版
         *
         * @param tmpReq DeleteAppStreamingOutTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppStreamingOutTemplateResponse
         */
        public DeleteAppStreamingOutTemplateResponse DeleteAppStreamingOutTemplateWithOptions(DeleteAppStreamingOutTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAppStreamingOutTemplateShrinkRequest request = new DeleteAppStreamingOutTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StreamingOutTemplate))
            {
                request.StreamingOutTemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StreamingOutTemplate, "StreamingOutTemplate", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamingOutTemplateShrink))
            {
                query["StreamingOutTemplate"] = request.StreamingOutTemplateShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppStreamingOutTemplate",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppStreamingOutTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除应用推流模版
         *
         * @param tmpReq DeleteAppStreamingOutTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppStreamingOutTemplateResponse
         */
        public async Task<DeleteAppStreamingOutTemplateResponse> DeleteAppStreamingOutTemplateWithOptionsAsync(DeleteAppStreamingOutTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAppStreamingOutTemplateShrinkRequest request = new DeleteAppStreamingOutTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StreamingOutTemplate))
            {
                request.StreamingOutTemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StreamingOutTemplate, "StreamingOutTemplate", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamingOutTemplateShrink))
            {
                query["StreamingOutTemplate"] = request.StreamingOutTemplateShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppStreamingOutTemplate",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppStreamingOutTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除应用推流模版
         *
         * @param request DeleteAppStreamingOutTemplateRequest
         * @return DeleteAppStreamingOutTemplateResponse
         */
        public DeleteAppStreamingOutTemplateResponse DeleteAppStreamingOutTemplate(DeleteAppStreamingOutTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppStreamingOutTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 删除应用推流模版
         *
         * @param request DeleteAppStreamingOutTemplateRequest
         * @return DeleteAppStreamingOutTemplateResponse
         */
        public async Task<DeleteAppStreamingOutTemplateResponse> DeleteAppStreamingOutTemplateAsync(DeleteAppStreamingOutTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppStreamingOutTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteAutoLiveStreamRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAutoLiveStreamRuleResponse
         */
        public DeleteAutoLiveStreamRuleResponse DeleteAutoLiveStreamRuleWithOptions(DeleteAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAutoLiveStreamRule",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAutoLiveStreamRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteAutoLiveStreamRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAutoLiveStreamRuleResponse
         */
        public async Task<DeleteAutoLiveStreamRuleResponse> DeleteAutoLiveStreamRuleWithOptionsAsync(DeleteAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAutoLiveStreamRule",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAutoLiveStreamRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteAutoLiveStreamRuleRequest
         * @return DeleteAutoLiveStreamRuleResponse
         */
        public DeleteAutoLiveStreamRuleResponse DeleteAutoLiveStreamRule(DeleteAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAutoLiveStreamRuleWithOptions(request, runtime);
        }

        /**
         * @param request DeleteAutoLiveStreamRuleRequest
         * @return DeleteAutoLiveStreamRuleResponse
         */
        public async Task<DeleteAutoLiveStreamRuleResponse> DeleteAutoLiveStreamRuleAsync(DeleteAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteChannelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteChannelResponse
         */
        public DeleteChannelResponse DeleteChannelWithOptions(DeleteChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteChannel",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChannelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteChannelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteChannelResponse
         */
        public async Task<DeleteChannelResponse> DeleteChannelWithOptionsAsync(DeleteChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteChannel",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteChannelRequest
         * @return DeleteChannelResponse
         */
        public DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteChannelWithOptions(request, runtime);
        }

        /**
         * @param request DeleteChannelRequest
         * @return DeleteChannelResponse
         */
        public async Task<DeleteChannelResponse> DeleteChannelAsync(DeleteChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteChannelWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteEventSubscribeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEventSubscribeResponse
         */
        public DeleteEventSubscribeResponse DeleteEventSubscribeWithOptions(DeleteEventSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscribeId))
            {
                query["SubscribeId"] = request.SubscribeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventSubscribe",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventSubscribeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteEventSubscribeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEventSubscribeResponse
         */
        public async Task<DeleteEventSubscribeResponse> DeleteEventSubscribeWithOptionsAsync(DeleteEventSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscribeId))
            {
                query["SubscribeId"] = request.SubscribeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventSubscribe",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventSubscribeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteEventSubscribeRequest
         * @return DeleteEventSubscribeResponse
         */
        public DeleteEventSubscribeResponse DeleteEventSubscribe(DeleteEventSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventSubscribeWithOptions(request, runtime);
        }

        /**
         * @param request DeleteEventSubscribeRequest
         * @return DeleteEventSubscribeResponse
         */
        public async Task<DeleteEventSubscribeResponse> DeleteEventSubscribeAsync(DeleteEventSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventSubscribeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteMPULayoutRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMPULayoutResponse
         */
        public DeleteMPULayoutResponse DeleteMPULayoutWithOptions(DeleteMPULayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutId))
            {
                query["LayoutId"] = request.LayoutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMPULayout",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMPULayoutResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteMPULayoutRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMPULayoutResponse
         */
        public async Task<DeleteMPULayoutResponse> DeleteMPULayoutWithOptionsAsync(DeleteMPULayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutId))
            {
                query["LayoutId"] = request.LayoutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMPULayout",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMPULayoutResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteMPULayoutRequest
         * @return DeleteMPULayoutResponse
         */
        public DeleteMPULayoutResponse DeleteMPULayout(DeleteMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMPULayoutWithOptions(request, runtime);
        }

        /**
         * @param request DeleteMPULayoutRequest
         * @return DeleteMPULayoutResponse
         */
        public async Task<DeleteMPULayoutResponse> DeleteMPULayoutAsync(DeleteMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMPULayoutWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteRecordTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRecordTemplateResponse
         */
        public DeleteRecordTemplateResponse DeleteRecordTemplateWithOptions(DeleteRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRecordTemplate",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRecordTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteRecordTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRecordTemplateResponse
         */
        public async Task<DeleteRecordTemplateResponse> DeleteRecordTemplateWithOptionsAsync(DeleteRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRecordTemplate",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRecordTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteRecordTemplateRequest
         * @return DeleteRecordTemplateResponse
         */
        public DeleteRecordTemplateResponse DeleteRecordTemplate(DeleteRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRecordTemplateWithOptions(request, runtime);
        }

        /**
         * @param request DeleteRecordTemplateRequest
         * @return DeleteRecordTemplateResponse
         */
        public async Task<DeleteRecordTemplateResponse> DeleteRecordTemplateAsync(DeleteRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRecordTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列出系统支持的事件回调
         *
         * @param request DescribeAllCallbackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAllCallbackResponse
         */
        public DescribeAllCallbackResponse DescribeAllCallbackWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAllCallback",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAllCallbackResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列出系统支持的事件回调
         *
         * @param request DescribeAllCallbackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAllCallbackResponse
         */
        public async Task<DescribeAllCallbackResponse> DescribeAllCallbackWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAllCallback",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAllCallbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列出系统支持的事件回调
         *
         * @return DescribeAllCallbackResponse
         */
        public DescribeAllCallbackResponse DescribeAllCallback()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAllCallbackWithOptions(runtime);
        }

        /**
         * @summary 列出系统支持的事件回调
         *
         * @return DescribeAllCallbackResponse
         */
        public async Task<DescribeAllCallbackResponse> DescribeAllCallbackAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAllCallbackWithOptionsAsync(runtime);
        }

        /**
         * @summary 查看app回调开关
         *
         * @param request DescribeAppCallStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppCallStatusResponse
         */
        public DescribeAppCallStatusResponse DescribeAppCallStatusWithOptions(DescribeAppCallStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppCallStatus",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppCallStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查看app回调开关
         *
         * @param request DescribeAppCallStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppCallStatusResponse
         */
        public async Task<DescribeAppCallStatusResponse> DescribeAppCallStatusWithOptionsAsync(DescribeAppCallStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppCallStatus",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppCallStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查看app回调开关
         *
         * @param request DescribeAppCallStatusRequest
         * @return DescribeAppCallStatusResponse
         */
        public DescribeAppCallStatusResponse DescribeAppCallStatus(DescribeAppCallStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppCallStatusWithOptions(request, runtime);
        }

        /**
         * @summary 查看app回调开关
         *
         * @param request DescribeAppCallStatusRequest
         * @return DescribeAppCallStatusResponse
         */
        public async Task<DescribeAppCallStatusResponse> DescribeAppCallStatusAsync(DescribeAppCallStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppCallStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取app回调密钥
         *
         * @param request DescribeAppCallbackSecretKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppCallbackSecretKeyResponse
         */
        public DescribeAppCallbackSecretKeyResponse DescribeAppCallbackSecretKeyWithOptions(DescribeAppCallbackSecretKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppCallbackSecretKey",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppCallbackSecretKeyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取app回调密钥
         *
         * @param request DescribeAppCallbackSecretKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppCallbackSecretKeyResponse
         */
        public async Task<DescribeAppCallbackSecretKeyResponse> DescribeAppCallbackSecretKeyWithOptionsAsync(DescribeAppCallbackSecretKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppCallbackSecretKey",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppCallbackSecretKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取app回调密钥
         *
         * @param request DescribeAppCallbackSecretKeyRequest
         * @return DescribeAppCallbackSecretKeyResponse
         */
        public DescribeAppCallbackSecretKeyResponse DescribeAppCallbackSecretKey(DescribeAppCallbackSecretKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppCallbackSecretKeyWithOptions(request, runtime);
        }

        /**
         * @summary 获取app回调密钥
         *
         * @param request DescribeAppCallbackSecretKeyRequest
         * @return DescribeAppCallbackSecretKeyResponse
         */
        public async Task<DescribeAppCallbackSecretKeyResponse> DescribeAppCallbackSecretKeyAsync(DescribeAppCallbackSecretKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppCallbackSecretKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查看AppKey
         *
         * @param request DescribeAppKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppKeyResponse
         */
        public DescribeAppKeyResponse DescribeAppKeyWithOptions(DescribeAppKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppKey",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppKeyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查看AppKey
         *
         * @param request DescribeAppKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppKeyResponse
         */
        public async Task<DescribeAppKeyResponse> DescribeAppKeyWithOptionsAsync(DescribeAppKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppKey",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查看AppKey
         *
         * @param request DescribeAppKeyRequest
         * @return DescribeAppKeyResponse
         */
        public DescribeAppKeyResponse DescribeAppKey(DescribeAppKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppKeyWithOptions(request, runtime);
        }

        /**
         * @summary 查看AppKey
         *
         * @param request DescribeAppKeyRequest
         * @return DescribeAppKeyResponse
         */
        public async Task<DescribeAppKeyResponse> DescribeAppKeyAsync(DescribeAppKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询app自定义布局
         *
         * @param tmpReq DescribeAppLayoutsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppLayoutsResponse
         */
        public DescribeAppLayoutsResponse DescribeAppLayoutsWithOptions(DescribeAppLayoutsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeAppLayoutsShrinkRequest request = new DescribeAppLayoutsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Condition))
            {
                request.ConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Condition, "Condition", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppLayouts",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppLayoutsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询app自定义布局
         *
         * @param tmpReq DescribeAppLayoutsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppLayoutsResponse
         */
        public async Task<DescribeAppLayoutsResponse> DescribeAppLayoutsWithOptionsAsync(DescribeAppLayoutsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeAppLayoutsShrinkRequest request = new DescribeAppLayoutsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Condition))
            {
                request.ConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Condition, "Condition", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppLayouts",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppLayoutsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询app自定义布局
         *
         * @param request DescribeAppLayoutsRequest
         * @return DescribeAppLayoutsResponse
         */
        public DescribeAppLayoutsResponse DescribeAppLayouts(DescribeAppLayoutsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppLayoutsWithOptions(request, runtime);
        }

        /**
         * @summary 查询app自定义布局
         *
         * @param request DescribeAppLayoutsRequest
         * @return DescribeAppLayoutsResponse
         */
        public async Task<DescribeAppLayoutsResponse> DescribeAppLayoutsAsync(DescribeAppLayoutsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppLayoutsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查看应用旁路开关
         *
         * @param request DescribeAppLiveStreamStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppLiveStreamStatusResponse
         */
        public DescribeAppLiveStreamStatusResponse DescribeAppLiveStreamStatusWithOptions(DescribeAppLiveStreamStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppLiveStreamStatus",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppLiveStreamStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查看应用旁路开关
         *
         * @param request DescribeAppLiveStreamStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppLiveStreamStatusResponse
         */
        public async Task<DescribeAppLiveStreamStatusResponse> DescribeAppLiveStreamStatusWithOptionsAsync(DescribeAppLiveStreamStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppLiveStreamStatus",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppLiveStreamStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查看应用旁路开关
         *
         * @param request DescribeAppLiveStreamStatusRequest
         * @return DescribeAppLiveStreamStatusResponse
         */
        public DescribeAppLiveStreamStatusResponse DescribeAppLiveStreamStatus(DescribeAppLiveStreamStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppLiveStreamStatusWithOptions(request, runtime);
        }

        /**
         * @summary 查看应用旁路开关
         *
         * @param request DescribeAppLiveStreamStatusRequest
         * @return DescribeAppLiveStreamStatusResponse
         */
        public async Task<DescribeAppLiveStreamStatusResponse> DescribeAppLiveStreamStatusAsync(DescribeAppLiveStreamStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppLiveStreamStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询应用录制开关
         *
         * @param request DescribeAppRecordStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppRecordStatusResponse
         */
        public DescribeAppRecordStatusResponse DescribeAppRecordStatusWithOptions(DescribeAppRecordStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppRecordStatus",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppRecordStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询应用录制开关
         *
         * @param request DescribeAppRecordStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppRecordStatusResponse
         */
        public async Task<DescribeAppRecordStatusResponse> DescribeAppRecordStatusWithOptionsAsync(DescribeAppRecordStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppRecordStatus",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppRecordStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询应用录制开关
         *
         * @param request DescribeAppRecordStatusRequest
         * @return DescribeAppRecordStatusResponse
         */
        public DescribeAppRecordStatusResponse DescribeAppRecordStatus(DescribeAppRecordStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppRecordStatusWithOptions(request, runtime);
        }

        /**
         * @summary 查询应用录制开关
         *
         * @param request DescribeAppRecordStatusRequest
         * @return DescribeAppRecordStatusResponse
         */
        public async Task<DescribeAppRecordStatusResponse> DescribeAppRecordStatusAsync(DescribeAppRecordStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppRecordStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 应用录制模版列表
         *
         * @param tmpReq DescribeAppRecordTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppRecordTemplatesResponse
         */
        public DescribeAppRecordTemplatesResponse DescribeAppRecordTemplatesWithOptions(DescribeAppRecordTemplatesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeAppRecordTemplatesShrinkRequest request = new DescribeAppRecordTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Condition))
            {
                request.ConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Condition, "Condition", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppRecordTemplates",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppRecordTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 应用录制模版列表
         *
         * @param tmpReq DescribeAppRecordTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppRecordTemplatesResponse
         */
        public async Task<DescribeAppRecordTemplatesResponse> DescribeAppRecordTemplatesWithOptionsAsync(DescribeAppRecordTemplatesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeAppRecordTemplatesShrinkRequest request = new DescribeAppRecordTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Condition))
            {
                request.ConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Condition, "Condition", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppRecordTemplates",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppRecordTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 应用录制模版列表
         *
         * @param request DescribeAppRecordTemplatesRequest
         * @return DescribeAppRecordTemplatesResponse
         */
        public DescribeAppRecordTemplatesResponse DescribeAppRecordTemplates(DescribeAppRecordTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppRecordTemplatesWithOptions(request, runtime);
        }

        /**
         * @summary 应用录制模版列表
         *
         * @param request DescribeAppRecordTemplatesRequest
         * @return DescribeAppRecordTemplatesResponse
         */
        public async Task<DescribeAppRecordTemplatesResponse> DescribeAppRecordTemplatesAsync(DescribeAppRecordTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppRecordTemplatesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询录制列表
         *
         * @param tmpReq DescribeAppRecordingFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppRecordingFilesResponse
         */
        public DescribeAppRecordingFilesResponse DescribeAppRecordingFilesWithOptions(DescribeAppRecordingFilesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeAppRecordingFilesShrinkRequest request = new DescribeAppRecordingFilesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskIds))
            {
                request.TaskIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskIds, "TaskIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppRecordingFiles",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppRecordingFilesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询录制列表
         *
         * @param tmpReq DescribeAppRecordingFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppRecordingFilesResponse
         */
        public async Task<DescribeAppRecordingFilesResponse> DescribeAppRecordingFilesWithOptionsAsync(DescribeAppRecordingFilesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeAppRecordingFilesShrinkRequest request = new DescribeAppRecordingFilesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskIds))
            {
                request.TaskIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskIds, "TaskIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppRecordingFiles",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppRecordingFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询录制列表
         *
         * @param request DescribeAppRecordingFilesRequest
         * @return DescribeAppRecordingFilesResponse
         */
        public DescribeAppRecordingFilesResponse DescribeAppRecordingFiles(DescribeAppRecordingFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppRecordingFilesWithOptions(request, runtime);
        }

        /**
         * @summary 查询录制列表
         *
         * @param request DescribeAppRecordingFilesRequest
         * @return DescribeAppRecordingFilesResponse
         */
        public async Task<DescribeAppRecordingFilesResponse> DescribeAppRecordingFilesAsync(DescribeAppRecordingFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppRecordingFilesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 应用推流模版列表
         *
         * @param tmpReq DescribeAppStreamingOutTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppStreamingOutTemplatesResponse
         */
        public DescribeAppStreamingOutTemplatesResponse DescribeAppStreamingOutTemplatesWithOptions(DescribeAppStreamingOutTemplatesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeAppStreamingOutTemplatesShrinkRequest request = new DescribeAppStreamingOutTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Condition))
            {
                request.ConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Condition, "Condition", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConditionShrink))
            {
                query["Condition"] = request.ConditionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppStreamingOutTemplates",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppStreamingOutTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 应用推流模版列表
         *
         * @param tmpReq DescribeAppStreamingOutTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppStreamingOutTemplatesResponse
         */
        public async Task<DescribeAppStreamingOutTemplatesResponse> DescribeAppStreamingOutTemplatesWithOptionsAsync(DescribeAppStreamingOutTemplatesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeAppStreamingOutTemplatesShrinkRequest request = new DescribeAppStreamingOutTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Condition))
            {
                request.ConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Condition, "Condition", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConditionShrink))
            {
                query["Condition"] = request.ConditionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppStreamingOutTemplates",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppStreamingOutTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 应用推流模版列表
         *
         * @param request DescribeAppStreamingOutTemplatesRequest
         * @return DescribeAppStreamingOutTemplatesResponse
         */
        public DescribeAppStreamingOutTemplatesResponse DescribeAppStreamingOutTemplates(DescribeAppStreamingOutTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppStreamingOutTemplatesWithOptions(request, runtime);
        }

        /**
         * @summary 应用推流模版列表
         *
         * @param request DescribeAppStreamingOutTemplatesRequest
         * @return DescribeAppStreamingOutTemplatesResponse
         */
        public async Task<DescribeAppStreamingOutTemplatesResponse> DescribeAppStreamingOutTemplatesAsync(DescribeAppStreamingOutTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppStreamingOutTemplatesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary App列表
         *
         * @param request DescribeAppsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppsResponse
         */
        public DescribeAppsResponse DescribeAppsWithOptions(DescribeAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                query["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "DescribeApps",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary App列表
         *
         * @param request DescribeAppsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppsResponse
         */
        public async Task<DescribeAppsResponse> DescribeAppsWithOptionsAsync(DescribeAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                query["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "DescribeApps",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary App列表
         *
         * @param request DescribeAppsRequest
         * @return DescribeAppsResponse
         */
        public DescribeAppsResponse DescribeApps(DescribeAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppsWithOptions(request, runtime);
        }

        /**
         * @summary App列表
         *
         * @param request DescribeAppsRequest
         * @return DescribeAppsResponse
         */
        public async Task<DescribeAppsResponse> DescribeAppsAsync(DescribeAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAutoLiveStreamRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAutoLiveStreamRuleResponse
         */
        public DescribeAutoLiveStreamRuleResponse DescribeAutoLiveStreamRuleWithOptions(DescribeAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutoLiveStreamRule",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutoLiveStreamRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAutoLiveStreamRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAutoLiveStreamRuleResponse
         */
        public async Task<DescribeAutoLiveStreamRuleResponse> DescribeAutoLiveStreamRuleWithOptionsAsync(DescribeAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutoLiveStreamRule",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutoLiveStreamRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAutoLiveStreamRuleRequest
         * @return DescribeAutoLiveStreamRuleResponse
         */
        public DescribeAutoLiveStreamRuleResponse DescribeAutoLiveStreamRule(DescribeAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoLiveStreamRuleWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAutoLiveStreamRuleRequest
         * @return DescribeAutoLiveStreamRuleResponse
         */
        public async Task<DescribeAutoLiveStreamRuleResponse> DescribeAutoLiveStreamRuleAsync(DescribeAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 调用DescribeCall获取单次通信详情。
         *
         * @param request DescribeCallRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCallResponse
         */
        public DescribeCallResponse DescribeCallWithOptions(DescribeCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtDataType))
            {
                query["ExtDataType"] = request.ExtDataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryExpInfo))
            {
                query["QueryExpInfo"] = request.QueryExpInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCall",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCallResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用DescribeCall获取单次通信详情。
         *
         * @param request DescribeCallRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCallResponse
         */
        public async Task<DescribeCallResponse> DescribeCallWithOptionsAsync(DescribeCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtDataType))
            {
                query["ExtDataType"] = request.ExtDataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryExpInfo))
            {
                query["QueryExpInfo"] = request.QueryExpInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCall",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用DescribeCall获取单次通信详情。
         *
         * @param request DescribeCallRequest
         * @return DescribeCallResponse
         */
        public DescribeCallResponse DescribeCall(DescribeCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCallWithOptions(request, runtime);
        }

        /**
         * @summary 调用DescribeCall获取单次通信详情。
         *
         * @param request DescribeCallRequest
         * @return DescribeCallResponse
         */
        public async Task<DescribeCallResponse> DescribeCallAsync(DescribeCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCallWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 调用DescribeCallList分页查询时间范围内创建的通信信息。
         *
         * @param request DescribeCallListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCallListResponse
         */
        public DescribeCallListResponse DescribeCallListWithOptions(DescribeCallListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallStatus))
            {
                query["CallStatus"] = request.CallStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryMode))
            {
                query["QueryMode"] = request.QueryMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCallList",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCallListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用DescribeCallList分页查询时间范围内创建的通信信息。
         *
         * @param request DescribeCallListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCallListResponse
         */
        public async Task<DescribeCallListResponse> DescribeCallListWithOptionsAsync(DescribeCallListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallStatus))
            {
                query["CallStatus"] = request.CallStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryMode))
            {
                query["QueryMode"] = request.QueryMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCallList",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCallListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用DescribeCallList分页查询时间范围内创建的通信信息。
         *
         * @param request DescribeCallListRequest
         * @return DescribeCallListResponse
         */
        public DescribeCallListResponse DescribeCallList(DescribeCallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCallListWithOptions(request, runtime);
        }

        /**
         * @summary 调用DescribeCallList分页查询时间范围内创建的通信信息。
         *
         * @param request DescribeCallListRequest
         * @return DescribeCallListResponse
         */
        public async Task<DescribeCallListResponse> DescribeCallListAsync(DescribeCallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCallListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary app事件回调列表
         *
         * @param request DescribeCallbacksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCallbacksResponse
         */
        public DescribeCallbacksResponse DescribeCallbacksWithOptions(DescribeCallbacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCallbacks",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCallbacksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary app事件回调列表
         *
         * @param request DescribeCallbacksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCallbacksResponse
         */
        public async Task<DescribeCallbacksResponse> DescribeCallbacksWithOptionsAsync(DescribeCallbacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCallbacks",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCallbacksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary app事件回调列表
         *
         * @param request DescribeCallbacksRequest
         * @return DescribeCallbacksResponse
         */
        public DescribeCallbacksResponse DescribeCallbacks(DescribeCallbacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCallbacksWithOptions(request, runtime);
        }

        /**
         * @summary app事件回调列表
         *
         * @param request DescribeCallbacksRequest
         * @return DescribeCallbacksResponse
         */
        public async Task<DescribeCallbacksResponse> DescribeCallbacksAsync(DescribeCallbacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCallbacksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary DescribeChannel
         *
         * @param request DescribeChannelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelResponse
         */
        public DescribeChannelResponse DescribeChannelWithOptions(DescribeChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannel",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary DescribeChannel
         *
         * @param request DescribeChannelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelResponse
         */
        public async Task<DescribeChannelResponse> DescribeChannelWithOptionsAsync(DescribeChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannel",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary DescribeChannel
         *
         * @param request DescribeChannelRequest
         * @return DescribeChannelResponse
         */
        public DescribeChannelResponse DescribeChannel(DescribeChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelWithOptions(request, runtime);
        }

        /**
         * @summary DescribeChannel
         *
         * @param request DescribeChannelRequest
         * @return DescribeChannelResponse
         */
        public async Task<DescribeChannelResponse> DescribeChannelAsync(DescribeChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询频道的所有参会者
         *
         * @param request DescribeChannelAllUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelAllUsersResponse
         */
        public DescribeChannelAllUsersResponse DescribeChannelAllUsersWithOptions(DescribeChannelAllUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelAllUsers",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelAllUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询频道的所有参会者
         *
         * @param request DescribeChannelAllUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelAllUsersResponse
         */
        public async Task<DescribeChannelAllUsersResponse> DescribeChannelAllUsersWithOptionsAsync(DescribeChannelAllUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelAllUsers",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelAllUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询频道的所有参会者
         *
         * @param request DescribeChannelAllUsersRequest
         * @return DescribeChannelAllUsersResponse
         */
        public DescribeChannelAllUsersResponse DescribeChannelAllUsers(DescribeChannelAllUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelAllUsersWithOptions(request, runtime);
        }

        /**
         * @summary 查询频道的所有参会者
         *
         * @param request DescribeChannelAllUsersRequest
         * @return DescribeChannelAllUsersResponse
         */
        public async Task<DescribeChannelAllUsersResponse> DescribeChannelAllUsersAsync(DescribeChannelAllUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelAllUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 调用DescribeChannelAreaDistributionStatData获取频道地区分布统计数据。
         *
         * @param request DescribeChannelAreaDistributionStatDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelAreaDistributionStatDataResponse
         */
        public DescribeChannelAreaDistributionStatDataResponse DescribeChannelAreaDistributionStatDataWithOptions(DescribeChannelAreaDistributionStatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentArea))
            {
                query["ParentArea"] = request.ParentArea;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelAreaDistributionStatData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelAreaDistributionStatDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用DescribeChannelAreaDistributionStatData获取频道地区分布统计数据。
         *
         * @param request DescribeChannelAreaDistributionStatDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelAreaDistributionStatDataResponse
         */
        public async Task<DescribeChannelAreaDistributionStatDataResponse> DescribeChannelAreaDistributionStatDataWithOptionsAsync(DescribeChannelAreaDistributionStatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentArea))
            {
                query["ParentArea"] = request.ParentArea;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelAreaDistributionStatData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelAreaDistributionStatDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用DescribeChannelAreaDistributionStatData获取频道地区分布统计数据。
         *
         * @param request DescribeChannelAreaDistributionStatDataRequest
         * @return DescribeChannelAreaDistributionStatDataResponse
         */
        public DescribeChannelAreaDistributionStatDataResponse DescribeChannelAreaDistributionStatData(DescribeChannelAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelAreaDistributionStatDataWithOptions(request, runtime);
        }

        /**
         * @summary 调用DescribeChannelAreaDistributionStatData获取频道地区分布统计数据。
         *
         * @param request DescribeChannelAreaDistributionStatDataRequest
         * @return DescribeChannelAreaDistributionStatDataResponse
         */
        public async Task<DescribeChannelAreaDistributionStatDataResponse> DescribeChannelAreaDistributionStatDataAsync(DescribeChannelAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelAreaDistributionStatDataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 调用DescribeChannelDistributionStatData获取频道分布统计数据。
         *
         * @param request DescribeChannelDistributionStatDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelDistributionStatDataResponse
         */
        public DescribeChannelDistributionStatDataResponse DescribeChannelDistributionStatDataWithOptions(DescribeChannelDistributionStatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelDistributionStatData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelDistributionStatDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用DescribeChannelDistributionStatData获取频道分布统计数据。
         *
         * @param request DescribeChannelDistributionStatDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelDistributionStatDataResponse
         */
        public async Task<DescribeChannelDistributionStatDataResponse> DescribeChannelDistributionStatDataWithOptionsAsync(DescribeChannelDistributionStatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelDistributionStatData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelDistributionStatDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用DescribeChannelDistributionStatData获取频道分布统计数据。
         *
         * @param request DescribeChannelDistributionStatDataRequest
         * @return DescribeChannelDistributionStatDataResponse
         */
        public DescribeChannelDistributionStatDataResponse DescribeChannelDistributionStatData(DescribeChannelDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelDistributionStatDataWithOptions(request, runtime);
        }

        /**
         * @summary 调用DescribeChannelDistributionStatData获取频道分布统计数据。
         *
         * @param request DescribeChannelDistributionStatDataRequest
         * @return DescribeChannelDistributionStatDataResponse
         */
        public async Task<DescribeChannelDistributionStatDataResponse> DescribeChannelDistributionStatDataAsync(DescribeChannelDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelDistributionStatDataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 调用DescribeChannelOverallData查询频道概览数据。
         *
         * @param request DescribeChannelOverallDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelOverallDataResponse
         */
        public DescribeChannelOverallDataResponse DescribeChannelOverallDataWithOptions(DescribeChannelOverallDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelOverallData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelOverallDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用DescribeChannelOverallData查询频道概览数据。
         *
         * @param request DescribeChannelOverallDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelOverallDataResponse
         */
        public async Task<DescribeChannelOverallDataResponse> DescribeChannelOverallDataWithOptionsAsync(DescribeChannelOverallDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelOverallData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelOverallDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用DescribeChannelOverallData查询频道概览数据。
         *
         * @param request DescribeChannelOverallDataRequest
         * @return DescribeChannelOverallDataResponse
         */
        public DescribeChannelOverallDataResponse DescribeChannelOverallData(DescribeChannelOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelOverallDataWithOptions(request, runtime);
        }

        /**
         * @summary 调用DescribeChannelOverallData查询频道概览数据。
         *
         * @param request DescribeChannelOverallDataRequest
         * @return DescribeChannelOverallDataResponse
         */
        public async Task<DescribeChannelOverallDataResponse> DescribeChannelOverallDataAsync(DescribeChannelOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelOverallDataWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeChannelParticipantsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelParticipantsResponse
         */
        public DescribeChannelParticipantsResponse DescribeChannelParticipantsWithOptions(DescribeChannelParticipantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelParticipants",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelParticipantsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeChannelParticipantsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelParticipantsResponse
         */
        public async Task<DescribeChannelParticipantsResponse> DescribeChannelParticipantsWithOptionsAsync(DescribeChannelParticipantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelParticipants",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelParticipantsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeChannelParticipantsRequest
         * @return DescribeChannelParticipantsResponse
         */
        public DescribeChannelParticipantsResponse DescribeChannelParticipants(DescribeChannelParticipantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelParticipantsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeChannelParticipantsRequest
         * @return DescribeChannelParticipantsResponse
         */
        public async Task<DescribeChannelParticipantsResponse> DescribeChannelParticipantsAsync(DescribeChannelParticipantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelParticipantsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 调用DescribeChannelTopPubUserList获取频道内发布端的用户列表（按用户在线时长降序）。
         *
         * @param request DescribeChannelTopPubUserListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelTopPubUserListResponse
         */
        public DescribeChannelTopPubUserListResponse DescribeChannelTopPubUserListWithOptions(DescribeChannelTopPubUserListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelTopPubUserList",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelTopPubUserListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用DescribeChannelTopPubUserList获取频道内发布端的用户列表（按用户在线时长降序）。
         *
         * @param request DescribeChannelTopPubUserListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelTopPubUserListResponse
         */
        public async Task<DescribeChannelTopPubUserListResponse> DescribeChannelTopPubUserListWithOptionsAsync(DescribeChannelTopPubUserListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelTopPubUserList",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelTopPubUserListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用DescribeChannelTopPubUserList获取频道内发布端的用户列表（按用户在线时长降序）。
         *
         * @param request DescribeChannelTopPubUserListRequest
         * @return DescribeChannelTopPubUserListResponse
         */
        public DescribeChannelTopPubUserListResponse DescribeChannelTopPubUserList(DescribeChannelTopPubUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelTopPubUserListWithOptions(request, runtime);
        }

        /**
         * @summary 调用DescribeChannelTopPubUserList获取频道内发布端的用户列表（按用户在线时长降序）。
         *
         * @param request DescribeChannelTopPubUserListRequest
         * @return DescribeChannelTopPubUserListResponse
         */
        public async Task<DescribeChannelTopPubUserListResponse> DescribeChannelTopPubUserListAsync(DescribeChannelTopPubUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelTopPubUserListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary DescribeChannelUser
         *
         * @param request DescribeChannelUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelUserResponse
         */
        public DescribeChannelUserResponse DescribeChannelUserWithOptions(DescribeChannelUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelUser",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary DescribeChannelUser
         *
         * @param request DescribeChannelUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelUserResponse
         */
        public async Task<DescribeChannelUserResponse> DescribeChannelUserWithOptionsAsync(DescribeChannelUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelUser",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary DescribeChannelUser
         *
         * @param request DescribeChannelUserRequest
         * @return DescribeChannelUserResponse
         */
        public DescribeChannelUserResponse DescribeChannelUser(DescribeChannelUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelUserWithOptions(request, runtime);
        }

        /**
         * @summary DescribeChannelUser
         *
         * @param request DescribeChannelUserRequest
         * @return DescribeChannelUserResponse
         */
        public async Task<DescribeChannelUserResponse> DescribeChannelUserAsync(DescribeChannelUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 调用DescribeChannelUserMetrics查询频道总览中的用户数据。
         *
         * @param request DescribeChannelUserMetricsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelUserMetricsResponse
         */
        public DescribeChannelUserMetricsResponse DescribeChannelUserMetricsWithOptions(DescribeChannelUserMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelUserMetrics",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelUserMetricsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用DescribeChannelUserMetrics查询频道总览中的用户数据。
         *
         * @param request DescribeChannelUserMetricsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelUserMetricsResponse
         */
        public async Task<DescribeChannelUserMetricsResponse> DescribeChannelUserMetricsWithOptionsAsync(DescribeChannelUserMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelUserMetrics",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelUserMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用DescribeChannelUserMetrics查询频道总览中的用户数据。
         *
         * @param request DescribeChannelUserMetricsRequest
         * @return DescribeChannelUserMetricsResponse
         */
        public DescribeChannelUserMetricsResponse DescribeChannelUserMetrics(DescribeChannelUserMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelUserMetricsWithOptions(request, runtime);
        }

        /**
         * @summary 调用DescribeChannelUserMetrics查询频道总览中的用户数据。
         *
         * @param request DescribeChannelUserMetricsRequest
         * @return DescribeChannelUserMetricsResponse
         */
        public async Task<DescribeChannelUserMetricsResponse> DescribeChannelUserMetricsAsync(DescribeChannelUserMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelUserMetricsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeChannelUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelUsersResponse
         */
        public DescribeChannelUsersResponse DescribeChannelUsersWithOptions(DescribeChannelUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelUsers",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeChannelUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelUsersResponse
         */
        public async Task<DescribeChannelUsersResponse> DescribeChannelUsersWithOptionsAsync(DescribeChannelUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelUsers",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeChannelUsersRequest
         * @return DescribeChannelUsersResponse
         */
        public DescribeChannelUsersResponse DescribeChannelUsers(DescribeChannelUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelUsersWithOptions(request, runtime);
        }

        /**
         * @param request DescribeChannelUsersRequest
         * @return DescribeChannelUsersResponse
         */
        public async Task<DescribeChannelUsersResponse> DescribeChannelUsersAsync(DescribeChannelUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询在线频道列表
         *
         * @param request DescribeChannelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelsResponse
         */
        public DescribeChannelsResponse DescribeChannelsWithOptions(DescribeChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannels",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询在线频道列表
         *
         * @param request DescribeChannelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChannelsResponse
         */
        public async Task<DescribeChannelsResponse> DescribeChannelsWithOptionsAsync(DescribeChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannels",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询在线频道列表
         *
         * @param request DescribeChannelsRequest
         * @return DescribeChannelsResponse
         */
        public DescribeChannelsResponse DescribeChannels(DescribeChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelsWithOptions(request, runtime);
        }

        /**
         * @summary 查询在线频道列表
         *
         * @param request DescribeChannelsRequest
         * @return DescribeChannelsResponse
         */
        public async Task<DescribeChannelsResponse> DescribeChannelsAsync(DescribeChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 调用DescribeEndPointEventList获取端对端用户事件列表。
         *
         * @param request DescribeEndPointEventListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEndPointEventListResponse
         */
        public DescribeEndPointEventListResponse DescribeEndPointEventListWithOptions(DescribeEndPointEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                query["UserIdList"] = request.UserIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEndPointEventList",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEndPointEventListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用DescribeEndPointEventList获取端对端用户事件列表。
         *
         * @param request DescribeEndPointEventListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEndPointEventListResponse
         */
        public async Task<DescribeEndPointEventListResponse> DescribeEndPointEventListWithOptionsAsync(DescribeEndPointEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                query["UserIdList"] = request.UserIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEndPointEventList",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEndPointEventListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用DescribeEndPointEventList获取端对端用户事件列表。
         *
         * @param request DescribeEndPointEventListRequest
         * @return DescribeEndPointEventListResponse
         */
        public DescribeEndPointEventListResponse DescribeEndPointEventList(DescribeEndPointEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEndPointEventListWithOptions(request, runtime);
        }

        /**
         * @summary 调用DescribeEndPointEventList获取端对端用户事件列表。
         *
         * @param request DescribeEndPointEventListRequest
         * @return DescribeEndPointEventListResponse
         */
        public async Task<DescribeEndPointEventListResponse> DescribeEndPointEventListAsync(DescribeEndPointEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEndPointEventListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 调用DescribeEndPointMetricData获取端对端指标数据。
         *
         * @param request DescribeEndPointMetricDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEndPointMetricDataResponse
         */
        public DescribeEndPointMetricDataResponse DescribeEndPointMetricDataWithOptions(DescribeEndPointMetricDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                query["Metrics"] = request.Metrics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PubCallIdList))
            {
                query["PubCallIdList"] = request.PubCallIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PubUserId))
            {
                query["PubUserId"] = request.PubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEndPointMetricData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEndPointMetricDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用DescribeEndPointMetricData获取端对端指标数据。
         *
         * @param request DescribeEndPointMetricDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEndPointMetricDataResponse
         */
        public async Task<DescribeEndPointMetricDataResponse> DescribeEndPointMetricDataWithOptionsAsync(DescribeEndPointMetricDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                query["Metrics"] = request.Metrics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PubCallIdList))
            {
                query["PubCallIdList"] = request.PubCallIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PubUserId))
            {
                query["PubUserId"] = request.PubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEndPointMetricData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEndPointMetricDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用DescribeEndPointMetricData获取端对端指标数据。
         *
         * @param request DescribeEndPointMetricDataRequest
         * @return DescribeEndPointMetricDataResponse
         */
        public DescribeEndPointMetricDataResponse DescribeEndPointMetricData(DescribeEndPointMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEndPointMetricDataWithOptions(request, runtime);
        }

        /**
         * @summary 调用DescribeEndPointMetricData获取端对端指标数据。
         *
         * @param request DescribeEndPointMetricDataRequest
         * @return DescribeEndPointMetricDataResponse
         */
        public async Task<DescribeEndPointMetricDataResponse> DescribeEndPointMetricDataAsync(DescribeEndPointMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEndPointMetricDataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取异常诊断影响因素分布
         *
         * @param request DescribeFaultDiagnosisFactorDistributionStatRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFaultDiagnosisFactorDistributionStatResponse
         */
        public DescribeFaultDiagnosisFactorDistributionStatResponse DescribeFaultDiagnosisFactorDistributionStatWithOptions(DescribeFaultDiagnosisFactorDistributionStatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFaultDiagnosisFactorDistributionStat",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisFactorDistributionStatResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取异常诊断影响因素分布
         *
         * @param request DescribeFaultDiagnosisFactorDistributionStatRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFaultDiagnosisFactorDistributionStatResponse
         */
        public async Task<DescribeFaultDiagnosisFactorDistributionStatResponse> DescribeFaultDiagnosisFactorDistributionStatWithOptionsAsync(DescribeFaultDiagnosisFactorDistributionStatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFaultDiagnosisFactorDistributionStat",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisFactorDistributionStatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取异常诊断影响因素分布
         *
         * @param request DescribeFaultDiagnosisFactorDistributionStatRequest
         * @return DescribeFaultDiagnosisFactorDistributionStatResponse
         */
        public DescribeFaultDiagnosisFactorDistributionStatResponse DescribeFaultDiagnosisFactorDistributionStat(DescribeFaultDiagnosisFactorDistributionStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFaultDiagnosisFactorDistributionStatWithOptions(request, runtime);
        }

        /**
         * @summary 获取异常诊断影响因素分布
         *
         * @param request DescribeFaultDiagnosisFactorDistributionStatRequest
         * @return DescribeFaultDiagnosisFactorDistributionStatResponse
         */
        public async Task<DescribeFaultDiagnosisFactorDistributionStatResponse> DescribeFaultDiagnosisFactorDistributionStatAsync(DescribeFaultDiagnosisFactorDistributionStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFaultDiagnosisFactorDistributionStatWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取异常诊断总览数据
         *
         * @param request DescribeFaultDiagnosisOverallDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFaultDiagnosisOverallDataResponse
         */
        public DescribeFaultDiagnosisOverallDataResponse DescribeFaultDiagnosisOverallDataWithOptions(DescribeFaultDiagnosisOverallDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFaultDiagnosisOverallData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisOverallDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取异常诊断总览数据
         *
         * @param request DescribeFaultDiagnosisOverallDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFaultDiagnosisOverallDataResponse
         */
        public async Task<DescribeFaultDiagnosisOverallDataResponse> DescribeFaultDiagnosisOverallDataWithOptionsAsync(DescribeFaultDiagnosisOverallDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFaultDiagnosisOverallData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisOverallDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取异常诊断总览数据
         *
         * @param request DescribeFaultDiagnosisOverallDataRequest
         * @return DescribeFaultDiagnosisOverallDataResponse
         */
        public DescribeFaultDiagnosisOverallDataResponse DescribeFaultDiagnosisOverallData(DescribeFaultDiagnosisOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFaultDiagnosisOverallDataWithOptions(request, runtime);
        }

        /**
         * @summary 获取异常诊断总览数据
         *
         * @param request DescribeFaultDiagnosisOverallDataRequest
         * @return DescribeFaultDiagnosisOverallDataResponse
         */
        public async Task<DescribeFaultDiagnosisOverallDataResponse> DescribeFaultDiagnosisOverallDataAsync(DescribeFaultDiagnosisOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFaultDiagnosisOverallDataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取异常诊断用户详情
         *
         * @param request DescribeFaultDiagnosisUserDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFaultDiagnosisUserDetailResponse
         */
        public DescribeFaultDiagnosisUserDetailResponse DescribeFaultDiagnosisUserDetailWithOptions(DescribeFaultDiagnosisUserDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultType))
            {
                query["FaultType"] = request.FaultType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCallUserInfo))
            {
                query["QueryCallUserInfo"] = request.QueryCallUserInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFaultDiagnosisUserDetail",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisUserDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取异常诊断用户详情
         *
         * @param request DescribeFaultDiagnosisUserDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFaultDiagnosisUserDetailResponse
         */
        public async Task<DescribeFaultDiagnosisUserDetailResponse> DescribeFaultDiagnosisUserDetailWithOptionsAsync(DescribeFaultDiagnosisUserDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultType))
            {
                query["FaultType"] = request.FaultType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCallUserInfo))
            {
                query["QueryCallUserInfo"] = request.QueryCallUserInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFaultDiagnosisUserDetail",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisUserDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取异常诊断用户详情
         *
         * @param request DescribeFaultDiagnosisUserDetailRequest
         * @return DescribeFaultDiagnosisUserDetailResponse
         */
        public DescribeFaultDiagnosisUserDetailResponse DescribeFaultDiagnosisUserDetail(DescribeFaultDiagnosisUserDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFaultDiagnosisUserDetailWithOptions(request, runtime);
        }

        /**
         * @summary 获取异常诊断用户详情
         *
         * @param request DescribeFaultDiagnosisUserDetailRequest
         * @return DescribeFaultDiagnosisUserDetailResponse
         */
        public async Task<DescribeFaultDiagnosisUserDetailResponse> DescribeFaultDiagnosisUserDetailAsync(DescribeFaultDiagnosisUserDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFaultDiagnosisUserDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取异常诊断用户明细列表
         *
         * @param request DescribeFaultDiagnosisUserListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFaultDiagnosisUserListResponse
         */
        public DescribeFaultDiagnosisUserListResponse DescribeFaultDiagnosisUserListWithOptions(DescribeFaultDiagnosisUserListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultTypes))
            {
                query["FaultTypes"] = request.FaultTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFaultDiagnosisUserList",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisUserListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取异常诊断用户明细列表
         *
         * @param request DescribeFaultDiagnosisUserListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFaultDiagnosisUserListResponse
         */
        public async Task<DescribeFaultDiagnosisUserListResponse> DescribeFaultDiagnosisUserListWithOptionsAsync(DescribeFaultDiagnosisUserListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultTypes))
            {
                query["FaultTypes"] = request.FaultTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFaultDiagnosisUserList",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisUserListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取异常诊断用户明细列表
         *
         * @param request DescribeFaultDiagnosisUserListRequest
         * @return DescribeFaultDiagnosisUserListResponse
         */
        public DescribeFaultDiagnosisUserListResponse DescribeFaultDiagnosisUserList(DescribeFaultDiagnosisUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFaultDiagnosisUserListWithOptions(request, runtime);
        }

        /**
         * @summary 获取异常诊断用户明细列表
         *
         * @param request DescribeFaultDiagnosisUserListRequest
         * @return DescribeFaultDiagnosisUserListResponse
         */
        public async Task<DescribeFaultDiagnosisUserListResponse> DescribeFaultDiagnosisUserListAsync(DescribeFaultDiagnosisUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFaultDiagnosisUserListWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeMPULayoutInfoListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMPULayoutInfoListResponse
         */
        public DescribeMPULayoutInfoListResponse DescribeMPULayoutInfoListWithOptions(DescribeMPULayoutInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutId))
            {
                query["LayoutId"] = request.LayoutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMPULayoutInfoList",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMPULayoutInfoListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeMPULayoutInfoListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMPULayoutInfoListResponse
         */
        public async Task<DescribeMPULayoutInfoListResponse> DescribeMPULayoutInfoListWithOptionsAsync(DescribeMPULayoutInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutId))
            {
                query["LayoutId"] = request.LayoutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMPULayoutInfoList",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMPULayoutInfoListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeMPULayoutInfoListRequest
         * @return DescribeMPULayoutInfoListResponse
         */
        public DescribeMPULayoutInfoListResponse DescribeMPULayoutInfoList(DescribeMPULayoutInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMPULayoutInfoListWithOptions(request, runtime);
        }

        /**
         * @param request DescribeMPULayoutInfoListRequest
         * @return DescribeMPULayoutInfoListResponse
         */
        public async Task<DescribeMPULayoutInfoListResponse> DescribeMPULayoutInfoListAsync(DescribeMPULayoutInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMPULayoutInfoListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 调用DescribePubUserListBySubUser根据订阅端获取通信中发布端用户列表。
         *
         * @param request DescribePubUserListBySubUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePubUserListBySubUserResponse
         */
        public DescribePubUserListBySubUserResponse DescribePubUserListBySubUserWithOptions(DescribePubUserListBySubUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePubUserListBySubUser",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePubUserListBySubUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用DescribePubUserListBySubUser根据订阅端获取通信中发布端用户列表。
         *
         * @param request DescribePubUserListBySubUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePubUserListBySubUserResponse
         */
        public async Task<DescribePubUserListBySubUserResponse> DescribePubUserListBySubUserWithOptionsAsync(DescribePubUserListBySubUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePubUserListBySubUser",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePubUserListBySubUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用DescribePubUserListBySubUser根据订阅端获取通信中发布端用户列表。
         *
         * @param request DescribePubUserListBySubUserRequest
         * @return DescribePubUserListBySubUserResponse
         */
        public DescribePubUserListBySubUserResponse DescribePubUserListBySubUser(DescribePubUserListBySubUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePubUserListBySubUserWithOptions(request, runtime);
        }

        /**
         * @summary 调用DescribePubUserListBySubUser根据订阅端获取通信中发布端用户列表。
         *
         * @param request DescribePubUserListBySubUserRequest
         * @return DescribePubUserListBySubUserResponse
         */
        public async Task<DescribePubUserListBySubUserResponse> DescribePubUserListBySubUserAsync(DescribePubUserListBySubUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePubUserListBySubUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 调用DescribeQoeMetricData获取单次通信中用户的下行体验质量指标。
         *
         * @param request DescribeQoeMetricDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeQoeMetricDataResponse
         */
        public DescribeQoeMetricDataResponse DescribeQoeMetricDataWithOptions(DescribeQoeMetricDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQoeMetricData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQoeMetricDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用DescribeQoeMetricData获取单次通信中用户的下行体验质量指标。
         *
         * @param request DescribeQoeMetricDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeQoeMetricDataResponse
         */
        public async Task<DescribeQoeMetricDataResponse> DescribeQoeMetricDataWithOptionsAsync(DescribeQoeMetricDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQoeMetricData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQoeMetricDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用DescribeQoeMetricData获取单次通信中用户的下行体验质量指标。
         *
         * @param request DescribeQoeMetricDataRequest
         * @return DescribeQoeMetricDataResponse
         */
        public DescribeQoeMetricDataResponse DescribeQoeMetricData(DescribeQoeMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeQoeMetricDataWithOptions(request, runtime);
        }

        /**
         * @summary 调用DescribeQoeMetricData获取单次通信中用户的下行体验质量指标。
         *
         * @param request DescribeQoeMetricDataRequest
         * @return DescribeQoeMetricDataResponse
         */
        public async Task<DescribeQoeMetricDataResponse> DescribeQoeMetricDataAsync(DescribeQoeMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeQoeMetricDataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取质量统计区域分布统计数据
         *
         * @param request DescribeQualityAreaDistributionStatDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeQualityAreaDistributionStatDataResponse
         */
        public DescribeQualityAreaDistributionStatDataResponse DescribeQualityAreaDistributionStatDataWithOptions(DescribeQualityAreaDistributionStatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentArea))
            {
                query["ParentArea"] = request.ParentArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQualityAreaDistributionStatData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQualityAreaDistributionStatDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取质量统计区域分布统计数据
         *
         * @param request DescribeQualityAreaDistributionStatDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeQualityAreaDistributionStatDataResponse
         */
        public async Task<DescribeQualityAreaDistributionStatDataResponse> DescribeQualityAreaDistributionStatDataWithOptionsAsync(DescribeQualityAreaDistributionStatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentArea))
            {
                query["ParentArea"] = request.ParentArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQualityAreaDistributionStatData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQualityAreaDistributionStatDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取质量统计区域分布统计数据
         *
         * @param request DescribeQualityAreaDistributionStatDataRequest
         * @return DescribeQualityAreaDistributionStatDataResponse
         */
        public DescribeQualityAreaDistributionStatDataResponse DescribeQualityAreaDistributionStatData(DescribeQualityAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeQualityAreaDistributionStatDataWithOptions(request, runtime);
        }

        /**
         * @summary 获取质量统计区域分布统计数据
         *
         * @param request DescribeQualityAreaDistributionStatDataRequest
         * @return DescribeQualityAreaDistributionStatDataResponse
         */
        public async Task<DescribeQualityAreaDistributionStatDataResponse> DescribeQualityAreaDistributionStatDataAsync(DescribeQualityAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeQualityAreaDistributionStatDataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取质量统计分布数据
         *
         * @param request DescribeQualityDistributionStatDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeQualityDistributionStatDataResponse
         */
        public DescribeQualityDistributionStatDataResponse DescribeQualityDistributionStatDataWithOptions(DescribeQualityDistributionStatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQualityDistributionStatData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQualityDistributionStatDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取质量统计分布数据
         *
         * @param request DescribeQualityDistributionStatDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeQualityDistributionStatDataResponse
         */
        public async Task<DescribeQualityDistributionStatDataResponse> DescribeQualityDistributionStatDataWithOptionsAsync(DescribeQualityDistributionStatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQualityDistributionStatData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQualityDistributionStatDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取质量统计分布数据
         *
         * @param request DescribeQualityDistributionStatDataRequest
         * @return DescribeQualityDistributionStatDataResponse
         */
        public DescribeQualityDistributionStatDataResponse DescribeQualityDistributionStatData(DescribeQualityDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeQualityDistributionStatDataWithOptions(request, runtime);
        }

        /**
         * @summary 获取质量统计分布数据
         *
         * @param request DescribeQualityDistributionStatDataRequest
         * @return DescribeQualityDistributionStatDataResponse
         */
        public async Task<DescribeQualityDistributionStatDataResponse> DescribeQualityDistributionStatDataAsync(DescribeQualityDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeQualityDistributionStatDataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取质量统计各操作系统下SDK版本分布数据
         *
         * @param request DescribeQualityOsSdkVersionDistributionStatDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeQualityOsSdkVersionDistributionStatDataResponse
         */
        public DescribeQualityOsSdkVersionDistributionStatDataResponse DescribeQualityOsSdkVersionDistributionStatDataWithOptions(DescribeQualityOsSdkVersionDistributionStatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQualityOsSdkVersionDistributionStatData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQualityOsSdkVersionDistributionStatDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取质量统计各操作系统下SDK版本分布数据
         *
         * @param request DescribeQualityOsSdkVersionDistributionStatDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeQualityOsSdkVersionDistributionStatDataResponse
         */
        public async Task<DescribeQualityOsSdkVersionDistributionStatDataResponse> DescribeQualityOsSdkVersionDistributionStatDataWithOptionsAsync(DescribeQualityOsSdkVersionDistributionStatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQualityOsSdkVersionDistributionStatData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQualityOsSdkVersionDistributionStatDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取质量统计各操作系统下SDK版本分布数据
         *
         * @param request DescribeQualityOsSdkVersionDistributionStatDataRequest
         * @return DescribeQualityOsSdkVersionDistributionStatDataResponse
         */
        public DescribeQualityOsSdkVersionDistributionStatDataResponse DescribeQualityOsSdkVersionDistributionStatData(DescribeQualityOsSdkVersionDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeQualityOsSdkVersionDistributionStatDataWithOptions(request, runtime);
        }

        /**
         * @summary 获取质量统计各操作系统下SDK版本分布数据
         *
         * @param request DescribeQualityOsSdkVersionDistributionStatDataRequest
         * @return DescribeQualityOsSdkVersionDistributionStatDataResponse
         */
        public async Task<DescribeQualityOsSdkVersionDistributionStatDataResponse> DescribeQualityOsSdkVersionDistributionStatDataAsync(DescribeQualityOsSdkVersionDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeQualityOsSdkVersionDistributionStatDataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取质量统计概览数据
         *
         * @param request DescribeQualityOverallDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeQualityOverallDataResponse
         */
        public DescribeQualityOverallDataResponse DescribeQualityOverallDataWithOptions(DescribeQualityOverallDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["Types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQualityOverallData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQualityOverallDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取质量统计概览数据
         *
         * @param request DescribeQualityOverallDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeQualityOverallDataResponse
         */
        public async Task<DescribeQualityOverallDataResponse> DescribeQualityOverallDataWithOptionsAsync(DescribeQualityOverallDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["Types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQualityOverallData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQualityOverallDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取质量统计概览数据
         *
         * @param request DescribeQualityOverallDataRequest
         * @return DescribeQualityOverallDataResponse
         */
        public DescribeQualityOverallDataResponse DescribeQualityOverallData(DescribeQualityOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeQualityOverallDataWithOptions(request, runtime);
        }

        /**
         * @summary 获取质量统计概览数据
         *
         * @param request DescribeQualityOverallDataRequest
         * @return DescribeQualityOverallDataResponse
         */
        public async Task<DescribeQualityOverallDataResponse> DescribeQualityOverallDataAsync(DescribeQualityOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeQualityOverallDataWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeRecordFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRecordFilesResponse
         */
        public DescribeRecordFilesResponse DescribeRecordFilesWithOptions(DescribeRecordFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                query["TaskIds"] = request.TaskIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecordFiles",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecordFilesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeRecordFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRecordFilesResponse
         */
        public async Task<DescribeRecordFilesResponse> DescribeRecordFilesWithOptionsAsync(DescribeRecordFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                query["TaskIds"] = request.TaskIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecordFiles",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecordFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeRecordFilesRequest
         * @return DescribeRecordFilesResponse
         */
        public DescribeRecordFilesResponse DescribeRecordFiles(DescribeRecordFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordFilesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeRecordFilesRequest
         * @return DescribeRecordFilesResponse
         */
        public async Task<DescribeRecordFilesResponse> DescribeRecordFilesAsync(DescribeRecordFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordFilesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeRecordTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRecordTemplatesResponse
         */
        public DescribeRecordTemplatesResponse DescribeRecordTemplatesWithOptions(DescribeRecordTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                query["TemplateIds"] = request.TemplateIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecordTemplates",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecordTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeRecordTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRecordTemplatesResponse
         */
        public async Task<DescribeRecordTemplatesResponse> DescribeRecordTemplatesWithOptionsAsync(DescribeRecordTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                query["TemplateIds"] = request.TemplateIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecordTemplates",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecordTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeRecordTemplatesRequest
         * @return DescribeRecordTemplatesResponse
         */
        public DescribeRecordTemplatesResponse DescribeRecordTemplates(DescribeRecordTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordTemplatesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeRecordTemplatesRequest
         * @return DescribeRecordTemplatesResponse
         */
        public async Task<DescribeRecordTemplatesResponse> DescribeRecordTemplatesAsync(DescribeRecordTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordTemplatesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeRtcChannelListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRtcChannelListResponse
         */
        public DescribeRtcChannelListResponse DescribeRtcChannelListWithOptions(DescribeRtcChannelListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePoint))
            {
                query["TimePoint"] = request.TimePoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRtcChannelList",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcChannelListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeRtcChannelListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRtcChannelListResponse
         */
        public async Task<DescribeRtcChannelListResponse> DescribeRtcChannelListWithOptionsAsync(DescribeRtcChannelListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePoint))
            {
                query["TimePoint"] = request.TimePoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRtcChannelList",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcChannelListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeRtcChannelListRequest
         * @return DescribeRtcChannelListResponse
         */
        public DescribeRtcChannelListResponse DescribeRtcChannelList(DescribeRtcChannelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcChannelListWithOptions(request, runtime);
        }

        /**
         * @param request DescribeRtcChannelListRequest
         * @return DescribeRtcChannelListResponse
         */
        public async Task<DescribeRtcChannelListResponse> DescribeRtcChannelListAsync(DescribeRtcChannelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcChannelListWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeRtcChannelMetricRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRtcChannelMetricResponse
         */
        public DescribeRtcChannelMetricResponse DescribeRtcChannelMetricWithOptions(DescribeRtcChannelMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePoint))
            {
                query["TimePoint"] = request.TimePoint;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRtcChannelMetric",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcChannelMetricResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeRtcChannelMetricRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRtcChannelMetricResponse
         */
        public async Task<DescribeRtcChannelMetricResponse> DescribeRtcChannelMetricWithOptionsAsync(DescribeRtcChannelMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePoint))
            {
                query["TimePoint"] = request.TimePoint;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRtcChannelMetric",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcChannelMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeRtcChannelMetricRequest
         * @return DescribeRtcChannelMetricResponse
         */
        public DescribeRtcChannelMetricResponse DescribeRtcChannelMetric(DescribeRtcChannelMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcChannelMetricWithOptions(request, runtime);
        }

        /**
         * @param request DescribeRtcChannelMetricRequest
         * @return DescribeRtcChannelMetricResponse
         */
        public async Task<DescribeRtcChannelMetricResponse> DescribeRtcChannelMetricAsync(DescribeRtcChannelMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcChannelMetricWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeRtcDurationDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRtcDurationDataResponse
         */
        public DescribeRtcDurationDataResponse DescribeRtcDurationDataWithOptions(DescribeRtcDurationDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
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
                Action = "DescribeRtcDurationData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcDurationDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeRtcDurationDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRtcDurationDataResponse
         */
        public async Task<DescribeRtcDurationDataResponse> DescribeRtcDurationDataWithOptionsAsync(DescribeRtcDurationDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
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
                Action = "DescribeRtcDurationData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcDurationDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeRtcDurationDataRequest
         * @return DescribeRtcDurationDataResponse
         */
        public DescribeRtcDurationDataResponse DescribeRtcDurationData(DescribeRtcDurationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcDurationDataWithOptions(request, runtime);
        }

        /**
         * @param request DescribeRtcDurationDataRequest
         * @return DescribeRtcDurationDataResponse
         */
        public async Task<DescribeRtcDurationDataResponse> DescribeRtcDurationDataAsync(DescribeRtcDurationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcDurationDataWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeRtcPeakChannelCntDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRtcPeakChannelCntDataResponse
         */
        public DescribeRtcPeakChannelCntDataResponse DescribeRtcPeakChannelCntDataWithOptions(DescribeRtcPeakChannelCntDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
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
                Action = "DescribeRtcPeakChannelCntData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcPeakChannelCntDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeRtcPeakChannelCntDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRtcPeakChannelCntDataResponse
         */
        public async Task<DescribeRtcPeakChannelCntDataResponse> DescribeRtcPeakChannelCntDataWithOptionsAsync(DescribeRtcPeakChannelCntDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
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
                Action = "DescribeRtcPeakChannelCntData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcPeakChannelCntDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeRtcPeakChannelCntDataRequest
         * @return DescribeRtcPeakChannelCntDataResponse
         */
        public DescribeRtcPeakChannelCntDataResponse DescribeRtcPeakChannelCntData(DescribeRtcPeakChannelCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcPeakChannelCntDataWithOptions(request, runtime);
        }

        /**
         * @param request DescribeRtcPeakChannelCntDataRequest
         * @return DescribeRtcPeakChannelCntDataResponse
         */
        public async Task<DescribeRtcPeakChannelCntDataResponse> DescribeRtcPeakChannelCntDataAsync(DescribeRtcPeakChannelCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcPeakChannelCntDataWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeRtcUserCntDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRtcUserCntDataResponse
         */
        public DescribeRtcUserCntDataResponse DescribeRtcUserCntDataWithOptions(DescribeRtcUserCntDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
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
                Action = "DescribeRtcUserCntData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcUserCntDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeRtcUserCntDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRtcUserCntDataResponse
         */
        public async Task<DescribeRtcUserCntDataResponse> DescribeRtcUserCntDataWithOptionsAsync(DescribeRtcUserCntDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
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
                Action = "DescribeRtcUserCntData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcUserCntDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeRtcUserCntDataRequest
         * @return DescribeRtcUserCntDataResponse
         */
        public DescribeRtcUserCntDataResponse DescribeRtcUserCntData(DescribeRtcUserCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcUserCntDataWithOptions(request, runtime);
        }

        /**
         * @param request DescribeRtcUserCntDataRequest
         * @return DescribeRtcUserCntDataResponse
         */
        public async Task<DescribeRtcUserCntDataResponse> DescribeRtcUserCntDataAsync(DescribeRtcUserCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcUserCntDataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询旁路推流状态
         *
         * @param request DescribeStreamingOutStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeStreamingOutStatusResponse
         */
        public DescribeStreamingOutStatusResponse DescribeStreamingOutStatusWithOptions(DescribeStreamingOutStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
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
                Action = "DescribeStreamingOutStatus",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStreamingOutStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询旁路推流状态
         *
         * @param request DescribeStreamingOutStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeStreamingOutStatusResponse
         */
        public async Task<DescribeStreamingOutStatusResponse> DescribeStreamingOutStatusWithOptionsAsync(DescribeStreamingOutStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
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
                Action = "DescribeStreamingOutStatus",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStreamingOutStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询旁路推流状态
         *
         * @param request DescribeStreamingOutStatusRequest
         * @return DescribeStreamingOutStatusResponse
         */
        public DescribeStreamingOutStatusResponse DescribeStreamingOutStatus(DescribeStreamingOutStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStreamingOutStatusWithOptions(request, runtime);
        }

        /**
         * @summary 查询旁路推流状态
         *
         * @param request DescribeStreamingOutStatusRequest
         * @return DescribeStreamingOutStatusResponse
         */
        public async Task<DescribeStreamingOutStatusResponse> DescribeStreamingOutStatusAsync(DescribeStreamingOutStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStreamingOutStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 系统内置布局
         *
         * @param request DescribeSystemLayoutListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSystemLayoutListResponse
         */
        public DescribeSystemLayoutListResponse DescribeSystemLayoutListWithOptions(DescribeSystemLayoutListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSystemLayoutList",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSystemLayoutListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 系统内置布局
         *
         * @param request DescribeSystemLayoutListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSystemLayoutListResponse
         */
        public async Task<DescribeSystemLayoutListResponse> DescribeSystemLayoutListWithOptionsAsync(DescribeSystemLayoutListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSystemLayoutList",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSystemLayoutListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 系统内置布局
         *
         * @param request DescribeSystemLayoutListRequest
         * @return DescribeSystemLayoutListResponse
         */
        public DescribeSystemLayoutListResponse DescribeSystemLayoutList(DescribeSystemLayoutListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSystemLayoutListWithOptions(request, runtime);
        }

        /**
         * @summary 系统内置布局
         *
         * @param request DescribeSystemLayoutListRequest
         * @return DescribeSystemLayoutListResponse
         */
        public async Task<DescribeSystemLayoutListResponse> DescribeSystemLayoutListAsync(DescribeSystemLayoutListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSystemLayoutListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取用量统计地域分布数据
         *
         * @param request DescribeUsageAreaDistributionStatDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUsageAreaDistributionStatDataResponse
         */
        public DescribeUsageAreaDistributionStatDataResponse DescribeUsageAreaDistributionStatDataWithOptions(DescribeUsageAreaDistributionStatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentArea))
            {
                query["ParentArea"] = request.ParentArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsageAreaDistributionStatData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsageAreaDistributionStatDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取用量统计地域分布数据
         *
         * @param request DescribeUsageAreaDistributionStatDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUsageAreaDistributionStatDataResponse
         */
        public async Task<DescribeUsageAreaDistributionStatDataResponse> DescribeUsageAreaDistributionStatDataWithOptionsAsync(DescribeUsageAreaDistributionStatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentArea))
            {
                query["ParentArea"] = request.ParentArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsageAreaDistributionStatData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsageAreaDistributionStatDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用量统计地域分布数据
         *
         * @param request DescribeUsageAreaDistributionStatDataRequest
         * @return DescribeUsageAreaDistributionStatDataResponse
         */
        public DescribeUsageAreaDistributionStatDataResponse DescribeUsageAreaDistributionStatData(DescribeUsageAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUsageAreaDistributionStatDataWithOptions(request, runtime);
        }

        /**
         * @summary 获取用量统计地域分布数据
         *
         * @param request DescribeUsageAreaDistributionStatDataRequest
         * @return DescribeUsageAreaDistributionStatDataResponse
         */
        public async Task<DescribeUsageAreaDistributionStatDataResponse> DescribeUsageAreaDistributionStatDataAsync(DescribeUsageAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUsageAreaDistributionStatDataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取用量统计分布数据
         *
         * @param request DescribeUsageDistributionStatDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUsageDistributionStatDataResponse
         */
        public DescribeUsageDistributionStatDataResponse DescribeUsageDistributionStatDataWithOptions(DescribeUsageDistributionStatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsageDistributionStatData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsageDistributionStatDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取用量统计分布数据
         *
         * @param request DescribeUsageDistributionStatDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUsageDistributionStatDataResponse
         */
        public async Task<DescribeUsageDistributionStatDataResponse> DescribeUsageDistributionStatDataWithOptionsAsync(DescribeUsageDistributionStatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsageDistributionStatData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsageDistributionStatDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用量统计分布数据
         *
         * @param request DescribeUsageDistributionStatDataRequest
         * @return DescribeUsageDistributionStatDataResponse
         */
        public DescribeUsageDistributionStatDataResponse DescribeUsageDistributionStatData(DescribeUsageDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUsageDistributionStatDataWithOptions(request, runtime);
        }

        /**
         * @summary 获取用量统计分布数据
         *
         * @param request DescribeUsageDistributionStatDataRequest
         * @return DescribeUsageDistributionStatDataResponse
         */
        public async Task<DescribeUsageDistributionStatDataResponse> DescribeUsageDistributionStatDataAsync(DescribeUsageDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUsageDistributionStatDataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取用量统计各操作系统下SDK版本分布数据
         *
         * @param request DescribeUsageOsSdkVersionDistributionStatDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUsageOsSdkVersionDistributionStatDataResponse
         */
        public DescribeUsageOsSdkVersionDistributionStatDataResponse DescribeUsageOsSdkVersionDistributionStatDataWithOptions(DescribeUsageOsSdkVersionDistributionStatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsageOsSdkVersionDistributionStatData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsageOsSdkVersionDistributionStatDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取用量统计各操作系统下SDK版本分布数据
         *
         * @param request DescribeUsageOsSdkVersionDistributionStatDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUsageOsSdkVersionDistributionStatDataResponse
         */
        public async Task<DescribeUsageOsSdkVersionDistributionStatDataResponse> DescribeUsageOsSdkVersionDistributionStatDataWithOptionsAsync(DescribeUsageOsSdkVersionDistributionStatDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsageOsSdkVersionDistributionStatData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsageOsSdkVersionDistributionStatDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用量统计各操作系统下SDK版本分布数据
         *
         * @param request DescribeUsageOsSdkVersionDistributionStatDataRequest
         * @return DescribeUsageOsSdkVersionDistributionStatDataResponse
         */
        public DescribeUsageOsSdkVersionDistributionStatDataResponse DescribeUsageOsSdkVersionDistributionStatData(DescribeUsageOsSdkVersionDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUsageOsSdkVersionDistributionStatDataWithOptions(request, runtime);
        }

        /**
         * @summary 获取用量统计各操作系统下SDK版本分布数据
         *
         * @param request DescribeUsageOsSdkVersionDistributionStatDataRequest
         * @return DescribeUsageOsSdkVersionDistributionStatDataResponse
         */
        public async Task<DescribeUsageOsSdkVersionDistributionStatDataResponse> DescribeUsageOsSdkVersionDistributionStatDataAsync(DescribeUsageOsSdkVersionDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUsageOsSdkVersionDistributionStatDataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取用量统计概览数据
         *
         * @param request DescribeUsageOverallDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUsageOverallDataResponse
         */
        public DescribeUsageOverallDataResponse DescribeUsageOverallDataWithOptions(DescribeUsageOverallDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["Types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsageOverallData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsageOverallDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取用量统计概览数据
         *
         * @param request DescribeUsageOverallDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUsageOverallDataResponse
         */
        public async Task<DescribeUsageOverallDataResponse> DescribeUsageOverallDataWithOptionsAsync(DescribeUsageOverallDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["Types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsageOverallData",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsageOverallDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用量统计概览数据
         *
         * @param request DescribeUsageOverallDataRequest
         * @return DescribeUsageOverallDataResponse
         */
        public DescribeUsageOverallDataResponse DescribeUsageOverallData(DescribeUsageOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUsageOverallDataWithOptions(request, runtime);
        }

        /**
         * @summary 获取用量统计概览数据
         *
         * @param request DescribeUsageOverallDataRequest
         * @return DescribeUsageOverallDataResponse
         */
        public async Task<DescribeUsageOverallDataResponse> DescribeUsageOverallDataAsync(DescribeUsageOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUsageOverallDataWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeUserInfoInChannelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserInfoInChannelResponse
         */
        public DescribeUserInfoInChannelResponse DescribeUserInfoInChannelWithOptions(DescribeUserInfoInChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserInfoInChannel",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserInfoInChannelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeUserInfoInChannelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserInfoInChannelResponse
         */
        public async Task<DescribeUserInfoInChannelResponse> DescribeUserInfoInChannelWithOptionsAsync(DescribeUserInfoInChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserInfoInChannel",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserInfoInChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeUserInfoInChannelRequest
         * @return DescribeUserInfoInChannelResponse
         */
        public DescribeUserInfoInChannelResponse DescribeUserInfoInChannel(DescribeUserInfoInChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserInfoInChannelWithOptions(request, runtime);
        }

        /**
         * @param request DescribeUserInfoInChannelRequest
         * @return DescribeUserInfoInChannelResponse
         */
        public async Task<DescribeUserInfoInChannelResponse> DescribeUserInfoInChannelAsync(DescribeUserInfoInChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserInfoInChannelWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DisableAutoLiveStreamRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableAutoLiveStreamRuleResponse
         */
        public DisableAutoLiveStreamRuleResponse DisableAutoLiveStreamRuleWithOptions(DisableAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableAutoLiveStreamRule",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableAutoLiveStreamRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DisableAutoLiveStreamRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableAutoLiveStreamRuleResponse
         */
        public async Task<DisableAutoLiveStreamRuleResponse> DisableAutoLiveStreamRuleWithOptionsAsync(DisableAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableAutoLiveStreamRule",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableAutoLiveStreamRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DisableAutoLiveStreamRuleRequest
         * @return DisableAutoLiveStreamRuleResponse
         */
        public DisableAutoLiveStreamRuleResponse DisableAutoLiveStreamRule(DisableAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableAutoLiveStreamRuleWithOptions(request, runtime);
        }

        /**
         * @param request DisableAutoLiveStreamRuleRequest
         * @return DisableAutoLiveStreamRuleResponse
         */
        public async Task<DisableAutoLiveStreamRuleResponse> DisableAutoLiveStreamRuleAsync(DisableAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @param request EnableAutoLiveStreamRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableAutoLiveStreamRuleResponse
         */
        public EnableAutoLiveStreamRuleResponse EnableAutoLiveStreamRuleWithOptions(EnableAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableAutoLiveStreamRule",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableAutoLiveStreamRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request EnableAutoLiveStreamRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableAutoLiveStreamRuleResponse
         */
        public async Task<EnableAutoLiveStreamRuleResponse> EnableAutoLiveStreamRuleWithOptionsAsync(EnableAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableAutoLiveStreamRule",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableAutoLiveStreamRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request EnableAutoLiveStreamRuleRequest
         * @return EnableAutoLiveStreamRuleResponse
         */
        public EnableAutoLiveStreamRuleResponse EnableAutoLiveStreamRule(EnableAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableAutoLiveStreamRuleWithOptions(request, runtime);
        }

        /**
         * @param request EnableAutoLiveStreamRuleRequest
         * @return EnableAutoLiveStreamRuleResponse
         */
        public async Task<EnableAutoLiveStreamRuleResponse> EnableAutoLiveStreamRuleAsync(EnableAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetMPUTaskStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMPUTaskStatusResponse
         */
        public GetMPUTaskStatusResponse GetMPUTaskStatusWithOptions(GetMPUTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "GetMPUTaskStatus",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMPUTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetMPUTaskStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMPUTaskStatusResponse
         */
        public async Task<GetMPUTaskStatusResponse> GetMPUTaskStatusWithOptionsAsync(GetMPUTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "GetMPUTaskStatus",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMPUTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetMPUTaskStatusRequest
         * @return GetMPUTaskStatusResponse
         */
        public GetMPUTaskStatusResponse GetMPUTaskStatus(GetMPUTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMPUTaskStatusWithOptions(request, runtime);
        }

        /**
         * @param request GetMPUTaskStatusRequest
         * @return GetMPUTaskStatusResponse
         */
        public async Task<GetMPUTaskStatusResponse> GetMPUTaskStatusAsync(GetMPUTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMPUTaskStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改App信息
         *
         * @param request ModifyAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppResponse
         */
        public ModifyAppResponse ModifyAppWithOptions(ModifyAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyApp",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改App信息
         *
         * @param request ModifyAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppResponse
         */
        public async Task<ModifyAppResponse> ModifyAppWithOptionsAsync(ModifyAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyApp",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改App信息
         *
         * @param request ModifyAppRequest
         * @return ModifyAppResponse
         */
        public ModifyAppResponse ModifyApp(ModifyAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppWithOptions(request, runtime);
        }

        /**
         * @summary 修改App信息
         *
         * @param request ModifyAppRequest
         * @return ModifyAppResponse
         */
        public async Task<ModifyAppResponse> ModifyAppAsync(ModifyAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新app回调事件开关
         *
         * @param request ModifyAppCallbackStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppCallbackStatusResponse
         */
        public ModifyAppCallbackStatusResponse ModifyAppCallbackStatusWithOptions(ModifyAppCallbackStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppCallbackStatus",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppCallbackStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新app回调事件开关
         *
         * @param request ModifyAppCallbackStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppCallbackStatusResponse
         */
        public async Task<ModifyAppCallbackStatusResponse> ModifyAppCallbackStatusWithOptionsAsync(ModifyAppCallbackStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppCallbackStatus",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppCallbackStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新app回调事件开关
         *
         * @param request ModifyAppCallbackStatusRequest
         * @return ModifyAppCallbackStatusResponse
         */
        public ModifyAppCallbackStatusResponse ModifyAppCallbackStatus(ModifyAppCallbackStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppCallbackStatusWithOptions(request, runtime);
        }

        /**
         * @summary 更新app回调事件开关
         *
         * @param request ModifyAppCallbackStatusRequest
         * @return ModifyAppCallbackStatusResponse
         */
        public async Task<ModifyAppCallbackStatusResponse> ModifyAppCallbackStatusAsync(ModifyAppCallbackStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppCallbackStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改应用旁路开关
         *
         * @param request ModifyAppLiveStreamStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppLiveStreamStatusResponse
         */
        public ModifyAppLiveStreamStatusResponse ModifyAppLiveStreamStatusWithOptions(ModifyAppLiveStreamStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppLiveStreamStatus",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppLiveStreamStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改应用旁路开关
         *
         * @param request ModifyAppLiveStreamStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppLiveStreamStatusResponse
         */
        public async Task<ModifyAppLiveStreamStatusResponse> ModifyAppLiveStreamStatusWithOptionsAsync(ModifyAppLiveStreamStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppLiveStreamStatus",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppLiveStreamStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改应用旁路开关
         *
         * @param request ModifyAppLiveStreamStatusRequest
         * @return ModifyAppLiveStreamStatusResponse
         */
        public ModifyAppLiveStreamStatusResponse ModifyAppLiveStreamStatus(ModifyAppLiveStreamStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppLiveStreamStatusWithOptions(request, runtime);
        }

        /**
         * @summary 修改应用旁路开关
         *
         * @param request ModifyAppLiveStreamStatusRequest
         * @return ModifyAppLiveStreamStatusResponse
         */
        public async Task<ModifyAppLiveStreamStatusResponse> ModifyAppLiveStreamStatusAsync(ModifyAppLiveStreamStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppLiveStreamStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改应用录制开关
         *
         * @param request ModifyAppRecordStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppRecordStatusResponse
         */
        public ModifyAppRecordStatusResponse ModifyAppRecordStatusWithOptions(ModifyAppRecordStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppRecordStatus",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppRecordStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改应用录制开关
         *
         * @param request ModifyAppRecordStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppRecordStatusResponse
         */
        public async Task<ModifyAppRecordStatusResponse> ModifyAppRecordStatusWithOptionsAsync(ModifyAppRecordStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppRecordStatus",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppRecordStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改应用录制开关
         *
         * @param request ModifyAppRecordStatusRequest
         * @return ModifyAppRecordStatusResponse
         */
        public ModifyAppRecordStatusResponse ModifyAppRecordStatus(ModifyAppRecordStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppRecordStatusWithOptions(request, runtime);
        }

        /**
         * @summary 修改应用录制开关
         *
         * @param request ModifyAppRecordStatusRequest
         * @return ModifyAppRecordStatusResponse
         */
        public async Task<ModifyAppRecordStatusResponse> ModifyAppRecordStatusAsync(ModifyAppRecordStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppRecordStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改应用录制模版
         *
         * @param tmpReq ModifyAppRecordTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppRecordTemplateResponse
         */
        public ModifyAppRecordTemplateResponse ModifyAppRecordTemplateWithOptions(ModifyAppRecordTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAppRecordTemplateShrinkRequest request = new ModifyAppRecordTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RecordTemplate))
            {
                request.RecordTemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RecordTemplate, "RecordTemplate", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordTemplateShrink))
            {
                query["RecordTemplate"] = request.RecordTemplateShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppRecordTemplate",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppRecordTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改应用录制模版
         *
         * @param tmpReq ModifyAppRecordTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppRecordTemplateResponse
         */
        public async Task<ModifyAppRecordTemplateResponse> ModifyAppRecordTemplateWithOptionsAsync(ModifyAppRecordTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAppRecordTemplateShrinkRequest request = new ModifyAppRecordTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RecordTemplate))
            {
                request.RecordTemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RecordTemplate, "RecordTemplate", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordTemplateShrink))
            {
                query["RecordTemplate"] = request.RecordTemplateShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppRecordTemplate",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppRecordTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改应用录制模版
         *
         * @param request ModifyAppRecordTemplateRequest
         * @return ModifyAppRecordTemplateResponse
         */
        public ModifyAppRecordTemplateResponse ModifyAppRecordTemplate(ModifyAppRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppRecordTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 修改应用录制模版
         *
         * @param request ModifyAppRecordTemplateRequest
         * @return ModifyAppRecordTemplateResponse
         */
        public async Task<ModifyAppRecordTemplateResponse> ModifyAppRecordTemplateAsync(ModifyAppRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppRecordTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新应用推流模版
         *
         * @param tmpReq ModifyAppStreamingOutTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppStreamingOutTemplateResponse
         */
        public ModifyAppStreamingOutTemplateResponse ModifyAppStreamingOutTemplateWithOptions(ModifyAppStreamingOutTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAppStreamingOutTemplateShrinkRequest request = new ModifyAppStreamingOutTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StreamingOutTemplate))
            {
                request.StreamingOutTemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StreamingOutTemplate, "StreamingOutTemplate", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamingOutTemplateShrink))
            {
                query["StreamingOutTemplate"] = request.StreamingOutTemplateShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppStreamingOutTemplate",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppStreamingOutTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新应用推流模版
         *
         * @param tmpReq ModifyAppStreamingOutTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppStreamingOutTemplateResponse
         */
        public async Task<ModifyAppStreamingOutTemplateResponse> ModifyAppStreamingOutTemplateWithOptionsAsync(ModifyAppStreamingOutTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAppStreamingOutTemplateShrinkRequest request = new ModifyAppStreamingOutTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StreamingOutTemplate))
            {
                request.StreamingOutTemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StreamingOutTemplate, "StreamingOutTemplate", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamingOutTemplateShrink))
            {
                query["StreamingOutTemplate"] = request.StreamingOutTemplateShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppStreamingOutTemplate",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppStreamingOutTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新应用推流模版
         *
         * @param request ModifyAppStreamingOutTemplateRequest
         * @return ModifyAppStreamingOutTemplateResponse
         */
        public ModifyAppStreamingOutTemplateResponse ModifyAppStreamingOutTemplate(ModifyAppStreamingOutTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppStreamingOutTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 更新应用推流模版
         *
         * @param request ModifyAppStreamingOutTemplateRequest
         * @return ModifyAppStreamingOutTemplateResponse
         */
        public async Task<ModifyAppStreamingOutTemplateResponse> ModifyAppStreamingOutTemplateAsync(ModifyAppStreamingOutTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppStreamingOutTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新app回调
         *
         * @param tmpReq ModifyCallbackMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyCallbackMetaResponse
         */
        public ModifyCallbackMetaResponse ModifyCallbackMetaWithOptions(ModifyCallbackMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyCallbackMetaShrinkRequest request = new ModifyCallbackMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Callback))
            {
                request.CallbackShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Callback, "Callback", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackShrink))
            {
                query["Callback"] = request.CallbackShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCallbackMeta",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCallbackMetaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新app回调
         *
         * @param tmpReq ModifyCallbackMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyCallbackMetaResponse
         */
        public async Task<ModifyCallbackMetaResponse> ModifyCallbackMetaWithOptionsAsync(ModifyCallbackMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyCallbackMetaShrinkRequest request = new ModifyCallbackMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Callback))
            {
                request.CallbackShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Callback, "Callback", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackShrink))
            {
                query["Callback"] = request.CallbackShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCallbackMeta",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCallbackMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新app回调
         *
         * @param request ModifyCallbackMetaRequest
         * @return ModifyCallbackMetaResponse
         */
        public ModifyCallbackMetaResponse ModifyCallbackMeta(ModifyCallbackMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCallbackMetaWithOptions(request, runtime);
        }

        /**
         * @summary 更新app回调
         *
         * @param request ModifyCallbackMetaRequest
         * @return ModifyCallbackMetaResponse
         */
        public async Task<ModifyCallbackMetaResponse> ModifyCallbackMetaAsync(ModifyCallbackMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCallbackMetaWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyMPULayoutRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyMPULayoutResponse
         */
        public ModifyMPULayoutResponse ModifyMPULayoutWithOptions(ModifyMPULayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioMixCount))
            {
                query["AudioMixCount"] = request.AudioMixCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutId))
            {
                query["LayoutId"] = request.LayoutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Panes))
            {
                query["Panes"] = request.Panes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMPULayout",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMPULayoutResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyMPULayoutRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyMPULayoutResponse
         */
        public async Task<ModifyMPULayoutResponse> ModifyMPULayoutWithOptionsAsync(ModifyMPULayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioMixCount))
            {
                query["AudioMixCount"] = request.AudioMixCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutId))
            {
                query["LayoutId"] = request.LayoutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Panes))
            {
                query["Panes"] = request.Panes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMPULayout",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMPULayoutResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyMPULayoutRequest
         * @return ModifyMPULayoutResponse
         */
        public ModifyMPULayoutResponse ModifyMPULayout(ModifyMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMPULayoutWithOptions(request, runtime);
        }

        /**
         * @param request ModifyMPULayoutRequest
         * @return ModifyMPULayoutResponse
         */
        public async Task<ModifyMPULayoutResponse> ModifyMPULayoutAsync(ModifyMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMPULayoutWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RemoveTerminalsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveTerminalsResponse
         */
        public RemoveTerminalsResponse RemoveTerminalsWithOptions(RemoveTerminalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalIds))
            {
                query["TerminalIds"] = request.TerminalIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveTerminals",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTerminalsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request RemoveTerminalsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveTerminalsResponse
         */
        public async Task<RemoveTerminalsResponse> RemoveTerminalsWithOptionsAsync(RemoveTerminalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalIds))
            {
                query["TerminalIds"] = request.TerminalIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveTerminals",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTerminalsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request RemoveTerminalsRequest
         * @return RemoveTerminalsResponse
         */
        public RemoveTerminalsResponse RemoveTerminals(RemoveTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTerminalsWithOptions(request, runtime);
        }

        /**
         * @param request RemoveTerminalsRequest
         * @return RemoveTerminalsResponse
         */
        public async Task<RemoveTerminalsResponse> RemoveTerminalsAsync(RemoveTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTerminalsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary RemoveUsers
         *
         * @param request RemoveUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveUsersResponse
         */
        public RemoveUsersResponse RemoveUsersWithOptions(RemoveUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                query["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveUsers",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary RemoveUsers
         *
         * @param request RemoveUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveUsersResponse
         */
        public async Task<RemoveUsersResponse> RemoveUsersWithOptionsAsync(RemoveUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                query["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveUsers",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary RemoveUsers
         *
         * @param request RemoveUsersRequest
         * @return RemoveUsersResponse
         */
        public RemoveUsersResponse RemoveUsers(RemoveUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveUsersWithOptions(request, runtime);
        }

        /**
         * @summary RemoveUsers
         *
         * @param request RemoveUsersRequest
         * @return RemoveUsersResponse
         */
        public async Task<RemoveUsersResponse> RemoveUsersAsync(RemoveUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 开启某个事件回调
         *
         * @param tmpReq StartCategoryCallbackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartCategoryCallbackResponse
         */
        public StartCategoryCallbackResponse StartCategoryCallbackWithOptions(StartCategoryCallbackRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StartCategoryCallbackShrinkRequest request = new StartCategoryCallbackShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Callback))
            {
                request.CallbackShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Callback, "Callback", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackShrink))
            {
                query["Callback"] = request.CallbackShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartCategoryCallback",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCategoryCallbackResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 开启某个事件回调
         *
         * @param tmpReq StartCategoryCallbackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartCategoryCallbackResponse
         */
        public async Task<StartCategoryCallbackResponse> StartCategoryCallbackWithOptionsAsync(StartCategoryCallbackRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StartCategoryCallbackShrinkRequest request = new StartCategoryCallbackShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Callback))
            {
                request.CallbackShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Callback, "Callback", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackShrink))
            {
                query["Callback"] = request.CallbackShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartCategoryCallback",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCategoryCallbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 开启某个事件回调
         *
         * @param request StartCategoryCallbackRequest
         * @return StartCategoryCallbackResponse
         */
        public StartCategoryCallbackResponse StartCategoryCallback(StartCategoryCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartCategoryCallbackWithOptions(request, runtime);
        }

        /**
         * @summary 开启某个事件回调
         *
         * @param request StartCategoryCallbackRequest
         * @return StartCategoryCallbackResponse
         */
        public async Task<StartCategoryCallbackResponse> StartCategoryCallbackAsync(StartCategoryCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartCategoryCallbackWithOptionsAsync(request, runtime);
        }

        /**
         * @summary StartCloudRecord
         *
         * @param request StartCloudRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartCloudRecordResponse
         */
        public StartCloudRecordResponse StartCloudRecordWithOptions(StartCloudRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClockWidgets))
            {
                query["ClockWidgets"] = request.ClockWidgets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CropMode))
            {
                query["CropMode"] = request.CropMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Images))
            {
                query["Images"] = request.Images;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Panes))
            {
                query["Panes"] = request.Panes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageConfig))
            {
                query["StorageConfig"] = request.StorageConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Texts))
            {
                query["Texts"] = request.Texts;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartCloudRecord",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCloudRecordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary StartCloudRecord
         *
         * @param request StartCloudRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartCloudRecordResponse
         */
        public async Task<StartCloudRecordResponse> StartCloudRecordWithOptionsAsync(StartCloudRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClockWidgets))
            {
                query["ClockWidgets"] = request.ClockWidgets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CropMode))
            {
                query["CropMode"] = request.CropMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Images))
            {
                query["Images"] = request.Images;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Panes))
            {
                query["Panes"] = request.Panes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageConfig))
            {
                query["StorageConfig"] = request.StorageConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Texts))
            {
                query["Texts"] = request.Texts;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartCloudRecord",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCloudRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary StartCloudRecord
         *
         * @param request StartCloudRecordRequest
         * @return StartCloudRecordResponse
         */
        public StartCloudRecordResponse StartCloudRecord(StartCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartCloudRecordWithOptions(request, runtime);
        }

        /**
         * @summary StartCloudRecord
         *
         * @param request StartCloudRecordRequest
         * @return StartCloudRecordResponse
         */
        public async Task<StartCloudRecordResponse> StartCloudRecordAsync(StartCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartCloudRecordWithOptionsAsync(request, runtime);
        }

        /**
         * @param request StartMPUTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartMPUTaskResponse
         */
        public StartMPUTaskResponse StartMPUTaskWithOptions(StartMPUTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundColor))
            {
                query["BackgroundColor"] = request.BackgroundColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Backgrounds))
            {
                query["Backgrounds"] = request.Backgrounds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClockWidgets))
            {
                query["ClockWidgets"] = request.ClockWidgets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CropMode))
            {
                query["CropMode"] = request.CropMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutIds))
            {
                query["LayoutIds"] = request.LayoutIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaEncode))
            {
                query["MediaEncode"] = request.MediaEncode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MixMode))
            {
                query["MixMode"] = request.MixMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadType))
            {
                query["PayloadType"] = request.PayloadType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportVad))
            {
                query["ReportVad"] = request.ReportVad;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RtpExtInfo))
            {
                query["RtpExtInfo"] = request.RtpExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamURL))
            {
                query["StreamURL"] = request.StreamURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecAudioUsers))
            {
                query["SubSpecAudioUsers"] = request.SubSpecAudioUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecCameraUsers))
            {
                query["SubSpecCameraUsers"] = request.SubSpecCameraUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecShareScreenUsers))
            {
                query["SubSpecShareScreenUsers"] = request.SubSpecShareScreenUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecUsers))
            {
                query["SubSpecUsers"] = request.SubSpecUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStampRef))
            {
                query["TimeStampRef"] = request.TimeStampRef;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecAudioUsers))
            {
                query["UnsubSpecAudioUsers"] = request.UnsubSpecAudioUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecCameraUsers))
            {
                query["UnsubSpecCameraUsers"] = request.UnsubSpecCameraUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecShareScreenUsers))
            {
                query["UnsubSpecShareScreenUsers"] = request.UnsubSpecShareScreenUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPanes))
            {
                query["UserPanes"] = request.UserPanes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VadInterval))
            {
                query["VadInterval"] = request.VadInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Watermarks))
            {
                query["Watermarks"] = request.Watermarks;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnhancedParam))
            {
                bodyFlat["EnhancedParam"] = request.EnhancedParam;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartMPUTask",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartMPUTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request StartMPUTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartMPUTaskResponse
         */
        public async Task<StartMPUTaskResponse> StartMPUTaskWithOptionsAsync(StartMPUTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundColor))
            {
                query["BackgroundColor"] = request.BackgroundColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Backgrounds))
            {
                query["Backgrounds"] = request.Backgrounds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClockWidgets))
            {
                query["ClockWidgets"] = request.ClockWidgets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CropMode))
            {
                query["CropMode"] = request.CropMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutIds))
            {
                query["LayoutIds"] = request.LayoutIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaEncode))
            {
                query["MediaEncode"] = request.MediaEncode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MixMode))
            {
                query["MixMode"] = request.MixMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadType))
            {
                query["PayloadType"] = request.PayloadType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportVad))
            {
                query["ReportVad"] = request.ReportVad;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RtpExtInfo))
            {
                query["RtpExtInfo"] = request.RtpExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamURL))
            {
                query["StreamURL"] = request.StreamURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecAudioUsers))
            {
                query["SubSpecAudioUsers"] = request.SubSpecAudioUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecCameraUsers))
            {
                query["SubSpecCameraUsers"] = request.SubSpecCameraUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecShareScreenUsers))
            {
                query["SubSpecShareScreenUsers"] = request.SubSpecShareScreenUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecUsers))
            {
                query["SubSpecUsers"] = request.SubSpecUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStampRef))
            {
                query["TimeStampRef"] = request.TimeStampRef;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecAudioUsers))
            {
                query["UnsubSpecAudioUsers"] = request.UnsubSpecAudioUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecCameraUsers))
            {
                query["UnsubSpecCameraUsers"] = request.UnsubSpecCameraUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecShareScreenUsers))
            {
                query["UnsubSpecShareScreenUsers"] = request.UnsubSpecShareScreenUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPanes))
            {
                query["UserPanes"] = request.UserPanes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VadInterval))
            {
                query["VadInterval"] = request.VadInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Watermarks))
            {
                query["Watermarks"] = request.Watermarks;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnhancedParam))
            {
                bodyFlat["EnhancedParam"] = request.EnhancedParam;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartMPUTask",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartMPUTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request StartMPUTaskRequest
         * @return StartMPUTaskResponse
         */
        public StartMPUTaskResponse StartMPUTask(StartMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartMPUTaskWithOptions(request, runtime);
        }

        /**
         * @param request StartMPUTaskRequest
         * @return StartMPUTaskResponse
         */
        public async Task<StartMPUTaskResponse> StartMPUTaskAsync(StartMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartMPUTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @param request StartRecordTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartRecordTaskResponse
         */
        public StartRecordTaskResponse StartRecordTaskWithOptions(StartRecordTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CropMode))
            {
                query["CropMode"] = request.CropMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutIds))
            {
                query["LayoutIds"] = request.LayoutIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaEncode))
            {
                query["MediaEncode"] = request.MediaEncode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MixMode))
            {
                query["MixMode"] = request.MixMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecAudioUsers))
            {
                query["SubSpecAudioUsers"] = request.SubSpecAudioUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecCameraUsers))
            {
                query["SubSpecCameraUsers"] = request.SubSpecCameraUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecShareScreenUsers))
            {
                query["SubSpecShareScreenUsers"] = request.SubSpecShareScreenUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecUsers))
            {
                query["SubSpecUsers"] = request.SubSpecUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskProfile))
            {
                query["TaskProfile"] = request.TaskProfile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecAudioUsers))
            {
                query["UnsubSpecAudioUsers"] = request.UnsubSpecAudioUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecCameraUsers))
            {
                query["UnsubSpecCameraUsers"] = request.UnsubSpecCameraUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecShareScreenUsers))
            {
                query["UnsubSpecShareScreenUsers"] = request.UnsubSpecShareScreenUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPanes))
            {
                query["UserPanes"] = request.UserPanes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartRecordTask",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartRecordTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request StartRecordTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartRecordTaskResponse
         */
        public async Task<StartRecordTaskResponse> StartRecordTaskWithOptionsAsync(StartRecordTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CropMode))
            {
                query["CropMode"] = request.CropMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutIds))
            {
                query["LayoutIds"] = request.LayoutIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaEncode))
            {
                query["MediaEncode"] = request.MediaEncode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MixMode))
            {
                query["MixMode"] = request.MixMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecAudioUsers))
            {
                query["SubSpecAudioUsers"] = request.SubSpecAudioUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecCameraUsers))
            {
                query["SubSpecCameraUsers"] = request.SubSpecCameraUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecShareScreenUsers))
            {
                query["SubSpecShareScreenUsers"] = request.SubSpecShareScreenUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecUsers))
            {
                query["SubSpecUsers"] = request.SubSpecUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskProfile))
            {
                query["TaskProfile"] = request.TaskProfile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecAudioUsers))
            {
                query["UnsubSpecAudioUsers"] = request.UnsubSpecAudioUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecCameraUsers))
            {
                query["UnsubSpecCameraUsers"] = request.UnsubSpecCameraUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecShareScreenUsers))
            {
                query["UnsubSpecShareScreenUsers"] = request.UnsubSpecShareScreenUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPanes))
            {
                query["UserPanes"] = request.UserPanes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartRecordTask",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartRecordTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request StartRecordTaskRequest
         * @return StartRecordTaskResponse
         */
        public StartRecordTaskResponse StartRecordTask(StartRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartRecordTaskWithOptions(request, runtime);
        }

        /**
         * @param request StartRecordTaskRequest
         * @return StartRecordTaskResponse
         */
        public async Task<StartRecordTaskResponse> StartRecordTaskAsync(StartRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartRecordTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary StartStreamingOut
         *
         * @param request StartStreamingOutRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartStreamingOutResponse
         */
        public StartStreamingOutResponse StartStreamingOutWithOptions(StartStreamingOutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClockWidgets))
            {
                query["ClockWidgets"] = request.ClockWidgets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CropMode))
            {
                query["CropMode"] = request.CropMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Images))
            {
                query["Images"] = request.Images;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Panes))
            {
                query["Panes"] = request.Panes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Texts))
            {
                query["Texts"] = request.Texts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartStreamingOut",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartStreamingOutResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary StartStreamingOut
         *
         * @param request StartStreamingOutRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartStreamingOutResponse
         */
        public async Task<StartStreamingOutResponse> StartStreamingOutWithOptionsAsync(StartStreamingOutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClockWidgets))
            {
                query["ClockWidgets"] = request.ClockWidgets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CropMode))
            {
                query["CropMode"] = request.CropMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Images))
            {
                query["Images"] = request.Images;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Panes))
            {
                query["Panes"] = request.Panes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Texts))
            {
                query["Texts"] = request.Texts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartStreamingOut",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartStreamingOutResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary StartStreamingOut
         *
         * @param request StartStreamingOutRequest
         * @return StartStreamingOutResponse
         */
        public StartStreamingOutResponse StartStreamingOut(StartStreamingOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartStreamingOutWithOptions(request, runtime);
        }

        /**
         * @summary StartStreamingOut
         *
         * @param request StartStreamingOutRequest
         * @return StartStreamingOutResponse
         */
        public async Task<StartStreamingOutResponse> StartStreamingOutAsync(StartStreamingOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartStreamingOutWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 关闭某个事件回调
         *
         * @param tmpReq StopCategoryCallbackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopCategoryCallbackResponse
         */
        public StopCategoryCallbackResponse StopCategoryCallbackWithOptions(StopCategoryCallbackRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StopCategoryCallbackShrinkRequest request = new StopCategoryCallbackShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Callback))
            {
                request.CallbackShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Callback, "Callback", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackShrink))
            {
                query["Callback"] = request.CallbackShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopCategoryCallback",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCategoryCallbackResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 关闭某个事件回调
         *
         * @param tmpReq StopCategoryCallbackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopCategoryCallbackResponse
         */
        public async Task<StopCategoryCallbackResponse> StopCategoryCallbackWithOptionsAsync(StopCategoryCallbackRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StopCategoryCallbackShrinkRequest request = new StopCategoryCallbackShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Callback))
            {
                request.CallbackShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Callback, "Callback", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackShrink))
            {
                query["Callback"] = request.CallbackShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopCategoryCallback",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCategoryCallbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 关闭某个事件回调
         *
         * @param request StopCategoryCallbackRequest
         * @return StopCategoryCallbackResponse
         */
        public StopCategoryCallbackResponse StopCategoryCallback(StopCategoryCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopCategoryCallbackWithOptions(request, runtime);
        }

        /**
         * @summary 关闭某个事件回调
         *
         * @param request StopCategoryCallbackRequest
         * @return StopCategoryCallbackResponse
         */
        public async Task<StopCategoryCallbackResponse> StopCategoryCallbackAsync(StopCategoryCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopCategoryCallbackWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除频道
         *
         * @param request StopChannelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopChannelResponse
         */
        public StopChannelResponse StopChannelWithOptions(StopChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopChannel",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopChannelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除频道
         *
         * @param request StopChannelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopChannelResponse
         */
        public async Task<StopChannelResponse> StopChannelWithOptionsAsync(StopChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopChannel",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除频道
         *
         * @param request StopChannelRequest
         * @return StopChannelResponse
         */
        public StopChannelResponse StopChannel(StopChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopChannelWithOptions(request, runtime);
        }

        /**
         * @summary 删除频道
         *
         * @param request StopChannelRequest
         * @return StopChannelResponse
         */
        public async Task<StopChannelResponse> StopChannelAsync(StopChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopChannelWithOptionsAsync(request, runtime);
        }

        /**
         * @summary StopCloudRecord
         *
         * @param request StopCloudRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopCloudRecordResponse
         */
        public StopCloudRecordResponse StopCloudRecordWithOptions(StopCloudRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
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
                Action = "StopCloudRecord",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCloudRecordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary StopCloudRecord
         *
         * @param request StopCloudRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopCloudRecordResponse
         */
        public async Task<StopCloudRecordResponse> StopCloudRecordWithOptionsAsync(StopCloudRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
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
                Action = "StopCloudRecord",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCloudRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary StopCloudRecord
         *
         * @param request StopCloudRecordRequest
         * @return StopCloudRecordResponse
         */
        public StopCloudRecordResponse StopCloudRecord(StopCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopCloudRecordWithOptions(request, runtime);
        }

        /**
         * @summary StopCloudRecord
         *
         * @param request StopCloudRecordRequest
         * @return StopCloudRecordResponse
         */
        public async Task<StopCloudRecordResponse> StopCloudRecordAsync(StopCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopCloudRecordWithOptionsAsync(request, runtime);
        }

        /**
         * @param request StopMPUTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopMPUTaskResponse
         */
        public StopMPUTaskResponse StopMPUTaskWithOptions(StopMPUTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "StopMPUTask",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopMPUTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request StopMPUTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopMPUTaskResponse
         */
        public async Task<StopMPUTaskResponse> StopMPUTaskWithOptionsAsync(StopMPUTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "StopMPUTask",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopMPUTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request StopMPUTaskRequest
         * @return StopMPUTaskResponse
         */
        public StopMPUTaskResponse StopMPUTask(StopMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopMPUTaskWithOptions(request, runtime);
        }

        /**
         * @param request StopMPUTaskRequest
         * @return StopMPUTaskResponse
         */
        public async Task<StopMPUTaskResponse> StopMPUTaskAsync(StopMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopMPUTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @param request StopRecordTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopRecordTaskResponse
         */
        public StopRecordTaskResponse StopRecordTaskWithOptions(StopRecordTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "StopRecordTask",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopRecordTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request StopRecordTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopRecordTaskResponse
         */
        public async Task<StopRecordTaskResponse> StopRecordTaskWithOptionsAsync(StopRecordTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "StopRecordTask",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopRecordTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request StopRecordTaskRequest
         * @return StopRecordTaskResponse
         */
        public StopRecordTaskResponse StopRecordTask(StopRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopRecordTaskWithOptions(request, runtime);
        }

        /**
         * @param request StopRecordTaskRequest
         * @return StopRecordTaskResponse
         */
        public async Task<StopRecordTaskResponse> StopRecordTaskAsync(StopRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopRecordTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary StopStreamingOut
         *
         * @param request StopStreamingOutRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopStreamingOutResponse
         */
        public StopStreamingOutResponse StopStreamingOutWithOptions(StopStreamingOutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
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
                Action = "StopStreamingOut",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopStreamingOutResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary StopStreamingOut
         *
         * @param request StopStreamingOutRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopStreamingOutResponse
         */
        public async Task<StopStreamingOutResponse> StopStreamingOutWithOptionsAsync(StopStreamingOutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
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
                Action = "StopStreamingOut",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopStreamingOutResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary StopStreamingOut
         *
         * @param request StopStreamingOutRequest
         * @return StopStreamingOutResponse
         */
        public StopStreamingOutResponse StopStreamingOut(StopStreamingOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopStreamingOutWithOptions(request, runtime);
        }

        /**
         * @summary StopStreamingOut
         *
         * @param request StopStreamingOutRequest
         * @return StopStreamingOutResponse
         */
        public async Task<StopStreamingOutResponse> StopStreamingOutAsync(StopStreamingOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopStreamingOutWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateAutoLiveStreamRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAutoLiveStreamRuleResponse
         */
        public UpdateAutoLiveStreamRuleResponse UpdateAutoLiveStreamRuleWithOptions(UpdateAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallBack))
            {
                query["CallBack"] = request.CallBack;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelIdPrefixes))
            {
                query["ChannelIdPrefixes"] = request.ChannelIdPrefixes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelIds))
            {
                query["ChannelIds"] = request.ChannelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaEncode))
            {
                query["MediaEncode"] = request.MediaEncode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayDomain))
            {
                query["PlayDomain"] = request.PlayDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAutoLiveStreamRule",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutoLiveStreamRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateAutoLiveStreamRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAutoLiveStreamRuleResponse
         */
        public async Task<UpdateAutoLiveStreamRuleResponse> UpdateAutoLiveStreamRuleWithOptionsAsync(UpdateAutoLiveStreamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallBack))
            {
                query["CallBack"] = request.CallBack;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelIdPrefixes))
            {
                query["ChannelIdPrefixes"] = request.ChannelIdPrefixes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelIds))
            {
                query["ChannelIds"] = request.ChannelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaEncode))
            {
                query["MediaEncode"] = request.MediaEncode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayDomain))
            {
                query["PlayDomain"] = request.PlayDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAutoLiveStreamRule",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutoLiveStreamRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateAutoLiveStreamRuleRequest
         * @return UpdateAutoLiveStreamRuleResponse
         */
        public UpdateAutoLiveStreamRuleResponse UpdateAutoLiveStreamRule(UpdateAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAutoLiveStreamRuleWithOptions(request, runtime);
        }

        /**
         * @param request UpdateAutoLiveStreamRuleRequest
         * @return UpdateAutoLiveStreamRuleResponse
         */
        public async Task<UpdateAutoLiveStreamRuleResponse> UpdateAutoLiveStreamRuleAsync(UpdateAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新云端录制任务
         *
         * @param request UpdateCloudRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCloudRecordResponse
         */
        public UpdateCloudRecordResponse UpdateCloudRecordWithOptions(UpdateCloudRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClockWidgets))
            {
                query["ClockWidgets"] = request.ClockWidgets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Images))
            {
                query["Images"] = request.Images;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Panes))
            {
                query["Panes"] = request.Panes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Texts))
            {
                query["Texts"] = request.Texts;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCloudRecord",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCloudRecordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新云端录制任务
         *
         * @param request UpdateCloudRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCloudRecordResponse
         */
        public async Task<UpdateCloudRecordResponse> UpdateCloudRecordWithOptionsAsync(UpdateCloudRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClockWidgets))
            {
                query["ClockWidgets"] = request.ClockWidgets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Images))
            {
                query["Images"] = request.Images;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Panes))
            {
                query["Panes"] = request.Panes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Texts))
            {
                query["Texts"] = request.Texts;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCloudRecord",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCloudRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新云端录制任务
         *
         * @param request UpdateCloudRecordRequest
         * @return UpdateCloudRecordResponse
         */
        public UpdateCloudRecordResponse UpdateCloudRecord(UpdateCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCloudRecordWithOptions(request, runtime);
        }

        /**
         * @summary 更新云端录制任务
         *
         * @param request UpdateCloudRecordRequest
         * @return UpdateCloudRecordResponse
         */
        public async Task<UpdateCloudRecordResponse> UpdateCloudRecordAsync(UpdateCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCloudRecordWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateMPUTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMPUTaskResponse
         */
        public UpdateMPUTaskResponse UpdateMPUTaskWithOptions(UpdateMPUTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundColor))
            {
                query["BackgroundColor"] = request.BackgroundColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Backgrounds))
            {
                query["Backgrounds"] = request.Backgrounds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClockWidgets))
            {
                query["ClockWidgets"] = request.ClockWidgets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CropMode))
            {
                query["CropMode"] = request.CropMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutIds))
            {
                query["LayoutIds"] = request.LayoutIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaEncode))
            {
                query["MediaEncode"] = request.MediaEncode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MixMode))
            {
                query["MixMode"] = request.MixMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecAudioUsers))
            {
                query["SubSpecAudioUsers"] = request.SubSpecAudioUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecCameraUsers))
            {
                query["SubSpecCameraUsers"] = request.SubSpecCameraUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecShareScreenUsers))
            {
                query["SubSpecShareScreenUsers"] = request.SubSpecShareScreenUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecUsers))
            {
                query["SubSpecUsers"] = request.SubSpecUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecAudioUsers))
            {
                query["UnsubSpecAudioUsers"] = request.UnsubSpecAudioUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecCameraUsers))
            {
                query["UnsubSpecCameraUsers"] = request.UnsubSpecCameraUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecShareScreenUsers))
            {
                query["UnsubSpecShareScreenUsers"] = request.UnsubSpecShareScreenUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPanes))
            {
                query["UserPanes"] = request.UserPanes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Watermarks))
            {
                query["Watermarks"] = request.Watermarks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMPUTask",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMPUTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateMPUTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMPUTaskResponse
         */
        public async Task<UpdateMPUTaskResponse> UpdateMPUTaskWithOptionsAsync(UpdateMPUTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundColor))
            {
                query["BackgroundColor"] = request.BackgroundColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Backgrounds))
            {
                query["Backgrounds"] = request.Backgrounds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClockWidgets))
            {
                query["ClockWidgets"] = request.ClockWidgets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CropMode))
            {
                query["CropMode"] = request.CropMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutIds))
            {
                query["LayoutIds"] = request.LayoutIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaEncode))
            {
                query["MediaEncode"] = request.MediaEncode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MixMode))
            {
                query["MixMode"] = request.MixMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecAudioUsers))
            {
                query["SubSpecAudioUsers"] = request.SubSpecAudioUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecCameraUsers))
            {
                query["SubSpecCameraUsers"] = request.SubSpecCameraUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecShareScreenUsers))
            {
                query["SubSpecShareScreenUsers"] = request.SubSpecShareScreenUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecUsers))
            {
                query["SubSpecUsers"] = request.SubSpecUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecAudioUsers))
            {
                query["UnsubSpecAudioUsers"] = request.UnsubSpecAudioUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecCameraUsers))
            {
                query["UnsubSpecCameraUsers"] = request.UnsubSpecCameraUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecShareScreenUsers))
            {
                query["UnsubSpecShareScreenUsers"] = request.UnsubSpecShareScreenUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPanes))
            {
                query["UserPanes"] = request.UserPanes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Watermarks))
            {
                query["Watermarks"] = request.Watermarks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMPUTask",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMPUTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateMPUTaskRequest
         * @return UpdateMPUTaskResponse
         */
        public UpdateMPUTaskResponse UpdateMPUTask(UpdateMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMPUTaskWithOptions(request, runtime);
        }

        /**
         * @param request UpdateMPUTaskRequest
         * @return UpdateMPUTaskResponse
         */
        public async Task<UpdateMPUTaskResponse> UpdateMPUTaskAsync(UpdateMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMPUTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateRecordTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRecordTaskResponse
         */
        public UpdateRecordTaskResponse UpdateRecordTaskWithOptions(UpdateRecordTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CropMode))
            {
                query["CropMode"] = request.CropMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutIds))
            {
                query["LayoutIds"] = request.LayoutIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaEncode))
            {
                query["MediaEncode"] = request.MediaEncode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecAudioUsers))
            {
                query["SubSpecAudioUsers"] = request.SubSpecAudioUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecCameraUsers))
            {
                query["SubSpecCameraUsers"] = request.SubSpecCameraUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecShareScreenUsers))
            {
                query["SubSpecShareScreenUsers"] = request.SubSpecShareScreenUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecUsers))
            {
                query["SubSpecUsers"] = request.SubSpecUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskProfile))
            {
                query["TaskProfile"] = request.TaskProfile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecAudioUsers))
            {
                query["UnsubSpecAudioUsers"] = request.UnsubSpecAudioUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecCameraUsers))
            {
                query["UnsubSpecCameraUsers"] = request.UnsubSpecCameraUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecShareScreenUsers))
            {
                query["UnsubSpecShareScreenUsers"] = request.UnsubSpecShareScreenUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPanes))
            {
                query["UserPanes"] = request.UserPanes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRecordTask",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRecordTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateRecordTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRecordTaskResponse
         */
        public async Task<UpdateRecordTaskResponse> UpdateRecordTaskWithOptionsAsync(UpdateRecordTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CropMode))
            {
                query["CropMode"] = request.CropMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutIds))
            {
                query["LayoutIds"] = request.LayoutIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaEncode))
            {
                query["MediaEncode"] = request.MediaEncode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecAudioUsers))
            {
                query["SubSpecAudioUsers"] = request.SubSpecAudioUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecCameraUsers))
            {
                query["SubSpecCameraUsers"] = request.SubSpecCameraUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecShareScreenUsers))
            {
                query["SubSpecShareScreenUsers"] = request.SubSpecShareScreenUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSpecUsers))
            {
                query["SubSpecUsers"] = request.SubSpecUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskProfile))
            {
                query["TaskProfile"] = request.TaskProfile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecAudioUsers))
            {
                query["UnsubSpecAudioUsers"] = request.UnsubSpecAudioUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecCameraUsers))
            {
                query["UnsubSpecCameraUsers"] = request.UnsubSpecCameraUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsubSpecShareScreenUsers))
            {
                query["UnsubSpecShareScreenUsers"] = request.UnsubSpecShareScreenUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPanes))
            {
                query["UserPanes"] = request.UserPanes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRecordTask",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRecordTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateRecordTaskRequest
         * @return UpdateRecordTaskResponse
         */
        public UpdateRecordTaskResponse UpdateRecordTask(UpdateRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRecordTaskWithOptions(request, runtime);
        }

        /**
         * @param request UpdateRecordTaskRequest
         * @return UpdateRecordTaskResponse
         */
        public async Task<UpdateRecordTaskResponse> UpdateRecordTaskAsync(UpdateRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRecordTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateRecordTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRecordTemplateResponse
         */
        public UpdateRecordTemplateResponse UpdateRecordTemplateWithOptions(UpdateRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundColor))
            {
                query["BackgroundColor"] = request.BackgroundColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Backgrounds))
            {
                query["Backgrounds"] = request.Backgrounds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClockWidgets))
            {
                query["ClockWidgets"] = request.ClockWidgets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayStopTime))
            {
                query["DelayStopTime"] = request.DelayStopTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableM3u8DateTime))
            {
                query["EnableM3u8DateTime"] = request.EnableM3u8DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSplitInterval))
            {
                query["FileSplitInterval"] = request.FileSplitInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Formats))
            {
                query["Formats"] = request.Formats;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpCallbackUrl))
            {
                query["HttpCallbackUrl"] = request.HttpCallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutIds))
            {
                query["LayoutIds"] = request.LayoutIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaEncode))
            {
                query["MediaEncode"] = request.MediaEncode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MnsQueue))
            {
                query["MnsQueue"] = request.MnsQueue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssFilePrefix))
            {
                query["OssFilePrefix"] = request.OssFilePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskProfile))
            {
                query["TaskProfile"] = request.TaskProfile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Watermarks))
            {
                query["Watermarks"] = request.Watermarks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRecordTemplate",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRecordTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateRecordTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRecordTemplateResponse
         */
        public async Task<UpdateRecordTemplateResponse> UpdateRecordTemplateWithOptionsAsync(UpdateRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundColor))
            {
                query["BackgroundColor"] = request.BackgroundColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Backgrounds))
            {
                query["Backgrounds"] = request.Backgrounds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClockWidgets))
            {
                query["ClockWidgets"] = request.ClockWidgets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelayStopTime))
            {
                query["DelayStopTime"] = request.DelayStopTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableM3u8DateTime))
            {
                query["EnableM3u8DateTime"] = request.EnableM3u8DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSplitInterval))
            {
                query["FileSplitInterval"] = request.FileSplitInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Formats))
            {
                query["Formats"] = request.Formats;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpCallbackUrl))
            {
                query["HttpCallbackUrl"] = request.HttpCallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutIds))
            {
                query["LayoutIds"] = request.LayoutIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaEncode))
            {
                query["MediaEncode"] = request.MediaEncode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MnsQueue))
            {
                query["MnsQueue"] = request.MnsQueue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssFilePrefix))
            {
                query["OssFilePrefix"] = request.OssFilePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskProfile))
            {
                query["TaskProfile"] = request.TaskProfile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Watermarks))
            {
                query["Watermarks"] = request.Watermarks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRecordTemplate",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRecordTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateRecordTemplateRequest
         * @return UpdateRecordTemplateResponse
         */
        public UpdateRecordTemplateResponse UpdateRecordTemplate(UpdateRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRecordTemplateWithOptions(request, runtime);
        }

        /**
         * @param request UpdateRecordTemplateRequest
         * @return UpdateRecordTemplateResponse
         */
        public async Task<UpdateRecordTemplateResponse> UpdateRecordTemplateAsync(UpdateRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRecordTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新旁路推流任务
         *
         * @param request UpdateStreamingOutRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateStreamingOutResponse
         */
        public UpdateStreamingOutResponse UpdateStreamingOutWithOptions(UpdateStreamingOutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClockWidgets))
            {
                query["ClockWidgets"] = request.ClockWidgets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Images))
            {
                query["Images"] = request.Images;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Panes))
            {
                query["Panes"] = request.Panes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Texts))
            {
                query["Texts"] = request.Texts;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStreamingOut",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStreamingOutResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新旁路推流任务
         *
         * @param request UpdateStreamingOutRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateStreamingOutResponse
         */
        public async Task<UpdateStreamingOutResponse> UpdateStreamingOutWithOptionsAsync(UpdateStreamingOutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClockWidgets))
            {
                query["ClockWidgets"] = request.ClockWidgets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Images))
            {
                query["Images"] = request.Images;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Panes))
            {
                query["Panes"] = request.Panes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Texts))
            {
                query["Texts"] = request.Texts;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStreamingOut",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStreamingOutResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新旁路推流任务
         *
         * @param request UpdateStreamingOutRequest
         * @return UpdateStreamingOutResponse
         */
        public UpdateStreamingOutResponse UpdateStreamingOut(UpdateStreamingOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStreamingOutWithOptions(request, runtime);
        }

        /**
         * @summary 更新旁路推流任务
         *
         * @param request UpdateStreamingOutRequest
         * @return UpdateStreamingOutResponse
         */
        public async Task<UpdateStreamingOutResponse> UpdateStreamingOutAsync(UpdateStreamingOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStreamingOutWithOptionsAsync(request, runtime);
        }

    }
}
