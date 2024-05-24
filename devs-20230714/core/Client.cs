// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Devs20230714.Models;

namespace AlibabaCloud.SDK.Devs20230714
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("devs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 激活身份绑定,完成OAuth授权
         *
         * @param request ActivateConnectionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ActivateConnectionResponse
         */
        public ActivateConnectionResponse ActivateConnectionWithOptions(string name, ActivateConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credential))
            {
                body["credential"] = request.Credential;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateConnection",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/activate",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateConnectionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 激活身份绑定,完成OAuth授权
         *
         * @param request ActivateConnectionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ActivateConnectionResponse
         */
        public async Task<ActivateConnectionResponse> ActivateConnectionWithOptionsAsync(string name, ActivateConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credential))
            {
                body["credential"] = request.Credential;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateConnection",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/activate",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 激活身份绑定,完成OAuth授权
         *
         * @param request ActivateConnectionRequest
         * @return ActivateConnectionResponse
         */
        public ActivateConnectionResponse ActivateConnection(string name, ActivateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ActivateConnectionWithOptions(name, request, headers, runtime);
        }

        /**
         * @summary 激活身份绑定,完成OAuth授权
         *
         * @param request ActivateConnectionRequest
         * @return ActivateConnectionResponse
         */
        public async Task<ActivateConnectionResponse> ActivateConnectionAsync(string name, ActivateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ActivateConnectionWithOptionsAsync(name, request, headers, runtime);
        }

        /**
         * @summary 取消流水线
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelPipelineResponse
         */
        public CancelPipelineResponse CancelPipelineWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelPipeline",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/cancel",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelPipelineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 取消流水线
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelPipelineResponse
         */
        public async Task<CancelPipelineResponse> CancelPipelineWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelPipeline",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/cancel",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelPipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 取消流水线
         *
         * @return CancelPipelineResponse
         */
        public CancelPipelineResponse CancelPipeline(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelPipelineWithOptions(name, headers, runtime);
        }

        /**
         * @summary 取消流水线
         *
         * @return CancelPipelineResponse
         */
        public async Task<CancelPipelineResponse> CancelPipelineAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelPipelineWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 取消任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelTaskResponse
         */
        public CancelTaskResponse CancelTaskWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/cancel",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 取消任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelTaskResponse
         */
        public async Task<CancelTaskResponse> CancelTaskWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/cancel",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 取消任务
         *
         * @return CancelTaskResponse
         */
        public CancelTaskResponse CancelTask(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelTaskWithOptions(name, headers, runtime);
        }

        /**
         * @summary 取消任务
         *
         * @return CancelTaskResponse
         */
        public async Task<CancelTaskResponse> CancelTaskAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelTaskWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 创建身份绑定
         *
         * @param request CreateConnectionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConnectionResponse
         */
        public CreateConnectionResponse CreateConnectionWithOptions(CreateConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConnection",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConnectionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建身份绑定
         *
         * @param request CreateConnectionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConnectionResponse
         */
        public async Task<CreateConnectionResponse> CreateConnectionWithOptionsAsync(CreateConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConnection",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建身份绑定
         *
         * @param request CreateConnectionRequest
         * @return CreateConnectionResponse
         */
        public CreateConnectionResponse CreateConnection(CreateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConnectionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建身份绑定
         *
         * @param request CreateConnectionRequest
         * @return CreateConnectionResponse
         */
        public async Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConnectionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建环境
         *
         * @param request CreateEnvironmentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEnvironmentResponse
         */
        public CreateEnvironmentResponse CreateEnvironmentWithOptions(string project, CreateEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(project) + "/environments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEnvironmentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建环境
         *
         * @param request CreateEnvironmentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEnvironmentResponse
         */
        public async Task<CreateEnvironmentResponse> CreateEnvironmentWithOptionsAsync(string project, CreateEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(project) + "/environments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建环境
         *
         * @param request CreateEnvironmentRequest
         * @return CreateEnvironmentResponse
         */
        public CreateEnvironmentResponse CreateEnvironment(string project, CreateEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateEnvironmentWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary 创建环境
         *
         * @param request CreateEnvironmentRequest
         * @return CreateEnvironmentResponse
         */
        public async Task<CreateEnvironmentResponse> CreateEnvironmentAsync(string project, CreateEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateEnvironmentWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary 创建流水线
         *
         * @param request CreatePipelineRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePipelineResponse
         */
        public CreatePipelineResponse CreatePipelineWithOptions(CreatePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePipeline",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePipelineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建流水线
         *
         * @param request CreatePipelineRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePipelineResponse
         */
        public async Task<CreatePipelineResponse> CreatePipelineWithOptionsAsync(CreatePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePipeline",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建流水线
         *
         * @param request CreatePipelineRequest
         * @return CreatePipelineResponse
         */
        public CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePipelineWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建流水线
         *
         * @param request CreatePipelineRequest
         * @return CreatePipelineResponse
         */
        public async Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePipelineWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建流水线模板
         *
         * @param request CreatePipelineTemplateRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePipelineTemplateResponse
         */
        public CreatePipelineTemplateResponse CreatePipelineTemplateWithOptions(CreatePipelineTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePipelineTemplate",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetemplates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePipelineTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建流水线模板
         *
         * @param request CreatePipelineTemplateRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePipelineTemplateResponse
         */
        public async Task<CreatePipelineTemplateResponse> CreatePipelineTemplateWithOptionsAsync(CreatePipelineTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePipelineTemplate",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetemplates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePipelineTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建流水线模板
         *
         * @param request CreatePipelineTemplateRequest
         * @return CreatePipelineTemplateResponse
         */
        public CreatePipelineTemplateResponse CreatePipelineTemplate(CreatePipelineTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePipelineTemplateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建流水线模板
         *
         * @param request CreatePipelineTemplateRequest
         * @return CreatePipelineTemplateResponse
         */
        public async Task<CreatePipelineTemplateResponse> CreatePipelineTemplateAsync(CreatePipelineTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePipelineTemplateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建流水线触发器
         *
         * @param request CreatePipelineTriggerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePipelineTriggerResponse
         */
        public CreatePipelineTriggerResponse CreatePipelineTriggerWithOptions(CreatePipelineTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePipelineTrigger",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetriggers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePipelineTriggerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建流水线触发器
         *
         * @param request CreatePipelineTriggerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePipelineTriggerResponse
         */
        public async Task<CreatePipelineTriggerResponse> CreatePipelineTriggerWithOptionsAsync(CreatePipelineTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePipelineTrigger",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetriggers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePipelineTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建流水线触发器
         *
         * @param request CreatePipelineTriggerRequest
         * @return CreatePipelineTriggerResponse
         */
        public CreatePipelineTriggerResponse CreatePipelineTrigger(CreatePipelineTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePipelineTriggerWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建流水线触发器
         *
         * @param request CreatePipelineTriggerRequest
         * @return CreatePipelineTriggerResponse
         */
        public async Task<CreatePipelineTriggerResponse> CreatePipelineTriggerAsync(CreatePipelineTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePipelineTriggerWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建流水线触发历史
         *
         * @param request CreatePipelineTriggerEventRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePipelineTriggerEventResponse
         */
        public CreatePipelineTriggerEventResponse CreatePipelineTriggerEventWithOptions(CreatePipelineTriggerEventRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePipelineTriggerEvent",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetriggerevents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePipelineTriggerEventResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建流水线触发历史
         *
         * @param request CreatePipelineTriggerEventRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePipelineTriggerEventResponse
         */
        public async Task<CreatePipelineTriggerEventResponse> CreatePipelineTriggerEventWithOptionsAsync(CreatePipelineTriggerEventRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePipelineTriggerEvent",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetriggerevents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePipelineTriggerEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建流水线触发历史
         *
         * @param request CreatePipelineTriggerEventRequest
         * @return CreatePipelineTriggerEventResponse
         */
        public CreatePipelineTriggerEventResponse CreatePipelineTriggerEvent(CreatePipelineTriggerEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePipelineTriggerEventWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建流水线触发历史
         *
         * @param request CreatePipelineTriggerEventRequest
         * @return CreatePipelineTriggerEventResponse
         */
        public async Task<CreatePipelineTriggerEventResponse> CreatePipelineTriggerEventAsync(CreatePipelineTriggerEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePipelineTriggerEventWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建项目
         *
         * @param request CreateProjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectResponse
         */
        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建项目
         *
         * @param request CreateProjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectResponse
         */
        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建项目
         *
         * @param request CreateProjectRequest
         * @return CreateProjectResponse
         */
        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProjectWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建项目
         *
         * @param request CreateProjectRequest
         * @return CreateProjectResponse
         */
        public async Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProjectWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建仓库绑定
         *
         * @param request CreateRepositoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRepositoryResponse
         */
        public CreateRepositoryResponse CreateRepositoryWithOptions(CreateRepositoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepository",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/repositories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepositoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建仓库绑定
         *
         * @param request CreateRepositoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRepositoryResponse
         */
        public async Task<CreateRepositoryResponse> CreateRepositoryWithOptionsAsync(CreateRepositoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepository",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/repositories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建仓库绑定
         *
         * @param request CreateRepositoryRequest
         * @return CreateRepositoryResponse
         */
        public CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRepositoryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建仓库绑定
         *
         * @param request CreateRepositoryRequest
         * @return CreateRepositoryResponse
         */
        public async Task<CreateRepositoryResponse> CreateRepositoryAsync(CreateRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRepositoryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建任务
         *
         * @param request CreateTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTaskResponse
         */
        public CreateTaskResponse CreateTaskWithOptions(CreateTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建任务
         *
         * @param request CreateTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTaskResponse
         */
        public async Task<CreateTaskResponse> CreateTaskWithOptionsAsync(CreateTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建任务
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
         * @summary 创建任务
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
         * @summary 创建任务模板
         *
         * @param request CreateTaskTemplateRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTaskTemplateResponse
         */
        public CreateTaskTemplateResponse CreateTaskTemplateWithOptions(CreateTaskTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTaskTemplate",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasktemplates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建任务模板
         *
         * @param request CreateTaskTemplateRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTaskTemplateResponse
         */
        public async Task<CreateTaskTemplateResponse> CreateTaskTemplateWithOptionsAsync(CreateTaskTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTaskTemplate",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasktemplates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建任务模板
         *
         * @param request CreateTaskTemplateRequest
         * @return CreateTaskTemplateResponse
         */
        public CreateTaskTemplateResponse CreateTaskTemplate(CreateTaskTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTaskTemplateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建任务模板
         *
         * @param request CreateTaskTemplateRequest
         * @return CreateTaskTemplateResponse
         */
        public async Task<CreateTaskTemplateResponse> CreateTaskTemplateAsync(CreateTaskTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTaskTemplateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除身份绑定
         *
         * @param request DeleteConnectionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteConnectionResponse
         */
        public DeleteConnectionResponse DeleteConnectionWithOptions(string name, DeleteConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConnection",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConnectionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除身份绑定
         *
         * @param request DeleteConnectionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteConnectionResponse
         */
        public async Task<DeleteConnectionResponse> DeleteConnectionWithOptionsAsync(string name, DeleteConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConnection",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除身份绑定
         *
         * @param request DeleteConnectionRequest
         * @return DeleteConnectionResponse
         */
        public DeleteConnectionResponse DeleteConnection(string name, DeleteConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConnectionWithOptions(name, request, headers, runtime);
        }

        /**
         * @summary 删除身份绑定
         *
         * @param request DeleteConnectionRequest
         * @return DeleteConnectionResponse
         */
        public async Task<DeleteConnectionResponse> DeleteConnectionAsync(string name, DeleteConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConnectionWithOptionsAsync(name, request, headers, runtime);
        }

        /**
         * @summary 删除环境
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEnvironmentResponse
         */
        public DeleteEnvironmentResponse DeleteEnvironmentWithOptions(string project, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(project) + "/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteEnvironmentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除环境
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEnvironmentResponse
         */
        public async Task<DeleteEnvironmentResponse> DeleteEnvironmentWithOptionsAsync(string project, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(project) + "/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除环境
         *
         * @return DeleteEnvironmentResponse
         */
        public DeleteEnvironmentResponse DeleteEnvironment(string project, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEnvironmentWithOptions(project, name, headers, runtime);
        }

        /**
         * @summary 删除环境
         *
         * @return DeleteEnvironmentResponse
         */
        public async Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(string project, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEnvironmentWithOptionsAsync(project, name, headers, runtime);
        }

        /**
         * @summary 删除流水线模板
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePipelineTemplateResponse
         */
        public DeletePipelineTemplateResponse DeletePipelineTemplateWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePipelineTemplate",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetemplates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePipelineTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除流水线模板
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePipelineTemplateResponse
         */
        public async Task<DeletePipelineTemplateResponse> DeletePipelineTemplateWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePipelineTemplate",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetemplates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePipelineTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除流水线模板
         *
         * @return DeletePipelineTemplateResponse
         */
        public DeletePipelineTemplateResponse DeletePipelineTemplate(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePipelineTemplateWithOptions(name, headers, runtime);
        }

        /**
         * @summary 删除流水线模板
         *
         * @return DeletePipelineTemplateResponse
         */
        public async Task<DeletePipelineTemplateResponse> DeletePipelineTemplateAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePipelineTemplateWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 删除流水线触发器
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePipelineTriggerResponse
         */
        public DeletePipelineTriggerResponse DeletePipelineTriggerWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePipelineTrigger",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetriggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePipelineTriggerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除流水线触发器
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePipelineTriggerResponse
         */
        public async Task<DeletePipelineTriggerResponse> DeletePipelineTriggerWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePipelineTrigger",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetriggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePipelineTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除流水线触发器
         *
         * @return DeletePipelineTriggerResponse
         */
        public DeletePipelineTriggerResponse DeletePipelineTrigger(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePipelineTriggerWithOptions(name, headers, runtime);
        }

        /**
         * @summary 删除流水线触发器
         *
         * @return DeletePipelineTriggerResponse
         */
        public async Task<DeletePipelineTriggerResponse> DeletePipelineTriggerAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePipelineTriggerWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 删除流水线触发历史
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePipelineTriggerEventResponse
         */
        public DeletePipelineTriggerEventResponse DeletePipelineTriggerEventWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePipelineTriggerEvent",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetriggerevents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePipelineTriggerEventResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除流水线触发历史
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePipelineTriggerEventResponse
         */
        public async Task<DeletePipelineTriggerEventResponse> DeletePipelineTriggerEventWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePipelineTriggerEvent",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetriggerevents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePipelineTriggerEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除流水线触发历史
         *
         * @return DeletePipelineTriggerEventResponse
         */
        public DeletePipelineTriggerEventResponse DeletePipelineTriggerEvent(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePipelineTriggerEventWithOptions(name, headers, runtime);
        }

        /**
         * @summary 删除流水线触发历史
         *
         * @return DeletePipelineTriggerEventResponse
         */
        public async Task<DeletePipelineTriggerEventResponse> DeletePipelineTriggerEventAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePipelineTriggerEventWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 删除项目
         *
         * @param request DeleteProjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProjectResponse
         */
        public DeleteProjectResponse DeleteProjectWithOptions(string name, DeleteProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProject",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除项目
         *
         * @param request DeleteProjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProjectResponse
         */
        public async Task<DeleteProjectResponse> DeleteProjectWithOptionsAsync(string name, DeleteProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProject",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除项目
         *
         * @param request DeleteProjectRequest
         * @return DeleteProjectResponse
         */
        public DeleteProjectResponse DeleteProject(string name, DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProjectWithOptions(name, request, headers, runtime);
        }

        /**
         * @summary 删除项目
         *
         * @param request DeleteProjectRequest
         * @return DeleteProjectResponse
         */
        public async Task<DeleteProjectResponse> DeleteProjectAsync(string name, DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProjectWithOptionsAsync(name, request, headers, runtime);
        }

        /**
         * @summary 删除仓库绑定
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRepositoryResponse
         */
        public DeleteRepositoryResponse DeleteRepositoryWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepository",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/repositories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除仓库绑定
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRepositoryResponse
         */
        public async Task<DeleteRepositoryResponse> DeleteRepositoryWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepository",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/repositories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除仓库绑定
         *
         * @return DeleteRepositoryResponse
         */
        public DeleteRepositoryResponse DeleteRepository(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRepositoryWithOptions(name, headers, runtime);
        }

        /**
         * @summary 删除仓库绑定
         *
         * @return DeleteRepositoryResponse
         */
        public async Task<DeleteRepositoryResponse> DeleteRepositoryAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRepositoryWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 删除任务模板
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTaskTemplateResponse
         */
        public DeleteTaskTemplateResponse DeleteTaskTemplateWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTaskTemplate",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasktemplates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTaskTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除任务模板
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTaskTemplateResponse
         */
        public async Task<DeleteTaskTemplateResponse> DeleteTaskTemplateWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTaskTemplate",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasktemplates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTaskTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除任务模板
         *
         * @return DeleteTaskTemplateResponse
         */
        public DeleteTaskTemplateResponse DeleteTaskTemplate(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTaskTemplateWithOptions(name, headers, runtime);
        }

        /**
         * @summary 删除任务模板
         *
         * @return DeleteTaskTemplateResponse
         */
        public async Task<DeleteTaskTemplateResponse> DeleteTaskTemplateAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTaskTemplateWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 查询身份绑定中的凭证信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FetchConnectionCredentialResponse
         */
        public FetchConnectionCredentialResponse FetchConnectionCredentialWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchConnectionCredential",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/fetchCredential",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FetchConnectionCredentialResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询身份绑定中的凭证信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FetchConnectionCredentialResponse
         */
        public async Task<FetchConnectionCredentialResponse> FetchConnectionCredentialWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchConnectionCredential",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/fetchCredential",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FetchConnectionCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询身份绑定中的凭证信息
         *
         * @return FetchConnectionCredentialResponse
         */
        public FetchConnectionCredentialResponse FetchConnectionCredential(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FetchConnectionCredentialWithOptions(name, headers, runtime);
        }

        /**
         * @summary 查询身份绑定中的凭证信息
         *
         * @return FetchConnectionCredentialResponse
         */
        public async Task<FetchConnectionCredentialResponse> FetchConnectionCredentialAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FetchConnectionCredentialWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 查询仓库代码拉取所需信息
         *
         * @param request FetchRepositoryCheckoutRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FetchRepositoryCheckoutResponse
         */
        public FetchRepositoryCheckoutResponse FetchRepositoryCheckoutWithOptions(string name, FetchRepositoryCheckoutRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Branch))
            {
                query["branch"] = request.Branch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Commit))
            {
                query["commit"] = request.Commit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchRepositoryCheckout",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/repositories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/fetchCheckout",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FetchRepositoryCheckoutResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询仓库代码拉取所需信息
         *
         * @param request FetchRepositoryCheckoutRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FetchRepositoryCheckoutResponse
         */
        public async Task<FetchRepositoryCheckoutResponse> FetchRepositoryCheckoutWithOptionsAsync(string name, FetchRepositoryCheckoutRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Branch))
            {
                query["branch"] = request.Branch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Commit))
            {
                query["commit"] = request.Commit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchRepositoryCheckout",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/repositories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/fetchCheckout",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FetchRepositoryCheckoutResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询仓库代码拉取所需信息
         *
         * @param request FetchRepositoryCheckoutRequest
         * @return FetchRepositoryCheckoutResponse
         */
        public FetchRepositoryCheckoutResponse FetchRepositoryCheckout(string name, FetchRepositoryCheckoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FetchRepositoryCheckoutWithOptions(name, request, headers, runtime);
        }

        /**
         * @summary 查询仓库代码拉取所需信息
         *
         * @param request FetchRepositoryCheckoutRequest
         * @return FetchRepositoryCheckoutResponse
         */
        public async Task<FetchRepositoryCheckoutResponse> FetchRepositoryCheckoutAsync(string name, FetchRepositoryCheckoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FetchRepositoryCheckoutWithOptionsAsync(name, request, headers, runtime);
        }

        /**
         * @summary 查询身份绑定
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConnectionResponse
         */
        public GetConnectionResponse GetConnectionWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConnection",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConnectionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询身份绑定
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConnectionResponse
         */
        public async Task<GetConnectionResponse> GetConnectionWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConnection",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询身份绑定
         *
         * @return GetConnectionResponse
         */
        public GetConnectionResponse GetConnection(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetConnectionWithOptions(name, headers, runtime);
        }

        /**
         * @summary 查询身份绑定
         *
         * @return GetConnectionResponse
         */
        public async Task<GetConnectionResponse> GetConnectionAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetConnectionWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 获取环境信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEnvironmentResponse
         */
        public GetEnvironmentResponse GetEnvironmentWithOptions(string project, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(project) + "/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnvironmentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取环境信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEnvironmentResponse
         */
        public async Task<GetEnvironmentResponse> GetEnvironmentWithOptionsAsync(string project, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(project) + "/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取环境信息
         *
         * @return GetEnvironmentResponse
         */
        public GetEnvironmentResponse GetEnvironment(string project, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEnvironmentWithOptions(project, name, headers, runtime);
        }

        /**
         * @summary 获取环境信息
         *
         * @return GetEnvironmentResponse
         */
        public async Task<GetEnvironmentResponse> GetEnvironmentAsync(string project, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEnvironmentWithOptionsAsync(project, name, headers, runtime);
        }

        /**
         * @summary 查询流水线
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPipelineResponse
         */
        public GetPipelineResponse GetPipelineWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipeline",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询流水线
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPipelineResponse
         */
        public async Task<GetPipelineResponse> GetPipelineWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipeline",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询流水线
         *
         * @return GetPipelineResponse
         */
        public GetPipelineResponse GetPipeline(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPipelineWithOptions(name, headers, runtime);
        }

        /**
         * @summary 查询流水线
         *
         * @return GetPipelineResponse
         */
        public async Task<GetPipelineResponse> GetPipelineAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPipelineWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 查询流水线模板
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPipelineTemplateResponse
         */
        public GetPipelineTemplateResponse GetPipelineTemplateWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineTemplate",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetemplates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询流水线模板
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPipelineTemplateResponse
         */
        public async Task<GetPipelineTemplateResponse> GetPipelineTemplateWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineTemplate",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetemplates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询流水线模板
         *
         * @return GetPipelineTemplateResponse
         */
        public GetPipelineTemplateResponse GetPipelineTemplate(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPipelineTemplateWithOptions(name, headers, runtime);
        }

        /**
         * @summary 查询流水线模板
         *
         * @return GetPipelineTemplateResponse
         */
        public async Task<GetPipelineTemplateResponse> GetPipelineTemplateAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPipelineTemplateWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 查询流水线触发器
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPipelineTriggerResponse
         */
        public GetPipelineTriggerResponse GetPipelineTriggerWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineTrigger",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetriggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineTriggerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询流水线触发器
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPipelineTriggerResponse
         */
        public async Task<GetPipelineTriggerResponse> GetPipelineTriggerWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineTrigger",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetriggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询流水线触发器
         *
         * @return GetPipelineTriggerResponse
         */
        public GetPipelineTriggerResponse GetPipelineTrigger(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPipelineTriggerWithOptions(name, headers, runtime);
        }

        /**
         * @summary 查询流水线触发器
         *
         * @return GetPipelineTriggerResponse
         */
        public async Task<GetPipelineTriggerResponse> GetPipelineTriggerAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPipelineTriggerWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 查询流水线触发历史
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPipelineTriggerEventResponse
         */
        public GetPipelineTriggerEventResponse GetPipelineTriggerEventWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineTriggerEvent",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetriggerevents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineTriggerEventResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询流水线触发历史
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPipelineTriggerEventResponse
         */
        public async Task<GetPipelineTriggerEventResponse> GetPipelineTriggerEventWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineTriggerEvent",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetriggerevents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineTriggerEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询流水线触发历史
         *
         * @return GetPipelineTriggerEventResponse
         */
        public GetPipelineTriggerEventResponse GetPipelineTriggerEvent(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPipelineTriggerEventWithOptions(name, headers, runtime);
        }

        /**
         * @summary 查询流水线触发历史
         *
         * @return GetPipelineTriggerEventResponse
         */
        public async Task<GetPipelineTriggerEventResponse> GetPipelineTriggerEventAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPipelineTriggerEventWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 查询项目
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectResponse
         */
        public GetProjectResponse GetProjectWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询项目
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectResponse
         */
        public async Task<GetProjectResponse> GetProjectWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询项目
         *
         * @return GetProjectResponse
         */
        public GetProjectResponse GetProject(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProjectWithOptions(name, headers, runtime);
        }

        /**
         * @summary 查询项目
         *
         * @return GetProjectResponse
         */
        public async Task<GetProjectResponse> GetProjectAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProjectWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 查询仓库绑定
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRepositoryResponse
         */
        public GetRepositoryResponse GetRepositoryWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepository",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/repositories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepositoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询仓库绑定
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRepositoryResponse
         */
        public async Task<GetRepositoryResponse> GetRepositoryWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepository",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/repositories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询仓库绑定
         *
         * @return GetRepositoryResponse
         */
        public GetRepositoryResponse GetRepository(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRepositoryWithOptions(name, headers, runtime);
        }

        /**
         * @summary 查询仓库绑定
         *
         * @return GetRepositoryResponse
         */
        public async Task<GetRepositoryResponse> GetRepositoryAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRepositoryWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 查询任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskResponse
         */
        public GetTaskResponse GetTaskWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskResponse
         */
        public async Task<GetTaskResponse> GetTaskWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询任务
         *
         * @return GetTaskResponse
         */
        public GetTaskResponse GetTask(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskWithOptions(name, headers, runtime);
        }

        /**
         * @summary 查询任务
         *
         * @return GetTaskResponse
         */
        public async Task<GetTaskResponse> GetTaskAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 查询任务模板
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskTemplateResponse
         */
        public GetTaskTemplateResponse GetTaskTemplateWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskTemplate",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasktemplates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询任务模板
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskTemplateResponse
         */
        public async Task<GetTaskTemplateResponse> GetTaskTemplateWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskTemplate",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasktemplates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询任务模板
         *
         * @return GetTaskTemplateResponse
         */
        public GetTaskTemplateResponse GetTaskTemplate(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskTemplateWithOptions(name, headers, runtime);
        }

        /**
         * @summary 查询任务模板
         *
         * @return GetTaskTemplateResponse
         */
        public async Task<GetTaskTemplateResponse> GetTaskTemplateAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskTemplateWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 批量查询身份绑定
         *
         * @param tmpReq ListConnectionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConnectionsResponse
         */
        public ListConnectionsResponse ListConnectionsWithOptions(ListConnectionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListConnectionsShrinkRequest request = new ListConnectionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConnections",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConnectionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量查询身份绑定
         *
         * @param tmpReq ListConnectionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConnectionsResponse
         */
        public async Task<ListConnectionsResponse> ListConnectionsWithOptionsAsync(ListConnectionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListConnectionsShrinkRequest request = new ListConnectionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConnections",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConnectionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量查询身份绑定
         *
         * @param request ListConnectionsRequest
         * @return ListConnectionsResponse
         */
        public ListConnectionsResponse ListConnections(ListConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConnectionsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询身份绑定
         *
         * @param request ListConnectionsRequest
         * @return ListConnectionsResponse
         */
        public async Task<ListConnectionsResponse> ListConnectionsAsync(ListConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConnectionsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询环境列表
         *
         * @param tmpReq ListEnvironmentsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEnvironmentsResponse
         */
        public ListEnvironmentsResponse ListEnvironmentsWithOptions(string project, ListEnvironmentsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListEnvironmentsShrinkRequest request = new ListEnvironmentsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnvironments",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(project) + "/environments/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnvironmentsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询环境列表
         *
         * @param tmpReq ListEnvironmentsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEnvironmentsResponse
         */
        public async Task<ListEnvironmentsResponse> ListEnvironmentsWithOptionsAsync(string project, ListEnvironmentsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListEnvironmentsShrinkRequest request = new ListEnvironmentsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnvironments",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(project) + "/environments/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnvironmentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询环境列表
         *
         * @param request ListEnvironmentsRequest
         * @return ListEnvironmentsResponse
         */
        public ListEnvironmentsResponse ListEnvironments(string project, ListEnvironmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEnvironmentsWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary 查询环境列表
         *
         * @param request ListEnvironmentsRequest
         * @return ListEnvironmentsResponse
         */
        public async Task<ListEnvironmentsResponse> ListEnvironmentsAsync(string project, ListEnvironmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEnvironmentsWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary 批量查询流水线模板
         *
         * @param tmpReq ListPipelineTemplatesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPipelineTemplatesResponse
         */
        public ListPipelineTemplatesResponse ListPipelineTemplatesWithOptions(ListPipelineTemplatesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPipelineTemplatesShrinkRequest request = new ListPipelineTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelineTemplates",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetemplates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<ListPipelineTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量查询流水线模板
         *
         * @param tmpReq ListPipelineTemplatesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPipelineTemplatesResponse
         */
        public async Task<ListPipelineTemplatesResponse> ListPipelineTemplatesWithOptionsAsync(ListPipelineTemplatesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPipelineTemplatesShrinkRequest request = new ListPipelineTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelineTemplates",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetemplates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<ListPipelineTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量查询流水线模板
         *
         * @param request ListPipelineTemplatesRequest
         * @return ListPipelineTemplatesResponse
         */
        public ListPipelineTemplatesResponse ListPipelineTemplates(ListPipelineTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPipelineTemplatesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询流水线模板
         *
         * @param request ListPipelineTemplatesRequest
         * @return ListPipelineTemplatesResponse
         */
        public async Task<ListPipelineTemplatesResponse> ListPipelineTemplatesAsync(ListPipelineTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPipelineTemplatesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量查询流水线触发历史
         *
         * @param tmpReq ListPipelineTriggerEventsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPipelineTriggerEventsResponse
         */
        public ListPipelineTriggerEventsResponse ListPipelineTriggerEventsWithOptions(ListPipelineTriggerEventsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPipelineTriggerEventsShrinkRequest request = new ListPipelineTriggerEventsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelineTriggerEvents",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetriggerevents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelineTriggerEventsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量查询流水线触发历史
         *
         * @param tmpReq ListPipelineTriggerEventsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPipelineTriggerEventsResponse
         */
        public async Task<ListPipelineTriggerEventsResponse> ListPipelineTriggerEventsWithOptionsAsync(ListPipelineTriggerEventsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPipelineTriggerEventsShrinkRequest request = new ListPipelineTriggerEventsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelineTriggerEvents",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetriggerevents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelineTriggerEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量查询流水线触发历史
         *
         * @param request ListPipelineTriggerEventsRequest
         * @return ListPipelineTriggerEventsResponse
         */
        public ListPipelineTriggerEventsResponse ListPipelineTriggerEvents(ListPipelineTriggerEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPipelineTriggerEventsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询流水线触发历史
         *
         * @param request ListPipelineTriggerEventsRequest
         * @return ListPipelineTriggerEventsResponse
         */
        public async Task<ListPipelineTriggerEventsResponse> ListPipelineTriggerEventsAsync(ListPipelineTriggerEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPipelineTriggerEventsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量查询流水线触发器
         *
         * @param tmpReq ListPipelineTriggersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPipelineTriggersResponse
         */
        public ListPipelineTriggersResponse ListPipelineTriggersWithOptions(ListPipelineTriggersRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPipelineTriggersShrinkRequest request = new ListPipelineTriggersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelineTriggers",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetriggers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelineTriggersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量查询流水线触发器
         *
         * @param tmpReq ListPipelineTriggersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPipelineTriggersResponse
         */
        public async Task<ListPipelineTriggersResponse> ListPipelineTriggersWithOptionsAsync(ListPipelineTriggersRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPipelineTriggersShrinkRequest request = new ListPipelineTriggersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelineTriggers",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetriggers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelineTriggersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量查询流水线触发器
         *
         * @param request ListPipelineTriggersRequest
         * @return ListPipelineTriggersResponse
         */
        public ListPipelineTriggersResponse ListPipelineTriggers(ListPipelineTriggersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPipelineTriggersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询流水线触发器
         *
         * @param request ListPipelineTriggersRequest
         * @return ListPipelineTriggersResponse
         */
        public async Task<ListPipelineTriggersResponse> ListPipelineTriggersAsync(ListPipelineTriggersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPipelineTriggersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量查询流水线
         *
         * @param tmpReq ListPipelinesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPipelinesResponse
         */
        public ListPipelinesResponse ListPipelinesWithOptions(ListPipelinesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPipelinesShrinkRequest request = new ListPipelinesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelines",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<ListPipelinesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量查询流水线
         *
         * @param tmpReq ListPipelinesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPipelinesResponse
         */
        public async Task<ListPipelinesResponse> ListPipelinesWithOptionsAsync(ListPipelinesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPipelinesShrinkRequest request = new ListPipelinesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelines",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<ListPipelinesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量查询流水线
         *
         * @param request ListPipelinesRequest
         * @return ListPipelinesResponse
         */
        public ListPipelinesResponse ListPipelines(ListPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPipelinesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询流水线
         *
         * @param request ListPipelinesRequest
         * @return ListPipelinesResponse
         */
        public async Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPipelinesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量查询项目
         *
         * @param tmpReq ListProjectsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProjectsResponse
         */
        public ListProjectsResponse ListProjectsWithOptions(ListProjectsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProjectsShrinkRequest request = new ListProjectsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjects",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量查询项目
         *
         * @param tmpReq ListProjectsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProjectsResponse
         */
        public async Task<ListProjectsResponse> ListProjectsWithOptionsAsync(ListProjectsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProjectsShrinkRequest request = new ListProjectsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjects",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量查询项目
         *
         * @param request ListProjectsRequest
         * @return ListProjectsResponse
         */
        public ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProjectsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询项目
         *
         * @param request ListProjectsRequest
         * @return ListProjectsResponse
         */
        public async Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProjectsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量查询仓库绑定
         *
         * @param tmpReq ListRepositoriesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRepositoriesResponse
         */
        public ListRepositoriesResponse ListRepositoriesWithOptions(ListRepositoriesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListRepositoriesShrinkRequest request = new ListRepositoriesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositories",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/repositories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoriesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量查询仓库绑定
         *
         * @param tmpReq ListRepositoriesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRepositoriesResponse
         */
        public async Task<ListRepositoriesResponse> ListRepositoriesWithOptionsAsync(ListRepositoriesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListRepositoriesShrinkRequest request = new ListRepositoriesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositories",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/repositories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量查询仓库绑定
         *
         * @param request ListRepositoriesRequest
         * @return ListRepositoriesResponse
         */
        public ListRepositoriesResponse ListRepositories(ListRepositoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRepositoriesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询仓库绑定
         *
         * @param request ListRepositoriesRequest
         * @return ListRepositoriesResponse
         */
        public async Task<ListRepositoriesResponse> ListRepositoriesAsync(ListRepositoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRepositoriesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量查询任务模板
         *
         * @param tmpReq ListTaskTemplatesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTaskTemplatesResponse
         */
        public ListTaskTemplatesResponse ListTaskTemplatesWithOptions(ListTaskTemplatesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTaskTemplatesShrinkRequest request = new ListTaskTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTaskTemplates",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasktemplates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<ListTaskTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量查询任务模板
         *
         * @param tmpReq ListTaskTemplatesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTaskTemplatesResponse
         */
        public async Task<ListTaskTemplatesResponse> ListTaskTemplatesWithOptionsAsync(ListTaskTemplatesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTaskTemplatesShrinkRequest request = new ListTaskTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTaskTemplates",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasktemplates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<ListTaskTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量查询任务模板
         *
         * @param request ListTaskTemplatesRequest
         * @return ListTaskTemplatesResponse
         */
        public ListTaskTemplatesResponse ListTaskTemplates(ListTaskTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTaskTemplatesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询任务模板
         *
         * @param request ListTaskTemplatesRequest
         * @return ListTaskTemplatesResponse
         */
        public async Task<ListTaskTemplatesResponse> ListTaskTemplatesAsync(ListTaskTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTaskTemplatesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量查询任务
         *
         * @param tmpReq ListTasksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTasksResponse
         */
        public ListTasksResponse ListTasksWithOptions(ListTasksRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTasksShrinkRequest request = new ListTasksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTasks",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<ListTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量查询任务
         *
         * @param tmpReq ListTasksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTasksResponse
         */
        public async Task<ListTasksResponse> ListTasksWithOptionsAsync(ListTasksRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTasksShrinkRequest request = new ListTasksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTasks",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<ListTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量查询任务
         *
         * @param request ListTasksRequest
         * @return ListTasksResponse
         */
        public ListTasksResponse ListTasks(ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTasksWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询任务
         *
         * @param request ListTasksRequest
         * @return ListTasksResponse
         */
        public async Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTasksWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新环境（全局更新）
         *
         * @param request PutEnvironmentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutEnvironmentResponse
         */
        public PutEnvironmentResponse PutEnvironmentWithOptions(string project, string name, PutEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(project) + "/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutEnvironmentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新环境（全局更新）
         *
         * @param request PutEnvironmentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutEnvironmentResponse
         */
        public async Task<PutEnvironmentResponse> PutEnvironmentWithOptionsAsync(string project, string name, PutEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(project) + "/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新环境（全局更新）
         *
         * @param request PutEnvironmentRequest
         * @return PutEnvironmentResponse
         */
        public PutEnvironmentResponse PutEnvironment(string project, string name, PutEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutEnvironmentWithOptions(project, name, request, headers, runtime);
        }

        /**
         * @summary 更新环境（全局更新）
         *
         * @param request PutEnvironmentRequest
         * @return PutEnvironmentResponse
         */
        public async Task<PutEnvironmentResponse> PutEnvironmentAsync(string project, string name, PutEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutEnvironmentWithOptionsAsync(project, name, request, headers, runtime);
        }

        /**
         * @summary 更新流水线状态
         *
         * @param request PutPipelineStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutPipelineStatusResponse
         */
        public PutPipelineStatusResponse PutPipelineStatusWithOptions(string name, PutPipelineStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutPipelineStatus",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/status",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutPipelineStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新流水线状态
         *
         * @param request PutPipelineStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutPipelineStatusResponse
         */
        public async Task<PutPipelineStatusResponse> PutPipelineStatusWithOptionsAsync(string name, PutPipelineStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutPipelineStatus",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/status",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutPipelineStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新流水线状态
         *
         * @param request PutPipelineStatusRequest
         * @return PutPipelineStatusResponse
         */
        public PutPipelineStatusResponse PutPipelineStatus(string name, PutPipelineStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutPipelineStatusWithOptions(name, request, headers, runtime);
        }

        /**
         * @summary 更新流水线状态
         *
         * @param request PutPipelineStatusRequest
         * @return PutPipelineStatusResponse
         */
        public async Task<PutPipelineStatusResponse> PutPipelineStatusAsync(string name, PutPipelineStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutPipelineStatusWithOptionsAsync(name, request, headers, runtime);
        }

        /**
         * @summary 更新替换流水线模板
         *
         * @param request PutPipelineTemplateRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutPipelineTemplateResponse
         */
        public PutPipelineTemplateResponse PutPipelineTemplateWithOptions(string name, PutPipelineTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutPipelineTemplate",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetemplates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutPipelineTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新替换流水线模板
         *
         * @param request PutPipelineTemplateRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutPipelineTemplateResponse
         */
        public async Task<PutPipelineTemplateResponse> PutPipelineTemplateWithOptionsAsync(string name, PutPipelineTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutPipelineTemplate",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetemplates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutPipelineTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新替换流水线模板
         *
         * @param request PutPipelineTemplateRequest
         * @return PutPipelineTemplateResponse
         */
        public PutPipelineTemplateResponse PutPipelineTemplate(string name, PutPipelineTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutPipelineTemplateWithOptions(name, request, headers, runtime);
        }

        /**
         * @summary 更新替换流水线模板
         *
         * @param request PutPipelineTemplateRequest
         * @return PutPipelineTemplateResponse
         */
        public async Task<PutPipelineTemplateResponse> PutPipelineTemplateAsync(string name, PutPipelineTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutPipelineTemplateWithOptionsAsync(name, request, headers, runtime);
        }

        /**
         * @summary 更新替换流水线触发器
         *
         * @param request PutPipelineTriggerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutPipelineTriggerResponse
         */
        public PutPipelineTriggerResponse PutPipelineTriggerWithOptions(string name, PutPipelineTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutPipelineTrigger",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetriggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutPipelineTriggerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新替换流水线触发器
         *
         * @param request PutPipelineTriggerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutPipelineTriggerResponse
         */
        public async Task<PutPipelineTriggerResponse> PutPipelineTriggerWithOptionsAsync(string name, PutPipelineTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutPipelineTrigger",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetriggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutPipelineTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新替换流水线触发器
         *
         * @param request PutPipelineTriggerRequest
         * @return PutPipelineTriggerResponse
         */
        public PutPipelineTriggerResponse PutPipelineTrigger(string name, PutPipelineTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutPipelineTriggerWithOptions(name, request, headers, runtime);
        }

        /**
         * @summary 更新替换流水线触发器
         *
         * @param request PutPipelineTriggerRequest
         * @return PutPipelineTriggerResponse
         */
        public async Task<PutPipelineTriggerResponse> PutPipelineTriggerAsync(string name, PutPipelineTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutPipelineTriggerWithOptionsAsync(name, request, headers, runtime);
        }

        /**
         * @summary 更新替换应用
         *
         * @param request PutProjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutProjectResponse
         */
        public PutProjectResponse PutProjectWithOptions(string name, PutProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutProject",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新替换应用
         *
         * @param request PutProjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutProjectResponse
         */
        public async Task<PutProjectResponse> PutProjectWithOptionsAsync(string name, PutProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutProject",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新替换应用
         *
         * @param request PutProjectRequest
         * @return PutProjectResponse
         */
        public PutProjectResponse PutProject(string name, PutProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutProjectWithOptions(name, request, headers, runtime);
        }

        /**
         * @summary 更新替换应用
         *
         * @param request PutProjectRequest
         * @return PutProjectResponse
         */
        public async Task<PutProjectResponse> PutProjectAsync(string name, PutProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutProjectWithOptionsAsync(name, request, headers, runtime);
        }

        /**
         * @summary 更新替换任务状态
         *
         * @param request PutTaskStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutTaskStatusResponse
         */
        public PutTaskStatusResponse PutTaskStatusWithOptions(string name, PutTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutTaskStatus",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/status",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新替换任务状态
         *
         * @param request PutTaskStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutTaskStatusResponse
         */
        public async Task<PutTaskStatusResponse> PutTaskStatusWithOptionsAsync(string name, PutTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutTaskStatus",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/status",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新替换任务状态
         *
         * @param request PutTaskStatusRequest
         * @return PutTaskStatusResponse
         */
        public PutTaskStatusResponse PutTaskStatus(string name, PutTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutTaskStatusWithOptions(name, request, headers, runtime);
        }

        /**
         * @summary 更新替换任务状态
         *
         * @param request PutTaskStatusRequest
         * @return PutTaskStatusResponse
         */
        public async Task<PutTaskStatusResponse> PutTaskStatusAsync(string name, PutTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutTaskStatusWithOptionsAsync(name, request, headers, runtime);
        }

        /**
         * @summary 更新替换任务模板
         *
         * @param request PutTaskTemplateRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutTaskTemplateResponse
         */
        public PutTaskTemplateResponse PutTaskTemplateWithOptions(string name, PutTaskTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutTaskTemplate",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasktemplates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutTaskTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新替换任务模板
         *
         * @param request PutTaskTemplateRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutTaskTemplateResponse
         */
        public async Task<PutTaskTemplateResponse> PutTaskTemplateWithOptionsAsync(string name, PutTaskTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutTaskTemplate",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasktemplates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutTaskTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新替换任务模板
         *
         * @param request PutTaskTemplateRequest
         * @return PutTaskTemplateResponse
         */
        public PutTaskTemplateResponse PutTaskTemplate(string name, PutTaskTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutTaskTemplateWithOptions(name, request, headers, runtime);
        }

        /**
         * @summary 更新替换任务模板
         *
         * @param request PutTaskTemplateRequest
         * @return PutTaskTemplateResponse
         */
        public async Task<PutTaskTemplateResponse> PutTaskTemplateAsync(string name, PutTaskTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutTaskTemplateWithOptionsAsync(name, request, headers, runtime);
        }

        /**
         * @summary 检查并刷新身份绑定中的凭证和账号信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefreshConnectionResponse
         */
        public RefreshConnectionResponse RefreshConnectionWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshConnection",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/refresh",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshConnectionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 检查并刷新身份绑定中的凭证和账号信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefreshConnectionResponse
         */
        public async Task<RefreshConnectionResponse> RefreshConnectionWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshConnection",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/refresh",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 检查并刷新身份绑定中的凭证和账号信息
         *
         * @return RefreshConnectionResponse
         */
        public RefreshConnectionResponse RefreshConnection(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RefreshConnectionWithOptions(name, headers, runtime);
        }

        /**
         * @summary 检查并刷新身份绑定中的凭证和账号信息
         *
         * @return RefreshConnectionResponse
         */
        public async Task<RefreshConnectionResponse> RefreshConnectionAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RefreshConnectionWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 确认并继续执行任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumeTaskResponse
         */
        public ResumeTaskResponse ResumeTaskWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/resume",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 确认并继续执行任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumeTaskResponse
         */
        public async Task<ResumeTaskResponse> ResumeTaskWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/resume",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 确认并继续执行任务
         *
         * @return ResumeTaskResponse
         */
        public ResumeTaskResponse ResumeTask(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResumeTaskWithOptions(name, headers, runtime);
        }

        /**
         * @summary 确认并继续执行任务
         *
         * @return ResumeTaskResponse
         */
        public async Task<ResumeTaskResponse> ResumeTaskAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResumeTaskWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 重试执行任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetryTaskResponse
         */
        public RetryTaskResponse RetryTaskWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/retry",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 重试执行任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetryTaskResponse
         */
        public async Task<RetryTaskResponse> RetryTaskWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/retry",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 重试执行任务
         *
         * @return RetryTaskResponse
         */
        public RetryTaskResponse RetryTask(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RetryTaskWithOptions(name, headers, runtime);
        }

        /**
         * @summary 重试执行任务
         *
         * @return RetryTaskResponse
         */
        public async Task<RetryTaskResponse> RetryTaskAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RetryTaskWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 开始执行流水线
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartPipelineResponse
         */
        public StartPipelineResponse StartPipelineWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartPipeline",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartPipelineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 开始执行流水线
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartPipelineResponse
         */
        public async Task<StartPipelineResponse> StartPipelineWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartPipeline",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartPipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 开始执行流水线
         *
         * @return StartPipelineResponse
         */
        public StartPipelineResponse StartPipeline(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartPipelineWithOptions(name, headers, runtime);
        }

        /**
         * @summary 开始执行流水线
         *
         * @return StartPipelineResponse
         */
        public async Task<StartPipelineResponse> StartPipelineAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartPipelineWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 开始执行任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartTaskResponse
         */
        public StartTaskResponse StartTaskWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 开始执行任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartTaskResponse
         */
        public async Task<StartTaskResponse> StartTaskWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 开始执行任务
         *
         * @return StartTaskResponse
         */
        public StartTaskResponse StartTask(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartTaskWithOptions(name, headers, runtime);
        }

        /**
         * @summary 开始执行任务
         *
         * @return StartTaskResponse
         */
        public async Task<StartTaskResponse> StartTaskAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartTaskWithOptionsAsync(name, headers, runtime);
        }

        /**
         * @summary 更新环境（局部更新）
         *
         * @param request UpdateEnvironmentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateEnvironmentResponse
         */
        public UpdateEnvironmentResponse UpdateEnvironmentWithOptions(string project, string name, UpdateEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(project) + "/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEnvironmentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新环境（局部更新）
         *
         * @param request UpdateEnvironmentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateEnvironmentResponse
         */
        public async Task<UpdateEnvironmentResponse> UpdateEnvironmentWithOptionsAsync(string project, string name, UpdateEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(project) + "/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新环境（局部更新）
         *
         * @param request UpdateEnvironmentRequest
         * @return UpdateEnvironmentResponse
         */
        public UpdateEnvironmentResponse UpdateEnvironment(string project, string name, UpdateEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateEnvironmentWithOptions(project, name, request, headers, runtime);
        }

        /**
         * @summary 更新环境（局部更新）
         *
         * @param request UpdateEnvironmentRequest
         * @return UpdateEnvironmentResponse
         */
        public async Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(string project, string name, UpdateEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateEnvironmentWithOptionsAsync(project, name, request, headers, runtime);
        }

        /**
         * @summary 更新流水线触发器
         *
         * @param request UpdatePipelineTriggerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePipelineTriggerResponse
         */
        public UpdatePipelineTriggerResponse UpdatePipelineTriggerWithOptions(string name, UpdatePipelineTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePipelineTrigger",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetriggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePipelineTriggerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新流水线触发器
         *
         * @param request UpdatePipelineTriggerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePipelineTriggerResponse
         */
        public async Task<UpdatePipelineTriggerResponse> UpdatePipelineTriggerWithOptionsAsync(string name, UpdatePipelineTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePipelineTrigger",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelinetriggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePipelineTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新流水线触发器
         *
         * @param request UpdatePipelineTriggerRequest
         * @return UpdatePipelineTriggerResponse
         */
        public UpdatePipelineTriggerResponse UpdatePipelineTrigger(string name, UpdatePipelineTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePipelineTriggerWithOptions(name, request, headers, runtime);
        }

        /**
         * @summary 更新流水线触发器
         *
         * @param request UpdatePipelineTriggerRequest
         * @return UpdatePipelineTriggerResponse
         */
        public async Task<UpdatePipelineTriggerResponse> UpdatePipelineTriggerAsync(string name, UpdatePipelineTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePipelineTriggerWithOptionsAsync(name, request, headers, runtime);
        }

        /**
         * @summary 更新替换应用
         *
         * @param request UpdateProjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProjectResponse
         */
        public UpdateProjectResponse UpdateProjectWithOptions(string name, UpdateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProject",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新替换应用
         *
         * @param request UpdateProjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProjectResponse
         */
        public async Task<UpdateProjectResponse> UpdateProjectWithOptionsAsync(string name, UpdateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProject",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新替换应用
         *
         * @param request UpdateProjectRequest
         * @return UpdateProjectResponse
         */
        public UpdateProjectResponse UpdateProject(string name, UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProjectWithOptions(name, request, headers, runtime);
        }

        /**
         * @summary 更新替换应用
         *
         * @param request UpdateProjectRequest
         * @return UpdateProjectResponse
         */
        public async Task<UpdateProjectResponse> UpdateProjectAsync(string name, UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProjectWithOptionsAsync(name, request, headers, runtime);
        }

    }
}
