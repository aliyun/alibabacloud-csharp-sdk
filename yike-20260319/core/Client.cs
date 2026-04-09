// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Yike20260319.Models;

namespace AlibabaCloud.SDK.Yike20260319
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("yike", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>批量获取一刻AI应用生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetYikeAIAppJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetYikeAIAppJobResponse
        /// </returns>
        public BatchGetYikeAIAppJobResponse BatchGetYikeAIAppJobWithOptions(BatchGetYikeAIAppJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIds))
            {
                query["JobIds"] = request.JobIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetYikeAIAppJob",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetYikeAIAppJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取一刻AI应用生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetYikeAIAppJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetYikeAIAppJobResponse
        /// </returns>
        public async Task<BatchGetYikeAIAppJobResponse> BatchGetYikeAIAppJobWithOptionsAsync(BatchGetYikeAIAppJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIds))
            {
                query["JobIds"] = request.JobIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetYikeAIAppJob",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetYikeAIAppJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取一刻AI应用生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetYikeAIAppJobRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetYikeAIAppJobResponse
        /// </returns>
        public BatchGetYikeAIAppJobResponse BatchGetYikeAIAppJob(BatchGetYikeAIAppJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetYikeAIAppJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取一刻AI应用生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetYikeAIAppJobRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetYikeAIAppJobResponse
        /// </returns>
        public async Task<BatchGetYikeAIAppJobResponse> BatchGetYikeAIAppJobAsync(BatchGetYikeAIAppJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetYikeAIAppJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻媒资上传凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateYikeAssetUploadRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateYikeAssetUploadResponse
        /// </returns>
        public CreateYikeAssetUploadResponse CreateYikeAssetUploadWithOptions(CreateYikeAssetUploadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileExt))
            {
                query["FileExt"] = request.FileExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateYikeAssetUpload",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateYikeAssetUploadResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻媒资上传凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateYikeAssetUploadRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateYikeAssetUploadResponse
        /// </returns>
        public async Task<CreateYikeAssetUploadResponse> CreateYikeAssetUploadWithOptionsAsync(CreateYikeAssetUploadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileExt))
            {
                query["FileExt"] = request.FileExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateYikeAssetUpload",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateYikeAssetUploadResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻媒资上传凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateYikeAssetUploadRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateYikeAssetUploadResponse
        /// </returns>
        public CreateYikeAssetUploadResponse CreateYikeAssetUpload(CreateYikeAssetUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateYikeAssetUploadWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻媒资上传凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateYikeAssetUploadRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateYikeAssetUploadResponse
        /// </returns>
        public async Task<CreateYikeAssetUploadResponse> CreateYikeAssetUploadAsync(CreateYikeAssetUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateYikeAssetUploadWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻AI应用任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeAIAppJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetYikeAIAppJobResponse
        /// </returns>
        public GetYikeAIAppJobResponse GetYikeAIAppJobWithOptions(GetYikeAIAppJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetYikeAIAppJob",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYikeAIAppJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻AI应用任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeAIAppJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetYikeAIAppJobResponse
        /// </returns>
        public async Task<GetYikeAIAppJobResponse> GetYikeAIAppJobWithOptionsAsync(GetYikeAIAppJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetYikeAIAppJob",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYikeAIAppJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻AI应用任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeAIAppJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetYikeAIAppJobResponse
        /// </returns>
        public GetYikeAIAppJobResponse GetYikeAIAppJob(GetYikeAIAppJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetYikeAIAppJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻AI应用任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeAIAppJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetYikeAIAppJobResponse
        /// </returns>
        public async Task<GetYikeAIAppJobResponse> GetYikeAIAppJobAsync(GetYikeAIAppJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetYikeAIAppJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻故事板任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeStoryboardJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetYikeStoryboardJobResponse
        /// </returns>
        public GetYikeStoryboardJobResponse GetYikeStoryboardJobWithOptions(GetYikeStoryboardJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetYikeStoryboardJob",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYikeStoryboardJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻故事板任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeStoryboardJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetYikeStoryboardJobResponse
        /// </returns>
        public async Task<GetYikeStoryboardJobResponse> GetYikeStoryboardJobWithOptionsAsync(GetYikeStoryboardJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetYikeStoryboardJob",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYikeStoryboardJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻故事板任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeStoryboardJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetYikeStoryboardJobResponse
        /// </returns>
        public GetYikeStoryboardJobResponse GetYikeStoryboardJob(GetYikeStoryboardJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetYikeStoryboardJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻故事板任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeStoryboardJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetYikeStoryboardJobResponse
        /// </returns>
        public async Task<GetYikeStoryboardJobResponse> GetYikeStoryboardJobAsync(GetYikeStoryboardJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetYikeStoryboardJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交一刻AI应用任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitYikeAIAppJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitYikeAIAppJobResponse
        /// </returns>
        public SubmitYikeAIAppJobResponse SubmitYikeAIAppJobWithOptions(SubmitYikeAIAppJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppParams))
            {
                body["AppParams"] = request.AppParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                body["FolderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionId))
            {
                body["ProductionId"] = request.ProductionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitYikeAIAppJob",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitYikeAIAppJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交一刻AI应用任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitYikeAIAppJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitYikeAIAppJobResponse
        /// </returns>
        public async Task<SubmitYikeAIAppJobResponse> SubmitYikeAIAppJobWithOptionsAsync(SubmitYikeAIAppJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppParams))
            {
                body["AppParams"] = request.AppParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                body["FolderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionId))
            {
                body["ProductionId"] = request.ProductionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitYikeAIAppJob",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitYikeAIAppJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交一刻AI应用任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitYikeAIAppJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitYikeAIAppJobResponse
        /// </returns>
        public SubmitYikeAIAppJobResponse SubmitYikeAIAppJob(SubmitYikeAIAppJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitYikeAIAppJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交一刻AI应用任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitYikeAIAppJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitYikeAIAppJobResponse
        /// </returns>
        public async Task<SubmitYikeAIAppJobResponse> SubmitYikeAIAppJobAsync(SubmitYikeAIAppJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitYikeAIAppJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交一刻故事板任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitYikeStoryboardJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitYikeStoryboardJobResponse
        /// </returns>
        public SubmitYikeStoryboardJobResponse SubmitYikeStoryboardJobWithOptions(SubmitYikeStoryboardJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AspectRatio))
            {
                query["AspectRatio"] = request.AspectRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecMode))
            {
                query["ExecMode"] = request.ExecMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelParams))
            {
                query["ModelParams"] = request.ModelParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NarrationVoiceId))
            {
                query["NarrationVoiceId"] = request.NarrationVoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                query["Resolution"] = request.Resolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShotPromptMode))
            {
                query["ShotPromptMode"] = request.ShotPromptMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipFailureShot))
            {
                query["SkipFailureShot"] = request.SkipFailureShot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoModel))
            {
                query["VideoModel"] = request.VideoModel;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileURL))
            {
                body["FileURL"] = request.FileURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShotSplitMode))
            {
                body["ShotSplitMode"] = request.ShotSplitMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleId))
            {
                body["StyleId"] = request.StyleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitYikeStoryboardJob",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitYikeStoryboardJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交一刻故事板任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitYikeStoryboardJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitYikeStoryboardJobResponse
        /// </returns>
        public async Task<SubmitYikeStoryboardJobResponse> SubmitYikeStoryboardJobWithOptionsAsync(SubmitYikeStoryboardJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AspectRatio))
            {
                query["AspectRatio"] = request.AspectRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecMode))
            {
                query["ExecMode"] = request.ExecMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelParams))
            {
                query["ModelParams"] = request.ModelParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NarrationVoiceId))
            {
                query["NarrationVoiceId"] = request.NarrationVoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                query["Resolution"] = request.Resolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShotPromptMode))
            {
                query["ShotPromptMode"] = request.ShotPromptMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipFailureShot))
            {
                query["SkipFailureShot"] = request.SkipFailureShot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoModel))
            {
                query["VideoModel"] = request.VideoModel;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileURL))
            {
                body["FileURL"] = request.FileURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShotSplitMode))
            {
                body["ShotSplitMode"] = request.ShotSplitMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleId))
            {
                body["StyleId"] = request.StyleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitYikeStoryboardJob",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitYikeStoryboardJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交一刻故事板任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitYikeStoryboardJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitYikeStoryboardJobResponse
        /// </returns>
        public SubmitYikeStoryboardJobResponse SubmitYikeStoryboardJob(SubmitYikeStoryboardJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitYikeStoryboardJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交一刻故事板任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitYikeStoryboardJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitYikeStoryboardJobResponse
        /// </returns>
        public async Task<SubmitYikeStoryboardJobResponse> SubmitYikeStoryboardJobAsync(SubmitYikeStoryboardJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitYikeStoryboardJobWithOptionsAsync(request, runtime);
        }

    }
}
