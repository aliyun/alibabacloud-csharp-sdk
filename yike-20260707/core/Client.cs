// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Yike20260707.Models;

namespace AlibabaCloud.SDK.Yike20260707
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-shanghai", "yike.cn-shanghai.aliyuncs.com"},
                {"ap-southeast-1", "yike.ap-southeast-1.aliyuncs.com"},
            };
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
        /// <para>批量获取媒资信息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于查询媒资内容理解作业。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchGetMediasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetMediasResponse
        /// </returns>
        public BatchGetMediasResponse BatchGetMediasWithOptions(BatchGetMediasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthTimeout))
            {
                query["AuthTimeout"] = request.AuthTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                query["MediaIds"] = request.MediaIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetMedias",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetMediasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取媒资信息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于查询媒资内容理解作业。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchGetMediasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetMediasResponse
        /// </returns>
        public async Task<BatchGetMediasResponse> BatchGetMediasWithOptionsAsync(BatchGetMediasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthTimeout))
            {
                query["AuthTimeout"] = request.AuthTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                query["MediaIds"] = request.MediaIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetMedias",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetMediasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取媒资信息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于查询媒资内容理解作业。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchGetMediasRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetMediasResponse
        /// </returns>
        public BatchGetMediasResponse BatchGetMedias(BatchGetMediasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetMediasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取媒资信息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于查询媒资内容理解作业。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchGetMediasRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetMediasResponse
        /// </returns>
        public async Task<BatchGetMediasResponse> BatchGetMediasAsync(BatchGetMediasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetMediasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除媒资信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMediasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMediasResponse
        /// </returns>
        public DeleteMediasResponse DeleteMediasWithOptions(DeleteMediasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletePhysicalFiles))
            {
                query["DeletePhysicalFiles"] = request.DeletePhysicalFiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURLs))
            {
                query["InputURLs"] = request.InputURLs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                query["MediaIds"] = request.MediaIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMedias",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMediasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除媒资信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMediasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMediasResponse
        /// </returns>
        public async Task<DeleteMediasResponse> DeleteMediasWithOptionsAsync(DeleteMediasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletePhysicalFiles))
            {
                query["DeletePhysicalFiles"] = request.DeletePhysicalFiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURLs))
            {
                query["InputURLs"] = request.InputURLs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                query["MediaIds"] = request.MediaIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMedias",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMediasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除媒资信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMediasRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMediasResponse
        /// </returns>
        public DeleteMediasResponse DeleteMedias(DeleteMediasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMediasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除媒资信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMediasRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMediasResponse
        /// </returns>
        public async Task<DeleteMediasResponse> DeleteMediasAsync(DeleteMediasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMediasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询图片生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageGenerationJobResponse
        /// </returns>
        public GetImageGenerationJobResponse GetImageGenerationJobWithOptions(GetImageGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetImageGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageGenerationJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询图片生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageGenerationJobResponse
        /// </returns>
        public async Task<GetImageGenerationJobResponse> GetImageGenerationJobWithOptionsAsync(GetImageGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetImageGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageGenerationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询图片生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageGenerationJobResponse
        /// </returns>
        public GetImageGenerationJobResponse GetImageGenerationJob(GetImageGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageGenerationJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询图片生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageGenerationJobResponse
        /// </returns>
        public async Task<GetImageGenerationJobResponse> GetImageGenerationJobAsync(GetImageGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageGenerationJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询媒资</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于查询媒资内容理解作业。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMediaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMediaResponse
        /// </returns>
        public GetMediaResponse GetMediaWithOptions(GetMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthTimeout))
            {
                query["AuthTimeout"] = request.AuthTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURL))
            {
                query["InputURL"] = request.InputURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMedia",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询媒资</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于查询媒资内容理解作业。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMediaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMediaResponse
        /// </returns>
        public async Task<GetMediaResponse> GetMediaWithOptionsAsync(GetMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthTimeout))
            {
                query["AuthTimeout"] = request.AuthTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURL))
            {
                query["InputURL"] = request.InputURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMedia",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询媒资</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于查询媒资内容理解作业。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMediaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMediaResponse
        /// </returns>
        public GetMediaResponse GetMedia(GetMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询媒资</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于查询媒资内容理解作业。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMediaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMediaResponse
        /// </returns>
        public async Task<GetMediaResponse> GetMediaAsync(GetMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询媒资内容理解作业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMediaComprehensionJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMediaComprehensionJobResponse
        /// </returns>
        public GetMediaComprehensionJobResponse GetMediaComprehensionJobWithOptions(GetMediaComprehensionJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetMediaComprehensionJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaComprehensionJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询媒资内容理解作业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMediaComprehensionJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMediaComprehensionJobResponse
        /// </returns>
        public async Task<GetMediaComprehensionJobResponse> GetMediaComprehensionJobWithOptionsAsync(GetMediaComprehensionJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetMediaComprehensionJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaComprehensionJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询媒资内容理解作业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMediaComprehensionJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMediaComprehensionJobResponse
        /// </returns>
        public GetMediaComprehensionJobResponse GetMediaComprehensionJob(GetMediaComprehensionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaComprehensionJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询媒资内容理解作业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMediaComprehensionJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMediaComprehensionJobResponse
        /// </returns>
        public async Task<GetMediaComprehensionJobResponse> GetMediaComprehensionJobAsync(GetMediaComprehensionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaComprehensionJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询视频生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoGenerationJobResponse
        /// </returns>
        public GetVideoGenerationJobResponse GetVideoGenerationJobWithOptions(GetVideoGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
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
                Action = "GetVideoGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoGenerationJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询视频生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoGenerationJobResponse
        /// </returns>
        public async Task<GetVideoGenerationJobResponse> GetVideoGenerationJobWithOptionsAsync(GetVideoGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
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
                Action = "GetVideoGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoGenerationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询视频生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoGenerationJobResponse
        /// </returns>
        public GetVideoGenerationJobResponse GetVideoGenerationJob(GetVideoGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoGenerationJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询视频生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoGenerationJobResponse
        /// </returns>
        public async Task<GetVideoGenerationJobResponse> GetVideoGenerationJobAsync(GetVideoGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoGenerationJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导入媒资</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于查询媒资内容理解作业。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportMediaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportMediaResponse
        /// </returns>
        public ImportMediaResponse ImportMediaWithOptions(ImportMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicMetaData))
            {
                query["DynamicMetaData"] = request.DynamicMetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportSource))
            {
                query["ImportSource"] = request.ImportSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURL))
            {
                query["InputURL"] = request.InputURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaTags))
            {
                query["MediaTags"] = request.MediaTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overwrite))
            {
                query["Overwrite"] = request.Overwrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterConfig))
            {
                query["RegisterConfig"] = request.RegisterConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportMedia",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportMediaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导入媒资</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于查询媒资内容理解作业。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportMediaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportMediaResponse
        /// </returns>
        public async Task<ImportMediaResponse> ImportMediaWithOptionsAsync(ImportMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicMetaData))
            {
                query["DynamicMetaData"] = request.DynamicMetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportSource))
            {
                query["ImportSource"] = request.ImportSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURL))
            {
                query["InputURL"] = request.InputURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaTags))
            {
                query["MediaTags"] = request.MediaTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overwrite))
            {
                query["Overwrite"] = request.Overwrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterConfig))
            {
                query["RegisterConfig"] = request.RegisterConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportMedia",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportMediaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导入媒资</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于查询媒资内容理解作业。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportMediaRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportMediaResponse
        /// </returns>
        public ImportMediaResponse ImportMedia(ImportMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportMediaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导入媒资</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于查询媒资内容理解作业。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportMediaRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportMediaResponse
        /// </returns>
        public async Task<ImportMediaResponse> ImportMediaAsync(ImportMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportMediaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交图像生成接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitImageGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitImageGenerationJobResponse
        /// </returns>
        public SubmitImageGenerationJobResponse SubmitImageGenerationJobWithOptions(SubmitImageGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AspectRatio))
            {
                query["AspectRatio"] = request.AspectRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                query["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParameters))
            {
                query["JobParameters"] = request.JobParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.N))
            {
                query["N"] = request.N;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                query["Resolution"] = request.Resolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitImageGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitImageGenerationJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交图像生成接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitImageGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitImageGenerationJobResponse
        /// </returns>
        public async Task<SubmitImageGenerationJobResponse> SubmitImageGenerationJobWithOptionsAsync(SubmitImageGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AspectRatio))
            {
                query["AspectRatio"] = request.AspectRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                query["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParameters))
            {
                query["JobParameters"] = request.JobParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.N))
            {
                query["N"] = request.N;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                query["Resolution"] = request.Resolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitImageGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitImageGenerationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交图像生成接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitImageGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitImageGenerationJobResponse
        /// </returns>
        public SubmitImageGenerationJobResponse SubmitImageGenerationJob(SubmitImageGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitImageGenerationJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交图像生成接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitImageGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitImageGenerationJobResponse
        /// </returns>
        public async Task<SubmitImageGenerationJobResponse> SubmitImageGenerationJobAsync(SubmitImageGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitImageGenerationJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交媒资内容理解作业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitMediaComprehensionJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitMediaComprehensionJobResponse
        /// </returns>
        public SubmitMediaComprehensionJobResponse SubmitMediaComprehensionJobWithOptions(SubmitMediaComprehensionJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParams))
            {
                query["JobParams"] = request.JobParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitMediaComprehensionJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitMediaComprehensionJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交媒资内容理解作业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitMediaComprehensionJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitMediaComprehensionJobResponse
        /// </returns>
        public async Task<SubmitMediaComprehensionJobResponse> SubmitMediaComprehensionJobWithOptionsAsync(SubmitMediaComprehensionJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParams))
            {
                query["JobParams"] = request.JobParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitMediaComprehensionJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitMediaComprehensionJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交媒资内容理解作业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitMediaComprehensionJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitMediaComprehensionJobResponse
        /// </returns>
        public SubmitMediaComprehensionJobResponse SubmitMediaComprehensionJob(SubmitMediaComprehensionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitMediaComprehensionJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交媒资内容理解作业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitMediaComprehensionJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitMediaComprehensionJobResponse
        /// </returns>
        public async Task<SubmitMediaComprehensionJobResponse> SubmitMediaComprehensionJobAsync(SubmitMediaComprehensionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitMediaComprehensionJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交视频生成接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitVideoGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoGenerationJobResponse
        /// </returns>
        public SubmitVideoGenerationJobResponse SubmitVideoGenerationJobWithOptions(SubmitVideoGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AspectRatio))
            {
                query["AspectRatio"] = request.AspectRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                query["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParameters))
            {
                query["JobParameters"] = request.JobParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.N))
            {
                query["N"] = request.N;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                query["Resolution"] = request.Resolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitVideoGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitVideoGenerationJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交视频生成接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitVideoGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoGenerationJobResponse
        /// </returns>
        public async Task<SubmitVideoGenerationJobResponse> SubmitVideoGenerationJobWithOptionsAsync(SubmitVideoGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AspectRatio))
            {
                query["AspectRatio"] = request.AspectRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                query["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParameters))
            {
                query["JobParameters"] = request.JobParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.N))
            {
                query["N"] = request.N;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                query["Resolution"] = request.Resolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitVideoGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitVideoGenerationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交视频生成接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitVideoGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoGenerationJobResponse
        /// </returns>
        public SubmitVideoGenerationJobResponse SubmitVideoGenerationJob(SubmitVideoGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitVideoGenerationJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交视频生成接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitVideoGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoGenerationJobResponse
        /// </returns>
        public async Task<SubmitVideoGenerationJobResponse> SubmitVideoGenerationJobAsync(SubmitVideoGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitVideoGenerationJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateMedia</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于查询媒资内容理解作业。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMediaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMediaResponse
        /// </returns>
        public UpdateMediaResponse UpdateMediaWithOptions(UpdateMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppendTags))
            {
                query["AppendTags"] = request.AppendTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicMetaData))
            {
                query["DynamicMetaData"] = request.DynamicMetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURL))
            {
                query["InputURL"] = request.InputURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaTags))
            {
                query["MediaTags"] = request.MediaTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMedia",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMediaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateMedia</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于查询媒资内容理解作业。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMediaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMediaResponse
        /// </returns>
        public async Task<UpdateMediaResponse> UpdateMediaWithOptionsAsync(UpdateMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppendTags))
            {
                query["AppendTags"] = request.AppendTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicMetaData))
            {
                query["DynamicMetaData"] = request.DynamicMetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURL))
            {
                query["InputURL"] = request.InputURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaTags))
            {
                query["MediaTags"] = request.MediaTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMedia",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMediaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateMedia</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于查询媒资内容理解作业。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMediaRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMediaResponse
        /// </returns>
        public UpdateMediaResponse UpdateMedia(UpdateMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMediaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateMedia</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于查询媒资内容理解作业。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMediaRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMediaResponse
        /// </returns>
        public async Task<UpdateMediaResponse> UpdateMediaAsync(UpdateMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMediaWithOptionsAsync(request, runtime);
        }

    }
}
