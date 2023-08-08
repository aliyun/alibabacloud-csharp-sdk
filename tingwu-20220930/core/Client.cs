// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Tingwu20220930.Models;

namespace AlibabaCloud.SDK.Tingwu20220930
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("tingwu", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateFileTransResponse CreateFileTransWithOptions(CreateFileTransRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AbilityParams))
            {
                body["AbilityParams"] = request.AbilityParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrParams))
            {
                body["AsrParams"] = request.AsrParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioLanguage))
            {
                body["AudioLanguage"] = request.AudioLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioOssBucket))
            {
                body["AudioOssBucket"] = request.AudioOssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioOssPath))
            {
                body["AudioOssPath"] = request.AudioOssPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioOutputEnabled))
            {
                body["AudioOutputEnabled"] = request.AudioOutputEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioOutputOssBucket))
            {
                body["AudioOutputOssBucket"] = request.AudioOutputOssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioOutputOssPath))
            {
                body["AudioOutputOssPath"] = request.AudioOutputOssPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioRoleNum))
            {
                body["AudioRoleNum"] = request.AudioRoleNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioSegmentsEnabled))
            {
                body["AudioSegmentsEnabled"] = request.AudioSegmentsEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabParams))
            {
                body["LabParams"] = request.LabParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransKey))
            {
                body["TransKey"] = request.TransKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransResultOssBucket))
            {
                body["TransResultOssBucket"] = request.TransResultOssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransResultOssPath))
            {
                body["TransResultOssPath"] = request.TransResultOssPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoOutputEnabled))
            {
                body["VideoOutputEnabled"] = request.VideoOutputEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoOutputOssBucket))
            {
                body["VideoOutputOssBucket"] = request.VideoOutputOssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoOutputOssPath))
            {
                body["VideoOutputOssPath"] = request.VideoOutputOssPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFileTrans",
                Version = "2022-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/file-trans",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFileTransResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFileTransResponse> CreateFileTransWithOptionsAsync(CreateFileTransRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AbilityParams))
            {
                body["AbilityParams"] = request.AbilityParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrParams))
            {
                body["AsrParams"] = request.AsrParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioLanguage))
            {
                body["AudioLanguage"] = request.AudioLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioOssBucket))
            {
                body["AudioOssBucket"] = request.AudioOssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioOssPath))
            {
                body["AudioOssPath"] = request.AudioOssPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioOutputEnabled))
            {
                body["AudioOutputEnabled"] = request.AudioOutputEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioOutputOssBucket))
            {
                body["AudioOutputOssBucket"] = request.AudioOutputOssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioOutputOssPath))
            {
                body["AudioOutputOssPath"] = request.AudioOutputOssPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioRoleNum))
            {
                body["AudioRoleNum"] = request.AudioRoleNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioSegmentsEnabled))
            {
                body["AudioSegmentsEnabled"] = request.AudioSegmentsEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabParams))
            {
                body["LabParams"] = request.LabParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransKey))
            {
                body["TransKey"] = request.TransKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransResultOssBucket))
            {
                body["TransResultOssBucket"] = request.TransResultOssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransResultOssPath))
            {
                body["TransResultOssPath"] = request.TransResultOssPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoOutputEnabled))
            {
                body["VideoOutputEnabled"] = request.VideoOutputEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoOutputOssBucket))
            {
                body["VideoOutputOssBucket"] = request.VideoOutputOssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoOutputOssPath))
            {
                body["VideoOutputOssPath"] = request.VideoOutputOssPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFileTrans",
                Version = "2022-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/file-trans",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFileTransResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFileTransResponse CreateFileTrans(CreateFileTransRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFileTransWithOptions(request, headers, runtime);
        }

        public async Task<CreateFileTransResponse> CreateFileTransAsync(CreateFileTransRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFileTransWithOptionsAsync(request, headers, runtime);
        }

        public CreateMeetingTransResponse CreateMeetingTransWithOptions(CreateMeetingTransRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AbilityParams))
            {
                body["AbilityParams"] = request.AbilityParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrParams))
            {
                body["AsrParams"] = request.AsrParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioBitRate))
            {
                body["AudioBitRate"] = request.AudioBitRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioFormat))
            {
                body["AudioFormat"] = request.AudioFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioLanguage))
            {
                body["AudioLanguage"] = request.AudioLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioOutputEnabled))
            {
                body["AudioOutputEnabled"] = request.AudioOutputEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioOutputOssBucket))
            {
                body["AudioOutputOssBucket"] = request.AudioOutputOssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioOutputOssPath))
            {
                body["AudioOutputOssPath"] = request.AudioOutputOssPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioPackage))
            {
                body["AudioPackage"] = request.AudioPackage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioSampleRate))
            {
                body["AudioSampleRate"] = request.AudioSampleRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioSegmentsEnabled))
            {
                body["AudioSegmentsEnabled"] = request.AudioSegmentsEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocResultEnabled))
            {
                body["DocResultEnabled"] = request.DocResultEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabParams))
            {
                body["LabParams"] = request.LabParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeetingKey))
            {
                body["MeetingKey"] = request.MeetingKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeetingResultEnabled))
            {
                body["MeetingResultEnabled"] = request.MeetingResultEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeetingResultOssBucket))
            {
                body["MeetingResultOssBucket"] = request.MeetingResultOssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeetingResultOssPath))
            {
                body["MeetingResultOssPath"] = request.MeetingResultOssPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealtimeActiveResultLevel))
            {
                body["RealtimeActiveResultLevel"] = request.RealtimeActiveResultLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealtimeResultEnabled))
            {
                body["RealtimeResultEnabled"] = request.RealtimeResultEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealtimeResultLevel))
            {
                body["RealtimeResultLevel"] = request.RealtimeResultLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealtimeResultMeetingInfoEnabled))
            {
                body["RealtimeResultMeetingInfoEnabled"] = request.RealtimeResultMeetingInfoEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealtimeResultWordsEnabled))
            {
                body["RealtimeResultWordsEnabled"] = request.RealtimeResultWordsEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslateActiveResultLevel))
            {
                body["TranslateActiveResultLevel"] = request.TranslateActiveResultLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslateLanguages))
            {
                body["TranslateLanguages"] = request.TranslateLanguages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslateResultEnabled))
            {
                body["TranslateResultEnabled"] = request.TranslateResultEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslateResultLevel))
            {
                body["TranslateResultLevel"] = request.TranslateResultLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMeetingTrans",
                Version = "2022-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/meeting-trans",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMeetingTransResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateMeetingTransResponse> CreateMeetingTransWithOptionsAsync(CreateMeetingTransRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AbilityParams))
            {
                body["AbilityParams"] = request.AbilityParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrParams))
            {
                body["AsrParams"] = request.AsrParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioBitRate))
            {
                body["AudioBitRate"] = request.AudioBitRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioFormat))
            {
                body["AudioFormat"] = request.AudioFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioLanguage))
            {
                body["AudioLanguage"] = request.AudioLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioOutputEnabled))
            {
                body["AudioOutputEnabled"] = request.AudioOutputEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioOutputOssBucket))
            {
                body["AudioOutputOssBucket"] = request.AudioOutputOssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioOutputOssPath))
            {
                body["AudioOutputOssPath"] = request.AudioOutputOssPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioPackage))
            {
                body["AudioPackage"] = request.AudioPackage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioSampleRate))
            {
                body["AudioSampleRate"] = request.AudioSampleRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioSegmentsEnabled))
            {
                body["AudioSegmentsEnabled"] = request.AudioSegmentsEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocResultEnabled))
            {
                body["DocResultEnabled"] = request.DocResultEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabParams))
            {
                body["LabParams"] = request.LabParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeetingKey))
            {
                body["MeetingKey"] = request.MeetingKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeetingResultEnabled))
            {
                body["MeetingResultEnabled"] = request.MeetingResultEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeetingResultOssBucket))
            {
                body["MeetingResultOssBucket"] = request.MeetingResultOssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeetingResultOssPath))
            {
                body["MeetingResultOssPath"] = request.MeetingResultOssPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealtimeActiveResultLevel))
            {
                body["RealtimeActiveResultLevel"] = request.RealtimeActiveResultLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealtimeResultEnabled))
            {
                body["RealtimeResultEnabled"] = request.RealtimeResultEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealtimeResultLevel))
            {
                body["RealtimeResultLevel"] = request.RealtimeResultLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealtimeResultMeetingInfoEnabled))
            {
                body["RealtimeResultMeetingInfoEnabled"] = request.RealtimeResultMeetingInfoEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealtimeResultWordsEnabled))
            {
                body["RealtimeResultWordsEnabled"] = request.RealtimeResultWordsEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslateActiveResultLevel))
            {
                body["TranslateActiveResultLevel"] = request.TranslateActiveResultLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslateLanguages))
            {
                body["TranslateLanguages"] = request.TranslateLanguages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslateResultEnabled))
            {
                body["TranslateResultEnabled"] = request.TranslateResultEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslateResultLevel))
            {
                body["TranslateResultLevel"] = request.TranslateResultLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMeetingTrans",
                Version = "2022-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/meeting-trans",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMeetingTransResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateMeetingTransResponse CreateMeetingTrans(CreateMeetingTransRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMeetingTransWithOptions(request, headers, runtime);
        }

        public async Task<CreateMeetingTransResponse> CreateMeetingTransAsync(CreateMeetingTransRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMeetingTransWithOptionsAsync(request, headers, runtime);
        }

        public GetFileTransResponse GetFileTransWithOptions(string TransId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileTrans",
                Version = "2022-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/file-trans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TransId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileTransResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFileTransResponse> GetFileTransWithOptionsAsync(string TransId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileTrans",
                Version = "2022-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/file-trans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TransId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileTransResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFileTransResponse GetFileTrans(string TransId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFileTransWithOptions(TransId, headers, runtime);
        }

        public async Task<GetFileTransResponse> GetFileTransAsync(string TransId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFileTransWithOptionsAsync(TransId, headers, runtime);
        }

        public GetMeetingTransResponse GetMeetingTransWithOptions(string MeetingId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMeetingTrans",
                Version = "2022-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/meeting-trans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MeetingId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMeetingTransResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMeetingTransResponse> GetMeetingTransWithOptionsAsync(string MeetingId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMeetingTrans",
                Version = "2022-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/meeting-trans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MeetingId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMeetingTransResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMeetingTransResponse GetMeetingTrans(string MeetingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMeetingTransWithOptions(MeetingId, headers, runtime);
        }

        public async Task<GetMeetingTransResponse> GetMeetingTransAsync(string MeetingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMeetingTransWithOptionsAsync(MeetingId, headers, runtime);
        }

        public StopMeetingTransResponse StopMeetingTransWithOptions(string MeetingId, StopMeetingTransRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeetingRoleNum))
            {
                body["MeetingRoleNum"] = request.MeetingRoleNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyRoleSplitResult))
            {
                body["OnlyRoleSplitResult"] = request.OnlyRoleSplitResult;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopMeetingTrans",
                Version = "2022-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/meeting-trans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MeetingId) + "/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopMeetingTransResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopMeetingTransResponse> StopMeetingTransWithOptionsAsync(string MeetingId, StopMeetingTransRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeetingRoleNum))
            {
                body["MeetingRoleNum"] = request.MeetingRoleNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyRoleSplitResult))
            {
                body["OnlyRoleSplitResult"] = request.OnlyRoleSplitResult;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopMeetingTrans",
                Version = "2022-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/meeting-trans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MeetingId) + "/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopMeetingTransResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopMeetingTransResponse StopMeetingTrans(string MeetingId, StopMeetingTransRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopMeetingTransWithOptions(MeetingId, request, headers, runtime);
        }

        public async Task<StopMeetingTransResponse> StopMeetingTransAsync(string MeetingId, StopMeetingTransRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopMeetingTransWithOptionsAsync(MeetingId, request, headers, runtime);
        }

    }
}
