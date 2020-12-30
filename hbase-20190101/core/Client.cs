// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.HBase20190101.Models;

namespace AlibabaCloud.SDK.HBase20190101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "hbase.aliyuncs.com"},
                {"ap-southeast-1", "hbase.aliyuncs.com"},
                {"cn-beijing", "hbase.aliyuncs.com"},
                {"cn-beijing-finance-1", "hbase.aliyuncs.com"},
                {"cn-beijing-finance-pop", "hbase.aliyuncs.com"},
                {"cn-beijing-gov-1", "hbase.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "hbase.aliyuncs.com"},
                {"cn-edge-1", "hbase.aliyuncs.com"},
                {"cn-fujian", "hbase.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "hbase.aliyuncs.com"},
                {"cn-hangzhou", "hbase.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "hbase.aliyuncs.com"},
                {"cn-hangzhou-finance", "hbase.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "hbase.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "hbase.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "hbase.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "hbase.aliyuncs.com"},
                {"cn-hangzhou-test-306", "hbase.aliyuncs.com"},
                {"cn-hongkong", "hbase.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "hbase.aliyuncs.com"},
                {"cn-north-2-gov-1", "hbase.aliyuncs.com"},
                {"cn-qingdao", "hbase.aliyuncs.com"},
                {"cn-qingdao-nebula", "hbase.aliyuncs.com"},
                {"cn-shanghai", "hbase.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "hbase.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "hbase.aliyuncs.com"},
                {"cn-shanghai-finance-1", "hbase.aliyuncs.com"},
                {"cn-shanghai-inner", "hbase.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "hbase.aliyuncs.com"},
                {"cn-shenzhen", "hbase.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "hbase.aliyuncs.com"},
                {"cn-shenzhen-inner", "hbase.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "hbase.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "hbase.aliyuncs.com"},
                {"cn-wuhan", "hbase.aliyuncs.com"},
                {"cn-yushanfang", "hbase.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "hbase.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "hbase.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "hbase.aliyuncs.com"},
                {"eu-west-1-oxs", "hbase.ap-northeast-1.aliyuncs.com"},
                {"rus-west-1-pop", "hbase.ap-northeast-1.aliyuncs.com"},
                {"us-east-1", "hbase.aliyuncs.com"},
                {"us-west-1", "hbase.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("hbase", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddUserHdfsInfoResponse AddUserHdfsInfoWithOptions(AddUserHdfsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddUserHdfsInfoResponse>(DoRPCRequest("AddUserHdfsInfo", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddUserHdfsInfoResponse> AddUserHdfsInfoWithOptionsAsync(AddUserHdfsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddUserHdfsInfoResponse>(await DoRPCRequestAsync("AddUserHdfsInfo", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddUserHdfsInfoResponse AddUserHdfsInfo(AddUserHdfsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserHdfsInfoWithOptions(request, runtime);
        }

        public async Task<AddUserHdfsInfoResponse> AddUserHdfsInfoAsync(AddUserHdfsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserHdfsInfoWithOptionsAsync(request, runtime);
        }

        public AllocatePublicNetworkAddressResponse AllocatePublicNetworkAddressWithOptions(AllocatePublicNetworkAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocatePublicNetworkAddressResponse>(DoRPCRequest("AllocatePublicNetworkAddress", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AllocatePublicNetworkAddressResponse> AllocatePublicNetworkAddressWithOptionsAsync(AllocatePublicNetworkAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocatePublicNetworkAddressResponse>(await DoRPCRequestAsync("AllocatePublicNetworkAddress", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AllocatePublicNetworkAddressResponse AllocatePublicNetworkAddress(AllocatePublicNetworkAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocatePublicNetworkAddressWithOptions(request, runtime);
        }

        public async Task<AllocatePublicNetworkAddressResponse> AllocatePublicNetworkAddressAsync(AllocatePublicNetworkAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocatePublicNetworkAddressWithOptionsAsync(request, runtime);
        }

        public CheckComponentsVersionResponse CheckComponentsVersionWithOptions(CheckComponentsVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckComponentsVersionResponse>(DoRPCRequest("CheckComponentsVersion", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckComponentsVersionResponse> CheckComponentsVersionWithOptionsAsync(CheckComponentsVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckComponentsVersionResponse>(await DoRPCRequestAsync("CheckComponentsVersion", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckComponentsVersionResponse CheckComponentsVersion(CheckComponentsVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckComponentsVersionWithOptions(request, runtime);
        }

        public async Task<CheckComponentsVersionResponse> CheckComponentsVersionAsync(CheckComponentsVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckComponentsVersionWithOptionsAsync(request, runtime);
        }

        public CloseBackupResponse CloseBackupWithOptions(CloseBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloseBackupResponse>(DoRPCRequest("CloseBackup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CloseBackupResponse> CloseBackupWithOptionsAsync(CloseBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloseBackupResponse>(await DoRPCRequestAsync("CloseBackup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CloseBackupResponse CloseBackup(CloseBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloseBackupWithOptions(request, runtime);
        }

        public async Task<CloseBackupResponse> CloseBackupAsync(CloseBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloseBackupWithOptionsAsync(request, runtime);
        }

        public ConvertInstanceResponse ConvertInstanceWithOptions(ConvertInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConvertInstanceResponse>(DoRPCRequest("ConvertInstance", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConvertInstanceResponse> ConvertInstanceWithOptionsAsync(ConvertInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConvertInstanceResponse>(await DoRPCRequestAsync("ConvertInstance", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConvertInstanceResponse ConvertInstance(ConvertInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConvertInstanceWithOptions(request, runtime);
        }

        public async Task<ConvertInstanceResponse> ConvertInstanceAsync(ConvertInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConvertInstanceWithOptionsAsync(request, runtime);
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

        public CreateGlobalResourceResponse CreateGlobalResourceWithOptions(CreateGlobalResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGlobalResourceResponse>(DoRPCRequest("CreateGlobalResource", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateGlobalResourceResponse> CreateGlobalResourceWithOptionsAsync(CreateGlobalResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGlobalResourceResponse>(await DoRPCRequestAsync("CreateGlobalResource", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateGlobalResourceResponse CreateGlobalResource(CreateGlobalResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGlobalResourceWithOptions(request, runtime);
        }

        public async Task<CreateGlobalResourceResponse> CreateGlobalResourceAsync(CreateGlobalResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGlobalResourceWithOptionsAsync(request, runtime);
        }

        public CreateHbaseHaSlbResponse CreateHbaseHaSlbWithOptions(CreateHbaseHaSlbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHbaseHaSlbResponse>(DoRPCRequest("CreateHbaseHaSlb", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateHbaseHaSlbResponse> CreateHbaseHaSlbWithOptionsAsync(CreateHbaseHaSlbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHbaseHaSlbResponse>(await DoRPCRequestAsync("CreateHbaseHaSlb", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateHbaseHaSlbResponse CreateHbaseHaSlb(CreateHbaseHaSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHbaseHaSlbWithOptions(request, runtime);
        }

        public async Task<CreateHbaseHaSlbResponse> CreateHbaseHaSlbAsync(CreateHbaseHaSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHbaseHaSlbWithOptionsAsync(request, runtime);
        }

        public CreateHBaseSlbServerResponse CreateHBaseSlbServerWithOptions(CreateHBaseSlbServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHBaseSlbServerResponse>(DoRPCRequest("CreateHBaseSlbServer", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateHBaseSlbServerResponse> CreateHBaseSlbServerWithOptionsAsync(CreateHBaseSlbServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHBaseSlbServerResponse>(await DoRPCRequestAsync("CreateHBaseSlbServer", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateHBaseSlbServerResponse CreateHBaseSlbServer(CreateHBaseSlbServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHBaseSlbServerWithOptions(request, runtime);
        }

        public async Task<CreateHBaseSlbServerResponse> CreateHBaseSlbServerAsync(CreateHBaseSlbServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHBaseSlbServerWithOptionsAsync(request, runtime);
        }

        public CreateMultiZoneClusterResponse CreateMultiZoneClusterWithOptions(CreateMultiZoneClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMultiZoneClusterResponse>(DoRPCRequest("CreateMultiZoneCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMultiZoneClusterResponse> CreateMultiZoneClusterWithOptionsAsync(CreateMultiZoneClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMultiZoneClusterResponse>(await DoRPCRequestAsync("CreateMultiZoneCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMultiZoneClusterResponse CreateMultiZoneCluster(CreateMultiZoneClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMultiZoneClusterWithOptions(request, runtime);
        }

        public async Task<CreateMultiZoneClusterResponse> CreateMultiZoneClusterAsync(CreateMultiZoneClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMultiZoneClusterWithOptionsAsync(request, runtime);
        }

        public CreateRestorePlanResponse CreateRestorePlanWithOptions(CreateRestorePlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRestorePlanResponse>(DoRPCRequest("CreateRestorePlan", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRestorePlanResponse> CreateRestorePlanWithOptionsAsync(CreateRestorePlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRestorePlanResponse>(await DoRPCRequestAsync("CreateRestorePlan", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRestorePlanResponse CreateRestorePlan(CreateRestorePlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRestorePlanWithOptions(request, runtime);
        }

        public async Task<CreateRestorePlanResponse> CreateRestorePlanAsync(CreateRestorePlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRestorePlanWithOptionsAsync(request, runtime);
        }

        public CreateServerlessClusterResponse CreateServerlessClusterWithOptions(CreateServerlessClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateServerlessClusterResponse>(DoRPCRequest("CreateServerlessCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateServerlessClusterResponse> CreateServerlessClusterWithOptionsAsync(CreateServerlessClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateServerlessClusterResponse>(await DoRPCRequestAsync("CreateServerlessCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateServerlessClusterResponse CreateServerlessCluster(CreateServerlessClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServerlessClusterWithOptions(request, runtime);
        }

        public async Task<CreateServerlessClusterResponse> CreateServerlessClusterAsync(CreateServerlessClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServerlessClusterWithOptionsAsync(request, runtime);
        }

        public DeleteGlobalResourceResponse DeleteGlobalResourceWithOptions(DeleteGlobalResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGlobalResourceResponse>(DoRPCRequest("DeleteGlobalResource", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteGlobalResourceResponse> DeleteGlobalResourceWithOptionsAsync(DeleteGlobalResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGlobalResourceResponse>(await DoRPCRequestAsync("DeleteGlobalResource", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteGlobalResourceResponse DeleteGlobalResource(DeleteGlobalResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGlobalResourceWithOptions(request, runtime);
        }

        public async Task<DeleteGlobalResourceResponse> DeleteGlobalResourceAsync(DeleteGlobalResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGlobalResourceWithOptionsAsync(request, runtime);
        }

        public DeleteHBaseHaDBResponse DeleteHBaseHaDBWithOptions(DeleteHBaseHaDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHBaseHaDBResponse>(DoRPCRequest("DeleteHBaseHaDB", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteHBaseHaDBResponse> DeleteHBaseHaDBWithOptionsAsync(DeleteHBaseHaDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHBaseHaDBResponse>(await DoRPCRequestAsync("DeleteHBaseHaDB", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteHBaseHaDBResponse DeleteHBaseHaDB(DeleteHBaseHaDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHBaseHaDBWithOptions(request, runtime);
        }

        public async Task<DeleteHBaseHaDBResponse> DeleteHBaseHaDBAsync(DeleteHBaseHaDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHBaseHaDBWithOptionsAsync(request, runtime);
        }

        public DeleteHbaseHaSlbResponse DeleteHbaseHaSlbWithOptions(DeleteHbaseHaSlbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHbaseHaSlbResponse>(DoRPCRequest("DeleteHbaseHaSlb", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteHbaseHaSlbResponse> DeleteHbaseHaSlbWithOptionsAsync(DeleteHbaseHaSlbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHbaseHaSlbResponse>(await DoRPCRequestAsync("DeleteHbaseHaSlb", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteHbaseHaSlbResponse DeleteHbaseHaSlb(DeleteHbaseHaSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHbaseHaSlbWithOptions(request, runtime);
        }

        public async Task<DeleteHbaseHaSlbResponse> DeleteHbaseHaSlbAsync(DeleteHbaseHaSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHbaseHaSlbWithOptionsAsync(request, runtime);
        }

        public DeleteHBaseSlbServerResponse DeleteHBaseSlbServerWithOptions(DeleteHBaseSlbServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHBaseSlbServerResponse>(DoRPCRequest("DeleteHBaseSlbServer", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteHBaseSlbServerResponse> DeleteHBaseSlbServerWithOptionsAsync(DeleteHBaseSlbServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHBaseSlbServerResponse>(await DoRPCRequestAsync("DeleteHBaseSlbServer", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteHBaseSlbServerResponse DeleteHBaseSlbServer(DeleteHBaseSlbServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHBaseSlbServerWithOptions(request, runtime);
        }

        public async Task<DeleteHBaseSlbServerResponse> DeleteHBaseSlbServerAsync(DeleteHBaseSlbServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHBaseSlbServerWithOptionsAsync(request, runtime);
        }

        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(DoRPCRequest("DeleteInstance", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await DoRPCRequestAsync("DeleteInstance", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteMultiZoneClusterResponse DeleteMultiZoneClusterWithOptions(DeleteMultiZoneClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMultiZoneClusterResponse>(DoRPCRequest("DeleteMultiZoneCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMultiZoneClusterResponse> DeleteMultiZoneClusterWithOptionsAsync(DeleteMultiZoneClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMultiZoneClusterResponse>(await DoRPCRequestAsync("DeleteMultiZoneCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMultiZoneClusterResponse DeleteMultiZoneCluster(DeleteMultiZoneClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMultiZoneClusterWithOptions(request, runtime);
        }

        public async Task<DeleteMultiZoneClusterResponse> DeleteMultiZoneClusterAsync(DeleteMultiZoneClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMultiZoneClusterWithOptionsAsync(request, runtime);
        }

        public DeleteServerlessClusterResponse DeleteServerlessClusterWithOptions(DeleteServerlessClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteServerlessClusterResponse>(DoRPCRequest("DeleteServerlessCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteServerlessClusterResponse> DeleteServerlessClusterWithOptionsAsync(DeleteServerlessClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteServerlessClusterResponse>(await DoRPCRequestAsync("DeleteServerlessCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteServerlessClusterResponse DeleteServerlessCluster(DeleteServerlessClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteServerlessClusterWithOptions(request, runtime);
        }

        public async Task<DeleteServerlessClusterResponse> DeleteServerlessClusterAsync(DeleteServerlessClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteServerlessClusterWithOptionsAsync(request, runtime);
        }

        public DeleteUserHdfsInfoResponse DeleteUserHdfsInfoWithOptions(DeleteUserHdfsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserHdfsInfoResponse>(DoRPCRequest("DeleteUserHdfsInfo", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUserHdfsInfoResponse> DeleteUserHdfsInfoWithOptionsAsync(DeleteUserHdfsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserHdfsInfoResponse>(await DoRPCRequestAsync("DeleteUserHdfsInfo", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUserHdfsInfoResponse DeleteUserHdfsInfo(DeleteUserHdfsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserHdfsInfoWithOptions(request, runtime);
        }

        public async Task<DeleteUserHdfsInfoResponse> DeleteUserHdfsInfoAsync(DeleteUserHdfsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserHdfsInfoWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableResourceResponse DescribeAvailableResourceWithOptions(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(DoRPCRequest("DescribeAvailableResource", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceWithOptionsAsync(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(await DoRPCRequestAsync("DescribeAvailableResource", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeBackupPlanConfigResponse DescribeBackupPlanConfigWithOptions(DescribeBackupPlanConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPlanConfigResponse>(DoRPCRequest("DescribeBackupPlanConfig", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupPlanConfigResponse> DescribeBackupPlanConfigWithOptionsAsync(DescribeBackupPlanConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPlanConfigResponse>(await DoRPCRequestAsync("DescribeBackupPlanConfig", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackupPlanConfigResponse DescribeBackupPlanConfig(DescribeBackupPlanConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupPlanConfigWithOptions(request, runtime);
        }

        public async Task<DescribeBackupPlanConfigResponse> DescribeBackupPlanConfigAsync(DescribeBackupPlanConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupPlanConfigWithOptionsAsync(request, runtime);
        }

        public DescribeBackupPolicyResponse DescribeBackupPolicyWithOptions(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPolicyResponse>(DoRPCRequest("DescribeBackupPolicy", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupPolicyResponse> DescribeBackupPolicyWithOptionsAsync(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPolicyResponse>(await DoRPCRequestAsync("DescribeBackupPolicy", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeBackupStatusResponse DescribeBackupStatusWithOptions(DescribeBackupStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupStatusResponse>(DoRPCRequest("DescribeBackupStatus", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupStatusResponse> DescribeBackupStatusWithOptionsAsync(DescribeBackupStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupStatusResponse>(await DoRPCRequestAsync("DescribeBackupStatus", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackupStatusResponse DescribeBackupStatus(DescribeBackupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupStatusWithOptions(request, runtime);
        }

        public async Task<DescribeBackupStatusResponse> DescribeBackupStatusAsync(DescribeBackupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupStatusWithOptionsAsync(request, runtime);
        }

        public DescribeBackupSummaryResponse DescribeBackupSummaryWithOptions(DescribeBackupSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupSummaryResponse>(DoRPCRequest("DescribeBackupSummary", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupSummaryResponse> DescribeBackupSummaryWithOptionsAsync(DescribeBackupSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupSummaryResponse>(await DoRPCRequestAsync("DescribeBackupSummary", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackupSummaryResponse DescribeBackupSummary(DescribeBackupSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeBackupSummaryResponse> DescribeBackupSummaryAsync(DescribeBackupSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupSummaryWithOptionsAsync(request, runtime);
        }

        public DescribeBackupTablesResponse DescribeBackupTablesWithOptions(DescribeBackupTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupTablesResponse>(DoRPCRequest("DescribeBackupTables", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupTablesResponse> DescribeBackupTablesWithOptionsAsync(DescribeBackupTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupTablesResponse>(await DoRPCRequestAsync("DescribeBackupTables", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackupTablesResponse DescribeBackupTables(DescribeBackupTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupTablesWithOptions(request, runtime);
        }

        public async Task<DescribeBackupTablesResponse> DescribeBackupTablesAsync(DescribeBackupTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupTablesWithOptionsAsync(request, runtime);
        }

        public DescribeClusterConnectionResponse DescribeClusterConnectionWithOptions(DescribeClusterConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterConnectionResponse>(DoRPCRequest("DescribeClusterConnection", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterConnectionResponse> DescribeClusterConnectionWithOptionsAsync(DescribeClusterConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterConnectionResponse>(await DoRPCRequestAsync("DescribeClusterConnection", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClusterConnectionResponse DescribeClusterConnection(DescribeClusterConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterConnectionWithOptions(request, runtime);
        }

        public async Task<DescribeClusterConnectionResponse> DescribeClusterConnectionAsync(DescribeClusterConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterConnectionWithOptionsAsync(request, runtime);
        }

        public DescribeColdStorageResponse DescribeColdStorageWithOptions(DescribeColdStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeColdStorageResponse>(DoRPCRequest("DescribeColdStorage", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeColdStorageResponse> DescribeColdStorageWithOptionsAsync(DescribeColdStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeColdStorageResponse>(await DoRPCRequestAsync("DescribeColdStorage", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeColdStorageResponse DescribeColdStorage(DescribeColdStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeColdStorageWithOptions(request, runtime);
        }

        public async Task<DescribeColdStorageResponse> DescribeColdStorageAsync(DescribeColdStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeColdStorageWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceUsageResponse DescribeDBInstanceUsageWithOptions(DescribeDBInstanceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceUsageResponse>(DoRPCRequest("DescribeDBInstanceUsage", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstanceUsageResponse> DescribeDBInstanceUsageWithOptionsAsync(DescribeDBInstanceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceUsageResponse>(await DoRPCRequestAsync("DescribeDBInstanceUsage", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstanceUsageResponse DescribeDBInstanceUsage(DescribeDBInstanceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceUsageWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceUsageResponse> DescribeDBInstanceUsageAsync(DescribeDBInstanceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceUsageWithOptionsAsync(request, runtime);
        }

        public DescribeDeletedInstancesResponse DescribeDeletedInstancesWithOptions(DescribeDeletedInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeletedInstancesResponse>(DoRPCRequest("DescribeDeletedInstances", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeletedInstancesResponse> DescribeDeletedInstancesWithOptionsAsync(DescribeDeletedInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeletedInstancesResponse>(await DoRPCRequestAsync("DescribeDeletedInstances", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDeletedInstancesResponse DescribeDeletedInstances(DescribeDeletedInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeletedInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeDeletedInstancesResponse> DescribeDeletedInstancesAsync(DescribeDeletedInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeletedInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeDiskWarningLineResponse DescribeDiskWarningLineWithOptions(DescribeDiskWarningLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDiskWarningLineResponse>(DoRPCRequest("DescribeDiskWarningLine", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDiskWarningLineResponse> DescribeDiskWarningLineWithOptionsAsync(DescribeDiskWarningLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDiskWarningLineResponse>(await DoRPCRequestAsync("DescribeDiskWarningLine", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDiskWarningLineResponse DescribeDiskWarningLine(DescribeDiskWarningLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDiskWarningLineWithOptions(request, runtime);
        }

        public async Task<DescribeDiskWarningLineResponse> DescribeDiskWarningLineAsync(DescribeDiskWarningLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDiskWarningLineWithOptionsAsync(request, runtime);
        }

        public DescribeEndpointsResponse DescribeEndpointsWithOptions(DescribeEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEndpointsResponse>(DoRPCRequest("DescribeEndpoints", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEndpointsResponse> DescribeEndpointsWithOptionsAsync(DescribeEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEndpointsResponse>(await DoRPCRequestAsync("DescribeEndpoints", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEndpointsResponse DescribeEndpoints(DescribeEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEndpointsWithOptions(request, runtime);
        }

        public async Task<DescribeEndpointsResponse> DescribeEndpointsAsync(DescribeEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEndpointsWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceResponse DescribeInstanceWithOptions(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(DoRPCRequest("DescribeInstance", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceResponse> DescribeInstanceWithOptionsAsync(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(await DoRPCRequestAsync("DescribeInstance", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceResponse DescribeInstance(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceResponse> DescribeInstanceAsync(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(DoRPCRequest("DescribeInstances", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(await DoRPCRequestAsync("DescribeInstances", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeMultiZoneAvailableRegionsResponse DescribeMultiZoneAvailableRegionsWithOptions(DescribeMultiZoneAvailableRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMultiZoneAvailableRegionsResponse>(DoRPCRequest("DescribeMultiZoneAvailableRegions", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMultiZoneAvailableRegionsResponse> DescribeMultiZoneAvailableRegionsWithOptionsAsync(DescribeMultiZoneAvailableRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMultiZoneAvailableRegionsResponse>(await DoRPCRequestAsync("DescribeMultiZoneAvailableRegions", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMultiZoneAvailableRegionsResponse DescribeMultiZoneAvailableRegions(DescribeMultiZoneAvailableRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMultiZoneAvailableRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeMultiZoneAvailableRegionsResponse> DescribeMultiZoneAvailableRegionsAsync(DescribeMultiZoneAvailableRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMultiZoneAvailableRegionsWithOptionsAsync(request, runtime);
        }

        public DescribeMultiZoneAvailableResourceResponse DescribeMultiZoneAvailableResourceWithOptions(DescribeMultiZoneAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMultiZoneAvailableResourceResponse>(DoRPCRequest("DescribeMultiZoneAvailableResource", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMultiZoneAvailableResourceResponse> DescribeMultiZoneAvailableResourceWithOptionsAsync(DescribeMultiZoneAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMultiZoneAvailableResourceResponse>(await DoRPCRequestAsync("DescribeMultiZoneAvailableResource", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMultiZoneAvailableResourceResponse DescribeMultiZoneAvailableResource(DescribeMultiZoneAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMultiZoneAvailableResourceWithOptions(request, runtime);
        }

        public async Task<DescribeMultiZoneAvailableResourceResponse> DescribeMultiZoneAvailableResourceAsync(DescribeMultiZoneAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMultiZoneAvailableResourceWithOptionsAsync(request, runtime);
        }

        public DescribeMultiZoneClusterResponse DescribeMultiZoneClusterWithOptions(DescribeMultiZoneClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMultiZoneClusterResponse>(DoRPCRequest("DescribeMultiZoneCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMultiZoneClusterResponse> DescribeMultiZoneClusterWithOptionsAsync(DescribeMultiZoneClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMultiZoneClusterResponse>(await DoRPCRequestAsync("DescribeMultiZoneCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMultiZoneClusterResponse DescribeMultiZoneCluster(DescribeMultiZoneClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMultiZoneClusterWithOptions(request, runtime);
        }

        public async Task<DescribeMultiZoneClusterResponse> DescribeMultiZoneClusterAsync(DescribeMultiZoneClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMultiZoneClusterWithOptionsAsync(request, runtime);
        }

        public DescribeRecoverableTimeRangeResponse DescribeRecoverableTimeRangeWithOptions(DescribeRecoverableTimeRangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecoverableTimeRangeResponse>(DoRPCRequest("DescribeRecoverableTimeRange", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRecoverableTimeRangeResponse> DescribeRecoverableTimeRangeWithOptionsAsync(DescribeRecoverableTimeRangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecoverableTimeRangeResponse>(await DoRPCRequestAsync("DescribeRecoverableTimeRange", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRecoverableTimeRangeResponse DescribeRecoverableTimeRange(DescribeRecoverableTimeRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecoverableTimeRangeWithOptions(request, runtime);
        }

        public async Task<DescribeRecoverableTimeRangeResponse> DescribeRecoverableTimeRangeAsync(DescribeRecoverableTimeRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecoverableTimeRangeWithOptionsAsync(request, runtime);
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

        public DescribeRestoreFullDetailsResponse DescribeRestoreFullDetailsWithOptions(DescribeRestoreFullDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRestoreFullDetailsResponse>(DoRPCRequest("DescribeRestoreFullDetails", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRestoreFullDetailsResponse> DescribeRestoreFullDetailsWithOptionsAsync(DescribeRestoreFullDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRestoreFullDetailsResponse>(await DoRPCRequestAsync("DescribeRestoreFullDetails", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRestoreFullDetailsResponse DescribeRestoreFullDetails(DescribeRestoreFullDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestoreFullDetailsWithOptions(request, runtime);
        }

        public async Task<DescribeRestoreFullDetailsResponse> DescribeRestoreFullDetailsAsync(DescribeRestoreFullDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestoreFullDetailsWithOptionsAsync(request, runtime);
        }

        public DescribeRestoreIncrDetailResponse DescribeRestoreIncrDetailWithOptions(DescribeRestoreIncrDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRestoreIncrDetailResponse>(DoRPCRequest("DescribeRestoreIncrDetail", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRestoreIncrDetailResponse> DescribeRestoreIncrDetailWithOptionsAsync(DescribeRestoreIncrDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRestoreIncrDetailResponse>(await DoRPCRequestAsync("DescribeRestoreIncrDetail", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRestoreIncrDetailResponse DescribeRestoreIncrDetail(DescribeRestoreIncrDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestoreIncrDetailWithOptions(request, runtime);
        }

        public async Task<DescribeRestoreIncrDetailResponse> DescribeRestoreIncrDetailAsync(DescribeRestoreIncrDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestoreIncrDetailWithOptionsAsync(request, runtime);
        }

        public DescribeRestoreSchemaDetailsResponse DescribeRestoreSchemaDetailsWithOptions(DescribeRestoreSchemaDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRestoreSchemaDetailsResponse>(DoRPCRequest("DescribeRestoreSchemaDetails", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRestoreSchemaDetailsResponse> DescribeRestoreSchemaDetailsWithOptionsAsync(DescribeRestoreSchemaDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRestoreSchemaDetailsResponse>(await DoRPCRequestAsync("DescribeRestoreSchemaDetails", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRestoreSchemaDetailsResponse DescribeRestoreSchemaDetails(DescribeRestoreSchemaDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestoreSchemaDetailsWithOptions(request, runtime);
        }

        public async Task<DescribeRestoreSchemaDetailsResponse> DescribeRestoreSchemaDetailsAsync(DescribeRestoreSchemaDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestoreSchemaDetailsWithOptionsAsync(request, runtime);
        }

        public DescribeRestoreSummaryResponse DescribeRestoreSummaryWithOptions(DescribeRestoreSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRestoreSummaryResponse>(DoRPCRequest("DescribeRestoreSummary", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRestoreSummaryResponse> DescribeRestoreSummaryWithOptionsAsync(DescribeRestoreSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRestoreSummaryResponse>(await DoRPCRequestAsync("DescribeRestoreSummary", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRestoreSummaryResponse DescribeRestoreSummary(DescribeRestoreSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestoreSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeRestoreSummaryResponse> DescribeRestoreSummaryAsync(DescribeRestoreSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestoreSummaryWithOptionsAsync(request, runtime);
        }

        public DescribeRestoreTablesResponse DescribeRestoreTablesWithOptions(DescribeRestoreTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRestoreTablesResponse>(DoRPCRequest("DescribeRestoreTables", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRestoreTablesResponse> DescribeRestoreTablesWithOptionsAsync(DescribeRestoreTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRestoreTablesResponse>(await DoRPCRequestAsync("DescribeRestoreTables", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRestoreTablesResponse DescribeRestoreTables(DescribeRestoreTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestoreTablesWithOptions(request, runtime);
        }

        public async Task<DescribeRestoreTablesResponse> DescribeRestoreTablesAsync(DescribeRestoreTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestoreTablesWithOptionsAsync(request, runtime);
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

        public DescribeSubDomainResponse DescribeSubDomainWithOptions(DescribeSubDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSubDomainResponse>(DoRPCRequest("DescribeSubDomain", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSubDomainResponse> DescribeSubDomainWithOptionsAsync(DescribeSubDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSubDomainResponse>(await DoRPCRequestAsync("DescribeSubDomain", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSubDomainResponse DescribeSubDomain(DescribeSubDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSubDomainWithOptions(request, runtime);
        }

        public async Task<DescribeSubDomainResponse> DescribeSubDomainAsync(DescribeSubDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSubDomainWithOptionsAsync(request, runtime);
        }

        public EnableHBaseueBackupResponse EnableHBaseueBackupWithOptions(EnableHBaseueBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableHBaseueBackupResponse>(DoRPCRequest("EnableHBaseueBackup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableHBaseueBackupResponse> EnableHBaseueBackupWithOptionsAsync(EnableHBaseueBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableHBaseueBackupResponse>(await DoRPCRequestAsync("EnableHBaseueBackup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableHBaseueBackupResponse EnableHBaseueBackup(EnableHBaseueBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableHBaseueBackupWithOptions(request, runtime);
        }

        public async Task<EnableHBaseueBackupResponse> EnableHBaseueBackupAsync(EnableHBaseueBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableHBaseueBackupWithOptionsAsync(request, runtime);
        }

        public EnableHBaseueModuleResponse EnableHBaseueModuleWithOptions(EnableHBaseueModuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableHBaseueModuleResponse>(DoRPCRequest("EnableHBaseueModule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableHBaseueModuleResponse> EnableHBaseueModuleWithOptionsAsync(EnableHBaseueModuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableHBaseueModuleResponse>(await DoRPCRequestAsync("EnableHBaseueModule", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableHBaseueModuleResponse EnableHBaseueModule(EnableHBaseueModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableHBaseueModuleWithOptions(request, runtime);
        }

        public async Task<EnableHBaseueModuleResponse> EnableHBaseueModuleAsync(EnableHBaseueModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableHBaseueModuleWithOptionsAsync(request, runtime);
        }

        public EvaluateMultiZoneResourceResponse EvaluateMultiZoneResourceWithOptions(EvaluateMultiZoneResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EvaluateMultiZoneResourceResponse>(DoRPCRequest("EvaluateMultiZoneResource", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EvaluateMultiZoneResourceResponse> EvaluateMultiZoneResourceWithOptionsAsync(EvaluateMultiZoneResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EvaluateMultiZoneResourceResponse>(await DoRPCRequestAsync("EvaluateMultiZoneResource", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EvaluateMultiZoneResourceResponse EvaluateMultiZoneResource(EvaluateMultiZoneResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EvaluateMultiZoneResourceWithOptions(request, runtime);
        }

        public async Task<EvaluateMultiZoneResourceResponse> EvaluateMultiZoneResourceAsync(EvaluateMultiZoneResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EvaluateMultiZoneResourceWithOptionsAsync(request, runtime);
        }

        public GetMultimodeCmsUrlResponse GetMultimodeCmsUrlWithOptions(GetMultimodeCmsUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMultimodeCmsUrlResponse>(DoRPCRequest("GetMultimodeCmsUrl", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMultimodeCmsUrlResponse> GetMultimodeCmsUrlWithOptionsAsync(GetMultimodeCmsUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMultimodeCmsUrlResponse>(await DoRPCRequestAsync("GetMultimodeCmsUrl", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMultimodeCmsUrlResponse GetMultimodeCmsUrl(GetMultimodeCmsUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMultimodeCmsUrlWithOptions(request, runtime);
        }

        public async Task<GetMultimodeCmsUrlResponse> GetMultimodeCmsUrlAsync(GetMultimodeCmsUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMultimodeCmsUrlWithOptionsAsync(request, runtime);
        }

        public ListHBaseInstancesResponse ListHBaseInstancesWithOptions(ListHBaseInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHBaseInstancesResponse>(DoRPCRequest("ListHBaseInstances", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListHBaseInstancesResponse> ListHBaseInstancesWithOptionsAsync(ListHBaseInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHBaseInstancesResponse>(await DoRPCRequestAsync("ListHBaseInstances", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListHBaseInstancesResponse ListHBaseInstances(ListHBaseInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHBaseInstancesWithOptions(request, runtime);
        }

        public async Task<ListHBaseInstancesResponse> ListHBaseInstancesAsync(ListHBaseInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHBaseInstancesWithOptionsAsync(request, runtime);
        }

        public ListInstanceServiceConfigHistoriesResponse ListInstanceServiceConfigHistoriesWithOptions(ListInstanceServiceConfigHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInstanceServiceConfigHistoriesResponse>(DoRPCRequest("ListInstanceServiceConfigHistories", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListInstanceServiceConfigHistoriesResponse> ListInstanceServiceConfigHistoriesWithOptionsAsync(ListInstanceServiceConfigHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInstanceServiceConfigHistoriesResponse>(await DoRPCRequestAsync("ListInstanceServiceConfigHistories", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListInstanceServiceConfigHistoriesResponse ListInstanceServiceConfigHistories(ListInstanceServiceConfigHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstanceServiceConfigHistoriesWithOptions(request, runtime);
        }

        public async Task<ListInstanceServiceConfigHistoriesResponse> ListInstanceServiceConfigHistoriesAsync(ListInstanceServiceConfigHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstanceServiceConfigHistoriesWithOptionsAsync(request, runtime);
        }

        public ListInstanceServiceConfigurationsResponse ListInstanceServiceConfigurationsWithOptions(ListInstanceServiceConfigurationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInstanceServiceConfigurationsResponse>(DoRPCRequest("ListInstanceServiceConfigurations", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListInstanceServiceConfigurationsResponse> ListInstanceServiceConfigurationsWithOptionsAsync(ListInstanceServiceConfigurationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInstanceServiceConfigurationsResponse>(await DoRPCRequestAsync("ListInstanceServiceConfigurations", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListInstanceServiceConfigurationsResponse ListInstanceServiceConfigurations(ListInstanceServiceConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstanceServiceConfigurationsWithOptions(request, runtime);
        }

        public async Task<ListInstanceServiceConfigurationsResponse> ListInstanceServiceConfigurationsAsync(ListInstanceServiceConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstanceServiceConfigurationsWithOptionsAsync(request, runtime);
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

        public ModifyBackupPlanConfigResponse ModifyBackupPlanConfigWithOptions(ModifyBackupPlanConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupPlanConfigResponse>(DoRPCRequest("ModifyBackupPlanConfig", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBackupPlanConfigResponse> ModifyBackupPlanConfigWithOptionsAsync(ModifyBackupPlanConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupPlanConfigResponse>(await DoRPCRequestAsync("ModifyBackupPlanConfig", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyBackupPlanConfigResponse ModifyBackupPlanConfig(ModifyBackupPlanConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupPlanConfigWithOptions(request, runtime);
        }

        public async Task<ModifyBackupPlanConfigResponse> ModifyBackupPlanConfigAsync(ModifyBackupPlanConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupPlanConfigWithOptionsAsync(request, runtime);
        }

        public ModifyBackupPolicyResponse ModifyBackupPolicyWithOptions(ModifyBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupPolicyResponse>(DoRPCRequest("ModifyBackupPolicy", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBackupPolicyResponse> ModifyBackupPolicyWithOptionsAsync(ModifyBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupPolicyResponse>(await DoRPCRequestAsync("ModifyBackupPolicy", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyClusterDeletionProtectionResponse ModifyClusterDeletionProtectionWithOptions(ModifyClusterDeletionProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterDeletionProtectionResponse>(DoRPCRequest("ModifyClusterDeletionProtection", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyClusterDeletionProtectionResponse> ModifyClusterDeletionProtectionWithOptionsAsync(ModifyClusterDeletionProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterDeletionProtectionResponse>(await DoRPCRequestAsync("ModifyClusterDeletionProtection", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyClusterDeletionProtectionResponse ModifyClusterDeletionProtection(ModifyClusterDeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClusterDeletionProtectionWithOptions(request, runtime);
        }

        public async Task<ModifyClusterDeletionProtectionResponse> ModifyClusterDeletionProtectionAsync(ModifyClusterDeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClusterDeletionProtectionWithOptionsAsync(request, runtime);
        }

        public ModifyDiskWarningLineResponse ModifyDiskWarningLineWithOptions(ModifyDiskWarningLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDiskWarningLineResponse>(DoRPCRequest("ModifyDiskWarningLine", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDiskWarningLineResponse> ModifyDiskWarningLineWithOptionsAsync(ModifyDiskWarningLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDiskWarningLineResponse>(await DoRPCRequestAsync("ModifyDiskWarningLine", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDiskWarningLineResponse ModifyDiskWarningLine(ModifyDiskWarningLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDiskWarningLineWithOptions(request, runtime);
        }

        public async Task<ModifyDiskWarningLineResponse> ModifyDiskWarningLineAsync(ModifyDiskWarningLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDiskWarningLineWithOptionsAsync(request, runtime);
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

        public ModifyInstanceNameResponse ModifyInstanceNameWithOptions(ModifyInstanceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceNameResponse>(DoRPCRequest("ModifyInstanceName", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceNameResponse> ModifyInstanceNameWithOptionsAsync(ModifyInstanceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceNameResponse>(await DoRPCRequestAsync("ModifyInstanceName", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceNameResponse ModifyInstanceName(ModifyInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceNameWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceNameResponse> ModifyInstanceNameAsync(ModifyInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceNameWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceServiceConfigResponse ModifyInstanceServiceConfigWithOptions(ModifyInstanceServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceServiceConfigResponse>(DoRPCRequest("ModifyInstanceServiceConfig", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceServiceConfigResponse> ModifyInstanceServiceConfigWithOptionsAsync(ModifyInstanceServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceServiceConfigResponse>(await DoRPCRequestAsync("ModifyInstanceServiceConfig", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceServiceConfigResponse ModifyInstanceServiceConfig(ModifyInstanceServiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceServiceConfigWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceServiceConfigResponse> ModifyInstanceServiceConfigAsync(ModifyInstanceServiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceServiceConfigWithOptionsAsync(request, runtime);
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

        public ModifyMultiZoneClusterNodeTypeResponse ModifyMultiZoneClusterNodeTypeWithOptions(ModifyMultiZoneClusterNodeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyMultiZoneClusterNodeTypeResponse>(DoRPCRequest("ModifyMultiZoneClusterNodeType", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyMultiZoneClusterNodeTypeResponse> ModifyMultiZoneClusterNodeTypeWithOptionsAsync(ModifyMultiZoneClusterNodeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyMultiZoneClusterNodeTypeResponse>(await DoRPCRequestAsync("ModifyMultiZoneClusterNodeType", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyMultiZoneClusterNodeTypeResponse ModifyMultiZoneClusterNodeType(ModifyMultiZoneClusterNodeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMultiZoneClusterNodeTypeWithOptions(request, runtime);
        }

        public async Task<ModifyMultiZoneClusterNodeTypeResponse> ModifyMultiZoneClusterNodeTypeAsync(ModifyMultiZoneClusterNodeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMultiZoneClusterNodeTypeWithOptionsAsync(request, runtime);
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

        public ModifyUIAccountPasswordResponse ModifyUIAccountPasswordWithOptions(ModifyUIAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUIAccountPasswordResponse>(DoRPCRequest("ModifyUIAccountPassword", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyUIAccountPasswordResponse> ModifyUIAccountPasswordWithOptionsAsync(ModifyUIAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUIAccountPasswordResponse>(await DoRPCRequestAsync("ModifyUIAccountPassword", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyUIAccountPasswordResponse ModifyUIAccountPassword(ModifyUIAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUIAccountPasswordWithOptions(request, runtime);
        }

        public async Task<ModifyUIAccountPasswordResponse> ModifyUIAccountPasswordAsync(ModifyUIAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUIAccountPasswordWithOptionsAsync(request, runtime);
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

        public OpenBackupResponse OpenBackupWithOptions(OpenBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenBackupResponse>(DoRPCRequest("OpenBackup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenBackupResponse> OpenBackupWithOptionsAsync(OpenBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenBackupResponse>(await DoRPCRequestAsync("OpenBackup", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpenBackupResponse OpenBackup(OpenBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenBackupWithOptions(request, runtime);
        }

        public async Task<OpenBackupResponse> OpenBackupAsync(OpenBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenBackupWithOptionsAsync(request, runtime);
        }

        public PurgeInstanceResponse PurgeInstanceWithOptions(PurgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PurgeInstanceResponse>(DoRPCRequest("PurgeInstance", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PurgeInstanceResponse> PurgeInstanceWithOptionsAsync(PurgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PurgeInstanceResponse>(await DoRPCRequestAsync("PurgeInstance", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PurgeInstanceResponse PurgeInstance(PurgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PurgeInstanceWithOptions(request, runtime);
        }

        public async Task<PurgeInstanceResponse> PurgeInstanceAsync(PurgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PurgeInstanceWithOptionsAsync(request, runtime);
        }

        public QueryHBaseHaDBResponse QueryHBaseHaDBWithOptions(QueryHBaseHaDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryHBaseHaDBResponse>(DoRPCRequest("QueryHBaseHaDB", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryHBaseHaDBResponse> QueryHBaseHaDBWithOptionsAsync(QueryHBaseHaDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryHBaseHaDBResponse>(await DoRPCRequestAsync("QueryHBaseHaDB", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryHBaseHaDBResponse QueryHBaseHaDB(QueryHBaseHaDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryHBaseHaDBWithOptions(request, runtime);
        }

        public async Task<QueryHBaseHaDBResponse> QueryHBaseHaDBAsync(QueryHBaseHaDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryHBaseHaDBWithOptionsAsync(request, runtime);
        }

        public QueryXpackRelateDBResponse QueryXpackRelateDBWithOptions(QueryXpackRelateDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryXpackRelateDBResponse>(DoRPCRequest("QueryXpackRelateDB", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryXpackRelateDBResponse> QueryXpackRelateDBWithOptionsAsync(QueryXpackRelateDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryXpackRelateDBResponse>(await DoRPCRequestAsync("QueryXpackRelateDB", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryXpackRelateDBResponse QueryXpackRelateDB(QueryXpackRelateDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryXpackRelateDBWithOptions(request, runtime);
        }

        public async Task<QueryXpackRelateDBResponse> QueryXpackRelateDBAsync(QueryXpackRelateDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryXpackRelateDBWithOptionsAsync(request, runtime);
        }

        public RelateDbForHBaseHaResponse RelateDbForHBaseHaWithOptions(RelateDbForHBaseHaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RelateDbForHBaseHaResponse>(DoRPCRequest("RelateDbForHBaseHa", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RelateDbForHBaseHaResponse> RelateDbForHBaseHaWithOptionsAsync(RelateDbForHBaseHaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RelateDbForHBaseHaResponse>(await DoRPCRequestAsync("RelateDbForHBaseHa", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RelateDbForHBaseHaResponse RelateDbForHBaseHa(RelateDbForHBaseHaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RelateDbForHBaseHaWithOptions(request, runtime);
        }

        public async Task<RelateDbForHBaseHaResponse> RelateDbForHBaseHaAsync(RelateDbForHBaseHaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RelateDbForHBaseHaWithOptionsAsync(request, runtime);
        }

        public ReleasePublicNetworkAddressResponse ReleasePublicNetworkAddressWithOptions(ReleasePublicNetworkAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleasePublicNetworkAddressResponse>(DoRPCRequest("ReleasePublicNetworkAddress", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleasePublicNetworkAddressResponse> ReleasePublicNetworkAddressWithOptionsAsync(ReleasePublicNetworkAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleasePublicNetworkAddressResponse>(await DoRPCRequestAsync("ReleasePublicNetworkAddress", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleasePublicNetworkAddressResponse ReleasePublicNetworkAddress(ReleasePublicNetworkAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleasePublicNetworkAddressWithOptions(request, runtime);
        }

        public async Task<ReleasePublicNetworkAddressResponse> ReleasePublicNetworkAddressAsync(ReleasePublicNetworkAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleasePublicNetworkAddressWithOptionsAsync(request, runtime);
        }

        public RenewInstanceResponse RenewInstanceWithOptions(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewInstanceResponse>(DoRPCRequest("RenewInstance", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenewInstanceResponse> RenewInstanceWithOptionsAsync(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewInstanceResponse>(await DoRPCRequestAsync("RenewInstance", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ResizeColdStorageSizeResponse ResizeColdStorageSizeWithOptions(ResizeColdStorageSizeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResizeColdStorageSizeResponse>(DoRPCRequest("ResizeColdStorageSize", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResizeColdStorageSizeResponse> ResizeColdStorageSizeWithOptionsAsync(ResizeColdStorageSizeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResizeColdStorageSizeResponse>(await DoRPCRequestAsync("ResizeColdStorageSize", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResizeColdStorageSizeResponse ResizeColdStorageSize(ResizeColdStorageSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResizeColdStorageSizeWithOptions(request, runtime);
        }

        public async Task<ResizeColdStorageSizeResponse> ResizeColdStorageSizeAsync(ResizeColdStorageSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResizeColdStorageSizeWithOptionsAsync(request, runtime);
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

        public ResizeMultiZoneClusterDiskSizeResponse ResizeMultiZoneClusterDiskSizeWithOptions(ResizeMultiZoneClusterDiskSizeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResizeMultiZoneClusterDiskSizeResponse>(DoRPCRequest("ResizeMultiZoneClusterDiskSize", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResizeMultiZoneClusterDiskSizeResponse> ResizeMultiZoneClusterDiskSizeWithOptionsAsync(ResizeMultiZoneClusterDiskSizeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResizeMultiZoneClusterDiskSizeResponse>(await DoRPCRequestAsync("ResizeMultiZoneClusterDiskSize", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResizeMultiZoneClusterDiskSizeResponse ResizeMultiZoneClusterDiskSize(ResizeMultiZoneClusterDiskSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResizeMultiZoneClusterDiskSizeWithOptions(request, runtime);
        }

        public async Task<ResizeMultiZoneClusterDiskSizeResponse> ResizeMultiZoneClusterDiskSizeAsync(ResizeMultiZoneClusterDiskSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResizeMultiZoneClusterDiskSizeWithOptionsAsync(request, runtime);
        }

        public ResizeMultiZoneClusterNodeCountResponse ResizeMultiZoneClusterNodeCountWithOptions(ResizeMultiZoneClusterNodeCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResizeMultiZoneClusterNodeCountResponse>(DoRPCRequest("ResizeMultiZoneClusterNodeCount", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResizeMultiZoneClusterNodeCountResponse> ResizeMultiZoneClusterNodeCountWithOptionsAsync(ResizeMultiZoneClusterNodeCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResizeMultiZoneClusterNodeCountResponse>(await DoRPCRequestAsync("ResizeMultiZoneClusterNodeCount", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResizeMultiZoneClusterNodeCountResponse ResizeMultiZoneClusterNodeCount(ResizeMultiZoneClusterNodeCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResizeMultiZoneClusterNodeCountWithOptions(request, runtime);
        }

        public async Task<ResizeMultiZoneClusterNodeCountResponse> ResizeMultiZoneClusterNodeCountAsync(ResizeMultiZoneClusterNodeCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResizeMultiZoneClusterNodeCountWithOptionsAsync(request, runtime);
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

        public RestartInstanceResponse RestartInstanceWithOptions(RestartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartInstanceResponse>(DoRPCRequest("RestartInstance", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestartInstanceResponse> RestartInstanceWithOptionsAsync(RestartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartInstanceResponse>(await DoRPCRequestAsync("RestartInstance", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SwitchHbaseHaSlbResponse SwitchHbaseHaSlbWithOptions(SwitchHbaseHaSlbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchHbaseHaSlbResponse>(DoRPCRequest("SwitchHbaseHaSlb", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SwitchHbaseHaSlbResponse> SwitchHbaseHaSlbWithOptionsAsync(SwitchHbaseHaSlbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchHbaseHaSlbResponse>(await DoRPCRequestAsync("SwitchHbaseHaSlb", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SwitchHbaseHaSlbResponse SwitchHbaseHaSlb(SwitchHbaseHaSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchHbaseHaSlbWithOptions(request, runtime);
        }

        public async Task<SwitchHbaseHaSlbResponse> SwitchHbaseHaSlbAsync(SwitchHbaseHaSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchHbaseHaSlbWithOptionsAsync(request, runtime);
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

        public UpgradeMinorVersionResponse UpgradeMinorVersionWithOptions(UpgradeMinorVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeMinorVersionResponse>(DoRPCRequest("UpgradeMinorVersion", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeMinorVersionResponse> UpgradeMinorVersionWithOptionsAsync(UpgradeMinorVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeMinorVersionResponse>(await DoRPCRequestAsync("UpgradeMinorVersion", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeMinorVersionResponse UpgradeMinorVersion(UpgradeMinorVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeMinorVersionWithOptions(request, runtime);
        }

        public async Task<UpgradeMinorVersionResponse> UpgradeMinorVersionAsync(UpgradeMinorVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeMinorVersionWithOptionsAsync(request, runtime);
        }

        public UpgradeMultiZoneClusterResponse UpgradeMultiZoneClusterWithOptions(UpgradeMultiZoneClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeMultiZoneClusterResponse>(DoRPCRequest("UpgradeMultiZoneCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeMultiZoneClusterResponse> UpgradeMultiZoneClusterWithOptionsAsync(UpgradeMultiZoneClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeMultiZoneClusterResponse>(await DoRPCRequestAsync("UpgradeMultiZoneCluster", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeMultiZoneClusterResponse UpgradeMultiZoneCluster(UpgradeMultiZoneClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeMultiZoneClusterWithOptions(request, runtime);
        }

        public async Task<UpgradeMultiZoneClusterResponse> UpgradeMultiZoneClusterAsync(UpgradeMultiZoneClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeMultiZoneClusterWithOptionsAsync(request, runtime);
        }

        public XpackRelateDBResponse XpackRelateDBWithOptions(XpackRelateDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<XpackRelateDBResponse>(DoRPCRequest("XpackRelateDB", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<XpackRelateDBResponse> XpackRelateDBWithOptionsAsync(XpackRelateDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<XpackRelateDBResponse>(await DoRPCRequestAsync("XpackRelateDB", "2019-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public XpackRelateDBResponse XpackRelateDB(XpackRelateDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return XpackRelateDBWithOptions(request, runtime);
        }

        public async Task<XpackRelateDBResponse> XpackRelateDBAsync(XpackRelateDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await XpackRelateDBWithOptionsAsync(request, runtime);
        }

    }
}
