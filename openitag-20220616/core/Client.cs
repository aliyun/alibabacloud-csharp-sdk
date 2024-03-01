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

        public AddWorkNodeWorkforceResponse AddWorkNodeWorkforce(string TenantId, string TaskId, string WorkNodeId, AddWorkNodeWorkforceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddWorkNodeWorkforceWithOptions(TenantId, TaskId, WorkNodeId, request, headers, runtime);
        }

        public async Task<AddWorkNodeWorkforceResponse> AddWorkNodeWorkforceAsync(string TenantId, string TaskId, string WorkNodeId, AddWorkNodeWorkforceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddWorkNodeWorkforceWithOptionsAsync(TenantId, TaskId, WorkNodeId, request, headers, runtime);
        }

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

        public CreateTaskResponse CreateTask(string TenantId, CreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTaskWithOptions(TenantId, request, headers, runtime);
        }

        public async Task<CreateTaskResponse> CreateTaskAsync(string TenantId, CreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTaskWithOptionsAsync(TenantId, request, headers, runtime);
        }

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

        public CreateTemplateResponse CreateTemplate(string TenantId, CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTemplateWithOptions(TenantId, request, headers, runtime);
        }

        public async Task<CreateTemplateResponse> CreateTemplateAsync(string TenantId, CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTemplateWithOptionsAsync(TenantId, request, headers, runtime);
        }

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

        public CreateUserResponse CreateUser(string TenantId, CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateUserWithOptions(TenantId, request, headers, runtime);
        }

        public async Task<CreateUserResponse> CreateUserAsync(string TenantId, CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateUserWithOptionsAsync(TenantId, request, headers, runtime);
        }

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

        public DeleteTaskResponse DeleteTask(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTaskWithOptions(TenantId, TaskId, headers, runtime);
        }

        public async Task<DeleteTaskResponse> DeleteTaskAsync(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTaskWithOptionsAsync(TenantId, TaskId, headers, runtime);
        }

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

        public DeleteTemplateResponse DeleteTemplate(string TenantId, string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTemplateWithOptions(TenantId, TemplateId, headers, runtime);
        }

        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(string TenantId, string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTemplateWithOptionsAsync(TenantId, TemplateId, headers, runtime);
        }

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

        public DeleteUserResponse DeleteUser(string TenantId, string UserId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteUserWithOptions(TenantId, UserId, headers, runtime);
        }

        public async Task<DeleteUserResponse> DeleteUserAsync(string TenantId, string UserId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteUserWithOptionsAsync(TenantId, UserId, headers, runtime);
        }

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

        public ExportAnnotationsResponse ExportAnnotations(string TenantId, string TaskId, ExportAnnotationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExportAnnotationsWithOptions(TenantId, TaskId, request, headers, runtime);
        }

        public async Task<ExportAnnotationsResponse> ExportAnnotationsAsync(string TenantId, string TaskId, ExportAnnotationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExportAnnotationsWithOptionsAsync(TenantId, TaskId, request, headers, runtime);
        }

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

        public GetJobResponse GetJob(string TenantId, string JobId, GetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetJobWithOptions(TenantId, JobId, request, headers, runtime);
        }

        public async Task<GetJobResponse> GetJobAsync(string TenantId, string JobId, GetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetJobWithOptionsAsync(TenantId, JobId, request, headers, runtime);
        }

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

        public GetSubtaskResponse GetSubtask(string TenantId, string TaskID, string SubtaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSubtaskWithOptions(TenantId, TaskID, SubtaskId, headers, runtime);
        }

        public async Task<GetSubtaskResponse> GetSubtaskAsync(string TenantId, string TaskID, string SubtaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSubtaskWithOptionsAsync(TenantId, TaskID, SubtaskId, headers, runtime);
        }

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

        public GetSubtaskItemResponse GetSubtaskItem(string TenantId, string TaskId, string SubtaskId, string ItemId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSubtaskItemWithOptions(TenantId, TaskId, SubtaskId, ItemId, headers, runtime);
        }

        public async Task<GetSubtaskItemResponse> GetSubtaskItemAsync(string TenantId, string TaskId, string SubtaskId, string ItemId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSubtaskItemWithOptionsAsync(TenantId, TaskId, SubtaskId, ItemId, headers, runtime);
        }

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

        public GetTaskResponse GetTask(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskWithOptions(TenantId, TaskId, headers, runtime);
        }

        public async Task<GetTaskResponse> GetTaskAsync(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskWithOptionsAsync(TenantId, TaskId, headers, runtime);
        }

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

        public GetTaskStatisticsResponse GetTaskStatistics(string TenantId, string TaskId, GetTaskStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskStatisticsWithOptions(TenantId, TaskId, request, headers, runtime);
        }

        public async Task<GetTaskStatisticsResponse> GetTaskStatisticsAsync(string TenantId, string TaskId, GetTaskStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskStatisticsWithOptionsAsync(TenantId, TaskId, request, headers, runtime);
        }

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

        public GetTaskStatusResponse GetTaskStatus(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskStatusWithOptions(TenantId, TaskId, headers, runtime);
        }

        public async Task<GetTaskStatusResponse> GetTaskStatusAsync(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskStatusWithOptionsAsync(TenantId, TaskId, headers, runtime);
        }

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

        public GetTaskTemplateResponse GetTaskTemplate(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskTemplateWithOptions(TenantId, TaskId, headers, runtime);
        }

        public async Task<GetTaskTemplateResponse> GetTaskTemplateAsync(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskTemplateWithOptionsAsync(TenantId, TaskId, headers, runtime);
        }

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

        public GetTaskTemplateQuestionsResponse GetTaskTemplateQuestions(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskTemplateQuestionsWithOptions(TenantId, TaskId, headers, runtime);
        }

        public async Task<GetTaskTemplateQuestionsResponse> GetTaskTemplateQuestionsAsync(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskTemplateQuestionsWithOptionsAsync(TenantId, TaskId, headers, runtime);
        }

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

        public GetTaskTemplateViewsResponse GetTaskTemplateViews(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskTemplateViewsWithOptions(TenantId, TaskId, headers, runtime);
        }

        public async Task<GetTaskTemplateViewsResponse> GetTaskTemplateViewsAsync(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskTemplateViewsWithOptionsAsync(TenantId, TaskId, headers, runtime);
        }

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

        public GetTaskWorkforceResponse GetTaskWorkforce(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskWorkforceWithOptions(TenantId, TaskId, headers, runtime);
        }

        public async Task<GetTaskWorkforceResponse> GetTaskWorkforceAsync(string TenantId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskWorkforceWithOptionsAsync(TenantId, TaskId, headers, runtime);
        }

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

        public GetTaskWorkforceStatisticResponse GetTaskWorkforceStatistic(string TenantId, string TaskId, GetTaskWorkforceStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskWorkforceStatisticWithOptions(TenantId, TaskId, request, headers, runtime);
        }

        public async Task<GetTaskWorkforceStatisticResponse> GetTaskWorkforceStatisticAsync(string TenantId, string TaskId, GetTaskWorkforceStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskWorkforceStatisticWithOptionsAsync(TenantId, TaskId, request, headers, runtime);
        }

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

        public GetTemplateResponse GetTemplate(string TenantId, string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTemplateWithOptions(TenantId, TemplateId, headers, runtime);
        }

        public async Task<GetTemplateResponse> GetTemplateAsync(string TenantId, string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTemplateWithOptionsAsync(TenantId, TemplateId, headers, runtime);
        }

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

        public GetTemplateQuestionsResponse GetTemplateQuestions(string TenantId, string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTemplateQuestionsWithOptions(TenantId, TemplateId, headers, runtime);
        }

        public async Task<GetTemplateQuestionsResponse> GetTemplateQuestionsAsync(string TenantId, string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTemplateQuestionsWithOptionsAsync(TenantId, TemplateId, headers, runtime);
        }

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

        public GetTemplateViewResponse GetTemplateView(string TenantId, string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTemplateViewWithOptions(TenantId, TemplateId, headers, runtime);
        }

        public async Task<GetTemplateViewResponse> GetTemplateViewAsync(string TenantId, string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTemplateViewWithOptionsAsync(TenantId, TemplateId, headers, runtime);
        }

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

        public GetTenantResponse GetTenant(string TenantId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTenantWithOptions(TenantId, headers, runtime);
        }

        public async Task<GetTenantResponse> GetTenantAsync(string TenantId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTenantWithOptionsAsync(TenantId, headers, runtime);
        }

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

        public GetUserResponse GetUser(string TenantId, string UserId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserWithOptions(TenantId, UserId, headers, runtime);
        }

        public async Task<GetUserResponse> GetUserAsync(string TenantId, string UserId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserWithOptionsAsync(TenantId, UserId, headers, runtime);
        }

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

        public ListJobsResponse ListJobs(string TenantId, ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListJobsWithOptions(TenantId, request, headers, runtime);
        }

        public async Task<ListJobsResponse> ListJobsAsync(string TenantId, ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListJobsWithOptionsAsync(TenantId, request, headers, runtime);
        }

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

        public ListSubtaskItemsResponse ListSubtaskItems(string TenantId, string TaskID, string SubtaskId, ListSubtaskItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSubtaskItemsWithOptions(TenantId, TaskID, SubtaskId, request, headers, runtime);
        }

        public async Task<ListSubtaskItemsResponse> ListSubtaskItemsAsync(string TenantId, string TaskID, string SubtaskId, ListSubtaskItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSubtaskItemsWithOptionsAsync(TenantId, TaskID, SubtaskId, request, headers, runtime);
        }

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

        public ListSubtasksResponse ListSubtasks(string TenantId, string TaskID, ListSubtasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSubtasksWithOptions(TenantId, TaskID, request, headers, runtime);
        }

        public async Task<ListSubtasksResponse> ListSubtasksAsync(string TenantId, string TaskID, ListSubtasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSubtasksWithOptionsAsync(TenantId, TaskID, request, headers, runtime);
        }

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

        public ListTasksResponse ListTasks(string TenantId, ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTasksWithOptions(TenantId, request, headers, runtime);
        }

        public async Task<ListTasksResponse> ListTasksAsync(string TenantId, ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTasksWithOptionsAsync(TenantId, request, headers, runtime);
        }

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

        public ListTemplatesResponse ListTemplates(string TenantId, ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTemplatesWithOptions(TenantId, request, headers, runtime);
        }

        public async Task<ListTemplatesResponse> ListTemplatesAsync(string TenantId, ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTemplatesWithOptionsAsync(TenantId, request, headers, runtime);
        }

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

        public ListTenantsResponse ListTenants(ListTenantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTenantsWithOptions(request, headers, runtime);
        }

        public async Task<ListTenantsResponse> ListTenantsAsync(ListTenantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTenantsWithOptionsAsync(request, headers, runtime);
        }

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

        public ListUsersResponse ListUsers(string TenantId, ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUsersWithOptions(TenantId, request, headers, runtime);
        }

        public async Task<ListUsersResponse> ListUsersAsync(string TenantId, ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUsersWithOptionsAsync(TenantId, request, headers, runtime);
        }

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

        public RemoveWorkNodeWorkforceResponse RemoveWorkNodeWorkforce(string TenantId, string TaskId, string WorkNodeId, RemoveWorkNodeWorkforceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveWorkNodeWorkforceWithOptions(TenantId, TaskId, WorkNodeId, request, headers, runtime);
        }

        public async Task<RemoveWorkNodeWorkforceResponse> RemoveWorkNodeWorkforceAsync(string TenantId, string TaskId, string WorkNodeId, RemoveWorkNodeWorkforceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveWorkNodeWorkforceWithOptionsAsync(TenantId, TaskId, WorkNodeId, request, headers, runtime);
        }

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

        public UpdateTaskResponse UpdateTask(string TenantId, string TaskId, UpdateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTaskWithOptions(TenantId, TaskId, request, headers, runtime);
        }

        public async Task<UpdateTaskResponse> UpdateTaskAsync(string TenantId, string TaskId, UpdateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTaskWithOptionsAsync(TenantId, TaskId, request, headers, runtime);
        }

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

        public UpdateTaskWorkforceResponse UpdateTaskWorkforce(string TenantId, string TaskId, UpdateTaskWorkforceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTaskWorkforceWithOptions(TenantId, TaskId, request, headers, runtime);
        }

        public async Task<UpdateTaskWorkforceResponse> UpdateTaskWorkforceAsync(string TenantId, string TaskId, UpdateTaskWorkforceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTaskWorkforceWithOptionsAsync(TenantId, TaskId, request, headers, runtime);
        }

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

        public UpdateTemplateResponse UpdateTemplate(string TenantId, string TemplateId, UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTemplateWithOptions(TenantId, TemplateId, request, headers, runtime);
        }

        public async Task<UpdateTemplateResponse> UpdateTemplateAsync(string TenantId, string TemplateId, UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTemplateWithOptionsAsync(TenantId, TemplateId, request, headers, runtime);
        }

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

        public UpdateTenantResponse UpdateTenant(string TenantId, UpdateTenantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTenantWithOptions(TenantId, request, headers, runtime);
        }

        public async Task<UpdateTenantResponse> UpdateTenantAsync(string TenantId, UpdateTenantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTenantWithOptionsAsync(TenantId, request, headers, runtime);
        }

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

        public UpdateUserResponse UpdateUser(string TenantId, string UserId, UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateUserWithOptions(TenantId, UserId, request, headers, runtime);
        }

        public async Task<UpdateUserResponse> UpdateUserAsync(string TenantId, string UserId, UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateUserWithOptionsAsync(TenantId, UserId, request, headers, runtime);
        }

    }
}
