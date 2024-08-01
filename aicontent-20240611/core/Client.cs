// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AiContent20240611.Models;

namespace AlibabaCloud.SDK.AiContent20240611
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("aicontent", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /**
         * @summary 阿里云控制台/列出阿里云控制台上可使用的服务列表
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse
         */
        public AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse AliyunConsoleOpenApiQueryAliyunConsoleServcieListWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AliyunConsoleOpenApiQueryAliyunConsoleServcieList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunconsole/queryAliyunConsoleServcieList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 阿里云控制台/列出阿里云控制台上可使用的服务列表
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse
         */
        public async Task<AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse> AliyunConsoleOpenApiQueryAliyunConsoleServcieListWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AliyunConsoleOpenApiQueryAliyunConsoleServcieList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunconsole/queryAliyunConsoleServcieList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 阿里云控制台/列出阿里云控制台上可使用的服务列表
         *
         * @return AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse
         */
        public AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse AliyunConsoleOpenApiQueryAliyunConsoleServcieList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AliyunConsoleOpenApiQueryAliyunConsoleServcieListWithOptions(headers, runtime);
        }

        /**
         * @summary 阿里云控制台/列出阿里云控制台上可使用的服务列表
         *
         * @return AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse
         */
        public async Task<AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse> AliyunConsoleOpenApiQueryAliyunConsoleServcieListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AliyunConsoleOpenApiQueryAliyunConsoleServcieListWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 个性化文生图/基于一个模型创建图片推理任务
         *
         * @param request Personalizedtxt2imgAddInferenceJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return Personalizedtxt2imgAddInferenceJobResponse
         */
        public Personalizedtxt2imgAddInferenceJobResponse Personalizedtxt2imgAddInferenceJobWithOptions(Personalizedtxt2imgAddInferenceJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNumber))
            {
                body["imageNumber"] = request.ImageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Seed))
            {
                body["seed"] = request.Seed;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgAddInferenceJob",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/addInferenceJob",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<Personalizedtxt2imgAddInferenceJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 个性化文生图/基于一个模型创建图片推理任务
         *
         * @param request Personalizedtxt2imgAddInferenceJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return Personalizedtxt2imgAddInferenceJobResponse
         */
        public async Task<Personalizedtxt2imgAddInferenceJobResponse> Personalizedtxt2imgAddInferenceJobWithOptionsAsync(Personalizedtxt2imgAddInferenceJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNumber))
            {
                body["imageNumber"] = request.ImageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Seed))
            {
                body["seed"] = request.Seed;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgAddInferenceJob",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/addInferenceJob",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<Personalizedtxt2imgAddInferenceJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 个性化文生图/基于一个模型创建图片推理任务
         *
         * @param request Personalizedtxt2imgAddInferenceJobRequest
         * @return Personalizedtxt2imgAddInferenceJobResponse
         */
        public Personalizedtxt2imgAddInferenceJobResponse Personalizedtxt2imgAddInferenceJob(Personalizedtxt2imgAddInferenceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return Personalizedtxt2imgAddInferenceJobWithOptions(request, headers, runtime);
        }

        /**
         * @summary 个性化文生图/基于一个模型创建图片推理任务
         *
         * @param request Personalizedtxt2imgAddInferenceJobRequest
         * @return Personalizedtxt2imgAddInferenceJobResponse
         */
        public async Task<Personalizedtxt2imgAddInferenceJobResponse> Personalizedtxt2imgAddInferenceJobAsync(Personalizedtxt2imgAddInferenceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await Personalizedtxt2imgAddInferenceJobWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 个性化文生图/创建一个模型训练任务
         *
         * @param request Personalizedtxt2imgAddModelTrainJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return Personalizedtxt2imgAddModelTrainJobResponse
         */
        public Personalizedtxt2imgAddModelTrainJobResponse Personalizedtxt2imgAddModelTrainJobWithOptions(Personalizedtxt2imgAddModelTrainJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["imageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["objectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainSteps))
            {
                body["trainSteps"] = request.TrainSteps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgAddModelTrainJob",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/addModelTrainJob",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<Personalizedtxt2imgAddModelTrainJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 个性化文生图/创建一个模型训练任务
         *
         * @param request Personalizedtxt2imgAddModelTrainJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return Personalizedtxt2imgAddModelTrainJobResponse
         */
        public async Task<Personalizedtxt2imgAddModelTrainJobResponse> Personalizedtxt2imgAddModelTrainJobWithOptionsAsync(Personalizedtxt2imgAddModelTrainJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["imageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["objectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainSteps))
            {
                body["trainSteps"] = request.TrainSteps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgAddModelTrainJob",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/addModelTrainJob",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<Personalizedtxt2imgAddModelTrainJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 个性化文生图/创建一个模型训练任务
         *
         * @param request Personalizedtxt2imgAddModelTrainJobRequest
         * @return Personalizedtxt2imgAddModelTrainJobResponse
         */
        public Personalizedtxt2imgAddModelTrainJobResponse Personalizedtxt2imgAddModelTrainJob(Personalizedtxt2imgAddModelTrainJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return Personalizedtxt2imgAddModelTrainJobWithOptions(request, headers, runtime);
        }

        /**
         * @summary 个性化文生图/创建一个模型训练任务
         *
         * @param request Personalizedtxt2imgAddModelTrainJobRequest
         * @return Personalizedtxt2imgAddModelTrainJobResponse
         */
        public async Task<Personalizedtxt2imgAddModelTrainJobResponse> Personalizedtxt2imgAddModelTrainJobAsync(Personalizedtxt2imgAddModelTrainJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await Personalizedtxt2imgAddModelTrainJobWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 个性化文生图/图片二进制内容获取
         *
         * @param request Personalizedtxt2imgQueryImageAssetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return Personalizedtxt2imgQueryImageAssetResponse
         */
        public Personalizedtxt2imgQueryImageAssetResponse Personalizedtxt2imgQueryImageAssetWithOptions(Personalizedtxt2imgQueryImageAssetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeFormat))
            {
                query["encodeFormat"] = request.EncodeFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["imageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptId))
            {
                query["promptId"] = request.PromptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgQueryImageAsset",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/queryImageAsset",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "any",
            };
            return TeaModel.ToObject<Personalizedtxt2imgQueryImageAssetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 个性化文生图/图片二进制内容获取
         *
         * @param request Personalizedtxt2imgQueryImageAssetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return Personalizedtxt2imgQueryImageAssetResponse
         */
        public async Task<Personalizedtxt2imgQueryImageAssetResponse> Personalizedtxt2imgQueryImageAssetWithOptionsAsync(Personalizedtxt2imgQueryImageAssetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeFormat))
            {
                query["encodeFormat"] = request.EncodeFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["imageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptId))
            {
                query["promptId"] = request.PromptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgQueryImageAsset",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/queryImageAsset",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "any",
            };
            return TeaModel.ToObject<Personalizedtxt2imgQueryImageAssetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 个性化文生图/图片二进制内容获取
         *
         * @param request Personalizedtxt2imgQueryImageAssetRequest
         * @return Personalizedtxt2imgQueryImageAssetResponse
         */
        public Personalizedtxt2imgQueryImageAssetResponse Personalizedtxt2imgQueryImageAsset(Personalizedtxt2imgQueryImageAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return Personalizedtxt2imgQueryImageAssetWithOptions(request, headers, runtime);
        }

        /**
         * @summary 个性化文生图/图片二进制内容获取
         *
         * @param request Personalizedtxt2imgQueryImageAssetRequest
         * @return Personalizedtxt2imgQueryImageAssetResponse
         */
        public async Task<Personalizedtxt2imgQueryImageAssetResponse> Personalizedtxt2imgQueryImageAssetAsync(Personalizedtxt2imgQueryImageAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await Personalizedtxt2imgQueryImageAssetWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 个性化文生图/查询模型推理任务的状态和结果信息
         *
         * @param request Personalizedtxt2imgQueryInferenceJobInfoRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return Personalizedtxt2imgQueryInferenceJobInfoResponse
         */
        public Personalizedtxt2imgQueryInferenceJobInfoResponse Personalizedtxt2imgQueryInferenceJobInfoWithOptions(Personalizedtxt2imgQueryInferenceJobInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InferenceJobId))
            {
                query["inferenceJobId"] = request.InferenceJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgQueryInferenceJobInfo",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/queryInferenceJobInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<Personalizedtxt2imgQueryInferenceJobInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 个性化文生图/查询模型推理任务的状态和结果信息
         *
         * @param request Personalizedtxt2imgQueryInferenceJobInfoRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return Personalizedtxt2imgQueryInferenceJobInfoResponse
         */
        public async Task<Personalizedtxt2imgQueryInferenceJobInfoResponse> Personalizedtxt2imgQueryInferenceJobInfoWithOptionsAsync(Personalizedtxt2imgQueryInferenceJobInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InferenceJobId))
            {
                query["inferenceJobId"] = request.InferenceJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgQueryInferenceJobInfo",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/queryInferenceJobInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<Personalizedtxt2imgQueryInferenceJobInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 个性化文生图/查询模型推理任务的状态和结果信息
         *
         * @param request Personalizedtxt2imgQueryInferenceJobInfoRequest
         * @return Personalizedtxt2imgQueryInferenceJobInfoResponse
         */
        public Personalizedtxt2imgQueryInferenceJobInfoResponse Personalizedtxt2imgQueryInferenceJobInfo(Personalizedtxt2imgQueryInferenceJobInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return Personalizedtxt2imgQueryInferenceJobInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 个性化文生图/查询模型推理任务的状态和结果信息
         *
         * @param request Personalizedtxt2imgQueryInferenceJobInfoRequest
         * @return Personalizedtxt2imgQueryInferenceJobInfoResponse
         */
        public async Task<Personalizedtxt2imgQueryInferenceJobInfoResponse> Personalizedtxt2imgQueryInferenceJobInfoAsync(Personalizedtxt2imgQueryInferenceJobInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await Personalizedtxt2imgQueryInferenceJobInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 个性化文生图/查询模型训练任务列表
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return Personalizedtxt2imgQueryModelTrainJobListResponse
         */
        public Personalizedtxt2imgQueryModelTrainJobListResponse Personalizedtxt2imgQueryModelTrainJobListWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgQueryModelTrainJobList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/queryModelTrainJobList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<Personalizedtxt2imgQueryModelTrainJobListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 个性化文生图/查询模型训练任务列表
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return Personalizedtxt2imgQueryModelTrainJobListResponse
         */
        public async Task<Personalizedtxt2imgQueryModelTrainJobListResponse> Personalizedtxt2imgQueryModelTrainJobListWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgQueryModelTrainJobList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/queryModelTrainJobList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<Personalizedtxt2imgQueryModelTrainJobListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 个性化文生图/查询模型训练任务列表
         *
         * @return Personalizedtxt2imgQueryModelTrainJobListResponse
         */
        public Personalizedtxt2imgQueryModelTrainJobListResponse Personalizedtxt2imgQueryModelTrainJobList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return Personalizedtxt2imgQueryModelTrainJobListWithOptions(headers, runtime);
        }

        /**
         * @summary 个性化文生图/查询模型训练任务列表
         *
         * @return Personalizedtxt2imgQueryModelTrainJobListResponse
         */
        public async Task<Personalizedtxt2imgQueryModelTrainJobListResponse> Personalizedtxt2imgQueryModelTrainJobListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await Personalizedtxt2imgQueryModelTrainJobListWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 个性化文生图/模型训练状态查询
         *
         * @param request Personalizedtxt2imgQueryModelTrainStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return Personalizedtxt2imgQueryModelTrainStatusResponse
         */
        public Personalizedtxt2imgQueryModelTrainStatusResponse Personalizedtxt2imgQueryModelTrainStatusWithOptions(Personalizedtxt2imgQueryModelTrainStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgQueryModelTrainStatus",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/queryModelTrainStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<Personalizedtxt2imgQueryModelTrainStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 个性化文生图/模型训练状态查询
         *
         * @param request Personalizedtxt2imgQueryModelTrainStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return Personalizedtxt2imgQueryModelTrainStatusResponse
         */
        public async Task<Personalizedtxt2imgQueryModelTrainStatusResponse> Personalizedtxt2imgQueryModelTrainStatusWithOptionsAsync(Personalizedtxt2imgQueryModelTrainStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgQueryModelTrainStatus",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/queryModelTrainStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<Personalizedtxt2imgQueryModelTrainStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 个性化文生图/模型训练状态查询
         *
         * @param request Personalizedtxt2imgQueryModelTrainStatusRequest
         * @return Personalizedtxt2imgQueryModelTrainStatusResponse
         */
        public Personalizedtxt2imgQueryModelTrainStatusResponse Personalizedtxt2imgQueryModelTrainStatus(Personalizedtxt2imgQueryModelTrainStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return Personalizedtxt2imgQueryModelTrainStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 个性化文生图/模型训练状态查询
         *
         * @param request Personalizedtxt2imgQueryModelTrainStatusRequest
         * @return Personalizedtxt2imgQueryModelTrainStatusResponse
         */
        public async Task<Personalizedtxt2imgQueryModelTrainStatusResponse> Personalizedtxt2imgQueryModelTrainStatusAsync(Personalizedtxt2imgQueryModelTrainStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await Personalizedtxt2imgQueryModelTrainStatusWithOptionsAsync(request, headers, runtime);
        }

    }
}
