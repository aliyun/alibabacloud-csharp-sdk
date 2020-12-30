// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Iqa20190813.Models;

namespace AlibabaCloud.SDK.Iqa20190813
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("iqa", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectResponse>(DoRPCRequest("CreateProject", "2019-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectResponse>(await DoRPCRequestAsync("CreateProject", "2019-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProjectWithOptions(request, runtime);
        }

        public async Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProjectWithOptionsAsync(request, runtime);
        }

        public DeleteProjectResponse DeleteProjectWithOptions(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProjectResponse>(DoRPCRequest("DeleteProject", "2019-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteProjectResponse> DeleteProjectWithOptionsAsync(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProjectResponse>(await DoRPCRequestAsync("DeleteProject", "2019-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProjectWithOptions(request, runtime);
        }

        public async Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProjectWithOptionsAsync(request, runtime);
        }

        public DeployServiceResponse DeployServiceWithOptions(DeployServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeployServiceResponse>(DoRPCRequest("DeployService", "2019-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeployServiceResponse> DeployServiceWithOptionsAsync(DeployServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeployServiceResponse>(await DoRPCRequestAsync("DeployService", "2019-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeployServiceResponse DeployService(DeployServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeployServiceWithOptions(request, runtime);
        }

        public async Task<DeployServiceResponse> DeployServiceAsync(DeployServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeployServiceWithOptionsAsync(request, runtime);
        }

        public DescribeProjectResponse DescribeProjectWithOptions(DescribeProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProjectResponse>(DoRPCRequest("DescribeProject", "2019-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeProjectResponse> DescribeProjectWithOptionsAsync(DescribeProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProjectResponse>(await DoRPCRequestAsync("DescribeProject", "2019-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeProjectResponse DescribeProject(DescribeProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProjectWithOptions(request, runtime);
        }

        public async Task<DescribeProjectResponse> DescribeProjectAsync(DescribeProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProjectWithOptionsAsync(request, runtime);
        }

        public GetPredictResultResponse GetPredictResultWithOptions(GetPredictResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPredictResultResponse>(DoRPCRequest("GetPredictResult", "2019-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPredictResultResponse> GetPredictResultWithOptionsAsync(GetPredictResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPredictResultResponse>(await DoRPCRequestAsync("GetPredictResult", "2019-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPredictResultResponse GetPredictResult(GetPredictResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPredictResultWithOptions(request, runtime);
        }

        public async Task<GetPredictResultResponse> GetPredictResultAsync(GetPredictResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPredictResultWithOptionsAsync(request, runtime);
        }

        public ListProjectsResponse ListProjectsWithOptions(ListProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectsResponse>(DoRPCRequest("ListProjects", "2019-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListProjectsResponse> ListProjectsWithOptionsAsync(ListProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectsResponse>(await DoRPCRequestAsync("ListProjects", "2019-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifiyProjectResponse ModifiyProjectWithOptions(ModifiyProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifiyProjectResponse>(DoRPCRequest("ModifiyProject", "2019-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifiyProjectResponse> ModifiyProjectWithOptionsAsync(ModifiyProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifiyProjectResponse>(await DoRPCRequestAsync("ModifiyProject", "2019-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifiyProjectResponse ModifiyProject(ModifiyProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifiyProjectWithOptions(request, runtime);
        }

        public async Task<ModifiyProjectResponse> ModifiyProjectAsync(ModifiyProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifiyProjectWithOptionsAsync(request, runtime);
        }

        public UploadDictionaryResponse UploadDictionaryWithOptions(UploadDictionaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadDictionaryResponse>(DoRPCRequest("UploadDictionary", "2019-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UploadDictionaryResponse> UploadDictionaryWithOptionsAsync(UploadDictionaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadDictionaryResponse>(await DoRPCRequestAsync("UploadDictionary", "2019-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UploadDictionaryResponse UploadDictionary(UploadDictionaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadDictionaryWithOptions(request, runtime);
        }

        public async Task<UploadDictionaryResponse> UploadDictionaryAsync(UploadDictionaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadDictionaryWithOptionsAsync(request, runtime);
        }

        public UploadDocumentResponse UploadDocumentWithOptions(UploadDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadDocumentResponse>(DoRPCRequest("UploadDocument", "2019-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UploadDocumentResponse> UploadDocumentWithOptionsAsync(UploadDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadDocumentResponse>(await DoRPCRequestAsync("UploadDocument", "2019-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UploadDocumentResponse UploadDocument(UploadDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadDocumentWithOptions(request, runtime);
        }

        public async Task<UploadDocumentResponse> UploadDocumentAsync(UploadDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadDocumentWithOptionsAsync(request, runtime);
        }

    }
}
