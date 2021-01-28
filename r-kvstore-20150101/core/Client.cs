// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.R_kvstore20150101.Models;

namespace AlibabaCloud.SDK.R_kvstore20150101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "r-kvstore.aliyuncs.com"},
                {"cn-beijing", "r-kvstore.aliyuncs.com"},
                {"cn-hangzhou", "r-kvstore.aliyuncs.com"},
                {"cn-shanghai", "r-kvstore.aliyuncs.com"},
                {"cn-shenzhen", "r-kvstore.aliyuncs.com"},
                {"cn-heyuan", "r-kvstore.aliyuncs.com"},
                {"ap-southeast-1", "r-kvstore.aliyuncs.com"},
                {"us-west-1", "r-kvstore.aliyuncs.com"},
                {"us-east-1", "r-kvstore.aliyuncs.com"},
                {"cn-hangzhou-finance", "r-kvstore.aliyuncs.com"},
                {"cn-shanghai-finance-1", "r-kvstore.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "r-kvstore.aliyuncs.com"},
                {"cn-north-2-gov-1", "r-kvstore.aliyuncs.com"},
                {"ap-northeast-2-pop", "r-kvstore.aliyuncs.com"},
                {"cn-beijing-finance-1", "r-kvstore.aliyuncs.com"},
                {"cn-beijing-finance-pop", "r-kvstore.aliyuncs.com"},
                {"cn-beijing-gov-1", "r-kvstore.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "r-kvstore.aliyuncs.com"},
                {"cn-edge-1", "r-kvstore.aliyuncs.com"},
                {"cn-fujian", "r-kvstore.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "r-kvstore.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "r-kvstore.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "r-kvstore.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "r-kvstore.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "r-kvstore.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "r-kvstore.aliyuncs.com"},
                {"cn-hangzhou-test-306", "r-kvstore.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "r-kvstore.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "r-kvstore.aliyuncs.com"},
                {"cn-qingdao-nebula", "r-kvstore.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "r-kvstore.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "r-kvstore.aliyuncs.com"},
                {"cn-shanghai-inner", "r-kvstore.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "r-kvstore.aliyuncs.com"},
                {"cn-shenzhen-inner", "r-kvstore.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "r-kvstore.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "r-kvstore.aliyuncs.com"},
                {"cn-wuhan", "r-kvstore.aliyuncs.com"},
                {"cn-wulanchabu", "r-kvstore.aliyuncs.com"},
                {"cn-yushanfang", "r-kvstore.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "r-kvstore.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "r-kvstore.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "r-kvstore.aliyuncs.com"},
                {"eu-west-1-oxs", "r-kvstore.aliyuncs.com"},
                {"rus-west-1-pop", "r-kvstore.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("r-kvstore", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddShardingNodeResponse AddShardingNodeWithOptions(AddShardingNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddShardingNodeResponse>(DoRPCRequest("AddShardingNode", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddShardingNodeResponse> AddShardingNodeWithOptionsAsync(AddShardingNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddShardingNodeResponse>(await DoRPCRequestAsync("AddShardingNode", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddShardingNodeResponse AddShardingNode(AddShardingNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddShardingNodeWithOptions(request, runtime);
        }

        public async Task<AddShardingNodeResponse> AddShardingNodeAsync(AddShardingNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddShardingNodeWithOptionsAsync(request, runtime);
        }

        public AllocateDirectConnectionResponse AllocateDirectConnectionWithOptions(AllocateDirectConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateDirectConnectionResponse>(DoRPCRequest("AllocateDirectConnection", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AllocateDirectConnectionResponse> AllocateDirectConnectionWithOptionsAsync(AllocateDirectConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateDirectConnectionResponse>(await DoRPCRequestAsync("AllocateDirectConnection", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AllocateDirectConnectionResponse AllocateDirectConnection(AllocateDirectConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateDirectConnectionWithOptions(request, runtime);
        }

        public async Task<AllocateDirectConnectionResponse> AllocateDirectConnectionAsync(AllocateDirectConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateDirectConnectionWithOptionsAsync(request, runtime);
        }

        public AllocateInstancePublicConnectionResponse AllocateInstancePublicConnectionWithOptions(AllocateInstancePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateInstancePublicConnectionResponse>(DoRPCRequest("AllocateInstancePublicConnection", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AllocateInstancePublicConnectionResponse> AllocateInstancePublicConnectionWithOptionsAsync(AllocateInstancePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateInstancePublicConnectionResponse>(await DoRPCRequestAsync("AllocateInstancePublicConnection", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AllocateInstancePublicConnectionResponse AllocateInstancePublicConnection(AllocateInstancePublicConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateInstancePublicConnectionWithOptions(request, runtime);
        }

        public async Task<AllocateInstancePublicConnectionResponse> AllocateInstancePublicConnectionAsync(AllocateInstancePublicConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateInstancePublicConnectionWithOptionsAsync(request, runtime);
        }

        public CreateAccountResponse CreateAccountWithOptions(CreateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAccountResponse>(DoRPCRequest("CreateAccount", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAccountResponse> CreateAccountWithOptionsAsync(CreateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAccountResponse>(await DoRPCRequestAsync("CreateAccount", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<CreateBackupResponse>(DoRPCRequest("CreateBackup", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateBackupResponse> CreateBackupWithOptionsAsync(CreateBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBackupResponse>(await DoRPCRequestAsync("CreateBackup", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateCacheAnalysisTaskResponse CreateCacheAnalysisTaskWithOptions(CreateCacheAnalysisTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCacheAnalysisTaskResponse>(DoRPCRequest("CreateCacheAnalysisTask", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCacheAnalysisTaskResponse> CreateCacheAnalysisTaskWithOptionsAsync(CreateCacheAnalysisTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCacheAnalysisTaskResponse>(await DoRPCRequestAsync("CreateCacheAnalysisTask", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCacheAnalysisTaskResponse CreateCacheAnalysisTask(CreateCacheAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCacheAnalysisTaskWithOptions(request, runtime);
        }

        public async Task<CreateCacheAnalysisTaskResponse> CreateCacheAnalysisTaskAsync(CreateCacheAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCacheAnalysisTaskWithOptionsAsync(request, runtime);
        }

        public CreateGlobalDistributeCacheResponse CreateGlobalDistributeCacheWithOptions(CreateGlobalDistributeCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGlobalDistributeCacheResponse>(DoRPCRequest("CreateGlobalDistributeCache", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateGlobalDistributeCacheResponse> CreateGlobalDistributeCacheWithOptionsAsync(CreateGlobalDistributeCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGlobalDistributeCacheResponse>(await DoRPCRequestAsync("CreateGlobalDistributeCache", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateGlobalDistributeCacheResponse CreateGlobalDistributeCache(CreateGlobalDistributeCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGlobalDistributeCacheWithOptions(request, runtime);
        }

        public async Task<CreateGlobalDistributeCacheResponse> CreateGlobalDistributeCacheAsync(CreateGlobalDistributeCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGlobalDistributeCacheWithOptionsAsync(request, runtime);
        }

        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceResponse>(DoRPCRequest("CreateInstance", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await DoRPCRequestAsync("CreateInstance", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        public CreateUserClusterHostResponse CreateUserClusterHostWithOptions(CreateUserClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserClusterHostResponse>(DoRPCRequest("CreateUserClusterHost", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUserClusterHostResponse> CreateUserClusterHostWithOptionsAsync(CreateUserClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserClusterHostResponse>(await DoRPCRequestAsync("CreateUserClusterHost", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateUserClusterHostResponse CreateUserClusterHost(CreateUserClusterHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserClusterHostWithOptions(request, runtime);
        }

        public async Task<CreateUserClusterHostResponse> CreateUserClusterHostAsync(CreateUserClusterHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserClusterHostWithOptionsAsync(request, runtime);
        }

        public DeleteAccountResponse DeleteAccountWithOptions(DeleteAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAccountResponse>(DoRPCRequest("DeleteAccount", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAccountResponse> DeleteAccountWithOptionsAsync(DeleteAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAccountResponse>(await DoRPCRequestAsync("DeleteAccount", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(DoRPCRequest("DeleteInstance", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await DoRPCRequestAsync("DeleteInstance", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceWithOptionsAsync(request, runtime);
        }

        public DeleteShardingNodeResponse DeleteShardingNodeWithOptions(DeleteShardingNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteShardingNodeResponse>(DoRPCRequest("DeleteShardingNode", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteShardingNodeResponse> DeleteShardingNodeWithOptionsAsync(DeleteShardingNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteShardingNodeResponse>(await DoRPCRequestAsync("DeleteShardingNode", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteShardingNodeResponse DeleteShardingNode(DeleteShardingNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteShardingNodeWithOptions(request, runtime);
        }

        public async Task<DeleteShardingNodeResponse> DeleteShardingNodeAsync(DeleteShardingNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteShardingNodeWithOptionsAsync(request, runtime);
        }

        public DeleteUserClusterHostResponse DeleteUserClusterHostWithOptions(DeleteUserClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserClusterHostResponse>(DoRPCRequest("DeleteUserClusterHost", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUserClusterHostResponse> DeleteUserClusterHostWithOptionsAsync(DeleteUserClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserClusterHostResponse>(await DoRPCRequestAsync("DeleteUserClusterHost", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUserClusterHostResponse DeleteUserClusterHost(DeleteUserClusterHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserClusterHostWithOptions(request, runtime);
        }

        public async Task<DeleteUserClusterHostResponse> DeleteUserClusterHostAsync(DeleteUserClusterHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserClusterHostWithOptionsAsync(request, runtime);
        }

        public DescribeAccountsResponse DescribeAccountsWithOptions(DescribeAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccountsResponse>(DoRPCRequest("DescribeAccounts", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAccountsResponse> DescribeAccountsWithOptionsAsync(DescribeAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccountsResponse>(await DoRPCRequestAsync("DescribeAccounts", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeActiveOperationTaskResponse DescribeActiveOperationTaskWithOptions(DescribeActiveOperationTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeActiveOperationTaskResponse>(DoRPCRequest("DescribeActiveOperationTask", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeActiveOperationTaskResponse> DescribeActiveOperationTaskWithOptionsAsync(DescribeActiveOperationTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeActiveOperationTaskResponse>(await DoRPCRequestAsync("DescribeActiveOperationTask", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeActiveOperationTaskResponse DescribeActiveOperationTask(DescribeActiveOperationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeActiveOperationTaskWithOptions(request, runtime);
        }

        public async Task<DescribeActiveOperationTaskResponse> DescribeActiveOperationTaskAsync(DescribeActiveOperationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeActiveOperationTaskWithOptionsAsync(request, runtime);
        }

        public DescribeAuditRecordsResponse DescribeAuditRecordsWithOptions(DescribeAuditRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAuditRecordsResponse>(DoRPCRequest("DescribeAuditRecords", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAuditRecordsResponse> DescribeAuditRecordsWithOptionsAsync(DescribeAuditRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAuditRecordsResponse>(await DoRPCRequestAsync("DescribeAuditRecords", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAuditRecordsResponse DescribeAuditRecords(DescribeAuditRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAuditRecordsWithOptions(request, runtime);
        }

        public async Task<DescribeAuditRecordsResponse> DescribeAuditRecordsAsync(DescribeAuditRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAuditRecordsWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableResourceResponse DescribeAvailableResourceWithOptions(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(DoRPCRequest("DescribeAvailableResource", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceWithOptionsAsync(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(await DoRPCRequestAsync("DescribeAvailableResource", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAvailableResourceResponse DescribeAvailableResource(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableResourceWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceAsync(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableResourceWithOptionsAsync(request, runtime);
        }

        public DescribeBackupPolicyResponse DescribeBackupPolicyWithOptions(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPolicyResponse>(DoRPCRequest("DescribeBackupPolicy", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupPolicyResponse> DescribeBackupPolicyWithOptionsAsync(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPolicyResponse>(await DoRPCRequestAsync("DescribeBackupPolicy", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeBackupsResponse>(DoRPCRequest("DescribeBackups", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupsResponse> DescribeBackupsWithOptionsAsync(DescribeBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupsResponse>(await DoRPCRequestAsync("DescribeBackups", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeBackupTasksResponse>(DoRPCRequest("DescribeBackupTasks", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupTasksResponse> DescribeBackupTasksWithOptionsAsync(DescribeBackupTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupTasksResponse>(await DoRPCRequestAsync("DescribeBackupTasks", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeCacheAnalysisReportResponse DescribeCacheAnalysisReportWithOptions(DescribeCacheAnalysisReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCacheAnalysisReportResponse>(DoRPCRequest("DescribeCacheAnalysisReport", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCacheAnalysisReportResponse> DescribeCacheAnalysisReportWithOptionsAsync(DescribeCacheAnalysisReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCacheAnalysisReportResponse>(await DoRPCRequestAsync("DescribeCacheAnalysisReport", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCacheAnalysisReportResponse DescribeCacheAnalysisReport(DescribeCacheAnalysisReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCacheAnalysisReportWithOptions(request, runtime);
        }

        public async Task<DescribeCacheAnalysisReportResponse> DescribeCacheAnalysisReportAsync(DescribeCacheAnalysisReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCacheAnalysisReportWithOptionsAsync(request, runtime);
        }

        public DescribeCacheAnalysisReportListResponse DescribeCacheAnalysisReportListWithOptions(DescribeCacheAnalysisReportListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCacheAnalysisReportListResponse>(DoRPCRequest("DescribeCacheAnalysisReportList", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCacheAnalysisReportListResponse> DescribeCacheAnalysisReportListWithOptionsAsync(DescribeCacheAnalysisReportListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCacheAnalysisReportListResponse>(await DoRPCRequestAsync("DescribeCacheAnalysisReportList", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCacheAnalysisReportListResponse DescribeCacheAnalysisReportList(DescribeCacheAnalysisReportListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCacheAnalysisReportListWithOptions(request, runtime);
        }

        public async Task<DescribeCacheAnalysisReportListResponse> DescribeCacheAnalysisReportListAsync(DescribeCacheAnalysisReportListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCacheAnalysisReportListWithOptionsAsync(request, runtime);
        }

        public DescribeClusterMemberInfoResponse DescribeClusterMemberInfoWithOptions(DescribeClusterMemberInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterMemberInfoResponse>(DoRPCRequest("DescribeClusterMemberInfo", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterMemberInfoResponse> DescribeClusterMemberInfoWithOptionsAsync(DescribeClusterMemberInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterMemberInfoResponse>(await DoRPCRequestAsync("DescribeClusterMemberInfo", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClusterMemberInfoResponse DescribeClusterMemberInfo(DescribeClusterMemberInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterMemberInfoWithOptions(request, runtime);
        }

        public async Task<DescribeClusterMemberInfoResponse> DescribeClusterMemberInfoAsync(DescribeClusterMemberInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterMemberInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceNetInfoResponse DescribeDBInstanceNetInfoWithOptions(DescribeDBInstanceNetInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceNetInfoResponse>(DoRPCRequest("DescribeDBInstanceNetInfo", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstanceNetInfoResponse> DescribeDBInstanceNetInfoWithOptionsAsync(DescribeDBInstanceNetInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceNetInfoResponse>(await DoRPCRequestAsync("DescribeDBInstanceNetInfo", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstanceNetInfoResponse DescribeDBInstanceNetInfo(DescribeDBInstanceNetInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceNetInfoWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceNetInfoResponse> DescribeDBInstanceNetInfoAsync(DescribeDBInstanceNetInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceNetInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedClusterInstanceListResponse DescribeDedicatedClusterInstanceListWithOptions(DescribeDedicatedClusterInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedClusterInstanceListResponse>(DoRPCRequest("DescribeDedicatedClusterInstanceList", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedClusterInstanceListResponse> DescribeDedicatedClusterInstanceListWithOptionsAsync(DescribeDedicatedClusterInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedClusterInstanceListResponse>(await DoRPCRequestAsync("DescribeDedicatedClusterInstanceList", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedClusterInstanceListResponse DescribeDedicatedClusterInstanceList(DescribeDedicatedClusterInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedClusterInstanceListWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedClusterInstanceListResponse> DescribeDedicatedClusterInstanceListAsync(DescribeDedicatedClusterInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedClusterInstanceListWithOptionsAsync(request, runtime);
        }

        public DescribeEngineVersionResponse DescribeEngineVersionWithOptions(DescribeEngineVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEngineVersionResponse>(DoRPCRequest("DescribeEngineVersion", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEngineVersionResponse> DescribeEngineVersionWithOptionsAsync(DescribeEngineVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEngineVersionResponse>(await DoRPCRequestAsync("DescribeEngineVersion", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEngineVersionResponse DescribeEngineVersion(DescribeEngineVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEngineVersionWithOptions(request, runtime);
        }

        public async Task<DescribeEngineVersionResponse> DescribeEngineVersionAsync(DescribeEngineVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEngineVersionWithOptionsAsync(request, runtime);
        }

        public DescribeGlobalDistributeCacheResponse DescribeGlobalDistributeCacheWithOptions(DescribeGlobalDistributeCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGlobalDistributeCacheResponse>(DoRPCRequest("DescribeGlobalDistributeCache", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGlobalDistributeCacheResponse> DescribeGlobalDistributeCacheWithOptionsAsync(DescribeGlobalDistributeCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGlobalDistributeCacheResponse>(await DoRPCRequestAsync("DescribeGlobalDistributeCache", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGlobalDistributeCacheResponse DescribeGlobalDistributeCache(DescribeGlobalDistributeCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGlobalDistributeCacheWithOptions(request, runtime);
        }

        public async Task<DescribeGlobalDistributeCacheResponse> DescribeGlobalDistributeCacheAsync(DescribeGlobalDistributeCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGlobalDistributeCacheWithOptionsAsync(request, runtime);
        }

        public DescribeHistoryMonitorValuesResponse DescribeHistoryMonitorValuesWithOptions(DescribeHistoryMonitorValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHistoryMonitorValuesResponse>(DoRPCRequest("DescribeHistoryMonitorValues", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHistoryMonitorValuesResponse> DescribeHistoryMonitorValuesWithOptionsAsync(DescribeHistoryMonitorValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHistoryMonitorValuesResponse>(await DoRPCRequestAsync("DescribeHistoryMonitorValues", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHistoryMonitorValuesResponse DescribeHistoryMonitorValues(DescribeHistoryMonitorValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHistoryMonitorValuesWithOptions(request, runtime);
        }

        public async Task<DescribeHistoryMonitorValuesResponse> DescribeHistoryMonitorValuesAsync(DescribeHistoryMonitorValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHistoryMonitorValuesWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceAttributeResponse DescribeInstanceAttributeWithOptions(DescribeInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAttributeResponse>(DoRPCRequest("DescribeInstanceAttribute", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceAttributeResponse> DescribeInstanceAttributeWithOptionsAsync(DescribeInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAttributeResponse>(await DoRPCRequestAsync("DescribeInstanceAttribute", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceAttributeResponse> DescribeInstanceAttributeAsync(DescribeInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceAutoRenewalAttributeResponse DescribeInstanceAutoRenewalAttributeWithOptions(DescribeInstanceAutoRenewalAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAutoRenewalAttributeResponse>(DoRPCRequest("DescribeInstanceAutoRenewalAttribute", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceAutoRenewalAttributeResponse> DescribeInstanceAutoRenewalAttributeWithOptionsAsync(DescribeInstanceAutoRenewalAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAutoRenewalAttributeResponse>(await DoRPCRequestAsync("DescribeInstanceAutoRenewalAttribute", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceAutoRenewalAttributeResponse DescribeInstanceAutoRenewalAttribute(DescribeInstanceAutoRenewalAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAutoRenewalAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceAutoRenewalAttributeResponse> DescribeInstanceAutoRenewalAttributeAsync(DescribeInstanceAutoRenewalAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAutoRenewalAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceConfigResponse DescribeInstanceConfigWithOptions(DescribeInstanceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceConfigResponse>(DoRPCRequest("DescribeInstanceConfig", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceConfigResponse> DescribeInstanceConfigWithOptionsAsync(DescribeInstanceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceConfigResponse>(await DoRPCRequestAsync("DescribeInstanceConfig", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceConfigResponse DescribeInstanceConfig(DescribeInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceConfigWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceConfigResponse> DescribeInstanceConfigAsync(DescribeInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceConfigWithOptionsAsync(request, runtime);
        }

        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(DoRPCRequest("DescribeInstances", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(await DoRPCRequestAsync("DescribeInstances", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceSSLResponse DescribeInstanceSSLWithOptions(DescribeInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceSSLResponse>(DoRPCRequest("DescribeInstanceSSL", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceSSLResponse> DescribeInstanceSSLWithOptionsAsync(DescribeInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceSSLResponse>(await DoRPCRequestAsync("DescribeInstanceSSL", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceSSLResponse DescribeInstanceSSL(DescribeInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceSSLWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceSSLResponse> DescribeInstanceSSLAsync(DescribeInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceSSLWithOptionsAsync(request, runtime);
        }

        public DescribeIntranetAttributeResponse DescribeIntranetAttributeWithOptions(DescribeIntranetAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIntranetAttributeResponse>(DoRPCRequest("DescribeIntranetAttribute", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIntranetAttributeResponse> DescribeIntranetAttributeWithOptionsAsync(DescribeIntranetAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIntranetAttributeResponse>(await DoRPCRequestAsync("DescribeIntranetAttribute", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIntranetAttributeResponse DescribeIntranetAttribute(DescribeIntranetAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIntranetAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeIntranetAttributeResponse> DescribeIntranetAttributeAsync(DescribeIntranetAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIntranetAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeLogicInstanceTopologyResponse DescribeLogicInstanceTopologyWithOptions(DescribeLogicInstanceTopologyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLogicInstanceTopologyResponse>(DoRPCRequest("DescribeLogicInstanceTopology", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLogicInstanceTopologyResponse> DescribeLogicInstanceTopologyWithOptionsAsync(DescribeLogicInstanceTopologyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLogicInstanceTopologyResponse>(await DoRPCRequestAsync("DescribeLogicInstanceTopology", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLogicInstanceTopologyResponse DescribeLogicInstanceTopology(DescribeLogicInstanceTopologyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogicInstanceTopologyWithOptions(request, runtime);
        }

        public async Task<DescribeLogicInstanceTopologyResponse> DescribeLogicInstanceTopologyAsync(DescribeLogicInstanceTopologyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogicInstanceTopologyWithOptionsAsync(request, runtime);
        }

        public DescribeMonitorItemsResponse DescribeMonitorItemsWithOptions(DescribeMonitorItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitorItemsResponse>(DoRPCRequest("DescribeMonitorItems", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMonitorItemsResponse> DescribeMonitorItemsWithOptionsAsync(DescribeMonitorItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMonitorItemsResponse>(await DoRPCRequestAsync("DescribeMonitorItems", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMonitorItemsResponse DescribeMonitorItems(DescribeMonitorItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitorItemsWithOptions(request, runtime);
        }

        public async Task<DescribeMonitorItemsResponse> DescribeMonitorItemsAsync(DescribeMonitorItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitorItemsWithOptionsAsync(request, runtime);
        }

        public DescribeParametersResponse DescribeParametersWithOptions(DescribeParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParametersResponse>(DoRPCRequest("DescribeParameters", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeParametersResponse> DescribeParametersWithOptionsAsync(DescribeParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParametersResponse>(await DoRPCRequestAsync("DescribeParameters", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeParameterTemplatesResponse DescribeParameterTemplatesWithOptions(DescribeParameterTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParameterTemplatesResponse>(DoRPCRequest("DescribeParameterTemplates", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeParameterTemplatesResponse> DescribeParameterTemplatesWithOptionsAsync(DescribeParameterTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParameterTemplatesResponse>(await DoRPCRequestAsync("DescribeParameterTemplates", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribePriceResponse DescribePriceWithOptions(DescribePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePriceResponse>(DoRPCRequest("DescribePrice", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePriceResponse> DescribePriceWithOptionsAsync(DescribePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePriceResponse>(await DoRPCRequestAsync("DescribePrice", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePriceResponse DescribePrice(DescribePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePriceWithOptions(request, runtime);
        }

        public async Task<DescribePriceResponse> DescribePriceAsync(DescribePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePriceWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeRoleZoneInfoResponse DescribeRoleZoneInfoWithOptions(DescribeRoleZoneInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRoleZoneInfoResponse>(DoRPCRequest("DescribeRoleZoneInfo", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRoleZoneInfoResponse> DescribeRoleZoneInfoWithOptionsAsync(DescribeRoleZoneInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRoleZoneInfoResponse>(await DoRPCRequestAsync("DescribeRoleZoneInfo", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRoleZoneInfoResponse DescribeRoleZoneInfo(DescribeRoleZoneInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRoleZoneInfoWithOptions(request, runtime);
        }

        public async Task<DescribeRoleZoneInfoResponse> DescribeRoleZoneInfoAsync(DescribeRoleZoneInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRoleZoneInfoWithOptionsAsync(request, runtime);
        }

        public DescribeRunningLogRecordsResponse DescribeRunningLogRecordsWithOptions(DescribeRunningLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRunningLogRecordsResponse>(DoRPCRequest("DescribeRunningLogRecords", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRunningLogRecordsResponse> DescribeRunningLogRecordsWithOptionsAsync(DescribeRunningLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRunningLogRecordsResponse>(await DoRPCRequestAsync("DescribeRunningLogRecords", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRunningLogRecordsResponse DescribeRunningLogRecords(DescribeRunningLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRunningLogRecordsWithOptions(request, runtime);
        }

        public async Task<DescribeRunningLogRecordsResponse> DescribeRunningLogRecordsAsync(DescribeRunningLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRunningLogRecordsWithOptionsAsync(request, runtime);
        }

        public DescribeSecurityGroupConfigurationResponse DescribeSecurityGroupConfigurationWithOptions(DescribeSecurityGroupConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityGroupConfigurationResponse>(DoRPCRequest("DescribeSecurityGroupConfiguration", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSecurityGroupConfigurationResponse> DescribeSecurityGroupConfigurationWithOptionsAsync(DescribeSecurityGroupConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityGroupConfigurationResponse>(await DoRPCRequestAsync("DescribeSecurityGroupConfiguration", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSecurityGroupConfigurationResponse DescribeSecurityGroupConfiguration(DescribeSecurityGroupConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityGroupConfigurationWithOptions(request, runtime);
        }

        public async Task<DescribeSecurityGroupConfigurationResponse> DescribeSecurityGroupConfigurationAsync(DescribeSecurityGroupConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityGroupConfigurationWithOptionsAsync(request, runtime);
        }

        public DescribeSecurityIpsResponse DescribeSecurityIpsWithOptions(DescribeSecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityIpsResponse>(DoRPCRequest("DescribeSecurityIps", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSecurityIpsResponse> DescribeSecurityIpsWithOptionsAsync(DescribeSecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityIpsResponse>(await DoRPCRequestAsync("DescribeSecurityIps", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSecurityIpsResponse DescribeSecurityIps(DescribeSecurityIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityIpsWithOptions(request, runtime);
        }

        public async Task<DescribeSecurityIpsResponse> DescribeSecurityIpsAsync(DescribeSecurityIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityIpsWithOptionsAsync(request, runtime);
        }

        public DescribeSlowLogRecordsResponse DescribeSlowLogRecordsWithOptions(DescribeSlowLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlowLogRecordsResponse>(DoRPCRequest("DescribeSlowLogRecords", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSlowLogRecordsResponse> DescribeSlowLogRecordsWithOptionsAsync(DescribeSlowLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlowLogRecordsResponse>(await DoRPCRequestAsync("DescribeSlowLogRecords", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeTasksResponse>(DoRPCRequest("DescribeTasks", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTasksResponse> DescribeTasksWithOptionsAsync(DescribeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTasksResponse>(await DoRPCRequestAsync("DescribeTasks", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeUserClusterHostResponse DescribeUserClusterHostWithOptions(DescribeUserClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserClusterHostResponse>(DoRPCRequest("DescribeUserClusterHost", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserClusterHostResponse> DescribeUserClusterHostWithOptionsAsync(DescribeUserClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserClusterHostResponse>(await DoRPCRequestAsync("DescribeUserClusterHost", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserClusterHostResponse DescribeUserClusterHost(DescribeUserClusterHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserClusterHostWithOptions(request, runtime);
        }

        public async Task<DescribeUserClusterHostResponse> DescribeUserClusterHostAsync(DescribeUserClusterHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserClusterHostWithOptionsAsync(request, runtime);
        }

        public DescribeUserClusterHostInstanceResponse DescribeUserClusterHostInstanceWithOptions(DescribeUserClusterHostInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserClusterHostInstanceResponse>(DoRPCRequest("DescribeUserClusterHostInstance", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserClusterHostInstanceResponse> DescribeUserClusterHostInstanceWithOptionsAsync(DescribeUserClusterHostInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserClusterHostInstanceResponse>(await DoRPCRequestAsync("DescribeUserClusterHostInstance", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserClusterHostInstanceResponse DescribeUserClusterHostInstance(DescribeUserClusterHostInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserClusterHostInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeUserClusterHostInstanceResponse> DescribeUserClusterHostInstanceAsync(DescribeUserClusterHostInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserClusterHostInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeZonesResponse DescribeZonesWithOptions(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZonesResponse>(DoRPCRequest("DescribeZones", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeZonesResponse> DescribeZonesWithOptionsAsync(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZonesResponse>(await DoRPCRequestAsync("DescribeZones", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeZonesResponse DescribeZones(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeZonesWithOptions(request, runtime);
        }

        public async Task<DescribeZonesResponse> DescribeZonesAsync(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeZonesWithOptionsAsync(request, runtime);
        }

        public FlushExpireKeysResponse FlushExpireKeysWithOptions(FlushExpireKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FlushExpireKeysResponse>(DoRPCRequest("FlushExpireKeys", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FlushExpireKeysResponse> FlushExpireKeysWithOptionsAsync(FlushExpireKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FlushExpireKeysResponse>(await DoRPCRequestAsync("FlushExpireKeys", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FlushExpireKeysResponse FlushExpireKeys(FlushExpireKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FlushExpireKeysWithOptions(request, runtime);
        }

        public async Task<FlushExpireKeysResponse> FlushExpireKeysAsync(FlushExpireKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FlushExpireKeysWithOptionsAsync(request, runtime);
        }

        public FlushInstanceResponse FlushInstanceWithOptions(FlushInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FlushInstanceResponse>(DoRPCRequest("FlushInstance", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FlushInstanceResponse> FlushInstanceWithOptionsAsync(FlushInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FlushInstanceResponse>(await DoRPCRequestAsync("FlushInstance", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FlushInstanceResponse FlushInstance(FlushInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FlushInstanceWithOptions(request, runtime);
        }

        public async Task<FlushInstanceResponse> FlushInstanceAsync(FlushInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FlushInstanceWithOptionsAsync(request, runtime);
        }

        public GrantAccountPrivilegeResponse GrantAccountPrivilegeWithOptions(GrantAccountPrivilegeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GrantAccountPrivilegeResponse>(DoRPCRequest("GrantAccountPrivilege", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GrantAccountPrivilegeResponse> GrantAccountPrivilegeWithOptionsAsync(GrantAccountPrivilegeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GrantAccountPrivilegeResponse>(await DoRPCRequestAsync("GrantAccountPrivilege", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public InitializeKvstorePermissionResponse InitializeKvstorePermissionWithOptions(InitializeKvstorePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InitializeKvstorePermissionResponse>(DoRPCRequest("InitializeKvstorePermission", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InitializeKvstorePermissionResponse> InitializeKvstorePermissionWithOptionsAsync(InitializeKvstorePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InitializeKvstorePermissionResponse>(await DoRPCRequestAsync("InitializeKvstorePermission", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InitializeKvstorePermissionResponse InitializeKvstorePermission(InitializeKvstorePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitializeKvstorePermissionWithOptions(request, runtime);
        }

        public async Task<InitializeKvstorePermissionResponse> InitializeKvstorePermissionAsync(InitializeKvstorePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitializeKvstorePermissionWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public MigrateToOtherZoneResponse MigrateToOtherZoneWithOptions(MigrateToOtherZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MigrateToOtherZoneResponse>(DoRPCRequest("MigrateToOtherZone", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MigrateToOtherZoneResponse> MigrateToOtherZoneWithOptionsAsync(MigrateToOtherZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MigrateToOtherZoneResponse>(await DoRPCRequestAsync("MigrateToOtherZone", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MigrateToOtherZoneResponse MigrateToOtherZone(MigrateToOtherZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MigrateToOtherZoneWithOptions(request, runtime);
        }

        public async Task<MigrateToOtherZoneResponse> MigrateToOtherZoneAsync(MigrateToOtherZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MigrateToOtherZoneWithOptionsAsync(request, runtime);
        }

        public ModifyAccountDescriptionResponse ModifyAccountDescriptionWithOptions(ModifyAccountDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccountDescriptionResponse>(DoRPCRequest("ModifyAccountDescription", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAccountDescriptionResponse> ModifyAccountDescriptionWithOptionsAsync(ModifyAccountDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccountDescriptionResponse>(await DoRPCRequestAsync("ModifyAccountDescription", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<ModifyAccountPasswordResponse>(DoRPCRequest("ModifyAccountPassword", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAccountPasswordResponse> ModifyAccountPasswordWithOptionsAsync(ModifyAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccountPasswordResponse>(await DoRPCRequestAsync("ModifyAccountPassword", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyActiveOperationTaskResponse ModifyActiveOperationTaskWithOptions(ModifyActiveOperationTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyActiveOperationTaskResponse>(DoRPCRequest("ModifyActiveOperationTask", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyActiveOperationTaskResponse> ModifyActiveOperationTaskWithOptionsAsync(ModifyActiveOperationTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyActiveOperationTaskResponse>(await DoRPCRequestAsync("ModifyActiveOperationTask", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyActiveOperationTaskResponse ModifyActiveOperationTask(ModifyActiveOperationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyActiveOperationTaskWithOptions(request, runtime);
        }

        public async Task<ModifyActiveOperationTaskResponse> ModifyActiveOperationTaskAsync(ModifyActiveOperationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyActiveOperationTaskWithOptionsAsync(request, runtime);
        }

        public ModifyBackupPolicyResponse ModifyBackupPolicyWithOptions(ModifyBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupPolicyResponse>(DoRPCRequest("ModifyBackupPolicy", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBackupPolicyResponse> ModifyBackupPolicyWithOptionsAsync(ModifyBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupPolicyResponse>(await DoRPCRequestAsync("ModifyBackupPolicy", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyDBInstanceConnectionStringResponse ModifyDBInstanceConnectionStringWithOptions(ModifyDBInstanceConnectionStringRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceConnectionStringResponse>(DoRPCRequest("ModifyDBInstanceConnectionString", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstanceConnectionStringResponse> ModifyDBInstanceConnectionStringWithOptionsAsync(ModifyDBInstanceConnectionStringRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceConnectionStringResponse>(await DoRPCRequestAsync("ModifyDBInstanceConnectionString", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBInstanceConnectionStringResponse ModifyDBInstanceConnectionString(ModifyDBInstanceConnectionStringRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceConnectionStringWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceConnectionStringResponse> ModifyDBInstanceConnectionStringAsync(ModifyDBInstanceConnectionStringRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceConnectionStringWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceAttributeResponse ModifyInstanceAttributeWithOptions(ModifyInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAttributeResponse>(DoRPCRequest("ModifyInstanceAttribute", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeWithOptionsAsync(ModifyInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAttributeResponse>(await DoRPCRequestAsync("ModifyInstanceAttribute", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeAsync(ModifyInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceAutoRenewalAttributeResponse ModifyInstanceAutoRenewalAttributeWithOptions(ModifyInstanceAutoRenewalAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAutoRenewalAttributeResponse>(DoRPCRequest("ModifyInstanceAutoRenewalAttribute", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceAutoRenewalAttributeResponse> ModifyInstanceAutoRenewalAttributeWithOptionsAsync(ModifyInstanceAutoRenewalAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAutoRenewalAttributeResponse>(await DoRPCRequestAsync("ModifyInstanceAutoRenewalAttribute", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceAutoRenewalAttributeResponse ModifyInstanceAutoRenewalAttribute(ModifyInstanceAutoRenewalAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceAutoRenewalAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceAutoRenewalAttributeResponse> ModifyInstanceAutoRenewalAttributeAsync(ModifyInstanceAutoRenewalAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceAutoRenewalAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceConfigResponse ModifyInstanceConfigWithOptions(ModifyInstanceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceConfigResponse>(DoRPCRequest("ModifyInstanceConfig", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceConfigResponse> ModifyInstanceConfigWithOptionsAsync(ModifyInstanceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceConfigResponse>(await DoRPCRequestAsync("ModifyInstanceConfig", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceConfigResponse ModifyInstanceConfig(ModifyInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceConfigWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceConfigResponse> ModifyInstanceConfigAsync(ModifyInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceConfigWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceMaintainTimeResponse ModifyInstanceMaintainTimeWithOptions(ModifyInstanceMaintainTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceMaintainTimeResponse>(DoRPCRequest("ModifyInstanceMaintainTime", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceMaintainTimeResponse> ModifyInstanceMaintainTimeWithOptionsAsync(ModifyInstanceMaintainTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceMaintainTimeResponse>(await DoRPCRequestAsync("ModifyInstanceMaintainTime", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyInstanceMajorVersionResponse ModifyInstanceMajorVersionWithOptions(ModifyInstanceMajorVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceMajorVersionResponse>(DoRPCRequest("ModifyInstanceMajorVersion", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceMajorVersionResponse> ModifyInstanceMajorVersionWithOptionsAsync(ModifyInstanceMajorVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceMajorVersionResponse>(await DoRPCRequestAsync("ModifyInstanceMajorVersion", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceMajorVersionResponse ModifyInstanceMajorVersion(ModifyInstanceMajorVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceMajorVersionWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceMajorVersionResponse> ModifyInstanceMajorVersionAsync(ModifyInstanceMajorVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceMajorVersionWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceMinorVersionResponse ModifyInstanceMinorVersionWithOptions(ModifyInstanceMinorVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceMinorVersionResponse>(DoRPCRequest("ModifyInstanceMinorVersion", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceMinorVersionResponse> ModifyInstanceMinorVersionWithOptionsAsync(ModifyInstanceMinorVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceMinorVersionResponse>(await DoRPCRequestAsync("ModifyInstanceMinorVersion", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceMinorVersionResponse ModifyInstanceMinorVersion(ModifyInstanceMinorVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceMinorVersionWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceMinorVersionResponse> ModifyInstanceMinorVersionAsync(ModifyInstanceMinorVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceMinorVersionWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceNetExpireTimeResponse ModifyInstanceNetExpireTimeWithOptions(ModifyInstanceNetExpireTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceNetExpireTimeResponse>(DoRPCRequest("ModifyInstanceNetExpireTime", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceNetExpireTimeResponse> ModifyInstanceNetExpireTimeWithOptionsAsync(ModifyInstanceNetExpireTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceNetExpireTimeResponse>(await DoRPCRequestAsync("ModifyInstanceNetExpireTime", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceNetExpireTimeResponse ModifyInstanceNetExpireTime(ModifyInstanceNetExpireTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceNetExpireTimeWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceNetExpireTimeResponse> ModifyInstanceNetExpireTimeAsync(ModifyInstanceNetExpireTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceNetExpireTimeWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceSpecResponse ModifyInstanceSpecWithOptions(ModifyInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceSpecResponse>(DoRPCRequest("ModifyInstanceSpec", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceSpecResponse> ModifyInstanceSpecWithOptionsAsync(ModifyInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceSpecResponse>(await DoRPCRequestAsync("ModifyInstanceSpec", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceSpecResponse ModifyInstanceSpec(ModifyInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceSpecWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceSpecResponse> ModifyInstanceSpecAsync(ModifyInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceSpecWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceSSLResponse ModifyInstanceSSLWithOptions(ModifyInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceSSLResponse>(DoRPCRequest("ModifyInstanceSSL", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceSSLResponse> ModifyInstanceSSLWithOptionsAsync(ModifyInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceSSLResponse>(await DoRPCRequestAsync("ModifyInstanceSSL", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceSSLResponse ModifyInstanceSSL(ModifyInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceSSLWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceSSLResponse> ModifyInstanceSSLAsync(ModifyInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceSSLWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceVpcAuthModeResponse ModifyInstanceVpcAuthModeWithOptions(ModifyInstanceVpcAuthModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceVpcAuthModeResponse>(DoRPCRequest("ModifyInstanceVpcAuthMode", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceVpcAuthModeResponse> ModifyInstanceVpcAuthModeWithOptionsAsync(ModifyInstanceVpcAuthModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceVpcAuthModeResponse>(await DoRPCRequestAsync("ModifyInstanceVpcAuthMode", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceVpcAuthModeResponse ModifyInstanceVpcAuthMode(ModifyInstanceVpcAuthModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceVpcAuthModeWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceVpcAuthModeResponse> ModifyInstanceVpcAuthModeAsync(ModifyInstanceVpcAuthModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceVpcAuthModeWithOptionsAsync(request, runtime);
        }

        public ModifyIntranetAttributeResponse ModifyIntranetAttributeWithOptions(ModifyIntranetAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIntranetAttributeResponse>(DoRPCRequest("ModifyIntranetAttribute", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyIntranetAttributeResponse> ModifyIntranetAttributeWithOptionsAsync(ModifyIntranetAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIntranetAttributeResponse>(await DoRPCRequestAsync("ModifyIntranetAttribute", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyIntranetAttributeResponse ModifyIntranetAttribute(ModifyIntranetAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIntranetAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyIntranetAttributeResponse> ModifyIntranetAttributeAsync(ModifyIntranetAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIntranetAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyNodeSpecResponse ModifyNodeSpecWithOptions(ModifyNodeSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNodeSpecResponse>(DoRPCRequest("ModifyNodeSpec", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyNodeSpecResponse> ModifyNodeSpecWithOptionsAsync(ModifyNodeSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNodeSpecResponse>(await DoRPCRequestAsync("ModifyNodeSpec", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyNodeSpecResponse ModifyNodeSpec(ModifyNodeSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNodeSpecWithOptions(request, runtime);
        }

        public async Task<ModifyNodeSpecResponse> ModifyNodeSpecAsync(ModifyNodeSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNodeSpecWithOptionsAsync(request, runtime);
        }

        public ModifyResourceGroupResponse ModifyResourceGroupWithOptions(ModifyResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyResourceGroupResponse>(DoRPCRequest("ModifyResourceGroup", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyResourceGroupResponse> ModifyResourceGroupWithOptionsAsync(ModifyResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyResourceGroupResponse>(await DoRPCRequestAsync("ModifyResourceGroup", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyResourceGroupResponse ModifyResourceGroup(ModifyResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyResourceGroupWithOptions(request, runtime);
        }

        public async Task<ModifyResourceGroupResponse> ModifyResourceGroupAsync(ModifyResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyResourceGroupWithOptionsAsync(request, runtime);
        }

        public ModifySecurityGroupConfigurationResponse ModifySecurityGroupConfigurationWithOptions(ModifySecurityGroupConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySecurityGroupConfigurationResponse>(DoRPCRequest("ModifySecurityGroupConfiguration", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySecurityGroupConfigurationResponse> ModifySecurityGroupConfigurationWithOptionsAsync(ModifySecurityGroupConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySecurityGroupConfigurationResponse>(await DoRPCRequestAsync("ModifySecurityGroupConfiguration", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySecurityGroupConfigurationResponse ModifySecurityGroupConfiguration(ModifySecurityGroupConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySecurityGroupConfigurationWithOptions(request, runtime);
        }

        public async Task<ModifySecurityGroupConfigurationResponse> ModifySecurityGroupConfigurationAsync(ModifySecurityGroupConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySecurityGroupConfigurationWithOptionsAsync(request, runtime);
        }

        public ModifySecurityIpsResponse ModifySecurityIpsWithOptions(ModifySecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySecurityIpsResponse>(DoRPCRequest("ModifySecurityIps", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySecurityIpsResponse> ModifySecurityIpsWithOptionsAsync(ModifySecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySecurityIpsResponse>(await DoRPCRequestAsync("ModifySecurityIps", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySecurityIpsResponse ModifySecurityIps(ModifySecurityIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySecurityIpsWithOptions(request, runtime);
        }

        public async Task<ModifySecurityIpsResponse> ModifySecurityIpsAsync(ModifySecurityIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySecurityIpsWithOptionsAsync(request, runtime);
        }

        public ModifyUserClusterHostResponse ModifyUserClusterHostWithOptions(ModifyUserClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUserClusterHostResponse>(DoRPCRequest("ModifyUserClusterHost", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyUserClusterHostResponse> ModifyUserClusterHostWithOptionsAsync(ModifyUserClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUserClusterHostResponse>(await DoRPCRequestAsync("ModifyUserClusterHost", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyUserClusterHostResponse ModifyUserClusterHost(ModifyUserClusterHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUserClusterHostWithOptions(request, runtime);
        }

        public async Task<ModifyUserClusterHostResponse> ModifyUserClusterHostAsync(ModifyUserClusterHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUserClusterHostWithOptionsAsync(request, runtime);
        }

        public ReleaseDirectConnectionResponse ReleaseDirectConnectionWithOptions(ReleaseDirectConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseDirectConnectionResponse>(DoRPCRequest("ReleaseDirectConnection", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseDirectConnectionResponse> ReleaseDirectConnectionWithOptionsAsync(ReleaseDirectConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseDirectConnectionResponse>(await DoRPCRequestAsync("ReleaseDirectConnection", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleaseDirectConnectionResponse ReleaseDirectConnection(ReleaseDirectConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseDirectConnectionWithOptions(request, runtime);
        }

        public async Task<ReleaseDirectConnectionResponse> ReleaseDirectConnectionAsync(ReleaseDirectConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseDirectConnectionWithOptionsAsync(request, runtime);
        }

        public ReleaseInstancePublicConnectionResponse ReleaseInstancePublicConnectionWithOptions(ReleaseInstancePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseInstancePublicConnectionResponse>(DoRPCRequest("ReleaseInstancePublicConnection", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseInstancePublicConnectionResponse> ReleaseInstancePublicConnectionWithOptionsAsync(ReleaseInstancePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseInstancePublicConnectionResponse>(await DoRPCRequestAsync("ReleaseInstancePublicConnection", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleaseInstancePublicConnectionResponse ReleaseInstancePublicConnection(ReleaseInstancePublicConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseInstancePublicConnectionWithOptions(request, runtime);
        }

        public async Task<ReleaseInstancePublicConnectionResponse> ReleaseInstancePublicConnectionAsync(ReleaseInstancePublicConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseInstancePublicConnectionWithOptionsAsync(request, runtime);
        }

        public RenewInstanceResponse RenewInstanceWithOptions(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewInstanceResponse>(DoRPCRequest("RenewInstance", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenewInstanceResponse> RenewInstanceWithOptionsAsync(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewInstanceResponse>(await DoRPCRequestAsync("RenewInstance", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RenewInstanceResponse RenewInstance(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewInstanceWithOptions(request, runtime);
        }

        public async Task<RenewInstanceResponse> RenewInstanceAsync(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewInstanceWithOptionsAsync(request, runtime);
        }

        public ReplaceUserClusterHostResponse ReplaceUserClusterHostWithOptions(ReplaceUserClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReplaceUserClusterHostResponse>(DoRPCRequest("ReplaceUserClusterHost", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReplaceUserClusterHostResponse> ReplaceUserClusterHostWithOptionsAsync(ReplaceUserClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReplaceUserClusterHostResponse>(await DoRPCRequestAsync("ReplaceUserClusterHost", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReplaceUserClusterHostResponse ReplaceUserClusterHost(ReplaceUserClusterHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReplaceUserClusterHostWithOptions(request, runtime);
        }

        public async Task<ReplaceUserClusterHostResponse> ReplaceUserClusterHostAsync(ReplaceUserClusterHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReplaceUserClusterHostWithOptionsAsync(request, runtime);
        }

        public ResetAccountPasswordResponse ResetAccountPasswordWithOptions(ResetAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetAccountPasswordResponse>(DoRPCRequest("ResetAccountPassword", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetAccountPasswordResponse> ResetAccountPasswordWithOptionsAsync(ResetAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetAccountPasswordResponse>(await DoRPCRequestAsync("ResetAccountPassword", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetAccountPasswordResponse ResetAccountPassword(ResetAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetAccountPasswordWithOptions(request, runtime);
        }

        public async Task<ResetAccountPasswordResponse> ResetAccountPasswordAsync(ResetAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetAccountPasswordWithOptionsAsync(request, runtime);
        }

        public RestartInstanceResponse RestartInstanceWithOptions(RestartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartInstanceResponse>(DoRPCRequest("RestartInstance", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestartInstanceResponse> RestartInstanceWithOptionsAsync(RestartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartInstanceResponse>(await DoRPCRequestAsync("RestartInstance", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RestartInstanceResponse RestartInstance(RestartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartInstanceWithOptions(request, runtime);
        }

        public async Task<RestartInstanceResponse> RestartInstanceAsync(RestartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartInstanceWithOptionsAsync(request, runtime);
        }

        public RestoreInstanceResponse RestoreInstanceWithOptions(RestoreInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestoreInstanceResponse>(DoRPCRequest("RestoreInstance", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestoreInstanceResponse> RestoreInstanceWithOptionsAsync(RestoreInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestoreInstanceResponse>(await DoRPCRequestAsync("RestoreInstance", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RestoreInstanceResponse RestoreInstance(RestoreInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestoreInstanceWithOptions(request, runtime);
        }

        public async Task<RestoreInstanceResponse> RestoreInstanceAsync(RestoreInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestoreInstanceWithOptionsAsync(request, runtime);
        }

        public SwitchInstanceHAResponse SwitchInstanceHAWithOptions(SwitchInstanceHARequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchInstanceHAResponse>(DoRPCRequest("SwitchInstanceHA", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SwitchInstanceHAResponse> SwitchInstanceHAWithOptionsAsync(SwitchInstanceHARequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchInstanceHAResponse>(await DoRPCRequestAsync("SwitchInstanceHA", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SwitchInstanceHAResponse SwitchInstanceHA(SwitchInstanceHARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchInstanceHAWithOptions(request, runtime);
        }

        public async Task<SwitchInstanceHAResponse> SwitchInstanceHAAsync(SwitchInstanceHARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchInstanceHAWithOptionsAsync(request, runtime);
        }

        public SwitchNetworkResponse SwitchNetworkWithOptions(SwitchNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchNetworkResponse>(DoRPCRequest("SwitchNetwork", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SwitchNetworkResponse> SwitchNetworkWithOptionsAsync(SwitchNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchNetworkResponse>(await DoRPCRequestAsync("SwitchNetwork", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SwitchNetworkResponse SwitchNetwork(SwitchNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchNetworkWithOptions(request, runtime);
        }

        public async Task<SwitchNetworkResponse> SwitchNetworkAsync(SwitchNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchNetworkWithOptionsAsync(request, runtime);
        }

        public SyncDtsStatusResponse SyncDtsStatusWithOptions(SyncDtsStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SyncDtsStatusResponse>(DoRPCRequest("SyncDtsStatus", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SyncDtsStatusResponse> SyncDtsStatusWithOptionsAsync(SyncDtsStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SyncDtsStatusResponse>(await DoRPCRequestAsync("SyncDtsStatus", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SyncDtsStatusResponse SyncDtsStatus(SyncDtsStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncDtsStatusWithOptions(request, runtime);
        }

        public async Task<SyncDtsStatusResponse> SyncDtsStatusAsync(SyncDtsStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncDtsStatusWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public TransformToPrePaidResponse TransformToPrePaidWithOptions(TransformToPrePaidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransformToPrePaidResponse>(DoRPCRequest("TransformToPrePaid", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TransformToPrePaidResponse> TransformToPrePaidWithOptionsAsync(TransformToPrePaidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransformToPrePaidResponse>(await DoRPCRequestAsync("TransformToPrePaid", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TransformToPrePaidResponse TransformToPrePaid(TransformToPrePaidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransformToPrePaidWithOptions(request, runtime);
        }

        public async Task<TransformToPrePaidResponse> TransformToPrePaidAsync(TransformToPrePaidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransformToPrePaidWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2015-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

    }
}
