// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Drds20190123.Models;

namespace AlibabaCloud.SDK.Drds20190123
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "drds.ap-southeast-1.aliyuncs.com"},
                {"ap-northeast-2-pop", "drds.ap-southeast-1.aliyuncs.com"},
                {"ap-south-1", "drds.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "drds.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-3", "drds.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "drds.ap-southeast-1.aliyuncs.com"},
                {"cn-beijing-finance-1", "drds.aliyuncs.com"},
                {"cn-beijing-finance-pop", "drds.aliyuncs.com"},
                {"cn-beijing-gov-1", "drds.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "drds.aliyuncs.com"},
                {"cn-chengdu", "drds.aliyuncs.com"},
                {"cn-edge-1", "drds.aliyuncs.com"},
                {"cn-fujian", "drds.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "drds.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "drds.aliyuncs.com"},
                {"cn-hangzhou-finance", "drds.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "drds.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "drds.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "drds.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "drds.aliyuncs.com"},
                {"cn-hangzhou-test-306", "drds.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "drds.aliyuncs.com"},
                {"cn-qingdao-nebula", "drds.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "drds.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "drds.aliyuncs.com"},
                {"cn-shanghai-inner", "drds.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "drds.aliyuncs.com"},
                {"cn-shenzhen-inner", "drds.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "drds.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "drds.aliyuncs.com"},
                {"cn-wuhan", "drds.aliyuncs.com"},
                {"cn-yushanfang", "drds.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "drds.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "drds.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "drds.aliyuncs.com"},
                {"eu-central-1", "drds.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1", "drds.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1-oxs", "drds.ap-southeast-1.aliyuncs.com"},
                {"me-east-1", "drds.ap-southeast-1.aliyuncs.com"},
                {"rus-west-1-pop", "drds.ap-southeast-1.aliyuncs.com"},
                {"us-west-1", "drds.ap-southeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("drds", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ChangeAccountPasswordResponse ChangeAccountPasswordWithOptions(ChangeAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeAccountPasswordResponse>(DoRPCRequest("ChangeAccountPassword", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ChangeAccountPasswordResponse> ChangeAccountPasswordWithOptionsAsync(ChangeAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeAccountPasswordResponse>(await DoRPCRequestAsync("ChangeAccountPassword", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ChangeAccountPasswordResponse ChangeAccountPassword(ChangeAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeAccountPasswordWithOptions(request, runtime);
        }

        public async Task<ChangeAccountPasswordResponse> ChangeAccountPasswordAsync(ChangeAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeAccountPasswordWithOptionsAsync(request, runtime);
        }

        public ChangeInstanceAzoneResponse ChangeInstanceAzoneWithOptions(ChangeInstanceAzoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeInstanceAzoneResponse>(DoRPCRequest("ChangeInstanceAzone", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ChangeInstanceAzoneResponse> ChangeInstanceAzoneWithOptionsAsync(ChangeInstanceAzoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeInstanceAzoneResponse>(await DoRPCRequestAsync("ChangeInstanceAzone", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ChangeInstanceAzoneResponse ChangeInstanceAzone(ChangeInstanceAzoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeInstanceAzoneWithOptions(request, runtime);
        }

        public async Task<ChangeInstanceAzoneResponse> ChangeInstanceAzoneAsync(ChangeInstanceAzoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeInstanceAzoneWithOptionsAsync(request, runtime);
        }

        public ChangeInstanceNetworkResponse ChangeInstanceNetworkWithOptions(ChangeInstanceNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeInstanceNetworkResponse>(DoRPCRequest("ChangeInstanceNetwork", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ChangeInstanceNetworkResponse> ChangeInstanceNetworkWithOptionsAsync(ChangeInstanceNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeInstanceNetworkResponse>(await DoRPCRequestAsync("ChangeInstanceNetwork", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ChangeInstanceNetworkResponse ChangeInstanceNetwork(ChangeInstanceNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeInstanceNetworkWithOptions(request, runtime);
        }

        public async Task<ChangeInstanceNetworkResponse> ChangeInstanceNetworkAsync(ChangeInstanceNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeInstanceNetworkWithOptionsAsync(request, runtime);
        }

        public CheckConnectivityResponse CheckConnectivityWithOptions(CheckConnectivityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CheckConnectivityShrinkRequest request = new CheckConnectivityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DbInfo))
            {
                request.DbInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DbInfo, "DbInfo", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckConnectivityResponse>(DoRPCRequest("CheckConnectivity", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckConnectivityResponse> CheckConnectivityWithOptionsAsync(CheckConnectivityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CheckConnectivityShrinkRequest request = new CheckConnectivityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DbInfo))
            {
                request.DbInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DbInfo, "DbInfo", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckConnectivityResponse>(await DoRPCRequestAsync("CheckConnectivity", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckConnectivityResponse CheckConnectivity(CheckConnectivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckConnectivityWithOptions(request, runtime);
        }

        public async Task<CheckConnectivityResponse> CheckConnectivityAsync(CheckConnectivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckConnectivityWithOptionsAsync(request, runtime);
        }

        public CheckDrdsDbNameResponse CheckDrdsDbNameWithOptions(CheckDrdsDbNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckDrdsDbNameResponse>(DoRPCRequest("CheckDrdsDbName", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckDrdsDbNameResponse> CheckDrdsDbNameWithOptionsAsync(CheckDrdsDbNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckDrdsDbNameResponse>(await DoRPCRequestAsync("CheckDrdsDbName", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckDrdsDbNameResponse CheckDrdsDbName(CheckDrdsDbNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDrdsDbNameWithOptions(request, runtime);
        }

        public async Task<CheckDrdsDbNameResponse> CheckDrdsDbNameAsync(CheckDrdsDbNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDrdsDbNameWithOptionsAsync(request, runtime);
        }

        public CheckExpandStatusResponse CheckExpandStatusWithOptions(CheckExpandStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckExpandStatusResponse>(DoRPCRequest("CheckExpandStatus", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckExpandStatusResponse> CheckExpandStatusWithOptionsAsync(CheckExpandStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckExpandStatusResponse>(await DoRPCRequestAsync("CheckExpandStatus", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckExpandStatusResponse CheckExpandStatus(CheckExpandStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckExpandStatusWithOptions(request, runtime);
        }

        public async Task<CheckExpandStatusResponse> CheckExpandStatusAsync(CheckExpandStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckExpandStatusWithOptionsAsync(request, runtime);
        }

        public CheckNewTableNameValidResponse CheckNewTableNameValidWithOptions(CheckNewTableNameValidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckNewTableNameValidResponse>(DoRPCRequest("CheckNewTableNameValid", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckNewTableNameValidResponse> CheckNewTableNameValidWithOptionsAsync(CheckNewTableNameValidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckNewTableNameValidResponse>(await DoRPCRequestAsync("CheckNewTableNameValid", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckNewTableNameValidResponse CheckNewTableNameValid(CheckNewTableNameValidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckNewTableNameValidWithOptions(request, runtime);
        }

        public async Task<CheckNewTableNameValidResponse> CheckNewTableNameValidAsync(CheckNewTableNameValidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckNewTableNameValidWithOptionsAsync(request, runtime);
        }

        public CheckRdsSuperAccountResponse CheckRdsSuperAccountWithOptions(CheckRdsSuperAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckRdsSuperAccountResponse>(DoRPCRequest("CheckRdsSuperAccount", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckRdsSuperAccountResponse> CheckRdsSuperAccountWithOptionsAsync(CheckRdsSuperAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckRdsSuperAccountResponse>(await DoRPCRequestAsync("CheckRdsSuperAccount", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckRdsSuperAccountResponse CheckRdsSuperAccount(CheckRdsSuperAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckRdsSuperAccountWithOptions(request, runtime);
        }

        public async Task<CheckRdsSuperAccountResponse> CheckRdsSuperAccountAsync(CheckRdsSuperAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckRdsSuperAccountWithOptionsAsync(request, runtime);
        }

        public CheckSqlAuditEnableStatusResponse CheckSqlAuditEnableStatusWithOptions(CheckSqlAuditEnableStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckSqlAuditEnableStatusResponse>(DoRPCRequest("CheckSqlAuditEnableStatus", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckSqlAuditEnableStatusResponse> CheckSqlAuditEnableStatusWithOptionsAsync(CheckSqlAuditEnableStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckSqlAuditEnableStatusResponse>(await DoRPCRequestAsync("CheckSqlAuditEnableStatus", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckSqlAuditEnableStatusResponse CheckSqlAuditEnableStatus(CheckSqlAuditEnableStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckSqlAuditEnableStatusWithOptions(request, runtime);
        }

        public async Task<CheckSqlAuditEnableStatusResponse> CheckSqlAuditEnableStatusAsync(CheckSqlAuditEnableStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckSqlAuditEnableStatusWithOptionsAsync(request, runtime);
        }

        public ConfigureDrdsDbInstancesResponse ConfigureDrdsDbInstancesWithOptions(ConfigureDrdsDbInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureDrdsDbInstancesResponse>(DoRPCRequest("ConfigureDrdsDbInstances", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigureDrdsDbInstancesResponse> ConfigureDrdsDbInstancesWithOptionsAsync(ConfigureDrdsDbInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigureDrdsDbInstancesResponse>(await DoRPCRequestAsync("ConfigureDrdsDbInstances", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConfigureDrdsDbInstancesResponse ConfigureDrdsDbInstances(ConfigureDrdsDbInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureDrdsDbInstancesWithOptions(request, runtime);
        }

        public async Task<ConfigureDrdsDbInstancesResponse> ConfigureDrdsDbInstancesAsync(ConfigureDrdsDbInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureDrdsDbInstancesWithOptionsAsync(request, runtime);
        }

        public CreateCustomDataExportPreCheckTaskResponse CreateCustomDataExportPreCheckTaskWithOptions(CreateCustomDataExportPreCheckTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCustomDataExportPreCheckTaskShrinkRequest request = new CreateCustomDataExportPreCheckTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExportParam))
            {
                request.ExportParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExportParam, "ExportParam", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCustomDataExportPreCheckTaskResponse>(DoRPCRequest("CreateCustomDataExportPreCheckTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCustomDataExportPreCheckTaskResponse> CreateCustomDataExportPreCheckTaskWithOptionsAsync(CreateCustomDataExportPreCheckTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCustomDataExportPreCheckTaskShrinkRequest request = new CreateCustomDataExportPreCheckTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExportParam))
            {
                request.ExportParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExportParam, "ExportParam", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCustomDataExportPreCheckTaskResponse>(await DoRPCRequestAsync("CreateCustomDataExportPreCheckTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCustomDataExportPreCheckTaskResponse CreateCustomDataExportPreCheckTask(CreateCustomDataExportPreCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomDataExportPreCheckTaskWithOptions(request, runtime);
        }

        public async Task<CreateCustomDataExportPreCheckTaskResponse> CreateCustomDataExportPreCheckTaskAsync(CreateCustomDataExportPreCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomDataExportPreCheckTaskWithOptionsAsync(request, runtime);
        }

        public CreateCustomDataExportTaskResponse CreateCustomDataExportTaskWithOptions(CreateCustomDataExportTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCustomDataExportTaskShrinkRequest request = new CreateCustomDataExportTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExportParam))
            {
                request.ExportParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExportParam, "ExportParam", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCustomDataExportTaskResponse>(DoRPCRequest("CreateCustomDataExportTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCustomDataExportTaskResponse> CreateCustomDataExportTaskWithOptionsAsync(CreateCustomDataExportTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCustomDataExportTaskShrinkRequest request = new CreateCustomDataExportTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExportParam))
            {
                request.ExportParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExportParam, "ExportParam", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCustomDataExportTaskResponse>(await DoRPCRequestAsync("CreateCustomDataExportTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCustomDataExportTaskResponse CreateCustomDataExportTask(CreateCustomDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomDataExportTaskWithOptions(request, runtime);
        }

        public async Task<CreateCustomDataExportTaskResponse> CreateCustomDataExportTaskAsync(CreateCustomDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomDataExportTaskWithOptionsAsync(request, runtime);
        }

        public CreateCustomDataImportPreCheckTaskResponse CreateCustomDataImportPreCheckTaskWithOptions(CreateCustomDataImportPreCheckTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCustomDataImportPreCheckTaskShrinkRequest request = new CreateCustomDataImportPreCheckTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImportParam))
            {
                request.ImportParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImportParam, "ImportParam", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCustomDataImportPreCheckTaskResponse>(DoRPCRequest("CreateCustomDataImportPreCheckTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCustomDataImportPreCheckTaskResponse> CreateCustomDataImportPreCheckTaskWithOptionsAsync(CreateCustomDataImportPreCheckTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCustomDataImportPreCheckTaskShrinkRequest request = new CreateCustomDataImportPreCheckTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImportParam))
            {
                request.ImportParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImportParam, "ImportParam", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCustomDataImportPreCheckTaskResponse>(await DoRPCRequestAsync("CreateCustomDataImportPreCheckTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCustomDataImportPreCheckTaskResponse CreateCustomDataImportPreCheckTask(CreateCustomDataImportPreCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomDataImportPreCheckTaskWithOptions(request, runtime);
        }

        public async Task<CreateCustomDataImportPreCheckTaskResponse> CreateCustomDataImportPreCheckTaskAsync(CreateCustomDataImportPreCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomDataImportPreCheckTaskWithOptionsAsync(request, runtime);
        }

        public CreateCustomDataImportTaskResponse CreateCustomDataImportTaskWithOptions(CreateCustomDataImportTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCustomDataImportTaskShrinkRequest request = new CreateCustomDataImportTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImportParam))
            {
                request.ImportParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImportParam, "ImportParam", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCustomDataImportTaskResponse>(DoRPCRequest("CreateCustomDataImportTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCustomDataImportTaskResponse> CreateCustomDataImportTaskWithOptionsAsync(CreateCustomDataImportTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCustomDataImportTaskShrinkRequest request = new CreateCustomDataImportTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImportParam))
            {
                request.ImportParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImportParam, "ImportParam", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCustomDataImportTaskResponse>(await DoRPCRequestAsync("CreateCustomDataImportTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCustomDataImportTaskResponse CreateCustomDataImportTask(CreateCustomDataImportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomDataImportTaskWithOptions(request, runtime);
        }

        public async Task<CreateCustomDataImportTaskResponse> CreateCustomDataImportTaskAsync(CreateCustomDataImportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomDataImportTaskWithOptionsAsync(request, runtime);
        }

        public CreateDrdsDBResponse CreateDrdsDBWithOptions(CreateDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDrdsDBResponse>(DoRPCRequest("CreateDrdsDB", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDrdsDBResponse> CreateDrdsDBWithOptionsAsync(CreateDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDrdsDBResponse>(await DoRPCRequestAsync("CreateDrdsDB", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDrdsDBResponse CreateDrdsDB(CreateDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDrdsDBWithOptions(request, runtime);
        }

        public async Task<CreateDrdsDBResponse> CreateDrdsDBAsync(CreateDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDrdsDBWithOptionsAsync(request, runtime);
        }

        public CreateDrdsDBPreCheckResponse CreateDrdsDBPreCheckWithOptions(CreateDrdsDBPreCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDrdsDBPreCheckResponse>(DoRPCRequest("CreateDrdsDBPreCheck", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDrdsDBPreCheckResponse> CreateDrdsDBPreCheckWithOptionsAsync(CreateDrdsDBPreCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDrdsDBPreCheckResponse>(await DoRPCRequestAsync("CreateDrdsDBPreCheck", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDrdsDBPreCheckResponse CreateDrdsDBPreCheck(CreateDrdsDBPreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDrdsDBPreCheckWithOptions(request, runtime);
        }

        public async Task<CreateDrdsDBPreCheckResponse> CreateDrdsDBPreCheckAsync(CreateDrdsDBPreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDrdsDBPreCheckWithOptionsAsync(request, runtime);
        }

        public CreateDrdsDBPreviewResponse CreateDrdsDBPreviewWithOptions(CreateDrdsDBPreviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDrdsDBPreviewResponse>(DoRPCRequest("CreateDrdsDBPreview", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDrdsDBPreviewResponse> CreateDrdsDBPreviewWithOptionsAsync(CreateDrdsDBPreviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDrdsDBPreviewResponse>(await DoRPCRequestAsync("CreateDrdsDBPreview", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDrdsDBPreviewResponse CreateDrdsDBPreview(CreateDrdsDBPreviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDrdsDBPreviewWithOptions(request, runtime);
        }

        public async Task<CreateDrdsDBPreviewResponse> CreateDrdsDBPreviewAsync(CreateDrdsDBPreviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDrdsDBPreviewWithOptionsAsync(request, runtime);
        }

        public CreateDrdsInstanceResponse CreateDrdsInstanceWithOptions(CreateDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDrdsInstanceResponse>(DoRPCRequest("CreateDrdsInstance", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDrdsInstanceResponse> CreateDrdsInstanceWithOptionsAsync(CreateDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDrdsInstanceResponse>(await DoRPCRequestAsync("CreateDrdsInstance", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDrdsInstanceResponse CreateDrdsInstance(CreateDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDrdsInstanceWithOptions(request, runtime);
        }

        public async Task<CreateDrdsInstanceResponse> CreateDrdsInstanceAsync(CreateDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDrdsInstanceWithOptionsAsync(request, runtime);
        }

        public CreateEvaluateDataImportPreCheckTaskResponse CreateEvaluateDataImportPreCheckTaskWithOptions(CreateEvaluateDataImportPreCheckTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEvaluateDataImportPreCheckTaskShrinkRequest request = new CreateEvaluateDataImportPreCheckTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImportParam))
            {
                request.ImportParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImportParam, "ImportParam", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEvaluateDataImportPreCheckTaskResponse>(DoRPCRequest("CreateEvaluateDataImportPreCheckTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateEvaluateDataImportPreCheckTaskResponse> CreateEvaluateDataImportPreCheckTaskWithOptionsAsync(CreateEvaluateDataImportPreCheckTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEvaluateDataImportPreCheckTaskShrinkRequest request = new CreateEvaluateDataImportPreCheckTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImportParam))
            {
                request.ImportParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImportParam, "ImportParam", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEvaluateDataImportPreCheckTaskResponse>(await DoRPCRequestAsync("CreateEvaluateDataImportPreCheckTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateEvaluateDataImportPreCheckTaskResponse CreateEvaluateDataImportPreCheckTask(CreateEvaluateDataImportPreCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEvaluateDataImportPreCheckTaskWithOptions(request, runtime);
        }

        public async Task<CreateEvaluateDataImportPreCheckTaskResponse> CreateEvaluateDataImportPreCheckTaskAsync(CreateEvaluateDataImportPreCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEvaluateDataImportPreCheckTaskWithOptionsAsync(request, runtime);
        }

        public CreateEvaluateDataImportTaskResponse CreateEvaluateDataImportTaskWithOptions(CreateEvaluateDataImportTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEvaluateDataImportTaskShrinkRequest request = new CreateEvaluateDataImportTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImportParam))
            {
                request.ImportParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImportParam, "ImportParam", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEvaluateDataImportTaskResponse>(DoRPCRequest("CreateEvaluateDataImportTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateEvaluateDataImportTaskResponse> CreateEvaluateDataImportTaskWithOptionsAsync(CreateEvaluateDataImportTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEvaluateDataImportTaskShrinkRequest request = new CreateEvaluateDataImportTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImportParam))
            {
                request.ImportParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImportParam, "ImportParam", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEvaluateDataImportTaskResponse>(await DoRPCRequestAsync("CreateEvaluateDataImportTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateEvaluateDataImportTaskResponse CreateEvaluateDataImportTask(CreateEvaluateDataImportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEvaluateDataImportTaskWithOptions(request, runtime);
        }

        public async Task<CreateEvaluateDataImportTaskResponse> CreateEvaluateDataImportTaskAsync(CreateEvaluateDataImportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEvaluateDataImportTaskWithOptionsAsync(request, runtime);
        }

        public CreateEvaluatePreCheckTaskResponse CreateEvaluatePreCheckTaskWithOptions(CreateEvaluatePreCheckTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEvaluatePreCheckTaskResponse>(DoRPCRequest("CreateEvaluatePreCheckTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateEvaluatePreCheckTaskResponse> CreateEvaluatePreCheckTaskWithOptionsAsync(CreateEvaluatePreCheckTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEvaluatePreCheckTaskResponse>(await DoRPCRequestAsync("CreateEvaluatePreCheckTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateEvaluatePreCheckTaskResponse CreateEvaluatePreCheckTask(CreateEvaluatePreCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEvaluatePreCheckTaskWithOptions(request, runtime);
        }

        public async Task<CreateEvaluatePreCheckTaskResponse> CreateEvaluatePreCheckTaskAsync(CreateEvaluatePreCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEvaluatePreCheckTaskWithOptionsAsync(request, runtime);
        }

        public CreateEvaluateTaskResponse CreateEvaluateTaskWithOptions(CreateEvaluateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEvaluateTaskResponse>(DoRPCRequest("CreateEvaluateTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateEvaluateTaskResponse> CreateEvaluateTaskWithOptionsAsync(CreateEvaluateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEvaluateTaskResponse>(await DoRPCRequestAsync("CreateEvaluateTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateEvaluateTaskResponse CreateEvaluateTask(CreateEvaluateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEvaluateTaskWithOptions(request, runtime);
        }

        public async Task<CreateEvaluateTaskResponse> CreateEvaluateTaskAsync(CreateEvaluateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEvaluateTaskWithOptionsAsync(request, runtime);
        }

        public CreateInstanceAccountResponse CreateInstanceAccountWithOptions(CreateInstanceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceAccountResponse>(DoRPCRequest("CreateInstanceAccount", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateInstanceAccountResponse> CreateInstanceAccountWithOptionsAsync(CreateInstanceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceAccountResponse>(await DoRPCRequestAsync("CreateInstanceAccount", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateInstanceAccountResponse CreateInstanceAccount(CreateInstanceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceAccountWithOptions(request, runtime);
        }

        public async Task<CreateInstanceAccountResponse> CreateInstanceAccountAsync(CreateInstanceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceAccountWithOptionsAsync(request, runtime);
        }

        public CreateInstanceInternetAddressResponse CreateInstanceInternetAddressWithOptions(CreateInstanceInternetAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceInternetAddressResponse>(DoRPCRequest("CreateInstanceInternetAddress", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateInstanceInternetAddressResponse> CreateInstanceInternetAddressWithOptionsAsync(CreateInstanceInternetAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceInternetAddressResponse>(await DoRPCRequestAsync("CreateInstanceInternetAddress", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateInstanceInternetAddressResponse CreateInstanceInternetAddress(CreateInstanceInternetAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceInternetAddressWithOptions(request, runtime);
        }

        public async Task<CreateInstanceInternetAddressResponse> CreateInstanceInternetAddressAsync(CreateInstanceInternetAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceInternetAddressWithOptionsAsync(request, runtime);
        }

        public CreateMyCatEvaluateResponse CreateMyCatEvaluateWithOptions(CreateMyCatEvaluateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMyCatEvaluateResponse>(DoRPCRequest("CreateMyCatEvaluate", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMyCatEvaluateResponse> CreateMyCatEvaluateWithOptionsAsync(CreateMyCatEvaluateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMyCatEvaluateResponse>(await DoRPCRequestAsync("CreateMyCatEvaluate", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMyCatEvaluateResponse CreateMyCatEvaluate(CreateMyCatEvaluateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMyCatEvaluateWithOptions(request, runtime);
        }

        public async Task<CreateMyCatEvaluateResponse> CreateMyCatEvaluateAsync(CreateMyCatEvaluateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMyCatEvaluateWithOptionsAsync(request, runtime);
        }

        public CreateOrderForRdsResponse CreateOrderForRdsWithOptions(CreateOrderForRdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateOrderForRdsResponse>(DoRPCRequest("CreateOrderForRds", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateOrderForRdsResponse> CreateOrderForRdsWithOptionsAsync(CreateOrderForRdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateOrderForRdsResponse>(await DoRPCRequestAsync("CreateOrderForRds", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateOrderForRdsResponse CreateOrderForRds(CreateOrderForRdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOrderForRdsWithOptions(request, runtime);
        }

        public async Task<CreateOrderForRdsResponse> CreateOrderForRdsAsync(CreateOrderForRdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOrderForRdsWithOptionsAsync(request, runtime);
        }

        public CreateShardTaskResponse CreateShardTaskWithOptions(CreateShardTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateShardTaskResponse>(DoRPCRequest("CreateShardTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateShardTaskResponse> CreateShardTaskWithOptionsAsync(CreateShardTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateShardTaskResponse>(await DoRPCRequestAsync("CreateShardTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateShardTaskResponse CreateShardTask(CreateShardTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateShardTaskWithOptions(request, runtime);
        }

        public async Task<CreateShardTaskResponse> CreateShardTaskAsync(CreateShardTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateShardTaskWithOptionsAsync(request, runtime);
        }

        public DescribeBackMenuResponse DescribeBackMenuWithOptions(DescribeBackMenuRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackMenuResponse>(DoRPCRequest("DescribeBackMenu", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackMenuResponse> DescribeBackMenuWithOptionsAsync(DescribeBackMenuRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackMenuResponse>(await DoRPCRequestAsync("DescribeBackMenu", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackMenuResponse DescribeBackMenu(DescribeBackMenuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackMenuWithOptions(request, runtime);
        }

        public async Task<DescribeBackMenuResponse> DescribeBackMenuAsync(DescribeBackMenuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackMenuWithOptionsAsync(request, runtime);
        }

        public DescribeBackupDbsResponse DescribeBackupDbsWithOptions(DescribeBackupDbsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupDbsResponse>(DoRPCRequest("DescribeBackupDbs", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupDbsResponse> DescribeBackupDbsWithOptionsAsync(DescribeBackupDbsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupDbsResponse>(await DoRPCRequestAsync("DescribeBackupDbs", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackupDbsResponse DescribeBackupDbs(DescribeBackupDbsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupDbsWithOptions(request, runtime);
        }

        public async Task<DescribeBackupDbsResponse> DescribeBackupDbsAsync(DescribeBackupDbsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupDbsWithOptionsAsync(request, runtime);
        }

        public DescribeBackupLocalResponse DescribeBackupLocalWithOptions(DescribeBackupLocalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupLocalResponse>(DoRPCRequest("DescribeBackupLocal", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupLocalResponse> DescribeBackupLocalWithOptionsAsync(DescribeBackupLocalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupLocalResponse>(await DoRPCRequestAsync("DescribeBackupLocal", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackupLocalResponse DescribeBackupLocal(DescribeBackupLocalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupLocalWithOptions(request, runtime);
        }

        public async Task<DescribeBackupLocalResponse> DescribeBackupLocalAsync(DescribeBackupLocalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupLocalWithOptionsAsync(request, runtime);
        }

        public DescribeBackupPolicyResponse DescribeBackupPolicyWithOptions(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPolicyResponse>(DoRPCRequest("DescribeBackupPolicy", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupPolicyResponse> DescribeBackupPolicyWithOptionsAsync(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPolicyResponse>(await DoRPCRequestAsync("DescribeBackupPolicy", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeBackupSetsResponse DescribeBackupSetsWithOptions(DescribeBackupSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupSetsResponse>(DoRPCRequest("DescribeBackupSets", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupSetsResponse> DescribeBackupSetsWithOptionsAsync(DescribeBackupSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupSetsResponse>(await DoRPCRequestAsync("DescribeBackupSets", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackupSetsResponse DescribeBackupSets(DescribeBackupSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupSetsWithOptions(request, runtime);
        }

        public async Task<DescribeBackupSetsResponse> DescribeBackupSetsAsync(DescribeBackupSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupSetsWithOptionsAsync(request, runtime);
        }

        public DescribeBackupTimesResponse DescribeBackupTimesWithOptions(DescribeBackupTimesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupTimesResponse>(DoRPCRequest("DescribeBackupTimes", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupTimesResponse> DescribeBackupTimesWithOptionsAsync(DescribeBackupTimesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupTimesResponse>(await DoRPCRequestAsync("DescribeBackupTimes", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackupTimesResponse DescribeBackupTimes(DescribeBackupTimesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupTimesWithOptions(request, runtime);
        }

        public async Task<DescribeBackupTimesResponse> DescribeBackupTimesAsync(DescribeBackupTimesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupTimesWithOptionsAsync(request, runtime);
        }

        public DescribeBatchEvaluateTaskReportResponse DescribeBatchEvaluateTaskReportWithOptions(DescribeBatchEvaluateTaskReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBatchEvaluateTaskReportResponse>(DoRPCRequest("DescribeBatchEvaluateTaskReport", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBatchEvaluateTaskReportResponse> DescribeBatchEvaluateTaskReportWithOptionsAsync(DescribeBatchEvaluateTaskReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBatchEvaluateTaskReportResponse>(await DoRPCRequestAsync("DescribeBatchEvaluateTaskReport", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBatchEvaluateTaskReportResponse DescribeBatchEvaluateTaskReport(DescribeBatchEvaluateTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBatchEvaluateTaskReportWithOptions(request, runtime);
        }

        public async Task<DescribeBatchEvaluateTaskReportResponse> DescribeBatchEvaluateTaskReportAsync(DescribeBatchEvaluateTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBatchEvaluateTaskReportWithOptionsAsync(request, runtime);
        }

        public DescribeBroadcastTablesResponse DescribeBroadcastTablesWithOptions(DescribeBroadcastTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBroadcastTablesResponse>(DoRPCRequest("DescribeBroadcastTables", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBroadcastTablesResponse> DescribeBroadcastTablesWithOptionsAsync(DescribeBroadcastTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBroadcastTablesResponse>(await DoRPCRequestAsync("DescribeBroadcastTables", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBroadcastTablesResponse DescribeBroadcastTables(DescribeBroadcastTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBroadcastTablesWithOptions(request, runtime);
        }

        public async Task<DescribeBroadcastTablesResponse> DescribeBroadcastTablesAsync(DescribeBroadcastTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBroadcastTablesWithOptionsAsync(request, runtime);
        }

        public DescribeCanExpandInstanceDetailListResponse DescribeCanExpandInstanceDetailListWithOptions(DescribeCanExpandInstanceDetailListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCanExpandInstanceDetailListResponse>(DoRPCRequest("DescribeCanExpandInstanceDetailList", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCanExpandInstanceDetailListResponse> DescribeCanExpandInstanceDetailListWithOptionsAsync(DescribeCanExpandInstanceDetailListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCanExpandInstanceDetailListResponse>(await DoRPCRequestAsync("DescribeCanExpandInstanceDetailList", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCanExpandInstanceDetailListResponse DescribeCanExpandInstanceDetailList(DescribeCanExpandInstanceDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCanExpandInstanceDetailListWithOptions(request, runtime);
        }

        public async Task<DescribeCanExpandInstanceDetailListResponse> DescribeCanExpandInstanceDetailListAsync(DescribeCanExpandInstanceDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCanExpandInstanceDetailListWithOptionsAsync(request, runtime);
        }

        public DescribeCustomDataExportSrcDstTablesResponse DescribeCustomDataExportSrcDstTablesWithOptions(DescribeCustomDataExportSrcDstTablesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCustomDataExportSrcDstTablesShrinkRequest request = new DescribeCustomDataExportSrcDstTablesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExportParam))
            {
                request.ExportParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExportParam, "ExportParam", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomDataExportSrcDstTablesResponse>(DoRPCRequest("DescribeCustomDataExportSrcDstTables", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCustomDataExportSrcDstTablesResponse> DescribeCustomDataExportSrcDstTablesWithOptionsAsync(DescribeCustomDataExportSrcDstTablesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCustomDataExportSrcDstTablesShrinkRequest request = new DescribeCustomDataExportSrcDstTablesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExportParam))
            {
                request.ExportParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExportParam, "ExportParam", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomDataExportSrcDstTablesResponse>(await DoRPCRequestAsync("DescribeCustomDataExportSrcDstTables", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCustomDataExportSrcDstTablesResponse DescribeCustomDataExportSrcDstTables(DescribeCustomDataExportSrcDstTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomDataExportSrcDstTablesWithOptions(request, runtime);
        }

        public async Task<DescribeCustomDataExportSrcDstTablesResponse> DescribeCustomDataExportSrcDstTablesAsync(DescribeCustomDataExportSrcDstTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomDataExportSrcDstTablesWithOptionsAsync(request, runtime);
        }

        public DescribeCustomDataImportSrcDstTablesResponse DescribeCustomDataImportSrcDstTablesWithOptions(DescribeCustomDataImportSrcDstTablesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCustomDataImportSrcDstTablesShrinkRequest request = new DescribeCustomDataImportSrcDstTablesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImportParam))
            {
                request.ImportParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImportParam, "ImportParam", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomDataImportSrcDstTablesResponse>(DoRPCRequest("DescribeCustomDataImportSrcDstTables", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCustomDataImportSrcDstTablesResponse> DescribeCustomDataImportSrcDstTablesWithOptionsAsync(DescribeCustomDataImportSrcDstTablesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCustomDataImportSrcDstTablesShrinkRequest request = new DescribeCustomDataImportSrcDstTablesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImportParam))
            {
                request.ImportParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImportParam, "ImportParam", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomDataImportSrcDstTablesResponse>(await DoRPCRequestAsync("DescribeCustomDataImportSrcDstTables", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCustomDataImportSrcDstTablesResponse DescribeCustomDataImportSrcDstTables(DescribeCustomDataImportSrcDstTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomDataImportSrcDstTablesWithOptions(request, runtime);
        }

        public async Task<DescribeCustomDataImportSrcDstTablesResponse> DescribeCustomDataImportSrcDstTablesAsync(DescribeCustomDataImportSrcDstTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomDataImportSrcDstTablesWithOptionsAsync(request, runtime);
        }

        public DescribeDataExportPreCheckResultResponse DescribeDataExportPreCheckResultWithOptions(DescribeDataExportPreCheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataExportPreCheckResultResponse>(DoRPCRequest("DescribeDataExportPreCheckResult", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDataExportPreCheckResultResponse> DescribeDataExportPreCheckResultWithOptionsAsync(DescribeDataExportPreCheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataExportPreCheckResultResponse>(await DoRPCRequestAsync("DescribeDataExportPreCheckResult", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDataExportPreCheckResultResponse DescribeDataExportPreCheckResult(DescribeDataExportPreCheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataExportPreCheckResultWithOptions(request, runtime);
        }

        public async Task<DescribeDataExportPreCheckResultResponse> DescribeDataExportPreCheckResultAsync(DescribeDataExportPreCheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataExportPreCheckResultWithOptionsAsync(request, runtime);
        }

        public DescribeDataExportTaskReportResponse DescribeDataExportTaskReportWithOptions(DescribeDataExportTaskReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataExportTaskReportResponse>(DoRPCRequest("DescribeDataExportTaskReport", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDataExportTaskReportResponse> DescribeDataExportTaskReportWithOptionsAsync(DescribeDataExportTaskReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataExportTaskReportResponse>(await DoRPCRequestAsync("DescribeDataExportTaskReport", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDataExportTaskReportResponse DescribeDataExportTaskReport(DescribeDataExportTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataExportTaskReportWithOptions(request, runtime);
        }

        public async Task<DescribeDataExportTaskReportResponse> DescribeDataExportTaskReportAsync(DescribeDataExportTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataExportTaskReportWithOptionsAsync(request, runtime);
        }

        public DescribeDataExportTasksResponse DescribeDataExportTasksWithOptions(DescribeDataExportTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataExportTasksResponse>(DoRPCRequest("DescribeDataExportTasks", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDataExportTasksResponse> DescribeDataExportTasksWithOptionsAsync(DescribeDataExportTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataExportTasksResponse>(await DoRPCRequestAsync("DescribeDataExportTasks", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDataExportTasksResponse DescribeDataExportTasks(DescribeDataExportTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataExportTasksWithOptions(request, runtime);
        }

        public async Task<DescribeDataExportTasksResponse> DescribeDataExportTasksAsync(DescribeDataExportTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataExportTasksWithOptionsAsync(request, runtime);
        }

        public DescribeDataImportPreCheckResultResponse DescribeDataImportPreCheckResultWithOptions(DescribeDataImportPreCheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataImportPreCheckResultResponse>(DoRPCRequest("DescribeDataImportPreCheckResult", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDataImportPreCheckResultResponse> DescribeDataImportPreCheckResultWithOptionsAsync(DescribeDataImportPreCheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataImportPreCheckResultResponse>(await DoRPCRequestAsync("DescribeDataImportPreCheckResult", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDataImportPreCheckResultResponse DescribeDataImportPreCheckResult(DescribeDataImportPreCheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataImportPreCheckResultWithOptions(request, runtime);
        }

        public async Task<DescribeDataImportPreCheckResultResponse> DescribeDataImportPreCheckResultAsync(DescribeDataImportPreCheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataImportPreCheckResultWithOptionsAsync(request, runtime);
        }

        public DescribeDataImportTaskReportResponse DescribeDataImportTaskReportWithOptions(DescribeDataImportTaskReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataImportTaskReportResponse>(DoRPCRequest("DescribeDataImportTaskReport", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDataImportTaskReportResponse> DescribeDataImportTaskReportWithOptionsAsync(DescribeDataImportTaskReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataImportTaskReportResponse>(await DoRPCRequestAsync("DescribeDataImportTaskReport", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDataImportTaskReportResponse DescribeDataImportTaskReport(DescribeDataImportTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataImportTaskReportWithOptions(request, runtime);
        }

        public async Task<DescribeDataImportTaskReportResponse> DescribeDataImportTaskReportAsync(DescribeDataImportTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataImportTaskReportWithOptionsAsync(request, runtime);
        }

        public DescribeDataImportTasksResponse DescribeDataImportTasksWithOptions(DescribeDataImportTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataImportTasksResponse>(DoRPCRequest("DescribeDataImportTasks", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDataImportTasksResponse> DescribeDataImportTasksWithOptionsAsync(DescribeDataImportTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataImportTasksResponse>(await DoRPCRequestAsync("DescribeDataImportTasks", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDataImportTasksResponse DescribeDataImportTasks(DescribeDataImportTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataImportTasksWithOptions(request, runtime);
        }

        public async Task<DescribeDataImportTasksResponse> DescribeDataImportTasksAsync(DescribeDataImportTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataImportTasksWithOptionsAsync(request, runtime);
        }

        public DescribeDbInstanceDbsResponse DescribeDbInstanceDbsWithOptions(DescribeDbInstanceDbsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDbInstanceDbsResponse>(DoRPCRequest("DescribeDbInstanceDbs", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDbInstanceDbsResponse> DescribeDbInstanceDbsWithOptionsAsync(DescribeDbInstanceDbsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDbInstanceDbsResponse>(await DoRPCRequestAsync("DescribeDbInstanceDbs", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDbInstanceDbsResponse DescribeDbInstanceDbs(DescribeDbInstanceDbsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDbInstanceDbsWithOptions(request, runtime);
        }

        public async Task<DescribeDbInstanceDbsResponse> DescribeDbInstanceDbsAsync(DescribeDbInstanceDbsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDbInstanceDbsWithOptionsAsync(request, runtime);
        }

        public DescribeDbInstancesResponse DescribeDbInstancesWithOptions(DescribeDbInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDbInstancesResponse>(DoRPCRequest("DescribeDbInstances", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDbInstancesResponse> DescribeDbInstancesWithOptionsAsync(DescribeDbInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDbInstancesResponse>(await DoRPCRequestAsync("DescribeDbInstances", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDbInstancesResponse DescribeDbInstances(DescribeDbInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDbInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeDbInstancesResponse> DescribeDbInstancesAsync(DescribeDbInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDbInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsDBResponse DescribeDrdsDBWithOptions(DescribeDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsDBResponse>(DoRPCRequest("DescribeDrdsDB", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDrdsDBResponse> DescribeDrdsDBWithOptionsAsync(DescribeDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsDBResponse>(await DoRPCRequestAsync("DescribeDrdsDB", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDrdsDBResponse DescribeDrdsDB(DescribeDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsDBWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsDBResponse> DescribeDrdsDBAsync(DescribeDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsDBWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsDBClusterResponse DescribeDrdsDBClusterWithOptions(DescribeDrdsDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsDBClusterResponse>(DoRPCRequest("DescribeDrdsDBCluster", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDrdsDBClusterResponse> DescribeDrdsDBClusterWithOptionsAsync(DescribeDrdsDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsDBClusterResponse>(await DoRPCRequestAsync("DescribeDrdsDBCluster", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDrdsDBClusterResponse DescribeDrdsDBCluster(DescribeDrdsDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsDBClusterWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsDBClusterResponse> DescribeDrdsDBClusterAsync(DescribeDrdsDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsDBClusterWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsDBIpWhiteListResponse DescribeDrdsDBIpWhiteListWithOptions(DescribeDrdsDBIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsDBIpWhiteListResponse>(DoRPCRequest("DescribeDrdsDBIpWhiteList", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDrdsDBIpWhiteListResponse> DescribeDrdsDBIpWhiteListWithOptionsAsync(DescribeDrdsDBIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsDBIpWhiteListResponse>(await DoRPCRequestAsync("DescribeDrdsDBIpWhiteList", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDrdsDBIpWhiteListResponse DescribeDrdsDBIpWhiteList(DescribeDrdsDBIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsDBIpWhiteListWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsDBIpWhiteListResponse> DescribeDrdsDBIpWhiteListAsync(DescribeDrdsDBIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsDBIpWhiteListWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsDBsResponse DescribeDrdsDBsWithOptions(DescribeDrdsDBsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsDBsResponse>(DoRPCRequest("DescribeDrdsDBs", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDrdsDBsResponse> DescribeDrdsDBsWithOptionsAsync(DescribeDrdsDBsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsDBsResponse>(await DoRPCRequestAsync("DescribeDrdsDBs", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDrdsDBsResponse DescribeDrdsDBs(DescribeDrdsDBsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsDBsWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsDBsResponse> DescribeDrdsDBsAsync(DescribeDrdsDBsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsDBsWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsDbInstanceResponse DescribeDrdsDbInstanceWithOptions(DescribeDrdsDbInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsDbInstanceResponse>(DoRPCRequest("DescribeDrdsDbInstance", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDrdsDbInstanceResponse> DescribeDrdsDbInstanceWithOptionsAsync(DescribeDrdsDbInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsDbInstanceResponse>(await DoRPCRequestAsync("DescribeDrdsDbInstance", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDrdsDbInstanceResponse DescribeDrdsDbInstance(DescribeDrdsDbInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsDbInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsDbInstanceResponse> DescribeDrdsDbInstanceAsync(DescribeDrdsDbInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsDbInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsDbInstancesResponse DescribeDrdsDbInstancesWithOptions(DescribeDrdsDbInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsDbInstancesResponse>(DoRPCRequest("DescribeDrdsDbInstances", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDrdsDbInstancesResponse> DescribeDrdsDbInstancesWithOptionsAsync(DescribeDrdsDbInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsDbInstancesResponse>(await DoRPCRequestAsync("DescribeDrdsDbInstances", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDrdsDbInstancesResponse DescribeDrdsDbInstances(DescribeDrdsDbInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsDbInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsDbInstancesResponse> DescribeDrdsDbInstancesAsync(DescribeDrdsDbInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsDbInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsDbRdsNameListResponse DescribeDrdsDbRdsNameListWithOptions(DescribeDrdsDbRdsNameListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsDbRdsNameListResponse>(DoRPCRequest("DescribeDrdsDbRdsNameList", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDrdsDbRdsNameListResponse> DescribeDrdsDbRdsNameListWithOptionsAsync(DescribeDrdsDbRdsNameListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsDbRdsNameListResponse>(await DoRPCRequestAsync("DescribeDrdsDbRdsNameList", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDrdsDbRdsNameListResponse DescribeDrdsDbRdsNameList(DescribeDrdsDbRdsNameListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsDbRdsNameListWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsDbRdsNameListResponse> DescribeDrdsDbRdsNameListAsync(DescribeDrdsDbRdsNameListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsDbRdsNameListWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsDbTasksResponse DescribeDrdsDbTasksWithOptions(DescribeDrdsDbTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsDbTasksResponse>(DoRPCRequest("DescribeDrdsDbTasks", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDrdsDbTasksResponse> DescribeDrdsDbTasksWithOptionsAsync(DescribeDrdsDbTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsDbTasksResponse>(await DoRPCRequestAsync("DescribeDrdsDbTasks", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDrdsDbTasksResponse DescribeDrdsDbTasks(DescribeDrdsDbTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsDbTasksWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsDbTasksResponse> DescribeDrdsDbTasksAsync(DescribeDrdsDbTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsDbTasksWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsInstanceResponse DescribeDrdsInstanceWithOptions(DescribeDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsInstanceResponse>(DoRPCRequest("DescribeDrdsInstance", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDrdsInstanceResponse> DescribeDrdsInstanceWithOptionsAsync(DescribeDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsInstanceResponse>(await DoRPCRequestAsync("DescribeDrdsInstance", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDrdsInstanceResponse DescribeDrdsInstance(DescribeDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsInstanceResponse> DescribeDrdsInstanceAsync(DescribeDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsInstanceDbMonitorResponse DescribeDrdsInstanceDbMonitorWithOptions(DescribeDrdsInstanceDbMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsInstanceDbMonitorResponse>(DoRPCRequest("DescribeDrdsInstanceDbMonitor", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDrdsInstanceDbMonitorResponse> DescribeDrdsInstanceDbMonitorWithOptionsAsync(DescribeDrdsInstanceDbMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsInstanceDbMonitorResponse>(await DoRPCRequestAsync("DescribeDrdsInstanceDbMonitor", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDrdsInstanceDbMonitorResponse DescribeDrdsInstanceDbMonitor(DescribeDrdsInstanceDbMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsInstanceDbMonitorWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsInstanceDbMonitorResponse> DescribeDrdsInstanceDbMonitorAsync(DescribeDrdsInstanceDbMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsInstanceDbMonitorWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsInstanceLevelTasksResponse DescribeDrdsInstanceLevelTasksWithOptions(DescribeDrdsInstanceLevelTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsInstanceLevelTasksResponse>(DoRPCRequest("DescribeDrdsInstanceLevelTasks", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDrdsInstanceLevelTasksResponse> DescribeDrdsInstanceLevelTasksWithOptionsAsync(DescribeDrdsInstanceLevelTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsInstanceLevelTasksResponse>(await DoRPCRequestAsync("DescribeDrdsInstanceLevelTasks", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDrdsInstanceLevelTasksResponse DescribeDrdsInstanceLevelTasks(DescribeDrdsInstanceLevelTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsInstanceLevelTasksWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsInstanceLevelTasksResponse> DescribeDrdsInstanceLevelTasksAsync(DescribeDrdsInstanceLevelTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsInstanceLevelTasksWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsInstanceMonitorResponse DescribeDrdsInstanceMonitorWithOptions(DescribeDrdsInstanceMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsInstanceMonitorResponse>(DoRPCRequest("DescribeDrdsInstanceMonitor", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDrdsInstanceMonitorResponse> DescribeDrdsInstanceMonitorWithOptionsAsync(DescribeDrdsInstanceMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsInstanceMonitorResponse>(await DoRPCRequestAsync("DescribeDrdsInstanceMonitor", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDrdsInstanceMonitorResponse DescribeDrdsInstanceMonitor(DescribeDrdsInstanceMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsInstanceMonitorWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsInstanceMonitorResponse> DescribeDrdsInstanceMonitorAsync(DescribeDrdsInstanceMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsInstanceMonitorWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsInstanceVersionResponse DescribeDrdsInstanceVersionWithOptions(DescribeDrdsInstanceVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsInstanceVersionResponse>(DoRPCRequest("DescribeDrdsInstanceVersion", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDrdsInstanceVersionResponse> DescribeDrdsInstanceVersionWithOptionsAsync(DescribeDrdsInstanceVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsInstanceVersionResponse>(await DoRPCRequestAsync("DescribeDrdsInstanceVersion", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDrdsInstanceVersionResponse DescribeDrdsInstanceVersion(DescribeDrdsInstanceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsInstanceVersionWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsInstanceVersionResponse> DescribeDrdsInstanceVersionAsync(DescribeDrdsInstanceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsInstanceVersionWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsInstancesResponse DescribeDrdsInstancesWithOptions(DescribeDrdsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsInstancesResponse>(DoRPCRequest("DescribeDrdsInstances", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDrdsInstancesResponse> DescribeDrdsInstancesWithOptionsAsync(DescribeDrdsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsInstancesResponse>(await DoRPCRequestAsync("DescribeDrdsInstances", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDrdsInstancesResponse DescribeDrdsInstances(DescribeDrdsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsInstancesResponse> DescribeDrdsInstancesAsync(DescribeDrdsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsParamsResponse DescribeDrdsParamsWithOptions(DescribeDrdsParamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsParamsResponse>(DoRPCRequest("DescribeDrdsParams", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDrdsParamsResponse> DescribeDrdsParamsWithOptionsAsync(DescribeDrdsParamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsParamsResponse>(await DoRPCRequestAsync("DescribeDrdsParams", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDrdsParamsResponse DescribeDrdsParams(DescribeDrdsParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsParamsWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsParamsResponse> DescribeDrdsParamsAsync(DescribeDrdsParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsParamsWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsRdsInstancesResponse DescribeDrdsRdsInstancesWithOptions(DescribeDrdsRdsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsRdsInstancesResponse>(DoRPCRequest("DescribeDrdsRdsInstances", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDrdsRdsInstancesResponse> DescribeDrdsRdsInstancesWithOptionsAsync(DescribeDrdsRdsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsRdsInstancesResponse>(await DoRPCRequestAsync("DescribeDrdsRdsInstances", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDrdsRdsInstancesResponse DescribeDrdsRdsInstances(DescribeDrdsRdsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsRdsInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsRdsInstancesResponse> DescribeDrdsRdsInstancesAsync(DescribeDrdsRdsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsRdsInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsShardingDbsResponse DescribeDrdsShardingDbsWithOptions(DescribeDrdsShardingDbsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsShardingDbsResponse>(DoRPCRequest("DescribeDrdsShardingDbs", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDrdsShardingDbsResponse> DescribeDrdsShardingDbsWithOptionsAsync(DescribeDrdsShardingDbsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsShardingDbsResponse>(await DoRPCRequestAsync("DescribeDrdsShardingDbs", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDrdsShardingDbsResponse DescribeDrdsShardingDbs(DescribeDrdsShardingDbsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsShardingDbsWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsShardingDbsResponse> DescribeDrdsShardingDbsAsync(DescribeDrdsShardingDbsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsShardingDbsWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsSlowSqlsResponse DescribeDrdsSlowSqlsWithOptions(DescribeDrdsSlowSqlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsSlowSqlsResponse>(DoRPCRequest("DescribeDrdsSlowSqls", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDrdsSlowSqlsResponse> DescribeDrdsSlowSqlsWithOptionsAsync(DescribeDrdsSlowSqlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsSlowSqlsResponse>(await DoRPCRequestAsync("DescribeDrdsSlowSqls", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDrdsSlowSqlsResponse DescribeDrdsSlowSqls(DescribeDrdsSlowSqlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsSlowSqlsWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsSlowSqlsResponse> DescribeDrdsSlowSqlsAsync(DescribeDrdsSlowSqlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsSlowSqlsWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsSqlAuditStatusResponse DescribeDrdsSqlAuditStatusWithOptions(DescribeDrdsSqlAuditStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsSqlAuditStatusResponse>(DoRPCRequest("DescribeDrdsSqlAuditStatus", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDrdsSqlAuditStatusResponse> DescribeDrdsSqlAuditStatusWithOptionsAsync(DescribeDrdsSqlAuditStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsSqlAuditStatusResponse>(await DoRPCRequestAsync("DescribeDrdsSqlAuditStatus", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDrdsSqlAuditStatusResponse DescribeDrdsSqlAuditStatus(DescribeDrdsSqlAuditStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsSqlAuditStatusWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsSqlAuditStatusResponse> DescribeDrdsSqlAuditStatusAsync(DescribeDrdsSqlAuditStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsSqlAuditStatusWithOptionsAsync(request, runtime);
        }

        public DescribeDrdsTasksResponse DescribeDrdsTasksWithOptions(DescribeDrdsTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsTasksResponse>(DoRPCRequest("DescribeDrdsTasks", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDrdsTasksResponse> DescribeDrdsTasksWithOptionsAsync(DescribeDrdsTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDrdsTasksResponse>(await DoRPCRequestAsync("DescribeDrdsTasks", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDrdsTasksResponse DescribeDrdsTasks(DescribeDrdsTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDrdsTasksWithOptions(request, runtime);
        }

        public async Task<DescribeDrdsTasksResponse> DescribeDrdsTasksAsync(DescribeDrdsTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDrdsTasksWithOptionsAsync(request, runtime);
        }

        public DescribeEvaluateDataImportDbTopologysResponse DescribeEvaluateDataImportDbTopologysWithOptions(DescribeEvaluateDataImportDbTopologysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeEvaluateDataImportDbTopologysShrinkRequest request = new DescribeEvaluateDataImportDbTopologysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImportParam))
            {
                request.ImportParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImportParam, "ImportParam", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEvaluateDataImportDbTopologysResponse>(DoRPCRequest("DescribeEvaluateDataImportDbTopologys", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEvaluateDataImportDbTopologysResponse> DescribeEvaluateDataImportDbTopologysWithOptionsAsync(DescribeEvaluateDataImportDbTopologysRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeEvaluateDataImportDbTopologysShrinkRequest request = new DescribeEvaluateDataImportDbTopologysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImportParam))
            {
                request.ImportParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImportParam, "ImportParam", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEvaluateDataImportDbTopologysResponse>(await DoRPCRequestAsync("DescribeEvaluateDataImportDbTopologys", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEvaluateDataImportDbTopologysResponse DescribeEvaluateDataImportDbTopologys(DescribeEvaluateDataImportDbTopologysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEvaluateDataImportDbTopologysWithOptions(request, runtime);
        }

        public async Task<DescribeEvaluateDataImportDbTopologysResponse> DescribeEvaluateDataImportDbTopologysAsync(DescribeEvaluateDataImportDbTopologysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEvaluateDataImportDbTopologysWithOptionsAsync(request, runtime);
        }

        public DescribeEvaluatePreCheckResultResponse DescribeEvaluatePreCheckResultWithOptions(DescribeEvaluatePreCheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEvaluatePreCheckResultResponse>(DoRPCRequest("DescribeEvaluatePreCheckResult", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEvaluatePreCheckResultResponse> DescribeEvaluatePreCheckResultWithOptionsAsync(DescribeEvaluatePreCheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEvaluatePreCheckResultResponse>(await DoRPCRequestAsync("DescribeEvaluatePreCheckResult", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEvaluatePreCheckResultResponse DescribeEvaluatePreCheckResult(DescribeEvaluatePreCheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEvaluatePreCheckResultWithOptions(request, runtime);
        }

        public async Task<DescribeEvaluatePreCheckResultResponse> DescribeEvaluatePreCheckResultAsync(DescribeEvaluatePreCheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEvaluatePreCheckResultWithOptionsAsync(request, runtime);
        }

        public DescribeEvaluateTaskReportResponse DescribeEvaluateTaskReportWithOptions(DescribeEvaluateTaskReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEvaluateTaskReportResponse>(DoRPCRequest("DescribeEvaluateTaskReport", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEvaluateTaskReportResponse> DescribeEvaluateTaskReportWithOptionsAsync(DescribeEvaluateTaskReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEvaluateTaskReportResponse>(await DoRPCRequestAsync("DescribeEvaluateTaskReport", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEvaluateTaskReportResponse DescribeEvaluateTaskReport(DescribeEvaluateTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEvaluateTaskReportWithOptions(request, runtime);
        }

        public async Task<DescribeEvaluateTaskReportResponse> DescribeEvaluateTaskReportAsync(DescribeEvaluateTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEvaluateTaskReportWithOptionsAsync(request, runtime);
        }

        public DescribeEvaluateTasksResponse DescribeEvaluateTasksWithOptions(DescribeEvaluateTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEvaluateTasksResponse>(DoRPCRequest("DescribeEvaluateTasks", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEvaluateTasksResponse> DescribeEvaluateTasksWithOptionsAsync(DescribeEvaluateTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEvaluateTasksResponse>(await DoRPCRequestAsync("DescribeEvaluateTasks", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEvaluateTasksResponse DescribeEvaluateTasks(DescribeEvaluateTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEvaluateTasksWithOptions(request, runtime);
        }

        public async Task<DescribeEvaluateTasksResponse> DescribeEvaluateTasksAsync(DescribeEvaluateTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEvaluateTasksWithOptionsAsync(request, runtime);
        }

        public DescribeExpandLogicTableInfoListResponse DescribeExpandLogicTableInfoListWithOptions(DescribeExpandLogicTableInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExpandLogicTableInfoListResponse>(DoRPCRequest("DescribeExpandLogicTableInfoList", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeExpandLogicTableInfoListResponse> DescribeExpandLogicTableInfoListWithOptionsAsync(DescribeExpandLogicTableInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExpandLogicTableInfoListResponse>(await DoRPCRequestAsync("DescribeExpandLogicTableInfoList", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeExpandLogicTableInfoListResponse DescribeExpandLogicTableInfoList(DescribeExpandLogicTableInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExpandLogicTableInfoListWithOptions(request, runtime);
        }

        public async Task<DescribeExpandLogicTableInfoListResponse> DescribeExpandLogicTableInfoListAsync(DescribeExpandLogicTableInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExpandLogicTableInfoListWithOptionsAsync(request, runtime);
        }

        public DescribeHiStoreInstanceInfoResponse DescribeHiStoreInstanceInfoWithOptions(DescribeHiStoreInstanceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHiStoreInstanceInfoResponse>(DoRPCRequest("DescribeHiStoreInstanceInfo", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHiStoreInstanceInfoResponse> DescribeHiStoreInstanceInfoWithOptionsAsync(DescribeHiStoreInstanceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHiStoreInstanceInfoResponse>(await DoRPCRequestAsync("DescribeHiStoreInstanceInfo", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHiStoreInstanceInfoResponse DescribeHiStoreInstanceInfo(DescribeHiStoreInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHiStoreInstanceInfoWithOptions(request, runtime);
        }

        public async Task<DescribeHiStoreInstanceInfoResponse> DescribeHiStoreInstanceInfoAsync(DescribeHiStoreInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHiStoreInstanceInfoWithOptionsAsync(request, runtime);
        }

        public DescribeHotDbListResponse DescribeHotDbListWithOptions(DescribeHotDbListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHotDbListResponse>(DoRPCRequest("DescribeHotDbList", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHotDbListResponse> DescribeHotDbListWithOptionsAsync(DescribeHotDbListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHotDbListResponse>(await DoRPCRequestAsync("DescribeHotDbList", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHotDbListResponse DescribeHotDbList(DescribeHotDbListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHotDbListWithOptions(request, runtime);
        }

        public async Task<DescribeHotDbListResponse> DescribeHotDbListAsync(DescribeHotDbListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHotDbListWithOptionsAsync(request, runtime);
        }

        public DescribeInstDbLogInfoResponse DescribeInstDbLogInfoWithOptions(DescribeInstDbLogInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstDbLogInfoResponse>(DoRPCRequest("DescribeInstDbLogInfo", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstDbLogInfoResponse> DescribeInstDbLogInfoWithOptionsAsync(DescribeInstDbLogInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstDbLogInfoResponse>(await DoRPCRequestAsync("DescribeInstDbLogInfo", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstDbLogInfoResponse DescribeInstDbLogInfo(DescribeInstDbLogInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstDbLogInfoWithOptions(request, runtime);
        }

        public async Task<DescribeInstDbLogInfoResponse> DescribeInstDbLogInfoAsync(DescribeInstDbLogInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstDbLogInfoWithOptionsAsync(request, runtime);
        }

        public DescribeInstDbSlsInfoResponse DescribeInstDbSlsInfoWithOptions(DescribeInstDbSlsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstDbSlsInfoResponse>(DoRPCRequest("DescribeInstDbSlsInfo", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstDbSlsInfoResponse> DescribeInstDbSlsInfoWithOptionsAsync(DescribeInstDbSlsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstDbSlsInfoResponse>(await DoRPCRequestAsync("DescribeInstDbSlsInfo", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstDbSlsInfoResponse DescribeInstDbSlsInfo(DescribeInstDbSlsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstDbSlsInfoWithOptions(request, runtime);
        }

        public async Task<DescribeInstDbSlsInfoResponse> DescribeInstDbSlsInfoAsync(DescribeInstDbSlsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstDbSlsInfoWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceAccountsResponse DescribeInstanceAccountsWithOptions(DescribeInstanceAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAccountsResponse>(DoRPCRequest("DescribeInstanceAccounts", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceAccountsResponse> DescribeInstanceAccountsWithOptionsAsync(DescribeInstanceAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAccountsResponse>(await DoRPCRequestAsync("DescribeInstanceAccounts", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceAccountsResponse DescribeInstanceAccounts(DescribeInstanceAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAccountsWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceAccountsResponse> DescribeInstanceAccountsAsync(DescribeInstanceAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAccountsWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceMenuSwitchResponse DescribeInstanceMenuSwitchWithOptions(DescribeInstanceMenuSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceMenuSwitchResponse>(DoRPCRequest("DescribeInstanceMenuSwitch", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceMenuSwitchResponse> DescribeInstanceMenuSwitchWithOptionsAsync(DescribeInstanceMenuSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceMenuSwitchResponse>(await DoRPCRequestAsync("DescribeInstanceMenuSwitch", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceMenuSwitchResponse DescribeInstanceMenuSwitch(DescribeInstanceMenuSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceMenuSwitchWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceMenuSwitchResponse> DescribeInstanceMenuSwitchAsync(DescribeInstanceMenuSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceMenuSwitchWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceSwitchAzoneResponse DescribeInstanceSwitchAzoneWithOptions(DescribeInstanceSwitchAzoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceSwitchAzoneResponse>(DoRPCRequest("DescribeInstanceSwitchAzone", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceSwitchAzoneResponse> DescribeInstanceSwitchAzoneWithOptionsAsync(DescribeInstanceSwitchAzoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceSwitchAzoneResponse>(await DoRPCRequestAsync("DescribeInstanceSwitchAzone", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceSwitchAzoneResponse DescribeInstanceSwitchAzone(DescribeInstanceSwitchAzoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceSwitchAzoneWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceSwitchAzoneResponse> DescribeInstanceSwitchAzoneAsync(DescribeInstanceSwitchAzoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceSwitchAzoneWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceSwitchNetworkResponse DescribeInstanceSwitchNetworkWithOptions(DescribeInstanceSwitchNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceSwitchNetworkResponse>(DoRPCRequest("DescribeInstanceSwitchNetwork", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceSwitchNetworkResponse> DescribeInstanceSwitchNetworkWithOptionsAsync(DescribeInstanceSwitchNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceSwitchNetworkResponse>(await DoRPCRequestAsync("DescribeInstanceSwitchNetwork", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceSwitchNetworkResponse DescribeInstanceSwitchNetwork(DescribeInstanceSwitchNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceSwitchNetworkWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceSwitchNetworkResponse> DescribeInstanceSwitchNetworkAsync(DescribeInstanceSwitchNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceSwitchNetworkWithOptionsAsync(request, runtime);
        }

        public DescribePreCheckResultResponse DescribePreCheckResultWithOptions(DescribePreCheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePreCheckResultResponse>(DoRPCRequest("DescribePreCheckResult", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePreCheckResultResponse> DescribePreCheckResultWithOptionsAsync(DescribePreCheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePreCheckResultResponse>(await DoRPCRequestAsync("DescribePreCheckResult", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePreCheckResultResponse DescribePreCheckResult(DescribePreCheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePreCheckResultWithOptions(request, runtime);
        }

        public async Task<DescribePreCheckResultResponse> DescribePreCheckResultAsync(DescribePreCheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePreCheckResultWithOptionsAsync(request, runtime);
        }

        public DescribeRDSPerformanceResponse DescribeRDSPerformanceWithOptions(DescribeRDSPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRDSPerformanceResponse>(DoRPCRequest("DescribeRDSPerformance", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRDSPerformanceResponse> DescribeRDSPerformanceWithOptionsAsync(DescribeRDSPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRDSPerformanceResponse>(await DoRPCRequestAsync("DescribeRDSPerformance", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRDSPerformanceResponse DescribeRDSPerformance(DescribeRDSPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRDSPerformanceWithOptions(request, runtime);
        }

        public async Task<DescribeRDSPerformanceResponse> DescribeRDSPerformanceAsync(DescribeRDSPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRDSPerformanceWithOptionsAsync(request, runtime);
        }

        public DescribeRdsCommodityResponse DescribeRdsCommodityWithOptions(DescribeRdsCommodityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRdsCommodityResponse>(DoRPCRequest("DescribeRdsCommodity", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRdsCommodityResponse> DescribeRdsCommodityWithOptionsAsync(DescribeRdsCommodityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRdsCommodityResponse>(await DoRPCRequestAsync("DescribeRdsCommodity", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRdsCommodityResponse DescribeRdsCommodity(DescribeRdsCommodityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRdsCommodityWithOptions(request, runtime);
        }

        public async Task<DescribeRdsCommodityResponse> DescribeRdsCommodityAsync(DescribeRdsCommodityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRdsCommodityWithOptionsAsync(request, runtime);
        }

        public DescribeRdsDrdsDBResponse DescribeRdsDrdsDBWithOptions(DescribeRdsDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRdsDrdsDBResponse>(DoRPCRequest("DescribeRdsDrdsDB", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRdsDrdsDBResponse> DescribeRdsDrdsDBWithOptionsAsync(DescribeRdsDrdsDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRdsDrdsDBResponse>(await DoRPCRequestAsync("DescribeRdsDrdsDB", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRdsDrdsDBResponse DescribeRdsDrdsDB(DescribeRdsDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRdsDrdsDBWithOptions(request, runtime);
        }

        public async Task<DescribeRdsDrdsDBResponse> DescribeRdsDrdsDBAsync(DescribeRdsDrdsDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRdsDrdsDBWithOptionsAsync(request, runtime);
        }

        public DescribeRdsPerformanceSummaryResponse DescribeRdsPerformanceSummaryWithOptions(DescribeRdsPerformanceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRdsPerformanceSummaryResponse>(DoRPCRequest("DescribeRdsPerformanceSummary", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRdsPerformanceSummaryResponse> DescribeRdsPerformanceSummaryWithOptionsAsync(DescribeRdsPerformanceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRdsPerformanceSummaryResponse>(await DoRPCRequestAsync("DescribeRdsPerformanceSummary", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRdsPerformanceSummaryResponse DescribeRdsPerformanceSummary(DescribeRdsPerformanceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRdsPerformanceSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeRdsPerformanceSummaryResponse> DescribeRdsPerformanceSummaryAsync(DescribeRdsPerformanceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRdsPerformanceSummaryWithOptionsAsync(request, runtime);
        }

        public DescribeRdsPriceResponse DescribeRdsPriceWithOptions(DescribeRdsPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRdsPriceResponse>(DoRPCRequest("DescribeRdsPrice", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRdsPriceResponse> DescribeRdsPriceWithOptionsAsync(DescribeRdsPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRdsPriceResponse>(await DoRPCRequestAsync("DescribeRdsPrice", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRdsPriceResponse DescribeRdsPrice(DescribeRdsPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRdsPriceWithOptions(request, runtime);
        }

        public async Task<DescribeRdsPriceResponse> DescribeRdsPriceAsync(DescribeRdsPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRdsPriceWithOptionsAsync(request, runtime);
        }

        public DescribeRdsReadOnlyResponse DescribeRdsReadOnlyWithOptions(DescribeRdsReadOnlyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRdsReadOnlyResponse>(DoRPCRequest("DescribeRdsReadOnly", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRdsReadOnlyResponse> DescribeRdsReadOnlyWithOptionsAsync(DescribeRdsReadOnlyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRdsReadOnlyResponse>(await DoRPCRequestAsync("DescribeRdsReadOnly", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRdsReadOnlyResponse DescribeRdsReadOnly(DescribeRdsReadOnlyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRdsReadOnlyWithOptions(request, runtime);
        }

        public async Task<DescribeRdsReadOnlyResponse> DescribeRdsReadOnlyAsync(DescribeRdsReadOnlyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRdsReadOnlyWithOptionsAsync(request, runtime);
        }

        public DescribeRdsSuperAccountInstancesResponse DescribeRdsSuperAccountInstancesWithOptions(DescribeRdsSuperAccountInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRdsSuperAccountInstancesResponse>(DoRPCRequest("DescribeRdsSuperAccountInstances", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRdsSuperAccountInstancesResponse> DescribeRdsSuperAccountInstancesWithOptionsAsync(DescribeRdsSuperAccountInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRdsSuperAccountInstancesResponse>(await DoRPCRequestAsync("DescribeRdsSuperAccountInstances", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRdsSuperAccountInstancesResponse DescribeRdsSuperAccountInstances(DescribeRdsSuperAccountInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRdsSuperAccountInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeRdsSuperAccountInstancesResponse> DescribeRdsSuperAccountInstancesAsync(DescribeRdsSuperAccountInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRdsSuperAccountInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeRdsVpcForZoneResponse DescribeRdsVpcForZoneWithOptions(DescribeRdsVpcForZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRdsVpcForZoneResponse>(DoRPCRequest("DescribeRdsVpcForZone", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRdsVpcForZoneResponse> DescribeRdsVpcForZoneWithOptionsAsync(DescribeRdsVpcForZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRdsVpcForZoneResponse>(await DoRPCRequestAsync("DescribeRdsVpcForZone", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRdsVpcForZoneResponse DescribeRdsVpcForZone(DescribeRdsVpcForZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRdsVpcForZoneWithOptions(request, runtime);
        }

        public async Task<DescribeRdsVpcForZoneResponse> DescribeRdsVpcForZoneAsync(DescribeRdsVpcForZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRdsVpcForZoneWithOptionsAsync(request, runtime);
        }

        public DescribeRecycleBinStatusResponse DescribeRecycleBinStatusWithOptions(DescribeRecycleBinStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecycleBinStatusResponse>(DoRPCRequest("DescribeRecycleBinStatus", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRecycleBinStatusResponse> DescribeRecycleBinStatusWithOptionsAsync(DescribeRecycleBinStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecycleBinStatusResponse>(await DoRPCRequestAsync("DescribeRecycleBinStatus", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRecycleBinStatusResponse DescribeRecycleBinStatus(DescribeRecycleBinStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecycleBinStatusWithOptions(request, runtime);
        }

        public async Task<DescribeRecycleBinStatusResponse> DescribeRecycleBinStatusAsync(DescribeRecycleBinStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecycleBinStatusWithOptionsAsync(request, runtime);
        }

        public DescribeRecycleBinTablesResponse DescribeRecycleBinTablesWithOptions(DescribeRecycleBinTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecycleBinTablesResponse>(DoRPCRequest("DescribeRecycleBinTables", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRecycleBinTablesResponse> DescribeRecycleBinTablesWithOptionsAsync(DescribeRecycleBinTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecycleBinTablesResponse>(await DoRPCRequestAsync("DescribeRecycleBinTables", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRecycleBinTablesResponse DescribeRecycleBinTables(DescribeRecycleBinTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecycleBinTablesWithOptions(request, runtime);
        }

        public async Task<DescribeRecycleBinTablesResponse> DescribeRecycleBinTablesAsync(DescribeRecycleBinTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecycleBinTablesWithOptionsAsync(request, runtime);
        }

        public DescribeRestoreOrderResponse DescribeRestoreOrderWithOptions(DescribeRestoreOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRestoreOrderResponse>(DoRPCRequest("DescribeRestoreOrder", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRestoreOrderResponse> DescribeRestoreOrderWithOptionsAsync(DescribeRestoreOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRestoreOrderResponse>(await DoRPCRequestAsync("DescribeRestoreOrder", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRestoreOrderResponse DescribeRestoreOrder(DescribeRestoreOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestoreOrderWithOptions(request, runtime);
        }

        public async Task<DescribeRestoreOrderResponse> DescribeRestoreOrderAsync(DescribeRestoreOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestoreOrderWithOptionsAsync(request, runtime);
        }

        public DescribeShardTaskInfoResponse DescribeShardTaskInfoWithOptions(DescribeShardTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeShardTaskInfoResponse>(DoRPCRequest("DescribeShardTaskInfo", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeShardTaskInfoResponse> DescribeShardTaskInfoWithOptionsAsync(DescribeShardTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeShardTaskInfoResponse>(await DoRPCRequestAsync("DescribeShardTaskInfo", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeShardTaskInfoResponse DescribeShardTaskInfo(DescribeShardTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeShardTaskInfoWithOptions(request, runtime);
        }

        public async Task<DescribeShardTaskInfoResponse> DescribeShardTaskInfoAsync(DescribeShardTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeShardTaskInfoWithOptionsAsync(request, runtime);
        }

        public DescribeShardTaskListResponse DescribeShardTaskListWithOptions(DescribeShardTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeShardTaskListResponse>(DoRPCRequest("DescribeShardTaskList", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeShardTaskListResponse> DescribeShardTaskListWithOptionsAsync(DescribeShardTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeShardTaskListResponse>(await DoRPCRequestAsync("DescribeShardTaskList", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeShardTaskListResponse DescribeShardTaskList(DescribeShardTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeShardTaskListWithOptions(request, runtime);
        }

        public async Task<DescribeShardTaskListResponse> DescribeShardTaskListAsync(DescribeShardTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeShardTaskListWithOptionsAsync(request, runtime);
        }

        public DescribeSqlFlashbakTaskResponse DescribeSqlFlashbakTaskWithOptions(DescribeSqlFlashbakTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSqlFlashbakTaskResponse>(DoRPCRequest("DescribeSqlFlashbakTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSqlFlashbakTaskResponse> DescribeSqlFlashbakTaskWithOptionsAsync(DescribeSqlFlashbakTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSqlFlashbakTaskResponse>(await DoRPCRequestAsync("DescribeSqlFlashbakTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSqlFlashbakTaskResponse DescribeSqlFlashbakTask(DescribeSqlFlashbakTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSqlFlashbakTaskWithOptions(request, runtime);
        }

        public async Task<DescribeSqlFlashbakTaskResponse> DescribeSqlFlashbakTaskAsync(DescribeSqlFlashbakTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSqlFlashbakTaskWithOptionsAsync(request, runtime);
        }

        public DescribeSrcRdsListResponse DescribeSrcRdsListWithOptions(DescribeSrcRdsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSrcRdsListResponse>(DoRPCRequest("DescribeSrcRdsList", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSrcRdsListResponse> DescribeSrcRdsListWithOptionsAsync(DescribeSrcRdsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSrcRdsListResponse>(await DoRPCRequestAsync("DescribeSrcRdsList", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSrcRdsListResponse DescribeSrcRdsList(DescribeSrcRdsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSrcRdsListWithOptions(request, runtime);
        }

        public async Task<DescribeSrcRdsListResponse> DescribeSrcRdsListAsync(DescribeSrcRdsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSrcRdsListWithOptionsAsync(request, runtime);
        }

        public DescribeTableResponse DescribeTableWithOptions(DescribeTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTableResponse>(DoRPCRequest("DescribeTable", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTableResponse> DescribeTableWithOptionsAsync(DescribeTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTableResponse>(await DoRPCRequestAsync("DescribeTable", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTableResponse DescribeTable(DescribeTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTableWithOptions(request, runtime);
        }

        public async Task<DescribeTableResponse> DescribeTableAsync(DescribeTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTableWithOptionsAsync(request, runtime);
        }

        public DescribeTableListByTypeResponse DescribeTableListByTypeWithOptions(DescribeTableListByTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTableListByTypeResponse>(DoRPCRequest("DescribeTableListByType", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTableListByTypeResponse> DescribeTableListByTypeWithOptionsAsync(DescribeTableListByTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTableListByTypeResponse>(await DoRPCRequestAsync("DescribeTableListByType", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTableListByTypeResponse DescribeTableListByType(DescribeTableListByTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTableListByTypeWithOptions(request, runtime);
        }

        public async Task<DescribeTableListByTypeResponse> DescribeTableListByTypeAsync(DescribeTableListByTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTableListByTypeWithOptionsAsync(request, runtime);
        }

        public DescribeTableShardingInfoResponse DescribeTableShardingInfoWithOptions(DescribeTableShardingInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTableShardingInfoResponse>(DoRPCRequest("DescribeTableShardingInfo", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTableShardingInfoResponse> DescribeTableShardingInfoWithOptionsAsync(DescribeTableShardingInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTableShardingInfoResponse>(await DoRPCRequestAsync("DescribeTableShardingInfo", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTableShardingInfoResponse DescribeTableShardingInfo(DescribeTableShardingInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTableShardingInfoWithOptions(request, runtime);
        }

        public async Task<DescribeTableShardingInfoResponse> DescribeTableShardingInfoAsync(DescribeTableShardingInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTableShardingInfoWithOptionsAsync(request, runtime);
        }

        public DescribeTablesResponse DescribeTablesWithOptions(DescribeTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTablesResponse>(DoRPCRequest("DescribeTables", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTablesResponse> DescribeTablesWithOptionsAsync(DescribeTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTablesResponse>(await DoRPCRequestAsync("DescribeTables", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTablesResponse DescribeTables(DescribeTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTablesWithOptions(request, runtime);
        }

        public async Task<DescribeTablesResponse> DescribeTablesAsync(DescribeTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTablesWithOptionsAsync(request, runtime);
        }

        public DisableSqlAuditResponse DisableSqlAuditWithOptions(DisableSqlAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableSqlAuditResponse>(DoRPCRequest("DisableSqlAudit", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableSqlAuditResponse> DisableSqlAuditWithOptionsAsync(DisableSqlAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableSqlAuditResponse>(await DoRPCRequestAsync("DisableSqlAudit", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableSqlAuditResponse DisableSqlAudit(DisableSqlAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableSqlAuditWithOptions(request, runtime);
        }

        public async Task<DisableSqlAuditResponse> DisableSqlAuditAsync(DisableSqlAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableSqlAuditWithOptionsAsync(request, runtime);
        }

        public EnableInstanceIpv6AddressResponse EnableInstanceIpv6AddressWithOptions(EnableInstanceIpv6AddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableInstanceIpv6AddressResponse>(DoRPCRequest("EnableInstanceIpv6Address", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableInstanceIpv6AddressResponse> EnableInstanceIpv6AddressWithOptionsAsync(EnableInstanceIpv6AddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableInstanceIpv6AddressResponse>(await DoRPCRequestAsync("EnableInstanceIpv6Address", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableInstanceIpv6AddressResponse EnableInstanceIpv6Address(EnableInstanceIpv6AddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableInstanceIpv6AddressWithOptions(request, runtime);
        }

        public async Task<EnableInstanceIpv6AddressResponse> EnableInstanceIpv6AddressAsync(EnableInstanceIpv6AddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableInstanceIpv6AddressWithOptionsAsync(request, runtime);
        }

        public EnableSqlAuditResponse EnableSqlAuditWithOptions(EnableSqlAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableSqlAuditResponse>(DoRPCRequest("EnableSqlAudit", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableSqlAuditResponse> EnableSqlAuditWithOptionsAsync(EnableSqlAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableSqlAuditResponse>(await DoRPCRequestAsync("EnableSqlAudit", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableSqlAuditResponse EnableSqlAudit(EnableSqlAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableSqlAuditWithOptions(request, runtime);
        }

        public async Task<EnableSqlAuditResponse> EnableSqlAuditAsync(EnableSqlAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableSqlAuditWithOptionsAsync(request, runtime);
        }

        public EnableSqlFlashbackMatchSwitchResponse EnableSqlFlashbackMatchSwitchWithOptions(EnableSqlFlashbackMatchSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableSqlFlashbackMatchSwitchResponse>(DoRPCRequest("EnableSqlFlashbackMatchSwitch", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableSqlFlashbackMatchSwitchResponse> EnableSqlFlashbackMatchSwitchWithOptionsAsync(EnableSqlFlashbackMatchSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableSqlFlashbackMatchSwitchResponse>(await DoRPCRequestAsync("EnableSqlFlashbackMatchSwitch", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableSqlFlashbackMatchSwitchResponse EnableSqlFlashbackMatchSwitch(EnableSqlFlashbackMatchSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableSqlFlashbackMatchSwitchWithOptions(request, runtime);
        }

        public async Task<EnableSqlFlashbackMatchSwitchResponse> EnableSqlFlashbackMatchSwitchAsync(EnableSqlFlashbackMatchSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableSqlFlashbackMatchSwitchWithOptionsAsync(request, runtime);
        }

        public FlashbackRecycleBinTableResponse FlashbackRecycleBinTableWithOptions(FlashbackRecycleBinTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FlashbackRecycleBinTableResponse>(DoRPCRequest("FlashbackRecycleBinTable", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FlashbackRecycleBinTableResponse> FlashbackRecycleBinTableWithOptionsAsync(FlashbackRecycleBinTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FlashbackRecycleBinTableResponse>(await DoRPCRequestAsync("FlashbackRecycleBinTable", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FlashbackRecycleBinTableResponse FlashbackRecycleBinTable(FlashbackRecycleBinTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FlashbackRecycleBinTableWithOptions(request, runtime);
        }

        public async Task<FlashbackRecycleBinTableResponse> FlashbackRecycleBinTableAsync(FlashbackRecycleBinTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FlashbackRecycleBinTableWithOptionsAsync(request, runtime);
        }

        public GetBatchEvaluateTaskReportResponse GetBatchEvaluateTaskReportWithOptions(GetBatchEvaluateTaskReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBatchEvaluateTaskReportResponse>(DoRPCRequest("GetBatchEvaluateTaskReport", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetBatchEvaluateTaskReportResponse> GetBatchEvaluateTaskReportWithOptionsAsync(GetBatchEvaluateTaskReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBatchEvaluateTaskReportResponse>(await DoRPCRequestAsync("GetBatchEvaluateTaskReport", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetBatchEvaluateTaskReportResponse GetBatchEvaluateTaskReport(GetBatchEvaluateTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBatchEvaluateTaskReportWithOptions(request, runtime);
        }

        public async Task<GetBatchEvaluateTaskReportResponse> GetBatchEvaluateTaskReportAsync(GetBatchEvaluateTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBatchEvaluateTaskReportWithOptionsAsync(request, runtime);
        }

        public GetDrdsDbRdsRelationInfoResponse GetDrdsDbRdsRelationInfoWithOptions(GetDrdsDbRdsRelationInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDrdsDbRdsRelationInfoResponse>(DoRPCRequest("GetDrdsDbRdsRelationInfo", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDrdsDbRdsRelationInfoResponse> GetDrdsDbRdsRelationInfoWithOptionsAsync(GetDrdsDbRdsRelationInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDrdsDbRdsRelationInfoResponse>(await DoRPCRequestAsync("GetDrdsDbRdsRelationInfo", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDrdsDbRdsRelationInfoResponse GetDrdsDbRdsRelationInfo(GetDrdsDbRdsRelationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDrdsDbRdsRelationInfoWithOptions(request, runtime);
        }

        public async Task<GetDrdsDbRdsRelationInfoResponse> GetDrdsDbRdsRelationInfoAsync(GetDrdsDbRdsRelationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDrdsDbRdsRelationInfoWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListUserReportsResponse ListUserReportsWithOptions(ListUserReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserReportsResponse>(DoRPCRequest("ListUserReports", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUserReportsResponse> ListUserReportsWithOptionsAsync(ListUserReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserReportsResponse>(await DoRPCRequestAsync("ListUserReports", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUserReportsResponse ListUserReports(ListUserReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserReportsWithOptions(request, runtime);
        }

        public async Task<ListUserReportsResponse> ListUserReportsAsync(ListUserReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserReportsWithOptionsAsync(request, runtime);
        }

        public ListVersionsResponse ListVersionsWithOptions(ListVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVersionsResponse>(DoRPCRequest("ListVersions", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListVersionsResponse> ListVersionsWithOptionsAsync(ListVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVersionsResponse>(await DoRPCRequestAsync("ListVersions", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListVersionsResponse ListVersions(ListVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVersionsWithOptions(request, runtime);
        }

        public async Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVersionsWithOptionsAsync(request, runtime);
        }

        public ManagePrivateRdsResponse ManagePrivateRdsWithOptions(ManagePrivateRdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ManagePrivateRdsResponse>(DoRPCRequest("ManagePrivateRds", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ManagePrivateRdsResponse> ManagePrivateRdsWithOptionsAsync(ManagePrivateRdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ManagePrivateRdsResponse>(await DoRPCRequestAsync("ManagePrivateRds", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ManagePrivateRdsResponse ManagePrivateRds(ManagePrivateRdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ManagePrivateRdsWithOptions(request, runtime);
        }

        public async Task<ManagePrivateRdsResponse> ManagePrivateRdsAsync(ManagePrivateRdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ManagePrivateRdsWithOptionsAsync(request, runtime);
        }

        public ModifyAccountDescriptionResponse ModifyAccountDescriptionWithOptions(ModifyAccountDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccountDescriptionResponse>(DoRPCRequest("ModifyAccountDescription", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAccountDescriptionResponse> ModifyAccountDescriptionWithOptionsAsync(ModifyAccountDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccountDescriptionResponse>(await DoRPCRequestAsync("ModifyAccountDescription", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyAccountPrivilegeResponse ModifyAccountPrivilegeWithOptions(ModifyAccountPrivilegeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccountPrivilegeResponse>(DoRPCRequest("ModifyAccountPrivilege", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAccountPrivilegeResponse> ModifyAccountPrivilegeWithOptionsAsync(ModifyAccountPrivilegeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccountPrivilegeResponse>(await DoRPCRequestAsync("ModifyAccountPrivilege", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyAccountPrivilegeResponse ModifyAccountPrivilege(ModifyAccountPrivilegeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccountPrivilegeWithOptions(request, runtime);
        }

        public async Task<ModifyAccountPrivilegeResponse> ModifyAccountPrivilegeAsync(ModifyAccountPrivilegeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccountPrivilegeWithOptionsAsync(request, runtime);
        }

        public ModifyDrdsInstanceDescriptionResponse ModifyDrdsInstanceDescriptionWithOptions(ModifyDrdsInstanceDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDrdsInstanceDescriptionResponse>(DoRPCRequest("ModifyDrdsInstanceDescription", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDrdsInstanceDescriptionResponse> ModifyDrdsInstanceDescriptionWithOptionsAsync(ModifyDrdsInstanceDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDrdsInstanceDescriptionResponse>(await DoRPCRequestAsync("ModifyDrdsInstanceDescription", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDrdsInstanceDescriptionResponse ModifyDrdsInstanceDescription(ModifyDrdsInstanceDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDrdsInstanceDescriptionWithOptions(request, runtime);
        }

        public async Task<ModifyDrdsInstanceDescriptionResponse> ModifyDrdsInstanceDescriptionAsync(ModifyDrdsInstanceDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDrdsInstanceDescriptionWithOptionsAsync(request, runtime);
        }

        public ModifyDrdsIpWhiteListResponse ModifyDrdsIpWhiteListWithOptions(ModifyDrdsIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDrdsIpWhiteListResponse>(DoRPCRequest("ModifyDrdsIpWhiteList", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDrdsIpWhiteListResponse> ModifyDrdsIpWhiteListWithOptionsAsync(ModifyDrdsIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDrdsIpWhiteListResponse>(await DoRPCRequestAsync("ModifyDrdsIpWhiteList", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDrdsIpWhiteListResponse ModifyDrdsIpWhiteList(ModifyDrdsIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDrdsIpWhiteListWithOptions(request, runtime);
        }

        public async Task<ModifyDrdsIpWhiteListResponse> ModifyDrdsIpWhiteListAsync(ModifyDrdsIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDrdsIpWhiteListWithOptionsAsync(request, runtime);
        }

        public ModifyEventTaskStatusResponse ModifyEventTaskStatusWithOptions(ModifyEventTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyEventTaskStatusResponse>(DoRPCRequest("ModifyEventTaskStatus", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyEventTaskStatusResponse> ModifyEventTaskStatusWithOptionsAsync(ModifyEventTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyEventTaskStatusResponse>(await DoRPCRequestAsync("ModifyEventTaskStatus", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyEventTaskStatusResponse ModifyEventTaskStatus(ModifyEventTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyEventTaskStatusWithOptions(request, runtime);
        }

        public async Task<ModifyEventTaskStatusResponse> ModifyEventTaskStatusAsync(ModifyEventTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyEventTaskStatusWithOptionsAsync(request, runtime);
        }

        public ModifyPolarDbReadWeightResponse ModifyPolarDbReadWeightWithOptions(ModifyPolarDbReadWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPolarDbReadWeightResponse>(DoRPCRequest("ModifyPolarDbReadWeight", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyPolarDbReadWeightResponse> ModifyPolarDbReadWeightWithOptionsAsync(ModifyPolarDbReadWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPolarDbReadWeightResponse>(await DoRPCRequestAsync("ModifyPolarDbReadWeight", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyPolarDbReadWeightResponse ModifyPolarDbReadWeight(ModifyPolarDbReadWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPolarDbReadWeightWithOptions(request, runtime);
        }

        public async Task<ModifyPolarDbReadWeightResponse> ModifyPolarDbReadWeightAsync(ModifyPolarDbReadWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPolarDbReadWeightWithOptionsAsync(request, runtime);
        }

        public ModifyRdsReadWeightResponse ModifyRdsReadWeightWithOptions(ModifyRdsReadWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRdsReadWeightResponse>(DoRPCRequest("ModifyRdsReadWeight", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyRdsReadWeightResponse> ModifyRdsReadWeightWithOptionsAsync(ModifyRdsReadWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRdsReadWeightResponse>(await DoRPCRequestAsync("ModifyRdsReadWeight", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyRdsReadWeightResponse ModifyRdsReadWeight(ModifyRdsReadWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRdsReadWeightWithOptions(request, runtime);
        }

        public async Task<ModifyRdsReadWeightResponse> ModifyRdsReadWeightAsync(ModifyRdsReadWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRdsReadWeightWithOptionsAsync(request, runtime);
        }

        public MyCatConnectTestResponse MyCatConnectTestWithOptions(MyCatConnectTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MyCatConnectTestResponse>(DoRPCRequest("MyCatConnectTest", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MyCatConnectTestResponse> MyCatConnectTestWithOptionsAsync(MyCatConnectTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MyCatConnectTestResponse>(await DoRPCRequestAsync("MyCatConnectTest", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MyCatConnectTestResponse MyCatConnectTest(MyCatConnectTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MyCatConnectTestWithOptions(request, runtime);
        }

        public async Task<MyCatConnectTestResponse> MyCatConnectTestAsync(MyCatConnectTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MyCatConnectTestWithOptionsAsync(request, runtime);
        }

        public MyCatCustomImportPreCheckResponse MyCatCustomImportPreCheckWithOptions(MyCatCustomImportPreCheckRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            MyCatCustomImportPreCheckShrinkRequest request = new MyCatCustomImportPreCheckShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TableMap))
            {
                request.TableMapShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TableMap, "TableMap", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MyCatCustomImportPreCheckResponse>(DoRPCRequest("MyCatCustomImportPreCheck", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MyCatCustomImportPreCheckResponse> MyCatCustomImportPreCheckWithOptionsAsync(MyCatCustomImportPreCheckRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            MyCatCustomImportPreCheckShrinkRequest request = new MyCatCustomImportPreCheckShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TableMap))
            {
                request.TableMapShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TableMap, "TableMap", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MyCatCustomImportPreCheckResponse>(await DoRPCRequestAsync("MyCatCustomImportPreCheck", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MyCatCustomImportPreCheckResponse MyCatCustomImportPreCheck(MyCatCustomImportPreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MyCatCustomImportPreCheckWithOptions(request, runtime);
        }

        public async Task<MyCatCustomImportPreCheckResponse> MyCatCustomImportPreCheckAsync(MyCatCustomImportPreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MyCatCustomImportPreCheckWithOptionsAsync(request, runtime);
        }

        public PreCheckModifyTableShardingKeyParamResponse PreCheckModifyTableShardingKeyParamWithOptions(PreCheckModifyTableShardingKeyParamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PreCheckModifyTableShardingKeyParamResponse>(DoRPCRequest("PreCheckModifyTableShardingKeyParam", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PreCheckModifyTableShardingKeyParamResponse> PreCheckModifyTableShardingKeyParamWithOptionsAsync(PreCheckModifyTableShardingKeyParamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PreCheckModifyTableShardingKeyParamResponse>(await DoRPCRequestAsync("PreCheckModifyTableShardingKeyParam", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PreCheckModifyTableShardingKeyParamResponse PreCheckModifyTableShardingKeyParam(PreCheckModifyTableShardingKeyParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PreCheckModifyTableShardingKeyParamWithOptions(request, runtime);
        }

        public async Task<PreCheckModifyTableShardingKeyParamResponse> PreCheckModifyTableShardingKeyParamAsync(PreCheckModifyTableShardingKeyParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PreCheckModifyTableShardingKeyParamWithOptionsAsync(request, runtime);
        }

        public PreCheckSqlFlashbackTaskResponse PreCheckSqlFlashbackTaskWithOptions(PreCheckSqlFlashbackTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PreCheckSqlFlashbackTaskResponse>(DoRPCRequest("PreCheckSqlFlashbackTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PreCheckSqlFlashbackTaskResponse> PreCheckSqlFlashbackTaskWithOptionsAsync(PreCheckSqlFlashbackTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PreCheckSqlFlashbackTaskResponse>(await DoRPCRequestAsync("PreCheckSqlFlashbackTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PreCheckSqlFlashbackTaskResponse PreCheckSqlFlashbackTask(PreCheckSqlFlashbackTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PreCheckSqlFlashbackTaskWithOptions(request, runtime);
        }

        public async Task<PreCheckSqlFlashbackTaskResponse> PreCheckSqlFlashbackTaskAsync(PreCheckSqlFlashbackTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PreCheckSqlFlashbackTaskWithOptionsAsync(request, runtime);
        }

        public PrecheckMyCatEvaluateResponse PrecheckMyCatEvaluateWithOptions(PrecheckMyCatEvaluateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PrecheckMyCatEvaluateResponse>(DoRPCRequest("PrecheckMyCatEvaluate", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PrecheckMyCatEvaluateResponse> PrecheckMyCatEvaluateWithOptionsAsync(PrecheckMyCatEvaluateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PrecheckMyCatEvaluateResponse>(await DoRPCRequestAsync("PrecheckMyCatEvaluate", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PrecheckMyCatEvaluateResponse PrecheckMyCatEvaluate(PrecheckMyCatEvaluateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PrecheckMyCatEvaluateWithOptions(request, runtime);
        }

        public async Task<PrecheckMyCatEvaluateResponse> PrecheckMyCatEvaluateAsync(PrecheckMyCatEvaluateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PrecheckMyCatEvaluateWithOptionsAsync(request, runtime);
        }

        public PutRestorePreCheckResponse PutRestorePreCheckWithOptions(PutRestorePreCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutRestorePreCheckResponse>(DoRPCRequest("PutRestorePreCheck", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutRestorePreCheckResponse> PutRestorePreCheckWithOptionsAsync(PutRestorePreCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutRestorePreCheckResponse>(await DoRPCRequestAsync("PutRestorePreCheck", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutRestorePreCheckResponse PutRestorePreCheck(PutRestorePreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutRestorePreCheckWithOptions(request, runtime);
        }

        public async Task<PutRestorePreCheckResponse> PutRestorePreCheckAsync(PutRestorePreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutRestorePreCheckWithOptionsAsync(request, runtime);
        }

        public PutStartBackupResponse PutStartBackupWithOptions(PutStartBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutStartBackupResponse>(DoRPCRequest("PutStartBackup", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutStartBackupResponse> PutStartBackupWithOptionsAsync(PutStartBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutStartBackupResponse>(await DoRPCRequestAsync("PutStartBackup", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutStartBackupResponse PutStartBackup(PutStartBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutStartBackupWithOptions(request, runtime);
        }

        public async Task<PutStartBackupResponse> PutStartBackupAsync(PutStartBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutStartBackupWithOptionsAsync(request, runtime);
        }

        public RearrangeDbToInstanceResponse RearrangeDbToInstanceWithOptions(RearrangeDbToInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RearrangeDbToInstanceResponse>(DoRPCRequest("RearrangeDbToInstance", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RearrangeDbToInstanceResponse> RearrangeDbToInstanceWithOptionsAsync(RearrangeDbToInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RearrangeDbToInstanceResponse>(await DoRPCRequestAsync("RearrangeDbToInstance", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RearrangeDbToInstanceResponse RearrangeDbToInstance(RearrangeDbToInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RearrangeDbToInstanceWithOptions(request, runtime);
        }

        public async Task<RearrangeDbToInstanceResponse> RearrangeDbToInstanceAsync(RearrangeDbToInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RearrangeDbToInstanceWithOptionsAsync(request, runtime);
        }

        public RefreshDrdsAtomUrlResponse RefreshDrdsAtomUrlWithOptions(RefreshDrdsAtomUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshDrdsAtomUrlResponse>(DoRPCRequest("RefreshDrdsAtomUrl", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RefreshDrdsAtomUrlResponse> RefreshDrdsAtomUrlWithOptionsAsync(RefreshDrdsAtomUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshDrdsAtomUrlResponse>(await DoRPCRequestAsync("RefreshDrdsAtomUrl", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RefreshDrdsAtomUrlResponse RefreshDrdsAtomUrl(RefreshDrdsAtomUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshDrdsAtomUrlWithOptions(request, runtime);
        }

        public async Task<RefreshDrdsAtomUrlResponse> RefreshDrdsAtomUrlAsync(RefreshDrdsAtomUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshDrdsAtomUrlWithOptionsAsync(request, runtime);
        }

        public ReleaseInstanceInternetAddressResponse ReleaseInstanceInternetAddressWithOptions(ReleaseInstanceInternetAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseInstanceInternetAddressResponse>(DoRPCRequest("ReleaseInstanceInternetAddress", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseInstanceInternetAddressResponse> ReleaseInstanceInternetAddressWithOptionsAsync(ReleaseInstanceInternetAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseInstanceInternetAddressResponse>(await DoRPCRequestAsync("ReleaseInstanceInternetAddress", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleaseInstanceInternetAddressResponse ReleaseInstanceInternetAddress(ReleaseInstanceInternetAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseInstanceInternetAddressWithOptions(request, runtime);
        }

        public async Task<ReleaseInstanceInternetAddressResponse> ReleaseInstanceInternetAddressAsync(ReleaseInstanceInternetAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseInstanceInternetAddressWithOptionsAsync(request, runtime);
        }

        public RemoveBackupsSetResponse RemoveBackupsSetWithOptions(RemoveBackupsSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveBackupsSetResponse>(DoRPCRequest("RemoveBackupsSet", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveBackupsSetResponse> RemoveBackupsSetWithOptionsAsync(RemoveBackupsSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveBackupsSetResponse>(await DoRPCRequestAsync("RemoveBackupsSet", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveBackupsSetResponse RemoveBackupsSet(RemoveBackupsSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveBackupsSetWithOptions(request, runtime);
        }

        public async Task<RemoveBackupsSetResponse> RemoveBackupsSetAsync(RemoveBackupsSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveBackupsSetWithOptionsAsync(request, runtime);
        }

        public RemoveDataExportTaskResponse RemoveDataExportTaskWithOptions(RemoveDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveDataExportTaskResponse>(DoRPCRequest("RemoveDataExportTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveDataExportTaskResponse> RemoveDataExportTaskWithOptionsAsync(RemoveDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveDataExportTaskResponse>(await DoRPCRequestAsync("RemoveDataExportTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveDataExportTaskResponse RemoveDataExportTask(RemoveDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveDataExportTaskWithOptions(request, runtime);
        }

        public async Task<RemoveDataExportTaskResponse> RemoveDataExportTaskAsync(RemoveDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveDataExportTaskWithOptionsAsync(request, runtime);
        }

        public RemoveDataImportTaskResponse RemoveDataImportTaskWithOptions(RemoveDataImportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveDataImportTaskResponse>(DoRPCRequest("RemoveDataImportTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveDataImportTaskResponse> RemoveDataImportTaskWithOptionsAsync(RemoveDataImportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveDataImportTaskResponse>(await DoRPCRequestAsync("RemoveDataImportTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveDataImportTaskResponse RemoveDataImportTask(RemoveDataImportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveDataImportTaskWithOptions(request, runtime);
        }

        public async Task<RemoveDataImportTaskResponse> RemoveDataImportTaskAsync(RemoveDataImportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveDataImportTaskWithOptionsAsync(request, runtime);
        }

        public RemoveDrdsDbResponse RemoveDrdsDbWithOptions(RemoveDrdsDbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveDrdsDbResponse>(DoRPCRequest("RemoveDrdsDb", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveDrdsDbResponse> RemoveDrdsDbWithOptionsAsync(RemoveDrdsDbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveDrdsDbResponse>(await DoRPCRequestAsync("RemoveDrdsDb", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveDrdsDbResponse RemoveDrdsDb(RemoveDrdsDbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveDrdsDbWithOptions(request, runtime);
        }

        public async Task<RemoveDrdsDbResponse> RemoveDrdsDbAsync(RemoveDrdsDbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveDrdsDbWithOptionsAsync(request, runtime);
        }

        public RemoveDrdsDbFailedRecordResponse RemoveDrdsDbFailedRecordWithOptions(RemoveDrdsDbFailedRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveDrdsDbFailedRecordResponse>(DoRPCRequest("RemoveDrdsDbFailedRecord", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveDrdsDbFailedRecordResponse> RemoveDrdsDbFailedRecordWithOptionsAsync(RemoveDrdsDbFailedRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveDrdsDbFailedRecordResponse>(await DoRPCRequestAsync("RemoveDrdsDbFailedRecord", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveDrdsDbFailedRecordResponse RemoveDrdsDbFailedRecord(RemoveDrdsDbFailedRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveDrdsDbFailedRecordWithOptions(request, runtime);
        }

        public async Task<RemoveDrdsDbFailedRecordResponse> RemoveDrdsDbFailedRecordAsync(RemoveDrdsDbFailedRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveDrdsDbFailedRecordWithOptionsAsync(request, runtime);
        }

        public RemoveDrdsInstanceResponse RemoveDrdsInstanceWithOptions(RemoveDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveDrdsInstanceResponse>(DoRPCRequest("RemoveDrdsInstance", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveDrdsInstanceResponse> RemoveDrdsInstanceWithOptionsAsync(RemoveDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveDrdsInstanceResponse>(await DoRPCRequestAsync("RemoveDrdsInstance", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveDrdsInstanceResponse RemoveDrdsInstance(RemoveDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveDrdsInstanceWithOptions(request, runtime);
        }

        public async Task<RemoveDrdsInstanceResponse> RemoveDrdsInstanceAsync(RemoveDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveDrdsInstanceWithOptionsAsync(request, runtime);
        }

        public RemoveDrdsMysqlResponse RemoveDrdsMysqlWithOptions(RemoveDrdsMysqlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveDrdsMysqlResponse>(DoRPCRequest("RemoveDrdsMysql", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveDrdsMysqlResponse> RemoveDrdsMysqlWithOptionsAsync(RemoveDrdsMysqlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveDrdsMysqlResponse>(await DoRPCRequestAsync("RemoveDrdsMysql", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveDrdsMysqlResponse RemoveDrdsMysql(RemoveDrdsMysqlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveDrdsMysqlWithOptions(request, runtime);
        }

        public async Task<RemoveDrdsMysqlResponse> RemoveDrdsMysqlAsync(RemoveDrdsMysqlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveDrdsMysqlWithOptionsAsync(request, runtime);
        }

        public RemoveEvaluateTaskResponse RemoveEvaluateTaskWithOptions(RemoveEvaluateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveEvaluateTaskResponse>(DoRPCRequest("RemoveEvaluateTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveEvaluateTaskResponse> RemoveEvaluateTaskWithOptionsAsync(RemoveEvaluateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveEvaluateTaskResponse>(await DoRPCRequestAsync("RemoveEvaluateTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveEvaluateTaskResponse RemoveEvaluateTask(RemoveEvaluateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveEvaluateTaskWithOptions(request, runtime);
        }

        public async Task<RemoveEvaluateTaskResponse> RemoveEvaluateTaskAsync(RemoveEvaluateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveEvaluateTaskWithOptionsAsync(request, runtime);
        }

        public RemoveInstanceAccountResponse RemoveInstanceAccountWithOptions(RemoveInstanceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveInstanceAccountResponse>(DoRPCRequest("RemoveInstanceAccount", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveInstanceAccountResponse> RemoveInstanceAccountWithOptionsAsync(RemoveInstanceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveInstanceAccountResponse>(await DoRPCRequestAsync("RemoveInstanceAccount", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveInstanceAccountResponse RemoveInstanceAccount(RemoveInstanceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveInstanceAccountWithOptions(request, runtime);
        }

        public async Task<RemoveInstanceAccountResponse> RemoveInstanceAccountAsync(RemoveInstanceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveInstanceAccountWithOptionsAsync(request, runtime);
        }

        public RemoveRecycleBinTableResponse RemoveRecycleBinTableWithOptions(RemoveRecycleBinTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveRecycleBinTableResponse>(DoRPCRequest("RemoveRecycleBinTable", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveRecycleBinTableResponse> RemoveRecycleBinTableWithOptionsAsync(RemoveRecycleBinTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveRecycleBinTableResponse>(await DoRPCRequestAsync("RemoveRecycleBinTable", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveRecycleBinTableResponse RemoveRecycleBinTable(RemoveRecycleBinTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveRecycleBinTableWithOptions(request, runtime);
        }

        public async Task<RemoveRecycleBinTableResponse> RemoveRecycleBinTableAsync(RemoveRecycleBinTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveRecycleBinTableWithOptionsAsync(request, runtime);
        }

        public RestartDrdsInstanceResponse RestartDrdsInstanceWithOptions(RestartDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartDrdsInstanceResponse>(DoRPCRequest("RestartDrdsInstance", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestartDrdsInstanceResponse> RestartDrdsInstanceWithOptionsAsync(RestartDrdsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartDrdsInstanceResponse>(await DoRPCRequestAsync("RestartDrdsInstance", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RestartDrdsInstanceResponse RestartDrdsInstance(RestartDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartDrdsInstanceWithOptions(request, runtime);
        }

        public async Task<RestartDrdsInstanceResponse> RestartDrdsInstanceAsync(RestartDrdsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartDrdsInstanceWithOptionsAsync(request, runtime);
        }

        public RollbackInstanceVersionResponse RollbackInstanceVersionWithOptions(RollbackInstanceVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RollbackInstanceVersionResponse>(DoRPCRequest("RollbackInstanceVersion", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RollbackInstanceVersionResponse> RollbackInstanceVersionWithOptionsAsync(RollbackInstanceVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RollbackInstanceVersionResponse>(await DoRPCRequestAsync("RollbackInstanceVersion", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RollbackInstanceVersionResponse RollbackInstanceVersion(RollbackInstanceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RollbackInstanceVersionWithOptions(request, runtime);
        }

        public async Task<RollbackInstanceVersionResponse> RollbackInstanceVersionAsync(RollbackInstanceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RollbackInstanceVersionWithOptionsAsync(request, runtime);
        }

        public SetBackupLocalResponse SetBackupLocalWithOptions(SetBackupLocalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetBackupLocalResponse>(DoRPCRequest("SetBackupLocal", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetBackupLocalResponse> SetBackupLocalWithOptionsAsync(SetBackupLocalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetBackupLocalResponse>(await DoRPCRequestAsync("SetBackupLocal", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetBackupLocalResponse SetBackupLocal(SetBackupLocalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetBackupLocalWithOptions(request, runtime);
        }

        public async Task<SetBackupLocalResponse> SetBackupLocalAsync(SetBackupLocalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetBackupLocalWithOptionsAsync(request, runtime);
        }

        public SetBackupPolicyResponse SetBackupPolicyWithOptions(SetBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetBackupPolicyResponse>(DoRPCRequest("SetBackupPolicy", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetBackupPolicyResponse> SetBackupPolicyWithOptionsAsync(SetBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetBackupPolicyResponse>(await DoRPCRequestAsync("SetBackupPolicy", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetBackupPolicyResponse SetBackupPolicy(SetBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetBackupPolicyWithOptions(request, runtime);
        }

        public async Task<SetBackupPolicyResponse> SetBackupPolicyAsync(SetBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetBackupPolicyWithOptionsAsync(request, runtime);
        }

        public SetupBroadcastTablesResponse SetupBroadcastTablesWithOptions(SetupBroadcastTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetupBroadcastTablesResponse>(DoRPCRequest("SetupBroadcastTables", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetupBroadcastTablesResponse> SetupBroadcastTablesWithOptionsAsync(SetupBroadcastTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetupBroadcastTablesResponse>(await DoRPCRequestAsync("SetupBroadcastTables", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetupBroadcastTablesResponse SetupBroadcastTables(SetupBroadcastTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetupBroadcastTablesWithOptions(request, runtime);
        }

        public async Task<SetupBroadcastTablesResponse> SetupBroadcastTablesAsync(SetupBroadcastTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetupBroadcastTablesWithOptionsAsync(request, runtime);
        }

        public SetupDrdsParamsResponse SetupDrdsParamsWithOptions(SetupDrdsParamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetupDrdsParamsResponse>(DoRPCRequest("SetupDrdsParams", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetupDrdsParamsResponse> SetupDrdsParamsWithOptionsAsync(SetupDrdsParamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetupDrdsParamsResponse>(await DoRPCRequestAsync("SetupDrdsParams", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetupDrdsParamsResponse SetupDrdsParams(SetupDrdsParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetupDrdsParamsWithOptions(request, runtime);
        }

        public async Task<SetupDrdsParamsResponse> SetupDrdsParamsAsync(SetupDrdsParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetupDrdsParamsWithOptionsAsync(request, runtime);
        }

        public SetupRecycleBinStatusResponse SetupRecycleBinStatusWithOptions(SetupRecycleBinStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetupRecycleBinStatusResponse>(DoRPCRequest("SetupRecycleBinStatus", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetupRecycleBinStatusResponse> SetupRecycleBinStatusWithOptionsAsync(SetupRecycleBinStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetupRecycleBinStatusResponse>(await DoRPCRequestAsync("SetupRecycleBinStatus", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetupRecycleBinStatusResponse SetupRecycleBinStatus(SetupRecycleBinStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetupRecycleBinStatusWithOptions(request, runtime);
        }

        public async Task<SetupRecycleBinStatusResponse> SetupRecycleBinStatusAsync(SetupRecycleBinStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetupRecycleBinStatusWithOptionsAsync(request, runtime);
        }

        public SetupTableResponse SetupTableWithOptions(SetupTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetupTableResponse>(DoRPCRequest("SetupTable", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetupTableResponse> SetupTableWithOptionsAsync(SetupTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetupTableResponse>(await DoRPCRequestAsync("SetupTable", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetupTableResponse SetupTable(SetupTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetupTableWithOptions(request, runtime);
        }

        public async Task<SetupTableResponse> SetupTableAsync(SetupTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetupTableWithOptionsAsync(request, runtime);
        }

        public SetupTableAsyncResponse SetupTableAsyncWithOptions(SetupTableAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetupTableAsyncResponse>(DoRPCRequest("SetupTableAsync", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetupTableAsyncResponse> SetupTableAsyncWithOptionsAsync(SetupTableAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetupTableAsyncResponse>(await DoRPCRequestAsync("SetupTableAsync", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetupTableAsyncResponse SetupTableAsync(SetupTableAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetupTableAsyncWithOptions(request, runtime);
        }

        public async Task<SetupTableAsyncResponse> SetupTableAsyncAsync(SetupTableAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetupTableAsyncWithOptionsAsync(request, runtime);
        }

        public SqlCompatibilityCancelResponse SqlCompatibilityCancelWithOptions(SqlCompatibilityCancelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SqlCompatibilityCancelResponse>(DoRPCRequest("SqlCompatibilityCancel", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SqlCompatibilityCancelResponse> SqlCompatibilityCancelWithOptionsAsync(SqlCompatibilityCancelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SqlCompatibilityCancelResponse>(await DoRPCRequestAsync("SqlCompatibilityCancel", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SqlCompatibilityCancelResponse SqlCompatibilityCancel(SqlCompatibilityCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SqlCompatibilityCancelWithOptions(request, runtime);
        }

        public async Task<SqlCompatibilityCancelResponse> SqlCompatibilityCancelAsync(SqlCompatibilityCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SqlCompatibilityCancelWithOptionsAsync(request, runtime);
        }

        public SqlCompatibilityStartResponse SqlCompatibilityStartWithOptions(SqlCompatibilityStartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SqlCompatibilityStartResponse>(DoRPCRequest("SqlCompatibilityStart", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SqlCompatibilityStartResponse> SqlCompatibilityStartWithOptionsAsync(SqlCompatibilityStartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SqlCompatibilityStartResponse>(await DoRPCRequestAsync("SqlCompatibilityStart", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SqlCompatibilityStartResponse SqlCompatibilityStart(SqlCompatibilityStartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SqlCompatibilityStartWithOptions(request, runtime);
        }

        public async Task<SqlCompatibilityStartResponse> SqlCompatibilityStartAsync(SqlCompatibilityStartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SqlCompatibilityStartWithOptionsAsync(request, runtime);
        }

        public StartEvaluateTaskResponse StartEvaluateTaskWithOptions(StartEvaluateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartEvaluateTaskResponse>(DoRPCRequest("StartEvaluateTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartEvaluateTaskResponse> StartEvaluateTaskWithOptionsAsync(StartEvaluateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartEvaluateTaskResponse>(await DoRPCRequestAsync("StartEvaluateTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartEvaluateTaskResponse StartEvaluateTask(StartEvaluateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartEvaluateTaskWithOptions(request, runtime);
        }

        public async Task<StartEvaluateTaskResponse> StartEvaluateTaskAsync(StartEvaluateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartEvaluateTaskWithOptionsAsync(request, runtime);
        }

        public StartRestoreResponse StartRestoreWithOptions(StartRestoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartRestoreResponse>(DoRPCRequest("StartRestore", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartRestoreResponse> StartRestoreWithOptionsAsync(StartRestoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartRestoreResponse>(await DoRPCRequestAsync("StartRestore", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartRestoreResponse StartRestore(StartRestoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartRestoreWithOptions(request, runtime);
        }

        public async Task<StartRestoreResponse> StartRestoreAsync(StartRestoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartRestoreWithOptionsAsync(request, runtime);
        }

        public StopDataExportTaskResponse StopDataExportTaskWithOptions(StopDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDataExportTaskResponse>(DoRPCRequest("StopDataExportTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopDataExportTaskResponse> StopDataExportTaskWithOptionsAsync(StopDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDataExportTaskResponse>(await DoRPCRequestAsync("StopDataExportTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopDataExportTaskResponse StopDataExportTask(StopDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDataExportTaskWithOptions(request, runtime);
        }

        public async Task<StopDataExportTaskResponse> StopDataExportTaskAsync(StopDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDataExportTaskWithOptionsAsync(request, runtime);
        }

        public StopDataImportTaskResponse StopDataImportTaskWithOptions(StopDataImportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDataImportTaskResponse>(DoRPCRequest("StopDataImportTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopDataImportTaskResponse> StopDataImportTaskWithOptionsAsync(StopDataImportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDataImportTaskResponse>(await DoRPCRequestAsync("StopDataImportTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopDataImportTaskResponse StopDataImportTask(StopDataImportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDataImportTaskWithOptions(request, runtime);
        }

        public async Task<StopDataImportTaskResponse> StopDataImportTaskAsync(StopDataImportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDataImportTaskWithOptionsAsync(request, runtime);
        }

        public StopEvaluateTaskResponse StopEvaluateTaskWithOptions(StopEvaluateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopEvaluateTaskResponse>(DoRPCRequest("StopEvaluateTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopEvaluateTaskResponse> StopEvaluateTaskWithOptionsAsync(StopEvaluateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopEvaluateTaskResponse>(await DoRPCRequestAsync("StopEvaluateTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopEvaluateTaskResponse StopEvaluateTask(StopEvaluateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopEvaluateTaskWithOptions(request, runtime);
        }

        public async Task<StopEvaluateTaskResponse> StopEvaluateTaskAsync(StopEvaluateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopEvaluateTaskWithOptionsAsync(request, runtime);
        }

        public SubmitCleanTableShardingKeyModifyResponse SubmitCleanTableShardingKeyModifyWithOptions(SubmitCleanTableShardingKeyModifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitCleanTableShardingKeyModifyResponse>(DoRPCRequest("SubmitCleanTableShardingKeyModify", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitCleanTableShardingKeyModifyResponse> SubmitCleanTableShardingKeyModifyWithOptionsAsync(SubmitCleanTableShardingKeyModifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitCleanTableShardingKeyModifyResponse>(await DoRPCRequestAsync("SubmitCleanTableShardingKeyModify", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitCleanTableShardingKeyModifyResponse SubmitCleanTableShardingKeyModify(SubmitCleanTableShardingKeyModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitCleanTableShardingKeyModifyWithOptions(request, runtime);
        }

        public async Task<SubmitCleanTableShardingKeyModifyResponse> SubmitCleanTableShardingKeyModifyAsync(SubmitCleanTableShardingKeyModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitCleanTableShardingKeyModifyWithOptionsAsync(request, runtime);
        }

        public SubmitCleanTaskResponse SubmitCleanTaskWithOptions(SubmitCleanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitCleanTaskResponse>(DoRPCRequest("SubmitCleanTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitCleanTaskResponse> SubmitCleanTaskWithOptionsAsync(SubmitCleanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitCleanTaskResponse>(await DoRPCRequestAsync("SubmitCleanTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitCleanTaskResponse SubmitCleanTask(SubmitCleanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitCleanTaskWithOptions(request, runtime);
        }

        public async Task<SubmitCleanTaskResponse> SubmitCleanTaskAsync(SubmitCleanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitCleanTaskWithOptionsAsync(request, runtime);
        }

        public SubmitHotExpandPreCheckTaskResponse SubmitHotExpandPreCheckTaskWithOptions(SubmitHotExpandPreCheckTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitHotExpandPreCheckTaskResponse>(DoRPCRequest("SubmitHotExpandPreCheckTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitHotExpandPreCheckTaskResponse> SubmitHotExpandPreCheckTaskWithOptionsAsync(SubmitHotExpandPreCheckTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitHotExpandPreCheckTaskResponse>(await DoRPCRequestAsync("SubmitHotExpandPreCheckTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitHotExpandPreCheckTaskResponse SubmitHotExpandPreCheckTask(SubmitHotExpandPreCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitHotExpandPreCheckTaskWithOptions(request, runtime);
        }

        public async Task<SubmitHotExpandPreCheckTaskResponse> SubmitHotExpandPreCheckTaskAsync(SubmitHotExpandPreCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitHotExpandPreCheckTaskWithOptionsAsync(request, runtime);
        }

        public SubmitHotExpandTaskResponse SubmitHotExpandTaskWithOptions(SubmitHotExpandTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitHotExpandTaskResponse>(DoRPCRequest("SubmitHotExpandTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitHotExpandTaskResponse> SubmitHotExpandTaskWithOptionsAsync(SubmitHotExpandTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitHotExpandTaskResponse>(await DoRPCRequestAsync("SubmitHotExpandTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitHotExpandTaskResponse SubmitHotExpandTask(SubmitHotExpandTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitHotExpandTaskWithOptions(request, runtime);
        }

        public async Task<SubmitHotExpandTaskResponse> SubmitHotExpandTaskAsync(SubmitHotExpandTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitHotExpandTaskWithOptionsAsync(request, runtime);
        }

        public SubmitRollbackShardingKeyModifyResponse SubmitRollbackShardingKeyModifyWithOptions(SubmitRollbackShardingKeyModifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitRollbackShardingKeyModifyResponse>(DoRPCRequest("SubmitRollbackShardingKeyModify", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitRollbackShardingKeyModifyResponse> SubmitRollbackShardingKeyModifyWithOptionsAsync(SubmitRollbackShardingKeyModifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitRollbackShardingKeyModifyResponse>(await DoRPCRequestAsync("SubmitRollbackShardingKeyModify", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitRollbackShardingKeyModifyResponse SubmitRollbackShardingKeyModify(SubmitRollbackShardingKeyModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitRollbackShardingKeyModifyWithOptions(request, runtime);
        }

        public async Task<SubmitRollbackShardingKeyModifyResponse> SubmitRollbackShardingKeyModifyAsync(SubmitRollbackShardingKeyModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitRollbackShardingKeyModifyWithOptionsAsync(request, runtime);
        }

        public SubmitSmoothExpandPreCheckResponse SubmitSmoothExpandPreCheckWithOptions(SubmitSmoothExpandPreCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitSmoothExpandPreCheckResponse>(DoRPCRequest("SubmitSmoothExpandPreCheck", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitSmoothExpandPreCheckResponse> SubmitSmoothExpandPreCheckWithOptionsAsync(SubmitSmoothExpandPreCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitSmoothExpandPreCheckResponse>(await DoRPCRequestAsync("SubmitSmoothExpandPreCheck", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitSmoothExpandPreCheckResponse SubmitSmoothExpandPreCheck(SubmitSmoothExpandPreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSmoothExpandPreCheckWithOptions(request, runtime);
        }

        public async Task<SubmitSmoothExpandPreCheckResponse> SubmitSmoothExpandPreCheckAsync(SubmitSmoothExpandPreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSmoothExpandPreCheckWithOptionsAsync(request, runtime);
        }

        public SubmitSmoothExpandPreCheckTaskResponse SubmitSmoothExpandPreCheckTaskWithOptions(SubmitSmoothExpandPreCheckTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitSmoothExpandPreCheckTaskResponse>(DoRPCRequest("SubmitSmoothExpandPreCheckTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitSmoothExpandPreCheckTaskResponse> SubmitSmoothExpandPreCheckTaskWithOptionsAsync(SubmitSmoothExpandPreCheckTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitSmoothExpandPreCheckTaskResponse>(await DoRPCRequestAsync("SubmitSmoothExpandPreCheckTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitSmoothExpandPreCheckTaskResponse SubmitSmoothExpandPreCheckTask(SubmitSmoothExpandPreCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSmoothExpandPreCheckTaskWithOptions(request, runtime);
        }

        public async Task<SubmitSmoothExpandPreCheckTaskResponse> SubmitSmoothExpandPreCheckTaskAsync(SubmitSmoothExpandPreCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSmoothExpandPreCheckTaskWithOptionsAsync(request, runtime);
        }

        public SubmitSmoothExpandTaskResponse SubmitSmoothExpandTaskWithOptions(SubmitSmoothExpandTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitSmoothExpandTaskResponse>(DoRPCRequest("SubmitSmoothExpandTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitSmoothExpandTaskResponse> SubmitSmoothExpandTaskWithOptionsAsync(SubmitSmoothExpandTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitSmoothExpandTaskResponse>(await DoRPCRequestAsync("SubmitSmoothExpandTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitSmoothExpandTaskResponse SubmitSmoothExpandTask(SubmitSmoothExpandTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSmoothExpandTaskWithOptions(request, runtime);
        }

        public async Task<SubmitSmoothExpandTaskResponse> SubmitSmoothExpandTaskAsync(SubmitSmoothExpandTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSmoothExpandTaskWithOptionsAsync(request, runtime);
        }

        public SubmitSqlFlashbackTaskResponse SubmitSqlFlashbackTaskWithOptions(SubmitSqlFlashbackTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitSqlFlashbackTaskResponse>(DoRPCRequest("SubmitSqlFlashbackTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitSqlFlashbackTaskResponse> SubmitSqlFlashbackTaskWithOptionsAsync(SubmitSqlFlashbackTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitSqlFlashbackTaskResponse>(await DoRPCRequestAsync("SubmitSqlFlashbackTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitSqlFlashbackTaskResponse SubmitSqlFlashbackTask(SubmitSqlFlashbackTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSqlFlashbackTaskWithOptions(request, runtime);
        }

        public async Task<SubmitSqlFlashbackTaskResponse> SubmitSqlFlashbackTaskAsync(SubmitSqlFlashbackTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSqlFlashbackTaskWithOptionsAsync(request, runtime);
        }

        public SubmitSwitchTableShardingKeyModifyResponse SubmitSwitchTableShardingKeyModifyWithOptions(SubmitSwitchTableShardingKeyModifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitSwitchTableShardingKeyModifyResponse>(DoRPCRequest("SubmitSwitchTableShardingKeyModify", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitSwitchTableShardingKeyModifyResponse> SubmitSwitchTableShardingKeyModifyWithOptionsAsync(SubmitSwitchTableShardingKeyModifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitSwitchTableShardingKeyModifyResponse>(await DoRPCRequestAsync("SubmitSwitchTableShardingKeyModify", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitSwitchTableShardingKeyModifyResponse SubmitSwitchTableShardingKeyModify(SubmitSwitchTableShardingKeyModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSwitchTableShardingKeyModifyWithOptions(request, runtime);
        }

        public async Task<SubmitSwitchTableShardingKeyModifyResponse> SubmitSwitchTableShardingKeyModifyAsync(SubmitSwitchTableShardingKeyModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSwitchTableShardingKeyModifyWithOptionsAsync(request, runtime);
        }

        public SubmitSwitchTaskResponse SubmitSwitchTaskWithOptions(SubmitSwitchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitSwitchTaskResponse>(DoRPCRequest("SubmitSwitchTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitSwitchTaskResponse> SubmitSwitchTaskWithOptionsAsync(SubmitSwitchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitSwitchTaskResponse>(await DoRPCRequestAsync("SubmitSwitchTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitSwitchTaskResponse SubmitSwitchTask(SubmitSwitchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSwitchTaskWithOptions(request, runtime);
        }

        public async Task<SubmitSwitchTaskResponse> SubmitSwitchTaskAsync(SubmitSwitchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSwitchTaskWithOptionsAsync(request, runtime);
        }

        public SubmitTableShardingKeyModifyResponse SubmitTableShardingKeyModifyWithOptions(SubmitTableShardingKeyModifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitTableShardingKeyModifyResponse>(DoRPCRequest("SubmitTableShardingKeyModify", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitTableShardingKeyModifyResponse> SubmitTableShardingKeyModifyWithOptionsAsync(SubmitTableShardingKeyModifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitTableShardingKeyModifyResponse>(await DoRPCRequestAsync("SubmitTableShardingKeyModify", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitTableShardingKeyModifyResponse SubmitTableShardingKeyModify(SubmitTableShardingKeyModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitTableShardingKeyModifyWithOptions(request, runtime);
        }

        public async Task<SubmitTableShardingKeyModifyResponse> SubmitTableShardingKeyModifyAsync(SubmitTableShardingKeyModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitTableShardingKeyModifyWithOptionsAsync(request, runtime);
        }

        public SwitchGlobalBroadcastTypeResponse SwitchGlobalBroadcastTypeWithOptions(SwitchGlobalBroadcastTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchGlobalBroadcastTypeResponse>(DoRPCRequest("SwitchGlobalBroadcastType", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SwitchGlobalBroadcastTypeResponse> SwitchGlobalBroadcastTypeWithOptionsAsync(SwitchGlobalBroadcastTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchGlobalBroadcastTypeResponse>(await DoRPCRequestAsync("SwitchGlobalBroadcastType", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SwitchGlobalBroadcastTypeResponse SwitchGlobalBroadcastType(SwitchGlobalBroadcastTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchGlobalBroadcastTypeWithOptions(request, runtime);
        }

        public async Task<SwitchGlobalBroadcastTypeResponse> SwitchGlobalBroadcastTypeAsync(SwitchGlobalBroadcastTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchGlobalBroadcastTypeWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UpdateInstanceNetworkResponse UpdateInstanceNetworkWithOptions(UpdateInstanceNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateInstanceNetworkResponse>(DoRPCRequest("UpdateInstanceNetwork", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateInstanceNetworkResponse> UpdateInstanceNetworkWithOptionsAsync(UpdateInstanceNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateInstanceNetworkResponse>(await DoRPCRequestAsync("UpdateInstanceNetwork", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateInstanceNetworkResponse UpdateInstanceNetwork(UpdateInstanceNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceNetworkWithOptions(request, runtime);
        }

        public async Task<UpdateInstanceNetworkResponse> UpdateInstanceNetworkAsync(UpdateInstanceNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceNetworkWithOptionsAsync(request, runtime);
        }

        public UpdatePrivateRdsClassResponse UpdatePrivateRdsClassWithOptions(UpdatePrivateRdsClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePrivateRdsClassResponse>(DoRPCRequest("UpdatePrivateRdsClass", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdatePrivateRdsClassResponse> UpdatePrivateRdsClassWithOptionsAsync(UpdatePrivateRdsClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePrivateRdsClassResponse>(await DoRPCRequestAsync("UpdatePrivateRdsClass", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdatePrivateRdsClassResponse UpdatePrivateRdsClass(UpdatePrivateRdsClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePrivateRdsClassWithOptions(request, runtime);
        }

        public async Task<UpdatePrivateRdsClassResponse> UpdatePrivateRdsClassAsync(UpdatePrivateRdsClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePrivateRdsClassWithOptionsAsync(request, runtime);
        }

        public UpdateResourceGroupAttributeResponse UpdateResourceGroupAttributeWithOptions(UpdateResourceGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateResourceGroupAttributeResponse>(DoRPCRequest("UpdateResourceGroupAttribute", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateResourceGroupAttributeResponse> UpdateResourceGroupAttributeWithOptionsAsync(UpdateResourceGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateResourceGroupAttributeResponse>(await DoRPCRequestAsync("UpdateResourceGroupAttribute", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateResourceGroupAttributeResponse UpdateResourceGroupAttribute(UpdateResourceGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateResourceGroupAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateResourceGroupAttributeResponse> UpdateResourceGroupAttributeAsync(UpdateResourceGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateResourceGroupAttributeWithOptionsAsync(request, runtime);
        }

        public UpgradeHiStoreInstanceResponse UpgradeHiStoreInstanceWithOptions(UpgradeHiStoreInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeHiStoreInstanceResponse>(DoRPCRequest("UpgradeHiStoreInstance", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeHiStoreInstanceResponse> UpgradeHiStoreInstanceWithOptionsAsync(UpgradeHiStoreInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeHiStoreInstanceResponse>(await DoRPCRequestAsync("UpgradeHiStoreInstance", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeHiStoreInstanceResponse UpgradeHiStoreInstance(UpgradeHiStoreInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeHiStoreInstanceWithOptions(request, runtime);
        }

        public async Task<UpgradeHiStoreInstanceResponse> UpgradeHiStoreInstanceAsync(UpgradeHiStoreInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeHiStoreInstanceWithOptionsAsync(request, runtime);
        }

        public UpgradeInstanceVersionResponse UpgradeInstanceVersionWithOptions(UpgradeInstanceVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeInstanceVersionResponse>(DoRPCRequest("UpgradeInstanceVersion", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeInstanceVersionResponse> UpgradeInstanceVersionWithOptionsAsync(UpgradeInstanceVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeInstanceVersionResponse>(await DoRPCRequestAsync("UpgradeInstanceVersion", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeInstanceVersionResponse UpgradeInstanceVersion(UpgradeInstanceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeInstanceVersionWithOptions(request, runtime);
        }

        public async Task<UpgradeInstanceVersionResponse> UpgradeInstanceVersionAsync(UpgradeInstanceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeInstanceVersionWithOptionsAsync(request, runtime);
        }

        public ValidateShardTaskResponse ValidateShardTaskWithOptions(ValidateShardTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ValidateShardTaskResponse>(DoRPCRequest("ValidateShardTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ValidateShardTaskResponse> ValidateShardTaskWithOptionsAsync(ValidateShardTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ValidateShardTaskResponse>(await DoRPCRequestAsync("ValidateShardTask", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ValidateShardTaskResponse ValidateShardTask(ValidateShardTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidateShardTaskWithOptions(request, runtime);
        }

        public async Task<ValidateShardTaskResponse> ValidateShardTaskAsync(ValidateShardTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidateShardTaskWithOptionsAsync(request, runtime);
        }

        public DescribeRdsInstInfosResponse DescribeRdsInstInfosWithOptions(DescribeRdsInstInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRdsInstInfosResponse>(DoRPCRequest("describeRdsInstInfos", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRdsInstInfosResponse> DescribeRdsInstInfosWithOptionsAsync(DescribeRdsInstInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRdsInstInfosResponse>(await DoRPCRequestAsync("describeRdsInstInfos", "2019-01-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRdsInstInfosResponse DescribeRdsInstInfos(DescribeRdsInstInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRdsInstInfosWithOptions(request, runtime);
        }

        public async Task<DescribeRdsInstInfosResponse> DescribeRdsInstInfosAsync(DescribeRdsInstInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRdsInstInfosWithOptionsAsync(request, runtime);
        }

    }
}
