// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ivpd20190625.Models;

namespace AlibabaCloud.SDK.Ivpd20190625
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ivpd", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AssessCompositionResponse AssessCompositionWithOptions(AssessCompositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssessCompositionResponse>(DoRPCRequest("AssessComposition", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssessCompositionResponse> AssessCompositionWithOptionsAsync(AssessCompositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssessCompositionResponse>(await DoRPCRequestAsync("AssessComposition", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssessCompositionResponse AssessComposition(AssessCompositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssessCompositionWithOptions(request, runtime);
        }

        public async Task<AssessCompositionResponse> AssessCompositionAsync(AssessCompositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssessCompositionWithOptionsAsync(request, runtime);
        }

        public AssessExposureResponse AssessExposureWithOptions(AssessExposureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssessExposureResponse>(DoRPCRequest("AssessExposure", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssessExposureResponse> AssessExposureWithOptionsAsync(AssessExposureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssessExposureResponse>(await DoRPCRequestAsync("AssessExposure", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssessExposureResponse AssessExposure(AssessExposureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssessExposureWithOptions(request, runtime);
        }

        public async Task<AssessExposureResponse> AssessExposureAsync(AssessExposureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssessExposureWithOptionsAsync(request, runtime);
        }

        public AssessSharpnessResponse AssessSharpnessWithOptions(AssessSharpnessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssessSharpnessResponse>(DoRPCRequest("AssessSharpness", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssessSharpnessResponse> AssessSharpnessWithOptionsAsync(AssessSharpnessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssessSharpnessResponse>(await DoRPCRequestAsync("AssessSharpness", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssessSharpnessResponse AssessSharpness(AssessSharpnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssessSharpnessWithOptions(request, runtime);
        }

        public async Task<AssessSharpnessResponse> AssessSharpnessAsync(AssessSharpnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssessSharpnessWithOptionsAsync(request, runtime);
        }

        public ChangeImageSizeResponse ChangeImageSizeWithOptions(ChangeImageSizeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeImageSizeResponse>(DoRPCRequest("ChangeImageSize", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ChangeImageSizeResponse> ChangeImageSizeWithOptionsAsync(ChangeImageSizeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeImageSizeResponse>(await DoRPCRequestAsync("ChangeImageSize", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ChangeImageSizeResponse ChangeImageSize(ChangeImageSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeImageSizeWithOptions(request, runtime);
        }

        public async Task<ChangeImageSizeResponse> ChangeImageSizeAsync(ChangeImageSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeImageSizeWithOptionsAsync(request, runtime);
        }

        public CreateSegmentBodyJobResponse CreateSegmentBodyJobWithOptions(CreateSegmentBodyJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSegmentBodyJobResponse>(DoRPCRequest("CreateSegmentBodyJob", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSegmentBodyJobResponse> CreateSegmentBodyJobWithOptionsAsync(CreateSegmentBodyJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSegmentBodyJobResponse>(await DoRPCRequestAsync("CreateSegmentBodyJob", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSegmentBodyJobResponse CreateSegmentBodyJob(CreateSegmentBodyJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSegmentBodyJobWithOptions(request, runtime);
        }

        public async Task<CreateSegmentBodyJobResponse> CreateSegmentBodyJobAsync(CreateSegmentBodyJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSegmentBodyJobWithOptionsAsync(request, runtime);
        }

        public DetectImageElementsResponse DetectImageElementsWithOptions(DetectImageElementsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectImageElementsResponse>(DoRPCRequest("DetectImageElements", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetectImageElementsResponse> DetectImageElementsWithOptionsAsync(DetectImageElementsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectImageElementsResponse>(await DoRPCRequestAsync("DetectImageElements", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetectImageElementsResponse DetectImageElements(DetectImageElementsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageElementsWithOptions(request, runtime);
        }

        public async Task<DetectImageElementsResponse> DetectImageElementsAsync(DetectImageElementsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageElementsWithOptionsAsync(request, runtime);
        }

        public DetectMainBodyResponse DetectMainBodyWithOptions(DetectMainBodyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectMainBodyResponse>(DoRPCRequest("DetectMainBody", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetectMainBodyResponse> DetectMainBodyWithOptionsAsync(DetectMainBodyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectMainBodyResponse>(await DoRPCRequestAsync("DetectMainBody", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetectMainBodyResponse DetectMainBody(DetectMainBodyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectMainBodyWithOptions(request, runtime);
        }

        public async Task<DetectMainBodyResponse> DetectMainBodyAsync(DetectMainBodyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectMainBodyWithOptionsAsync(request, runtime);
        }

        public EnhanceFaceResponse EnhanceFaceWithOptions(EnhanceFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnhanceFaceResponse>(DoRPCRequest("EnhanceFace", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnhanceFaceResponse> EnhanceFaceWithOptionsAsync(EnhanceFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnhanceFaceResponse>(await DoRPCRequestAsync("EnhanceFace", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnhanceFaceResponse EnhanceFace(EnhanceFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnhanceFaceWithOptions(request, runtime);
        }

        public async Task<EnhanceFaceResponse> EnhanceFaceAsync(EnhanceFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnhanceFaceWithOptionsAsync(request, runtime);
        }

        public EraseLogoInVideoResponse EraseLogoInVideoWithOptions(EraseLogoInVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EraseLogoInVideoResponse>(DoRPCRequest("EraseLogoInVideo", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EraseLogoInVideoResponse> EraseLogoInVideoWithOptionsAsync(EraseLogoInVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EraseLogoInVideoResponse>(await DoRPCRequestAsync("EraseLogoInVideo", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EraseLogoInVideoResponse EraseLogoInVideo(EraseLogoInVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EraseLogoInVideoWithOptions(request, runtime);
        }

        public async Task<EraseLogoInVideoResponse> EraseLogoInVideoAsync(EraseLogoInVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EraseLogoInVideoWithOptionsAsync(request, runtime);
        }

        public ExtendImageStyleResponse ExtendImageStyleWithOptions(ExtendImageStyleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExtendImageStyleResponse>(DoRPCRequest("ExtendImageStyle", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExtendImageStyleResponse> ExtendImageStyleWithOptionsAsync(ExtendImageStyleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExtendImageStyleResponse>(await DoRPCRequestAsync("ExtendImageStyle", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExtendImageStyleResponse ExtendImageStyle(ExtendImageStyleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExtendImageStyleWithOptions(request, runtime);
        }

        public async Task<ExtendImageStyleResponse> ExtendImageStyleAsync(ExtendImageStyleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExtendImageStyleWithOptionsAsync(request, runtime);
        }

        public GetAsyncJobResultResponse GetAsyncJobResultWithOptions(GetAsyncJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAsyncJobResultResponse>(DoRPCRequest("GetAsyncJobResult", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAsyncJobResultResponse> GetAsyncJobResultWithOptionsAsync(GetAsyncJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAsyncJobResultResponse>(await DoRPCRequestAsync("GetAsyncJobResult", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAsyncJobResultResponse GetAsyncJobResult(GetAsyncJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAsyncJobResultWithOptions(request, runtime);
        }

        public async Task<GetAsyncJobResultResponse> GetAsyncJobResultAsync(GetAsyncJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAsyncJobResultWithOptionsAsync(request, runtime);
        }

        public GetAsyncResultResponse GetAsyncResultWithOptions(GetAsyncResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAsyncResultResponse>(DoRPCRequest("GetAsyncResult", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAsyncResultResponse> GetAsyncResultWithOptionsAsync(GetAsyncResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAsyncResultResponse>(await DoRPCRequestAsync("GetAsyncResult", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAsyncResultResponse GetAsyncResult(GetAsyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAsyncResultWithOptions(request, runtime);
        }

        public async Task<GetAsyncResultResponse> GetAsyncResultAsync(GetAsyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAsyncResultWithOptionsAsync(request, runtime);
        }

        public GetJobResultResponse GetJobResultWithOptions(GetJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobResultResponse>(DoRPCRequest("GetJobResult", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetJobResultResponse> GetJobResultWithOptionsAsync(GetJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobResultResponse>(await DoRPCRequestAsync("GetJobResult", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetJobResultResponse GetJobResult(GetJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobResultWithOptions(request, runtime);
        }

        public async Task<GetJobResultResponse> GetJobResultAsync(GetJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobResultWithOptionsAsync(request, runtime);
        }

        public GetJobStatusResponse GetJobStatusWithOptions(GetJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobStatusResponse>(DoRPCRequest("GetJobStatus", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetJobStatusResponse> GetJobStatusWithOptionsAsync(GetJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobStatusResponse>(await DoRPCRequestAsync("GetJobStatus", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetJobStatusResponse GetJobStatus(GetJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobStatusWithOptions(request, runtime);
        }

        public async Task<GetJobStatusResponse> GetJobStatusAsync(GetJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobStatusWithOptionsAsync(request, runtime);
        }

        public GetRenderResultResponse GetRenderResultWithOptions(GetRenderResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRenderResultResponse>(DoRPCRequest("GetRenderResult", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRenderResultResponse> GetRenderResultWithOptionsAsync(GetRenderResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRenderResultResponse>(await DoRPCRequestAsync("GetRenderResult", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRenderResultResponse GetRenderResult(GetRenderResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRenderResultWithOptions(request, runtime);
        }

        public async Task<GetRenderResultResponse> GetRenderResultAsync(GetRenderResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRenderResultWithOptionsAsync(request, runtime);
        }

        public GetUserBucketConfigResponse GetUserBucketConfigWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetUserBucketConfigResponse>(DoRPCRequest("GetUserBucketConfig", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserBucketConfigResponse> GetUserBucketConfigWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetUserBucketConfigResponse>(await DoRPCRequestAsync("GetUserBucketConfig", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserBucketConfigResponse GetUserBucketConfig()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserBucketConfigWithOptions(runtime);
        }

        public async Task<GetUserBucketConfigResponse> GetUserBucketConfigAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserBucketConfigWithOptionsAsync(runtime);
        }

        public HighlightGameVideoResponse HighlightGameVideoWithOptions(HighlightGameVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HighlightGameVideoResponse>(DoRPCRequest("HighlightGameVideo", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<HighlightGameVideoResponse> HighlightGameVideoWithOptionsAsync(HighlightGameVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HighlightGameVideoResponse>(await DoRPCRequestAsync("HighlightGameVideo", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public HighlightGameVideoResponse HighlightGameVideo(HighlightGameVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HighlightGameVideoWithOptions(request, runtime);
        }

        public async Task<HighlightGameVideoResponse> HighlightGameVideoAsync(HighlightGameVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HighlightGameVideoWithOptionsAsync(request, runtime);
        }

        public HighlightGameVideoResponse HighlightGameVideoAdvance(HighlightGameVideoAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Endpoint = "openplatform.aliyuncs.com",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "ivpd",
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
            HighlightGameVideoRequest highlightGameVideoReq = new HighlightGameVideoRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, highlightGameVideoReq);
            authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
            ossConfig.AccessKeyId = authResponse.AccessKeyId;
            ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
            ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
            {
                Filename = authResponse.ObjectKey,
                Content = request.VideoUrlObject,
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
            highlightGameVideoReq.VideoUrl = "http://" + authResponse.Bucket + "." + authResponse.Endpoint + "/" + authResponse.ObjectKey;
            HighlightGameVideoResponse highlightGameVideoResp = HighlightGameVideoWithOptions(highlightGameVideoReq, runtime);
            return highlightGameVideoResp;
        }

        public async Task<HighlightGameVideoResponse> HighlightGameVideoAdvanceAsync(HighlightGameVideoAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Endpoint = "openplatform.aliyuncs.com",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "ivpd",
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
            HighlightGameVideoRequest highlightGameVideoReq = new HighlightGameVideoRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, highlightGameVideoReq);
            authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
            ossConfig.AccessKeyId = authResponse.AccessKeyId;
            ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
            ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
            {
                Filename = authResponse.ObjectKey,
                Content = request.VideoUrlObject,
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
            highlightGameVideoReq.VideoUrl = "http://" + authResponse.Bucket + "." + authResponse.Endpoint + "/" + authResponse.ObjectKey;
            HighlightGameVideoResponse highlightGameVideoResp = await HighlightGameVideoWithOptionsAsync(highlightGameVideoReq, runtime);
            return highlightGameVideoResp;
        }

        public IntelligentCompositionResponse IntelligentCompositionWithOptions(IntelligentCompositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<IntelligentCompositionResponse>(DoRPCRequest("IntelligentComposition", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<IntelligentCompositionResponse> IntelligentCompositionWithOptionsAsync(IntelligentCompositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<IntelligentCompositionResponse>(await DoRPCRequestAsync("IntelligentComposition", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public IntelligentCompositionResponse IntelligentComposition(IntelligentCompositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IntelligentCompositionWithOptions(request, runtime);
        }

        public async Task<IntelligentCompositionResponse> IntelligentCompositionAsync(IntelligentCompositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IntelligentCompositionWithOptionsAsync(request, runtime);
        }

        public ListPackageDesignModelTypesResponse ListPackageDesignModelTypesWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListPackageDesignModelTypesResponse>(DoRPCRequest("ListPackageDesignModelTypes", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPackageDesignModelTypesResponse> ListPackageDesignModelTypesWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListPackageDesignModelTypesResponse>(await DoRPCRequestAsync("ListPackageDesignModelTypes", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPackageDesignModelTypesResponse ListPackageDesignModelTypes()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPackageDesignModelTypesWithOptions(runtime);
        }

        public async Task<ListPackageDesignModelTypesResponse> ListPackageDesignModelTypesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPackageDesignModelTypesWithOptionsAsync(runtime);
        }

        public ListUserBucketsResponse ListUserBucketsWithOptions(ListUserBucketsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserBucketsResponse>(DoRPCRequest("ListUserBuckets", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUserBucketsResponse> ListUserBucketsWithOptionsAsync(ListUserBucketsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserBucketsResponse>(await DoRPCRequestAsync("ListUserBuckets", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUserBucketsResponse ListUserBuckets(ListUserBucketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserBucketsWithOptions(request, runtime);
        }

        public async Task<ListUserBucketsResponse> ListUserBucketsAsync(ListUserBucketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserBucketsWithOptionsAsync(request, runtime);
        }

        public MakeSuperResolutionImageResponse MakeSuperResolutionImageWithOptions(MakeSuperResolutionImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MakeSuperResolutionImageResponse>(DoRPCRequest("MakeSuperResolutionImage", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MakeSuperResolutionImageResponse> MakeSuperResolutionImageWithOptionsAsync(MakeSuperResolutionImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MakeSuperResolutionImageResponse>(await DoRPCRequestAsync("MakeSuperResolutionImage", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MakeSuperResolutionImageResponse MakeSuperResolutionImage(MakeSuperResolutionImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MakeSuperResolutionImageWithOptions(request, runtime);
        }

        public async Task<MakeSuperResolutionImageResponse> MakeSuperResolutionImageAsync(MakeSuperResolutionImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MakeSuperResolutionImageWithOptionsAsync(request, runtime);
        }

        public ParseFaceResponse ParseFaceWithOptions(ParseFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ParseFaceResponse>(DoRPCRequest("ParseFace", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ParseFaceResponse> ParseFaceWithOptionsAsync(ParseFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ParseFaceResponse>(await DoRPCRequestAsync("ParseFace", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ParseFaceResponse ParseFace(ParseFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ParseFaceWithOptions(request, runtime);
        }

        public async Task<ParseFaceResponse> ParseFaceAsync(ParseFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ParseFaceWithOptionsAsync(request, runtime);
        }

        public PreviewModelForPackageDesignResponse PreviewModelForPackageDesignWithOptions(PreviewModelForPackageDesignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PreviewModelForPackageDesignResponse>(DoRPCRequest("PreviewModelForPackageDesign", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PreviewModelForPackageDesignResponse> PreviewModelForPackageDesignWithOptionsAsync(PreviewModelForPackageDesignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PreviewModelForPackageDesignResponse>(await DoRPCRequestAsync("PreviewModelForPackageDesign", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PreviewModelForPackageDesignResponse PreviewModelForPackageDesign(PreviewModelForPackageDesignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PreviewModelForPackageDesignWithOptions(request, runtime);
        }

        public async Task<PreviewModelForPackageDesignResponse> PreviewModelForPackageDesignAsync(PreviewModelForPackageDesignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PreviewModelForPackageDesignWithOptionsAsync(request, runtime);
        }

        public RecognizeImageColorResponse RecognizeImageColorWithOptions(RecognizeImageColorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecognizeImageColorResponse>(DoRPCRequest("RecognizeImageColor", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RecognizeImageColorResponse> RecognizeImageColorWithOptionsAsync(RecognizeImageColorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecognizeImageColorResponse>(await DoRPCRequestAsync("RecognizeImageColor", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RecognizeImageColorResponse RecognizeImageColor(RecognizeImageColorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeImageColorWithOptions(request, runtime);
        }

        public async Task<RecognizeImageColorResponse> RecognizeImageColorAsync(RecognizeImageColorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeImageColorWithOptionsAsync(request, runtime);
        }

        public RecognizeImageStyleResponse RecognizeImageStyleWithOptions(RecognizeImageStyleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecognizeImageStyleResponse>(DoRPCRequest("RecognizeImageStyle", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RecognizeImageStyleResponse> RecognizeImageStyleWithOptionsAsync(RecognizeImageStyleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecognizeImageStyleResponse>(await DoRPCRequestAsync("RecognizeImageStyle", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RecognizeImageStyleResponse RecognizeImageStyle(RecognizeImageStyleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeImageStyleWithOptions(request, runtime);
        }

        public async Task<RecognizeImageStyleResponse> RecognizeImageStyleAsync(RecognizeImageStyleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeImageStyleWithOptionsAsync(request, runtime);
        }

        public RecolorImageResponse RecolorImageWithOptions(RecolorImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecolorImageResponse>(DoRPCRequest("RecolorImage", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RecolorImageResponse> RecolorImageWithOptionsAsync(RecolorImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecolorImageResponse>(await DoRPCRequestAsync("RecolorImage", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RecolorImageResponse RecolorImage(RecolorImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecolorImageWithOptions(request, runtime);
        }

        public async Task<RecolorImageResponse> RecolorImageAsync(RecolorImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecolorImageWithOptionsAsync(request, runtime);
        }

        public RenderImageForPackageDesignResponse RenderImageForPackageDesignWithOptions(RenderImageForPackageDesignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenderImageForPackageDesignResponse>(DoRPCRequest("RenderImageForPackageDesign", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenderImageForPackageDesignResponse> RenderImageForPackageDesignWithOptionsAsync(RenderImageForPackageDesignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenderImageForPackageDesignResponse>(await DoRPCRequestAsync("RenderImageForPackageDesign", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RenderImageForPackageDesignResponse RenderImageForPackageDesign(RenderImageForPackageDesignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenderImageForPackageDesignWithOptions(request, runtime);
        }

        public async Task<RenderImageForPackageDesignResponse> RenderImageForPackageDesignAsync(RenderImageForPackageDesignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenderImageForPackageDesignWithOptionsAsync(request, runtime);
        }

        public SegmentAnimalResponse SegmentAnimalWithOptions(SegmentAnimalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SegmentAnimalResponse>(DoRPCRequest("SegmentAnimal", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SegmentAnimalResponse> SegmentAnimalWithOptionsAsync(SegmentAnimalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SegmentAnimalResponse>(await DoRPCRequestAsync("SegmentAnimal", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SegmentAnimalResponse SegmentAnimal(SegmentAnimalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SegmentAnimalWithOptions(request, runtime);
        }

        public async Task<SegmentAnimalResponse> SegmentAnimalAsync(SegmentAnimalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SegmentAnimalWithOptionsAsync(request, runtime);
        }

        public SegmentBodyResponse SegmentBodyWithOptions(SegmentBodyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SegmentBodyResponse>(DoRPCRequest("SegmentBody", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SegmentBodyResponse> SegmentBodyWithOptionsAsync(SegmentBodyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SegmentBodyResponse>(await DoRPCRequestAsync("SegmentBody", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SegmentBodyResponse SegmentBody(SegmentBodyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SegmentBodyWithOptions(request, runtime);
        }

        public async Task<SegmentBodyResponse> SegmentBodyAsync(SegmentBodyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SegmentBodyWithOptionsAsync(request, runtime);
        }

        public SegmentClothResponse SegmentClothWithOptions(SegmentClothRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SegmentClothResponse>(DoRPCRequest("SegmentCloth", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SegmentClothResponse> SegmentClothWithOptionsAsync(SegmentClothRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SegmentClothResponse>(await DoRPCRequestAsync("SegmentCloth", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SegmentClothResponse SegmentCloth(SegmentClothRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SegmentClothWithOptions(request, runtime);
        }

        public async Task<SegmentClothResponse> SegmentClothAsync(SegmentClothRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SegmentClothWithOptionsAsync(request, runtime);
        }

        public SegmentCommodityResponse SegmentCommodityWithOptions(SegmentCommodityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SegmentCommodityResponse>(DoRPCRequest("SegmentCommodity", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SegmentCommodityResponse> SegmentCommodityWithOptionsAsync(SegmentCommodityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SegmentCommodityResponse>(await DoRPCRequestAsync("SegmentCommodity", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SegmentCommodityResponse SegmentCommodity(SegmentCommodityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SegmentCommodityWithOptions(request, runtime);
        }

        public async Task<SegmentCommodityResponse> SegmentCommodityAsync(SegmentCommodityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SegmentCommodityWithOptionsAsync(request, runtime);
        }

        public SegmentHairResponse SegmentHairWithOptions(SegmentHairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SegmentHairResponse>(DoRPCRequest("SegmentHair", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SegmentHairResponse> SegmentHairWithOptionsAsync(SegmentHairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SegmentHairResponse>(await DoRPCRequestAsync("SegmentHair", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SegmentHairResponse SegmentHair(SegmentHairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SegmentHairWithOptions(request, runtime);
        }

        public async Task<SegmentHairResponse> SegmentHairAsync(SegmentHairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SegmentHairWithOptionsAsync(request, runtime);
        }

        public SegmentHeadResponse SegmentHeadWithOptions(SegmentHeadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SegmentHeadResponse>(DoRPCRequest("SegmentHead", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SegmentHeadResponse> SegmentHeadWithOptionsAsync(SegmentHeadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SegmentHeadResponse>(await DoRPCRequestAsync("SegmentHead", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SegmentHeadResponse SegmentHead(SegmentHeadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SegmentHeadWithOptions(request, runtime);
        }

        public async Task<SegmentHeadResponse> SegmentHeadAsync(SegmentHeadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SegmentHeadWithOptionsAsync(request, runtime);
        }

        public SegmentImageResponse SegmentImageWithOptions(SegmentImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SegmentImageResponse>(DoRPCRequest("SegmentImage", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SegmentImageResponse> SegmentImageWithOptionsAsync(SegmentImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SegmentImageResponse>(await DoRPCRequestAsync("SegmentImage", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SegmentImageResponse SegmentImage(SegmentImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SegmentImageWithOptions(request, runtime);
        }

        public async Task<SegmentImageResponse> SegmentImageAsync(SegmentImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SegmentImageWithOptionsAsync(request, runtime);
        }

        public SegmentSkyResponse SegmentSkyWithOptions(SegmentSkyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SegmentSkyResponse>(DoRPCRequest("SegmentSky", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SegmentSkyResponse> SegmentSkyWithOptionsAsync(SegmentSkyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SegmentSkyResponse>(await DoRPCRequestAsync("SegmentSky", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SegmentSkyResponse SegmentSky(SegmentSkyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SegmentSkyWithOptions(request, runtime);
        }

        public async Task<SegmentSkyResponse> SegmentSkyAsync(SegmentSkyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SegmentSkyWithOptionsAsync(request, runtime);
        }

        public SegmentVehicleResponse SegmentVehicleWithOptions(SegmentVehicleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SegmentVehicleResponse>(DoRPCRequest("SegmentVehicle", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SegmentVehicleResponse> SegmentVehicleWithOptionsAsync(SegmentVehicleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SegmentVehicleResponse>(await DoRPCRequestAsync("SegmentVehicle", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SegmentVehicleResponse SegmentVehicle(SegmentVehicleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SegmentVehicleWithOptions(request, runtime);
        }

        public async Task<SegmentVehicleResponse> SegmentVehicleAsync(SegmentVehicleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SegmentVehicleWithOptionsAsync(request, runtime);
        }

        public UpdateUserBucketConfigResponse UpdateUserBucketConfigWithOptions(UpdateUserBucketConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateUserBucketConfigResponse>(DoRPCRequest("UpdateUserBucketConfig", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateUserBucketConfigResponse> UpdateUserBucketConfigWithOptionsAsync(UpdateUserBucketConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateUserBucketConfigResponse>(await DoRPCRequestAsync("UpdateUserBucketConfig", "2019-06-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateUserBucketConfigResponse UpdateUserBucketConfig(UpdateUserBucketConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserBucketConfigWithOptions(request, runtime);
        }

        public async Task<UpdateUserBucketConfigResponse> UpdateUserBucketConfigAsync(UpdateUserBucketConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserBucketConfigWithOptionsAsync(request, runtime);
        }

    }
}
