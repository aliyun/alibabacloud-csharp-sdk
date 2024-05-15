// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.OpenITag20220616.Models;

namespace AlibabaCloud.SDK.OpenITag20220616
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("openitag", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 增加结点任务人力
         *
         * @param request AddWorkNodeWorkforceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddWorkNodeWorkforceResponse
         */
        public AddWorkNodeWorkforceResponse AddWorkNodeWorkforceWithOptions(string TenantId, string TaskId, string WorkNodeId, AddWorkNodeWorkforceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["UserIds"] = request.UserIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWorkNodeWorkforce",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/worknodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkNodeId) + "/workforce",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWorkNodeWorkforceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 增加结点任务人力
         *
         * @param request AddWorkNodeWorkforceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddWorkNodeWorkforceResponse
         */
        public async Task<AddWorkNodeWorkforceResponse> AddWorkNodeWorkforceWithOptionsAsync(string TenantId, string TaskId, string WorkNodeId, AddWorkNodeWorkforceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["UserIds"] = request.UserIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWorkNodeWorkforce",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/worknodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkNodeId) + "/workforce",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWorkNodeWorkforceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 增加结点任务人力
         *
         * @param request AddWorkNodeWorkforceRequest
         * @return AddWorkNodeWorkforceResponse
         */
        public AddWorkNodeWorkforceResponse AddWorkNodeWorkforce(string TenantId, string TaskId, string WorkNodeId, AddWorkNodeWorkforceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddWorkNodeWorkforceWithOptions(TenantId, TaskId, WorkNodeId, request, headers, runtime);
        }

        /**
         * @summary 增加结点任务人力
         *
         * @param request AddWorkNodeWorkforceRequest
         * @return AddWorkNodeWorkforceResponse
         */
        public async Task<AddWorkNodeWorkforceResponse> AddWorkNodeWorkforceAsync(string TenantId, string TaskId, string WorkNodeId, AddWorkNodeWorkforceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddWorkNodeWorkforceWithOptionsAsync(TenantId, TaskId, WorkNodeId, request, headers, runtime);
        }

        /**
         * @summary 数据追加
         *
         * @param request AppendAllDataToTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AppendAllDataToTaskResponse
         */
        public AppendAllDataToTaskResponse AppendAllDataToTaskWithOptions(string TenantId, string TaskId, AppendAllDataToTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AppendAllDataToTask",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/appendAllDataToTask",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AppendAllDataToTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 数据追加
         *
         * @param request AppendAllDataToTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AppendAllDataToTaskResponse
         */
        public async Task<AppendAllDataToTaskResponse> AppendAllDataToTaskWithOptionsAsync(string TenantId, string TaskId, AppendAllDataToTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AppendAllDataToTask",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/appendAllDataToTask",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AppendAllDataToTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 数据追加
         *
         * @param request AppendAllDataToTaskRequest
         * @return AppendAllDataToTaskResponse
         */
        public AppendAllDataToTaskResponse AppendAllDataToTask(string TenantId, string TaskId, AppendAllDataToTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AppendAllDataToTaskWithOptions(TenantId, TaskId, request, headers, runtime);
        }

        /**
         * @summary 数据追加
         *
         * @param request AppendAllDataToTaskRequest
         * @return AppendAllDataToTaskResponse
         */
        public async Task<AppendAllDataToTaskResponse> AppendAllDataToTaskAsync(string TenantId, string TaskId, AppendAllDataToTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AppendAllDataToTaskWithOptionsAsync(TenantId, TaskId, request, headers, runtime);
        }

        /**
         * @summary 创建标注任务
         *
         * @param request CreateTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTaskResponse
         */
        public CreateTaskResponse CreateTaskWithOptions(string TenantId, CreateTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建标注任务
         *
         * @param request CreateTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTaskResponse
         */
        public async Task<CreateTaskResponse> CreateTaskWithOptionsAsync(string TenantId, CreateTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建标注任务
         *
         * @param request CreateTaskRequest
         * @return CreateTaskResponse
         */
        public CreateTaskResponse CreateTask(string TenantId, CreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTaskWithOptions(TenantId, request, headers, runtime);
        }

        /**
         * @summary 创建标注任务
         *
         * @param request CreateTaskRequest
         * @return CreateTaskResponse
         */
        public async Task<CreateTaskResponse> CreateTaskAsync(string TenantId, CreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTaskWithOptionsAsync(TenantId, request, headers, runtime);
        }

        /**
         * @summary 创建标注模版
         *
         * @param request CreateTemplateRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTemplateResponse
         */
        public CreateTemplateResponse CreateTemplateWithOptions(string TenantId, CreateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplate",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建标注模版
         *
         * @param request CreateTemplateRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTemplateResponse
         */
        public async Task<CreateTemplateResponse> CreateTemplateWithOptionsAsync(string TenantId, CreateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplate",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建标注模版
         *
         * @param request CreateTemplateRequest
         * @return CreateTemplateResponse
         */
        public CreateTemplateResponse CreateTemplate(string TenantId, CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTemplateWithOptions(TenantId, request, headers, runtime);
        }

        /**
         * @summary 创建标注模版
         *
         * @param request CreateTemplateRequest
         * @return CreateTemplateResponse
         */
        public async Task<CreateTemplateResponse> CreateTemplateAsync(string TenantId, CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTemplateWithOptionsAsync(TenantId, request, headers, runtime);
        }

        /**
         * @summary 创建租户内用户
         *
         * @param request CreateUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserResponse
         */
        public CreateUserResponse CreateUserWithOptions(string TenantId, CreateUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                body["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/users",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建租户内用户
         *
         * @param request CreateUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserResponse
         */
        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(string TenantId, CreateUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                body["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/users",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建租户内用户
         *
         * @param request CreateUserRequest
         * @return CreateUserResponse
         */
        public CreateUserResponse CreateUser(string TenantId, CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateUserWithOptions(TenantId, request, headers, runtime);
        }

        /**
         * @summary 创建租户内用户
         *
         * @param request CreateUserRequest
         * @return CreateUserResponse
         */
        public async Task<CreateUserResponse> CreateUserAsync(string TenantId, CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateUserWithOptionsAsync(TenantId, request, headers, runtime);
        }

        /**
         * @summary 删除任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTaskResponse
         */
        public DeleteTaskResponse DeleteTaskWithOptions(string TenantId, string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTask",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTaskResponse
         */
        public async Task<DeleteTaskResponse> DeleteTaskWithOptionsAsync(string TenantId, string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTask",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除任务
         *
         * @return DeleteTaskResponse
         */
        public DeleteTaskResponse DeleteTask(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTaskWithOptions(TenantId, TaskId, headers, runtime);
        }

        /**
         * @summary 删除任务
         *
         * @return DeleteTaskResponse
         */
        public async Task<DeleteTaskResponse> DeleteTaskAsync(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTaskWithOptionsAsync(TenantId, TaskId, headers, runtime);
        }

        /**
         * @summary 删除租户下的单个模板
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTemplateResponse
         */
        public DeleteTemplateResponse DeleteTemplateWithOptions(string TenantId, string TemplateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplate",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除租户下的单个模板
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTemplateResponse
         */
        public async Task<DeleteTemplateResponse> DeleteTemplateWithOptionsAsync(string TenantId, string TemplateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplate",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除租户下的单个模板
         *
         * @return DeleteTemplateResponse
         */
        public DeleteTemplateResponse DeleteTemplate(string TenantId, string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTemplateWithOptions(TenantId, TemplateId, headers, runtime);
        }

        /**
         * @summary 删除租户下的单个模板
         *
         * @return DeleteTemplateResponse
         */
        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(string TenantId, string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTemplateWithOptionsAsync(TenantId, TemplateId, headers, runtime);
        }

        /**
         * @summary 删除用户
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserResponse
         */
        public DeleteUserResponse DeleteUserWithOptions(string TenantId, string UserId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(UserId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除用户
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserResponse
         */
        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(string TenantId, string UserId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(UserId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除用户
         *
         * @return DeleteUserResponse
         */
        public DeleteUserResponse DeleteUser(string TenantId, string UserId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteUserWithOptions(TenantId, UserId, headers, runtime);
        }

        /**
         * @summary 删除用户
         *
         * @return DeleteUserResponse
         */
        public async Task<DeleteUserResponse> DeleteUserAsync(string TenantId, string UserId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteUserWithOptionsAsync(TenantId, UserId, headers, runtime);
        }

        /**
         * @summary 获取任务导出结果
         *
         * @param request ExportAnnotationsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportAnnotationsResponse
         */
        public ExportAnnotationsResponse ExportAnnotationsWithOptions(string TenantId, string TaskId, ExportAnnotationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssPath))
            {
                query["OssPath"] = request.OssPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterDataset))
            {
                query["RegisterDataset"] = request.RegisterDataset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportAnnotations",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/annotations/export",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportAnnotationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取任务导出结果
         *
         * @param request ExportAnnotationsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportAnnotationsResponse
         */
        public async Task<ExportAnnotationsResponse> ExportAnnotationsWithOptionsAsync(string TenantId, string TaskId, ExportAnnotationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssPath))
            {
                query["OssPath"] = request.OssPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterDataset))
            {
                query["RegisterDataset"] = request.RegisterDataset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportAnnotations",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/annotations/export",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportAnnotationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取任务导出结果
         *
         * @param request ExportAnnotationsRequest
         * @return ExportAnnotationsResponse
         */
        public ExportAnnotationsResponse ExportAnnotations(string TenantId, string TaskId, ExportAnnotationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExportAnnotationsWithOptions(TenantId, TaskId, request, headers, runtime);
        }

        /**
         * @summary 获取任务导出结果
         *
         * @param request ExportAnnotationsRequest
         * @return ExportAnnotationsResponse
         */
        public async Task<ExportAnnotationsResponse> ExportAnnotationsAsync(string TenantId, string TaskId, ExportAnnotationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExportAnnotationsWithOptionsAsync(TenantId, TaskId, request, headers, runtime);
        }

        /**
         * @summary 获取异步任务Job
         *
         * @param request GetJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobResponse
         */
        public GetJobResponse GetJobWithOptions(string TenantId, string JobId, GetJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJob",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取异步任务Job
         *
         * @param request GetJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobResponse
         */
        public async Task<GetJobResponse> GetJobWithOptionsAsync(string TenantId, string JobId, GetJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJob",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取异步任务Job
         *
         * @param request GetJobRequest
         * @return GetJobResponse
         */
        public GetJobResponse GetJob(string TenantId, string JobId, GetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetJobWithOptions(TenantId, JobId, request, headers, runtime);
        }

        /**
         * @summary 获取异步任务Job
         *
         * @param request GetJobRequest
         * @return GetJobResponse
         */
        public async Task<GetJobResponse> GetJobAsync(string TenantId, string JobId, GetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetJobWithOptionsAsync(TenantId, JobId, request, headers, runtime);
        }

        /**
         * @summary 获取单个子任务信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSubtaskResponse
         */
        public GetSubtaskResponse GetSubtaskWithOptions(string TenantId, string TaskID, string SubtaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubtask",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskID) + "/subtasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SubtaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubtaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取单个子任务信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSubtaskResponse
         */
        public async Task<GetSubtaskResponse> GetSubtaskWithOptionsAsync(string TenantId, string TaskID, string SubtaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubtask",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskID) + "/subtasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SubtaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubtaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取单个子任务信息
         *
         * @return GetSubtaskResponse
         */
        public GetSubtaskResponse GetSubtask(string TenantId, string TaskID, string SubtaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSubtaskWithOptions(TenantId, TaskID, SubtaskId, headers, runtime);
        }

        /**
         * @summary 获取单个子任务信息
         *
         * @return GetSubtaskResponse
         */
        public async Task<GetSubtaskResponse> GetSubtaskAsync(string TenantId, string TaskID, string SubtaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSubtaskWithOptionsAsync(TenantId, TaskID, SubtaskId, headers, runtime);
        }

        /**
         * @summary 获取子任务单个ITEM信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSubtaskItemResponse
         */
        public GetSubtaskItemResponse GetSubtaskItemWithOptions(string TenantId, string TaskId, string SubtaskId, string ItemId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubtaskItem",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/subtasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SubtaskId) + "/items/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ItemId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubtaskItemResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取子任务单个ITEM信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSubtaskItemResponse
         */
        public async Task<GetSubtaskItemResponse> GetSubtaskItemWithOptionsAsync(string TenantId, string TaskId, string SubtaskId, string ItemId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubtaskItem",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/subtasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SubtaskId) + "/items/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ItemId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubtaskItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取子任务单个ITEM信息
         *
         * @return GetSubtaskItemResponse
         */
        public GetSubtaskItemResponse GetSubtaskItem(string TenantId, string TaskId, string SubtaskId, string ItemId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSubtaskItemWithOptions(TenantId, TaskId, SubtaskId, ItemId, headers, runtime);
        }

        /**
         * @summary 获取子任务单个ITEM信息
         *
         * @return GetSubtaskItemResponse
         */
        public async Task<GetSubtaskItemResponse> GetSubtaskItemAsync(string TenantId, string TaskId, string SubtaskId, string ItemId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSubtaskItemWithOptionsAsync(TenantId, TaskId, SubtaskId, ItemId, headers, runtime);
        }

        /**
         * @summary 获取任务状态信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskResponse
         */
        public GetTaskResponse GetTaskWithOptions(string TenantId, string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTask",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取任务状态信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskResponse
         */
        public async Task<GetTaskResponse> GetTaskWithOptionsAsync(string TenantId, string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTask",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取任务状态信息
         *
         * @return GetTaskResponse
         */
        public GetTaskResponse GetTask(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskWithOptions(TenantId, TaskId, headers, runtime);
        }

        /**
         * @summary 获取任务状态信息
         *
         * @return GetTaskResponse
         */
        public async Task<GetTaskResponse> GetTaskAsync(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskWithOptionsAsync(TenantId, TaskId, headers, runtime);
        }

        /**
         * @summary 获取任务统计信息
         *
         * @param request GetTaskStatisticsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskStatisticsResponse
         */
        public GetTaskStatisticsResponse GetTaskStatisticsWithOptions(string TenantId, string TaskId, GetTaskStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatType))
            {
                query["StatType"] = request.StatType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskStatistics",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取任务统计信息
         *
         * @param request GetTaskStatisticsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskStatisticsResponse
         */
        public async Task<GetTaskStatisticsResponse> GetTaskStatisticsWithOptionsAsync(string TenantId, string TaskId, GetTaskStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatType))
            {
                query["StatType"] = request.StatType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskStatistics",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取任务统计信息
         *
         * @param request GetTaskStatisticsRequest
         * @return GetTaskStatisticsResponse
         */
        public GetTaskStatisticsResponse GetTaskStatistics(string TenantId, string TaskId, GetTaskStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskStatisticsWithOptions(TenantId, TaskId, request, headers, runtime);
        }

        /**
         * @summary 获取任务统计信息
         *
         * @param request GetTaskStatisticsRequest
         * @return GetTaskStatisticsResponse
         */
        public async Task<GetTaskStatisticsResponse> GetTaskStatisticsAsync(string TenantId, string TaskId, GetTaskStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskStatisticsWithOptionsAsync(TenantId, TaskId, request, headers, runtime);
        }

        /**
         * @summary 获取任务状态信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskStatusResponse
         */
        public GetTaskStatusResponse GetTaskStatusWithOptions(string TenantId, string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskStatus",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取任务状态信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskStatusResponse
         */
        public async Task<GetTaskStatusResponse> GetTaskStatusWithOptionsAsync(string TenantId, string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskStatus",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取任务状态信息
         *
         * @return GetTaskStatusResponse
         */
        public GetTaskStatusResponse GetTaskStatus(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskStatusWithOptions(TenantId, TaskId, headers, runtime);
        }

        /**
         * @summary 获取任务状态信息
         *
         * @return GetTaskStatusResponse
         */
        public async Task<GetTaskStatusResponse> GetTaskStatusAsync(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskStatusWithOptionsAsync(TenantId, TaskId, headers, runtime);
        }

        /**
         * @summary 获取任务模版信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskTemplateResponse
         */
        public GetTaskTemplateResponse GetTaskTemplateWithOptions(string TenantId, string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskTemplate",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/template",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取任务模版信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskTemplateResponse
         */
        public async Task<GetTaskTemplateResponse> GetTaskTemplateWithOptionsAsync(string TenantId, string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskTemplate",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/template",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取任务模版信息
         *
         * @return GetTaskTemplateResponse
         */
        public GetTaskTemplateResponse GetTaskTemplate(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskTemplateWithOptions(TenantId, TaskId, headers, runtime);
        }

        /**
         * @summary 获取任务模版信息
         *
         * @return GetTaskTemplateResponse
         */
        public async Task<GetTaskTemplateResponse> GetTaskTemplateAsync(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskTemplateWithOptionsAsync(TenantId, TaskId, headers, runtime);
        }

        /**
         * @summary 获取任务题目信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskTemplateQuestionsResponse
         */
        public GetTaskTemplateQuestionsResponse GetTaskTemplateQuestionsWithOptions(string TenantId, string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskTemplateQuestions",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/template/questions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskTemplateQuestionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取任务题目信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskTemplateQuestionsResponse
         */
        public async Task<GetTaskTemplateQuestionsResponse> GetTaskTemplateQuestionsWithOptionsAsync(string TenantId, string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskTemplateQuestions",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/template/questions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskTemplateQuestionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取任务题目信息
         *
         * @return GetTaskTemplateQuestionsResponse
         */
        public GetTaskTemplateQuestionsResponse GetTaskTemplateQuestions(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskTemplateQuestionsWithOptions(TenantId, TaskId, headers, runtime);
        }

        /**
         * @summary 获取任务题目信息
         *
         * @return GetTaskTemplateQuestionsResponse
         */
        public async Task<GetTaskTemplateQuestionsResponse> GetTaskTemplateQuestionsAsync(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskTemplateQuestionsWithOptionsAsync(TenantId, TaskId, headers, runtime);
        }

        /**
         * @summary 获取任务题目信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskTemplateViewsResponse
         */
        public GetTaskTemplateViewsResponse GetTaskTemplateViewsWithOptions(string TenantId, string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskTemplateViews",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/template/views",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskTemplateViewsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取任务题目信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskTemplateViewsResponse
         */
        public async Task<GetTaskTemplateViewsResponse> GetTaskTemplateViewsWithOptionsAsync(string TenantId, string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskTemplateViews",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/template/views",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskTemplateViewsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取任务题目信息
         *
         * @return GetTaskTemplateViewsResponse
         */
        public GetTaskTemplateViewsResponse GetTaskTemplateViews(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskTemplateViewsWithOptions(TenantId, TaskId, headers, runtime);
        }

        /**
         * @summary 获取任务题目信息
         *
         * @return GetTaskTemplateViewsResponse
         */
        public async Task<GetTaskTemplateViewsResponse> GetTaskTemplateViewsAsync(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskTemplateViewsWithOptionsAsync(TenantId, TaskId, headers, runtime);
        }

        /**
         * @summary 获取任务人力
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskWorkforceResponse
         */
        public GetTaskWorkforceResponse GetTaskWorkforceWithOptions(string TenantId, string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskWorkforce",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/workforce",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskWorkforceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取任务人力
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskWorkforceResponse
         */
        public async Task<GetTaskWorkforceResponse> GetTaskWorkforceWithOptionsAsync(string TenantId, string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskWorkforce",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/workforce",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskWorkforceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取任务人力
         *
         * @return GetTaskWorkforceResponse
         */
        public GetTaskWorkforceResponse GetTaskWorkforce(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskWorkforceWithOptions(TenantId, TaskId, headers, runtime);
        }

        /**
         * @summary 获取任务人力
         *
         * @return GetTaskWorkforceResponse
         */
        public async Task<GetTaskWorkforceResponse> GetTaskWorkforceAsync(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskWorkforceWithOptionsAsync(TenantId, TaskId, headers, runtime);
        }

        /**
         * @summary 获取任务人力统计信息
         *
         * @param request GetTaskWorkforceStatisticRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskWorkforceStatisticResponse
         */
        public GetTaskWorkforceStatisticResponse GetTaskWorkforceStatisticWithOptions(string TenantId, string TaskId, GetTaskWorkforceStatisticRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatType))
            {
                query["StatType"] = request.StatType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskWorkforceStatistic",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/workforce/statistic",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskWorkforceStatisticResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取任务人力统计信息
         *
         * @param request GetTaskWorkforceStatisticRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskWorkforceStatisticResponse
         */
        public async Task<GetTaskWorkforceStatisticResponse> GetTaskWorkforceStatisticWithOptionsAsync(string TenantId, string TaskId, GetTaskWorkforceStatisticRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatType))
            {
                query["StatType"] = request.StatType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskWorkforceStatistic",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/workforce/statistic",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskWorkforceStatisticResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取任务人力统计信息
         *
         * @param request GetTaskWorkforceStatisticRequest
         * @return GetTaskWorkforceStatisticResponse
         */
        public GetTaskWorkforceStatisticResponse GetTaskWorkforceStatistic(string TenantId, string TaskId, GetTaskWorkforceStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskWorkforceStatisticWithOptions(TenantId, TaskId, request, headers, runtime);
        }

        /**
         * @summary 获取任务人力统计信息
         *
         * @param request GetTaskWorkforceStatisticRequest
         * @return GetTaskWorkforceStatisticResponse
         */
        public async Task<GetTaskWorkforceStatisticResponse> GetTaskWorkforceStatisticAsync(string TenantId, string TaskId, GetTaskWorkforceStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskWorkforceStatisticWithOptionsAsync(TenantId, TaskId, request, headers, runtime);
        }

        /**
         * @summary 获取租户下单个模板
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTemplateResponse
         */
        public GetTemplateResponse GetTemplateWithOptions(string TenantId, string TemplateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplate",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取租户下单个模板
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTemplateResponse
         */
        public async Task<GetTemplateResponse> GetTemplateWithOptionsAsync(string TenantId, string TemplateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplate",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取租户下单个模板
         *
         * @return GetTemplateResponse
         */
        public GetTemplateResponse GetTemplate(string TenantId, string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTemplateWithOptions(TenantId, TemplateId, headers, runtime);
        }

        /**
         * @summary 获取租户下单个模板
         *
         * @return GetTemplateResponse
         */
        public async Task<GetTemplateResponse> GetTemplateAsync(string TenantId, string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTemplateWithOptionsAsync(TenantId, TemplateId, headers, runtime);
        }

        /**
         * @summary 获取租户下单个模板问题
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTemplateQuestionsResponse
         */
        public GetTemplateQuestionsResponse GetTemplateQuestionsWithOptions(string TenantId, string TemplateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateQuestions",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId) + "/questions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateQuestionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取租户下单个模板问题
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTemplateQuestionsResponse
         */
        public async Task<GetTemplateQuestionsResponse> GetTemplateQuestionsWithOptionsAsync(string TenantId, string TemplateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateQuestions",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId) + "/questions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateQuestionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取租户下单个模板问题
         *
         * @return GetTemplateQuestionsResponse
         */
        public GetTemplateQuestionsResponse GetTemplateQuestions(string TenantId, string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTemplateQuestionsWithOptions(TenantId, TemplateId, headers, runtime);
        }

        /**
         * @summary 获取租户下单个模板问题
         *
         * @return GetTemplateQuestionsResponse
         */
        public async Task<GetTemplateQuestionsResponse> GetTemplateQuestionsAsync(string TenantId, string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTemplateQuestionsWithOptionsAsync(TenantId, TemplateId, headers, runtime);
        }

        /**
         * @summary 获取租户下模板视图
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTemplateViewResponse
         */
        public GetTemplateViewResponse GetTemplateViewWithOptions(string TenantId, string TemplateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateView",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId) + "/views",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateViewResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取租户下模板视图
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTemplateViewResponse
         */
        public async Task<GetTemplateViewResponse> GetTemplateViewWithOptionsAsync(string TenantId, string TemplateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateView",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId) + "/views",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateViewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取租户下模板视图
         *
         * @return GetTemplateViewResponse
         */
        public GetTemplateViewResponse GetTemplateView(string TenantId, string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTemplateViewWithOptions(TenantId, TemplateId, headers, runtime);
        }

        /**
         * @summary 获取租户下模板视图
         *
         * @return GetTemplateViewResponse
         */
        public async Task<GetTemplateViewResponse> GetTemplateViewAsync(string TenantId, string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTemplateViewWithOptionsAsync(TenantId, TemplateId, headers, runtime);
        }

        /**
         * @summary 获取租户信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTenantResponse
         */
        public GetTenantResponse GetTenantWithOptions(string TenantId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTenant",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTenantResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取租户信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTenantResponse
         */
        public async Task<GetTenantResponse> GetTenantWithOptionsAsync(string TenantId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTenant",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTenantResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取租户信息
         *
         * @return GetTenantResponse
         */
        public GetTenantResponse GetTenant(string TenantId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTenantWithOptions(TenantId, headers, runtime);
        }

        /**
         * @summary 获取租户信息
         *
         * @return GetTenantResponse
         */
        public async Task<GetTenantResponse> GetTenantAsync(string TenantId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTenantWithOptionsAsync(TenantId, headers, runtime);
        }

        /**
         * @summary 获取用户
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserResponse
         */
        public GetUserResponse GetUserWithOptions(string TenantId, string UserId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(UserId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取用户
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserResponse
         */
        public async Task<GetUserResponse> GetUserWithOptionsAsync(string TenantId, string UserId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(UserId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户
         *
         * @return GetUserResponse
         */
        public GetUserResponse GetUser(string TenantId, string UserId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserWithOptions(TenantId, UserId, headers, runtime);
        }

        /**
         * @summary 获取用户
         *
         * @return GetUserResponse
         */
        public async Task<GetUserResponse> GetUserAsync(string TenantId, string UserId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserWithOptionsAsync(TenantId, UserId, headers, runtime);
        }

        /**
         * @summary 获取异步任务Job列表
         *
         * @param request ListJobsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListJobsResponse
         */
        public ListJobsResponse ListJobsWithOptions(string TenantId, ListJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/jobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取异步任务Job列表
         *
         * @param request ListJobsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListJobsResponse
         */
        public async Task<ListJobsResponse> ListJobsWithOptionsAsync(string TenantId, ListJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/jobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取异步任务Job列表
         *
         * @param request ListJobsRequest
         * @return ListJobsResponse
         */
        public ListJobsResponse ListJobs(string TenantId, ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListJobsWithOptions(TenantId, request, headers, runtime);
        }

        /**
         * @summary 获取异步任务Job列表
         *
         * @param request ListJobsRequest
         * @return ListJobsResponse
         */
        public async Task<ListJobsResponse> ListJobsAsync(string TenantId, ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListJobsWithOptionsAsync(TenantId, request, headers, runtime);
        }

        /**
         * @summary 获取子任务ITEM列表页信息
         *
         * @param request ListSubtaskItemsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubtaskItemsResponse
         */
        public ListSubtaskItemsResponse ListSubtaskItemsWithOptions(string TenantId, string TaskID, string SubtaskId, ListSubtaskItemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubtaskItems",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskID) + "/subtasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SubtaskId) + "/items",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubtaskItemsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取子任务ITEM列表页信息
         *
         * @param request ListSubtaskItemsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubtaskItemsResponse
         */
        public async Task<ListSubtaskItemsResponse> ListSubtaskItemsWithOptionsAsync(string TenantId, string TaskID, string SubtaskId, ListSubtaskItemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubtaskItems",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskID) + "/subtasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SubtaskId) + "/items",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubtaskItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取子任务ITEM列表页信息
         *
         * @param request ListSubtaskItemsRequest
         * @return ListSubtaskItemsResponse
         */
        public ListSubtaskItemsResponse ListSubtaskItems(string TenantId, string TaskID, string SubtaskId, ListSubtaskItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSubtaskItemsWithOptions(TenantId, TaskID, SubtaskId, request, headers, runtime);
        }

        /**
         * @summary 获取子任务ITEM列表页信息
         *
         * @param request ListSubtaskItemsRequest
         * @return ListSubtaskItemsResponse
         */
        public async Task<ListSubtaskItemsResponse> ListSubtaskItemsAsync(string TenantId, string TaskID, string SubtaskId, ListSubtaskItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSubtaskItemsWithOptionsAsync(TenantId, TaskID, SubtaskId, request, headers, runtime);
        }

        /**
         * @summary 获取子任务列表页信息
         *
         * @param request ListSubtasksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubtasksResponse
         */
        public ListSubtasksResponse ListSubtasksWithOptions(string TenantId, string TaskID, ListSubtasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubtasks",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskID) + "/subtasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubtasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取子任务列表页信息
         *
         * @param request ListSubtasksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubtasksResponse
         */
        public async Task<ListSubtasksResponse> ListSubtasksWithOptionsAsync(string TenantId, string TaskID, ListSubtasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubtasks",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskID) + "/subtasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubtasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取子任务列表页信息
         *
         * @param request ListSubtasksRequest
         * @return ListSubtasksResponse
         */
        public ListSubtasksResponse ListSubtasks(string TenantId, string TaskID, ListSubtasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSubtasksWithOptions(TenantId, TaskID, request, headers, runtime);
        }

        /**
         * @summary 获取子任务列表页信息
         *
         * @param request ListSubtasksRequest
         * @return ListSubtasksResponse
         */
        public async Task<ListSubtasksResponse> ListSubtasksAsync(string TenantId, string TaskID, ListSubtasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSubtasksWithOptionsAsync(TenantId, TaskID, request, headers, runtime);
        }

        /**
         * @summary 获取任务列表页信息
         *
         * @param request ListTasksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTasksResponse
         */
        public ListTasksResponse ListTasksWithOptions(string TenantId, ListTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTasks",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取任务列表页信息
         *
         * @param request ListTasksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTasksResponse
         */
        public async Task<ListTasksResponse> ListTasksWithOptionsAsync(string TenantId, ListTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTasks",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取任务列表页信息
         *
         * @param request ListTasksRequest
         * @return ListTasksResponse
         */
        public ListTasksResponse ListTasks(string TenantId, ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTasksWithOptions(TenantId, request, headers, runtime);
        }

        /**
         * @summary 获取任务列表页信息
         *
         * @param request ListTasksRequest
         * @return ListTasksResponse
         */
        public async Task<ListTasksResponse> ListTasksAsync(string TenantId, ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTasksWithOptionsAsync(TenantId, request, headers, runtime);
        }

        /**
         * @summary 获取租户模板信息列表
         *
         * @param tmpReq ListTemplatesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTemplatesResponse
         */
        public ListTemplatesResponse ListTemplatesWithOptions(string TenantId, ListTemplatesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTemplatesShrinkRequest request = new ListTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Types))
            {
                request.TypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Types, "Types", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypesShrink))
            {
                query["Types"] = request.TypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplates",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取租户模板信息列表
         *
         * @param tmpReq ListTemplatesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTemplatesResponse
         */
        public async Task<ListTemplatesResponse> ListTemplatesWithOptionsAsync(string TenantId, ListTemplatesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTemplatesShrinkRequest request = new ListTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Types))
            {
                request.TypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Types, "Types", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypesShrink))
            {
                query["Types"] = request.TypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplates",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取租户模板信息列表
         *
         * @param request ListTemplatesRequest
         * @return ListTemplatesResponse
         */
        public ListTemplatesResponse ListTemplates(string TenantId, ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTemplatesWithOptions(TenantId, request, headers, runtime);
        }

        /**
         * @summary 获取租户模板信息列表
         *
         * @param request ListTemplatesRequest
         * @return ListTemplatesResponse
         */
        public async Task<ListTemplatesResponse> ListTemplatesAsync(string TenantId, ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTemplatesWithOptionsAsync(TenantId, request, headers, runtime);
        }

        /**
         * @summary 获取租户列表
         *
         * @param request ListTenantsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTenantsResponse
         */
        public ListTenantsResponse ListTenantsWithOptions(ListTenantsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTenants",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTenantsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取租户列表
         *
         * @param request ListTenantsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTenantsResponse
         */
        public async Task<ListTenantsResponse> ListTenantsWithOptionsAsync(ListTenantsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTenants",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTenantsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取租户列表
         *
         * @param request ListTenantsRequest
         * @return ListTenantsResponse
         */
        public ListTenantsResponse ListTenants(ListTenantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTenantsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取租户列表
         *
         * @param request ListTenantsRequest
         * @return ListTenantsResponse
         */
        public async Task<ListTenantsResponse> ListTenantsAsync(ListTenantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTenantsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取用户列表
         *
         * @param request ListUsersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersResponse
         */
        public ListUsersResponse ListUsersWithOptions(string TenantId, ListUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取用户列表
         *
         * @param request ListUsersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersResponse
         */
        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(string TenantId, ListUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户列表
         *
         * @param request ListUsersRequest
         * @return ListUsersResponse
         */
        public ListUsersResponse ListUsers(string TenantId, ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUsersWithOptions(TenantId, request, headers, runtime);
        }

        /**
         * @summary 获取用户列表
         *
         * @param request ListUsersRequest
         * @return ListUsersResponse
         */
        public async Task<ListUsersResponse> ListUsersAsync(string TenantId, ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUsersWithOptionsAsync(TenantId, request, headers, runtime);
        }

        /**
         * @summary 删除结点人力
         *
         * @param request RemoveWorkNodeWorkforceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveWorkNodeWorkforceResponse
         */
        public RemoveWorkNodeWorkforceResponse RemoveWorkNodeWorkforceWithOptions(string TenantId, string TaskId, string WorkNodeId, RemoveWorkNodeWorkforceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["UserIds"] = request.UserIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveWorkNodeWorkforce",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/worknodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkNodeId) + "/workforce",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveWorkNodeWorkforceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除结点人力
         *
         * @param request RemoveWorkNodeWorkforceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveWorkNodeWorkforceResponse
         */
        public async Task<RemoveWorkNodeWorkforceResponse> RemoveWorkNodeWorkforceWithOptionsAsync(string TenantId, string TaskId, string WorkNodeId, RemoveWorkNodeWorkforceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["UserIds"] = request.UserIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveWorkNodeWorkforce",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/worknodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkNodeId) + "/workforce",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveWorkNodeWorkforceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除结点人力
         *
         * @param request RemoveWorkNodeWorkforceRequest
         * @return RemoveWorkNodeWorkforceResponse
         */
        public RemoveWorkNodeWorkforceResponse RemoveWorkNodeWorkforce(string TenantId, string TaskId, string WorkNodeId, RemoveWorkNodeWorkforceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveWorkNodeWorkforceWithOptions(TenantId, TaskId, WorkNodeId, request, headers, runtime);
        }

        /**
         * @summary 删除结点人力
         *
         * @param request RemoveWorkNodeWorkforceRequest
         * @return RemoveWorkNodeWorkforceResponse
         */
        public async Task<RemoveWorkNodeWorkforceResponse> RemoveWorkNodeWorkforceAsync(string TenantId, string TaskId, string WorkNodeId, RemoveWorkNodeWorkforceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveWorkNodeWorkforceWithOptionsAsync(TenantId, TaskId, WorkNodeId, request, headers, runtime);
        }

        /**
         * @summary 更新标注任务基础信息
         *
         * @param request UpdateTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskResponse
         */
        public UpdateTaskResponse UpdateTaskWithOptions(string TenantId, string TaskId, UpdateTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTask",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新标注任务基础信息
         *
         * @param request UpdateTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskResponse
         */
        public async Task<UpdateTaskResponse> UpdateTaskWithOptionsAsync(string TenantId, string TaskId, UpdateTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTask",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新标注任务基础信息
         *
         * @param request UpdateTaskRequest
         * @return UpdateTaskResponse
         */
        public UpdateTaskResponse UpdateTask(string TenantId, string TaskId, UpdateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTaskWithOptions(TenantId, TaskId, request, headers, runtime);
        }

        /**
         * @summary 更新标注任务基础信息
         *
         * @param request UpdateTaskRequest
         * @return UpdateTaskResponse
         */
        public async Task<UpdateTaskResponse> UpdateTaskAsync(string TenantId, string TaskId, UpdateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTaskWithOptionsAsync(TenantId, TaskId, request, headers, runtime);
        }

        /**
         * @summary 更新任务人力
         *
         * @param request UpdateTaskWorkforceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskWorkforceResponse
         */
        public UpdateTaskWorkforceResponse UpdateTaskWorkforceWithOptions(string TenantId, string TaskId, UpdateTaskWorkforceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workforce))
            {
                body["Workforce"] = request.Workforce;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTaskWorkforce",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/workforce",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskWorkforceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新任务人力
         *
         * @param request UpdateTaskWorkforceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskWorkforceResponse
         */
        public async Task<UpdateTaskWorkforceResponse> UpdateTaskWorkforceWithOptionsAsync(string TenantId, string TaskId, UpdateTaskWorkforceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workforce))
            {
                body["Workforce"] = request.Workforce;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTaskWorkforce",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/workforce",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskWorkforceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新任务人力
         *
         * @param request UpdateTaskWorkforceRequest
         * @return UpdateTaskWorkforceResponse
         */
        public UpdateTaskWorkforceResponse UpdateTaskWorkforce(string TenantId, string TaskId, UpdateTaskWorkforceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTaskWorkforceWithOptions(TenantId, TaskId, request, headers, runtime);
        }

        /**
         * @summary 更新任务人力
         *
         * @param request UpdateTaskWorkforceRequest
         * @return UpdateTaskWorkforceResponse
         */
        public async Task<UpdateTaskWorkforceResponse> UpdateTaskWorkforceAsync(string TenantId, string TaskId, UpdateTaskWorkforceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTaskWorkforceWithOptionsAsync(TenantId, TaskId, request, headers, runtime);
        }

        /**
         * @summary 更新标注模版
         *
         * @param request UpdateTemplateRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTemplateResponse
         */
        public UpdateTemplateResponse UpdateTemplateWithOptions(string TenantId, string TemplateId, UpdateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTemplate",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新标注模版
         *
         * @param request UpdateTemplateRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTemplateResponse
         */
        public async Task<UpdateTemplateResponse> UpdateTemplateWithOptionsAsync(string TenantId, string TemplateId, UpdateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTemplate",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新标注模版
         *
         * @param request UpdateTemplateRequest
         * @return UpdateTemplateResponse
         */
        public UpdateTemplateResponse UpdateTemplate(string TenantId, string TemplateId, UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTemplateWithOptions(TenantId, TemplateId, request, headers, runtime);
        }

        /**
         * @summary 更新标注模版
         *
         * @param request UpdateTemplateRequest
         * @return UpdateTemplateResponse
         */
        public async Task<UpdateTemplateResponse> UpdateTemplateAsync(string TenantId, string TemplateId, UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTemplateWithOptionsAsync(TenantId, TemplateId, request, headers, runtime);
        }

        /**
         * @summary 更新租户信息
         *
         * @param request UpdateTenantRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTenantResponse
         */
        public UpdateTenantResponse UpdateTenantWithOptions(string TenantId, UpdateTenantRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantName))
            {
                body["TenantName"] = request.TenantName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTenant",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTenantResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新租户信息
         *
         * @param request UpdateTenantRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTenantResponse
         */
        public async Task<UpdateTenantResponse> UpdateTenantWithOptionsAsync(string TenantId, UpdateTenantRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantName))
            {
                body["TenantName"] = request.TenantName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTenant",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTenantResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新租户信息
         *
         * @param request UpdateTenantRequest
         * @return UpdateTenantResponse
         */
        public UpdateTenantResponse UpdateTenant(string TenantId, UpdateTenantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTenantWithOptions(TenantId, request, headers, runtime);
        }

        /**
         * @summary 更新租户信息
         *
         * @param request UpdateTenantRequest
         * @return UpdateTenantResponse
         */
        public async Task<UpdateTenantResponse> UpdateTenantAsync(string TenantId, UpdateTenantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTenantWithOptionsAsync(TenantId, request, headers, runtime);
        }

        /**
         * @summary 更新用户信息
         *
         * @param request UpdateUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserResponse
         */
        public UpdateUserResponse UpdateUserWithOptions(string TenantId, string UserId, UpdateUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(UserId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新用户信息
         *
         * @param request UpdateUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserResponse
         */
        public async Task<UpdateUserResponse> UpdateUserWithOptionsAsync(string TenantId, string UserId, UpdateUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/openapi/api/v1/tenants/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(UserId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新用户信息
         *
         * @param request UpdateUserRequest
         * @return UpdateUserResponse
         */
        public UpdateUserResponse UpdateUser(string TenantId, string UserId, UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateUserWithOptions(TenantId, UserId, request, headers, runtime);
        }

        /**
         * @summary 更新用户信息
         *
         * @param request UpdateUserRequest
         * @return UpdateUserResponse
         */
        public async Task<UpdateUserResponse> UpdateUserAsync(string TenantId, string UserId, UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateUserWithOptionsAsync(TenantId, UserId, request, headers, runtime);
        }

    }
}
