// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cassandra20190101.Models;

namespace AlibabaCloud.SDK.Cassandra20190101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cassandra", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AllocatePublicContactPointsResponse AllocatePublicContactPointsWithOptions(AllocatePublicContactPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocatePublicContactPointsResponse>(DoRPCRequest("AllocatePublicContactPoints", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AllocatePublicContactPointsResponse> AllocatePublicContactPointsWithOptionsAsync(AllocatePublicContactPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocatePublicContactPointsResponse>(await DoRPCRequestAsync("AllocatePublicContactPoints", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AllocatePublicContactPointsResponse AllocatePublicContactPoints(AllocatePublicContactPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocatePublicContactPointsWithOptions(request, runtime);
        }

        public async Task<AllocatePublicContactPointsResponse> AllocatePublicContactPointsAsync(AllocatePublicContactPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocatePublicContactPointsWithOptionsAsync(request, runtime);
        }

        public CreateBackupPlanResponse CreateBackupPlanWithOptions(CreateBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBackupPlanResponse>(DoRPCRequest("CreateBackupPlan", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateBackupPlanResponse> CreateBackupPlanWithOptionsAsync(CreateBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBackupPlanResponse>(await DoRPCRequestAsync("CreateBackupPlan", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateClusterResponse CreateClusterWithOptions(CreateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateClusterResponse>(DoRPCRequest("CreateCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateClusterResponse> CreateClusterWithOptionsAsync(CreateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateClusterResponse>(await DoRPCRequestAsync("CreateCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClusterWithOptions(request, runtime);
        }

        public async Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClusterWithOptionsAsync(request, runtime);
        }

        public CreateDataCenterResponse CreateDataCenterWithOptions(CreateDataCenterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDataCenterResponse>(DoRPCRequest("CreateDataCenter", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDataCenterResponse> CreateDataCenterWithOptionsAsync(CreateDataCenterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDataCenterResponse>(await DoRPCRequestAsync("CreateDataCenter", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDataCenterResponse CreateDataCenter(CreateDataCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataCenterWithOptions(request, runtime);
        }

        public async Task<CreateDataCenterResponse> CreateDataCenterAsync(CreateDataCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataCenterWithOptionsAsync(request, runtime);
        }

        public DeleteBackupPlanResponse DeleteBackupPlanWithOptions(DeleteBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBackupPlanResponse>(DoRPCRequest("DeleteBackupPlan", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteBackupPlanResponse> DeleteBackupPlanWithOptionsAsync(DeleteBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBackupPlanResponse>(await DoRPCRequestAsync("DeleteBackupPlan", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteBackupPlanResponse DeleteBackupPlan(DeleteBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBackupPlanWithOptions(request, runtime);
        }

        public async Task<DeleteBackupPlanResponse> DeleteBackupPlanAsync(DeleteBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBackupPlanWithOptionsAsync(request, runtime);
        }

        public DeleteClusterResponse DeleteClusterWithOptions(DeleteClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteClusterResponse>(DoRPCRequest("DeleteCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteClusterResponse> DeleteClusterWithOptionsAsync(DeleteClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteClusterResponse>(await DoRPCRequestAsync("DeleteCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClusterWithOptions(request, runtime);
        }

        public async Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClusterWithOptionsAsync(request, runtime);
        }

        public DeleteDataCenterResponse DeleteDataCenterWithOptions(DeleteDataCenterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDataCenterResponse>(DoRPCRequest("DeleteDataCenter", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDataCenterResponse> DeleteDataCenterWithOptionsAsync(DeleteDataCenterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDataCenterResponse>(await DoRPCRequestAsync("DeleteDataCenter", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDataCenterResponse DeleteDataCenter(DeleteDataCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataCenterWithOptions(request, runtime);
        }

        public async Task<DeleteDataCenterResponse> DeleteDataCenterAsync(DeleteDataCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataCenterWithOptionsAsync(request, runtime);
        }

        public DeleteNodeToolExecutionHistoryResponse DeleteNodeToolExecutionHistoryWithOptions(DeleteNodeToolExecutionHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNodeToolExecutionHistoryResponse>(DoRPCRequest("DeleteNodeToolExecutionHistory", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteNodeToolExecutionHistoryResponse> DeleteNodeToolExecutionHistoryWithOptionsAsync(DeleteNodeToolExecutionHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNodeToolExecutionHistoryResponse>(await DoRPCRequestAsync("DeleteNodeToolExecutionHistory", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteNodeToolExecutionHistoryResponse DeleteNodeToolExecutionHistory(DeleteNodeToolExecutionHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNodeToolExecutionHistoryWithOptions(request, runtime);
        }

        public async Task<DeleteNodeToolExecutionHistoryResponse> DeleteNodeToolExecutionHistoryAsync(DeleteNodeToolExecutionHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNodeToolExecutionHistoryWithOptionsAsync(request, runtime);
        }

        public DescribeAccountsResponse DescribeAccountsWithOptions(DescribeAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccountsResponse>(DoRPCRequest("DescribeAccounts", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAccountsResponse> DescribeAccountsWithOptionsAsync(DescribeAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccountsResponse>(await DoRPCRequestAsync("DescribeAccounts", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAccountsResponse DescribeAccounts(DescribeAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccountsWithOptions(request, runtime);
        }

        public async Task<DescribeAccountsResponse> DescribeAccountsAsync(DescribeAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccountsWithOptionsAsync(request, runtime);
        }

        public DescribeBackupResponse DescribeBackupWithOptions(DescribeBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupResponse>(DoRPCRequest("DescribeBackup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupResponse> DescribeBackupWithOptionsAsync(DescribeBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupResponse>(await DoRPCRequestAsync("DescribeBackup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackupResponse DescribeBackup(DescribeBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupWithOptions(request, runtime);
        }

        public async Task<DescribeBackupResponse> DescribeBackupAsync(DescribeBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupWithOptionsAsync(request, runtime);
        }

        public DescribeBackupPlanResponse DescribeBackupPlanWithOptions(DescribeBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPlanResponse>(DoRPCRequest("DescribeBackupPlan", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupPlanResponse> DescribeBackupPlanWithOptionsAsync(DescribeBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPlanResponse>(await DoRPCRequestAsync("DescribeBackupPlan", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackupPlanResponse DescribeBackupPlan(DescribeBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupPlanWithOptions(request, runtime);
        }

        public async Task<DescribeBackupPlanResponse> DescribeBackupPlanAsync(DescribeBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupPlanWithOptionsAsync(request, runtime);
        }

        public DescribeBackupPlansResponse DescribeBackupPlansWithOptions(DescribeBackupPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPlansResponse>(DoRPCRequest("DescribeBackupPlans", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupPlansResponse> DescribeBackupPlansWithOptionsAsync(DescribeBackupPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPlansResponse>(await DoRPCRequestAsync("DescribeBackupPlans", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackupPlansResponse DescribeBackupPlans(DescribeBackupPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupPlansWithOptions(request, runtime);
        }

        public async Task<DescribeBackupPlansResponse> DescribeBackupPlansAsync(DescribeBackupPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupPlansWithOptionsAsync(request, runtime);
        }

        public DescribeBackupsResponse DescribeBackupsWithOptions(DescribeBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupsResponse>(DoRPCRequest("DescribeBackups", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupsResponse> DescribeBackupsWithOptionsAsync(DescribeBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupsResponse>(await DoRPCRequestAsync("DescribeBackups", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackupsResponse DescribeBackups(DescribeBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupsWithOptions(request, runtime);
        }

        public async Task<DescribeBackupsResponse> DescribeBackupsAsync(DescribeBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupsWithOptionsAsync(request, runtime);
        }

        public DescribeClusterResponse DescribeClusterWithOptions(DescribeClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterResponse>(DoRPCRequest("DescribeCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterResponse> DescribeClusterWithOptionsAsync(DescribeClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterResponse>(await DoRPCRequestAsync("DescribeCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClusterResponse DescribeCluster(DescribeClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterWithOptions(request, runtime);
        }

        public async Task<DescribeClusterResponse> DescribeClusterAsync(DescribeClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterWithOptionsAsync(request, runtime);
        }

        public DescribeClusterDashboardResponse DescribeClusterDashboardWithOptions(DescribeClusterDashboardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterDashboardResponse>(DoRPCRequest("DescribeClusterDashboard", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterDashboardResponse> DescribeClusterDashboardWithOptionsAsync(DescribeClusterDashboardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterDashboardResponse>(await DoRPCRequestAsync("DescribeClusterDashboard", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClusterDashboardResponse DescribeClusterDashboard(DescribeClusterDashboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterDashboardWithOptions(request, runtime);
        }

        public async Task<DescribeClusterDashboardResponse> DescribeClusterDashboardAsync(DescribeClusterDashboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterDashboardWithOptionsAsync(request, runtime);
        }

        public DescribeClustersResponse DescribeClustersWithOptions(DescribeClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClustersResponse>(DoRPCRequest("DescribeClusters", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClustersResponse> DescribeClustersWithOptionsAsync(DescribeClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClustersResponse>(await DoRPCRequestAsync("DescribeClusters", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClustersWithOptions(request, runtime);
        }

        public async Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClustersWithOptionsAsync(request, runtime);
        }

        public DescribeClusterStatusResponse DescribeClusterStatusWithOptions(DescribeClusterStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterStatusResponse>(DoRPCRequest("DescribeClusterStatus", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterStatusResponse> DescribeClusterStatusWithOptionsAsync(DescribeClusterStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterStatusResponse>(await DoRPCRequestAsync("DescribeClusterStatus", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClusterStatusResponse DescribeClusterStatus(DescribeClusterStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterStatusWithOptions(request, runtime);
        }

        public async Task<DescribeClusterStatusResponse> DescribeClusterStatusAsync(DescribeClusterStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterStatusWithOptionsAsync(request, runtime);
        }

        public DescribeContactPointsResponse DescribeContactPointsWithOptions(DescribeContactPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContactPointsResponse>(DoRPCRequest("DescribeContactPoints", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeContactPointsResponse> DescribeContactPointsWithOptionsAsync(DescribeContactPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContactPointsResponse>(await DoRPCRequestAsync("DescribeContactPoints", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeContactPointsResponse DescribeContactPoints(DescribeContactPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContactPointsWithOptions(request, runtime);
        }

        public async Task<DescribeContactPointsResponse> DescribeContactPointsAsync(DescribeContactPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContactPointsWithOptionsAsync(request, runtime);
        }

        public DescribeDataCenterResponse DescribeDataCenterWithOptions(DescribeDataCenterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataCenterResponse>(DoRPCRequest("DescribeDataCenter", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDataCenterResponse> DescribeDataCenterWithOptionsAsync(DescribeDataCenterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataCenterResponse>(await DoRPCRequestAsync("DescribeDataCenter", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDataCenterResponse DescribeDataCenter(DescribeDataCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataCenterWithOptions(request, runtime);
        }

        public async Task<DescribeDataCenterResponse> DescribeDataCenterAsync(DescribeDataCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataCenterWithOptionsAsync(request, runtime);
        }

        public DescribeDataCentersResponse DescribeDataCentersWithOptions(DescribeDataCentersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataCentersResponse>(DoRPCRequest("DescribeDataCenters", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDataCentersResponse> DescribeDataCentersWithOptionsAsync(DescribeDataCentersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataCentersResponse>(await DoRPCRequestAsync("DescribeDataCenters", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDataCentersResponse DescribeDataCenters(DescribeDataCentersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataCentersWithOptions(request, runtime);
        }

        public async Task<DescribeDataCentersResponse> DescribeDataCentersAsync(DescribeDataCentersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataCentersWithOptionsAsync(request, runtime);
        }

        public DescribeDeletedClustersResponse DescribeDeletedClustersWithOptions(DescribeDeletedClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeletedClustersResponse>(DoRPCRequest("DescribeDeletedClusters", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeletedClustersResponse> DescribeDeletedClustersWithOptionsAsync(DescribeDeletedClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeletedClustersResponse>(await DoRPCRequestAsync("DescribeDeletedClusters", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDeletedClustersResponse DescribeDeletedClusters(DescribeDeletedClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeletedClustersWithOptions(request, runtime);
        }

        public async Task<DescribeDeletedClustersResponse> DescribeDeletedClustersAsync(DescribeDeletedClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeletedClustersWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceTypeResponse DescribeInstanceTypeWithOptions(DescribeInstanceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceTypeResponse>(DoRPCRequest("DescribeInstanceType", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceTypeResponse> DescribeInstanceTypeWithOptionsAsync(DescribeInstanceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceTypeResponse>(await DoRPCRequestAsync("DescribeInstanceType", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceTypeResponse DescribeInstanceType(DescribeInstanceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceTypeWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceTypeResponse> DescribeInstanceTypeAsync(DescribeInstanceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceTypeWithOptionsAsync(request, runtime);
        }

        public DescribeIpWhitelistResponse DescribeIpWhitelistWithOptions(DescribeIpWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpWhitelistResponse>(DoRPCRequest("DescribeIpWhitelist", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIpWhitelistResponse> DescribeIpWhitelistWithOptionsAsync(DescribeIpWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpWhitelistResponse>(await DoRPCRequestAsync("DescribeIpWhitelist", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIpWhitelistResponse DescribeIpWhitelist(DescribeIpWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpWhitelistWithOptions(request, runtime);
        }

        public async Task<DescribeIpWhitelistResponse> DescribeIpWhitelistAsync(DescribeIpWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpWhitelistWithOptionsAsync(request, runtime);
        }

        public DescribeIpWhitelistGroupsResponse DescribeIpWhitelistGroupsWithOptions(DescribeIpWhitelistGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpWhitelistGroupsResponse>(DoRPCRequest("DescribeIpWhitelistGroups", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIpWhitelistGroupsResponse> DescribeIpWhitelistGroupsWithOptionsAsync(DescribeIpWhitelistGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpWhitelistGroupsResponse>(await DoRPCRequestAsync("DescribeIpWhitelistGroups", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIpWhitelistGroupsResponse DescribeIpWhitelistGroups(DescribeIpWhitelistGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpWhitelistGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeIpWhitelistGroupsResponse> DescribeIpWhitelistGroupsAsync(DescribeIpWhitelistGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpWhitelistGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeNodeToolExecutionHistoriesResponse DescribeNodeToolExecutionHistoriesWithOptions(DescribeNodeToolExecutionHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNodeToolExecutionHistoriesResponse>(DoRPCRequest("DescribeNodeToolExecutionHistories", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNodeToolExecutionHistoriesResponse> DescribeNodeToolExecutionHistoriesWithOptionsAsync(DescribeNodeToolExecutionHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNodeToolExecutionHistoriesResponse>(await DoRPCRequestAsync("DescribeNodeToolExecutionHistories", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNodeToolExecutionHistoriesResponse DescribeNodeToolExecutionHistories(DescribeNodeToolExecutionHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNodeToolExecutionHistoriesWithOptions(request, runtime);
        }

        public async Task<DescribeNodeToolExecutionHistoriesResponse> DescribeNodeToolExecutionHistoriesAsync(DescribeNodeToolExecutionHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNodeToolExecutionHistoriesWithOptionsAsync(request, runtime);
        }

        public DescribeNodeToolExecutionHistoryResponse DescribeNodeToolExecutionHistoryWithOptions(DescribeNodeToolExecutionHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNodeToolExecutionHistoryResponse>(DoRPCRequest("DescribeNodeToolExecutionHistory", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNodeToolExecutionHistoryResponse> DescribeNodeToolExecutionHistoryWithOptionsAsync(DescribeNodeToolExecutionHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNodeToolExecutionHistoryResponse>(await DoRPCRequestAsync("DescribeNodeToolExecutionHistory", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNodeToolExecutionHistoryResponse DescribeNodeToolExecutionHistory(DescribeNodeToolExecutionHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNodeToolExecutionHistoryWithOptions(request, runtime);
        }

        public async Task<DescribeNodeToolExecutionHistoryResponse> DescribeNodeToolExecutionHistoryAsync(DescribeNodeToolExecutionHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNodeToolExecutionHistoryWithOptionsAsync(request, runtime);
        }

        public DescribeParameterModificationHistoriesResponse DescribeParameterModificationHistoriesWithOptions(DescribeParameterModificationHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParameterModificationHistoriesResponse>(DoRPCRequest("DescribeParameterModificationHistories", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeParameterModificationHistoriesResponse> DescribeParameterModificationHistoriesWithOptionsAsync(DescribeParameterModificationHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParameterModificationHistoriesResponse>(await DoRPCRequestAsync("DescribeParameterModificationHistories", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeParameterModificationHistoriesResponse DescribeParameterModificationHistories(DescribeParameterModificationHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeParameterModificationHistoriesWithOptions(request, runtime);
        }

        public async Task<DescribeParameterModificationHistoriesResponse> DescribeParameterModificationHistoriesAsync(DescribeParameterModificationHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeParameterModificationHistoriesWithOptionsAsync(request, runtime);
        }

        public DescribeParametersResponse DescribeParametersWithOptions(DescribeParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParametersResponse>(DoRPCRequest("DescribeParameters", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeParametersResponse> DescribeParametersWithOptionsAsync(DescribeParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParametersResponse>(await DoRPCRequestAsync("DescribeParameters", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeParametersResponse DescribeParameters(DescribeParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeParametersWithOptions(request, runtime);
        }

        public async Task<DescribeParametersResponse> DescribeParametersAsync(DescribeParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeParametersWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeSecurityGroupsResponse DescribeSecurityGroupsWithOptions(DescribeSecurityGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityGroupsResponse>(DoRPCRequest("DescribeSecurityGroups", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsWithOptionsAsync(DescribeSecurityGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityGroupsResponse>(await DoRPCRequestAsync("DescribeSecurityGroups", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(DescribeSecurityGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityGroupsWithOptionsAsync(request, runtime);
        }

        public ExecuteNodeToolResponse ExecuteNodeToolWithOptions(ExecuteNodeToolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteNodeToolResponse>(DoRPCRequest("ExecuteNodeTool", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExecuteNodeToolResponse> ExecuteNodeToolWithOptionsAsync(ExecuteNodeToolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteNodeToolResponse>(await DoRPCRequestAsync("ExecuteNodeTool", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExecuteNodeToolResponse ExecuteNodeTool(ExecuteNodeToolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteNodeToolWithOptions(request, runtime);
        }

        public async Task<ExecuteNodeToolResponse> ExecuteNodeToolAsync(ExecuteNodeToolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteNodeToolWithOptionsAsync(request, runtime);
        }

        public GetCmsUrlResponse GetCmsUrlWithOptions(GetCmsUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCmsUrlResponse>(DoRPCRequest("GetCmsUrl", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetCmsUrlResponse> GetCmsUrlWithOptionsAsync(GetCmsUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCmsUrlResponse>(await DoRPCRequestAsync("GetCmsUrl", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetCmsUrlResponse GetCmsUrl(GetCmsUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCmsUrlWithOptions(request, runtime);
        }

        public async Task<GetCmsUrlResponse> GetCmsUrlAsync(GetCmsUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCmsUrlWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        public ListTagsResponse ListTagsWithOptions(ListTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagsResponse>(DoRPCRequest("ListTags", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagsResponse> ListTagsWithOptionsAsync(ListTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagsResponse>(await DoRPCRequestAsync("ListTags", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagsResponse ListTags(ListTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagsWithOptions(request, runtime);
        }

        public async Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagsWithOptionsAsync(request, runtime);
        }

        public ModifyAccountPasswordResponse ModifyAccountPasswordWithOptions(ModifyAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccountPasswordResponse>(DoRPCRequest("ModifyAccountPassword", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAccountPasswordResponse> ModifyAccountPasswordWithOptionsAsync(ModifyAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccountPasswordResponse>(await DoRPCRequestAsync("ModifyAccountPassword", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyAccountPasswordResponse ModifyAccountPassword(ModifyAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccountPasswordWithOptions(request, runtime);
        }

        public async Task<ModifyAccountPasswordResponse> ModifyAccountPasswordAsync(ModifyAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccountPasswordWithOptionsAsync(request, runtime);
        }

        public ModifyBackupPlanResponse ModifyBackupPlanWithOptions(ModifyBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupPlanResponse>(DoRPCRequest("ModifyBackupPlan", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBackupPlanResponse> ModifyBackupPlanWithOptionsAsync(ModifyBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupPlanResponse>(await DoRPCRequestAsync("ModifyBackupPlan", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyBackupPlanResponse ModifyBackupPlan(ModifyBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupPlanWithOptions(request, runtime);
        }

        public async Task<ModifyBackupPlanResponse> ModifyBackupPlanAsync(ModifyBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupPlanWithOptionsAsync(request, runtime);
        }

        public ModifyClusterResponse ModifyClusterWithOptions(ModifyClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterResponse>(DoRPCRequest("ModifyCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyClusterResponse> ModifyClusterWithOptionsAsync(ModifyClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterResponse>(await DoRPCRequestAsync("ModifyCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyClusterResponse ModifyCluster(ModifyClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClusterWithOptions(request, runtime);
        }

        public async Task<ModifyClusterResponse> ModifyClusterAsync(ModifyClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClusterWithOptionsAsync(request, runtime);
        }

        public ModifyDataCenterResponse ModifyDataCenterWithOptions(ModifyDataCenterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDataCenterResponse>(DoRPCRequest("ModifyDataCenter", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDataCenterResponse> ModifyDataCenterWithOptionsAsync(ModifyDataCenterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDataCenterResponse>(await DoRPCRequestAsync("ModifyDataCenter", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDataCenterResponse ModifyDataCenter(ModifyDataCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDataCenterWithOptions(request, runtime);
        }

        public async Task<ModifyDataCenterResponse> ModifyDataCenterAsync(ModifyDataCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDataCenterWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceMaintainTimeResponse ModifyInstanceMaintainTimeWithOptions(ModifyInstanceMaintainTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceMaintainTimeResponse>(DoRPCRequest("ModifyInstanceMaintainTime", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceMaintainTimeResponse> ModifyInstanceMaintainTimeWithOptionsAsync(ModifyInstanceMaintainTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceMaintainTimeResponse>(await DoRPCRequestAsync("ModifyInstanceMaintainTime", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceMaintainTimeResponse ModifyInstanceMaintainTime(ModifyInstanceMaintainTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceMaintainTimeWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceMaintainTimeResponse> ModifyInstanceMaintainTimeAsync(ModifyInstanceMaintainTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceMaintainTimeWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceTypeResponse ModifyInstanceTypeWithOptions(ModifyInstanceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceTypeResponse>(DoRPCRequest("ModifyInstanceType", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceTypeResponse> ModifyInstanceTypeWithOptionsAsync(ModifyInstanceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceTypeResponse>(await DoRPCRequestAsync("ModifyInstanceType", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceTypeResponse ModifyInstanceType(ModifyInstanceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceTypeWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceTypeResponse> ModifyInstanceTypeAsync(ModifyInstanceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceTypeWithOptionsAsync(request, runtime);
        }

        public ModifyIpWhitelistResponse ModifyIpWhitelistWithOptions(ModifyIpWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIpWhitelistResponse>(DoRPCRequest("ModifyIpWhitelist", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyIpWhitelistResponse> ModifyIpWhitelistWithOptionsAsync(ModifyIpWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIpWhitelistResponse>(await DoRPCRequestAsync("ModifyIpWhitelist", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyIpWhitelistResponse ModifyIpWhitelist(ModifyIpWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIpWhitelistWithOptions(request, runtime);
        }

        public async Task<ModifyIpWhitelistResponse> ModifyIpWhitelistAsync(ModifyIpWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIpWhitelistWithOptionsAsync(request, runtime);
        }

        public ModifyIpWhitelistGroupResponse ModifyIpWhitelistGroupWithOptions(ModifyIpWhitelistGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIpWhitelistGroupResponse>(DoRPCRequest("ModifyIpWhitelistGroup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyIpWhitelistGroupResponse> ModifyIpWhitelistGroupWithOptionsAsync(ModifyIpWhitelistGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIpWhitelistGroupResponse>(await DoRPCRequestAsync("ModifyIpWhitelistGroup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyIpWhitelistGroupResponse ModifyIpWhitelistGroup(ModifyIpWhitelistGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIpWhitelistGroupWithOptions(request, runtime);
        }

        public async Task<ModifyIpWhitelistGroupResponse> ModifyIpWhitelistGroupAsync(ModifyIpWhitelistGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIpWhitelistGroupWithOptionsAsync(request, runtime);
        }

        public ModifyParameterResponse ModifyParameterWithOptions(ModifyParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyParameterResponse>(DoRPCRequest("ModifyParameter", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyParameterResponse> ModifyParameterWithOptionsAsync(ModifyParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyParameterResponse>(await DoRPCRequestAsync("ModifyParameter", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyParameterResponse ModifyParameter(ModifyParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyParameterWithOptions(request, runtime);
        }

        public async Task<ModifyParameterResponse> ModifyParameterAsync(ModifyParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyParameterWithOptionsAsync(request, runtime);
        }

        public ModifySecurityGroupsResponse ModifySecurityGroupsWithOptions(ModifySecurityGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySecurityGroupsResponse>(DoRPCRequest("ModifySecurityGroups", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySecurityGroupsResponse> ModifySecurityGroupsWithOptionsAsync(ModifySecurityGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySecurityGroupsResponse>(await DoRPCRequestAsync("ModifySecurityGroups", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySecurityGroupsResponse ModifySecurityGroups(ModifySecurityGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySecurityGroupsWithOptions(request, runtime);
        }

        public async Task<ModifySecurityGroupsResponse> ModifySecurityGroupsAsync(ModifySecurityGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySecurityGroupsWithOptionsAsync(request, runtime);
        }

        public MoveResourceGroupResponse MoveResourceGroupWithOptions(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(DoRPCRequest("MoveResourceGroup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MoveResourceGroupResponse> MoveResourceGroupWithOptionsAsync(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(await DoRPCRequestAsync("MoveResourceGroup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MoveResourceGroupResponse MoveResourceGroup(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveResourceGroupWithOptions(request, runtime);
        }

        public async Task<MoveResourceGroupResponse> MoveResourceGroupAsync(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveResourceGroupWithOptionsAsync(request, runtime);
        }

        public PurgeClusterResponse PurgeClusterWithOptions(PurgeClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PurgeClusterResponse>(DoRPCRequest("PurgeCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PurgeClusterResponse> PurgeClusterWithOptionsAsync(PurgeClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PurgeClusterResponse>(await DoRPCRequestAsync("PurgeCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PurgeClusterResponse PurgeCluster(PurgeClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PurgeClusterWithOptions(request, runtime);
        }

        public async Task<PurgeClusterResponse> PurgeClusterAsync(PurgeClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PurgeClusterWithOptionsAsync(request, runtime);
        }

        public RebootClusterResponse RebootClusterWithOptions(RebootClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RebootClusterResponse>(DoRPCRequest("RebootCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RebootClusterResponse> RebootClusterWithOptionsAsync(RebootClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RebootClusterResponse>(await DoRPCRequestAsync("RebootCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RebootClusterResponse RebootCluster(RebootClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebootClusterWithOptions(request, runtime);
        }

        public async Task<RebootClusterResponse> RebootClusterAsync(RebootClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebootClusterWithOptionsAsync(request, runtime);
        }

        public ReleasePublicContactPointsResponse ReleasePublicContactPointsWithOptions(ReleasePublicContactPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleasePublicContactPointsResponse>(DoRPCRequest("ReleasePublicContactPoints", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleasePublicContactPointsResponse> ReleasePublicContactPointsWithOptionsAsync(ReleasePublicContactPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleasePublicContactPointsResponse>(await DoRPCRequestAsync("ReleasePublicContactPoints", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleasePublicContactPointsResponse ReleasePublicContactPoints(ReleasePublicContactPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleasePublicContactPointsWithOptions(request, runtime);
        }

        public async Task<ReleasePublicContactPointsResponse> ReleasePublicContactPointsAsync(ReleasePublicContactPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleasePublicContactPointsWithOptionsAsync(request, runtime);
        }

        public ResizeDiskSizeResponse ResizeDiskSizeWithOptions(ResizeDiskSizeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResizeDiskSizeResponse>(DoRPCRequest("ResizeDiskSize", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResizeDiskSizeResponse> ResizeDiskSizeWithOptionsAsync(ResizeDiskSizeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResizeDiskSizeResponse>(await DoRPCRequestAsync("ResizeDiskSize", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResizeDiskSizeResponse ResizeDiskSize(ResizeDiskSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResizeDiskSizeWithOptions(request, runtime);
        }

        public async Task<ResizeDiskSizeResponse> ResizeDiskSizeAsync(ResizeDiskSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResizeDiskSizeWithOptionsAsync(request, runtime);
        }

        public ResizeNodeCountResponse ResizeNodeCountWithOptions(ResizeNodeCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResizeNodeCountResponse>(DoRPCRequest("ResizeNodeCount", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResizeNodeCountResponse> ResizeNodeCountWithOptionsAsync(ResizeNodeCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResizeNodeCountResponse>(await DoRPCRequestAsync("ResizeNodeCount", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResizeNodeCountResponse ResizeNodeCount(ResizeNodeCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResizeNodeCountWithOptions(request, runtime);
        }

        public async Task<ResizeNodeCountResponse> ResizeNodeCountAsync(ResizeNodeCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResizeNodeCountWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        public UnTagResourcesResponse UnTagResourcesWithOptions(UnTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnTagResourcesResponse>(DoRPCRequest("UnTagResources", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnTagResourcesResponse> UnTagResourcesWithOptionsAsync(UnTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnTagResourcesResponse>(await DoRPCRequestAsync("UnTagResources", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnTagResourcesResponse UnTagResources(UnTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnTagResourcesWithOptions(request, runtime);
        }

        public async Task<UnTagResourcesResponse> UnTagResourcesAsync(UnTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnTagResourcesWithOptionsAsync(request, runtime);
        }

        public UpgradeClusterVersionResponse UpgradeClusterVersionWithOptions(UpgradeClusterVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeClusterVersionResponse>(DoRPCRequest("UpgradeClusterVersion", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeClusterVersionResponse> UpgradeClusterVersionWithOptionsAsync(UpgradeClusterVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeClusterVersionResponse>(await DoRPCRequestAsync("UpgradeClusterVersion", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeClusterVersionResponse UpgradeClusterVersion(UpgradeClusterVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeClusterVersionWithOptions(request, runtime);
        }

        public async Task<UpgradeClusterVersionResponse> UpgradeClusterVersionAsync(UpgradeClusterVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeClusterVersionWithOptionsAsync(request, runtime);
        }

    }
}
