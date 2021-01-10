// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ivision20190308.Models;

namespace AlibabaCloud.SDK.Ivision20190308
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ivision", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateFaceGroupResponse CreateFaceGroupWithOptions(CreateFaceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateFaceGroupResponse>(DoRPCRequest("CreateFaceGroup", "2019-03-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<CreateFaceGroupResponse> CreateFaceGroupWithOptionsAsync(CreateFaceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateFaceGroupResponse>(await DoRPCRequestAsync("CreateFaceGroup", "2019-03-08", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public CreateStreamPredictResponse CreateStreamPredictWithOptions(CreateStreamPredictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateStreamPredictResponse>(DoRPCRequest("CreateStreamPredict", "2019-03-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateStreamPredictResponse> CreateStreamPredictWithOptionsAsync(CreateStreamPredictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateStreamPredictResponse>(await DoRPCRequestAsync("CreateStreamPredict", "2019-03-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateStreamPredictResponse CreateStreamPredict(CreateStreamPredictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStreamPredictWithOptions(request, runtime);
        }

        public async Task<CreateStreamPredictResponse> CreateStreamPredictAsync(CreateStreamPredictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStreamPredictWithOptionsAsync(request, runtime);
        }

        public DeleteFaceGroupResponse DeleteFaceGroupWithOptions(DeleteFaceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteFaceGroupResponse>(DoRPCRequest("DeleteFaceGroup", "2019-03-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteFaceGroupResponse> DeleteFaceGroupWithOptionsAsync(DeleteFaceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteFaceGroupResponse>(await DoRPCRequestAsync("DeleteFaceGroup", "2019-03-08", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public DeleteStreamPredictResponse DeleteStreamPredictWithOptions(DeleteStreamPredictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteStreamPredictResponse>(DoRPCRequest("DeleteStreamPredict", "2019-03-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteStreamPredictResponse> DeleteStreamPredictWithOptionsAsync(DeleteStreamPredictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteStreamPredictResponse>(await DoRPCRequestAsync("DeleteStreamPredict", "2019-03-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteStreamPredictResponse DeleteStreamPredict(DeleteStreamPredictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStreamPredictWithOptions(request, runtime);
        }

        public async Task<DeleteStreamPredictResponse> DeleteStreamPredictAsync(DeleteStreamPredictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStreamPredictWithOptionsAsync(request, runtime);
        }

        public DescribeFaceGroupsResponse DescribeFaceGroupsWithOptions(DescribeFaceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeFaceGroupsResponse>(DoRPCRequest("DescribeFaceGroups", "2019-03-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeFaceGroupsResponse> DescribeFaceGroupsWithOptionsAsync(DescribeFaceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeFaceGroupsResponse>(await DoRPCRequestAsync("DescribeFaceGroups", "2019-03-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeFaceGroupsResponse DescribeFaceGroups(DescribeFaceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFaceGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeFaceGroupsResponse> DescribeFaceGroupsAsync(DescribeFaceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFaceGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeStreamPredictResultResponse DescribeStreamPredictResultWithOptions(DescribeStreamPredictResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStreamPredictResultResponse>(DoRPCRequest("DescribeStreamPredictResult", "2019-03-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeStreamPredictResultResponse> DescribeStreamPredictResultWithOptionsAsync(DescribeStreamPredictResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStreamPredictResultResponse>(await DoRPCRequestAsync("DescribeStreamPredictResult", "2019-03-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeStreamPredictResultResponse DescribeStreamPredictResult(DescribeStreamPredictResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStreamPredictResultWithOptions(request, runtime);
        }

        public async Task<DescribeStreamPredictResultResponse> DescribeStreamPredictResultAsync(DescribeStreamPredictResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStreamPredictResultWithOptionsAsync(request, runtime);
        }

        public DescribeStreamPredictsResponse DescribeStreamPredictsWithOptions(DescribeStreamPredictsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStreamPredictsResponse>(DoRPCRequest("DescribeStreamPredicts", "2019-03-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeStreamPredictsResponse> DescribeStreamPredictsWithOptionsAsync(DescribeStreamPredictsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStreamPredictsResponse>(await DoRPCRequestAsync("DescribeStreamPredicts", "2019-03-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeStreamPredictsResponse DescribeStreamPredicts(DescribeStreamPredictsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStreamPredictsWithOptions(request, runtime);
        }

        public async Task<DescribeStreamPredictsResponse> DescribeStreamPredictsAsync(DescribeStreamPredictsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStreamPredictsWithOptionsAsync(request, runtime);
        }

        public GetAlgorithmDetailResponse GetAlgorithmDetailWithOptions(GetAlgorithmDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAlgorithmDetailResponse>(DoRPCRequest("GetAlgorithmDetail", "2019-03-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAlgorithmDetailResponse> GetAlgorithmDetailWithOptionsAsync(GetAlgorithmDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAlgorithmDetailResponse>(await DoRPCRequestAsync("GetAlgorithmDetail", "2019-03-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAlgorithmDetailResponse GetAlgorithmDetail(GetAlgorithmDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAlgorithmDetailWithOptions(request, runtime);
        }

        public async Task<GetAlgorithmDetailResponse> GetAlgorithmDetailAsync(GetAlgorithmDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAlgorithmDetailWithOptionsAsync(request, runtime);
        }

        public GetAlgorithmHistogramsResponse GetAlgorithmHistogramsWithOptions(GetAlgorithmHistogramsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAlgorithmHistogramsResponse>(DoRPCRequest("GetAlgorithmHistograms", "2019-03-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAlgorithmHistogramsResponse> GetAlgorithmHistogramsWithOptionsAsync(GetAlgorithmHistogramsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAlgorithmHistogramsResponse>(await DoRPCRequestAsync("GetAlgorithmHistograms", "2019-03-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAlgorithmHistogramsResponse GetAlgorithmHistograms(GetAlgorithmHistogramsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAlgorithmHistogramsWithOptions(request, runtime);
        }

        public async Task<GetAlgorithmHistogramsResponse> GetAlgorithmHistogramsAsync(GetAlgorithmHistogramsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAlgorithmHistogramsWithOptionsAsync(request, runtime);
        }

        public ImagePredictResponse ImagePredictWithOptions(ImagePredictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ImagePredictResponse>(DoRPCRequest("ImagePredict", "2019-03-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ImagePredictResponse> ImagePredictWithOptionsAsync(ImagePredictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ImagePredictResponse>(await DoRPCRequestAsync("ImagePredict", "2019-03-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ImagePredictResponse ImagePredict(ImagePredictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImagePredictWithOptions(request, runtime);
        }

        public async Task<ImagePredictResponse> ImagePredictAsync(ImagePredictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImagePredictWithOptionsAsync(request, runtime);
        }

        public ListMyAlgorithmResponse ListMyAlgorithmWithOptions(ListMyAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMyAlgorithmResponse>(DoRPCRequest("ListMyAlgorithm", "2019-03-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListMyAlgorithmResponse> ListMyAlgorithmWithOptionsAsync(ListMyAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMyAlgorithmResponse>(await DoRPCRequestAsync("ListMyAlgorithm", "2019-03-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListMyAlgorithmResponse ListMyAlgorithm(ListMyAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMyAlgorithmWithOptions(request, runtime);
        }

        public async Task<ListMyAlgorithmResponse> ListMyAlgorithmAsync(ListMyAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMyAlgorithmWithOptionsAsync(request, runtime);
        }

        public PredictPictureResponse PredictPictureWithOptions(PredictPictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PredictPictureResponse>(DoRPCRequest("PredictPicture", "2019-03-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PredictPictureResponse> PredictPictureWithOptionsAsync(PredictPictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PredictPictureResponse>(await DoRPCRequestAsync("PredictPicture", "2019-03-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PredictPictureResponse PredictPicture(PredictPictureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PredictPictureWithOptions(request, runtime);
        }

        public async Task<PredictPictureResponse> PredictPictureAsync(PredictPictureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PredictPictureWithOptionsAsync(request, runtime);
        }

        public RegisterFaceResponse RegisterFaceWithOptions(RegisterFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RegisterFaceResponse>(DoRPCRequest("RegisterFace", "2019-03-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RegisterFaceResponse> RegisterFaceWithOptionsAsync(RegisterFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RegisterFaceResponse>(await DoRPCRequestAsync("RegisterFace", "2019-03-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RegisterFaceResponse RegisterFace(RegisterFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterFaceWithOptions(request, runtime);
        }

        public async Task<RegisterFaceResponse> RegisterFaceAsync(RegisterFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterFaceWithOptionsAsync(request, runtime);
        }

        public SearchFaceResponse SearchFaceWithOptions(SearchFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SearchFaceResponse>(DoRPCRequest("SearchFace", "2019-03-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<SearchFaceResponse> SearchFaceWithOptionsAsync(SearchFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SearchFaceResponse>(await DoRPCRequestAsync("SearchFace", "2019-03-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public SearchFaceResponse SearchFace(SearchFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchFaceWithOptions(request, runtime);
        }

        public async Task<SearchFaceResponse> SearchFaceAsync(SearchFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchFaceWithOptionsAsync(request, runtime);
        }

        public StartStreamPredictResponse StartStreamPredictWithOptions(StartStreamPredictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartStreamPredictResponse>(DoRPCRequest("StartStreamPredict", "2019-03-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartStreamPredictResponse> StartStreamPredictWithOptionsAsync(StartStreamPredictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartStreamPredictResponse>(await DoRPCRequestAsync("StartStreamPredict", "2019-03-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartStreamPredictResponse StartStreamPredict(StartStreamPredictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartStreamPredictWithOptions(request, runtime);
        }

        public async Task<StartStreamPredictResponse> StartStreamPredictAsync(StartStreamPredictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartStreamPredictWithOptionsAsync(request, runtime);
        }

        public StopStreamPredictResponse StopStreamPredictWithOptions(StopStreamPredictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopStreamPredictResponse>(DoRPCRequest("StopStreamPredict", "2019-03-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopStreamPredictResponse> StopStreamPredictWithOptionsAsync(StopStreamPredictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopStreamPredictResponse>(await DoRPCRequestAsync("StopStreamPredict", "2019-03-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopStreamPredictResponse StopStreamPredict(StopStreamPredictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopStreamPredictWithOptions(request, runtime);
        }

        public async Task<StopStreamPredictResponse> StopStreamPredictAsync(StopStreamPredictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopStreamPredictWithOptionsAsync(request, runtime);
        }

        public UnregisterFaceResponse UnregisterFaceWithOptions(UnregisterFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<UnregisterFaceResponse>(DoRPCRequest("UnregisterFace", "2019-03-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<UnregisterFaceResponse> UnregisterFaceWithOptionsAsync(UnregisterFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<UnregisterFaceResponse>(await DoRPCRequestAsync("UnregisterFace", "2019-03-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public UnregisterFaceResponse UnregisterFace(UnregisterFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnregisterFaceWithOptions(request, runtime);
        }

        public async Task<UnregisterFaceResponse> UnregisterFaceAsync(UnregisterFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnregisterFaceWithOptionsAsync(request, runtime);
        }

    }
}
