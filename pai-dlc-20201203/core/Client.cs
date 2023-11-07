// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Pai_dlc20201203.Models;

namespace AlibabaCloud.SDK.Pai_dlc20201203
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "pai-dlc.aliyuncs.com"},
                {"ap-northeast-2-pop", "pai-dlc.aliyuncs.com"},
                {"ap-south-1", "pai-dlc.aliyuncs.com"},
                {"ap-southeast-2", "pai-dlc.aliyuncs.com"},
                {"ap-southeast-3", "pai-dlc.aliyuncs.com"},
                {"ap-southeast-5", "pai-dlc.aliyuncs.com"},
                {"cn-beijing-finance-1", "pai-dlc.aliyuncs.com"},
                {"cn-beijing-finance-pop", "pai-dlc.aliyuncs.com"},
                {"cn-beijing-gov-1", "pai-dlc.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "pai-dlc.aliyuncs.com"},
                {"cn-chengdu", "pai-dlc.aliyuncs.com"},
                {"cn-edge-1", "pai-dlc.aliyuncs.com"},
                {"cn-fujian", "pai-dlc.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "pai-dlc.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "pai-dlc.aliyuncs.com"},
                {"cn-hangzhou-finance", "pai-dlc.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "pai-dlc.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "pai-dlc.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "pai-dlc.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "pai-dlc.aliyuncs.com"},
                {"cn-hangzhou-test-306", "pai-dlc.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "pai-dlc.aliyuncs.com"},
                {"cn-huhehaote", "pai-dlc.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "pai-dlc.aliyuncs.com"},
                {"cn-north-2-gov-1", "pai-dlc.aliyuncs.com"},
                {"cn-qingdao", "pai-dlc.aliyuncs.com"},
                {"cn-qingdao-nebula", "pai-dlc.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "pai-dlc.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "pai-dlc.aliyuncs.com"},
                {"cn-shanghai-inner", "pai-dlc.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "pai-dlc.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "pai-dlc.aliyuncs.com"},
                {"cn-shenzhen-inner", "pai-dlc.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "pai-dlc.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "pai-dlc.aliyuncs.com"},
                {"cn-wuhan", "pai-dlc.aliyuncs.com"},
                {"cn-wulanchabu", "pai-dlc.aliyuncs.com"},
                {"cn-yushanfang", "pai-dlc.aliyuncs.com"},
                {"cn-zhangbei", "pai-dlc.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "pai-dlc.aliyuncs.com"},
                {"cn-zhangjiakou", "pai-dlc.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "pai-dlc.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "pai-dlc.aliyuncs.com"},
                {"eu-west-1", "pai-dlc.aliyuncs.com"},
                {"eu-west-1-oxs", "pai-dlc.aliyuncs.com"},
                {"me-east-1", "pai-dlc.aliyuncs.com"},
                {"rus-west-1-pop", "pai-dlc.aliyuncs.com"},
                {"us-east-1", "pai-dlc.aliyuncs.com"},
                {"us-west-1", "pai-dlc.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("pai-dlc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateJobResponse CreateJobWithOptions(CreateJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeSource))
            {
                body["CodeSource"] = request.CodeSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSources))
            {
                body["DataSources"] = request.DataSources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebuggerConfigContent))
            {
                body["DebuggerConfigContent"] = request.DebuggerConfigContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticSpec))
            {
                body["ElasticSpec"] = request.ElasticSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                body["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobMaxRunningTimeMinutes))
            {
                body["JobMaxRunningTimeMinutes"] = request.JobMaxRunningTimeMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobSpecs))
            {
                body["JobSpecs"] = request.JobSpecs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                body["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Settings))
            {
                body["Settings"] = request.Settings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuccessPolicy))
            {
                body["SuccessPolicy"] = request.SuccessPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartyLibDir))
            {
                body["ThirdpartyLibDir"] = request.ThirdpartyLibDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartyLibs))
            {
                body["ThirdpartyLibs"] = request.ThirdpartyLibs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCommand))
            {
                body["UserCommand"] = request.UserCommand;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpc))
            {
                body["UserVpc"] = request.UserVpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJob",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateJobResponse> CreateJobWithOptionsAsync(CreateJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeSource))
            {
                body["CodeSource"] = request.CodeSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSources))
            {
                body["DataSources"] = request.DataSources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebuggerConfigContent))
            {
                body["DebuggerConfigContent"] = request.DebuggerConfigContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticSpec))
            {
                body["ElasticSpec"] = request.ElasticSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                body["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobMaxRunningTimeMinutes))
            {
                body["JobMaxRunningTimeMinutes"] = request.JobMaxRunningTimeMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobSpecs))
            {
                body["JobSpecs"] = request.JobSpecs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                body["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Settings))
            {
                body["Settings"] = request.Settings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuccessPolicy))
            {
                body["SuccessPolicy"] = request.SuccessPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartyLibDir))
            {
                body["ThirdpartyLibDir"] = request.ThirdpartyLibDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartyLibs))
            {
                body["ThirdpartyLibs"] = request.ThirdpartyLibs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCommand))
            {
                body["UserCommand"] = request.UserCommand;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpc))
            {
                body["UserVpc"] = request.UserVpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJob",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateJobResponse CreateJob(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateJobWithOptions(request, headers, runtime);
        }

        public async Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateJobWithOptionsAsync(request, headers, runtime);
        }

        public CreateTensorboardResponse CreateTensorboardWithOptions(CreateTensorboardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSources))
            {
                body["DataSources"] = request.DataSources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRunningTimeMinutes))
            {
                body["MaxRunningTimeMinutes"] = request.MaxRunningTimeMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                body["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryPath))
            {
                body["SummaryPath"] = request.SummaryPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryRelativePath))
            {
                body["SummaryRelativePath"] = request.SummaryRelativePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTensorboard",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tensorboards",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTensorboardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTensorboardResponse> CreateTensorboardWithOptionsAsync(CreateTensorboardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSources))
            {
                body["DataSources"] = request.DataSources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRunningTimeMinutes))
            {
                body["MaxRunningTimeMinutes"] = request.MaxRunningTimeMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                body["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryPath))
            {
                body["SummaryPath"] = request.SummaryPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryRelativePath))
            {
                body["SummaryRelativePath"] = request.SummaryRelativePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTensorboard",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tensorboards",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTensorboardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTensorboardResponse CreateTensorboard(CreateTensorboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTensorboardWithOptions(request, headers, runtime);
        }

        public async Task<CreateTensorboardResponse> CreateTensorboardAsync(CreateTensorboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTensorboardWithOptionsAsync(request, headers, runtime);
        }

        public DeleteJobResponse DeleteJobWithOptions(string JobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJob",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteJobResponse> DeleteJobWithOptionsAsync(string JobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJob",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteJobResponse DeleteJob(string JobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteJobWithOptions(JobId, headers, runtime);
        }

        public async Task<DeleteJobResponse> DeleteJobAsync(string JobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteJobWithOptionsAsync(JobId, headers, runtime);
        }

        public DeleteTensorboardResponse DeleteTensorboardWithOptions(string TensorboardId, DeleteTensorboardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTensorboard",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tensorboards/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TensorboardId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTensorboardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTensorboardResponse> DeleteTensorboardWithOptionsAsync(string TensorboardId, DeleteTensorboardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTensorboard",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tensorboards/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TensorboardId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTensorboardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTensorboardResponse DeleteTensorboard(string TensorboardId, DeleteTensorboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTensorboardWithOptions(TensorboardId, request, headers, runtime);
        }

        public async Task<DeleteTensorboardResponse> DeleteTensorboardAsync(string TensorboardId, DeleteTensorboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTensorboardWithOptionsAsync(TensorboardId, request, headers, runtime);
        }

        public GetJobResponse GetJobWithOptions(string JobId, GetJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedDetail))
            {
                query["NeedDetail"] = request.NeedDetail;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJob",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetJobResponse> GetJobWithOptionsAsync(string JobId, GetJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedDetail))
            {
                query["NeedDetail"] = request.NeedDetail;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJob",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetJobResponse GetJob(string JobId, GetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetJobWithOptions(JobId, request, headers, runtime);
        }

        public async Task<GetJobResponse> GetJobAsync(string JobId, GetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetJobWithOptionsAsync(JobId, request, headers, runtime);
        }

        public GetJobEventsResponse GetJobEventsWithOptions(string JobId, GetJobEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxEventsNum))
            {
                query["MaxEventsNum"] = request.MaxEventsNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobEvents",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId) + "/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobEventsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetJobEventsResponse> GetJobEventsWithOptionsAsync(string JobId, GetJobEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxEventsNum))
            {
                query["MaxEventsNum"] = request.MaxEventsNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobEvents",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId) + "/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetJobEventsResponse GetJobEvents(string JobId, GetJobEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetJobEventsWithOptions(JobId, request, headers, runtime);
        }

        public async Task<GetJobEventsResponse> GetJobEventsAsync(string JobId, GetJobEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetJobEventsWithOptionsAsync(JobId, request, headers, runtime);
        }

        public GetJobMetricsResponse GetJobMetricsWithOptions(string JobId, GetJobMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStep))
            {
                query["TimeStep"] = request.TimeStep;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobMetrics",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId) + "/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobMetricsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetJobMetricsResponse> GetJobMetricsWithOptionsAsync(string JobId, GetJobMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStep))
            {
                query["TimeStep"] = request.TimeStep;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobMetrics",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId) + "/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetJobMetricsResponse GetJobMetrics(string JobId, GetJobMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetJobMetricsWithOptions(JobId, request, headers, runtime);
        }

        public async Task<GetJobMetricsResponse> GetJobMetricsAsync(string JobId, GetJobMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetJobMetricsWithOptionsAsync(JobId, request, headers, runtime);
        }

        public GetPodEventsResponse GetPodEventsWithOptions(string JobId, string PodId, GetPodEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxEventsNum))
            {
                query["MaxEventsNum"] = request.MaxEventsNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PodUid))
            {
                query["PodUid"] = request.PodUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPodEvents",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId) + "/pods/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PodId) + "/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPodEventsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPodEventsResponse> GetPodEventsWithOptionsAsync(string JobId, string PodId, GetPodEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxEventsNum))
            {
                query["MaxEventsNum"] = request.MaxEventsNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PodUid))
            {
                query["PodUid"] = request.PodUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPodEvents",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId) + "/pods/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PodId) + "/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPodEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPodEventsResponse GetPodEvents(string JobId, string PodId, GetPodEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPodEventsWithOptions(JobId, PodId, request, headers, runtime);
        }

        public async Task<GetPodEventsResponse> GetPodEventsAsync(string JobId, string PodId, GetPodEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPodEventsWithOptionsAsync(JobId, PodId, request, headers, runtime);
        }

        public GetPodLogsResponse GetPodLogsWithOptions(string JobId, string PodId, GetPodLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadToFile))
            {
                query["DownloadToFile"] = request.DownloadToFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxLines))
            {
                query["MaxLines"] = request.MaxLines;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PodUid))
            {
                query["PodUid"] = request.PodUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPodLogs",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId) + "/pods/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PodId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPodLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPodLogsResponse> GetPodLogsWithOptionsAsync(string JobId, string PodId, GetPodLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadToFile))
            {
                query["DownloadToFile"] = request.DownloadToFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxLines))
            {
                query["MaxLines"] = request.MaxLines;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PodUid))
            {
                query["PodUid"] = request.PodUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPodLogs",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId) + "/pods/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PodId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPodLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPodLogsResponse GetPodLogs(string JobId, string PodId, GetPodLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPodLogsWithOptions(JobId, PodId, request, headers, runtime);
        }

        public async Task<GetPodLogsResponse> GetPodLogsAsync(string JobId, string PodId, GetPodLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPodLogsWithOptionsAsync(JobId, PodId, request, headers, runtime);
        }

        public GetTensorboardResponse GetTensorboardWithOptions(string TensorboardId, GetTensorboardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JodId))
            {
                query["JodId"] = request.JodId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTensorboard",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tensorboards/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TensorboardId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTensorboardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTensorboardResponse> GetTensorboardWithOptionsAsync(string TensorboardId, GetTensorboardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JodId))
            {
                query["JodId"] = request.JodId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTensorboard",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tensorboards/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TensorboardId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTensorboardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTensorboardResponse GetTensorboard(string TensorboardId, GetTensorboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTensorboardWithOptions(TensorboardId, request, headers, runtime);
        }

        public async Task<GetTensorboardResponse> GetTensorboardAsync(string TensorboardId, GetTensorboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTensorboardWithOptionsAsync(TensorboardId, request, headers, runtime);
        }

        public GetTensorboardSharedUrlResponse GetTensorboardSharedUrlWithOptions(string TensorboardId, GetTensorboardSharedUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTimeSeconds))
            {
                query["ExpireTimeSeconds"] = request.ExpireTimeSeconds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTensorboardSharedUrl",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tensorboards/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TensorboardId) + "/sharedurl",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTensorboardSharedUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTensorboardSharedUrlResponse> GetTensorboardSharedUrlWithOptionsAsync(string TensorboardId, GetTensorboardSharedUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTimeSeconds))
            {
                query["ExpireTimeSeconds"] = request.ExpireTimeSeconds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTensorboardSharedUrl",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tensorboards/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TensorboardId) + "/sharedurl",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTensorboardSharedUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTensorboardSharedUrlResponse GetTensorboardSharedUrl(string TensorboardId, GetTensorboardSharedUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTensorboardSharedUrlWithOptions(TensorboardId, request, headers, runtime);
        }

        public async Task<GetTensorboardSharedUrlResponse> GetTensorboardSharedUrlAsync(string TensorboardId, GetTensorboardSharedUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTensorboardSharedUrlWithOptionsAsync(TensorboardId, request, headers, runtime);
        }

        public GetTokenResponse GetTokenWithOptions(GetTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetToken",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tokens",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTokenResponse> GetTokenWithOptionsAsync(GetTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetToken",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tokens",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTokenResponse GetToken(GetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTokenWithOptions(request, headers, runtime);
        }

        public async Task<GetTokenResponse> GetTokenAsync(GetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTokenWithOptionsAsync(request, headers, runtime);
        }

        public GetWebTerminalResponse GetWebTerminalWithOptions(string JobId, string PodId, GetWebTerminalRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsShared))
            {
                query["IsShared"] = request.IsShared;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PodUid))
            {
                query["PodUid"] = request.PodUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWebTerminal",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId) + "/pods/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PodId) + "/webterminal",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWebTerminalResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetWebTerminalResponse> GetWebTerminalWithOptionsAsync(string JobId, string PodId, GetWebTerminalRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsShared))
            {
                query["IsShared"] = request.IsShared;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PodUid))
            {
                query["PodUid"] = request.PodUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWebTerminal",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId) + "/pods/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PodId) + "/webterminal",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWebTerminalResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetWebTerminalResponse GetWebTerminal(string JobId, string PodId, GetWebTerminalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWebTerminalWithOptions(JobId, PodId, request, headers, runtime);
        }

        public async Task<GetWebTerminalResponse> GetWebTerminalAsync(string JobId, string PodId, GetWebTerminalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWebTerminalWithOptionsAsync(JobId, PodId, request, headers, runtime);
        }

        public ListEcsSpecsResponse ListEcsSpecsWithOptions(ListEcsSpecsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceleratorType))
            {
                query["AcceleratorType"] = request.AcceleratorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEcsSpecs",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/ecsspecs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEcsSpecsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListEcsSpecsResponse> ListEcsSpecsWithOptionsAsync(ListEcsSpecsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceleratorType))
            {
                query["AcceleratorType"] = request.AcceleratorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEcsSpecs",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/ecsspecs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEcsSpecsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListEcsSpecsResponse ListEcsSpecs(ListEcsSpecsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEcsSpecsWithOptions(request, headers, runtime);
        }

        public async Task<ListEcsSpecsResponse> ListEcsSpecsAsync(ListEcsSpecsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEcsSpecsWithOptionsAsync(request, headers, runtime);
        }

        public ListJobsResponse ListJobsWithOptions(ListJobsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListJobsShrinkRequest request = new ListJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessUserId))
            {
                query["BusinessUserId"] = request.BusinessUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromAllWorkspaces))
            {
                query["FromAllWorkspaces"] = request.FromAllWorkspaces;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowOwn))
            {
                query["ShowOwn"] = request.ShowOwn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListJobsResponse> ListJobsWithOptionsAsync(ListJobsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListJobsShrinkRequest request = new ListJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessUserId))
            {
                query["BusinessUserId"] = request.BusinessUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromAllWorkspaces))
            {
                query["FromAllWorkspaces"] = request.FromAllWorkspaces;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowOwn))
            {
                query["ShowOwn"] = request.ShowOwn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListJobsResponse ListJobs(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListJobsWithOptions(request, headers, runtime);
        }

        public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListJobsWithOptionsAsync(request, headers, runtime);
        }

        public ListTensorboardsResponse ListTensorboardsWithOptions(ListTensorboardsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowOwn))
            {
                query["ShowOwn"] = request.ShowOwn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TensorboardId))
            {
                query["TensorboardId"] = request.TensorboardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTensorboards",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tensorboards",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTensorboardsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTensorboardsResponse> ListTensorboardsWithOptionsAsync(ListTensorboardsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowOwn))
            {
                query["ShowOwn"] = request.ShowOwn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TensorboardId))
            {
                query["TensorboardId"] = request.TensorboardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTensorboards",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tensorboards",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTensorboardsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTensorboardsResponse ListTensorboards(ListTensorboardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTensorboardsWithOptions(request, headers, runtime);
        }

        public async Task<ListTensorboardsResponse> ListTensorboardsAsync(ListTensorboardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTensorboardsWithOptionsAsync(request, headers, runtime);
        }

        public StartTensorboardResponse StartTensorboardWithOptions(string TensorboardId, StartTensorboardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartTensorboard",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tensorboards/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TensorboardId) + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartTensorboardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartTensorboardResponse> StartTensorboardWithOptionsAsync(string TensorboardId, StartTensorboardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartTensorboard",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tensorboards/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TensorboardId) + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartTensorboardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartTensorboardResponse StartTensorboard(string TensorboardId, StartTensorboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartTensorboardWithOptions(TensorboardId, request, headers, runtime);
        }

        public async Task<StartTensorboardResponse> StartTensorboardAsync(string TensorboardId, StartTensorboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartTensorboardWithOptionsAsync(TensorboardId, request, headers, runtime);
        }

        public StopJobResponse StopJobWithOptions(string JobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopJob",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId) + "/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopJobResponse> StopJobWithOptionsAsync(string JobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopJob",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId) + "/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopJobResponse StopJob(string JobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopJobWithOptions(JobId, headers, runtime);
        }

        public async Task<StopJobResponse> StopJobAsync(string JobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopJobWithOptionsAsync(JobId, headers, runtime);
        }

        public StopTensorboardResponse StopTensorboardWithOptions(string TensorboardId, StopTensorboardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopTensorboard",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tensorboards/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TensorboardId) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopTensorboardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopTensorboardResponse> StopTensorboardWithOptionsAsync(string TensorboardId, StopTensorboardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopTensorboard",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tensorboards/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TensorboardId) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopTensorboardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopTensorboardResponse StopTensorboard(string TensorboardId, StopTensorboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopTensorboardWithOptions(TensorboardId, request, headers, runtime);
        }

        public async Task<StopTensorboardResponse> StopTensorboardAsync(string TensorboardId, StopTensorboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopTensorboardWithOptionsAsync(TensorboardId, request, headers, runtime);
        }

        public UpdateJobResponse UpdateJobWithOptions(string JobId, UpdateJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateJob",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateJobResponse> UpdateJobWithOptionsAsync(string JobId, UpdateJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateJob",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateJobResponse UpdateJob(string JobId, UpdateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateJobWithOptions(JobId, request, headers, runtime);
        }

        public async Task<UpdateJobResponse> UpdateJobAsync(string JobId, UpdateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateJobWithOptionsAsync(JobId, request, headers, runtime);
        }

        public UpdateTensorboardResponse UpdateTensorboardWithOptions(string TensorboardId, UpdateTensorboardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRunningTimeMinutes))
            {
                query["MaxRunningTimeMinutes"] = request.MaxRunningTimeMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTensorboard",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tensorboards/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TensorboardId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTensorboardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTensorboardResponse> UpdateTensorboardWithOptionsAsync(string TensorboardId, UpdateTensorboardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRunningTimeMinutes))
            {
                query["MaxRunningTimeMinutes"] = request.MaxRunningTimeMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTensorboard",
                Version = "2020-12-03",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tensorboards/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TensorboardId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTensorboardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTensorboardResponse UpdateTensorboard(string TensorboardId, UpdateTensorboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTensorboardWithOptions(TensorboardId, request, headers, runtime);
        }

        public async Task<UpdateTensorboardResponse> UpdateTensorboardAsync(string TensorboardId, UpdateTensorboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTensorboardWithOptionsAsync(TensorboardId, request, headers, runtime);
        }

    }
}
