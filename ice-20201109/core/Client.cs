// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ICE20201109.Models;

namespace AlibabaCloud.SDK.ICE20201109
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "ice.aliyuncs.com"},
                {"ap-northeast-2-pop", "ice.aliyuncs.com"},
                {"ap-south-1", "ice.aliyuncs.com"},
                {"ap-southeast-1", "ice.aliyuncs.com"},
                {"ap-southeast-2", "ice.aliyuncs.com"},
                {"ap-southeast-3", "ice.aliyuncs.com"},
                {"ap-southeast-5", "ice.aliyuncs.com"},
                {"cn-beijing", "ice.aliyuncs.com"},
                {"cn-beijing-finance-1", "ice.aliyuncs.com"},
                {"cn-beijing-finance-pop", "ice.aliyuncs.com"},
                {"cn-beijing-gov-1", "ice.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "ice.aliyuncs.com"},
                {"cn-chengdu", "ice.aliyuncs.com"},
                {"cn-edge-1", "ice.aliyuncs.com"},
                {"cn-fujian", "ice.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "ice.aliyuncs.com"},
                {"cn-hangzhou", "ice.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "ice.aliyuncs.com"},
                {"cn-hangzhou-finance", "ice.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "ice.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "ice.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "ice.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "ice.aliyuncs.com"},
                {"cn-hangzhou-test-306", "ice.aliyuncs.com"},
                {"cn-hongkong", "ice.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "ice.aliyuncs.com"},
                {"cn-huhehaote", "ice.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "ice.aliyuncs.com"},
                {"cn-north-2-gov-1", "ice.aliyuncs.com"},
                {"cn-qingdao", "ice.aliyuncs.com"},
                {"cn-qingdao-nebula", "ice.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "ice.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "ice.aliyuncs.com"},
                {"cn-shanghai-finance-1", "ice.aliyuncs.com"},
                {"cn-shanghai-inner", "ice.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "ice.aliyuncs.com"},
                {"cn-shenzhen", "ice.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "ice.aliyuncs.com"},
                {"cn-shenzhen-inner", "ice.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "ice.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "ice.aliyuncs.com"},
                {"cn-wuhan", "ice.aliyuncs.com"},
                {"cn-wulanchabu", "ice.aliyuncs.com"},
                {"cn-yushanfang", "ice.aliyuncs.com"},
                {"cn-zhangbei", "ice.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "ice.aliyuncs.com"},
                {"cn-zhangjiakou", "ice.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "ice.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "ice.aliyuncs.com"},
                {"eu-central-1", "ice.aliyuncs.com"},
                {"eu-west-1", "ice.aliyuncs.com"},
                {"eu-west-1-oxs", "ice.aliyuncs.com"},
                {"me-east-1", "ice.aliyuncs.com"},
                {"rus-west-1-pop", "ice.aliyuncs.com"},
                {"us-east-1", "ice.aliyuncs.com"},
                {"us-west-1", "ice.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("ice", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddEditingProjectMaterialsResponse AddEditingProjectMaterialsWithOptions(AddEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddEditingProjectMaterialsResponse>(DoRPCRequest("AddEditingProjectMaterials", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddEditingProjectMaterialsResponse> AddEditingProjectMaterialsWithOptionsAsync(AddEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddEditingProjectMaterialsResponse>(await DoRPCRequestAsync("AddEditingProjectMaterials", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddEditingProjectMaterialsResponse AddEditingProjectMaterials(AddEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddEditingProjectMaterialsWithOptions(request, runtime);
        }

        public async Task<AddEditingProjectMaterialsResponse> AddEditingProjectMaterialsAsync(AddEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddEditingProjectMaterialsWithOptionsAsync(request, runtime);
        }

        public AddTemplateResponse AddTemplateWithOptions(AddTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddTemplateResponse>(DoRPCRequest("AddTemplate", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddTemplateResponse> AddTemplateWithOptionsAsync(AddTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddTemplateResponse>(await DoRPCRequestAsync("AddTemplate", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddTemplateResponse AddTemplate(AddTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTemplateWithOptions(request, runtime);
        }

        public async Task<AddTemplateResponse> AddTemplateAsync(AddTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTemplateWithOptionsAsync(request, runtime);
        }

        public BatchGetMediaInfosResponse BatchGetMediaInfosWithOptions(BatchGetMediaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchGetMediaInfosResponse>(DoRPCRequest("BatchGetMediaInfos", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchGetMediaInfosResponse> BatchGetMediaInfosWithOptionsAsync(BatchGetMediaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchGetMediaInfosResponse>(await DoRPCRequestAsync("BatchGetMediaInfos", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchGetMediaInfosResponse BatchGetMediaInfos(BatchGetMediaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetMediaInfosWithOptions(request, runtime);
        }

        public async Task<BatchGetMediaInfosResponse> BatchGetMediaInfosAsync(BatchGetMediaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetMediaInfosWithOptionsAsync(request, runtime);
        }

        public CreateEditingProjectResponse CreateEditingProjectWithOptions(CreateEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEditingProjectResponse>(DoRPCRequest("CreateEditingProject", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateEditingProjectResponse> CreateEditingProjectWithOptionsAsync(CreateEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEditingProjectResponse>(await DoRPCRequestAsync("CreateEditingProject", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateEditingProjectResponse CreateEditingProject(CreateEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEditingProjectWithOptions(request, runtime);
        }

        public async Task<CreateEditingProjectResponse> CreateEditingProjectAsync(CreateEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEditingProjectWithOptionsAsync(request, runtime);
        }

        public DeleteEditingProjectMaterialsResponse DeleteEditingProjectMaterialsWithOptions(DeleteEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteEditingProjectMaterialsResponse>(DoRPCRequest("DeleteEditingProjectMaterials", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteEditingProjectMaterialsResponse> DeleteEditingProjectMaterialsWithOptionsAsync(DeleteEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteEditingProjectMaterialsResponse>(await DoRPCRequestAsync("DeleteEditingProjectMaterials", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DeleteEditingProjectMaterialsResponse DeleteEditingProjectMaterials(DeleteEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEditingProjectMaterialsWithOptions(request, runtime);
        }

        public async Task<DeleteEditingProjectMaterialsResponse> DeleteEditingProjectMaterialsAsync(DeleteEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEditingProjectMaterialsWithOptionsAsync(request, runtime);
        }

        public DeleteEditingProjectsResponse DeleteEditingProjectsWithOptions(DeleteEditingProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEditingProjectsResponse>(DoRPCRequest("DeleteEditingProjects", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteEditingProjectsResponse> DeleteEditingProjectsWithOptionsAsync(DeleteEditingProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEditingProjectsResponse>(await DoRPCRequestAsync("DeleteEditingProjects", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteEditingProjectsResponse DeleteEditingProjects(DeleteEditingProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEditingProjectsWithOptions(request, runtime);
        }

        public async Task<DeleteEditingProjectsResponse> DeleteEditingProjectsAsync(DeleteEditingProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEditingProjectsWithOptionsAsync(request, runtime);
        }

        public DeleteMediaInfosResponse DeleteMediaInfosWithOptions(DeleteMediaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMediaInfosResponse>(DoRPCRequest("DeleteMediaInfos", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMediaInfosResponse> DeleteMediaInfosWithOptionsAsync(DeleteMediaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMediaInfosResponse>(await DoRPCRequestAsync("DeleteMediaInfos", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMediaInfosResponse DeleteMediaInfos(DeleteMediaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMediaInfosWithOptions(request, runtime);
        }

        public async Task<DeleteMediaInfosResponse> DeleteMediaInfosAsync(DeleteMediaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMediaInfosWithOptionsAsync(request, runtime);
        }

        public DeleteSmartJobResponse DeleteSmartJobWithOptions(DeleteSmartJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSmartJobResponse>(DoRPCRequest("DeleteSmartJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSmartJobResponse> DeleteSmartJobWithOptionsAsync(DeleteSmartJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSmartJobResponse>(await DoRPCRequestAsync("DeleteSmartJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSmartJobResponse DeleteSmartJob(DeleteSmartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSmartJobWithOptions(request, runtime);
        }

        public async Task<DeleteSmartJobResponse> DeleteSmartJobAsync(DeleteSmartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSmartJobWithOptionsAsync(request, runtime);
        }

        public DeleteTemplateResponse DeleteTemplateWithOptions(DeleteTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(DoRPCRequest("DeleteTemplate", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteTemplateResponse> DeleteTemplateWithOptionsAsync(DeleteTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(await DoRPCRequestAsync("DeleteTemplate", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTemplateWithOptionsAsync(request, runtime);
        }

        public DescribeIceProductStatusResponse DescribeIceProductStatusWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeIceProductStatusResponse>(DoRPCRequest("DescribeIceProductStatus", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIceProductStatusResponse> DescribeIceProductStatusWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeIceProductStatusResponse>(await DoRPCRequestAsync("DescribeIceProductStatus", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIceProductStatusResponse DescribeIceProductStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIceProductStatusWithOptions(runtime);
        }

        public async Task<DescribeIceProductStatusResponse> DescribeIceProductStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIceProductStatusWithOptionsAsync(runtime);
        }

        public DescribeRelatedAuthorizationStatusResponse DescribeRelatedAuthorizationStatusWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeRelatedAuthorizationStatusResponse>(DoRPCRequest("DescribeRelatedAuthorizationStatus", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeRelatedAuthorizationStatusResponse> DescribeRelatedAuthorizationStatusWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeRelatedAuthorizationStatusResponse>(await DoRPCRequestAsync("DescribeRelatedAuthorizationStatus", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeRelatedAuthorizationStatusResponse DescribeRelatedAuthorizationStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRelatedAuthorizationStatusWithOptions(runtime);
        }

        public async Task<DescribeRelatedAuthorizationStatusResponse> DescribeRelatedAuthorizationStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRelatedAuthorizationStatusWithOptionsAsync(runtime);
        }

        public GetDefaultStorageLocationResponse GetDefaultStorageLocationWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetDefaultStorageLocationResponse>(DoRPCRequest("GetDefaultStorageLocation", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDefaultStorageLocationResponse> GetDefaultStorageLocationWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetDefaultStorageLocationResponse>(await DoRPCRequestAsync("GetDefaultStorageLocation", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDefaultStorageLocationResponse GetDefaultStorageLocation()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDefaultStorageLocationWithOptions(runtime);
        }

        public async Task<GetDefaultStorageLocationResponse> GetDefaultStorageLocationAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDefaultStorageLocationWithOptionsAsync(runtime);
        }

        public GetEditingProjectResponse GetEditingProjectWithOptions(GetEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetEditingProjectResponse>(DoRPCRequest("GetEditingProject", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetEditingProjectResponse> GetEditingProjectWithOptionsAsync(GetEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetEditingProjectResponse>(await DoRPCRequestAsync("GetEditingProject", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetEditingProjectResponse GetEditingProject(GetEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEditingProjectWithOptions(request, runtime);
        }

        public async Task<GetEditingProjectResponse> GetEditingProjectAsync(GetEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEditingProjectWithOptionsAsync(request, runtime);
        }

        public GetEditingProjectMaterialsResponse GetEditingProjectMaterialsWithOptions(GetEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetEditingProjectMaterialsResponse>(DoRPCRequest("GetEditingProjectMaterials", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetEditingProjectMaterialsResponse> GetEditingProjectMaterialsWithOptionsAsync(GetEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetEditingProjectMaterialsResponse>(await DoRPCRequestAsync("GetEditingProjectMaterials", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetEditingProjectMaterialsResponse GetEditingProjectMaterials(GetEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEditingProjectMaterialsWithOptions(request, runtime);
        }

        public async Task<GetEditingProjectMaterialsResponse> GetEditingProjectMaterialsAsync(GetEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEditingProjectMaterialsWithOptionsAsync(request, runtime);
        }

        public GetEventCallbackResponse GetEventCallbackWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetEventCallbackResponse>(DoRPCRequest("GetEventCallback", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetEventCallbackResponse> GetEventCallbackWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetEventCallbackResponse>(await DoRPCRequestAsync("GetEventCallback", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetEventCallbackResponse GetEventCallback()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEventCallbackWithOptions(runtime);
        }

        public async Task<GetEventCallbackResponse> GetEventCallbackAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEventCallbackWithOptionsAsync(runtime);
        }

        public GetLiveEditingIndexFileResponse GetLiveEditingIndexFileWithOptions(GetLiveEditingIndexFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetLiveEditingIndexFileResponse>(DoRPCRequest("GetLiveEditingIndexFile", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetLiveEditingIndexFileResponse> GetLiveEditingIndexFileWithOptionsAsync(GetLiveEditingIndexFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetLiveEditingIndexFileResponse>(await DoRPCRequestAsync("GetLiveEditingIndexFile", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetLiveEditingIndexFileResponse GetLiveEditingIndexFile(GetLiveEditingIndexFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLiveEditingIndexFileWithOptions(request, runtime);
        }

        public async Task<GetLiveEditingIndexFileResponse> GetLiveEditingIndexFileAsync(GetLiveEditingIndexFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLiveEditingIndexFileWithOptionsAsync(request, runtime);
        }

        public GetLiveEditingJobResponse GetLiveEditingJobWithOptions(GetLiveEditingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLiveEditingJobResponse>(DoRPCRequest("GetLiveEditingJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLiveEditingJobResponse> GetLiveEditingJobWithOptionsAsync(GetLiveEditingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLiveEditingJobResponse>(await DoRPCRequestAsync("GetLiveEditingJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLiveEditingJobResponse GetLiveEditingJob(GetLiveEditingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLiveEditingJobWithOptions(request, runtime);
        }

        public async Task<GetLiveEditingJobResponse> GetLiveEditingJobAsync(GetLiveEditingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLiveEditingJobWithOptionsAsync(request, runtime);
        }

        public GetMediaInfoResponse GetMediaInfoWithOptions(GetMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMediaInfoResponse>(DoRPCRequest("GetMediaInfo", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMediaInfoResponse> GetMediaInfoWithOptionsAsync(GetMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMediaInfoResponse>(await DoRPCRequestAsync("GetMediaInfo", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMediaInfoResponse GetMediaInfo(GetMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaInfoWithOptions(request, runtime);
        }

        public async Task<GetMediaInfoResponse> GetMediaInfoAsync(GetMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaInfoWithOptionsAsync(request, runtime);
        }

        public GetMediaProducingJobResponse GetMediaProducingJobWithOptions(GetMediaProducingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetMediaProducingJobResponse>(DoRPCRequest("GetMediaProducingJob", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetMediaProducingJobResponse> GetMediaProducingJobWithOptionsAsync(GetMediaProducingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetMediaProducingJobResponse>(await DoRPCRequestAsync("GetMediaProducingJob", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetMediaProducingJobResponse GetMediaProducingJob(GetMediaProducingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaProducingJobWithOptions(request, runtime);
        }

        public async Task<GetMediaProducingJobResponse> GetMediaProducingJobAsync(GetMediaProducingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaProducingJobWithOptionsAsync(request, runtime);
        }

        public GetSmartHandleJobResponse GetSmartHandleJobWithOptions(GetSmartHandleJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetSmartHandleJobResponse>(DoRPCRequest("GetSmartHandleJob", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetSmartHandleJobResponse> GetSmartHandleJobWithOptionsAsync(GetSmartHandleJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetSmartHandleJobResponse>(await DoRPCRequestAsync("GetSmartHandleJob", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetSmartHandleJobResponse GetSmartHandleJob(GetSmartHandleJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSmartHandleJobWithOptions(request, runtime);
        }

        public async Task<GetSmartHandleJobResponse> GetSmartHandleJobAsync(GetSmartHandleJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSmartHandleJobWithOptionsAsync(request, runtime);
        }

        public GetTemplateResponse GetTemplateWithOptions(GetTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetTemplateResponse>(DoRPCRequest("GetTemplate", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetTemplateResponse> GetTemplateWithOptionsAsync(GetTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetTemplateResponse>(await DoRPCRequestAsync("GetTemplate", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateWithOptions(request, runtime);
        }

        public async Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateWithOptionsAsync(request, runtime);
        }

        public ListAllPublicMediaTagsResponse ListAllPublicMediaTagsWithOptions(ListAllPublicMediaTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAllPublicMediaTagsResponse>(DoRPCRequest("ListAllPublicMediaTags", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAllPublicMediaTagsResponse> ListAllPublicMediaTagsWithOptionsAsync(ListAllPublicMediaTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAllPublicMediaTagsResponse>(await DoRPCRequestAsync("ListAllPublicMediaTags", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAllPublicMediaTagsResponse ListAllPublicMediaTags(ListAllPublicMediaTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAllPublicMediaTagsWithOptions(request, runtime);
        }

        public async Task<ListAllPublicMediaTagsResponse> ListAllPublicMediaTagsAsync(ListAllPublicMediaTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAllPublicMediaTagsWithOptionsAsync(request, runtime);
        }

        public ListMediaBasicInfosResponse ListMediaBasicInfosWithOptions(ListMediaBasicInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMediaBasicInfosResponse>(DoRPCRequest("ListMediaBasicInfos", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListMediaBasicInfosResponse> ListMediaBasicInfosWithOptionsAsync(ListMediaBasicInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMediaBasicInfosResponse>(await DoRPCRequestAsync("ListMediaBasicInfos", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListMediaBasicInfosResponse ListMediaBasicInfos(ListMediaBasicInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMediaBasicInfosWithOptions(request, runtime);
        }

        public async Task<ListMediaBasicInfosResponse> ListMediaBasicInfosAsync(ListMediaBasicInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMediaBasicInfosWithOptionsAsync(request, runtime);
        }

        public ListMediaProducingJobsResponse ListMediaProducingJobsWithOptions(ListMediaProducingJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMediaProducingJobsResponse>(DoRPCRequest("ListMediaProducingJobs", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListMediaProducingJobsResponse> ListMediaProducingJobsWithOptionsAsync(ListMediaProducingJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMediaProducingJobsResponse>(await DoRPCRequestAsync("ListMediaProducingJobs", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListMediaProducingJobsResponse ListMediaProducingJobs(ListMediaProducingJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMediaProducingJobsWithOptions(request, runtime);
        }

        public async Task<ListMediaProducingJobsResponse> ListMediaProducingJobsAsync(ListMediaProducingJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMediaProducingJobsWithOptionsAsync(request, runtime);
        }

        public ListPublicMediaBasicInfosResponse ListPublicMediaBasicInfosWithOptions(ListPublicMediaBasicInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPublicMediaBasicInfosResponse>(DoRPCRequest("ListPublicMediaBasicInfos", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPublicMediaBasicInfosResponse> ListPublicMediaBasicInfosWithOptionsAsync(ListPublicMediaBasicInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPublicMediaBasicInfosResponse>(await DoRPCRequestAsync("ListPublicMediaBasicInfos", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPublicMediaBasicInfosResponse ListPublicMediaBasicInfos(ListPublicMediaBasicInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPublicMediaBasicInfosWithOptions(request, runtime);
        }

        public async Task<ListPublicMediaBasicInfosResponse> ListPublicMediaBasicInfosAsync(ListPublicMediaBasicInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPublicMediaBasicInfosWithOptionsAsync(request, runtime);
        }

        public ListSmartJobsResponse ListSmartJobsWithOptions(ListSmartJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListSmartJobsResponse>(DoRPCRequest("ListSmartJobs", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListSmartJobsResponse> ListSmartJobsWithOptionsAsync(ListSmartJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListSmartJobsResponse>(await DoRPCRequestAsync("ListSmartJobs", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListSmartJobsResponse ListSmartJobs(ListSmartJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSmartJobsWithOptions(request, runtime);
        }

        public async Task<ListSmartJobsResponse> ListSmartJobsAsync(ListSmartJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSmartJobsWithOptionsAsync(request, runtime);
        }

        public ListSysTemplatesResponse ListSysTemplatesWithOptions(ListSysTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListSysTemplatesResponse>(DoRPCRequest("ListSysTemplates", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListSysTemplatesResponse> ListSysTemplatesWithOptionsAsync(ListSysTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListSysTemplatesResponse>(await DoRPCRequestAsync("ListSysTemplates", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListSysTemplatesResponse ListSysTemplates(ListSysTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSysTemplatesWithOptions(request, runtime);
        }

        public async Task<ListSysTemplatesResponse> ListSysTemplatesAsync(ListSysTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSysTemplatesWithOptionsAsync(request, runtime);
        }

        public ListTemplatesResponse ListTemplatesWithOptions(ListTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTemplatesResponse>(DoRPCRequest("ListTemplates", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTemplatesResponse> ListTemplatesWithOptionsAsync(ListTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTemplatesResponse>(await DoRPCRequestAsync("ListTemplates", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTemplatesWithOptions(request, runtime);
        }

        public async Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTemplatesWithOptionsAsync(request, runtime);
        }

        public RegisterMediaInfoResponse RegisterMediaInfoWithOptions(RegisterMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterMediaInfoResponse>(DoRPCRequest("RegisterMediaInfo", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RegisterMediaInfoResponse> RegisterMediaInfoWithOptionsAsync(RegisterMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterMediaInfoResponse>(await DoRPCRequestAsync("RegisterMediaInfo", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RegisterMediaInfoResponse RegisterMediaInfo(RegisterMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterMediaInfoWithOptions(request, runtime);
        }

        public async Task<RegisterMediaInfoResponse> RegisterMediaInfoAsync(RegisterMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterMediaInfoWithOptionsAsync(request, runtime);
        }

        public SearchEditingProjectResponse SearchEditingProjectWithOptions(SearchEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchEditingProjectResponse>(DoRPCRequest("SearchEditingProject", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchEditingProjectResponse> SearchEditingProjectWithOptionsAsync(SearchEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchEditingProjectResponse>(await DoRPCRequestAsync("SearchEditingProject", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchEditingProjectResponse SearchEditingProject(SearchEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchEditingProjectWithOptions(request, runtime);
        }

        public async Task<SearchEditingProjectResponse> SearchEditingProjectAsync(SearchEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchEditingProjectWithOptionsAsync(request, runtime);
        }

        public SetDefaultStorageLocationResponse SetDefaultStorageLocationWithOptions(SetDefaultStorageLocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDefaultStorageLocationResponse>(DoRPCRequest("SetDefaultStorageLocation", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDefaultStorageLocationResponse> SetDefaultStorageLocationWithOptionsAsync(SetDefaultStorageLocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDefaultStorageLocationResponse>(await DoRPCRequestAsync("SetDefaultStorageLocation", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetDefaultStorageLocationResponse SetDefaultStorageLocation(SetDefaultStorageLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDefaultStorageLocationWithOptions(request, runtime);
        }

        public async Task<SetDefaultStorageLocationResponse> SetDefaultStorageLocationAsync(SetDefaultStorageLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDefaultStorageLocationWithOptionsAsync(request, runtime);
        }

        public SetEventCallbackResponse SetEventCallbackWithOptions(SetEventCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetEventCallbackResponse>(DoRPCRequest("SetEventCallback", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetEventCallbackResponse> SetEventCallbackWithOptionsAsync(SetEventCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetEventCallbackResponse>(await DoRPCRequestAsync("SetEventCallback", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetEventCallbackResponse SetEventCallback(SetEventCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetEventCallbackWithOptions(request, runtime);
        }

        public async Task<SetEventCallbackResponse> SetEventCallbackAsync(SetEventCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetEventCallbackWithOptionsAsync(request, runtime);
        }

        public SubmitASRJobResponse SubmitASRJobWithOptions(SubmitASRJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitASRJobResponse>(DoRPCRequest("SubmitASRJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitASRJobResponse> SubmitASRJobWithOptionsAsync(SubmitASRJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitASRJobResponse>(await DoRPCRequestAsync("SubmitASRJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitASRJobResponse SubmitASRJob(SubmitASRJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitASRJobWithOptions(request, runtime);
        }

        public async Task<SubmitASRJobResponse> SubmitASRJobAsync(SubmitASRJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitASRJobWithOptionsAsync(request, runtime);
        }

        public SubmitAudioProduceJobResponse SubmitAudioProduceJobWithOptions(SubmitAudioProduceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitAudioProduceJobResponse>(DoRPCRequest("SubmitAudioProduceJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitAudioProduceJobResponse> SubmitAudioProduceJobWithOptionsAsync(SubmitAudioProduceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitAudioProduceJobResponse>(await DoRPCRequestAsync("SubmitAudioProduceJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitAudioProduceJobResponse SubmitAudioProduceJob(SubmitAudioProduceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitAudioProduceJobWithOptions(request, runtime);
        }

        public async Task<SubmitAudioProduceJobResponse> SubmitAudioProduceJobAsync(SubmitAudioProduceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitAudioProduceJobWithOptionsAsync(request, runtime);
        }

        public SubmitDelogoJobResponse SubmitDelogoJobWithOptions(SubmitDelogoJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitDelogoJobResponse>(DoRPCRequest("SubmitDelogoJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitDelogoJobResponse> SubmitDelogoJobWithOptionsAsync(SubmitDelogoJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitDelogoJobResponse>(await DoRPCRequestAsync("SubmitDelogoJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitDelogoJobResponse SubmitDelogoJob(SubmitDelogoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDelogoJobWithOptions(request, runtime);
        }

        public async Task<SubmitDelogoJobResponse> SubmitDelogoJobAsync(SubmitDelogoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitDelogoJobWithOptionsAsync(request, runtime);
        }

        public SubmitH2VJobResponse SubmitH2VJobWithOptions(SubmitH2VJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitH2VJobResponse>(DoRPCRequest("SubmitH2VJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitH2VJobResponse> SubmitH2VJobWithOptionsAsync(SubmitH2VJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitH2VJobResponse>(await DoRPCRequestAsync("SubmitH2VJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitH2VJobResponse SubmitH2VJob(SubmitH2VJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitH2VJobWithOptions(request, runtime);
        }

        public async Task<SubmitH2VJobResponse> SubmitH2VJobAsync(SubmitH2VJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitH2VJobWithOptionsAsync(request, runtime);
        }

        public SubmitKeyWordCutJobResponse SubmitKeyWordCutJobWithOptions(SubmitKeyWordCutJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SubmitKeyWordCutJobResponse>(DoRPCRequest("SubmitKeyWordCutJob", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<SubmitKeyWordCutJobResponse> SubmitKeyWordCutJobWithOptionsAsync(SubmitKeyWordCutJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SubmitKeyWordCutJobResponse>(await DoRPCRequestAsync("SubmitKeyWordCutJob", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public SubmitKeyWordCutJobResponse SubmitKeyWordCutJob(SubmitKeyWordCutJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitKeyWordCutJobWithOptions(request, runtime);
        }

        public async Task<SubmitKeyWordCutJobResponse> SubmitKeyWordCutJobAsync(SubmitKeyWordCutJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitKeyWordCutJobWithOptionsAsync(request, runtime);
        }

        public SubmitLiveEditingJobResponse SubmitLiveEditingJobWithOptions(SubmitLiveEditingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitLiveEditingJobResponse>(DoRPCRequest("SubmitLiveEditingJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitLiveEditingJobResponse> SubmitLiveEditingJobWithOptionsAsync(SubmitLiveEditingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitLiveEditingJobResponse>(await DoRPCRequestAsync("SubmitLiveEditingJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitLiveEditingJobResponse SubmitLiveEditingJob(SubmitLiveEditingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitLiveEditingJobWithOptions(request, runtime);
        }

        public async Task<SubmitLiveEditingJobResponse> SubmitLiveEditingJobAsync(SubmitLiveEditingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitLiveEditingJobWithOptionsAsync(request, runtime);
        }

        public SubmitMattingJobResponse SubmitMattingJobWithOptions(SubmitMattingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitMattingJobResponse>(DoRPCRequest("SubmitMattingJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitMattingJobResponse> SubmitMattingJobWithOptionsAsync(SubmitMattingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitMattingJobResponse>(await DoRPCRequestAsync("SubmitMattingJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitMattingJobResponse SubmitMattingJob(SubmitMattingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitMattingJobWithOptions(request, runtime);
        }

        public async Task<SubmitMattingJobResponse> SubmitMattingJobAsync(SubmitMattingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitMattingJobWithOptionsAsync(request, runtime);
        }

        public SubmitMediaProducingJobResponse SubmitMediaProducingJobWithOptions(SubmitMediaProducingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitMediaProducingJobResponse>(DoRPCRequest("SubmitMediaProducingJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitMediaProducingJobResponse> SubmitMediaProducingJobWithOptionsAsync(SubmitMediaProducingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitMediaProducingJobResponse>(await DoRPCRequestAsync("SubmitMediaProducingJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitMediaProducingJobResponse SubmitMediaProducingJob(SubmitMediaProducingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitMediaProducingJobWithOptions(request, runtime);
        }

        public async Task<SubmitMediaProducingJobResponse> SubmitMediaProducingJobAsync(SubmitMediaProducingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitMediaProducingJobWithOptionsAsync(request, runtime);
        }

        public SubmitPPTCutJobResponse SubmitPPTCutJobWithOptions(SubmitPPTCutJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SubmitPPTCutJobResponse>(DoRPCRequest("SubmitPPTCutJob", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<SubmitPPTCutJobResponse> SubmitPPTCutJobWithOptionsAsync(SubmitPPTCutJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SubmitPPTCutJobResponse>(await DoRPCRequestAsync("SubmitPPTCutJob", "2020-11-09", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public SubmitPPTCutJobResponse SubmitPPTCutJob(SubmitPPTCutJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitPPTCutJobWithOptions(request, runtime);
        }

        public async Task<SubmitPPTCutJobResponse> SubmitPPTCutJobAsync(SubmitPPTCutJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitPPTCutJobWithOptionsAsync(request, runtime);
        }

        public SubmitSubtitleProduceJobResponse SubmitSubtitleProduceJobWithOptions(SubmitSubtitleProduceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitSubtitleProduceJobResponse>(DoRPCRequest("SubmitSubtitleProduceJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitSubtitleProduceJobResponse> SubmitSubtitleProduceJobWithOptionsAsync(SubmitSubtitleProduceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitSubtitleProduceJobResponse>(await DoRPCRequestAsync("SubmitSubtitleProduceJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitSubtitleProduceJobResponse SubmitSubtitleProduceJob(SubmitSubtitleProduceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSubtitleProduceJobWithOptions(request, runtime);
        }

        public async Task<SubmitSubtitleProduceJobResponse> SubmitSubtitleProduceJobAsync(SubmitSubtitleProduceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSubtitleProduceJobWithOptionsAsync(request, runtime);
        }

        public UpdateEditingProjectResponse UpdateEditingProjectWithOptions(UpdateEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateEditingProjectResponse>(DoRPCRequest("UpdateEditingProject", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateEditingProjectResponse> UpdateEditingProjectWithOptionsAsync(UpdateEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateEditingProjectResponse>(await DoRPCRequestAsync("UpdateEditingProject", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateEditingProjectResponse UpdateEditingProject(UpdateEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEditingProjectWithOptions(request, runtime);
        }

        public async Task<UpdateEditingProjectResponse> UpdateEditingProjectAsync(UpdateEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEditingProjectWithOptionsAsync(request, runtime);
        }

        public UpdateMediaInfoResponse UpdateMediaInfoWithOptions(UpdateMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMediaInfoResponse>(DoRPCRequest("UpdateMediaInfo", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMediaInfoResponse> UpdateMediaInfoWithOptionsAsync(UpdateMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMediaInfoResponse>(await DoRPCRequestAsync("UpdateMediaInfo", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMediaInfoResponse UpdateMediaInfo(UpdateMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMediaInfoWithOptions(request, runtime);
        }

        public async Task<UpdateMediaInfoResponse> UpdateMediaInfoAsync(UpdateMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMediaInfoWithOptionsAsync(request, runtime);
        }

        public UpdateSmartJobResponse UpdateSmartJobWithOptions(UpdateSmartJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSmartJobResponse>(DoRPCRequest("UpdateSmartJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateSmartJobResponse> UpdateSmartJobWithOptionsAsync(UpdateSmartJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSmartJobResponse>(await DoRPCRequestAsync("UpdateSmartJob", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateSmartJobResponse UpdateSmartJob(UpdateSmartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSmartJobWithOptions(request, runtime);
        }

        public async Task<UpdateSmartJobResponse> UpdateSmartJobAsync(UpdateSmartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSmartJobWithOptionsAsync(request, runtime);
        }

        public UpdateTemplateResponse UpdateTemplateWithOptions(UpdateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(DoRPCRequest("UpdateTemplate", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateTemplateResponse> UpdateTemplateWithOptionsAsync(UpdateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(await DoRPCRequestAsync("UpdateTemplate", "2020-11-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTemplateWithOptions(request, runtime);
        }

        public async Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTemplateWithOptionsAsync(request, runtime);
        }

    }
}
