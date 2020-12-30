// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Nlp_automl20191111.Models;

namespace AlibabaCloud.SDK.Nlp_automl20191111
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("nlp-automl", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateAsyncPredictResponse CreateAsyncPredictWithOptions(CreateAsyncPredictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAsyncPredictResponse>(DoRPCRequest("CreateAsyncPredict", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAsyncPredictResponse> CreateAsyncPredictWithOptionsAsync(CreateAsyncPredictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAsyncPredictResponse>(await DoRPCRequestAsync("CreateAsyncPredict", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAsyncPredictResponse CreateAsyncPredict(CreateAsyncPredictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAsyncPredictWithOptions(request, runtime);
        }

        public async Task<CreateAsyncPredictResponse> CreateAsyncPredictAsync(CreateAsyncPredictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAsyncPredictWithOptionsAsync(request, runtime);
        }

        public CreateDatasetResponse CreateDatasetWithOptions(CreateDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDatasetResponse>(DoRPCRequest("CreateDataset", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDatasetResponse> CreateDatasetWithOptionsAsync(CreateDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDatasetResponse>(await DoRPCRequestAsync("CreateDataset", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDatasetResponse CreateDataset(CreateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDatasetWithOptions(request, runtime);
        }

        public async Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDatasetWithOptionsAsync(request, runtime);
        }

        public CreateDatasetRecordResponse CreateDatasetRecordWithOptions(CreateDatasetRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDatasetRecordResponse>(DoRPCRequest("CreateDatasetRecord", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDatasetRecordResponse> CreateDatasetRecordWithOptionsAsync(CreateDatasetRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDatasetRecordResponse>(await DoRPCRequestAsync("CreateDatasetRecord", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDatasetRecordResponse CreateDatasetRecord(CreateDatasetRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDatasetRecordWithOptions(request, runtime);
        }

        public async Task<CreateDatasetRecordResponse> CreateDatasetRecordAsync(CreateDatasetRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDatasetRecordWithOptionsAsync(request, runtime);
        }

        public CreateModelResponse CreateModelWithOptions(CreateModelRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateModelShrinkRequest request = new CreateModelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DatasetIdList))
            {
                request.DatasetIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DatasetIdList, "DatasetIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TestDatasetIdList))
            {
                request.TestDatasetIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TestDatasetIdList, "TestDatasetIdList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateModelResponse>(DoRPCRequest("CreateModel", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateModelResponse> CreateModelWithOptionsAsync(CreateModelRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateModelShrinkRequest request = new CreateModelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DatasetIdList))
            {
                request.DatasetIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DatasetIdList, "DatasetIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TestDatasetIdList))
            {
                request.TestDatasetIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TestDatasetIdList, "TestDatasetIdList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateModelResponse>(await DoRPCRequestAsync("CreateModel", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateModelResponse CreateModel(CreateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateModelWithOptions(request, runtime);
        }

        public async Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateModelWithOptionsAsync(request, runtime);
        }

        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectResponse>(DoRPCRequest("CreateProject", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectResponse>(await DoRPCRequestAsync("CreateProject", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteModelResponse DeleteModelWithOptions(DeleteModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteModelResponse>(DoRPCRequest("DeleteModel", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteModelResponse> DeleteModelWithOptionsAsync(DeleteModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteModelResponse>(await DoRPCRequestAsync("DeleteModel", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteModelWithOptions(request, runtime);
        }

        public async Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteModelWithOptionsAsync(request, runtime);
        }

        public DeployModelResponse DeployModelWithOptions(DeployModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeployModelResponse>(DoRPCRequest("DeployModel", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeployModelResponse> DeployModelWithOptionsAsync(DeployModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeployModelResponse>(await DoRPCRequestAsync("DeployModel", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeployModelResponse DeployModel(DeployModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeployModelWithOptions(request, runtime);
        }

        public async Task<DeployModelResponse> DeployModelAsync(DeployModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeployModelWithOptionsAsync(request, runtime);
        }

        public GetAsyncPredictResponse GetAsyncPredictWithOptions(GetAsyncPredictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAsyncPredictResponse>(DoRPCRequest("GetAsyncPredict", "2019-11-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAsyncPredictResponse> GetAsyncPredictWithOptionsAsync(GetAsyncPredictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAsyncPredictResponse>(await DoRPCRequestAsync("GetAsyncPredict", "2019-11-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAsyncPredictResponse GetAsyncPredict(GetAsyncPredictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAsyncPredictWithOptions(request, runtime);
        }

        public async Task<GetAsyncPredictResponse> GetAsyncPredictAsync(GetAsyncPredictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAsyncPredictWithOptionsAsync(request, runtime);
        }

        public GetModelResponse GetModelWithOptions(GetModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetModelResponse>(DoRPCRequest("GetModel", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetModelResponse> GetModelWithOptionsAsync(GetModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetModelResponse>(await DoRPCRequestAsync("GetModel", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetModelResponse GetModel(GetModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetModelWithOptions(request, runtime);
        }

        public async Task<GetModelResponse> GetModelAsync(GetModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetModelWithOptionsAsync(request, runtime);
        }

        public GetPredictResultResponse GetPredictResultWithOptions(GetPredictResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPredictResultResponse>(DoRPCRequest("GetPredictResult", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPredictResultResponse> GetPredictResultWithOptionsAsync(GetPredictResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPredictResultResponse>(await DoRPCRequestAsync("GetPredictResult", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListDatasetResponse ListDatasetWithOptions(ListDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDatasetResponse>(DoRPCRequest("ListDataset", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDatasetResponse> ListDatasetWithOptionsAsync(ListDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDatasetResponse>(await DoRPCRequestAsync("ListDataset", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDatasetResponse ListDataset(ListDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDatasetWithOptions(request, runtime);
        }

        public async Task<ListDatasetResponse> ListDatasetAsync(ListDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDatasetWithOptionsAsync(request, runtime);
        }

        public ListModelsResponse ListModelsWithOptions(ListModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListModelsResponse>(DoRPCRequest("ListModels", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListModelsResponse> ListModelsWithOptionsAsync(ListModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListModelsResponse>(await DoRPCRequestAsync("ListModels", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListModelsResponse ListModels(ListModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListModelsWithOptions(request, runtime);
        }

        public async Task<ListModelsResponse> ListModelsAsync(ListModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListModelsWithOptionsAsync(request, runtime);
        }

        public RunContactReviewResponse RunContactReviewWithOptions(RunContactReviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunContactReviewResponse>(DoRPCRequest("RunContactReview", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RunContactReviewResponse> RunContactReviewWithOptionsAsync(RunContactReviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunContactReviewResponse>(await DoRPCRequestAsync("RunContactReview", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RunContactReviewResponse RunContactReview(RunContactReviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunContactReviewWithOptions(request, runtime);
        }

        public async Task<RunContactReviewResponse> RunContactReviewAsync(RunContactReviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunContactReviewWithOptionsAsync(request, runtime);
        }

        public RunPreTrainServiceResponse RunPreTrainServiceWithOptions(RunPreTrainServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunPreTrainServiceResponse>(DoRPCRequest("RunPreTrainService", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RunPreTrainServiceResponse> RunPreTrainServiceWithOptionsAsync(RunPreTrainServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunPreTrainServiceResponse>(await DoRPCRequestAsync("RunPreTrainService", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RunPreTrainServiceResponse RunPreTrainService(RunPreTrainServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunPreTrainServiceWithOptions(request, runtime);
        }

        public async Task<RunPreTrainServiceResponse> RunPreTrainServiceAsync(RunPreTrainServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunPreTrainServiceWithOptionsAsync(request, runtime);
        }

        public RunSmartCallServiceResponse RunSmartCallServiceWithOptions(RunSmartCallServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunSmartCallServiceResponse>(DoRPCRequest("RunSmartCallService", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RunSmartCallServiceResponse> RunSmartCallServiceWithOptionsAsync(RunSmartCallServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunSmartCallServiceResponse>(await DoRPCRequestAsync("RunSmartCallService", "2019-11-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RunSmartCallServiceResponse RunSmartCallService(RunSmartCallServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunSmartCallServiceWithOptions(request, runtime);
        }

        public async Task<RunSmartCallServiceResponse> RunSmartCallServiceAsync(RunSmartCallServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunSmartCallServiceWithOptionsAsync(request, runtime);
        }

    }
}
