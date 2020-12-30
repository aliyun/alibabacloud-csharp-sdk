// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Multimediaai20190810.Models;

namespace AlibabaCloud.SDK.Multimediaai20190810
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("multimediaai", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateCoverTaskResponse CreateCoverTaskWithOptions(CreateCoverTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCoverTaskResponse>(DoRPCRequest("CreateCoverTask", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCoverTaskResponse> CreateCoverTaskWithOptionsAsync(CreateCoverTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCoverTaskResponse>(await DoRPCRequestAsync("CreateCoverTask", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCoverTaskResponse CreateCoverTask(CreateCoverTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCoverTaskWithOptions(request, runtime);
        }

        public async Task<CreateCoverTaskResponse> CreateCoverTaskAsync(CreateCoverTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCoverTaskWithOptionsAsync(request, runtime);
        }

        public CreateFaceGroupResponse CreateFaceGroupWithOptions(CreateFaceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFaceGroupResponse>(DoRPCRequest("CreateFaceGroup", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFaceGroupResponse> CreateFaceGroupWithOptionsAsync(CreateFaceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFaceGroupResponse>(await DoRPCRequestAsync("CreateFaceGroup", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFaceGroupResponse CreateFaceGroup(CreateFaceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFaceGroupWithOptions(request, runtime);
        }

        public async Task<CreateFaceGroupResponse> CreateFaceGroupAsync(CreateFaceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFaceGroupWithOptionsAsync(request, runtime);
        }

        public CreateFacePersonResponse CreateFacePersonWithOptions(CreateFacePersonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFacePersonResponse>(DoRPCRequest("CreateFacePerson", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFacePersonResponse> CreateFacePersonWithOptionsAsync(CreateFacePersonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFacePersonResponse>(await DoRPCRequestAsync("CreateFacePerson", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFacePersonResponse CreateFacePerson(CreateFacePersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFacePersonWithOptions(request, runtime);
        }

        public async Task<CreateFacePersonResponse> CreateFacePersonAsync(CreateFacePersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFacePersonWithOptionsAsync(request, runtime);
        }

        public CreateGifTaskResponse CreateGifTaskWithOptions(CreateGifTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGifTaskResponse>(DoRPCRequest("CreateGifTask", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateGifTaskResponse> CreateGifTaskWithOptionsAsync(CreateGifTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGifTaskResponse>(await DoRPCRequestAsync("CreateGifTask", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateGifTaskResponse CreateGifTask(CreateGifTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGifTaskWithOptions(request, runtime);
        }

        public async Task<CreateGifTaskResponse> CreateGifTaskAsync(CreateGifTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGifTaskWithOptionsAsync(request, runtime);
        }

        public CreateLabelTaskResponse CreateLabelTaskWithOptions(CreateLabelTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLabelTaskResponse>(DoRPCRequest("CreateLabelTask", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateLabelTaskResponse> CreateLabelTaskWithOptionsAsync(CreateLabelTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLabelTaskResponse>(await DoRPCRequestAsync("CreateLabelTask", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateLabelTaskResponse CreateLabelTask(CreateLabelTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLabelTaskWithOptions(request, runtime);
        }

        public async Task<CreateLabelTaskResponse> CreateLabelTaskAsync(CreateLabelTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLabelTaskWithOptionsAsync(request, runtime);
        }

        public CreateTemplateResponse CreateTemplateWithOptions(CreateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTemplateResponse>(DoRPCRequest("CreateTemplate", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateTemplateResponse> CreateTemplateWithOptionsAsync(CreateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTemplateResponse>(await DoRPCRequestAsync("CreateTemplate", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTemplateWithOptions(request, runtime);
        }

        public async Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTemplateWithOptionsAsync(request, runtime);
        }

        public DeleteFaceGroupResponse DeleteFaceGroupWithOptions(DeleteFaceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFaceGroupResponse>(DoRPCRequest("DeleteFaceGroup", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFaceGroupResponse> DeleteFaceGroupWithOptionsAsync(DeleteFaceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFaceGroupResponse>(await DoRPCRequestAsync("DeleteFaceGroup", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFaceGroupResponse DeleteFaceGroup(DeleteFaceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFaceGroupWithOptions(request, runtime);
        }

        public async Task<DeleteFaceGroupResponse> DeleteFaceGroupAsync(DeleteFaceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFaceGroupWithOptionsAsync(request, runtime);
        }

        public DeleteFaceImageResponse DeleteFaceImageWithOptions(DeleteFaceImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFaceImageResponse>(DoRPCRequest("DeleteFaceImage", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFaceImageResponse> DeleteFaceImageWithOptionsAsync(DeleteFaceImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFaceImageResponse>(await DoRPCRequestAsync("DeleteFaceImage", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFaceImageResponse DeleteFaceImage(DeleteFaceImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFaceImageWithOptions(request, runtime);
        }

        public async Task<DeleteFaceImageResponse> DeleteFaceImageAsync(DeleteFaceImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFaceImageWithOptionsAsync(request, runtime);
        }

        public DeleteFacePersonResponse DeleteFacePersonWithOptions(DeleteFacePersonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFacePersonResponse>(DoRPCRequest("DeleteFacePerson", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFacePersonResponse> DeleteFacePersonWithOptionsAsync(DeleteFacePersonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFacePersonResponse>(await DoRPCRequestAsync("DeleteFacePerson", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFacePersonResponse DeleteFacePerson(DeleteFacePersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFacePersonWithOptions(request, runtime);
        }

        public async Task<DeleteFacePersonResponse> DeleteFacePersonAsync(DeleteFacePersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFacePersonWithOptionsAsync(request, runtime);
        }

        public GetTaskResultResponse GetTaskResultWithOptions(GetTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTaskResultResponse>(DoRPCRequest("GetTaskResult", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTaskResultResponse> GetTaskResultWithOptionsAsync(GetTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTaskResultResponse>(await DoRPCRequestAsync("GetTaskResult", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTaskResultResponse GetTaskResult(GetTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTaskResultWithOptions(request, runtime);
        }

        public async Task<GetTaskResultResponse> GetTaskResultAsync(GetTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTaskResultWithOptionsAsync(request, runtime);
        }

        public GetTaskStatusResponse GetTaskStatusWithOptions(GetTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTaskStatusResponse>(DoRPCRequest("GetTaskStatus", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTaskStatusResponse> GetTaskStatusWithOptionsAsync(GetTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTaskStatusResponse>(await DoRPCRequestAsync("GetTaskStatus", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTaskStatusResponse GetTaskStatus(GetTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTaskStatusWithOptions(request, runtime);
        }

        public async Task<GetTaskStatusResponse> GetTaskStatusAsync(GetTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTaskStatusWithOptionsAsync(request, runtime);
        }

        public GetTemplateResponse GetTemplateWithOptions(GetTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTemplateResponse>(DoRPCRequest("GetTemplate", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTemplateResponse> GetTemplateWithOptionsAsync(GetTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTemplateResponse>(await DoRPCRequestAsync("GetTemplate", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListFaceGroupsResponse ListFaceGroupsWithOptions(ListFaceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFaceGroupsResponse>(DoRPCRequest("ListFaceGroups", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFaceGroupsResponse> ListFaceGroupsWithOptionsAsync(ListFaceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFaceGroupsResponse>(await DoRPCRequestAsync("ListFaceGroups", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFaceGroupsResponse ListFaceGroups(ListFaceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFaceGroupsWithOptions(request, runtime);
        }

        public async Task<ListFaceGroupsResponse> ListFaceGroupsAsync(ListFaceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFaceGroupsWithOptionsAsync(request, runtime);
        }

        public ListFaceImagesResponse ListFaceImagesWithOptions(ListFaceImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFaceImagesResponse>(DoRPCRequest("ListFaceImages", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFaceImagesResponse> ListFaceImagesWithOptionsAsync(ListFaceImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFaceImagesResponse>(await DoRPCRequestAsync("ListFaceImages", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFaceImagesResponse ListFaceImages(ListFaceImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFaceImagesWithOptions(request, runtime);
        }

        public async Task<ListFaceImagesResponse> ListFaceImagesAsync(ListFaceImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFaceImagesWithOptionsAsync(request, runtime);
        }

        public ListFacePersonsResponse ListFacePersonsWithOptions(ListFacePersonsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFacePersonsResponse>(DoRPCRequest("ListFacePersons", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFacePersonsResponse> ListFacePersonsWithOptionsAsync(ListFacePersonsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFacePersonsResponse>(await DoRPCRequestAsync("ListFacePersons", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFacePersonsResponse ListFacePersons(ListFacePersonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFacePersonsWithOptions(request, runtime);
        }

        public async Task<ListFacePersonsResponse> ListFacePersonsAsync(ListFacePersonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFacePersonsWithOptionsAsync(request, runtime);
        }

        public ListTemplatesResponse ListTemplatesWithOptions(ListTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTemplatesResponse>(DoRPCRequest("ListTemplates", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTemplatesResponse> ListTemplatesWithOptionsAsync(ListTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTemplatesResponse>(await DoRPCRequestAsync("ListTemplates", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ProcessFaceAlgorithmResponse ProcessFaceAlgorithmWithOptions(ProcessFaceAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ProcessFaceAlgorithmResponse>(DoRPCRequest("ProcessFaceAlgorithm", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ProcessFaceAlgorithmResponse> ProcessFaceAlgorithmWithOptionsAsync(ProcessFaceAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ProcessFaceAlgorithmResponse>(await DoRPCRequestAsync("ProcessFaceAlgorithm", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ProcessFaceAlgorithmResponse ProcessFaceAlgorithm(ProcessFaceAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ProcessFaceAlgorithmWithOptions(request, runtime);
        }

        public async Task<ProcessFaceAlgorithmResponse> ProcessFaceAlgorithmAsync(ProcessFaceAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ProcessFaceAlgorithmWithOptionsAsync(request, runtime);
        }

        public ProcessImageTagAlgorithmResponse ProcessImageTagAlgorithmWithOptions(ProcessImageTagAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ProcessImageTagAlgorithmResponse>(DoRPCRequest("ProcessImageTagAlgorithm", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ProcessImageTagAlgorithmResponse> ProcessImageTagAlgorithmWithOptionsAsync(ProcessImageTagAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ProcessImageTagAlgorithmResponse>(await DoRPCRequestAsync("ProcessImageTagAlgorithm", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ProcessImageTagAlgorithmResponse ProcessImageTagAlgorithm(ProcessImageTagAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ProcessImageTagAlgorithmWithOptions(request, runtime);
        }

        public async Task<ProcessImageTagAlgorithmResponse> ProcessImageTagAlgorithmAsync(ProcessImageTagAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ProcessImageTagAlgorithmWithOptionsAsync(request, runtime);
        }

        public ProcessLandmarkAlgorithmResponse ProcessLandmarkAlgorithmWithOptions(ProcessLandmarkAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ProcessLandmarkAlgorithmResponse>(DoRPCRequest("ProcessLandmarkAlgorithm", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ProcessLandmarkAlgorithmResponse> ProcessLandmarkAlgorithmWithOptionsAsync(ProcessLandmarkAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ProcessLandmarkAlgorithmResponse>(await DoRPCRequestAsync("ProcessLandmarkAlgorithm", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ProcessLandmarkAlgorithmResponse ProcessLandmarkAlgorithm(ProcessLandmarkAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ProcessLandmarkAlgorithmWithOptions(request, runtime);
        }

        public async Task<ProcessLandmarkAlgorithmResponse> ProcessLandmarkAlgorithmAsync(ProcessLandmarkAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ProcessLandmarkAlgorithmWithOptionsAsync(request, runtime);
        }

        public ProcessLogoAlgorithmResponse ProcessLogoAlgorithmWithOptions(ProcessLogoAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ProcessLogoAlgorithmResponse>(DoRPCRequest("ProcessLogoAlgorithm", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ProcessLogoAlgorithmResponse> ProcessLogoAlgorithmWithOptionsAsync(ProcessLogoAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ProcessLogoAlgorithmResponse>(await DoRPCRequestAsync("ProcessLogoAlgorithm", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ProcessLogoAlgorithmResponse ProcessLogoAlgorithm(ProcessLogoAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ProcessLogoAlgorithmWithOptions(request, runtime);
        }

        public async Task<ProcessLogoAlgorithmResponse> ProcessLogoAlgorithmAsync(ProcessLogoAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ProcessLogoAlgorithmWithOptionsAsync(request, runtime);
        }

        public ProcessNewsAlgorithmResponse ProcessNewsAlgorithmWithOptions(ProcessNewsAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ProcessNewsAlgorithmResponse>(DoRPCRequest("ProcessNewsAlgorithm", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ProcessNewsAlgorithmResponse> ProcessNewsAlgorithmWithOptionsAsync(ProcessNewsAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ProcessNewsAlgorithmResponse>(await DoRPCRequestAsync("ProcessNewsAlgorithm", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ProcessNewsAlgorithmResponse ProcessNewsAlgorithm(ProcessNewsAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ProcessNewsAlgorithmWithOptions(request, runtime);
        }

        public async Task<ProcessNewsAlgorithmResponse> ProcessNewsAlgorithmAsync(ProcessNewsAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ProcessNewsAlgorithmWithOptionsAsync(request, runtime);
        }

        public ProcessNlpAlgorithmResponse ProcessNlpAlgorithmWithOptions(ProcessNlpAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ProcessNlpAlgorithmResponse>(DoRPCRequest("ProcessNlpAlgorithm", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ProcessNlpAlgorithmResponse> ProcessNlpAlgorithmWithOptionsAsync(ProcessNlpAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ProcessNlpAlgorithmResponse>(await DoRPCRequestAsync("ProcessNlpAlgorithm", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ProcessNlpAlgorithmResponse ProcessNlpAlgorithm(ProcessNlpAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ProcessNlpAlgorithmWithOptions(request, runtime);
        }

        public async Task<ProcessNlpAlgorithmResponse> ProcessNlpAlgorithmAsync(ProcessNlpAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ProcessNlpAlgorithmWithOptionsAsync(request, runtime);
        }

        public ProcessOcrAlgorithmResponse ProcessOcrAlgorithmWithOptions(ProcessOcrAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ProcessOcrAlgorithmResponse>(DoRPCRequest("ProcessOcrAlgorithm", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ProcessOcrAlgorithmResponse> ProcessOcrAlgorithmWithOptionsAsync(ProcessOcrAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ProcessOcrAlgorithmResponse>(await DoRPCRequestAsync("ProcessOcrAlgorithm", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ProcessOcrAlgorithmResponse ProcessOcrAlgorithm(ProcessOcrAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ProcessOcrAlgorithmWithOptions(request, runtime);
        }

        public async Task<ProcessOcrAlgorithmResponse> ProcessOcrAlgorithmAsync(ProcessOcrAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ProcessOcrAlgorithmWithOptionsAsync(request, runtime);
        }

        public RegisterFaceImageResponse RegisterFaceImageWithOptions(RegisterFaceImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterFaceImageResponse>(DoRPCRequest("RegisterFaceImage", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RegisterFaceImageResponse> RegisterFaceImageWithOptionsAsync(RegisterFaceImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterFaceImageResponse>(await DoRPCRequestAsync("RegisterFaceImage", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RegisterFaceImageResponse RegisterFaceImage(RegisterFaceImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterFaceImageWithOptions(request, runtime);
        }

        public async Task<RegisterFaceImageResponse> RegisterFaceImageAsync(RegisterFaceImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterFaceImageWithOptionsAsync(request, runtime);
        }

        public UpdateTemplateResponse UpdateTemplateWithOptions(UpdateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(DoRPCRequest("UpdateTemplate", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateTemplateResponse> UpdateTemplateWithOptionsAsync(UpdateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(await DoRPCRequestAsync("UpdateTemplate", "2019-08-10", "HTTPS", "POST", "AK", "json", req, runtime));
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
