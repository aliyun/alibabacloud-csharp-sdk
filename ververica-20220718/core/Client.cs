// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ververica20220718.Models;

namespace AlibabaCloud.SDK.Ververica20220718
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ververica", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary create a deployment
         *
         * @param request CreateDeploymentRequest
         * @param headers CreateDeploymentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDeploymentResponse
         */
        public CreateDeploymentResponse CreateDeploymentWithOptions(string namespace_, CreateDeploymentRequest request, CreateDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeploymentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary create a deployment
         *
         * @param request CreateDeploymentRequest
         * @param headers CreateDeploymentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDeploymentResponse
         */
        public async Task<CreateDeploymentResponse> CreateDeploymentWithOptionsAsync(string namespace_, CreateDeploymentRequest request, CreateDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeploymentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary create a deployment
         *
         * @param request CreateDeploymentRequest
         * @return CreateDeploymentResponse
         */
        public CreateDeploymentResponse CreateDeployment(string namespace_, CreateDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeploymentHeaders headers = new CreateDeploymentHeaders();
            return CreateDeploymentWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary create a deployment
         *
         * @param request CreateDeploymentRequest
         * @return CreateDeploymentResponse
         */
        public async Task<CreateDeploymentResponse> CreateDeploymentAsync(string namespace_, CreateDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeploymentHeaders headers = new CreateDeploymentHeaders();
            return await CreateDeploymentWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary 调用CreateMember创建成员。
         *
         * @param request CreateMemberRequest
         * @param headers CreateMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMemberResponse
         */
        public CreateMemberResponse CreateMemberWithOptions(string namespace_, CreateMemberRequest request, CreateMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用CreateMember创建成员。
         *
         * @param request CreateMemberRequest
         * @param headers CreateMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMemberResponse
         */
        public async Task<CreateMemberResponse> CreateMemberWithOptionsAsync(string namespace_, CreateMemberRequest request, CreateMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用CreateMember创建成员。
         *
         * @param request CreateMemberRequest
         * @return CreateMemberResponse
         */
        public CreateMemberResponse CreateMember(string namespace_, CreateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMemberHeaders headers = new CreateMemberHeaders();
            return CreateMemberWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary 调用CreateMember创建成员。
         *
         * @param request CreateMemberRequest
         * @return CreateMemberResponse
         */
        public async Task<CreateMemberResponse> CreateMemberAsync(string namespace_, CreateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMemberHeaders headers = new CreateMemberHeaders();
            return await CreateMemberWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary 调用CreateSavepoint触发一次savepoint。
         *
         * @param request CreateSavepointRequest
         * @param headers CreateSavepointHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSavepointResponse
         */
        public CreateSavepointResponse CreateSavepointWithOptions(string namespace_, CreateSavepointRequest request, CreateSavepointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                body["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NativeFormat))
            {
                body["nativeFormat"] = request.NativeFormat;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSavepoint",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSavepointResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用CreateSavepoint触发一次savepoint。
         *
         * @param request CreateSavepointRequest
         * @param headers CreateSavepointHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSavepointResponse
         */
        public async Task<CreateSavepointResponse> CreateSavepointWithOptionsAsync(string namespace_, CreateSavepointRequest request, CreateSavepointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                body["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NativeFormat))
            {
                body["nativeFormat"] = request.NativeFormat;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSavepoint",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSavepointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用CreateSavepoint触发一次savepoint。
         *
         * @param request CreateSavepointRequest
         * @return CreateSavepointResponse
         */
        public CreateSavepointResponse CreateSavepoint(string namespace_, CreateSavepointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSavepointHeaders headers = new CreateSavepointHeaders();
            return CreateSavepointWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary 调用CreateSavepoint触发一次savepoint。
         *
         * @param request CreateSavepointRequest
         * @return CreateSavepointResponse
         */
        public async Task<CreateSavepointResponse> CreateSavepointAsync(string namespace_, CreateSavepointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSavepointHeaders headers = new CreateSavepointHeaders();
            return await CreateSavepointWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary 调用CreateVariable创建变量。
         *
         * @param request CreateVariableRequest
         * @param headers CreateVariableHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVariableResponse
         */
        public CreateVariableResponse CreateVariableWithOptions(string namespace_, CreateVariableRequest request, CreateVariableHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVariable",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/variables",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVariableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用CreateVariable创建变量。
         *
         * @param request CreateVariableRequest
         * @param headers CreateVariableHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVariableResponse
         */
        public async Task<CreateVariableResponse> CreateVariableWithOptionsAsync(string namespace_, CreateVariableRequest request, CreateVariableHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVariable",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/variables",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVariableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用CreateVariable创建变量。
         *
         * @param request CreateVariableRequest
         * @return CreateVariableResponse
         */
        public CreateVariableResponse CreateVariable(string namespace_, CreateVariableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVariableHeaders headers = new CreateVariableHeaders();
            return CreateVariableWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary 调用CreateVariable创建变量。
         *
         * @param request CreateVariableRequest
         * @return CreateVariableResponse
         */
        public async Task<CreateVariableResponse> CreateVariableAsync(string namespace_, CreateVariableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVariableHeaders headers = new CreateVariableHeaders();
            return await CreateVariableWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary delete deployment
         *
         * @param headers DeleteDeploymentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDeploymentResponse
         */
        public DeleteDeploymentResponse DeleteDeploymentWithOptions(string namespace_, string deploymentId, DeleteDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeploymentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary delete deployment
         *
         * @param headers DeleteDeploymentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDeploymentResponse
         */
        public async Task<DeleteDeploymentResponse> DeleteDeploymentWithOptionsAsync(string namespace_, string deploymentId, DeleteDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeploymentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary delete deployment
         *
         * @return DeleteDeploymentResponse
         */
        public DeleteDeploymentResponse DeleteDeployment(string namespace_, string deploymentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDeploymentHeaders headers = new DeleteDeploymentHeaders();
            return DeleteDeploymentWithOptions(namespace_, deploymentId, headers, runtime);
        }

        /**
         * @summary delete deployment
         *
         * @return DeleteDeploymentResponse
         */
        public async Task<DeleteDeploymentResponse> DeleteDeploymentAsync(string namespace_, string deploymentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDeploymentHeaders headers = new DeleteDeploymentHeaders();
            return await DeleteDeploymentWithOptionsAsync(namespace_, deploymentId, headers, runtime);
        }

        /**
         * @summary delete job
         *
         * @param headers DeleteJobHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteJobResponse
         */
        public DeleteJobResponse DeleteJobWithOptions(string namespace_, string jobId, DeleteJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary delete job
         *
         * @param headers DeleteJobHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteJobResponse
         */
        public async Task<DeleteJobResponse> DeleteJobWithOptionsAsync(string namespace_, string jobId, DeleteJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary delete job
         *
         * @return DeleteJobResponse
         */
        public DeleteJobResponse DeleteJob(string namespace_, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteJobHeaders headers = new DeleteJobHeaders();
            return DeleteJobWithOptions(namespace_, jobId, headers, runtime);
        }

        /**
         * @summary delete job
         *
         * @return DeleteJobResponse
         */
        public async Task<DeleteJobResponse> DeleteJobAsync(string namespace_, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteJobHeaders headers = new DeleteJobHeaders();
            return await DeleteJobWithOptionsAsync(namespace_, jobId, headers, runtime);
        }

        /**
         * @summary 调用DeleteMember删除成员。
         *
         * @param headers DeleteMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMemberResponse
         */
        public DeleteMemberResponse DeleteMemberWithOptions(string namespace_, string member, DeleteMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(member),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用DeleteMember删除成员。
         *
         * @param headers DeleteMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMemberResponse
         */
        public async Task<DeleteMemberResponse> DeleteMemberWithOptionsAsync(string namespace_, string member, DeleteMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(member),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用DeleteMember删除成员。
         *
         * @return DeleteMemberResponse
         */
        public DeleteMemberResponse DeleteMember(string namespace_, string member)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMemberHeaders headers = new DeleteMemberHeaders();
            return DeleteMemberWithOptions(namespace_, member, headers, runtime);
        }

        /**
         * @summary 调用DeleteMember删除成员。
         *
         * @return DeleteMemberResponse
         */
        public async Task<DeleteMemberResponse> DeleteMemberAsync(string namespace_, string member)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMemberHeaders headers = new DeleteMemberHeaders();
            return await DeleteMemberWithOptionsAsync(namespace_, member, headers, runtime);
        }

        /**
         * @summary 调用DeleteSavepoint删除savepoint。
         *
         * @param headers DeleteSavepointHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSavepointResponse
         */
        public DeleteSavepointResponse DeleteSavepointWithOptions(string namespace_, string savepointId, DeleteSavepointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSavepoint",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(savepointId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSavepointResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用DeleteSavepoint删除savepoint。
         *
         * @param headers DeleteSavepointHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSavepointResponse
         */
        public async Task<DeleteSavepointResponse> DeleteSavepointWithOptionsAsync(string namespace_, string savepointId, DeleteSavepointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSavepoint",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(savepointId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSavepointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用DeleteSavepoint删除savepoint。
         *
         * @return DeleteSavepointResponse
         */
        public DeleteSavepointResponse DeleteSavepoint(string namespace_, string savepointId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSavepointHeaders headers = new DeleteSavepointHeaders();
            return DeleteSavepointWithOptions(namespace_, savepointId, headers, runtime);
        }

        /**
         * @summary 调用DeleteSavepoint删除savepoint。
         *
         * @return DeleteSavepointResponse
         */
        public async Task<DeleteSavepointResponse> DeleteSavepointAsync(string namespace_, string savepointId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSavepointHeaders headers = new DeleteSavepointHeaders();
            return await DeleteSavepointWithOptionsAsync(namespace_, savepointId, headers, runtime);
        }

        /**
         * @summary deleta variable
         *
         * @param headers DeleteVariableHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVariableResponse
         */
        public DeleteVariableResponse DeleteVariableWithOptions(string namespace_, string name, DeleteVariableHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVariable",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/variables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVariableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary deleta variable
         *
         * @param headers DeleteVariableHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVariableResponse
         */
        public async Task<DeleteVariableResponse> DeleteVariableWithOptionsAsync(string namespace_, string name, DeleteVariableHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVariable",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/variables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVariableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary deleta variable
         *
         * @return DeleteVariableResponse
         */
        public DeleteVariableResponse DeleteVariable(string namespace_, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteVariableHeaders headers = new DeleteVariableHeaders();
            return DeleteVariableWithOptions(namespace_, name, headers, runtime);
        }

        /**
         * @summary deleta variable
         *
         * @return DeleteVariableResponse
         */
        public async Task<DeleteVariableResponse> DeleteVariableAsync(string namespace_, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteVariableHeaders headers = new DeleteVariableHeaders();
            return await DeleteVariableWithOptionsAsync(namespace_, name, headers, runtime);
        }

        /**
         * @summary 调用FlinkApiProxy代理Flink请求。
         *
         * @param request FlinkApiProxyRequest
         * @param headers FlinkApiProxyHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FlinkApiProxyResponse
         */
        public FlinkApiProxyResponse FlinkApiProxyWithOptions(FlinkApiProxyRequest request, FlinkApiProxyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlinkApiPath))
            {
                query["flinkApiPath"] = request.FlinkApiPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlinkApiProxy",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/flink-ui/v2/proxy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlinkApiProxyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用FlinkApiProxy代理Flink请求。
         *
         * @param request FlinkApiProxyRequest
         * @param headers FlinkApiProxyHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FlinkApiProxyResponse
         */
        public async Task<FlinkApiProxyResponse> FlinkApiProxyWithOptionsAsync(FlinkApiProxyRequest request, FlinkApiProxyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlinkApiPath))
            {
                query["flinkApiPath"] = request.FlinkApiPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlinkApiProxy",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/flink-ui/v2/proxy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlinkApiProxyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用FlinkApiProxy代理Flink请求。
         *
         * @param request FlinkApiProxyRequest
         * @return FlinkApiProxyResponse
         */
        public FlinkApiProxyResponse FlinkApiProxy(FlinkApiProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlinkApiProxyHeaders headers = new FlinkApiProxyHeaders();
            return FlinkApiProxyWithOptions(request, headers, runtime);
        }

        /**
         * @summary 调用FlinkApiProxy代理Flink请求。
         *
         * @param request FlinkApiProxyRequest
         * @return FlinkApiProxyResponse
         */
        public async Task<FlinkApiProxyResponse> FlinkApiProxyAsync(FlinkApiProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlinkApiProxyHeaders headers = new FlinkApiProxyHeaders();
            return await FlinkApiProxyWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary generate resource plan with flink conf async.
         *
         * @param request GenerateResourcePlanWithFlinkConfAsyncRequest
         * @param headers GenerateResourcePlanWithFlinkConfAsyncHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateResourcePlanWithFlinkConfAsyncResponse
         */
        public GenerateResourcePlanWithFlinkConfAsyncResponse GenerateResourcePlanWithFlinkConfAsyncWithOptions(string namespace_, string deploymentId, GenerateResourcePlanWithFlinkConfAsyncRequest request, GenerateResourcePlanWithFlinkConfAsyncHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateResourcePlanWithFlinkConfAsync",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId) + "/resource-plan%3AasyncGenerate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateResourcePlanWithFlinkConfAsyncResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary generate resource plan with flink conf async.
         *
         * @param request GenerateResourcePlanWithFlinkConfAsyncRequest
         * @param headers GenerateResourcePlanWithFlinkConfAsyncHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateResourcePlanWithFlinkConfAsyncResponse
         */
        public async Task<GenerateResourcePlanWithFlinkConfAsyncResponse> GenerateResourcePlanWithFlinkConfAsyncWithOptionsAsync(string namespace_, string deploymentId, GenerateResourcePlanWithFlinkConfAsyncRequest request, GenerateResourcePlanWithFlinkConfAsyncHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateResourcePlanWithFlinkConfAsync",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId) + "/resource-plan%3AasyncGenerate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateResourcePlanWithFlinkConfAsyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary generate resource plan with flink conf async.
         *
         * @param request GenerateResourcePlanWithFlinkConfAsyncRequest
         * @return GenerateResourcePlanWithFlinkConfAsyncResponse
         */
        public GenerateResourcePlanWithFlinkConfAsyncResponse GenerateResourcePlanWithFlinkConfAsync(string namespace_, string deploymentId, GenerateResourcePlanWithFlinkConfAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GenerateResourcePlanWithFlinkConfAsyncHeaders headers = new GenerateResourcePlanWithFlinkConfAsyncHeaders();
            return GenerateResourcePlanWithFlinkConfAsyncWithOptions(namespace_, deploymentId, request, headers, runtime);
        }

        /**
         * @summary generate resource plan with flink conf async.
         *
         * @param request GenerateResourcePlanWithFlinkConfAsyncRequest
         * @return GenerateResourcePlanWithFlinkConfAsyncResponse
         */
        public async Task<GenerateResourcePlanWithFlinkConfAsyncResponse> GenerateResourcePlanWithFlinkConfAsyncAsync(string namespace_, string deploymentId, GenerateResourcePlanWithFlinkConfAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GenerateResourcePlanWithFlinkConfAsyncHeaders headers = new GenerateResourcePlanWithFlinkConfAsyncHeaders();
            return await GenerateResourcePlanWithFlinkConfAsyncWithOptionsAsync(namespace_, deploymentId, request, headers, runtime);
        }

        /**
         * @summary get a deployment
         *
         * @param headers GetDeploymentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeploymentResponse
         */
        public GetDeploymentResponse GetDeploymentWithOptions(string namespace_, string deploymentId, GetDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeploymentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary get a deployment
         *
         * @param headers GetDeploymentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeploymentResponse
         */
        public async Task<GetDeploymentResponse> GetDeploymentWithOptionsAsync(string namespace_, string deploymentId, GetDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeploymentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary get a deployment
         *
         * @return GetDeploymentResponse
         */
        public GetDeploymentResponse GetDeployment(string namespace_, string deploymentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeploymentHeaders headers = new GetDeploymentHeaders();
            return GetDeploymentWithOptions(namespace_, deploymentId, headers, runtime);
        }

        /**
         * @summary get a deployment
         *
         * @return GetDeploymentResponse
         */
        public async Task<GetDeploymentResponse> GetDeploymentAsync(string namespace_, string deploymentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeploymentHeaders headers = new GetDeploymentHeaders();
            return await GetDeploymentWithOptionsAsync(namespace_, deploymentId, headers, runtime);
        }

        /**
         * @summary 获取生成ResourcePlan异步操作的结果。
         *
         * @param headers GetGenerateResourcePlanResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGenerateResourcePlanResultResponse
         */
        public GetGenerateResourcePlanResultResponse GetGenerateResourcePlanResultWithOptions(string namespace_, string ticketId, GetGenerateResourcePlanResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGenerateResourcePlanResult",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/tickets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ticketId) + "/resource-plan%3AasyncGenerate",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGenerateResourcePlanResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取生成ResourcePlan异步操作的结果。
         *
         * @param headers GetGenerateResourcePlanResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGenerateResourcePlanResultResponse
         */
        public async Task<GetGenerateResourcePlanResultResponse> GetGenerateResourcePlanResultWithOptionsAsync(string namespace_, string ticketId, GetGenerateResourcePlanResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGenerateResourcePlanResult",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/tickets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ticketId) + "/resource-plan%3AasyncGenerate",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGenerateResourcePlanResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取生成ResourcePlan异步操作的结果。
         *
         * @return GetGenerateResourcePlanResultResponse
         */
        public GetGenerateResourcePlanResultResponse GetGenerateResourcePlanResult(string namespace_, string ticketId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGenerateResourcePlanResultHeaders headers = new GetGenerateResourcePlanResultHeaders();
            return GetGenerateResourcePlanResultWithOptions(namespace_, ticketId, headers, runtime);
        }

        /**
         * @summary 获取生成ResourcePlan异步操作的结果。
         *
         * @return GetGenerateResourcePlanResultResponse
         */
        public async Task<GetGenerateResourcePlanResultResponse> GetGenerateResourcePlanResultAsync(string namespace_, string ticketId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGenerateResourcePlanResultHeaders headers = new GetGenerateResourcePlanResultHeaders();
            return await GetGenerateResourcePlanResultWithOptionsAsync(namespace_, ticketId, headers, runtime);
        }

        /**
         * @summary get job
         *
         * @param headers GetJobHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobResponse
         */
        public GetJobResponse GetJobWithOptions(string namespace_, string jobId, GetJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary get job
         *
         * @param headers GetJobHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobResponse
         */
        public async Task<GetJobResponse> GetJobWithOptionsAsync(string namespace_, string jobId, GetJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary get job
         *
         * @return GetJobResponse
         */
        public GetJobResponse GetJob(string namespace_, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobHeaders headers = new GetJobHeaders();
            return GetJobWithOptions(namespace_, jobId, headers, runtime);
        }

        /**
         * @summary get job
         *
         * @return GetJobResponse
         */
        public async Task<GetJobResponse> GetJobAsync(string namespace_, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobHeaders headers = new GetJobHeaders();
            return await GetJobWithOptionsAsync(namespace_, jobId, headers, runtime);
        }

        /**
         * @summary 调用GetMember获取成员。
         *
         * @param headers GetMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMemberResponse
         */
        public GetMemberResponse GetMemberWithOptions(string namespace_, string member, GetMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(member),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用GetMember获取成员。
         *
         * @param headers GetMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMemberResponse
         */
        public async Task<GetMemberResponse> GetMemberWithOptionsAsync(string namespace_, string member, GetMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(member),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用GetMember获取成员。
         *
         * @return GetMemberResponse
         */
        public GetMemberResponse GetMember(string namespace_, string member)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMemberHeaders headers = new GetMemberHeaders();
            return GetMemberWithOptions(namespace_, member, headers, runtime);
        }

        /**
         * @summary 调用GetMember获取成员。
         *
         * @return GetMemberResponse
         */
        public async Task<GetMemberResponse> GetMemberAsync(string namespace_, string member)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMemberHeaders headers = new GetMemberHeaders();
            return await GetMemberWithOptionsAsync(namespace_, member, headers, runtime);
        }

        /**
         * @summary 调用GetSavepoint获取savepoint信息。
         *
         * @param headers GetSavepointHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSavepointResponse
         */
        public GetSavepointResponse GetSavepointWithOptions(string namespace_, string savepointId, GetSavepointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSavepoint",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(savepointId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSavepointResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用GetSavepoint获取savepoint信息。
         *
         * @param headers GetSavepointHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSavepointResponse
         */
        public async Task<GetSavepointResponse> GetSavepointWithOptionsAsync(string namespace_, string savepointId, GetSavepointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSavepoint",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(savepointId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSavepointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用GetSavepoint获取savepoint信息。
         *
         * @return GetSavepointResponse
         */
        public GetSavepointResponse GetSavepoint(string namespace_, string savepointId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSavepointHeaders headers = new GetSavepointHeaders();
            return GetSavepointWithOptions(namespace_, savepointId, headers, runtime);
        }

        /**
         * @summary 调用GetSavepoint获取savepoint信息。
         *
         * @return GetSavepointResponse
         */
        public async Task<GetSavepointResponse> GetSavepointAsync(string namespace_, string savepointId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSavepointHeaders headers = new GetSavepointHeaders();
            return await GetSavepointWithOptionsAsync(namespace_, savepointId, headers, runtime);
        }

        /**
         * @summary list deployment targets
         *
         * @param request ListDeploymentTargetsRequest
         * @param headers ListDeploymentTargetsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeploymentTargetsResponse
         */
        public ListDeploymentTargetsResponse ListDeploymentTargetsWithOptions(string namespace_, ListDeploymentTargetsRequest request, ListDeploymentTargetsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeploymentTargets",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-targets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentTargetsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary list deployment targets
         *
         * @param request ListDeploymentTargetsRequest
         * @param headers ListDeploymentTargetsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeploymentTargetsResponse
         */
        public async Task<ListDeploymentTargetsResponse> ListDeploymentTargetsWithOptionsAsync(string namespace_, ListDeploymentTargetsRequest request, ListDeploymentTargetsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeploymentTargets",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-targets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentTargetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary list deployment targets
         *
         * @param request ListDeploymentTargetsRequest
         * @return ListDeploymentTargetsResponse
         */
        public ListDeploymentTargetsResponse ListDeploymentTargets(string namespace_, ListDeploymentTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeploymentTargetsHeaders headers = new ListDeploymentTargetsHeaders();
            return ListDeploymentTargetsWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary list deployment targets
         *
         * @param request ListDeploymentTargetsRequest
         * @return ListDeploymentTargetsResponse
         */
        public async Task<ListDeploymentTargetsResponse> ListDeploymentTargetsAsync(string namespace_, ListDeploymentTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeploymentTargetsHeaders headers = new ListDeploymentTargetsHeaders();
            return await ListDeploymentTargetsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary list deployments
         *
         * @param request ListDeploymentsRequest
         * @param headers ListDeploymentsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeploymentsResponse
         */
        public ListDeploymentsResponse ListDeploymentsWithOptions(string namespace_, ListDeploymentsRequest request, ListDeploymentsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionMode))
            {
                query["executionMode"] = request.ExecutionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelKey))
            {
                query["labelKey"] = request.LabelKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelValueArray))
            {
                query["labelValueArray"] = request.LabelValueArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Modifier))
            {
                query["modifier"] = request.Modifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeployments",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary list deployments
         *
         * @param request ListDeploymentsRequest
         * @param headers ListDeploymentsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeploymentsResponse
         */
        public async Task<ListDeploymentsResponse> ListDeploymentsWithOptionsAsync(string namespace_, ListDeploymentsRequest request, ListDeploymentsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionMode))
            {
                query["executionMode"] = request.ExecutionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelKey))
            {
                query["labelKey"] = request.LabelKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelValueArray))
            {
                query["labelValueArray"] = request.LabelValueArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Modifier))
            {
                query["modifier"] = request.Modifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeployments",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary list deployments
         *
         * @param request ListDeploymentsRequest
         * @return ListDeploymentsResponse
         */
        public ListDeploymentsResponse ListDeployments(string namespace_, ListDeploymentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeploymentsHeaders headers = new ListDeploymentsHeaders();
            return ListDeploymentsWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary list deployments
         *
         * @param request ListDeploymentsRequest
         * @return ListDeploymentsResponse
         */
        public async Task<ListDeploymentsResponse> ListDeploymentsAsync(string namespace_, ListDeploymentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeploymentsHeaders headers = new ListDeploymentsHeaders();
            return await ListDeploymentsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary 列出有编辑权限的项目空间。
         *
         * @param request ListEditableNamespaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEditableNamespaceResponse
         */
        public ListEditableNamespaceResponse ListEditableNamespaceWithOptions(ListEditableNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEditableNamespace",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/editable",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEditableNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列出有编辑权限的项目空间。
         *
         * @param request ListEditableNamespaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEditableNamespaceResponse
         */
        public async Task<ListEditableNamespaceResponse> ListEditableNamespaceWithOptionsAsync(ListEditableNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEditableNamespace",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/editable",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEditableNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列出有编辑权限的项目空间。
         *
         * @param request ListEditableNamespaceRequest
         * @return ListEditableNamespaceResponse
         */
        public ListEditableNamespaceResponse ListEditableNamespace(ListEditableNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEditableNamespaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 列出有编辑权限的项目空间。
         *
         * @param request ListEditableNamespaceRequest
         * @return ListEditableNamespaceResponse
         */
        public async Task<ListEditableNamespaceResponse> ListEditableNamespaceAsync(ListEditableNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEditableNamespaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取系统支持的引擎版本信息。
         *
         * @param headers ListEngineVersionMetadataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEngineVersionMetadataResponse
         */
        public ListEngineVersionMetadataResponse ListEngineVersionMetadataWithOptions(ListEngineVersionMetadataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEngineVersionMetadata",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/engine-version-meta.json",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEngineVersionMetadataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取系统支持的引擎版本信息。
         *
         * @param headers ListEngineVersionMetadataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEngineVersionMetadataResponse
         */
        public async Task<ListEngineVersionMetadataResponse> ListEngineVersionMetadataWithOptionsAsync(ListEngineVersionMetadataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEngineVersionMetadata",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/engine-version-meta.json",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEngineVersionMetadataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取系统支持的引擎版本信息。
         *
         * @return ListEngineVersionMetadataResponse
         */
        public ListEngineVersionMetadataResponse ListEngineVersionMetadata()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEngineVersionMetadataHeaders headers = new ListEngineVersionMetadataHeaders();
            return ListEngineVersionMetadataWithOptions(headers, runtime);
        }

        /**
         * @summary 获取系统支持的引擎版本信息。
         *
         * @return ListEngineVersionMetadataResponse
         */
        public async Task<ListEngineVersionMetadataResponse> ListEngineVersionMetadataAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEngineVersionMetadataHeaders headers = new ListEngineVersionMetadataHeaders();
            return await ListEngineVersionMetadataWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary list jobs
         *
         * @param request ListJobsRequest
         * @param headers ListJobsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListJobsResponse
         */
        public ListJobsResponse ListJobsWithOptions(string namespace_, ListJobsRequest request, ListJobsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                query["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortName))
            {
                query["sortName"] = request.SortName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary list jobs
         *
         * @param request ListJobsRequest
         * @param headers ListJobsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListJobsResponse
         */
        public async Task<ListJobsResponse> ListJobsWithOptionsAsync(string namespace_, ListJobsRequest request, ListJobsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                query["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortName))
            {
                query["sortName"] = request.SortName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary list jobs
         *
         * @param request ListJobsRequest
         * @return ListJobsResponse
         */
        public ListJobsResponse ListJobs(string namespace_, ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListJobsHeaders headers = new ListJobsHeaders();
            return ListJobsWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary list jobs
         *
         * @param request ListJobsRequest
         * @return ListJobsResponse
         */
        public async Task<ListJobsResponse> ListJobsAsync(string namespace_, ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListJobsHeaders headers = new ListJobsHeaders();
            return await ListJobsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary 调用ListMembers接口获取成员列表。
         *
         * @param request ListMembersRequest
         * @param headers ListMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMembersResponse
         */
        public ListMembersResponse ListMembersWithOptions(string namespace_, ListMembersRequest request, ListMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMembers",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMembersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用ListMembers接口获取成员列表。
         *
         * @param request ListMembersRequest
         * @param headers ListMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMembersResponse
         */
        public async Task<ListMembersResponse> ListMembersWithOptionsAsync(string namespace_, ListMembersRequest request, ListMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMembers",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用ListMembers接口获取成员列表。
         *
         * @param request ListMembersRequest
         * @return ListMembersResponse
         */
        public ListMembersResponse ListMembers(string namespace_, ListMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMembersHeaders headers = new ListMembersHeaders();
            return ListMembersWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary 调用ListMembers接口获取成员列表。
         *
         * @param request ListMembersRequest
         * @return ListMembersResponse
         */
        public async Task<ListMembersResponse> ListMembersAsync(string namespace_, ListMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMembersHeaders headers = new ListMembersHeaders();
            return await ListMembersWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary 调用ListSavepoints获取满足查询条件的savepoint列表。
         *
         * @param request ListSavepointsRequest
         * @param headers ListSavepointsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSavepointsResponse
         */
        public ListSavepointsResponse ListSavepointsWithOptions(string namespace_, ListSavepointsRequest request, ListSavepointsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                query["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["jobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSavepoints",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSavepointsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用ListSavepoints获取满足查询条件的savepoint列表。
         *
         * @param request ListSavepointsRequest
         * @param headers ListSavepointsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSavepointsResponse
         */
        public async Task<ListSavepointsResponse> ListSavepointsWithOptionsAsync(string namespace_, ListSavepointsRequest request, ListSavepointsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                query["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["jobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSavepoints",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSavepointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用ListSavepoints获取满足查询条件的savepoint列表。
         *
         * @param request ListSavepointsRequest
         * @return ListSavepointsResponse
         */
        public ListSavepointsResponse ListSavepoints(string namespace_, ListSavepointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSavepointsHeaders headers = new ListSavepointsHeaders();
            return ListSavepointsWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary 调用ListSavepoints获取满足查询条件的savepoint列表。
         *
         * @param request ListSavepointsRequest
         * @return ListSavepointsResponse
         */
        public async Task<ListSavepointsResponse> ListSavepointsAsync(string namespace_, ListSavepointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSavepointsHeaders headers = new ListSavepointsHeaders();
            return await ListSavepointsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary list variables
         *
         * @param request ListVariablesRequest
         * @param headers ListVariablesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListVariablesResponse
         */
        public ListVariablesResponse ListVariablesWithOptions(string namespace_, ListVariablesRequest request, ListVariablesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVariables",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/variables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVariablesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary list variables
         *
         * @param request ListVariablesRequest
         * @param headers ListVariablesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListVariablesResponse
         */
        public async Task<ListVariablesResponse> ListVariablesWithOptionsAsync(string namespace_, ListVariablesRequest request, ListVariablesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVariables",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/variables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVariablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary list variables
         *
         * @param request ListVariablesRequest
         * @return ListVariablesResponse
         */
        public ListVariablesResponse ListVariables(string namespace_, ListVariablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListVariablesHeaders headers = new ListVariablesHeaders();
            return ListVariablesWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary list variables
         *
         * @param request ListVariablesRequest
         * @return ListVariablesResponse
         */
        public async Task<ListVariablesResponse> ListVariablesAsync(string namespace_, ListVariablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListVariablesHeaders headers = new ListVariablesHeaders();
            return await ListVariablesWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI StartJob is deprecated
         *
         * @summary start job
         *
         * @param request StartJobRequest
         * @param headers StartJobHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartJobResponse
         */
        // Deprecated
        public StartJobResponse StartJobWithOptions(string namespace_, StartJobRequest request, StartJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI StartJob is deprecated
         *
         * @summary start job
         *
         * @param request StartJobRequest
         * @param headers StartJobHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartJobResponse
         */
        // Deprecated
        public async Task<StartJobResponse> StartJobWithOptionsAsync(string namespace_, StartJobRequest request, StartJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI StartJob is deprecated
         *
         * @summary start job
         *
         * @param request StartJobRequest
         * @return StartJobResponse
         */
        // Deprecated
        public StartJobResponse StartJob(string namespace_, StartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartJobHeaders headers = new StartJobHeaders();
            return StartJobWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI StartJob is deprecated
         *
         * @summary start job
         *
         * @param request StartJobRequest
         * @return StartJobResponse
         */
        // Deprecated
        public async Task<StartJobResponse> StartJobAsync(string namespace_, StartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartJobHeaders headers = new StartJobHeaders();
            return await StartJobWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary 启动作业实例。
         *
         * @param request StartJobWithParamsRequest
         * @param headers StartJobWithParamsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartJobWithParamsResponse
         */
        public StartJobWithParamsResponse StartJobWithParamsWithOptions(string namespace_, StartJobWithParamsRequest request, StartJobWithParamsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartJobWithParams",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs%3Astart",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartJobWithParamsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 启动作业实例。
         *
         * @param request StartJobWithParamsRequest
         * @param headers StartJobWithParamsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartJobWithParamsResponse
         */
        public async Task<StartJobWithParamsResponse> StartJobWithParamsWithOptionsAsync(string namespace_, StartJobWithParamsRequest request, StartJobWithParamsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartJobWithParams",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs%3Astart",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartJobWithParamsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 启动作业实例。
         *
         * @param request StartJobWithParamsRequest
         * @return StartJobWithParamsResponse
         */
        public StartJobWithParamsResponse StartJobWithParams(string namespace_, StartJobWithParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartJobWithParamsHeaders headers = new StartJobWithParamsHeaders();
            return StartJobWithParamsWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary 启动作业实例。
         *
         * @param request StartJobWithParamsRequest
         * @return StartJobWithParamsResponse
         */
        public async Task<StartJobWithParamsResponse> StartJobWithParamsAsync(string namespace_, StartJobWithParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartJobWithParamsHeaders headers = new StartJobWithParamsHeaders();
            return await StartJobWithParamsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary 调用StopJob停止实例。
         *
         * @param request StopJobRequest
         * @param headers StopJobHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopJobResponse
         */
        public StopJobResponse StopJobWithOptions(string namespace_, string jobId, StopJobRequest request, StopJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "%3Astop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用StopJob停止实例。
         *
         * @param request StopJobRequest
         * @param headers StopJobHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopJobResponse
         */
        public async Task<StopJobResponse> StopJobWithOptionsAsync(string namespace_, string jobId, StopJobRequest request, StopJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "%3Astop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用StopJob停止实例。
         *
         * @param request StopJobRequest
         * @return StopJobResponse
         */
        public StopJobResponse StopJob(string namespace_, string jobId, StopJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopJobHeaders headers = new StopJobHeaders();
            return StopJobWithOptions(namespace_, jobId, request, headers, runtime);
        }

        /**
         * @summary 调用StopJob停止实例。
         *
         * @param request StopJobRequest
         * @return StopJobResponse
         */
        public async Task<StopJobResponse> StopJobAsync(string namespace_, string jobId, StopJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopJobHeaders headers = new StopJobHeaders();
            return await StopJobWithOptionsAsync(namespace_, jobId, request, headers, runtime);
        }

        /**
         * @summary update a deployment using patch
         *
         * @param request UpdateDeploymentRequest
         * @param headers UpdateDeploymentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDeploymentResponse
         */
        public UpdateDeploymentResponse UpdateDeploymentWithOptions(string namespace_, string deploymentId, UpdateDeploymentRequest request, UpdateDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeploymentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary update a deployment using patch
         *
         * @param request UpdateDeploymentRequest
         * @param headers UpdateDeploymentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDeploymentResponse
         */
        public async Task<UpdateDeploymentResponse> UpdateDeploymentWithOptionsAsync(string namespace_, string deploymentId, UpdateDeploymentRequest request, UpdateDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeploymentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary update a deployment using patch
         *
         * @param request UpdateDeploymentRequest
         * @return UpdateDeploymentResponse
         */
        public UpdateDeploymentResponse UpdateDeployment(string namespace_, string deploymentId, UpdateDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeploymentHeaders headers = new UpdateDeploymentHeaders();
            return UpdateDeploymentWithOptions(namespace_, deploymentId, request, headers, runtime);
        }

        /**
         * @summary update a deployment using patch
         *
         * @param request UpdateDeploymentRequest
         * @return UpdateDeploymentResponse
         */
        public async Task<UpdateDeploymentResponse> UpdateDeploymentAsync(string namespace_, string deploymentId, UpdateDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeploymentHeaders headers = new UpdateDeploymentHeaders();
            return await UpdateDeploymentWithOptionsAsync(namespace_, deploymentId, request, headers, runtime);
        }

        /**
         * @summary 调用UpdateMember更新成员。
         *
         * @param request UpdateMemberRequest
         * @param headers UpdateMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMemberResponse
         */
        public UpdateMemberResponse UpdateMemberWithOptions(string namespace_, UpdateMemberRequest request, UpdateMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用UpdateMember更新成员。
         *
         * @param request UpdateMemberRequest
         * @param headers UpdateMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMemberResponse
         */
        public async Task<UpdateMemberResponse> UpdateMemberWithOptionsAsync(string namespace_, UpdateMemberRequest request, UpdateMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用UpdateMember更新成员。
         *
         * @param request UpdateMemberRequest
         * @return UpdateMemberResponse
         */
        public UpdateMemberResponse UpdateMember(string namespace_, UpdateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMemberHeaders headers = new UpdateMemberHeaders();
            return UpdateMemberWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary 调用UpdateMember更新成员。
         *
         * @param request UpdateMemberRequest
         * @return UpdateMemberResponse
         */
        public async Task<UpdateMemberResponse> UpdateMemberAsync(string namespace_, UpdateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMemberHeaders headers = new UpdateMemberHeaders();
            return await UpdateMemberWithOptionsAsync(namespace_, request, headers, runtime);
        }

    }
}
