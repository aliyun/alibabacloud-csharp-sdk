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

        public AddRecordTemplateResponse AddRecordTemplate(AddRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddRecordTemplateWithOptions(request, runtime);
        }

        public async Task<AddRecordTemplateResponse> AddRecordTemplateAsync(AddRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddRecordTemplateWithOptionsAsync(request, runtime);
        }

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

        public CreateAutoLiveStreamRuleResponse CreateAutoLiveStreamRule(CreateAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAutoLiveStreamRuleWithOptions(request, runtime);
        }

        public async Task<CreateAutoLiveStreamRuleResponse> CreateAutoLiveStreamRuleAsync(CreateAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

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

        public CreateEventSubscribeResponse CreateEventSubscribe(CreateEventSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEventSubscribeWithOptions(request, runtime);
        }

        public async Task<CreateEventSubscribeResponse> CreateEventSubscribeAsync(CreateEventSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEventSubscribeWithOptionsAsync(request, runtime);
        }

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

        public CreateMPULayoutResponse CreateMPULayout(CreateMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMPULayoutWithOptions(request, runtime);
        }

        public async Task<CreateMPULayoutResponse> CreateMPULayoutAsync(CreateMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMPULayoutWithOptionsAsync(request, runtime);
        }

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

        public DeleteAutoLiveStreamRuleResponse DeleteAutoLiveStreamRule(DeleteAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAutoLiveStreamRuleWithOptions(request, runtime);
        }

        public async Task<DeleteAutoLiveStreamRuleResponse> DeleteAutoLiveStreamRuleAsync(DeleteAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

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

        public DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteChannelWithOptions(request, runtime);
        }

        public async Task<DeleteChannelResponse> DeleteChannelAsync(DeleteChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteChannelWithOptionsAsync(request, runtime);
        }

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

        public DeleteEventSubscribeResponse DeleteEventSubscribe(DeleteEventSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventSubscribeWithOptions(request, runtime);
        }

        public async Task<DeleteEventSubscribeResponse> DeleteEventSubscribeAsync(DeleteEventSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventSubscribeWithOptionsAsync(request, runtime);
        }

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

        public DeleteMPULayoutResponse DeleteMPULayout(DeleteMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMPULayoutWithOptions(request, runtime);
        }

        public async Task<DeleteMPULayoutResponse> DeleteMPULayoutAsync(DeleteMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMPULayoutWithOptionsAsync(request, runtime);
        }

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

        public DeleteRecordTemplateResponse DeleteRecordTemplate(DeleteRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRecordTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteRecordTemplateResponse> DeleteRecordTemplateAsync(DeleteRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRecordTemplateWithOptionsAsync(request, runtime);
        }

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

        public DescribeAppKeyResponse DescribeAppKey(DescribeAppKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppKeyWithOptions(request, runtime);
        }

        public async Task<DescribeAppKeyResponse> DescribeAppKeyAsync(DescribeAppKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppKeyWithOptionsAsync(request, runtime);
        }

        public DescribeAppsResponse DescribeAppsWithOptions(DescribeAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
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

        public async Task<DescribeAppsResponse> DescribeAppsWithOptionsAsync(DescribeAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
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

        public DescribeAppsResponse DescribeApps(DescribeAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppsWithOptions(request, runtime);
        }

        public async Task<DescribeAppsResponse> DescribeAppsAsync(DescribeAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppsWithOptionsAsync(request, runtime);
        }

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

        public DescribeAutoLiveStreamRuleResponse DescribeAutoLiveStreamRule(DescribeAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoLiveStreamRuleWithOptions(request, runtime);
        }

        public async Task<DescribeAutoLiveStreamRuleResponse> DescribeAutoLiveStreamRuleAsync(DescribeAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

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

        public DescribeChannelParticipantsResponse DescribeChannelParticipants(DescribeChannelParticipantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelParticipantsWithOptions(request, runtime);
        }

        public async Task<DescribeChannelParticipantsResponse> DescribeChannelParticipantsAsync(DescribeChannelParticipantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelParticipantsWithOptionsAsync(request, runtime);
        }

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

        public DescribeChannelUsersResponse DescribeChannelUsers(DescribeChannelUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChannelUsersWithOptions(request, runtime);
        }

        public async Task<DescribeChannelUsersResponse> DescribeChannelUsersAsync(DescribeChannelUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChannelUsersWithOptionsAsync(request, runtime);
        }

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

        public DescribeMPULayoutInfoListResponse DescribeMPULayoutInfoList(DescribeMPULayoutInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMPULayoutInfoListWithOptions(request, runtime);
        }

        public async Task<DescribeMPULayoutInfoListResponse> DescribeMPULayoutInfoListAsync(DescribeMPULayoutInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMPULayoutInfoListWithOptionsAsync(request, runtime);
        }

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

        public DescribeRecordFilesResponse DescribeRecordFiles(DescribeRecordFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordFilesWithOptions(request, runtime);
        }

        public async Task<DescribeRecordFilesResponse> DescribeRecordFilesAsync(DescribeRecordFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordFilesWithOptionsAsync(request, runtime);
        }

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

        public DescribeRecordTemplatesResponse DescribeRecordTemplates(DescribeRecordTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordTemplatesWithOptions(request, runtime);
        }

        public async Task<DescribeRecordTemplatesResponse> DescribeRecordTemplatesAsync(DescribeRecordTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordTemplatesWithOptionsAsync(request, runtime);
        }

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

        public DescribeUserInfoInChannelResponse DescribeUserInfoInChannel(DescribeUserInfoInChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserInfoInChannelWithOptions(request, runtime);
        }

        public async Task<DescribeUserInfoInChannelResponse> DescribeUserInfoInChannelAsync(DescribeUserInfoInChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserInfoInChannelWithOptionsAsync(request, runtime);
        }

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

        public DisableAutoLiveStreamRuleResponse DisableAutoLiveStreamRule(DisableAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableAutoLiveStreamRuleWithOptions(request, runtime);
        }

        public async Task<DisableAutoLiveStreamRuleResponse> DisableAutoLiveStreamRuleAsync(DisableAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

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

        public EnableAutoLiveStreamRuleResponse EnableAutoLiveStreamRule(EnableAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableAutoLiveStreamRuleWithOptions(request, runtime);
        }

        public async Task<EnableAutoLiveStreamRuleResponse> EnableAutoLiveStreamRuleAsync(EnableAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

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

        public GetMPUTaskStatusResponse GetMPUTaskStatus(GetMPUTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMPUTaskStatusWithOptions(request, runtime);
        }

        public async Task<GetMPUTaskStatusResponse> GetMPUTaskStatusAsync(GetMPUTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMPUTaskStatusWithOptionsAsync(request, runtime);
        }

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

        public ModifyAppResponse ModifyApp(ModifyAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppWithOptions(request, runtime);
        }

        public async Task<ModifyAppResponse> ModifyAppAsync(ModifyAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppWithOptionsAsync(request, runtime);
        }

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

        public ModifyMPULayoutResponse ModifyMPULayout(ModifyMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMPULayoutWithOptions(request, runtime);
        }

        public async Task<ModifyMPULayoutResponse> ModifyMPULayoutAsync(ModifyMPULayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMPULayoutWithOptionsAsync(request, runtime);
        }

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

        public RemoveTerminalsResponse RemoveTerminals(RemoveTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTerminalsWithOptions(request, runtime);
        }

        public async Task<RemoveTerminalsResponse> RemoveTerminalsAsync(RemoveTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTerminalsWithOptionsAsync(request, runtime);
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnhancedParam.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnhancedParam.ToMap()))
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

        public StartMPUTaskResponse StartMPUTask(StartMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartMPUTaskWithOptions(request, runtime);
        }

        public async Task<StartMPUTaskResponse> StartMPUTaskAsync(StartMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartMPUTaskWithOptionsAsync(request, runtime);
        }

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

        public StartRecordTaskResponse StartRecordTask(StartRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartRecordTaskWithOptions(request, runtime);
        }

        public async Task<StartRecordTaskResponse> StartRecordTaskAsync(StartRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartRecordTaskWithOptionsAsync(request, runtime);
        }

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

        public StopMPUTaskResponse StopMPUTask(StopMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopMPUTaskWithOptions(request, runtime);
        }

        public async Task<StopMPUTaskResponse> StopMPUTaskAsync(StopMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopMPUTaskWithOptionsAsync(request, runtime);
        }

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

        public StopRecordTaskResponse StopRecordTask(StopRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopRecordTaskWithOptions(request, runtime);
        }

        public async Task<StopRecordTaskResponse> StopRecordTaskAsync(StopRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopRecordTaskWithOptionsAsync(request, runtime);
        }

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

        public UpdateAutoLiveStreamRuleResponse UpdateAutoLiveStreamRule(UpdateAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAutoLiveStreamRuleWithOptions(request, runtime);
        }

        public async Task<UpdateAutoLiveStreamRuleResponse> UpdateAutoLiveStreamRuleAsync(UpdateAutoLiveStreamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAutoLiveStreamRuleWithOptionsAsync(request, runtime);
        }

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

        public UpdateMPUTaskResponse UpdateMPUTask(UpdateMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMPUTaskWithOptions(request, runtime);
        }

        public async Task<UpdateMPUTaskResponse> UpdateMPUTaskAsync(UpdateMPUTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMPUTaskWithOptionsAsync(request, runtime);
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutIds))
            {
                query["LayoutIds"] = request.LayoutIds;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutIds))
            {
                query["LayoutIds"] = request.LayoutIds;
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

        public UpdateRecordTaskResponse UpdateRecordTask(UpdateRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRecordTaskWithOptions(request, runtime);
        }

        public async Task<UpdateRecordTaskResponse> UpdateRecordTaskAsync(UpdateRecordTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRecordTaskWithOptionsAsync(request, runtime);
        }

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

        public UpdateRecordTemplateResponse UpdateRecordTemplate(UpdateRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRecordTemplateWithOptions(request, runtime);
        }

        public async Task<UpdateRecordTemplateResponse> UpdateRecordTemplateAsync(UpdateRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRecordTemplateWithOptionsAsync(request, runtime);
        }

    }
}
