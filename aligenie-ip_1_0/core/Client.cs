// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AliGenieip_1_0.Models;

namespace AlibabaCloud.SDK.AliGenieip_1_0
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

        public AddCartoonResponse AddCartoonWithOptions(AddCartoonRequest request, AddCartoonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartVideoMd5))
            {
                body["StartVideoMd5"] = request.StartVideoMd5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartVideoUrl))
            {
                body["StartVideoUrl"] = request.StartVideoUrl;
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
                Action = "AddCartoon",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/addCartoon",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCartoonResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddCartoonResponse> AddCartoonWithOptionsAsync(AddCartoonRequest request, AddCartoonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartVideoMd5))
            {
                body["StartVideoMd5"] = request.StartVideoMd5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartVideoUrl))
            {
                body["StartVideoUrl"] = request.StartVideoUrl;
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
                Action = "AddCartoon",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/addCartoon",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCartoonResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddCartoonResponse AddCartoon(AddCartoonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCartoonHeaders headers = new AddCartoonHeaders();
            return AddCartoonWithOptions(request, headers, runtime);
        }

        public async Task<AddCartoonResponse> AddCartoonAsync(AddCartoonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCartoonHeaders headers = new AddCartoonHeaders();
            return await AddCartoonWithOptionsAsync(request, headers, runtime);
        }

        public AddCustomQAResponse AddCustomQAWithOptions(AddCustomQARequest tmpReq, AddCustomQAHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddCustomQAShrinkRequest request = new AddCustomQAShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Answers))
            {
                request.AnswersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Answers, "Answers", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.KeyWords))
            {
                request.KeyWordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.KeyWords, "KeyWords", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SupplementaryQuestions))
            {
                request.SupplementaryQuestionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SupplementaryQuestions, "SupplementaryQuestions", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnswersShrink))
            {
                body["Answers"] = request.AnswersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWordsShrink))
            {
                body["KeyWords"] = request.KeyWordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MajorQuestion))
            {
                body["MajorQuestion"] = request.MajorQuestion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplementaryQuestionsShrink))
            {
                body["SupplementaryQuestions"] = request.SupplementaryQuestionsShrink;
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
                Action = "AddCustomQA",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/addCustomQA",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCustomQAResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddCustomQAResponse> AddCustomQAWithOptionsAsync(AddCustomQARequest tmpReq, AddCustomQAHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddCustomQAShrinkRequest request = new AddCustomQAShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Answers))
            {
                request.AnswersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Answers, "Answers", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.KeyWords))
            {
                request.KeyWordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.KeyWords, "KeyWords", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SupplementaryQuestions))
            {
                request.SupplementaryQuestionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SupplementaryQuestions, "SupplementaryQuestions", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnswersShrink))
            {
                body["Answers"] = request.AnswersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWordsShrink))
            {
                body["KeyWords"] = request.KeyWordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MajorQuestion))
            {
                body["MajorQuestion"] = request.MajorQuestion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplementaryQuestionsShrink))
            {
                body["SupplementaryQuestions"] = request.SupplementaryQuestionsShrink;
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
                Action = "AddCustomQA",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/addCustomQA",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCustomQAResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddCustomQAResponse AddCustomQA(AddCustomQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCustomQAHeaders headers = new AddCustomQAHeaders();
            return AddCustomQAWithOptions(request, headers, runtime);
        }

        public async Task<AddCustomQAResponse> AddCustomQAAsync(AddCustomQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCustomQAHeaders headers = new AddCustomQAHeaders();
            return await AddCustomQAWithOptionsAsync(request, headers, runtime);
        }

        public AddMessageTemplateResponse AddMessageTemplateWithOptions(AddMessageTemplateRequest request, AddMessageTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateDetail))
            {
                body["TemplateDetail"] = request.TemplateDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
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
                Action = "AddMessageTemplate",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/addMessageTemplate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMessageTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddMessageTemplateResponse> AddMessageTemplateWithOptionsAsync(AddMessageTemplateRequest request, AddMessageTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateDetail))
            {
                body["TemplateDetail"] = request.TemplateDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
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
                Action = "AddMessageTemplate",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/addMessageTemplate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMessageTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddMessageTemplateResponse AddMessageTemplate(AddMessageTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddMessageTemplateHeaders headers = new AddMessageTemplateHeaders();
            return AddMessageTemplateWithOptions(request, headers, runtime);
        }

        public async Task<AddMessageTemplateResponse> AddMessageTemplateAsync(AddMessageTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddMessageTemplateHeaders headers = new AddMessageTemplateHeaders();
            return await AddMessageTemplateWithOptionsAsync(request, headers, runtime);
        }

        public AddOrUpdateDisPlayModesResponse AddOrUpdateDisPlayModesWithOptions(AddOrUpdateDisPlayModesRequest tmpReq, AddOrUpdateDisPlayModesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddOrUpdateDisPlayModesShrinkRequest request = new AddOrUpdateDisPlayModesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelDeviceModeList))
            {
                request.HotelDeviceModeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelDeviceModeList, "HotelDeviceModeList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelDeviceModeListShrink))
            {
                body["HotelDeviceModeList"] = request.HotelDeviceModeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "AddOrUpdateDisPlayModes",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/addOrUpdateDisPlayModes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOrUpdateDisPlayModesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddOrUpdateDisPlayModesResponse> AddOrUpdateDisPlayModesWithOptionsAsync(AddOrUpdateDisPlayModesRequest tmpReq, AddOrUpdateDisPlayModesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddOrUpdateDisPlayModesShrinkRequest request = new AddOrUpdateDisPlayModesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelDeviceModeList))
            {
                request.HotelDeviceModeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelDeviceModeList, "HotelDeviceModeList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelDeviceModeListShrink))
            {
                body["HotelDeviceModeList"] = request.HotelDeviceModeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "AddOrUpdateDisPlayModes",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/addOrUpdateDisPlayModes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOrUpdateDisPlayModesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddOrUpdateDisPlayModesResponse AddOrUpdateDisPlayModes(AddOrUpdateDisPlayModesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrUpdateDisPlayModesHeaders headers = new AddOrUpdateDisPlayModesHeaders();
            return AddOrUpdateDisPlayModesWithOptions(request, headers, runtime);
        }

        public async Task<AddOrUpdateDisPlayModesResponse> AddOrUpdateDisPlayModesAsync(AddOrUpdateDisPlayModesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrUpdateDisPlayModesHeaders headers = new AddOrUpdateDisPlayModesHeaders();
            return await AddOrUpdateDisPlayModesWithOptionsAsync(request, headers, runtime);
        }

        public AddOrUpdateHotelSettingResponse AddOrUpdateHotelSettingWithOptions(AddOrUpdateHotelSettingRequest tmpReq, AddOrUpdateHotelSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddOrUpdateHotelSettingShrinkRequest request = new AddOrUpdateHotelSettingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelDeviceModeList))
            {
                request.HotelDeviceModeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelDeviceModeList, "HotelDeviceModeList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelScreenSaver))
            {
                request.HotelScreenSaverShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelScreenSaver, "HotelScreenSaver", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NightMode))
            {
                request.NightModeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NightMode, "NightMode", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelDeviceModeListShrink))
            {
                body["HotelDeviceModeList"] = request.HotelDeviceModeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelScreenSaverShrink))
            {
                body["HotelScreenSaver"] = request.HotelScreenSaverShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NightModeShrink))
            {
                body["NightMode"] = request.NightModeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingType))
            {
                body["SettingType"] = request.SettingType;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddOrUpdateHotelSetting",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/addOrUpdateHotelSetting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOrUpdateHotelSettingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddOrUpdateHotelSettingResponse> AddOrUpdateHotelSettingWithOptionsAsync(AddOrUpdateHotelSettingRequest tmpReq, AddOrUpdateHotelSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddOrUpdateHotelSettingShrinkRequest request = new AddOrUpdateHotelSettingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelDeviceModeList))
            {
                request.HotelDeviceModeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelDeviceModeList, "HotelDeviceModeList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelScreenSaver))
            {
                request.HotelScreenSaverShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelScreenSaver, "HotelScreenSaver", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NightMode))
            {
                request.NightModeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NightMode, "NightMode", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelDeviceModeListShrink))
            {
                body["HotelDeviceModeList"] = request.HotelDeviceModeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelScreenSaverShrink))
            {
                body["HotelScreenSaver"] = request.HotelScreenSaverShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NightModeShrink))
            {
                body["NightMode"] = request.NightModeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingType))
            {
                body["SettingType"] = request.SettingType;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddOrUpdateHotelSetting",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/addOrUpdateHotelSetting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOrUpdateHotelSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddOrUpdateHotelSettingResponse AddOrUpdateHotelSetting(AddOrUpdateHotelSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrUpdateHotelSettingHeaders headers = new AddOrUpdateHotelSettingHeaders();
            return AddOrUpdateHotelSettingWithOptions(request, headers, runtime);
        }

        public async Task<AddOrUpdateHotelSettingResponse> AddOrUpdateHotelSettingAsync(AddOrUpdateHotelSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrUpdateHotelSettingHeaders headers = new AddOrUpdateHotelSettingHeaders();
            return await AddOrUpdateHotelSettingWithOptionsAsync(request, headers, runtime);
        }

        public AddOrUpdateScreenSaverResponse AddOrUpdateScreenSaverWithOptions(AddOrUpdateScreenSaverRequest tmpReq, AddOrUpdateScreenSaverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddOrUpdateScreenSaverShrinkRequest request = new AddOrUpdateScreenSaverShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelScreenSaver))
            {
                request.HotelScreenSaverShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelScreenSaver, "HotelScreenSaver", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelScreenSaverShrink))
            {
                body["HotelScreenSaver"] = request.HotelScreenSaverShrink;
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
                Action = "AddOrUpdateScreenSaver",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/addOrUpdateScreenSaver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOrUpdateScreenSaverResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddOrUpdateScreenSaverResponse> AddOrUpdateScreenSaverWithOptionsAsync(AddOrUpdateScreenSaverRequest tmpReq, AddOrUpdateScreenSaverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddOrUpdateScreenSaverShrinkRequest request = new AddOrUpdateScreenSaverShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelScreenSaver))
            {
                request.HotelScreenSaverShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelScreenSaver, "HotelScreenSaver", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelScreenSaverShrink))
            {
                body["HotelScreenSaver"] = request.HotelScreenSaverShrink;
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
                Action = "AddOrUpdateScreenSaver",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/addOrUpdateScreenSaver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOrUpdateScreenSaverResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddOrUpdateScreenSaverResponse AddOrUpdateScreenSaver(AddOrUpdateScreenSaverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrUpdateScreenSaverHeaders headers = new AddOrUpdateScreenSaverHeaders();
            return AddOrUpdateScreenSaverWithOptions(request, headers, runtime);
        }

        public async Task<AddOrUpdateScreenSaverResponse> AddOrUpdateScreenSaverAsync(AddOrUpdateScreenSaverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrUpdateScreenSaverHeaders headers = new AddOrUpdateScreenSaverHeaders();
            return await AddOrUpdateScreenSaverWithOptionsAsync(request, headers, runtime);
        }

        public AddOrUpdateWelcomeTextResponse AddOrUpdateWelcomeTextWithOptions(AddOrUpdateWelcomeTextRequest request, AddOrUpdateWelcomeTextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MusicUrl))
            {
                body["MusicUrl"] = request.MusicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WelcomeText))
            {
                body["WelcomeText"] = request.WelcomeText;
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
                Action = "AddOrUpdateWelcomeText",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/addOrUpdateWelcomeText",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOrUpdateWelcomeTextResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddOrUpdateWelcomeTextResponse> AddOrUpdateWelcomeTextWithOptionsAsync(AddOrUpdateWelcomeTextRequest request, AddOrUpdateWelcomeTextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MusicUrl))
            {
                body["MusicUrl"] = request.MusicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WelcomeText))
            {
                body["WelcomeText"] = request.WelcomeText;
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
                Action = "AddOrUpdateWelcomeText",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/addOrUpdateWelcomeText",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOrUpdateWelcomeTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddOrUpdateWelcomeTextResponse AddOrUpdateWelcomeText(AddOrUpdateWelcomeTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrUpdateWelcomeTextHeaders headers = new AddOrUpdateWelcomeTextHeaders();
            return AddOrUpdateWelcomeTextWithOptions(request, headers, runtime);
        }

        public async Task<AddOrUpdateWelcomeTextResponse> AddOrUpdateWelcomeTextAsync(AddOrUpdateWelcomeTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrUpdateWelcomeTextHeaders headers = new AddOrUpdateWelcomeTextHeaders();
            return await AddOrUpdateWelcomeTextWithOptionsAsync(request, headers, runtime);
        }

        public AuditHotelResponse AuditHotelWithOptions(AuditHotelRequest tmpReq, AuditHotelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AuditHotelShrinkRequest request = new AuditHotelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AuditHotelReq))
            {
                request.AuditHotelReqShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AuditHotelReq, "AuditHotelReq", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditHotelReqShrink))
            {
                query["AuditHotelReq"] = request.AuditHotelReqShrink;
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
                Action = "AuditHotel",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/auditHotel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuditHotelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AuditHotelResponse> AuditHotelWithOptionsAsync(AuditHotelRequest tmpReq, AuditHotelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AuditHotelShrinkRequest request = new AuditHotelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AuditHotelReq))
            {
                request.AuditHotelReqShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AuditHotelReq, "AuditHotelReq", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditHotelReqShrink))
            {
                query["AuditHotelReq"] = request.AuditHotelReqShrink;
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
                Action = "AuditHotel",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/auditHotel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuditHotelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AuditHotelResponse AuditHotel(AuditHotelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AuditHotelHeaders headers = new AuditHotelHeaders();
            return AuditHotelWithOptions(request, headers, runtime);
        }

        public async Task<AuditHotelResponse> AuditHotelAsync(AuditHotelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AuditHotelHeaders headers = new AuditHotelHeaders();
            return await AuditHotelWithOptionsAsync(request, headers, runtime);
        }

        public BatchAddHotelRoomResponse BatchAddHotelRoomWithOptions(BatchAddHotelRoomRequest tmpReq, BatchAddHotelRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchAddHotelRoomShrinkRequest request = new BatchAddHotelRoomShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoomNoList))
            {
                request.RoomNoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoomNoList, "RoomNoList", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNoListShrink))
            {
                body["RoomNoList"] = request.RoomNoListShrink;
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
                Action = "BatchAddHotelRoom",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/batchAddHotelRoom",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddHotelRoomResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchAddHotelRoomResponse> BatchAddHotelRoomWithOptionsAsync(BatchAddHotelRoomRequest tmpReq, BatchAddHotelRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchAddHotelRoomShrinkRequest request = new BatchAddHotelRoomShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoomNoList))
            {
                request.RoomNoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoomNoList, "RoomNoList", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNoListShrink))
            {
                body["RoomNoList"] = request.RoomNoListShrink;
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
                Action = "BatchAddHotelRoom",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/batchAddHotelRoom",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddHotelRoomResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchAddHotelRoomResponse BatchAddHotelRoom(BatchAddHotelRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchAddHotelRoomHeaders headers = new BatchAddHotelRoomHeaders();
            return BatchAddHotelRoomWithOptions(request, headers, runtime);
        }

        public async Task<BatchAddHotelRoomResponse> BatchAddHotelRoomAsync(BatchAddHotelRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchAddHotelRoomHeaders headers = new BatchAddHotelRoomHeaders();
            return await BatchAddHotelRoomWithOptionsAsync(request, headers, runtime);
        }

        public BatchDeleteHotelRoomResponse BatchDeleteHotelRoomWithOptions(BatchDeleteHotelRoomRequest tmpReq, BatchDeleteHotelRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchDeleteHotelRoomShrinkRequest request = new BatchDeleteHotelRoomShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoomNoList))
            {
                request.RoomNoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoomNoList, "RoomNoList", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNoListShrink))
            {
                body["RoomNoList"] = request.RoomNoListShrink;
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
                Action = "BatchDeleteHotelRoom",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/batchDeleteHotelRoom",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteHotelRoomResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchDeleteHotelRoomResponse> BatchDeleteHotelRoomWithOptionsAsync(BatchDeleteHotelRoomRequest tmpReq, BatchDeleteHotelRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchDeleteHotelRoomShrinkRequest request = new BatchDeleteHotelRoomShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoomNoList))
            {
                request.RoomNoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoomNoList, "RoomNoList", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNoListShrink))
            {
                body["RoomNoList"] = request.RoomNoListShrink;
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
                Action = "BatchDeleteHotelRoom",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/batchDeleteHotelRoom",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteHotelRoomResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchDeleteHotelRoomResponse BatchDeleteHotelRoom(BatchDeleteHotelRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchDeleteHotelRoomHeaders headers = new BatchDeleteHotelRoomHeaders();
            return BatchDeleteHotelRoomWithOptions(request, headers, runtime);
        }

        public async Task<BatchDeleteHotelRoomResponse> BatchDeleteHotelRoomAsync(BatchDeleteHotelRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchDeleteHotelRoomHeaders headers = new BatchDeleteHotelRoomHeaders();
            return await BatchDeleteHotelRoomWithOptionsAsync(request, headers, runtime);
        }

        public CheckoutWithAKResponse CheckoutWithAKWithOptions(CheckoutWithAKRequest request, CheckoutWithAKHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
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
                Action = "CheckoutWithAK",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/checkoutWithAK",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckoutWithAKResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckoutWithAKResponse> CheckoutWithAKWithOptionsAsync(CheckoutWithAKRequest request, CheckoutWithAKHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
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
                Action = "CheckoutWithAK",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/checkoutWithAK",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckoutWithAKResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckoutWithAKResponse CheckoutWithAK(CheckoutWithAKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckoutWithAKHeaders headers = new CheckoutWithAKHeaders();
            return CheckoutWithAKWithOptions(request, headers, runtime);
        }

        public async Task<CheckoutWithAKResponse> CheckoutWithAKAsync(CheckoutWithAKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckoutWithAKHeaders headers = new CheckoutWithAKHeaders();
            return await CheckoutWithAKWithOptionsAsync(request, headers, runtime);
        }

        public ChildAccountAuthResponse ChildAccountAuthWithOptions(ChildAccountAuthRequest request, ChildAccountAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbOpenId))
            {
                body["TbOpenId"] = request.TbOpenId;
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
                Action = "ChildAccountAuth",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/childAccountAuth",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChildAccountAuthResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ChildAccountAuthResponse> ChildAccountAuthWithOptionsAsync(ChildAccountAuthRequest request, ChildAccountAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbOpenId))
            {
                body["TbOpenId"] = request.TbOpenId;
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
                Action = "ChildAccountAuth",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/childAccountAuth",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChildAccountAuthResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ChildAccountAuthResponse ChildAccountAuth(ChildAccountAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChildAccountAuthHeaders headers = new ChildAccountAuthHeaders();
            return ChildAccountAuthWithOptions(request, headers, runtime);
        }

        public async Task<ChildAccountAuthResponse> ChildAccountAuthAsync(ChildAccountAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChildAccountAuthHeaders headers = new ChildAccountAuthHeaders();
            return await ChildAccountAuthWithOptionsAsync(request, headers, runtime);
        }

        public ControlRoomDeviceResponse ControlRoomDeviceWithOptions(ControlRoomDeviceRequest tmpReq, ControlRoomDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ControlRoomDeviceShrinkRequest request = new ControlRoomDeviceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Properties))
            {
                request.PropertiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Properties, "Properties", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cmd))
            {
                body["Cmd"] = request.Cmd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIndex))
            {
                body["DeviceIndex"] = request.DeviceIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceNumber))
            {
                body["DeviceNumber"] = request.DeviceNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertiesShrink))
            {
                body["Properties"] = request.PropertiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
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
                Action = "ControlRoomDevice",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/controlRoomDevice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ControlRoomDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ControlRoomDeviceResponse> ControlRoomDeviceWithOptionsAsync(ControlRoomDeviceRequest tmpReq, ControlRoomDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ControlRoomDeviceShrinkRequest request = new ControlRoomDeviceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Properties))
            {
                request.PropertiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Properties, "Properties", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cmd))
            {
                body["Cmd"] = request.Cmd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIndex))
            {
                body["DeviceIndex"] = request.DeviceIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceNumber))
            {
                body["DeviceNumber"] = request.DeviceNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertiesShrink))
            {
                body["Properties"] = request.PropertiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
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
                Action = "ControlRoomDevice",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/controlRoomDevice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ControlRoomDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ControlRoomDeviceResponse ControlRoomDevice(ControlRoomDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ControlRoomDeviceHeaders headers = new ControlRoomDeviceHeaders();
            return ControlRoomDeviceWithOptions(request, headers, runtime);
        }

        public async Task<ControlRoomDeviceResponse> ControlRoomDeviceAsync(ControlRoomDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ControlRoomDeviceHeaders headers = new ControlRoomDeviceHeaders();
            return await ControlRoomDeviceWithOptionsAsync(request, headers, runtime);
        }

        public CreateHotelResponse CreateHotelWithOptions(CreateHotelRequest tmpReq, CreateHotelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateHotelShrinkRequest request = new CreateHotelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RelatedPks))
            {
                request.RelatedPksShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RelatedPks, "RelatedPks", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EstOpenTime))
            {
                body["EstOpenTime"] = request.EstOpenTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelAddress))
            {
                body["HotelAddress"] = request.HotelAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelEmail))
            {
                body["HotelEmail"] = request.HotelEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelName))
            {
                body["HotelName"] = request.HotelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedPk))
            {
                body["RelatedPk"] = request.RelatedPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedPksShrink))
            {
                body["RelatedPks"] = request.RelatedPksShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNum))
            {
                body["RoomNum"] = request.RoomNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbOpenId))
            {
                body["TbOpenId"] = request.TbOpenId;
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
                Action = "CreateHotel",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/createHotel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHotelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateHotelResponse> CreateHotelWithOptionsAsync(CreateHotelRequest tmpReq, CreateHotelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateHotelShrinkRequest request = new CreateHotelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RelatedPks))
            {
                request.RelatedPksShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RelatedPks, "RelatedPks", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EstOpenTime))
            {
                body["EstOpenTime"] = request.EstOpenTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelAddress))
            {
                body["HotelAddress"] = request.HotelAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelEmail))
            {
                body["HotelEmail"] = request.HotelEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelName))
            {
                body["HotelName"] = request.HotelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedPk))
            {
                body["RelatedPk"] = request.RelatedPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedPksShrink))
            {
                body["RelatedPks"] = request.RelatedPksShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNum))
            {
                body["RoomNum"] = request.RoomNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbOpenId))
            {
                body["TbOpenId"] = request.TbOpenId;
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
                Action = "CreateHotel",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/createHotel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHotelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateHotelResponse CreateHotel(CreateHotelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateHotelHeaders headers = new CreateHotelHeaders();
            return CreateHotelWithOptions(request, headers, runtime);
        }

        public async Task<CreateHotelResponse> CreateHotelAsync(CreateHotelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateHotelHeaders headers = new CreateHotelHeaders();
            return await CreateHotelWithOptionsAsync(request, headers, runtime);
        }

        public CreateHotelAlarmResponse CreateHotelAlarmWithOptions(CreateHotelAlarmRequest tmpReq, CreateHotelAlarmHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateHotelAlarmShrinkRequest request = new CreateHotelAlarmShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rooms))
            {
                request.RoomsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rooms, "Rooms", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleInfo))
            {
                request.ScheduleInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleInfo, "ScheduleInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MusicType))
            {
                body["MusicType"] = request.MusicType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomsShrink))
            {
                body["Rooms"] = request.RoomsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleInfoShrink))
            {
                body["ScheduleInfo"] = request.ScheduleInfoShrink;
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
                Action = "CreateHotelAlarm",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/createHotelAlarm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHotelAlarmResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateHotelAlarmResponse> CreateHotelAlarmWithOptionsAsync(CreateHotelAlarmRequest tmpReq, CreateHotelAlarmHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateHotelAlarmShrinkRequest request = new CreateHotelAlarmShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rooms))
            {
                request.RoomsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rooms, "Rooms", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleInfo))
            {
                request.ScheduleInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleInfo, "ScheduleInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MusicType))
            {
                body["MusicType"] = request.MusicType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomsShrink))
            {
                body["Rooms"] = request.RoomsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleInfoShrink))
            {
                body["ScheduleInfo"] = request.ScheduleInfoShrink;
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
                Action = "CreateHotelAlarm",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/createHotelAlarm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHotelAlarmResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateHotelAlarmResponse CreateHotelAlarm(CreateHotelAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateHotelAlarmHeaders headers = new CreateHotelAlarmHeaders();
            return CreateHotelAlarmWithOptions(request, headers, runtime);
        }

        public async Task<CreateHotelAlarmResponse> CreateHotelAlarmAsync(CreateHotelAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateHotelAlarmHeaders headers = new CreateHotelAlarmHeaders();
            return await CreateHotelAlarmWithOptionsAsync(request, headers, runtime);
        }

        public CreateRcuSceneResponse CreateRcuSceneWithOptions(CreateRcuSceneRequest tmpReq, CreateRcuSceneHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateRcuSceneShrinkRequest request = new CreateRcuSceneShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SceneRelationExtDTO))
            {
                request.SceneRelationExtDTOShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SceneRelationExtDTO, "SceneRelationExtDTO", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneRelationExtDTOShrink))
            {
                body["SceneRelationExtDTO"] = request.SceneRelationExtDTOShrink;
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
                Action = "CreateRcuScene",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/createRcuScene",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRcuSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateRcuSceneResponse> CreateRcuSceneWithOptionsAsync(CreateRcuSceneRequest tmpReq, CreateRcuSceneHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateRcuSceneShrinkRequest request = new CreateRcuSceneShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SceneRelationExtDTO))
            {
                request.SceneRelationExtDTOShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SceneRelationExtDTO, "SceneRelationExtDTO", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneRelationExtDTOShrink))
            {
                body["SceneRelationExtDTO"] = request.SceneRelationExtDTOShrink;
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
                Action = "CreateRcuScene",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/createRcuScene",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRcuSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateRcuSceneResponse CreateRcuScene(CreateRcuSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateRcuSceneHeaders headers = new CreateRcuSceneHeaders();
            return CreateRcuSceneWithOptions(request, headers, runtime);
        }

        public async Task<CreateRcuSceneResponse> CreateRcuSceneAsync(CreateRcuSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateRcuSceneHeaders headers = new CreateRcuSceneHeaders();
            return await CreateRcuSceneWithOptionsAsync(request, headers, runtime);
        }

        public DeleteCartoonResponse DeleteCartoonWithOptions(DeleteCartoonRequest request, DeleteCartoonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "DeleteCartoon",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/deleteCartoon",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCartoonResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteCartoonResponse> DeleteCartoonWithOptionsAsync(DeleteCartoonRequest request, DeleteCartoonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "DeleteCartoon",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/deleteCartoon",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCartoonResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteCartoonResponse DeleteCartoon(DeleteCartoonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCartoonHeaders headers = new DeleteCartoonHeaders();
            return DeleteCartoonWithOptions(request, headers, runtime);
        }

        public async Task<DeleteCartoonResponse> DeleteCartoonAsync(DeleteCartoonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCartoonHeaders headers = new DeleteCartoonHeaders();
            return await DeleteCartoonWithOptionsAsync(request, headers, runtime);
        }

        public DeleteCustomQAResponse DeleteCustomQAWithOptions(DeleteCustomQARequest tmpReq, DeleteCustomQAHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteCustomQAShrinkRequest request = new DeleteCustomQAShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomQAIds))
            {
                request.CustomQAIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomQAIds, "CustomQAIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomQAIdsShrink))
            {
                body["CustomQAIds"] = request.CustomQAIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "DeleteCustomQA",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/deleteCustomQA",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomQAResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteCustomQAResponse> DeleteCustomQAWithOptionsAsync(DeleteCustomQARequest tmpReq, DeleteCustomQAHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteCustomQAShrinkRequest request = new DeleteCustomQAShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomQAIds))
            {
                request.CustomQAIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomQAIds, "CustomQAIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomQAIdsShrink))
            {
                body["CustomQAIds"] = request.CustomQAIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "DeleteCustomQA",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/deleteCustomQA",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomQAResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteCustomQAResponse DeleteCustomQA(DeleteCustomQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCustomQAHeaders headers = new DeleteCustomQAHeaders();
            return DeleteCustomQAWithOptions(request, headers, runtime);
        }

        public async Task<DeleteCustomQAResponse> DeleteCustomQAAsync(DeleteCustomQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCustomQAHeaders headers = new DeleteCustomQAHeaders();
            return await DeleteCustomQAWithOptionsAsync(request, headers, runtime);
        }

        public DeleteHotelAlarmResponse DeleteHotelAlarmWithOptions(DeleteHotelAlarmRequest tmpReq, DeleteHotelAlarmHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteHotelAlarmShrinkRequest request = new DeleteHotelAlarmShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Alarms))
            {
                request.AlarmsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Alarms, "Alarms", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmsShrink))
            {
                body["Alarms"] = request.AlarmsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "DeleteHotelAlarm",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/deleteHotelAlarm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHotelAlarmResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteHotelAlarmResponse> DeleteHotelAlarmWithOptionsAsync(DeleteHotelAlarmRequest tmpReq, DeleteHotelAlarmHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteHotelAlarmShrinkRequest request = new DeleteHotelAlarmShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Alarms))
            {
                request.AlarmsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Alarms, "Alarms", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmsShrink))
            {
                body["Alarms"] = request.AlarmsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "DeleteHotelAlarm",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/deleteHotelAlarm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHotelAlarmResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteHotelAlarmResponse DeleteHotelAlarm(DeleteHotelAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteHotelAlarmHeaders headers = new DeleteHotelAlarmHeaders();
            return DeleteHotelAlarmWithOptions(request, headers, runtime);
        }

        public async Task<DeleteHotelAlarmResponse> DeleteHotelAlarmAsync(DeleteHotelAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteHotelAlarmHeaders headers = new DeleteHotelAlarmHeaders();
            return await DeleteHotelAlarmWithOptionsAsync(request, headers, runtime);
        }

        public DeleteHotelSceneBookItemResponse DeleteHotelSceneBookItemWithOptions(DeleteHotelSceneBookItemRequest request, DeleteHotelSceneBookItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
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
                Action = "DeleteHotelSceneBookItem",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/deleteHotelSceneBookItem",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHotelSceneBookItemResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteHotelSceneBookItemResponse> DeleteHotelSceneBookItemWithOptionsAsync(DeleteHotelSceneBookItemRequest request, DeleteHotelSceneBookItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
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
                Action = "DeleteHotelSceneBookItem",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/deleteHotelSceneBookItem",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHotelSceneBookItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteHotelSceneBookItemResponse DeleteHotelSceneBookItem(DeleteHotelSceneBookItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteHotelSceneBookItemHeaders headers = new DeleteHotelSceneBookItemHeaders();
            return DeleteHotelSceneBookItemWithOptions(request, headers, runtime);
        }

        public async Task<DeleteHotelSceneBookItemResponse> DeleteHotelSceneBookItemAsync(DeleteHotelSceneBookItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteHotelSceneBookItemHeaders headers = new DeleteHotelSceneBookItemHeaders();
            return await DeleteHotelSceneBookItemWithOptionsAsync(request, headers, runtime);
        }

        public DeleteHotelSettingResponse DeleteHotelSettingWithOptions(DeleteHotelSettingRequest request, DeleteHotelSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingType))
            {
                body["SettingType"] = request.SettingType;
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
                Action = "DeleteHotelSetting",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/deleteHotelSetting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHotelSettingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteHotelSettingResponse> DeleteHotelSettingWithOptionsAsync(DeleteHotelSettingRequest request, DeleteHotelSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingType))
            {
                body["SettingType"] = request.SettingType;
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
                Action = "DeleteHotelSetting",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/deleteHotelSetting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHotelSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteHotelSettingResponse DeleteHotelSetting(DeleteHotelSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteHotelSettingHeaders headers = new DeleteHotelSettingHeaders();
            return DeleteHotelSettingWithOptions(request, headers, runtime);
        }

        public async Task<DeleteHotelSettingResponse> DeleteHotelSettingAsync(DeleteHotelSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteHotelSettingHeaders headers = new DeleteHotelSettingHeaders();
            return await DeleteHotelSettingWithOptionsAsync(request, headers, runtime);
        }

        public DeleteMessageTemplateResponse DeleteMessageTemplateWithOptions(DeleteMessageTemplateRequest request, DeleteMessageTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
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
                Action = "DeleteMessageTemplate",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/deleteMessageTemplate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMessageTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteMessageTemplateResponse> DeleteMessageTemplateWithOptionsAsync(DeleteMessageTemplateRequest request, DeleteMessageTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
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
                Action = "DeleteMessageTemplate",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/deleteMessageTemplate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMessageTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteMessageTemplateResponse DeleteMessageTemplate(DeleteMessageTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMessageTemplateHeaders headers = new DeleteMessageTemplateHeaders();
            return DeleteMessageTemplateWithOptions(request, headers, runtime);
        }

        public async Task<DeleteMessageTemplateResponse> DeleteMessageTemplateAsync(DeleteMessageTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMessageTemplateHeaders headers = new DeleteMessageTemplateHeaders();
            return await DeleteMessageTemplateWithOptionsAsync(request, headers, runtime);
        }

        public DeleteRcuSceneResponse DeleteRcuSceneWithOptions(DeleteRcuSceneRequest request, DeleteRcuSceneHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
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
                Action = "DeleteRcuScene",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/deleteRcuScene",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRcuSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRcuSceneResponse> DeleteRcuSceneWithOptionsAsync(DeleteRcuSceneRequest request, DeleteRcuSceneHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
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
                Action = "DeleteRcuScene",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/deleteRcuScene",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRcuSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRcuSceneResponse DeleteRcuScene(DeleteRcuSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRcuSceneHeaders headers = new DeleteRcuSceneHeaders();
            return DeleteRcuSceneWithOptions(request, headers, runtime);
        }

        public async Task<DeleteRcuSceneResponse> DeleteRcuSceneAsync(DeleteRcuSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRcuSceneHeaders headers = new DeleteRcuSceneHeaders();
            return await DeleteRcuSceneWithOptionsAsync(request, headers, runtime);
        }

        public DeviceControlResponse DeviceControlWithOptions(DeviceControlRequest tmpReq, DeviceControlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeviceControlShrinkRequest request = new DeviceControlShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
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
                Action = "DeviceControl",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/deviceControl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeviceControlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeviceControlResponse> DeviceControlWithOptionsAsync(DeviceControlRequest tmpReq, DeviceControlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeviceControlShrinkRequest request = new DeviceControlShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
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
                Action = "DeviceControl",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/deviceControl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeviceControlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeviceControlResponse DeviceControl(DeviceControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeviceControlHeaders headers = new DeviceControlHeaders();
            return DeviceControlWithOptions(request, headers, runtime);
        }

        public async Task<DeviceControlResponse> DeviceControlAsync(DeviceControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeviceControlHeaders headers = new DeviceControlHeaders();
            return await DeviceControlWithOptionsAsync(request, headers, runtime);
        }

        public GetBasicInfoQAResponse GetBasicInfoQAWithOptions(GetBasicInfoQARequest request, GetBasicInfoQAHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "GetBasicInfoQA",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getBasicInfoQA",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBasicInfoQAResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetBasicInfoQAResponse> GetBasicInfoQAWithOptionsAsync(GetBasicInfoQARequest request, GetBasicInfoQAHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "GetBasicInfoQA",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getBasicInfoQA",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBasicInfoQAResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetBasicInfoQAResponse GetBasicInfoQA(GetBasicInfoQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBasicInfoQAHeaders headers = new GetBasicInfoQAHeaders();
            return GetBasicInfoQAWithOptions(request, headers, runtime);
        }

        public async Task<GetBasicInfoQAResponse> GetBasicInfoQAAsync(GetBasicInfoQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBasicInfoQAHeaders headers = new GetBasicInfoQAHeaders();
            return await GetBasicInfoQAWithOptionsAsync(request, headers, runtime);
        }

        public GetCartoonResponse GetCartoonWithOptions(GetCartoonRequest request, GetCartoonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "GetCartoon",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getCartoon",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCartoonResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCartoonResponse> GetCartoonWithOptionsAsync(GetCartoonRequest request, GetCartoonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "GetCartoon",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getCartoon",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCartoonResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCartoonResponse GetCartoon(GetCartoonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCartoonHeaders headers = new GetCartoonHeaders();
            return GetCartoonWithOptions(request, headers, runtime);
        }

        public async Task<GetCartoonResponse> GetCartoonAsync(GetCartoonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCartoonHeaders headers = new GetCartoonHeaders();
            return await GetCartoonWithOptionsAsync(request, headers, runtime);
        }

        public GetHotelContactByGenieDeviceResponse GetHotelContactByGenieDeviceWithOptions(GetHotelContactByGenieDeviceRequest tmpReq, GetHotelContactByGenieDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotelContactByGenieDeviceShrinkRequest request = new GetHotelContactByGenieDeviceShrinkRequest();
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
                Action = "GetHotelContactByGenieDevice",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelContactByGenieDevice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelContactByGenieDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHotelContactByGenieDeviceResponse> GetHotelContactByGenieDeviceWithOptionsAsync(GetHotelContactByGenieDeviceRequest tmpReq, GetHotelContactByGenieDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotelContactByGenieDeviceShrinkRequest request = new GetHotelContactByGenieDeviceShrinkRequest();
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
                Action = "GetHotelContactByGenieDevice",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelContactByGenieDevice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelContactByGenieDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHotelContactByGenieDeviceResponse GetHotelContactByGenieDevice(GetHotelContactByGenieDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelContactByGenieDeviceHeaders headers = new GetHotelContactByGenieDeviceHeaders();
            return GetHotelContactByGenieDeviceWithOptions(request, headers, runtime);
        }

        public async Task<GetHotelContactByGenieDeviceResponse> GetHotelContactByGenieDeviceAsync(GetHotelContactByGenieDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelContactByGenieDeviceHeaders headers = new GetHotelContactByGenieDeviceHeaders();
            return await GetHotelContactByGenieDeviceWithOptionsAsync(request, headers, runtime);
        }

        public GetHotelContactByNumberResponse GetHotelContactByNumberWithOptions(GetHotelContactByNumberRequest tmpReq, GetHotelContactByNumberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotelContactByNumberShrinkRequest request = new GetHotelContactByNumberShrinkRequest();
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                body["Number"] = request.Number;
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
                Action = "GetHotelContactByNumber",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelContactByNumber",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelContactByNumberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHotelContactByNumberResponse> GetHotelContactByNumberWithOptionsAsync(GetHotelContactByNumberRequest tmpReq, GetHotelContactByNumberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotelContactByNumberShrinkRequest request = new GetHotelContactByNumberShrinkRequest();
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                body["Number"] = request.Number;
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
                Action = "GetHotelContactByNumber",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelContactByNumber",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelContactByNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHotelContactByNumberResponse GetHotelContactByNumber(GetHotelContactByNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelContactByNumberHeaders headers = new GetHotelContactByNumberHeaders();
            return GetHotelContactByNumberWithOptions(request, headers, runtime);
        }

        public async Task<GetHotelContactByNumberResponse> GetHotelContactByNumberAsync(GetHotelContactByNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelContactByNumberHeaders headers = new GetHotelContactByNumberHeaders();
            return await GetHotelContactByNumberWithOptionsAsync(request, headers, runtime);
        }

        public GetHotelContactsResponse GetHotelContactsWithOptions(GetHotelContactsRequest tmpReq, GetHotelContactsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotelContactsShrinkRequest request = new GetHotelContactsShrinkRequest();
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
                Action = "GetHotelContacts",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelContacts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelContactsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHotelContactsResponse> GetHotelContactsWithOptionsAsync(GetHotelContactsRequest tmpReq, GetHotelContactsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotelContactsShrinkRequest request = new GetHotelContactsShrinkRequest();
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
                Action = "GetHotelContacts",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelContacts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelContactsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHotelContactsResponse GetHotelContacts(GetHotelContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelContactsHeaders headers = new GetHotelContactsHeaders();
            return GetHotelContactsWithOptions(request, headers, runtime);
        }

        public async Task<GetHotelContactsResponse> GetHotelContactsAsync(GetHotelContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelContactsHeaders headers = new GetHotelContactsHeaders();
            return await GetHotelContactsWithOptionsAsync(request, headers, runtime);
        }

        public GetHotelHomeBackImageAndModesResponse GetHotelHomeBackImageAndModesWithOptions(GetHotelHomeBackImageAndModesRequest tmpReq, GetHotelHomeBackImageAndModesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotelHomeBackImageAndModesShrinkRequest request = new GetHotelHomeBackImageAndModesShrinkRequest();
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
                Action = "GetHotelHomeBackImageAndModes",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelHomeBackImageAndModes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelHomeBackImageAndModesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHotelHomeBackImageAndModesResponse> GetHotelHomeBackImageAndModesWithOptionsAsync(GetHotelHomeBackImageAndModesRequest tmpReq, GetHotelHomeBackImageAndModesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotelHomeBackImageAndModesShrinkRequest request = new GetHotelHomeBackImageAndModesShrinkRequest();
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
                Action = "GetHotelHomeBackImageAndModes",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelHomeBackImageAndModes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelHomeBackImageAndModesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHotelHomeBackImageAndModesResponse GetHotelHomeBackImageAndModes(GetHotelHomeBackImageAndModesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelHomeBackImageAndModesHeaders headers = new GetHotelHomeBackImageAndModesHeaders();
            return GetHotelHomeBackImageAndModesWithOptions(request, headers, runtime);
        }

        public async Task<GetHotelHomeBackImageAndModesResponse> GetHotelHomeBackImageAndModesAsync(GetHotelHomeBackImageAndModesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelHomeBackImageAndModesHeaders headers = new GetHotelHomeBackImageAndModesHeaders();
            return await GetHotelHomeBackImageAndModesWithOptionsAsync(request, headers, runtime);
        }

        public GetHotelNoticeResponse GetHotelNoticeWithOptions(GetHotelNoticeRequest tmpReq, GetHotelNoticeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotelNoticeShrinkRequest request = new GetHotelNoticeShrinkRequest();
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
                Action = "GetHotelNotice",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelNotice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelNoticeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHotelNoticeResponse> GetHotelNoticeWithOptionsAsync(GetHotelNoticeRequest tmpReq, GetHotelNoticeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotelNoticeShrinkRequest request = new GetHotelNoticeShrinkRequest();
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
                Action = "GetHotelNotice",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelNotice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelNoticeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHotelNoticeResponse GetHotelNotice(GetHotelNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelNoticeHeaders headers = new GetHotelNoticeHeaders();
            return GetHotelNoticeWithOptions(request, headers, runtime);
        }

        public async Task<GetHotelNoticeResponse> GetHotelNoticeAsync(GetHotelNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelNoticeHeaders headers = new GetHotelNoticeHeaders();
            return await GetHotelNoticeWithOptionsAsync(request, headers, runtime);
        }

        public GetHotelNoticeV2Response GetHotelNoticeV2WithOptions(GetHotelNoticeV2Request tmpReq, GetHotelNoticeV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotelNoticeV2ShrinkRequest request = new GetHotelNoticeV2ShrinkRequest();
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
                Action = "GetHotelNoticeV2",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelNoticeV2",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelNoticeV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<GetHotelNoticeV2Response> GetHotelNoticeV2WithOptionsAsync(GetHotelNoticeV2Request tmpReq, GetHotelNoticeV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotelNoticeV2ShrinkRequest request = new GetHotelNoticeV2ShrinkRequest();
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
                Action = "GetHotelNoticeV2",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelNoticeV2",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelNoticeV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public GetHotelNoticeV2Response GetHotelNoticeV2(GetHotelNoticeV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelNoticeV2Headers headers = new GetHotelNoticeV2Headers();
            return GetHotelNoticeV2WithOptions(request, headers, runtime);
        }

        public async Task<GetHotelNoticeV2Response> GetHotelNoticeV2Async(GetHotelNoticeV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelNoticeV2Headers headers = new GetHotelNoticeV2Headers();
            return await GetHotelNoticeV2WithOptionsAsync(request, headers, runtime);
        }

        public GetHotelOrderDetailResponse GetHotelOrderDetailWithOptions(GetHotelOrderDetailRequest tmpReq, GetHotelOrderDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotelOrderDetailShrinkRequest request = new GetHotelOrderDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
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
                Action = "GetHotelOrderDetail",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelOrderDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelOrderDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHotelOrderDetailResponse> GetHotelOrderDetailWithOptionsAsync(GetHotelOrderDetailRequest tmpReq, GetHotelOrderDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotelOrderDetailShrinkRequest request = new GetHotelOrderDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
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
                Action = "GetHotelOrderDetail",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelOrderDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelOrderDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHotelOrderDetailResponse GetHotelOrderDetail(GetHotelOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelOrderDetailHeaders headers = new GetHotelOrderDetailHeaders();
            return GetHotelOrderDetailWithOptions(request, headers, runtime);
        }

        public async Task<GetHotelOrderDetailResponse> GetHotelOrderDetailAsync(GetHotelOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelOrderDetailHeaders headers = new GetHotelOrderDetailHeaders();
            return await GetHotelOrderDetailWithOptionsAsync(request, headers, runtime);
        }

        public GetHotelRoomDeviceResponse GetHotelRoomDeviceWithOptions(GetHotelRoomDeviceRequest request, GetHotelRoomDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                query["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                query["RoomNo"] = request.RoomNo;
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
                Action = "GetHotelRoomDevice",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelRoomDevice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelRoomDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHotelRoomDeviceResponse> GetHotelRoomDeviceWithOptionsAsync(GetHotelRoomDeviceRequest request, GetHotelRoomDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                query["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                query["RoomNo"] = request.RoomNo;
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
                Action = "GetHotelRoomDevice",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelRoomDevice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelRoomDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHotelRoomDeviceResponse GetHotelRoomDevice(GetHotelRoomDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelRoomDeviceHeaders headers = new GetHotelRoomDeviceHeaders();
            return GetHotelRoomDeviceWithOptions(request, headers, runtime);
        }

        public async Task<GetHotelRoomDeviceResponse> GetHotelRoomDeviceAsync(GetHotelRoomDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelRoomDeviceHeaders headers = new GetHotelRoomDeviceHeaders();
            return await GetHotelRoomDeviceWithOptionsAsync(request, headers, runtime);
        }

        public GetHotelSampleUtterancesResponse GetHotelSampleUtterancesWithOptions(GetHotelSampleUtterancesRequest tmpReq, GetHotelSampleUtterancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotelSampleUtterancesShrinkRequest request = new GetHotelSampleUtterancesShrinkRequest();
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
                Action = "GetHotelSampleUtterances",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelSampleUtterances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelSampleUtterancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHotelSampleUtterancesResponse> GetHotelSampleUtterancesWithOptionsAsync(GetHotelSampleUtterancesRequest tmpReq, GetHotelSampleUtterancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotelSampleUtterancesShrinkRequest request = new GetHotelSampleUtterancesShrinkRequest();
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
                Action = "GetHotelSampleUtterances",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelSampleUtterances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelSampleUtterancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHotelSampleUtterancesResponse GetHotelSampleUtterances(GetHotelSampleUtterancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelSampleUtterancesHeaders headers = new GetHotelSampleUtterancesHeaders();
            return GetHotelSampleUtterancesWithOptions(request, headers, runtime);
        }

        public async Task<GetHotelSampleUtterancesResponse> GetHotelSampleUtterancesAsync(GetHotelSampleUtterancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelSampleUtterancesHeaders headers = new GetHotelSampleUtterancesHeaders();
            return await GetHotelSampleUtterancesWithOptionsAsync(request, headers, runtime);
        }

        public GetHotelSceneItemDetailResponse GetHotelSceneItemDetailWithOptions(GetHotelSceneItemDetailRequest request, GetHotelSceneItemDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                body["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
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
                Action = "GetHotelSceneItemDetail",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelSceneItemDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelSceneItemDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHotelSceneItemDetailResponse> GetHotelSceneItemDetailWithOptionsAsync(GetHotelSceneItemDetailRequest request, GetHotelSceneItemDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                body["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
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
                Action = "GetHotelSceneItemDetail",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelSceneItemDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelSceneItemDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHotelSceneItemDetailResponse GetHotelSceneItemDetail(GetHotelSceneItemDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelSceneItemDetailHeaders headers = new GetHotelSceneItemDetailHeaders();
            return GetHotelSceneItemDetailWithOptions(request, headers, runtime);
        }

        public async Task<GetHotelSceneItemDetailResponse> GetHotelSceneItemDetailAsync(GetHotelSceneItemDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelSceneItemDetailHeaders headers = new GetHotelSceneItemDetailHeaders();
            return await GetHotelSceneItemDetailWithOptionsAsync(request, headers, runtime);
        }

        public GetHotelScreenSaverResponse GetHotelScreenSaverWithOptions(GetHotelScreenSaverRequest tmpReq, GetHotelScreenSaverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotelScreenSaverShrinkRequest request = new GetHotelScreenSaverShrinkRequest();
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
                Action = "GetHotelScreenSaver",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelScreenSaver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelScreenSaverResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHotelScreenSaverResponse> GetHotelScreenSaverWithOptionsAsync(GetHotelScreenSaverRequest tmpReq, GetHotelScreenSaverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotelScreenSaverShrinkRequest request = new GetHotelScreenSaverShrinkRequest();
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
                Action = "GetHotelScreenSaver",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelScreenSaver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelScreenSaverResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHotelScreenSaverResponse GetHotelScreenSaver(GetHotelScreenSaverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelScreenSaverHeaders headers = new GetHotelScreenSaverHeaders();
            return GetHotelScreenSaverWithOptions(request, headers, runtime);
        }

        public async Task<GetHotelScreenSaverResponse> GetHotelScreenSaverAsync(GetHotelScreenSaverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelScreenSaverHeaders headers = new GetHotelScreenSaverHeaders();
            return await GetHotelScreenSaverWithOptionsAsync(request, headers, runtime);
        }

        public GetHotelScreenSaverStyleResponse GetHotelScreenSaverStyleWithOptions(GetHotelScreenSaverStyleRequest request, GetHotelScreenSaverStyleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "GetHotelScreenSaverStyle",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelScreenSaverStyle",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelScreenSaverStyleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHotelScreenSaverStyleResponse> GetHotelScreenSaverStyleWithOptionsAsync(GetHotelScreenSaverStyleRequest request, GetHotelScreenSaverStyleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "GetHotelScreenSaverStyle",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelScreenSaverStyle",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelScreenSaverStyleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHotelScreenSaverStyleResponse GetHotelScreenSaverStyle(GetHotelScreenSaverStyleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelScreenSaverStyleHeaders headers = new GetHotelScreenSaverStyleHeaders();
            return GetHotelScreenSaverStyleWithOptions(request, headers, runtime);
        }

        public async Task<GetHotelScreenSaverStyleResponse> GetHotelScreenSaverStyleAsync(GetHotelScreenSaverStyleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelScreenSaverStyleHeaders headers = new GetHotelScreenSaverStyleHeaders();
            return await GetHotelScreenSaverStyleWithOptionsAsync(request, headers, runtime);
        }

        public GetHotelSettingResponse GetHotelSettingWithOptions(GetHotelSettingRequest request, GetHotelSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingType))
            {
                body["SettingType"] = request.SettingType;
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
                Action = "GetHotelSetting",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelSetting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelSettingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHotelSettingResponse> GetHotelSettingWithOptionsAsync(GetHotelSettingRequest request, GetHotelSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingType))
            {
                body["SettingType"] = request.SettingType;
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
                Action = "GetHotelSetting",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelSetting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHotelSettingResponse GetHotelSetting(GetHotelSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelSettingHeaders headers = new GetHotelSettingHeaders();
            return GetHotelSettingWithOptions(request, headers, runtime);
        }

        public async Task<GetHotelSettingResponse> GetHotelSettingAsync(GetHotelSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelSettingHeaders headers = new GetHotelSettingHeaders();
            return await GetHotelSettingWithOptionsAsync(request, headers, runtime);
        }

        public GetRelationProductListResponse GetRelationProductListWithOptions(GetRelationProductListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRelationProductList",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getRelationProductList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRelationProductListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRelationProductListResponse> GetRelationProductListWithOptionsAsync(GetRelationProductListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRelationProductList",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getRelationProductList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRelationProductListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRelationProductListResponse GetRelationProductList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRelationProductListHeaders headers = new GetRelationProductListHeaders();
            return GetRelationProductListWithOptions(headers, runtime);
        }

        public async Task<GetRelationProductListResponse> GetRelationProductListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRelationProductListHeaders headers = new GetRelationProductListHeaders();
            return await GetRelationProductListWithOptionsAsync(headers, runtime);
        }

        public GetUnionIdResponse GetUnionIdWithOptions(GetUnionIdRequest request, GetUnionIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdType))
            {
                body["IdType"] = request.IdType;
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
                Action = "GetUnionId",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getUnionId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUnionIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUnionIdResponse> GetUnionIdWithOptionsAsync(GetUnionIdRequest request, GetUnionIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdType))
            {
                body["IdType"] = request.IdType;
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
                Action = "GetUnionId",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getUnionId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUnionIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUnionIdResponse GetUnionId(GetUnionIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUnionIdHeaders headers = new GetUnionIdHeaders();
            return GetUnionIdWithOptions(request, headers, runtime);
        }

        public async Task<GetUnionIdResponse> GetUnionIdAsync(GetUnionIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUnionIdHeaders headers = new GetUnionIdHeaders();
            return await GetUnionIdWithOptionsAsync(request, headers, runtime);
        }

        public GetWelcomeTextAndMusicResponse GetWelcomeTextAndMusicWithOptions(GetWelcomeTextAndMusicRequest request, GetWelcomeTextAndMusicHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "GetWelcomeTextAndMusic",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getWelcomeTextAndMusic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWelcomeTextAndMusicResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetWelcomeTextAndMusicResponse> GetWelcomeTextAndMusicWithOptionsAsync(GetWelcomeTextAndMusicRequest request, GetWelcomeTextAndMusicHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "GetWelcomeTextAndMusic",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getWelcomeTextAndMusic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWelcomeTextAndMusicResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetWelcomeTextAndMusicResponse GetWelcomeTextAndMusic(GetWelcomeTextAndMusicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWelcomeTextAndMusicHeaders headers = new GetWelcomeTextAndMusicHeaders();
            return GetWelcomeTextAndMusicWithOptions(request, headers, runtime);
        }

        public async Task<GetWelcomeTextAndMusicResponse> GetWelcomeTextAndMusicAsync(GetWelcomeTextAndMusicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWelcomeTextAndMusicHeaders headers = new GetWelcomeTextAndMusicHeaders();
            return await GetWelcomeTextAndMusicWithOptionsAsync(request, headers, runtime);
        }

        public HotelQrBindResponse HotelQrBindWithOptions(HotelQrBindRequest request, HotelQrBindHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
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
                Action = "HotelQrBind",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/hotelQrBind",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelQrBindResponse>(CallApi(params_, req, runtime));
        }

        public async Task<HotelQrBindResponse> HotelQrBindWithOptionsAsync(HotelQrBindRequest request, HotelQrBindHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
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
                Action = "HotelQrBind",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/hotelQrBind",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotelQrBindResponse>(await CallApiAsync(params_, req, runtime));
        }

        public HotelQrBindResponse HotelQrBind(HotelQrBindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelQrBindHeaders headers = new HotelQrBindHeaders();
            return HotelQrBindWithOptions(request, headers, runtime);
        }

        public async Task<HotelQrBindResponse> HotelQrBindAsync(HotelQrBindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelQrBindHeaders headers = new HotelQrBindHeaders();
            return await HotelQrBindWithOptionsAsync(request, headers, runtime);
        }

        public ImportHotelConfigResponse ImportHotelConfigWithOptions(ImportHotelConfigRequest tmpReq, ImportHotelConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportHotelConfigShrinkRequest request = new ImportHotelConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImportHotelConfig))
            {
                request.ImportHotelConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImportHotelConfig, "ImportHotelConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportHotelConfigShrink))
            {
                body["ImportHotelConfig"] = request.ImportHotelConfigShrink;
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
                Action = "ImportHotelConfig",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/importHotelConfig",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportHotelConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ImportHotelConfigResponse> ImportHotelConfigWithOptionsAsync(ImportHotelConfigRequest tmpReq, ImportHotelConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportHotelConfigShrinkRequest request = new ImportHotelConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImportHotelConfig))
            {
                request.ImportHotelConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImportHotelConfig, "ImportHotelConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportHotelConfigShrink))
            {
                body["ImportHotelConfig"] = request.ImportHotelConfigShrink;
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
                Action = "ImportHotelConfig",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/importHotelConfig",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportHotelConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ImportHotelConfigResponse ImportHotelConfig(ImportHotelConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ImportHotelConfigHeaders headers = new ImportHotelConfigHeaders();
            return ImportHotelConfigWithOptions(request, headers, runtime);
        }

        public async Task<ImportHotelConfigResponse> ImportHotelConfigAsync(ImportHotelConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ImportHotelConfigHeaders headers = new ImportHotelConfigHeaders();
            return await ImportHotelConfigWithOptionsAsync(request, headers, runtime);
        }

        public ImportRoomControlDevicesResponse ImportRoomControlDevicesWithOptions(ImportRoomControlDevicesRequest tmpReq, ImportRoomControlDevicesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportRoomControlDevicesShrinkRequest request = new ImportRoomControlDevicesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LocationDevices))
            {
                request.LocationDevicesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LocationDevices, "LocationDevices", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInfraredDeviceImport))
            {
                body["EnableInfraredDeviceImport"] = request.EnableInfraredDeviceImport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationDevicesShrink))
            {
                body["LocationDevices"] = request.LocationDevicesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
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
                Action = "ImportRoomControlDevices",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/importRoomControlDevices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportRoomControlDevicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ImportRoomControlDevicesResponse> ImportRoomControlDevicesWithOptionsAsync(ImportRoomControlDevicesRequest tmpReq, ImportRoomControlDevicesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportRoomControlDevicesShrinkRequest request = new ImportRoomControlDevicesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LocationDevices))
            {
                request.LocationDevicesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LocationDevices, "LocationDevices", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInfraredDeviceImport))
            {
                body["EnableInfraredDeviceImport"] = request.EnableInfraredDeviceImport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationDevicesShrink))
            {
                body["LocationDevices"] = request.LocationDevicesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
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
                Action = "ImportRoomControlDevices",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/importRoomControlDevices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportRoomControlDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ImportRoomControlDevicesResponse ImportRoomControlDevices(ImportRoomControlDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ImportRoomControlDevicesHeaders headers = new ImportRoomControlDevicesHeaders();
            return ImportRoomControlDevicesWithOptions(request, headers, runtime);
        }

        public async Task<ImportRoomControlDevicesResponse> ImportRoomControlDevicesAsync(ImportRoomControlDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ImportRoomControlDevicesHeaders headers = new ImportRoomControlDevicesHeaders();
            return await ImportRoomControlDevicesWithOptionsAsync(request, headers, runtime);
        }

        public ImportRoomGenieScenesResponse ImportRoomGenieScenesWithOptions(ImportRoomGenieScenesRequest tmpReq, ImportRoomGenieScenesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportRoomGenieScenesShrinkRequest request = new ImportRoomGenieScenesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SceneList))
            {
                request.SceneListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SceneList, "SceneList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneListShrink))
            {
                body["SceneList"] = request.SceneListShrink;
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
                Action = "ImportRoomGenieScenes",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/importRoomGenieScenes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportRoomGenieScenesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ImportRoomGenieScenesResponse> ImportRoomGenieScenesWithOptionsAsync(ImportRoomGenieScenesRequest tmpReq, ImportRoomGenieScenesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportRoomGenieScenesShrinkRequest request = new ImportRoomGenieScenesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SceneList))
            {
                request.SceneListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SceneList, "SceneList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneListShrink))
            {
                body["SceneList"] = request.SceneListShrink;
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
                Action = "ImportRoomGenieScenes",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/importRoomGenieScenes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportRoomGenieScenesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ImportRoomGenieScenesResponse ImportRoomGenieScenes(ImportRoomGenieScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ImportRoomGenieScenesHeaders headers = new ImportRoomGenieScenesHeaders();
            return ImportRoomGenieScenesWithOptions(request, headers, runtime);
        }

        public async Task<ImportRoomGenieScenesResponse> ImportRoomGenieScenesAsync(ImportRoomGenieScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ImportRoomGenieScenesHeaders headers = new ImportRoomGenieScenesHeaders();
            return await ImportRoomGenieScenesWithOptionsAsync(request, headers, runtime);
        }

        public InsertHotelSceneBookItemResponse InsertHotelSceneBookItemWithOptions(InsertHotelSceneBookItemRequest tmpReq, InsertHotelSceneBookItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsertHotelSceneBookItemShrinkRequest request = new InsertHotelSceneBookItemShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AddHotelSceneItemReq))
            {
                request.AddHotelSceneItemReqShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AddHotelSceneItemReq, "AddHotelSceneItemReq", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddHotelSceneItemReqShrink))
            {
                query["AddHotelSceneItemReq"] = request.AddHotelSceneItemReqShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "InsertHotelSceneBookItem",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/insertHotelSceneBookItem",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertHotelSceneBookItemResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsertHotelSceneBookItemResponse> InsertHotelSceneBookItemWithOptionsAsync(InsertHotelSceneBookItemRequest tmpReq, InsertHotelSceneBookItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsertHotelSceneBookItemShrinkRequest request = new InsertHotelSceneBookItemShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AddHotelSceneItemReq))
            {
                request.AddHotelSceneItemReqShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AddHotelSceneItemReq, "AddHotelSceneItemReq", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddHotelSceneItemReqShrink))
            {
                query["AddHotelSceneItemReq"] = request.AddHotelSceneItemReqShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "InsertHotelSceneBookItem",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/insertHotelSceneBookItem",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertHotelSceneBookItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsertHotelSceneBookItemResponse InsertHotelSceneBookItem(InsertHotelSceneBookItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertHotelSceneBookItemHeaders headers = new InsertHotelSceneBookItemHeaders();
            return InsertHotelSceneBookItemWithOptions(request, headers, runtime);
        }

        public async Task<InsertHotelSceneBookItemResponse> InsertHotelSceneBookItemAsync(InsertHotelSceneBookItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertHotelSceneBookItemHeaders headers = new InsertHotelSceneBookItemHeaders();
            return await InsertHotelSceneBookItemWithOptionsAsync(request, headers, runtime);
        }

        public InvokeRobotPushResponse InvokeRobotPushWithOptions(InvokeRobotPushRequest request, InvokeRobotPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                body["PushType"] = request.PushType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
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
                Action = "InvokeRobotPush",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/invokeRobotPush",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokeRobotPushResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InvokeRobotPushResponse> InvokeRobotPushWithOptionsAsync(InvokeRobotPushRequest request, InvokeRobotPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                body["PushType"] = request.PushType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
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
                Action = "InvokeRobotPush",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/invokeRobotPush",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokeRobotPushResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InvokeRobotPushResponse InvokeRobotPush(InvokeRobotPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvokeRobotPushHeaders headers = new InvokeRobotPushHeaders();
            return InvokeRobotPushWithOptions(request, headers, runtime);
        }

        public async Task<InvokeRobotPushResponse> InvokeRobotPushAsync(InvokeRobotPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvokeRobotPushHeaders headers = new InvokeRobotPushHeaders();
            return await InvokeRobotPushWithOptionsAsync(request, headers, runtime);
        }

        public ListAllProvincesResponse ListAllProvincesWithOptions(ListAllProvincesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAllProvinces",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listAllProvinces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllProvincesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAllProvincesResponse> ListAllProvincesWithOptionsAsync(ListAllProvincesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAllProvinces",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listAllProvinces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllProvincesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAllProvincesResponse ListAllProvinces()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAllProvincesHeaders headers = new ListAllProvincesHeaders();
            return ListAllProvincesWithOptions(headers, runtime);
        }

        public async Task<ListAllProvincesResponse> ListAllProvincesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAllProvincesHeaders headers = new ListAllProvincesHeaders();
            return await ListAllProvincesWithOptionsAsync(headers, runtime);
        }

        public ListCitiesByProvinceResponse ListCitiesByProvinceWithOptions(ListCitiesByProvinceRequest request, ListCitiesByProvinceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                body["Province"] = request.Province;
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
                Action = "ListCitiesByProvince",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listCitiesByProvince",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCitiesByProvinceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListCitiesByProvinceResponse> ListCitiesByProvinceWithOptionsAsync(ListCitiesByProvinceRequest request, ListCitiesByProvinceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                body["Province"] = request.Province;
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
                Action = "ListCitiesByProvince",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listCitiesByProvince",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCitiesByProvinceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListCitiesByProvinceResponse ListCitiesByProvince(ListCitiesByProvinceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCitiesByProvinceHeaders headers = new ListCitiesByProvinceHeaders();
            return ListCitiesByProvinceWithOptions(request, headers, runtime);
        }

        public async Task<ListCitiesByProvinceResponse> ListCitiesByProvinceAsync(ListCitiesByProvinceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCitiesByProvinceHeaders headers = new ListCitiesByProvinceHeaders();
            return await ListCitiesByProvinceWithOptionsAsync(request, headers, runtime);
        }

        public ListCustomQAResponse ListCustomQAWithOptions(ListCustomQARequest tmpReq, ListCustomQAHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCustomQAShrinkRequest request = new ListCustomQAShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Page))
            {
                request.PageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Page, "Page", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageShrink))
            {
                body["Page"] = request.PageShrink;
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
                Action = "ListCustomQA",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listCustomQA",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomQAResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListCustomQAResponse> ListCustomQAWithOptionsAsync(ListCustomQARequest tmpReq, ListCustomQAHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCustomQAShrinkRequest request = new ListCustomQAShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Page))
            {
                request.PageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Page, "Page", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageShrink))
            {
                body["Page"] = request.PageShrink;
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
                Action = "ListCustomQA",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listCustomQA",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomQAResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListCustomQAResponse ListCustomQA(ListCustomQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCustomQAHeaders headers = new ListCustomQAHeaders();
            return ListCustomQAWithOptions(request, headers, runtime);
        }

        public async Task<ListCustomQAResponse> ListCustomQAAsync(ListCustomQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCustomQAHeaders headers = new ListCustomQAHeaders();
            return await ListCustomQAWithOptionsAsync(request, headers, runtime);
        }

        public ListDialogueTemplateResponse ListDialogueTemplateWithOptions(ListDialogueTemplateRequest request, ListDialogueTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "ListDialogueTemplate",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listDialogueTemplate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDialogueTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDialogueTemplateResponse> ListDialogueTemplateWithOptionsAsync(ListDialogueTemplateRequest request, ListDialogueTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "ListDialogueTemplate",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listDialogueTemplate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDialogueTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDialogueTemplateResponse ListDialogueTemplate(ListDialogueTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDialogueTemplateHeaders headers = new ListDialogueTemplateHeaders();
            return ListDialogueTemplateWithOptions(request, headers, runtime);
        }

        public async Task<ListDialogueTemplateResponse> ListDialogueTemplateAsync(ListDialogueTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDialogueTemplateHeaders headers = new ListDialogueTemplateHeaders();
            return await ListDialogueTemplateWithOptionsAsync(request, headers, runtime);
        }

        public ListHotelAlarmResponse ListHotelAlarmWithOptions(ListHotelAlarmRequest tmpReq, ListHotelAlarmHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotelAlarmShrinkRequest request = new ListHotelAlarmShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rooms))
            {
                request.RoomsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rooms, "Rooms", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomsShrink))
            {
                body["Rooms"] = request.RoomsShrink;
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
                Action = "ListHotelAlarm",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelAlarmList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelAlarmResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListHotelAlarmResponse> ListHotelAlarmWithOptionsAsync(ListHotelAlarmRequest tmpReq, ListHotelAlarmHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotelAlarmShrinkRequest request = new ListHotelAlarmShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rooms))
            {
                request.RoomsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rooms, "Rooms", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomsShrink))
            {
                body["Rooms"] = request.RoomsShrink;
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
                Action = "ListHotelAlarm",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/getHotelAlarmList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelAlarmResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListHotelAlarmResponse ListHotelAlarm(ListHotelAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelAlarmHeaders headers = new ListHotelAlarmHeaders();
            return ListHotelAlarmWithOptions(request, headers, runtime);
        }

        public async Task<ListHotelAlarmResponse> ListHotelAlarmAsync(ListHotelAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelAlarmHeaders headers = new ListHotelAlarmHeaders();
            return await ListHotelAlarmWithOptionsAsync(request, headers, runtime);
        }

        public ListHotelControlDeviceResponse ListHotelControlDeviceWithOptions(ListHotelControlDeviceRequest tmpReq, ListHotelControlDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotelControlDeviceShrinkRequest request = new ListHotelControlDeviceShrinkRequest();
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
                Action = "ListHotelControlDevice",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listHotelControlDevice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelControlDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListHotelControlDeviceResponse> ListHotelControlDeviceWithOptionsAsync(ListHotelControlDeviceRequest tmpReq, ListHotelControlDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotelControlDeviceShrinkRequest request = new ListHotelControlDeviceShrinkRequest();
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
                Action = "ListHotelControlDevice",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listHotelControlDevice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelControlDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListHotelControlDeviceResponse ListHotelControlDevice(ListHotelControlDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelControlDeviceHeaders headers = new ListHotelControlDeviceHeaders();
            return ListHotelControlDeviceWithOptions(request, headers, runtime);
        }

        public async Task<ListHotelControlDeviceResponse> ListHotelControlDeviceAsync(ListHotelControlDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelControlDeviceHeaders headers = new ListHotelControlDeviceHeaders();
            return await ListHotelControlDeviceWithOptionsAsync(request, headers, runtime);
        }

        public ListHotelInfoResponse ListHotelInfoWithOptions(ListHotelInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHotelInfo",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listHotelInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListHotelInfoResponse> ListHotelInfoWithOptionsAsync(ListHotelInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHotelInfo",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listHotelInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListHotelInfoResponse ListHotelInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelInfoHeaders headers = new ListHotelInfoHeaders();
            return ListHotelInfoWithOptions(headers, runtime);
        }

        public async Task<ListHotelInfoResponse> ListHotelInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelInfoHeaders headers = new ListHotelInfoHeaders();
            return await ListHotelInfoWithOptionsAsync(headers, runtime);
        }

        public ListHotelMessageTemplateResponse ListHotelMessageTemplateWithOptions(ListHotelMessageTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHotelMessageTemplate",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listHotelMessageTemplate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelMessageTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListHotelMessageTemplateResponse> ListHotelMessageTemplateWithOptionsAsync(ListHotelMessageTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHotelMessageTemplate",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listHotelMessageTemplate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelMessageTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListHotelMessageTemplateResponse ListHotelMessageTemplate()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelMessageTemplateHeaders headers = new ListHotelMessageTemplateHeaders();
            return ListHotelMessageTemplateWithOptions(headers, runtime);
        }

        public async Task<ListHotelMessageTemplateResponse> ListHotelMessageTemplateAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelMessageTemplateHeaders headers = new ListHotelMessageTemplateHeaders();
            return await ListHotelMessageTemplateWithOptionsAsync(headers, runtime);
        }

        public ListHotelOrderResponse ListHotelOrderWithOptions(ListHotelOrderRequest tmpReq, ListHotelOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotelOrderShrinkRequest request = new ListHotelOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
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
                Action = "ListHotelOrder",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listHotelOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListHotelOrderResponse> ListHotelOrderWithOptionsAsync(ListHotelOrderRequest tmpReq, ListHotelOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotelOrderShrinkRequest request = new ListHotelOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
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
                Action = "ListHotelOrder",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listHotelOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListHotelOrderResponse ListHotelOrder(ListHotelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelOrderHeaders headers = new ListHotelOrderHeaders();
            return ListHotelOrderWithOptions(request, headers, runtime);
        }

        public async Task<ListHotelOrderResponse> ListHotelOrderAsync(ListHotelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelOrderHeaders headers = new ListHotelOrderHeaders();
            return await ListHotelOrderWithOptionsAsync(request, headers, runtime);
        }

        public ListHotelRoomsResponse ListHotelRoomsWithOptions(ListHotelRoomsRequest request, ListHotelRoomsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "ListHotelRooms",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listHotelRooms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelRoomsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListHotelRoomsResponse> ListHotelRoomsWithOptionsAsync(ListHotelRoomsRequest request, ListHotelRoomsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "ListHotelRooms",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listHotelRooms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelRoomsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListHotelRoomsResponse ListHotelRooms(ListHotelRoomsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelRoomsHeaders headers = new ListHotelRoomsHeaders();
            return ListHotelRoomsWithOptions(request, headers, runtime);
        }

        public async Task<ListHotelRoomsResponse> ListHotelRoomsAsync(ListHotelRoomsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelRoomsHeaders headers = new ListHotelRoomsHeaders();
            return await ListHotelRoomsWithOptionsAsync(request, headers, runtime);
        }

        public ListHotelSceneBookItemsResponse ListHotelSceneBookItemsWithOptions(ListHotelSceneBookItemsRequest tmpReq, ListHotelSceneBookItemsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotelSceneBookItemsShrinkRequest request = new ListHotelSceneBookItemsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Page))
            {
                request.PageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Page, "Page", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageShrink))
            {
                query["Page"] = request.PageShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
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
                Action = "ListHotelSceneBookItems",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listHotelSceneBookItems",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelSceneBookItemsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListHotelSceneBookItemsResponse> ListHotelSceneBookItemsWithOptionsAsync(ListHotelSceneBookItemsRequest tmpReq, ListHotelSceneBookItemsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotelSceneBookItemsShrinkRequest request = new ListHotelSceneBookItemsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Page))
            {
                request.PageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Page, "Page", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageShrink))
            {
                query["Page"] = request.PageShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
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
                Action = "ListHotelSceneBookItems",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listHotelSceneBookItems",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelSceneBookItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListHotelSceneBookItemsResponse ListHotelSceneBookItems(ListHotelSceneBookItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelSceneBookItemsHeaders headers = new ListHotelSceneBookItemsHeaders();
            return ListHotelSceneBookItemsWithOptions(request, headers, runtime);
        }

        public async Task<ListHotelSceneBookItemsResponse> ListHotelSceneBookItemsAsync(ListHotelSceneBookItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelSceneBookItemsHeaders headers = new ListHotelSceneBookItemsHeaders();
            return await ListHotelSceneBookItemsWithOptionsAsync(request, headers, runtime);
        }

        public ListHotelSceneItemResponse ListHotelSceneItemWithOptions(ListHotelSceneItemRequest tmpReq, ListHotelSceneItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotelSceneItemShrinkRequest request = new ListHotelSceneItemShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
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
                Action = "ListHotelSceneItem",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listHotelSceneItem",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelSceneItemResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListHotelSceneItemResponse> ListHotelSceneItemWithOptionsAsync(ListHotelSceneItemRequest tmpReq, ListHotelSceneItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotelSceneItemShrinkRequest request = new ListHotelSceneItemShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
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
                Action = "ListHotelSceneItem",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listHotelSceneItem",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelSceneItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListHotelSceneItemResponse ListHotelSceneItem(ListHotelSceneItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelSceneItemHeaders headers = new ListHotelSceneItemHeaders();
            return ListHotelSceneItemWithOptions(request, headers, runtime);
        }

        public async Task<ListHotelSceneItemResponse> ListHotelSceneItemAsync(ListHotelSceneItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelSceneItemHeaders headers = new ListHotelSceneItemHeaders();
            return await ListHotelSceneItemWithOptionsAsync(request, headers, runtime);
        }

        public ListHotelSceneItemsResponse ListHotelSceneItemsWithOptions(ListHotelSceneItemsRequest tmpReq, ListHotelSceneItemsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotelSceneItemsShrinkRequest request = new ListHotelSceneItemsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListHotelSceneReq))
            {
                request.ListHotelSceneReqShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListHotelSceneReq, "ListHotelSceneReq", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListHotelSceneReqShrink))
            {
                query["ListHotelSceneReq"] = request.ListHotelSceneReqShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "ListHotelSceneItems",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listHotelSceneItems",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelSceneItemsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListHotelSceneItemsResponse> ListHotelSceneItemsWithOptionsAsync(ListHotelSceneItemsRequest tmpReq, ListHotelSceneItemsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotelSceneItemsShrinkRequest request = new ListHotelSceneItemsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListHotelSceneReq))
            {
                request.ListHotelSceneReqShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListHotelSceneReq, "ListHotelSceneReq", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListHotelSceneReqShrink))
            {
                query["ListHotelSceneReq"] = request.ListHotelSceneReqShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "ListHotelSceneItems",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listHotelSceneItems",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelSceneItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListHotelSceneItemsResponse ListHotelSceneItems(ListHotelSceneItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelSceneItemsHeaders headers = new ListHotelSceneItemsHeaders();
            return ListHotelSceneItemsWithOptions(request, headers, runtime);
        }

        public async Task<ListHotelSceneItemsResponse> ListHotelSceneItemsAsync(ListHotelSceneItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelSceneItemsHeaders headers = new ListHotelSceneItemsHeaders();
            return await ListHotelSceneItemsWithOptionsAsync(request, headers, runtime);
        }

        public ListHotelServiceCategoryResponse ListHotelServiceCategoryWithOptions(ListHotelServiceCategoryRequest tmpReq, ListHotelServiceCategoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotelServiceCategoryShrinkRequest request = new ListHotelServiceCategoryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
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
                Action = "ListHotelServiceCategory",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listHotelServiceCategory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelServiceCategoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListHotelServiceCategoryResponse> ListHotelServiceCategoryWithOptionsAsync(ListHotelServiceCategoryRequest tmpReq, ListHotelServiceCategoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotelServiceCategoryShrinkRequest request = new ListHotelServiceCategoryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
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
                Action = "ListHotelServiceCategory",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listHotelServiceCategory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelServiceCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListHotelServiceCategoryResponse ListHotelServiceCategory(ListHotelServiceCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelServiceCategoryHeaders headers = new ListHotelServiceCategoryHeaders();
            return ListHotelServiceCategoryWithOptions(request, headers, runtime);
        }

        public async Task<ListHotelServiceCategoryResponse> ListHotelServiceCategoryAsync(ListHotelServiceCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelServiceCategoryHeaders headers = new ListHotelServiceCategoryHeaders();
            return await ListHotelServiceCategoryWithOptionsAsync(request, headers, runtime);
        }

        public ListHotelsResponse ListHotelsWithOptions(ListHotelsRequest tmpReq, ListHotelsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotelsShrinkRequest request = new ListHotelsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Page))
            {
                request.PageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Page, "Page", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageShrink))
            {
                query["Page"] = request.PageShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
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
                Action = "ListHotels",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listHotels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListHotelsResponse> ListHotelsWithOptionsAsync(ListHotelsRequest tmpReq, ListHotelsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotelsShrinkRequest request = new ListHotelsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Page))
            {
                request.PageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Page, "Page", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageShrink))
            {
                query["Page"] = request.PageShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
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
                Action = "ListHotels",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listHotels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListHotelsResponse ListHotels(ListHotelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelsHeaders headers = new ListHotelsHeaders();
            return ListHotelsWithOptions(request, headers, runtime);
        }

        public async Task<ListHotelsResponse> ListHotelsAsync(ListHotelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelsHeaders headers = new ListHotelsHeaders();
            return await ListHotelsWithOptionsAsync(request, headers, runtime);
        }

        public ListInfraredDeviceBrandsResponse ListInfraredDeviceBrandsWithOptions(ListInfraredDeviceBrandsRequest request, ListInfraredDeviceBrandsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceProvider))
            {
                body["ServiceProvider"] = request.ServiceProvider;
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
                Action = "ListInfraredDeviceBrands",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listInfraredDeviceBrands",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInfraredDeviceBrandsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListInfraredDeviceBrandsResponse> ListInfraredDeviceBrandsWithOptionsAsync(ListInfraredDeviceBrandsRequest request, ListInfraredDeviceBrandsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceProvider))
            {
                body["ServiceProvider"] = request.ServiceProvider;
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
                Action = "ListInfraredDeviceBrands",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listInfraredDeviceBrands",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInfraredDeviceBrandsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListInfraredDeviceBrandsResponse ListInfraredDeviceBrands(ListInfraredDeviceBrandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInfraredDeviceBrandsHeaders headers = new ListInfraredDeviceBrandsHeaders();
            return ListInfraredDeviceBrandsWithOptions(request, headers, runtime);
        }

        public async Task<ListInfraredDeviceBrandsResponse> ListInfraredDeviceBrandsAsync(ListInfraredDeviceBrandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInfraredDeviceBrandsHeaders headers = new ListInfraredDeviceBrandsHeaders();
            return await ListInfraredDeviceBrandsWithOptionsAsync(request, headers, runtime);
        }

        public ListInfraredRemoteControllersResponse ListInfraredRemoteControllersWithOptions(ListInfraredRemoteControllersRequest request, ListInfraredRemoteControllersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Brand))
            {
                body["Brand"] = request.Brand;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                body["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceProvider))
            {
                body["ServiceProvider"] = request.ServiceProvider;
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
                Action = "ListInfraredRemoteControllers",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listInfraredRemoteControllers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInfraredRemoteControllersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListInfraredRemoteControllersResponse> ListInfraredRemoteControllersWithOptionsAsync(ListInfraredRemoteControllersRequest request, ListInfraredRemoteControllersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Brand))
            {
                body["Brand"] = request.Brand;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                body["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceProvider))
            {
                body["ServiceProvider"] = request.ServiceProvider;
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
                Action = "ListInfraredRemoteControllers",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listInfraredRemoteControllers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInfraredRemoteControllersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListInfraredRemoteControllersResponse ListInfraredRemoteControllers(ListInfraredRemoteControllersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInfraredRemoteControllersHeaders headers = new ListInfraredRemoteControllersHeaders();
            return ListInfraredRemoteControllersWithOptions(request, headers, runtime);
        }

        public async Task<ListInfraredRemoteControllersResponse> ListInfraredRemoteControllersAsync(ListInfraredRemoteControllersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInfraredRemoteControllersHeaders headers = new ListInfraredRemoteControllersHeaders();
            return await ListInfraredRemoteControllersWithOptionsAsync(request, headers, runtime);
        }

        public ListSTBServiceProvidersResponse ListSTBServiceProvidersWithOptions(ListSTBServiceProvidersRequest request, ListSTBServiceProvidersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                body["Province"] = request.Province;
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
                Action = "ListSTBServiceProviders",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listSTBServiceProviders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSTBServiceProvidersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSTBServiceProvidersResponse> ListSTBServiceProvidersWithOptionsAsync(ListSTBServiceProvidersRequest request, ListSTBServiceProvidersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                body["Province"] = request.Province;
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
                Action = "ListSTBServiceProviders",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listSTBServiceProviders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSTBServiceProvidersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSTBServiceProvidersResponse ListSTBServiceProviders(ListSTBServiceProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSTBServiceProvidersHeaders headers = new ListSTBServiceProvidersHeaders();
            return ListSTBServiceProvidersWithOptions(request, headers, runtime);
        }

        public async Task<ListSTBServiceProvidersResponse> ListSTBServiceProvidersAsync(ListSTBServiceProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSTBServiceProvidersHeaders headers = new ListSTBServiceProvidersHeaders();
            return await ListSTBServiceProvidersWithOptionsAsync(request, headers, runtime);
        }

        public ListSceneCategoryResponse ListSceneCategoryWithOptions(ListSceneCategoryRequest request, ListSceneCategoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
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
                Action = "ListSceneCategory",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listSceneCategory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSceneCategoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSceneCategoryResponse> ListSceneCategoryWithOptionsAsync(ListSceneCategoryRequest request, ListSceneCategoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
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
                Action = "ListSceneCategory",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listSceneCategory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSceneCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSceneCategoryResponse ListSceneCategory(ListSceneCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSceneCategoryHeaders headers = new ListSceneCategoryHeaders();
            return ListSceneCategoryWithOptions(request, headers, runtime);
        }

        public async Task<ListSceneCategoryResponse> ListSceneCategoryAsync(ListSceneCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSceneCategoryHeaders headers = new ListSceneCategoryHeaders();
            return await ListSceneCategoryWithOptionsAsync(request, headers, runtime);
        }

        public ListServiceQAResponse ListServiceQAWithOptions(ListServiceQARequest tmpReq, ListServiceQAHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListServiceQAShrinkRequest request = new ListServiceQAShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Page))
            {
                request.PageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Page, "Page", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                body["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageShrink))
            {
                body["Page"] = request.PageShrink;
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
                Action = "ListServiceQA",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listServiceQA",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceQAResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListServiceQAResponse> ListServiceQAWithOptionsAsync(ListServiceQARequest tmpReq, ListServiceQAHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListServiceQAShrinkRequest request = new ListServiceQAShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Page))
            {
                request.PageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Page, "Page", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                body["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageShrink))
            {
                body["Page"] = request.PageShrink;
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
                Action = "ListServiceQA",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listServiceQA",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceQAResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListServiceQAResponse ListServiceQA(ListServiceQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListServiceQAHeaders headers = new ListServiceQAHeaders();
            return ListServiceQAWithOptions(request, headers, runtime);
        }

        public async Task<ListServiceQAResponse> ListServiceQAAsync(ListServiceQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListServiceQAHeaders headers = new ListServiceQAHeaders();
            return await ListServiceQAWithOptionsAsync(request, headers, runtime);
        }

        public ListTicketsResponse ListTicketsWithOptions(ListTicketsRequest tmpReq, ListTicketsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTicketsShrinkRequest request = new ListTicketsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Page))
            {
                request.PageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Page, "Page", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDesc))
            {
                body["IsDesc"] = request.IsDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsNeedCallback))
            {
                body["IsNeedCallback"] = request.IsNeedCallback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsNeedCharges))
            {
                body["IsNeedCharges"] = request.IsNeedCharges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageShrink))
            {
                body["Page"] = request.PageShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
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
                Action = "ListTickets",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listTickets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTicketsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTicketsResponse> ListTicketsWithOptionsAsync(ListTicketsRequest tmpReq, ListTicketsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTicketsShrinkRequest request = new ListTicketsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Page))
            {
                request.PageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Page, "Page", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDesc))
            {
                body["IsDesc"] = request.IsDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsNeedCallback))
            {
                body["IsNeedCallback"] = request.IsNeedCallback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsNeedCharges))
            {
                body["IsNeedCharges"] = request.IsNeedCharges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageShrink))
            {
                body["Page"] = request.PageShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
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
                Action = "ListTickets",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/listTickets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTicketsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTicketsResponse ListTickets(ListTicketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTicketsHeaders headers = new ListTicketsHeaders();
            return ListTicketsWithOptions(request, headers, runtime);
        }

        public async Task<ListTicketsResponse> ListTicketsAsync(ListTicketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTicketsHeaders headers = new ListTicketsHeaders();
            return await ListTicketsWithOptionsAsync(request, headers, runtime);
        }

        public PageGetHotelRoomDevicesResponse PageGetHotelRoomDevicesWithOptions(PageGetHotelRoomDevicesRequest request, PageGetHotelRoomDevicesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
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
                Action = "PageGetHotelRoomDevices",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/pageGetHotelRoomDevices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageGetHotelRoomDevicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PageGetHotelRoomDevicesResponse> PageGetHotelRoomDevicesWithOptionsAsync(PageGetHotelRoomDevicesRequest request, PageGetHotelRoomDevicesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
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
                Action = "PageGetHotelRoomDevices",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/pageGetHotelRoomDevices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageGetHotelRoomDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PageGetHotelRoomDevicesResponse PageGetHotelRoomDevices(PageGetHotelRoomDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageGetHotelRoomDevicesHeaders headers = new PageGetHotelRoomDevicesHeaders();
            return PageGetHotelRoomDevicesWithOptions(request, headers, runtime);
        }

        public async Task<PageGetHotelRoomDevicesResponse> PageGetHotelRoomDevicesAsync(PageGetHotelRoomDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageGetHotelRoomDevicesHeaders headers = new PageGetHotelRoomDevicesHeaders();
            return await PageGetHotelRoomDevicesWithOptionsAsync(request, headers, runtime);
        }

        public PushHotelMessageResponse PushHotelMessageWithOptions(PushHotelMessageRequest tmpReq, PushHotelMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushHotelMessageShrinkRequest request = new PushHotelMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PushHotelMessageReq))
            {
                request.PushHotelMessageReqShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PushHotelMessageReq, "PushHotelMessageReq", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushHotelMessageReqShrink))
            {
                query["PushHotelMessageReq"] = request.PushHotelMessageReqShrink;
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
                Action = "PushHotelMessage",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/pushHotelMessage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushHotelMessageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PushHotelMessageResponse> PushHotelMessageWithOptionsAsync(PushHotelMessageRequest tmpReq, PushHotelMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushHotelMessageShrinkRequest request = new PushHotelMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PushHotelMessageReq))
            {
                request.PushHotelMessageReqShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PushHotelMessageReq, "PushHotelMessageReq", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushHotelMessageReqShrink))
            {
                query["PushHotelMessageReq"] = request.PushHotelMessageReqShrink;
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
                Action = "PushHotelMessage",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/pushHotelMessage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushHotelMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PushHotelMessageResponse PushHotelMessage(PushHotelMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushHotelMessageHeaders headers = new PushHotelMessageHeaders();
            return PushHotelMessageWithOptions(request, headers, runtime);
        }

        public async Task<PushHotelMessageResponse> PushHotelMessageAsync(PushHotelMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushHotelMessageHeaders headers = new PushHotelMessageHeaders();
            return await PushHotelMessageWithOptionsAsync(request, headers, runtime);
        }

        public PushWelcomeTextAndMusicResponse PushWelcomeTextAndMusicWithOptions(PushWelcomeTextAndMusicRequest tmpReq, PushWelcomeTextAndMusicHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushWelcomeTextAndMusicShrinkRequest request = new PushWelcomeTextAndMusicShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TemplateVariable))
            {
                request.TemplateVariableShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TemplateVariable, "TemplateVariable", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVariableShrink))
            {
                body["TemplateVariable"] = request.TemplateVariableShrink;
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
                Action = "PushWelcomeTextAndMusic",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/pushWelcomeTextAndMusic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushWelcomeTextAndMusicResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PushWelcomeTextAndMusicResponse> PushWelcomeTextAndMusicWithOptionsAsync(PushWelcomeTextAndMusicRequest tmpReq, PushWelcomeTextAndMusicHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushWelcomeTextAndMusicShrinkRequest request = new PushWelcomeTextAndMusicShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TemplateVariable))
            {
                request.TemplateVariableShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TemplateVariable, "TemplateVariable", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVariableShrink))
            {
                body["TemplateVariable"] = request.TemplateVariableShrink;
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
                Action = "PushWelcomeTextAndMusic",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/pushWelcomeTextAndMusic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushWelcomeTextAndMusicResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PushWelcomeTextAndMusicResponse PushWelcomeTextAndMusic(PushWelcomeTextAndMusicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushWelcomeTextAndMusicHeaders headers = new PushWelcomeTextAndMusicHeaders();
            return PushWelcomeTextAndMusicWithOptions(request, headers, runtime);
        }

        public async Task<PushWelcomeTextAndMusicResponse> PushWelcomeTextAndMusicAsync(PushWelcomeTextAndMusicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushWelcomeTextAndMusicHeaders headers = new PushWelcomeTextAndMusicHeaders();
            return await PushWelcomeTextAndMusicWithOptionsAsync(request, headers, runtime);
        }

        public QueryDeviceStatusResponse QueryDeviceStatusWithOptions(QueryDeviceStatusRequest tmpReq, QueryDeviceStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryDeviceStatusShrinkRequest request = new QueryDeviceStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
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
                Action = "QueryDeviceStatus",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/queryDeviceStatus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDeviceStatusResponse> QueryDeviceStatusWithOptionsAsync(QueryDeviceStatusRequest tmpReq, QueryDeviceStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryDeviceStatusShrinkRequest request = new QueryDeviceStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
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
                Action = "QueryDeviceStatus",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/queryDeviceStatus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDeviceStatusResponse QueryDeviceStatus(QueryDeviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceStatusHeaders headers = new QueryDeviceStatusHeaders();
            return QueryDeviceStatusWithOptions(request, headers, runtime);
        }

        public async Task<QueryDeviceStatusResponse> QueryDeviceStatusAsync(QueryDeviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceStatusHeaders headers = new QueryDeviceStatusHeaders();
            return await QueryDeviceStatusWithOptionsAsync(request, headers, runtime);
        }

        public QueryHotelRoomDetailResponse QueryHotelRoomDetailWithOptions(QueryHotelRoomDetailRequest request, QueryHotelRoomDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                body["Mac"] = request.Mac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sn))
            {
                body["Sn"] = request.Sn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
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
                Action = "QueryHotelRoomDetail",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/queryHotelRoomDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHotelRoomDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryHotelRoomDetailResponse> QueryHotelRoomDetailWithOptionsAsync(QueryHotelRoomDetailRequest request, QueryHotelRoomDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                body["Mac"] = request.Mac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sn))
            {
                body["Sn"] = request.Sn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
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
                Action = "QueryHotelRoomDetail",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/queryHotelRoomDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHotelRoomDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryHotelRoomDetailResponse QueryHotelRoomDetail(QueryHotelRoomDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHotelRoomDetailHeaders headers = new QueryHotelRoomDetailHeaders();
            return QueryHotelRoomDetailWithOptions(request, headers, runtime);
        }

        public async Task<QueryHotelRoomDetailResponse> QueryHotelRoomDetailAsync(QueryHotelRoomDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHotelRoomDetailHeaders headers = new QueryHotelRoomDetailHeaders();
            return await QueryHotelRoomDetailWithOptionsAsync(request, headers, runtime);
        }

        public QueryRoomControlDevicesResponse QueryRoomControlDevicesWithOptions(QueryRoomControlDevicesRequest request, QueryRoomControlDevicesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                query["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                query["RoomNo"] = request.RoomNo;
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
                Action = "QueryRoomControlDevices",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/queryRoomControlDevices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRoomControlDevicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRoomControlDevicesResponse> QueryRoomControlDevicesWithOptionsAsync(QueryRoomControlDevicesRequest request, QueryRoomControlDevicesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                query["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                query["RoomNo"] = request.RoomNo;
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
                Action = "QueryRoomControlDevices",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/queryRoomControlDevices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRoomControlDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRoomControlDevicesResponse QueryRoomControlDevices(QueryRoomControlDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRoomControlDevicesHeaders headers = new QueryRoomControlDevicesHeaders();
            return QueryRoomControlDevicesWithOptions(request, headers, runtime);
        }

        public async Task<QueryRoomControlDevicesResponse> QueryRoomControlDevicesAsync(QueryRoomControlDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRoomControlDevicesHeaders headers = new QueryRoomControlDevicesHeaders();
            return await QueryRoomControlDevicesWithOptionsAsync(request, headers, runtime);
        }

        public QuerySceneListResponse QuerySceneListWithOptions(QuerySceneListRequest tmpReq, QuerySceneListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QuerySceneListShrinkRequest request = new QuerySceneListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SceneStates))
            {
                request.SceneStatesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SceneStates, "SceneStates", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SceneTypes))
            {
                request.SceneTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SceneTypes, "SceneTypes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TemplateInfoIds))
            {
                request.TemplateInfoIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TemplateInfoIds, "TemplateInfoIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneStatesShrink))
            {
                body["SceneStates"] = request.SceneStatesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneTypesShrink))
            {
                body["SceneTypes"] = request.SceneTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateInfoIdsShrink))
            {
                body["TemplateInfoIds"] = request.TemplateInfoIdsShrink;
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
                Action = "QuerySceneList",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/querySceneList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySceneListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QuerySceneListResponse> QuerySceneListWithOptionsAsync(QuerySceneListRequest tmpReq, QuerySceneListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QuerySceneListShrinkRequest request = new QuerySceneListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SceneStates))
            {
                request.SceneStatesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SceneStates, "SceneStates", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SceneTypes))
            {
                request.SceneTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SceneTypes, "SceneTypes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TemplateInfoIds))
            {
                request.TemplateInfoIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TemplateInfoIds, "TemplateInfoIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneStatesShrink))
            {
                body["SceneStates"] = request.SceneStatesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneTypesShrink))
            {
                body["SceneTypes"] = request.SceneTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateInfoIdsShrink))
            {
                body["TemplateInfoIds"] = request.TemplateInfoIdsShrink;
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
                Action = "QuerySceneList",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/querySceneList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySceneListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QuerySceneListResponse QuerySceneList(QuerySceneListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySceneListHeaders headers = new QuerySceneListHeaders();
            return QuerySceneListWithOptions(request, headers, runtime);
        }

        public async Task<QuerySceneListResponse> QuerySceneListAsync(QuerySceneListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySceneListHeaders headers = new QuerySceneListHeaders();
            return await QuerySceneListWithOptionsAsync(request, headers, runtime);
        }

        public RemoveChildAccountAuthResponse RemoveChildAccountAuthWithOptions(RemoveChildAccountAuthRequest request, RemoveChildAccountAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildAccountName))
            {
                body["ChildAccountName"] = request.ChildAccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbOpenId))
            {
                body["TbOpenId"] = request.TbOpenId;
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
                Action = "RemoveChildAccountAuth",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/removeChildAccountAuth",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveChildAccountAuthResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveChildAccountAuthResponse> RemoveChildAccountAuthWithOptionsAsync(RemoveChildAccountAuthRequest request, RemoveChildAccountAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildAccountName))
            {
                body["ChildAccountName"] = request.ChildAccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbOpenId))
            {
                body["TbOpenId"] = request.TbOpenId;
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
                Action = "RemoveChildAccountAuth",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/removeChildAccountAuth",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveChildAccountAuthResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveChildAccountAuthResponse RemoveChildAccountAuth(RemoveChildAccountAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveChildAccountAuthHeaders headers = new RemoveChildAccountAuthHeaders();
            return RemoveChildAccountAuthWithOptions(request, headers, runtime);
        }

        public async Task<RemoveChildAccountAuthResponse> RemoveChildAccountAuthAsync(RemoveChildAccountAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveChildAccountAuthHeaders headers = new RemoveChildAccountAuthHeaders();
            return await RemoveChildAccountAuthWithOptionsAsync(request, headers, runtime);
        }

        public RemoveHotelResponse RemoveHotelWithOptions(RemoveHotelRequest request, RemoveHotelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbOpenId))
            {
                body["TbOpenId"] = request.TbOpenId;
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
                Action = "RemoveHotel",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/removeHotel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveHotelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveHotelResponse> RemoveHotelWithOptionsAsync(RemoveHotelRequest request, RemoveHotelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbOpenId))
            {
                body["TbOpenId"] = request.TbOpenId;
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
                Action = "RemoveHotel",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/removeHotel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveHotelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveHotelResponse RemoveHotel(RemoveHotelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveHotelHeaders headers = new RemoveHotelHeaders();
            return RemoveHotelWithOptions(request, headers, runtime);
        }

        public async Task<RemoveHotelResponse> RemoveHotelAsync(RemoveHotelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveHotelHeaders headers = new RemoveHotelHeaders();
            return await RemoveHotelWithOptionsAsync(request, headers, runtime);
        }

        public ResetWelcomeTextAndMusicResponse ResetWelcomeTextAndMusicWithOptions(ResetWelcomeTextAndMusicRequest request, ResetWelcomeTextAndMusicHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "ResetWelcomeTextAndMusic",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/resetWelcomeTextAndMusic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetWelcomeTextAndMusicResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResetWelcomeTextAndMusicResponse> ResetWelcomeTextAndMusicWithOptionsAsync(ResetWelcomeTextAndMusicRequest request, ResetWelcomeTextAndMusicHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "ResetWelcomeTextAndMusic",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/resetWelcomeTextAndMusic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetWelcomeTextAndMusicResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResetWelcomeTextAndMusicResponse ResetWelcomeTextAndMusic(ResetWelcomeTextAndMusicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ResetWelcomeTextAndMusicHeaders headers = new ResetWelcomeTextAndMusicHeaders();
            return ResetWelcomeTextAndMusicWithOptions(request, headers, runtime);
        }

        public async Task<ResetWelcomeTextAndMusicResponse> ResetWelcomeTextAndMusicAsync(ResetWelcomeTextAndMusicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ResetWelcomeTextAndMusicHeaders headers = new ResetWelcomeTextAndMusicHeaders();
            return await ResetWelcomeTextAndMusicWithOptionsAsync(request, headers, runtime);
        }

        public RoomCheckOutResponse RoomCheckOutWithOptions(RoomCheckOutRequest tmpReq, RoomCheckOutHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RoomCheckOutShrinkRequest request = new RoomCheckOutShrinkRequest();
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
                Action = "RoomCheckOut",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/roomCheckOut",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RoomCheckOutResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RoomCheckOutResponse> RoomCheckOutWithOptionsAsync(RoomCheckOutRequest tmpReq, RoomCheckOutHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RoomCheckOutShrinkRequest request = new RoomCheckOutShrinkRequest();
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
                Action = "RoomCheckOut",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/roomCheckOut",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RoomCheckOutResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RoomCheckOutResponse RoomCheckOut(RoomCheckOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RoomCheckOutHeaders headers = new RoomCheckOutHeaders();
            return RoomCheckOutWithOptions(request, headers, runtime);
        }

        public async Task<RoomCheckOutResponse> RoomCheckOutAsync(RoomCheckOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RoomCheckOutHeaders headers = new RoomCheckOutHeaders();
            return await RoomCheckOutWithOptionsAsync(request, headers, runtime);
        }

        public SubmitHotelOrderResponse SubmitHotelOrderWithOptions(SubmitHotelOrderRequest tmpReq, SubmitHotelOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitHotelOrderShrinkRequest request = new SubmitHotelOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
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
                Action = "SubmitHotelOrder",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/submitHotelOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitHotelOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitHotelOrderResponse> SubmitHotelOrderWithOptionsAsync(SubmitHotelOrderRequest tmpReq, SubmitHotelOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitHotelOrderShrinkRequest request = new SubmitHotelOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
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
                Action = "SubmitHotelOrder",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/submitHotelOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitHotelOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitHotelOrderResponse SubmitHotelOrder(SubmitHotelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubmitHotelOrderHeaders headers = new SubmitHotelOrderHeaders();
            return SubmitHotelOrderWithOptions(request, headers, runtime);
        }

        public async Task<SubmitHotelOrderResponse> SubmitHotelOrderAsync(SubmitHotelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubmitHotelOrderHeaders headers = new SubmitHotelOrderHeaders();
            return await SubmitHotelOrderWithOptionsAsync(request, headers, runtime);
        }

        public SyncDeviceStatusWithAkResponse SyncDeviceStatusWithAkWithOptions(SyncDeviceStatusWithAkRequest request, SyncDeviceStatusWithAkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryCnName))
            {
                body["CategoryCnName"] = request.CategoryCnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryEnName))
            {
                body["CategoryEnName"] = request.CategoryEnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationCnName))
            {
                body["LocationCnName"] = request.LocationCnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                body["Number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Switch))
            {
                body["Switch"] = request.Switch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FanSpeed))
            {
                body["fanSpeed"] = request.FanSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomTemperature))
            {
                body["roomTemperature"] = request.RoomTemperature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Temperature))
            {
                body["temperature"] = request.Temperature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
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
                Action = "SyncDeviceStatusWithAk",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/syncDeviceStatusWithAk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncDeviceStatusWithAkResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SyncDeviceStatusWithAkResponse> SyncDeviceStatusWithAkWithOptionsAsync(SyncDeviceStatusWithAkRequest request, SyncDeviceStatusWithAkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryCnName))
            {
                body["CategoryCnName"] = request.CategoryCnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryEnName))
            {
                body["CategoryEnName"] = request.CategoryEnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationCnName))
            {
                body["LocationCnName"] = request.LocationCnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                body["Number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Switch))
            {
                body["Switch"] = request.Switch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FanSpeed))
            {
                body["fanSpeed"] = request.FanSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomTemperature))
            {
                body["roomTemperature"] = request.RoomTemperature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Temperature))
            {
                body["temperature"] = request.Temperature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
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
                Action = "SyncDeviceStatusWithAk",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/syncDeviceStatusWithAk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncDeviceStatusWithAkResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SyncDeviceStatusWithAkResponse SyncDeviceStatusWithAk(SyncDeviceStatusWithAkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncDeviceStatusWithAkHeaders headers = new SyncDeviceStatusWithAkHeaders();
            return SyncDeviceStatusWithAkWithOptions(request, headers, runtime);
        }

        public async Task<SyncDeviceStatusWithAkResponse> SyncDeviceStatusWithAkAsync(SyncDeviceStatusWithAkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncDeviceStatusWithAkHeaders headers = new SyncDeviceStatusWithAkHeaders();
            return await SyncDeviceStatusWithAkWithOptionsAsync(request, headers, runtime);
        }

        public UpdateBasicInfoQAResponse UpdateBasicInfoQAWithOptions(UpdateBasicInfoQARequest request, UpdateBasicInfoQAHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckInTime))
            {
                body["CheckInTime"] = request.CheckInTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckOutTime))
            {
                body["CheckOutTime"] = request.CheckOutTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelAddress))
            {
                body["HotelAddress"] = request.HotelAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelIntroduction))
            {
                body["HotelIntroduction"] = request.HotelIntroduction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelMember))
            {
                body["HotelMember"] = request.HotelMember;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelService))
            {
                body["HotelService"] = request.HotelService;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParkingExpenses))
            {
                body["ParkingExpenses"] = request.ParkingExpenses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParkingPosition))
            {
                body["ParkingPosition"] = request.ParkingPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WifiName))
            {
                body["WifiName"] = request.WifiName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WifiPassword))
            {
                body["WifiPassword"] = request.WifiPassword;
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
                Action = "UpdateBasicInfoQA",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/updateBasicInfoQA",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBasicInfoQAResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateBasicInfoQAResponse> UpdateBasicInfoQAWithOptionsAsync(UpdateBasicInfoQARequest request, UpdateBasicInfoQAHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckInTime))
            {
                body["CheckInTime"] = request.CheckInTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckOutTime))
            {
                body["CheckOutTime"] = request.CheckOutTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelAddress))
            {
                body["HotelAddress"] = request.HotelAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelIntroduction))
            {
                body["HotelIntroduction"] = request.HotelIntroduction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelMember))
            {
                body["HotelMember"] = request.HotelMember;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelService))
            {
                body["HotelService"] = request.HotelService;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParkingExpenses))
            {
                body["ParkingExpenses"] = request.ParkingExpenses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParkingPosition))
            {
                body["ParkingPosition"] = request.ParkingPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WifiName))
            {
                body["WifiName"] = request.WifiName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WifiPassword))
            {
                body["WifiPassword"] = request.WifiPassword;
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
                Action = "UpdateBasicInfoQA",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/updateBasicInfoQA",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBasicInfoQAResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateBasicInfoQAResponse UpdateBasicInfoQA(UpdateBasicInfoQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateBasicInfoQAHeaders headers = new UpdateBasicInfoQAHeaders();
            return UpdateBasicInfoQAWithOptions(request, headers, runtime);
        }

        public async Task<UpdateBasicInfoQAResponse> UpdateBasicInfoQAAsync(UpdateBasicInfoQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateBasicInfoQAHeaders headers = new UpdateBasicInfoQAHeaders();
            return await UpdateBasicInfoQAWithOptionsAsync(request, headers, runtime);
        }

        public UpdateCustomQAResponse UpdateCustomQAWithOptions(UpdateCustomQARequest tmpReq, UpdateCustomQAHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateCustomQAShrinkRequest request = new UpdateCustomQAShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Answers))
            {
                request.AnswersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Answers, "Answers", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.KeyWords))
            {
                request.KeyWordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.KeyWords, "KeyWords", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SupplementaryQuestions))
            {
                request.SupplementaryQuestionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SupplementaryQuestions, "SupplementaryQuestions", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnswersShrink))
            {
                body["Answers"] = request.AnswersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomQAId))
            {
                body["CustomQAId"] = request.CustomQAId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWordsShrink))
            {
                body["KeyWords"] = request.KeyWordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MajorQuestion))
            {
                body["MajorQuestion"] = request.MajorQuestion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplementaryQuestionsShrink))
            {
                body["SupplementaryQuestions"] = request.SupplementaryQuestionsShrink;
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
                Action = "UpdateCustomQA",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/updateCustomQA",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomQAResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateCustomQAResponse> UpdateCustomQAWithOptionsAsync(UpdateCustomQARequest tmpReq, UpdateCustomQAHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateCustomQAShrinkRequest request = new UpdateCustomQAShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Answers))
            {
                request.AnswersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Answers, "Answers", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.KeyWords))
            {
                request.KeyWordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.KeyWords, "KeyWords", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SupplementaryQuestions))
            {
                request.SupplementaryQuestionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SupplementaryQuestions, "SupplementaryQuestions", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnswersShrink))
            {
                body["Answers"] = request.AnswersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomQAId))
            {
                body["CustomQAId"] = request.CustomQAId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWordsShrink))
            {
                body["KeyWords"] = request.KeyWordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MajorQuestion))
            {
                body["MajorQuestion"] = request.MajorQuestion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplementaryQuestionsShrink))
            {
                body["SupplementaryQuestions"] = request.SupplementaryQuestionsShrink;
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
                Action = "UpdateCustomQA",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/updateCustomQA",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomQAResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateCustomQAResponse UpdateCustomQA(UpdateCustomQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCustomQAHeaders headers = new UpdateCustomQAHeaders();
            return UpdateCustomQAWithOptions(request, headers, runtime);
        }

        public async Task<UpdateCustomQAResponse> UpdateCustomQAAsync(UpdateCustomQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCustomQAHeaders headers = new UpdateCustomQAHeaders();
            return await UpdateCustomQAWithOptionsAsync(request, headers, runtime);
        }

        public UpdateHotelResponse UpdateHotelWithOptions(UpdateHotelRequest tmpReq, UpdateHotelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateHotelShrinkRequest request = new UpdateHotelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RelatedPks))
            {
                request.RelatedPksShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RelatedPks, "RelatedPks", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EstOpenTime))
            {
                body["EstOpenTime"] = request.EstOpenTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelAddress))
            {
                body["HotelAddress"] = request.HotelAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelEmail))
            {
                body["HotelEmail"] = request.HotelEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelName))
            {
                body["HotelName"] = request.HotelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedPksShrink))
            {
                body["RelatedPks"] = request.RelatedPksShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNum))
            {
                body["RoomNum"] = request.RoomNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbOpenId))
            {
                body["TbOpenId"] = request.TbOpenId;
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
                Action = "UpdateHotel",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/updateHotel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHotelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateHotelResponse> UpdateHotelWithOptionsAsync(UpdateHotelRequest tmpReq, UpdateHotelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateHotelShrinkRequest request = new UpdateHotelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RelatedPks))
            {
                request.RelatedPksShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RelatedPks, "RelatedPks", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EstOpenTime))
            {
                body["EstOpenTime"] = request.EstOpenTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelAddress))
            {
                body["HotelAddress"] = request.HotelAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelEmail))
            {
                body["HotelEmail"] = request.HotelEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelName))
            {
                body["HotelName"] = request.HotelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedPksShrink))
            {
                body["RelatedPks"] = request.RelatedPksShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNum))
            {
                body["RoomNum"] = request.RoomNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbOpenId))
            {
                body["TbOpenId"] = request.TbOpenId;
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
                Action = "UpdateHotel",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/updateHotel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHotelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateHotelResponse UpdateHotel(UpdateHotelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHotelHeaders headers = new UpdateHotelHeaders();
            return UpdateHotelWithOptions(request, headers, runtime);
        }

        public async Task<UpdateHotelResponse> UpdateHotelAsync(UpdateHotelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHotelHeaders headers = new UpdateHotelHeaders();
            return await UpdateHotelWithOptionsAsync(request, headers, runtime);
        }

        public UpdateHotelAlarmResponse UpdateHotelAlarmWithOptions(UpdateHotelAlarmRequest tmpReq, UpdateHotelAlarmHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateHotelAlarmShrinkRequest request = new UpdateHotelAlarmShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Alarms))
            {
                request.AlarmsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Alarms, "Alarms", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleInfo))
            {
                request.ScheduleInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleInfo, "ScheduleInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmsShrink))
            {
                body["Alarms"] = request.AlarmsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleInfoShrink))
            {
                body["ScheduleInfo"] = request.ScheduleInfoShrink;
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
                Action = "UpdateHotelAlarm",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/updateHotelAlarm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHotelAlarmResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateHotelAlarmResponse> UpdateHotelAlarmWithOptionsAsync(UpdateHotelAlarmRequest tmpReq, UpdateHotelAlarmHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateHotelAlarmShrinkRequest request = new UpdateHotelAlarmShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Alarms))
            {
                request.AlarmsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Alarms, "Alarms", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleInfo))
            {
                request.ScheduleInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleInfo, "ScheduleInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmsShrink))
            {
                body["Alarms"] = request.AlarmsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleInfoShrink))
            {
                body["ScheduleInfo"] = request.ScheduleInfoShrink;
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
                Action = "UpdateHotelAlarm",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/updateHotelAlarm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHotelAlarmResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateHotelAlarmResponse UpdateHotelAlarm(UpdateHotelAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHotelAlarmHeaders headers = new UpdateHotelAlarmHeaders();
            return UpdateHotelAlarmWithOptions(request, headers, runtime);
        }

        public async Task<UpdateHotelAlarmResponse> UpdateHotelAlarmAsync(UpdateHotelAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHotelAlarmHeaders headers = new UpdateHotelAlarmHeaders();
            return await UpdateHotelAlarmWithOptionsAsync(request, headers, runtime);
        }

        public UpdateHotelSceneBookItemResponse UpdateHotelSceneBookItemWithOptions(UpdateHotelSceneBookItemRequest tmpReq, UpdateHotelSceneBookItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateHotelSceneBookItemShrinkRequest request = new UpdateHotelSceneBookItemShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateHotelSceneBookReq))
            {
                request.UpdateHotelSceneBookReqShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateHotelSceneBookReq, "UpdateHotelSceneBookReq", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateHotelSceneBookReqShrink))
            {
                query["UpdateHotelSceneBookReq"] = request.UpdateHotelSceneBookReqShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "UpdateHotelSceneBookItem",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/updateHotelSceneBookItem",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHotelSceneBookItemResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateHotelSceneBookItemResponse> UpdateHotelSceneBookItemWithOptionsAsync(UpdateHotelSceneBookItemRequest tmpReq, UpdateHotelSceneBookItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateHotelSceneBookItemShrinkRequest request = new UpdateHotelSceneBookItemShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateHotelSceneBookReq))
            {
                request.UpdateHotelSceneBookReqShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateHotelSceneBookReq, "UpdateHotelSceneBookReq", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateHotelSceneBookReqShrink))
            {
                query["UpdateHotelSceneBookReq"] = request.UpdateHotelSceneBookReqShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "UpdateHotelSceneBookItem",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/updateHotelSceneBookItem",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHotelSceneBookItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateHotelSceneBookItemResponse UpdateHotelSceneBookItem(UpdateHotelSceneBookItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHotelSceneBookItemHeaders headers = new UpdateHotelSceneBookItemHeaders();
            return UpdateHotelSceneBookItemWithOptions(request, headers, runtime);
        }

        public async Task<UpdateHotelSceneBookItemResponse> UpdateHotelSceneBookItemAsync(UpdateHotelSceneBookItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHotelSceneBookItemHeaders headers = new UpdateHotelSceneBookItemHeaders();
            return await UpdateHotelSceneBookItemWithOptionsAsync(request, headers, runtime);
        }

        public UpdateHotelSceneItemResponse UpdateHotelSceneItemWithOptions(UpdateHotelSceneItemRequest tmpReq, UpdateHotelSceneItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateHotelSceneItemShrinkRequest request = new UpdateHotelSceneItemShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateHotelSceneOperateReq))
            {
                request.UpdateHotelSceneOperateReqShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateHotelSceneOperateReq, "UpdateHotelSceneOperateReq", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateHotelSceneReq))
            {
                request.UpdateHotelSceneReqShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateHotelSceneReq, "UpdateHotelSceneReq", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateHotelSceneOperateReqShrink))
            {
                query["UpdateHotelSceneOperateReq"] = request.UpdateHotelSceneOperateReqShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateHotelSceneReqShrink))
            {
                query["UpdateHotelSceneReq"] = request.UpdateHotelSceneReqShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "UpdateHotelSceneItem",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/updateHotelSceneItem",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHotelSceneItemResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateHotelSceneItemResponse> UpdateHotelSceneItemWithOptionsAsync(UpdateHotelSceneItemRequest tmpReq, UpdateHotelSceneItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateHotelSceneItemShrinkRequest request = new UpdateHotelSceneItemShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateHotelSceneOperateReq))
            {
                request.UpdateHotelSceneOperateReqShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateHotelSceneOperateReq, "UpdateHotelSceneOperateReq", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateHotelSceneReq))
            {
                request.UpdateHotelSceneReqShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateHotelSceneReq, "UpdateHotelSceneReq", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateHotelSceneOperateReqShrink))
            {
                query["UpdateHotelSceneOperateReq"] = request.UpdateHotelSceneOperateReqShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateHotelSceneReqShrink))
            {
                query["UpdateHotelSceneReq"] = request.UpdateHotelSceneReqShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
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
                Action = "UpdateHotelSceneItem",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/updateHotelSceneItem",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHotelSceneItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateHotelSceneItemResponse UpdateHotelSceneItem(UpdateHotelSceneItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHotelSceneItemHeaders headers = new UpdateHotelSceneItemHeaders();
            return UpdateHotelSceneItemWithOptions(request, headers, runtime);
        }

        public async Task<UpdateHotelSceneItemResponse> UpdateHotelSceneItemAsync(UpdateHotelSceneItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHotelSceneItemHeaders headers = new UpdateHotelSceneItemHeaders();
            return await UpdateHotelSceneItemWithOptionsAsync(request, headers, runtime);
        }

        public UpdateMessageTemplateResponse UpdateMessageTemplateWithOptions(UpdateMessageTemplateRequest request, UpdateMessageTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateDetail))
            {
                body["TemplateDetail"] = request.TemplateDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
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
                Action = "UpdateMessageTemplate",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/updateMessageTemplate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMessageTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateMessageTemplateResponse> UpdateMessageTemplateWithOptionsAsync(UpdateMessageTemplateRequest request, UpdateMessageTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateDetail))
            {
                body["TemplateDetail"] = request.TemplateDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
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
                Action = "UpdateMessageTemplate",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/updateMessageTemplate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMessageTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateMessageTemplateResponse UpdateMessageTemplate(UpdateMessageTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMessageTemplateHeaders headers = new UpdateMessageTemplateHeaders();
            return UpdateMessageTemplateWithOptions(request, headers, runtime);
        }

        public async Task<UpdateMessageTemplateResponse> UpdateMessageTemplateAsync(UpdateMessageTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMessageTemplateHeaders headers = new UpdateMessageTemplateHeaders();
            return await UpdateMessageTemplateWithOptionsAsync(request, headers, runtime);
        }

        public UpdateRcuSceneResponse UpdateRcuSceneWithOptions(UpdateRcuSceneRequest tmpReq, UpdateRcuSceneHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateRcuSceneShrinkRequest request = new UpdateRcuSceneShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SceneRelationExtDTO))
            {
                request.SceneRelationExtDTOShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SceneRelationExtDTO, "SceneRelationExtDTO", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneRelationExtDTOShrink))
            {
                body["SceneRelationExtDTO"] = request.SceneRelationExtDTOShrink;
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
                Action = "UpdateRcuScene",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/updateRcuScene",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRcuSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateRcuSceneResponse> UpdateRcuSceneWithOptionsAsync(UpdateRcuSceneRequest tmpReq, UpdateRcuSceneHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateRcuSceneShrinkRequest request = new UpdateRcuSceneShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SceneRelationExtDTO))
            {
                request.SceneRelationExtDTOShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SceneRelationExtDTO, "SceneRelationExtDTO", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneRelationExtDTOShrink))
            {
                body["SceneRelationExtDTO"] = request.SceneRelationExtDTOShrink;
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
                Action = "UpdateRcuScene",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/updateRcuScene",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRcuSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateRcuSceneResponse UpdateRcuScene(UpdateRcuSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRcuSceneHeaders headers = new UpdateRcuSceneHeaders();
            return UpdateRcuSceneWithOptions(request, headers, runtime);
        }

        public async Task<UpdateRcuSceneResponse> UpdateRcuSceneAsync(UpdateRcuSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRcuSceneHeaders headers = new UpdateRcuSceneHeaders();
            return await UpdateRcuSceneWithOptionsAsync(request, headers, runtime);
        }

        public UpdateServiceQAResponse UpdateServiceQAWithOptions(UpdateServiceQARequest request, UpdateServiceQAHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Answer))
            {
                body["Answer"] = request.Answer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceQAId))
            {
                body["ServiceQAId"] = request.ServiceQAId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsActive))
            {
                body["isActive"] = request.IsActive;
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
                Action = "UpdateServiceQA",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/updateServiceQA",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceQAResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateServiceQAResponse> UpdateServiceQAWithOptionsAsync(UpdateServiceQARequest request, UpdateServiceQAHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Answer))
            {
                body["Answer"] = request.Answer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceQAId))
            {
                body["ServiceQAId"] = request.ServiceQAId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsActive))
            {
                body["isActive"] = request.IsActive;
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
                Action = "UpdateServiceQA",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/updateServiceQA",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceQAResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateServiceQAResponse UpdateServiceQA(UpdateServiceQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateServiceQAHeaders headers = new UpdateServiceQAHeaders();
            return UpdateServiceQAWithOptions(request, headers, runtime);
        }

        public async Task<UpdateServiceQAResponse> UpdateServiceQAAsync(UpdateServiceQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateServiceQAHeaders headers = new UpdateServiceQAHeaders();
            return await UpdateServiceQAWithOptionsAsync(request, headers, runtime);
        }

        public UpdateTicketResponse UpdateTicketWithOptions(UpdateTicketRequest request, UpdateTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupKey))
            {
                body["GroupKey"] = request.GroupKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
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
                Action = "UpdateTicket",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/updateTicket",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTicketResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTicketResponse> UpdateTicketWithOptionsAsync(UpdateTicketRequest request, UpdateTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupKey))
            {
                body["GroupKey"] = request.GroupKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
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
                Action = "UpdateTicket",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/updateTicket",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTicketResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTicketResponse UpdateTicket(UpdateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTicketHeaders headers = new UpdateTicketHeaders();
            return UpdateTicketWithOptions(request, headers, runtime);
        }

        public async Task<UpdateTicketResponse> UpdateTicketAsync(UpdateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTicketHeaders headers = new UpdateTicketHeaders();
            return await UpdateTicketWithOptionsAsync(request, headers, runtime);
        }

    }
}
