// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dbs20190306.Models;

namespace AlibabaCloud.SDK.Dbs20190306
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-beijing", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-chengdu", "dbs-api.cn-chengdu.aliyuncs.com"},
                {"cn-zhangjiakou", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-huhehaote", "dbs-api.cn-huhehaote.aliyuncs.com"},
                {"cn-hangzhou", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-shenzhen", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-hongkong", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"ap-southeast-1", "dbs-api.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "dbs-api.ap-southeast-2.aliyuncs.com"},
                {"ap-southeast-3", "dbs-api.ap-southeast-3.aliyuncs.com"},
                {"ap-southeast-5", "dbs-api.ap-southeast-5.aliyuncs.com"},
                {"ap-northeast-1", "dbs-api.ap-northeast-1.aliyuncs.com"},
                {"us-west-1", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"us-east-1", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"eu-central-1", "dbs-api.eu-central-1.aliyuncs.com"},
                {"cn-hangzhou-finance", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai-finance-1", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"ap-south-1", "dbs-api.ap-south-1.aliyuncs.com"},
                {"eu-west-1", "dbs-api.eu-west-1.aliyuncs.com"},
                {"me-east-1", "dbs-api.me-east-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("dbs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ConfigureBackupPlanResponse ConfigureBackupPlanWithOptions(ConfigureBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureBackupPlanResponse>(DoRPCRequest("ConfigureBackupPlan", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigureBackupPlanResponse> ConfigureBackupPlanWithOptionsAsync(ConfigureBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureBackupPlanResponse>(await DoRPCRequestAsync("ConfigureBackupPlan", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConfigureBackupPlanResponse ConfigureBackupPlan(ConfigureBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureBackupPlanWithOptions(request, runtime);
        }

        public async Task<ConfigureBackupPlanResponse> ConfigureBackupPlanAsync(ConfigureBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureBackupPlanWithOptionsAsync(request, runtime);
        }

        public CreateBackupPlanResponse CreateBackupPlanWithOptions(CreateBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBackupPlanResponse>(DoRPCRequest("CreateBackupPlan", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateBackupPlanResponse> CreateBackupPlanWithOptionsAsync(CreateBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBackupPlanResponse>(await DoRPCRequestAsync("CreateBackupPlan", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateBackupPlanResponse CreateBackupPlan(CreateBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBackupPlanWithOptions(request, runtime);
        }

        public async Task<CreateBackupPlanResponse> CreateBackupPlanAsync(CreateBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBackupPlanWithOptionsAsync(request, runtime);
        }

        public CreateFullBackupSetDownloadResponse CreateFullBackupSetDownloadWithOptions(CreateFullBackupSetDownloadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFullBackupSetDownloadResponse>(DoRPCRequest("CreateFullBackupSetDownload", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFullBackupSetDownloadResponse> CreateFullBackupSetDownloadWithOptionsAsync(CreateFullBackupSetDownloadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFullBackupSetDownloadResponse>(await DoRPCRequestAsync("CreateFullBackupSetDownload", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFullBackupSetDownloadResponse CreateFullBackupSetDownload(CreateFullBackupSetDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFullBackupSetDownloadWithOptions(request, runtime);
        }

        public async Task<CreateFullBackupSetDownloadResponse> CreateFullBackupSetDownloadAsync(CreateFullBackupSetDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFullBackupSetDownloadWithOptionsAsync(request, runtime);
        }

        public CreateGetDBListFromAgentTaskResponse CreateGetDBListFromAgentTaskWithOptions(CreateGetDBListFromAgentTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGetDBListFromAgentTaskResponse>(DoRPCRequest("CreateGetDBListFromAgentTask", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateGetDBListFromAgentTaskResponse> CreateGetDBListFromAgentTaskWithOptionsAsync(CreateGetDBListFromAgentTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGetDBListFromAgentTaskResponse>(await DoRPCRequestAsync("CreateGetDBListFromAgentTask", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateGetDBListFromAgentTaskResponse CreateGetDBListFromAgentTask(CreateGetDBListFromAgentTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGetDBListFromAgentTaskWithOptions(request, runtime);
        }

        public async Task<CreateGetDBListFromAgentTaskResponse> CreateGetDBListFromAgentTaskAsync(CreateGetDBListFromAgentTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGetDBListFromAgentTaskWithOptionsAsync(request, runtime);
        }

        public CreateIncrementBackupSetDownloadResponse CreateIncrementBackupSetDownloadWithOptions(CreateIncrementBackupSetDownloadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIncrementBackupSetDownloadResponse>(DoRPCRequest("CreateIncrementBackupSetDownload", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateIncrementBackupSetDownloadResponse> CreateIncrementBackupSetDownloadWithOptionsAsync(CreateIncrementBackupSetDownloadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIncrementBackupSetDownloadResponse>(await DoRPCRequestAsync("CreateIncrementBackupSetDownload", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateIncrementBackupSetDownloadResponse CreateIncrementBackupSetDownload(CreateIncrementBackupSetDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIncrementBackupSetDownloadWithOptions(request, runtime);
        }

        public async Task<CreateIncrementBackupSetDownloadResponse> CreateIncrementBackupSetDownloadAsync(CreateIncrementBackupSetDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIncrementBackupSetDownloadWithOptionsAsync(request, runtime);
        }

        public CreateRestoreTaskResponse CreateRestoreTaskWithOptions(CreateRestoreTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRestoreTaskResponse>(DoRPCRequest("CreateRestoreTask", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRestoreTaskResponse> CreateRestoreTaskWithOptionsAsync(CreateRestoreTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRestoreTaskResponse>(await DoRPCRequestAsync("CreateRestoreTask", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRestoreTaskResponse CreateRestoreTask(CreateRestoreTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRestoreTaskWithOptions(request, runtime);
        }

        public async Task<CreateRestoreTaskResponse> CreateRestoreTaskAsync(CreateRestoreTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRestoreTaskWithOptionsAsync(request, runtime);
        }

        public DescribeBackupGatewayListResponse DescribeBackupGatewayListWithOptions(DescribeBackupGatewayListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupGatewayListResponse>(DoRPCRequest("DescribeBackupGatewayList", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupGatewayListResponse> DescribeBackupGatewayListWithOptionsAsync(DescribeBackupGatewayListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupGatewayListResponse>(await DoRPCRequestAsync("DescribeBackupGatewayList", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackupGatewayListResponse DescribeBackupGatewayList(DescribeBackupGatewayListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupGatewayListWithOptions(request, runtime);
        }

        public async Task<DescribeBackupGatewayListResponse> DescribeBackupGatewayListAsync(DescribeBackupGatewayListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupGatewayListWithOptionsAsync(request, runtime);
        }

        public DescribeBackupPlanBillingResponse DescribeBackupPlanBillingWithOptions(DescribeBackupPlanBillingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPlanBillingResponse>(DoRPCRequest("DescribeBackupPlanBilling", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupPlanBillingResponse> DescribeBackupPlanBillingWithOptionsAsync(DescribeBackupPlanBillingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPlanBillingResponse>(await DoRPCRequestAsync("DescribeBackupPlanBilling", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackupPlanBillingResponse DescribeBackupPlanBilling(DescribeBackupPlanBillingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupPlanBillingWithOptions(request, runtime);
        }

        public async Task<DescribeBackupPlanBillingResponse> DescribeBackupPlanBillingAsync(DescribeBackupPlanBillingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupPlanBillingWithOptionsAsync(request, runtime);
        }

        public DescribeBackupPlanListResponse DescribeBackupPlanListWithOptions(DescribeBackupPlanListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPlanListResponse>(DoRPCRequest("DescribeBackupPlanList", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupPlanListResponse> DescribeBackupPlanListWithOptionsAsync(DescribeBackupPlanListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPlanListResponse>(await DoRPCRequestAsync("DescribeBackupPlanList", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackupPlanListResponse DescribeBackupPlanList(DescribeBackupPlanListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupPlanListWithOptions(request, runtime);
        }

        public async Task<DescribeBackupPlanListResponse> DescribeBackupPlanListAsync(DescribeBackupPlanListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupPlanListWithOptionsAsync(request, runtime);
        }

        public DescribeBackupSetDownloadTaskListResponse DescribeBackupSetDownloadTaskListWithOptions(DescribeBackupSetDownloadTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupSetDownloadTaskListResponse>(DoRPCRequest("DescribeBackupSetDownloadTaskList", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupSetDownloadTaskListResponse> DescribeBackupSetDownloadTaskListWithOptionsAsync(DescribeBackupSetDownloadTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupSetDownloadTaskListResponse>(await DoRPCRequestAsync("DescribeBackupSetDownloadTaskList", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackupSetDownloadTaskListResponse DescribeBackupSetDownloadTaskList(DescribeBackupSetDownloadTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupSetDownloadTaskListWithOptions(request, runtime);
        }

        public async Task<DescribeBackupSetDownloadTaskListResponse> DescribeBackupSetDownloadTaskListAsync(DescribeBackupSetDownloadTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupSetDownloadTaskListWithOptionsAsync(request, runtime);
        }

        public DescribeFullBackupListResponse DescribeFullBackupListWithOptions(DescribeFullBackupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFullBackupListResponse>(DoRPCRequest("DescribeFullBackupList", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFullBackupListResponse> DescribeFullBackupListWithOptionsAsync(DescribeFullBackupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFullBackupListResponse>(await DoRPCRequestAsync("DescribeFullBackupList", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFullBackupListResponse DescribeFullBackupList(DescribeFullBackupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFullBackupListWithOptions(request, runtime);
        }

        public async Task<DescribeFullBackupListResponse> DescribeFullBackupListAsync(DescribeFullBackupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFullBackupListWithOptionsAsync(request, runtime);
        }

        public DescribeIncrementBackupListResponse DescribeIncrementBackupListWithOptions(DescribeIncrementBackupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIncrementBackupListResponse>(DoRPCRequest("DescribeIncrementBackupList", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIncrementBackupListResponse> DescribeIncrementBackupListWithOptionsAsync(DescribeIncrementBackupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIncrementBackupListResponse>(await DoRPCRequestAsync("DescribeIncrementBackupList", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIncrementBackupListResponse DescribeIncrementBackupList(DescribeIncrementBackupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIncrementBackupListWithOptions(request, runtime);
        }

        public async Task<DescribeIncrementBackupListResponse> DescribeIncrementBackupListAsync(DescribeIncrementBackupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIncrementBackupListWithOptionsAsync(request, runtime);
        }

        public DescribeJobErrorCodeResponse DescribeJobErrorCodeWithOptions(DescribeJobErrorCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeJobErrorCodeResponse>(DoRPCRequest("DescribeJobErrorCode", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeJobErrorCodeResponse> DescribeJobErrorCodeWithOptionsAsync(DescribeJobErrorCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeJobErrorCodeResponse>(await DoRPCRequestAsync("DescribeJobErrorCode", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeJobErrorCodeResponse DescribeJobErrorCode(DescribeJobErrorCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeJobErrorCodeWithOptions(request, runtime);
        }

        public async Task<DescribeJobErrorCodeResponse> DescribeJobErrorCodeAsync(DescribeJobErrorCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeJobErrorCodeWithOptionsAsync(request, runtime);
        }

        public DescribeNodeCidrListResponse DescribeNodeCidrListWithOptions(DescribeNodeCidrListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNodeCidrListResponse>(DoRPCRequest("DescribeNodeCidrList", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNodeCidrListResponse> DescribeNodeCidrListWithOptionsAsync(DescribeNodeCidrListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNodeCidrListResponse>(await DoRPCRequestAsync("DescribeNodeCidrList", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNodeCidrListResponse DescribeNodeCidrList(DescribeNodeCidrListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNodeCidrListWithOptions(request, runtime);
        }

        public async Task<DescribeNodeCidrListResponse> DescribeNodeCidrListAsync(DescribeNodeCidrListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNodeCidrListWithOptionsAsync(request, runtime);
        }

        public DescribePreCheckProgressListResponse DescribePreCheckProgressListWithOptions(DescribePreCheckProgressListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePreCheckProgressListResponse>(DoRPCRequest("DescribePreCheckProgressList", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePreCheckProgressListResponse> DescribePreCheckProgressListWithOptionsAsync(DescribePreCheckProgressListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePreCheckProgressListResponse>(await DoRPCRequestAsync("DescribePreCheckProgressList", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePreCheckProgressListResponse DescribePreCheckProgressList(DescribePreCheckProgressListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePreCheckProgressListWithOptions(request, runtime);
        }

        public async Task<DescribePreCheckProgressListResponse> DescribePreCheckProgressListAsync(DescribePreCheckProgressListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePreCheckProgressListWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        public DescribeRestoreRangeInfoResponse DescribeRestoreRangeInfoWithOptions(DescribeRestoreRangeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRestoreRangeInfoResponse>(DoRPCRequest("DescribeRestoreRangeInfo", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRestoreRangeInfoResponse> DescribeRestoreRangeInfoWithOptionsAsync(DescribeRestoreRangeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRestoreRangeInfoResponse>(await DoRPCRequestAsync("DescribeRestoreRangeInfo", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRestoreRangeInfoResponse DescribeRestoreRangeInfo(DescribeRestoreRangeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestoreRangeInfoWithOptions(request, runtime);
        }

        public async Task<DescribeRestoreRangeInfoResponse> DescribeRestoreRangeInfoAsync(DescribeRestoreRangeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestoreRangeInfoWithOptionsAsync(request, runtime);
        }

        public DescribeRestoreTaskListResponse DescribeRestoreTaskListWithOptions(DescribeRestoreTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRestoreTaskListResponse>(DoRPCRequest("DescribeRestoreTaskList", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRestoreTaskListResponse> DescribeRestoreTaskListWithOptionsAsync(DescribeRestoreTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRestoreTaskListResponse>(await DoRPCRequestAsync("DescribeRestoreTaskList", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRestoreTaskListResponse DescribeRestoreTaskList(DescribeRestoreTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestoreTaskListWithOptions(request, runtime);
        }

        public async Task<DescribeRestoreTaskListResponse> DescribeRestoreTaskListAsync(DescribeRestoreTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestoreTaskListWithOptionsAsync(request, runtime);
        }

        public DisableBackupLogResponse DisableBackupLogWithOptions(DisableBackupLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableBackupLogResponse>(DoRPCRequest("DisableBackupLog", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableBackupLogResponse> DisableBackupLogWithOptionsAsync(DisableBackupLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableBackupLogResponse>(await DoRPCRequestAsync("DisableBackupLog", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableBackupLogResponse DisableBackupLog(DisableBackupLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableBackupLogWithOptions(request, runtime);
        }

        public async Task<DisableBackupLogResponse> DisableBackupLogAsync(DisableBackupLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableBackupLogWithOptionsAsync(request, runtime);
        }

        public EnableBackupLogResponse EnableBackupLogWithOptions(EnableBackupLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableBackupLogResponse>(DoRPCRequest("EnableBackupLog", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableBackupLogResponse> EnableBackupLogWithOptionsAsync(EnableBackupLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableBackupLogResponse>(await DoRPCRequestAsync("EnableBackupLog", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableBackupLogResponse EnableBackupLog(EnableBackupLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableBackupLogWithOptions(request, runtime);
        }

        public async Task<EnableBackupLogResponse> EnableBackupLogAsync(EnableBackupLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableBackupLogWithOptionsAsync(request, runtime);
        }

        public GetDBListFromAgentResponse GetDBListFromAgentWithOptions(GetDBListFromAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDBListFromAgentResponse>(DoRPCRequest("GetDBListFromAgent", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDBListFromAgentResponse> GetDBListFromAgentWithOptionsAsync(GetDBListFromAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDBListFromAgentResponse>(await DoRPCRequestAsync("GetDBListFromAgent", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDBListFromAgentResponse GetDBListFromAgent(GetDBListFromAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDBListFromAgentWithOptions(request, runtime);
        }

        public async Task<GetDBListFromAgentResponse> GetDBListFromAgentAsync(GetDBListFromAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDBListFromAgentWithOptionsAsync(request, runtime);
        }

        public ModifyBackupObjectsResponse ModifyBackupObjectsWithOptions(ModifyBackupObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupObjectsResponse>(DoRPCRequest("ModifyBackupObjects", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBackupObjectsResponse> ModifyBackupObjectsWithOptionsAsync(ModifyBackupObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupObjectsResponse>(await DoRPCRequestAsync("ModifyBackupObjects", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyBackupObjectsResponse ModifyBackupObjects(ModifyBackupObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupObjectsWithOptions(request, runtime);
        }

        public async Task<ModifyBackupObjectsResponse> ModifyBackupObjectsAsync(ModifyBackupObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupObjectsWithOptionsAsync(request, runtime);
        }

        public ModifyBackupPlanNameResponse ModifyBackupPlanNameWithOptions(ModifyBackupPlanNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupPlanNameResponse>(DoRPCRequest("ModifyBackupPlanName", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBackupPlanNameResponse> ModifyBackupPlanNameWithOptionsAsync(ModifyBackupPlanNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupPlanNameResponse>(await DoRPCRequestAsync("ModifyBackupPlanName", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyBackupPlanNameResponse ModifyBackupPlanName(ModifyBackupPlanNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupPlanNameWithOptions(request, runtime);
        }

        public async Task<ModifyBackupPlanNameResponse> ModifyBackupPlanNameAsync(ModifyBackupPlanNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupPlanNameWithOptionsAsync(request, runtime);
        }

        public ModifyBackupSetDownloadRulesResponse ModifyBackupSetDownloadRulesWithOptions(ModifyBackupSetDownloadRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupSetDownloadRulesResponse>(DoRPCRequest("ModifyBackupSetDownloadRules", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBackupSetDownloadRulesResponse> ModifyBackupSetDownloadRulesWithOptionsAsync(ModifyBackupSetDownloadRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupSetDownloadRulesResponse>(await DoRPCRequestAsync("ModifyBackupSetDownloadRules", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyBackupSetDownloadRulesResponse ModifyBackupSetDownloadRules(ModifyBackupSetDownloadRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupSetDownloadRulesWithOptions(request, runtime);
        }

        public async Task<ModifyBackupSetDownloadRulesResponse> ModifyBackupSetDownloadRulesAsync(ModifyBackupSetDownloadRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupSetDownloadRulesWithOptionsAsync(request, runtime);
        }

        public ModifyBackupSourceEndpointResponse ModifyBackupSourceEndpointWithOptions(ModifyBackupSourceEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupSourceEndpointResponse>(DoRPCRequest("ModifyBackupSourceEndpoint", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBackupSourceEndpointResponse> ModifyBackupSourceEndpointWithOptionsAsync(ModifyBackupSourceEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupSourceEndpointResponse>(await DoRPCRequestAsync("ModifyBackupSourceEndpoint", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyBackupSourceEndpointResponse ModifyBackupSourceEndpoint(ModifyBackupSourceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupSourceEndpointWithOptions(request, runtime);
        }

        public async Task<ModifyBackupSourceEndpointResponse> ModifyBackupSourceEndpointAsync(ModifyBackupSourceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupSourceEndpointWithOptionsAsync(request, runtime);
        }

        public ModifyBackupStrategyResponse ModifyBackupStrategyWithOptions(ModifyBackupStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupStrategyResponse>(DoRPCRequest("ModifyBackupStrategy", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBackupStrategyResponse> ModifyBackupStrategyWithOptionsAsync(ModifyBackupStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupStrategyResponse>(await DoRPCRequestAsync("ModifyBackupStrategy", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyBackupStrategyResponse ModifyBackupStrategy(ModifyBackupStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupStrategyWithOptions(request, runtime);
        }

        public async Task<ModifyBackupStrategyResponse> ModifyBackupStrategyAsync(ModifyBackupStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupStrategyWithOptionsAsync(request, runtime);
        }

        public ModifyStorageStrategyResponse ModifyStorageStrategyWithOptions(ModifyStorageStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyStorageStrategyResponse>(DoRPCRequest("ModifyStorageStrategy", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyStorageStrategyResponse> ModifyStorageStrategyWithOptionsAsync(ModifyStorageStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyStorageStrategyResponse>(await DoRPCRequestAsync("ModifyStorageStrategy", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyStorageStrategyResponse ModifyStorageStrategy(ModifyStorageStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyStorageStrategyWithOptions(request, runtime);
        }

        public async Task<ModifyStorageStrategyResponse> ModifyStorageStrategyAsync(ModifyStorageStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyStorageStrategyWithOptionsAsync(request, runtime);
        }

        public ReleaseBackupPlanResponse ReleaseBackupPlanWithOptions(ReleaseBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseBackupPlanResponse>(DoRPCRequest("ReleaseBackupPlan", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseBackupPlanResponse> ReleaseBackupPlanWithOptionsAsync(ReleaseBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseBackupPlanResponse>(await DoRPCRequestAsync("ReleaseBackupPlan", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleaseBackupPlanResponse ReleaseBackupPlan(ReleaseBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseBackupPlanWithOptions(request, runtime);
        }

        public async Task<ReleaseBackupPlanResponse> ReleaseBackupPlanAsync(ReleaseBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseBackupPlanWithOptionsAsync(request, runtime);
        }

        public RenewBackupPlanResponse RenewBackupPlanWithOptions(RenewBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewBackupPlanResponse>(DoRPCRequest("RenewBackupPlan", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenewBackupPlanResponse> RenewBackupPlanWithOptionsAsync(RenewBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewBackupPlanResponse>(await DoRPCRequestAsync("RenewBackupPlan", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RenewBackupPlanResponse RenewBackupPlan(RenewBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewBackupPlanWithOptions(request, runtime);
        }

        public async Task<RenewBackupPlanResponse> RenewBackupPlanAsync(RenewBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewBackupPlanWithOptionsAsync(request, runtime);
        }

        public StartBackupPlanResponse StartBackupPlanWithOptions(StartBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartBackupPlanResponse>(DoRPCRequest("StartBackupPlan", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartBackupPlanResponse> StartBackupPlanWithOptionsAsync(StartBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartBackupPlanResponse>(await DoRPCRequestAsync("StartBackupPlan", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartBackupPlanResponse StartBackupPlan(StartBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartBackupPlanWithOptions(request, runtime);
        }

        public async Task<StartBackupPlanResponse> StartBackupPlanAsync(StartBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartBackupPlanWithOptionsAsync(request, runtime);
        }

        public StartRestoreTaskResponse StartRestoreTaskWithOptions(StartRestoreTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartRestoreTaskResponse>(DoRPCRequest("StartRestoreTask", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartRestoreTaskResponse> StartRestoreTaskWithOptionsAsync(StartRestoreTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartRestoreTaskResponse>(await DoRPCRequestAsync("StartRestoreTask", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartRestoreTaskResponse StartRestoreTask(StartRestoreTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartRestoreTaskWithOptions(request, runtime);
        }

        public async Task<StartRestoreTaskResponse> StartRestoreTaskAsync(StartRestoreTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartRestoreTaskWithOptionsAsync(request, runtime);
        }

        public StartTaskResponse StartTaskWithOptions(StartTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartTaskResponse>(DoRPCRequest("StartTask", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartTaskResponse> StartTaskWithOptionsAsync(StartTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartTaskResponse>(await DoRPCRequestAsync("StartTask", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartTaskResponse StartTask(StartTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartTaskWithOptions(request, runtime);
        }

        public async Task<StartTaskResponse> StartTaskAsync(StartTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartTaskWithOptionsAsync(request, runtime);
        }

        public StopBackupPlanResponse StopBackupPlanWithOptions(StopBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopBackupPlanResponse>(DoRPCRequest("StopBackupPlan", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopBackupPlanResponse> StopBackupPlanWithOptionsAsync(StopBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopBackupPlanResponse>(await DoRPCRequestAsync("StopBackupPlan", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopBackupPlanResponse StopBackupPlan(StopBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopBackupPlanWithOptions(request, runtime);
        }

        public async Task<StopBackupPlanResponse> StopBackupPlanAsync(StopBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopBackupPlanWithOptionsAsync(request, runtime);
        }

        public UpgradeBackupPlanResponse UpgradeBackupPlanWithOptions(UpgradeBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeBackupPlanResponse>(DoRPCRequest("UpgradeBackupPlan", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeBackupPlanResponse> UpgradeBackupPlanWithOptionsAsync(UpgradeBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeBackupPlanResponse>(await DoRPCRequestAsync("UpgradeBackupPlan", "2019-03-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeBackupPlanResponse UpgradeBackupPlan(UpgradeBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeBackupPlanWithOptions(request, runtime);
        }

        public async Task<UpgradeBackupPlanResponse> UpgradeBackupPlanAsync(UpgradeBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeBackupPlanWithOptionsAsync(request, runtime);
        }

    }
}
