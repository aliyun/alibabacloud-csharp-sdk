// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.MaxCompute20220104.Models;

namespace AlibabaCloud.SDK.MaxCompute20220104
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "maxcompute.aliyuncs.com"},
                {"ap-northeast-2-pop", "maxcompute.aliyuncs.com"},
                {"ap-south-1", "maxcompute.aliyuncs.com"},
                {"ap-southeast-1", "maxcompute.aliyuncs.com"},
                {"ap-southeast-2", "maxcompute.aliyuncs.com"},
                {"ap-southeast-3", "maxcompute.aliyuncs.com"},
                {"ap-southeast-5", "maxcompute.aliyuncs.com"},
                {"cn-beijing", "maxcompute.aliyuncs.com"},
                {"cn-beijing-finance-1", "maxcompute.aliyuncs.com"},
                {"cn-beijing-finance-pop", "maxcompute.aliyuncs.com"},
                {"cn-beijing-gov-1", "maxcompute.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "maxcompute.aliyuncs.com"},
                {"cn-chengdu", "maxcompute.aliyuncs.com"},
                {"cn-edge-1", "maxcompute.aliyuncs.com"},
                {"cn-fujian", "maxcompute.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "maxcompute.aliyuncs.com"},
                {"cn-hangzhou", "maxcompute.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "maxcompute.aliyuncs.com"},
                {"cn-hangzhou-finance", "maxcompute.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "maxcompute.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "maxcompute.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "maxcompute.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "maxcompute.aliyuncs.com"},
                {"cn-hangzhou-test-306", "maxcompute.aliyuncs.com"},
                {"cn-hongkong", "maxcompute.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "maxcompute.aliyuncs.com"},
                {"cn-huhehaote", "maxcompute.aliyuncs.com"},
                {"cn-north-2-gov-1", "maxcompute.aliyuncs.com"},
                {"cn-qingdao", "maxcompute.aliyuncs.com"},
                {"cn-qingdao-nebula", "maxcompute.aliyuncs.com"},
                {"cn-shanghai", "maxcompute.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "maxcompute.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "maxcompute.aliyuncs.com"},
                {"cn-shanghai-finance-1", "maxcompute.aliyuncs.com"},
                {"cn-shanghai-inner", "maxcompute.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "maxcompute.aliyuncs.com"},
                {"cn-shenzhen", "maxcompute.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "maxcompute.aliyuncs.com"},
                {"cn-shenzhen-inner", "maxcompute.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "maxcompute.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "maxcompute.aliyuncs.com"},
                {"cn-wuhan", "maxcompute.aliyuncs.com"},
                {"cn-yushanfang", "maxcompute.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "maxcompute.aliyuncs.com"},
                {"cn-zhangjiakou", "maxcompute.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "maxcompute.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "maxcompute.aliyuncs.com"},
                {"eu-central-1", "maxcompute.aliyuncs.com"},
                {"eu-west-1", "maxcompute.aliyuncs.com"},
                {"eu-west-1-oxs", "maxcompute.aliyuncs.com"},
                {"me-east-1", "maxcompute.aliyuncs.com"},
                {"rus-west-1-pop", "maxcompute.aliyuncs.com"},
                {"us-east-1", "maxcompute.aliyuncs.com"},
                {"us-west-1", "maxcompute.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("maxcompute", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreatePackageResponse CreatePackageWithOptions(string projectName, CreatePackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsInstall))
            {
                query["isInstall"] = request.IsInstall;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePackage",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/packages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePackageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreatePackageResponse> CreatePackageWithOptionsAsync(string projectName, CreatePackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsInstall))
            {
                query["isInstall"] = request.IsInstall;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePackage",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/packages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreatePackageResponse CreatePackage(string projectName, CreatePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePackageWithOptions(projectName, request, headers, runtime);
        }

        public async Task<CreatePackageResponse> CreatePackageAsync(string projectName, CreatePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePackageWithOptionsAsync(projectName, request, headers, runtime);
        }

        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProjectWithOptions(request, headers, runtime);
        }

        public async Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProjectWithOptionsAsync(request, headers, runtime);
        }

        public CreateQuotaPlanResponse CreateQuotaPlanWithOptions(string nickname, CreateQuotaPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/plans",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQuotaPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateQuotaPlanResponse> CreateQuotaPlanWithOptionsAsync(string nickname, CreateQuotaPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/plans",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQuotaPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateQuotaPlanResponse CreateQuotaPlan(string nickname, CreateQuotaPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateQuotaPlanWithOptions(nickname, request, headers, runtime);
        }

        public async Task<CreateQuotaPlanResponse> CreateQuotaPlanAsync(string nickname, CreateQuotaPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateQuotaPlanWithOptionsAsync(nickname, request, headers, runtime);
        }

        public CreateQuotaScheduleResponse CreateQuotaScheduleWithOptions(string nickname, CreateQuotaScheduleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQuotaSchedule",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/schedule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQuotaScheduleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateQuotaScheduleResponse> CreateQuotaScheduleWithOptionsAsync(string nickname, CreateQuotaScheduleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQuotaSchedule",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/schedule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQuotaScheduleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateQuotaScheduleResponse CreateQuotaSchedule(string nickname, CreateQuotaScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateQuotaScheduleWithOptions(nickname, request, headers, runtime);
        }

        public async Task<CreateQuotaScheduleResponse> CreateQuotaScheduleAsync(string nickname, CreateQuotaScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateQuotaScheduleWithOptionsAsync(nickname, request, headers, runtime);
        }

        public CreateRoleResponse CreateRoleWithOptions(string projectName, CreateRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRole",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRoleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateRoleResponse> CreateRoleWithOptionsAsync(string projectName, CreateRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRole",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateRoleResponse CreateRole(string projectName, CreateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRoleWithOptions(projectName, request, headers, runtime);
        }

        public async Task<CreateRoleResponse> CreateRoleAsync(string projectName, CreateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRoleWithOptionsAsync(projectName, request, headers, runtime);
        }

        public DeleteQuotaPlanResponse DeleteQuotaPlanWithOptions(string nickname, string planName, DeleteQuotaPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(planName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQuotaPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteQuotaPlanResponse> DeleteQuotaPlanWithOptionsAsync(string nickname, string planName, DeleteQuotaPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(planName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQuotaPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteQuotaPlanResponse DeleteQuotaPlan(string nickname, string planName, DeleteQuotaPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteQuotaPlanWithOptions(nickname, planName, request, headers, runtime);
        }

        public async Task<DeleteQuotaPlanResponse> DeleteQuotaPlanAsync(string nickname, string planName, DeleteQuotaPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteQuotaPlanWithOptionsAsync(nickname, planName, request, headers, runtime);
        }

        public GetJobResourceUsageResponse GetJobResourceUsageWithOptions(GetJobResourceUsageRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetJobResourceUsageShrinkRequest request = new GetJobResourceUsageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobOwnerList))
            {
                request.JobOwnerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobOwnerList, "jobOwnerList", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QuotaNicknameList))
            {
                request.QuotaNicknameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QuotaNicknameList, "quotaNicknameList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["date"] = request.Date;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobOwnerListShrink))
            {
                query["jobOwnerList"] = request.JobOwnerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNicknameListShrink))
            {
                query["quotaNicknameList"] = request.QuotaNicknameListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobResourceUsage",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/resourceUsage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResourceUsageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetJobResourceUsageResponse> GetJobResourceUsageWithOptionsAsync(GetJobResourceUsageRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetJobResourceUsageShrinkRequest request = new GetJobResourceUsageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobOwnerList))
            {
                request.JobOwnerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobOwnerList, "jobOwnerList", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QuotaNicknameList))
            {
                request.QuotaNicknameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QuotaNicknameList, "quotaNicknameList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["date"] = request.Date;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobOwnerListShrink))
            {
                query["jobOwnerList"] = request.JobOwnerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNicknameListShrink))
            {
                query["quotaNicknameList"] = request.QuotaNicknameListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobResourceUsage",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/resourceUsage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResourceUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetJobResourceUsageResponse GetJobResourceUsage(GetJobResourceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetJobResourceUsageWithOptions(request, headers, runtime);
        }

        public async Task<GetJobResourceUsageResponse> GetJobResourceUsageAsync(GetJobResourceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetJobResourceUsageWithOptionsAsync(request, headers, runtime);
        }

        public GetPackageResponse GetPackageWithOptions(string projectName, string packageName, GetPackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProject))
            {
                query["sourceProject"] = request.SourceProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPackage",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/packages/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(packageName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPackageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPackageResponse> GetPackageWithOptionsAsync(string projectName, string packageName, GetPackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProject))
            {
                query["sourceProject"] = request.SourceProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPackage",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/packages/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(packageName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPackageResponse GetPackage(string projectName, string packageName, GetPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPackageWithOptions(projectName, packageName, request, headers, runtime);
        }

        public async Task<GetPackageResponse> GetPackageAsync(string projectName, string packageName, GetPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPackageWithOptionsAsync(projectName, packageName, request, headers, runtime);
        }

        public GetProjectResponse GetProjectWithOptions(string projectName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetProjectResponse> GetProjectWithOptionsAsync(string projectName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetProjectResponse GetProject(string projectName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProjectWithOptions(projectName, headers, runtime);
        }

        public async Task<GetProjectResponse> GetProjectAsync(string projectName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProjectWithOptionsAsync(projectName, headers, runtime);
        }

        public GetQuotaResponse GetQuotaWithOptions(string nickname, GetQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AkProven))
            {
                query["AkProven"] = request.AkProven;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mock))
            {
                query["mock"] = request.Mock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuota",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetQuotaResponse> GetQuotaWithOptionsAsync(string nickname, GetQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AkProven))
            {
                query["AkProven"] = request.AkProven;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mock))
            {
                query["mock"] = request.Mock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuota",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetQuotaResponse GetQuota(string nickname, GetQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetQuotaWithOptions(nickname, request, headers, runtime);
        }

        public async Task<GetQuotaResponse> GetQuotaAsync(string nickname, GetQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetQuotaWithOptionsAsync(nickname, request, headers, runtime);
        }

        public GetQuotaPlanResponse GetQuotaPlanWithOptions(string nickname, string planName, GetQuotaPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(planName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetQuotaPlanResponse> GetQuotaPlanWithOptionsAsync(string nickname, string planName, GetQuotaPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(planName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetQuotaPlanResponse GetQuotaPlan(string nickname, string planName, GetQuotaPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetQuotaPlanWithOptions(nickname, planName, request, headers, runtime);
        }

        public async Task<GetQuotaPlanResponse> GetQuotaPlanAsync(string nickname, string planName, GetQuotaPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetQuotaPlanWithOptionsAsync(nickname, planName, request, headers, runtime);
        }

        public GetQuotaScheduleResponse GetQuotaScheduleWithOptions(string nickname, GetQuotaScheduleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayTimezone))
            {
                query["displayTimezone"] = request.DisplayTimezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaSchedule",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/schedule",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaScheduleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetQuotaScheduleResponse> GetQuotaScheduleWithOptionsAsync(string nickname, GetQuotaScheduleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayTimezone))
            {
                query["displayTimezone"] = request.DisplayTimezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaSchedule",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/schedule",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaScheduleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetQuotaScheduleResponse GetQuotaSchedule(string nickname, GetQuotaScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetQuotaScheduleWithOptions(nickname, request, headers, runtime);
        }

        public async Task<GetQuotaScheduleResponse> GetQuotaScheduleAsync(string nickname, GetQuotaScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetQuotaScheduleWithOptionsAsync(nickname, request, headers, runtime);
        }

        public GetRoleAclResponse GetRoleAclWithOptions(string projectName, string roleName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRoleAcl",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleName) + "/roleAcl",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRoleAclResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRoleAclResponse> GetRoleAclWithOptionsAsync(string projectName, string roleName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRoleAcl",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleName) + "/roleAcl",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRoleAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRoleAclResponse GetRoleAcl(string projectName, string roleName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRoleAclWithOptions(projectName, roleName, headers, runtime);
        }

        public async Task<GetRoleAclResponse> GetRoleAclAsync(string projectName, string roleName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRoleAclWithOptionsAsync(projectName, roleName, headers, runtime);
        }

        public GetRoleAclOnObjectResponse GetRoleAclOnObjectWithOptions(string projectName, string roleName, GetRoleAclOnObjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectName))
            {
                query["objectName"] = request.ObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["objectType"] = request.ObjectType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRoleAclOnObject",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleName) + "/acl",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRoleAclOnObjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRoleAclOnObjectResponse> GetRoleAclOnObjectWithOptionsAsync(string projectName, string roleName, GetRoleAclOnObjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectName))
            {
                query["objectName"] = request.ObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["objectType"] = request.ObjectType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRoleAclOnObject",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleName) + "/acl",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRoleAclOnObjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRoleAclOnObjectResponse GetRoleAclOnObject(string projectName, string roleName, GetRoleAclOnObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRoleAclOnObjectWithOptions(projectName, roleName, request, headers, runtime);
        }

        public async Task<GetRoleAclOnObjectResponse> GetRoleAclOnObjectAsync(string projectName, string roleName, GetRoleAclOnObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRoleAclOnObjectWithOptionsAsync(projectName, roleName, request, headers, runtime);
        }

        public GetRolePolicyResponse GetRolePolicyWithOptions(string projectName, string roleName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRolePolicy",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleName) + "/policy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRolePolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRolePolicyResponse> GetRolePolicyWithOptionsAsync(string projectName, string roleName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRolePolicy",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleName) + "/policy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRolePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRolePolicyResponse GetRolePolicy(string projectName, string roleName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRolePolicyWithOptions(projectName, roleName, headers, runtime);
        }

        public async Task<GetRolePolicyResponse> GetRolePolicyAsync(string projectName, string roleName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRolePolicyWithOptionsAsync(projectName, roleName, headers, runtime);
        }

        public GetRunningJobsResponse GetRunningJobsWithOptions(GetRunningJobsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetRunningJobsShrinkRequest request = new GetRunningJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobOwnerList))
            {
                request.JobOwnerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobOwnerList, "jobOwnerList", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QuotaNicknameList))
            {
                request.QuotaNicknameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QuotaNicknameList, "quotaNicknameList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobOwnerListShrink))
            {
                query["jobOwnerList"] = request.JobOwnerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNicknameListShrink))
            {
                query["quotaNicknameList"] = request.QuotaNicknameListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["to"] = request.To;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRunningJobs",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/runningJobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRunningJobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRunningJobsResponse> GetRunningJobsWithOptionsAsync(GetRunningJobsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetRunningJobsShrinkRequest request = new GetRunningJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobOwnerList))
            {
                request.JobOwnerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobOwnerList, "jobOwnerList", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QuotaNicknameList))
            {
                request.QuotaNicknameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QuotaNicknameList, "quotaNicknameList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobOwnerListShrink))
            {
                query["jobOwnerList"] = request.JobOwnerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNicknameListShrink))
            {
                query["quotaNicknameList"] = request.QuotaNicknameListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["to"] = request.To;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRunningJobs",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/runningJobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRunningJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRunningJobsResponse GetRunningJobs(GetRunningJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRunningJobsWithOptions(request, headers, runtime);
        }

        public async Task<GetRunningJobsResponse> GetRunningJobsAsync(GetRunningJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRunningJobsWithOptionsAsync(request, headers, runtime);
        }

        public GetTrustedProjectsResponse GetTrustedProjectsWithOptions(string projectName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrustedProjects",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/trustedProjects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrustedProjectsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTrustedProjectsResponse> GetTrustedProjectsWithOptionsAsync(string projectName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrustedProjects",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/trustedProjects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrustedProjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTrustedProjectsResponse GetTrustedProjects(string projectName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTrustedProjectsWithOptions(projectName, headers, runtime);
        }

        public async Task<GetTrustedProjectsResponse> GetTrustedProjectsAsync(string projectName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTrustedProjectsWithOptionsAsync(projectName, headers, runtime);
        }

        public KillJobsResponse KillJobsWithOptions(KillJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillJobs",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/kill",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillJobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<KillJobsResponse> KillJobsWithOptionsAsync(KillJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillJobs",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/kill",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public KillJobsResponse KillJobs(KillJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return KillJobsWithOptions(request, headers, runtime);
        }

        public async Task<KillJobsResponse> KillJobsAsync(KillJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await KillJobsWithOptionsAsync(request, headers, runtime);
        }

        public ListFunctionsResponse ListFunctionsWithOptions(string projectName, ListFunctionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["maxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["schemaName"] = request.SchemaName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctions",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/functions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFunctionsResponse> ListFunctionsWithOptionsAsync(string projectName, ListFunctionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["maxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["schemaName"] = request.SchemaName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctions",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/functions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFunctionsResponse ListFunctions(string projectName, ListFunctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFunctionsWithOptions(projectName, request, headers, runtime);
        }

        public async Task<ListFunctionsResponse> ListFunctionsAsync(string projectName, ListFunctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFunctionsWithOptionsAsync(projectName, request, headers, runtime);
        }

        public ListPackagesResponse ListPackagesWithOptions(string projectName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPackages",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/packages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPackagesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPackagesResponse> ListPackagesWithOptionsAsync(string projectName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPackages",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/packages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPackagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPackagesResponse ListPackages(string projectName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPackagesWithOptions(projectName, headers, runtime);
        }

        public async Task<ListPackagesResponse> ListPackagesAsync(string projectName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPackagesWithOptionsAsync(projectName, headers, runtime);
        }

        public ListProjectUsersResponse ListProjectUsersWithOptions(string projectName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjectUsers",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectUsersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProjectUsersResponse> ListProjectUsersWithOptionsAsync(string projectName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjectUsers",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProjectUsersResponse ListProjectUsers(string projectName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProjectUsersWithOptions(projectName, headers, runtime);
        }

        public async Task<ListProjectUsersResponse> ListProjectUsersAsync(string projectName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProjectUsersWithOptionsAsync(projectName, headers, runtime);
        }

        public ListProjectsResponse ListProjectsWithOptions(ListProjectsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListSystemCatalog))
            {
                query["listSystemCatalog"] = request.ListSystemCatalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["maxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaName))
            {
                query["quotaName"] = request.QuotaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNickName))
            {
                query["quotaNickName"] = request.QuotaNickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleTags))
            {
                query["saleTags"] = request.SaleTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjects",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProjectsResponse> ListProjectsWithOptionsAsync(ListProjectsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListSystemCatalog))
            {
                query["listSystemCatalog"] = request.ListSystemCatalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["maxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaName))
            {
                query["quotaName"] = request.QuotaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNickName))
            {
                query["quotaNickName"] = request.QuotaNickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleTags))
            {
                query["saleTags"] = request.SaleTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjects",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProjectsWithOptions(request, headers, runtime);
        }

        public async Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProjectsWithOptionsAsync(request, headers, runtime);
        }

        public ListQuotasResponse ListQuotasWithOptions(ListQuotasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingType))
            {
                query["billingType"] = request.BillingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["maxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleTags))
            {
                query["saleTags"] = request.SaleTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotas",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotasResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListQuotasResponse> ListQuotasWithOptionsAsync(ListQuotasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingType))
            {
                query["billingType"] = request.BillingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["maxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleTags))
            {
                query["saleTags"] = request.SaleTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotas",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotasResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListQuotasResponse ListQuotas(ListQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListQuotasWithOptions(request, headers, runtime);
        }

        public async Task<ListQuotasResponse> ListQuotasAsync(ListQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListQuotasWithOptionsAsync(request, headers, runtime);
        }

        public ListQuotasPlansResponse ListQuotasPlansWithOptions(string nickname, ListQuotasPlansRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotasPlans",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/plans",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotasPlansResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListQuotasPlansResponse> ListQuotasPlansWithOptionsAsync(string nickname, ListQuotasPlansRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotasPlans",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/plans",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotasPlansResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListQuotasPlansResponse ListQuotasPlans(string nickname, ListQuotasPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListQuotasPlansWithOptions(nickname, request, headers, runtime);
        }

        public async Task<ListQuotasPlansResponse> ListQuotasPlansAsync(string nickname, ListQuotasPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListQuotasPlansWithOptionsAsync(nickname, request, headers, runtime);
        }

        public ListResourcesResponse ListResourcesWithOptions(string projectName, ListResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["maxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["schemaName"] = request.SchemaName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResources",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListResourcesResponse> ListResourcesWithOptionsAsync(string projectName, ListResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["maxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["schemaName"] = request.SchemaName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResources",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListResourcesResponse ListResources(string projectName, ListResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourcesWithOptions(projectName, request, headers, runtime);
        }

        public async Task<ListResourcesResponse> ListResourcesAsync(string projectName, ListResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourcesWithOptionsAsync(projectName, request, headers, runtime);
        }

        public ListRolesResponse ListRolesWithOptions(string projectName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoles",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRolesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRolesResponse> ListRolesWithOptionsAsync(string projectName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoles",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRolesResponse ListRoles(string projectName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRolesWithOptions(projectName, headers, runtime);
        }

        public async Task<ListRolesResponse> ListRolesAsync(string projectName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRolesWithOptionsAsync(projectName, headers, runtime);
        }

        public ListTablesResponse ListTablesWithOptions(string projectName, ListTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["maxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["schemaName"] = request.SchemaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTables",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTablesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTablesResponse> ListTablesWithOptionsAsync(string projectName, ListTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["maxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["schemaName"] = request.SchemaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTables",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTablesResponse ListTables(string projectName, ListTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTablesWithOptions(projectName, request, headers, runtime);
        }

        public async Task<ListTablesResponse> ListTablesAsync(string projectName, ListTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTablesWithOptionsAsync(projectName, request, headers, runtime);
        }

        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListUsers",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListUsers",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUsersWithOptions(request, headers, runtime);
        }

        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUsersWithOptionsAsync(request, headers, runtime);
        }

        public ListUsersByRoleResponse ListUsersByRoleWithOptions(string projectName, string roleName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsersByRole",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleName) + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersByRoleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListUsersByRoleResponse> ListUsersByRoleWithOptionsAsync(string projectName, string roleName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsersByRole",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleName) + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersByRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListUsersByRoleResponse ListUsersByRole(string projectName, string roleName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUsersByRoleWithOptions(projectName, roleName, headers, runtime);
        }

        public async Task<ListUsersByRoleResponse> ListUsersByRoleAsync(string projectName, string roleName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUsersByRoleWithOptionsAsync(projectName, roleName, headers, runtime);
        }

        public UpdatePackageResponse UpdatePackageWithOptions(string projectName, string packageName, UpdatePackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePackage",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/packages/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(packageName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePackageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdatePackageResponse> UpdatePackageWithOptionsAsync(string projectName, string packageName, UpdatePackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePackage",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/packages/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(packageName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdatePackageResponse UpdatePackage(string projectName, string packageName, UpdatePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePackageWithOptions(projectName, packageName, request, headers, runtime);
        }

        public async Task<UpdatePackageResponse> UpdatePackageAsync(string projectName, string packageName, UpdatePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePackageWithOptionsAsync(projectName, packageName, request, headers, runtime);
        }

        public UpdateProjectIpWhiteListResponse UpdateProjectIpWhiteListWithOptions(string projectName, UpdateProjectIpWhiteListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProjectIpWhiteList",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/ipWhiteList",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectIpWhiteListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateProjectIpWhiteListResponse> UpdateProjectIpWhiteListWithOptionsAsync(string projectName, UpdateProjectIpWhiteListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProjectIpWhiteList",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/ipWhiteList",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectIpWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateProjectIpWhiteListResponse UpdateProjectIpWhiteList(string projectName, UpdateProjectIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProjectIpWhiteListWithOptions(projectName, request, headers, runtime);
        }

        public async Task<UpdateProjectIpWhiteListResponse> UpdateProjectIpWhiteListAsync(string projectName, UpdateProjectIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProjectIpWhiteListWithOptionsAsync(projectName, request, headers, runtime);
        }

        public UpdateQuotaResponse UpdateQuotaWithOptions(string nickname, UpdateQuotaRequest request, UpdateQuotaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AkProven))
            {
                realHeaders["AkProven"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AkProven);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQuota",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQuotaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateQuotaResponse> UpdateQuotaWithOptionsAsync(string nickname, UpdateQuotaRequest request, UpdateQuotaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AkProven))
            {
                realHeaders["AkProven"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AkProven);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQuota",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateQuotaResponse UpdateQuota(string nickname, UpdateQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateQuotaHeaders headers = new UpdateQuotaHeaders();
            return UpdateQuotaWithOptions(nickname, request, headers, runtime);
        }

        public async Task<UpdateQuotaResponse> UpdateQuotaAsync(string nickname, UpdateQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateQuotaHeaders headers = new UpdateQuotaHeaders();
            return await UpdateQuotaWithOptionsAsync(nickname, request, headers, runtime);
        }

        public UpdateQuotaPlanResponse UpdateQuotaPlanWithOptions(string nickname, string planName, UpdateQuotaPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(planName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQuotaPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateQuotaPlanResponse> UpdateQuotaPlanWithOptionsAsync(string nickname, string planName, UpdateQuotaPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(planName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQuotaPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateQuotaPlanResponse UpdateQuotaPlan(string nickname, string planName, UpdateQuotaPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateQuotaPlanWithOptions(nickname, planName, request, headers, runtime);
        }

        public async Task<UpdateQuotaPlanResponse> UpdateQuotaPlanAsync(string nickname, string planName, UpdateQuotaPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateQuotaPlanWithOptionsAsync(nickname, planName, request, headers, runtime);
        }

        public UpdateQuotaScheduleResponse UpdateQuotaScheduleWithOptions(string nickname, UpdateQuotaScheduleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQuotaSchedule",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/schedule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQuotaScheduleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateQuotaScheduleResponse> UpdateQuotaScheduleWithOptionsAsync(string nickname, UpdateQuotaScheduleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQuotaSchedule",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/schedule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQuotaScheduleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateQuotaScheduleResponse UpdateQuotaSchedule(string nickname, UpdateQuotaScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateQuotaScheduleWithOptions(nickname, request, headers, runtime);
        }

        public async Task<UpdateQuotaScheduleResponse> UpdateQuotaScheduleAsync(string nickname, UpdateQuotaScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateQuotaScheduleWithOptionsAsync(nickname, request, headers, runtime);
        }

    }
}
