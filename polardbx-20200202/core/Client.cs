// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Polardbx20200202.Models;

namespace AlibabaCloud.SDK.Polardbx20200202
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "polardbx.aliyuncs.com"},
                {"ap-northeast-2-pop", "polardbx.aliyuncs.com"},
                {"ap-south-1", "polardbx.aliyuncs.com"},
                {"ap-southeast-2", "polardbx.aliyuncs.com"},
                {"ap-southeast-3", "polardbx.aliyuncs.com"},
                {"ap-southeast-5", "polardbx.aliyuncs.com"},
                {"cn-beijing-finance-1", "polardbx.aliyuncs.com"},
                {"cn-beijing-finance-pop", "polardbx.aliyuncs.com"},
                {"cn-beijing-gov-1", "polardbx.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "polardbx.aliyuncs.com"},
                {"cn-edge-1", "polardbx.aliyuncs.com"},
                {"cn-fujian", "polardbx.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "polardbx.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "polardbx.aliyuncs.com"},
                {"cn-hangzhou-finance", "polardbx.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "polardbx.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "polardbx.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "polardbx.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "polardbx.aliyuncs.com"},
                {"cn-hangzhou-test-306", "polardbx.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "polardbx.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "polardbx.aliyuncs.com"},
                {"cn-north-2-gov-1", "polardbx.aliyuncs.com"},
                {"cn-qingdao-nebula", "polardbx.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "polardbx.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "polardbx.aliyuncs.com"},
                {"cn-shanghai-finance-1", "polardbx.aliyuncs.com"},
                {"cn-shanghai-inner", "polardbx.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "polardbx.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "polardbx.aliyuncs.com"},
                {"cn-shenzhen-inner", "polardbx.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "polardbx.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "polardbx.aliyuncs.com"},
                {"cn-wuhan", "polardbx.aliyuncs.com"},
                {"cn-wulanchabu", "polardbx.aliyuncs.com"},
                {"cn-yushanfang", "polardbx.aliyuncs.com"},
                {"cn-zhangbei", "polardbx.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "polardbx.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "polardbx.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "polardbx.aliyuncs.com"},
                {"eu-central-1", "polardbx.aliyuncs.com"},
                {"eu-west-1", "polardbx.aliyuncs.com"},
                {"eu-west-1-oxs", "polardbx.aliyuncs.com"},
                {"me-east-1", "polardbx.aliyuncs.com"},
                {"rus-west-1-pop", "polardbx.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("polardbx", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AllocateInstancePublicConnectionResponse AllocateInstancePublicConnectionWithOptions(AllocateInstancePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateInstancePublicConnectionResponse>(DoRPCRequest("AllocateInstancePublicConnection", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AllocateInstancePublicConnectionResponse> AllocateInstancePublicConnectionWithOptionsAsync(AllocateInstancePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateInstancePublicConnectionResponse>(await DoRPCRequestAsync("AllocateInstancePublicConnection", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CancelPolarxOrderResponse CancelPolarxOrderWithOptions(CancelPolarxOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelPolarxOrderResponse>(DoRPCRequest("CancelPolarxOrder", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelPolarxOrderResponse> CancelPolarxOrderWithOptionsAsync(CancelPolarxOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelPolarxOrderResponse>(await DoRPCRequestAsync("CancelPolarxOrder", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelPolarxOrderResponse CancelPolarxOrder(CancelPolarxOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelPolarxOrderWithOptions(request, runtime);
        }

        public async Task<CancelPolarxOrderResponse> CancelPolarxOrderAsync(CancelPolarxOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelPolarxOrderWithOptionsAsync(request, runtime);
        }

        public CheckCloudResourceAuthorizedResponse CheckCloudResourceAuthorizedWithOptions(CheckCloudResourceAuthorizedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckCloudResourceAuthorizedResponse>(DoRPCRequest("CheckCloudResourceAuthorized", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckCloudResourceAuthorizedResponse> CheckCloudResourceAuthorizedWithOptionsAsync(CheckCloudResourceAuthorizedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckCloudResourceAuthorizedResponse>(await DoRPCRequestAsync("CheckCloudResourceAuthorized", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckCloudResourceAuthorizedResponse CheckCloudResourceAuthorized(CheckCloudResourceAuthorizedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckCloudResourceAuthorizedWithOptions(request, runtime);
        }

        public async Task<CheckCloudResourceAuthorizedResponse> CheckCloudResourceAuthorizedAsync(CheckCloudResourceAuthorizedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckCloudResourceAuthorizedWithOptionsAsync(request, runtime);
        }

        public CreateAccountResponse CreateAccountWithOptions(CreateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAccountResponse>(DoRPCRequest("CreateAccount", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAccountResponse> CreateAccountWithOptionsAsync(CreateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAccountResponse>(await DoRPCRequestAsync("CreateAccount", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<CreateBackupResponse>(DoRPCRequest("CreateBackup", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateBackupResponse> CreateBackupWithOptionsAsync(CreateBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBackupResponse>(await DoRPCRequestAsync("CreateBackup", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateDBResponse CreateDBWithOptions(CreateDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBResponse>(DoRPCRequest("CreateDB", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDBResponse> CreateDBWithOptionsAsync(CreateDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBResponse>(await DoRPCRequestAsync("CreateDB", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDBResponse CreateDB(CreateDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDBWithOptions(request, runtime);
        }

        public async Task<CreateDBResponse> CreateDBAsync(CreateDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDBWithOptionsAsync(request, runtime);
        }

        public CreateDBInstanceResponse CreateDBInstanceWithOptions(CreateDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBInstanceResponse>(DoRPCRequest("CreateDBInstance", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDBInstanceResponse> CreateDBInstanceWithOptionsAsync(CreateDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBInstanceResponse>(await DoRPCRequestAsync("CreateDBInstance", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDBInstanceWithOptions(request, runtime);
        }

        public async Task<CreateDBInstanceResponse> CreateDBInstanceAsync(CreateDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDBInstanceWithOptionsAsync(request, runtime);
        }

        public CreatePolarxOrderResponse CreatePolarxOrderWithOptions(CreatePolarxOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePolarxOrderResponse>(DoRPCRequest("CreatePolarxOrder", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreatePolarxOrderResponse> CreatePolarxOrderWithOptionsAsync(CreatePolarxOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePolarxOrderResponse>(await DoRPCRequestAsync("CreatePolarxOrder", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreatePolarxOrderResponse CreatePolarxOrder(CreatePolarxOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePolarxOrderWithOptions(request, runtime);
        }

        public async Task<CreatePolarxOrderResponse> CreatePolarxOrderAsync(CreatePolarxOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePolarxOrderWithOptionsAsync(request, runtime);
        }

        public CreateSuperAccountResponse CreateSuperAccountWithOptions(CreateSuperAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSuperAccountResponse>(DoRPCRequest("CreateSuperAccount", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSuperAccountResponse> CreateSuperAccountWithOptionsAsync(CreateSuperAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSuperAccountResponse>(await DoRPCRequestAsync("CreateSuperAccount", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSuperAccountResponse CreateSuperAccount(CreateSuperAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSuperAccountWithOptions(request, runtime);
        }

        public async Task<CreateSuperAccountResponse> CreateSuperAccountAsync(CreateSuperAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSuperAccountWithOptionsAsync(request, runtime);
        }

        public DeleteAccountResponse DeleteAccountWithOptions(DeleteAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAccountResponse>(DoRPCRequest("DeleteAccount", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAccountResponse> DeleteAccountWithOptionsAsync(DeleteAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAccountResponse>(await DoRPCRequestAsync("DeleteAccount", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteDBResponse DeleteDBWithOptions(DeleteDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDBResponse>(DoRPCRequest("DeleteDB", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDBResponse> DeleteDBWithOptionsAsync(DeleteDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDBResponse>(await DoRPCRequestAsync("DeleteDB", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDBResponse DeleteDB(DeleteDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDBWithOptions(request, runtime);
        }

        public async Task<DeleteDBResponse> DeleteDBAsync(DeleteDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDBWithOptionsAsync(request, runtime);
        }

        public DeleteDBInstanceResponse DeleteDBInstanceWithOptions(DeleteDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDBInstanceResponse>(DoRPCRequest("DeleteDBInstance", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDBInstanceResponse> DeleteDBInstanceWithOptionsAsync(DeleteDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDBInstanceResponse>(await DoRPCRequestAsync("DeleteDBInstance", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDBInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteDBInstanceResponse> DeleteDBInstanceAsync(DeleteDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDBInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeAccountListResponse DescribeAccountListWithOptions(DescribeAccountListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccountListResponse>(DoRPCRequest("DescribeAccountList", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAccountListResponse> DescribeAccountListWithOptionsAsync(DescribeAccountListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccountListResponse>(await DoRPCRequestAsync("DescribeAccountList", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAccountListResponse DescribeAccountList(DescribeAccountListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccountListWithOptions(request, runtime);
        }

        public async Task<DescribeAccountListResponse> DescribeAccountListAsync(DescribeAccountListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccountListWithOptionsAsync(request, runtime);
        }

        public DescribeBackupPolicyResponse DescribeBackupPolicyWithOptions(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPolicyResponse>(DoRPCRequest("DescribeBackupPolicy", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupPolicyResponse> DescribeBackupPolicyWithOptionsAsync(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPolicyResponse>(await DoRPCRequestAsync("DescribeBackupPolicy", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeBackupSetListResponse DescribeBackupSetListWithOptions(DescribeBackupSetListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeBackupSetListResponse>(DoRPCRequest("DescribeBackupSetList", "2020-02-02", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupSetListResponse> DescribeBackupSetListWithOptionsAsync(DescribeBackupSetListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeBackupSetListResponse>(await DoRPCRequestAsync("DescribeBackupSetList", "2020-02-02", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeBackupSetListResponse DescribeBackupSetList(DescribeBackupSetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupSetListWithOptions(request, runtime);
        }

        public async Task<DescribeBackupSetListResponse> DescribeBackupSetListAsync(DescribeBackupSetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupSetListWithOptionsAsync(request, runtime);
        }

        public DescribeBinaryLogListResponse DescribeBinaryLogListWithOptions(DescribeBinaryLogListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBinaryLogListResponse>(DoRPCRequest("DescribeBinaryLogList", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBinaryLogListResponse> DescribeBinaryLogListWithOptionsAsync(DescribeBinaryLogListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBinaryLogListResponse>(await DoRPCRequestAsync("DescribeBinaryLogList", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBinaryLogListResponse DescribeBinaryLogList(DescribeBinaryLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBinaryLogListWithOptions(request, runtime);
        }

        public async Task<DescribeBinaryLogListResponse> DescribeBinaryLogListAsync(DescribeBinaryLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBinaryLogListWithOptionsAsync(request, runtime);
        }

        public DescribeCharacterSetResponse DescribeCharacterSetWithOptions(DescribeCharacterSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCharacterSetResponse>(DoRPCRequest("DescribeCharacterSet", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCharacterSetResponse> DescribeCharacterSetWithOptionsAsync(DescribeCharacterSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCharacterSetResponse>(await DoRPCRequestAsync("DescribeCharacterSet", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCharacterSetResponse DescribeCharacterSet(DescribeCharacterSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCharacterSetWithOptions(request, runtime);
        }

        public async Task<DescribeCharacterSetResponse> DescribeCharacterSetAsync(DescribeCharacterSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCharacterSetWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceAttributeResponse DescribeDBInstanceAttributeWithOptions(DescribeDBInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceAttributeResponse>(DoRPCRequest("DescribeDBInstanceAttribute", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstanceAttributeResponse> DescribeDBInstanceAttributeWithOptionsAsync(DescribeDBInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceAttributeResponse>(await DoRPCRequestAsync("DescribeDBInstanceAttribute", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstanceAttributeResponse DescribeDBInstanceAttribute(DescribeDBInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceAttributeResponse> DescribeDBInstanceAttributeAsync(DescribeDBInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceConfigResponse DescribeDBInstanceConfigWithOptions(DescribeDBInstanceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceConfigResponse>(DoRPCRequest("DescribeDBInstanceConfig", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstanceConfigResponse> DescribeDBInstanceConfigWithOptionsAsync(DescribeDBInstanceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceConfigResponse>(await DoRPCRequestAsync("DescribeDBInstanceConfig", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstanceConfigResponse DescribeDBInstanceConfig(DescribeDBInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceConfigWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceConfigResponse> DescribeDBInstanceConfigAsync(DescribeDBInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceConfigWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceSSLResponse DescribeDBInstanceSSLWithOptions(DescribeDBInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceSSLResponse>(DoRPCRequest("DescribeDBInstanceSSL", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstanceSSLResponse> DescribeDBInstanceSSLWithOptionsAsync(DescribeDBInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceSSLResponse>(await DoRPCRequestAsync("DescribeDBInstanceSSL", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstanceSSLResponse DescribeDBInstanceSSL(DescribeDBInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceSSLWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceSSLResponse> DescribeDBInstanceSSLAsync(DescribeDBInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceSSLWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceTDEResponse DescribeDBInstanceTDEWithOptions(DescribeDBInstanceTDERequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceTDEResponse>(DoRPCRequest("DescribeDBInstanceTDE", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstanceTDEResponse> DescribeDBInstanceTDEWithOptionsAsync(DescribeDBInstanceTDERequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceTDEResponse>(await DoRPCRequestAsync("DescribeDBInstanceTDE", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstanceTDEResponse DescribeDBInstanceTDE(DescribeDBInstanceTDERequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceTDEWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceTDEResponse> DescribeDBInstanceTDEAsync(DescribeDBInstanceTDERequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceTDEWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceTopologyResponse DescribeDBInstanceTopologyWithOptions(DescribeDBInstanceTopologyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceTopologyResponse>(DoRPCRequest("DescribeDBInstanceTopology", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstanceTopologyResponse> DescribeDBInstanceTopologyWithOptionsAsync(DescribeDBInstanceTopologyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceTopologyResponse>(await DoRPCRequestAsync("DescribeDBInstanceTopology", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstanceTopologyResponse DescribeDBInstanceTopology(DescribeDBInstanceTopologyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceTopologyWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceTopologyResponse> DescribeDBInstanceTopologyAsync(DescribeDBInstanceTopologyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceTopologyWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstancesResponse DescribeDBInstancesWithOptions(DescribeDBInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstancesResponse>(DoRPCRequest("DescribeDBInstances", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstancesResponse> DescribeDBInstancesWithOptionsAsync(DescribeDBInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstancesResponse>(await DoRPCRequestAsync("DescribeDBInstances", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(DescribeDBInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeDBNodePerformanceResponse DescribeDBNodePerformanceWithOptions(DescribeDBNodePerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBNodePerformanceResponse>(DoRPCRequest("DescribeDBNodePerformance", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBNodePerformanceResponse> DescribeDBNodePerformanceWithOptionsAsync(DescribeDBNodePerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBNodePerformanceResponse>(await DoRPCRequestAsync("DescribeDBNodePerformance", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDbListResponse DescribeDbListWithOptions(DescribeDbListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDbListResponse>(DoRPCRequest("DescribeDbList", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDbListResponse> DescribeDbListWithOptionsAsync(DescribeDbListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDbListResponse>(await DoRPCRequestAsync("DescribeDbList", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDbListResponse DescribeDbList(DescribeDbListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDbListWithOptions(request, runtime);
        }

        public async Task<DescribeDbListResponse> DescribeDbListAsync(DescribeDbListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDbListWithOptionsAsync(request, runtime);
        }

        public DescribeDistributeTableListResponse DescribeDistributeTableListWithOptions(DescribeDistributeTableListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDistributeTableListResponse>(DoRPCRequest("DescribeDistributeTableList", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDistributeTableListResponse> DescribeDistributeTableListWithOptionsAsync(DescribeDistributeTableListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDistributeTableListResponse>(await DoRPCRequestAsync("DescribeDistributeTableList", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDistributeTableListResponse DescribeDistributeTableList(DescribeDistributeTableListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDistributeTableListWithOptions(request, runtime);
        }

        public async Task<DescribeDistributeTableListResponse> DescribeDistributeTableListAsync(DescribeDistributeTableListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDistributeTableListWithOptionsAsync(request, runtime);
        }

        public DescribeParameterTemplatesResponse DescribeParameterTemplatesWithOptions(DescribeParameterTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParameterTemplatesResponse>(DoRPCRequest("DescribeParameterTemplates", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeParameterTemplatesResponse> DescribeParameterTemplatesWithOptionsAsync(DescribeParameterTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParameterTemplatesResponse>(await DoRPCRequestAsync("DescribeParameterTemplates", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeParametersResponse DescribeParametersWithOptions(DescribeParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParametersResponse>(DoRPCRequest("DescribeParameters", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeParametersResponse> DescribeParametersWithOptionsAsync(DescribeParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParametersResponse>(await DoRPCRequestAsync("DescribeParameters", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribePolarxDataNodesResponse DescribePolarxDataNodesWithOptions(DescribePolarxDataNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePolarxDataNodesResponse>(DoRPCRequest("DescribePolarxDataNodes", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePolarxDataNodesResponse> DescribePolarxDataNodesWithOptionsAsync(DescribePolarxDataNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePolarxDataNodesResponse>(await DoRPCRequestAsync("DescribePolarxDataNodes", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePolarxDataNodesResponse DescribePolarxDataNodes(DescribePolarxDataNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePolarxDataNodesWithOptions(request, runtime);
        }

        public async Task<DescribePolarxDataNodesResponse> DescribePolarxDataNodesAsync(DescribePolarxDataNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePolarxDataNodesWithOptionsAsync(request, runtime);
        }

        public DescribePolarxDbInstancesResponse DescribePolarxDbInstancesWithOptions(DescribePolarxDbInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePolarxDbInstancesResponse>(DoRPCRequest("DescribePolarxDbInstances", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePolarxDbInstancesResponse> DescribePolarxDbInstancesWithOptionsAsync(DescribePolarxDbInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePolarxDbInstancesResponse>(await DoRPCRequestAsync("DescribePolarxDbInstances", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePolarxDbInstancesResponse DescribePolarxDbInstances(DescribePolarxDbInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePolarxDbInstancesWithOptions(request, runtime);
        }

        public async Task<DescribePolarxDbInstancesResponse> DescribePolarxDbInstancesAsync(DescribePolarxDbInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePolarxDbInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(runtime);
        }

        public DescribeScaleOutMigrateTaskListResponse DescribeScaleOutMigrateTaskListWithOptions(DescribeScaleOutMigrateTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScaleOutMigrateTaskListResponse>(DoRPCRequest("DescribeScaleOutMigrateTaskList", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScaleOutMigrateTaskListResponse> DescribeScaleOutMigrateTaskListWithOptionsAsync(DescribeScaleOutMigrateTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScaleOutMigrateTaskListResponse>(await DoRPCRequestAsync("DescribeScaleOutMigrateTaskList", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScaleOutMigrateTaskListResponse DescribeScaleOutMigrateTaskList(DescribeScaleOutMigrateTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScaleOutMigrateTaskListWithOptions(request, runtime);
        }

        public async Task<DescribeScaleOutMigrateTaskListResponse> DescribeScaleOutMigrateTaskListAsync(DescribeScaleOutMigrateTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScaleOutMigrateTaskListWithOptionsAsync(request, runtime);
        }

        public DescribeSecurityIpsResponse DescribeSecurityIpsWithOptions(DescribeSecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityIpsResponse>(DoRPCRequest("DescribeSecurityIps", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSecurityIpsResponse> DescribeSecurityIpsWithOptionsAsync(DescribeSecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityIpsResponse>(await DoRPCRequestAsync("DescribeSecurityIps", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeTableDetailResponse DescribeTableDetailWithOptions(DescribeTableDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTableDetailResponse>(DoRPCRequest("DescribeTableDetail", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTableDetailResponse> DescribeTableDetailWithOptionsAsync(DescribeTableDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTableDetailResponse>(await DoRPCRequestAsync("DescribeTableDetail", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTableDetailResponse DescribeTableDetail(DescribeTableDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTableDetailWithOptions(request, runtime);
        }

        public async Task<DescribeTableDetailResponse> DescribeTableDetailAsync(DescribeTableDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTableDetailWithOptionsAsync(request, runtime);
        }

        public DescribeTasksResponse DescribeTasksWithOptions(DescribeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTasksResponse>(DoRPCRequest("DescribeTasks", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTasksResponse> DescribeTasksWithOptionsAsync(DescribeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTasksResponse>(await DoRPCRequestAsync("DescribeTasks", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeUserEncryptionKeyListResponse DescribeUserEncryptionKeyListWithOptions(DescribeUserEncryptionKeyListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserEncryptionKeyListResponse>(DoRPCRequest("DescribeUserEncryptionKeyList", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserEncryptionKeyListResponse> DescribeUserEncryptionKeyListWithOptionsAsync(DescribeUserEncryptionKeyListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserEncryptionKeyListResponse>(await DoRPCRequestAsync("DescribeUserEncryptionKeyList", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserEncryptionKeyListResponse DescribeUserEncryptionKeyList(DescribeUserEncryptionKeyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserEncryptionKeyListWithOptions(request, runtime);
        }

        public async Task<DescribeUserEncryptionKeyListResponse> DescribeUserEncryptionKeyListAsync(DescribeUserEncryptionKeyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserEncryptionKeyListWithOptionsAsync(request, runtime);
        }

        public DisableRightsSeparationResponse DisableRightsSeparationWithOptions(DisableRightsSeparationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableRightsSeparationResponse>(DoRPCRequest("DisableRightsSeparation", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableRightsSeparationResponse> DisableRightsSeparationWithOptionsAsync(DisableRightsSeparationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableRightsSeparationResponse>(await DoRPCRequestAsync("DisableRightsSeparation", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableRightsSeparationResponse DisableRightsSeparation(DisableRightsSeparationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableRightsSeparationWithOptions(request, runtime);
        }

        public async Task<DisableRightsSeparationResponse> DisableRightsSeparationAsync(DisableRightsSeparationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableRightsSeparationWithOptionsAsync(request, runtime);
        }

        public EnableRightsSeparationResponse EnableRightsSeparationWithOptions(EnableRightsSeparationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableRightsSeparationResponse>(DoRPCRequest("EnableRightsSeparation", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableRightsSeparationResponse> EnableRightsSeparationWithOptionsAsync(EnableRightsSeparationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableRightsSeparationResponse>(await DoRPCRequestAsync("EnableRightsSeparation", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableRightsSeparationResponse EnableRightsSeparation(EnableRightsSeparationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableRightsSeparationWithOptions(request, runtime);
        }

        public async Task<EnableRightsSeparationResponse> EnableRightsSeparationAsync(EnableRightsSeparationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableRightsSeparationWithOptionsAsync(request, runtime);
        }

        public GetPolarxCommodityResponse GetPolarxCommodityWithOptions(GetPolarxCommodityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPolarxCommodityResponse>(DoRPCRequest("GetPolarxCommodity", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPolarxCommodityResponse> GetPolarxCommodityWithOptionsAsync(GetPolarxCommodityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPolarxCommodityResponse>(await DoRPCRequestAsync("GetPolarxCommodity", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPolarxCommodityResponse GetPolarxCommodity(GetPolarxCommodityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPolarxCommodityWithOptions(request, runtime);
        }

        public async Task<GetPolarxCommodityResponse> GetPolarxCommodityAsync(GetPolarxCommodityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPolarxCommodityWithOptionsAsync(request, runtime);
        }

        public ModifyAccountDescriptionResponse ModifyAccountDescriptionWithOptions(ModifyAccountDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccountDescriptionResponse>(DoRPCRequest("ModifyAccountDescription", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAccountDescriptionResponse> ModifyAccountDescriptionWithOptionsAsync(ModifyAccountDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccountDescriptionResponse>(await DoRPCRequestAsync("ModifyAccountDescription", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<ModifyAccountPrivilegeResponse>(DoRPCRequest("ModifyAccountPrivilege", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAccountPrivilegeResponse> ModifyAccountPrivilegeWithOptionsAsync(ModifyAccountPrivilegeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccountPrivilegeResponse>(await DoRPCRequestAsync("ModifyAccountPrivilege", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyDBInstanceClassResponse ModifyDBInstanceClassWithOptions(ModifyDBInstanceClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceClassResponse>(DoRPCRequest("ModifyDBInstanceClass", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstanceClassResponse> ModifyDBInstanceClassWithOptionsAsync(ModifyDBInstanceClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceClassResponse>(await DoRPCRequestAsync("ModifyDBInstanceClass", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBInstanceClassResponse ModifyDBInstanceClass(ModifyDBInstanceClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceClassWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceClassResponse> ModifyDBInstanceClassAsync(ModifyDBInstanceClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceClassWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceConfigResponse ModifyDBInstanceConfigWithOptions(ModifyDBInstanceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceConfigResponse>(DoRPCRequest("ModifyDBInstanceConfig", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstanceConfigResponse> ModifyDBInstanceConfigWithOptionsAsync(ModifyDBInstanceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceConfigResponse>(await DoRPCRequestAsync("ModifyDBInstanceConfig", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBInstanceConfigResponse ModifyDBInstanceConfig(ModifyDBInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceConfigWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceConfigResponse> ModifyDBInstanceConfigAsync(ModifyDBInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceConfigWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceDescriptionResponse ModifyDBInstanceDescriptionWithOptions(ModifyDBInstanceDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceDescriptionResponse>(DoRPCRequest("ModifyDBInstanceDescription", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstanceDescriptionResponse> ModifyDBInstanceDescriptionWithOptionsAsync(ModifyDBInstanceDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceDescriptionResponse>(await DoRPCRequestAsync("ModifyDBInstanceDescription", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBInstanceDescriptionResponse ModifyDBInstanceDescription(ModifyDBInstanceDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceDescriptionWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceDescriptionResponse> ModifyDBInstanceDescriptionAsync(ModifyDBInstanceDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceDescriptionWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceMaintainTimeResponse ModifyDBInstanceMaintainTimeWithOptions(ModifyDBInstanceMaintainTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceMaintainTimeResponse>(DoRPCRequest("ModifyDBInstanceMaintainTime", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstanceMaintainTimeResponse> ModifyDBInstanceMaintainTimeWithOptionsAsync(ModifyDBInstanceMaintainTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceMaintainTimeResponse>(await DoRPCRequestAsync("ModifyDBInstanceMaintainTime", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBInstanceMaintainTimeResponse ModifyDBInstanceMaintainTime(ModifyDBInstanceMaintainTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceMaintainTimeWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceMaintainTimeResponse> ModifyDBInstanceMaintainTimeAsync(ModifyDBInstanceMaintainTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceMaintainTimeWithOptionsAsync(request, runtime);
        }

        public ModifyDatabaseDescriptionResponse ModifyDatabaseDescriptionWithOptions(ModifyDatabaseDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDatabaseDescriptionResponse>(DoRPCRequest("ModifyDatabaseDescription", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDatabaseDescriptionResponse> ModifyDatabaseDescriptionWithOptionsAsync(ModifyDatabaseDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDatabaseDescriptionResponse>(await DoRPCRequestAsync("ModifyDatabaseDescription", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDatabaseDescriptionResponse ModifyDatabaseDescription(ModifyDatabaseDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDatabaseDescriptionWithOptions(request, runtime);
        }

        public async Task<ModifyDatabaseDescriptionResponse> ModifyDatabaseDescriptionAsync(ModifyDatabaseDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDatabaseDescriptionWithOptionsAsync(request, runtime);
        }

        public ModifyParameterResponse ModifyParameterWithOptions(ModifyParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyParameterResponse>(DoRPCRequest("ModifyParameter", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyParameterResponse> ModifyParameterWithOptionsAsync(ModifyParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyParameterResponse>(await DoRPCRequestAsync("ModifyParameter", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifySecurityIpsResponse ModifySecurityIpsWithOptions(ModifySecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySecurityIpsResponse>(DoRPCRequest("ModifySecurityIps", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySecurityIpsResponse> ModifySecurityIpsWithOptionsAsync(ModifySecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySecurityIpsResponse>(await DoRPCRequestAsync("ModifySecurityIps", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ReleaseInstancePublicConnectionResponse ReleaseInstancePublicConnectionWithOptions(ReleaseInstancePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseInstancePublicConnectionResponse>(DoRPCRequest("ReleaseInstancePublicConnection", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseInstancePublicConnectionResponse> ReleaseInstancePublicConnectionWithOptionsAsync(ReleaseInstancePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseInstancePublicConnectionResponse>(await DoRPCRequestAsync("ReleaseInstancePublicConnection", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ResetAccountPasswordResponse ResetAccountPasswordWithOptions(ResetAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetAccountPasswordResponse>(DoRPCRequest("ResetAccountPassword", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetAccountPasswordResponse> ResetAccountPasswordWithOptionsAsync(ResetAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetAccountPasswordResponse>(await DoRPCRequestAsync("ResetAccountPassword", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public RestartDBInstanceResponse RestartDBInstanceWithOptions(RestartDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartDBInstanceResponse>(DoRPCRequest("RestartDBInstance", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestartDBInstanceResponse> RestartDBInstanceWithOptionsAsync(RestartDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartDBInstanceResponse>(await DoRPCRequestAsync("RestartDBInstance", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RestartDBInstanceResponse RestartDBInstance(RestartDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartDBInstanceWithOptions(request, runtime);
        }

        public async Task<RestartDBInstanceResponse> RestartDBInstanceAsync(RestartDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartDBInstanceWithOptionsAsync(request, runtime);
        }

        public UpdateBackupPolicyResponse UpdateBackupPolicyWithOptions(UpdateBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateBackupPolicyResponse>(DoRPCRequest("UpdateBackupPolicy", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateBackupPolicyResponse> UpdateBackupPolicyWithOptionsAsync(UpdateBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateBackupPolicyResponse>(await DoRPCRequestAsync("UpdateBackupPolicy", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateBackupPolicyResponse UpdateBackupPolicy(UpdateBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBackupPolicyWithOptions(request, runtime);
        }

        public async Task<UpdateBackupPolicyResponse> UpdateBackupPolicyAsync(UpdateBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBackupPolicyWithOptionsAsync(request, runtime);
        }

        public UpdateDBInstanceSSLResponse UpdateDBInstanceSSLWithOptions(UpdateDBInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDBInstanceSSLResponse>(DoRPCRequest("UpdateDBInstanceSSL", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDBInstanceSSLResponse> UpdateDBInstanceSSLWithOptionsAsync(UpdateDBInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDBInstanceSSLResponse>(await DoRPCRequestAsync("UpdateDBInstanceSSL", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDBInstanceSSLResponse UpdateDBInstanceSSL(UpdateDBInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDBInstanceSSLWithOptions(request, runtime);
        }

        public async Task<UpdateDBInstanceSSLResponse> UpdateDBInstanceSSLAsync(UpdateDBInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDBInstanceSSLWithOptionsAsync(request, runtime);
        }

        public UpdateDBInstanceTDEResponse UpdateDBInstanceTDEWithOptions(UpdateDBInstanceTDERequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDBInstanceTDEResponse>(DoRPCRequest("UpdateDBInstanceTDE", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDBInstanceTDEResponse> UpdateDBInstanceTDEWithOptionsAsync(UpdateDBInstanceTDERequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDBInstanceTDEResponse>(await DoRPCRequestAsync("UpdateDBInstanceTDE", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDBInstanceTDEResponse UpdateDBInstanceTDE(UpdateDBInstanceTDERequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDBInstanceTDEWithOptions(request, runtime);
        }

        public async Task<UpdateDBInstanceTDEResponse> UpdateDBInstanceTDEAsync(UpdateDBInstanceTDERequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDBInstanceTDEWithOptionsAsync(request, runtime);
        }

        public UpdatePolarDBXInstanceNodeResponse UpdatePolarDBXInstanceNodeWithOptions(UpdatePolarDBXInstanceNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePolarDBXInstanceNodeResponse>(DoRPCRequest("UpdatePolarDBXInstanceNode", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdatePolarDBXInstanceNodeResponse> UpdatePolarDBXInstanceNodeWithOptionsAsync(UpdatePolarDBXInstanceNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePolarDBXInstanceNodeResponse>(await DoRPCRequestAsync("UpdatePolarDBXInstanceNode", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdatePolarDBXInstanceNodeResponse UpdatePolarDBXInstanceNode(UpdatePolarDBXInstanceNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePolarDBXInstanceNodeWithOptions(request, runtime);
        }

        public async Task<UpdatePolarDBXInstanceNodeResponse> UpdatePolarDBXInstanceNodeAsync(UpdatePolarDBXInstanceNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePolarDBXInstanceNodeWithOptionsAsync(request, runtime);
        }

        public UpgradeDBInstanceKernelVersionResponse UpgradeDBInstanceKernelVersionWithOptions(UpgradeDBInstanceKernelVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeDBInstanceKernelVersionResponse>(DoRPCRequest("UpgradeDBInstanceKernelVersion", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeDBInstanceKernelVersionResponse> UpgradeDBInstanceKernelVersionWithOptionsAsync(UpgradeDBInstanceKernelVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeDBInstanceKernelVersionResponse>(await DoRPCRequestAsync("UpgradeDBInstanceKernelVersion", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeDBInstanceKernelVersionResponse UpgradeDBInstanceKernelVersion(UpgradeDBInstanceKernelVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeDBInstanceKernelVersionWithOptions(request, runtime);
        }

        public async Task<UpgradeDBInstanceKernelVersionResponse> UpgradeDBInstanceKernelVersionAsync(UpgradeDBInstanceKernelVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeDBInstanceKernelVersionWithOptionsAsync(request, runtime);
        }

    }
}
