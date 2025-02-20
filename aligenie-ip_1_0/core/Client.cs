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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加动画</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCartoonRequest
        /// </param>
        /// <param name="headers">
        /// AddCartoonHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCartoonResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddCartoonResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddCartoonResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加动画</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCartoonRequest
        /// </param>
        /// <param name="headers">
        /// AddCartoonHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCartoonResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddCartoonResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddCartoonResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加动画</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCartoonRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCartoonResponse
        /// </returns>
        public AddCartoonResponse AddCartoon(AddCartoonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCartoonHeaders headers = new AddCartoonHeaders();
            return AddCartoonWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加动画</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCartoonRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCartoonResponse
        /// </returns>
        public async Task<AddCartoonResponse> AddCartoonAsync(AddCartoonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCartoonHeaders headers = new AddCartoonHeaders();
            return await AddCartoonWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增自定义问答</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddCustomQARequest
        /// </param>
        /// <param name="headers">
        /// AddCustomQAHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCustomQAResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddCustomQAResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddCustomQAResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增自定义问答</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddCustomQARequest
        /// </param>
        /// <param name="headers">
        /// AddCustomQAHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCustomQAResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddCustomQAResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddCustomQAResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增自定义问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCustomQARequest
        /// </param>
        /// 
        /// <returns>
        /// AddCustomQAResponse
        /// </returns>
        public AddCustomQAResponse AddCustomQA(AddCustomQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCustomQAHeaders headers = new AddCustomQAHeaders();
            return AddCustomQAWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增自定义问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCustomQARequest
        /// </param>
        /// 
        /// <returns>
        /// AddCustomQAResponse
        /// </returns>
        public async Task<AddCustomQAResponse> AddCustomQAAsync(AddCustomQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCustomQAHeaders headers = new AddCustomQAHeaders();
            return await AddCustomQAWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加问答V2</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddCustomQAV2Request
        /// </param>
        /// <param name="headers">
        /// AddCustomQAV2Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCustomQAV2Response
        /// </returns>
        public AddCustomQAV2Response AddCustomQAV2WithOptions(AddCustomQAV2Request tmpReq, AddCustomQAV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddCustomQAV2ShrinkRequest request = new AddCustomQAV2ShrinkRequest();
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
                Action = "AddCustomQAV2",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/addQAV2",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddCustomQAV2Response>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddCustomQAV2Response>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加问答V2</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddCustomQAV2Request
        /// </param>
        /// <param name="headers">
        /// AddCustomQAV2Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCustomQAV2Response
        /// </returns>
        public async Task<AddCustomQAV2Response> AddCustomQAV2WithOptionsAsync(AddCustomQAV2Request tmpReq, AddCustomQAV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddCustomQAV2ShrinkRequest request = new AddCustomQAV2ShrinkRequest();
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
                Action = "AddCustomQAV2",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/addQAV2",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddCustomQAV2Response>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddCustomQAV2Response>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加问答V2</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCustomQAV2Request
        /// </param>
        /// 
        /// <returns>
        /// AddCustomQAV2Response
        /// </returns>
        public AddCustomQAV2Response AddCustomQAV2(AddCustomQAV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCustomQAV2Headers headers = new AddCustomQAV2Headers();
            return AddCustomQAV2WithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加问答V2</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCustomQAV2Request
        /// </param>
        /// 
        /// <returns>
        /// AddCustomQAV2Response
        /// </returns>
        public async Task<AddCustomQAV2Response> AddCustomQAV2Async(AddCustomQAV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCustomQAV2Headers headers = new AddCustomQAV2Headers();
            return await AddCustomQAV2WithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加消息模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMessageTemplateRequest
        /// </param>
        /// <param name="headers">
        /// AddMessageTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddMessageTemplateResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddMessageTemplateResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddMessageTemplateResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加消息模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMessageTemplateRequest
        /// </param>
        /// <param name="headers">
        /// AddMessageTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddMessageTemplateResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddMessageTemplateResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddMessageTemplateResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加消息模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMessageTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// AddMessageTemplateResponse
        /// </returns>
        public AddMessageTemplateResponse AddMessageTemplate(AddMessageTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddMessageTemplateHeaders headers = new AddMessageTemplateHeaders();
            return AddMessageTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加消息模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMessageTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// AddMessageTemplateResponse
        /// </returns>
        public async Task<AddMessageTemplateResponse> AddMessageTemplateAsync(AddMessageTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddMessageTemplateHeaders headers = new AddMessageTemplateHeaders();
            return await AddMessageTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或者编辑带屏展示模式</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddOrUpdateDisPlayModesRequest
        /// </param>
        /// <param name="headers">
        /// AddOrUpdateDisPlayModesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddOrUpdateDisPlayModesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddOrUpdateDisPlayModesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddOrUpdateDisPlayModesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或者编辑带屏展示模式</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddOrUpdateDisPlayModesRequest
        /// </param>
        /// <param name="headers">
        /// AddOrUpdateDisPlayModesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddOrUpdateDisPlayModesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddOrUpdateDisPlayModesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddOrUpdateDisPlayModesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或者编辑带屏展示模式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrUpdateDisPlayModesRequest
        /// </param>
        /// 
        /// <returns>
        /// AddOrUpdateDisPlayModesResponse
        /// </returns>
        public AddOrUpdateDisPlayModesResponse AddOrUpdateDisPlayModes(AddOrUpdateDisPlayModesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrUpdateDisPlayModesHeaders headers = new AddOrUpdateDisPlayModesHeaders();
            return AddOrUpdateDisPlayModesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或者编辑带屏展示模式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrUpdateDisPlayModesRequest
        /// </param>
        /// 
        /// <returns>
        /// AddOrUpdateDisPlayModesResponse
        /// </returns>
        public async Task<AddOrUpdateDisPlayModesResponse> AddOrUpdateDisPlayModesAsync(AddOrUpdateDisPlayModesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrUpdateDisPlayModesHeaders headers = new AddOrUpdateDisPlayModesHeaders();
            return await AddOrUpdateDisPlayModesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或者编辑定制配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddOrUpdateHotelSettingRequest
        /// </param>
        /// <param name="headers">
        /// AddOrUpdateHotelSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddOrUpdateHotelSettingResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddOrUpdateHotelSettingResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddOrUpdateHotelSettingResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或者编辑定制配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddOrUpdateHotelSettingRequest
        /// </param>
        /// <param name="headers">
        /// AddOrUpdateHotelSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddOrUpdateHotelSettingResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddOrUpdateHotelSettingResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddOrUpdateHotelSettingResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或者编辑定制配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrUpdateHotelSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// AddOrUpdateHotelSettingResponse
        /// </returns>
        public AddOrUpdateHotelSettingResponse AddOrUpdateHotelSetting(AddOrUpdateHotelSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrUpdateHotelSettingHeaders headers = new AddOrUpdateHotelSettingHeaders();
            return AddOrUpdateHotelSettingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或者编辑定制配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrUpdateHotelSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// AddOrUpdateHotelSettingResponse
        /// </returns>
        public async Task<AddOrUpdateHotelSettingResponse> AddOrUpdateHotelSettingAsync(AddOrUpdateHotelSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrUpdateHotelSettingHeaders headers = new AddOrUpdateHotelSettingHeaders();
            return await AddOrUpdateHotelSettingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或者编辑带屏屏保</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddOrUpdateScreenSaverRequest
        /// </param>
        /// <param name="headers">
        /// AddOrUpdateScreenSaverHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddOrUpdateScreenSaverResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddOrUpdateScreenSaverResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddOrUpdateScreenSaverResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或者编辑带屏屏保</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddOrUpdateScreenSaverRequest
        /// </param>
        /// <param name="headers">
        /// AddOrUpdateScreenSaverHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddOrUpdateScreenSaverResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddOrUpdateScreenSaverResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddOrUpdateScreenSaverResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或者编辑带屏屏保</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrUpdateScreenSaverRequest
        /// </param>
        /// 
        /// <returns>
        /// AddOrUpdateScreenSaverResponse
        /// </returns>
        public AddOrUpdateScreenSaverResponse AddOrUpdateScreenSaver(AddOrUpdateScreenSaverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrUpdateScreenSaverHeaders headers = new AddOrUpdateScreenSaverHeaders();
            return AddOrUpdateScreenSaverWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或者编辑带屏屏保</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrUpdateScreenSaverRequest
        /// </param>
        /// 
        /// <returns>
        /// AddOrUpdateScreenSaverResponse
        /// </returns>
        public async Task<AddOrUpdateScreenSaverResponse> AddOrUpdateScreenSaverAsync(AddOrUpdateScreenSaverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrUpdateScreenSaverHeaders headers = new AddOrUpdateScreenSaverHeaders();
            return await AddOrUpdateScreenSaverWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加/更新欢迎语信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrUpdateWelcomeTextRequest
        /// </param>
        /// <param name="headers">
        /// AddOrUpdateWelcomeTextHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddOrUpdateWelcomeTextResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddOrUpdateWelcomeTextResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddOrUpdateWelcomeTextResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加/更新欢迎语信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrUpdateWelcomeTextRequest
        /// </param>
        /// <param name="headers">
        /// AddOrUpdateWelcomeTextHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddOrUpdateWelcomeTextResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddOrUpdateWelcomeTextResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddOrUpdateWelcomeTextResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加/更新欢迎语信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrUpdateWelcomeTextRequest
        /// </param>
        /// 
        /// <returns>
        /// AddOrUpdateWelcomeTextResponse
        /// </returns>
        public AddOrUpdateWelcomeTextResponse AddOrUpdateWelcomeText(AddOrUpdateWelcomeTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrUpdateWelcomeTextHeaders headers = new AddOrUpdateWelcomeTextHeaders();
            return AddOrUpdateWelcomeTextWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加/更新欢迎语信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrUpdateWelcomeTextRequest
        /// </param>
        /// 
        /// <returns>
        /// AddOrUpdateWelcomeTextResponse
        /// </returns>
        public async Task<AddOrUpdateWelcomeTextResponse> AddOrUpdateWelcomeTextAsync(AddOrUpdateWelcomeTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrUpdateWelcomeTextHeaders headers = new AddOrUpdateWelcomeTextHeaders();
            return await AddOrUpdateWelcomeTextWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>审批酒店</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AuditHotelRequest
        /// </param>
        /// <param name="headers">
        /// AuditHotelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuditHotelResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AuditHotelResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AuditHotelResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>审批酒店</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AuditHotelRequest
        /// </param>
        /// <param name="headers">
        /// AuditHotelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuditHotelResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AuditHotelResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AuditHotelResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>审批酒店</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AuditHotelRequest
        /// </param>
        /// 
        /// <returns>
        /// AuditHotelResponse
        /// </returns>
        public AuditHotelResponse AuditHotel(AuditHotelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AuditHotelHeaders headers = new AuditHotelHeaders();
            return AuditHotelWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>审批酒店</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AuditHotelRequest
        /// </param>
        /// 
        /// <returns>
        /// AuditHotelResponse
        /// </returns>
        public async Task<AuditHotelResponse> AuditHotelAsync(AuditHotelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AuditHotelHeaders headers = new AuditHotelHeaders();
            return await AuditHotelWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建房间</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchAddHotelRoomRequest
        /// </param>
        /// <param name="headers">
        /// BatchAddHotelRoomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchAddHotelRoomResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BatchAddHotelRoomResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BatchAddHotelRoomResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建房间</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchAddHotelRoomRequest
        /// </param>
        /// <param name="headers">
        /// BatchAddHotelRoomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchAddHotelRoomResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BatchAddHotelRoomResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BatchAddHotelRoomResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建房间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddHotelRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchAddHotelRoomResponse
        /// </returns>
        public BatchAddHotelRoomResponse BatchAddHotelRoom(BatchAddHotelRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchAddHotelRoomHeaders headers = new BatchAddHotelRoomHeaders();
            return BatchAddHotelRoomWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建房间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddHotelRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchAddHotelRoomResponse
        /// </returns>
        public async Task<BatchAddHotelRoomResponse> BatchAddHotelRoomAsync(BatchAddHotelRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchAddHotelRoomHeaders headers = new BatchAddHotelRoomHeaders();
            return await BatchAddHotelRoomWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除房间</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchDeleteHotelRoomRequest
        /// </param>
        /// <param name="headers">
        /// BatchDeleteHotelRoomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteHotelRoomResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BatchDeleteHotelRoomResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BatchDeleteHotelRoomResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除房间</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchDeleteHotelRoomRequest
        /// </param>
        /// <param name="headers">
        /// BatchDeleteHotelRoomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteHotelRoomResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BatchDeleteHotelRoomResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BatchDeleteHotelRoomResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除房间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteHotelRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteHotelRoomResponse
        /// </returns>
        public BatchDeleteHotelRoomResponse BatchDeleteHotelRoom(BatchDeleteHotelRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchDeleteHotelRoomHeaders headers = new BatchDeleteHotelRoomHeaders();
            return BatchDeleteHotelRoomWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除房间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteHotelRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteHotelRoomResponse
        /// </returns>
        public async Task<BatchDeleteHotelRoomResponse> BatchDeleteHotelRoomAsync(BatchDeleteHotelRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchDeleteHotelRoomHeaders headers = new BatchDeleteHotelRoomHeaders();
            return await BatchDeleteHotelRoomWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店退房，清楚例如闹钟等定时信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckoutWithAKRequest
        /// </param>
        /// <param name="headers">
        /// CheckoutWithAKHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckoutWithAKResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CheckoutWithAKResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CheckoutWithAKResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店退房，清楚例如闹钟等定时信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckoutWithAKRequest
        /// </param>
        /// <param name="headers">
        /// CheckoutWithAKHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckoutWithAKResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CheckoutWithAKResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CheckoutWithAKResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店退房，清楚例如闹钟等定时信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckoutWithAKRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckoutWithAKResponse
        /// </returns>
        public CheckoutWithAKResponse CheckoutWithAK(CheckoutWithAKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckoutWithAKHeaders headers = new CheckoutWithAKHeaders();
            return CheckoutWithAKWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店退房，清楚例如闹钟等定时信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckoutWithAKRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckoutWithAKResponse
        /// </returns>
        public async Task<CheckoutWithAKResponse> CheckoutWithAKAsync(CheckoutWithAKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckoutWithAKHeaders headers = new CheckoutWithAKHeaders();
            return await CheckoutWithAKWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>子账号授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChildAccountAuthRequest
        /// </param>
        /// <param name="headers">
        /// ChildAccountAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChildAccountAuthResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ChildAccountAuthResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ChildAccountAuthResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>子账号授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChildAccountAuthRequest
        /// </param>
        /// <param name="headers">
        /// ChildAccountAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChildAccountAuthResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ChildAccountAuthResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ChildAccountAuthResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>子账号授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChildAccountAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// ChildAccountAuthResponse
        /// </returns>
        public ChildAccountAuthResponse ChildAccountAuth(ChildAccountAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChildAccountAuthHeaders headers = new ChildAccountAuthHeaders();
            return ChildAccountAuthWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>子账号授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChildAccountAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// ChildAccountAuthResponse
        /// </returns>
        public async Task<ChildAccountAuthResponse> ChildAccountAuthAsync(ChildAccountAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChildAccountAuthHeaders headers = new ChildAccountAuthHeaders();
            return await ChildAccountAuthWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>控制房间内设备</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ControlRoomDeviceRequest
        /// </param>
        /// <param name="headers">
        /// ControlRoomDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ControlRoomDeviceResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ControlRoomDeviceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ControlRoomDeviceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>控制房间内设备</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ControlRoomDeviceRequest
        /// </param>
        /// <param name="headers">
        /// ControlRoomDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ControlRoomDeviceResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ControlRoomDeviceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ControlRoomDeviceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>控制房间内设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ControlRoomDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// ControlRoomDeviceResponse
        /// </returns>
        public ControlRoomDeviceResponse ControlRoomDevice(ControlRoomDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ControlRoomDeviceHeaders headers = new ControlRoomDeviceHeaders();
            return ControlRoomDeviceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>控制房间内设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ControlRoomDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// ControlRoomDeviceResponse
        /// </returns>
        public async Task<ControlRoomDeviceResponse> ControlRoomDeviceAsync(ControlRoomDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ControlRoomDeviceHeaders headers = new ControlRoomDeviceHeaders();
            return await ControlRoomDeviceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建酒店项目</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateHotelRequest
        /// </param>
        /// <param name="headers">
        /// CreateHotelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateHotelResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateHotelResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateHotelResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建酒店项目</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateHotelRequest
        /// </param>
        /// <param name="headers">
        /// CreateHotelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateHotelResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateHotelResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateHotelResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建酒店项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHotelRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateHotelResponse
        /// </returns>
        public CreateHotelResponse CreateHotel(CreateHotelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateHotelHeaders headers = new CreateHotelHeaders();
            return CreateHotelWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建酒店项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHotelRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateHotelResponse
        /// </returns>
        public async Task<CreateHotelResponse> CreateHotelAsync(CreateHotelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateHotelHeaders headers = new CreateHotelHeaders();
            return await CreateHotelWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建闹钟</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateHotelAlarmRequest
        /// </param>
        /// <param name="headers">
        /// CreateHotelAlarmHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateHotelAlarmResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateHotelAlarmResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateHotelAlarmResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建闹钟</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateHotelAlarmRequest
        /// </param>
        /// <param name="headers">
        /// CreateHotelAlarmHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateHotelAlarmResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateHotelAlarmResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateHotelAlarmResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建闹钟</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHotelAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateHotelAlarmResponse
        /// </returns>
        public CreateHotelAlarmResponse CreateHotelAlarm(CreateHotelAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateHotelAlarmHeaders headers = new CreateHotelAlarmHeaders();
            return CreateHotelAlarmWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量创建闹钟</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHotelAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateHotelAlarmResponse
        /// </returns>
        public async Task<CreateHotelAlarmResponse> CreateHotelAlarmAsync(CreateHotelAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateHotelAlarmHeaders headers = new CreateHotelAlarmHeaders();
            return await CreateHotelAlarmWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店rcu自定义场景创建</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateRcuSceneRequest
        /// </param>
        /// <param name="headers">
        /// CreateRcuSceneHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRcuSceneResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateRcuSceneResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateRcuSceneResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店rcu自定义场景创建</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateRcuSceneRequest
        /// </param>
        /// <param name="headers">
        /// CreateRcuSceneHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRcuSceneResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateRcuSceneResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateRcuSceneResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店rcu自定义场景创建</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRcuSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRcuSceneResponse
        /// </returns>
        public CreateRcuSceneResponse CreateRcuScene(CreateRcuSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateRcuSceneHeaders headers = new CreateRcuSceneHeaders();
            return CreateRcuSceneWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店rcu自定义场景创建</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRcuSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRcuSceneResponse
        /// </returns>
        public async Task<CreateRcuSceneResponse> CreateRcuSceneAsync(CreateRcuSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateRcuSceneHeaders headers = new CreateRcuSceneHeaders();
            return await CreateRcuSceneWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除动画</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCartoonRequest
        /// </param>
        /// <param name="headers">
        /// DeleteCartoonHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCartoonResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteCartoonResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteCartoonResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除动画</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCartoonRequest
        /// </param>
        /// <param name="headers">
        /// DeleteCartoonHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCartoonResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteCartoonResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteCartoonResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除动画</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCartoonRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCartoonResponse
        /// </returns>
        public DeleteCartoonResponse DeleteCartoon(DeleteCartoonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCartoonHeaders headers = new DeleteCartoonHeaders();
            return DeleteCartoonWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除动画</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCartoonRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCartoonResponse
        /// </returns>
        public async Task<DeleteCartoonResponse> DeleteCartoonAsync(DeleteCartoonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCartoonHeaders headers = new DeleteCartoonHeaders();
            return await DeleteCartoonWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义问答</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteCustomQARequest
        /// </param>
        /// <param name="headers">
        /// DeleteCustomQAHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomQAResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteCustomQAResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteCustomQAResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义问答</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteCustomQARequest
        /// </param>
        /// <param name="headers">
        /// DeleteCustomQAHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomQAResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteCustomQAResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteCustomQAResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomQARequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomQAResponse
        /// </returns>
        public DeleteCustomQAResponse DeleteCustomQA(DeleteCustomQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCustomQAHeaders headers = new DeleteCustomQAHeaders();
            return DeleteCustomQAWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomQARequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomQAResponse
        /// </returns>
        public async Task<DeleteCustomQAResponse> DeleteCustomQAAsync(DeleteCustomQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCustomQAHeaders headers = new DeleteCustomQAHeaders();
            return await DeleteCustomQAWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除酒店闹钟</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteHotelAlarmRequest
        /// </param>
        /// <param name="headers">
        /// DeleteHotelAlarmHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteHotelAlarmResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteHotelAlarmResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteHotelAlarmResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除酒店闹钟</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteHotelAlarmRequest
        /// </param>
        /// <param name="headers">
        /// DeleteHotelAlarmHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteHotelAlarmResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteHotelAlarmResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteHotelAlarmResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除酒店闹钟</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHotelAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteHotelAlarmResponse
        /// </returns>
        public DeleteHotelAlarmResponse DeleteHotelAlarm(DeleteHotelAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteHotelAlarmHeaders headers = new DeleteHotelAlarmHeaders();
            return DeleteHotelAlarmWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除酒店闹钟</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHotelAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteHotelAlarmResponse
        /// </returns>
        public async Task<DeleteHotelAlarmResponse> DeleteHotelAlarmAsync(DeleteHotelAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteHotelAlarmHeaders headers = new DeleteHotelAlarmHeaders();
            return await DeleteHotelAlarmWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景预订删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHotelSceneBookItemRequest
        /// </param>
        /// <param name="headers">
        /// DeleteHotelSceneBookItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteHotelSceneBookItemResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteHotelSceneBookItemResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteHotelSceneBookItemResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景预订删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHotelSceneBookItemRequest
        /// </param>
        /// <param name="headers">
        /// DeleteHotelSceneBookItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteHotelSceneBookItemResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteHotelSceneBookItemResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteHotelSceneBookItemResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景预订删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHotelSceneBookItemRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteHotelSceneBookItemResponse
        /// </returns>
        public DeleteHotelSceneBookItemResponse DeleteHotelSceneBookItem(DeleteHotelSceneBookItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteHotelSceneBookItemHeaders headers = new DeleteHotelSceneBookItemHeaders();
            return DeleteHotelSceneBookItemWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景预订删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHotelSceneBookItemRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteHotelSceneBookItemResponse
        /// </returns>
        public async Task<DeleteHotelSceneBookItemResponse> DeleteHotelSceneBookItemAsync(DeleteHotelSceneBookItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteHotelSceneBookItemHeaders headers = new DeleteHotelSceneBookItemHeaders();
            return await DeleteHotelSceneBookItemWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除定制配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHotelSettingRequest
        /// </param>
        /// <param name="headers">
        /// DeleteHotelSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteHotelSettingResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteHotelSettingResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteHotelSettingResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除定制配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHotelSettingRequest
        /// </param>
        /// <param name="headers">
        /// DeleteHotelSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteHotelSettingResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteHotelSettingResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteHotelSettingResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除定制配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHotelSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteHotelSettingResponse
        /// </returns>
        public DeleteHotelSettingResponse DeleteHotelSetting(DeleteHotelSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteHotelSettingHeaders headers = new DeleteHotelSettingHeaders();
            return DeleteHotelSettingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除定制配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHotelSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteHotelSettingResponse
        /// </returns>
        public async Task<DeleteHotelSettingResponse> DeleteHotelSettingAsync(DeleteHotelSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteHotelSettingHeaders headers = new DeleteHotelSettingHeaders();
            return await DeleteHotelSettingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除消息通知模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMessageTemplateRequest
        /// </param>
        /// <param name="headers">
        /// DeleteMessageTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMessageTemplateResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteMessageTemplateResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteMessageTemplateResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除消息通知模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMessageTemplateRequest
        /// </param>
        /// <param name="headers">
        /// DeleteMessageTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMessageTemplateResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteMessageTemplateResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteMessageTemplateResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除消息通知模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMessageTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMessageTemplateResponse
        /// </returns>
        public DeleteMessageTemplateResponse DeleteMessageTemplate(DeleteMessageTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMessageTemplateHeaders headers = new DeleteMessageTemplateHeaders();
            return DeleteMessageTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除消息通知模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMessageTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMessageTemplateResponse
        /// </returns>
        public async Task<DeleteMessageTemplateResponse> DeleteMessageTemplateAsync(DeleteMessageTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMessageTemplateHeaders headers = new DeleteMessageTemplateHeaders();
            return await DeleteMessageTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除酒店自定义rcu场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRcuSceneRequest
        /// </param>
        /// <param name="headers">
        /// DeleteRcuSceneHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRcuSceneResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteRcuSceneResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteRcuSceneResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除酒店自定义rcu场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRcuSceneRequest
        /// </param>
        /// <param name="headers">
        /// DeleteRcuSceneHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRcuSceneResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteRcuSceneResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteRcuSceneResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除酒店自定义rcu场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRcuSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRcuSceneResponse
        /// </returns>
        public DeleteRcuSceneResponse DeleteRcuScene(DeleteRcuSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRcuSceneHeaders headers = new DeleteRcuSceneHeaders();
            return DeleteRcuSceneWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除酒店自定义rcu场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRcuSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRcuSceneResponse
        /// </returns>
        public async Task<DeleteRcuSceneResponse> DeleteRcuSceneAsync(DeleteRcuSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRcuSceneHeaders headers = new DeleteRcuSceneHeaders();
            return await DeleteRcuSceneWithOptionsAsync(request, headers, runtime);
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeviceControlResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeviceControlResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeviceControlResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeviceControlResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
        /// <para>控制房间场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteSceneRequest
        /// </param>
        /// <param name="headers">
        /// ExecuteSceneHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSceneResponse
        /// </returns>
        public ExecuteSceneResponse ExecuteSceneWithOptions(ExecuteSceneRequest request, ExecuteSceneHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneName))
            {
                body["SceneName"] = request.SceneName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
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
                Action = "ExecuteScene",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/executeScene",
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
        /// <para>控制房间场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteSceneRequest
        /// </param>
        /// <param name="headers">
        /// ExecuteSceneHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSceneResponse
        /// </returns>
        public async Task<ExecuteSceneResponse> ExecuteSceneWithOptionsAsync(ExecuteSceneRequest request, ExecuteSceneHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneName))
            {
                body["SceneName"] = request.SceneName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
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
                Action = "ExecuteScene",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/executeScene",
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
        /// <para>控制房间场景</para>
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
            ExecuteSceneHeaders headers = new ExecuteSceneHeaders();
            return ExecuteSceneWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>控制房间场景</para>
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
            ExecuteSceneHeaders headers = new ExecuteSceneHeaders();
            return await ExecuteSceneWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取基础信息问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBasicInfoQARequest
        /// </param>
        /// <param name="headers">
        /// GetBasicInfoQAHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBasicInfoQAResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetBasicInfoQAResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetBasicInfoQAResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取基础信息问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBasicInfoQARequest
        /// </param>
        /// <param name="headers">
        /// GetBasicInfoQAHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBasicInfoQAResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetBasicInfoQAResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetBasicInfoQAResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取基础信息问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBasicInfoQARequest
        /// </param>
        /// 
        /// <returns>
        /// GetBasicInfoQAResponse
        /// </returns>
        public GetBasicInfoQAResponse GetBasicInfoQA(GetBasicInfoQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBasicInfoQAHeaders headers = new GetBasicInfoQAHeaders();
            return GetBasicInfoQAWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取基础信息问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBasicInfoQARequest
        /// </param>
        /// 
        /// <returns>
        /// GetBasicInfoQAResponse
        /// </returns>
        public async Task<GetBasicInfoQAResponse> GetBasicInfoQAAsync(GetBasicInfoQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBasicInfoQAHeaders headers = new GetBasicInfoQAHeaders();
            return await GetBasicInfoQAWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询动画</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCartoonRequest
        /// </param>
        /// <param name="headers">
        /// GetCartoonHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCartoonResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetCartoonResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetCartoonResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询动画</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCartoonRequest
        /// </param>
        /// <param name="headers">
        /// GetCartoonHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCartoonResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetCartoonResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetCartoonResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询动画</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCartoonRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCartoonResponse
        /// </returns>
        public GetCartoonResponse GetCartoon(GetCartoonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCartoonHeaders headers = new GetCartoonHeaders();
            return GetCartoonWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询动画</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCartoonRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCartoonResponse
        /// </returns>
        public async Task<GetCartoonResponse> GetCartoonAsync(GetCartoonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCartoonHeaders headers = new GetCartoonHeaders();
            return await GetCartoonWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前设备的通话信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotelContactByGenieDeviceRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelContactByGenieDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelContactByGenieDeviceResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelContactByGenieDeviceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelContactByGenieDeviceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前设备的通话信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotelContactByGenieDeviceRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelContactByGenieDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelContactByGenieDeviceResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelContactByGenieDeviceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelContactByGenieDeviceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前设备的通话信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelContactByGenieDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelContactByGenieDeviceResponse
        /// </returns>
        public GetHotelContactByGenieDeviceResponse GetHotelContactByGenieDevice(GetHotelContactByGenieDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelContactByGenieDeviceHeaders headers = new GetHotelContactByGenieDeviceHeaders();
            return GetHotelContactByGenieDeviceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前设备的通话信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelContactByGenieDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelContactByGenieDeviceResponse
        /// </returns>
        public async Task<GetHotelContactByGenieDeviceResponse> GetHotelContactByGenieDeviceAsync(GetHotelContactByGenieDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelContactByGenieDeviceHeaders headers = new GetHotelContactByGenieDeviceHeaders();
            return await GetHotelContactByGenieDeviceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据号码获取酒店联系人</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotelContactByNumberRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelContactByNumberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelContactByNumberResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelContactByNumberResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelContactByNumberResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据号码获取酒店联系人</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotelContactByNumberRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelContactByNumberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelContactByNumberResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelContactByNumberResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelContactByNumberResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据号码获取酒店联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelContactByNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelContactByNumberResponse
        /// </returns>
        public GetHotelContactByNumberResponse GetHotelContactByNumber(GetHotelContactByNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelContactByNumberHeaders headers = new GetHotelContactByNumberHeaders();
            return GetHotelContactByNumberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据号码获取酒店联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelContactByNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelContactByNumberResponse
        /// </returns>
        public async Task<GetHotelContactByNumberResponse> GetHotelContactByNumberAsync(GetHotelContactByNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelContactByNumberHeaders headers = new GetHotelContactByNumberHeaders();
            return await GetHotelContactByNumberWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店联系人</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotelContactsRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelContactsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelContactsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelContactsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelContactsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店联系人</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotelContactsRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelContactsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelContactsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelContactsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelContactsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelContactsResponse
        /// </returns>
        public GetHotelContactsResponse GetHotelContacts(GetHotelContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelContactsHeaders headers = new GetHotelContactsHeaders();
            return GetHotelContactsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelContactsResponse
        /// </returns>
        public async Task<GetHotelContactsResponse> GetHotelContactsAsync(GetHotelContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelContactsHeaders headers = new GetHotelContactsHeaders();
            return await GetHotelContactsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取首页背景图和场景模式</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotelHomeBackImageAndModesRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelHomeBackImageAndModesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelHomeBackImageAndModesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelHomeBackImageAndModesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelHomeBackImageAndModesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取首页背景图和场景模式</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotelHomeBackImageAndModesRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelHomeBackImageAndModesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelHomeBackImageAndModesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelHomeBackImageAndModesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelHomeBackImageAndModesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取首页背景图和场景模式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelHomeBackImageAndModesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelHomeBackImageAndModesResponse
        /// </returns>
        public GetHotelHomeBackImageAndModesResponse GetHotelHomeBackImageAndModes(GetHotelHomeBackImageAndModesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelHomeBackImageAndModesHeaders headers = new GetHotelHomeBackImageAndModesHeaders();
            return GetHotelHomeBackImageAndModesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取首页背景图和场景模式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelHomeBackImageAndModesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelHomeBackImageAndModesResponse
        /// </returns>
        public async Task<GetHotelHomeBackImageAndModesResponse> GetHotelHomeBackImageAndModesAsync(GetHotelHomeBackImageAndModesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelHomeBackImageAndModesHeaders headers = new GetHotelHomeBackImageAndModesHeaders();
            return await GetHotelHomeBackImageAndModesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店通知</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotelNoticeRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelNoticeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelNoticeResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelNoticeResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelNoticeResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店通知</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotelNoticeRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelNoticeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelNoticeResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelNoticeResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelNoticeResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店通知</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelNoticeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelNoticeResponse
        /// </returns>
        public GetHotelNoticeResponse GetHotelNotice(GetHotelNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelNoticeHeaders headers = new GetHotelNoticeHeaders();
            return GetHotelNoticeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店通知</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelNoticeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelNoticeResponse
        /// </returns>
        public async Task<GetHotelNoticeResponse> GetHotelNoticeAsync(GetHotelNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelNoticeHeaders headers = new GetHotelNoticeHeaders();
            return await GetHotelNoticeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店通知</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotelNoticeV2Request
        /// </param>
        /// <param name="headers">
        /// GetHotelNoticeV2Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelNoticeV2Response
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelNoticeV2Response>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelNoticeV2Response>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店通知</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotelNoticeV2Request
        /// </param>
        /// <param name="headers">
        /// GetHotelNoticeV2Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelNoticeV2Response
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelNoticeV2Response>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelNoticeV2Response>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店通知</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelNoticeV2Request
        /// </param>
        /// 
        /// <returns>
        /// GetHotelNoticeV2Response
        /// </returns>
        public GetHotelNoticeV2Response GetHotelNoticeV2(GetHotelNoticeV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelNoticeV2Headers headers = new GetHotelNoticeV2Headers();
            return GetHotelNoticeV2WithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店通知</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelNoticeV2Request
        /// </param>
        /// 
        /// <returns>
        /// GetHotelNoticeV2Response
        /// </returns>
        public async Task<GetHotelNoticeV2Response> GetHotelNoticeV2Async(GetHotelNoticeV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelNoticeV2Headers headers = new GetHotelNoticeV2Headers();
            return await GetHotelNoticeV2WithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店订单详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotelOrderDetailRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelOrderDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelOrderDetailResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelOrderDetailResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelOrderDetailResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店订单详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotelOrderDetailRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelOrderDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelOrderDetailResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelOrderDetailResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelOrderDetailResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店订单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelOrderDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelOrderDetailResponse
        /// </returns>
        public GetHotelOrderDetailResponse GetHotelOrderDetail(GetHotelOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelOrderDetailHeaders headers = new GetHotelOrderDetailHeaders();
            return GetHotelOrderDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店订单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelOrderDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelOrderDetailResponse
        /// </returns>
        public async Task<GetHotelOrderDetailResponse> GetHotelOrderDetailAsync(GetHotelOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelOrderDetailHeaders headers = new GetHotelOrderDetailHeaders();
            return await GetHotelOrderDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店房间猫精设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelRoomDeviceRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelRoomDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelRoomDeviceResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelRoomDeviceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelRoomDeviceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店房间猫精设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelRoomDeviceRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelRoomDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelRoomDeviceResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelRoomDeviceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelRoomDeviceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店房间猫精设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelRoomDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelRoomDeviceResponse
        /// </returns>
        public GetHotelRoomDeviceResponse GetHotelRoomDevice(GetHotelRoomDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelRoomDeviceHeaders headers = new GetHotelRoomDeviceHeaders();
            return GetHotelRoomDeviceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店房间猫精设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelRoomDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelRoomDeviceResponse
        /// </returns>
        public async Task<GetHotelRoomDeviceResponse> GetHotelRoomDeviceAsync(GetHotelRoomDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelRoomDeviceHeaders headers = new GetHotelRoomDeviceHeaders();
            return await GetHotelRoomDeviceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取推荐语料</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotelSampleUtterancesRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelSampleUtterancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelSampleUtterancesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelSampleUtterancesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelSampleUtterancesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取推荐语料</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotelSampleUtterancesRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelSampleUtterancesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelSampleUtterancesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelSampleUtterancesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelSampleUtterancesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取推荐语料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelSampleUtterancesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelSampleUtterancesResponse
        /// </returns>
        public GetHotelSampleUtterancesResponse GetHotelSampleUtterances(GetHotelSampleUtterancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelSampleUtterancesHeaders headers = new GetHotelSampleUtterancesHeaders();
            return GetHotelSampleUtterancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取推荐语料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelSampleUtterancesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelSampleUtterancesResponse
        /// </returns>
        public async Task<GetHotelSampleUtterancesResponse> GetHotelSampleUtterancesAsync(GetHotelSampleUtterancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelSampleUtterancesHeaders headers = new GetHotelSampleUtterancesHeaders();
            return await GetHotelSampleUtterancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelSceneItemDetailRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelSceneItemDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelSceneItemDetailResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelSceneItemDetailResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelSceneItemDetailResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelSceneItemDetailRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelSceneItemDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelSceneItemDetailResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelSceneItemDetailResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelSceneItemDetailResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelSceneItemDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelSceneItemDetailResponse
        /// </returns>
        public GetHotelSceneItemDetailResponse GetHotelSceneItemDetail(GetHotelSceneItemDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelSceneItemDetailHeaders headers = new GetHotelSceneItemDetailHeaders();
            return GetHotelSceneItemDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelSceneItemDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelSceneItemDetailResponse
        /// </returns>
        public async Task<GetHotelSceneItemDetailResponse> GetHotelSceneItemDetailAsync(GetHotelSceneItemDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelSceneItemDetailHeaders headers = new GetHotelSceneItemDetailHeaders();
            return await GetHotelSceneItemDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店屏保</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotelScreenSaverRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelScreenSaverHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelScreenSaverResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelScreenSaverResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelScreenSaverResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店屏保</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotelScreenSaverRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelScreenSaverHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelScreenSaverResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelScreenSaverResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelScreenSaverResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店屏保</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelScreenSaverRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelScreenSaverResponse
        /// </returns>
        public GetHotelScreenSaverResponse GetHotelScreenSaver(GetHotelScreenSaverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelScreenSaverHeaders headers = new GetHotelScreenSaverHeaders();
            return GetHotelScreenSaverWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店屏保</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelScreenSaverRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelScreenSaverResponse
        /// </returns>
        public async Task<GetHotelScreenSaverResponse> GetHotelScreenSaverAsync(GetHotelScreenSaverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelScreenSaverHeaders headers = new GetHotelScreenSaverHeaders();
            return await GetHotelScreenSaverWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取屏保列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelScreenSaverStyleRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelScreenSaverStyleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelScreenSaverStyleResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelScreenSaverStyleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelScreenSaverStyleResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取屏保列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelScreenSaverStyleRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelScreenSaverStyleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelScreenSaverStyleResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelScreenSaverStyleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelScreenSaverStyleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取屏保列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelScreenSaverStyleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelScreenSaverStyleResponse
        /// </returns>
        public GetHotelScreenSaverStyleResponse GetHotelScreenSaverStyle(GetHotelScreenSaverStyleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelScreenSaverStyleHeaders headers = new GetHotelScreenSaverStyleHeaders();
            return GetHotelScreenSaverStyleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取屏保列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelScreenSaverStyleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelScreenSaverStyleResponse
        /// </returns>
        public async Task<GetHotelScreenSaverStyleResponse> GetHotelScreenSaverStyleAsync(GetHotelScreenSaverStyleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelScreenSaverStyleHeaders headers = new GetHotelScreenSaverStyleHeaders();
            return await GetHotelScreenSaverStyleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询定制配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelSettingRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelSettingResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelSettingResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelSettingResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询定制配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelSettingRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelSettingResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHotelSettingResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHotelSettingResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询定制配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelSettingResponse
        /// </returns>
        public GetHotelSettingResponse GetHotelSetting(GetHotelSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelSettingHeaders headers = new GetHotelSettingHeaders();
            return GetHotelSettingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询定制配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelSettingResponse
        /// </returns>
        public async Task<GetHotelSettingResponse> GetHotelSettingAsync(GetHotelSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelSettingHeaders headers = new GetHotelSettingHeaders();
            return await GetHotelSettingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关联产品列表查看</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetRelationProductListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRelationProductListResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetRelationProductListResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetRelationProductListResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关联产品列表查看</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetRelationProductListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRelationProductListResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetRelationProductListResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetRelationProductListResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关联产品列表查看</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRelationProductListResponse
        /// </returns>
        public GetRelationProductListResponse GetRelationProductList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRelationProductListHeaders headers = new GetRelationProductListHeaders();
            return GetRelationProductListWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关联产品列表查看</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRelationProductListResponse
        /// </returns>
        public async Task<GetRelationProductListResponse> GetRelationProductListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRelationProductListHeaders headers = new GetRelationProductListHeaders();
            return await GetRelationProductListWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织下unionId列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUnionIdRequest
        /// </param>
        /// <param name="headers">
        /// GetUnionIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUnionIdResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetUnionIdResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetUnionIdResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织下unionId列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUnionIdRequest
        /// </param>
        /// <param name="headers">
        /// GetUnionIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUnionIdResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetUnionIdResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetUnionIdResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织下unionId列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUnionIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUnionIdResponse
        /// </returns>
        public GetUnionIdResponse GetUnionId(GetUnionIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUnionIdHeaders headers = new GetUnionIdHeaders();
            return GetUnionIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织下unionId列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUnionIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUnionIdResponse
        /// </returns>
        public async Task<GetUnionIdResponse> GetUnionIdAsync(GetUnionIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUnionIdHeaders headers = new GetUnionIdHeaders();
            return await GetUnionIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询欢迎语信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWelcomeTextAndMusicRequest
        /// </param>
        /// <param name="headers">
        /// GetWelcomeTextAndMusicHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWelcomeTextAndMusicResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetWelcomeTextAndMusicResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetWelcomeTextAndMusicResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询欢迎语信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWelcomeTextAndMusicRequest
        /// </param>
        /// <param name="headers">
        /// GetWelcomeTextAndMusicHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWelcomeTextAndMusicResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetWelcomeTextAndMusicResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetWelcomeTextAndMusicResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询欢迎语信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWelcomeTextAndMusicRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWelcomeTextAndMusicResponse
        /// </returns>
        public GetWelcomeTextAndMusicResponse GetWelcomeTextAndMusic(GetWelcomeTextAndMusicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWelcomeTextAndMusicHeaders headers = new GetWelcomeTextAndMusicHeaders();
            return GetWelcomeTextAndMusicWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询欢迎语信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWelcomeTextAndMusicRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWelcomeTextAndMusicResponse
        /// </returns>
        public async Task<GetWelcomeTextAndMusicResponse> GetWelcomeTextAndMusicAsync(GetWelcomeTextAndMusicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWelcomeTextAndMusicHeaders headers = new GetWelcomeTextAndMusicHeaders();
            return await GetWelcomeTextAndMusicWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店带屏设备扫码绑定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HotelQrBindRequest
        /// </param>
        /// <param name="headers">
        /// HotelQrBindHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HotelQrBindResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<HotelQrBindResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<HotelQrBindResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店带屏设备扫码绑定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HotelQrBindRequest
        /// </param>
        /// <param name="headers">
        /// HotelQrBindHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HotelQrBindResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<HotelQrBindResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<HotelQrBindResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店带屏设备扫码绑定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HotelQrBindRequest
        /// </param>
        /// 
        /// <returns>
        /// HotelQrBindResponse
        /// </returns>
        public HotelQrBindResponse HotelQrBind(HotelQrBindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelQrBindHeaders headers = new HotelQrBindHeaders();
            return HotelQrBindWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店带屏设备扫码绑定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HotelQrBindRequest
        /// </param>
        /// 
        /// <returns>
        /// HotelQrBindResponse
        /// </returns>
        public async Task<HotelQrBindResponse> HotelQrBindAsync(HotelQrBindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotelQrBindHeaders headers = new HotelQrBindHeaders();
            return await HotelQrBindWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量导入酒店配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ImportHotelConfigRequest
        /// </param>
        /// <param name="headers">
        /// ImportHotelConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportHotelConfigResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ImportHotelConfigResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ImportHotelConfigResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量导入酒店配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ImportHotelConfigRequest
        /// </param>
        /// <param name="headers">
        /// ImportHotelConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportHotelConfigResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ImportHotelConfigResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ImportHotelConfigResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量导入酒店配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportHotelConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportHotelConfigResponse
        /// </returns>
        public ImportHotelConfigResponse ImportHotelConfig(ImportHotelConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ImportHotelConfigHeaders headers = new ImportHotelConfigHeaders();
            return ImportHotelConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量导入酒店配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportHotelConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportHotelConfigResponse
        /// </returns>
        public async Task<ImportHotelConfigResponse> ImportHotelConfigAsync(ImportHotelConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ImportHotelConfigHeaders headers = new ImportHotelConfigHeaders();
            return await ImportHotelConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量导入设备（同时补充房型）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ImportRoomControlDevicesRequest
        /// </param>
        /// <param name="headers">
        /// ImportRoomControlDevicesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportRoomControlDevicesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ImportRoomControlDevicesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ImportRoomControlDevicesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量导入设备（同时补充房型）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ImportRoomControlDevicesRequest
        /// </param>
        /// <param name="headers">
        /// ImportRoomControlDevicesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportRoomControlDevicesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ImportRoomControlDevicesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ImportRoomControlDevicesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量导入设备（同时补充房型）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportRoomControlDevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportRoomControlDevicesResponse
        /// </returns>
        public ImportRoomControlDevicesResponse ImportRoomControlDevices(ImportRoomControlDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ImportRoomControlDevicesHeaders headers = new ImportRoomControlDevicesHeaders();
            return ImportRoomControlDevicesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量导入设备（同时补充房型）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportRoomControlDevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportRoomControlDevicesResponse
        /// </returns>
        public async Task<ImportRoomControlDevicesResponse> ImportRoomControlDevicesAsync(ImportRoomControlDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ImportRoomControlDevicesHeaders headers = new ImportRoomControlDevicesHeaders();
            return await ImportRoomControlDevicesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导入房间内精灵场景</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ImportRoomGenieScenesRequest
        /// </param>
        /// <param name="headers">
        /// ImportRoomGenieScenesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportRoomGenieScenesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ImportRoomGenieScenesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ImportRoomGenieScenesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导入房间内精灵场景</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ImportRoomGenieScenesRequest
        /// </param>
        /// <param name="headers">
        /// ImportRoomGenieScenesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportRoomGenieScenesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ImportRoomGenieScenesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ImportRoomGenieScenesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导入房间内精灵场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportRoomGenieScenesRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportRoomGenieScenesResponse
        /// </returns>
        public ImportRoomGenieScenesResponse ImportRoomGenieScenes(ImportRoomGenieScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ImportRoomGenieScenesHeaders headers = new ImportRoomGenieScenesHeaders();
            return ImportRoomGenieScenesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导入房间内精灵场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportRoomGenieScenesRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportRoomGenieScenesResponse
        /// </returns>
        public async Task<ImportRoomGenieScenesResponse> ImportRoomGenieScenesAsync(ImportRoomGenieScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ImportRoomGenieScenesHeaders headers = new ImportRoomGenieScenesHeaders();
            return await ImportRoomGenieScenesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景预订新增</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// InsertHotelSceneBookItemRequest
        /// </param>
        /// <param name="headers">
        /// InsertHotelSceneBookItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertHotelSceneBookItemResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<InsertHotelSceneBookItemResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<InsertHotelSceneBookItemResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景预订新增</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// InsertHotelSceneBookItemRequest
        /// </param>
        /// <param name="headers">
        /// InsertHotelSceneBookItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertHotelSceneBookItemResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<InsertHotelSceneBookItemResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<InsertHotelSceneBookItemResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景预订新增</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertHotelSceneBookItemRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertHotelSceneBookItemResponse
        /// </returns>
        public InsertHotelSceneBookItemResponse InsertHotelSceneBookItem(InsertHotelSceneBookItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertHotelSceneBookItemHeaders headers = new InsertHotelSceneBookItemHeaders();
            return InsertHotelSceneBookItemWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景预订新增</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertHotelSceneBookItemRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertHotelSceneBookItemResponse
        /// </returns>
        public async Task<InsertHotelSceneBookItemResponse> InsertHotelSceneBookItemAsync(InsertHotelSceneBookItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertHotelSceneBookItemHeaders headers = new InsertHotelSceneBookItemHeaders();
            return await InsertHotelSceneBookItemWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人服务，消息推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokeRobotPushRequest
        /// </param>
        /// <param name="headers">
        /// InvokeRobotPushHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvokeRobotPushResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomName))
            {
                body["RoomName"] = request.RoomName;
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<InvokeRobotPushResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<InvokeRobotPushResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人服务，消息推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokeRobotPushRequest
        /// </param>
        /// <param name="headers">
        /// InvokeRobotPushHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvokeRobotPushResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomName))
            {
                body["RoomName"] = request.RoomName;
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<InvokeRobotPushResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<InvokeRobotPushResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人服务，消息推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokeRobotPushRequest
        /// </param>
        /// 
        /// <returns>
        /// InvokeRobotPushResponse
        /// </returns>
        public InvokeRobotPushResponse InvokeRobotPush(InvokeRobotPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvokeRobotPushHeaders headers = new InvokeRobotPushHeaders();
            return InvokeRobotPushWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人服务，消息推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokeRobotPushRequest
        /// </param>
        /// 
        /// <returns>
        /// InvokeRobotPushResponse
        /// </returns>
        public async Task<InvokeRobotPushResponse> InvokeRobotPushAsync(InvokeRobotPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvokeRobotPushHeaders headers = new InvokeRobotPushHeaders();
            return await InvokeRobotPushWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询省份</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListAllProvincesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllProvincesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListAllProvincesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListAllProvincesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询省份</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListAllProvincesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllProvincesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListAllProvincesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListAllProvincesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询省份</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListAllProvincesResponse
        /// </returns>
        public ListAllProvincesResponse ListAllProvinces()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAllProvincesHeaders headers = new ListAllProvincesHeaders();
            return ListAllProvincesWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询省份</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListAllProvincesResponse
        /// </returns>
        public async Task<ListAllProvincesResponse> ListAllProvincesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAllProvincesHeaders headers = new ListAllProvincesHeaders();
            return await ListAllProvincesWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询城市</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCitiesByProvinceRequest
        /// </param>
        /// <param name="headers">
        /// ListCitiesByProvinceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCitiesByProvinceResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListCitiesByProvinceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListCitiesByProvinceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询城市</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCitiesByProvinceRequest
        /// </param>
        /// <param name="headers">
        /// ListCitiesByProvinceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCitiesByProvinceResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListCitiesByProvinceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListCitiesByProvinceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询城市</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCitiesByProvinceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCitiesByProvinceResponse
        /// </returns>
        public ListCitiesByProvinceResponse ListCitiesByProvince(ListCitiesByProvinceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCitiesByProvinceHeaders headers = new ListCitiesByProvinceHeaders();
            return ListCitiesByProvinceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询城市</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCitiesByProvinceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCitiesByProvinceResponse
        /// </returns>
        public async Task<ListCitiesByProvinceResponse> ListCitiesByProvinceAsync(ListCitiesByProvinceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCitiesByProvinceHeaders headers = new ListCitiesByProvinceHeaders();
            return await ListCitiesByProvinceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义问答列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListCustomQARequest
        /// </param>
        /// <param name="headers">
        /// ListCustomQAHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomQAResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListCustomQAResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListCustomQAResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义问答列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListCustomQARequest
        /// </param>
        /// <param name="headers">
        /// ListCustomQAHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomQAResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListCustomQAResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListCustomQAResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义问答列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomQARequest
        /// </param>
        /// 
        /// <returns>
        /// ListCustomQAResponse
        /// </returns>
        public ListCustomQAResponse ListCustomQA(ListCustomQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCustomQAHeaders headers = new ListCustomQAHeaders();
            return ListCustomQAWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义问答列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomQARequest
        /// </param>
        /// 
        /// <returns>
        /// ListCustomQAResponse
        /// </returns>
        public async Task<ListCustomQAResponse> ListCustomQAAsync(ListCustomQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCustomQAHeaders headers = new ListCustomQAHeaders();
            return await ListCustomQAWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景对话模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDialogueTemplateRequest
        /// </param>
        /// <param name="headers">
        /// ListDialogueTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDialogueTemplateResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListDialogueTemplateResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListDialogueTemplateResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景对话模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDialogueTemplateRequest
        /// </param>
        /// <param name="headers">
        /// ListDialogueTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDialogueTemplateResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListDialogueTemplateResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListDialogueTemplateResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景对话模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDialogueTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDialogueTemplateResponse
        /// </returns>
        public ListDialogueTemplateResponse ListDialogueTemplate(ListDialogueTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDialogueTemplateHeaders headers = new ListDialogueTemplateHeaders();
            return ListDialogueTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景对话模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDialogueTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDialogueTemplateResponse
        /// </returns>
        public async Task<ListDialogueTemplateResponse> ListDialogueTemplateAsync(ListDialogueTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDialogueTemplateHeaders headers = new ListDialogueTemplateHeaders();
            return await ListDialogueTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询酒店闹钟</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotelAlarmRequest
        /// </param>
        /// <param name="headers">
        /// ListHotelAlarmHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelAlarmResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelAlarmResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelAlarmResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询酒店闹钟</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotelAlarmRequest
        /// </param>
        /// <param name="headers">
        /// ListHotelAlarmHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelAlarmResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelAlarmResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelAlarmResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询酒店闹钟</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotelAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotelAlarmResponse
        /// </returns>
        public ListHotelAlarmResponse ListHotelAlarm(ListHotelAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelAlarmHeaders headers = new ListHotelAlarmHeaders();
            return ListHotelAlarmWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询酒店闹钟</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotelAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotelAlarmResponse
        /// </returns>
        public async Task<ListHotelAlarmResponse> ListHotelAlarmAsync(ListHotelAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelAlarmHeaders headers = new ListHotelAlarmHeaders();
            return await ListHotelAlarmWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店设备列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotelControlDeviceRequest
        /// </param>
        /// <param name="headers">
        /// ListHotelControlDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelControlDeviceResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelControlDeviceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelControlDeviceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店设备列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotelControlDeviceRequest
        /// </param>
        /// <param name="headers">
        /// ListHotelControlDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelControlDeviceResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelControlDeviceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelControlDeviceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotelControlDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotelControlDeviceResponse
        /// </returns>
        public ListHotelControlDeviceResponse ListHotelControlDevice(ListHotelControlDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelControlDeviceHeaders headers = new ListHotelControlDeviceHeaders();
            return ListHotelControlDeviceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotelControlDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotelControlDeviceResponse
        /// </returns>
        public async Task<ListHotelControlDeviceResponse> ListHotelControlDeviceAsync(ListHotelControlDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelControlDeviceHeaders headers = new ListHotelControlDeviceHeaders();
            return await ListHotelControlDeviceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListHotelInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelInfoResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelInfoResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelInfoResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListHotelInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelInfoResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelInfoResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelInfoResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListHotelInfoResponse
        /// </returns>
        public ListHotelInfoResponse ListHotelInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelInfoHeaders headers = new ListHotelInfoHeaders();
            return ListHotelInfoWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListHotelInfoResponse
        /// </returns>
        public async Task<ListHotelInfoResponse> ListHotelInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelInfoHeaders headers = new ListHotelInfoHeaders();
            return await ListHotelInfoWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取消息模板</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListHotelMessageTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelMessageTemplateResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelMessageTemplateResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelMessageTemplateResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取消息模板</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListHotelMessageTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelMessageTemplateResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelMessageTemplateResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelMessageTemplateResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取消息模板</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListHotelMessageTemplateResponse
        /// </returns>
        public ListHotelMessageTemplateResponse ListHotelMessageTemplate()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelMessageTemplateHeaders headers = new ListHotelMessageTemplateHeaders();
            return ListHotelMessageTemplateWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取消息模板</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListHotelMessageTemplateResponse
        /// </returns>
        public async Task<ListHotelMessageTemplateResponse> ListHotelMessageTemplateAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelMessageTemplateHeaders headers = new ListHotelMessageTemplateHeaders();
            return await ListHotelMessageTemplateWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店订单列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotelOrderRequest
        /// </param>
        /// <param name="headers">
        /// ListHotelOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelOrderResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelOrderResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店订单列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotelOrderRequest
        /// </param>
        /// <param name="headers">
        /// ListHotelOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelOrderResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelOrderResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店订单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotelOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotelOrderResponse
        /// </returns>
        public ListHotelOrderResponse ListHotelOrder(ListHotelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelOrderHeaders headers = new ListHotelOrderHeaders();
            return ListHotelOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店订单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotelOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotelOrderResponse
        /// </returns>
        public async Task<ListHotelOrderResponse> ListHotelOrderAsync(ListHotelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelOrderHeaders headers = new ListHotelOrderHeaders();
            return await ListHotelOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店的所有房间</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotelRoomsRequest
        /// </param>
        /// <param name="headers">
        /// ListHotelRoomsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelRoomsResponse
        /// </returns>
        public ListHotelRoomsResponse ListHotelRoomsWithOptions(ListHotelRoomsRequest tmpReq, ListHotelRoomsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotelRoomsShrinkRequest request = new ListHotelRoomsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelAdminRoom))
            {
                request.HotelAdminRoomShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelAdminRoom, "HotelAdminRoom", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelAdminRoomShrink))
            {
                body["HotelAdminRoom"] = request.HotelAdminRoomShrink;
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelRoomsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelRoomsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店的所有房间</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotelRoomsRequest
        /// </param>
        /// <param name="headers">
        /// ListHotelRoomsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelRoomsResponse
        /// </returns>
        public async Task<ListHotelRoomsResponse> ListHotelRoomsWithOptionsAsync(ListHotelRoomsRequest tmpReq, ListHotelRoomsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotelRoomsShrinkRequest request = new ListHotelRoomsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelAdminRoom))
            {
                request.HotelAdminRoomShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelAdminRoom, "HotelAdminRoom", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelAdminRoomShrink))
            {
                body["HotelAdminRoom"] = request.HotelAdminRoomShrink;
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelRoomsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelRoomsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店的所有房间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotelRoomsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotelRoomsResponse
        /// </returns>
        public ListHotelRoomsResponse ListHotelRooms(ListHotelRoomsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelRoomsHeaders headers = new ListHotelRoomsHeaders();
            return ListHotelRoomsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酒店的所有房间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotelRoomsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotelRoomsResponse
        /// </returns>
        public async Task<ListHotelRoomsResponse> ListHotelRoomsAsync(ListHotelRoomsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelRoomsHeaders headers = new ListHotelRoomsHeaders();
            return await ListHotelRoomsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景预订列表（餐饮/SPA休闲/打车）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotelSceneBookItemsRequest
        /// </param>
        /// <param name="headers">
        /// ListHotelSceneBookItemsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelSceneBookItemsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelSceneBookItemsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelSceneBookItemsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景预订列表（餐饮/SPA休闲/打车）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotelSceneBookItemsRequest
        /// </param>
        /// <param name="headers">
        /// ListHotelSceneBookItemsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelSceneBookItemsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelSceneBookItemsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelSceneBookItemsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景预订列表（餐饮/SPA休闲/打车）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotelSceneBookItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotelSceneBookItemsResponse
        /// </returns>
        public ListHotelSceneBookItemsResponse ListHotelSceneBookItems(ListHotelSceneBookItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelSceneBookItemsHeaders headers = new ListHotelSceneBookItemsHeaders();
            return ListHotelSceneBookItemsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景预订列表（餐饮/SPA休闲/打车）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotelSceneBookItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotelSceneBookItemsResponse
        /// </returns>
        public async Task<ListHotelSceneBookItemsResponse> ListHotelSceneBookItemsAsync(ListHotelSceneBookItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelSceneBookItemsHeaders headers = new ListHotelSceneBookItemsHeaders();
            return await ListHotelSceneBookItemsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务项目</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotelSceneItemRequest
        /// </param>
        /// <param name="headers">
        /// ListHotelSceneItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelSceneItemResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelSceneItemResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelSceneItemResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务项目</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotelSceneItemRequest
        /// </param>
        /// <param name="headers">
        /// ListHotelSceneItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelSceneItemResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelSceneItemResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelSceneItemResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotelSceneItemRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotelSceneItemResponse
        /// </returns>
        public ListHotelSceneItemResponse ListHotelSceneItem(ListHotelSceneItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelSceneItemHeaders headers = new ListHotelSceneItemHeaders();
            return ListHotelSceneItemWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotelSceneItemRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotelSceneItemResponse
        /// </returns>
        public async Task<ListHotelSceneItemResponse> ListHotelSceneItemAsync(ListHotelSceneItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelSceneItemHeaders headers = new ListHotelSceneItemHeaders();
            return await ListHotelSceneItemWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景列表（物品/服务/维修）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotelSceneItemsRequest
        /// </param>
        /// <param name="headers">
        /// ListHotelSceneItemsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelSceneItemsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelSceneItemsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelSceneItemsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景列表（物品/服务/维修）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotelSceneItemsRequest
        /// </param>
        /// <param name="headers">
        /// ListHotelSceneItemsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelSceneItemsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelSceneItemsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelSceneItemsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景列表（物品/服务/维修）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotelSceneItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotelSceneItemsResponse
        /// </returns>
        public ListHotelSceneItemsResponse ListHotelSceneItems(ListHotelSceneItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelSceneItemsHeaders headers = new ListHotelSceneItemsHeaders();
            return ListHotelSceneItemsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景列表（物品/服务/维修）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotelSceneItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotelSceneItemsResponse
        /// </returns>
        public async Task<ListHotelSceneItemsResponse> ListHotelSceneItemsAsync(ListHotelSceneItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelSceneItemsHeaders headers = new ListHotelSceneItemsHeaders();
            return await ListHotelSceneItemsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务分类列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotelServiceCategoryRequest
        /// </param>
        /// <param name="headers">
        /// ListHotelServiceCategoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelServiceCategoryResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelServiceCategoryResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelServiceCategoryResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务分类列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotelServiceCategoryRequest
        /// </param>
        /// <param name="headers">
        /// ListHotelServiceCategoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelServiceCategoryResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelServiceCategoryResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelServiceCategoryResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务分类列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotelServiceCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotelServiceCategoryResponse
        /// </returns>
        public ListHotelServiceCategoryResponse ListHotelServiceCategory(ListHotelServiceCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelServiceCategoryHeaders headers = new ListHotelServiceCategoryHeaders();
            return ListHotelServiceCategoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务分类列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotelServiceCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotelServiceCategoryResponse
        /// </returns>
        public async Task<ListHotelServiceCategoryResponse> ListHotelServiceCategoryAsync(ListHotelServiceCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelServiceCategoryHeaders headers = new ListHotelServiceCategoryHeaders();
            return await ListHotelServiceCategoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店列表(待审批/已拒绝/已通过)</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotelsRequest
        /// </param>
        /// <param name="headers">
        /// ListHotelsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelsResponse
        /// </returns>
        public ListHotelsResponse ListHotelsWithOptions(ListHotelsRequest tmpReq, ListHotelsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotelsShrinkRequest request = new ListHotelsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelRequest))
            {
                request.HotelRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelRequest, "HotelRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Page))
            {
                request.PageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Page, "Page", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelRequestShrink))
            {
                query["HotelRequest"] = request.HotelRequestShrink;
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店列表(待审批/已拒绝/已通过)</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotelsRequest
        /// </param>
        /// <param name="headers">
        /// ListHotelsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotelsResponse
        /// </returns>
        public async Task<ListHotelsResponse> ListHotelsWithOptionsAsync(ListHotelsRequest tmpReq, ListHotelsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotelsShrinkRequest request = new ListHotelsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotelRequest))
            {
                request.HotelRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotelRequest, "HotelRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Page))
            {
                request.PageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Page, "Page", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelRequestShrink))
            {
                query["HotelRequest"] = request.HotelRequestShrink;
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListHotelsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListHotelsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店列表(待审批/已拒绝/已通过)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotelsResponse
        /// </returns>
        public ListHotelsResponse ListHotels(ListHotelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelsHeaders headers = new ListHotelsHeaders();
            return ListHotelsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店列表(待审批/已拒绝/已通过)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotelsResponse
        /// </returns>
        public async Task<ListHotelsResponse> ListHotelsAsync(ListHotelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListHotelsHeaders headers = new ListHotelsHeaders();
            return await ListHotelsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询红外品牌列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInfraredDeviceBrandsRequest
        /// </param>
        /// <param name="headers">
        /// ListInfraredDeviceBrandsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInfraredDeviceBrandsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListInfraredDeviceBrandsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListInfraredDeviceBrandsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询红外品牌列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInfraredDeviceBrandsRequest
        /// </param>
        /// <param name="headers">
        /// ListInfraredDeviceBrandsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInfraredDeviceBrandsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListInfraredDeviceBrandsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListInfraredDeviceBrandsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询红外品牌列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInfraredDeviceBrandsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInfraredDeviceBrandsResponse
        /// </returns>
        public ListInfraredDeviceBrandsResponse ListInfraredDeviceBrands(ListInfraredDeviceBrandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInfraredDeviceBrandsHeaders headers = new ListInfraredDeviceBrandsHeaders();
            return ListInfraredDeviceBrandsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询红外品牌列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInfraredDeviceBrandsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInfraredDeviceBrandsResponse
        /// </returns>
        public async Task<ListInfraredDeviceBrandsResponse> ListInfraredDeviceBrandsAsync(ListInfraredDeviceBrandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInfraredDeviceBrandsHeaders headers = new ListInfraredDeviceBrandsHeaders();
            return await ListInfraredDeviceBrandsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询红外码库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInfraredRemoteControllersRequest
        /// </param>
        /// <param name="headers">
        /// ListInfraredRemoteControllersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInfraredRemoteControllersResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListInfraredRemoteControllersResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListInfraredRemoteControllersResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询红外码库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInfraredRemoteControllersRequest
        /// </param>
        /// <param name="headers">
        /// ListInfraredRemoteControllersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInfraredRemoteControllersResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListInfraredRemoteControllersResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListInfraredRemoteControllersResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询红外码库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInfraredRemoteControllersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInfraredRemoteControllersResponse
        /// </returns>
        public ListInfraredRemoteControllersResponse ListInfraredRemoteControllers(ListInfraredRemoteControllersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInfraredRemoteControllersHeaders headers = new ListInfraredRemoteControllersHeaders();
            return ListInfraredRemoteControllersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询红外码库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInfraredRemoteControllersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInfraredRemoteControllersResponse
        /// </returns>
        public async Task<ListInfraredRemoteControllersResponse> ListInfraredRemoteControllersAsync(ListInfraredRemoteControllersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInfraredRemoteControllersHeaders headers = new ListInfraredRemoteControllersHeaders();
            return await ListInfraredRemoteControllersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询服务提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSTBServiceProvidersRequest
        /// </param>
        /// <param name="headers">
        /// ListSTBServiceProvidersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSTBServiceProvidersResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListSTBServiceProvidersResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListSTBServiceProvidersResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询服务提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSTBServiceProvidersRequest
        /// </param>
        /// <param name="headers">
        /// ListSTBServiceProvidersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSTBServiceProvidersResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListSTBServiceProvidersResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListSTBServiceProvidersResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询服务提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSTBServiceProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSTBServiceProvidersResponse
        /// </returns>
        public ListSTBServiceProvidersResponse ListSTBServiceProviders(ListSTBServiceProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSTBServiceProvidersHeaders headers = new ListSTBServiceProvidersHeaders();
            return ListSTBServiceProvidersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询服务提供商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSTBServiceProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSTBServiceProvidersResponse
        /// </returns>
        public async Task<ListSTBServiceProvidersResponse> ListSTBServiceProvidersAsync(ListSTBServiceProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSTBServiceProvidersHeaders headers = new ListSTBServiceProvidersHeaders();
            return await ListSTBServiceProvidersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景分类</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSceneCategoryRequest
        /// </param>
        /// <param name="headers">
        /// ListSceneCategoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSceneCategoryResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListSceneCategoryResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListSceneCategoryResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景分类</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSceneCategoryRequest
        /// </param>
        /// <param name="headers">
        /// ListSceneCategoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSceneCategoryResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListSceneCategoryResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListSceneCategoryResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景分类</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSceneCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSceneCategoryResponse
        /// </returns>
        public ListSceneCategoryResponse ListSceneCategory(ListSceneCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSceneCategoryHeaders headers = new ListSceneCategoryHeaders();
            return ListSceneCategoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景分类</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSceneCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSceneCategoryResponse
        /// </returns>
        public async Task<ListSceneCategoryResponse> ListSceneCategoryAsync(ListSceneCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSceneCategoryHeaders headers = new ListSceneCategoryHeaders();
            return await ListSceneCategoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询服务设施问答列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListServiceQARequest
        /// </param>
        /// <param name="headers">
        /// ListServiceQAHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServiceQAResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListServiceQAResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListServiceQAResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询服务设施问答列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListServiceQARequest
        /// </param>
        /// <param name="headers">
        /// ListServiceQAHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServiceQAResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListServiceQAResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListServiceQAResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询服务设施问答列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServiceQARequest
        /// </param>
        /// 
        /// <returns>
        /// ListServiceQAResponse
        /// </returns>
        public ListServiceQAResponse ListServiceQA(ListServiceQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListServiceQAHeaders headers = new ListServiceQAHeaders();
            return ListServiceQAWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询服务设施问答列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServiceQARequest
        /// </param>
        /// 
        /// <returns>
        /// ListServiceQAResponse
        /// </returns>
        public async Task<ListServiceQAResponse> ListServiceQAAsync(ListServiceQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListServiceQAHeaders headers = new ListServiceQAHeaders();
            return await ListServiceQAWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询工单列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListTicketsRequest
        /// </param>
        /// <param name="headers">
        /// ListTicketsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTicketsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTicketsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTicketsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询工单列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListTicketsRequest
        /// </param>
        /// <param name="headers">
        /// ListTicketsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTicketsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTicketsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTicketsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询工单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTicketsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTicketsResponse
        /// </returns>
        public ListTicketsResponse ListTickets(ListTicketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTicketsHeaders headers = new ListTicketsHeaders();
            return ListTicketsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询工单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTicketsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTicketsResponse
        /// </returns>
        public async Task<ListTicketsResponse> ListTicketsAsync(ListTicketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTicketsHeaders headers = new ListTicketsHeaders();
            return await ListTicketsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询酒店房间主控设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageGetHotelRoomDevicesRequest
        /// </param>
        /// <param name="headers">
        /// PageGetHotelRoomDevicesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageGetHotelRoomDevicesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PageGetHotelRoomDevicesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PageGetHotelRoomDevicesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询酒店房间主控设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageGetHotelRoomDevicesRequest
        /// </param>
        /// <param name="headers">
        /// PageGetHotelRoomDevicesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageGetHotelRoomDevicesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PageGetHotelRoomDevicesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PageGetHotelRoomDevicesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询酒店房间主控设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageGetHotelRoomDevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// PageGetHotelRoomDevicesResponse
        /// </returns>
        public PageGetHotelRoomDevicesResponse PageGetHotelRoomDevices(PageGetHotelRoomDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageGetHotelRoomDevicesHeaders headers = new PageGetHotelRoomDevicesHeaders();
            return PageGetHotelRoomDevicesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询酒店房间主控设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageGetHotelRoomDevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// PageGetHotelRoomDevicesResponse
        /// </returns>
        public async Task<PageGetHotelRoomDevicesResponse> PageGetHotelRoomDevicesAsync(PageGetHotelRoomDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageGetHotelRoomDevicesHeaders headers = new PageGetHotelRoomDevicesHeaders();
            return await PageGetHotelRoomDevicesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pms事件上报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PmsEventReportRequest
        /// </param>
        /// <param name="headers">
        /// PmsEventReportHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PmsEventReportResponse
        /// </returns>
        public PmsEventReportResponse PmsEventReportWithOptions(PmsEventReportRequest request, PmsEventReportHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Payload))
            {
                body["Payload"] = request.Payload;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
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
                Action = "PmsEventReport",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/pmsEventReport",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PmsEventReportResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PmsEventReportResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pms事件上报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PmsEventReportRequest
        /// </param>
        /// <param name="headers">
        /// PmsEventReportHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PmsEventReportResponse
        /// </returns>
        public async Task<PmsEventReportResponse> PmsEventReportWithOptionsAsync(PmsEventReportRequest request, PmsEventReportHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Payload))
            {
                body["Payload"] = request.Payload;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
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
                Action = "PmsEventReport",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/pmsEventReport",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PmsEventReportResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PmsEventReportResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pms事件上报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PmsEventReportRequest
        /// </param>
        /// 
        /// <returns>
        /// PmsEventReportResponse
        /// </returns>
        public PmsEventReportResponse PmsEventReport(PmsEventReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PmsEventReportHeaders headers = new PmsEventReportHeaders();
            return PmsEventReportWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pms事件上报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PmsEventReportRequest
        /// </param>
        /// 
        /// <returns>
        /// PmsEventReportResponse
        /// </returns>
        public async Task<PmsEventReportResponse> PmsEventReportAsync(PmsEventReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PmsEventReportHeaders headers = new PmsEventReportHeaders();
            return await PmsEventReportWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送酒店消息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PushHotelMessageRequest
        /// </param>
        /// <param name="headers">
        /// PushHotelMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushHotelMessageResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PushHotelMessageResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PushHotelMessageResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送酒店消息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PushHotelMessageRequest
        /// </param>
        /// <param name="headers">
        /// PushHotelMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushHotelMessageResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PushHotelMessageResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PushHotelMessageResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送酒店消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushHotelMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// PushHotelMessageResponse
        /// </returns>
        public PushHotelMessageResponse PushHotelMessage(PushHotelMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushHotelMessageHeaders headers = new PushHotelMessageHeaders();
            return PushHotelMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送酒店消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushHotelMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// PushHotelMessageResponse
        /// </returns>
        public async Task<PushHotelMessageResponse> PushHotelMessageAsync(PushHotelMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushHotelMessageHeaders headers = new PushHotelMessageHeaders();
            return await PushHotelMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送音箱指令</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PushVoiceBoxCommandsRequest
        /// </param>
        /// <param name="headers">
        /// PushVoiceBoxCommandsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushVoiceBoxCommandsResponse
        /// </returns>
        public PushVoiceBoxCommandsResponse PushVoiceBoxCommandsWithOptions(PushVoiceBoxCommandsRequest tmpReq, PushVoiceBoxCommandsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushVoiceBoxCommandsShrinkRequest request = new PushVoiceBoxCommandsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Commands))
            {
                request.CommandsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Commands, "Commands", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandsShrink))
            {
                body["Commands"] = request.CommandsShrink;
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
                Action = "PushVoiceBoxCommands",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/pushVoiceBoxCommands",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PushVoiceBoxCommandsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PushVoiceBoxCommandsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送音箱指令</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PushVoiceBoxCommandsRequest
        /// </param>
        /// <param name="headers">
        /// PushVoiceBoxCommandsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushVoiceBoxCommandsResponse
        /// </returns>
        public async Task<PushVoiceBoxCommandsResponse> PushVoiceBoxCommandsWithOptionsAsync(PushVoiceBoxCommandsRequest tmpReq, PushVoiceBoxCommandsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushVoiceBoxCommandsShrinkRequest request = new PushVoiceBoxCommandsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Commands))
            {
                request.CommandsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Commands, "Commands", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandsShrink))
            {
                body["Commands"] = request.CommandsShrink;
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
                Action = "PushVoiceBoxCommands",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/pushVoiceBoxCommands",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PushVoiceBoxCommandsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PushVoiceBoxCommandsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送音箱指令</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushVoiceBoxCommandsRequest
        /// </param>
        /// 
        /// <returns>
        /// PushVoiceBoxCommandsResponse
        /// </returns>
        public PushVoiceBoxCommandsResponse PushVoiceBoxCommands(PushVoiceBoxCommandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushVoiceBoxCommandsHeaders headers = new PushVoiceBoxCommandsHeaders();
            return PushVoiceBoxCommandsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送音箱指令</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushVoiceBoxCommandsRequest
        /// </param>
        /// 
        /// <returns>
        /// PushVoiceBoxCommandsResponse
        /// </returns>
        public async Task<PushVoiceBoxCommandsResponse> PushVoiceBoxCommandsAsync(PushVoiceBoxCommandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushVoiceBoxCommandsHeaders headers = new PushVoiceBoxCommandsHeaders();
            return await PushVoiceBoxCommandsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>直接推送欢迎语</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushWelcomeRequest
        /// </param>
        /// <param name="headers">
        /// PushWelcomeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushWelcomeResponse
        /// </returns>
        public PushWelcomeResponse PushWelcomeWithOptions(PushWelcomeRequest request, PushWelcomeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomName))
            {
                body["RoomName"] = request.RoomName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WelcomeMusicUrl))
            {
                body["WelcomeMusicUrl"] = request.WelcomeMusicUrl;
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
                Action = "PushWelcome",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/pushWelcome",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PushWelcomeResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PushWelcomeResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>直接推送欢迎语</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushWelcomeRequest
        /// </param>
        /// <param name="headers">
        /// PushWelcomeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushWelcomeResponse
        /// </returns>
        public async Task<PushWelcomeResponse> PushWelcomeWithOptionsAsync(PushWelcomeRequest request, PushWelcomeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotelId))
            {
                body["HotelId"] = request.HotelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomName))
            {
                body["RoomName"] = request.RoomName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomNo))
            {
                body["RoomNo"] = request.RoomNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WelcomeMusicUrl))
            {
                body["WelcomeMusicUrl"] = request.WelcomeMusicUrl;
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
                Action = "PushWelcome",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/pushWelcome",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PushWelcomeResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PushWelcomeResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>直接推送欢迎语</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushWelcomeRequest
        /// </param>
        /// 
        /// <returns>
        /// PushWelcomeResponse
        /// </returns>
        public PushWelcomeResponse PushWelcome(PushWelcomeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushWelcomeHeaders headers = new PushWelcomeHeaders();
            return PushWelcomeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>直接推送欢迎语</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushWelcomeRequest
        /// </param>
        /// 
        /// <returns>
        /// PushWelcomeResponse
        /// </returns>
        public async Task<PushWelcomeResponse> PushWelcomeAsync(PushWelcomeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushWelcomeHeaders headers = new PushWelcomeHeaders();
            return await PushWelcomeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送欢迎语</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PushWelcomeTextAndMusicRequest
        /// </param>
        /// <param name="headers">
        /// PushWelcomeTextAndMusicHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushWelcomeTextAndMusicResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomName))
            {
                body["RoomName"] = request.RoomName;
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PushWelcomeTextAndMusicResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PushWelcomeTextAndMusicResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送欢迎语</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PushWelcomeTextAndMusicRequest
        /// </param>
        /// <param name="headers">
        /// PushWelcomeTextAndMusicHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushWelcomeTextAndMusicResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomName))
            {
                body["RoomName"] = request.RoomName;
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PushWelcomeTextAndMusicResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PushWelcomeTextAndMusicResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送欢迎语</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushWelcomeTextAndMusicRequest
        /// </param>
        /// 
        /// <returns>
        /// PushWelcomeTextAndMusicResponse
        /// </returns>
        public PushWelcomeTextAndMusicResponse PushWelcomeTextAndMusic(PushWelcomeTextAndMusicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushWelcomeTextAndMusicHeaders headers = new PushWelcomeTextAndMusicHeaders();
            return PushWelcomeTextAndMusicWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送欢迎语</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushWelcomeTextAndMusicRequest
        /// </param>
        /// 
        /// <returns>
        /// PushWelcomeTextAndMusicResponse
        /// </returns>
        public async Task<PushWelcomeTextAndMusicResponse> PushWelcomeTextAndMusicAsync(PushWelcomeTextAndMusicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushWelcomeTextAndMusicHeaders headers = new PushWelcomeTextAndMusicHeaders();
            return await PushWelcomeTextAndMusicWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询酒店设备状态/模式状态查询</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryDeviceStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryDeviceStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceStatusResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryDeviceStatusResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryDeviceStatusResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询酒店设备状态/模式状态查询</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryDeviceStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryDeviceStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceStatusResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryDeviceStatusResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryDeviceStatusResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询酒店设备状态/模式状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeviceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceStatusResponse
        /// </returns>
        public QueryDeviceStatusResponse QueryDeviceStatus(QueryDeviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceStatusHeaders headers = new QueryDeviceStatusHeaders();
            return QueryDeviceStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询酒店设备状态/模式状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeviceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDeviceStatusResponse
        /// </returns>
        public async Task<QueryDeviceStatusResponse> QueryDeviceStatusAsync(QueryDeviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceStatusHeaders headers = new QueryDeviceStatusHeaders();
            return await QueryDeviceStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询房间详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHotelRoomDetailRequest
        /// </param>
        /// <param name="headers">
        /// QueryHotelRoomDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryHotelRoomDetailResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryHotelRoomDetailResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryHotelRoomDetailResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询房间详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHotelRoomDetailRequest
        /// </param>
        /// <param name="headers">
        /// QueryHotelRoomDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryHotelRoomDetailResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryHotelRoomDetailResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryHotelRoomDetailResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询房间详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHotelRoomDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryHotelRoomDetailResponse
        /// </returns>
        public QueryHotelRoomDetailResponse QueryHotelRoomDetail(QueryHotelRoomDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHotelRoomDetailHeaders headers = new QueryHotelRoomDetailHeaders();
            return QueryHotelRoomDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询房间详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHotelRoomDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryHotelRoomDetailResponse
        /// </returns>
        public async Task<QueryHotelRoomDetailResponse> QueryHotelRoomDetailAsync(QueryHotelRoomDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHotelRoomDetailHeaders headers = new QueryHotelRoomDetailHeaders();
            return await QueryHotelRoomDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询酒店房间客控设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRoomControlDevicesRequest
        /// </param>
        /// <param name="headers">
        /// QueryRoomControlDevicesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRoomControlDevicesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryRoomControlDevicesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryRoomControlDevicesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询酒店房间客控设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRoomControlDevicesRequest
        /// </param>
        /// <param name="headers">
        /// QueryRoomControlDevicesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRoomControlDevicesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryRoomControlDevicesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryRoomControlDevicesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询酒店房间客控设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRoomControlDevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRoomControlDevicesResponse
        /// </returns>
        public QueryRoomControlDevicesResponse QueryRoomControlDevices(QueryRoomControlDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRoomControlDevicesHeaders headers = new QueryRoomControlDevicesHeaders();
            return QueryRoomControlDevicesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询酒店房间客控设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRoomControlDevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRoomControlDevicesResponse
        /// </returns>
        public async Task<QueryRoomControlDevicesResponse> QueryRoomControlDevicesAsync(QueryRoomControlDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRoomControlDevicesHeaders headers = new QueryRoomControlDevicesHeaders();
            return await QueryRoomControlDevicesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询房间被控设备包含设备状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRoomControlDevicesAndStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryRoomControlDevicesAndStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRoomControlDevicesAndStatusResponse
        /// </returns>
        public QueryRoomControlDevicesAndStatusResponse QueryRoomControlDevicesAndStatusWithOptions(QueryRoomControlDevicesAndStatusRequest request, QueryRoomControlDevicesAndStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryRoomControlDevicesAndStatus",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/queryRoomControlDevicesAndStatus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryRoomControlDevicesAndStatusResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryRoomControlDevicesAndStatusResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询房间被控设备包含设备状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRoomControlDevicesAndStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryRoomControlDevicesAndStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRoomControlDevicesAndStatusResponse
        /// </returns>
        public async Task<QueryRoomControlDevicesAndStatusResponse> QueryRoomControlDevicesAndStatusWithOptionsAsync(QueryRoomControlDevicesAndStatusRequest request, QueryRoomControlDevicesAndStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryRoomControlDevicesAndStatus",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/queryRoomControlDevicesAndStatus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryRoomControlDevicesAndStatusResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryRoomControlDevicesAndStatusResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询房间被控设备包含设备状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRoomControlDevicesAndStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRoomControlDevicesAndStatusResponse
        /// </returns>
        public QueryRoomControlDevicesAndStatusResponse QueryRoomControlDevicesAndStatus(QueryRoomControlDevicesAndStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRoomControlDevicesAndStatusHeaders headers = new QueryRoomControlDevicesAndStatusHeaders();
            return QueryRoomControlDevicesAndStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询房间被控设备包含设备状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRoomControlDevicesAndStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRoomControlDevicesAndStatusResponse
        /// </returns>
        public async Task<QueryRoomControlDevicesAndStatusResponse> QueryRoomControlDevicesAndStatusAsync(QueryRoomControlDevicesAndStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRoomControlDevicesAndStatusHeaders headers = new QueryRoomControlDevicesAndStatusHeaders();
            return await QueryRoomControlDevicesAndStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询房态信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRoomStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryRoomStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRoomStatusResponse
        /// </returns>
        public QueryRoomStatusResponse QueryRoomStatusWithOptions(QueryRoomStatusRequest request, QueryRoomStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryRoomStatus",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/queryRoomStatus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryRoomStatusResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryRoomStatusResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询房态信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRoomStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryRoomStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRoomStatusResponse
        /// </returns>
        public async Task<QueryRoomStatusResponse> QueryRoomStatusWithOptionsAsync(QueryRoomStatusRequest request, QueryRoomStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryRoomStatus",
                Version = "ip_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/ip/queryRoomStatus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryRoomStatusResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryRoomStatusResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询房态信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRoomStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRoomStatusResponse
        /// </returns>
        public QueryRoomStatusResponse QueryRoomStatus(QueryRoomStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRoomStatusHeaders headers = new QueryRoomStatusHeaders();
            return QueryRoomStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询房态信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRoomStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRoomStatusResponse
        /// </returns>
        public async Task<QueryRoomStatusResponse> QueryRoomStatusAsync(QueryRoomStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRoomStatusHeaders headers = new QueryRoomStatusHeaders();
            return await QueryRoomStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询酒店场景列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QuerySceneListRequest
        /// </param>
        /// <param name="headers">
        /// QuerySceneListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySceneListResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QuerySceneListResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QuerySceneListResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询酒店场景列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QuerySceneListRequest
        /// </param>
        /// <param name="headers">
        /// QuerySceneListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySceneListResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QuerySceneListResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QuerySceneListResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询酒店场景列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySceneListRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySceneListResponse
        /// </returns>
        public QuerySceneListResponse QuerySceneList(QuerySceneListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySceneListHeaders headers = new QuerySceneListHeaders();
            return QuerySceneListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询酒店场景列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySceneListRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySceneListResponse
        /// </returns>
        public async Task<QuerySceneListResponse> QuerySceneListAsync(QuerySceneListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySceneListHeaders headers = new QuerySceneListHeaders();
            return await QuerySceneListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除子账号授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveChildAccountAuthRequest
        /// </param>
        /// <param name="headers">
        /// RemoveChildAccountAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveChildAccountAuthResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RemoveChildAccountAuthResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RemoveChildAccountAuthResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除子账号授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveChildAccountAuthRequest
        /// </param>
        /// <param name="headers">
        /// RemoveChildAccountAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveChildAccountAuthResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RemoveChildAccountAuthResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RemoveChildAccountAuthResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除子账号授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveChildAccountAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveChildAccountAuthResponse
        /// </returns>
        public RemoveChildAccountAuthResponse RemoveChildAccountAuth(RemoveChildAccountAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveChildAccountAuthHeaders headers = new RemoveChildAccountAuthHeaders();
            return RemoveChildAccountAuthWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除子账号授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveChildAccountAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveChildAccountAuthResponse
        /// </returns>
        public async Task<RemoveChildAccountAuthResponse> RemoveChildAccountAuthAsync(RemoveChildAccountAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveChildAccountAuthHeaders headers = new RemoveChildAccountAuthHeaders();
            return await RemoveChildAccountAuthWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除酒店项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveHotelRequest
        /// </param>
        /// <param name="headers">
        /// RemoveHotelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveHotelResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RemoveHotelResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RemoveHotelResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除酒店项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveHotelRequest
        /// </param>
        /// <param name="headers">
        /// RemoveHotelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveHotelResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RemoveHotelResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RemoveHotelResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除酒店项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveHotelRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveHotelResponse
        /// </returns>
        public RemoveHotelResponse RemoveHotel(RemoveHotelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveHotelHeaders headers = new RemoveHotelHeaders();
            return RemoveHotelWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除酒店项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveHotelRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveHotelResponse
        /// </returns>
        public async Task<RemoveHotelResponse> RemoveHotelAsync(RemoveHotelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveHotelHeaders headers = new RemoveHotelHeaders();
            return await RemoveHotelWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置欢迎语信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetWelcomeTextAndMusicRequest
        /// </param>
        /// <param name="headers">
        /// ResetWelcomeTextAndMusicHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetWelcomeTextAndMusicResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ResetWelcomeTextAndMusicResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ResetWelcomeTextAndMusicResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置欢迎语信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetWelcomeTextAndMusicRequest
        /// </param>
        /// <param name="headers">
        /// ResetWelcomeTextAndMusicHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetWelcomeTextAndMusicResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ResetWelcomeTextAndMusicResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ResetWelcomeTextAndMusicResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置欢迎语信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetWelcomeTextAndMusicRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetWelcomeTextAndMusicResponse
        /// </returns>
        public ResetWelcomeTextAndMusicResponse ResetWelcomeTextAndMusic(ResetWelcomeTextAndMusicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ResetWelcomeTextAndMusicHeaders headers = new ResetWelcomeTextAndMusicHeaders();
            return ResetWelcomeTextAndMusicWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置欢迎语信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetWelcomeTextAndMusicRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetWelcomeTextAndMusicResponse
        /// </returns>
        public async Task<ResetWelcomeTextAndMusicResponse> ResetWelcomeTextAndMusicAsync(ResetWelcomeTextAndMusicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ResetWelcomeTextAndMusicHeaders headers = new ResetWelcomeTextAndMusicHeaders();
            return await ResetWelcomeTextAndMusicWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>退房</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RoomCheckOutRequest
        /// </param>
        /// <param name="headers">
        /// RoomCheckOutHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RoomCheckOutResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RoomCheckOutResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RoomCheckOutResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>退房</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RoomCheckOutRequest
        /// </param>
        /// <param name="headers">
        /// RoomCheckOutHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RoomCheckOutResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RoomCheckOutResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RoomCheckOutResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>退房</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RoomCheckOutRequest
        /// </param>
        /// 
        /// <returns>
        /// RoomCheckOutResponse
        /// </returns>
        public RoomCheckOutResponse RoomCheckOut(RoomCheckOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RoomCheckOutHeaders headers = new RoomCheckOutHeaders();
            return RoomCheckOutWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>退房</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RoomCheckOutRequest
        /// </param>
        /// 
        /// <returns>
        /// RoomCheckOutResponse
        /// </returns>
        public async Task<RoomCheckOutResponse> RoomCheckOutAsync(RoomCheckOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RoomCheckOutHeaders headers = new RoomCheckOutHeaders();
            return await RoomCheckOutWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交酒店订单</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitHotelOrderRequest
        /// </param>
        /// <param name="headers">
        /// SubmitHotelOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitHotelOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SubmitHotelOrderResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SubmitHotelOrderResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交酒店订单</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitHotelOrderRequest
        /// </param>
        /// <param name="headers">
        /// SubmitHotelOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitHotelOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SubmitHotelOrderResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SubmitHotelOrderResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交酒店订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitHotelOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitHotelOrderResponse
        /// </returns>
        public SubmitHotelOrderResponse SubmitHotelOrder(SubmitHotelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubmitHotelOrderHeaders headers = new SubmitHotelOrderHeaders();
            return SubmitHotelOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交酒店订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitHotelOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitHotelOrderResponse
        /// </returns>
        public async Task<SubmitHotelOrderResponse> SubmitHotelOrderAsync(SubmitHotelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubmitHotelOrderHeaders headers = new SubmitHotelOrderHeaders();
            return await SubmitHotelOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步客控设备状态到主控设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncDeviceStatusWithAkRequest
        /// </param>
        /// <param name="headers">
        /// SyncDeviceStatusWithAkHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncDeviceStatusWithAkResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SyncDeviceStatusWithAkResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SyncDeviceStatusWithAkResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步客控设备状态到主控设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncDeviceStatusWithAkRequest
        /// </param>
        /// <param name="headers">
        /// SyncDeviceStatusWithAkHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncDeviceStatusWithAkResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SyncDeviceStatusWithAkResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SyncDeviceStatusWithAkResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步客控设备状态到主控设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncDeviceStatusWithAkRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncDeviceStatusWithAkResponse
        /// </returns>
        public SyncDeviceStatusWithAkResponse SyncDeviceStatusWithAk(SyncDeviceStatusWithAkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncDeviceStatusWithAkHeaders headers = new SyncDeviceStatusWithAkHeaders();
            return SyncDeviceStatusWithAkWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步客控设备状态到主控设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncDeviceStatusWithAkRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncDeviceStatusWithAkResponse
        /// </returns>
        public async Task<SyncDeviceStatusWithAkResponse> SyncDeviceStatusWithAkAsync(SyncDeviceStatusWithAkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncDeviceStatusWithAkHeaders headers = new SyncDeviceStatusWithAkHeaders();
            return await SyncDeviceStatusWithAkWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改基础信息问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBasicInfoQARequest
        /// </param>
        /// <param name="headers">
        /// UpdateBasicInfoQAHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBasicInfoQAResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateBasicInfoQAResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateBasicInfoQAResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改基础信息问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBasicInfoQARequest
        /// </param>
        /// <param name="headers">
        /// UpdateBasicInfoQAHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBasicInfoQAResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateBasicInfoQAResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateBasicInfoQAResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改基础信息问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBasicInfoQARequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBasicInfoQAResponse
        /// </returns>
        public UpdateBasicInfoQAResponse UpdateBasicInfoQA(UpdateBasicInfoQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateBasicInfoQAHeaders headers = new UpdateBasicInfoQAHeaders();
            return UpdateBasicInfoQAWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改基础信息问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBasicInfoQARequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBasicInfoQAResponse
        /// </returns>
        public async Task<UpdateBasicInfoQAResponse> UpdateBasicInfoQAAsync(UpdateBasicInfoQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateBasicInfoQAHeaders headers = new UpdateBasicInfoQAHeaders();
            return await UpdateBasicInfoQAWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自定义问答</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateCustomQARequest
        /// </param>
        /// <param name="headers">
        /// UpdateCustomQAHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomQAResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateCustomQAResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateCustomQAResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自定义问答</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateCustomQARequest
        /// </param>
        /// <param name="headers">
        /// UpdateCustomQAHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomQAResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateCustomQAResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateCustomQAResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自定义问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomQARequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomQAResponse
        /// </returns>
        public UpdateCustomQAResponse UpdateCustomQA(UpdateCustomQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCustomQAHeaders headers = new UpdateCustomQAHeaders();
            return UpdateCustomQAWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自定义问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomQARequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomQAResponse
        /// </returns>
        public async Task<UpdateCustomQAResponse> UpdateCustomQAAsync(UpdateCustomQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCustomQAHeaders headers = new UpdateCustomQAHeaders();
            return await UpdateCustomQAWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改酒店项目</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateHotelRequest
        /// </param>
        /// <param name="headers">
        /// UpdateHotelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHotelResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateHotelResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateHotelResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改酒店项目</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateHotelRequest
        /// </param>
        /// <param name="headers">
        /// UpdateHotelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHotelResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateHotelResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateHotelResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改酒店项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHotelRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHotelResponse
        /// </returns>
        public UpdateHotelResponse UpdateHotel(UpdateHotelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHotelHeaders headers = new UpdateHotelHeaders();
            return UpdateHotelWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改酒店项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHotelRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHotelResponse
        /// </returns>
        public async Task<UpdateHotelResponse> UpdateHotelAsync(UpdateHotelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHotelHeaders headers = new UpdateHotelHeaders();
            return await UpdateHotelWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改酒店闹钟</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateHotelAlarmRequest
        /// </param>
        /// <param name="headers">
        /// UpdateHotelAlarmHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHotelAlarmResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateHotelAlarmResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateHotelAlarmResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改酒店闹钟</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateHotelAlarmRequest
        /// </param>
        /// <param name="headers">
        /// UpdateHotelAlarmHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHotelAlarmResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateHotelAlarmResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateHotelAlarmResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改酒店闹钟</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHotelAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHotelAlarmResponse
        /// </returns>
        public UpdateHotelAlarmResponse UpdateHotelAlarm(UpdateHotelAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHotelAlarmHeaders headers = new UpdateHotelAlarmHeaders();
            return UpdateHotelAlarmWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改酒店闹钟</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHotelAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHotelAlarmResponse
        /// </returns>
        public async Task<UpdateHotelAlarmResponse> UpdateHotelAlarmAsync(UpdateHotelAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHotelAlarmHeaders headers = new UpdateHotelAlarmHeaders();
            return await UpdateHotelAlarmWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景预订编辑</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateHotelSceneBookItemRequest
        /// </param>
        /// <param name="headers">
        /// UpdateHotelSceneBookItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHotelSceneBookItemResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateHotelSceneBookItemResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateHotelSceneBookItemResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景预订编辑</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateHotelSceneBookItemRequest
        /// </param>
        /// <param name="headers">
        /// UpdateHotelSceneBookItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHotelSceneBookItemResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateHotelSceneBookItemResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateHotelSceneBookItemResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景预订编辑</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHotelSceneBookItemRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHotelSceneBookItemResponse
        /// </returns>
        public UpdateHotelSceneBookItemResponse UpdateHotelSceneBookItem(UpdateHotelSceneBookItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHotelSceneBookItemHeaders headers = new UpdateHotelSceneBookItemHeaders();
            return UpdateHotelSceneBookItemWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景预订编辑</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHotelSceneBookItemRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHotelSceneBookItemResponse
        /// </returns>
        public async Task<UpdateHotelSceneBookItemResponse> UpdateHotelSceneBookItemAsync(UpdateHotelSceneBookItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHotelSceneBookItemHeaders headers = new UpdateHotelSceneBookItemHeaders();
            return await UpdateHotelSceneBookItemWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景修改（开启/关闭/编辑）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateHotelSceneItemRequest
        /// </param>
        /// <param name="headers">
        /// UpdateHotelSceneItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHotelSceneItemResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateHotelSceneItemResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateHotelSceneItemResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景修改（开启/关闭/编辑）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateHotelSceneItemRequest
        /// </param>
        /// <param name="headers">
        /// UpdateHotelSceneItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHotelSceneItemResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateHotelSceneItemResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateHotelSceneItemResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景修改（开启/关闭/编辑）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHotelSceneItemRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHotelSceneItemResponse
        /// </returns>
        public UpdateHotelSceneItemResponse UpdateHotelSceneItem(UpdateHotelSceneItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHotelSceneItemHeaders headers = new UpdateHotelSceneItemHeaders();
            return UpdateHotelSceneItemWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店场景修改（开启/关闭/编辑）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHotelSceneItemRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHotelSceneItemResponse
        /// </returns>
        public async Task<UpdateHotelSceneItemResponse> UpdateHotelSceneItemAsync(UpdateHotelSceneItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateHotelSceneItemHeaders headers = new UpdateHotelSceneItemHeaders();
            return await UpdateHotelSceneItemWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新消息通知模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMessageTemplateRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMessageTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMessageTemplateResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateMessageTemplateResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateMessageTemplateResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新消息通知模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMessageTemplateRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMessageTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMessageTemplateResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateMessageTemplateResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateMessageTemplateResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新消息通知模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMessageTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMessageTemplateResponse
        /// </returns>
        public UpdateMessageTemplateResponse UpdateMessageTemplate(UpdateMessageTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMessageTemplateHeaders headers = new UpdateMessageTemplateHeaders();
            return UpdateMessageTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新消息通知模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMessageTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMessageTemplateResponse
        /// </returns>
        public async Task<UpdateMessageTemplateResponse> UpdateMessageTemplateAsync(UpdateMessageTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMessageTemplateHeaders headers = new UpdateMessageTemplateHeaders();
            return await UpdateMessageTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改酒店自定义rcu场景</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateRcuSceneRequest
        /// </param>
        /// <param name="headers">
        /// UpdateRcuSceneHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRcuSceneResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateRcuSceneResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateRcuSceneResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改酒店自定义rcu场景</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateRcuSceneRequest
        /// </param>
        /// <param name="headers">
        /// UpdateRcuSceneHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRcuSceneResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateRcuSceneResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateRcuSceneResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改酒店自定义rcu场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRcuSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRcuSceneResponse
        /// </returns>
        public UpdateRcuSceneResponse UpdateRcuScene(UpdateRcuSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRcuSceneHeaders headers = new UpdateRcuSceneHeaders();
            return UpdateRcuSceneWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改酒店自定义rcu场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRcuSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRcuSceneResponse
        /// </returns>
        public async Task<UpdateRcuSceneResponse> UpdateRcuSceneAsync(UpdateRcuSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRcuSceneHeaders headers = new UpdateRcuSceneHeaders();
            return await UpdateRcuSceneWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改服务设施问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceQARequest
        /// </param>
        /// <param name="headers">
        /// UpdateServiceQAHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceQAResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateServiceQAResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateServiceQAResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改服务设施问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceQARequest
        /// </param>
        /// <param name="headers">
        /// UpdateServiceQAHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceQAResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateServiceQAResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateServiceQAResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改服务设施问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceQARequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceQAResponse
        /// </returns>
        public UpdateServiceQAResponse UpdateServiceQA(UpdateServiceQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateServiceQAHeaders headers = new UpdateServiceQAHeaders();
            return UpdateServiceQAWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改服务设施问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceQARequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceQAResponse
        /// </returns>
        public async Task<UpdateServiceQAResponse> UpdateServiceQAAsync(UpdateServiceQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateServiceQAHeaders headers = new UpdateServiceQAHeaders();
            return await UpdateServiceQAWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改工单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTicketRequest
        /// </param>
        /// <param name="headers">
        /// UpdateTicketHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTicketResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateTicketResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateTicketResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改工单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTicketRequest
        /// </param>
        /// <param name="headers">
        /// UpdateTicketHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTicketResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateTicketResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateTicketResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改工单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTicketResponse
        /// </returns>
        public UpdateTicketResponse UpdateTicket(UpdateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTicketHeaders headers = new UpdateTicketHeaders();
            return UpdateTicketWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改工单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTicketResponse
        /// </returns>
        public async Task<UpdateTicketResponse> UpdateTicketAsync(UpdateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTicketHeaders headers = new UpdateTicketHeaders();
            return await UpdateTicketWithOptionsAsync(request, headers, runtime);
        }

    }
}
