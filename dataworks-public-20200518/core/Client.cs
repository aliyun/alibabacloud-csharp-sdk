// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dataworks_public20200518.Models;

namespace AlibabaCloud.SDK.Dataworks_public20200518
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "dataworks.ap-northeast-1.aliyuncs.com"},
                {"ap-south-1", "dataworks.ap-south-1.aliyuncs.com"},
                {"ap-southeast-1", "dataworks.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "dataworks.ap-southeast-2.aliyuncs.com"},
                {"ap-southeast-3", "dataworks.ap-southeast-3.aliyuncs.com"},
                {"ap-southeast-5", "dataworks.ap-southeast-5.aliyuncs.com"},
                {"cn-beijing", "dataworks.cn-beijing.aliyuncs.com"},
                {"cn-chengdu", "dataworks.cn-chengdu.aliyuncs.com"},
                {"cn-hangzhou", "dataworks.cn-hangzhou.aliyuncs.com"},
                {"cn-hongkong", "dataworks.cn-hongkong.aliyuncs.com"},
                {"cn-huhehaote", "dataworks.aliyuncs.com"},
                {"cn-qingdao", "dataworks.aliyuncs.com"},
                {"cn-shanghai", "dataworks.cn-shanghai.aliyuncs.com"},
                {"cn-shenzhen", "dataworks.cn-shenzhen.aliyuncs.com"},
                {"cn-zhangjiakou", "dataworks.aliyuncs.com"},
                {"eu-central-1", "dataworks.eu-central-1.aliyuncs.com"},
                {"eu-west-1", "dataworks.eu-west-1.aliyuncs.com"},
                {"me-east-1", "dataworks.me-east-1.aliyuncs.com"},
                {"us-east-1", "dataworks.us-east-1.aliyuncs.com"},
                {"us-west-1", "dataworks.us-west-1.aliyuncs.com"},
                {"cn-hangzhou-finance", "dataworks.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "dataworks.aliyuncs.com"},
                {"cn-shanghai-finance-1", "dataworks.aliyuncs.com"},
                {"cn-north-2-gov-1", "dataworks.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("dataworks-public", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AbolishDataServiceApiResponse AbolishDataServiceApiWithOptions(AbolishDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AbolishDataServiceApiResponse>(DoRPCRequest("AbolishDataServiceApi", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AbolishDataServiceApiResponse> AbolishDataServiceApiWithOptionsAsync(AbolishDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AbolishDataServiceApiResponse>(await DoRPCRequestAsync("AbolishDataServiceApi", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AbolishDataServiceApiResponse AbolishDataServiceApi(AbolishDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AbolishDataServiceApiWithOptions(request, runtime);
        }

        public async Task<AbolishDataServiceApiResponse> AbolishDataServiceApiAsync(AbolishDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AbolishDataServiceApiWithOptionsAsync(request, runtime);
        }

        public AddProjectMemberToRoleResponse AddProjectMemberToRoleWithOptions(AddProjectMemberToRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddProjectMemberToRoleResponse>(DoRPCRequest("AddProjectMemberToRole", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddProjectMemberToRoleResponse> AddProjectMemberToRoleWithOptionsAsync(AddProjectMemberToRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddProjectMemberToRoleResponse>(await DoRPCRequestAsync("AddProjectMemberToRole", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddProjectMemberToRoleResponse AddProjectMemberToRole(AddProjectMemberToRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddProjectMemberToRoleWithOptions(request, runtime);
        }

        public async Task<AddProjectMemberToRoleResponse> AddProjectMemberToRoleAsync(AddProjectMemberToRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddProjectMemberToRoleWithOptionsAsync(request, runtime);
        }

        public AddToMetaCategoryResponse AddToMetaCategoryWithOptions(AddToMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddToMetaCategoryResponse>(DoRPCRequest("AddToMetaCategory", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddToMetaCategoryResponse> AddToMetaCategoryWithOptionsAsync(AddToMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddToMetaCategoryResponse>(await DoRPCRequestAsync("AddToMetaCategory", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddToMetaCategoryResponse AddToMetaCategory(AddToMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddToMetaCategoryWithOptions(request, runtime);
        }

        public async Task<AddToMetaCategoryResponse> AddToMetaCategoryAsync(AddToMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddToMetaCategoryWithOptionsAsync(request, runtime);
        }

        public ApprovePermissionApplyOrderResponse ApprovePermissionApplyOrderWithOptions(ApprovePermissionApplyOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApprovePermissionApplyOrderResponse>(DoRPCRequest("ApprovePermissionApplyOrder", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ApprovePermissionApplyOrderResponse> ApprovePermissionApplyOrderWithOptionsAsync(ApprovePermissionApplyOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApprovePermissionApplyOrderResponse>(await DoRPCRequestAsync("ApprovePermissionApplyOrder", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ApprovePermissionApplyOrderResponse ApprovePermissionApplyOrder(ApprovePermissionApplyOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApprovePermissionApplyOrderWithOptions(request, runtime);
        }

        public async Task<ApprovePermissionApplyOrderResponse> ApprovePermissionApplyOrderAsync(ApprovePermissionApplyOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApprovePermissionApplyOrderWithOptionsAsync(request, runtime);
        }

        public CheckEngineMetaPartitionResponse CheckEngineMetaPartitionWithOptions(CheckEngineMetaPartitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckEngineMetaPartitionResponse>(DoRPCRequest("CheckEngineMetaPartition", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckEngineMetaPartitionResponse> CheckEngineMetaPartitionWithOptionsAsync(CheckEngineMetaPartitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckEngineMetaPartitionResponse>(await DoRPCRequestAsync("CheckEngineMetaPartition", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckEngineMetaPartitionResponse CheckEngineMetaPartition(CheckEngineMetaPartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckEngineMetaPartitionWithOptions(request, runtime);
        }

        public async Task<CheckEngineMetaPartitionResponse> CheckEngineMetaPartitionAsync(CheckEngineMetaPartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckEngineMetaPartitionWithOptionsAsync(request, runtime);
        }

        public CheckEngineMetaTableResponse CheckEngineMetaTableWithOptions(CheckEngineMetaTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckEngineMetaTableResponse>(DoRPCRequest("CheckEngineMetaTable", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckEngineMetaTableResponse> CheckEngineMetaTableWithOptionsAsync(CheckEngineMetaTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckEngineMetaTableResponse>(await DoRPCRequestAsync("CheckEngineMetaTable", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckEngineMetaTableResponse CheckEngineMetaTable(CheckEngineMetaTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckEngineMetaTableWithOptions(request, runtime);
        }

        public async Task<CheckEngineMetaTableResponse> CheckEngineMetaTableAsync(CheckEngineMetaTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckEngineMetaTableWithOptionsAsync(request, runtime);
        }

        public CheckFileDeploymentResponse CheckFileDeploymentWithOptions(CheckFileDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckFileDeploymentResponse>(DoRPCRequest("CheckFileDeployment", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckFileDeploymentResponse> CheckFileDeploymentWithOptionsAsync(CheckFileDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckFileDeploymentResponse>(await DoRPCRequestAsync("CheckFileDeployment", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckFileDeploymentResponse CheckFileDeployment(CheckFileDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckFileDeploymentWithOptions(request, runtime);
        }

        public async Task<CheckFileDeploymentResponse> CheckFileDeploymentAsync(CheckFileDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckFileDeploymentWithOptionsAsync(request, runtime);
        }

        public CheckMetaPartitionResponse CheckMetaPartitionWithOptions(CheckMetaPartitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckMetaPartitionResponse>(DoRPCRequest("CheckMetaPartition", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckMetaPartitionResponse> CheckMetaPartitionWithOptionsAsync(CheckMetaPartitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckMetaPartitionResponse>(await DoRPCRequestAsync("CheckMetaPartition", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckMetaPartitionResponse CheckMetaPartition(CheckMetaPartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckMetaPartitionWithOptions(request, runtime);
        }

        public async Task<CheckMetaPartitionResponse> CheckMetaPartitionAsync(CheckMetaPartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckMetaPartitionWithOptionsAsync(request, runtime);
        }

        public CheckMetaTableResponse CheckMetaTableWithOptions(CheckMetaTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckMetaTableResponse>(DoRPCRequest("CheckMetaTable", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckMetaTableResponse> CheckMetaTableWithOptionsAsync(CheckMetaTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckMetaTableResponse>(await DoRPCRequestAsync("CheckMetaTable", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckMetaTableResponse CheckMetaTable(CheckMetaTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckMetaTableWithOptions(request, runtime);
        }

        public async Task<CheckMetaTableResponse> CheckMetaTableAsync(CheckMetaTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckMetaTableWithOptionsAsync(request, runtime);
        }

        public CheckMetaTableTaskResponse CheckMetaTableTaskWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<CheckMetaTableTaskResponse>(DoRPCRequest("CheckMetaTableTask", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckMetaTableTaskResponse> CheckMetaTableTaskWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<CheckMetaTableTaskResponse>(await DoRPCRequestAsync("CheckMetaTableTask", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckMetaTableTaskResponse CheckMetaTableTask()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckMetaTableTaskWithOptions(runtime);
        }

        public async Task<CheckMetaTableTaskResponse> CheckMetaTableTaskAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckMetaTableTaskWithOptionsAsync(runtime);
        }

        public CreateBusinessResponse CreateBusinessWithOptions(CreateBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBusinessResponse>(DoRPCRequest("CreateBusiness", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateBusinessResponse> CreateBusinessWithOptionsAsync(CreateBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBusinessResponse>(await DoRPCRequestAsync("CreateBusiness", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateBusinessResponse CreateBusiness(CreateBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBusinessWithOptions(request, runtime);
        }

        public async Task<CreateBusinessResponse> CreateBusinessAsync(CreateBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBusinessWithOptionsAsync(request, runtime);
        }

        public CreateConnectionResponse CreateConnectionWithOptions(CreateConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateConnectionResponse>(DoRPCRequest("CreateConnection", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateConnectionResponse> CreateConnectionWithOptionsAsync(CreateConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateConnectionResponse>(await DoRPCRequestAsync("CreateConnection", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateConnectionResponse CreateConnection(CreateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConnectionWithOptions(request, runtime);
        }

        public async Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConnectionWithOptionsAsync(request, runtime);
        }

        public CreateDagComplementResponse CreateDagComplementWithOptions(CreateDagComplementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDagComplementResponse>(DoRPCRequest("CreateDagComplement", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDagComplementResponse> CreateDagComplementWithOptionsAsync(CreateDagComplementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDagComplementResponse>(await DoRPCRequestAsync("CreateDagComplement", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDagComplementResponse CreateDagComplement(CreateDagComplementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDagComplementWithOptions(request, runtime);
        }

        public async Task<CreateDagComplementResponse> CreateDagComplementAsync(CreateDagComplementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDagComplementWithOptionsAsync(request, runtime);
        }

        public CreateDagTestResponse CreateDagTestWithOptions(CreateDagTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDagTestResponse>(DoRPCRequest("CreateDagTest", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDagTestResponse> CreateDagTestWithOptionsAsync(CreateDagTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDagTestResponse>(await DoRPCRequestAsync("CreateDagTest", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDagTestResponse CreateDagTest(CreateDagTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDagTestWithOptions(request, runtime);
        }

        public async Task<CreateDagTestResponse> CreateDagTestAsync(CreateDagTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDagTestWithOptionsAsync(request, runtime);
        }

        public CreateDataServiceApiResponse CreateDataServiceApiWithOptions(CreateDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDataServiceApiResponse>(DoRPCRequest("CreateDataServiceApi", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDataServiceApiResponse> CreateDataServiceApiWithOptionsAsync(CreateDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDataServiceApiResponse>(await DoRPCRequestAsync("CreateDataServiceApi", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDataServiceApiResponse CreateDataServiceApi(CreateDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataServiceApiWithOptions(request, runtime);
        }

        public async Task<CreateDataServiceApiResponse> CreateDataServiceApiAsync(CreateDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataServiceApiWithOptionsAsync(request, runtime);
        }

        public CreateDataServiceApiAuthorityResponse CreateDataServiceApiAuthorityWithOptions(CreateDataServiceApiAuthorityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDataServiceApiAuthorityResponse>(DoRPCRequest("CreateDataServiceApiAuthority", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDataServiceApiAuthorityResponse> CreateDataServiceApiAuthorityWithOptionsAsync(CreateDataServiceApiAuthorityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDataServiceApiAuthorityResponse>(await DoRPCRequestAsync("CreateDataServiceApiAuthority", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDataServiceApiAuthorityResponse CreateDataServiceApiAuthority(CreateDataServiceApiAuthorityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataServiceApiAuthorityWithOptions(request, runtime);
        }

        public async Task<CreateDataServiceApiAuthorityResponse> CreateDataServiceApiAuthorityAsync(CreateDataServiceApiAuthorityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataServiceApiAuthorityWithOptionsAsync(request, runtime);
        }

        public CreateDataServiceFolderResponse CreateDataServiceFolderWithOptions(CreateDataServiceFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDataServiceFolderResponse>(DoRPCRequest("CreateDataServiceFolder", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDataServiceFolderResponse> CreateDataServiceFolderWithOptionsAsync(CreateDataServiceFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDataServiceFolderResponse>(await DoRPCRequestAsync("CreateDataServiceFolder", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDataServiceFolderResponse CreateDataServiceFolder(CreateDataServiceFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataServiceFolderWithOptions(request, runtime);
        }

        public async Task<CreateDataServiceFolderResponse> CreateDataServiceFolderAsync(CreateDataServiceFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataServiceFolderWithOptionsAsync(request, runtime);
        }

        public CreateDataServiceGroupResponse CreateDataServiceGroupWithOptions(CreateDataServiceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDataServiceGroupResponse>(DoRPCRequest("CreateDataServiceGroup", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDataServiceGroupResponse> CreateDataServiceGroupWithOptionsAsync(CreateDataServiceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDataServiceGroupResponse>(await DoRPCRequestAsync("CreateDataServiceGroup", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDataServiceGroupResponse CreateDataServiceGroup(CreateDataServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataServiceGroupWithOptions(request, runtime);
        }

        public async Task<CreateDataServiceGroupResponse> CreateDataServiceGroupAsync(CreateDataServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataServiceGroupWithOptionsAsync(request, runtime);
        }

        public CreateDataSourceResponse CreateDataSourceWithOptions(CreateDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDataSourceResponse>(DoRPCRequest("CreateDataSource", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDataSourceResponse> CreateDataSourceWithOptionsAsync(CreateDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDataSourceResponse>(await DoRPCRequestAsync("CreateDataSource", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataSourceWithOptions(request, runtime);
        }

        public async Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataSourceWithOptionsAsync(request, runtime);
        }

        public CreateDISyncTaskResponse CreateDISyncTaskWithOptions(CreateDISyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDISyncTaskResponse>(DoRPCRequest("CreateDISyncTask", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDISyncTaskResponse> CreateDISyncTaskWithOptionsAsync(CreateDISyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDISyncTaskResponse>(await DoRPCRequestAsync("CreateDISyncTask", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDISyncTaskResponse CreateDISyncTask(CreateDISyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDISyncTaskWithOptions(request, runtime);
        }

        public async Task<CreateDISyncTaskResponse> CreateDISyncTaskAsync(CreateDISyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDISyncTaskWithOptionsAsync(request, runtime);
        }

        public CreateFileResponse CreateFileWithOptions(CreateFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFileResponse>(DoRPCRequest("CreateFile", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFileResponse> CreateFileWithOptionsAsync(CreateFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFileResponse>(await DoRPCRequestAsync("CreateFile", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFileResponse CreateFile(CreateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFileWithOptions(request, runtime);
        }

        public async Task<CreateFileResponse> CreateFileAsync(CreateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFileWithOptionsAsync(request, runtime);
        }

        public CreateFolderResponse CreateFolderWithOptions(CreateFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFolderResponse>(DoRPCRequest("CreateFolder", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFolderResponse> CreateFolderWithOptionsAsync(CreateFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFolderResponse>(await DoRPCRequestAsync("CreateFolder", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFolderResponse CreateFolder(CreateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFolderWithOptions(request, runtime);
        }

        public async Task<CreateFolderResponse> CreateFolderAsync(CreateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFolderWithOptionsAsync(request, runtime);
        }

        public CreateImportMigrationResponse CreateImportMigrationWithOptions(CreateImportMigrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateImportMigrationResponse>(DoRPCRequest("CreateImportMigration", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateImportMigrationResponse> CreateImportMigrationWithOptionsAsync(CreateImportMigrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateImportMigrationResponse>(await DoRPCRequestAsync("CreateImportMigration", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateImportMigrationResponse CreateImportMigration(CreateImportMigrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImportMigrationWithOptions(request, runtime);
        }

        public async Task<CreateImportMigrationResponse> CreateImportMigrationAsync(CreateImportMigrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImportMigrationWithOptionsAsync(request, runtime);
        }

        public CreateImportMigrationResponse CreateImportMigrationAdvance(CreateImportMigrationAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "dataworks-public",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            CreateImportMigrationRequest createImportMigrationReq = new CreateImportMigrationRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, createImportMigrationReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageFileObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.ObjectKey,
                    Content = request.PackageFileObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.AccessKeyId,
                    Policy = authResponse.EncodedPolicy,
                    Signature = authResponse.Signature,
                    Key = authResponse.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                createImportMigrationReq.PackageFile = "http://" + authResponse.Bucket + "." + authResponse.Endpoint + "/" + authResponse.ObjectKey;
            }
            CreateImportMigrationResponse createImportMigrationResp = CreateImportMigrationWithOptions(createImportMigrationReq, runtime);
            return createImportMigrationResp;
        }

        public async Task<CreateImportMigrationResponse> CreateImportMigrationAdvanceAsync(CreateImportMigrationAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "dataworks-public",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            CreateImportMigrationRequest createImportMigrationReq = new CreateImportMigrationRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, createImportMigrationReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageFileObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.ObjectKey,
                    Content = request.PackageFileObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.AccessKeyId,
                    Policy = authResponse.EncodedPolicy,
                    Signature = authResponse.Signature,
                    Key = authResponse.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                createImportMigrationReq.PackageFile = "http://" + authResponse.Bucket + "." + authResponse.Endpoint + "/" + authResponse.ObjectKey;
            }
            CreateImportMigrationResponse createImportMigrationResp = await CreateImportMigrationWithOptionsAsync(createImportMigrationReq, runtime);
            return createImportMigrationResp;
        }

        public CreateManualDagResponse CreateManualDagWithOptions(CreateManualDagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateManualDagResponse>(DoRPCRequest("CreateManualDag", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateManualDagResponse> CreateManualDagWithOptionsAsync(CreateManualDagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateManualDagResponse>(await DoRPCRequestAsync("CreateManualDag", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateManualDagResponse CreateManualDag(CreateManualDagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateManualDagWithOptions(request, runtime);
        }

        public async Task<CreateManualDagResponse> CreateManualDagAsync(CreateManualDagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateManualDagWithOptionsAsync(request, runtime);
        }

        public CreateMetaCategoryResponse CreateMetaCategoryWithOptions(CreateMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMetaCategoryResponse>(DoRPCRequest("CreateMetaCategory", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMetaCategoryResponse> CreateMetaCategoryWithOptionsAsync(CreateMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMetaCategoryResponse>(await DoRPCRequestAsync("CreateMetaCategory", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMetaCategoryResponse CreateMetaCategory(CreateMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMetaCategoryWithOptions(request, runtime);
        }

        public async Task<CreateMetaCategoryResponse> CreateMetaCategoryAsync(CreateMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMetaCategoryWithOptionsAsync(request, runtime);
        }

        public CreatePermissionApplyOrderResponse CreatePermissionApplyOrderWithOptions(CreatePermissionApplyOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePermissionApplyOrderResponse>(DoRPCRequest("CreatePermissionApplyOrder", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreatePermissionApplyOrderResponse> CreatePermissionApplyOrderWithOptionsAsync(CreatePermissionApplyOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePermissionApplyOrderResponse>(await DoRPCRequestAsync("CreatePermissionApplyOrder", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreatePermissionApplyOrderResponse CreatePermissionApplyOrder(CreatePermissionApplyOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePermissionApplyOrderWithOptions(request, runtime);
        }

        public async Task<CreatePermissionApplyOrderResponse> CreatePermissionApplyOrderAsync(CreatePermissionApplyOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePermissionApplyOrderWithOptionsAsync(request, runtime);
        }

        public CreateProjectMemberResponse CreateProjectMemberWithOptions(CreateProjectMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectMemberResponse>(DoRPCRequest("CreateProjectMember", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateProjectMemberResponse> CreateProjectMemberWithOptionsAsync(CreateProjectMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectMemberResponse>(await DoRPCRequestAsync("CreateProjectMember", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateProjectMemberResponse CreateProjectMember(CreateProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProjectMemberWithOptions(request, runtime);
        }

        public async Task<CreateProjectMemberResponse> CreateProjectMemberAsync(CreateProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProjectMemberWithOptionsAsync(request, runtime);
        }

        public CreateQualityEntityResponse CreateQualityEntityWithOptions(CreateQualityEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQualityEntityResponse>(DoRPCRequest("CreateQualityEntity", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateQualityEntityResponse> CreateQualityEntityWithOptionsAsync(CreateQualityEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQualityEntityResponse>(await DoRPCRequestAsync("CreateQualityEntity", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateQualityEntityResponse CreateQualityEntity(CreateQualityEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQualityEntityWithOptions(request, runtime);
        }

        public async Task<CreateQualityEntityResponse> CreateQualityEntityAsync(CreateQualityEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQualityEntityWithOptionsAsync(request, runtime);
        }

        public CreateQualityFollowerResponse CreateQualityFollowerWithOptions(CreateQualityFollowerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQualityFollowerResponse>(DoRPCRequest("CreateQualityFollower", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateQualityFollowerResponse> CreateQualityFollowerWithOptionsAsync(CreateQualityFollowerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQualityFollowerResponse>(await DoRPCRequestAsync("CreateQualityFollower", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateQualityFollowerResponse CreateQualityFollower(CreateQualityFollowerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQualityFollowerWithOptions(request, runtime);
        }

        public async Task<CreateQualityFollowerResponse> CreateQualityFollowerAsync(CreateQualityFollowerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQualityFollowerWithOptionsAsync(request, runtime);
        }

        public CreateQualityRelativeNodeResponse CreateQualityRelativeNodeWithOptions(CreateQualityRelativeNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQualityRelativeNodeResponse>(DoRPCRequest("CreateQualityRelativeNode", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateQualityRelativeNodeResponse> CreateQualityRelativeNodeWithOptionsAsync(CreateQualityRelativeNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQualityRelativeNodeResponse>(await DoRPCRequestAsync("CreateQualityRelativeNode", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateQualityRelativeNodeResponse CreateQualityRelativeNode(CreateQualityRelativeNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQualityRelativeNodeWithOptions(request, runtime);
        }

        public async Task<CreateQualityRelativeNodeResponse> CreateQualityRelativeNodeAsync(CreateQualityRelativeNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQualityRelativeNodeWithOptionsAsync(request, runtime);
        }

        public CreateQualityRuleResponse CreateQualityRuleWithOptions(CreateQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQualityRuleResponse>(DoRPCRequest("CreateQualityRule", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateQualityRuleResponse> CreateQualityRuleWithOptionsAsync(CreateQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQualityRuleResponse>(await DoRPCRequestAsync("CreateQualityRule", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateQualityRuleResponse CreateQualityRule(CreateQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQualityRuleWithOptions(request, runtime);
        }

        public async Task<CreateQualityRuleResponse> CreateQualityRuleAsync(CreateQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQualityRuleWithOptionsAsync(request, runtime);
        }

        public CreateRemindResponse CreateRemindWithOptions(CreateRemindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRemindResponse>(DoRPCRequest("CreateRemind", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRemindResponse> CreateRemindWithOptionsAsync(CreateRemindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRemindResponse>(await DoRPCRequestAsync("CreateRemind", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRemindResponse CreateRemind(CreateRemindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRemindWithOptions(request, runtime);
        }

        public async Task<CreateRemindResponse> CreateRemindAsync(CreateRemindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRemindWithOptionsAsync(request, runtime);
        }

        public CreateTableResponse CreateTableWithOptions(CreateTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTableResponse>(DoRPCRequest("CreateTable", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateTableResponse> CreateTableWithOptionsAsync(CreateTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTableResponse>(await DoRPCRequestAsync("CreateTable", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateTableResponse CreateTable(CreateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTableWithOptions(request, runtime);
        }

        public async Task<CreateTableResponse> CreateTableAsync(CreateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTableWithOptionsAsync(request, runtime);
        }

        public CreateTableLevelResponse CreateTableLevelWithOptions(CreateTableLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTableLevelResponse>(DoRPCRequest("CreateTableLevel", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateTableLevelResponse> CreateTableLevelWithOptionsAsync(CreateTableLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTableLevelResponse>(await DoRPCRequestAsync("CreateTableLevel", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateTableLevelResponse CreateTableLevel(CreateTableLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTableLevelWithOptions(request, runtime);
        }

        public async Task<CreateTableLevelResponse> CreateTableLevelAsync(CreateTableLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTableLevelWithOptionsAsync(request, runtime);
        }

        public CreateTableThemeResponse CreateTableThemeWithOptions(CreateTableThemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTableThemeResponse>(DoRPCRequest("CreateTableTheme", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateTableThemeResponse> CreateTableThemeWithOptionsAsync(CreateTableThemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTableThemeResponse>(await DoRPCRequestAsync("CreateTableTheme", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateTableThemeResponse CreateTableTheme(CreateTableThemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTableThemeWithOptions(request, runtime);
        }

        public async Task<CreateTableThemeResponse> CreateTableThemeAsync(CreateTableThemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTableThemeWithOptionsAsync(request, runtime);
        }

        public CreateUdfFileResponse CreateUdfFileWithOptions(CreateUdfFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUdfFileResponse>(DoRPCRequest("CreateUdfFile", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUdfFileResponse> CreateUdfFileWithOptionsAsync(CreateUdfFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUdfFileResponse>(await DoRPCRequestAsync("CreateUdfFile", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateUdfFileResponse CreateUdfFile(CreateUdfFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUdfFileWithOptions(request, runtime);
        }

        public async Task<CreateUdfFileResponse> CreateUdfFileAsync(CreateUdfFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUdfFileWithOptionsAsync(request, runtime);
        }

        public CreateViewResponse CreateViewWithOptions(CreateViewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateViewResponse>(DoRPCRequest("CreateView", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateViewResponse> CreateViewWithOptionsAsync(CreateViewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateViewResponse>(await DoRPCRequestAsync("CreateView", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateViewResponse CreateView(CreateViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateViewWithOptions(request, runtime);
        }

        public async Task<CreateViewResponse> CreateViewAsync(CreateViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateViewWithOptionsAsync(request, runtime);
        }

        public DeleteBusinessResponse DeleteBusinessWithOptions(DeleteBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBusinessResponse>(DoRPCRequest("DeleteBusiness", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteBusinessResponse> DeleteBusinessWithOptionsAsync(DeleteBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBusinessResponse>(await DoRPCRequestAsync("DeleteBusiness", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteBusinessResponse DeleteBusiness(DeleteBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBusinessWithOptions(request, runtime);
        }

        public async Task<DeleteBusinessResponse> DeleteBusinessAsync(DeleteBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBusinessWithOptionsAsync(request, runtime);
        }

        public DeleteConnectionResponse DeleteConnectionWithOptions(DeleteConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteConnectionResponse>(DoRPCRequest("DeleteConnection", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteConnectionResponse> DeleteConnectionWithOptionsAsync(DeleteConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteConnectionResponse>(await DoRPCRequestAsync("DeleteConnection", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteConnectionWithOptions(request, runtime);
        }

        public async Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteConnectionWithOptionsAsync(request, runtime);
        }

        public DeleteDataServiceApiResponse DeleteDataServiceApiWithOptions(DeleteDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDataServiceApiResponse>(DoRPCRequest("DeleteDataServiceApi", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDataServiceApiResponse> DeleteDataServiceApiWithOptionsAsync(DeleteDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDataServiceApiResponse>(await DoRPCRequestAsync("DeleteDataServiceApi", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDataServiceApiResponse DeleteDataServiceApi(DeleteDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataServiceApiWithOptions(request, runtime);
        }

        public async Task<DeleteDataServiceApiResponse> DeleteDataServiceApiAsync(DeleteDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataServiceApiWithOptionsAsync(request, runtime);
        }

        public DeleteDataServiceApiAuthorityResponse DeleteDataServiceApiAuthorityWithOptions(DeleteDataServiceApiAuthorityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDataServiceApiAuthorityResponse>(DoRPCRequest("DeleteDataServiceApiAuthority", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDataServiceApiAuthorityResponse> DeleteDataServiceApiAuthorityWithOptionsAsync(DeleteDataServiceApiAuthorityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDataServiceApiAuthorityResponse>(await DoRPCRequestAsync("DeleteDataServiceApiAuthority", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDataServiceApiAuthorityResponse DeleteDataServiceApiAuthority(DeleteDataServiceApiAuthorityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataServiceApiAuthorityWithOptions(request, runtime);
        }

        public async Task<DeleteDataServiceApiAuthorityResponse> DeleteDataServiceApiAuthorityAsync(DeleteDataServiceApiAuthorityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataServiceApiAuthorityWithOptionsAsync(request, runtime);
        }

        public DeleteDataSourceResponse DeleteDataSourceWithOptions(DeleteDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDataSourceResponse>(DoRPCRequest("DeleteDataSource", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDataSourceResponse> DeleteDataSourceWithOptionsAsync(DeleteDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDataSourceResponse>(await DoRPCRequestAsync("DeleteDataSource", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataSourceWithOptions(request, runtime);
        }

        public async Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataSourceWithOptionsAsync(request, runtime);
        }

        public DeleteDISyncTaskResponse DeleteDISyncTaskWithOptions(DeleteDISyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDISyncTaskResponse>(DoRPCRequest("DeleteDISyncTask", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDISyncTaskResponse> DeleteDISyncTaskWithOptionsAsync(DeleteDISyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDISyncTaskResponse>(await DoRPCRequestAsync("DeleteDISyncTask", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDISyncTaskResponse DeleteDISyncTask(DeleteDISyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDISyncTaskWithOptions(request, runtime);
        }

        public async Task<DeleteDISyncTaskResponse> DeleteDISyncTaskAsync(DeleteDISyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDISyncTaskWithOptionsAsync(request, runtime);
        }

        public DeleteFileResponse DeleteFileWithOptions(DeleteFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFileResponse>(DoRPCRequest("DeleteFile", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFileResponse> DeleteFileWithOptionsAsync(DeleteFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFileResponse>(await DoRPCRequestAsync("DeleteFile", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFileResponse DeleteFile(DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFileWithOptions(request, runtime);
        }

        public async Task<DeleteFileResponse> DeleteFileAsync(DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFileWithOptionsAsync(request, runtime);
        }

        public DeleteFolderResponse DeleteFolderWithOptions(DeleteFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFolderResponse>(DoRPCRequest("DeleteFolder", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFolderResponse> DeleteFolderWithOptionsAsync(DeleteFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFolderResponse>(await DoRPCRequestAsync("DeleteFolder", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFolderResponse DeleteFolder(DeleteFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFolderWithOptions(request, runtime);
        }

        public async Task<DeleteFolderResponse> DeleteFolderAsync(DeleteFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFolderWithOptionsAsync(request, runtime);
        }

        public DeleteFromMetaCategoryResponse DeleteFromMetaCategoryWithOptions(DeleteFromMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFromMetaCategoryResponse>(DoRPCRequest("DeleteFromMetaCategory", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFromMetaCategoryResponse> DeleteFromMetaCategoryWithOptionsAsync(DeleteFromMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFromMetaCategoryResponse>(await DoRPCRequestAsync("DeleteFromMetaCategory", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFromMetaCategoryResponse DeleteFromMetaCategory(DeleteFromMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFromMetaCategoryWithOptions(request, runtime);
        }

        public async Task<DeleteFromMetaCategoryResponse> DeleteFromMetaCategoryAsync(DeleteFromMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFromMetaCategoryWithOptionsAsync(request, runtime);
        }

        public DeleteMetaCategoryResponse DeleteMetaCategoryWithOptions(DeleteMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteMetaCategoryResponse>(DoRPCRequest("DeleteMetaCategory", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteMetaCategoryResponse> DeleteMetaCategoryWithOptionsAsync(DeleteMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteMetaCategoryResponse>(await DoRPCRequestAsync("DeleteMetaCategory", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DeleteMetaCategoryResponse DeleteMetaCategory(DeleteMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMetaCategoryWithOptions(request, runtime);
        }

        public async Task<DeleteMetaCategoryResponse> DeleteMetaCategoryAsync(DeleteMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMetaCategoryWithOptionsAsync(request, runtime);
        }

        public DeleteProjectMemberResponse DeleteProjectMemberWithOptions(DeleteProjectMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProjectMemberResponse>(DoRPCRequest("DeleteProjectMember", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteProjectMemberResponse> DeleteProjectMemberWithOptionsAsync(DeleteProjectMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProjectMemberResponse>(await DoRPCRequestAsync("DeleteProjectMember", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteProjectMemberResponse DeleteProjectMember(DeleteProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProjectMemberWithOptions(request, runtime);
        }

        public async Task<DeleteProjectMemberResponse> DeleteProjectMemberAsync(DeleteProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProjectMemberWithOptionsAsync(request, runtime);
        }

        public DeleteQualityEntityResponse DeleteQualityEntityWithOptions(DeleteQualityEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQualityEntityResponse>(DoRPCRequest("DeleteQualityEntity", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteQualityEntityResponse> DeleteQualityEntityWithOptionsAsync(DeleteQualityEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQualityEntityResponse>(await DoRPCRequestAsync("DeleteQualityEntity", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteQualityEntityResponse DeleteQualityEntity(DeleteQualityEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQualityEntityWithOptions(request, runtime);
        }

        public async Task<DeleteQualityEntityResponse> DeleteQualityEntityAsync(DeleteQualityEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQualityEntityWithOptionsAsync(request, runtime);
        }

        public DeleteQualityFollowerResponse DeleteQualityFollowerWithOptions(DeleteQualityFollowerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQualityFollowerResponse>(DoRPCRequest("DeleteQualityFollower", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteQualityFollowerResponse> DeleteQualityFollowerWithOptionsAsync(DeleteQualityFollowerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQualityFollowerResponse>(await DoRPCRequestAsync("DeleteQualityFollower", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteQualityFollowerResponse DeleteQualityFollower(DeleteQualityFollowerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQualityFollowerWithOptions(request, runtime);
        }

        public async Task<DeleteQualityFollowerResponse> DeleteQualityFollowerAsync(DeleteQualityFollowerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQualityFollowerWithOptionsAsync(request, runtime);
        }

        public DeleteQualityRelativeNodeResponse DeleteQualityRelativeNodeWithOptions(DeleteQualityRelativeNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQualityRelativeNodeResponse>(DoRPCRequest("DeleteQualityRelativeNode", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteQualityRelativeNodeResponse> DeleteQualityRelativeNodeWithOptionsAsync(DeleteQualityRelativeNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQualityRelativeNodeResponse>(await DoRPCRequestAsync("DeleteQualityRelativeNode", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteQualityRelativeNodeResponse DeleteQualityRelativeNode(DeleteQualityRelativeNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQualityRelativeNodeWithOptions(request, runtime);
        }

        public async Task<DeleteQualityRelativeNodeResponse> DeleteQualityRelativeNodeAsync(DeleteQualityRelativeNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQualityRelativeNodeWithOptionsAsync(request, runtime);
        }

        public DeleteQualityRuleResponse DeleteQualityRuleWithOptions(DeleteQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQualityRuleResponse>(DoRPCRequest("DeleteQualityRule", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteQualityRuleResponse> DeleteQualityRuleWithOptionsAsync(DeleteQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQualityRuleResponse>(await DoRPCRequestAsync("DeleteQualityRule", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteQualityRuleResponse DeleteQualityRule(DeleteQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQualityRuleWithOptions(request, runtime);
        }

        public async Task<DeleteQualityRuleResponse> DeleteQualityRuleAsync(DeleteQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQualityRuleWithOptionsAsync(request, runtime);
        }

        public DeleteRemindResponse DeleteRemindWithOptions(DeleteRemindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRemindResponse>(DoRPCRequest("DeleteRemind", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRemindResponse> DeleteRemindWithOptionsAsync(DeleteRemindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRemindResponse>(await DoRPCRequestAsync("DeleteRemind", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRemindResponse DeleteRemind(DeleteRemindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRemindWithOptions(request, runtime);
        }

        public async Task<DeleteRemindResponse> DeleteRemindAsync(DeleteRemindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRemindWithOptionsAsync(request, runtime);
        }

        public DeleteTableResponse DeleteTableWithOptions(DeleteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTableResponse>(DoRPCRequest("DeleteTable", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTableResponse> DeleteTableWithOptionsAsync(DeleteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTableResponse>(await DoRPCRequestAsync("DeleteTable", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTableResponse DeleteTable(DeleteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTableWithOptions(request, runtime);
        }

        public async Task<DeleteTableResponse> DeleteTableAsync(DeleteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTableWithOptionsAsync(request, runtime);
        }

        public DeleteTableLevelResponse DeleteTableLevelWithOptions(DeleteTableLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTableLevelResponse>(DoRPCRequest("DeleteTableLevel", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTableLevelResponse> DeleteTableLevelWithOptionsAsync(DeleteTableLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTableLevelResponse>(await DoRPCRequestAsync("DeleteTableLevel", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTableLevelResponse DeleteTableLevel(DeleteTableLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTableLevelWithOptions(request, runtime);
        }

        public async Task<DeleteTableLevelResponse> DeleteTableLevelAsync(DeleteTableLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTableLevelWithOptionsAsync(request, runtime);
        }

        public DeleteTableThemeResponse DeleteTableThemeWithOptions(DeleteTableThemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTableThemeResponse>(DoRPCRequest("DeleteTableTheme", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTableThemeResponse> DeleteTableThemeWithOptionsAsync(DeleteTableThemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTableThemeResponse>(await DoRPCRequestAsync("DeleteTableTheme", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTableThemeResponse DeleteTableTheme(DeleteTableThemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTableThemeWithOptions(request, runtime);
        }

        public async Task<DeleteTableThemeResponse> DeleteTableThemeAsync(DeleteTableThemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTableThemeWithOptionsAsync(request, runtime);
        }

        public DeleteViewResponse DeleteViewWithOptions(DeleteViewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteViewResponse>(DoRPCRequest("DeleteView", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteViewResponse> DeleteViewWithOptionsAsync(DeleteViewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteViewResponse>(await DoRPCRequestAsync("DeleteView", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteViewResponse DeleteView(DeleteViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteViewWithOptions(request, runtime);
        }

        public async Task<DeleteViewResponse> DeleteViewAsync(DeleteViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteViewWithOptionsAsync(request, runtime);
        }

        public DeployDISyncTaskResponse DeployDISyncTaskWithOptions(DeployDISyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeployDISyncTaskResponse>(DoRPCRequest("DeployDISyncTask", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeployDISyncTaskResponse> DeployDISyncTaskWithOptionsAsync(DeployDISyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeployDISyncTaskResponse>(await DoRPCRequestAsync("DeployDISyncTask", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeployDISyncTaskResponse DeployDISyncTask(DeployDISyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeployDISyncTaskWithOptions(request, runtime);
        }

        public async Task<DeployDISyncTaskResponse> DeployDISyncTaskAsync(DeployDISyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeployDISyncTaskWithOptionsAsync(request, runtime);
        }

        public DeployFileResponse DeployFileWithOptions(DeployFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeployFileResponse>(DoRPCRequest("DeployFile", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeployFileResponse> DeployFileWithOptionsAsync(DeployFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeployFileResponse>(await DoRPCRequestAsync("DeployFile", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeployFileResponse DeployFile(DeployFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeployFileWithOptions(request, runtime);
        }

        public async Task<DeployFileResponse> DeployFileAsync(DeployFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeployFileWithOptionsAsync(request, runtime);
        }

        public DesensitizeDataResponse DesensitizeDataWithOptions(DesensitizeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DesensitizeDataResponse>(DoRPCRequest("DesensitizeData", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DesensitizeDataResponse> DesensitizeDataWithOptionsAsync(DesensitizeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DesensitizeDataResponse>(await DoRPCRequestAsync("DesensitizeData", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DesensitizeDataResponse DesensitizeData(DesensitizeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DesensitizeDataWithOptions(request, runtime);
        }

        public async Task<DesensitizeDataResponse> DesensitizeDataAsync(DesensitizeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DesensitizeDataWithOptionsAsync(request, runtime);
        }

        public EstablishRelationTableToBusinessResponse EstablishRelationTableToBusinessWithOptions(EstablishRelationTableToBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EstablishRelationTableToBusinessResponse>(DoRPCRequest("EstablishRelationTableToBusiness", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EstablishRelationTableToBusinessResponse> EstablishRelationTableToBusinessWithOptionsAsync(EstablishRelationTableToBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EstablishRelationTableToBusinessResponse>(await DoRPCRequestAsync("EstablishRelationTableToBusiness", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EstablishRelationTableToBusinessResponse EstablishRelationTableToBusiness(EstablishRelationTableToBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EstablishRelationTableToBusinessWithOptions(request, runtime);
        }

        public async Task<EstablishRelationTableToBusinessResponse> EstablishRelationTableToBusinessAsync(EstablishRelationTableToBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EstablishRelationTableToBusinessWithOptionsAsync(request, runtime);
        }

        public ExportConnectionsResponse ExportConnectionsWithOptions(ExportConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ExportConnectionsResponse>(DoRPCRequest("ExportConnections", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ExportConnectionsResponse> ExportConnectionsWithOptionsAsync(ExportConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ExportConnectionsResponse>(await DoRPCRequestAsync("ExportConnections", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ExportConnectionsResponse ExportConnections(ExportConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportConnectionsWithOptions(request, runtime);
        }

        public async Task<ExportConnectionsResponse> ExportConnectionsAsync(ExportConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportConnectionsWithOptionsAsync(request, runtime);
        }

        public ExportDataSourcesResponse ExportDataSourcesWithOptions(ExportDataSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ExportDataSourcesResponse>(DoRPCRequest("ExportDataSources", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ExportDataSourcesResponse> ExportDataSourcesWithOptionsAsync(ExportDataSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ExportDataSourcesResponse>(await DoRPCRequestAsync("ExportDataSources", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ExportDataSourcesResponse ExportDataSources(ExportDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportDataSourcesWithOptions(request, runtime);
        }

        public async Task<ExportDataSourcesResponse> ExportDataSourcesAsync(ExportDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportDataSourcesWithOptionsAsync(request, runtime);
        }

        public ExportDISyncTasksResponse ExportDISyncTasksWithOptions(ExportDISyncTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportDISyncTasksResponse>(DoRPCRequest("ExportDISyncTasks", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExportDISyncTasksResponse> ExportDISyncTasksWithOptionsAsync(ExportDISyncTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportDISyncTasksResponse>(await DoRPCRequestAsync("ExportDISyncTasks", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExportDISyncTasksResponse ExportDISyncTasks(ExportDISyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportDISyncTasksWithOptions(request, runtime);
        }

        public async Task<ExportDISyncTasksResponse> ExportDISyncTasksAsync(ExportDISyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportDISyncTasksWithOptionsAsync(request, runtime);
        }

        public GenerateDISyncTaskConfigForCreatingResponse GenerateDISyncTaskConfigForCreatingWithOptions(GenerateDISyncTaskConfigForCreatingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateDISyncTaskConfigForCreatingResponse>(DoRPCRequest("GenerateDISyncTaskConfigForCreating", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateDISyncTaskConfigForCreatingResponse> GenerateDISyncTaskConfigForCreatingWithOptionsAsync(GenerateDISyncTaskConfigForCreatingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateDISyncTaskConfigForCreatingResponse>(await DoRPCRequestAsync("GenerateDISyncTaskConfigForCreating", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateDISyncTaskConfigForCreatingResponse GenerateDISyncTaskConfigForCreating(GenerateDISyncTaskConfigForCreatingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateDISyncTaskConfigForCreatingWithOptions(request, runtime);
        }

        public async Task<GenerateDISyncTaskConfigForCreatingResponse> GenerateDISyncTaskConfigForCreatingAsync(GenerateDISyncTaskConfigForCreatingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateDISyncTaskConfigForCreatingWithOptionsAsync(request, runtime);
        }

        public GenerateDISyncTaskConfigForUpdatingResponse GenerateDISyncTaskConfigForUpdatingWithOptions(GenerateDISyncTaskConfigForUpdatingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateDISyncTaskConfigForUpdatingResponse>(DoRPCRequest("GenerateDISyncTaskConfigForUpdating", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateDISyncTaskConfigForUpdatingResponse> GenerateDISyncTaskConfigForUpdatingWithOptionsAsync(GenerateDISyncTaskConfigForUpdatingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateDISyncTaskConfigForUpdatingResponse>(await DoRPCRequestAsync("GenerateDISyncTaskConfigForUpdating", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateDISyncTaskConfigForUpdatingResponse GenerateDISyncTaskConfigForUpdating(GenerateDISyncTaskConfigForUpdatingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateDISyncTaskConfigForUpdatingWithOptions(request, runtime);
        }

        public async Task<GenerateDISyncTaskConfigForUpdatingResponse> GenerateDISyncTaskConfigForUpdatingAsync(GenerateDISyncTaskConfigForUpdatingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateDISyncTaskConfigForUpdatingWithOptionsAsync(request, runtime);
        }

        public GetBaselineConfigResponse GetBaselineConfigWithOptions(GetBaselineConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBaselineConfigResponse>(DoRPCRequest("GetBaselineConfig", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetBaselineConfigResponse> GetBaselineConfigWithOptionsAsync(GetBaselineConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBaselineConfigResponse>(await DoRPCRequestAsync("GetBaselineConfig", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetBaselineConfigResponse GetBaselineConfig(GetBaselineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBaselineConfigWithOptions(request, runtime);
        }

        public async Task<GetBaselineConfigResponse> GetBaselineConfigAsync(GetBaselineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBaselineConfigWithOptionsAsync(request, runtime);
        }

        public GetBaselineKeyPathResponse GetBaselineKeyPathWithOptions(GetBaselineKeyPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBaselineKeyPathResponse>(DoRPCRequest("GetBaselineKeyPath", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetBaselineKeyPathResponse> GetBaselineKeyPathWithOptionsAsync(GetBaselineKeyPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBaselineKeyPathResponse>(await DoRPCRequestAsync("GetBaselineKeyPath", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetBaselineKeyPathResponse GetBaselineKeyPath(GetBaselineKeyPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBaselineKeyPathWithOptions(request, runtime);
        }

        public async Task<GetBaselineKeyPathResponse> GetBaselineKeyPathAsync(GetBaselineKeyPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBaselineKeyPathWithOptionsAsync(request, runtime);
        }

        public GetBaselineStatusResponse GetBaselineStatusWithOptions(GetBaselineStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBaselineStatusResponse>(DoRPCRequest("GetBaselineStatus", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetBaselineStatusResponse> GetBaselineStatusWithOptionsAsync(GetBaselineStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBaselineStatusResponse>(await DoRPCRequestAsync("GetBaselineStatus", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetBaselineStatusResponse GetBaselineStatus(GetBaselineStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBaselineStatusWithOptions(request, runtime);
        }

        public async Task<GetBaselineStatusResponse> GetBaselineStatusAsync(GetBaselineStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBaselineStatusWithOptionsAsync(request, runtime);
        }

        public GetBusinessResponse GetBusinessWithOptions(GetBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBusinessResponse>(DoRPCRequest("GetBusiness", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetBusinessResponse> GetBusinessWithOptionsAsync(GetBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBusinessResponse>(await DoRPCRequestAsync("GetBusiness", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetBusinessResponse GetBusiness(GetBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBusinessWithOptions(request, runtime);
        }

        public async Task<GetBusinessResponse> GetBusinessAsync(GetBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBusinessWithOptionsAsync(request, runtime);
        }

        public GetConnectionMetaResponse GetConnectionMetaWithOptions(GetConnectionMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetConnectionMetaResponse>(DoRPCRequest("GetConnectionMeta", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetConnectionMetaResponse> GetConnectionMetaWithOptionsAsync(GetConnectionMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetConnectionMetaResponse>(await DoRPCRequestAsync("GetConnectionMeta", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetConnectionMetaResponse GetConnectionMeta(GetConnectionMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConnectionMetaWithOptions(request, runtime);
        }

        public async Task<GetConnectionMetaResponse> GetConnectionMetaAsync(GetConnectionMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConnectionMetaWithOptionsAsync(request, runtime);
        }

        public GetDagResponse GetDagWithOptions(GetDagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDagResponse>(DoRPCRequest("GetDag", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDagResponse> GetDagWithOptionsAsync(GetDagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDagResponse>(await DoRPCRequestAsync("GetDag", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDagResponse GetDag(GetDagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDagWithOptions(request, runtime);
        }

        public async Task<GetDagResponse> GetDagAsync(GetDagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDagWithOptionsAsync(request, runtime);
        }

        public GetDataServiceApiResponse GetDataServiceApiWithOptions(GetDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDataServiceApiResponse>(DoRPCRequest("GetDataServiceApi", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDataServiceApiResponse> GetDataServiceApiWithOptionsAsync(GetDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDataServiceApiResponse>(await DoRPCRequestAsync("GetDataServiceApi", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDataServiceApiResponse GetDataServiceApi(GetDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataServiceApiWithOptions(request, runtime);
        }

        public async Task<GetDataServiceApiResponse> GetDataServiceApiAsync(GetDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataServiceApiWithOptionsAsync(request, runtime);
        }

        public GetDataServiceApplicationResponse GetDataServiceApplicationWithOptions(GetDataServiceApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDataServiceApplicationResponse>(DoRPCRequest("GetDataServiceApplication", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDataServiceApplicationResponse> GetDataServiceApplicationWithOptionsAsync(GetDataServiceApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDataServiceApplicationResponse>(await DoRPCRequestAsync("GetDataServiceApplication", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDataServiceApplicationResponse GetDataServiceApplication(GetDataServiceApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataServiceApplicationWithOptions(request, runtime);
        }

        public async Task<GetDataServiceApplicationResponse> GetDataServiceApplicationAsync(GetDataServiceApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataServiceApplicationWithOptionsAsync(request, runtime);
        }

        public GetDataServiceFolderResponse GetDataServiceFolderWithOptions(GetDataServiceFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDataServiceFolderResponse>(DoRPCRequest("GetDataServiceFolder", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDataServiceFolderResponse> GetDataServiceFolderWithOptionsAsync(GetDataServiceFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDataServiceFolderResponse>(await DoRPCRequestAsync("GetDataServiceFolder", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDataServiceFolderResponse GetDataServiceFolder(GetDataServiceFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataServiceFolderWithOptions(request, runtime);
        }

        public async Task<GetDataServiceFolderResponse> GetDataServiceFolderAsync(GetDataServiceFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataServiceFolderWithOptionsAsync(request, runtime);
        }

        public GetDataServiceGroupResponse GetDataServiceGroupWithOptions(GetDataServiceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDataServiceGroupResponse>(DoRPCRequest("GetDataServiceGroup", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDataServiceGroupResponse> GetDataServiceGroupWithOptionsAsync(GetDataServiceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDataServiceGroupResponse>(await DoRPCRequestAsync("GetDataServiceGroup", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDataServiceGroupResponse GetDataServiceGroup(GetDataServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataServiceGroupWithOptions(request, runtime);
        }

        public async Task<GetDataServiceGroupResponse> GetDataServiceGroupAsync(GetDataServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataServiceGroupWithOptionsAsync(request, runtime);
        }

        public GetDataServicePublishedApiResponse GetDataServicePublishedApiWithOptions(GetDataServicePublishedApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDataServicePublishedApiResponse>(DoRPCRequest("GetDataServicePublishedApi", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDataServicePublishedApiResponse> GetDataServicePublishedApiWithOptionsAsync(GetDataServicePublishedApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDataServicePublishedApiResponse>(await DoRPCRequestAsync("GetDataServicePublishedApi", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDataServicePublishedApiResponse GetDataServicePublishedApi(GetDataServicePublishedApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataServicePublishedApiWithOptions(request, runtime);
        }

        public async Task<GetDataServicePublishedApiResponse> GetDataServicePublishedApiAsync(GetDataServicePublishedApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataServicePublishedApiWithOptionsAsync(request, runtime);
        }

        public GetDataSourceMetaResponse GetDataSourceMetaWithOptions(GetDataSourceMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDataSourceMetaResponse>(DoRPCRequest("GetDataSourceMeta", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDataSourceMetaResponse> GetDataSourceMetaWithOptionsAsync(GetDataSourceMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDataSourceMetaResponse>(await DoRPCRequestAsync("GetDataSourceMeta", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDataSourceMetaResponse GetDataSourceMeta(GetDataSourceMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataSourceMetaWithOptions(request, runtime);
        }

        public async Task<GetDataSourceMetaResponse> GetDataSourceMetaAsync(GetDataSourceMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataSourceMetaWithOptionsAsync(request, runtime);
        }

        public GetDDLJobStatusResponse GetDDLJobStatusWithOptions(GetDDLJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDDLJobStatusResponse>(DoRPCRequest("GetDDLJobStatus", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetDDLJobStatusResponse> GetDDLJobStatusWithOptionsAsync(GetDDLJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDDLJobStatusResponse>(await DoRPCRequestAsync("GetDDLJobStatus", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetDDLJobStatusResponse GetDDLJobStatus(GetDDLJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDDLJobStatusWithOptions(request, runtime);
        }

        public async Task<GetDDLJobStatusResponse> GetDDLJobStatusAsync(GetDDLJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDDLJobStatusWithOptionsAsync(request, runtime);
        }

        public GetDeploymentResponse GetDeploymentWithOptions(GetDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDeploymentResponse>(DoRPCRequest("GetDeployment", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDeploymentResponse> GetDeploymentWithOptionsAsync(GetDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDeploymentResponse>(await DoRPCRequestAsync("GetDeployment", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeploymentWithOptions(request, runtime);
        }

        public async Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeploymentWithOptionsAsync(request, runtime);
        }

        public GetDISyncInstanceInfoResponse GetDISyncInstanceInfoWithOptions(GetDISyncInstanceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDISyncInstanceInfoResponse>(DoRPCRequest("GetDISyncInstanceInfo", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDISyncInstanceInfoResponse> GetDISyncInstanceInfoWithOptionsAsync(GetDISyncInstanceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDISyncInstanceInfoResponse>(await DoRPCRequestAsync("GetDISyncInstanceInfo", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDISyncInstanceInfoResponse GetDISyncInstanceInfo(GetDISyncInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDISyncInstanceInfoWithOptions(request, runtime);
        }

        public async Task<GetDISyncInstanceInfoResponse> GetDISyncInstanceInfoAsync(GetDISyncInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDISyncInstanceInfoWithOptionsAsync(request, runtime);
        }

        public GetDISyncTaskResponse GetDISyncTaskWithOptions(GetDISyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDISyncTaskResponse>(DoRPCRequest("GetDISyncTask", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDISyncTaskResponse> GetDISyncTaskWithOptionsAsync(GetDISyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDISyncTaskResponse>(await DoRPCRequestAsync("GetDISyncTask", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDISyncTaskResponse GetDISyncTask(GetDISyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDISyncTaskWithOptions(request, runtime);
        }

        public async Task<GetDISyncTaskResponse> GetDISyncTaskAsync(GetDISyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDISyncTaskWithOptionsAsync(request, runtime);
        }

        public GetDISyncTaskMetricInfoResponse GetDISyncTaskMetricInfoWithOptions(GetDISyncTaskMetricInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDISyncTaskMetricInfoResponse>(DoRPCRequest("GetDISyncTaskMetricInfo", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetDISyncTaskMetricInfoResponse> GetDISyncTaskMetricInfoWithOptionsAsync(GetDISyncTaskMetricInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDISyncTaskMetricInfoResponse>(await DoRPCRequestAsync("GetDISyncTaskMetricInfo", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetDISyncTaskMetricInfoResponse GetDISyncTaskMetricInfo(GetDISyncTaskMetricInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDISyncTaskMetricInfoWithOptions(request, runtime);
        }

        public async Task<GetDISyncTaskMetricInfoResponse> GetDISyncTaskMetricInfoAsync(GetDISyncTaskMetricInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDISyncTaskMetricInfoWithOptionsAsync(request, runtime);
        }

        public GetFileResponse GetFileWithOptions(GetFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetFileResponse>(DoRPCRequest("GetFile", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetFileResponse> GetFileWithOptionsAsync(GetFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetFileResponse>(await DoRPCRequestAsync("GetFile", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetFileResponse GetFile(GetFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFileWithOptions(request, runtime);
        }

        public async Task<GetFileResponse> GetFileAsync(GetFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFileWithOptionsAsync(request, runtime);
        }

        public GetFileTypeStatisticResponse GetFileTypeStatisticWithOptions(GetFileTypeStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetFileTypeStatisticResponse>(DoRPCRequest("GetFileTypeStatistic", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetFileTypeStatisticResponse> GetFileTypeStatisticWithOptionsAsync(GetFileTypeStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetFileTypeStatisticResponse>(await DoRPCRequestAsync("GetFileTypeStatistic", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetFileTypeStatisticResponse GetFileTypeStatistic(GetFileTypeStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFileTypeStatisticWithOptions(request, runtime);
        }

        public async Task<GetFileTypeStatisticResponse> GetFileTypeStatisticAsync(GetFileTypeStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFileTypeStatisticWithOptionsAsync(request, runtime);
        }

        public GetFileVersionResponse GetFileVersionWithOptions(GetFileVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetFileVersionResponse>(DoRPCRequest("GetFileVersion", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetFileVersionResponse> GetFileVersionWithOptionsAsync(GetFileVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetFileVersionResponse>(await DoRPCRequestAsync("GetFileVersion", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetFileVersionResponse GetFileVersion(GetFileVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFileVersionWithOptions(request, runtime);
        }

        public async Task<GetFileVersionResponse> GetFileVersionAsync(GetFileVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFileVersionWithOptionsAsync(request, runtime);
        }

        public GetFolderResponse GetFolderWithOptions(GetFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetFolderResponse>(DoRPCRequest("GetFolder", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetFolderResponse> GetFolderWithOptionsAsync(GetFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetFolderResponse>(await DoRPCRequestAsync("GetFolder", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetFolderResponse GetFolder(GetFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFolderWithOptions(request, runtime);
        }

        public async Task<GetFolderResponse> GetFolderAsync(GetFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFolderWithOptionsAsync(request, runtime);
        }

        public GetInstanceResponse GetInstanceWithOptions(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceResponse>(DoRPCRequest("GetInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceResponse> GetInstanceWithOptionsAsync(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceResponse>(await DoRPCRequestAsync("GetInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceResponse GetInstance(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceWithOptions(request, runtime);
        }

        public async Task<GetInstanceResponse> GetInstanceAsync(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceWithOptionsAsync(request, runtime);
        }

        public GetInstanceConsumeTimeRankResponse GetInstanceConsumeTimeRankWithOptions(GetInstanceConsumeTimeRankRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceConsumeTimeRankResponse>(DoRPCRequest("GetInstanceConsumeTimeRank", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceConsumeTimeRankResponse> GetInstanceConsumeTimeRankWithOptionsAsync(GetInstanceConsumeTimeRankRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceConsumeTimeRankResponse>(await DoRPCRequestAsync("GetInstanceConsumeTimeRank", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceConsumeTimeRankResponse GetInstanceConsumeTimeRank(GetInstanceConsumeTimeRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceConsumeTimeRankWithOptions(request, runtime);
        }

        public async Task<GetInstanceConsumeTimeRankResponse> GetInstanceConsumeTimeRankAsync(GetInstanceConsumeTimeRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceConsumeTimeRankWithOptionsAsync(request, runtime);
        }

        public GetInstanceCountTrendResponse GetInstanceCountTrendWithOptions(GetInstanceCountTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceCountTrendResponse>(DoRPCRequest("GetInstanceCountTrend", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceCountTrendResponse> GetInstanceCountTrendWithOptionsAsync(GetInstanceCountTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceCountTrendResponse>(await DoRPCRequestAsync("GetInstanceCountTrend", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceCountTrendResponse GetInstanceCountTrend(GetInstanceCountTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceCountTrendWithOptions(request, runtime);
        }

        public async Task<GetInstanceCountTrendResponse> GetInstanceCountTrendAsync(GetInstanceCountTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceCountTrendWithOptionsAsync(request, runtime);
        }

        public GetInstanceErrorRankResponse GetInstanceErrorRankWithOptions(GetInstanceErrorRankRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceErrorRankResponse>(DoRPCRequest("GetInstanceErrorRank", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceErrorRankResponse> GetInstanceErrorRankWithOptionsAsync(GetInstanceErrorRankRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceErrorRankResponse>(await DoRPCRequestAsync("GetInstanceErrorRank", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceErrorRankResponse GetInstanceErrorRank(GetInstanceErrorRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceErrorRankWithOptions(request, runtime);
        }

        public async Task<GetInstanceErrorRankResponse> GetInstanceErrorRankAsync(GetInstanceErrorRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceErrorRankWithOptionsAsync(request, runtime);
        }

        public GetInstanceLogResponse GetInstanceLogWithOptions(GetInstanceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceLogResponse>(DoRPCRequest("GetInstanceLog", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceLogResponse> GetInstanceLogWithOptionsAsync(GetInstanceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceLogResponse>(await DoRPCRequestAsync("GetInstanceLog", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceLogResponse GetInstanceLog(GetInstanceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceLogWithOptions(request, runtime);
        }

        public async Task<GetInstanceLogResponse> GetInstanceLogAsync(GetInstanceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceLogWithOptionsAsync(request, runtime);
        }

        public GetInstanceStatusCountResponse GetInstanceStatusCountWithOptions(GetInstanceStatusCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceStatusCountResponse>(DoRPCRequest("GetInstanceStatusCount", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceStatusCountResponse> GetInstanceStatusCountWithOptionsAsync(GetInstanceStatusCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceStatusCountResponse>(await DoRPCRequestAsync("GetInstanceStatusCount", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceStatusCountResponse GetInstanceStatusCount(GetInstanceStatusCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceStatusCountWithOptions(request, runtime);
        }

        public async Task<GetInstanceStatusCountResponse> GetInstanceStatusCountAsync(GetInstanceStatusCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceStatusCountWithOptionsAsync(request, runtime);
        }

        public GetInstanceStatusStatisticResponse GetInstanceStatusStatisticWithOptions(GetInstanceStatusStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceStatusStatisticResponse>(DoRPCRequest("GetInstanceStatusStatistic", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceStatusStatisticResponse> GetInstanceStatusStatisticWithOptionsAsync(GetInstanceStatusStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceStatusStatisticResponse>(await DoRPCRequestAsync("GetInstanceStatusStatistic", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceStatusStatisticResponse GetInstanceStatusStatistic(GetInstanceStatusStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceStatusStatisticWithOptions(request, runtime);
        }

        public async Task<GetInstanceStatusStatisticResponse> GetInstanceStatusStatisticAsync(GetInstanceStatusStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceStatusStatisticWithOptionsAsync(request, runtime);
        }

        public GetManualDagInstancesResponse GetManualDagInstancesWithOptions(GetManualDagInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetManualDagInstancesResponse>(DoRPCRequest("GetManualDagInstances", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetManualDagInstancesResponse> GetManualDagInstancesWithOptionsAsync(GetManualDagInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetManualDagInstancesResponse>(await DoRPCRequestAsync("GetManualDagInstances", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetManualDagInstancesResponse GetManualDagInstances(GetManualDagInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetManualDagInstancesWithOptions(request, runtime);
        }

        public async Task<GetManualDagInstancesResponse> GetManualDagInstancesAsync(GetManualDagInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetManualDagInstancesWithOptionsAsync(request, runtime);
        }

        public GetMetaCategoryResponse GetMetaCategoryWithOptions(GetMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetaCategoryResponse>(DoRPCRequest("GetMetaCategory", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMetaCategoryResponse> GetMetaCategoryWithOptionsAsync(GetMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetaCategoryResponse>(await DoRPCRequestAsync("GetMetaCategory", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMetaCategoryResponse GetMetaCategory(GetMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaCategoryWithOptions(request, runtime);
        }

        public async Task<GetMetaCategoryResponse> GetMetaCategoryAsync(GetMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaCategoryWithOptionsAsync(request, runtime);
        }

        public GetMetaColumnLineageResponse GetMetaColumnLineageWithOptions(GetMetaColumnLineageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetaColumnLineageResponse>(DoRPCRequest("GetMetaColumnLineage", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMetaColumnLineageResponse> GetMetaColumnLineageWithOptionsAsync(GetMetaColumnLineageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetaColumnLineageResponse>(await DoRPCRequestAsync("GetMetaColumnLineage", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMetaColumnLineageResponse GetMetaColumnLineage(GetMetaColumnLineageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaColumnLineageWithOptions(request, runtime);
        }

        public async Task<GetMetaColumnLineageResponse> GetMetaColumnLineageAsync(GetMetaColumnLineageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaColumnLineageWithOptionsAsync(request, runtime);
        }

        public GetMetaDBInfoResponse GetMetaDBInfoWithOptions(GetMetaDBInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetMetaDBInfoResponse>(DoRPCRequest("GetMetaDBInfo", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetMetaDBInfoResponse> GetMetaDBInfoWithOptionsAsync(GetMetaDBInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetMetaDBInfoResponse>(await DoRPCRequestAsync("GetMetaDBInfo", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetMetaDBInfoResponse GetMetaDBInfo(GetMetaDBInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaDBInfoWithOptions(request, runtime);
        }

        public async Task<GetMetaDBInfoResponse> GetMetaDBInfoAsync(GetMetaDBInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaDBInfoWithOptionsAsync(request, runtime);
        }

        public GetMetaDBTableListResponse GetMetaDBTableListWithOptions(GetMetaDBTableListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetaDBTableListResponse>(DoRPCRequest("GetMetaDBTableList", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMetaDBTableListResponse> GetMetaDBTableListWithOptionsAsync(GetMetaDBTableListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetaDBTableListResponse>(await DoRPCRequestAsync("GetMetaDBTableList", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMetaDBTableListResponse GetMetaDBTableList(GetMetaDBTableListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaDBTableListWithOptions(request, runtime);
        }

        public async Task<GetMetaDBTableListResponse> GetMetaDBTableListAsync(GetMetaDBTableListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaDBTableListWithOptionsAsync(request, runtime);
        }

        public GetMetaTableBasicInfoResponse GetMetaTableBasicInfoWithOptions(GetMetaTableBasicInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetMetaTableBasicInfoResponse>(DoRPCRequest("GetMetaTableBasicInfo", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetMetaTableBasicInfoResponse> GetMetaTableBasicInfoWithOptionsAsync(GetMetaTableBasicInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetMetaTableBasicInfoResponse>(await DoRPCRequestAsync("GetMetaTableBasicInfo", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetMetaTableBasicInfoResponse GetMetaTableBasicInfo(GetMetaTableBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTableBasicInfoWithOptions(request, runtime);
        }

        public async Task<GetMetaTableBasicInfoResponse> GetMetaTableBasicInfoAsync(GetMetaTableBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTableBasicInfoWithOptionsAsync(request, runtime);
        }

        public GetMetaTableChangeLogResponse GetMetaTableChangeLogWithOptions(GetMetaTableChangeLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetaTableChangeLogResponse>(DoRPCRequest("GetMetaTableChangeLog", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMetaTableChangeLogResponse> GetMetaTableChangeLogWithOptionsAsync(GetMetaTableChangeLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetaTableChangeLogResponse>(await DoRPCRequestAsync("GetMetaTableChangeLog", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMetaTableChangeLogResponse GetMetaTableChangeLog(GetMetaTableChangeLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTableChangeLogWithOptions(request, runtime);
        }

        public async Task<GetMetaTableChangeLogResponse> GetMetaTableChangeLogAsync(GetMetaTableChangeLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTableChangeLogWithOptionsAsync(request, runtime);
        }

        public GetMetaTableColumnResponse GetMetaTableColumnWithOptions(GetMetaTableColumnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetMetaTableColumnResponse>(DoRPCRequest("GetMetaTableColumn", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetMetaTableColumnResponse> GetMetaTableColumnWithOptionsAsync(GetMetaTableColumnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetMetaTableColumnResponse>(await DoRPCRequestAsync("GetMetaTableColumn", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetMetaTableColumnResponse GetMetaTableColumn(GetMetaTableColumnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTableColumnWithOptions(request, runtime);
        }

        public async Task<GetMetaTableColumnResponse> GetMetaTableColumnAsync(GetMetaTableColumnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTableColumnWithOptionsAsync(request, runtime);
        }

        public GetMetaTableFullInfoResponse GetMetaTableFullInfoWithOptions(GetMetaTableFullInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetMetaTableFullInfoResponse>(DoRPCRequest("GetMetaTableFullInfo", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetMetaTableFullInfoResponse> GetMetaTableFullInfoWithOptionsAsync(GetMetaTableFullInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetMetaTableFullInfoResponse>(await DoRPCRequestAsync("GetMetaTableFullInfo", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetMetaTableFullInfoResponse GetMetaTableFullInfo(GetMetaTableFullInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTableFullInfoWithOptions(request, runtime);
        }

        public async Task<GetMetaTableFullInfoResponse> GetMetaTableFullInfoAsync(GetMetaTableFullInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTableFullInfoWithOptionsAsync(request, runtime);
        }

        public GetMetaTableIntroWikiResponse GetMetaTableIntroWikiWithOptions(GetMetaTableIntroWikiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetaTableIntroWikiResponse>(DoRPCRequest("GetMetaTableIntroWiki", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMetaTableIntroWikiResponse> GetMetaTableIntroWikiWithOptionsAsync(GetMetaTableIntroWikiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetaTableIntroWikiResponse>(await DoRPCRequestAsync("GetMetaTableIntroWiki", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMetaTableIntroWikiResponse GetMetaTableIntroWiki(GetMetaTableIntroWikiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTableIntroWikiWithOptions(request, runtime);
        }

        public async Task<GetMetaTableIntroWikiResponse> GetMetaTableIntroWikiAsync(GetMetaTableIntroWikiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTableIntroWikiWithOptionsAsync(request, runtime);
        }

        public GetMetaTableLineageResponse GetMetaTableLineageWithOptions(GetMetaTableLineageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetaTableLineageResponse>(DoRPCRequest("GetMetaTableLineage", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMetaTableLineageResponse> GetMetaTableLineageWithOptionsAsync(GetMetaTableLineageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetaTableLineageResponse>(await DoRPCRequestAsync("GetMetaTableLineage", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMetaTableLineageResponse GetMetaTableLineage(GetMetaTableLineageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTableLineageWithOptions(request, runtime);
        }

        public async Task<GetMetaTableLineageResponse> GetMetaTableLineageAsync(GetMetaTableLineageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTableLineageWithOptionsAsync(request, runtime);
        }

        public GetMetaTableListByCategoryResponse GetMetaTableListByCategoryWithOptions(GetMetaTableListByCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetMetaTableListByCategoryResponse>(DoRPCRequest("GetMetaTableListByCategory", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetMetaTableListByCategoryResponse> GetMetaTableListByCategoryWithOptionsAsync(GetMetaTableListByCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetMetaTableListByCategoryResponse>(await DoRPCRequestAsync("GetMetaTableListByCategory", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetMetaTableListByCategoryResponse GetMetaTableListByCategory(GetMetaTableListByCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTableListByCategoryWithOptions(request, runtime);
        }

        public async Task<GetMetaTableListByCategoryResponse> GetMetaTableListByCategoryAsync(GetMetaTableListByCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTableListByCategoryWithOptionsAsync(request, runtime);
        }

        public GetMetaTableOutputResponse GetMetaTableOutputWithOptions(GetMetaTableOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetaTableOutputResponse>(DoRPCRequest("GetMetaTableOutput", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMetaTableOutputResponse> GetMetaTableOutputWithOptionsAsync(GetMetaTableOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetaTableOutputResponse>(await DoRPCRequestAsync("GetMetaTableOutput", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMetaTableOutputResponse GetMetaTableOutput(GetMetaTableOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTableOutputWithOptions(request, runtime);
        }

        public async Task<GetMetaTableOutputResponse> GetMetaTableOutputAsync(GetMetaTableOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTableOutputWithOptionsAsync(request, runtime);
        }

        public GetMetaTablePartitionResponse GetMetaTablePartitionWithOptions(GetMetaTablePartitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetaTablePartitionResponse>(DoRPCRequest("GetMetaTablePartition", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMetaTablePartitionResponse> GetMetaTablePartitionWithOptionsAsync(GetMetaTablePartitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetaTablePartitionResponse>(await DoRPCRequestAsync("GetMetaTablePartition", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMetaTablePartitionResponse GetMetaTablePartition(GetMetaTablePartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTablePartitionWithOptions(request, runtime);
        }

        public async Task<GetMetaTablePartitionResponse> GetMetaTablePartitionAsync(GetMetaTablePartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTablePartitionWithOptionsAsync(request, runtime);
        }

        public GetMetaTableThemeLevelResponse GetMetaTableThemeLevelWithOptions(GetMetaTableThemeLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetMetaTableThemeLevelResponse>(DoRPCRequest("GetMetaTableThemeLevel", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetMetaTableThemeLevelResponse> GetMetaTableThemeLevelWithOptionsAsync(GetMetaTableThemeLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetMetaTableThemeLevelResponse>(await DoRPCRequestAsync("GetMetaTableThemeLevel", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetMetaTableThemeLevelResponse GetMetaTableThemeLevel(GetMetaTableThemeLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTableThemeLevelWithOptions(request, runtime);
        }

        public async Task<GetMetaTableThemeLevelResponse> GetMetaTableThemeLevelAsync(GetMetaTableThemeLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTableThemeLevelWithOptionsAsync(request, runtime);
        }

        public GetMigrationProcessResponse GetMigrationProcessWithOptions(GetMigrationProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMigrationProcessResponse>(DoRPCRequest("GetMigrationProcess", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMigrationProcessResponse> GetMigrationProcessWithOptionsAsync(GetMigrationProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMigrationProcessResponse>(await DoRPCRequestAsync("GetMigrationProcess", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMigrationProcessResponse GetMigrationProcess(GetMigrationProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMigrationProcessWithOptions(request, runtime);
        }

        public async Task<GetMigrationProcessResponse> GetMigrationProcessAsync(GetMigrationProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMigrationProcessWithOptionsAsync(request, runtime);
        }

        public GetNodeResponse GetNodeWithOptions(GetNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNodeResponse>(DoRPCRequest("GetNode", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetNodeResponse> GetNodeWithOptionsAsync(GetNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNodeResponse>(await DoRPCRequestAsync("GetNode", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetNodeResponse GetNode(GetNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNodeWithOptions(request, runtime);
        }

        public async Task<GetNodeResponse> GetNodeAsync(GetNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNodeWithOptionsAsync(request, runtime);
        }

        public GetNodeChildrenResponse GetNodeChildrenWithOptions(GetNodeChildrenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNodeChildrenResponse>(DoRPCRequest("GetNodeChildren", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetNodeChildrenResponse> GetNodeChildrenWithOptionsAsync(GetNodeChildrenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNodeChildrenResponse>(await DoRPCRequestAsync("GetNodeChildren", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetNodeChildrenResponse GetNodeChildren(GetNodeChildrenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNodeChildrenWithOptions(request, runtime);
        }

        public async Task<GetNodeChildrenResponse> GetNodeChildrenAsync(GetNodeChildrenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNodeChildrenWithOptionsAsync(request, runtime);
        }

        public GetNodeCodeResponse GetNodeCodeWithOptions(GetNodeCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNodeCodeResponse>(DoRPCRequest("GetNodeCode", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetNodeCodeResponse> GetNodeCodeWithOptionsAsync(GetNodeCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNodeCodeResponse>(await DoRPCRequestAsync("GetNodeCode", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetNodeCodeResponse GetNodeCode(GetNodeCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNodeCodeWithOptions(request, runtime);
        }

        public async Task<GetNodeCodeResponse> GetNodeCodeAsync(GetNodeCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNodeCodeWithOptionsAsync(request, runtime);
        }

        public GetNodeOnBaselineResponse GetNodeOnBaselineWithOptions(GetNodeOnBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNodeOnBaselineResponse>(DoRPCRequest("GetNodeOnBaseline", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetNodeOnBaselineResponse> GetNodeOnBaselineWithOptionsAsync(GetNodeOnBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNodeOnBaselineResponse>(await DoRPCRequestAsync("GetNodeOnBaseline", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetNodeOnBaselineResponse GetNodeOnBaseline(GetNodeOnBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNodeOnBaselineWithOptions(request, runtime);
        }

        public async Task<GetNodeOnBaselineResponse> GetNodeOnBaselineAsync(GetNodeOnBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNodeOnBaselineWithOptionsAsync(request, runtime);
        }

        public GetNodeParentsResponse GetNodeParentsWithOptions(GetNodeParentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNodeParentsResponse>(DoRPCRequest("GetNodeParents", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetNodeParentsResponse> GetNodeParentsWithOptionsAsync(GetNodeParentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNodeParentsResponse>(await DoRPCRequestAsync("GetNodeParents", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetNodeParentsResponse GetNodeParents(GetNodeParentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNodeParentsWithOptions(request, runtime);
        }

        public async Task<GetNodeParentsResponse> GetNodeParentsAsync(GetNodeParentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNodeParentsWithOptionsAsync(request, runtime);
        }

        public GetNodeTypeListInfoResponse GetNodeTypeListInfoWithOptions(GetNodeTypeListInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNodeTypeListInfoResponse>(DoRPCRequest("GetNodeTypeListInfo", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetNodeTypeListInfoResponse> GetNodeTypeListInfoWithOptionsAsync(GetNodeTypeListInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNodeTypeListInfoResponse>(await DoRPCRequestAsync("GetNodeTypeListInfo", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetNodeTypeListInfoResponse GetNodeTypeListInfo(GetNodeTypeListInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNodeTypeListInfoWithOptions(request, runtime);
        }

        public async Task<GetNodeTypeListInfoResponse> GetNodeTypeListInfoAsync(GetNodeTypeListInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNodeTypeListInfoWithOptionsAsync(request, runtime);
        }

        public GetOpRiskDataResponse GetOpRiskDataWithOptions(GetOpRiskDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetOpRiskDataResponse>(DoRPCRequest("GetOpRiskData", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetOpRiskDataResponse> GetOpRiskDataWithOptionsAsync(GetOpRiskDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetOpRiskDataResponse>(await DoRPCRequestAsync("GetOpRiskData", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetOpRiskDataResponse GetOpRiskData(GetOpRiskDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOpRiskDataWithOptions(request, runtime);
        }

        public async Task<GetOpRiskDataResponse> GetOpRiskDataAsync(GetOpRiskDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOpRiskDataWithOptionsAsync(request, runtime);
        }

        public GetOpSensitiveDataResponse GetOpSensitiveDataWithOptions(GetOpSensitiveDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetOpSensitiveDataResponse>(DoRPCRequest("GetOpSensitiveData", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetOpSensitiveDataResponse> GetOpSensitiveDataWithOptionsAsync(GetOpSensitiveDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetOpSensitiveDataResponse>(await DoRPCRequestAsync("GetOpSensitiveData", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetOpSensitiveDataResponse GetOpSensitiveData(GetOpSensitiveDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOpSensitiveDataWithOptions(request, runtime);
        }

        public async Task<GetOpSensitiveDataResponse> GetOpSensitiveDataAsync(GetOpSensitiveDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOpSensitiveDataWithOptionsAsync(request, runtime);
        }

        public GetPermissionApplyOrderDetailResponse GetPermissionApplyOrderDetailWithOptions(GetPermissionApplyOrderDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPermissionApplyOrderDetailResponse>(DoRPCRequest("GetPermissionApplyOrderDetail", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPermissionApplyOrderDetailResponse> GetPermissionApplyOrderDetailWithOptionsAsync(GetPermissionApplyOrderDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPermissionApplyOrderDetailResponse>(await DoRPCRequestAsync("GetPermissionApplyOrderDetail", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPermissionApplyOrderDetailResponse GetPermissionApplyOrderDetail(GetPermissionApplyOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPermissionApplyOrderDetailWithOptions(request, runtime);
        }

        public async Task<GetPermissionApplyOrderDetailResponse> GetPermissionApplyOrderDetailAsync(GetPermissionApplyOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPermissionApplyOrderDetailWithOptionsAsync(request, runtime);
        }

        public GetProjectResponse GetProjectWithOptions(GetProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProjectResponse>(DoRPCRequest("GetProject", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetProjectResponse> GetProjectWithOptionsAsync(GetProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProjectResponse>(await DoRPCRequestAsync("GetProject", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetProjectResponse GetProject(GetProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProjectWithOptions(request, runtime);
        }

        public async Task<GetProjectResponse> GetProjectAsync(GetProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProjectWithOptionsAsync(request, runtime);
        }

        public GetProjectDetailResponse GetProjectDetailWithOptions(GetProjectDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProjectDetailResponse>(DoRPCRequest("GetProjectDetail", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetProjectDetailResponse> GetProjectDetailWithOptionsAsync(GetProjectDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProjectDetailResponse>(await DoRPCRequestAsync("GetProjectDetail", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetProjectDetailResponse GetProjectDetail(GetProjectDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProjectDetailWithOptions(request, runtime);
        }

        public async Task<GetProjectDetailResponse> GetProjectDetailAsync(GetProjectDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProjectDetailWithOptionsAsync(request, runtime);
        }

        public GetQualityEntityResponse GetQualityEntityWithOptions(GetQualityEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualityEntityResponse>(DoRPCRequest("GetQualityEntity", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetQualityEntityResponse> GetQualityEntityWithOptionsAsync(GetQualityEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualityEntityResponse>(await DoRPCRequestAsync("GetQualityEntity", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetQualityEntityResponse GetQualityEntity(GetQualityEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityEntityWithOptions(request, runtime);
        }

        public async Task<GetQualityEntityResponse> GetQualityEntityAsync(GetQualityEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityEntityWithOptionsAsync(request, runtime);
        }

        public GetQualityFollowerResponse GetQualityFollowerWithOptions(GetQualityFollowerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualityFollowerResponse>(DoRPCRequest("GetQualityFollower", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetQualityFollowerResponse> GetQualityFollowerWithOptionsAsync(GetQualityFollowerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualityFollowerResponse>(await DoRPCRequestAsync("GetQualityFollower", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetQualityFollowerResponse GetQualityFollower(GetQualityFollowerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityFollowerWithOptions(request, runtime);
        }

        public async Task<GetQualityFollowerResponse> GetQualityFollowerAsync(GetQualityFollowerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityFollowerWithOptionsAsync(request, runtime);
        }

        public GetQualityRuleResponse GetQualityRuleWithOptions(GetQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualityRuleResponse>(DoRPCRequest("GetQualityRule", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetQualityRuleResponse> GetQualityRuleWithOptionsAsync(GetQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualityRuleResponse>(await DoRPCRequestAsync("GetQualityRule", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetQualityRuleResponse GetQualityRule(GetQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityRuleWithOptions(request, runtime);
        }

        public async Task<GetQualityRuleResponse> GetQualityRuleAsync(GetQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityRuleWithOptionsAsync(request, runtime);
        }

        public GetRemindResponse GetRemindWithOptions(GetRemindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRemindResponse>(DoRPCRequest("GetRemind", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRemindResponse> GetRemindWithOptionsAsync(GetRemindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRemindResponse>(await DoRPCRequestAsync("GetRemind", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRemindResponse GetRemind(GetRemindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRemindWithOptions(request, runtime);
        }

        public async Task<GetRemindResponse> GetRemindAsync(GetRemindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRemindWithOptionsAsync(request, runtime);
        }

        public GetSensitiveDataResponse GetSensitiveDataWithOptions(GetSensitiveDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetSensitiveDataResponse>(DoRPCRequest("GetSensitiveData", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetSensitiveDataResponse> GetSensitiveDataWithOptionsAsync(GetSensitiveDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetSensitiveDataResponse>(await DoRPCRequestAsync("GetSensitiveData", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetSensitiveDataResponse GetSensitiveData(GetSensitiveDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSensitiveDataWithOptions(request, runtime);
        }

        public async Task<GetSensitiveDataResponse> GetSensitiveDataAsync(GetSensitiveDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSensitiveDataWithOptionsAsync(request, runtime);
        }

        public GetSuccessInstanceTrendResponse GetSuccessInstanceTrendWithOptions(GetSuccessInstanceTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSuccessInstanceTrendResponse>(DoRPCRequest("GetSuccessInstanceTrend", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSuccessInstanceTrendResponse> GetSuccessInstanceTrendWithOptionsAsync(GetSuccessInstanceTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSuccessInstanceTrendResponse>(await DoRPCRequestAsync("GetSuccessInstanceTrend", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSuccessInstanceTrendResponse GetSuccessInstanceTrend(GetSuccessInstanceTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSuccessInstanceTrendWithOptions(request, runtime);
        }

        public async Task<GetSuccessInstanceTrendResponse> GetSuccessInstanceTrendAsync(GetSuccessInstanceTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSuccessInstanceTrendWithOptionsAsync(request, runtime);
        }

        public GetTopicResponse GetTopicWithOptions(GetTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTopicResponse>(DoRPCRequest("GetTopic", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTopicResponse> GetTopicWithOptionsAsync(GetTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTopicResponse>(await DoRPCRequestAsync("GetTopic", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTopicResponse GetTopic(GetTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTopicWithOptions(request, runtime);
        }

        public async Task<GetTopicResponse> GetTopicAsync(GetTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTopicWithOptionsAsync(request, runtime);
        }

        public GetTopicInfluenceResponse GetTopicInfluenceWithOptions(GetTopicInfluenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTopicInfluenceResponse>(DoRPCRequest("GetTopicInfluence", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTopicInfluenceResponse> GetTopicInfluenceWithOptionsAsync(GetTopicInfluenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTopicInfluenceResponse>(await DoRPCRequestAsync("GetTopicInfluence", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTopicInfluenceResponse GetTopicInfluence(GetTopicInfluenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTopicInfluenceWithOptions(request, runtime);
        }

        public async Task<GetTopicInfluenceResponse> GetTopicInfluenceAsync(GetTopicInfluenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTopicInfluenceWithOptionsAsync(request, runtime);
        }

        public ImportConnectionsResponse ImportConnectionsWithOptions(ImportConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportConnectionsResponse>(DoRPCRequest("ImportConnections", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportConnectionsResponse> ImportConnectionsWithOptionsAsync(ImportConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportConnectionsResponse>(await DoRPCRequestAsync("ImportConnections", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportConnectionsResponse ImportConnections(ImportConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportConnectionsWithOptions(request, runtime);
        }

        public async Task<ImportConnectionsResponse> ImportConnectionsAsync(ImportConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportConnectionsWithOptionsAsync(request, runtime);
        }

        public ImportDataSourcesResponse ImportDataSourcesWithOptions(ImportDataSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportDataSourcesResponse>(DoRPCRequest("ImportDataSources", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportDataSourcesResponse> ImportDataSourcesWithOptionsAsync(ImportDataSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportDataSourcesResponse>(await DoRPCRequestAsync("ImportDataSources", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportDataSourcesResponse ImportDataSources(ImportDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportDataSourcesWithOptions(request, runtime);
        }

        public async Task<ImportDataSourcesResponse> ImportDataSourcesAsync(ImportDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportDataSourcesWithOptionsAsync(request, runtime);
        }

        public ImportDISyncTasksResponse ImportDISyncTasksWithOptions(ImportDISyncTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportDISyncTasksResponse>(DoRPCRequest("ImportDISyncTasks", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportDISyncTasksResponse> ImportDISyncTasksWithOptionsAsync(ImportDISyncTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportDISyncTasksResponse>(await DoRPCRequestAsync("ImportDISyncTasks", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportDISyncTasksResponse ImportDISyncTasks(ImportDISyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportDISyncTasksWithOptions(request, runtime);
        }

        public async Task<ImportDISyncTasksResponse> ImportDISyncTasksAsync(ImportDISyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportDISyncTasksWithOptionsAsync(request, runtime);
        }

        public ListAlertMessagesResponse ListAlertMessagesWithOptions(ListAlertMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAlertMessagesResponse>(DoRPCRequest("ListAlertMessages", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAlertMessagesResponse> ListAlertMessagesWithOptionsAsync(ListAlertMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAlertMessagesResponse>(await DoRPCRequestAsync("ListAlertMessages", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAlertMessagesResponse ListAlertMessages(ListAlertMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAlertMessagesWithOptions(request, runtime);
        }

        public async Task<ListAlertMessagesResponse> ListAlertMessagesAsync(ListAlertMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAlertMessagesWithOptionsAsync(request, runtime);
        }

        public ListBaselineConfigsResponse ListBaselineConfigsWithOptions(ListBaselineConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBaselineConfigsResponse>(DoRPCRequest("ListBaselineConfigs", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListBaselineConfigsResponse> ListBaselineConfigsWithOptionsAsync(ListBaselineConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBaselineConfigsResponse>(await DoRPCRequestAsync("ListBaselineConfigs", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListBaselineConfigsResponse ListBaselineConfigs(ListBaselineConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBaselineConfigsWithOptions(request, runtime);
        }

        public async Task<ListBaselineConfigsResponse> ListBaselineConfigsAsync(ListBaselineConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBaselineConfigsWithOptionsAsync(request, runtime);
        }

        public ListBaselineStatusesResponse ListBaselineStatusesWithOptions(ListBaselineStatusesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBaselineStatusesResponse>(DoRPCRequest("ListBaselineStatuses", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListBaselineStatusesResponse> ListBaselineStatusesWithOptionsAsync(ListBaselineStatusesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBaselineStatusesResponse>(await DoRPCRequestAsync("ListBaselineStatuses", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListBaselineStatusesResponse ListBaselineStatuses(ListBaselineStatusesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBaselineStatusesWithOptions(request, runtime);
        }

        public async Task<ListBaselineStatusesResponse> ListBaselineStatusesAsync(ListBaselineStatusesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBaselineStatusesWithOptionsAsync(request, runtime);
        }

        public ListBusinessResponse ListBusinessWithOptions(ListBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBusinessResponse>(DoRPCRequest("ListBusiness", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListBusinessResponse> ListBusinessWithOptionsAsync(ListBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBusinessResponse>(await DoRPCRequestAsync("ListBusiness", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListBusinessResponse ListBusiness(ListBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBusinessWithOptions(request, runtime);
        }

        public async Task<ListBusinessResponse> ListBusinessAsync(ListBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBusinessWithOptionsAsync(request, runtime);
        }

        public ListCalcEnginesResponse ListCalcEnginesWithOptions(ListCalcEnginesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCalcEnginesResponse>(DoRPCRequest("ListCalcEngines", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCalcEnginesResponse> ListCalcEnginesWithOptionsAsync(ListCalcEnginesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCalcEnginesResponse>(await DoRPCRequestAsync("ListCalcEngines", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCalcEnginesResponse ListCalcEngines(ListCalcEnginesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCalcEnginesWithOptions(request, runtime);
        }

        public async Task<ListCalcEnginesResponse> ListCalcEnginesAsync(ListCalcEnginesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCalcEnginesWithOptionsAsync(request, runtime);
        }

        public ListConnectionsResponse ListConnectionsWithOptions(ListConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListConnectionsResponse>(DoRPCRequest("ListConnections", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListConnectionsResponse> ListConnectionsWithOptionsAsync(ListConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListConnectionsResponse>(await DoRPCRequestAsync("ListConnections", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListConnectionsResponse ListConnections(ListConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConnectionsWithOptions(request, runtime);
        }

        public async Task<ListConnectionsResponse> ListConnectionsAsync(ListConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConnectionsWithOptionsAsync(request, runtime);
        }

        public ListDataServiceApiAuthoritiesResponse ListDataServiceApiAuthoritiesWithOptions(ListDataServiceApiAuthoritiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataServiceApiAuthoritiesResponse>(DoRPCRequest("ListDataServiceApiAuthorities", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDataServiceApiAuthoritiesResponse> ListDataServiceApiAuthoritiesWithOptionsAsync(ListDataServiceApiAuthoritiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataServiceApiAuthoritiesResponse>(await DoRPCRequestAsync("ListDataServiceApiAuthorities", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDataServiceApiAuthoritiesResponse ListDataServiceApiAuthorities(ListDataServiceApiAuthoritiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataServiceApiAuthoritiesWithOptions(request, runtime);
        }

        public async Task<ListDataServiceApiAuthoritiesResponse> ListDataServiceApiAuthoritiesAsync(ListDataServiceApiAuthoritiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataServiceApiAuthoritiesWithOptionsAsync(request, runtime);
        }

        public ListDataServiceApisResponse ListDataServiceApisWithOptions(ListDataServiceApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataServiceApisResponse>(DoRPCRequest("ListDataServiceApis", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDataServiceApisResponse> ListDataServiceApisWithOptionsAsync(ListDataServiceApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataServiceApisResponse>(await DoRPCRequestAsync("ListDataServiceApis", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDataServiceApisResponse ListDataServiceApis(ListDataServiceApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataServiceApisWithOptions(request, runtime);
        }

        public async Task<ListDataServiceApisResponse> ListDataServiceApisAsync(ListDataServiceApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataServiceApisWithOptionsAsync(request, runtime);
        }

        public ListDataServiceApplicationsResponse ListDataServiceApplicationsWithOptions(ListDataServiceApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataServiceApplicationsResponse>(DoRPCRequest("ListDataServiceApplications", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDataServiceApplicationsResponse> ListDataServiceApplicationsWithOptionsAsync(ListDataServiceApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataServiceApplicationsResponse>(await DoRPCRequestAsync("ListDataServiceApplications", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDataServiceApplicationsResponse ListDataServiceApplications(ListDataServiceApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataServiceApplicationsWithOptions(request, runtime);
        }

        public async Task<ListDataServiceApplicationsResponse> ListDataServiceApplicationsAsync(ListDataServiceApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataServiceApplicationsWithOptionsAsync(request, runtime);
        }

        public ListDataServiceAuthorizedApisResponse ListDataServiceAuthorizedApisWithOptions(ListDataServiceAuthorizedApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataServiceAuthorizedApisResponse>(DoRPCRequest("ListDataServiceAuthorizedApis", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDataServiceAuthorizedApisResponse> ListDataServiceAuthorizedApisWithOptionsAsync(ListDataServiceAuthorizedApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataServiceAuthorizedApisResponse>(await DoRPCRequestAsync("ListDataServiceAuthorizedApis", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDataServiceAuthorizedApisResponse ListDataServiceAuthorizedApis(ListDataServiceAuthorizedApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataServiceAuthorizedApisWithOptions(request, runtime);
        }

        public async Task<ListDataServiceAuthorizedApisResponse> ListDataServiceAuthorizedApisAsync(ListDataServiceAuthorizedApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataServiceAuthorizedApisWithOptionsAsync(request, runtime);
        }

        public ListDataServiceFoldersResponse ListDataServiceFoldersWithOptions(ListDataServiceFoldersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataServiceFoldersResponse>(DoRPCRequest("ListDataServiceFolders", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDataServiceFoldersResponse> ListDataServiceFoldersWithOptionsAsync(ListDataServiceFoldersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataServiceFoldersResponse>(await DoRPCRequestAsync("ListDataServiceFolders", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDataServiceFoldersResponse ListDataServiceFolders(ListDataServiceFoldersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataServiceFoldersWithOptions(request, runtime);
        }

        public async Task<ListDataServiceFoldersResponse> ListDataServiceFoldersAsync(ListDataServiceFoldersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataServiceFoldersWithOptionsAsync(request, runtime);
        }

        public ListDataServiceGroupsResponse ListDataServiceGroupsWithOptions(ListDataServiceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataServiceGroupsResponse>(DoRPCRequest("ListDataServiceGroups", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDataServiceGroupsResponse> ListDataServiceGroupsWithOptionsAsync(ListDataServiceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataServiceGroupsResponse>(await DoRPCRequestAsync("ListDataServiceGroups", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDataServiceGroupsResponse ListDataServiceGroups(ListDataServiceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataServiceGroupsWithOptions(request, runtime);
        }

        public async Task<ListDataServiceGroupsResponse> ListDataServiceGroupsAsync(ListDataServiceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataServiceGroupsWithOptionsAsync(request, runtime);
        }

        public ListDataServicePublishedApisResponse ListDataServicePublishedApisWithOptions(ListDataServicePublishedApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataServicePublishedApisResponse>(DoRPCRequest("ListDataServicePublishedApis", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDataServicePublishedApisResponse> ListDataServicePublishedApisWithOptionsAsync(ListDataServicePublishedApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataServicePublishedApisResponse>(await DoRPCRequestAsync("ListDataServicePublishedApis", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDataServicePublishedApisResponse ListDataServicePublishedApis(ListDataServicePublishedApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataServicePublishedApisWithOptions(request, runtime);
        }

        public async Task<ListDataServicePublishedApisResponse> ListDataServicePublishedApisAsync(ListDataServicePublishedApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataServicePublishedApisWithOptionsAsync(request, runtime);
        }

        public ListDataSourcesResponse ListDataSourcesWithOptions(ListDataSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListDataSourcesResponse>(DoRPCRequest("ListDataSources", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListDataSourcesResponse> ListDataSourcesWithOptionsAsync(ListDataSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListDataSourcesResponse>(await DoRPCRequestAsync("ListDataSources", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataSourcesWithOptions(request, runtime);
        }

        public async Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataSourcesWithOptionsAsync(request, runtime);
        }

        public ListDIProjectConfigResponse ListDIProjectConfigWithOptions(ListDIProjectConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDIProjectConfigResponse>(DoRPCRequest("ListDIProjectConfig", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDIProjectConfigResponse> ListDIProjectConfigWithOptionsAsync(ListDIProjectConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDIProjectConfigResponse>(await DoRPCRequestAsync("ListDIProjectConfig", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDIProjectConfigResponse ListDIProjectConfig(ListDIProjectConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDIProjectConfigWithOptions(request, runtime);
        }

        public async Task<ListDIProjectConfigResponse> ListDIProjectConfigAsync(ListDIProjectConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDIProjectConfigWithOptionsAsync(request, runtime);
        }

        public ListDISyncTasksResponse ListDISyncTasksWithOptions(ListDISyncTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDISyncTasksResponse>(DoRPCRequest("ListDISyncTasks", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDISyncTasksResponse> ListDISyncTasksWithOptionsAsync(ListDISyncTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDISyncTasksResponse>(await DoRPCRequestAsync("ListDISyncTasks", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDISyncTasksResponse ListDISyncTasks(ListDISyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDISyncTasksWithOptions(request, runtime);
        }

        public async Task<ListDISyncTasksResponse> ListDISyncTasksAsync(ListDISyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDISyncTasksWithOptionsAsync(request, runtime);
        }

        public ListFilesResponse ListFilesWithOptions(ListFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFilesResponse>(DoRPCRequest("ListFiles", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFilesResponse> ListFilesWithOptionsAsync(ListFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFilesResponse>(await DoRPCRequestAsync("ListFiles", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFilesResponse ListFiles(ListFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFilesWithOptions(request, runtime);
        }

        public async Task<ListFilesResponse> ListFilesAsync(ListFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFilesWithOptionsAsync(request, runtime);
        }

        public ListFileTypeResponse ListFileTypeWithOptions(ListFileTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFileTypeResponse>(DoRPCRequest("ListFileType", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFileTypeResponse> ListFileTypeWithOptionsAsync(ListFileTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFileTypeResponse>(await DoRPCRequestAsync("ListFileType", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFileTypeResponse ListFileType(ListFileTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFileTypeWithOptions(request, runtime);
        }

        public async Task<ListFileTypeResponse> ListFileTypeAsync(ListFileTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFileTypeWithOptionsAsync(request, runtime);
        }

        public ListFileVersionsResponse ListFileVersionsWithOptions(ListFileVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFileVersionsResponse>(DoRPCRequest("ListFileVersions", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFileVersionsResponse> ListFileVersionsWithOptionsAsync(ListFileVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFileVersionsResponse>(await DoRPCRequestAsync("ListFileVersions", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFileVersionsResponse ListFileVersions(ListFileVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFileVersionsWithOptions(request, runtime);
        }

        public async Task<ListFileVersionsResponse> ListFileVersionsAsync(ListFileVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFileVersionsWithOptionsAsync(request, runtime);
        }

        public ListFoldersResponse ListFoldersWithOptions(ListFoldersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFoldersResponse>(DoRPCRequest("ListFolders", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFoldersResponse> ListFoldersWithOptionsAsync(ListFoldersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFoldersResponse>(await DoRPCRequestAsync("ListFolders", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFoldersResponse ListFolders(ListFoldersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFoldersWithOptions(request, runtime);
        }

        public async Task<ListFoldersResponse> ListFoldersAsync(ListFoldersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFoldersWithOptionsAsync(request, runtime);
        }

        public ListInstanceAmountResponse ListInstanceAmountWithOptions(ListInstanceAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInstanceAmountResponse>(DoRPCRequest("ListInstanceAmount", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListInstanceAmountResponse> ListInstanceAmountWithOptionsAsync(ListInstanceAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInstanceAmountResponse>(await DoRPCRequestAsync("ListInstanceAmount", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListInstanceAmountResponse ListInstanceAmount(ListInstanceAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstanceAmountWithOptions(request, runtime);
        }

        public async Task<ListInstanceAmountResponse> ListInstanceAmountAsync(ListInstanceAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstanceAmountWithOptionsAsync(request, runtime);
        }

        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInstancesResponse>(DoRPCRequest("ListInstances", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInstancesResponse>(await DoRPCRequestAsync("ListInstances", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancesWithOptions(request, runtime);
        }

        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesWithOptionsAsync(request, runtime);
        }

        public ListManualDagInstancesResponse ListManualDagInstancesWithOptions(ListManualDagInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListManualDagInstancesResponse>(DoRPCRequest("ListManualDagInstances", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListManualDagInstancesResponse> ListManualDagInstancesWithOptionsAsync(ListManualDagInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListManualDagInstancesResponse>(await DoRPCRequestAsync("ListManualDagInstances", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListManualDagInstancesResponse ListManualDagInstances(ListManualDagInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListManualDagInstancesWithOptions(request, runtime);
        }

        public async Task<ListManualDagInstancesResponse> ListManualDagInstancesAsync(ListManualDagInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListManualDagInstancesWithOptionsAsync(request, runtime);
        }

        public ListMetaDBResponse ListMetaDBWithOptions(ListMetaDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListMetaDBResponse>(DoRPCRequest("ListMetaDB", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListMetaDBResponse> ListMetaDBWithOptionsAsync(ListMetaDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListMetaDBResponse>(await DoRPCRequestAsync("ListMetaDB", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListMetaDBResponse ListMetaDB(ListMetaDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMetaDBWithOptions(request, runtime);
        }

        public async Task<ListMetaDBResponse> ListMetaDBAsync(ListMetaDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMetaDBWithOptionsAsync(request, runtime);
        }

        public ListNodeInputOrOutputResponse ListNodeInputOrOutputWithOptions(ListNodeInputOrOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNodeInputOrOutputResponse>(DoRPCRequest("ListNodeInputOrOutput", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListNodeInputOrOutputResponse> ListNodeInputOrOutputWithOptionsAsync(ListNodeInputOrOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNodeInputOrOutputResponse>(await DoRPCRequestAsync("ListNodeInputOrOutput", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListNodeInputOrOutputResponse ListNodeInputOrOutput(ListNodeInputOrOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodeInputOrOutputWithOptions(request, runtime);
        }

        public async Task<ListNodeInputOrOutputResponse> ListNodeInputOrOutputAsync(ListNodeInputOrOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodeInputOrOutputWithOptionsAsync(request, runtime);
        }

        public ListNodeIOResponse ListNodeIOWithOptions(ListNodeIORequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNodeIOResponse>(DoRPCRequest("ListNodeIO", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListNodeIOResponse> ListNodeIOWithOptionsAsync(ListNodeIORequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNodeIOResponse>(await DoRPCRequestAsync("ListNodeIO", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListNodeIOResponse ListNodeIO(ListNodeIORequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodeIOWithOptions(request, runtime);
        }

        public async Task<ListNodeIOResponse> ListNodeIOAsync(ListNodeIORequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodeIOWithOptionsAsync(request, runtime);
        }

        public ListNodesResponse ListNodesWithOptions(ListNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNodesResponse>(DoRPCRequest("ListNodes", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListNodesResponse> ListNodesWithOptionsAsync(ListNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNodesResponse>(await DoRPCRequestAsync("ListNodes", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListNodesResponse ListNodes(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodesWithOptions(request, runtime);
        }

        public async Task<ListNodesResponse> ListNodesAsync(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodesWithOptionsAsync(request, runtime);
        }

        public ListNodesByBaselineResponse ListNodesByBaselineWithOptions(ListNodesByBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNodesByBaselineResponse>(DoRPCRequest("ListNodesByBaseline", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListNodesByBaselineResponse> ListNodesByBaselineWithOptionsAsync(ListNodesByBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNodesByBaselineResponse>(await DoRPCRequestAsync("ListNodesByBaseline", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListNodesByBaselineResponse ListNodesByBaseline(ListNodesByBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodesByBaselineWithOptions(request, runtime);
        }

        public async Task<ListNodesByBaselineResponse> ListNodesByBaselineAsync(ListNodesByBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodesByBaselineWithOptionsAsync(request, runtime);
        }

        public ListNodesByOutputResponse ListNodesByOutputWithOptions(ListNodesByOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNodesByOutputResponse>(DoRPCRequest("ListNodesByOutput", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListNodesByOutputResponse> ListNodesByOutputWithOptionsAsync(ListNodesByOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNodesByOutputResponse>(await DoRPCRequestAsync("ListNodesByOutput", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListNodesByOutputResponse ListNodesByOutput(ListNodesByOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodesByOutputWithOptions(request, runtime);
        }

        public async Task<ListNodesByOutputResponse> ListNodesByOutputAsync(ListNodesByOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodesByOutputWithOptionsAsync(request, runtime);
        }

        public ListPermissionApplyOrdersResponse ListPermissionApplyOrdersWithOptions(ListPermissionApplyOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPermissionApplyOrdersResponse>(DoRPCRequest("ListPermissionApplyOrders", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPermissionApplyOrdersResponse> ListPermissionApplyOrdersWithOptionsAsync(ListPermissionApplyOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPermissionApplyOrdersResponse>(await DoRPCRequestAsync("ListPermissionApplyOrders", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPermissionApplyOrdersResponse ListPermissionApplyOrders(ListPermissionApplyOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPermissionApplyOrdersWithOptions(request, runtime);
        }

        public async Task<ListPermissionApplyOrdersResponse> ListPermissionApplyOrdersAsync(ListPermissionApplyOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPermissionApplyOrdersWithOptionsAsync(request, runtime);
        }

        public ListProgramTypeCountResponse ListProgramTypeCountWithOptions(ListProgramTypeCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProgramTypeCountResponse>(DoRPCRequest("ListProgramTypeCount", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListProgramTypeCountResponse> ListProgramTypeCountWithOptionsAsync(ListProgramTypeCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProgramTypeCountResponse>(await DoRPCRequestAsync("ListProgramTypeCount", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListProgramTypeCountResponse ListProgramTypeCount(ListProgramTypeCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProgramTypeCountWithOptions(request, runtime);
        }

        public async Task<ListProgramTypeCountResponse> ListProgramTypeCountAsync(ListProgramTypeCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProgramTypeCountWithOptionsAsync(request, runtime);
        }

        public ListProjectIdsResponse ListProjectIdsWithOptions(ListProjectIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectIdsResponse>(DoRPCRequest("ListProjectIds", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListProjectIdsResponse> ListProjectIdsWithOptionsAsync(ListProjectIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectIdsResponse>(await DoRPCRequestAsync("ListProjectIds", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListProjectIdsResponse ListProjectIds(ListProjectIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectIdsWithOptions(request, runtime);
        }

        public async Task<ListProjectIdsResponse> ListProjectIdsAsync(ListProjectIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectIdsWithOptionsAsync(request, runtime);
        }

        public ListProjectMembersResponse ListProjectMembersWithOptions(ListProjectMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectMembersResponse>(DoRPCRequest("ListProjectMembers", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListProjectMembersResponse> ListProjectMembersWithOptionsAsync(ListProjectMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectMembersResponse>(await DoRPCRequestAsync("ListProjectMembers", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListProjectMembersResponse ListProjectMembers(ListProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectMembersWithOptions(request, runtime);
        }

        public async Task<ListProjectMembersResponse> ListProjectMembersAsync(ListProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectMembersWithOptionsAsync(request, runtime);
        }

        public ListProjectRolesResponse ListProjectRolesWithOptions(ListProjectRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectRolesResponse>(DoRPCRequest("ListProjectRoles", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListProjectRolesResponse> ListProjectRolesWithOptionsAsync(ListProjectRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectRolesResponse>(await DoRPCRequestAsync("ListProjectRoles", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListProjectRolesResponse ListProjectRoles(ListProjectRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectRolesWithOptions(request, runtime);
        }

        public async Task<ListProjectRolesResponse> ListProjectRolesAsync(ListProjectRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectRolesWithOptionsAsync(request, runtime);
        }

        public ListProjectsResponse ListProjectsWithOptions(ListProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectsResponse>(DoRPCRequest("ListProjects", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListProjectsResponse> ListProjectsWithOptionsAsync(ListProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectsResponse>(await DoRPCRequestAsync("ListProjects", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectsWithOptions(request, runtime);
        }

        public async Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectsWithOptionsAsync(request, runtime);
        }

        public ListQualityResultsByEntityResponse ListQualityResultsByEntityWithOptions(ListQualityResultsByEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListQualityResultsByEntityResponse>(DoRPCRequest("ListQualityResultsByEntity", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListQualityResultsByEntityResponse> ListQualityResultsByEntityWithOptionsAsync(ListQualityResultsByEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListQualityResultsByEntityResponse>(await DoRPCRequestAsync("ListQualityResultsByEntity", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListQualityResultsByEntityResponse ListQualityResultsByEntity(ListQualityResultsByEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQualityResultsByEntityWithOptions(request, runtime);
        }

        public async Task<ListQualityResultsByEntityResponse> ListQualityResultsByEntityAsync(ListQualityResultsByEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQualityResultsByEntityWithOptionsAsync(request, runtime);
        }

        public ListQualityResultsByRuleResponse ListQualityResultsByRuleWithOptions(ListQualityResultsByRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListQualityResultsByRuleResponse>(DoRPCRequest("ListQualityResultsByRule", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListQualityResultsByRuleResponse> ListQualityResultsByRuleWithOptionsAsync(ListQualityResultsByRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListQualityResultsByRuleResponse>(await DoRPCRequestAsync("ListQualityResultsByRule", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListQualityResultsByRuleResponse ListQualityResultsByRule(ListQualityResultsByRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQualityResultsByRuleWithOptions(request, runtime);
        }

        public async Task<ListQualityResultsByRuleResponse> ListQualityResultsByRuleAsync(ListQualityResultsByRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQualityResultsByRuleWithOptionsAsync(request, runtime);
        }

        public ListQualityRulesResponse ListQualityRulesWithOptions(ListQualityRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListQualityRulesResponse>(DoRPCRequest("ListQualityRules", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListQualityRulesResponse> ListQualityRulesWithOptionsAsync(ListQualityRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListQualityRulesResponse>(await DoRPCRequestAsync("ListQualityRules", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListQualityRulesResponse ListQualityRules(ListQualityRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQualityRulesWithOptions(request, runtime);
        }

        public async Task<ListQualityRulesResponse> ListQualityRulesAsync(ListQualityRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQualityRulesWithOptionsAsync(request, runtime);
        }

        public ListRefDISyncTasksResponse ListRefDISyncTasksWithOptions(ListRefDISyncTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRefDISyncTasksResponse>(DoRPCRequest("ListRefDISyncTasks", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRefDISyncTasksResponse> ListRefDISyncTasksWithOptionsAsync(ListRefDISyncTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRefDISyncTasksResponse>(await DoRPCRequestAsync("ListRefDISyncTasks", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRefDISyncTasksResponse ListRefDISyncTasks(ListRefDISyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRefDISyncTasksWithOptions(request, runtime);
        }

        public async Task<ListRefDISyncTasksResponse> ListRefDISyncTasksAsync(ListRefDISyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRefDISyncTasksWithOptionsAsync(request, runtime);
        }

        public ListRemindsResponse ListRemindsWithOptions(ListRemindsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRemindsResponse>(DoRPCRequest("ListReminds", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRemindsResponse> ListRemindsWithOptionsAsync(ListRemindsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRemindsResponse>(await DoRPCRequestAsync("ListReminds", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRemindsResponse ListReminds(ListRemindsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRemindsWithOptions(request, runtime);
        }

        public async Task<ListRemindsResponse> ListRemindsAsync(ListRemindsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRemindsWithOptionsAsync(request, runtime);
        }

        public ListResourceGroupsResponse ListResourceGroupsWithOptions(ListResourceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListResourceGroupsResponse>(DoRPCRequest("ListResourceGroups", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListResourceGroupsResponse> ListResourceGroupsWithOptionsAsync(ListResourceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListResourceGroupsResponse>(await DoRPCRequestAsync("ListResourceGroups", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListResourceGroupsResponse ListResourceGroups(ListResourceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceGroupsWithOptions(request, runtime);
        }

        public async Task<ListResourceGroupsResponse> ListResourceGroupsAsync(ListResourceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceGroupsWithOptionsAsync(request, runtime);
        }

        public ListSuccessInstanceAmountResponse ListSuccessInstanceAmountWithOptions(ListSuccessInstanceAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSuccessInstanceAmountResponse>(DoRPCRequest("ListSuccessInstanceAmount", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSuccessInstanceAmountResponse> ListSuccessInstanceAmountWithOptionsAsync(ListSuccessInstanceAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSuccessInstanceAmountResponse>(await DoRPCRequestAsync("ListSuccessInstanceAmount", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSuccessInstanceAmountResponse ListSuccessInstanceAmount(ListSuccessInstanceAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSuccessInstanceAmountWithOptions(request, runtime);
        }

        public async Task<ListSuccessInstanceAmountResponse> ListSuccessInstanceAmountAsync(ListSuccessInstanceAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSuccessInstanceAmountWithOptionsAsync(request, runtime);
        }

        public ListTableLevelResponse ListTableLevelWithOptions(ListTableLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListTableLevelResponse>(DoRPCRequest("ListTableLevel", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListTableLevelResponse> ListTableLevelWithOptionsAsync(ListTableLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListTableLevelResponse>(await DoRPCRequestAsync("ListTableLevel", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListTableLevelResponse ListTableLevel(ListTableLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTableLevelWithOptions(request, runtime);
        }

        public async Task<ListTableLevelResponse> ListTableLevelAsync(ListTableLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTableLevelWithOptionsAsync(request, runtime);
        }

        public ListTableThemeResponse ListTableThemeWithOptions(ListTableThemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListTableThemeResponse>(DoRPCRequest("ListTableTheme", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListTableThemeResponse> ListTableThemeWithOptionsAsync(ListTableThemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListTableThemeResponse>(await DoRPCRequestAsync("ListTableTheme", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListTableThemeResponse ListTableTheme(ListTableThemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTableThemeWithOptions(request, runtime);
        }

        public async Task<ListTableThemeResponse> ListTableThemeAsync(ListTableThemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTableThemeWithOptionsAsync(request, runtime);
        }

        public ListTopicsResponse ListTopicsWithOptions(ListTopicsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTopicsResponse>(DoRPCRequest("ListTopics", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTopicsResponse> ListTopicsWithOptionsAsync(ListTopicsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTopicsResponse>(await DoRPCRequestAsync("ListTopics", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTopicsResponse ListTopics(ListTopicsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTopicsWithOptions(request, runtime);
        }

        public async Task<ListTopicsResponse> ListTopicsAsync(ListTopicsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTopicsWithOptionsAsync(request, runtime);
        }

        public PublishDataServiceApiResponse PublishDataServiceApiWithOptions(PublishDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishDataServiceApiResponse>(DoRPCRequest("PublishDataServiceApi", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PublishDataServiceApiResponse> PublishDataServiceApiWithOptionsAsync(PublishDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishDataServiceApiResponse>(await DoRPCRequestAsync("PublishDataServiceApi", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PublishDataServiceApiResponse PublishDataServiceApi(PublishDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishDataServiceApiWithOptions(request, runtime);
        }

        public async Task<PublishDataServiceApiResponse> PublishDataServiceApiAsync(PublishDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishDataServiceApiWithOptionsAsync(request, runtime);
        }

        public QueryDISyncTaskConfigProcessResultResponse QueryDISyncTaskConfigProcessResultWithOptions(QueryDISyncTaskConfigProcessResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDISyncTaskConfigProcessResultResponse>(DoRPCRequest("QueryDISyncTaskConfigProcessResult", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDISyncTaskConfigProcessResultResponse> QueryDISyncTaskConfigProcessResultWithOptionsAsync(QueryDISyncTaskConfigProcessResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDISyncTaskConfigProcessResultResponse>(await DoRPCRequestAsync("QueryDISyncTaskConfigProcessResult", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDISyncTaskConfigProcessResultResponse QueryDISyncTaskConfigProcessResult(QueryDISyncTaskConfigProcessResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDISyncTaskConfigProcessResultWithOptions(request, runtime);
        }

        public async Task<QueryDISyncTaskConfigProcessResultResponse> QueryDISyncTaskConfigProcessResultAsync(QueryDISyncTaskConfigProcessResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDISyncTaskConfigProcessResultWithOptionsAsync(request, runtime);
        }

        public QueryPublicModelEngineResponse QueryPublicModelEngineWithOptions(QueryPublicModelEngineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPublicModelEngineResponse>(DoRPCRequest("QueryPublicModelEngine", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryPublicModelEngineResponse> QueryPublicModelEngineWithOptionsAsync(QueryPublicModelEngineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPublicModelEngineResponse>(await DoRPCRequestAsync("QueryPublicModelEngine", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryPublicModelEngineResponse QueryPublicModelEngine(QueryPublicModelEngineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPublicModelEngineWithOptions(request, runtime);
        }

        public async Task<QueryPublicModelEngineResponse> QueryPublicModelEngineAsync(QueryPublicModelEngineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPublicModelEngineWithOptionsAsync(request, runtime);
        }

        public RemoveProjectMemberFromRoleResponse RemoveProjectMemberFromRoleWithOptions(RemoveProjectMemberFromRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveProjectMemberFromRoleResponse>(DoRPCRequest("RemoveProjectMemberFromRole", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveProjectMemberFromRoleResponse> RemoveProjectMemberFromRoleWithOptionsAsync(RemoveProjectMemberFromRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveProjectMemberFromRoleResponse>(await DoRPCRequestAsync("RemoveProjectMemberFromRole", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveProjectMemberFromRoleResponse RemoveProjectMemberFromRole(RemoveProjectMemberFromRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveProjectMemberFromRoleWithOptions(request, runtime);
        }

        public async Task<RemoveProjectMemberFromRoleResponse> RemoveProjectMemberFromRoleAsync(RemoveProjectMemberFromRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveProjectMemberFromRoleWithOptionsAsync(request, runtime);
        }

        public RestartInstanceResponse RestartInstanceWithOptions(RestartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartInstanceResponse>(DoRPCRequest("RestartInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestartInstanceResponse> RestartInstanceWithOptionsAsync(RestartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartInstanceResponse>(await DoRPCRequestAsync("RestartInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ResumeInstanceResponse ResumeInstanceWithOptions(ResumeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResumeInstanceResponse>(DoRPCRequest("ResumeInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResumeInstanceResponse> ResumeInstanceWithOptionsAsync(ResumeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResumeInstanceResponse>(await DoRPCRequestAsync("ResumeInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResumeInstanceResponse ResumeInstance(ResumeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeInstanceWithOptions(request, runtime);
        }

        public async Task<ResumeInstanceResponse> ResumeInstanceAsync(ResumeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeInstanceWithOptionsAsync(request, runtime);
        }

        public RevokeColumnPermissionResponse RevokeColumnPermissionWithOptions(RevokeColumnPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeColumnPermissionResponse>(DoRPCRequest("RevokeColumnPermission", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RevokeColumnPermissionResponse> RevokeColumnPermissionWithOptionsAsync(RevokeColumnPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeColumnPermissionResponse>(await DoRPCRequestAsync("RevokeColumnPermission", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RevokeColumnPermissionResponse RevokeColumnPermission(RevokeColumnPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeColumnPermissionWithOptions(request, runtime);
        }

        public async Task<RevokeColumnPermissionResponse> RevokeColumnPermissionAsync(RevokeColumnPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeColumnPermissionWithOptionsAsync(request, runtime);
        }

        public RevokeTablePermissionResponse RevokeTablePermissionWithOptions(RevokeTablePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeTablePermissionResponse>(DoRPCRequest("RevokeTablePermission", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RevokeTablePermissionResponse> RevokeTablePermissionWithOptionsAsync(RevokeTablePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeTablePermissionResponse>(await DoRPCRequestAsync("RevokeTablePermission", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RevokeTablePermissionResponse RevokeTablePermission(RevokeTablePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeTablePermissionWithOptions(request, runtime);
        }

        public async Task<RevokeTablePermissionResponse> RevokeTablePermissionAsync(RevokeTablePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeTablePermissionWithOptionsAsync(request, runtime);
        }

        public RunCycleDagNodesResponse RunCycleDagNodesWithOptions(RunCycleDagNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunCycleDagNodesResponse>(DoRPCRequest("RunCycleDagNodes", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RunCycleDagNodesResponse> RunCycleDagNodesWithOptionsAsync(RunCycleDagNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunCycleDagNodesResponse>(await DoRPCRequestAsync("RunCycleDagNodes", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RunCycleDagNodesResponse RunCycleDagNodes(RunCycleDagNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunCycleDagNodesWithOptions(request, runtime);
        }

        public async Task<RunCycleDagNodesResponse> RunCycleDagNodesAsync(RunCycleDagNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunCycleDagNodesWithOptionsAsync(request, runtime);
        }

        public RunManualDagNodesResponse RunManualDagNodesWithOptions(RunManualDagNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunManualDagNodesResponse>(DoRPCRequest("RunManualDagNodes", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RunManualDagNodesResponse> RunManualDagNodesWithOptionsAsync(RunManualDagNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunManualDagNodesResponse>(await DoRPCRequestAsync("RunManualDagNodes", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RunManualDagNodesResponse RunManualDagNodes(RunManualDagNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunManualDagNodesWithOptions(request, runtime);
        }

        public async Task<RunManualDagNodesResponse> RunManualDagNodesAsync(RunManualDagNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunManualDagNodesWithOptionsAsync(request, runtime);
        }

        public RunSmokeTestResponse RunSmokeTestWithOptions(RunSmokeTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunSmokeTestResponse>(DoRPCRequest("RunSmokeTest", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RunSmokeTestResponse> RunSmokeTestWithOptionsAsync(RunSmokeTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunSmokeTestResponse>(await DoRPCRequestAsync("RunSmokeTest", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RunSmokeTestResponse RunSmokeTest(RunSmokeTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunSmokeTestWithOptions(request, runtime);
        }

        public async Task<RunSmokeTestResponse> RunSmokeTestAsync(RunSmokeTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunSmokeTestWithOptionsAsync(request, runtime);
        }

        public RunTriggerNodeResponse RunTriggerNodeWithOptions(RunTriggerNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunTriggerNodeResponse>(DoRPCRequest("RunTriggerNode", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RunTriggerNodeResponse> RunTriggerNodeWithOptionsAsync(RunTriggerNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunTriggerNodeResponse>(await DoRPCRequestAsync("RunTriggerNode", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RunTriggerNodeResponse RunTriggerNode(RunTriggerNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunTriggerNodeWithOptions(request, runtime);
        }

        public async Task<RunTriggerNodeResponse> RunTriggerNodeAsync(RunTriggerNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunTriggerNodeWithOptionsAsync(request, runtime);
        }

        public ScanSensitiveDataResponse ScanSensitiveDataWithOptions(ScanSensitiveDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ScanSensitiveDataResponse>(DoRPCRequest("ScanSensitiveData", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ScanSensitiveDataResponse> ScanSensitiveDataWithOptionsAsync(ScanSensitiveDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ScanSensitiveDataResponse>(await DoRPCRequestAsync("ScanSensitiveData", "2020-05-18", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ScanSensitiveDataResponse ScanSensitiveData(ScanSensitiveDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ScanSensitiveDataWithOptions(request, runtime);
        }

        public async Task<ScanSensitiveDataResponse> ScanSensitiveDataAsync(ScanSensitiveDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ScanSensitiveDataWithOptionsAsync(request, runtime);
        }

        public SearchMetaTablesResponse SearchMetaTablesWithOptions(SearchMetaTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchMetaTablesResponse>(DoRPCRequest("SearchMetaTables", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchMetaTablesResponse> SearchMetaTablesWithOptionsAsync(SearchMetaTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchMetaTablesResponse>(await DoRPCRequestAsync("SearchMetaTables", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchMetaTablesResponse SearchMetaTables(SearchMetaTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchMetaTablesWithOptions(request, runtime);
        }

        public async Task<SearchMetaTablesResponse> SearchMetaTablesAsync(SearchMetaTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchMetaTablesWithOptionsAsync(request, runtime);
        }

        public SearchNodesByOutputResponse SearchNodesByOutputWithOptions(SearchNodesByOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchNodesByOutputResponse>(DoRPCRequest("SearchNodesByOutput", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchNodesByOutputResponse> SearchNodesByOutputWithOptionsAsync(SearchNodesByOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchNodesByOutputResponse>(await DoRPCRequestAsync("SearchNodesByOutput", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchNodesByOutputResponse SearchNodesByOutput(SearchNodesByOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchNodesByOutputWithOptions(request, runtime);
        }

        public async Task<SearchNodesByOutputResponse> SearchNodesByOutputAsync(SearchNodesByOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchNodesByOutputWithOptionsAsync(request, runtime);
        }

        public SetConnectionShareResponse SetConnectionShareWithOptions(SetConnectionShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetConnectionShareResponse>(DoRPCRequest("SetConnectionShare", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetConnectionShareResponse> SetConnectionShareWithOptionsAsync(SetConnectionShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetConnectionShareResponse>(await DoRPCRequestAsync("SetConnectionShare", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetConnectionShareResponse SetConnectionShare(SetConnectionShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetConnectionShareWithOptions(request, runtime);
        }

        public async Task<SetConnectionShareResponse> SetConnectionShareAsync(SetConnectionShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetConnectionShareWithOptionsAsync(request, runtime);
        }

        public SetDataSourceShareResponse SetDataSourceShareWithOptions(SetDataSourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDataSourceShareResponse>(DoRPCRequest("SetDataSourceShare", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDataSourceShareResponse> SetDataSourceShareWithOptionsAsync(SetDataSourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDataSourceShareResponse>(await DoRPCRequestAsync("SetDataSourceShare", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetDataSourceShareResponse SetDataSourceShare(SetDataSourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDataSourceShareWithOptions(request, runtime);
        }

        public async Task<SetDataSourceShareResponse> SetDataSourceShareAsync(SetDataSourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDataSourceShareWithOptionsAsync(request, runtime);
        }

        public SetSuccessInstanceResponse SetSuccessInstanceWithOptions(SetSuccessInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetSuccessInstanceResponse>(DoRPCRequest("SetSuccessInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetSuccessInstanceResponse> SetSuccessInstanceWithOptionsAsync(SetSuccessInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetSuccessInstanceResponse>(await DoRPCRequestAsync("SetSuccessInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetSuccessInstanceResponse SetSuccessInstance(SetSuccessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetSuccessInstanceWithOptions(request, runtime);
        }

        public async Task<SetSuccessInstanceResponse> SetSuccessInstanceAsync(SetSuccessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetSuccessInstanceWithOptionsAsync(request, runtime);
        }

        public StartDISyncInstanceResponse StartDISyncInstanceWithOptions(StartDISyncInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartDISyncInstanceResponse>(DoRPCRequest("StartDISyncInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartDISyncInstanceResponse> StartDISyncInstanceWithOptionsAsync(StartDISyncInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartDISyncInstanceResponse>(await DoRPCRequestAsync("StartDISyncInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartDISyncInstanceResponse StartDISyncInstance(StartDISyncInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDISyncInstanceWithOptions(request, runtime);
        }

        public async Task<StartDISyncInstanceResponse> StartDISyncInstanceAsync(StartDISyncInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDISyncInstanceWithOptionsAsync(request, runtime);
        }

        public StartMigrationResponse StartMigrationWithOptions(StartMigrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartMigrationResponse>(DoRPCRequest("StartMigration", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartMigrationResponse> StartMigrationWithOptionsAsync(StartMigrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartMigrationResponse>(await DoRPCRequestAsync("StartMigration", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartMigrationResponse StartMigration(StartMigrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartMigrationWithOptions(request, runtime);
        }

        public async Task<StartMigrationResponse> StartMigrationAsync(StartMigrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartMigrationWithOptionsAsync(request, runtime);
        }

        public StopDISyncInstanceResponse StopDISyncInstanceWithOptions(StopDISyncInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDISyncInstanceResponse>(DoRPCRequest("StopDISyncInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopDISyncInstanceResponse> StopDISyncInstanceWithOptionsAsync(StopDISyncInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDISyncInstanceResponse>(await DoRPCRequestAsync("StopDISyncInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopDISyncInstanceResponse StopDISyncInstance(StopDISyncInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDISyncInstanceWithOptions(request, runtime);
        }

        public async Task<StopDISyncInstanceResponse> StopDISyncInstanceAsync(StopDISyncInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDISyncInstanceWithOptionsAsync(request, runtime);
        }

        public StopInstanceResponse StopInstanceWithOptions(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopInstanceResponse>(DoRPCRequest("StopInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopInstanceResponse> StopInstanceWithOptionsAsync(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopInstanceResponse>(await DoRPCRequestAsync("StopInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopInstanceWithOptions(request, runtime);
        }

        public async Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopInstanceWithOptionsAsync(request, runtime);
        }

        public SubmitFileResponse SubmitFileWithOptions(SubmitFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitFileResponse>(DoRPCRequest("SubmitFile", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitFileResponse> SubmitFileWithOptionsAsync(SubmitFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitFileResponse>(await DoRPCRequestAsync("SubmitFile", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitFileResponse SubmitFile(SubmitFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitFileWithOptions(request, runtime);
        }

        public async Task<SubmitFileResponse> SubmitFileAsync(SubmitFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitFileWithOptionsAsync(request, runtime);
        }

        public SuspendInstanceResponse SuspendInstanceWithOptions(SuspendInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendInstanceResponse>(DoRPCRequest("SuspendInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SuspendInstanceResponse> SuspendInstanceWithOptionsAsync(SuspendInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendInstanceResponse>(await DoRPCRequestAsync("SuspendInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SuspendInstanceResponse SuspendInstance(SuspendInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendInstanceWithOptions(request, runtime);
        }

        public async Task<SuspendInstanceResponse> SuspendInstanceAsync(SuspendInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendInstanceWithOptionsAsync(request, runtime);
        }

        public TerminateDISyncInstanceResponse TerminateDISyncInstanceWithOptions(TerminateDISyncInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TerminateDISyncInstanceResponse>(DoRPCRequest("TerminateDISyncInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TerminateDISyncInstanceResponse> TerminateDISyncInstanceWithOptionsAsync(TerminateDISyncInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TerminateDISyncInstanceResponse>(await DoRPCRequestAsync("TerminateDISyncInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TerminateDISyncInstanceResponse TerminateDISyncInstance(TerminateDISyncInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TerminateDISyncInstanceWithOptions(request, runtime);
        }

        public async Task<TerminateDISyncInstanceResponse> TerminateDISyncInstanceAsync(TerminateDISyncInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TerminateDISyncInstanceWithOptionsAsync(request, runtime);
        }

        public TestNetworkConnectionResponse TestNetworkConnectionWithOptions(TestNetworkConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TestNetworkConnectionResponse>(DoRPCRequest("TestNetworkConnection", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TestNetworkConnectionResponse> TestNetworkConnectionWithOptionsAsync(TestNetworkConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TestNetworkConnectionResponse>(await DoRPCRequestAsync("TestNetworkConnection", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TestNetworkConnectionResponse TestNetworkConnection(TestNetworkConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TestNetworkConnectionWithOptions(request, runtime);
        }

        public async Task<TestNetworkConnectionResponse> TestNetworkConnectionAsync(TestNetworkConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TestNetworkConnectionWithOptionsAsync(request, runtime);
        }

        public TopTenElapsedTimeInstanceResponse TopTenElapsedTimeInstanceWithOptions(TopTenElapsedTimeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TopTenElapsedTimeInstanceResponse>(DoRPCRequest("TopTenElapsedTimeInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TopTenElapsedTimeInstanceResponse> TopTenElapsedTimeInstanceWithOptionsAsync(TopTenElapsedTimeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TopTenElapsedTimeInstanceResponse>(await DoRPCRequestAsync("TopTenElapsedTimeInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TopTenElapsedTimeInstanceResponse TopTenElapsedTimeInstance(TopTenElapsedTimeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TopTenElapsedTimeInstanceWithOptions(request, runtime);
        }

        public async Task<TopTenElapsedTimeInstanceResponse> TopTenElapsedTimeInstanceAsync(TopTenElapsedTimeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TopTenElapsedTimeInstanceWithOptionsAsync(request, runtime);
        }

        public TopTenErrorTimesInstanceResponse TopTenErrorTimesInstanceWithOptions(TopTenErrorTimesInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TopTenErrorTimesInstanceResponse>(DoRPCRequest("TopTenErrorTimesInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TopTenErrorTimesInstanceResponse> TopTenErrorTimesInstanceWithOptionsAsync(TopTenErrorTimesInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TopTenErrorTimesInstanceResponse>(await DoRPCRequestAsync("TopTenErrorTimesInstance", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TopTenErrorTimesInstanceResponse TopTenErrorTimesInstance(TopTenErrorTimesInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TopTenErrorTimesInstanceWithOptions(request, runtime);
        }

        public async Task<TopTenErrorTimesInstanceResponse> TopTenErrorTimesInstanceAsync(TopTenErrorTimesInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TopTenErrorTimesInstanceWithOptionsAsync(request, runtime);
        }

        public UpdateBusinessResponse UpdateBusinessWithOptions(UpdateBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateBusinessResponse>(DoRPCRequest("UpdateBusiness", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateBusinessResponse> UpdateBusinessWithOptionsAsync(UpdateBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateBusinessResponse>(await DoRPCRequestAsync("UpdateBusiness", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateBusinessResponse UpdateBusiness(UpdateBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBusinessWithOptions(request, runtime);
        }

        public async Task<UpdateBusinessResponse> UpdateBusinessAsync(UpdateBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBusinessWithOptionsAsync(request, runtime);
        }

        public UpdateConnectionResponse UpdateConnectionWithOptions(UpdateConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateConnectionResponse>(DoRPCRequest("UpdateConnection", "2020-05-18", "HTTPS", "PUT", "AK", "json", req, runtime));
        }

        public async Task<UpdateConnectionResponse> UpdateConnectionWithOptionsAsync(UpdateConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateConnectionResponse>(await DoRPCRequestAsync("UpdateConnection", "2020-05-18", "HTTPS", "PUT", "AK", "json", req, runtime));
        }

        public UpdateConnectionResponse UpdateConnection(UpdateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateConnectionWithOptions(request, runtime);
        }

        public async Task<UpdateConnectionResponse> UpdateConnectionAsync(UpdateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateConnectionWithOptionsAsync(request, runtime);
        }

        public UpdateDataServiceApiResponse UpdateDataServiceApiWithOptions(UpdateDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDataServiceApiResponse>(DoRPCRequest("UpdateDataServiceApi", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDataServiceApiResponse> UpdateDataServiceApiWithOptionsAsync(UpdateDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDataServiceApiResponse>(await DoRPCRequestAsync("UpdateDataServiceApi", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDataServiceApiResponse UpdateDataServiceApi(UpdateDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataServiceApiWithOptions(request, runtime);
        }

        public async Task<UpdateDataServiceApiResponse> UpdateDataServiceApiAsync(UpdateDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataServiceApiWithOptionsAsync(request, runtime);
        }

        public UpdateDataSourceResponse UpdateDataSourceWithOptions(UpdateDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDataSourceResponse>(DoRPCRequest("UpdateDataSource", "2020-05-18", "HTTPS", "PUT", "AK", "json", req, runtime));
        }

        public async Task<UpdateDataSourceResponse> UpdateDataSourceWithOptionsAsync(UpdateDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDataSourceResponse>(await DoRPCRequestAsync("UpdateDataSource", "2020-05-18", "HTTPS", "PUT", "AK", "json", req, runtime));
        }

        public UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataSourceWithOptions(request, runtime);
        }

        public async Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataSourceWithOptionsAsync(request, runtime);
        }

        public UpdateDIProjectConfigResponse UpdateDIProjectConfigWithOptions(UpdateDIProjectConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDIProjectConfigResponse>(DoRPCRequest("UpdateDIProjectConfig", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDIProjectConfigResponse> UpdateDIProjectConfigWithOptionsAsync(UpdateDIProjectConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDIProjectConfigResponse>(await DoRPCRequestAsync("UpdateDIProjectConfig", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDIProjectConfigResponse UpdateDIProjectConfig(UpdateDIProjectConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDIProjectConfigWithOptions(request, runtime);
        }

        public async Task<UpdateDIProjectConfigResponse> UpdateDIProjectConfigAsync(UpdateDIProjectConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDIProjectConfigWithOptionsAsync(request, runtime);
        }

        public UpdateDISyncTaskResponse UpdateDISyncTaskWithOptions(UpdateDISyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDISyncTaskResponse>(DoRPCRequest("UpdateDISyncTask", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDISyncTaskResponse> UpdateDISyncTaskWithOptionsAsync(UpdateDISyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDISyncTaskResponse>(await DoRPCRequestAsync("UpdateDISyncTask", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDISyncTaskResponse UpdateDISyncTask(UpdateDISyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDISyncTaskWithOptions(request, runtime);
        }

        public async Task<UpdateDISyncTaskResponse> UpdateDISyncTaskAsync(UpdateDISyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDISyncTaskWithOptionsAsync(request, runtime);
        }

        public UpdateFileResponse UpdateFileWithOptions(UpdateFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFileResponse>(DoRPCRequest("UpdateFile", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateFileResponse> UpdateFileWithOptionsAsync(UpdateFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFileResponse>(await DoRPCRequestAsync("UpdateFile", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateFileResponse UpdateFile(UpdateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFileWithOptions(request, runtime);
        }

        public async Task<UpdateFileResponse> UpdateFileAsync(UpdateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFileWithOptionsAsync(request, runtime);
        }

        public UpdateFolderResponse UpdateFolderWithOptions(UpdateFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFolderResponse>(DoRPCRequest("UpdateFolder", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateFolderResponse> UpdateFolderWithOptionsAsync(UpdateFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFolderResponse>(await DoRPCRequestAsync("UpdateFolder", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateFolderResponse UpdateFolder(UpdateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFolderWithOptions(request, runtime);
        }

        public async Task<UpdateFolderResponse> UpdateFolderAsync(UpdateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFolderWithOptionsAsync(request, runtime);
        }

        public UpdateMetaCategoryResponse UpdateMetaCategoryWithOptions(UpdateMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMetaCategoryResponse>(DoRPCRequest("UpdateMetaCategory", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMetaCategoryResponse> UpdateMetaCategoryWithOptionsAsync(UpdateMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMetaCategoryResponse>(await DoRPCRequestAsync("UpdateMetaCategory", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMetaCategoryResponse UpdateMetaCategory(UpdateMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMetaCategoryWithOptions(request, runtime);
        }

        public async Task<UpdateMetaCategoryResponse> UpdateMetaCategoryAsync(UpdateMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMetaCategoryWithOptionsAsync(request, runtime);
        }

        public UpdateMetaTableResponse UpdateMetaTableWithOptions(UpdateMetaTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMetaTableResponse>(DoRPCRequest("UpdateMetaTable", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMetaTableResponse> UpdateMetaTableWithOptionsAsync(UpdateMetaTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMetaTableResponse>(await DoRPCRequestAsync("UpdateMetaTable", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMetaTableResponse UpdateMetaTable(UpdateMetaTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMetaTableWithOptions(request, runtime);
        }

        public async Task<UpdateMetaTableResponse> UpdateMetaTableAsync(UpdateMetaTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMetaTableWithOptionsAsync(request, runtime);
        }

        public UpdateMetaTableIntroWikiResponse UpdateMetaTableIntroWikiWithOptions(UpdateMetaTableIntroWikiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMetaTableIntroWikiResponse>(DoRPCRequest("UpdateMetaTableIntroWiki", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMetaTableIntroWikiResponse> UpdateMetaTableIntroWikiWithOptionsAsync(UpdateMetaTableIntroWikiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMetaTableIntroWikiResponse>(await DoRPCRequestAsync("UpdateMetaTableIntroWiki", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMetaTableIntroWikiResponse UpdateMetaTableIntroWiki(UpdateMetaTableIntroWikiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMetaTableIntroWikiWithOptions(request, runtime);
        }

        public async Task<UpdateMetaTableIntroWikiResponse> UpdateMetaTableIntroWikiAsync(UpdateMetaTableIntroWikiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMetaTableIntroWikiWithOptionsAsync(request, runtime);
        }

        public UpdateNodeOwnerResponse UpdateNodeOwnerWithOptions(UpdateNodeOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateNodeOwnerResponse>(DoRPCRequest("UpdateNodeOwner", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateNodeOwnerResponse> UpdateNodeOwnerWithOptionsAsync(UpdateNodeOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateNodeOwnerResponse>(await DoRPCRequestAsync("UpdateNodeOwner", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateNodeOwnerResponse UpdateNodeOwner(UpdateNodeOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNodeOwnerWithOptions(request, runtime);
        }

        public async Task<UpdateNodeOwnerResponse> UpdateNodeOwnerAsync(UpdateNodeOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNodeOwnerWithOptionsAsync(request, runtime);
        }

        public UpdateNodeRunModeResponse UpdateNodeRunModeWithOptions(UpdateNodeRunModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateNodeRunModeResponse>(DoRPCRequest("UpdateNodeRunMode", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateNodeRunModeResponse> UpdateNodeRunModeWithOptionsAsync(UpdateNodeRunModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateNodeRunModeResponse>(await DoRPCRequestAsync("UpdateNodeRunMode", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateNodeRunModeResponse UpdateNodeRunMode(UpdateNodeRunModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNodeRunModeWithOptions(request, runtime);
        }

        public async Task<UpdateNodeRunModeResponse> UpdateNodeRunModeAsync(UpdateNodeRunModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNodeRunModeWithOptionsAsync(request, runtime);
        }

        public UpdateQualityFollowerResponse UpdateQualityFollowerWithOptions(UpdateQualityFollowerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateQualityFollowerResponse>(DoRPCRequest("UpdateQualityFollower", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateQualityFollowerResponse> UpdateQualityFollowerWithOptionsAsync(UpdateQualityFollowerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateQualityFollowerResponse>(await DoRPCRequestAsync("UpdateQualityFollower", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateQualityFollowerResponse UpdateQualityFollower(UpdateQualityFollowerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateQualityFollowerWithOptions(request, runtime);
        }

        public async Task<UpdateQualityFollowerResponse> UpdateQualityFollowerAsync(UpdateQualityFollowerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateQualityFollowerWithOptionsAsync(request, runtime);
        }

        public UpdateQualityRuleResponse UpdateQualityRuleWithOptions(UpdateQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateQualityRuleResponse>(DoRPCRequest("UpdateQualityRule", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateQualityRuleResponse> UpdateQualityRuleWithOptionsAsync(UpdateQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateQualityRuleResponse>(await DoRPCRequestAsync("UpdateQualityRule", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateQualityRuleResponse UpdateQualityRule(UpdateQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateQualityRuleWithOptions(request, runtime);
        }

        public async Task<UpdateQualityRuleResponse> UpdateQualityRuleAsync(UpdateQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateQualityRuleWithOptionsAsync(request, runtime);
        }

        public UpdateRemindResponse UpdateRemindWithOptions(UpdateRemindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRemindResponse>(DoRPCRequest("UpdateRemind", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateRemindResponse> UpdateRemindWithOptionsAsync(UpdateRemindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRemindResponse>(await DoRPCRequestAsync("UpdateRemind", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateRemindResponse UpdateRemind(UpdateRemindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRemindWithOptions(request, runtime);
        }

        public async Task<UpdateRemindResponse> UpdateRemindAsync(UpdateRemindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRemindWithOptionsAsync(request, runtime);
        }

        public UpdateTableResponse UpdateTableWithOptions(UpdateTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTableResponse>(DoRPCRequest("UpdateTable", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateTableResponse> UpdateTableWithOptionsAsync(UpdateTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTableResponse>(await DoRPCRequestAsync("UpdateTable", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateTableResponse UpdateTable(UpdateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTableWithOptions(request, runtime);
        }

        public async Task<UpdateTableResponse> UpdateTableAsync(UpdateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTableWithOptionsAsync(request, runtime);
        }

        public UpdateTableAddColumnResponse UpdateTableAddColumnWithOptions(UpdateTableAddColumnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTableAddColumnResponse>(DoRPCRequest("UpdateTableAddColumn", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateTableAddColumnResponse> UpdateTableAddColumnWithOptionsAsync(UpdateTableAddColumnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTableAddColumnResponse>(await DoRPCRequestAsync("UpdateTableAddColumn", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateTableAddColumnResponse UpdateTableAddColumn(UpdateTableAddColumnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTableAddColumnWithOptions(request, runtime);
        }

        public async Task<UpdateTableAddColumnResponse> UpdateTableAddColumnAsync(UpdateTableAddColumnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTableAddColumnWithOptionsAsync(request, runtime);
        }

        public UpdateTableLevelResponse UpdateTableLevelWithOptions(UpdateTableLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTableLevelResponse>(DoRPCRequest("UpdateTableLevel", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateTableLevelResponse> UpdateTableLevelWithOptionsAsync(UpdateTableLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTableLevelResponse>(await DoRPCRequestAsync("UpdateTableLevel", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateTableLevelResponse UpdateTableLevel(UpdateTableLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTableLevelWithOptions(request, runtime);
        }

        public async Task<UpdateTableLevelResponse> UpdateTableLevelAsync(UpdateTableLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTableLevelWithOptionsAsync(request, runtime);
        }

        public UpdateTableModelInfoResponse UpdateTableModelInfoWithOptions(UpdateTableModelInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTableModelInfoResponse>(DoRPCRequest("UpdateTableModelInfo", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateTableModelInfoResponse> UpdateTableModelInfoWithOptionsAsync(UpdateTableModelInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTableModelInfoResponse>(await DoRPCRequestAsync("UpdateTableModelInfo", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateTableModelInfoResponse UpdateTableModelInfo(UpdateTableModelInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTableModelInfoWithOptions(request, runtime);
        }

        public async Task<UpdateTableModelInfoResponse> UpdateTableModelInfoAsync(UpdateTableModelInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTableModelInfoWithOptionsAsync(request, runtime);
        }

        public UpdateTableThemeResponse UpdateTableThemeWithOptions(UpdateTableThemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTableThemeResponse>(DoRPCRequest("UpdateTableTheme", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateTableThemeResponse> UpdateTableThemeWithOptionsAsync(UpdateTableThemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTableThemeResponse>(await DoRPCRequestAsync("UpdateTableTheme", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateTableThemeResponse UpdateTableTheme(UpdateTableThemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTableThemeWithOptions(request, runtime);
        }

        public async Task<UpdateTableThemeResponse> UpdateTableThemeAsync(UpdateTableThemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTableThemeWithOptionsAsync(request, runtime);
        }

        public UpdateUdfFileResponse UpdateUdfFileWithOptions(UpdateUdfFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateUdfFileResponse>(DoRPCRequest("UpdateUdfFile", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateUdfFileResponse> UpdateUdfFileWithOptionsAsync(UpdateUdfFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateUdfFileResponse>(await DoRPCRequestAsync("UpdateUdfFile", "2020-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateUdfFileResponse UpdateUdfFile(UpdateUdfFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUdfFileWithOptions(request, runtime);
        }

        public async Task<UpdateUdfFileResponse> UpdateUdfFileAsync(UpdateUdfFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUdfFileWithOptionsAsync(request, runtime);
        }

    }
}
