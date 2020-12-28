// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Rds20140815.Models;

namespace AlibabaCloud.SDK.Rds20140815
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "rds.aliyuncs.com"},
                {"cn-beijing", "rds.aliyuncs.com"},
                {"cn-hangzhou", "rds.aliyuncs.com"},
                {"cn-shanghai", "rds.aliyuncs.com"},
                {"cn-shenzhen", "rds.aliyuncs.com"},
                {"cn-hongkong", "rds.aliyuncs.com"},
                {"ap-southeast-1", "rds.aliyuncs.com"},
                {"us-west-1", "rds.aliyuncs.com"},
                {"us-east-1", "rds.aliyuncs.com"},
                {"cn-shanghai-finance-1", "rds.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "rds.aliyuncs.com"},
                {"cn-north-2-gov-1", "rds.aliyuncs.com"},
                {"ap-northeast-2-pop", "rds.ap-northeast-1.aliyuncs.com"},
                {"cn-beijing-finance-1", "rds.aliyuncs.com"},
                {"cn-beijing-finance-pop", "rds.aliyuncs.com"},
                {"cn-beijing-gov-1", "rds.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "rds.aliyuncs.com"},
                {"cn-edge-1", "rds.aliyuncs.com"},
                {"cn-fujian", "rds.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "rds.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "rds.aliyuncs.com"},
                {"cn-hangzhou-finance", "rds.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "rds.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "rds.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "rds.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "rds.aliyuncs.com"},
                {"cn-hangzhou-test-306", "rds.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "rds.aliyuncs.com"},
                {"cn-qingdao-nebula", "rds.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "rds.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "rds.aliyuncs.com"},
                {"cn-shanghai-inner", "rds.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "rds.aliyuncs.com"},
                {"cn-shenzhen-inner", "rds.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "rds.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "rds.aliyuncs.com"},
                {"cn-wuhan", "rds.aliyuncs.com"},
                {"cn-yushanfang", "rds.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "rds.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "rds.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "rds.aliyuncs.com"},
                {"eu-west-1-oxs", "rds.ap-northeast-1.aliyuncs.com"},
                {"rus-west-1-pop", "rds.ap-northeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("rds", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateDiagnosticReportResponse CreateDiagnosticReportWithOptions(CreateDiagnosticReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDiagnosticReportResponse>(DoRPCRequest("CreateDiagnosticReport", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDiagnosticReportResponse> CreateDiagnosticReportWithOptionsAsync(CreateDiagnosticReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDiagnosticReportResponse>(await DoRPCRequestAsync("CreateDiagnosticReport", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDiagnosticReportResponse CreateDiagnosticReport(CreateDiagnosticReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDiagnosticReportWithOptions(request, runtime);
        }

        public async Task<CreateDiagnosticReportResponse> CreateDiagnosticReportAsync(CreateDiagnosticReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDiagnosticReportWithOptionsAsync(request, runtime);
        }

        public DescribeDiagnosticReportListResponse DescribeDiagnosticReportListWithOptions(DescribeDiagnosticReportListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDiagnosticReportListResponse>(DoRPCRequest("DescribeDiagnosticReportList", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDiagnosticReportListResponse> DescribeDiagnosticReportListWithOptionsAsync(DescribeDiagnosticReportListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDiagnosticReportListResponse>(await DoRPCRequestAsync("DescribeDiagnosticReportList", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDiagnosticReportListResponse DescribeDiagnosticReportList(DescribeDiagnosticReportListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDiagnosticReportListWithOptions(request, runtime);
        }

        public async Task<DescribeDiagnosticReportListResponse> DescribeDiagnosticReportListAsync(DescribeDiagnosticReportListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDiagnosticReportListWithOptionsAsync(request, runtime);
        }

        public GetDBInstanceTopologyResponse GetDBInstanceTopologyWithOptions(GetDBInstanceTopologyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDBInstanceTopologyResponse>(DoRPCRequest("GetDBInstanceTopology", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDBInstanceTopologyResponse> GetDBInstanceTopologyWithOptionsAsync(GetDBInstanceTopologyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDBInstanceTopologyResponse>(await DoRPCRequestAsync("GetDBInstanceTopology", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDBInstanceTopologyResponse GetDBInstanceTopology(GetDBInstanceTopologyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDBInstanceTopologyWithOptions(request, runtime);
        }

        public async Task<GetDBInstanceTopologyResponse> GetDBInstanceTopologyAsync(GetDBInstanceTopologyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDBInstanceTopologyWithOptionsAsync(request, runtime);
        }

        public MigrateConnectionToOtherZoneResponse MigrateConnectionToOtherZoneWithOptions(MigrateConnectionToOtherZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MigrateConnectionToOtherZoneResponse>(DoRPCRequest("MigrateConnectionToOtherZone", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MigrateConnectionToOtherZoneResponse> MigrateConnectionToOtherZoneWithOptionsAsync(MigrateConnectionToOtherZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MigrateConnectionToOtherZoneResponse>(await DoRPCRequestAsync("MigrateConnectionToOtherZone", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MigrateConnectionToOtherZoneResponse MigrateConnectionToOtherZone(MigrateConnectionToOtherZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MigrateConnectionToOtherZoneWithOptions(request, runtime);
        }

        public async Task<MigrateConnectionToOtherZoneResponse> MigrateConnectionToOtherZoneAsync(MigrateConnectionToOtherZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MigrateConnectionToOtherZoneWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceMonitorResponse ModifyDBInstanceMonitorWithOptions(ModifyDBInstanceMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceMonitorResponse>(DoRPCRequest("ModifyDBInstanceMonitor", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstanceMonitorResponse> ModifyDBInstanceMonitorWithOptionsAsync(ModifyDBInstanceMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceMonitorResponse>(await DoRPCRequestAsync("ModifyDBInstanceMonitor", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBInstanceMonitorResponse ModifyDBInstanceMonitor(ModifyDBInstanceMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceMonitorWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceMonitorResponse> ModifyDBInstanceMonitorAsync(ModifyDBInstanceMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceMonitorWithOptionsAsync(request, runtime);
        }

    }
}
