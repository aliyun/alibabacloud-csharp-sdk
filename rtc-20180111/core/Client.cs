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

        /// <param name="request">
        /// AddRecordTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRecordTemplateResponse
        /// </returns>
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

        /// <param name="request">
        /// AddRecordTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRecordTemplateResponse
        /// </returns>
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

        /// <param name="request">
        /// AddRecordTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// AddRecordTemplateResponse
        /// </returns>
        public AddRecordTemplateResponse AddRecordTemplate(AddRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddRecordTemplateWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AddRecordTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// AddRecordTemplateResponse
        /// </returns>
        public async Task<AddRecordTemplateResponse> AddRecordTemplateAsync(AddRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddRecordTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增app自定义布局</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAppLayoutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppLayoutResponse
        /// </returns>
        public CreateAppLayoutResponse CreateAppLayoutWithOptions(CreateAppLayoutRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAppLayoutShrinkRequest request = new CreateAppLayoutShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Layout))
            {
                request.LayoutShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Layout, "Layout", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutShrink))
            {
                query["Layout"] = request.LayoutShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppLayout",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppLayoutResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增app自定义布局</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAppLayoutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppLayoutResponse
        /// </returns>
        public async Task<CreateAppLayoutResponse> CreateAppLayoutWithOptionsAsync(CreateAppLayoutRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAppLayoutShrinkRequest request = new CreateAppLayoutShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Layout))
            {
                request.LayoutShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Layout, "Layout", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutShrink))
            {
                query["Layout"] = request.LayoutShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppLayout",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppLayoutResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增app自定义布局</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppLayoutRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppLayoutResponse
        /// </returns>
        public CreateAppLayoutResponse CreateAppLayout(CreateAppLayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppLayoutWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增app自定义布局</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppLayoutRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppLayoutResponse
        /// </returns>
        public async Task<CreateAppLayoutResponse> CreateAppLayoutAsync(CreateAppLayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppLayoutWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加应用录制模版</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAppRecordTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppRecordTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加应用录制模版</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAppRecordTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppRecordTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加应用录制模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppRecordTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppRecordTemplateResponse
        /// </returns>
        public CreateAppRecordTemplateResponse CreateAppRecordTemplate(CreateAppRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppRecordTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加应用录制模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppRecordTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppRecordTemplateResponse
        /// </returns>
        public async Task<CreateAppRecordTemplateResponse> CreateAppRecordTemplateAsync(CreateAppRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppRecordTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用推流模版</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAppStreamingOutTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppStreamingOutTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用推流模版</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAppStreamingOutTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppStreamingOutTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用推流模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppStreamingOutTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppStreamingOutTemplateResponse
        /// </returns>
        public CreateAppStreamingOutTemplateResponse CreateAppStreamingOutTemplate(CreateAppStreamingOutTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppStreamingOutTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用推流模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppStreamingOutTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppStreamingOutTemplateResponse
        /// </returns>
        public async Task<CreateAppStreamingOutTemplateResponse> CreateAppStreamingOutTemplateAsync(CreateAppStreamingOutTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppStreamingOutTemplateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateAutoLiveStreamRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAutoLiveStreamRuleResponse
        /// </returns>
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

        /// <param name="request">
        /// CreateAutoLiveStreamRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAutoLiveStreamRuleResponse
        /// </returns>
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

        /// <param name="request">
        /// CreateAutoLiveStreamRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAutoLiveStreamRuleResponse
        /// </returns>
        public CreateAutoLiveStreamRuleResponse CreateAutoLiveStreamRule(CreateAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAutoLiveStreamRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateAutoLiveStreamRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAutoLiveStreamRuleResponse
        /// </returns>
        public async Task<CreateAutoLiveStreamRuleResponse> CreateAutoLiveStreamRuleAsync(CreateAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateEventSubscribeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEventSubscribeResponse
        /// </returns>
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

        /// <param name="request">
        /// CreateEventSubscribeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEventSubscribeResponse
        /// </returns>
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

        /// <param name="request">
        /// CreateEventSubscribeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEventSubscribeResponse
        /// </returns>
        public CreateEventSubscribeResponse CreateEventSubscribe(CreateEventSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEventSubscribeWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateEventSubscribeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEventSubscribeResponse
        /// </returns>
        public async Task<CreateEventSubscribeResponse> CreateEventSubscribeAsync(CreateEventSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEventSubscribeWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateMPULayoutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMPULayoutResponse
        /// </returns>
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

        /// <param name="request">
        /// CreateMPULayoutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMPULayoutResponse
        /// </returns>
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

        /// <param name="request">
        /// CreateMPULayoutRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMPULayoutResponse
        /// </returns>
        public CreateMPULayoutResponse CreateMPULayout(CreateMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMPULayoutWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateMPULayoutRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMPULayoutResponse
        /// </returns>
        public async Task<CreateMPULayoutResponse> CreateMPULayoutAsync(CreateMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMPULayoutWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除app自定义布局</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteAppLayoutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppLayoutResponse
        /// </returns>
        public DeleteAppLayoutResponse DeleteAppLayoutWithOptions(DeleteAppLayoutRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAppLayoutShrinkRequest request = new DeleteAppLayoutShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Layout))
            {
                request.LayoutShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Layout, "Layout", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutShrink))
            {
                query["Layout"] = request.LayoutShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppLayout",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppLayoutResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除app自定义布局</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteAppLayoutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppLayoutResponse
        /// </returns>
        public async Task<DeleteAppLayoutResponse> DeleteAppLayoutWithOptionsAsync(DeleteAppLayoutRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAppLayoutShrinkRequest request = new DeleteAppLayoutShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Layout))
            {
                request.LayoutShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Layout, "Layout", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutShrink))
            {
                query["Layout"] = request.LayoutShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppLayout",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppLayoutResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除app自定义布局</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppLayoutRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppLayoutResponse
        /// </returns>
        public DeleteAppLayoutResponse DeleteAppLayout(DeleteAppLayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppLayoutWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除app自定义布局</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppLayoutRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppLayoutResponse
        /// </returns>
        public async Task<DeleteAppLayoutResponse> DeleteAppLayoutAsync(DeleteAppLayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppLayoutWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除应用录制模版</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteAppRecordTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppRecordTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除应用录制模版</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteAppRecordTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppRecordTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除应用录制模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppRecordTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppRecordTemplateResponse
        /// </returns>
        public DeleteAppRecordTemplateResponse DeleteAppRecordTemplate(DeleteAppRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppRecordTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除应用录制模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppRecordTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppRecordTemplateResponse
        /// </returns>
        public async Task<DeleteAppRecordTemplateResponse> DeleteAppRecordTemplateAsync(DeleteAppRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppRecordTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除应用推流模版</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteAppStreamingOutTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppStreamingOutTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除应用推流模版</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteAppStreamingOutTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppStreamingOutTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除应用推流模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppStreamingOutTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppStreamingOutTemplateResponse
        /// </returns>
        public DeleteAppStreamingOutTemplateResponse DeleteAppStreamingOutTemplate(DeleteAppStreamingOutTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppStreamingOutTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除应用推流模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppStreamingOutTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppStreamingOutTemplateResponse
        /// </returns>
        public async Task<DeleteAppStreamingOutTemplateResponse> DeleteAppStreamingOutTemplateAsync(DeleteAppStreamingOutTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppStreamingOutTemplateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteAutoLiveStreamRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAutoLiveStreamRuleResponse
        /// </returns>
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

        /// <param name="request">
        /// DeleteAutoLiveStreamRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAutoLiveStreamRuleResponse
        /// </returns>
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

        /// <param name="request">
        /// DeleteAutoLiveStreamRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAutoLiveStreamRuleResponse
        /// </returns>
        public DeleteAutoLiveStreamRuleResponse DeleteAutoLiveStreamRule(DeleteAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAutoLiveStreamRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteAutoLiveStreamRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAutoLiveStreamRuleResponse
        /// </returns>
        public async Task<DeleteAutoLiveStreamRuleResponse> DeleteAutoLiveStreamRuleAsync(DeleteAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteChannelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteChannelResponse
        /// </returns>
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

        /// <param name="request">
        /// DeleteChannelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteChannelResponse
        /// </returns>
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

        /// <param name="request">
        /// DeleteChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteChannelResponse
        /// </returns>
        public DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteChannelWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteChannelResponse
        /// </returns>
        public async Task<DeleteChannelResponse> DeleteChannelAsync(DeleteChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteChannelWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteEventSubscribeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventSubscribeResponse
        /// </returns>
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

        /// <param name="request">
        /// DeleteEventSubscribeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventSubscribeResponse
        /// </returns>
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

        /// <param name="request">
        /// DeleteEventSubscribeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventSubscribeResponse
        /// </returns>
        public DeleteEventSubscribeResponse DeleteEventSubscribe(DeleteEventSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventSubscribeWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteEventSubscribeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventSubscribeResponse
        /// </returns>
        public async Task<DeleteEventSubscribeResponse> DeleteEventSubscribeAsync(DeleteEventSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventSubscribeWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteMPULayoutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMPULayoutResponse
        /// </returns>
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

        /// <param name="request">
        /// DeleteMPULayoutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMPULayoutResponse
        /// </returns>
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

        /// <param name="request">
        /// DeleteMPULayoutRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMPULayoutResponse
        /// </returns>
        public DeleteMPULayoutResponse DeleteMPULayout(DeleteMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMPULayoutWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteMPULayoutRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMPULayoutResponse
        /// </returns>
        public async Task<DeleteMPULayoutResponse> DeleteMPULayoutAsync(DeleteMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMPULayoutWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteRecordTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRecordTemplateResponse
        /// </returns>
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

        /// <param name="request">
        /// DeleteRecordTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRecordTemplateResponse
        /// </returns>
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

        /// <param name="request">
        /// DeleteRecordTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRecordTemplateResponse
        /// </returns>
        public DeleteRecordTemplateResponse DeleteRecordTemplate(DeleteRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRecordTemplateWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteRecordTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRecordTemplateResponse
        /// </returns>
        public async Task<DeleteRecordTemplateResponse> DeleteRecordTemplateAsync(DeleteRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRecordTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出系统支持的事件回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAllCallbackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAllCallbackResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出系统支持的事件回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAllCallbackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAllCallbackResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出系统支持的事件回调</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeAllCallbackResponse
        /// </returns>
        public DescribeAllCallbackResponse DescribeAllCallback()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAllCallbackWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出系统支持的事件回调</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeAllCallbackResponse
        /// </returns>
        public async Task<DescribeAllCallbackResponse> DescribeAllCallbackAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAllCallbackWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看app回调开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppCallStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppCallStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看app回调开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppCallStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppCallStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看app回调开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppCallStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppCallStatusResponse
        /// </returns>
        public DescribeAppCallStatusResponse DescribeAppCallStatus(DescribeAppCallStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppCallStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看app回调开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppCallStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppCallStatusResponse
        /// </returns>
        public async Task<DescribeAppCallStatusResponse> DescribeAppCallStatusAsync(DescribeAppCallStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppCallStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取app回调密钥</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppCallbackSecretKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppCallbackSecretKeyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取app回调密钥</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppCallbackSecretKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppCallbackSecretKeyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取app回调密钥</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppCallbackSecretKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppCallbackSecretKeyResponse
        /// </returns>
        public DescribeAppCallbackSecretKeyResponse DescribeAppCallbackSecretKey(DescribeAppCallbackSecretKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppCallbackSecretKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取app回调密钥</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppCallbackSecretKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppCallbackSecretKeyResponse
        /// </returns>
        public async Task<DescribeAppCallbackSecretKeyResponse> DescribeAppCallbackSecretKeyAsync(DescribeAppCallbackSecretKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppCallbackSecretKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看AppKey</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppKeyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看AppKey</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppKeyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看AppKey</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppKeyResponse
        /// </returns>
        public DescribeAppKeyResponse DescribeAppKey(DescribeAppKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看AppKey</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppKeyResponse
        /// </returns>
        public async Task<DescribeAppKeyResponse> DescribeAppKeyAsync(DescribeAppKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询app自定义布局</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeAppLayoutsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppLayoutsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询app自定义布局</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeAppLayoutsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppLayoutsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询app自定义布局</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppLayoutsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppLayoutsResponse
        /// </returns>
        public DescribeAppLayoutsResponse DescribeAppLayouts(DescribeAppLayoutsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppLayoutsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询app自定义布局</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppLayoutsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppLayoutsResponse
        /// </returns>
        public async Task<DescribeAppLayoutsResponse> DescribeAppLayoutsAsync(DescribeAppLayoutsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppLayoutsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看应用旁路开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppLiveStreamStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppLiveStreamStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看应用旁路开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppLiveStreamStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppLiveStreamStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看应用旁路开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppLiveStreamStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppLiveStreamStatusResponse
        /// </returns>
        public DescribeAppLiveStreamStatusResponse DescribeAppLiveStreamStatus(DescribeAppLiveStreamStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppLiveStreamStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看应用旁路开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppLiveStreamStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppLiveStreamStatusResponse
        /// </returns>
        public async Task<DescribeAppLiveStreamStatusResponse> DescribeAppLiveStreamStatusAsync(DescribeAppLiveStreamStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppLiveStreamStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用录制开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppRecordStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppRecordStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用录制开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppRecordStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppRecordStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用录制开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppRecordStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppRecordStatusResponse
        /// </returns>
        public DescribeAppRecordStatusResponse DescribeAppRecordStatus(DescribeAppRecordStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppRecordStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用录制开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppRecordStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppRecordStatusResponse
        /// </returns>
        public async Task<DescribeAppRecordStatusResponse> DescribeAppRecordStatusAsync(DescribeAppRecordStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppRecordStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用录制模版列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeAppRecordTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppRecordTemplatesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用录制模版列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeAppRecordTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppRecordTemplatesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用录制模版列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppRecordTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppRecordTemplatesResponse
        /// </returns>
        public DescribeAppRecordTemplatesResponse DescribeAppRecordTemplates(DescribeAppRecordTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppRecordTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用录制模版列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppRecordTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppRecordTemplatesResponse
        /// </returns>
        public async Task<DescribeAppRecordTemplatesResponse> DescribeAppRecordTemplatesAsync(DescribeAppRecordTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppRecordTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询录制列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeAppRecordingFilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppRecordingFilesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询录制列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeAppRecordingFilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppRecordingFilesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询录制列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppRecordingFilesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppRecordingFilesResponse
        /// </returns>
        public DescribeAppRecordingFilesResponse DescribeAppRecordingFiles(DescribeAppRecordingFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppRecordingFilesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询录制列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppRecordingFilesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppRecordingFilesResponse
        /// </returns>
        public async Task<DescribeAppRecordingFilesResponse> DescribeAppRecordingFilesAsync(DescribeAppRecordingFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppRecordingFilesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用推流模版列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeAppStreamingOutTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppStreamingOutTemplatesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用推流模版列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeAppStreamingOutTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppStreamingOutTemplatesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用推流模版列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppStreamingOutTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppStreamingOutTemplatesResponse
        /// </returns>
        public DescribeAppStreamingOutTemplatesResponse DescribeAppStreamingOutTemplates(DescribeAppStreamingOutTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppStreamingOutTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用推流模版列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppStreamingOutTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppStreamingOutTemplatesResponse
        /// </returns>
        public async Task<DescribeAppStreamingOutTemplatesResponse> DescribeAppStreamingOutTemplatesAsync(DescribeAppStreamingOutTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppStreamingOutTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>App列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>App列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>App列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppsResponse
        /// </returns>
        public DescribeAppsResponse DescribeApps(DescribeAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>App列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppsResponse
        /// </returns>
        public async Task<DescribeAppsResponse> DescribeAppsAsync(DescribeAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeAutoLiveStreamRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutoLiveStreamRuleResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeAutoLiveStreamRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutoLiveStreamRuleResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeAutoLiveStreamRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutoLiveStreamRuleResponse
        /// </returns>
        public DescribeAutoLiveStreamRuleResponse DescribeAutoLiveStreamRule(DescribeAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoLiveStreamRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeAutoLiveStreamRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutoLiveStreamRuleResponse
        /// </returns>
        public async Task<DescribeAutoLiveStreamRuleResponse> DescribeAutoLiveStreamRuleAsync(DescribeAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeCall获取单次通信详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCallResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeCall获取单次通信详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCallResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeCall获取单次通信详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCallRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCallResponse
        /// </returns>
        public DescribeCallResponse DescribeCall(DescribeCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCallWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeCall获取单次通信详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCallRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCallResponse
        /// </returns>
        public async Task<DescribeCallResponse> DescribeCallAsync(DescribeCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCallWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeCallList分页查询时间范围内创建的通信信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCallListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCallListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeCallList分页查询时间范围内创建的通信信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCallListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCallListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeCallList分页查询时间范围内创建的通信信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCallListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCallListResponse
        /// </returns>
        public DescribeCallListResponse DescribeCallList(DescribeCallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCallListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeCallList分页查询时间范围内创建的通信信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCallListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCallListResponse
        /// </returns>
        public async Task<DescribeCallListResponse> DescribeCallListAsync(DescribeCallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCallListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>app事件回调列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCallbacksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCallbacksResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>app事件回调列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCallbacksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCallbacksResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>app事件回调列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCallbacksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCallbacksResponse
        /// </returns>
        public DescribeCallbacksResponse DescribeCallbacks(DescribeCallbacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCallbacksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>app事件回调列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCallbacksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCallbacksResponse
        /// </returns>
        public async Task<DescribeCallbacksResponse> DescribeCallbacksAsync(DescribeCallbacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCallbacksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeChannel</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeChannel</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeChannel</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelResponse
        /// </returns>
        public DescribeChannelResponse DescribeChannel(DescribeChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeChannel</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelResponse
        /// </returns>
        public async Task<DescribeChannelResponse> DescribeChannelAsync(DescribeChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询频道的所有参会者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelAllUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelAllUsersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询频道的所有参会者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelAllUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelAllUsersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询频道的所有参会者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelAllUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelAllUsersResponse
        /// </returns>
        public DescribeChannelAllUsersResponse DescribeChannelAllUsers(DescribeChannelAllUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelAllUsersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询频道的所有参会者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelAllUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelAllUsersResponse
        /// </returns>
        public async Task<DescribeChannelAllUsersResponse> DescribeChannelAllUsersAsync(DescribeChannelAllUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelAllUsersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeChannelAreaDistributionStatData获取频道地区分布统计数据。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelAreaDistributionStatDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelAreaDistributionStatDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeChannelAreaDistributionStatData获取频道地区分布统计数据。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelAreaDistributionStatDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelAreaDistributionStatDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeChannelAreaDistributionStatData获取频道地区分布统计数据。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelAreaDistributionStatDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelAreaDistributionStatDataResponse
        /// </returns>
        public DescribeChannelAreaDistributionStatDataResponse DescribeChannelAreaDistributionStatData(DescribeChannelAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelAreaDistributionStatDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeChannelAreaDistributionStatData获取频道地区分布统计数据。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelAreaDistributionStatDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelAreaDistributionStatDataResponse
        /// </returns>
        public async Task<DescribeChannelAreaDistributionStatDataResponse> DescribeChannelAreaDistributionStatDataAsync(DescribeChannelAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelAreaDistributionStatDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeChannelDistributionStatData获取频道分布统计数据。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelDistributionStatDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelDistributionStatDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeChannelDistributionStatData获取频道分布统计数据。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelDistributionStatDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelDistributionStatDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeChannelDistributionStatData获取频道分布统计数据。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelDistributionStatDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelDistributionStatDataResponse
        /// </returns>
        public DescribeChannelDistributionStatDataResponse DescribeChannelDistributionStatData(DescribeChannelDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelDistributionStatDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeChannelDistributionStatData获取频道分布统计数据。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelDistributionStatDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelDistributionStatDataResponse
        /// </returns>
        public async Task<DescribeChannelDistributionStatDataResponse> DescribeChannelDistributionStatDataAsync(DescribeChannelDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelDistributionStatDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeChannelOverallData查询频道概览数据。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelOverallDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelOverallDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeChannelOverallData查询频道概览数据。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelOverallDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelOverallDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeChannelOverallData查询频道概览数据。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelOverallDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelOverallDataResponse
        /// </returns>
        public DescribeChannelOverallDataResponse DescribeChannelOverallData(DescribeChannelOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelOverallDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeChannelOverallData查询频道概览数据。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelOverallDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelOverallDataResponse
        /// </returns>
        public async Task<DescribeChannelOverallDataResponse> DescribeChannelOverallDataAsync(DescribeChannelOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelOverallDataWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeChannelParticipantsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelParticipantsResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeChannelParticipantsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelParticipantsResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeChannelParticipantsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelParticipantsResponse
        /// </returns>
        public DescribeChannelParticipantsResponse DescribeChannelParticipants(DescribeChannelParticipantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelParticipantsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeChannelParticipantsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelParticipantsResponse
        /// </returns>
        public async Task<DescribeChannelParticipantsResponse> DescribeChannelParticipantsAsync(DescribeChannelParticipantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelParticipantsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeChannelTopPubUserList获取频道内发布端的用户列表（按用户在线时长降序）。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelTopPubUserListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelTopPubUserListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeChannelTopPubUserList获取频道内发布端的用户列表（按用户在线时长降序）。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelTopPubUserListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelTopPubUserListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeChannelTopPubUserList获取频道内发布端的用户列表（按用户在线时长降序）。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelTopPubUserListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelTopPubUserListResponse
        /// </returns>
        public DescribeChannelTopPubUserListResponse DescribeChannelTopPubUserList(DescribeChannelTopPubUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelTopPubUserListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeChannelTopPubUserList获取频道内发布端的用户列表（按用户在线时长降序）。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelTopPubUserListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelTopPubUserListResponse
        /// </returns>
        public async Task<DescribeChannelTopPubUserListResponse> DescribeChannelTopPubUserListAsync(DescribeChannelTopPubUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelTopPubUserListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeChannelUser</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelUserResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeChannelUser</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelUserResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeChannelUser</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelUserRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelUserResponse
        /// </returns>
        public DescribeChannelUserResponse DescribeChannelUser(DescribeChannelUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeChannelUser</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelUserRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelUserResponse
        /// </returns>
        public async Task<DescribeChannelUserResponse> DescribeChannelUserAsync(DescribeChannelUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeChannelUserMetrics查询频道总览中的用户数据。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelUserMetricsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelUserMetricsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeChannelUserMetrics查询频道总览中的用户数据。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelUserMetricsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelUserMetricsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeChannelUserMetrics查询频道总览中的用户数据。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelUserMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelUserMetricsResponse
        /// </returns>
        public DescribeChannelUserMetricsResponse DescribeChannelUserMetrics(DescribeChannelUserMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelUserMetricsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeChannelUserMetrics查询频道总览中的用户数据。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelUserMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelUserMetricsResponse
        /// </returns>
        public async Task<DescribeChannelUserMetricsResponse> DescribeChannelUserMetricsAsync(DescribeChannelUserMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelUserMetricsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeChannelUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelUsersResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeChannelUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelUsersResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeChannelUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelUsersResponse
        /// </returns>
        public DescribeChannelUsersResponse DescribeChannelUsers(DescribeChannelUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelUsersWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeChannelUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelUsersResponse
        /// </returns>
        public async Task<DescribeChannelUsersResponse> DescribeChannelUsersAsync(DescribeChannelUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelUsersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询在线频道列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询在线频道列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询在线频道列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelsResponse
        /// </returns>
        public DescribeChannelsResponse DescribeChannels(DescribeChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询在线频道列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChannelsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChannelsResponse
        /// </returns>
        public async Task<DescribeChannelsResponse> DescribeChannelsAsync(DescribeChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>纪要列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeCloudNotesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudNotesResponse
        /// </returns>
        public DescribeCloudNotesResponse DescribeCloudNotesWithOptions(DescribeCloudNotesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCloudNotesShrinkRequest request = new DescribeCloudNotesShrinkRequest();
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
                Action = "DescribeCloudNotes",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudNotesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>纪要列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeCloudNotesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudNotesResponse
        /// </returns>
        public async Task<DescribeCloudNotesResponse> DescribeCloudNotesWithOptionsAsync(DescribeCloudNotesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCloudNotesShrinkRequest request = new DescribeCloudNotesShrinkRequest();
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
                Action = "DescribeCloudNotes",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudNotesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>纪要列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudNotesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudNotesResponse
        /// </returns>
        public DescribeCloudNotesResponse DescribeCloudNotes(DescribeCloudNotesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudNotesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>纪要列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudNotesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudNotesResponse
        /// </returns>
        public async Task<DescribeCloudNotesResponse> DescribeCloudNotesAsync(DescribeCloudNotesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudNotesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeEndPointEventList获取端对端用户事件列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEndPointEventListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEndPointEventListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeEndPointEventList获取端对端用户事件列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEndPointEventListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEndPointEventListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeEndPointEventList获取端对端用户事件列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEndPointEventListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEndPointEventListResponse
        /// </returns>
        public DescribeEndPointEventListResponse DescribeEndPointEventList(DescribeEndPointEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEndPointEventListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeEndPointEventList获取端对端用户事件列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEndPointEventListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEndPointEventListResponse
        /// </returns>
        public async Task<DescribeEndPointEventListResponse> DescribeEndPointEventListAsync(DescribeEndPointEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEndPointEventListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeEndPointMetricData获取端对端指标数据。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEndPointMetricDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEndPointMetricDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeEndPointMetricData获取端对端指标数据。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEndPointMetricDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEndPointMetricDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeEndPointMetricData获取端对端指标数据。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEndPointMetricDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEndPointMetricDataResponse
        /// </returns>
        public DescribeEndPointMetricDataResponse DescribeEndPointMetricData(DescribeEndPointMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEndPointMetricDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeEndPointMetricData获取端对端指标数据。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEndPointMetricDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEndPointMetricDataResponse
        /// </returns>
        public async Task<DescribeEndPointMetricDataResponse> DescribeEndPointMetricDataAsync(DescribeEndPointMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEndPointMetricDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异常诊断影响因素分布</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFaultDiagnosisFactorDistributionStatRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaultDiagnosisFactorDistributionStatResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异常诊断影响因素分布</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFaultDiagnosisFactorDistributionStatRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaultDiagnosisFactorDistributionStatResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异常诊断影响因素分布</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFaultDiagnosisFactorDistributionStatRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaultDiagnosisFactorDistributionStatResponse
        /// </returns>
        public DescribeFaultDiagnosisFactorDistributionStatResponse DescribeFaultDiagnosisFactorDistributionStat(DescribeFaultDiagnosisFactorDistributionStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFaultDiagnosisFactorDistributionStatWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异常诊断影响因素分布</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFaultDiagnosisFactorDistributionStatRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaultDiagnosisFactorDistributionStatResponse
        /// </returns>
        public async Task<DescribeFaultDiagnosisFactorDistributionStatResponse> DescribeFaultDiagnosisFactorDistributionStatAsync(DescribeFaultDiagnosisFactorDistributionStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFaultDiagnosisFactorDistributionStatWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异常诊断总览数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFaultDiagnosisOverallDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaultDiagnosisOverallDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异常诊断总览数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFaultDiagnosisOverallDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaultDiagnosisOverallDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异常诊断总览数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFaultDiagnosisOverallDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaultDiagnosisOverallDataResponse
        /// </returns>
        public DescribeFaultDiagnosisOverallDataResponse DescribeFaultDiagnosisOverallData(DescribeFaultDiagnosisOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFaultDiagnosisOverallDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异常诊断总览数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFaultDiagnosisOverallDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaultDiagnosisOverallDataResponse
        /// </returns>
        public async Task<DescribeFaultDiagnosisOverallDataResponse> DescribeFaultDiagnosisOverallDataAsync(DescribeFaultDiagnosisOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFaultDiagnosisOverallDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异常诊断用户详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFaultDiagnosisUserDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaultDiagnosisUserDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异常诊断用户详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFaultDiagnosisUserDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaultDiagnosisUserDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异常诊断用户详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFaultDiagnosisUserDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaultDiagnosisUserDetailResponse
        /// </returns>
        public DescribeFaultDiagnosisUserDetailResponse DescribeFaultDiagnosisUserDetail(DescribeFaultDiagnosisUserDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFaultDiagnosisUserDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异常诊断用户详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFaultDiagnosisUserDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaultDiagnosisUserDetailResponse
        /// </returns>
        public async Task<DescribeFaultDiagnosisUserDetailResponse> DescribeFaultDiagnosisUserDetailAsync(DescribeFaultDiagnosisUserDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFaultDiagnosisUserDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异常诊断用户明细列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFaultDiagnosisUserListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaultDiagnosisUserListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异常诊断用户明细列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFaultDiagnosisUserListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaultDiagnosisUserListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异常诊断用户明细列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFaultDiagnosisUserListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaultDiagnosisUserListResponse
        /// </returns>
        public DescribeFaultDiagnosisUserListResponse DescribeFaultDiagnosisUserList(DescribeFaultDiagnosisUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFaultDiagnosisUserListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异常诊断用户明细列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFaultDiagnosisUserListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaultDiagnosisUserListResponse
        /// </returns>
        public async Task<DescribeFaultDiagnosisUserListResponse> DescribeFaultDiagnosisUserListAsync(DescribeFaultDiagnosisUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFaultDiagnosisUserListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeMPULayoutInfoListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMPULayoutInfoListResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeMPULayoutInfoListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMPULayoutInfoListResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeMPULayoutInfoListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMPULayoutInfoListResponse
        /// </returns>
        public DescribeMPULayoutInfoListResponse DescribeMPULayoutInfoList(DescribeMPULayoutInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMPULayoutInfoListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeMPULayoutInfoListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMPULayoutInfoListResponse
        /// </returns>
        public async Task<DescribeMPULayoutInfoListResponse> DescribeMPULayoutInfoListAsync(DescribeMPULayoutInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMPULayoutInfoListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribePubUserListBySubUser根据订阅端获取通信中发布端用户列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePubUserListBySubUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePubUserListBySubUserResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribePubUserListBySubUser根据订阅端获取通信中发布端用户列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePubUserListBySubUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePubUserListBySubUserResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribePubUserListBySubUser根据订阅端获取通信中发布端用户列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePubUserListBySubUserRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePubUserListBySubUserResponse
        /// </returns>
        public DescribePubUserListBySubUserResponse DescribePubUserListBySubUser(DescribePubUserListBySubUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePubUserListBySubUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribePubUserListBySubUser根据订阅端获取通信中发布端用户列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePubUserListBySubUserRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePubUserListBySubUserResponse
        /// </returns>
        public async Task<DescribePubUserListBySubUserResponse> DescribePubUserListBySubUserAsync(DescribePubUserListBySubUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePubUserListBySubUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeQoeMetricData获取单次通信中用户的下行体验质量指标。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQoeMetricDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeQoeMetricDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeQoeMetricData获取单次通信中用户的下行体验质量指标。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQoeMetricDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeQoeMetricDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeQoeMetricData获取单次通信中用户的下行体验质量指标。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQoeMetricDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeQoeMetricDataResponse
        /// </returns>
        public DescribeQoeMetricDataResponse DescribeQoeMetricData(DescribeQoeMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeQoeMetricDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DescribeQoeMetricData获取单次通信中用户的下行体验质量指标。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQoeMetricDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeQoeMetricDataResponse
        /// </returns>
        public async Task<DescribeQoeMetricDataResponse> DescribeQoeMetricDataAsync(DescribeQoeMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeQoeMetricDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质量统计区域分布统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQualityAreaDistributionStatDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeQualityAreaDistributionStatDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质量统计区域分布统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQualityAreaDistributionStatDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeQualityAreaDistributionStatDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质量统计区域分布统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQualityAreaDistributionStatDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeQualityAreaDistributionStatDataResponse
        /// </returns>
        public DescribeQualityAreaDistributionStatDataResponse DescribeQualityAreaDistributionStatData(DescribeQualityAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeQualityAreaDistributionStatDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质量统计区域分布统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQualityAreaDistributionStatDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeQualityAreaDistributionStatDataResponse
        /// </returns>
        public async Task<DescribeQualityAreaDistributionStatDataResponse> DescribeQualityAreaDistributionStatDataAsync(DescribeQualityAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeQualityAreaDistributionStatDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质量统计分布数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQualityDistributionStatDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeQualityDistributionStatDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质量统计分布数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQualityDistributionStatDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeQualityDistributionStatDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质量统计分布数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQualityDistributionStatDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeQualityDistributionStatDataResponse
        /// </returns>
        public DescribeQualityDistributionStatDataResponse DescribeQualityDistributionStatData(DescribeQualityDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeQualityDistributionStatDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质量统计分布数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQualityDistributionStatDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeQualityDistributionStatDataResponse
        /// </returns>
        public async Task<DescribeQualityDistributionStatDataResponse> DescribeQualityDistributionStatDataAsync(DescribeQualityDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeQualityDistributionStatDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质量统计各操作系统下SDK版本分布数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQualityOsSdkVersionDistributionStatDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeQualityOsSdkVersionDistributionStatDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质量统计各操作系统下SDK版本分布数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQualityOsSdkVersionDistributionStatDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeQualityOsSdkVersionDistributionStatDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质量统计各操作系统下SDK版本分布数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQualityOsSdkVersionDistributionStatDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeQualityOsSdkVersionDistributionStatDataResponse
        /// </returns>
        public DescribeQualityOsSdkVersionDistributionStatDataResponse DescribeQualityOsSdkVersionDistributionStatData(DescribeQualityOsSdkVersionDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeQualityOsSdkVersionDistributionStatDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质量统计各操作系统下SDK版本分布数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQualityOsSdkVersionDistributionStatDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeQualityOsSdkVersionDistributionStatDataResponse
        /// </returns>
        public async Task<DescribeQualityOsSdkVersionDistributionStatDataResponse> DescribeQualityOsSdkVersionDistributionStatDataAsync(DescribeQualityOsSdkVersionDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeQualityOsSdkVersionDistributionStatDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质量统计概览数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQualityOverallDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeQualityOverallDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质量统计概览数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQualityOverallDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeQualityOverallDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质量统计概览数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQualityOverallDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeQualityOverallDataResponse
        /// </returns>
        public DescribeQualityOverallDataResponse DescribeQualityOverallData(DescribeQualityOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeQualityOverallDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质量统计概览数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQualityOverallDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeQualityOverallDataResponse
        /// </returns>
        public async Task<DescribeQualityOverallDataResponse> DescribeQualityOverallDataAsync(DescribeQualityOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeQualityOverallDataWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeRecordFilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRecordFilesResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeRecordFilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRecordFilesResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeRecordFilesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRecordFilesResponse
        /// </returns>
        public DescribeRecordFilesResponse DescribeRecordFiles(DescribeRecordFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordFilesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeRecordFilesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRecordFilesResponse
        /// </returns>
        public async Task<DescribeRecordFilesResponse> DescribeRecordFilesAsync(DescribeRecordFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordFilesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeRecordTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRecordTemplatesResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeRecordTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRecordTemplatesResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeRecordTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRecordTemplatesResponse
        /// </returns>
        public DescribeRecordTemplatesResponse DescribeRecordTemplates(DescribeRecordTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordTemplatesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeRecordTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRecordTemplatesResponse
        /// </returns>
        public async Task<DescribeRecordTemplatesResponse> DescribeRecordTemplatesAsync(DescribeRecordTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordTemplatesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeRtcChannelListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRtcChannelListResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeRtcChannelListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRtcChannelListResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeRtcChannelListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRtcChannelListResponse
        /// </returns>
        public DescribeRtcChannelListResponse DescribeRtcChannelList(DescribeRtcChannelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcChannelListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeRtcChannelListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRtcChannelListResponse
        /// </returns>
        public async Task<DescribeRtcChannelListResponse> DescribeRtcChannelListAsync(DescribeRtcChannelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcChannelListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeRtcChannelMetricRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRtcChannelMetricResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeRtcChannelMetricRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRtcChannelMetricResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeRtcChannelMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRtcChannelMetricResponse
        /// </returns>
        public DescribeRtcChannelMetricResponse DescribeRtcChannelMetric(DescribeRtcChannelMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcChannelMetricWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeRtcChannelMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRtcChannelMetricResponse
        /// </returns>
        public async Task<DescribeRtcChannelMetricResponse> DescribeRtcChannelMetricAsync(DescribeRtcChannelMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcChannelMetricWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeRtcDurationDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRtcDurationDataResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeRtcDurationDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRtcDurationDataResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeRtcDurationDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRtcDurationDataResponse
        /// </returns>
        public DescribeRtcDurationDataResponse DescribeRtcDurationData(DescribeRtcDurationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcDurationDataWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeRtcDurationDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRtcDurationDataResponse
        /// </returns>
        public async Task<DescribeRtcDurationDataResponse> DescribeRtcDurationDataAsync(DescribeRtcDurationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcDurationDataWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeRtcPeakChannelCntDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRtcPeakChannelCntDataResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeRtcPeakChannelCntDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRtcPeakChannelCntDataResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeRtcPeakChannelCntDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRtcPeakChannelCntDataResponse
        /// </returns>
        public DescribeRtcPeakChannelCntDataResponse DescribeRtcPeakChannelCntData(DescribeRtcPeakChannelCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcPeakChannelCntDataWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeRtcPeakChannelCntDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRtcPeakChannelCntDataResponse
        /// </returns>
        public async Task<DescribeRtcPeakChannelCntDataResponse> DescribeRtcPeakChannelCntDataAsync(DescribeRtcPeakChannelCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcPeakChannelCntDataWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeRtcUserCntDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRtcUserCntDataResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeRtcUserCntDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRtcUserCntDataResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeRtcUserCntDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRtcUserCntDataResponse
        /// </returns>
        public DescribeRtcUserCntDataResponse DescribeRtcUserCntData(DescribeRtcUserCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRtcUserCntDataWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeRtcUserCntDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRtcUserCntDataResponse
        /// </returns>
        public async Task<DescribeRtcUserCntDataResponse> DescribeRtcUserCntDataAsync(DescribeRtcUserCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRtcUserCntDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询旁路推流状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeStreamingOutStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeStreamingOutStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询旁路推流状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeStreamingOutStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeStreamingOutStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询旁路推流状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeStreamingOutStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeStreamingOutStatusResponse
        /// </returns>
        public DescribeStreamingOutStatusResponse DescribeStreamingOutStatus(DescribeStreamingOutStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStreamingOutStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询旁路推流状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeStreamingOutStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeStreamingOutStatusResponse
        /// </returns>
        public async Task<DescribeStreamingOutStatusResponse> DescribeStreamingOutStatusAsync(DescribeStreamingOutStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStreamingOutStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>系统内置布局</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSystemLayoutListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSystemLayoutListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>系统内置布局</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSystemLayoutListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSystemLayoutListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>系统内置布局</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSystemLayoutListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSystemLayoutListResponse
        /// </returns>
        public DescribeSystemLayoutListResponse DescribeSystemLayoutList(DescribeSystemLayoutListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSystemLayoutListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>系统内置布局</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSystemLayoutListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSystemLayoutListResponse
        /// </returns>
        public async Task<DescribeSystemLayoutListResponse> DescribeSystemLayoutListAsync(DescribeSystemLayoutListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSystemLayoutListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用量统计地域分布数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUsageAreaDistributionStatDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUsageAreaDistributionStatDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用量统计地域分布数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUsageAreaDistributionStatDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUsageAreaDistributionStatDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用量统计地域分布数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUsageAreaDistributionStatDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUsageAreaDistributionStatDataResponse
        /// </returns>
        public DescribeUsageAreaDistributionStatDataResponse DescribeUsageAreaDistributionStatData(DescribeUsageAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUsageAreaDistributionStatDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用量统计地域分布数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUsageAreaDistributionStatDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUsageAreaDistributionStatDataResponse
        /// </returns>
        public async Task<DescribeUsageAreaDistributionStatDataResponse> DescribeUsageAreaDistributionStatDataAsync(DescribeUsageAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUsageAreaDistributionStatDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用量统计分布数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUsageDistributionStatDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUsageDistributionStatDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用量统计分布数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUsageDistributionStatDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUsageDistributionStatDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用量统计分布数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUsageDistributionStatDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUsageDistributionStatDataResponse
        /// </returns>
        public DescribeUsageDistributionStatDataResponse DescribeUsageDistributionStatData(DescribeUsageDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUsageDistributionStatDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用量统计分布数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUsageDistributionStatDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUsageDistributionStatDataResponse
        /// </returns>
        public async Task<DescribeUsageDistributionStatDataResponse> DescribeUsageDistributionStatDataAsync(DescribeUsageDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUsageDistributionStatDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用量统计各操作系统下SDK版本分布数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUsageOsSdkVersionDistributionStatDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUsageOsSdkVersionDistributionStatDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用量统计各操作系统下SDK版本分布数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUsageOsSdkVersionDistributionStatDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUsageOsSdkVersionDistributionStatDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用量统计各操作系统下SDK版本分布数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUsageOsSdkVersionDistributionStatDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUsageOsSdkVersionDistributionStatDataResponse
        /// </returns>
        public DescribeUsageOsSdkVersionDistributionStatDataResponse DescribeUsageOsSdkVersionDistributionStatData(DescribeUsageOsSdkVersionDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUsageOsSdkVersionDistributionStatDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用量统计各操作系统下SDK版本分布数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUsageOsSdkVersionDistributionStatDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUsageOsSdkVersionDistributionStatDataResponse
        /// </returns>
        public async Task<DescribeUsageOsSdkVersionDistributionStatDataResponse> DescribeUsageOsSdkVersionDistributionStatDataAsync(DescribeUsageOsSdkVersionDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUsageOsSdkVersionDistributionStatDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用量统计概览数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUsageOverallDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUsageOverallDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用量统计概览数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUsageOverallDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUsageOverallDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用量统计概览数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUsageOverallDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUsageOverallDataResponse
        /// </returns>
        public DescribeUsageOverallDataResponse DescribeUsageOverallData(DescribeUsageOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUsageOverallDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用量统计概览数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUsageOverallDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUsageOverallDataResponse
        /// </returns>
        public async Task<DescribeUsageOverallDataResponse> DescribeUsageOverallDataAsync(DescribeUsageOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUsageOverallDataWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeUserInfoInChannelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserInfoInChannelResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeUserInfoInChannelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserInfoInChannelResponse
        /// </returns>
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

        /// <param name="request">
        /// DescribeUserInfoInChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserInfoInChannelResponse
        /// </returns>
        public DescribeUserInfoInChannelResponse DescribeUserInfoInChannel(DescribeUserInfoInChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserInfoInChannelWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeUserInfoInChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserInfoInChannelResponse
        /// </returns>
        public async Task<DescribeUserInfoInChannelResponse> DescribeUserInfoInChannelAsync(DescribeUserInfoInChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserInfoInChannelWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DisableAutoLiveStreamRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableAutoLiveStreamRuleResponse
        /// </returns>
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

        /// <param name="request">
        /// DisableAutoLiveStreamRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableAutoLiveStreamRuleResponse
        /// </returns>
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

        /// <param name="request">
        /// DisableAutoLiveStreamRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableAutoLiveStreamRuleResponse
        /// </returns>
        public DisableAutoLiveStreamRuleResponse DisableAutoLiveStreamRule(DisableAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableAutoLiveStreamRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DisableAutoLiveStreamRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableAutoLiveStreamRuleResponse
        /// </returns>
        public async Task<DisableAutoLiveStreamRuleResponse> DisableAutoLiveStreamRuleAsync(DisableAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// EnableAutoLiveStreamRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableAutoLiveStreamRuleResponse
        /// </returns>
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

        /// <param name="request">
        /// EnableAutoLiveStreamRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableAutoLiveStreamRuleResponse
        /// </returns>
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

        /// <param name="request">
        /// EnableAutoLiveStreamRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableAutoLiveStreamRuleResponse
        /// </returns>
        public EnableAutoLiveStreamRuleResponse EnableAutoLiveStreamRule(EnableAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableAutoLiveStreamRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// EnableAutoLiveStreamRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableAutoLiveStreamRuleResponse
        /// </returns>
        public async Task<EnableAutoLiveStreamRuleResponse> EnableAutoLiveStreamRuleAsync(EnableAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetMPUTaskStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMPUTaskStatusResponse
        /// </returns>
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

        /// <param name="request">
        /// GetMPUTaskStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMPUTaskStatusResponse
        /// </returns>
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

        /// <param name="request">
        /// GetMPUTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMPUTaskStatusResponse
        /// </returns>
        public GetMPUTaskStatusResponse GetMPUTaskStatus(GetMPUTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMPUTaskStatusWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetMPUTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMPUTaskStatusResponse
        /// </returns>
        public async Task<GetMPUTaskStatusResponse> GetMPUTaskStatusAsync(GetMPUTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMPUTaskStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改App信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改App信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改App信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppResponse
        /// </returns>
        public ModifyAppResponse ModifyApp(ModifyAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改App信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppResponse
        /// </returns>
        public async Task<ModifyAppResponse> ModifyAppAsync(ModifyAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新app回调事件开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppCallbackStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppCallbackStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新app回调事件开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppCallbackStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppCallbackStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新app回调事件开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppCallbackStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppCallbackStatusResponse
        /// </returns>
        public ModifyAppCallbackStatusResponse ModifyAppCallbackStatus(ModifyAppCallbackStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppCallbackStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新app回调事件开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppCallbackStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppCallbackStatusResponse
        /// </returns>
        public async Task<ModifyAppCallbackStatusResponse> ModifyAppCallbackStatusAsync(ModifyAppCallbackStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppCallbackStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改app自定义布局</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyAppLayoutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppLayoutResponse
        /// </returns>
        public ModifyAppLayoutResponse ModifyAppLayoutWithOptions(ModifyAppLayoutRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAppLayoutShrinkRequest request = new ModifyAppLayoutShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Layout))
            {
                request.LayoutShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Layout, "Layout", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutShrink))
            {
                query["Layout"] = request.LayoutShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppLayout",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppLayoutResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改app自定义布局</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyAppLayoutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppLayoutResponse
        /// </returns>
        public async Task<ModifyAppLayoutResponse> ModifyAppLayoutWithOptionsAsync(ModifyAppLayoutRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAppLayoutShrinkRequest request = new ModifyAppLayoutShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Layout))
            {
                request.LayoutShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Layout, "Layout", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutShrink))
            {
                query["Layout"] = request.LayoutShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppLayout",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppLayoutResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改app自定义布局</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppLayoutRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppLayoutResponse
        /// </returns>
        public ModifyAppLayoutResponse ModifyAppLayout(ModifyAppLayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppLayoutWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改app自定义布局</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppLayoutRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppLayoutResponse
        /// </returns>
        public async Task<ModifyAppLayoutResponse> ModifyAppLayoutAsync(ModifyAppLayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppLayoutWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改应用旁路开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppLiveStreamStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppLiveStreamStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改应用旁路开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppLiveStreamStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppLiveStreamStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改应用旁路开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppLiveStreamStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppLiveStreamStatusResponse
        /// </returns>
        public ModifyAppLiveStreamStatusResponse ModifyAppLiveStreamStatus(ModifyAppLiveStreamStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppLiveStreamStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改应用旁路开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppLiveStreamStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppLiveStreamStatusResponse
        /// </returns>
        public async Task<ModifyAppLiveStreamStatusResponse> ModifyAppLiveStreamStatusAsync(ModifyAppLiveStreamStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppLiveStreamStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改应用录制开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppRecordStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppRecordStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改应用录制开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppRecordStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppRecordStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改应用录制开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppRecordStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppRecordStatusResponse
        /// </returns>
        public ModifyAppRecordStatusResponse ModifyAppRecordStatus(ModifyAppRecordStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppRecordStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改应用录制开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppRecordStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppRecordStatusResponse
        /// </returns>
        public async Task<ModifyAppRecordStatusResponse> ModifyAppRecordStatusAsync(ModifyAppRecordStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppRecordStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改应用录制模版</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyAppRecordTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppRecordTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改应用录制模版</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyAppRecordTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppRecordTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改应用录制模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppRecordTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppRecordTemplateResponse
        /// </returns>
        public ModifyAppRecordTemplateResponse ModifyAppRecordTemplate(ModifyAppRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppRecordTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改应用录制模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppRecordTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppRecordTemplateResponse
        /// </returns>
        public async Task<ModifyAppRecordTemplateResponse> ModifyAppRecordTemplateAsync(ModifyAppRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppRecordTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新应用推流模版</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyAppStreamingOutTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppStreamingOutTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新应用推流模版</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyAppStreamingOutTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppStreamingOutTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新应用推流模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppStreamingOutTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppStreamingOutTemplateResponse
        /// </returns>
        public ModifyAppStreamingOutTemplateResponse ModifyAppStreamingOutTemplate(ModifyAppStreamingOutTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppStreamingOutTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新应用推流模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppStreamingOutTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppStreamingOutTemplateResponse
        /// </returns>
        public async Task<ModifyAppStreamingOutTemplateResponse> ModifyAppStreamingOutTemplateAsync(ModifyAppStreamingOutTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppStreamingOutTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新app回调</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyCallbackMetaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyCallbackMetaResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新app回调</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyCallbackMetaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyCallbackMetaResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新app回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCallbackMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyCallbackMetaResponse
        /// </returns>
        public ModifyCallbackMetaResponse ModifyCallbackMeta(ModifyCallbackMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCallbackMetaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新app回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCallbackMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyCallbackMetaResponse
        /// </returns>
        public async Task<ModifyCallbackMetaResponse> ModifyCallbackMetaAsync(ModifyCallbackMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCallbackMetaWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyMPULayoutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyMPULayoutResponse
        /// </returns>
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

        /// <param name="request">
        /// ModifyMPULayoutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyMPULayoutResponse
        /// </returns>
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

        /// <param name="request">
        /// ModifyMPULayoutRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyMPULayoutResponse
        /// </returns>
        public ModifyMPULayoutResponse ModifyMPULayout(ModifyMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMPULayoutWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyMPULayoutRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyMPULayoutResponse
        /// </returns>
        public async Task<ModifyMPULayoutResponse> ModifyMPULayoutAsync(ModifyMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMPULayoutWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RemoveTerminalsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveTerminalsResponse
        /// </returns>
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

        /// <param name="request">
        /// RemoveTerminalsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveTerminalsResponse
        /// </returns>
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

        /// <param name="request">
        /// RemoveTerminalsRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveTerminalsResponse
        /// </returns>
        public RemoveTerminalsResponse RemoveTerminals(RemoveTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTerminalsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RemoveTerminalsRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveTerminalsResponse
        /// </returns>
        public async Task<RemoveTerminalsResponse> RemoveTerminalsAsync(RemoveTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTerminalsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>RemoveUsers</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveUsersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>RemoveUsers</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveUsersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>RemoveUsers</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveUsersResponse
        /// </returns>
        public RemoveUsersResponse RemoveUsers(RemoveUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveUsersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>RemoveUsers</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveUsersResponse
        /// </returns>
        public async Task<RemoveUsersResponse> RemoveUsersAsync(RemoveUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveUsersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启某个事件回调</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// StartCategoryCallbackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartCategoryCallbackResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启某个事件回调</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// StartCategoryCallbackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartCategoryCallbackResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启某个事件回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartCategoryCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// StartCategoryCallbackResponse
        /// </returns>
        public StartCategoryCallbackResponse StartCategoryCallback(StartCategoryCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartCategoryCallbackWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启某个事件回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartCategoryCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// StartCategoryCallbackResponse
        /// </returns>
        public async Task<StartCategoryCallbackResponse> StartCategoryCallbackAsync(StartCategoryCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartCategoryCallbackWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启智能纪要</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// StartCloudNoteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartCloudNoteResponse
        /// </returns>
        public StartCloudNoteResponse StartCloudNoteWithOptions(StartCloudNoteRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StartCloudNoteShrinkRequest request = new StartCloudNoteShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AutoChapters))
            {
                request.AutoChaptersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AutoChapters, "AutoChapters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomPrompt))
            {
                request.CustomPromptShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomPrompt, "CustomPrompt", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MeetingAssistance))
            {
                request.MeetingAssistanceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MeetingAssistance, "MeetingAssistance", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RealtimeSubtitle))
            {
                request.RealtimeSubtitleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RealtimeSubtitle, "RealtimeSubtitle", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ServiceInspection))
            {
                request.ServiceInspectionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ServiceInspection, "ServiceInspection", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Summarization))
            {
                request.SummarizationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Summarization, "Summarization", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TextPolish))
            {
                request.TextPolishShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TextPolish, "TextPolish", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Transcription))
            {
                request.TranscriptionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Transcription, "Transcription", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoChaptersShrink))
            {
                query["AutoChapters"] = request.AutoChaptersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPromptShrink))
            {
                query["CustomPrompt"] = request.CustomPromptShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageHints))
            {
                query["LanguageHints"] = request.LanguageHints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeetingAssistanceShrink))
            {
                query["MeetingAssistance"] = request.MeetingAssistanceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealtimeSubtitleShrink))
            {
                query["RealtimeSubtitle"] = request.RealtimeSubtitleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInspectionShrink))
            {
                query["ServiceInspection"] = request.ServiceInspectionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                query["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageConfig))
            {
                query["StorageConfig"] = request.StorageConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummarizationShrink))
            {
                query["Summarization"] = request.SummarizationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextPolishShrink))
            {
                query["TextPolish"] = request.TextPolishShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscriptionShrink))
            {
                query["Transcription"] = request.TranscriptionShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartCloudNote",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCloudNoteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启智能纪要</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// StartCloudNoteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartCloudNoteResponse
        /// </returns>
        public async Task<StartCloudNoteResponse> StartCloudNoteWithOptionsAsync(StartCloudNoteRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StartCloudNoteShrinkRequest request = new StartCloudNoteShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AutoChapters))
            {
                request.AutoChaptersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AutoChapters, "AutoChapters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomPrompt))
            {
                request.CustomPromptShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomPrompt, "CustomPrompt", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MeetingAssistance))
            {
                request.MeetingAssistanceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MeetingAssistance, "MeetingAssistance", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RealtimeSubtitle))
            {
                request.RealtimeSubtitleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RealtimeSubtitle, "RealtimeSubtitle", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ServiceInspection))
            {
                request.ServiceInspectionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ServiceInspection, "ServiceInspection", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Summarization))
            {
                request.SummarizationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Summarization, "Summarization", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TextPolish))
            {
                request.TextPolishShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TextPolish, "TextPolish", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Transcription))
            {
                request.TranscriptionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Transcription, "Transcription", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoChaptersShrink))
            {
                query["AutoChapters"] = request.AutoChaptersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPromptShrink))
            {
                query["CustomPrompt"] = request.CustomPromptShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageHints))
            {
                query["LanguageHints"] = request.LanguageHints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeetingAssistanceShrink))
            {
                query["MeetingAssistance"] = request.MeetingAssistanceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealtimeSubtitleShrink))
            {
                query["RealtimeSubtitle"] = request.RealtimeSubtitleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInspectionShrink))
            {
                query["ServiceInspection"] = request.ServiceInspectionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                query["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageConfig))
            {
                query["StorageConfig"] = request.StorageConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummarizationShrink))
            {
                query["Summarization"] = request.SummarizationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextPolishShrink))
            {
                query["TextPolish"] = request.TextPolishShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscriptionShrink))
            {
                query["Transcription"] = request.TranscriptionShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartCloudNote",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCloudNoteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启智能纪要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartCloudNoteRequest
        /// </param>
        /// 
        /// <returns>
        /// StartCloudNoteResponse
        /// </returns>
        public StartCloudNoteResponse StartCloudNote(StartCloudNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartCloudNoteWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启智能纪要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartCloudNoteRequest
        /// </param>
        /// 
        /// <returns>
        /// StartCloudNoteResponse
        /// </returns>
        public async Task<StartCloudNoteResponse> StartCloudNoteAsync(StartCloudNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartCloudNoteWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StartCloudRecord</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// StartCloudRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartCloudRecordResponse
        /// </returns>
        public StartCloudRecordResponse StartCloudRecordWithOptions(StartCloudRecordRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StartCloudRecordShrinkRequest request = new StartCloudRecordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LayoutSpecifiedUsers))
            {
                request.LayoutSpecifiedUsersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LayoutSpecifiedUsers, "LayoutSpecifiedUsers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Images))
            {
                query["Images"] = request.Images;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutSpecifiedUsersShrink))
            {
                query["LayoutSpecifiedUsers"] = request.LayoutSpecifiedUsersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Panes))
            {
                query["Panes"] = request.Panes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionColor))
            {
                query["RegionColor"] = request.RegionColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservePaneForNoCameraUser))
            {
                query["ReservePaneForNoCameraUser"] = request.ReservePaneForNoCameraUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDefaultBackgroundOnMute))
            {
                query["ShowDefaultBackgroundOnMute"] = request.ShowDefaultBackgroundOnMute;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StartCloudRecord</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// StartCloudRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartCloudRecordResponse
        /// </returns>
        public async Task<StartCloudRecordResponse> StartCloudRecordWithOptionsAsync(StartCloudRecordRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StartCloudRecordShrinkRequest request = new StartCloudRecordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LayoutSpecifiedUsers))
            {
                request.LayoutSpecifiedUsersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LayoutSpecifiedUsers, "LayoutSpecifiedUsers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Images))
            {
                query["Images"] = request.Images;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutSpecifiedUsersShrink))
            {
                query["LayoutSpecifiedUsers"] = request.LayoutSpecifiedUsersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Panes))
            {
                query["Panes"] = request.Panes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionColor))
            {
                query["RegionColor"] = request.RegionColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservePaneForNoCameraUser))
            {
                query["ReservePaneForNoCameraUser"] = request.ReservePaneForNoCameraUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDefaultBackgroundOnMute))
            {
                query["ShowDefaultBackgroundOnMute"] = request.ShowDefaultBackgroundOnMute;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StartCloudRecord</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartCloudRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// StartCloudRecordResponse
        /// </returns>
        public StartCloudRecordResponse StartCloudRecord(StartCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartCloudRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StartCloudRecord</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartCloudRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// StartCloudRecordResponse
        /// </returns>
        public async Task<StartCloudRecordResponse> StartCloudRecordAsync(StartCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartCloudRecordWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// StartMPUTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartMPUTaskResponse
        /// </returns>
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

        /// <param name="request">
        /// StartMPUTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartMPUTaskResponse
        /// </returns>
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

        /// <param name="request">
        /// StartMPUTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StartMPUTaskResponse
        /// </returns>
        public StartMPUTaskResponse StartMPUTask(StartMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartMPUTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// StartMPUTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StartMPUTaskResponse
        /// </returns>
        public async Task<StartMPUTaskResponse> StartMPUTaskAsync(StartMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartMPUTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// StartRecordTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartRecordTaskResponse
        /// </returns>
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

        /// <param name="request">
        /// StartRecordTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartRecordTaskResponse
        /// </returns>
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

        /// <param name="request">
        /// StartRecordTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StartRecordTaskResponse
        /// </returns>
        public StartRecordTaskResponse StartRecordTask(StartRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartRecordTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// StartRecordTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StartRecordTaskResponse
        /// </returns>
        public async Task<StartRecordTaskResponse> StartRecordTaskAsync(StartRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartRecordTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StartStreamingOut</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// StartStreamingOutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartStreamingOutResponse
        /// </returns>
        public StartStreamingOutResponse StartStreamingOutWithOptions(StartStreamingOutRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StartStreamingOutShrinkRequest request = new StartStreamingOutShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LayoutSpecifiedUsers))
            {
                request.LayoutSpecifiedUsersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LayoutSpecifiedUsers, "LayoutSpecifiedUsers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Images))
            {
                query["Images"] = request.Images;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutSpecifiedUsersShrink))
            {
                query["LayoutSpecifiedUsers"] = request.LayoutSpecifiedUsersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Panes))
            {
                query["Panes"] = request.Panes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionColor))
            {
                query["RegionColor"] = request.RegionColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservePaneForNoCameraUser))
            {
                query["ReservePaneForNoCameraUser"] = request.ReservePaneForNoCameraUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDefaultBackgroundOnMute))
            {
                query["ShowDefaultBackgroundOnMute"] = request.ShowDefaultBackgroundOnMute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartWithoutChannel))
            {
                query["StartWithoutChannel"] = request.StartWithoutChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartWithoutChannelWaitTime))
            {
                query["StartWithoutChannelWaitTime"] = request.StartWithoutChannelWaitTime;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StartStreamingOut</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// StartStreamingOutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartStreamingOutResponse
        /// </returns>
        public async Task<StartStreamingOutResponse> StartStreamingOutWithOptionsAsync(StartStreamingOutRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StartStreamingOutShrinkRequest request = new StartStreamingOutShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LayoutSpecifiedUsers))
            {
                request.LayoutSpecifiedUsersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LayoutSpecifiedUsers, "LayoutSpecifiedUsers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Images))
            {
                query["Images"] = request.Images;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutSpecifiedUsersShrink))
            {
                query["LayoutSpecifiedUsers"] = request.LayoutSpecifiedUsersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Panes))
            {
                query["Panes"] = request.Panes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionColor))
            {
                query["RegionColor"] = request.RegionColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservePaneForNoCameraUser))
            {
                query["ReservePaneForNoCameraUser"] = request.ReservePaneForNoCameraUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDefaultBackgroundOnMute))
            {
                query["ShowDefaultBackgroundOnMute"] = request.ShowDefaultBackgroundOnMute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartWithoutChannel))
            {
                query["StartWithoutChannel"] = request.StartWithoutChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartWithoutChannelWaitTime))
            {
                query["StartWithoutChannelWaitTime"] = request.StartWithoutChannelWaitTime;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StartStreamingOut</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartStreamingOutRequest
        /// </param>
        /// 
        /// <returns>
        /// StartStreamingOutResponse
        /// </returns>
        public StartStreamingOutResponse StartStreamingOut(StartStreamingOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartStreamingOutWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StartStreamingOut</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartStreamingOutRequest
        /// </param>
        /// 
        /// <returns>
        /// StartStreamingOutResponse
        /// </returns>
        public async Task<StartStreamingOutResponse> StartStreamingOutAsync(StartStreamingOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartStreamingOutWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭某个事件回调</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// StopCategoryCallbackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopCategoryCallbackResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭某个事件回调</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// StopCategoryCallbackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopCategoryCallbackResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭某个事件回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCategoryCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// StopCategoryCallbackResponse
        /// </returns>
        public StopCategoryCallbackResponse StopCategoryCallback(StopCategoryCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopCategoryCallbackWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭某个事件回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCategoryCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// StopCategoryCallbackResponse
        /// </returns>
        public async Task<StopCategoryCallbackResponse> StopCategoryCallbackAsync(StopCategoryCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopCategoryCallbackWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除频道</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopChannelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopChannelResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除频道</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopChannelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopChannelResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除频道</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// StopChannelResponse
        /// </returns>
        public StopChannelResponse StopChannel(StopChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopChannelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除频道</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// StopChannelResponse
        /// </returns>
        public async Task<StopChannelResponse> StopChannelAsync(StopChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopChannelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止智能纪要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCloudNoteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopCloudNoteResponse
        /// </returns>
        public StopCloudNoteResponse StopCloudNoteWithOptions(StopCloudNoteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
                Action = "StopCloudNote",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCloudNoteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止智能纪要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCloudNoteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopCloudNoteResponse
        /// </returns>
        public async Task<StopCloudNoteResponse> StopCloudNoteWithOptionsAsync(StopCloudNoteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
                Action = "StopCloudNote",
                Version = "2018-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCloudNoteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止智能纪要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCloudNoteRequest
        /// </param>
        /// 
        /// <returns>
        /// StopCloudNoteResponse
        /// </returns>
        public StopCloudNoteResponse StopCloudNote(StopCloudNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopCloudNoteWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止智能纪要</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCloudNoteRequest
        /// </param>
        /// 
        /// <returns>
        /// StopCloudNoteResponse
        /// </returns>
        public async Task<StopCloudNoteResponse> StopCloudNoteAsync(StopCloudNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopCloudNoteWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StopCloudRecord</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCloudRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopCloudRecordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StopCloudRecord</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCloudRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopCloudRecordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StopCloudRecord</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCloudRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// StopCloudRecordResponse
        /// </returns>
        public StopCloudRecordResponse StopCloudRecord(StopCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopCloudRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StopCloudRecord</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCloudRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// StopCloudRecordResponse
        /// </returns>
        public async Task<StopCloudRecordResponse> StopCloudRecordAsync(StopCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopCloudRecordWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// StopMPUTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopMPUTaskResponse
        /// </returns>
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

        /// <param name="request">
        /// StopMPUTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopMPUTaskResponse
        /// </returns>
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

        /// <param name="request">
        /// StopMPUTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StopMPUTaskResponse
        /// </returns>
        public StopMPUTaskResponse StopMPUTask(StopMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopMPUTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// StopMPUTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StopMPUTaskResponse
        /// </returns>
        public async Task<StopMPUTaskResponse> StopMPUTaskAsync(StopMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopMPUTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// StopRecordTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopRecordTaskResponse
        /// </returns>
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

        /// <param name="request">
        /// StopRecordTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopRecordTaskResponse
        /// </returns>
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

        /// <param name="request">
        /// StopRecordTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StopRecordTaskResponse
        /// </returns>
        public StopRecordTaskResponse StopRecordTask(StopRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopRecordTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// StopRecordTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StopRecordTaskResponse
        /// </returns>
        public async Task<StopRecordTaskResponse> StopRecordTaskAsync(StopRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopRecordTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StopStreamingOut</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopStreamingOutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopStreamingOutResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StopStreamingOut</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopStreamingOutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopStreamingOutResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StopStreamingOut</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopStreamingOutRequest
        /// </param>
        /// 
        /// <returns>
        /// StopStreamingOutResponse
        /// </returns>
        public StopStreamingOutResponse StopStreamingOut(StopStreamingOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopStreamingOutWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StopStreamingOut</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopStreamingOutRequest
        /// </param>
        /// 
        /// <returns>
        /// StopStreamingOutResponse
        /// </returns>
        public async Task<StopStreamingOutResponse> StopStreamingOutAsync(StopStreamingOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopStreamingOutWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateAutoLiveStreamRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAutoLiveStreamRuleResponse
        /// </returns>
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

        /// <param name="request">
        /// UpdateAutoLiveStreamRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAutoLiveStreamRuleResponse
        /// </returns>
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

        /// <param name="request">
        /// UpdateAutoLiveStreamRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAutoLiveStreamRuleResponse
        /// </returns>
        public UpdateAutoLiveStreamRuleResponse UpdateAutoLiveStreamRule(UpdateAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAutoLiveStreamRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateAutoLiveStreamRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAutoLiveStreamRuleResponse
        /// </returns>
        public async Task<UpdateAutoLiveStreamRuleResponse> UpdateAutoLiveStreamRuleAsync(UpdateAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新云端录制任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateCloudRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCloudRecordResponse
        /// </returns>
        public UpdateCloudRecordResponse UpdateCloudRecordWithOptions(UpdateCloudRecordRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateCloudRecordShrinkRequest request = new UpdateCloudRecordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LayoutSpecifiedUsers))
            {
                request.LayoutSpecifiedUsersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LayoutSpecifiedUsers, "LayoutSpecifiedUsers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Images))
            {
                query["Images"] = request.Images;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutSpecifiedUsersShrink))
            {
                query["LayoutSpecifiedUsers"] = request.LayoutSpecifiedUsersShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新云端录制任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateCloudRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCloudRecordResponse
        /// </returns>
        public async Task<UpdateCloudRecordResponse> UpdateCloudRecordWithOptionsAsync(UpdateCloudRecordRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateCloudRecordShrinkRequest request = new UpdateCloudRecordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LayoutSpecifiedUsers))
            {
                request.LayoutSpecifiedUsersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LayoutSpecifiedUsers, "LayoutSpecifiedUsers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Images))
            {
                query["Images"] = request.Images;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutSpecifiedUsersShrink))
            {
                query["LayoutSpecifiedUsers"] = request.LayoutSpecifiedUsersShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新云端录制任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCloudRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCloudRecordResponse
        /// </returns>
        public UpdateCloudRecordResponse UpdateCloudRecord(UpdateCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCloudRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新云端录制任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCloudRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCloudRecordResponse
        /// </returns>
        public async Task<UpdateCloudRecordResponse> UpdateCloudRecordAsync(UpdateCloudRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCloudRecordWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateMPUTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMPUTaskResponse
        /// </returns>
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

        /// <param name="request">
        /// UpdateMPUTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMPUTaskResponse
        /// </returns>
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

        /// <param name="request">
        /// UpdateMPUTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMPUTaskResponse
        /// </returns>
        public UpdateMPUTaskResponse UpdateMPUTask(UpdateMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMPUTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateMPUTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMPUTaskResponse
        /// </returns>
        public async Task<UpdateMPUTaskResponse> UpdateMPUTaskAsync(UpdateMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMPUTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateRecordTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRecordTaskResponse
        /// </returns>
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

        /// <param name="request">
        /// UpdateRecordTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRecordTaskResponse
        /// </returns>
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

        /// <param name="request">
        /// UpdateRecordTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRecordTaskResponse
        /// </returns>
        public UpdateRecordTaskResponse UpdateRecordTask(UpdateRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRecordTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateRecordTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRecordTaskResponse
        /// </returns>
        public async Task<UpdateRecordTaskResponse> UpdateRecordTaskAsync(UpdateRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRecordTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateRecordTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRecordTemplateResponse
        /// </returns>
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

        /// <param name="request">
        /// UpdateRecordTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRecordTemplateResponse
        /// </returns>
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

        /// <param name="request">
        /// UpdateRecordTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRecordTemplateResponse
        /// </returns>
        public UpdateRecordTemplateResponse UpdateRecordTemplate(UpdateRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRecordTemplateWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateRecordTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRecordTemplateResponse
        /// </returns>
        public async Task<UpdateRecordTemplateResponse> UpdateRecordTemplateAsync(UpdateRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRecordTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新旁路推流任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateStreamingOutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateStreamingOutResponse
        /// </returns>
        public UpdateStreamingOutResponse UpdateStreamingOutWithOptions(UpdateStreamingOutRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateStreamingOutShrinkRequest request = new UpdateStreamingOutShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LayoutSpecifiedUsers))
            {
                request.LayoutSpecifiedUsersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LayoutSpecifiedUsers, "LayoutSpecifiedUsers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Images))
            {
                query["Images"] = request.Images;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutSpecifiedUsersShrink))
            {
                query["LayoutSpecifiedUsers"] = request.LayoutSpecifiedUsersShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新旁路推流任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateStreamingOutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateStreamingOutResponse
        /// </returns>
        public async Task<UpdateStreamingOutResponse> UpdateStreamingOutWithOptionsAsync(UpdateStreamingOutRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateStreamingOutShrinkRequest request = new UpdateStreamingOutShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LayoutSpecifiedUsers))
            {
                request.LayoutSpecifiedUsersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LayoutSpecifiedUsers, "LayoutSpecifiedUsers", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Images))
            {
                query["Images"] = request.Images;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutSpecifiedUsersShrink))
            {
                query["LayoutSpecifiedUsers"] = request.LayoutSpecifiedUsersShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新旁路推流任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateStreamingOutRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateStreamingOutResponse
        /// </returns>
        public UpdateStreamingOutResponse UpdateStreamingOut(UpdateStreamingOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStreamingOutWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新旁路推流任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateStreamingOutRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateStreamingOutResponse
        /// </returns>
        public async Task<UpdateStreamingOutResponse> UpdateStreamingOutAsync(UpdateStreamingOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStreamingOutWithOptionsAsync(request, runtime);
        }

    }
}
