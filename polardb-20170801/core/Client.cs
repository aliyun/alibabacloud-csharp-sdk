// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Polardb20170801.Models;

namespace AlibabaCloud.SDK.Polardb20170801
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "polardb.aliyuncs.com"},
                {"cn-beijing", "polardb.aliyuncs.com"},
                {"cn-hangzhou", "polardb.aliyuncs.com"},
                {"cn-shanghai", "polardb.aliyuncs.com"},
                {"cn-shenzhen", "polardb.aliyuncs.com"},
                {"cn-hongkong", "polardb.aliyuncs.com"},
                {"ap-southeast-1", "polardb.aliyuncs.com"},
                {"us-west-1", "polardb.aliyuncs.com"},
                {"us-east-1", "polardb.aliyuncs.com"},
                {"cn-hangzhou-finance", "polardb.aliyuncs.com"},
                {"cn-shanghai-finance-1", "polardb.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "polardb.aliyuncs.com"},
                {"ap-northeast-2-pop", "polardb.aliyuncs.com"},
                {"cn-beijing-finance-1", "polardb.aliyuncs.com"},
                {"cn-beijing-finance-pop", "polardb.aliyuncs.com"},
                {"cn-beijing-gov-1", "polardb.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "polardb.aliyuncs.com"},
                {"cn-edge-1", "polardb.aliyuncs.com"},
                {"cn-fujian", "polardb.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "polardb.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "polardb.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "polardb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "polardb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "polardb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "polardb.aliyuncs.com"},
                {"cn-hangzhou-test-306", "polardb.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "polardb.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "polardb.aliyuncs.com"},
                {"cn-north-2-gov-1", "polardb.aliyuncs.com"},
                {"cn-qingdao-nebula", "polardb.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "polardb.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "polardb.aliyuncs.com"},
                {"cn-shanghai-inner", "polardb.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "polardb.aliyuncs.com"},
                {"cn-shenzhen-inner", "polardb.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "polardb.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "polardb.aliyuncs.com"},
                {"cn-wuhan", "polardb.aliyuncs.com"},
                {"cn-wulanchabu", "polardb.aliyuncs.com"},
                {"cn-yushanfang", "polardb.aliyuncs.com"},
                {"cn-zhangbei", "polardb.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "polardb.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "polardb.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "polardb.aliyuncs.com"},
                {"eu-west-1-oxs", "polardb.aliyuncs.com"},
                {"rus-west-1-pop", "polardb.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("polardb", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CancelScheduleTasksResponse CancelScheduleTasksWithOptions(CancelScheduleTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelScheduleTasksResponse>(DoRPCRequest("CancelScheduleTasks", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelScheduleTasksResponse> CancelScheduleTasksWithOptionsAsync(CancelScheduleTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelScheduleTasksResponse>(await DoRPCRequestAsync("CancelScheduleTasks", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelScheduleTasksResponse CancelScheduleTasks(CancelScheduleTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelScheduleTasksWithOptions(request, runtime);
        }

        public async Task<CancelScheduleTasksResponse> CancelScheduleTasksAsync(CancelScheduleTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelScheduleTasksWithOptionsAsync(request, runtime);
        }

        public CheckAccountNameResponse CheckAccountNameWithOptions(CheckAccountNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckAccountNameResponse>(DoRPCRequest("CheckAccountName", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckAccountNameResponse> CheckAccountNameWithOptionsAsync(CheckAccountNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckAccountNameResponse>(await DoRPCRequestAsync("CheckAccountName", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckAccountNameResponse CheckAccountName(CheckAccountNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckAccountNameWithOptions(request, runtime);
        }

        public async Task<CheckAccountNameResponse> CheckAccountNameAsync(CheckAccountNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckAccountNameWithOptionsAsync(request, runtime);
        }

        public CheckDBNameResponse CheckDBNameWithOptions(CheckDBNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckDBNameResponse>(DoRPCRequest("CheckDBName", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckDBNameResponse> CheckDBNameWithOptionsAsync(CheckDBNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckDBNameResponse>(await DoRPCRequestAsync("CheckDBName", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckDBNameResponse CheckDBName(CheckDBNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDBNameWithOptions(request, runtime);
        }

        public async Task<CheckDBNameResponse> CheckDBNameAsync(CheckDBNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDBNameWithOptionsAsync(request, runtime);
        }

        public CloseDBClusterMigrationResponse CloseDBClusterMigrationWithOptions(CloseDBClusterMigrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloseDBClusterMigrationResponse>(DoRPCRequest("CloseDBClusterMigration", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CloseDBClusterMigrationResponse> CloseDBClusterMigrationWithOptionsAsync(CloseDBClusterMigrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloseDBClusterMigrationResponse>(await DoRPCRequestAsync("CloseDBClusterMigration", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CloseDBClusterMigrationResponse CloseDBClusterMigration(CloseDBClusterMigrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloseDBClusterMigrationWithOptions(request, runtime);
        }

        public async Task<CloseDBClusterMigrationResponse> CloseDBClusterMigrationAsync(CloseDBClusterMigrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloseDBClusterMigrationWithOptionsAsync(request, runtime);
        }

        public CreateAccountResponse CreateAccountWithOptions(CreateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAccountResponse>(DoRPCRequest("CreateAccount", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAccountResponse> CreateAccountWithOptionsAsync(CreateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAccountResponse>(await DoRPCRequestAsync("CreateAccount", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAccountResponse CreateAccount(CreateAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccountWithOptions(request, runtime);
        }

        public async Task<CreateAccountResponse> CreateAccountAsync(CreateAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccountWithOptionsAsync(request, runtime);
        }

        public CreateBackupResponse CreateBackupWithOptions(CreateBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBackupResponse>(DoRPCRequest("CreateBackup", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateBackupResponse> CreateBackupWithOptionsAsync(CreateBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBackupResponse>(await DoRPCRequestAsync("CreateBackup", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateBackupResponse CreateBackup(CreateBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBackupWithOptions(request, runtime);
        }

        public async Task<CreateBackupResponse> CreateBackupAsync(CreateBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBackupWithOptionsAsync(request, runtime);
        }

        public CreateDatabaseResponse CreateDatabaseWithOptions(CreateDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDatabaseResponse>(DoRPCRequest("CreateDatabase", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDatabaseResponse> CreateDatabaseWithOptionsAsync(CreateDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDatabaseResponse>(await DoRPCRequestAsync("CreateDatabase", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDatabaseResponse CreateDatabase(CreateDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDatabaseWithOptions(request, runtime);
        }

        public async Task<CreateDatabaseResponse> CreateDatabaseAsync(CreateDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDatabaseWithOptionsAsync(request, runtime);
        }

        public CreateDBClusterResponse CreateDBClusterWithOptions(CreateDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBClusterResponse>(DoRPCRequest("CreateDBCluster", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDBClusterResponse> CreateDBClusterWithOptionsAsync(CreateDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBClusterResponse>(await DoRPCRequestAsync("CreateDBCluster", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDBClusterResponse CreateDBCluster(CreateDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDBClusterWithOptions(request, runtime);
        }

        public async Task<CreateDBClusterResponse> CreateDBClusterAsync(CreateDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDBClusterWithOptionsAsync(request, runtime);
        }

        public CreateDBClusterEndpointResponse CreateDBClusterEndpointWithOptions(CreateDBClusterEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBClusterEndpointResponse>(DoRPCRequest("CreateDBClusterEndpoint", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDBClusterEndpointResponse> CreateDBClusterEndpointWithOptionsAsync(CreateDBClusterEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBClusterEndpointResponse>(await DoRPCRequestAsync("CreateDBClusterEndpoint", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDBClusterEndpointResponse CreateDBClusterEndpoint(CreateDBClusterEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDBClusterEndpointWithOptions(request, runtime);
        }

        public async Task<CreateDBClusterEndpointResponse> CreateDBClusterEndpointAsync(CreateDBClusterEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDBClusterEndpointWithOptionsAsync(request, runtime);
        }

        public CreateDBEndpointAddressResponse CreateDBEndpointAddressWithOptions(CreateDBEndpointAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBEndpointAddressResponse>(DoRPCRequest("CreateDBEndpointAddress", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDBEndpointAddressResponse> CreateDBEndpointAddressWithOptionsAsync(CreateDBEndpointAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBEndpointAddressResponse>(await DoRPCRequestAsync("CreateDBEndpointAddress", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDBEndpointAddressResponse CreateDBEndpointAddress(CreateDBEndpointAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDBEndpointAddressWithOptions(request, runtime);
        }

        public async Task<CreateDBEndpointAddressResponse> CreateDBEndpointAddressAsync(CreateDBEndpointAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDBEndpointAddressWithOptionsAsync(request, runtime);
        }

        public CreateDBLinkResponse CreateDBLinkWithOptions(CreateDBLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBLinkResponse>(DoRPCRequest("CreateDBLink", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDBLinkResponse> CreateDBLinkWithOptionsAsync(CreateDBLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBLinkResponse>(await DoRPCRequestAsync("CreateDBLink", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDBLinkResponse CreateDBLink(CreateDBLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDBLinkWithOptions(request, runtime);
        }

        public async Task<CreateDBLinkResponse> CreateDBLinkAsync(CreateDBLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDBLinkWithOptionsAsync(request, runtime);
        }

        public CreateDBNodesResponse CreateDBNodesWithOptions(CreateDBNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBNodesResponse>(DoRPCRequest("CreateDBNodes", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDBNodesResponse> CreateDBNodesWithOptionsAsync(CreateDBNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBNodesResponse>(await DoRPCRequestAsync("CreateDBNodes", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDBNodesResponse CreateDBNodes(CreateDBNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDBNodesWithOptions(request, runtime);
        }

        public async Task<CreateDBNodesResponse> CreateDBNodesAsync(CreateDBNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDBNodesWithOptionsAsync(request, runtime);
        }

        public CreateGlobalDatabaseNetworkResponse CreateGlobalDatabaseNetworkWithOptions(CreateGlobalDatabaseNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGlobalDatabaseNetworkResponse>(DoRPCRequest("CreateGlobalDatabaseNetwork", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateGlobalDatabaseNetworkResponse> CreateGlobalDatabaseNetworkWithOptionsAsync(CreateGlobalDatabaseNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGlobalDatabaseNetworkResponse>(await DoRPCRequestAsync("CreateGlobalDatabaseNetwork", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateGlobalDatabaseNetworkResponse CreateGlobalDatabaseNetwork(CreateGlobalDatabaseNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGlobalDatabaseNetworkWithOptions(request, runtime);
        }

        public async Task<CreateGlobalDatabaseNetworkResponse> CreateGlobalDatabaseNetworkAsync(CreateGlobalDatabaseNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGlobalDatabaseNetworkWithOptionsAsync(request, runtime);
        }

        public CreateParameterGroupResponse CreateParameterGroupWithOptions(CreateParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateParameterGroupResponse>(DoRPCRequest("CreateParameterGroup", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateParameterGroupResponse> CreateParameterGroupWithOptionsAsync(CreateParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateParameterGroupResponse>(await DoRPCRequestAsync("CreateParameterGroup", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateParameterGroupResponse CreateParameterGroup(CreateParameterGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateParameterGroupWithOptions(request, runtime);
        }

        public async Task<CreateParameterGroupResponse> CreateParameterGroupAsync(CreateParameterGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateParameterGroupWithOptionsAsync(request, runtime);
        }

        public DeleteAccountResponse DeleteAccountWithOptions(DeleteAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAccountResponse>(DoRPCRequest("DeleteAccount", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAccountResponse> DeleteAccountWithOptionsAsync(DeleteAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAccountResponse>(await DoRPCRequestAsync("DeleteAccount", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAccountResponse DeleteAccount(DeleteAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccountWithOptions(request, runtime);
        }

        public async Task<DeleteAccountResponse> DeleteAccountAsync(DeleteAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccountWithOptionsAsync(request, runtime);
        }

        public DeleteBackupResponse DeleteBackupWithOptions(DeleteBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBackupResponse>(DoRPCRequest("DeleteBackup", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteBackupResponse> DeleteBackupWithOptionsAsync(DeleteBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBackupResponse>(await DoRPCRequestAsync("DeleteBackup", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteBackupResponse DeleteBackup(DeleteBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBackupWithOptions(request, runtime);
        }

        public async Task<DeleteBackupResponse> DeleteBackupAsync(DeleteBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBackupWithOptionsAsync(request, runtime);
        }

        public DeleteDatabaseResponse DeleteDatabaseWithOptions(DeleteDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDatabaseResponse>(DoRPCRequest("DeleteDatabase", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDatabaseResponse> DeleteDatabaseWithOptionsAsync(DeleteDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDatabaseResponse>(await DoRPCRequestAsync("DeleteDatabase", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDatabaseResponse DeleteDatabase(DeleteDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDatabaseWithOptions(request, runtime);
        }

        public async Task<DeleteDatabaseResponse> DeleteDatabaseAsync(DeleteDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDatabaseWithOptionsAsync(request, runtime);
        }

        public DeleteDBClusterResponse DeleteDBClusterWithOptions(DeleteDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDBClusterResponse>(DoRPCRequest("DeleteDBCluster", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDBClusterResponse> DeleteDBClusterWithOptionsAsync(DeleteDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDBClusterResponse>(await DoRPCRequestAsync("DeleteDBCluster", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDBClusterResponse DeleteDBCluster(DeleteDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDBClusterWithOptions(request, runtime);
        }

        public async Task<DeleteDBClusterResponse> DeleteDBClusterAsync(DeleteDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDBClusterWithOptionsAsync(request, runtime);
        }

        public DeleteDBClusterEndpointResponse DeleteDBClusterEndpointWithOptions(DeleteDBClusterEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDBClusterEndpointResponse>(DoRPCRequest("DeleteDBClusterEndpoint", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDBClusterEndpointResponse> DeleteDBClusterEndpointWithOptionsAsync(DeleteDBClusterEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDBClusterEndpointResponse>(await DoRPCRequestAsync("DeleteDBClusterEndpoint", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDBClusterEndpointResponse DeleteDBClusterEndpoint(DeleteDBClusterEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDBClusterEndpointWithOptions(request, runtime);
        }

        public async Task<DeleteDBClusterEndpointResponse> DeleteDBClusterEndpointAsync(DeleteDBClusterEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDBClusterEndpointWithOptionsAsync(request, runtime);
        }

        public DeleteDBEndpointAddressResponse DeleteDBEndpointAddressWithOptions(DeleteDBEndpointAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDBEndpointAddressResponse>(DoRPCRequest("DeleteDBEndpointAddress", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDBEndpointAddressResponse> DeleteDBEndpointAddressWithOptionsAsync(DeleteDBEndpointAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDBEndpointAddressResponse>(await DoRPCRequestAsync("DeleteDBEndpointAddress", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDBEndpointAddressResponse DeleteDBEndpointAddress(DeleteDBEndpointAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDBEndpointAddressWithOptions(request, runtime);
        }

        public async Task<DeleteDBEndpointAddressResponse> DeleteDBEndpointAddressAsync(DeleteDBEndpointAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDBEndpointAddressWithOptionsAsync(request, runtime);
        }

        public DeleteDBLinkResponse DeleteDBLinkWithOptions(DeleteDBLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDBLinkResponse>(DoRPCRequest("DeleteDBLink", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDBLinkResponse> DeleteDBLinkWithOptionsAsync(DeleteDBLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDBLinkResponse>(await DoRPCRequestAsync("DeleteDBLink", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDBLinkResponse DeleteDBLink(DeleteDBLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDBLinkWithOptions(request, runtime);
        }

        public async Task<DeleteDBLinkResponse> DeleteDBLinkAsync(DeleteDBLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDBLinkWithOptionsAsync(request, runtime);
        }

        public DeleteDBNodesResponse DeleteDBNodesWithOptions(DeleteDBNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDBNodesResponse>(DoRPCRequest("DeleteDBNodes", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDBNodesResponse> DeleteDBNodesWithOptionsAsync(DeleteDBNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDBNodesResponse>(await DoRPCRequestAsync("DeleteDBNodes", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDBNodesResponse DeleteDBNodes(DeleteDBNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDBNodesWithOptions(request, runtime);
        }

        public async Task<DeleteDBNodesResponse> DeleteDBNodesAsync(DeleteDBNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDBNodesWithOptionsAsync(request, runtime);
        }

        public DeleteGlobalDatabaseNetworkResponse DeleteGlobalDatabaseNetworkWithOptions(DeleteGlobalDatabaseNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGlobalDatabaseNetworkResponse>(DoRPCRequest("DeleteGlobalDatabaseNetwork", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteGlobalDatabaseNetworkResponse> DeleteGlobalDatabaseNetworkWithOptionsAsync(DeleteGlobalDatabaseNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGlobalDatabaseNetworkResponse>(await DoRPCRequestAsync("DeleteGlobalDatabaseNetwork", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteGlobalDatabaseNetworkResponse DeleteGlobalDatabaseNetwork(DeleteGlobalDatabaseNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGlobalDatabaseNetworkWithOptions(request, runtime);
        }

        public async Task<DeleteGlobalDatabaseNetworkResponse> DeleteGlobalDatabaseNetworkAsync(DeleteGlobalDatabaseNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGlobalDatabaseNetworkWithOptionsAsync(request, runtime);
        }

        public DeleteParameterGroupResponse DeleteParameterGroupWithOptions(DeleteParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteParameterGroupResponse>(DoRPCRequest("DeleteParameterGroup", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteParameterGroupResponse> DeleteParameterGroupWithOptionsAsync(DeleteParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteParameterGroupResponse>(await DoRPCRequestAsync("DeleteParameterGroup", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteParameterGroupResponse DeleteParameterGroup(DeleteParameterGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteParameterGroupWithOptions(request, runtime);
        }

        public async Task<DeleteParameterGroupResponse> DeleteParameterGroupAsync(DeleteParameterGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteParameterGroupWithOptionsAsync(request, runtime);
        }

        public DescribeAccountsResponse DescribeAccountsWithOptions(DescribeAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccountsResponse>(DoRPCRequest("DescribeAccounts", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAccountsResponse> DescribeAccountsWithOptionsAsync(DescribeAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccountsResponse>(await DoRPCRequestAsync("DescribeAccounts", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeAutoRenewAttributeResponse DescribeAutoRenewAttributeWithOptions(DescribeAutoRenewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoRenewAttributeResponse>(DoRPCRequest("DescribeAutoRenewAttribute", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAutoRenewAttributeResponse> DescribeAutoRenewAttributeWithOptionsAsync(DescribeAutoRenewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoRenewAttributeResponse>(await DoRPCRequestAsync("DescribeAutoRenewAttribute", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAutoRenewAttributeResponse DescribeAutoRenewAttribute(DescribeAutoRenewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoRenewAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeAutoRenewAttributeResponse> DescribeAutoRenewAttributeAsync(DescribeAutoRenewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoRenewAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeBackupLogsResponse DescribeBackupLogsWithOptions(DescribeBackupLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupLogsResponse>(DoRPCRequest("DescribeBackupLogs", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupLogsResponse> DescribeBackupLogsWithOptionsAsync(DescribeBackupLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupLogsResponse>(await DoRPCRequestAsync("DescribeBackupLogs", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackupLogsResponse DescribeBackupLogs(DescribeBackupLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupLogsWithOptions(request, runtime);
        }

        public async Task<DescribeBackupLogsResponse> DescribeBackupLogsAsync(DescribeBackupLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupLogsWithOptionsAsync(request, runtime);
        }

        public DescribeBackupPolicyResponse DescribeBackupPolicyWithOptions(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPolicyResponse>(DoRPCRequest("DescribeBackupPolicy", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupPolicyResponse> DescribeBackupPolicyWithOptionsAsync(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPolicyResponse>(await DoRPCRequestAsync("DescribeBackupPolicy", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackupPolicyResponse DescribeBackupPolicy(DescribeBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupPolicyWithOptions(request, runtime);
        }

        public async Task<DescribeBackupPolicyResponse> DescribeBackupPolicyAsync(DescribeBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupPolicyWithOptionsAsync(request, runtime);
        }

        public DescribeBackupsResponse DescribeBackupsWithOptions(DescribeBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupsResponse>(DoRPCRequest("DescribeBackups", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupsResponse> DescribeBackupsWithOptionsAsync(DescribeBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupsResponse>(await DoRPCRequestAsync("DescribeBackups", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeBackupTasksResponse DescribeBackupTasksWithOptions(DescribeBackupTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupTasksResponse>(DoRPCRequest("DescribeBackupTasks", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupTasksResponse> DescribeBackupTasksWithOptionsAsync(DescribeBackupTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupTasksResponse>(await DoRPCRequestAsync("DescribeBackupTasks", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackupTasksResponse DescribeBackupTasks(DescribeBackupTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupTasksWithOptions(request, runtime);
        }

        public async Task<DescribeBackupTasksResponse> DescribeBackupTasksAsync(DescribeBackupTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupTasksWithOptionsAsync(request, runtime);
        }

        public DescribeCharacterSetNameResponse DescribeCharacterSetNameWithOptions(DescribeCharacterSetNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCharacterSetNameResponse>(DoRPCRequest("DescribeCharacterSetName", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCharacterSetNameResponse> DescribeCharacterSetNameWithOptionsAsync(DescribeCharacterSetNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCharacterSetNameResponse>(await DoRPCRequestAsync("DescribeCharacterSetName", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCharacterSetNameResponse DescribeCharacterSetName(DescribeCharacterSetNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCharacterSetNameWithOptions(request, runtime);
        }

        public async Task<DescribeCharacterSetNameResponse> DescribeCharacterSetNameAsync(DescribeCharacterSetNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCharacterSetNameWithOptionsAsync(request, runtime);
        }

        public DescribeDatabasesResponse DescribeDatabasesWithOptions(DescribeDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDatabasesResponse>(DoRPCRequest("DescribeDatabases", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDatabasesResponse> DescribeDatabasesWithOptionsAsync(DescribeDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDatabasesResponse>(await DoRPCRequestAsync("DescribeDatabases", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDatabasesResponse DescribeDatabases(DescribeDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDatabasesWithOptions(request, runtime);
        }

        public async Task<DescribeDatabasesResponse> DescribeDatabasesAsync(DescribeDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDatabasesWithOptionsAsync(request, runtime);
        }

        public DescribeDBClusterAccessWhitelistResponse DescribeDBClusterAccessWhitelistWithOptions(DescribeDBClusterAccessWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterAccessWhitelistResponse>(DoRPCRequest("DescribeDBClusterAccessWhitelist", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBClusterAccessWhitelistResponse> DescribeDBClusterAccessWhitelistWithOptionsAsync(DescribeDBClusterAccessWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterAccessWhitelistResponse>(await DoRPCRequestAsync("DescribeDBClusterAccessWhitelist", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBClusterAccessWhitelistResponse DescribeDBClusterAccessWhitelist(DescribeDBClusterAccessWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClusterAccessWhitelistWithOptions(request, runtime);
        }

        public async Task<DescribeDBClusterAccessWhitelistResponse> DescribeDBClusterAccessWhitelistAsync(DescribeDBClusterAccessWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClusterAccessWhitelistWithOptionsAsync(request, runtime);
        }

        public DescribeDBClusterAttributeResponse DescribeDBClusterAttributeWithOptions(DescribeDBClusterAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterAttributeResponse>(DoRPCRequest("DescribeDBClusterAttribute", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBClusterAttributeResponse> DescribeDBClusterAttributeWithOptionsAsync(DescribeDBClusterAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterAttributeResponse>(await DoRPCRequestAsync("DescribeDBClusterAttribute", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBClusterAttributeResponse DescribeDBClusterAttribute(DescribeDBClusterAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClusterAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeDBClusterAttributeResponse> DescribeDBClusterAttributeAsync(DescribeDBClusterAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClusterAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeDBClusterAuditLogCollectorResponse DescribeDBClusterAuditLogCollectorWithOptions(DescribeDBClusterAuditLogCollectorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterAuditLogCollectorResponse>(DoRPCRequest("DescribeDBClusterAuditLogCollector", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBClusterAuditLogCollectorResponse> DescribeDBClusterAuditLogCollectorWithOptionsAsync(DescribeDBClusterAuditLogCollectorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterAuditLogCollectorResponse>(await DoRPCRequestAsync("DescribeDBClusterAuditLogCollector", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBClusterAuditLogCollectorResponse DescribeDBClusterAuditLogCollector(DescribeDBClusterAuditLogCollectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClusterAuditLogCollectorWithOptions(request, runtime);
        }

        public async Task<DescribeDBClusterAuditLogCollectorResponse> DescribeDBClusterAuditLogCollectorAsync(DescribeDBClusterAuditLogCollectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClusterAuditLogCollectorWithOptionsAsync(request, runtime);
        }

        public DescribeDBClusterAvailableResourcesResponse DescribeDBClusterAvailableResourcesWithOptions(DescribeDBClusterAvailableResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterAvailableResourcesResponse>(DoRPCRequest("DescribeDBClusterAvailableResources", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBClusterAvailableResourcesResponse> DescribeDBClusterAvailableResourcesWithOptionsAsync(DescribeDBClusterAvailableResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterAvailableResourcesResponse>(await DoRPCRequestAsync("DescribeDBClusterAvailableResources", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBClusterAvailableResourcesResponse DescribeDBClusterAvailableResources(DescribeDBClusterAvailableResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClusterAvailableResourcesWithOptions(request, runtime);
        }

        public async Task<DescribeDBClusterAvailableResourcesResponse> DescribeDBClusterAvailableResourcesAsync(DescribeDBClusterAvailableResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClusterAvailableResourcesWithOptionsAsync(request, runtime);
        }

        public DescribeDBClusterEndpointsResponse DescribeDBClusterEndpointsWithOptions(DescribeDBClusterEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterEndpointsResponse>(DoRPCRequest("DescribeDBClusterEndpoints", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBClusterEndpointsResponse> DescribeDBClusterEndpointsWithOptionsAsync(DescribeDBClusterEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterEndpointsResponse>(await DoRPCRequestAsync("DescribeDBClusterEndpoints", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBClusterEndpointsResponse DescribeDBClusterEndpoints(DescribeDBClusterEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClusterEndpointsWithOptions(request, runtime);
        }

        public async Task<DescribeDBClusterEndpointsResponse> DescribeDBClusterEndpointsAsync(DescribeDBClusterEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClusterEndpointsWithOptionsAsync(request, runtime);
        }

        public DescribeDBClusterMigrationResponse DescribeDBClusterMigrationWithOptions(DescribeDBClusterMigrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterMigrationResponse>(DoRPCRequest("DescribeDBClusterMigration", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBClusterMigrationResponse> DescribeDBClusterMigrationWithOptionsAsync(DescribeDBClusterMigrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterMigrationResponse>(await DoRPCRequestAsync("DescribeDBClusterMigration", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBClusterMigrationResponse DescribeDBClusterMigration(DescribeDBClusterMigrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClusterMigrationWithOptions(request, runtime);
        }

        public async Task<DescribeDBClusterMigrationResponse> DescribeDBClusterMigrationAsync(DescribeDBClusterMigrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClusterMigrationWithOptionsAsync(request, runtime);
        }

        public DescribeDBClusterMonitorResponse DescribeDBClusterMonitorWithOptions(DescribeDBClusterMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterMonitorResponse>(DoRPCRequest("DescribeDBClusterMonitor", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBClusterMonitorResponse> DescribeDBClusterMonitorWithOptionsAsync(DescribeDBClusterMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterMonitorResponse>(await DoRPCRequestAsync("DescribeDBClusterMonitor", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBClusterMonitorResponse DescribeDBClusterMonitor(DescribeDBClusterMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClusterMonitorWithOptions(request, runtime);
        }

        public async Task<DescribeDBClusterMonitorResponse> DescribeDBClusterMonitorAsync(DescribeDBClusterMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClusterMonitorWithOptionsAsync(request, runtime);
        }

        public DescribeDBClusterParametersResponse DescribeDBClusterParametersWithOptions(DescribeDBClusterParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterParametersResponse>(DoRPCRequest("DescribeDBClusterParameters", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBClusterParametersResponse> DescribeDBClusterParametersWithOptionsAsync(DescribeDBClusterParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterParametersResponse>(await DoRPCRequestAsync("DescribeDBClusterParameters", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBClusterParametersResponse DescribeDBClusterParameters(DescribeDBClusterParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClusterParametersWithOptions(request, runtime);
        }

        public async Task<DescribeDBClusterParametersResponse> DescribeDBClusterParametersAsync(DescribeDBClusterParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClusterParametersWithOptionsAsync(request, runtime);
        }

        public DescribeDBClusterPerformanceResponse DescribeDBClusterPerformanceWithOptions(DescribeDBClusterPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterPerformanceResponse>(DoRPCRequest("DescribeDBClusterPerformance", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBClusterPerformanceResponse> DescribeDBClusterPerformanceWithOptionsAsync(DescribeDBClusterPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterPerformanceResponse>(await DoRPCRequestAsync("DescribeDBClusterPerformance", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBClusterPerformanceResponse DescribeDBClusterPerformance(DescribeDBClusterPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClusterPerformanceWithOptions(request, runtime);
        }

        public async Task<DescribeDBClusterPerformanceResponse> DescribeDBClusterPerformanceAsync(DescribeDBClusterPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClusterPerformanceWithOptionsAsync(request, runtime);
        }

        public DescribeDBClustersResponse DescribeDBClustersWithOptions(DescribeDBClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClustersResponse>(DoRPCRequest("DescribeDBClusters", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBClustersResponse> DescribeDBClustersWithOptionsAsync(DescribeDBClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClustersResponse>(await DoRPCRequestAsync("DescribeDBClusters", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBClustersResponse DescribeDBClusters(DescribeDBClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClustersWithOptions(request, runtime);
        }

        public async Task<DescribeDBClustersResponse> DescribeDBClustersAsync(DescribeDBClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClustersWithOptionsAsync(request, runtime);
        }

        public DescribeDBClusterSSLResponse DescribeDBClusterSSLWithOptions(DescribeDBClusterSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterSSLResponse>(DoRPCRequest("DescribeDBClusterSSL", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBClusterSSLResponse> DescribeDBClusterSSLWithOptionsAsync(DescribeDBClusterSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterSSLResponse>(await DoRPCRequestAsync("DescribeDBClusterSSL", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBClusterSSLResponse DescribeDBClusterSSL(DescribeDBClusterSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClusterSSLWithOptions(request, runtime);
        }

        public async Task<DescribeDBClusterSSLResponse> DescribeDBClusterSSLAsync(DescribeDBClusterSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClusterSSLWithOptionsAsync(request, runtime);
        }

        public DescribeDBClustersWithBackupsResponse DescribeDBClustersWithBackupsWithOptions(DescribeDBClustersWithBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClustersWithBackupsResponse>(DoRPCRequest("DescribeDBClustersWithBackups", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBClustersWithBackupsResponse> DescribeDBClustersWithBackupsWithOptionsAsync(DescribeDBClustersWithBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClustersWithBackupsResponse>(await DoRPCRequestAsync("DescribeDBClustersWithBackups", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBClustersWithBackupsResponse DescribeDBClustersWithBackups(DescribeDBClustersWithBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClustersWithBackupsWithOptions(request, runtime);
        }

        public async Task<DescribeDBClustersWithBackupsResponse> DescribeDBClustersWithBackupsAsync(DescribeDBClustersWithBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClustersWithBackupsWithOptionsAsync(request, runtime);
        }

        public DescribeDBClusterTDEResponse DescribeDBClusterTDEWithOptions(DescribeDBClusterTDERequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterTDEResponse>(DoRPCRequest("DescribeDBClusterTDE", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBClusterTDEResponse> DescribeDBClusterTDEWithOptionsAsync(DescribeDBClusterTDERequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterTDEResponse>(await DoRPCRequestAsync("DescribeDBClusterTDE", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBClusterTDEResponse DescribeDBClusterTDE(DescribeDBClusterTDERequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClusterTDEWithOptions(request, runtime);
        }

        public async Task<DescribeDBClusterTDEResponse> DescribeDBClusterTDEAsync(DescribeDBClusterTDERequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClusterTDEWithOptionsAsync(request, runtime);
        }

        public DescribeDBClusterVersionResponse DescribeDBClusterVersionWithOptions(DescribeDBClusterVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterVersionResponse>(DoRPCRequest("DescribeDBClusterVersion", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBClusterVersionResponse> DescribeDBClusterVersionWithOptionsAsync(DescribeDBClusterVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBClusterVersionResponse>(await DoRPCRequestAsync("DescribeDBClusterVersion", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBClusterVersionResponse DescribeDBClusterVersion(DescribeDBClusterVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClusterVersionWithOptions(request, runtime);
        }

        public async Task<DescribeDBClusterVersionResponse> DescribeDBClusterVersionAsync(DescribeDBClusterVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClusterVersionWithOptionsAsync(request, runtime);
        }

        public DescribeDBInitializeVariableResponse DescribeDBInitializeVariableWithOptions(DescribeDBInitializeVariableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInitializeVariableResponse>(DoRPCRequest("DescribeDBInitializeVariable", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInitializeVariableResponse> DescribeDBInitializeVariableWithOptionsAsync(DescribeDBInitializeVariableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInitializeVariableResponse>(await DoRPCRequestAsync("DescribeDBInitializeVariable", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInitializeVariableResponse DescribeDBInitializeVariable(DescribeDBInitializeVariableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInitializeVariableWithOptions(request, runtime);
        }

        public async Task<DescribeDBInitializeVariableResponse> DescribeDBInitializeVariableAsync(DescribeDBInitializeVariableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInitializeVariableWithOptionsAsync(request, runtime);
        }

        public DescribeDBLinksResponse DescribeDBLinksWithOptions(DescribeDBLinksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBLinksResponse>(DoRPCRequest("DescribeDBLinks", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBLinksResponse> DescribeDBLinksWithOptionsAsync(DescribeDBLinksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBLinksResponse>(await DoRPCRequestAsync("DescribeDBLinks", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBLinksResponse DescribeDBLinks(DescribeDBLinksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBLinksWithOptions(request, runtime);
        }

        public async Task<DescribeDBLinksResponse> DescribeDBLinksAsync(DescribeDBLinksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBLinksWithOptionsAsync(request, runtime);
        }

        public DescribeDBNodePerformanceResponse DescribeDBNodePerformanceWithOptions(DescribeDBNodePerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBNodePerformanceResponse>(DoRPCRequest("DescribeDBNodePerformance", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBNodePerformanceResponse> DescribeDBNodePerformanceWithOptionsAsync(DescribeDBNodePerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBNodePerformanceResponse>(await DoRPCRequestAsync("DescribeDBNodePerformance", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBNodePerformanceResponse DescribeDBNodePerformance(DescribeDBNodePerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBNodePerformanceWithOptions(request, runtime);
        }

        public async Task<DescribeDBNodePerformanceResponse> DescribeDBNodePerformanceAsync(DescribeDBNodePerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBNodePerformanceWithOptionsAsync(request, runtime);
        }

        public DescribeDetachedBackupsResponse DescribeDetachedBackupsWithOptions(DescribeDetachedBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDetachedBackupsResponse>(DoRPCRequest("DescribeDetachedBackups", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDetachedBackupsResponse> DescribeDetachedBackupsWithOptionsAsync(DescribeDetachedBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDetachedBackupsResponse>(await DoRPCRequestAsync("DescribeDetachedBackups", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDetachedBackupsResponse DescribeDetachedBackups(DescribeDetachedBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDetachedBackupsWithOptions(request, runtime);
        }

        public async Task<DescribeDetachedBackupsResponse> DescribeDetachedBackupsAsync(DescribeDetachedBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDetachedBackupsWithOptionsAsync(request, runtime);
        }

        public DescribeGlobalDatabaseNetworkResponse DescribeGlobalDatabaseNetworkWithOptions(DescribeGlobalDatabaseNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGlobalDatabaseNetworkResponse>(DoRPCRequest("DescribeGlobalDatabaseNetwork", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGlobalDatabaseNetworkResponse> DescribeGlobalDatabaseNetworkWithOptionsAsync(DescribeGlobalDatabaseNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGlobalDatabaseNetworkResponse>(await DoRPCRequestAsync("DescribeGlobalDatabaseNetwork", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGlobalDatabaseNetworkResponse DescribeGlobalDatabaseNetwork(DescribeGlobalDatabaseNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGlobalDatabaseNetworkWithOptions(request, runtime);
        }

        public async Task<DescribeGlobalDatabaseNetworkResponse> DescribeGlobalDatabaseNetworkAsync(DescribeGlobalDatabaseNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGlobalDatabaseNetworkWithOptionsAsync(request, runtime);
        }

        public DescribeGlobalDatabaseNetworksResponse DescribeGlobalDatabaseNetworksWithOptions(DescribeGlobalDatabaseNetworksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGlobalDatabaseNetworksResponse>(DoRPCRequest("DescribeGlobalDatabaseNetworks", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGlobalDatabaseNetworksResponse> DescribeGlobalDatabaseNetworksWithOptionsAsync(DescribeGlobalDatabaseNetworksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGlobalDatabaseNetworksResponse>(await DoRPCRequestAsync("DescribeGlobalDatabaseNetworks", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGlobalDatabaseNetworksResponse DescribeGlobalDatabaseNetworks(DescribeGlobalDatabaseNetworksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGlobalDatabaseNetworksWithOptions(request, runtime);
        }

        public async Task<DescribeGlobalDatabaseNetworksResponse> DescribeGlobalDatabaseNetworksAsync(DescribeGlobalDatabaseNetworksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGlobalDatabaseNetworksWithOptionsAsync(request, runtime);
        }

        public DescribeLogBackupPolicyResponse DescribeLogBackupPolicyWithOptions(DescribeLogBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLogBackupPolicyResponse>(DoRPCRequest("DescribeLogBackupPolicy", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLogBackupPolicyResponse> DescribeLogBackupPolicyWithOptionsAsync(DescribeLogBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLogBackupPolicyResponse>(await DoRPCRequestAsync("DescribeLogBackupPolicy", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLogBackupPolicyResponse DescribeLogBackupPolicy(DescribeLogBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogBackupPolicyWithOptions(request, runtime);
        }

        public async Task<DescribeLogBackupPolicyResponse> DescribeLogBackupPolicyAsync(DescribeLogBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogBackupPolicyWithOptionsAsync(request, runtime);
        }

        public DescribeMetaListResponse DescribeMetaListWithOptions(DescribeMetaListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetaListResponse>(DoRPCRequest("DescribeMetaList", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMetaListResponse> DescribeMetaListWithOptionsAsync(DescribeMetaListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetaListResponse>(await DoRPCRequestAsync("DescribeMetaList", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMetaListResponse DescribeMetaList(DescribeMetaListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetaListWithOptions(request, runtime);
        }

        public async Task<DescribeMetaListResponse> DescribeMetaListAsync(DescribeMetaListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetaListWithOptionsAsync(request, runtime);
        }

        public DescribeParameterGroupResponse DescribeParameterGroupWithOptions(DescribeParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParameterGroupResponse>(DoRPCRequest("DescribeParameterGroup", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeParameterGroupResponse> DescribeParameterGroupWithOptionsAsync(DescribeParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParameterGroupResponse>(await DoRPCRequestAsync("DescribeParameterGroup", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeParameterGroupResponse DescribeParameterGroup(DescribeParameterGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeParameterGroupWithOptions(request, runtime);
        }

        public async Task<DescribeParameterGroupResponse> DescribeParameterGroupAsync(DescribeParameterGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeParameterGroupWithOptionsAsync(request, runtime);
        }

        public DescribeParameterGroupsResponse DescribeParameterGroupsWithOptions(DescribeParameterGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParameterGroupsResponse>(DoRPCRequest("DescribeParameterGroups", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeParameterGroupsResponse> DescribeParameterGroupsWithOptionsAsync(DescribeParameterGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParameterGroupsResponse>(await DoRPCRequestAsync("DescribeParameterGroups", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeParameterGroupsResponse DescribeParameterGroups(DescribeParameterGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeParameterGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeParameterGroupsResponse> DescribeParameterGroupsAsync(DescribeParameterGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeParameterGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeParameterTemplatesResponse DescribeParameterTemplatesWithOptions(DescribeParameterTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParameterTemplatesResponse>(DoRPCRequest("DescribeParameterTemplates", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeParameterTemplatesResponse> DescribeParameterTemplatesWithOptionsAsync(DescribeParameterTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParameterTemplatesResponse>(await DoRPCRequestAsync("DescribeParameterTemplates", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeParameterTemplatesResponse DescribeParameterTemplates(DescribeParameterTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeParameterTemplatesWithOptions(request, runtime);
        }

        public async Task<DescribeParameterTemplatesResponse> DescribeParameterTemplatesAsync(DescribeParameterTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeParameterTemplatesWithOptionsAsync(request, runtime);
        }

        public DescribePendingMaintenanceActionResponse DescribePendingMaintenanceActionWithOptions(DescribePendingMaintenanceActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePendingMaintenanceActionResponse>(DoRPCRequest("DescribePendingMaintenanceAction", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePendingMaintenanceActionResponse> DescribePendingMaintenanceActionWithOptionsAsync(DescribePendingMaintenanceActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePendingMaintenanceActionResponse>(await DoRPCRequestAsync("DescribePendingMaintenanceAction", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePendingMaintenanceActionResponse DescribePendingMaintenanceAction(DescribePendingMaintenanceActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePendingMaintenanceActionWithOptions(request, runtime);
        }

        public async Task<DescribePendingMaintenanceActionResponse> DescribePendingMaintenanceActionAsync(DescribePendingMaintenanceActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePendingMaintenanceActionWithOptionsAsync(request, runtime);
        }

        public DescribePendingMaintenanceActionsResponse DescribePendingMaintenanceActionsWithOptions(DescribePendingMaintenanceActionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePendingMaintenanceActionsResponse>(DoRPCRequest("DescribePendingMaintenanceActions", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePendingMaintenanceActionsResponse> DescribePendingMaintenanceActionsWithOptionsAsync(DescribePendingMaintenanceActionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePendingMaintenanceActionsResponse>(await DoRPCRequestAsync("DescribePendingMaintenanceActions", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePendingMaintenanceActionsResponse DescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePendingMaintenanceActionsWithOptions(request, runtime);
        }

        public async Task<DescribePendingMaintenanceActionsResponse> DescribePendingMaintenanceActionsAsync(DescribePendingMaintenanceActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePendingMaintenanceActionsWithOptionsAsync(request, runtime);
        }

        public DescribePolarSQLCollectorPolicyResponse DescribePolarSQLCollectorPolicyWithOptions(DescribePolarSQLCollectorPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribePolarSQLCollectorPolicyResponse>(DoRPCRequest("DescribePolarSQLCollectorPolicy", "2017-08-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribePolarSQLCollectorPolicyResponse> DescribePolarSQLCollectorPolicyWithOptionsAsync(DescribePolarSQLCollectorPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribePolarSQLCollectorPolicyResponse>(await DoRPCRequestAsync("DescribePolarSQLCollectorPolicy", "2017-08-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribePolarSQLCollectorPolicyResponse DescribePolarSQLCollectorPolicy(DescribePolarSQLCollectorPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePolarSQLCollectorPolicyWithOptions(request, runtime);
        }

        public async Task<DescribePolarSQLCollectorPolicyResponse> DescribePolarSQLCollectorPolicyAsync(DescribePolarSQLCollectorPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePolarSQLCollectorPolicyWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeScheduleTasksResponse DescribeScheduleTasksWithOptions(DescribeScheduleTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScheduleTasksResponse>(DoRPCRequest("DescribeScheduleTasks", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScheduleTasksResponse> DescribeScheduleTasksWithOptionsAsync(DescribeScheduleTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScheduleTasksResponse>(await DoRPCRequestAsync("DescribeScheduleTasks", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScheduleTasksResponse DescribeScheduleTasks(DescribeScheduleTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScheduleTasksWithOptions(request, runtime);
        }

        public async Task<DescribeScheduleTasksResponse> DescribeScheduleTasksAsync(DescribeScheduleTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScheduleTasksWithOptionsAsync(request, runtime);
        }

        public DescribeSlowLogRecordsResponse DescribeSlowLogRecordsWithOptions(DescribeSlowLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlowLogRecordsResponse>(DoRPCRequest("DescribeSlowLogRecords", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSlowLogRecordsResponse> DescribeSlowLogRecordsWithOptionsAsync(DescribeSlowLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlowLogRecordsResponse>(await DoRPCRequestAsync("DescribeSlowLogRecords", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSlowLogRecordsResponse DescribeSlowLogRecords(DescribeSlowLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlowLogRecordsWithOptions(request, runtime);
        }

        public async Task<DescribeSlowLogRecordsResponse> DescribeSlowLogRecordsAsync(DescribeSlowLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlowLogRecordsWithOptionsAsync(request, runtime);
        }

        public DescribeTasksResponse DescribeTasksWithOptions(DescribeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTasksResponse>(DoRPCRequest("DescribeTasks", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTasksResponse> DescribeTasksWithOptionsAsync(DescribeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTasksResponse>(await DoRPCRequestAsync("DescribeTasks", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTasksResponse DescribeTasks(DescribeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTasksWithOptions(request, runtime);
        }

        public async Task<DescribeTasksResponse> DescribeTasksAsync(DescribeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTasksWithOptionsAsync(request, runtime);
        }

        public FailoverDBClusterResponse FailoverDBClusterWithOptions(FailoverDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FailoverDBClusterResponse>(DoRPCRequest("FailoverDBCluster", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FailoverDBClusterResponse> FailoverDBClusterWithOptionsAsync(FailoverDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FailoverDBClusterResponse>(await DoRPCRequestAsync("FailoverDBCluster", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FailoverDBClusterResponse FailoverDBCluster(FailoverDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FailoverDBClusterWithOptions(request, runtime);
        }

        public async Task<FailoverDBClusterResponse> FailoverDBClusterAsync(FailoverDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FailoverDBClusterWithOptionsAsync(request, runtime);
        }

        public GrantAccountPrivilegeResponse GrantAccountPrivilegeWithOptions(GrantAccountPrivilegeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GrantAccountPrivilegeResponse>(DoRPCRequest("GrantAccountPrivilege", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GrantAccountPrivilegeResponse> GrantAccountPrivilegeWithOptionsAsync(GrantAccountPrivilegeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GrantAccountPrivilegeResponse>(await DoRPCRequestAsync("GrantAccountPrivilege", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GrantAccountPrivilegeResponse GrantAccountPrivilege(GrantAccountPrivilegeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantAccountPrivilegeWithOptions(request, runtime);
        }

        public async Task<GrantAccountPrivilegeResponse> GrantAccountPrivilegeAsync(GrantAccountPrivilegeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantAccountPrivilegeWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyAccountDescriptionResponse ModifyAccountDescriptionWithOptions(ModifyAccountDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccountDescriptionResponse>(DoRPCRequest("ModifyAccountDescription", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAccountDescriptionResponse> ModifyAccountDescriptionWithOptionsAsync(ModifyAccountDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccountDescriptionResponse>(await DoRPCRequestAsync("ModifyAccountDescription", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyAccountDescriptionResponse ModifyAccountDescription(ModifyAccountDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccountDescriptionWithOptions(request, runtime);
        }

        public async Task<ModifyAccountDescriptionResponse> ModifyAccountDescriptionAsync(ModifyAccountDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccountDescriptionWithOptionsAsync(request, runtime);
        }

        public ModifyAccountPasswordResponse ModifyAccountPasswordWithOptions(ModifyAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccountPasswordResponse>(DoRPCRequest("ModifyAccountPassword", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAccountPasswordResponse> ModifyAccountPasswordWithOptionsAsync(ModifyAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccountPasswordResponse>(await DoRPCRequestAsync("ModifyAccountPassword", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyAutoRenewAttributeResponse ModifyAutoRenewAttributeWithOptions(ModifyAutoRenewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAutoRenewAttributeResponse>(DoRPCRequest("ModifyAutoRenewAttribute", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAutoRenewAttributeResponse> ModifyAutoRenewAttributeWithOptionsAsync(ModifyAutoRenewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAutoRenewAttributeResponse>(await DoRPCRequestAsync("ModifyAutoRenewAttribute", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyAutoRenewAttributeResponse ModifyAutoRenewAttribute(ModifyAutoRenewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAutoRenewAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyAutoRenewAttributeResponse> ModifyAutoRenewAttributeAsync(ModifyAutoRenewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAutoRenewAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyBackupPolicyResponse ModifyBackupPolicyWithOptions(ModifyBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupPolicyResponse>(DoRPCRequest("ModifyBackupPolicy", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBackupPolicyResponse> ModifyBackupPolicyWithOptionsAsync(ModifyBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupPolicyResponse>(await DoRPCRequestAsync("ModifyBackupPolicy", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyBackupPolicyResponse ModifyBackupPolicy(ModifyBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupPolicyWithOptions(request, runtime);
        }

        public async Task<ModifyBackupPolicyResponse> ModifyBackupPolicyAsync(ModifyBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupPolicyWithOptionsAsync(request, runtime);
        }

        public ModifyDBClusterAccessWhitelistResponse ModifyDBClusterAccessWhitelistWithOptions(ModifyDBClusterAccessWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterAccessWhitelistResponse>(DoRPCRequest("ModifyDBClusterAccessWhitelist", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBClusterAccessWhitelistResponse> ModifyDBClusterAccessWhitelistWithOptionsAsync(ModifyDBClusterAccessWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterAccessWhitelistResponse>(await DoRPCRequestAsync("ModifyDBClusterAccessWhitelist", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBClusterAccessWhitelistResponse ModifyDBClusterAccessWhitelist(ModifyDBClusterAccessWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBClusterAccessWhitelistWithOptions(request, runtime);
        }

        public async Task<ModifyDBClusterAccessWhitelistResponse> ModifyDBClusterAccessWhitelistAsync(ModifyDBClusterAccessWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBClusterAccessWhitelistWithOptionsAsync(request, runtime);
        }

        public ModifyDBClusterAuditLogCollectorResponse ModifyDBClusterAuditLogCollectorWithOptions(ModifyDBClusterAuditLogCollectorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterAuditLogCollectorResponse>(DoRPCRequest("ModifyDBClusterAuditLogCollector", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBClusterAuditLogCollectorResponse> ModifyDBClusterAuditLogCollectorWithOptionsAsync(ModifyDBClusterAuditLogCollectorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterAuditLogCollectorResponse>(await DoRPCRequestAsync("ModifyDBClusterAuditLogCollector", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBClusterAuditLogCollectorResponse ModifyDBClusterAuditLogCollector(ModifyDBClusterAuditLogCollectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBClusterAuditLogCollectorWithOptions(request, runtime);
        }

        public async Task<ModifyDBClusterAuditLogCollectorResponse> ModifyDBClusterAuditLogCollectorAsync(ModifyDBClusterAuditLogCollectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBClusterAuditLogCollectorWithOptionsAsync(request, runtime);
        }

        public ModifyDBClusterDescriptionResponse ModifyDBClusterDescriptionWithOptions(ModifyDBClusterDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterDescriptionResponse>(DoRPCRequest("ModifyDBClusterDescription", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBClusterDescriptionResponse> ModifyDBClusterDescriptionWithOptionsAsync(ModifyDBClusterDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterDescriptionResponse>(await DoRPCRequestAsync("ModifyDBClusterDescription", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBClusterDescriptionResponse ModifyDBClusterDescription(ModifyDBClusterDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBClusterDescriptionWithOptions(request, runtime);
        }

        public async Task<ModifyDBClusterDescriptionResponse> ModifyDBClusterDescriptionAsync(ModifyDBClusterDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBClusterDescriptionWithOptionsAsync(request, runtime);
        }

        public ModifyDBClusterEndpointResponse ModifyDBClusterEndpointWithOptions(ModifyDBClusterEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterEndpointResponse>(DoRPCRequest("ModifyDBClusterEndpoint", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBClusterEndpointResponse> ModifyDBClusterEndpointWithOptionsAsync(ModifyDBClusterEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterEndpointResponse>(await DoRPCRequestAsync("ModifyDBClusterEndpoint", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBClusterEndpointResponse ModifyDBClusterEndpoint(ModifyDBClusterEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBClusterEndpointWithOptions(request, runtime);
        }

        public async Task<ModifyDBClusterEndpointResponse> ModifyDBClusterEndpointAsync(ModifyDBClusterEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBClusterEndpointWithOptionsAsync(request, runtime);
        }

        public ModifyDBClusterMaintainTimeResponse ModifyDBClusterMaintainTimeWithOptions(ModifyDBClusterMaintainTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterMaintainTimeResponse>(DoRPCRequest("ModifyDBClusterMaintainTime", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBClusterMaintainTimeResponse> ModifyDBClusterMaintainTimeWithOptionsAsync(ModifyDBClusterMaintainTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterMaintainTimeResponse>(await DoRPCRequestAsync("ModifyDBClusterMaintainTime", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBClusterMaintainTimeResponse ModifyDBClusterMaintainTime(ModifyDBClusterMaintainTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBClusterMaintainTimeWithOptions(request, runtime);
        }

        public async Task<ModifyDBClusterMaintainTimeResponse> ModifyDBClusterMaintainTimeAsync(ModifyDBClusterMaintainTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBClusterMaintainTimeWithOptionsAsync(request, runtime);
        }

        public ModifyDBClusterMigrationResponse ModifyDBClusterMigrationWithOptions(ModifyDBClusterMigrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterMigrationResponse>(DoRPCRequest("ModifyDBClusterMigration", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBClusterMigrationResponse> ModifyDBClusterMigrationWithOptionsAsync(ModifyDBClusterMigrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterMigrationResponse>(await DoRPCRequestAsync("ModifyDBClusterMigration", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBClusterMigrationResponse ModifyDBClusterMigration(ModifyDBClusterMigrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBClusterMigrationWithOptions(request, runtime);
        }

        public async Task<ModifyDBClusterMigrationResponse> ModifyDBClusterMigrationAsync(ModifyDBClusterMigrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBClusterMigrationWithOptionsAsync(request, runtime);
        }

        public ModifyDBClusterMonitorResponse ModifyDBClusterMonitorWithOptions(ModifyDBClusterMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterMonitorResponse>(DoRPCRequest("ModifyDBClusterMonitor", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBClusterMonitorResponse> ModifyDBClusterMonitorWithOptionsAsync(ModifyDBClusterMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterMonitorResponse>(await DoRPCRequestAsync("ModifyDBClusterMonitor", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBClusterMonitorResponse ModifyDBClusterMonitor(ModifyDBClusterMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBClusterMonitorWithOptions(request, runtime);
        }

        public async Task<ModifyDBClusterMonitorResponse> ModifyDBClusterMonitorAsync(ModifyDBClusterMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBClusterMonitorWithOptionsAsync(request, runtime);
        }

        public ModifyDBClusterParametersResponse ModifyDBClusterParametersWithOptions(ModifyDBClusterParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterParametersResponse>(DoRPCRequest("ModifyDBClusterParameters", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBClusterParametersResponse> ModifyDBClusterParametersWithOptionsAsync(ModifyDBClusterParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterParametersResponse>(await DoRPCRequestAsync("ModifyDBClusterParameters", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBClusterParametersResponse ModifyDBClusterParameters(ModifyDBClusterParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBClusterParametersWithOptions(request, runtime);
        }

        public async Task<ModifyDBClusterParametersResponse> ModifyDBClusterParametersAsync(ModifyDBClusterParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBClusterParametersWithOptionsAsync(request, runtime);
        }

        public ModifyDBClusterPrimaryZoneResponse ModifyDBClusterPrimaryZoneWithOptions(ModifyDBClusterPrimaryZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterPrimaryZoneResponse>(DoRPCRequest("ModifyDBClusterPrimaryZone", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBClusterPrimaryZoneResponse> ModifyDBClusterPrimaryZoneWithOptionsAsync(ModifyDBClusterPrimaryZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterPrimaryZoneResponse>(await DoRPCRequestAsync("ModifyDBClusterPrimaryZone", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBClusterPrimaryZoneResponse ModifyDBClusterPrimaryZone(ModifyDBClusterPrimaryZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBClusterPrimaryZoneWithOptions(request, runtime);
        }

        public async Task<ModifyDBClusterPrimaryZoneResponse> ModifyDBClusterPrimaryZoneAsync(ModifyDBClusterPrimaryZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBClusterPrimaryZoneWithOptionsAsync(request, runtime);
        }

        public ModifyDBClusterSSLResponse ModifyDBClusterSSLWithOptions(ModifyDBClusterSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterSSLResponse>(DoRPCRequest("ModifyDBClusterSSL", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBClusterSSLResponse> ModifyDBClusterSSLWithOptionsAsync(ModifyDBClusterSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterSSLResponse>(await DoRPCRequestAsync("ModifyDBClusterSSL", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBClusterSSLResponse ModifyDBClusterSSL(ModifyDBClusterSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBClusterSSLWithOptions(request, runtime);
        }

        public async Task<ModifyDBClusterSSLResponse> ModifyDBClusterSSLAsync(ModifyDBClusterSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBClusterSSLWithOptionsAsync(request, runtime);
        }

        public ModifyDBClusterTDEResponse ModifyDBClusterTDEWithOptions(ModifyDBClusterTDERequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterTDEResponse>(DoRPCRequest("ModifyDBClusterTDE", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBClusterTDEResponse> ModifyDBClusterTDEWithOptionsAsync(ModifyDBClusterTDERequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterTDEResponse>(await DoRPCRequestAsync("ModifyDBClusterTDE", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBClusterTDEResponse ModifyDBClusterTDE(ModifyDBClusterTDERequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBClusterTDEWithOptions(request, runtime);
        }

        public async Task<ModifyDBClusterTDEResponse> ModifyDBClusterTDEAsync(ModifyDBClusterTDERequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBClusterTDEWithOptionsAsync(request, runtime);
        }

        public ModifyDBDescriptionResponse ModifyDBDescriptionWithOptions(ModifyDBDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBDescriptionResponse>(DoRPCRequest("ModifyDBDescription", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBDescriptionResponse> ModifyDBDescriptionWithOptionsAsync(ModifyDBDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBDescriptionResponse>(await DoRPCRequestAsync("ModifyDBDescription", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBDescriptionResponse ModifyDBDescription(ModifyDBDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBDescriptionWithOptions(request, runtime);
        }

        public async Task<ModifyDBDescriptionResponse> ModifyDBDescriptionAsync(ModifyDBDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBDescriptionWithOptionsAsync(request, runtime);
        }

        public ModifyDBEndpointAddressResponse ModifyDBEndpointAddressWithOptions(ModifyDBEndpointAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBEndpointAddressResponse>(DoRPCRequest("ModifyDBEndpointAddress", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBEndpointAddressResponse> ModifyDBEndpointAddressWithOptionsAsync(ModifyDBEndpointAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBEndpointAddressResponse>(await DoRPCRequestAsync("ModifyDBEndpointAddress", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBEndpointAddressResponse ModifyDBEndpointAddress(ModifyDBEndpointAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBEndpointAddressWithOptions(request, runtime);
        }

        public async Task<ModifyDBEndpointAddressResponse> ModifyDBEndpointAddressAsync(ModifyDBEndpointAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBEndpointAddressWithOptionsAsync(request, runtime);
        }

        public ModifyDBNodeClassResponse ModifyDBNodeClassWithOptions(ModifyDBNodeClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBNodeClassResponse>(DoRPCRequest("ModifyDBNodeClass", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBNodeClassResponse> ModifyDBNodeClassWithOptionsAsync(ModifyDBNodeClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBNodeClassResponse>(await DoRPCRequestAsync("ModifyDBNodeClass", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBNodeClassResponse ModifyDBNodeClass(ModifyDBNodeClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBNodeClassWithOptions(request, runtime);
        }

        public async Task<ModifyDBNodeClassResponse> ModifyDBNodeClassAsync(ModifyDBNodeClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBNodeClassWithOptionsAsync(request, runtime);
        }

        public ModifyGlobalDatabaseNetworkResponse ModifyGlobalDatabaseNetworkWithOptions(ModifyGlobalDatabaseNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyGlobalDatabaseNetworkResponse>(DoRPCRequest("ModifyGlobalDatabaseNetwork", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyGlobalDatabaseNetworkResponse> ModifyGlobalDatabaseNetworkWithOptionsAsync(ModifyGlobalDatabaseNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyGlobalDatabaseNetworkResponse>(await DoRPCRequestAsync("ModifyGlobalDatabaseNetwork", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyGlobalDatabaseNetworkResponse ModifyGlobalDatabaseNetwork(ModifyGlobalDatabaseNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyGlobalDatabaseNetworkWithOptions(request, runtime);
        }

        public async Task<ModifyGlobalDatabaseNetworkResponse> ModifyGlobalDatabaseNetworkAsync(ModifyGlobalDatabaseNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyGlobalDatabaseNetworkWithOptionsAsync(request, runtime);
        }

        public ModifyLogBackupPolicyResponse ModifyLogBackupPolicyWithOptions(ModifyLogBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLogBackupPolicyResponse>(DoRPCRequest("ModifyLogBackupPolicy", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyLogBackupPolicyResponse> ModifyLogBackupPolicyWithOptionsAsync(ModifyLogBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLogBackupPolicyResponse>(await DoRPCRequestAsync("ModifyLogBackupPolicy", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyLogBackupPolicyResponse ModifyLogBackupPolicy(ModifyLogBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLogBackupPolicyWithOptions(request, runtime);
        }

        public async Task<ModifyLogBackupPolicyResponse> ModifyLogBackupPolicyAsync(ModifyLogBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLogBackupPolicyWithOptionsAsync(request, runtime);
        }

        public ModifyPendingMaintenanceActionResponse ModifyPendingMaintenanceActionWithOptions(ModifyPendingMaintenanceActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPendingMaintenanceActionResponse>(DoRPCRequest("ModifyPendingMaintenanceAction", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyPendingMaintenanceActionResponse> ModifyPendingMaintenanceActionWithOptionsAsync(ModifyPendingMaintenanceActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPendingMaintenanceActionResponse>(await DoRPCRequestAsync("ModifyPendingMaintenanceAction", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyPendingMaintenanceActionResponse ModifyPendingMaintenanceAction(ModifyPendingMaintenanceActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPendingMaintenanceActionWithOptions(request, runtime);
        }

        public async Task<ModifyPendingMaintenanceActionResponse> ModifyPendingMaintenanceActionAsync(ModifyPendingMaintenanceActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPendingMaintenanceActionWithOptionsAsync(request, runtime);
        }

        public RemoveDBClusterFromGDNResponse RemoveDBClusterFromGDNWithOptions(RemoveDBClusterFromGDNRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveDBClusterFromGDNResponse>(DoRPCRequest("RemoveDBClusterFromGDN", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveDBClusterFromGDNResponse> RemoveDBClusterFromGDNWithOptionsAsync(RemoveDBClusterFromGDNRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveDBClusterFromGDNResponse>(await DoRPCRequestAsync("RemoveDBClusterFromGDN", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveDBClusterFromGDNResponse RemoveDBClusterFromGDN(RemoveDBClusterFromGDNRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveDBClusterFromGDNWithOptions(request, runtime);
        }

        public async Task<RemoveDBClusterFromGDNResponse> RemoveDBClusterFromGDNAsync(RemoveDBClusterFromGDNRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveDBClusterFromGDNWithOptionsAsync(request, runtime);
        }

        public ResetAccountResponse ResetAccountWithOptions(ResetAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetAccountResponse>(DoRPCRequest("ResetAccount", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetAccountResponse> ResetAccountWithOptionsAsync(ResetAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetAccountResponse>(await DoRPCRequestAsync("ResetAccount", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetAccountResponse ResetAccount(ResetAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetAccountWithOptions(request, runtime);
        }

        public async Task<ResetAccountResponse> ResetAccountAsync(ResetAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetAccountWithOptionsAsync(request, runtime);
        }

        public RestartDBNodeResponse RestartDBNodeWithOptions(RestartDBNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartDBNodeResponse>(DoRPCRequest("RestartDBNode", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestartDBNodeResponse> RestartDBNodeWithOptionsAsync(RestartDBNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartDBNodeResponse>(await DoRPCRequestAsync("RestartDBNode", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RestartDBNodeResponse RestartDBNode(RestartDBNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartDBNodeWithOptions(request, runtime);
        }

        public async Task<RestartDBNodeResponse> RestartDBNodeAsync(RestartDBNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartDBNodeWithOptionsAsync(request, runtime);
        }

        public RestoreTableResponse RestoreTableWithOptions(RestoreTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestoreTableResponse>(DoRPCRequest("RestoreTable", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestoreTableResponse> RestoreTableWithOptionsAsync(RestoreTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestoreTableResponse>(await DoRPCRequestAsync("RestoreTable", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RestoreTableResponse RestoreTable(RestoreTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestoreTableWithOptions(request, runtime);
        }

        public async Task<RestoreTableResponse> RestoreTableAsync(RestoreTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestoreTableWithOptionsAsync(request, runtime);
        }

        public RevokeAccountPrivilegeResponse RevokeAccountPrivilegeWithOptions(RevokeAccountPrivilegeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeAccountPrivilegeResponse>(DoRPCRequest("RevokeAccountPrivilege", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RevokeAccountPrivilegeResponse> RevokeAccountPrivilegeWithOptionsAsync(RevokeAccountPrivilegeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeAccountPrivilegeResponse>(await DoRPCRequestAsync("RevokeAccountPrivilege", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RevokeAccountPrivilegeResponse RevokeAccountPrivilege(RevokeAccountPrivilegeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeAccountPrivilegeWithOptions(request, runtime);
        }

        public async Task<RevokeAccountPrivilegeResponse> RevokeAccountPrivilegeAsync(RevokeAccountPrivilegeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeAccountPrivilegeWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public TransformDBClusterPayTypeResponse TransformDBClusterPayTypeWithOptions(TransformDBClusterPayTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransformDBClusterPayTypeResponse>(DoRPCRequest("TransformDBClusterPayType", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TransformDBClusterPayTypeResponse> TransformDBClusterPayTypeWithOptionsAsync(TransformDBClusterPayTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransformDBClusterPayTypeResponse>(await DoRPCRequestAsync("TransformDBClusterPayType", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TransformDBClusterPayTypeResponse TransformDBClusterPayType(TransformDBClusterPayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransformDBClusterPayTypeWithOptions(request, runtime);
        }

        public async Task<TransformDBClusterPayTypeResponse> TransformDBClusterPayTypeAsync(TransformDBClusterPayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransformDBClusterPayTypeWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        public UpgradeDBClusterMinorVersionResponse UpgradeDBClusterMinorVersionWithOptions(UpgradeDBClusterMinorVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeDBClusterMinorVersionResponse>(DoRPCRequest("UpgradeDBClusterMinorVersion", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeDBClusterMinorVersionResponse> UpgradeDBClusterMinorVersionWithOptionsAsync(UpgradeDBClusterMinorVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeDBClusterMinorVersionResponse>(await DoRPCRequestAsync("UpgradeDBClusterMinorVersion", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeDBClusterMinorVersionResponse UpgradeDBClusterMinorVersion(UpgradeDBClusterMinorVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeDBClusterMinorVersionWithOptions(request, runtime);
        }

        public async Task<UpgradeDBClusterMinorVersionResponse> UpgradeDBClusterMinorVersionAsync(UpgradeDBClusterMinorVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeDBClusterMinorVersionWithOptionsAsync(request, runtime);
        }

        public UpgradeDBClusterVersionResponse UpgradeDBClusterVersionWithOptions(UpgradeDBClusterVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeDBClusterVersionResponse>(DoRPCRequest("UpgradeDBClusterVersion", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeDBClusterVersionResponse> UpgradeDBClusterVersionWithOptionsAsync(UpgradeDBClusterVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeDBClusterVersionResponse>(await DoRPCRequestAsync("UpgradeDBClusterVersion", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeDBClusterVersionResponse UpgradeDBClusterVersion(UpgradeDBClusterVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeDBClusterVersionWithOptions(request, runtime);
        }

        public async Task<UpgradeDBClusterVersionResponse> UpgradeDBClusterVersionAsync(UpgradeDBClusterVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeDBClusterVersionWithOptionsAsync(request, runtime);
        }

    }
}
