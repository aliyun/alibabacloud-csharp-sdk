// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.IntelligentCreation20240313.Models;

namespace AlibabaCloud.SDK.IntelligentCreation20240313
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("intelligentcreation", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 创建配图生成任务
         *
         * @param request CreateIllustrationTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIllustrationTaskResponse
         */
        public CreateIllustrationTaskResponse CreateIllustrationTaskWithOptions(string textId, CreateIllustrationTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIllustrationTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textId) + "/illustrationTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIllustrationTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建配图生成任务
         *
         * @param request CreateIllustrationTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIllustrationTaskResponse
         */
        public async Task<CreateIllustrationTaskResponse> CreateIllustrationTaskWithOptionsAsync(string textId, CreateIllustrationTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIllustrationTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textId) + "/illustrationTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIllustrationTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建配图生成任务
         *
         * @param request CreateIllustrationTaskRequest
         * @return CreateIllustrationTaskResponse
         */
        public CreateIllustrationTaskResponse CreateIllustrationTask(string textId, CreateIllustrationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIllustrationTaskWithOptions(textId, request, headers, runtime);
        }

        /**
         * @summary 创建配图生成任务
         *
         * @param request CreateIllustrationTaskRequest
         * @return CreateIllustrationTaskResponse
         */
        public async Task<CreateIllustrationTaskResponse> CreateIllustrationTaskAsync(string textId, CreateIllustrationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIllustrationTaskWithOptionsAsync(textId, request, headers, runtime);
        }

        /**
         * @summary 创建文案生成任务
         *
         * @param request CreateTextTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTextTaskResponse
         */
        public CreateTextTaskResponse CreateTextTaskWithOptions(CreateTextTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTextTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/textTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTextTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建文案生成任务
         *
         * @param request CreateTextTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTextTaskResponse
         */
        public async Task<CreateTextTaskResponse> CreateTextTaskWithOptionsAsync(CreateTextTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTextTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/textTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTextTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建文案生成任务
         *
         * @param request CreateTextTaskRequest
         * @return CreateTextTaskResponse
         */
        public CreateTextTaskResponse CreateTextTask(CreateTextTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTextTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建文案生成任务
         *
         * @param request CreateTextTaskRequest
         * @return CreateTextTaskResponse
         */
        public async Task<CreateTextTaskResponse> CreateTextTaskAsync(CreateTextTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTextTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询配图
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIllustrationResponse
         */
        public GetIllustrationResponse GetIllustrationWithOptions(string textId, string illustrationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIllustration",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textId) + "/illustrations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(illustrationId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIllustrationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询配图
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIllustrationResponse
         */
        public async Task<GetIllustrationResponse> GetIllustrationWithOptionsAsync(string textId, string illustrationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIllustration",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textId) + "/illustrations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(illustrationId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIllustrationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询配图
         *
         * @return GetIllustrationResponse
         */
        public GetIllustrationResponse GetIllustration(string textId, string illustrationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIllustrationWithOptions(textId, illustrationId, headers, runtime);
        }

        /**
         * @summary 查询配图
         *
         * @return GetIllustrationResponse
         */
        public async Task<GetIllustrationResponse> GetIllustrationAsync(string textId, string illustrationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIllustrationWithOptionsAsync(textId, illustrationId, headers, runtime);
        }

        /**
         * @summary 查询配图任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIllustrationTaskResponse
         */
        public GetIllustrationTaskResponse GetIllustrationTaskWithOptions(string textId, string illustrationTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIllustrationTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textId) + "/illustrationTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(illustrationTaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIllustrationTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询配图任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIllustrationTaskResponse
         */
        public async Task<GetIllustrationTaskResponse> GetIllustrationTaskWithOptionsAsync(string textId, string illustrationTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIllustrationTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textId) + "/illustrationTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(illustrationTaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIllustrationTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询配图任务
         *
         * @return GetIllustrationTaskResponse
         */
        public GetIllustrationTaskResponse GetIllustrationTask(string textId, string illustrationTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIllustrationTaskWithOptions(textId, illustrationTaskId, headers, runtime);
        }

        /**
         * @summary 查询配图任务
         *
         * @return GetIllustrationTaskResponse
         */
        public async Task<GetIllustrationTaskResponse> GetIllustrationTaskAsync(string textId, string illustrationTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIllustrationTaskWithOptionsAsync(textId, illustrationTaskId, headers, runtime);
        }

        /**
         * @summary 获取图片上传oss token
         *
         * @param request GetOssUploadTokenRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOssUploadTokenResponse
         */
        public GetOssUploadTokenResponse GetOssUploadTokenWithOptions(GetOssUploadTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["fileType"] = request.FileType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOssUploadToken",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/uploadToken",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOssUploadTokenResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取图片上传oss token
         *
         * @param request GetOssUploadTokenRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOssUploadTokenResponse
         */
        public async Task<GetOssUploadTokenResponse> GetOssUploadTokenWithOptionsAsync(GetOssUploadTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["fileType"] = request.FileType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOssUploadToken",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/uploadToken",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOssUploadTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取图片上传oss token
         *
         * @param request GetOssUploadTokenRequest
         * @return GetOssUploadTokenResponse
         */
        public GetOssUploadTokenResponse GetOssUploadToken(GetOssUploadTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOssUploadTokenWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取图片上传oss token
         *
         * @param request GetOssUploadTokenRequest
         * @return GetOssUploadTokenResponse
         */
        public async Task<GetOssUploadTokenResponse> GetOssUploadTokenAsync(GetOssUploadTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOssUploadTokenWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询文案
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTextResponse
         */
        public GetTextResponse GetTextWithOptions(string textId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetText",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTextResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询文案
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTextResponse
         */
        public async Task<GetTextResponse> GetTextWithOptionsAsync(string textId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetText",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询文案
         *
         * @return GetTextResponse
         */
        public GetTextResponse GetText(string textId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTextWithOptions(textId, headers, runtime);
        }

        /**
         * @summary 查询文案
         *
         * @return GetTextResponse
         */
        public async Task<GetTextResponse> GetTextAsync(string textId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTextWithOptionsAsync(textId, headers, runtime);
        }

        /**
         * @summary 查询文案任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTextTaskResponse
         */
        public GetTextTaskResponse GetTextTaskWithOptions(string textTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTextTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/textTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textTaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTextTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询文案任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTextTaskResponse
         */
        public async Task<GetTextTaskResponse> GetTextTaskWithOptionsAsync(string textTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTextTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/textTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textTaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTextTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询文案任务
         *
         * @return GetTextTaskResponse
         */
        public GetTextTaskResponse GetTextTask(string textTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTextTaskWithOptions(textTaskId, headers, runtime);
        }

        /**
         * @summary 查询文案任务
         *
         * @return GetTextTaskResponse
         */
        public async Task<GetTextTaskResponse> GetTextTaskAsync(string textTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTextTaskWithOptionsAsync(textTaskId, headers, runtime);
        }

        /**
         * @summary 查询文案主题列表
         *
         * @param request ListTextThemesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTextThemesResponse
         */
        public ListTextThemesResponse ListTextThemesWithOptions(ListTextThemesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["industry"] = request.Industry;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTextThemes",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/textThemes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTextThemesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询文案主题列表
         *
         * @param request ListTextThemesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTextThemesResponse
         */
        public async Task<ListTextThemesResponse> ListTextThemesWithOptionsAsync(ListTextThemesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["industry"] = request.Industry;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTextThemes",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/textThemes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTextThemesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询文案主题列表
         *
         * @param request ListTextThemesRequest
         * @return ListTextThemesResponse
         */
        public ListTextThemesResponse ListTextThemes(ListTextThemesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTextThemesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询文案主题列表
         *
         * @param request ListTextThemesRequest
         * @return ListTextThemesResponse
         */
        public async Task<ListTextThemesResponse> ListTextThemesAsync(ListTextThemesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTextThemesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 列举文案
         *
         * @param request ListTextsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTextsResponse
         */
        public ListTextsResponse ListTextsWithOptions(ListTextsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerationSource))
            {
                query["generationSource"] = request.GenerationSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishStatus))
            {
                query["publishStatus"] = request.PublishStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextStyleType))
            {
                query["textStyleType"] = request.TextStyleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextTheme))
            {
                query["textTheme"] = request.TextTheme;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTexts",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTextsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列举文案
         *
         * @param request ListTextsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTextsResponse
         */
        public async Task<ListTextsResponse> ListTextsWithOptionsAsync(ListTextsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerationSource))
            {
                query["generationSource"] = request.GenerationSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishStatus))
            {
                query["publishStatus"] = request.PublishStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextStyleType))
            {
                query["textStyleType"] = request.TextStyleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextTheme))
            {
                query["textTheme"] = request.TextTheme;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTexts",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTextsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列举文案
         *
         * @param request ListTextsRequest
         * @return ListTextsResponse
         */
        public ListTextsResponse ListTexts(ListTextsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTextsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 列举文案
         *
         * @param request ListTextsRequest
         * @return ListTextsResponse
         */
        public async Task<ListTextsResponse> ListTextsAsync(ListTextsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTextsWithOptionsAsync(request, headers, runtime);
        }

    }
}
