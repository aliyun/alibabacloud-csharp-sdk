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
                {"cn-heyuan", "rds.aliyuncs.com"},
                {"cn-hongkong", "rds.aliyuncs.com"},
                {"ap-southeast-1", "rds.aliyuncs.com"},
                {"us-west-1", "rds.aliyuncs.com"},
                {"us-east-1", "rds.aliyuncs.com"},
                {"cn-shanghai-finance-1", "rds.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "rds.aliyuncs.com"},
                {"cn-north-2-gov-1", "rds.aliyuncs.com"},
                {"ap-northeast-2-pop", "rds.aliyuncs.com"},
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
                {"cn-zhangbei", "rds.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "rds.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "rds.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "rds.aliyuncs.com"},
                {"eu-west-1-oxs", "rds.aliyuncs.com"},
                {"rus-west-1-pop", "rds.aliyuncs.com"},
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

        public AddTagsToResourceResponse AddTagsToResourceWithOptions(AddTagsToResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddTagsToResourceResponse>(DoRPCRequest("AddTagsToResource", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddTagsToResourceResponse> AddTagsToResourceWithOptionsAsync(AddTagsToResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddTagsToResourceResponse>(await DoRPCRequestAsync("AddTagsToResource", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTagsToResourceWithOptions(request, runtime);
        }

        public async Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTagsToResourceWithOptionsAsync(request, runtime);
        }

        public AllocateInstancePublicConnectionResponse AllocateInstancePublicConnectionWithOptions(AllocateInstancePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateInstancePublicConnectionResponse>(DoRPCRequest("AllocateInstancePublicConnection", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AllocateInstancePublicConnectionResponse> AllocateInstancePublicConnectionWithOptionsAsync(AllocateInstancePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateInstancePublicConnectionResponse>(await DoRPCRequestAsync("AllocateInstancePublicConnection", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public AllocateReadWriteSplittingConnectionResponse AllocateReadWriteSplittingConnectionWithOptions(AllocateReadWriteSplittingConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateReadWriteSplittingConnectionResponse>(DoRPCRequest("AllocateReadWriteSplittingConnection", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AllocateReadWriteSplittingConnectionResponse> AllocateReadWriteSplittingConnectionWithOptionsAsync(AllocateReadWriteSplittingConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateReadWriteSplittingConnectionResponse>(await DoRPCRequestAsync("AllocateReadWriteSplittingConnection", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AllocateReadWriteSplittingConnectionResponse AllocateReadWriteSplittingConnection(AllocateReadWriteSplittingConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateReadWriteSplittingConnectionWithOptions(request, runtime);
        }

        public async Task<AllocateReadWriteSplittingConnectionResponse> AllocateReadWriteSplittingConnectionAsync(AllocateReadWriteSplittingConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateReadWriteSplittingConnectionWithOptionsAsync(request, runtime);
        }

        public CalculateDBInstanceWeightResponse CalculateDBInstanceWeightWithOptions(CalculateDBInstanceWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CalculateDBInstanceWeightResponse>(DoRPCRequest("CalculateDBInstanceWeight", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CalculateDBInstanceWeightResponse> CalculateDBInstanceWeightWithOptionsAsync(CalculateDBInstanceWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CalculateDBInstanceWeightResponse>(await DoRPCRequestAsync("CalculateDBInstanceWeight", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CalculateDBInstanceWeightResponse CalculateDBInstanceWeight(CalculateDBInstanceWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CalculateDBInstanceWeightWithOptions(request, runtime);
        }

        public async Task<CalculateDBInstanceWeightResponse> CalculateDBInstanceWeightAsync(CalculateDBInstanceWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CalculateDBInstanceWeightWithOptionsAsync(request, runtime);
        }

        public CancelImportResponse CancelImportWithOptions(CancelImportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelImportResponse>(DoRPCRequest("CancelImport", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelImportResponse> CancelImportWithOptionsAsync(CancelImportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelImportResponse>(await DoRPCRequestAsync("CancelImport", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelImportResponse CancelImport(CancelImportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelImportWithOptions(request, runtime);
        }

        public async Task<CancelImportResponse> CancelImportAsync(CancelImportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelImportWithOptionsAsync(request, runtime);
        }

        public CheckAccountNameAvailableResponse CheckAccountNameAvailableWithOptions(CheckAccountNameAvailableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckAccountNameAvailableResponse>(DoRPCRequest("CheckAccountNameAvailable", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckAccountNameAvailableResponse> CheckAccountNameAvailableWithOptionsAsync(CheckAccountNameAvailableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckAccountNameAvailableResponse>(await DoRPCRequestAsync("CheckAccountNameAvailable", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckAccountNameAvailableResponse CheckAccountNameAvailable(CheckAccountNameAvailableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckAccountNameAvailableWithOptions(request, runtime);
        }

        public async Task<CheckAccountNameAvailableResponse> CheckAccountNameAvailableAsync(CheckAccountNameAvailableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckAccountNameAvailableWithOptionsAsync(request, runtime);
        }

        public CheckCloudResourceAuthorizedResponse CheckCloudResourceAuthorizedWithOptions(CheckCloudResourceAuthorizedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckCloudResourceAuthorizedResponse>(DoRPCRequest("CheckCloudResourceAuthorized", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckCloudResourceAuthorizedResponse> CheckCloudResourceAuthorizedWithOptionsAsync(CheckCloudResourceAuthorizedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckCloudResourceAuthorizedResponse>(await DoRPCRequestAsync("CheckCloudResourceAuthorized", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CheckCreateDdrDBInstanceResponse CheckCreateDdrDBInstanceWithOptions(CheckCreateDdrDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckCreateDdrDBInstanceResponse>(DoRPCRequest("CheckCreateDdrDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckCreateDdrDBInstanceResponse> CheckCreateDdrDBInstanceWithOptionsAsync(CheckCreateDdrDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckCreateDdrDBInstanceResponse>(await DoRPCRequestAsync("CheckCreateDdrDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckCreateDdrDBInstanceResponse CheckCreateDdrDBInstance(CheckCreateDdrDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckCreateDdrDBInstanceWithOptions(request, runtime);
        }

        public async Task<CheckCreateDdrDBInstanceResponse> CheckCreateDdrDBInstanceAsync(CheckCreateDdrDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckCreateDdrDBInstanceWithOptionsAsync(request, runtime);
        }

        public CheckDBNameAvailableResponse CheckDBNameAvailableWithOptions(CheckDBNameAvailableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckDBNameAvailableResponse>(DoRPCRequest("CheckDBNameAvailable", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckDBNameAvailableResponse> CheckDBNameAvailableWithOptionsAsync(CheckDBNameAvailableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckDBNameAvailableResponse>(await DoRPCRequestAsync("CheckDBNameAvailable", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckDBNameAvailableResponse CheckDBNameAvailable(CheckDBNameAvailableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDBNameAvailableWithOptions(request, runtime);
        }

        public async Task<CheckDBNameAvailableResponse> CheckDBNameAvailableAsync(CheckDBNameAvailableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDBNameAvailableWithOptionsAsync(request, runtime);
        }

        public CheckInstanceExistResponse CheckInstanceExistWithOptions(CheckInstanceExistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckInstanceExistResponse>(DoRPCRequest("CheckInstanceExist", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckInstanceExistResponse> CheckInstanceExistWithOptionsAsync(CheckInstanceExistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckInstanceExistResponse>(await DoRPCRequestAsync("CheckInstanceExist", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckInstanceExistResponse CheckInstanceExist(CheckInstanceExistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckInstanceExistWithOptions(request, runtime);
        }

        public async Task<CheckInstanceExistResponse> CheckInstanceExistAsync(CheckInstanceExistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckInstanceExistWithOptionsAsync(request, runtime);
        }

        public ClearDedicatedHostResponse ClearDedicatedHostWithOptions(ClearDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ClearDedicatedHostResponse>(DoRPCRequest("ClearDedicatedHost", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ClearDedicatedHostResponse> ClearDedicatedHostWithOptionsAsync(ClearDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ClearDedicatedHostResponse>(await DoRPCRequestAsync("ClearDedicatedHost", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ClearDedicatedHostResponse ClearDedicatedHost(ClearDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClearDedicatedHostWithOptions(request, runtime);
        }

        public async Task<ClearDedicatedHostResponse> ClearDedicatedHostAsync(ClearDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClearDedicatedHostWithOptionsAsync(request, runtime);
        }

        public CloneDBInstanceResponse CloneDBInstanceWithOptions(CloneDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloneDBInstanceResponse>(DoRPCRequest("CloneDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CloneDBInstanceResponse> CloneDBInstanceWithOptionsAsync(CloneDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloneDBInstanceResponse>(await DoRPCRequestAsync("CloneDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CloneDBInstanceResponse CloneDBInstance(CloneDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloneDBInstanceWithOptions(request, runtime);
        }

        public async Task<CloneDBInstanceResponse> CloneDBInstanceAsync(CloneDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloneDBInstanceWithOptionsAsync(request, runtime);
        }

        public CloneParameterGroupResponse CloneParameterGroupWithOptions(CloneParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloneParameterGroupResponse>(DoRPCRequest("CloneParameterGroup", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CloneParameterGroupResponse> CloneParameterGroupWithOptionsAsync(CloneParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloneParameterGroupResponse>(await DoRPCRequestAsync("CloneParameterGroup", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CloneParameterGroupResponse CloneParameterGroup(CloneParameterGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloneParameterGroupWithOptions(request, runtime);
        }

        public async Task<CloneParameterGroupResponse> CloneParameterGroupAsync(CloneParameterGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloneParameterGroupWithOptionsAsync(request, runtime);
        }

        public CopyDatabaseResponse CopyDatabaseWithOptions(CopyDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CopyDatabaseResponse>(DoRPCRequest("CopyDatabase", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CopyDatabaseResponse> CopyDatabaseWithOptionsAsync(CopyDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CopyDatabaseResponse>(await DoRPCRequestAsync("CopyDatabase", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CopyDatabaseResponse CopyDatabase(CopyDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyDatabaseWithOptions(request, runtime);
        }

        public async Task<CopyDatabaseResponse> CopyDatabaseAsync(CopyDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyDatabaseWithOptionsAsync(request, runtime);
        }

        public CopyDatabaseBetweenInstancesResponse CopyDatabaseBetweenInstancesWithOptions(CopyDatabaseBetweenInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CopyDatabaseBetweenInstancesResponse>(DoRPCRequest("CopyDatabaseBetweenInstances", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CopyDatabaseBetweenInstancesResponse> CopyDatabaseBetweenInstancesWithOptionsAsync(CopyDatabaseBetweenInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CopyDatabaseBetweenInstancesResponse>(await DoRPCRequestAsync("CopyDatabaseBetweenInstances", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CopyDatabaseBetweenInstancesResponse CopyDatabaseBetweenInstances(CopyDatabaseBetweenInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyDatabaseBetweenInstancesWithOptions(request, runtime);
        }

        public async Task<CopyDatabaseBetweenInstancesResponse> CopyDatabaseBetweenInstancesAsync(CopyDatabaseBetweenInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyDatabaseBetweenInstancesWithOptionsAsync(request, runtime);
        }

        public CreateAccountResponse CreateAccountWithOptions(CreateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAccountResponse>(DoRPCRequest("CreateAccount", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAccountResponse> CreateAccountWithOptionsAsync(CreateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAccountResponse>(await DoRPCRequestAsync("CreateAccount", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<CreateBackupResponse>(DoRPCRequest("CreateBackup", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateBackupResponse> CreateBackupWithOptionsAsync(CreateBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBackupResponse>(await DoRPCRequestAsync("CreateBackup", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<CreateDatabaseResponse>(DoRPCRequest("CreateDatabase", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDatabaseResponse> CreateDatabaseWithOptionsAsync(CreateDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDatabaseResponse>(await DoRPCRequestAsync("CreateDatabase", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateDBInstanceResponse CreateDBInstanceWithOptions(CreateDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBInstanceResponse>(DoRPCRequest("CreateDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDBInstanceResponse> CreateDBInstanceWithOptionsAsync(CreateDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBInstanceResponse>(await DoRPCRequestAsync("CreateDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateDBProxyEndpointAddressResponse CreateDBProxyEndpointAddressWithOptions(CreateDBProxyEndpointAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBProxyEndpointAddressResponse>(DoRPCRequest("CreateDBProxyEndpointAddress", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDBProxyEndpointAddressResponse> CreateDBProxyEndpointAddressWithOptionsAsync(CreateDBProxyEndpointAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBProxyEndpointAddressResponse>(await DoRPCRequestAsync("CreateDBProxyEndpointAddress", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDBProxyEndpointAddressResponse CreateDBProxyEndpointAddress(CreateDBProxyEndpointAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDBProxyEndpointAddressWithOptions(request, runtime);
        }

        public async Task<CreateDBProxyEndpointAddressResponse> CreateDBProxyEndpointAddressAsync(CreateDBProxyEndpointAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDBProxyEndpointAddressWithOptionsAsync(request, runtime);
        }

        public CreateDdrInstanceResponse CreateDdrInstanceWithOptions(CreateDdrInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDdrInstanceResponse>(DoRPCRequest("CreateDdrInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDdrInstanceResponse> CreateDdrInstanceWithOptionsAsync(CreateDdrInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDdrInstanceResponse>(await DoRPCRequestAsync("CreateDdrInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDdrInstanceResponse CreateDdrInstance(CreateDdrInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDdrInstanceWithOptions(request, runtime);
        }

        public async Task<CreateDdrInstanceResponse> CreateDdrInstanceAsync(CreateDdrInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDdrInstanceWithOptionsAsync(request, runtime);
        }

        public CreateDedicatedHostResponse CreateDedicatedHostWithOptions(CreateDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDedicatedHostResponse>(DoRPCRequest("CreateDedicatedHost", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDedicatedHostResponse> CreateDedicatedHostWithOptionsAsync(CreateDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDedicatedHostResponse>(await DoRPCRequestAsync("CreateDedicatedHost", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDedicatedHostResponse CreateDedicatedHost(CreateDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDedicatedHostWithOptions(request, runtime);
        }

        public async Task<CreateDedicatedHostResponse> CreateDedicatedHostAsync(CreateDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDedicatedHostWithOptionsAsync(request, runtime);
        }

        public CreateDedicatedHostAccountResponse CreateDedicatedHostAccountWithOptions(CreateDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDedicatedHostAccountResponse>(DoRPCRequest("CreateDedicatedHostAccount", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDedicatedHostAccountResponse> CreateDedicatedHostAccountWithOptionsAsync(CreateDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDedicatedHostAccountResponse>(await DoRPCRequestAsync("CreateDedicatedHostAccount", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDedicatedHostAccountResponse CreateDedicatedHostAccount(CreateDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDedicatedHostAccountWithOptions(request, runtime);
        }

        public async Task<CreateDedicatedHostAccountResponse> CreateDedicatedHostAccountAsync(CreateDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDedicatedHostAccountWithOptionsAsync(request, runtime);
        }

        public CreateDedicatedHostGroupResponse CreateDedicatedHostGroupWithOptions(CreateDedicatedHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDedicatedHostGroupResponse>(DoRPCRequest("CreateDedicatedHostGroup", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDedicatedHostGroupResponse> CreateDedicatedHostGroupWithOptionsAsync(CreateDedicatedHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDedicatedHostGroupResponse>(await DoRPCRequestAsync("CreateDedicatedHostGroup", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDedicatedHostGroupResponse CreateDedicatedHostGroup(CreateDedicatedHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDedicatedHostGroupWithOptions(request, runtime);
        }

        public async Task<CreateDedicatedHostGroupResponse> CreateDedicatedHostGroupAsync(CreateDedicatedHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDedicatedHostGroupWithOptionsAsync(request, runtime);
        }

        public CreateDedicatedHostUserResponse CreateDedicatedHostUserWithOptions(CreateDedicatedHostUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDedicatedHostUserResponse>(DoRPCRequest("CreateDedicatedHostUser", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDedicatedHostUserResponse> CreateDedicatedHostUserWithOptionsAsync(CreateDedicatedHostUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDedicatedHostUserResponse>(await DoRPCRequestAsync("CreateDedicatedHostUser", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDedicatedHostUserResponse CreateDedicatedHostUser(CreateDedicatedHostUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDedicatedHostUserWithOptions(request, runtime);
        }

        public async Task<CreateDedicatedHostUserResponse> CreateDedicatedHostUserAsync(CreateDedicatedHostUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDedicatedHostUserWithOptionsAsync(request, runtime);
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

        public CreateMigrateTaskResponse CreateMigrateTaskWithOptions(CreateMigrateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMigrateTaskResponse>(DoRPCRequest("CreateMigrateTask", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMigrateTaskResponse> CreateMigrateTaskWithOptionsAsync(CreateMigrateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMigrateTaskResponse>(await DoRPCRequestAsync("CreateMigrateTask", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMigrateTaskResponse CreateMigrateTask(CreateMigrateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMigrateTaskWithOptions(request, runtime);
        }

        public async Task<CreateMigrateTaskResponse> CreateMigrateTaskAsync(CreateMigrateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMigrateTaskWithOptionsAsync(request, runtime);
        }

        public CreateMigrateTaskForSQLServerResponse CreateMigrateTaskForSQLServerWithOptions(CreateMigrateTaskForSQLServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMigrateTaskForSQLServerResponse>(DoRPCRequest("CreateMigrateTaskForSQLServer", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMigrateTaskForSQLServerResponse> CreateMigrateTaskForSQLServerWithOptionsAsync(CreateMigrateTaskForSQLServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMigrateTaskForSQLServerResponse>(await DoRPCRequestAsync("CreateMigrateTaskForSQLServer", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMigrateTaskForSQLServerResponse CreateMigrateTaskForSQLServer(CreateMigrateTaskForSQLServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMigrateTaskForSQLServerWithOptions(request, runtime);
        }

        public async Task<CreateMigrateTaskForSQLServerResponse> CreateMigrateTaskForSQLServerAsync(CreateMigrateTaskForSQLServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMigrateTaskForSQLServerWithOptionsAsync(request, runtime);
        }

        public CreateOnlineDatabaseTaskResponse CreateOnlineDatabaseTaskWithOptions(CreateOnlineDatabaseTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateOnlineDatabaseTaskResponse>(DoRPCRequest("CreateOnlineDatabaseTask", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateOnlineDatabaseTaskResponse> CreateOnlineDatabaseTaskWithOptionsAsync(CreateOnlineDatabaseTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateOnlineDatabaseTaskResponse>(await DoRPCRequestAsync("CreateOnlineDatabaseTask", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateOnlineDatabaseTaskResponse CreateOnlineDatabaseTask(CreateOnlineDatabaseTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOnlineDatabaseTaskWithOptions(request, runtime);
        }

        public async Task<CreateOnlineDatabaseTaskResponse> CreateOnlineDatabaseTaskAsync(CreateOnlineDatabaseTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOnlineDatabaseTaskWithOptionsAsync(request, runtime);
        }

        public CreateParameterGroupResponse CreateParameterGroupWithOptions(CreateParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateParameterGroupResponse>(DoRPCRequest("CreateParameterGroup", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateParameterGroupResponse> CreateParameterGroupWithOptionsAsync(CreateParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateParameterGroupResponse>(await DoRPCRequestAsync("CreateParameterGroup", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateReadOnlyDBInstanceResponse CreateReadOnlyDBInstanceWithOptions(CreateReadOnlyDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateReadOnlyDBInstanceResponse>(DoRPCRequest("CreateReadOnlyDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateReadOnlyDBInstanceResponse> CreateReadOnlyDBInstanceWithOptionsAsync(CreateReadOnlyDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateReadOnlyDBInstanceResponse>(await DoRPCRequestAsync("CreateReadOnlyDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateReadOnlyDBInstanceResponse CreateReadOnlyDBInstance(CreateReadOnlyDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateReadOnlyDBInstanceWithOptions(request, runtime);
        }

        public async Task<CreateReadOnlyDBInstanceResponse> CreateReadOnlyDBInstanceAsync(CreateReadOnlyDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateReadOnlyDBInstanceWithOptionsAsync(request, runtime);
        }

        public CreateTempDBInstanceResponse CreateTempDBInstanceWithOptions(CreateTempDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTempDBInstanceResponse>(DoRPCRequest("CreateTempDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateTempDBInstanceResponse> CreateTempDBInstanceWithOptionsAsync(CreateTempDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTempDBInstanceResponse>(await DoRPCRequestAsync("CreateTempDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateTempDBInstanceResponse CreateTempDBInstance(CreateTempDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTempDBInstanceWithOptions(request, runtime);
        }

        public async Task<CreateTempDBInstanceResponse> CreateTempDBInstanceAsync(CreateTempDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTempDBInstanceWithOptionsAsync(request, runtime);
        }

        public DeleteAccountResponse DeleteAccountWithOptions(DeleteAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAccountResponse>(DoRPCRequest("DeleteAccount", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAccountResponse> DeleteAccountWithOptionsAsync(DeleteAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAccountResponse>(await DoRPCRequestAsync("DeleteAccount", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteBackupResponse>(DoRPCRequest("DeleteBackup", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteBackupResponse> DeleteBackupWithOptionsAsync(DeleteBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBackupResponse>(await DoRPCRequestAsync("DeleteBackup", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteBackupFileResponse DeleteBackupFileWithOptions(DeleteBackupFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBackupFileResponse>(DoRPCRequest("DeleteBackupFile", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteBackupFileResponse> DeleteBackupFileWithOptionsAsync(DeleteBackupFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBackupFileResponse>(await DoRPCRequestAsync("DeleteBackupFile", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteBackupFileResponse DeleteBackupFile(DeleteBackupFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBackupFileWithOptions(request, runtime);
        }

        public async Task<DeleteBackupFileResponse> DeleteBackupFileAsync(DeleteBackupFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBackupFileWithOptionsAsync(request, runtime);
        }

        public DeleteDatabaseResponse DeleteDatabaseWithOptions(DeleteDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDatabaseResponse>(DoRPCRequest("DeleteDatabase", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDatabaseResponse> DeleteDatabaseWithOptionsAsync(DeleteDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDatabaseResponse>(await DoRPCRequestAsync("DeleteDatabase", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteDBInstanceResponse DeleteDBInstanceWithOptions(DeleteDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDBInstanceResponse>(DoRPCRequest("DeleteDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDBInstanceResponse> DeleteDBInstanceWithOptionsAsync(DeleteDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDBInstanceResponse>(await DoRPCRequestAsync("DeleteDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteDBProxyEndpointAddressResponse DeleteDBProxyEndpointAddressWithOptions(DeleteDBProxyEndpointAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDBProxyEndpointAddressResponse>(DoRPCRequest("DeleteDBProxyEndpointAddress", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDBProxyEndpointAddressResponse> DeleteDBProxyEndpointAddressWithOptionsAsync(DeleteDBProxyEndpointAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDBProxyEndpointAddressResponse>(await DoRPCRequestAsync("DeleteDBProxyEndpointAddress", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDBProxyEndpointAddressResponse DeleteDBProxyEndpointAddress(DeleteDBProxyEndpointAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDBProxyEndpointAddressWithOptions(request, runtime);
        }

        public async Task<DeleteDBProxyEndpointAddressResponse> DeleteDBProxyEndpointAddressAsync(DeleteDBProxyEndpointAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDBProxyEndpointAddressWithOptionsAsync(request, runtime);
        }

        public DeleteDedicatedHostAccountResponse DeleteDedicatedHostAccountWithOptions(DeleteDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDedicatedHostAccountResponse>(DoRPCRequest("DeleteDedicatedHostAccount", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDedicatedHostAccountResponse> DeleteDedicatedHostAccountWithOptionsAsync(DeleteDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDedicatedHostAccountResponse>(await DoRPCRequestAsync("DeleteDedicatedHostAccount", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDedicatedHostAccountResponse DeleteDedicatedHostAccount(DeleteDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDedicatedHostAccountWithOptions(request, runtime);
        }

        public async Task<DeleteDedicatedHostAccountResponse> DeleteDedicatedHostAccountAsync(DeleteDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDedicatedHostAccountWithOptionsAsync(request, runtime);
        }

        public DeleteDedicatedHostGroupResponse DeleteDedicatedHostGroupWithOptions(DeleteDedicatedHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDedicatedHostGroupResponse>(DoRPCRequest("DeleteDedicatedHostGroup", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDedicatedHostGroupResponse> DeleteDedicatedHostGroupWithOptionsAsync(DeleteDedicatedHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDedicatedHostGroupResponse>(await DoRPCRequestAsync("DeleteDedicatedHostGroup", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDedicatedHostGroupResponse DeleteDedicatedHostGroup(DeleteDedicatedHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDedicatedHostGroupWithOptions(request, runtime);
        }

        public async Task<DeleteDedicatedHostGroupResponse> DeleteDedicatedHostGroupAsync(DeleteDedicatedHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDedicatedHostGroupWithOptionsAsync(request, runtime);
        }

        public DeleteParameterGroupResponse DeleteParameterGroupWithOptions(DeleteParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteParameterGroupResponse>(DoRPCRequest("DeleteParameterGroup", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteParameterGroupResponse> DeleteParameterGroupWithOptionsAsync(DeleteParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteParameterGroupResponse>(await DoRPCRequestAsync("DeleteParameterGroup", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescibeImportsFromDatabaseResponse DescibeImportsFromDatabaseWithOptions(DescibeImportsFromDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescibeImportsFromDatabaseResponse>(DoRPCRequest("DescibeImportsFromDatabase", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescibeImportsFromDatabaseResponse> DescibeImportsFromDatabaseWithOptionsAsync(DescibeImportsFromDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescibeImportsFromDatabaseResponse>(await DoRPCRequestAsync("DescibeImportsFromDatabase", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescibeImportsFromDatabaseResponse DescibeImportsFromDatabase(DescibeImportsFromDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescibeImportsFromDatabaseWithOptions(request, runtime);
        }

        public async Task<DescibeImportsFromDatabaseResponse> DescibeImportsFromDatabaseAsync(DescibeImportsFromDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescibeImportsFromDatabaseWithOptionsAsync(request, runtime);
        }

        public DescribeAccountsResponse DescribeAccountsWithOptions(DescribeAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccountsResponse>(DoRPCRequest("DescribeAccounts", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAccountsResponse> DescribeAccountsWithOptionsAsync(DescribeAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccountsResponse>(await DoRPCRequestAsync("DescribeAccounts", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeActionEventPolicyResponse DescribeActionEventPolicyWithOptions(DescribeActionEventPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeActionEventPolicyResponse>(DoRPCRequest("DescribeActionEventPolicy", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeActionEventPolicyResponse> DescribeActionEventPolicyWithOptionsAsync(DescribeActionEventPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeActionEventPolicyResponse>(await DoRPCRequestAsync("DescribeActionEventPolicy", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeActionEventPolicyResponse DescribeActionEventPolicy(DescribeActionEventPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeActionEventPolicyWithOptions(request, runtime);
        }

        public async Task<DescribeActionEventPolicyResponse> DescribeActionEventPolicyAsync(DescribeActionEventPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeActionEventPolicyWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableClassesResponse DescribeAvailableClassesWithOptions(DescribeAvailableClassesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableClassesResponse>(DoRPCRequest("DescribeAvailableClasses", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAvailableClassesResponse> DescribeAvailableClassesWithOptionsAsync(DescribeAvailableClassesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableClassesResponse>(await DoRPCRequestAsync("DescribeAvailableClasses", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAvailableClassesResponse DescribeAvailableClasses(DescribeAvailableClassesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableClassesWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableClassesResponse> DescribeAvailableClassesAsync(DescribeAvailableClassesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableClassesWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableCrossRegionResponse DescribeAvailableCrossRegionWithOptions(DescribeAvailableCrossRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableCrossRegionResponse>(DoRPCRequest("DescribeAvailableCrossRegion", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAvailableCrossRegionResponse> DescribeAvailableCrossRegionWithOptionsAsync(DescribeAvailableCrossRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableCrossRegionResponse>(await DoRPCRequestAsync("DescribeAvailableCrossRegion", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAvailableCrossRegionResponse DescribeAvailableCrossRegion(DescribeAvailableCrossRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableCrossRegionWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableCrossRegionResponse> DescribeAvailableCrossRegionAsync(DescribeAvailableCrossRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableCrossRegionWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableDedicatedHostClassesResponse DescribeAvailableDedicatedHostClassesWithOptions(DescribeAvailableDedicatedHostClassesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableDedicatedHostClassesResponse>(DoRPCRequest("DescribeAvailableDedicatedHostClasses", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAvailableDedicatedHostClassesResponse> DescribeAvailableDedicatedHostClassesWithOptionsAsync(DescribeAvailableDedicatedHostClassesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableDedicatedHostClassesResponse>(await DoRPCRequestAsync("DescribeAvailableDedicatedHostClasses", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAvailableDedicatedHostClassesResponse DescribeAvailableDedicatedHostClasses(DescribeAvailableDedicatedHostClassesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableDedicatedHostClassesWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableDedicatedHostClassesResponse> DescribeAvailableDedicatedHostClassesAsync(DescribeAvailableDedicatedHostClassesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableDedicatedHostClassesWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableDedicatedHostZonesResponse DescribeAvailableDedicatedHostZonesWithOptions(DescribeAvailableDedicatedHostZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableDedicatedHostZonesResponse>(DoRPCRequest("DescribeAvailableDedicatedHostZones", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAvailableDedicatedHostZonesResponse> DescribeAvailableDedicatedHostZonesWithOptionsAsync(DescribeAvailableDedicatedHostZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableDedicatedHostZonesResponse>(await DoRPCRequestAsync("DescribeAvailableDedicatedHostZones", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAvailableDedicatedHostZonesResponse DescribeAvailableDedicatedHostZones(DescribeAvailableDedicatedHostZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableDedicatedHostZonesWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableDedicatedHostZonesResponse> DescribeAvailableDedicatedHostZonesAsync(DescribeAvailableDedicatedHostZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableDedicatedHostZonesWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableRecoveryTimeResponse DescribeAvailableRecoveryTimeWithOptions(DescribeAvailableRecoveryTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableRecoveryTimeResponse>(DoRPCRequest("DescribeAvailableRecoveryTime", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAvailableRecoveryTimeResponse> DescribeAvailableRecoveryTimeWithOptionsAsync(DescribeAvailableRecoveryTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableRecoveryTimeResponse>(await DoRPCRequestAsync("DescribeAvailableRecoveryTime", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAvailableRecoveryTimeResponse DescribeAvailableRecoveryTime(DescribeAvailableRecoveryTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableRecoveryTimeWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableRecoveryTimeResponse> DescribeAvailableRecoveryTimeAsync(DescribeAvailableRecoveryTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableRecoveryTimeWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableResourceResponse DescribeAvailableResourceWithOptions(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(DoRPCRequest("DescribeAvailableResource", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceWithOptionsAsync(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(await DoRPCRequestAsync("DescribeAvailableResource", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeAvailableZonesResponse DescribeAvailableZonesWithOptions(DescribeAvailableZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableZonesResponse>(DoRPCRequest("DescribeAvailableZones", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAvailableZonesResponse> DescribeAvailableZonesWithOptionsAsync(DescribeAvailableZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableZonesResponse>(await DoRPCRequestAsync("DescribeAvailableZones", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAvailableZonesResponse DescribeAvailableZones(DescribeAvailableZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableZonesWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableZonesResponse> DescribeAvailableZonesAsync(DescribeAvailableZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableZonesWithOptionsAsync(request, runtime);
        }

        public DescribeBackupDatabaseResponse DescribeBackupDatabaseWithOptions(DescribeBackupDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupDatabaseResponse>(DoRPCRequest("DescribeBackupDatabase", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupDatabaseResponse> DescribeBackupDatabaseWithOptionsAsync(DescribeBackupDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupDatabaseResponse>(await DoRPCRequestAsync("DescribeBackupDatabase", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackupDatabaseResponse DescribeBackupDatabase(DescribeBackupDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupDatabaseWithOptions(request, runtime);
        }

        public async Task<DescribeBackupDatabaseResponse> DescribeBackupDatabaseAsync(DescribeBackupDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupDatabaseWithOptionsAsync(request, runtime);
        }

        public DescribeBackupPolicyResponse DescribeBackupPolicyWithOptions(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPolicyResponse>(DoRPCRequest("DescribeBackupPolicy", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupPolicyResponse> DescribeBackupPolicyWithOptionsAsync(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupPolicyResponse>(await DoRPCRequestAsync("DescribeBackupPolicy", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeBackupsResponse>(DoRPCRequest("DescribeBackups", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupsResponse> DescribeBackupsWithOptionsAsync(DescribeBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupsResponse>(await DoRPCRequestAsync("DescribeBackups", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeBackupTasksResponse>(DoRPCRequest("DescribeBackupTasks", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackupTasksResponse> DescribeBackupTasksWithOptionsAsync(DescribeBackupTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackupTasksResponse>(await DoRPCRequestAsync("DescribeBackupTasks", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeBinlogFilesResponse DescribeBinlogFilesWithOptions(DescribeBinlogFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBinlogFilesResponse>(DoRPCRequest("DescribeBinlogFiles", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBinlogFilesResponse> DescribeBinlogFilesWithOptionsAsync(DescribeBinlogFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBinlogFilesResponse>(await DoRPCRequestAsync("DescribeBinlogFiles", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBinlogFilesResponse DescribeBinlogFiles(DescribeBinlogFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBinlogFilesWithOptions(request, runtime);
        }

        public async Task<DescribeBinlogFilesResponse> DescribeBinlogFilesAsync(DescribeBinlogFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBinlogFilesWithOptionsAsync(request, runtime);
        }

        public DescribeCharacterSetNameResponse DescribeCharacterSetNameWithOptions(DescribeCharacterSetNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCharacterSetNameResponse>(DoRPCRequest("DescribeCharacterSetName", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCharacterSetNameResponse> DescribeCharacterSetNameWithOptionsAsync(DescribeCharacterSetNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCharacterSetNameResponse>(await DoRPCRequestAsync("DescribeCharacterSetName", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeCollationTimeZonesResponse DescribeCollationTimeZonesWithOptions(DescribeCollationTimeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCollationTimeZonesResponse>(DoRPCRequest("DescribeCollationTimeZones", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCollationTimeZonesResponse> DescribeCollationTimeZonesWithOptionsAsync(DescribeCollationTimeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCollationTimeZonesResponse>(await DoRPCRequestAsync("DescribeCollationTimeZones", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCollationTimeZonesResponse DescribeCollationTimeZones(DescribeCollationTimeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCollationTimeZonesWithOptions(request, runtime);
        }

        public async Task<DescribeCollationTimeZonesResponse> DescribeCollationTimeZonesAsync(DescribeCollationTimeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCollationTimeZonesWithOptionsAsync(request, runtime);
        }

        public DescribeCrossBackupMetaListResponse DescribeCrossBackupMetaListWithOptions(DescribeCrossBackupMetaListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCrossBackupMetaListResponse>(DoRPCRequest("DescribeCrossBackupMetaList", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCrossBackupMetaListResponse> DescribeCrossBackupMetaListWithOptionsAsync(DescribeCrossBackupMetaListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCrossBackupMetaListResponse>(await DoRPCRequestAsync("DescribeCrossBackupMetaList", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCrossBackupMetaListResponse DescribeCrossBackupMetaList(DescribeCrossBackupMetaListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCrossBackupMetaListWithOptions(request, runtime);
        }

        public async Task<DescribeCrossBackupMetaListResponse> DescribeCrossBackupMetaListAsync(DescribeCrossBackupMetaListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCrossBackupMetaListWithOptionsAsync(request, runtime);
        }

        public DescribeCrossRegionBackupDBInstanceResponse DescribeCrossRegionBackupDBInstanceWithOptions(DescribeCrossRegionBackupDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCrossRegionBackupDBInstanceResponse>(DoRPCRequest("DescribeCrossRegionBackupDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCrossRegionBackupDBInstanceResponse> DescribeCrossRegionBackupDBInstanceWithOptionsAsync(DescribeCrossRegionBackupDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCrossRegionBackupDBInstanceResponse>(await DoRPCRequestAsync("DescribeCrossRegionBackupDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCrossRegionBackupDBInstanceResponse DescribeCrossRegionBackupDBInstance(DescribeCrossRegionBackupDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCrossRegionBackupDBInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeCrossRegionBackupDBInstanceResponse> DescribeCrossRegionBackupDBInstanceAsync(DescribeCrossRegionBackupDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCrossRegionBackupDBInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeCrossRegionBackupsResponse DescribeCrossRegionBackupsWithOptions(DescribeCrossRegionBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCrossRegionBackupsResponse>(DoRPCRequest("DescribeCrossRegionBackups", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCrossRegionBackupsResponse> DescribeCrossRegionBackupsWithOptionsAsync(DescribeCrossRegionBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCrossRegionBackupsResponse>(await DoRPCRequestAsync("DescribeCrossRegionBackups", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCrossRegionBackupsResponse DescribeCrossRegionBackups(DescribeCrossRegionBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCrossRegionBackupsWithOptions(request, runtime);
        }

        public async Task<DescribeCrossRegionBackupsResponse> DescribeCrossRegionBackupsAsync(DescribeCrossRegionBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCrossRegionBackupsWithOptionsAsync(request, runtime);
        }

        public DescribeCrossRegionLogBackupFilesResponse DescribeCrossRegionLogBackupFilesWithOptions(DescribeCrossRegionLogBackupFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCrossRegionLogBackupFilesResponse>(DoRPCRequest("DescribeCrossRegionLogBackupFiles", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCrossRegionLogBackupFilesResponse> DescribeCrossRegionLogBackupFilesWithOptionsAsync(DescribeCrossRegionLogBackupFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCrossRegionLogBackupFilesResponse>(await DoRPCRequestAsync("DescribeCrossRegionLogBackupFiles", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCrossRegionLogBackupFilesResponse DescribeCrossRegionLogBackupFiles(DescribeCrossRegionLogBackupFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCrossRegionLogBackupFilesWithOptions(request, runtime);
        }

        public async Task<DescribeCrossRegionLogBackupFilesResponse> DescribeCrossRegionLogBackupFilesAsync(DescribeCrossRegionLogBackupFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCrossRegionLogBackupFilesWithOptionsAsync(request, runtime);
        }

        public DescribeDatabasesResponse DescribeDatabasesWithOptions(DescribeDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDatabasesResponse>(DoRPCRequest("DescribeDatabases", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDatabasesResponse> DescribeDatabasesWithOptionsAsync(DescribeDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDatabasesResponse>(await DoRPCRequestAsync("DescribeDatabases", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDBInstanceAttributeResponse DescribeDBInstanceAttributeWithOptions(DescribeDBInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceAttributeResponse>(DoRPCRequest("DescribeDBInstanceAttribute", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstanceAttributeResponse> DescribeDBInstanceAttributeWithOptionsAsync(DescribeDBInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceAttributeResponse>(await DoRPCRequestAsync("DescribeDBInstanceAttribute", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDBInstanceDetailResponse DescribeDBInstanceDetailWithOptions(DescribeDBInstanceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceDetailResponse>(DoRPCRequest("DescribeDBInstanceDetail", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstanceDetailResponse> DescribeDBInstanceDetailWithOptionsAsync(DescribeDBInstanceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceDetailResponse>(await DoRPCRequestAsync("DescribeDBInstanceDetail", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstanceDetailResponse DescribeDBInstanceDetail(DescribeDBInstanceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceDetailWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceDetailResponse> DescribeDBInstanceDetailAsync(DescribeDBInstanceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceDetailWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceHAConfigResponse DescribeDBInstanceHAConfigWithOptions(DescribeDBInstanceHAConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceHAConfigResponse>(DoRPCRequest("DescribeDBInstanceHAConfig", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstanceHAConfigResponse> DescribeDBInstanceHAConfigWithOptionsAsync(DescribeDBInstanceHAConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceHAConfigResponse>(await DoRPCRequestAsync("DescribeDBInstanceHAConfig", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstanceHAConfigResponse DescribeDBInstanceHAConfig(DescribeDBInstanceHAConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceHAConfigWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceHAConfigResponse> DescribeDBInstanceHAConfigAsync(DescribeDBInstanceHAConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceHAConfigWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceIPArrayListResponse DescribeDBInstanceIPArrayListWithOptions(DescribeDBInstanceIPArrayListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceIPArrayListResponse>(DoRPCRequest("DescribeDBInstanceIPArrayList", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstanceIPArrayListResponse> DescribeDBInstanceIPArrayListWithOptionsAsync(DescribeDBInstanceIPArrayListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceIPArrayListResponse>(await DoRPCRequestAsync("DescribeDBInstanceIPArrayList", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstanceIPArrayListResponse DescribeDBInstanceIPArrayList(DescribeDBInstanceIPArrayListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceIPArrayListWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceIPArrayListResponse> DescribeDBInstanceIPArrayListAsync(DescribeDBInstanceIPArrayListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceIPArrayListWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceIpHostnameResponse DescribeDBInstanceIpHostnameWithOptions(DescribeDBInstanceIpHostnameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceIpHostnameResponse>(DoRPCRequest("DescribeDBInstanceIpHostname", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstanceIpHostnameResponse> DescribeDBInstanceIpHostnameWithOptionsAsync(DescribeDBInstanceIpHostnameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceIpHostnameResponse>(await DoRPCRequestAsync("DescribeDBInstanceIpHostname", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstanceIpHostnameResponse DescribeDBInstanceIpHostname(DescribeDBInstanceIpHostnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceIpHostnameWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceIpHostnameResponse> DescribeDBInstanceIpHostnameAsync(DescribeDBInstanceIpHostnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceIpHostnameWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceMonitorResponse DescribeDBInstanceMonitorWithOptions(DescribeDBInstanceMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceMonitorResponse>(DoRPCRequest("DescribeDBInstanceMonitor", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstanceMonitorResponse> DescribeDBInstanceMonitorWithOptionsAsync(DescribeDBInstanceMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceMonitorResponse>(await DoRPCRequestAsync("DescribeDBInstanceMonitor", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstanceMonitorResponse DescribeDBInstanceMonitor(DescribeDBInstanceMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceMonitorWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceMonitorResponse> DescribeDBInstanceMonitorAsync(DescribeDBInstanceMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceMonitorWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceNetInfoResponse DescribeDBInstanceNetInfoWithOptions(DescribeDBInstanceNetInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceNetInfoResponse>(DoRPCRequest("DescribeDBInstanceNetInfo", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstanceNetInfoResponse> DescribeDBInstanceNetInfoWithOptionsAsync(DescribeDBInstanceNetInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceNetInfoResponse>(await DoRPCRequestAsync("DescribeDBInstanceNetInfo", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDBInstancePerformanceResponse DescribeDBInstancePerformanceWithOptions(DescribeDBInstancePerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstancePerformanceResponse>(DoRPCRequest("DescribeDBInstancePerformance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstancePerformanceResponse> DescribeDBInstancePerformanceWithOptionsAsync(DescribeDBInstancePerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstancePerformanceResponse>(await DoRPCRequestAsync("DescribeDBInstancePerformance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstancePerformanceResponse DescribeDBInstancePerformance(DescribeDBInstancePerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstancePerformanceWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstancePerformanceResponse> DescribeDBInstancePerformanceAsync(DescribeDBInstancePerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstancePerformanceWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceProxyConfigurationResponse DescribeDBInstanceProxyConfigurationWithOptions(DescribeDBInstanceProxyConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceProxyConfigurationResponse>(DoRPCRequest("DescribeDBInstanceProxyConfiguration", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstanceProxyConfigurationResponse> DescribeDBInstanceProxyConfigurationWithOptionsAsync(DescribeDBInstanceProxyConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceProxyConfigurationResponse>(await DoRPCRequestAsync("DescribeDBInstanceProxyConfiguration", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstanceProxyConfigurationResponse DescribeDBInstanceProxyConfiguration(DescribeDBInstanceProxyConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceProxyConfigurationWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceProxyConfigurationResponse> DescribeDBInstanceProxyConfigurationAsync(DescribeDBInstanceProxyConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceProxyConfigurationWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstancesResponse DescribeDBInstancesWithOptions(DescribeDBInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstancesResponse>(DoRPCRequest("DescribeDBInstances", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstancesResponse> DescribeDBInstancesWithOptionsAsync(DescribeDBInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstancesResponse>(await DoRPCRequestAsync("DescribeDBInstances", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDBInstancesAsCsvResponse DescribeDBInstancesAsCsvWithOptions(DescribeDBInstancesAsCsvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstancesAsCsvResponse>(DoRPCRequest("DescribeDBInstancesAsCsv", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstancesAsCsvResponse> DescribeDBInstancesAsCsvWithOptionsAsync(DescribeDBInstancesAsCsvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstancesAsCsvResponse>(await DoRPCRequestAsync("DescribeDBInstancesAsCsv", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstancesAsCsvResponse DescribeDBInstancesAsCsv(DescribeDBInstancesAsCsvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstancesAsCsvWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstancesAsCsvResponse> DescribeDBInstancesAsCsvAsync(DescribeDBInstancesAsCsvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstancesAsCsvWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstancesByExpireTimeResponse DescribeDBInstancesByExpireTimeWithOptions(DescribeDBInstancesByExpireTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstancesByExpireTimeResponse>(DoRPCRequest("DescribeDBInstancesByExpireTime", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstancesByExpireTimeResponse> DescribeDBInstancesByExpireTimeWithOptionsAsync(DescribeDBInstancesByExpireTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstancesByExpireTimeResponse>(await DoRPCRequestAsync("DescribeDBInstancesByExpireTime", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstancesByExpireTimeResponse DescribeDBInstancesByExpireTime(DescribeDBInstancesByExpireTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstancesByExpireTimeWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstancesByExpireTimeResponse> DescribeDBInstancesByExpireTimeAsync(DescribeDBInstancesByExpireTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstancesByExpireTimeWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstancesByPerformanceResponse DescribeDBInstancesByPerformanceWithOptions(DescribeDBInstancesByPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstancesByPerformanceResponse>(DoRPCRequest("DescribeDBInstancesByPerformance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstancesByPerformanceResponse> DescribeDBInstancesByPerformanceWithOptionsAsync(DescribeDBInstancesByPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstancesByPerformanceResponse>(await DoRPCRequestAsync("DescribeDBInstancesByPerformance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstancesByPerformanceResponse DescribeDBInstancesByPerformance(DescribeDBInstancesByPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstancesByPerformanceWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstancesByPerformanceResponse> DescribeDBInstancesByPerformanceAsync(DescribeDBInstancesByPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstancesByPerformanceWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstancesForCloneResponse DescribeDBInstancesForCloneWithOptions(DescribeDBInstancesForCloneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstancesForCloneResponse>(DoRPCRequest("DescribeDBInstancesForClone", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstancesForCloneResponse> DescribeDBInstancesForCloneWithOptionsAsync(DescribeDBInstancesForCloneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstancesForCloneResponse>(await DoRPCRequestAsync("DescribeDBInstancesForClone", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstancesForCloneResponse DescribeDBInstancesForClone(DescribeDBInstancesForCloneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstancesForCloneWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstancesForCloneResponse> DescribeDBInstancesForCloneAsync(DescribeDBInstancesForCloneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstancesForCloneWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceSSLResponse DescribeDBInstanceSSLWithOptions(DescribeDBInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceSSLResponse>(DoRPCRequest("DescribeDBInstanceSSL", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstanceSSLResponse> DescribeDBInstanceSSLWithOptionsAsync(DescribeDBInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceSSLResponse>(await DoRPCRequestAsync("DescribeDBInstanceSSL", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeDBInstanceTDEResponse>(DoRPCRequest("DescribeDBInstanceTDE", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstanceTDEResponse> DescribeDBInstanceTDEWithOptionsAsync(DescribeDBInstanceTDERequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceTDEResponse>(await DoRPCRequestAsync("DescribeDBInstanceTDE", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDBProxyResponse DescribeDBProxyWithOptions(DescribeDBProxyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBProxyResponse>(DoRPCRequest("DescribeDBProxy", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBProxyResponse> DescribeDBProxyWithOptionsAsync(DescribeDBProxyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBProxyResponse>(await DoRPCRequestAsync("DescribeDBProxy", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBProxyResponse DescribeDBProxy(DescribeDBProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBProxyWithOptions(request, runtime);
        }

        public async Task<DescribeDBProxyResponse> DescribeDBProxyAsync(DescribeDBProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBProxyWithOptionsAsync(request, runtime);
        }

        public DescribeDBProxyEndpointResponse DescribeDBProxyEndpointWithOptions(DescribeDBProxyEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBProxyEndpointResponse>(DoRPCRequest("DescribeDBProxyEndpoint", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBProxyEndpointResponse> DescribeDBProxyEndpointWithOptionsAsync(DescribeDBProxyEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBProxyEndpointResponse>(await DoRPCRequestAsync("DescribeDBProxyEndpoint", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBProxyEndpointResponse DescribeDBProxyEndpoint(DescribeDBProxyEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBProxyEndpointWithOptions(request, runtime);
        }

        public async Task<DescribeDBProxyEndpointResponse> DescribeDBProxyEndpointAsync(DescribeDBProxyEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBProxyEndpointWithOptionsAsync(request, runtime);
        }

        public DescribeDBProxyPerformanceResponse DescribeDBProxyPerformanceWithOptions(DescribeDBProxyPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBProxyPerformanceResponse>(DoRPCRequest("DescribeDBProxyPerformance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBProxyPerformanceResponse> DescribeDBProxyPerformanceWithOptionsAsync(DescribeDBProxyPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBProxyPerformanceResponse>(await DoRPCRequestAsync("DescribeDBProxyPerformance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBProxyPerformanceResponse DescribeDBProxyPerformance(DescribeDBProxyPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBProxyPerformanceWithOptions(request, runtime);
        }

        public async Task<DescribeDBProxyPerformanceResponse> DescribeDBProxyPerformanceAsync(DescribeDBProxyPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBProxyPerformanceWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostAttributeResponse DescribeDedicatedHostAttributeWithOptions(DescribeDedicatedHostAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostAttributeResponse>(DoRPCRequest("DescribeDedicatedHostAttribute", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedHostAttributeResponse> DescribeDedicatedHostAttributeWithOptionsAsync(DescribeDedicatedHostAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostAttributeResponse>(await DoRPCRequestAsync("DescribeDedicatedHostAttribute", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedHostAttributeResponse DescribeDedicatedHostAttribute(DescribeDedicatedHostAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostAttributeResponse> DescribeDedicatedHostAttributeAsync(DescribeDedicatedHostAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostGroupsResponse DescribeDedicatedHostGroupsWithOptions(DescribeDedicatedHostGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostGroupsResponse>(DoRPCRequest("DescribeDedicatedHostGroups", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedHostGroupsResponse> DescribeDedicatedHostGroupsWithOptionsAsync(DescribeDedicatedHostGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostGroupsResponse>(await DoRPCRequestAsync("DescribeDedicatedHostGroups", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedHostGroupsResponse DescribeDedicatedHostGroups(DescribeDedicatedHostGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostGroupsResponse> DescribeDedicatedHostGroupsAsync(DescribeDedicatedHostGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostImageCategoriesResponse DescribeDedicatedHostImageCategoriesWithOptions(DescribeDedicatedHostImageCategoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostImageCategoriesResponse>(DoRPCRequest("DescribeDedicatedHostImageCategories", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedHostImageCategoriesResponse> DescribeDedicatedHostImageCategoriesWithOptionsAsync(DescribeDedicatedHostImageCategoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostImageCategoriesResponse>(await DoRPCRequestAsync("DescribeDedicatedHostImageCategories", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedHostImageCategoriesResponse DescribeDedicatedHostImageCategories(DescribeDedicatedHostImageCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostImageCategoriesWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostImageCategoriesResponse> DescribeDedicatedHostImageCategoriesAsync(DescribeDedicatedHostImageCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostImageCategoriesWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostsResponse DescribeDedicatedHostsWithOptions(DescribeDedicatedHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostsResponse>(DoRPCRequest("DescribeDedicatedHosts", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedHostsResponse> DescribeDedicatedHostsWithOptionsAsync(DescribeDedicatedHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostsResponse>(await DoRPCRequestAsync("DescribeDedicatedHosts", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedHostsResponse DescribeDedicatedHosts(DescribeDedicatedHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostsWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostsResponse> DescribeDedicatedHostsAsync(DescribeDedicatedHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostsWithOptionsAsync(request, runtime);
        }

        public DescribeDetachedBackupsResponse DescribeDetachedBackupsWithOptions(DescribeDetachedBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDetachedBackupsResponse>(DoRPCRequest("DescribeDetachedBackups", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDetachedBackupsResponse> DescribeDetachedBackupsWithOptionsAsync(DescribeDetachedBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDetachedBackupsResponse>(await DoRPCRequestAsync("DescribeDetachedBackups", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeDTCSecurityIpHostsForSQLServerResponse DescribeDTCSecurityIpHostsForSQLServerWithOptions(DescribeDTCSecurityIpHostsForSQLServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDTCSecurityIpHostsForSQLServerResponse>(DoRPCRequest("DescribeDTCSecurityIpHostsForSQLServer", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDTCSecurityIpHostsForSQLServerResponse> DescribeDTCSecurityIpHostsForSQLServerWithOptionsAsync(DescribeDTCSecurityIpHostsForSQLServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDTCSecurityIpHostsForSQLServerResponse>(await DoRPCRequestAsync("DescribeDTCSecurityIpHostsForSQLServer", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDTCSecurityIpHostsForSQLServerResponse DescribeDTCSecurityIpHostsForSQLServer(DescribeDTCSecurityIpHostsForSQLServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDTCSecurityIpHostsForSQLServerWithOptions(request, runtime);
        }

        public async Task<DescribeDTCSecurityIpHostsForSQLServerResponse> DescribeDTCSecurityIpHostsForSQLServerAsync(DescribeDTCSecurityIpHostsForSQLServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDTCSecurityIpHostsForSQLServerWithOptionsAsync(request, runtime);
        }

        public DescribeErrorLogsResponse DescribeErrorLogsWithOptions(DescribeErrorLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeErrorLogsResponse>(DoRPCRequest("DescribeErrorLogs", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeErrorLogsResponse> DescribeErrorLogsWithOptionsAsync(DescribeErrorLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeErrorLogsResponse>(await DoRPCRequestAsync("DescribeErrorLogs", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeErrorLogsResponse DescribeErrorLogs(DescribeErrorLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeErrorLogsWithOptions(request, runtime);
        }

        public async Task<DescribeErrorLogsResponse> DescribeErrorLogsAsync(DescribeErrorLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeErrorLogsWithOptionsAsync(request, runtime);
        }

        public DescribeEventsResponse DescribeEventsWithOptions(DescribeEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEventsResponse>(DoRPCRequest("DescribeEvents", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEventsResponse> DescribeEventsWithOptionsAsync(DescribeEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEventsResponse>(await DoRPCRequestAsync("DescribeEvents", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventsWithOptions(request, runtime);
        }

        public async Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventsWithOptionsAsync(request, runtime);
        }

        public DescribeHADiagnoseConfigResponse DescribeHADiagnoseConfigWithOptions(DescribeHADiagnoseConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHADiagnoseConfigResponse>(DoRPCRequest("DescribeHADiagnoseConfig", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHADiagnoseConfigResponse> DescribeHADiagnoseConfigWithOptionsAsync(DescribeHADiagnoseConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHADiagnoseConfigResponse>(await DoRPCRequestAsync("DescribeHADiagnoseConfig", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHADiagnoseConfigResponse DescribeHADiagnoseConfig(DescribeHADiagnoseConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHADiagnoseConfigWithOptions(request, runtime);
        }

        public async Task<DescribeHADiagnoseConfigResponse> DescribeHADiagnoseConfigAsync(DescribeHADiagnoseConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHADiagnoseConfigWithOptionsAsync(request, runtime);
        }

        public DescribeHASwitchConfigResponse DescribeHASwitchConfigWithOptions(DescribeHASwitchConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHASwitchConfigResponse>(DoRPCRequest("DescribeHASwitchConfig", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHASwitchConfigResponse> DescribeHASwitchConfigWithOptionsAsync(DescribeHASwitchConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHASwitchConfigResponse>(await DoRPCRequestAsync("DescribeHASwitchConfig", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHASwitchConfigResponse DescribeHASwitchConfig(DescribeHASwitchConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHASwitchConfigWithOptions(request, runtime);
        }

        public async Task<DescribeHASwitchConfigResponse> DescribeHASwitchConfigAsync(DescribeHASwitchConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHASwitchConfigWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceAutoRenewalAttributeResponse DescribeInstanceAutoRenewalAttributeWithOptions(DescribeInstanceAutoRenewalAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAutoRenewalAttributeResponse>(DoRPCRequest("DescribeInstanceAutoRenewalAttribute", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceAutoRenewalAttributeResponse> DescribeInstanceAutoRenewalAttributeWithOptionsAsync(DescribeInstanceAutoRenewalAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAutoRenewalAttributeResponse>(await DoRPCRequestAsync("DescribeInstanceAutoRenewalAttribute", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeInstanceCrossBackupPolicyResponse DescribeInstanceCrossBackupPolicyWithOptions(DescribeInstanceCrossBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceCrossBackupPolicyResponse>(DoRPCRequest("DescribeInstanceCrossBackupPolicy", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceCrossBackupPolicyResponse> DescribeInstanceCrossBackupPolicyWithOptionsAsync(DescribeInstanceCrossBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceCrossBackupPolicyResponse>(await DoRPCRequestAsync("DescribeInstanceCrossBackupPolicy", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceCrossBackupPolicyResponse DescribeInstanceCrossBackupPolicy(DescribeInstanceCrossBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceCrossBackupPolicyWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceCrossBackupPolicyResponse> DescribeInstanceCrossBackupPolicyAsync(DescribeInstanceCrossBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceCrossBackupPolicyWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceKeywordsResponse DescribeInstanceKeywordsWithOptions(DescribeInstanceKeywordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceKeywordsResponse>(DoRPCRequest("DescribeInstanceKeywords", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceKeywordsResponse> DescribeInstanceKeywordsWithOptionsAsync(DescribeInstanceKeywordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceKeywordsResponse>(await DoRPCRequestAsync("DescribeInstanceKeywords", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceKeywordsResponse DescribeInstanceKeywords(DescribeInstanceKeywordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceKeywordsWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceKeywordsResponse> DescribeInstanceKeywordsAsync(DescribeInstanceKeywordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceKeywordsWithOptionsAsync(request, runtime);
        }

        public DescribeLocalAvailableRecoveryTimeResponse DescribeLocalAvailableRecoveryTimeWithOptions(DescribeLocalAvailableRecoveryTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLocalAvailableRecoveryTimeResponse>(DoRPCRequest("DescribeLocalAvailableRecoveryTime", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLocalAvailableRecoveryTimeResponse> DescribeLocalAvailableRecoveryTimeWithOptionsAsync(DescribeLocalAvailableRecoveryTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLocalAvailableRecoveryTimeResponse>(await DoRPCRequestAsync("DescribeLocalAvailableRecoveryTime", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLocalAvailableRecoveryTimeResponse DescribeLocalAvailableRecoveryTime(DescribeLocalAvailableRecoveryTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLocalAvailableRecoveryTimeWithOptions(request, runtime);
        }

        public async Task<DescribeLocalAvailableRecoveryTimeResponse> DescribeLocalAvailableRecoveryTimeAsync(DescribeLocalAvailableRecoveryTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLocalAvailableRecoveryTimeWithOptionsAsync(request, runtime);
        }

        public DescribeLogBackupFilesResponse DescribeLogBackupFilesWithOptions(DescribeLogBackupFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLogBackupFilesResponse>(DoRPCRequest("DescribeLogBackupFiles", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLogBackupFilesResponse> DescribeLogBackupFilesWithOptionsAsync(DescribeLogBackupFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLogBackupFilesResponse>(await DoRPCRequestAsync("DescribeLogBackupFiles", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLogBackupFilesResponse DescribeLogBackupFiles(DescribeLogBackupFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogBackupFilesWithOptions(request, runtime);
        }

        public async Task<DescribeLogBackupFilesResponse> DescribeLogBackupFilesAsync(DescribeLogBackupFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogBackupFilesWithOptionsAsync(request, runtime);
        }

        public DescribeMetaListResponse DescribeMetaListWithOptions(DescribeMetaListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetaListResponse>(DoRPCRequest("DescribeMetaList", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMetaListResponse> DescribeMetaListWithOptionsAsync(DescribeMetaListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetaListResponse>(await DoRPCRequestAsync("DescribeMetaList", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeMigrateTaskByIdResponse DescribeMigrateTaskByIdWithOptions(DescribeMigrateTaskByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMigrateTaskByIdResponse>(DoRPCRequest("DescribeMigrateTaskById", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMigrateTaskByIdResponse> DescribeMigrateTaskByIdWithOptionsAsync(DescribeMigrateTaskByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMigrateTaskByIdResponse>(await DoRPCRequestAsync("DescribeMigrateTaskById", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMigrateTaskByIdResponse DescribeMigrateTaskById(DescribeMigrateTaskByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMigrateTaskByIdWithOptions(request, runtime);
        }

        public async Task<DescribeMigrateTaskByIdResponse> DescribeMigrateTaskByIdAsync(DescribeMigrateTaskByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMigrateTaskByIdWithOptionsAsync(request, runtime);
        }

        public DescribeMigrateTasksResponse DescribeMigrateTasksWithOptions(DescribeMigrateTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMigrateTasksResponse>(DoRPCRequest("DescribeMigrateTasks", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMigrateTasksResponse> DescribeMigrateTasksWithOptionsAsync(DescribeMigrateTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMigrateTasksResponse>(await DoRPCRequestAsync("DescribeMigrateTasks", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMigrateTasksResponse DescribeMigrateTasks(DescribeMigrateTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMigrateTasksWithOptions(request, runtime);
        }

        public async Task<DescribeMigrateTasksResponse> DescribeMigrateTasksAsync(DescribeMigrateTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMigrateTasksWithOptionsAsync(request, runtime);
        }

        public DescribeMigrateTasksForSQLServerResponse DescribeMigrateTasksForSQLServerWithOptions(DescribeMigrateTasksForSQLServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMigrateTasksForSQLServerResponse>(DoRPCRequest("DescribeMigrateTasksForSQLServer", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMigrateTasksForSQLServerResponse> DescribeMigrateTasksForSQLServerWithOptionsAsync(DescribeMigrateTasksForSQLServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMigrateTasksForSQLServerResponse>(await DoRPCRequestAsync("DescribeMigrateTasksForSQLServer", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMigrateTasksForSQLServerResponse DescribeMigrateTasksForSQLServer(DescribeMigrateTasksForSQLServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMigrateTasksForSQLServerWithOptions(request, runtime);
        }

        public async Task<DescribeMigrateTasksForSQLServerResponse> DescribeMigrateTasksForSQLServerAsync(DescribeMigrateTasksForSQLServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMigrateTasksForSQLServerWithOptionsAsync(request, runtime);
        }

        public DescribeModifyParameterLogResponse DescribeModifyParameterLogWithOptions(DescribeModifyParameterLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeModifyParameterLogResponse>(DoRPCRequest("DescribeModifyParameterLog", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeModifyParameterLogResponse> DescribeModifyParameterLogWithOptionsAsync(DescribeModifyParameterLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeModifyParameterLogResponse>(await DoRPCRequestAsync("DescribeModifyParameterLog", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeModifyParameterLogResponse DescribeModifyParameterLog(DescribeModifyParameterLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeModifyParameterLogWithOptions(request, runtime);
        }

        public async Task<DescribeModifyParameterLogResponse> DescribeModifyParameterLogAsync(DescribeModifyParameterLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeModifyParameterLogWithOptionsAsync(request, runtime);
        }

        public DescribeOssDownloadsResponse DescribeOssDownloadsWithOptions(DescribeOssDownloadsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOssDownloadsResponse>(DoRPCRequest("DescribeOssDownloads", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeOssDownloadsResponse> DescribeOssDownloadsWithOptionsAsync(DescribeOssDownloadsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOssDownloadsResponse>(await DoRPCRequestAsync("DescribeOssDownloads", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeOssDownloadsResponse DescribeOssDownloads(DescribeOssDownloadsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOssDownloadsWithOptions(request, runtime);
        }

        public async Task<DescribeOssDownloadsResponse> DescribeOssDownloadsAsync(DescribeOssDownloadsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOssDownloadsWithOptionsAsync(request, runtime);
        }

        public DescribeOssDownloadsForSQLServerResponse DescribeOssDownloadsForSQLServerWithOptions(DescribeOssDownloadsForSQLServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOssDownloadsForSQLServerResponse>(DoRPCRequest("DescribeOssDownloadsForSQLServer", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeOssDownloadsForSQLServerResponse> DescribeOssDownloadsForSQLServerWithOptionsAsync(DescribeOssDownloadsForSQLServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOssDownloadsForSQLServerResponse>(await DoRPCRequestAsync("DescribeOssDownloadsForSQLServer", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeOssDownloadsForSQLServerResponse DescribeOssDownloadsForSQLServer(DescribeOssDownloadsForSQLServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOssDownloadsForSQLServerWithOptions(request, runtime);
        }

        public async Task<DescribeOssDownloadsForSQLServerResponse> DescribeOssDownloadsForSQLServerAsync(DescribeOssDownloadsForSQLServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOssDownloadsForSQLServerWithOptionsAsync(request, runtime);
        }

        public DescribeParameterGroupResponse DescribeParameterGroupWithOptions(DescribeParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParameterGroupResponse>(DoRPCRequest("DescribeParameterGroup", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeParameterGroupResponse> DescribeParameterGroupWithOptionsAsync(DescribeParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParameterGroupResponse>(await DoRPCRequestAsync("DescribeParameterGroup", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeParameterGroupsResponse>(DoRPCRequest("DescribeParameterGroups", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeParameterGroupsResponse> DescribeParameterGroupsWithOptionsAsync(DescribeParameterGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParameterGroupsResponse>(await DoRPCRequestAsync("DescribeParameterGroups", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeParametersResponse DescribeParametersWithOptions(DescribeParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParametersResponse>(DoRPCRequest("DescribeParameters", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeParametersResponse> DescribeParametersWithOptionsAsync(DescribeParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParametersResponse>(await DoRPCRequestAsync("DescribeParameters", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeParameterTemplatesResponse>(DoRPCRequest("DescribeParameterTemplates", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeParameterTemplatesResponse> DescribeParameterTemplatesWithOptionsAsync(DescribeParameterTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParameterTemplatesResponse>(await DoRPCRequestAsync("DescribeParameterTemplates", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<DescribePriceResponse>(DoRPCRequest("DescribePrice", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePriceResponse> DescribePriceWithOptionsAsync(DescribePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePriceResponse>(await DoRPCRequestAsync("DescribePrice", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeRdsResourceSettingsResponse DescribeRdsResourceSettingsWithOptions(DescribeRdsResourceSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRdsResourceSettingsResponse>(DoRPCRequest("DescribeRdsResourceSettings", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRdsResourceSettingsResponse> DescribeRdsResourceSettingsWithOptionsAsync(DescribeRdsResourceSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRdsResourceSettingsResponse>(await DoRPCRequestAsync("DescribeRdsResourceSettings", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRdsResourceSettingsResponse DescribeRdsResourceSettings(DescribeRdsResourceSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRdsResourceSettingsWithOptions(request, runtime);
        }

        public async Task<DescribeRdsResourceSettingsResponse> DescribeRdsResourceSettingsAsync(DescribeRdsResourceSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRdsResourceSettingsWithOptionsAsync(request, runtime);
        }

        public DescribeReadDBInstanceDelayResponse DescribeReadDBInstanceDelayWithOptions(DescribeReadDBInstanceDelayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeReadDBInstanceDelayResponse>(DoRPCRequest("DescribeReadDBInstanceDelay", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeReadDBInstanceDelayResponse> DescribeReadDBInstanceDelayWithOptionsAsync(DescribeReadDBInstanceDelayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeReadDBInstanceDelayResponse>(await DoRPCRequestAsync("DescribeReadDBInstanceDelay", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeReadDBInstanceDelayResponse DescribeReadDBInstanceDelay(DescribeReadDBInstanceDelayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeReadDBInstanceDelayWithOptions(request, runtime);
        }

        public async Task<DescribeReadDBInstanceDelayResponse> DescribeReadDBInstanceDelayAsync(DescribeReadDBInstanceDelayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeReadDBInstanceDelayWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeRenewalPriceResponse DescribeRenewalPriceWithOptions(DescribeRenewalPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRenewalPriceResponse>(DoRPCRequest("DescribeRenewalPrice", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRenewalPriceResponse> DescribeRenewalPriceWithOptionsAsync(DescribeRenewalPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRenewalPriceResponse>(await DoRPCRequestAsync("DescribeRenewalPrice", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRenewalPriceResponse DescribeRenewalPrice(DescribeRenewalPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRenewalPriceWithOptions(request, runtime);
        }

        public async Task<DescribeRenewalPriceResponse> DescribeRenewalPriceAsync(DescribeRenewalPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRenewalPriceWithOptionsAsync(request, runtime);
        }

        public DescribeResourceUsageResponse DescribeResourceUsageWithOptions(DescribeResourceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeResourceUsageResponse>(DoRPCRequest("DescribeResourceUsage", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeResourceUsageResponse> DescribeResourceUsageWithOptionsAsync(DescribeResourceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeResourceUsageResponse>(await DoRPCRequestAsync("DescribeResourceUsage", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeResourceUsageResponse DescribeResourceUsage(DescribeResourceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourceUsageWithOptions(request, runtime);
        }

        public async Task<DescribeResourceUsageResponse> DescribeResourceUsageAsync(DescribeResourceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourceUsageWithOptionsAsync(request, runtime);
        }

        public DescribeSecurityGroupConfigurationResponse DescribeSecurityGroupConfigurationWithOptions(DescribeSecurityGroupConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityGroupConfigurationResponse>(DoRPCRequest("DescribeSecurityGroupConfiguration", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSecurityGroupConfigurationResponse> DescribeSecurityGroupConfigurationWithOptionsAsync(DescribeSecurityGroupConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityGroupConfigurationResponse>(await DoRPCRequestAsync("DescribeSecurityGroupConfiguration", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeSlowLogRecordsResponse DescribeSlowLogRecordsWithOptions(DescribeSlowLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlowLogRecordsResponse>(DoRPCRequest("DescribeSlowLogRecords", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSlowLogRecordsResponse> DescribeSlowLogRecordsWithOptionsAsync(DescribeSlowLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlowLogRecordsResponse>(await DoRPCRequestAsync("DescribeSlowLogRecords", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeSlowLogsResponse DescribeSlowLogsWithOptions(DescribeSlowLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlowLogsResponse>(DoRPCRequest("DescribeSlowLogs", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSlowLogsResponse> DescribeSlowLogsWithOptionsAsync(DescribeSlowLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSlowLogsResponse>(await DoRPCRequestAsync("DescribeSlowLogs", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSlowLogsResponse DescribeSlowLogs(DescribeSlowLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlowLogsWithOptions(request, runtime);
        }

        public async Task<DescribeSlowLogsResponse> DescribeSlowLogsAsync(DescribeSlowLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlowLogsWithOptionsAsync(request, runtime);
        }

        public DescribeSQLCollectorPolicyResponse DescribeSQLCollectorPolicyWithOptions(DescribeSQLCollectorPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSQLCollectorPolicyResponse>(DoRPCRequest("DescribeSQLCollectorPolicy", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSQLCollectorPolicyResponse> DescribeSQLCollectorPolicyWithOptionsAsync(DescribeSQLCollectorPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSQLCollectorPolicyResponse>(await DoRPCRequestAsync("DescribeSQLCollectorPolicy", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSQLCollectorPolicyResponse DescribeSQLCollectorPolicy(DescribeSQLCollectorPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSQLCollectorPolicyWithOptions(request, runtime);
        }

        public async Task<DescribeSQLCollectorPolicyResponse> DescribeSQLCollectorPolicyAsync(DescribeSQLCollectorPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSQLCollectorPolicyWithOptionsAsync(request, runtime);
        }

        public DescribeSQLCollectorRetentionResponse DescribeSQLCollectorRetentionWithOptions(DescribeSQLCollectorRetentionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSQLCollectorRetentionResponse>(DoRPCRequest("DescribeSQLCollectorRetention", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSQLCollectorRetentionResponse> DescribeSQLCollectorRetentionWithOptionsAsync(DescribeSQLCollectorRetentionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSQLCollectorRetentionResponse>(await DoRPCRequestAsync("DescribeSQLCollectorRetention", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSQLCollectorRetentionResponse DescribeSQLCollectorRetention(DescribeSQLCollectorRetentionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSQLCollectorRetentionWithOptions(request, runtime);
        }

        public async Task<DescribeSQLCollectorRetentionResponse> DescribeSQLCollectorRetentionAsync(DescribeSQLCollectorRetentionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSQLCollectorRetentionWithOptionsAsync(request, runtime);
        }

        public DescribeSQLLogFilesResponse DescribeSQLLogFilesWithOptions(DescribeSQLLogFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSQLLogFilesResponse>(DoRPCRequest("DescribeSQLLogFiles", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSQLLogFilesResponse> DescribeSQLLogFilesWithOptionsAsync(DescribeSQLLogFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSQLLogFilesResponse>(await DoRPCRequestAsync("DescribeSQLLogFiles", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSQLLogFilesResponse DescribeSQLLogFiles(DescribeSQLLogFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSQLLogFilesWithOptions(request, runtime);
        }

        public async Task<DescribeSQLLogFilesResponse> DescribeSQLLogFilesAsync(DescribeSQLLogFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSQLLogFilesWithOptionsAsync(request, runtime);
        }

        public DescribeSQLLogRecordsResponse DescribeSQLLogRecordsWithOptions(DescribeSQLLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSQLLogRecordsResponse>(DoRPCRequest("DescribeSQLLogRecords", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSQLLogRecordsResponse> DescribeSQLLogRecordsWithOptionsAsync(DescribeSQLLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSQLLogRecordsResponse>(await DoRPCRequestAsync("DescribeSQLLogRecords", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSQLLogRecordsResponse DescribeSQLLogRecords(DescribeSQLLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSQLLogRecordsWithOptions(request, runtime);
        }

        public async Task<DescribeSQLLogRecordsResponse> DescribeSQLLogRecordsAsync(DescribeSQLLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSQLLogRecordsWithOptionsAsync(request, runtime);
        }

        public DescribeSQLLogReportListResponse DescribeSQLLogReportListWithOptions(DescribeSQLLogReportListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSQLLogReportListResponse>(DoRPCRequest("DescribeSQLLogReportList", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSQLLogReportListResponse> DescribeSQLLogReportListWithOptionsAsync(DescribeSQLLogReportListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSQLLogReportListResponse>(await DoRPCRequestAsync("DescribeSQLLogReportList", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSQLLogReportListResponse DescribeSQLLogReportList(DescribeSQLLogReportListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSQLLogReportListWithOptions(request, runtime);
        }

        public async Task<DescribeSQLLogReportListResponse> DescribeSQLLogReportListAsync(DescribeSQLLogReportListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSQLLogReportListWithOptionsAsync(request, runtime);
        }

        public DescribeSQLLogReportsResponse DescribeSQLLogReportsWithOptions(DescribeSQLLogReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSQLLogReportsResponse>(DoRPCRequest("DescribeSQLLogReports", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSQLLogReportsResponse> DescribeSQLLogReportsWithOptionsAsync(DescribeSQLLogReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSQLLogReportsResponse>(await DoRPCRequestAsync("DescribeSQLLogReports", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSQLLogReportsResponse DescribeSQLLogReports(DescribeSQLLogReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSQLLogReportsWithOptions(request, runtime);
        }

        public async Task<DescribeSQLLogReportsResponse> DescribeSQLLogReportsAsync(DescribeSQLLogReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSQLLogReportsWithOptionsAsync(request, runtime);
        }

        public DescribeTagsResponse DescribeTagsWithOptions(DescribeTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTagsResponse>(DoRPCRequest("DescribeTags", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTagsResponse> DescribeTagsWithOptionsAsync(DescribeTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTagsResponse>(await DoRPCRequestAsync("DescribeTags", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTagsWithOptions(request, runtime);
        }

        public async Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTagsWithOptionsAsync(request, runtime);
        }

        public DescribeTasksResponse DescribeTasksWithOptions(DescribeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTasksResponse>(DoRPCRequest("DescribeTasks", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTasksResponse> DescribeTasksWithOptionsAsync(DescribeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTasksResponse>(await DoRPCRequestAsync("DescribeTasks", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DestroyDBInstanceResponse DestroyDBInstanceWithOptions(DestroyDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DestroyDBInstanceResponse>(DoRPCRequest("DestroyDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DestroyDBInstanceResponse> DestroyDBInstanceWithOptionsAsync(DestroyDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DestroyDBInstanceResponse>(await DoRPCRequestAsync("DestroyDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DestroyDBInstanceResponse DestroyDBInstance(DestroyDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DestroyDBInstanceWithOptions(request, runtime);
        }

        public async Task<DestroyDBInstanceResponse> DestroyDBInstanceAsync(DestroyDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DestroyDBInstanceWithOptionsAsync(request, runtime);
        }

        public DropDedicatedHostUserResponse DropDedicatedHostUserWithOptions(DropDedicatedHostUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DropDedicatedHostUserResponse>(DoRPCRequest("DropDedicatedHostUser", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DropDedicatedHostUserResponse> DropDedicatedHostUserWithOptionsAsync(DropDedicatedHostUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DropDedicatedHostUserResponse>(await DoRPCRequestAsync("DropDedicatedHostUser", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DropDedicatedHostUserResponse DropDedicatedHostUser(DropDedicatedHostUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DropDedicatedHostUserWithOptions(request, runtime);
        }

        public async Task<DropDedicatedHostUserResponse> DropDedicatedHostUserAsync(DropDedicatedHostUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DropDedicatedHostUserWithOptionsAsync(request, runtime);
        }

        public EvaluateDedicatedHostInstanceResourceResponse EvaluateDedicatedHostInstanceResourceWithOptions(EvaluateDedicatedHostInstanceResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EvaluateDedicatedHostInstanceResourceResponse>(DoRPCRequest("EvaluateDedicatedHostInstanceResource", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EvaluateDedicatedHostInstanceResourceResponse> EvaluateDedicatedHostInstanceResourceWithOptionsAsync(EvaluateDedicatedHostInstanceResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EvaluateDedicatedHostInstanceResourceResponse>(await DoRPCRequestAsync("EvaluateDedicatedHostInstanceResource", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EvaluateDedicatedHostInstanceResourceResponse EvaluateDedicatedHostInstanceResource(EvaluateDedicatedHostInstanceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EvaluateDedicatedHostInstanceResourceWithOptions(request, runtime);
        }

        public async Task<EvaluateDedicatedHostInstanceResourceResponse> EvaluateDedicatedHostInstanceResourceAsync(EvaluateDedicatedHostInstanceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EvaluateDedicatedHostInstanceResourceWithOptionsAsync(request, runtime);
        }

        public GetDbProxyInstanceSslResponse GetDbProxyInstanceSslWithOptions(GetDbProxyInstanceSslRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDbProxyInstanceSslResponse>(DoRPCRequest("GetDbProxyInstanceSsl", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDbProxyInstanceSslResponse> GetDbProxyInstanceSslWithOptionsAsync(GetDbProxyInstanceSslRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDbProxyInstanceSslResponse>(await DoRPCRequestAsync("GetDbProxyInstanceSsl", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDbProxyInstanceSslResponse GetDbProxyInstanceSsl(GetDbProxyInstanceSslRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDbProxyInstanceSslWithOptions(request, runtime);
        }

        public async Task<GetDbProxyInstanceSslResponse> GetDbProxyInstanceSslAsync(GetDbProxyInstanceSslRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDbProxyInstanceSslWithOptionsAsync(request, runtime);
        }

        public GrantAccountPrivilegeResponse GrantAccountPrivilegeWithOptions(GrantAccountPrivilegeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GrantAccountPrivilegeResponse>(DoRPCRequest("GrantAccountPrivilege", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GrantAccountPrivilegeResponse> GrantAccountPrivilegeWithOptionsAsync(GrantAccountPrivilegeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GrantAccountPrivilegeResponse>(await DoRPCRequestAsync("GrantAccountPrivilege", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GrantOperatorPermissionResponse GrantOperatorPermissionWithOptions(GrantOperatorPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GrantOperatorPermissionResponse>(DoRPCRequest("GrantOperatorPermission", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GrantOperatorPermissionResponse> GrantOperatorPermissionWithOptionsAsync(GrantOperatorPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GrantOperatorPermissionResponse>(await DoRPCRequestAsync("GrantOperatorPermission", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GrantOperatorPermissionResponse GrantOperatorPermission(GrantOperatorPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantOperatorPermissionWithOptions(request, runtime);
        }

        public async Task<GrantOperatorPermissionResponse> GrantOperatorPermissionAsync(GrantOperatorPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantOperatorPermissionWithOptionsAsync(request, runtime);
        }

        public ImportDatabaseBetweenInstancesResponse ImportDatabaseBetweenInstancesWithOptions(ImportDatabaseBetweenInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportDatabaseBetweenInstancesResponse>(DoRPCRequest("ImportDatabaseBetweenInstances", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportDatabaseBetweenInstancesResponse> ImportDatabaseBetweenInstancesWithOptionsAsync(ImportDatabaseBetweenInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportDatabaseBetweenInstancesResponse>(await DoRPCRequestAsync("ImportDatabaseBetweenInstances", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportDatabaseBetweenInstancesResponse ImportDatabaseBetweenInstances(ImportDatabaseBetweenInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportDatabaseBetweenInstancesWithOptions(request, runtime);
        }

        public async Task<ImportDatabaseBetweenInstancesResponse> ImportDatabaseBetweenInstancesAsync(ImportDatabaseBetweenInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportDatabaseBetweenInstancesWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public LockAccountResponse LockAccountWithOptions(LockAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LockAccountResponse>(DoRPCRequest("LockAccount", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<LockAccountResponse> LockAccountWithOptionsAsync(LockAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LockAccountResponse>(await DoRPCRequestAsync("LockAccount", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public LockAccountResponse LockAccount(LockAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LockAccountWithOptions(request, runtime);
        }

        public async Task<LockAccountResponse> LockAccountAsync(LockAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LockAccountWithOptionsAsync(request, runtime);
        }

        public MigrateDBInstanceResponse MigrateDBInstanceWithOptions(MigrateDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MigrateDBInstanceResponse>(DoRPCRequest("MigrateDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MigrateDBInstanceResponse> MigrateDBInstanceWithOptionsAsync(MigrateDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MigrateDBInstanceResponse>(await DoRPCRequestAsync("MigrateDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MigrateDBInstanceResponse MigrateDBInstance(MigrateDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MigrateDBInstanceWithOptions(request, runtime);
        }

        public async Task<MigrateDBInstanceResponse> MigrateDBInstanceAsync(MigrateDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MigrateDBInstanceWithOptionsAsync(request, runtime);
        }

        public MigrateSecurityIPModeResponse MigrateSecurityIPModeWithOptions(MigrateSecurityIPModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MigrateSecurityIPModeResponse>(DoRPCRequest("MigrateSecurityIPMode", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MigrateSecurityIPModeResponse> MigrateSecurityIPModeWithOptionsAsync(MigrateSecurityIPModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MigrateSecurityIPModeResponse>(await DoRPCRequestAsync("MigrateSecurityIPMode", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MigrateSecurityIPModeResponse MigrateSecurityIPMode(MigrateSecurityIPModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MigrateSecurityIPModeWithOptions(request, runtime);
        }

        public async Task<MigrateSecurityIPModeResponse> MigrateSecurityIPModeAsync(MigrateSecurityIPModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MigrateSecurityIPModeWithOptionsAsync(request, runtime);
        }

        public MigrateToOtherZoneResponse MigrateToOtherZoneWithOptions(MigrateToOtherZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MigrateToOtherZoneResponse>(DoRPCRequest("MigrateToOtherZone", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MigrateToOtherZoneResponse> MigrateToOtherZoneWithOptionsAsync(MigrateToOtherZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MigrateToOtherZoneResponse>(await DoRPCRequestAsync("MigrateToOtherZone", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<ModifyAccountDescriptionResponse>(DoRPCRequest("ModifyAccountDescription", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAccountDescriptionResponse> ModifyAccountDescriptionWithOptionsAsync(ModifyAccountDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccountDescriptionResponse>(await DoRPCRequestAsync("ModifyAccountDescription", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyActionEventPolicyResponse ModifyActionEventPolicyWithOptions(ModifyActionEventPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyActionEventPolicyResponse>(DoRPCRequest("ModifyActionEventPolicy", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyActionEventPolicyResponse> ModifyActionEventPolicyWithOptionsAsync(ModifyActionEventPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyActionEventPolicyResponse>(await DoRPCRequestAsync("ModifyActionEventPolicy", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyActionEventPolicyResponse ModifyActionEventPolicy(ModifyActionEventPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyActionEventPolicyWithOptions(request, runtime);
        }

        public async Task<ModifyActionEventPolicyResponse> ModifyActionEventPolicyAsync(ModifyActionEventPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyActionEventPolicyWithOptionsAsync(request, runtime);
        }

        public ModifyBackupPolicyResponse ModifyBackupPolicyWithOptions(ModifyBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupPolicyResponse>(DoRPCRequest("ModifyBackupPolicy", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBackupPolicyResponse> ModifyBackupPolicyWithOptionsAsync(ModifyBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBackupPolicyResponse>(await DoRPCRequestAsync("ModifyBackupPolicy", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyCollationTimeZoneResponse ModifyCollationTimeZoneWithOptions(ModifyCollationTimeZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCollationTimeZoneResponse>(DoRPCRequest("ModifyCollationTimeZone", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCollationTimeZoneResponse> ModifyCollationTimeZoneWithOptionsAsync(ModifyCollationTimeZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCollationTimeZoneResponse>(await DoRPCRequestAsync("ModifyCollationTimeZone", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCollationTimeZoneResponse ModifyCollationTimeZone(ModifyCollationTimeZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCollationTimeZoneWithOptions(request, runtime);
        }

        public async Task<ModifyCollationTimeZoneResponse> ModifyCollationTimeZoneAsync(ModifyCollationTimeZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCollationTimeZoneWithOptionsAsync(request, runtime);
        }

        public ModifyDasInstanceConfigResponse ModifyDasInstanceConfigWithOptions(ModifyDasInstanceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDasInstanceConfigResponse>(DoRPCRequest("ModifyDasInstanceConfig", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDasInstanceConfigResponse> ModifyDasInstanceConfigWithOptionsAsync(ModifyDasInstanceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDasInstanceConfigResponse>(await DoRPCRequestAsync("ModifyDasInstanceConfig", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDasInstanceConfigResponse ModifyDasInstanceConfig(ModifyDasInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDasInstanceConfigWithOptions(request, runtime);
        }

        public async Task<ModifyDasInstanceConfigResponse> ModifyDasInstanceConfigAsync(ModifyDasInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDasInstanceConfigWithOptionsAsync(request, runtime);
        }

        public ModifyDBDescriptionResponse ModifyDBDescriptionWithOptions(ModifyDBDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBDescriptionResponse>(DoRPCRequest("ModifyDBDescription", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBDescriptionResponse> ModifyDBDescriptionWithOptionsAsync(ModifyDBDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBDescriptionResponse>(await DoRPCRequestAsync("ModifyDBDescription", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyDBInstanceAutoUpgradeMinorVersionResponse ModifyDBInstanceAutoUpgradeMinorVersionWithOptions(ModifyDBInstanceAutoUpgradeMinorVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceAutoUpgradeMinorVersionResponse>(DoRPCRequest("ModifyDBInstanceAutoUpgradeMinorVersion", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstanceAutoUpgradeMinorVersionResponse> ModifyDBInstanceAutoUpgradeMinorVersionWithOptionsAsync(ModifyDBInstanceAutoUpgradeMinorVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceAutoUpgradeMinorVersionResponse>(await DoRPCRequestAsync("ModifyDBInstanceAutoUpgradeMinorVersion", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBInstanceAutoUpgradeMinorVersionResponse ModifyDBInstanceAutoUpgradeMinorVersion(ModifyDBInstanceAutoUpgradeMinorVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceAutoUpgradeMinorVersionWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceAutoUpgradeMinorVersionResponse> ModifyDBInstanceAutoUpgradeMinorVersionAsync(ModifyDBInstanceAutoUpgradeMinorVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceAutoUpgradeMinorVersionWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceConnectionModeResponse ModifyDBInstanceConnectionModeWithOptions(ModifyDBInstanceConnectionModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceConnectionModeResponse>(DoRPCRequest("ModifyDBInstanceConnectionMode", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstanceConnectionModeResponse> ModifyDBInstanceConnectionModeWithOptionsAsync(ModifyDBInstanceConnectionModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceConnectionModeResponse>(await DoRPCRequestAsync("ModifyDBInstanceConnectionMode", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBInstanceConnectionModeResponse ModifyDBInstanceConnectionMode(ModifyDBInstanceConnectionModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceConnectionModeWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceConnectionModeResponse> ModifyDBInstanceConnectionModeAsync(ModifyDBInstanceConnectionModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceConnectionModeWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceConnectionStringResponse ModifyDBInstanceConnectionStringWithOptions(ModifyDBInstanceConnectionStringRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceConnectionStringResponse>(DoRPCRequest("ModifyDBInstanceConnectionString", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstanceConnectionStringResponse> ModifyDBInstanceConnectionStringWithOptionsAsync(ModifyDBInstanceConnectionStringRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceConnectionStringResponse>(await DoRPCRequestAsync("ModifyDBInstanceConnectionString", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyDBInstanceDescriptionResponse ModifyDBInstanceDescriptionWithOptions(ModifyDBInstanceDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceDescriptionResponse>(DoRPCRequest("ModifyDBInstanceDescription", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstanceDescriptionResponse> ModifyDBInstanceDescriptionWithOptionsAsync(ModifyDBInstanceDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceDescriptionResponse>(await DoRPCRequestAsync("ModifyDBInstanceDescription", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyDBInstanceHAConfigResponse ModifyDBInstanceHAConfigWithOptions(ModifyDBInstanceHAConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceHAConfigResponse>(DoRPCRequest("ModifyDBInstanceHAConfig", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstanceHAConfigResponse> ModifyDBInstanceHAConfigWithOptionsAsync(ModifyDBInstanceHAConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceHAConfigResponse>(await DoRPCRequestAsync("ModifyDBInstanceHAConfig", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBInstanceHAConfigResponse ModifyDBInstanceHAConfig(ModifyDBInstanceHAConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceHAConfigWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceHAConfigResponse> ModifyDBInstanceHAConfigAsync(ModifyDBInstanceHAConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceHAConfigWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceMaintainTimeResponse ModifyDBInstanceMaintainTimeWithOptions(ModifyDBInstanceMaintainTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceMaintainTimeResponse>(DoRPCRequest("ModifyDBInstanceMaintainTime", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstanceMaintainTimeResponse> ModifyDBInstanceMaintainTimeWithOptionsAsync(ModifyDBInstanceMaintainTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceMaintainTimeResponse>(await DoRPCRequestAsync("ModifyDBInstanceMaintainTime", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyDBInstanceNetworkExpireTimeResponse ModifyDBInstanceNetworkExpireTimeWithOptions(ModifyDBInstanceNetworkExpireTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceNetworkExpireTimeResponse>(DoRPCRequest("ModifyDBInstanceNetworkExpireTime", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstanceNetworkExpireTimeResponse> ModifyDBInstanceNetworkExpireTimeWithOptionsAsync(ModifyDBInstanceNetworkExpireTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceNetworkExpireTimeResponse>(await DoRPCRequestAsync("ModifyDBInstanceNetworkExpireTime", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBInstanceNetworkExpireTimeResponse ModifyDBInstanceNetworkExpireTime(ModifyDBInstanceNetworkExpireTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceNetworkExpireTimeWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceNetworkExpireTimeResponse> ModifyDBInstanceNetworkExpireTimeAsync(ModifyDBInstanceNetworkExpireTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceNetworkExpireTimeWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceNetworkTypeResponse ModifyDBInstanceNetworkTypeWithOptions(ModifyDBInstanceNetworkTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceNetworkTypeResponse>(DoRPCRequest("ModifyDBInstanceNetworkType", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstanceNetworkTypeResponse> ModifyDBInstanceNetworkTypeWithOptionsAsync(ModifyDBInstanceNetworkTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceNetworkTypeResponse>(await DoRPCRequestAsync("ModifyDBInstanceNetworkType", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBInstanceNetworkTypeResponse ModifyDBInstanceNetworkType(ModifyDBInstanceNetworkTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceNetworkTypeWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceNetworkTypeResponse> ModifyDBInstanceNetworkTypeAsync(ModifyDBInstanceNetworkTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceNetworkTypeWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstancePayTypeResponse ModifyDBInstancePayTypeWithOptions(ModifyDBInstancePayTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstancePayTypeResponse>(DoRPCRequest("ModifyDBInstancePayType", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstancePayTypeResponse> ModifyDBInstancePayTypeWithOptionsAsync(ModifyDBInstancePayTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstancePayTypeResponse>(await DoRPCRequestAsync("ModifyDBInstancePayType", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBInstancePayTypeResponse ModifyDBInstancePayType(ModifyDBInstancePayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstancePayTypeWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstancePayTypeResponse> ModifyDBInstancePayTypeAsync(ModifyDBInstancePayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstancePayTypeWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceProxyConfigurationResponse ModifyDBInstanceProxyConfigurationWithOptions(ModifyDBInstanceProxyConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceProxyConfigurationResponse>(DoRPCRequest("ModifyDBInstanceProxyConfiguration", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstanceProxyConfigurationResponse> ModifyDBInstanceProxyConfigurationWithOptionsAsync(ModifyDBInstanceProxyConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceProxyConfigurationResponse>(await DoRPCRequestAsync("ModifyDBInstanceProxyConfiguration", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBInstanceProxyConfigurationResponse ModifyDBInstanceProxyConfiguration(ModifyDBInstanceProxyConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceProxyConfigurationWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceProxyConfigurationResponse> ModifyDBInstanceProxyConfigurationAsync(ModifyDBInstanceProxyConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceProxyConfigurationWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceSpecResponse ModifyDBInstanceSpecWithOptions(ModifyDBInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceSpecResponse>(DoRPCRequest("ModifyDBInstanceSpec", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstanceSpecResponse> ModifyDBInstanceSpecWithOptionsAsync(ModifyDBInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceSpecResponse>(await DoRPCRequestAsync("ModifyDBInstanceSpec", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBInstanceSpecResponse ModifyDBInstanceSpec(ModifyDBInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceSpecWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceSpecResponse> ModifyDBInstanceSpecAsync(ModifyDBInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceSpecWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceSSLResponse ModifyDBInstanceSSLWithOptions(ModifyDBInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceSSLResponse>(DoRPCRequest("ModifyDBInstanceSSL", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstanceSSLResponse> ModifyDBInstanceSSLWithOptionsAsync(ModifyDBInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceSSLResponse>(await DoRPCRequestAsync("ModifyDBInstanceSSL", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBInstanceSSLResponse ModifyDBInstanceSSL(ModifyDBInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceSSLWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceSSLResponse> ModifyDBInstanceSSLAsync(ModifyDBInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceSSLWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceTDEResponse ModifyDBInstanceTDEWithOptions(ModifyDBInstanceTDERequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceTDEResponse>(DoRPCRequest("ModifyDBInstanceTDE", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstanceTDEResponse> ModifyDBInstanceTDEWithOptionsAsync(ModifyDBInstanceTDERequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceTDEResponse>(await DoRPCRequestAsync("ModifyDBInstanceTDE", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBInstanceTDEResponse ModifyDBInstanceTDE(ModifyDBInstanceTDERequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceTDEWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceTDEResponse> ModifyDBInstanceTDEAsync(ModifyDBInstanceTDERequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceTDEWithOptionsAsync(request, runtime);
        }

        public ModifyDBProxyResponse ModifyDBProxyWithOptions(ModifyDBProxyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBProxyResponse>(DoRPCRequest("ModifyDBProxy", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBProxyResponse> ModifyDBProxyWithOptionsAsync(ModifyDBProxyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBProxyResponse>(await DoRPCRequestAsync("ModifyDBProxy", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBProxyResponse ModifyDBProxy(ModifyDBProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBProxyWithOptions(request, runtime);
        }

        public async Task<ModifyDBProxyResponse> ModifyDBProxyAsync(ModifyDBProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBProxyWithOptionsAsync(request, runtime);
        }

        public ModifyDBProxyEndpointResponse ModifyDBProxyEndpointWithOptions(ModifyDBProxyEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBProxyEndpointResponse>(DoRPCRequest("ModifyDBProxyEndpoint", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBProxyEndpointResponse> ModifyDBProxyEndpointWithOptionsAsync(ModifyDBProxyEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBProxyEndpointResponse>(await DoRPCRequestAsync("ModifyDBProxyEndpoint", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBProxyEndpointResponse ModifyDBProxyEndpoint(ModifyDBProxyEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBProxyEndpointWithOptions(request, runtime);
        }

        public async Task<ModifyDBProxyEndpointResponse> ModifyDBProxyEndpointAsync(ModifyDBProxyEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBProxyEndpointWithOptionsAsync(request, runtime);
        }

        public ModifyDBProxyEndpointAddressResponse ModifyDBProxyEndpointAddressWithOptions(ModifyDBProxyEndpointAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBProxyEndpointAddressResponse>(DoRPCRequest("ModifyDBProxyEndpointAddress", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBProxyEndpointAddressResponse> ModifyDBProxyEndpointAddressWithOptionsAsync(ModifyDBProxyEndpointAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBProxyEndpointAddressResponse>(await DoRPCRequestAsync("ModifyDBProxyEndpointAddress", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBProxyEndpointAddressResponse ModifyDBProxyEndpointAddress(ModifyDBProxyEndpointAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBProxyEndpointAddressWithOptions(request, runtime);
        }

        public async Task<ModifyDBProxyEndpointAddressResponse> ModifyDBProxyEndpointAddressAsync(ModifyDBProxyEndpointAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBProxyEndpointAddressWithOptionsAsync(request, runtime);
        }

        public ModifyDBProxyInstanceResponse ModifyDBProxyInstanceWithOptions(ModifyDBProxyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBProxyInstanceResponse>(DoRPCRequest("ModifyDBProxyInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBProxyInstanceResponse> ModifyDBProxyInstanceWithOptionsAsync(ModifyDBProxyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBProxyInstanceResponse>(await DoRPCRequestAsync("ModifyDBProxyInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBProxyInstanceResponse ModifyDBProxyInstance(ModifyDBProxyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBProxyInstanceWithOptions(request, runtime);
        }

        public async Task<ModifyDBProxyInstanceResponse> ModifyDBProxyInstanceAsync(ModifyDBProxyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBProxyInstanceWithOptionsAsync(request, runtime);
        }

        public ModifyDbProxyInstanceSslResponse ModifyDbProxyInstanceSslWithOptions(ModifyDbProxyInstanceSslRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDbProxyInstanceSslResponse>(DoRPCRequest("ModifyDbProxyInstanceSsl", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDbProxyInstanceSslResponse> ModifyDbProxyInstanceSslWithOptionsAsync(ModifyDbProxyInstanceSslRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDbProxyInstanceSslResponse>(await DoRPCRequestAsync("ModifyDbProxyInstanceSsl", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDbProxyInstanceSslResponse ModifyDbProxyInstanceSsl(ModifyDbProxyInstanceSslRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDbProxyInstanceSslWithOptions(request, runtime);
        }

        public async Task<ModifyDbProxyInstanceSslResponse> ModifyDbProxyInstanceSslAsync(ModifyDbProxyInstanceSslRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDbProxyInstanceSslWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostAccountResponse ModifyDedicatedHostAccountWithOptions(ModifyDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostAccountResponse>(DoRPCRequest("ModifyDedicatedHostAccount", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDedicatedHostAccountResponse> ModifyDedicatedHostAccountWithOptionsAsync(ModifyDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostAccountResponse>(await DoRPCRequestAsync("ModifyDedicatedHostAccount", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDedicatedHostAccountResponse ModifyDedicatedHostAccount(ModifyDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostAccountWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostAccountResponse> ModifyDedicatedHostAccountAsync(ModifyDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostAccountWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostAttributeResponse ModifyDedicatedHostAttributeWithOptions(ModifyDedicatedHostAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostAttributeResponse>(DoRPCRequest("ModifyDedicatedHostAttribute", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDedicatedHostAttributeResponse> ModifyDedicatedHostAttributeWithOptionsAsync(ModifyDedicatedHostAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostAttributeResponse>(await DoRPCRequestAsync("ModifyDedicatedHostAttribute", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDedicatedHostAttributeResponse ModifyDedicatedHostAttribute(ModifyDedicatedHostAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostAttributeResponse> ModifyDedicatedHostAttributeAsync(ModifyDedicatedHostAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostGroupAttributeResponse ModifyDedicatedHostGroupAttributeWithOptions(ModifyDedicatedHostGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostGroupAttributeResponse>(DoRPCRequest("ModifyDedicatedHostGroupAttribute", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDedicatedHostGroupAttributeResponse> ModifyDedicatedHostGroupAttributeWithOptionsAsync(ModifyDedicatedHostGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostGroupAttributeResponse>(await DoRPCRequestAsync("ModifyDedicatedHostGroupAttribute", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDedicatedHostGroupAttributeResponse ModifyDedicatedHostGroupAttribute(ModifyDedicatedHostGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostGroupAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostGroupAttributeResponse> ModifyDedicatedHostGroupAttributeAsync(ModifyDedicatedHostGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostGroupAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostUserResponse ModifyDedicatedHostUserWithOptions(ModifyDedicatedHostUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostUserResponse>(DoRPCRequest("ModifyDedicatedHostUser", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDedicatedHostUserResponse> ModifyDedicatedHostUserWithOptionsAsync(ModifyDedicatedHostUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostUserResponse>(await DoRPCRequestAsync("ModifyDedicatedHostUser", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDedicatedHostUserResponse ModifyDedicatedHostUser(ModifyDedicatedHostUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostUserWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostUserResponse> ModifyDedicatedHostUserAsync(ModifyDedicatedHostUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostUserWithOptionsAsync(request, runtime);
        }

        public ModifyDTCSecurityIpHostsForSQLServerResponse ModifyDTCSecurityIpHostsForSQLServerWithOptions(ModifyDTCSecurityIpHostsForSQLServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDTCSecurityIpHostsForSQLServerResponse>(DoRPCRequest("ModifyDTCSecurityIpHostsForSQLServer", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDTCSecurityIpHostsForSQLServerResponse> ModifyDTCSecurityIpHostsForSQLServerWithOptionsAsync(ModifyDTCSecurityIpHostsForSQLServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDTCSecurityIpHostsForSQLServerResponse>(await DoRPCRequestAsync("ModifyDTCSecurityIpHostsForSQLServer", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDTCSecurityIpHostsForSQLServerResponse ModifyDTCSecurityIpHostsForSQLServer(ModifyDTCSecurityIpHostsForSQLServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDTCSecurityIpHostsForSQLServerWithOptions(request, runtime);
        }

        public async Task<ModifyDTCSecurityIpHostsForSQLServerResponse> ModifyDTCSecurityIpHostsForSQLServerAsync(ModifyDTCSecurityIpHostsForSQLServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDTCSecurityIpHostsForSQLServerWithOptionsAsync(request, runtime);
        }

        public ModifyHADiagnoseConfigResponse ModifyHADiagnoseConfigWithOptions(ModifyHADiagnoseConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHADiagnoseConfigResponse>(DoRPCRequest("ModifyHADiagnoseConfig", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHADiagnoseConfigResponse> ModifyHADiagnoseConfigWithOptionsAsync(ModifyHADiagnoseConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHADiagnoseConfigResponse>(await DoRPCRequestAsync("ModifyHADiagnoseConfig", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHADiagnoseConfigResponse ModifyHADiagnoseConfig(ModifyHADiagnoseConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHADiagnoseConfigWithOptions(request, runtime);
        }

        public async Task<ModifyHADiagnoseConfigResponse> ModifyHADiagnoseConfigAsync(ModifyHADiagnoseConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHADiagnoseConfigWithOptionsAsync(request, runtime);
        }

        public ModifyHASwitchConfigResponse ModifyHASwitchConfigWithOptions(ModifyHASwitchConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHASwitchConfigResponse>(DoRPCRequest("ModifyHASwitchConfig", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHASwitchConfigResponse> ModifyHASwitchConfigWithOptionsAsync(ModifyHASwitchConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHASwitchConfigResponse>(await DoRPCRequestAsync("ModifyHASwitchConfig", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHASwitchConfigResponse ModifyHASwitchConfig(ModifyHASwitchConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHASwitchConfigWithOptions(request, runtime);
        }

        public async Task<ModifyHASwitchConfigResponse> ModifyHASwitchConfigAsync(ModifyHASwitchConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHASwitchConfigWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceAutoRenewalAttributeResponse ModifyInstanceAutoRenewalAttributeWithOptions(ModifyInstanceAutoRenewalAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAutoRenewalAttributeResponse>(DoRPCRequest("ModifyInstanceAutoRenewalAttribute", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceAutoRenewalAttributeResponse> ModifyInstanceAutoRenewalAttributeWithOptionsAsync(ModifyInstanceAutoRenewalAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAutoRenewalAttributeResponse>(await DoRPCRequestAsync("ModifyInstanceAutoRenewalAttribute", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyInstanceCrossBackupPolicyResponse ModifyInstanceCrossBackupPolicyWithOptions(ModifyInstanceCrossBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceCrossBackupPolicyResponse>(DoRPCRequest("ModifyInstanceCrossBackupPolicy", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceCrossBackupPolicyResponse> ModifyInstanceCrossBackupPolicyWithOptionsAsync(ModifyInstanceCrossBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceCrossBackupPolicyResponse>(await DoRPCRequestAsync("ModifyInstanceCrossBackupPolicy", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceCrossBackupPolicyResponse ModifyInstanceCrossBackupPolicy(ModifyInstanceCrossBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceCrossBackupPolicyWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceCrossBackupPolicyResponse> ModifyInstanceCrossBackupPolicyAsync(ModifyInstanceCrossBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceCrossBackupPolicyWithOptionsAsync(request, runtime);
        }

        public ModifyParameterResponse ModifyParameterWithOptions(ModifyParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyParameterResponse>(DoRPCRequest("ModifyParameter", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyParameterResponse> ModifyParameterWithOptionsAsync(ModifyParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyParameterResponse>(await DoRPCRequestAsync("ModifyParameter", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyParameterGroupResponse ModifyParameterGroupWithOptions(ModifyParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyParameterGroupResponse>(DoRPCRequest("ModifyParameterGroup", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyParameterGroupResponse> ModifyParameterGroupWithOptionsAsync(ModifyParameterGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyParameterGroupResponse>(await DoRPCRequestAsync("ModifyParameterGroup", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyParameterGroupResponse ModifyParameterGroup(ModifyParameterGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyParameterGroupWithOptions(request, runtime);
        }

        public async Task<ModifyParameterGroupResponse> ModifyParameterGroupAsync(ModifyParameterGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyParameterGroupWithOptionsAsync(request, runtime);
        }

        public ModifyReadonlyInstanceDelayReplicationTimeResponse ModifyReadonlyInstanceDelayReplicationTimeWithOptions(ModifyReadonlyInstanceDelayReplicationTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyReadonlyInstanceDelayReplicationTimeResponse>(DoRPCRequest("ModifyReadonlyInstanceDelayReplicationTime", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyReadonlyInstanceDelayReplicationTimeResponse> ModifyReadonlyInstanceDelayReplicationTimeWithOptionsAsync(ModifyReadonlyInstanceDelayReplicationTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyReadonlyInstanceDelayReplicationTimeResponse>(await DoRPCRequestAsync("ModifyReadonlyInstanceDelayReplicationTime", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyReadonlyInstanceDelayReplicationTimeResponse ModifyReadonlyInstanceDelayReplicationTime(ModifyReadonlyInstanceDelayReplicationTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyReadonlyInstanceDelayReplicationTimeWithOptions(request, runtime);
        }

        public async Task<ModifyReadonlyInstanceDelayReplicationTimeResponse> ModifyReadonlyInstanceDelayReplicationTimeAsync(ModifyReadonlyInstanceDelayReplicationTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyReadonlyInstanceDelayReplicationTimeWithOptionsAsync(request, runtime);
        }

        public ModifyReadWriteSplittingConnectionResponse ModifyReadWriteSplittingConnectionWithOptions(ModifyReadWriteSplittingConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyReadWriteSplittingConnectionResponse>(DoRPCRequest("ModifyReadWriteSplittingConnection", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyReadWriteSplittingConnectionResponse> ModifyReadWriteSplittingConnectionWithOptionsAsync(ModifyReadWriteSplittingConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyReadWriteSplittingConnectionResponse>(await DoRPCRequestAsync("ModifyReadWriteSplittingConnection", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyReadWriteSplittingConnectionResponse ModifyReadWriteSplittingConnection(ModifyReadWriteSplittingConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyReadWriteSplittingConnectionWithOptions(request, runtime);
        }

        public async Task<ModifyReadWriteSplittingConnectionResponse> ModifyReadWriteSplittingConnectionAsync(ModifyReadWriteSplittingConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyReadWriteSplittingConnectionWithOptionsAsync(request, runtime);
        }

        public ModifyResourceGroupResponse ModifyResourceGroupWithOptions(ModifyResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyResourceGroupResponse>(DoRPCRequest("ModifyResourceGroup", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyResourceGroupResponse> ModifyResourceGroupWithOptionsAsync(ModifyResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyResourceGroupResponse>(await DoRPCRequestAsync("ModifyResourceGroup", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<ModifySecurityGroupConfigurationResponse>(DoRPCRequest("ModifySecurityGroupConfiguration", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySecurityGroupConfigurationResponse> ModifySecurityGroupConfigurationWithOptionsAsync(ModifySecurityGroupConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySecurityGroupConfigurationResponse>(await DoRPCRequestAsync("ModifySecurityGroupConfiguration", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<ModifySecurityIpsResponse>(DoRPCRequest("ModifySecurityIps", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySecurityIpsResponse> ModifySecurityIpsWithOptionsAsync(ModifySecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySecurityIpsResponse>(await DoRPCRequestAsync("ModifySecurityIps", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifySQLCollectorPolicyResponse ModifySQLCollectorPolicyWithOptions(ModifySQLCollectorPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySQLCollectorPolicyResponse>(DoRPCRequest("ModifySQLCollectorPolicy", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySQLCollectorPolicyResponse> ModifySQLCollectorPolicyWithOptionsAsync(ModifySQLCollectorPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySQLCollectorPolicyResponse>(await DoRPCRequestAsync("ModifySQLCollectorPolicy", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySQLCollectorPolicyResponse ModifySQLCollectorPolicy(ModifySQLCollectorPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySQLCollectorPolicyWithOptions(request, runtime);
        }

        public async Task<ModifySQLCollectorPolicyResponse> ModifySQLCollectorPolicyAsync(ModifySQLCollectorPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySQLCollectorPolicyWithOptionsAsync(request, runtime);
        }

        public ModifySQLCollectorRetentionResponse ModifySQLCollectorRetentionWithOptions(ModifySQLCollectorRetentionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySQLCollectorRetentionResponse>(DoRPCRequest("ModifySQLCollectorRetention", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySQLCollectorRetentionResponse> ModifySQLCollectorRetentionWithOptionsAsync(ModifySQLCollectorRetentionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySQLCollectorRetentionResponse>(await DoRPCRequestAsync("ModifySQLCollectorRetention", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySQLCollectorRetentionResponse ModifySQLCollectorRetention(ModifySQLCollectorRetentionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySQLCollectorRetentionWithOptions(request, runtime);
        }

        public async Task<ModifySQLCollectorRetentionResponse> ModifySQLCollectorRetentionAsync(ModifySQLCollectorRetentionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySQLCollectorRetentionWithOptionsAsync(request, runtime);
        }

        public PurgeDBInstanceLogResponse PurgeDBInstanceLogWithOptions(PurgeDBInstanceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PurgeDBInstanceLogResponse>(DoRPCRequest("PurgeDBInstanceLog", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PurgeDBInstanceLogResponse> PurgeDBInstanceLogWithOptionsAsync(PurgeDBInstanceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PurgeDBInstanceLogResponse>(await DoRPCRequestAsync("PurgeDBInstanceLog", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PurgeDBInstanceLogResponse PurgeDBInstanceLog(PurgeDBInstanceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PurgeDBInstanceLogWithOptions(request, runtime);
        }

        public async Task<PurgeDBInstanceLogResponse> PurgeDBInstanceLogAsync(PurgeDBInstanceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PurgeDBInstanceLogWithOptionsAsync(request, runtime);
        }

        public RebuildDBInstanceResponse RebuildDBInstanceWithOptions(RebuildDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RebuildDBInstanceResponse>(DoRPCRequest("RebuildDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RebuildDBInstanceResponse> RebuildDBInstanceWithOptionsAsync(RebuildDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RebuildDBInstanceResponse>(await DoRPCRequestAsync("RebuildDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RebuildDBInstanceResponse RebuildDBInstance(RebuildDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebuildDBInstanceWithOptions(request, runtime);
        }

        public async Task<RebuildDBInstanceResponse> RebuildDBInstanceAsync(RebuildDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebuildDBInstanceWithOptionsAsync(request, runtime);
        }

        public RecoveryDBInstanceResponse RecoveryDBInstanceWithOptions(RecoveryDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecoveryDBInstanceResponse>(DoRPCRequest("RecoveryDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RecoveryDBInstanceResponse> RecoveryDBInstanceWithOptionsAsync(RecoveryDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecoveryDBInstanceResponse>(await DoRPCRequestAsync("RecoveryDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RecoveryDBInstanceResponse RecoveryDBInstance(RecoveryDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecoveryDBInstanceWithOptions(request, runtime);
        }

        public async Task<RecoveryDBInstanceResponse> RecoveryDBInstanceAsync(RecoveryDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecoveryDBInstanceWithOptionsAsync(request, runtime);
        }

        public ReleaseInstanceConnectionResponse ReleaseInstanceConnectionWithOptions(ReleaseInstanceConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseInstanceConnectionResponse>(DoRPCRequest("ReleaseInstanceConnection", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseInstanceConnectionResponse> ReleaseInstanceConnectionWithOptionsAsync(ReleaseInstanceConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseInstanceConnectionResponse>(await DoRPCRequestAsync("ReleaseInstanceConnection", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleaseInstanceConnectionResponse ReleaseInstanceConnection(ReleaseInstanceConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseInstanceConnectionWithOptions(request, runtime);
        }

        public async Task<ReleaseInstanceConnectionResponse> ReleaseInstanceConnectionAsync(ReleaseInstanceConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseInstanceConnectionWithOptionsAsync(request, runtime);
        }

        public ReleaseInstancePublicConnectionResponse ReleaseInstancePublicConnectionWithOptions(ReleaseInstancePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseInstancePublicConnectionResponse>(DoRPCRequest("ReleaseInstancePublicConnection", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseInstancePublicConnectionResponse> ReleaseInstancePublicConnectionWithOptionsAsync(ReleaseInstancePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseInstancePublicConnectionResponse>(await DoRPCRequestAsync("ReleaseInstancePublicConnection", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ReleaseReadWriteSplittingConnectionResponse ReleaseReadWriteSplittingConnectionWithOptions(ReleaseReadWriteSplittingConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseReadWriteSplittingConnectionResponse>(DoRPCRequest("ReleaseReadWriteSplittingConnection", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseReadWriteSplittingConnectionResponse> ReleaseReadWriteSplittingConnectionWithOptionsAsync(ReleaseReadWriteSplittingConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseReadWriteSplittingConnectionResponse>(await DoRPCRequestAsync("ReleaseReadWriteSplittingConnection", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleaseReadWriteSplittingConnectionResponse ReleaseReadWriteSplittingConnection(ReleaseReadWriteSplittingConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseReadWriteSplittingConnectionWithOptions(request, runtime);
        }

        public async Task<ReleaseReadWriteSplittingConnectionResponse> ReleaseReadWriteSplittingConnectionAsync(ReleaseReadWriteSplittingConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseReadWriteSplittingConnectionWithOptionsAsync(request, runtime);
        }

        public RemoveTagsFromResourceResponse RemoveTagsFromResourceWithOptions(RemoveTagsFromResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveTagsFromResourceResponse>(DoRPCRequest("RemoveTagsFromResource", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceWithOptionsAsync(RemoveTagsFromResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveTagsFromResourceResponse>(await DoRPCRequestAsync("RemoveTagsFromResource", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTagsFromResourceWithOptions(request, runtime);
        }

        public async Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTagsFromResourceWithOptionsAsync(request, runtime);
        }

        public RenewInstanceResponse RenewInstanceWithOptions(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewInstanceResponse>(DoRPCRequest("RenewInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenewInstanceResponse> RenewInstanceWithOptionsAsync(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewInstanceResponse>(await DoRPCRequestAsync("RenewInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ReplaceDedicatedHostResponse ReplaceDedicatedHostWithOptions(ReplaceDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReplaceDedicatedHostResponse>(DoRPCRequest("ReplaceDedicatedHost", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReplaceDedicatedHostResponse> ReplaceDedicatedHostWithOptionsAsync(ReplaceDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReplaceDedicatedHostResponse>(await DoRPCRequestAsync("ReplaceDedicatedHost", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReplaceDedicatedHostResponse ReplaceDedicatedHost(ReplaceDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReplaceDedicatedHostWithOptions(request, runtime);
        }

        public async Task<ReplaceDedicatedHostResponse> ReplaceDedicatedHostAsync(ReplaceDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReplaceDedicatedHostWithOptionsAsync(request, runtime);
        }

        public ResetAccountResponse ResetAccountWithOptions(ResetAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetAccountResponse>(DoRPCRequest("ResetAccount", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetAccountResponse> ResetAccountWithOptionsAsync(ResetAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetAccountResponse>(await DoRPCRequestAsync("ResetAccount", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ResetAccountPasswordResponse ResetAccountPasswordWithOptions(ResetAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetAccountPasswordResponse>(DoRPCRequest("ResetAccountPassword", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetAccountPasswordResponse> ResetAccountPasswordWithOptionsAsync(ResetAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetAccountPasswordResponse>(await DoRPCRequestAsync("ResetAccountPassword", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<RestartDBInstanceResponse>(DoRPCRequest("RestartDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestartDBInstanceResponse> RestartDBInstanceWithOptionsAsync(RestartDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartDBInstanceResponse>(await DoRPCRequestAsync("RestartDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public RestartDedicatedHostResponse RestartDedicatedHostWithOptions(RestartDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartDedicatedHostResponse>(DoRPCRequest("RestartDedicatedHost", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestartDedicatedHostResponse> RestartDedicatedHostWithOptionsAsync(RestartDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartDedicatedHostResponse>(await DoRPCRequestAsync("RestartDedicatedHost", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RestartDedicatedHostResponse RestartDedicatedHost(RestartDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartDedicatedHostWithOptions(request, runtime);
        }

        public async Task<RestartDedicatedHostResponse> RestartDedicatedHostAsync(RestartDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartDedicatedHostWithOptionsAsync(request, runtime);
        }

        public RestoreDdrTableResponse RestoreDdrTableWithOptions(RestoreDdrTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestoreDdrTableResponse>(DoRPCRequest("RestoreDdrTable", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestoreDdrTableResponse> RestoreDdrTableWithOptionsAsync(RestoreDdrTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestoreDdrTableResponse>(await DoRPCRequestAsync("RestoreDdrTable", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RestoreDdrTableResponse RestoreDdrTable(RestoreDdrTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestoreDdrTableWithOptions(request, runtime);
        }

        public async Task<RestoreDdrTableResponse> RestoreDdrTableAsync(RestoreDdrTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestoreDdrTableWithOptionsAsync(request, runtime);
        }

        public RestoreTableResponse RestoreTableWithOptions(RestoreTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestoreTableResponse>(DoRPCRequest("RestoreTable", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestoreTableResponse> RestoreTableWithOptionsAsync(RestoreTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestoreTableResponse>(await DoRPCRequestAsync("RestoreTable", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<RevokeAccountPrivilegeResponse>(DoRPCRequest("RevokeAccountPrivilege", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RevokeAccountPrivilegeResponse> RevokeAccountPrivilegeWithOptionsAsync(RevokeAccountPrivilegeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeAccountPrivilegeResponse>(await DoRPCRequestAsync("RevokeAccountPrivilege", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public RevokeOperatorPermissionResponse RevokeOperatorPermissionWithOptions(RevokeOperatorPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeOperatorPermissionResponse>(DoRPCRequest("RevokeOperatorPermission", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RevokeOperatorPermissionResponse> RevokeOperatorPermissionWithOptionsAsync(RevokeOperatorPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeOperatorPermissionResponse>(await DoRPCRequestAsync("RevokeOperatorPermission", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RevokeOperatorPermissionResponse RevokeOperatorPermission(RevokeOperatorPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeOperatorPermissionWithOptions(request, runtime);
        }

        public async Task<RevokeOperatorPermissionResponse> RevokeOperatorPermissionAsync(RevokeOperatorPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeOperatorPermissionWithOptionsAsync(request, runtime);
        }

        public StartDBInstanceResponse StartDBInstanceWithOptions(StartDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartDBInstanceResponse>(DoRPCRequest("StartDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartDBInstanceResponse> StartDBInstanceWithOptionsAsync(StartDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartDBInstanceResponse>(await DoRPCRequestAsync("StartDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartDBInstanceResponse StartDBInstance(StartDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDBInstanceWithOptions(request, runtime);
        }

        public async Task<StartDBInstanceResponse> StartDBInstanceAsync(StartDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDBInstanceWithOptionsAsync(request, runtime);
        }

        public StopDBInstanceResponse StopDBInstanceWithOptions(StopDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDBInstanceResponse>(DoRPCRequest("StopDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopDBInstanceResponse> StopDBInstanceWithOptionsAsync(StopDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDBInstanceResponse>(await DoRPCRequestAsync("StopDBInstance", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopDBInstanceResponse StopDBInstance(StopDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDBInstanceWithOptions(request, runtime);
        }

        public async Task<StopDBInstanceResponse> StopDBInstanceAsync(StopDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDBInstanceWithOptionsAsync(request, runtime);
        }

        public SwitchDBInstanceHAResponse SwitchDBInstanceHAWithOptions(SwitchDBInstanceHARequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchDBInstanceHAResponse>(DoRPCRequest("SwitchDBInstanceHA", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SwitchDBInstanceHAResponse> SwitchDBInstanceHAWithOptionsAsync(SwitchDBInstanceHARequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchDBInstanceHAResponse>(await DoRPCRequestAsync("SwitchDBInstanceHA", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SwitchDBInstanceHAResponse SwitchDBInstanceHA(SwitchDBInstanceHARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchDBInstanceHAWithOptions(request, runtime);
        }

        public async Task<SwitchDBInstanceHAResponse> SwitchDBInstanceHAAsync(SwitchDBInstanceHARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchDBInstanceHAWithOptionsAsync(request, runtime);
        }

        public SwitchDBInstanceNetTypeResponse SwitchDBInstanceNetTypeWithOptions(SwitchDBInstanceNetTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchDBInstanceNetTypeResponse>(DoRPCRequest("SwitchDBInstanceNetType", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SwitchDBInstanceNetTypeResponse> SwitchDBInstanceNetTypeWithOptionsAsync(SwitchDBInstanceNetTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchDBInstanceNetTypeResponse>(await DoRPCRequestAsync("SwitchDBInstanceNetType", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SwitchDBInstanceNetTypeResponse SwitchDBInstanceNetType(SwitchDBInstanceNetTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchDBInstanceNetTypeWithOptions(request, runtime);
        }

        public async Task<SwitchDBInstanceNetTypeResponse> SwitchDBInstanceNetTypeAsync(SwitchDBInstanceNetTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchDBInstanceNetTypeWithOptionsAsync(request, runtime);
        }

        public SwitchDBInstanceVpcResponse SwitchDBInstanceVpcWithOptions(SwitchDBInstanceVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchDBInstanceVpcResponse>(DoRPCRequest("SwitchDBInstanceVpc", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SwitchDBInstanceVpcResponse> SwitchDBInstanceVpcWithOptionsAsync(SwitchDBInstanceVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchDBInstanceVpcResponse>(await DoRPCRequestAsync("SwitchDBInstanceVpc", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SwitchDBInstanceVpcResponse SwitchDBInstanceVpc(SwitchDBInstanceVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchDBInstanceVpcWithOptions(request, runtime);
        }

        public async Task<SwitchDBInstanceVpcResponse> SwitchDBInstanceVpcAsync(SwitchDBInstanceVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchDBInstanceVpcWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public TerminateMigrateTaskResponse TerminateMigrateTaskWithOptions(TerminateMigrateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TerminateMigrateTaskResponse>(DoRPCRequest("TerminateMigrateTask", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TerminateMigrateTaskResponse> TerminateMigrateTaskWithOptionsAsync(TerminateMigrateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TerminateMigrateTaskResponse>(await DoRPCRequestAsync("TerminateMigrateTask", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TerminateMigrateTaskResponse TerminateMigrateTask(TerminateMigrateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TerminateMigrateTaskWithOptions(request, runtime);
        }

        public async Task<TerminateMigrateTaskResponse> TerminateMigrateTaskAsync(TerminateMigrateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TerminateMigrateTaskWithOptionsAsync(request, runtime);
        }

        public TransformDBInstancePayTypeResponse TransformDBInstancePayTypeWithOptions(TransformDBInstancePayTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransformDBInstancePayTypeResponse>(DoRPCRequest("TransformDBInstancePayType", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TransformDBInstancePayTypeResponse> TransformDBInstancePayTypeWithOptionsAsync(TransformDBInstancePayTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransformDBInstancePayTypeResponse>(await DoRPCRequestAsync("TransformDBInstancePayType", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TransformDBInstancePayTypeResponse TransformDBInstancePayType(TransformDBInstancePayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransformDBInstancePayTypeWithOptions(request, runtime);
        }

        public async Task<TransformDBInstancePayTypeResponse> TransformDBInstancePayTypeAsync(TransformDBInstancePayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransformDBInstancePayTypeWithOptionsAsync(request, runtime);
        }

        public UnlockAccountResponse UnlockAccountWithOptions(UnlockAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnlockAccountResponse>(DoRPCRequest("UnlockAccount", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnlockAccountResponse> UnlockAccountWithOptionsAsync(UnlockAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnlockAccountResponse>(await DoRPCRequestAsync("UnlockAccount", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnlockAccountResponse UnlockAccount(UnlockAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnlockAccountWithOptions(request, runtime);
        }

        public async Task<UnlockAccountResponse> UnlockAccountAsync(UnlockAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnlockAccountWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UpgradeDBInstanceEngineVersionResponse UpgradeDBInstanceEngineVersionWithOptions(UpgradeDBInstanceEngineVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeDBInstanceEngineVersionResponse>(DoRPCRequest("UpgradeDBInstanceEngineVersion", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeDBInstanceEngineVersionResponse> UpgradeDBInstanceEngineVersionWithOptionsAsync(UpgradeDBInstanceEngineVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeDBInstanceEngineVersionResponse>(await DoRPCRequestAsync("UpgradeDBInstanceEngineVersion", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeDBInstanceEngineVersionResponse UpgradeDBInstanceEngineVersion(UpgradeDBInstanceEngineVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeDBInstanceEngineVersionWithOptions(request, runtime);
        }

        public async Task<UpgradeDBInstanceEngineVersionResponse> UpgradeDBInstanceEngineVersionAsync(UpgradeDBInstanceEngineVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeDBInstanceEngineVersionWithOptionsAsync(request, runtime);
        }

        public UpgradeDBInstanceKernelVersionResponse UpgradeDBInstanceKernelVersionWithOptions(UpgradeDBInstanceKernelVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeDBInstanceKernelVersionResponse>(DoRPCRequest("UpgradeDBInstanceKernelVersion", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeDBInstanceKernelVersionResponse> UpgradeDBInstanceKernelVersionWithOptionsAsync(UpgradeDBInstanceKernelVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeDBInstanceKernelVersionResponse>(await DoRPCRequestAsync("UpgradeDBInstanceKernelVersion", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UpgradeDBProxyInstanceKernelVersionResponse UpgradeDBProxyInstanceKernelVersionWithOptions(UpgradeDBProxyInstanceKernelVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeDBProxyInstanceKernelVersionResponse>(DoRPCRequest("UpgradeDBProxyInstanceKernelVersion", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeDBProxyInstanceKernelVersionResponse> UpgradeDBProxyInstanceKernelVersionWithOptionsAsync(UpgradeDBProxyInstanceKernelVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeDBProxyInstanceKernelVersionResponse>(await DoRPCRequestAsync("UpgradeDBProxyInstanceKernelVersion", "2014-08-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeDBProxyInstanceKernelVersionResponse UpgradeDBProxyInstanceKernelVersion(UpgradeDBProxyInstanceKernelVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeDBProxyInstanceKernelVersionWithOptions(request, runtime);
        }

        public async Task<UpgradeDBProxyInstanceKernelVersionResponse> UpgradeDBProxyInstanceKernelVersionAsync(UpgradeDBProxyInstanceKernelVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeDBProxyInstanceKernelVersionWithOptionsAsync(request, runtime);
        }

    }
}
