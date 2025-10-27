// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Captcha20230305.Models;

namespace AlibabaCloud.SDK.Captcha20230305
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("captcha", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>验证码验证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyCaptchaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyCaptchaResponse
        /// </returns>
        public VerifyCaptchaResponse VerifyCaptchaWithOptions(VerifyCaptchaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaptchaVerifyParam))
            {
                query["CaptchaVerifyParam"] = request.CaptchaVerifyParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyCaptcha",
                Version = "2023-03-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyCaptchaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>验证码验证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyCaptchaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyCaptchaResponse
        /// </returns>
        public async Task<VerifyCaptchaResponse> VerifyCaptchaWithOptionsAsync(VerifyCaptchaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaptchaVerifyParam))
            {
                query["CaptchaVerifyParam"] = request.CaptchaVerifyParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyCaptcha",
                Version = "2023-03-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyCaptchaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>验证码验证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyCaptchaRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyCaptchaResponse
        /// </returns>
        public VerifyCaptchaResponse VerifyCaptcha(VerifyCaptchaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyCaptchaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>验证码验证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyCaptchaRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyCaptchaResponse
        /// </returns>
        public async Task<VerifyCaptchaResponse> VerifyCaptchaAsync(VerifyCaptchaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyCaptchaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>验证码验证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyIntelligentCaptchaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyIntelligentCaptchaResponse
        /// </returns>
        public VerifyIntelligentCaptchaResponse VerifyIntelligentCaptchaWithOptions(VerifyIntelligentCaptchaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaptchaVerifyParam))
            {
                body["CaptchaVerifyParam"] = request.CaptchaVerifyParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyIntelligentCaptcha",
                Version = "2023-03-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyIntelligentCaptchaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>验证码验证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyIntelligentCaptchaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyIntelligentCaptchaResponse
        /// </returns>
        public async Task<VerifyIntelligentCaptchaResponse> VerifyIntelligentCaptchaWithOptionsAsync(VerifyIntelligentCaptchaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaptchaVerifyParam))
            {
                body["CaptchaVerifyParam"] = request.CaptchaVerifyParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyIntelligentCaptcha",
                Version = "2023-03-05",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyIntelligentCaptchaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>验证码验证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyIntelligentCaptchaRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyIntelligentCaptchaResponse
        /// </returns>
        public VerifyIntelligentCaptchaResponse VerifyIntelligentCaptcha(VerifyIntelligentCaptchaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyIntelligentCaptchaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>验证码验证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyIntelligentCaptchaRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyIntelligentCaptchaResponse
        /// </returns>
        public async Task<VerifyIntelligentCaptchaResponse> VerifyIntelligentCaptchaAsync(VerifyIntelligentCaptchaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyIntelligentCaptchaWithOptionsAsync(request, runtime);
        }

    }
}
