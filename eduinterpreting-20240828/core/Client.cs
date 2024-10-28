// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.EduInterpreting20240828.Models;

namespace AlibabaCloud.SDK.EduInterpreting20240828
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("eduinterpreting", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>英语口译语音文件识别成英文内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeAudioRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeAudioResponse
        /// </returns>
        public RecognizeAudioResponse RecognizeAudioWithOptions(RecognizeAudioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCallBack))
            {
                query["EnableCallBack"] = request.EnableCallBack;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioFileUrl))
            {
                body["AudioFileUrl"] = request.AudioFileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterBizId))
            {
                body["OuterBizId"] = request.OuterBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeAudio",
                Version = "2024-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeAudioResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>英语口译语音文件识别成英文内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeAudioRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeAudioResponse
        /// </returns>
        public async Task<RecognizeAudioResponse> RecognizeAudioWithOptionsAsync(RecognizeAudioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCallBack))
            {
                query["EnableCallBack"] = request.EnableCallBack;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioFileUrl))
            {
                body["AudioFileUrl"] = request.AudioFileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterBizId))
            {
                body["OuterBizId"] = request.OuterBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeAudio",
                Version = "2024-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeAudioResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>英语口译语音文件识别成英文内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeAudioRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeAudioResponse
        /// </returns>
        public RecognizeAudioResponse RecognizeAudio(RecognizeAudioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeAudioWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>英语口译语音文件识别成英文内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeAudioRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeAudioResponse
        /// </returns>
        public async Task<RecognizeAudioResponse> RecognizeAudioAsync(RecognizeAudioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeAudioWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>口译评测任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitEvaluationTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitEvaluationTaskResponse
        /// </returns>
        public SubmitEvaluationTaskResponse SubmitEvaluationTaskWithOptions(SubmitEvaluationTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioUrl))
            {
                body["AudioUrl"] = request.AudioUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialText))
            {
                body["MaterialText"] = request.MaterialText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterBizId))
            {
                body["OuterBizId"] = request.OuterBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuggestedAnswer))
            {
                body["SuggestedAnswer"] = request.SuggestedAnswer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitEvaluationTask",
                Version = "2024-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitEvaluationTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>口译评测任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitEvaluationTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitEvaluationTaskResponse
        /// </returns>
        public async Task<SubmitEvaluationTaskResponse> SubmitEvaluationTaskWithOptionsAsync(SubmitEvaluationTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioUrl))
            {
                body["AudioUrl"] = request.AudioUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialText))
            {
                body["MaterialText"] = request.MaterialText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterBizId))
            {
                body["OuterBizId"] = request.OuterBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuggestedAnswer))
            {
                body["SuggestedAnswer"] = request.SuggestedAnswer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitEvaluationTask",
                Version = "2024-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitEvaluationTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>口译评测任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitEvaluationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitEvaluationTaskResponse
        /// </returns>
        public SubmitEvaluationTaskResponse SubmitEvaluationTask(SubmitEvaluationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitEvaluationTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>口译评测任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitEvaluationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitEvaluationTaskResponse
        /// </returns>
        public async Task<SubmitEvaluationTaskResponse> SubmitEvaluationTaskAsync(SubmitEvaluationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitEvaluationTaskWithOptionsAsync(request, runtime);
        }

    }
}
