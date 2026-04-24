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
        /// <para>增加用户积分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddYikeUserCreditRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddYikeUserCreditResponse
        /// </returns>
        public AddYikeUserCreditResponse AddYikeUserCreditWithOptions(AddYikeUserCreditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credit))
            {
                query["Credit"] = request.Credit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YikeUserId))
            {
                query["YikeUserId"] = request.YikeUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddYikeUserCredit",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddYikeUserCreditResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加用户积分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddYikeUserCreditRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddYikeUserCreditResponse
        /// </returns>
        public async Task<AddYikeUserCreditResponse> AddYikeUserCreditWithOptionsAsync(AddYikeUserCreditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credit))
            {
                query["Credit"] = request.Credit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YikeUserId))
            {
                query["YikeUserId"] = request.YikeUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddYikeUserCredit",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddYikeUserCreditResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加用户积分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddYikeUserCreditRequest
        /// </param>
        /// 
        /// <returns>
        /// AddYikeUserCreditResponse
        /// </returns>
        public AddYikeUserCreditResponse AddYikeUserCredit(AddYikeUserCreditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddYikeUserCreditWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加用户积分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddYikeUserCreditRequest
        /// </param>
        /// 
        /// <returns>
        /// AddYikeUserCreditResponse
        /// </returns>
        public async Task<AddYikeUserCreditResponse> AddYikeUserCreditAsync(AddYikeUserCreditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddYikeUserCreditWithOptionsAsync(request, runtime);
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
        /// <para>批量获取媒资信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetYikeAssetMediaInfosRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetYikeAssetMediaInfosResponse
        /// </returns>
        public BatchGetYikeAssetMediaInfosResponse BatchGetYikeAssetMediaInfosWithOptions(BatchGetYikeAssetMediaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "BatchGetYikeAssetMediaInfos",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetYikeAssetMediaInfosResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取媒资信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetYikeAssetMediaInfosRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetYikeAssetMediaInfosResponse
        /// </returns>
        public async Task<BatchGetYikeAssetMediaInfosResponse> BatchGetYikeAssetMediaInfosWithOptionsAsync(BatchGetYikeAssetMediaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "BatchGetYikeAssetMediaInfos",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetYikeAssetMediaInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取媒资信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetYikeAssetMediaInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetYikeAssetMediaInfosResponse
        /// </returns>
        public BatchGetYikeAssetMediaInfosResponse BatchGetYikeAssetMediaInfos(BatchGetYikeAssetMediaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetYikeAssetMediaInfosWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取媒资信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetYikeAssetMediaInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetYikeAssetMediaInfosResponse
        /// </returns>
        public async Task<BatchGetYikeAssetMediaInfosResponse> BatchGetYikeAssetMediaInfosAsync(BatchGetYikeAssetMediaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetYikeAssetMediaInfosWithOptionsAsync(request, runtime);
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
        /// <para>创建一刻项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateYikeProductionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateYikeProductionResponse
        /// </returns>
        public CreateYikeProductionResponse CreateYikeProductionWithOptions(CreateYikeProductionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateYikeProduction",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateYikeProductionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一刻项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateYikeProductionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateYikeProductionResponse
        /// </returns>
        public async Task<CreateYikeProductionResponse> CreateYikeProductionWithOptionsAsync(CreateYikeProductionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateYikeProduction",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateYikeProductionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一刻项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateYikeProductionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateYikeProductionResponse
        /// </returns>
        public CreateYikeProductionResponse CreateYikeProduction(CreateYikeProductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateYikeProductionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一刻项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateYikeProductionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateYikeProductionResponse
        /// </returns>
        public async Task<CreateYikeProductionResponse> CreateYikeProductionAsync(CreateYikeProductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateYikeProductionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一刻子用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateYikeUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateYikeUserResponse
        /// </returns>
        public CreateYikeUserResponse CreateYikeUserWithOptions(CreateYikeUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nickname))
            {
                query["Nickname"] = request.Nickname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionIds))
            {
                query["ProductionIds"] = request.ProductionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserNamePrefix))
            {
                query["UserNamePrefix"] = request.UserNamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateYikeUser",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateYikeUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一刻子用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateYikeUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateYikeUserResponse
        /// </returns>
        public async Task<CreateYikeUserResponse> CreateYikeUserWithOptionsAsync(CreateYikeUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nickname))
            {
                query["Nickname"] = request.Nickname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionIds))
            {
                query["ProductionIds"] = request.ProductionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserNamePrefix))
            {
                query["UserNamePrefix"] = request.UserNamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateYikeUser",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateYikeUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一刻子用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateYikeUserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateYikeUserResponse
        /// </returns>
        public CreateYikeUserResponse CreateYikeUser(CreateYikeUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateYikeUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一刻子用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateYikeUserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateYikeUserResponse
        /// </returns>
        public async Task<CreateYikeUserResponse> CreateYikeUserAsync(CreateYikeUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateYikeUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工作室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateYikeWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateYikeWorkspaceResponse
        /// </returns>
        public CreateYikeWorkspaceResponse CreateYikeWorkspaceWithOptions(CreateYikeWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCountLimit))
            {
                query["UserCountLimit"] = request.UserCountLimit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateYikeWorkspace",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateYikeWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工作室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateYikeWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateYikeWorkspaceResponse
        /// </returns>
        public async Task<CreateYikeWorkspaceResponse> CreateYikeWorkspaceWithOptionsAsync(CreateYikeWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCountLimit))
            {
                query["UserCountLimit"] = request.UserCountLimit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateYikeWorkspace",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateYikeWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工作室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateYikeWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateYikeWorkspaceResponse
        /// </returns>
        public CreateYikeWorkspaceResponse CreateYikeWorkspace(CreateYikeWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateYikeWorkspaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工作室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateYikeWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateYikeWorkspaceResponse
        /// </returns>
        public async Task<CreateYikeWorkspaceResponse> CreateYikeWorkspaceAsync(CreateYikeWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateYikeWorkspaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除媒资信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteYikeAssetMediaInfosRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteYikeAssetMediaInfosResponse
        /// </returns>
        public DeleteYikeAssetMediaInfosResponse DeleteYikeAssetMediaInfosWithOptions(DeleteYikeAssetMediaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicDelete))
            {
                query["LogicDelete"] = request.LogicDelete;
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
                Action = "DeleteYikeAssetMediaInfos",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteYikeAssetMediaInfosResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除媒资信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteYikeAssetMediaInfosRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteYikeAssetMediaInfosResponse
        /// </returns>
        public async Task<DeleteYikeAssetMediaInfosResponse> DeleteYikeAssetMediaInfosWithOptionsAsync(DeleteYikeAssetMediaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicDelete))
            {
                query["LogicDelete"] = request.LogicDelete;
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
                Action = "DeleteYikeAssetMediaInfos",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteYikeAssetMediaInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除媒资信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteYikeAssetMediaInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteYikeAssetMediaInfosResponse
        /// </returns>
        public DeleteYikeAssetMediaInfosResponse DeleteYikeAssetMediaInfos(DeleteYikeAssetMediaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteYikeAssetMediaInfosWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除媒资信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteYikeAssetMediaInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteYikeAssetMediaInfosResponse
        /// </returns>
        public async Task<DeleteYikeAssetMediaInfosResponse> DeleteYikeAssetMediaInfosAsync(DeleteYikeAssetMediaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteYikeAssetMediaInfosWithOptionsAsync(request, runtime);
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
        /// <para>获取一刻媒资内容信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeAssetMediaInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetYikeAssetMediaInfoResponse
        /// </returns>
        public GetYikeAssetMediaInfoResponse GetYikeAssetMediaInfoWithOptions(GetYikeAssetMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetYikeAssetMediaInfo",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYikeAssetMediaInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻媒资内容信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeAssetMediaInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetYikeAssetMediaInfoResponse
        /// </returns>
        public async Task<GetYikeAssetMediaInfoResponse> GetYikeAssetMediaInfoWithOptionsAsync(GetYikeAssetMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetYikeAssetMediaInfo",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYikeAssetMediaInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻媒资内容信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeAssetMediaInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetYikeAssetMediaInfoResponse
        /// </returns>
        public GetYikeAssetMediaInfoResponse GetYikeAssetMediaInfo(GetYikeAssetMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetYikeAssetMediaInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻媒资内容信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeAssetMediaInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetYikeAssetMediaInfoResponse
        /// </returns>
        public async Task<GetYikeAssetMediaInfoResponse> GetYikeAssetMediaInfoAsync(GetYikeAssetMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetYikeAssetMediaInfoWithOptionsAsync(request, runtime);
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
        /// <para>获取一刻子用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetYikeUserResponse
        /// </returns>
        public GetYikeUserResponse GetYikeUserWithOptions(GetYikeUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetYikeUser",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYikeUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻子用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetYikeUserResponse
        /// </returns>
        public async Task<GetYikeUserResponse> GetYikeUserWithOptionsAsync(GetYikeUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetYikeUser",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYikeUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻子用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeUserRequest
        /// </param>
        /// 
        /// <returns>
        /// GetYikeUserResponse
        /// </returns>
        public GetYikeUserResponse GetYikeUser(GetYikeUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetYikeUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻子用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeUserRequest
        /// </param>
        /// 
        /// <returns>
        /// GetYikeUserResponse
        /// </returns>
        public async Task<GetYikeUserResponse> GetYikeUserAsync(GetYikeUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetYikeUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一刻用户积分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeUserCreditRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetYikeUserCreditResponse
        /// </returns>
        public GetYikeUserCreditResponse GetYikeUserCreditWithOptions(GetYikeUserCreditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YikeUserId))
            {
                query["YikeUserId"] = request.YikeUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetYikeUserCredit",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYikeUserCreditResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一刻用户积分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeUserCreditRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetYikeUserCreditResponse
        /// </returns>
        public async Task<GetYikeUserCreditResponse> GetYikeUserCreditWithOptionsAsync(GetYikeUserCreditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YikeUserId))
            {
                query["YikeUserId"] = request.YikeUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetYikeUserCredit",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYikeUserCreditResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一刻用户积分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeUserCreditRequest
        /// </param>
        /// 
        /// <returns>
        /// GetYikeUserCreditResponse
        /// </returns>
        public GetYikeUserCreditResponse GetYikeUserCredit(GetYikeUserCreditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetYikeUserCreditWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一刻用户积分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeUserCreditRequest
        /// </param>
        /// 
        /// <returns>
        /// GetYikeUserCreditResponse
        /// </returns>
        public async Task<GetYikeUserCreditResponse> GetYikeUserCreditAsync(GetYikeUserCreditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetYikeUserCreditWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一刻口播视频生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeVoiceNarratorJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetYikeVoiceNarratorJobResponse
        /// </returns>
        public GetYikeVoiceNarratorJobResponse GetYikeVoiceNarratorJobWithOptions(GetYikeVoiceNarratorJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetYikeVoiceNarratorJob",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYikeVoiceNarratorJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一刻口播视频生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeVoiceNarratorJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetYikeVoiceNarratorJobResponse
        /// </returns>
        public async Task<GetYikeVoiceNarratorJobResponse> GetYikeVoiceNarratorJobWithOptionsAsync(GetYikeVoiceNarratorJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetYikeVoiceNarratorJob",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYikeVoiceNarratorJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一刻口播视频生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeVoiceNarratorJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetYikeVoiceNarratorJobResponse
        /// </returns>
        public GetYikeVoiceNarratorJobResponse GetYikeVoiceNarratorJob(GetYikeVoiceNarratorJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetYikeVoiceNarratorJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一刻口播视频生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeVoiceNarratorJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetYikeVoiceNarratorJobResponse
        /// </returns>
        public async Task<GetYikeVoiceNarratorJobResponse> GetYikeVoiceNarratorJobAsync(GetYikeVoiceNarratorJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetYikeVoiceNarratorJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻文件夹列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListYikeAssetFoldersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListYikeAssetFoldersResponse
        /// </returns>
        public ListYikeAssetFoldersResponse ListYikeAssetFoldersWithOptions(ListYikeAssetFoldersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionId))
            {
                query["ProductionId"] = request.ProductionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListYikeAssetFolders",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListYikeAssetFoldersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻文件夹列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListYikeAssetFoldersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListYikeAssetFoldersResponse
        /// </returns>
        public async Task<ListYikeAssetFoldersResponse> ListYikeAssetFoldersWithOptionsAsync(ListYikeAssetFoldersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionId))
            {
                query["ProductionId"] = request.ProductionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListYikeAssetFolders",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListYikeAssetFoldersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻文件夹列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListYikeAssetFoldersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListYikeAssetFoldersResponse
        /// </returns>
        public ListYikeAssetFoldersResponse ListYikeAssetFolders(ListYikeAssetFoldersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListYikeAssetFoldersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻文件夹列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListYikeAssetFoldersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListYikeAssetFoldersResponse
        /// </returns>
        public async Task<ListYikeAssetFoldersResponse> ListYikeAssetFoldersAsync(ListYikeAssetFoldersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListYikeAssetFoldersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻项目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListYikeProductionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListYikeProductionsResponse
        /// </returns>
        public ListYikeProductionsResponse ListYikeProductionsWithOptions(ListYikeProductionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListYikeProductions",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListYikeProductionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻项目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListYikeProductionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListYikeProductionsResponse
        /// </returns>
        public async Task<ListYikeProductionsResponse> ListYikeProductionsWithOptionsAsync(ListYikeProductionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListYikeProductions",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListYikeProductionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻项目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListYikeProductionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListYikeProductionsResponse
        /// </returns>
        public ListYikeProductionsResponse ListYikeProductions(ListYikeProductionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListYikeProductionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一刻项目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListYikeProductionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListYikeProductionsResponse
        /// </returns>
        public async Task<ListYikeProductionsResponse> ListYikeProductionsAsync(ListYikeProductionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListYikeProductionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查应用参数是否合法</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PrecheckYikeAIAppJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PrecheckYikeAIAppJobResponse
        /// </returns>
        public PrecheckYikeAIAppJobResponse PrecheckYikeAIAppJobWithOptions(PrecheckYikeAIAppJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppParams))
            {
                query["AppParams"] = request.AppParams;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PrecheckYikeAIAppJob",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PrecheckYikeAIAppJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查应用参数是否合法</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PrecheckYikeAIAppJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PrecheckYikeAIAppJobResponse
        /// </returns>
        public async Task<PrecheckYikeAIAppJobResponse> PrecheckYikeAIAppJobWithOptionsAsync(PrecheckYikeAIAppJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppParams))
            {
                query["AppParams"] = request.AppParams;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PrecheckYikeAIAppJob",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PrecheckYikeAIAppJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查应用参数是否合法</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PrecheckYikeAIAppJobRequest
        /// </param>
        /// 
        /// <returns>
        /// PrecheckYikeAIAppJobResponse
        /// </returns>
        public PrecheckYikeAIAppJobResponse PrecheckYikeAIAppJob(PrecheckYikeAIAppJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PrecheckYikeAIAppJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查应用参数是否合法</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PrecheckYikeAIAppJobRequest
        /// </param>
        /// 
        /// <returns>
        /// PrecheckYikeAIAppJobResponse
        /// </returns>
        public async Task<PrecheckYikeAIAppJobResponse> PrecheckYikeAIAppJobAsync(PrecheckYikeAIAppJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PrecheckYikeAIAppJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册一刻媒资</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterYikeAssetMediaInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterYikeAssetMediaInfoResponse
        /// </returns>
        public RegisterYikeAssetMediaInfoResponse RegisterYikeAssetMediaInfoWithOptions(RegisterYikeAssetMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                query["FolderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURL))
            {
                query["InputURL"] = request.InputURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionId))
            {
                query["ProductionId"] = request.ProductionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterYikeAssetMediaInfo",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterYikeAssetMediaInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册一刻媒资</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterYikeAssetMediaInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterYikeAssetMediaInfoResponse
        /// </returns>
        public async Task<RegisterYikeAssetMediaInfoResponse> RegisterYikeAssetMediaInfoWithOptionsAsync(RegisterYikeAssetMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                query["FolderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURL))
            {
                query["InputURL"] = request.InputURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionId))
            {
                query["ProductionId"] = request.ProductionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterYikeAssetMediaInfo",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterYikeAssetMediaInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册一刻媒资</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterYikeAssetMediaInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterYikeAssetMediaInfoResponse
        /// </returns>
        public RegisterYikeAssetMediaInfoResponse RegisterYikeAssetMediaInfo(RegisterYikeAssetMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterYikeAssetMediaInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册一刻媒资</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterYikeAssetMediaInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterYikeAssetMediaInfoResponse
        /// </returns>
        public async Task<RegisterYikeAssetMediaInfoResponse> RegisterYikeAssetMediaInfoAsync(RegisterYikeAssetMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterYikeAssetMediaInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>故事板任务恢复继续执行任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeYikeStoryboardJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeYikeStoryboardJobResponse
        /// </returns>
        public ResumeYikeStoryboardJobResponse ResumeYikeStoryboardJobWithOptions(ResumeYikeStoryboardJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ResumeYikeStoryboardJob",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeYikeStoryboardJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>故事板任务恢复继续执行任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeYikeStoryboardJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeYikeStoryboardJobResponse
        /// </returns>
        public async Task<ResumeYikeStoryboardJobResponse> ResumeYikeStoryboardJobWithOptionsAsync(ResumeYikeStoryboardJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ResumeYikeStoryboardJob",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeYikeStoryboardJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>故事板任务恢复继续执行任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeYikeStoryboardJobRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumeYikeStoryboardJobResponse
        /// </returns>
        public ResumeYikeStoryboardJobResponse ResumeYikeStoryboardJob(ResumeYikeStoryboardJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeYikeStoryboardJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>故事板任务恢复继续执行任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeYikeStoryboardJobRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumeYikeStoryboardJobResponse
        /// </returns>
        public async Task<ResumeYikeStoryboardJobResponse> ResumeYikeStoryboardJobAsync(ResumeYikeStoryboardJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeYikeStoryboardJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置一刻事件回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetYikeCallbackConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetYikeCallbackConfigResponse
        /// </returns>
        public SetYikeCallbackConfigResponse SetYikeCallbackConfigWithOptions(SetYikeCallbackConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackConfig))
            {
                query["CallbackConfig"] = request.CallbackConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetYikeCallbackConfig",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetYikeCallbackConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置一刻事件回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetYikeCallbackConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetYikeCallbackConfigResponse
        /// </returns>
        public async Task<SetYikeCallbackConfigResponse> SetYikeCallbackConfigWithOptionsAsync(SetYikeCallbackConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackConfig))
            {
                query["CallbackConfig"] = request.CallbackConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetYikeCallbackConfig",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetYikeCallbackConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置一刻事件回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetYikeCallbackConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SetYikeCallbackConfigResponse
        /// </returns>
        public SetYikeCallbackConfigResponse SetYikeCallbackConfig(SetYikeCallbackConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetYikeCallbackConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置一刻事件回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetYikeCallbackConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SetYikeCallbackConfigResponse
        /// </returns>
        public async Task<SetYikeCallbackConfigResponse> SetYikeCallbackConfigAsync(SetYikeCallbackConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetYikeCallbackConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置用户角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetYikeUserRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetYikeUserRoleResponse
        /// </returns>
        public SetYikeUserRoleResponse SetYikeUserRoleWithOptions(SetYikeUserRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YikeUserId))
            {
                query["YikeUserId"] = request.YikeUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetYikeUserRole",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetYikeUserRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置用户角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetYikeUserRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetYikeUserRoleResponse
        /// </returns>
        public async Task<SetYikeUserRoleResponse> SetYikeUserRoleWithOptionsAsync(SetYikeUserRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YikeUserId))
            {
                query["YikeUserId"] = request.YikeUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetYikeUserRole",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetYikeUserRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置用户角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetYikeUserRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// SetYikeUserRoleResponse
        /// </returns>
        public SetYikeUserRoleResponse SetYikeUserRole(SetYikeUserRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetYikeUserRoleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置用户角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetYikeUserRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// SetYikeUserRoleResponse
        /// </returns>
        public async Task<SetYikeUserRoleResponse> SetYikeUserRoleAsync(SetYikeUserRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetYikeUserRoleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>扣减用户积分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubYikeUserCreditRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubYikeUserCreditResponse
        /// </returns>
        public SubYikeUserCreditResponse SubYikeUserCreditWithOptions(SubYikeUserCreditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credit))
            {
                query["Credit"] = request.Credit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YikeUserId))
            {
                query["YikeUserId"] = request.YikeUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubYikeUserCredit",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubYikeUserCreditResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>扣减用户积分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubYikeUserCreditRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubYikeUserCreditResponse
        /// </returns>
        public async Task<SubYikeUserCreditResponse> SubYikeUserCreditWithOptionsAsync(SubYikeUserCreditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credit))
            {
                query["Credit"] = request.Credit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YikeUserId))
            {
                query["YikeUserId"] = request.YikeUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubYikeUserCredit",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubYikeUserCreditResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>扣减用户积分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubYikeUserCreditRequest
        /// </param>
        /// 
        /// <returns>
        /// SubYikeUserCreditResponse
        /// </returns>
        public SubYikeUserCreditResponse SubYikeUserCredit(SubYikeUserCreditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubYikeUserCreditWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>扣减用户积分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubYikeUserCreditRequest
        /// </param>
        /// 
        /// <returns>
        /// SubYikeUserCreditResponse
        /// </returns>
        public async Task<SubYikeUserCreditResponse> SubYikeUserCreditAsync(SubYikeUserCreditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubYikeUserCreditWithOptionsAsync(request, runtime);
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交一刻口播视频生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitYikeVoiceNarratorJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitYikeVoiceNarratorJobResponse
        /// </returns>
        public SubmitYikeVoiceNarratorJobResponse SubmitYikeVoiceNarratorJobWithOptions(SubmitYikeVoiceNarratorJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParams))
            {
                body["JobParams"] = request.JobParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitYikeVoiceNarratorJob",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitYikeVoiceNarratorJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交一刻口播视频生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitYikeVoiceNarratorJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitYikeVoiceNarratorJobResponse
        /// </returns>
        public async Task<SubmitYikeVoiceNarratorJobResponse> SubmitYikeVoiceNarratorJobWithOptionsAsync(SubmitYikeVoiceNarratorJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParams))
            {
                body["JobParams"] = request.JobParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitYikeVoiceNarratorJob",
                Version = "2026-03-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitYikeVoiceNarratorJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交一刻口播视频生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitYikeVoiceNarratorJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitYikeVoiceNarratorJobResponse
        /// </returns>
        public SubmitYikeVoiceNarratorJobResponse SubmitYikeVoiceNarratorJob(SubmitYikeVoiceNarratorJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitYikeVoiceNarratorJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交一刻口播视频生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitYikeVoiceNarratorJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitYikeVoiceNarratorJobResponse
        /// </returns>
        public async Task<SubmitYikeVoiceNarratorJobResponse> SubmitYikeVoiceNarratorJobAsync(SubmitYikeVoiceNarratorJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitYikeVoiceNarratorJobWithOptionsAsync(request, runtime);
        }

    }
}
