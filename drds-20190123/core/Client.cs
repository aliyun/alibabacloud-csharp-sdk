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

    }
}
