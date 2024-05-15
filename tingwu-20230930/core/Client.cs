// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Tingwu20230930.Models;

namespace AlibabaCloud.SDK.Tingwu20230930
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

        /**
         * @summary 创建听悟任务
         *
         * @param request CreateTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTaskResponse
         */
        public CreateTaskResponse CreateTaskWithOptions(CreateTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                query["operation"] = request.Operation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["Parameters"] = request.Parameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTask",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/tingwu/v2/tasks",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建听悟任务
         *
         * @param request CreateTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTaskResponse
         */
        public async Task<CreateTaskResponse> CreateTaskWithOptionsAsync(CreateTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                query["operation"] = request.Operation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["Parameters"] = request.Parameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTask",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/tingwu/v2/tasks",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建听悟任务
         *
         * @param request CreateTaskRequest
         * @return CreateTaskResponse
         */
        public CreateTaskResponse CreateTask(CreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建听悟任务
         *
         * @param request CreateTaskRequest
         * @return CreateTaskResponse
         */
        public async Task<CreateTaskResponse> CreateTaskAsync(CreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建热词词表
         *
         * @param request CreateTranscriptionPhrasesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTranscriptionPhrasesResponse
         */
        public CreateTranscriptionPhrasesResponse CreateTranscriptionPhrasesWithOptions(CreateTranscriptionPhrasesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordWeights))
            {
                body["WordWeights"] = request.WordWeights;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTranscriptionPhrases",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/tingwu/v2/resources/phrases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTranscriptionPhrasesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建热词词表
         *
         * @param request CreateTranscriptionPhrasesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTranscriptionPhrasesResponse
         */
        public async Task<CreateTranscriptionPhrasesResponse> CreateTranscriptionPhrasesWithOptionsAsync(CreateTranscriptionPhrasesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordWeights))
            {
                body["WordWeights"] = request.WordWeights;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTranscriptionPhrases",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/tingwu/v2/resources/phrases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTranscriptionPhrasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建热词词表
         *
         * @param request CreateTranscriptionPhrasesRequest
         * @return CreateTranscriptionPhrasesResponse
         */
        public CreateTranscriptionPhrasesResponse CreateTranscriptionPhrases(CreateTranscriptionPhrasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTranscriptionPhrasesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建热词词表
         *
         * @param request CreateTranscriptionPhrasesRequest
         * @return CreateTranscriptionPhrasesResponse
         */
        public async Task<CreateTranscriptionPhrasesResponse> CreateTranscriptionPhrasesAsync(CreateTranscriptionPhrasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTranscriptionPhrasesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除词表
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTranscriptionPhrasesResponse
         */
        public DeleteTranscriptionPhrasesResponse DeleteTranscriptionPhrasesWithOptions(string PhraseId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTranscriptionPhrases",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/tingwu/v2/resources/phrases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PhraseId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTranscriptionPhrasesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除词表
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTranscriptionPhrasesResponse
         */
        public async Task<DeleteTranscriptionPhrasesResponse> DeleteTranscriptionPhrasesWithOptionsAsync(string PhraseId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTranscriptionPhrases",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/tingwu/v2/resources/phrases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PhraseId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTranscriptionPhrasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除词表
         *
         * @return DeleteTranscriptionPhrasesResponse
         */
        public DeleteTranscriptionPhrasesResponse DeleteTranscriptionPhrases(string PhraseId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTranscriptionPhrasesWithOptions(PhraseId, headers, runtime);
        }

        /**
         * @summary 删除词表
         *
         * @return DeleteTranscriptionPhrasesResponse
         */
        public async Task<DeleteTranscriptionPhrasesResponse> DeleteTranscriptionPhrasesAsync(string PhraseId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTranscriptionPhrasesWithOptionsAsync(PhraseId, headers, runtime);
        }

        /**
         * @summary 查询听悟任务信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskInfoResponse
         */
        public GetTaskInfoResponse GetTaskInfoWithOptions(string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskInfo",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/tingwu/v2/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询听悟任务信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskInfoResponse
         */
        public async Task<GetTaskInfoResponse> GetTaskInfoWithOptionsAsync(string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskInfo",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/tingwu/v2/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询听悟任务信息
         *
         * @return GetTaskInfoResponse
         */
        public GetTaskInfoResponse GetTaskInfo(string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskInfoWithOptions(TaskId, headers, runtime);
        }

        /**
         * @summary 查询听悟任务信息
         *
         * @return GetTaskInfoResponse
         */
        public async Task<GetTaskInfoResponse> GetTaskInfoAsync(string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskInfoWithOptionsAsync(TaskId, headers, runtime);
        }

        /**
         * @summary 查询热词词表信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTranscriptionPhrasesResponse
         */
        public GetTranscriptionPhrasesResponse GetTranscriptionPhrasesWithOptions(string PhraseId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTranscriptionPhrases",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/tingwu/v2/resources/phrases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PhraseId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTranscriptionPhrasesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询热词词表信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTranscriptionPhrasesResponse
         */
        public async Task<GetTranscriptionPhrasesResponse> GetTranscriptionPhrasesWithOptionsAsync(string PhraseId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTranscriptionPhrases",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/tingwu/v2/resources/phrases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PhraseId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTranscriptionPhrasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询热词词表信息
         *
         * @return GetTranscriptionPhrasesResponse
         */
        public GetTranscriptionPhrasesResponse GetTranscriptionPhrases(string PhraseId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTranscriptionPhrasesWithOptions(PhraseId, headers, runtime);
        }

        /**
         * @summary 查询热词词表信息
         *
         * @return GetTranscriptionPhrasesResponse
         */
        public async Task<GetTranscriptionPhrasesResponse> GetTranscriptionPhrasesAsync(string PhraseId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTranscriptionPhrasesWithOptionsAsync(PhraseId, headers, runtime);
        }

        /**
         * @summary 列举用户所有热词词表信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTranscriptionPhrasesResponse
         */
        public ListTranscriptionPhrasesResponse ListTranscriptionPhrasesWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTranscriptionPhrases",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/tingwu/v2/resources/phrases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTranscriptionPhrasesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列举用户所有热词词表信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTranscriptionPhrasesResponse
         */
        public async Task<ListTranscriptionPhrasesResponse> ListTranscriptionPhrasesWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTranscriptionPhrases",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/tingwu/v2/resources/phrases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTranscriptionPhrasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列举用户所有热词词表信息
         *
         * @return ListTranscriptionPhrasesResponse
         */
        public ListTranscriptionPhrasesResponse ListTranscriptionPhrases()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTranscriptionPhrasesWithOptions(headers, runtime);
        }

        /**
         * @summary 列举用户所有热词词表信息
         *
         * @return ListTranscriptionPhrasesResponse
         */
        public async Task<ListTranscriptionPhrasesResponse> ListTranscriptionPhrasesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTranscriptionPhrasesWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 更新热词词表
         *
         * @param request UpdateTranscriptionPhrasesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTranscriptionPhrasesResponse
         */
        public UpdateTranscriptionPhrasesResponse UpdateTranscriptionPhrasesWithOptions(string PhraseId, UpdateTranscriptionPhrasesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordWeights))
            {
                body["WordWeights"] = request.WordWeights;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTranscriptionPhrases",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/tingwu/v2/resources/phrases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PhraseId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTranscriptionPhrasesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新热词词表
         *
         * @param request UpdateTranscriptionPhrasesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTranscriptionPhrasesResponse
         */
        public async Task<UpdateTranscriptionPhrasesResponse> UpdateTranscriptionPhrasesWithOptionsAsync(string PhraseId, UpdateTranscriptionPhrasesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordWeights))
            {
                body["WordWeights"] = request.WordWeights;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTranscriptionPhrases",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/openapi/tingwu/v2/resources/phrases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PhraseId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTranscriptionPhrasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新热词词表
         *
         * @param request UpdateTranscriptionPhrasesRequest
         * @return UpdateTranscriptionPhrasesResponse
         */
        public UpdateTranscriptionPhrasesResponse UpdateTranscriptionPhrases(string PhraseId, UpdateTranscriptionPhrasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTranscriptionPhrasesWithOptions(PhraseId, request, headers, runtime);
        }

        /**
         * @summary 更新热词词表
         *
         * @param request UpdateTranscriptionPhrasesRequest
         * @return UpdateTranscriptionPhrasesResponse
         */
        public async Task<UpdateTranscriptionPhrasesResponse> UpdateTranscriptionPhrasesAsync(string PhraseId, UpdateTranscriptionPhrasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTranscriptionPhrasesWithOptionsAsync(PhraseId, request, headers, runtime);
        }

    }
}
