// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.DBFS20200418.Models;

namespace AlibabaCloud.SDK.DBFS20200418
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "dbfs.aliyuncs.com"},
                {"cn-beijing-finance-1", "dbfs.aliyuncs.com"},
                {"cn-beijing-finance-pop", "dbfs.aliyuncs.com"},
                {"cn-beijing-gov-1", "dbfs.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "dbfs.aliyuncs.com"},
                {"cn-edge-1", "dbfs.aliyuncs.com"},
                {"cn-fujian", "dbfs.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "dbfs.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "dbfs.aliyuncs.com"},
                {"cn-hangzhou-finance", "dbfs.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "dbfs.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "dbfs.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "dbfs.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "dbfs.aliyuncs.com"},
                {"cn-hangzhou-test-306", "dbfs.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "dbfs.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "dbfs.aliyuncs.com"},
                {"cn-north-2-gov-1", "dbfs.aliyuncs.com"},
                {"cn-qingdao-nebula", "dbfs.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "dbfs.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "dbfs.aliyuncs.com"},
                {"cn-shanghai-finance-1", "dbfs.aliyuncs.com"},
                {"cn-shanghai-inner", "dbfs.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "dbfs.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "dbfs.aliyuncs.com"},
                {"cn-shenzhen-inner", "dbfs.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "dbfs.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "dbfs.aliyuncs.com"},
                {"cn-wuhan", "dbfs.aliyuncs.com"},
                {"cn-wulanchabu", "dbfs.aliyuncs.com"},
                {"cn-yushanfang", "dbfs.aliyuncs.com"},
                {"cn-zhangbei", "dbfs.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "dbfs.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "dbfs.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "dbfs.aliyuncs.com"},
                {"eu-west-1-oxs", "dbfs.aliyuncs.com"},
                {"rus-west-1-pop", "dbfs.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("dbfs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateConstantsResponse CreateConstantsWithOptions(CreateConstantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateConstantsResponse>(DoRPCRequest("CreateConstants", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateConstantsResponse> CreateConstantsWithOptionsAsync(CreateConstantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateConstantsResponse>(await DoRPCRequestAsync("CreateConstants", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateConstantsResponse CreateConstants(CreateConstantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConstantsWithOptions(request, runtime);
        }

        public async Task<CreateConstantsResponse> CreateConstantsAsync(CreateConstantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConstantsWithOptionsAsync(request, runtime);
        }

        public DeleteDbfsResponse DeleteDbfsWithOptions(DeleteDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDbfsResponse>(DoRPCRequest("DeleteDbfs", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDbfsResponse> DeleteDbfsWithOptionsAsync(DeleteDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDbfsResponse>(await DoRPCRequestAsync("DeleteDbfs", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDbfsResponse DeleteDbfs(DeleteDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDbfsWithOptions(request, runtime);
        }

        public async Task<DeleteDbfsResponse> DeleteDbfsAsync(DeleteDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDbfsWithOptionsAsync(request, runtime);
        }

        public DeleteConstantsResponse DeleteConstantsWithOptions(DeleteConstantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteConstantsResponse>(DoRPCRequest("DeleteConstants", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteConstantsResponse> DeleteConstantsWithOptionsAsync(DeleteConstantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteConstantsResponse>(await DoRPCRequestAsync("DeleteConstants", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteConstantsResponse DeleteConstants(DeleteConstantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteConstantsWithOptions(request, runtime);
        }

        public async Task<DeleteConstantsResponse> DeleteConstantsAsync(DeleteConstantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteConstantsWithOptionsAsync(request, runtime);
        }

        public CreateServiceLinkedRoleResponse CreateServiceLinkedRoleWithOptions(CreateServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateServiceLinkedRoleResponse>(DoRPCRequest("CreateServiceLinkedRole", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRoleWithOptionsAsync(CreateServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateServiceLinkedRoleResponse>(await DoRPCRequestAsync("CreateServiceLinkedRole", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateServiceLinkedRoleResponse CreateServiceLinkedRole(CreateServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceLinkedRoleWithOptions(request, runtime);
        }

        public async Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRoleAsync(CreateServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceLinkedRoleWithOptionsAsync(request, runtime);
        }

        public ResizeDbfsResponse ResizeDbfsWithOptions(ResizeDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResizeDbfsResponse>(DoRPCRequest("ResizeDbfs", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResizeDbfsResponse> ResizeDbfsWithOptionsAsync(ResizeDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResizeDbfsResponse>(await DoRPCRequestAsync("ResizeDbfs", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResizeDbfsResponse ResizeDbfs(ResizeDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResizeDbfsWithOptions(request, runtime);
        }

        public async Task<ResizeDbfsResponse> ResizeDbfsAsync(ResizeDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResizeDbfsWithOptionsAsync(request, runtime);
        }

        public PublishUpgradeTaskResponse PublishUpgradeTaskWithOptions(PublishUpgradeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishUpgradeTaskResponse>(DoRPCRequest("PublishUpgradeTask", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PublishUpgradeTaskResponse> PublishUpgradeTaskWithOptionsAsync(PublishUpgradeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishUpgradeTaskResponse>(await DoRPCRequestAsync("PublishUpgradeTask", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PublishUpgradeTaskResponse PublishUpgradeTask(PublishUpgradeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishUpgradeTaskWithOptions(request, runtime);
        }

        public async Task<PublishUpgradeTaskResponse> PublishUpgradeTaskAsync(PublishUpgradeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishUpgradeTaskWithOptionsAsync(request, runtime);
        }

        public ListTagValuesResponse ListTagValuesWithOptions(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagValuesResponse>(DoRPCRequest("ListTagValues", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagValuesResponse> ListTagValuesWithOptionsAsync(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagValuesResponse>(await DoRPCRequestAsync("ListTagValues", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagValuesResponse ListTagValues(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagValuesWithOptions(request, runtime);
        }

        public async Task<ListTagValuesResponse> ListTagValuesAsync(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagValuesWithOptionsAsync(request, runtime);
        }

        public DeleteSnapshotResponse DeleteSnapshotWithOptions(DeleteSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSnapshotResponse>(DoRPCRequest("DeleteSnapshot", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSnapshotResponse> DeleteSnapshotWithOptionsAsync(DeleteSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSnapshotResponse>(await DoRPCRequestAsync("DeleteSnapshot", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSnapshotWithOptions(request, runtime);
        }

        public async Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSnapshotWithOptionsAsync(request, runtime);
        }

        public DetachDbfsResponse DetachDbfsWithOptions(DetachDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachDbfsResponse>(DoRPCRequest("DetachDbfs", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachDbfsResponse> DetachDbfsWithOptionsAsync(DetachDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachDbfsResponse>(await DoRPCRequestAsync("DetachDbfs", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachDbfsResponse DetachDbfs(DetachDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachDbfsWithOptions(request, runtime);
        }

        public async Task<DetachDbfsResponse> DetachDbfsAsync(DetachDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachDbfsWithOptionsAsync(request, runtime);
        }

        public GenerateUpgradeRecordResponse GenerateUpgradeRecordWithOptions(GenerateUpgradeRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateUpgradeRecordResponse>(DoRPCRequest("GenerateUpgradeRecord", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateUpgradeRecordResponse> GenerateUpgradeRecordWithOptionsAsync(GenerateUpgradeRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateUpgradeRecordResponse>(await DoRPCRequestAsync("GenerateUpgradeRecord", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateUpgradeRecordResponse GenerateUpgradeRecord(GenerateUpgradeRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateUpgradeRecordWithOptions(request, runtime);
        }

        public async Task<GenerateUpgradeRecordResponse> GenerateUpgradeRecordAsync(GenerateUpgradeRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateUpgradeRecordWithOptionsAsync(request, runtime);
        }

        public ResetDbfsResponse ResetDbfsWithOptions(ResetDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetDbfsResponse>(DoRPCRequest("ResetDbfs", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetDbfsResponse> ResetDbfsWithOptionsAsync(ResetDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetDbfsResponse>(await DoRPCRequestAsync("ResetDbfs", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetDbfsResponse ResetDbfs(ResetDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetDbfsWithOptions(request, runtime);
        }

        public async Task<ResetDbfsResponse> ResetDbfsAsync(ResetDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetDbfsWithOptionsAsync(request, runtime);
        }

        public GetDbfsResponse GetDbfsWithOptions(GetDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDbfsResponse>(DoRPCRequest("GetDbfs", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDbfsResponse> GetDbfsWithOptionsAsync(GetDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDbfsResponse>(await DoRPCRequestAsync("GetDbfs", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDbfsResponse GetDbfs(GetDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDbfsWithOptions(request, runtime);
        }

        public async Task<GetDbfsResponse> GetDbfsAsync(GetDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDbfsWithOptionsAsync(request, runtime);
        }

        public DbfsRecordResponse DbfsRecordWithOptions(DbfsRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DbfsRecordResponse>(DoRPCRequest("DbfsRecord", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DbfsRecordResponse> DbfsRecordWithOptionsAsync(DbfsRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DbfsRecordResponse>(await DoRPCRequestAsync("DbfsRecord", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DbfsRecordResponse DbfsRecord(DbfsRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DbfsRecordWithOptions(request, runtime);
        }

        public async Task<DbfsRecordResponse> DbfsRecordAsync(DbfsRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DbfsRecordWithOptionsAsync(request, runtime);
        }

        public StopUpgradeTaskResponse StopUpgradeTaskWithOptions(StopUpgradeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopUpgradeTaskResponse>(DoRPCRequest("StopUpgradeTask", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopUpgradeTaskResponse> StopUpgradeTaskWithOptionsAsync(StopUpgradeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopUpgradeTaskResponse>(await DoRPCRequestAsync("StopUpgradeTask", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopUpgradeTaskResponse StopUpgradeTask(StopUpgradeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopUpgradeTaskWithOptions(request, runtime);
        }

        public async Task<StopUpgradeTaskResponse> StopUpgradeTaskAsync(StopUpgradeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopUpgradeTaskWithOptionsAsync(request, runtime);
        }

        public CreateDbfsResponse CreateDbfsWithOptions(CreateDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDbfsResponse>(DoRPCRequest("CreateDbfs", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDbfsResponse> CreateDbfsWithOptionsAsync(CreateDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDbfsResponse>(await DoRPCRequestAsync("CreateDbfs", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDbfsResponse CreateDbfs(CreateDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDbfsWithOptions(request, runtime);
        }

        public async Task<CreateDbfsResponse> CreateDbfsAsync(CreateDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDbfsWithOptionsAsync(request, runtime);
        }

        public UpdateTaskResponse UpdateTaskWithOptions(UpdateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTaskResponse>(DoRPCRequest("UpdateTask", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateTaskResponse> UpdateTaskWithOptionsAsync(UpdateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTaskResponse>(await DoRPCRequestAsync("UpdateTask", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateTaskResponse UpdateTask(UpdateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTaskWithOptions(request, runtime);
        }

        public async Task<UpdateTaskResponse> UpdateTaskAsync(UpdateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTaskWithOptionsAsync(request, runtime);
        }

        public DeleteTagsBatchResponse DeleteTagsBatchWithOptions(DeleteTagsBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTagsBatchResponse>(DoRPCRequest("DeleteTagsBatch", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTagsBatchResponse> DeleteTagsBatchWithOptionsAsync(DeleteTagsBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTagsBatchResponse>(await DoRPCRequestAsync("DeleteTagsBatch", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTagsBatchResponse DeleteTagsBatch(DeleteTagsBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTagsBatchWithOptions(request, runtime);
        }

        public async Task<DeleteTagsBatchResponse> DeleteTagsBatchAsync(DeleteTagsBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTagsBatchWithOptionsAsync(request, runtime);
        }

        public GetServiceLinkedRoleResponse GetServiceLinkedRoleWithOptions(GetServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetServiceLinkedRoleResponse>(DoRPCRequest("GetServiceLinkedRole", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetServiceLinkedRoleResponse> GetServiceLinkedRoleWithOptionsAsync(GetServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetServiceLinkedRoleResponse>(await DoRPCRequestAsync("GetServiceLinkedRole", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetServiceLinkedRoleResponse GetServiceLinkedRole(GetServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceLinkedRoleWithOptions(request, runtime);
        }

        public async Task<GetServiceLinkedRoleResponse> GetServiceLinkedRoleAsync(GetServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceLinkedRoleWithOptionsAsync(request, runtime);
        }

        public UpdateConstantsResponse UpdateConstantsWithOptions(UpdateConstantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateConstantsResponse>(DoRPCRequest("UpdateConstants", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateConstantsResponse> UpdateConstantsWithOptionsAsync(UpdateConstantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateConstantsResponse>(await DoRPCRequestAsync("UpdateConstants", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateConstantsResponse UpdateConstants(UpdateConstantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateConstantsWithOptions(request, runtime);
        }

        public async Task<UpdateConstantsResponse> UpdateConstantsAsync(UpdateConstantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateConstantsWithOptionsAsync(request, runtime);
        }

        public InsertSynchronizConstantsResponse InsertSynchronizConstantsWithOptions(InsertSynchronizConstantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InsertSynchronizConstantsResponse>(DoRPCRequest("InsertSynchronizConstants", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InsertSynchronizConstantsResponse> InsertSynchronizConstantsWithOptionsAsync(InsertSynchronizConstantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InsertSynchronizConstantsResponse>(await DoRPCRequestAsync("InsertSynchronizConstants", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InsertSynchronizConstantsResponse InsertSynchronizConstants(InsertSynchronizConstantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertSynchronizConstantsWithOptions(request, runtime);
        }

        public async Task<InsertSynchronizConstantsResponse> InsertSynchronizConstantsAsync(InsertSynchronizConstantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertSynchronizConstantsWithOptionsAsync(request, runtime);
        }

        public AttachDbfsResponse AttachDbfsWithOptions(AttachDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachDbfsResponse>(DoRPCRequest("AttachDbfs", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachDbfsResponse> AttachDbfsWithOptionsAsync(AttachDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachDbfsResponse>(await DoRPCRequestAsync("AttachDbfs", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachDbfsResponse AttachDbfs(AttachDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachDbfsWithOptions(request, runtime);
        }

        public async Task<AttachDbfsResponse> AttachDbfsAsync(AttachDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachDbfsWithOptionsAsync(request, runtime);
        }

        public ListTaskResponse ListTaskWithOptions(ListTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTaskResponse>(DoRPCRequest("ListTask", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTaskResponse> ListTaskWithOptionsAsync(ListTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTaskResponse>(await DoRPCRequestAsync("ListTask", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTaskResponse ListTask(ListTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTaskWithOptions(request, runtime);
        }

        public async Task<ListTaskResponse> ListTaskAsync(ListTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTaskWithOptionsAsync(request, runtime);
        }

        public ListDbfsResponse ListDbfsWithOptions(ListDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDbfsResponse>(DoRPCRequest("ListDbfs", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDbfsResponse> ListDbfsWithOptionsAsync(ListDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDbfsResponse>(await DoRPCRequestAsync("ListDbfs", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDbfsResponse ListDbfs(ListDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDbfsWithOptions(request, runtime);
        }

        public async Task<ListDbfsResponse> ListDbfsAsync(ListDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDbfsWithOptionsAsync(request, runtime);
        }

        public AddTagsBatchResponse AddTagsBatchWithOptions(AddTagsBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddTagsBatchResponse>(DoRPCRequest("AddTagsBatch", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddTagsBatchResponse> AddTagsBatchWithOptionsAsync(AddTagsBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddTagsBatchResponse>(await DoRPCRequestAsync("AddTagsBatch", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddTagsBatchResponse AddTagsBatch(AddTagsBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTagsBatchWithOptions(request, runtime);
        }

        public async Task<AddTagsBatchResponse> AddTagsBatchAsync(AddTagsBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTagsBatchWithOptionsAsync(request, runtime);
        }

        public TagDbfsResponse TagDbfsWithOptions(TagDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagDbfsResponse>(DoRPCRequest("TagDbfs", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagDbfsResponse> TagDbfsWithOptionsAsync(TagDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagDbfsResponse>(await DoRPCRequestAsync("TagDbfs", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TagDbfsResponse TagDbfs(TagDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagDbfsWithOptions(request, runtime);
        }

        public async Task<TagDbfsResponse> TagDbfsAsync(TagDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagDbfsWithOptionsAsync(request, runtime);
        }

        public GetSynchronizConstantsResponse GetSynchronizConstantsWithOptions(GetSynchronizConstantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSynchronizConstantsResponse>(DoRPCRequest("GetSynchronizConstants", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSynchronizConstantsResponse> GetSynchronizConstantsWithOptionsAsync(GetSynchronizConstantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSynchronizConstantsResponse>(await DoRPCRequestAsync("GetSynchronizConstants", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSynchronizConstantsResponse GetSynchronizConstants(GetSynchronizConstantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSynchronizConstantsWithOptions(request, runtime);
        }

        public async Task<GetSynchronizConstantsResponse> GetSynchronizConstantsAsync(GetSynchronizConstantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSynchronizConstantsWithOptionsAsync(request, runtime);
        }

        public OpreateConstantsResponse OpreateConstantsWithOptions(OpreateConstantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpreateConstantsResponse>(DoRPCRequest("OpreateConstants", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpreateConstantsResponse> OpreateConstantsWithOptionsAsync(OpreateConstantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpreateConstantsResponse>(await DoRPCRequestAsync("OpreateConstants", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpreateConstantsResponse OpreateConstants(OpreateConstantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpreateConstantsWithOptions(request, runtime);
        }

        public async Task<OpreateConstantsResponse> OpreateConstantsAsync(OpreateConstantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpreateConstantsWithOptionsAsync(request, runtime);
        }

        public RenameDbfsResponse RenameDbfsWithOptions(RenameDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenameDbfsResponse>(DoRPCRequest("RenameDbfs", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenameDbfsResponse> RenameDbfsWithOptionsAsync(RenameDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenameDbfsResponse>(await DoRPCRequestAsync("RenameDbfs", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RenameDbfsResponse RenameDbfs(RenameDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenameDbfsWithOptions(request, runtime);
        }

        public async Task<RenameDbfsResponse> RenameDbfsAsync(RenameDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenameDbfsWithOptionsAsync(request, runtime);
        }

        public ListTagKeysResponse ListTagKeysWithOptions(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagKeysResponse>(DoRPCRequest("ListTagKeys", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagKeysResponse> ListTagKeysWithOptionsAsync(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagKeysResponse>(await DoRPCRequestAsync("ListTagKeys", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagKeysResponse ListTagKeys(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagKeysWithOptions(request, runtime);
        }

        public async Task<ListTagKeysResponse> ListTagKeysAsync(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagKeysWithOptionsAsync(request, runtime);
        }

        public ListConstantsResponse ListConstantsWithOptions(ListConstantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListConstantsResponse>(DoRPCRequest("ListConstants", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListConstantsResponse> ListConstantsWithOptionsAsync(ListConstantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListConstantsResponse>(await DoRPCRequestAsync("ListConstants", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListConstantsResponse ListConstants(ListConstantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConstantsWithOptions(request, runtime);
        }

        public async Task<ListConstantsResponse> ListConstantsAsync(ListConstantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConstantsWithOptionsAsync(request, runtime);
        }

        public ListSnapshotResponse ListSnapshotWithOptions(ListSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSnapshotResponse>(DoRPCRequest("ListSnapshot", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSnapshotResponse> ListSnapshotWithOptionsAsync(ListSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSnapshotResponse>(await DoRPCRequestAsync("ListSnapshot", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSnapshotResponse ListSnapshot(ListSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSnapshotWithOptions(request, runtime);
        }

        public async Task<ListSnapshotResponse> ListSnapshotAsync(ListSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSnapshotWithOptionsAsync(request, runtime);
        }

        public DescribeDbfsSpecificationsResponse DescribeDbfsSpecificationsWithOptions(DescribeDbfsSpecificationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDbfsSpecificationsResponse>(DoRPCRequest("DescribeDbfsSpecifications", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDbfsSpecificationsResponse> DescribeDbfsSpecificationsWithOptionsAsync(DescribeDbfsSpecificationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDbfsSpecificationsResponse>(await DoRPCRequestAsync("DescribeDbfsSpecifications", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDbfsSpecificationsResponse DescribeDbfsSpecifications(DescribeDbfsSpecificationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDbfsSpecificationsWithOptions(request, runtime);
        }

        public async Task<DescribeDbfsSpecificationsResponse> DescribeDbfsSpecificationsAsync(DescribeDbfsSpecificationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDbfsSpecificationsWithOptionsAsync(request, runtime);
        }

        public CreateSnapshotResponse CreateSnapshotWithOptions(CreateSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSnapshotResponse>(DoRPCRequest("CreateSnapshot", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSnapshotResponse> CreateSnapshotWithOptionsAsync(CreateSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSnapshotResponse>(await DoRPCRequestAsync("CreateSnapshot", "2020-04-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSnapshotWithOptions(request, runtime);
        }

        public async Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSnapshotWithOptionsAsync(request, runtime);
        }

    }
}
