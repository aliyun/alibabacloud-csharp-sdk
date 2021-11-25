// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Imm20170906.Models;

namespace AlibabaCloud.SDK.Imm20170906
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing-gov-1", "imm-vpc.cn-beijing-gov-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("imm", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CompareImageFacesResponse CompareImageFacesWithOptions(CompareImageFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CompareImageFacesResponse>(DoRPCRequest("CompareImageFaces", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CompareImageFacesResponse> CompareImageFacesWithOptionsAsync(CompareImageFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CompareImageFacesResponse>(await DoRPCRequestAsync("CompareImageFaces", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CompareImageFacesResponse CompareImageFaces(CompareImageFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompareImageFacesWithOptions(request, runtime);
        }

        public async Task<CompareImageFacesResponse> CompareImageFacesAsync(CompareImageFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompareImageFacesWithOptionsAsync(request, runtime);
        }

        public ConvertOfficeFormatResponse ConvertOfficeFormatWithOptions(ConvertOfficeFormatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConvertOfficeFormatResponse>(DoRPCRequest("ConvertOfficeFormat", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConvertOfficeFormatResponse> ConvertOfficeFormatWithOptionsAsync(ConvertOfficeFormatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConvertOfficeFormatResponse>(await DoRPCRequestAsync("ConvertOfficeFormat", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConvertOfficeFormatResponse ConvertOfficeFormat(ConvertOfficeFormatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConvertOfficeFormatWithOptions(request, runtime);
        }

        public async Task<ConvertOfficeFormatResponse> ConvertOfficeFormatAsync(ConvertOfficeFormatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConvertOfficeFormatWithOptionsAsync(request, runtime);
        }

        public CreateGrabFrameTaskResponse CreateGrabFrameTaskWithOptions(CreateGrabFrameTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGrabFrameTaskResponse>(DoRPCRequest("CreateGrabFrameTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateGrabFrameTaskResponse> CreateGrabFrameTaskWithOptionsAsync(CreateGrabFrameTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGrabFrameTaskResponse>(await DoRPCRequestAsync("CreateGrabFrameTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateGrabFrameTaskResponse CreateGrabFrameTask(CreateGrabFrameTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGrabFrameTaskWithOptions(request, runtime);
        }

        public async Task<CreateGrabFrameTaskResponse> CreateGrabFrameTaskAsync(CreateGrabFrameTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGrabFrameTaskWithOptionsAsync(request, runtime);
        }

        public CreateGroupFacesJobResponse CreateGroupFacesJobWithOptions(CreateGroupFacesJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGroupFacesJobResponse>(DoRPCRequest("CreateGroupFacesJob", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateGroupFacesJobResponse> CreateGroupFacesJobWithOptionsAsync(CreateGroupFacesJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGroupFacesJobResponse>(await DoRPCRequestAsync("CreateGroupFacesJob", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateGroupFacesJobResponse CreateGroupFacesJob(CreateGroupFacesJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGroupFacesJobWithOptions(request, runtime);
        }

        public async Task<CreateGroupFacesJobResponse> CreateGroupFacesJobAsync(CreateGroupFacesJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGroupFacesJobWithOptionsAsync(request, runtime);
        }

        public CreateImageProcessTaskResponse CreateImageProcessTaskWithOptions(CreateImageProcessTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateImageProcessTaskResponse>(DoRPCRequest("CreateImageProcessTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateImageProcessTaskResponse> CreateImageProcessTaskWithOptionsAsync(CreateImageProcessTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateImageProcessTaskResponse>(await DoRPCRequestAsync("CreateImageProcessTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateImageProcessTaskResponse CreateImageProcessTask(CreateImageProcessTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageProcessTaskWithOptions(request, runtime);
        }

        public async Task<CreateImageProcessTaskResponse> CreateImageProcessTaskAsync(CreateImageProcessTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageProcessTaskWithOptionsAsync(request, runtime);
        }

        public CreateMediaComplexTaskResponse CreateMediaComplexTaskWithOptions(CreateMediaComplexTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMediaComplexTaskResponse>(DoRPCRequest("CreateMediaComplexTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMediaComplexTaskResponse> CreateMediaComplexTaskWithOptionsAsync(CreateMediaComplexTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMediaComplexTaskResponse>(await DoRPCRequestAsync("CreateMediaComplexTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMediaComplexTaskResponse CreateMediaComplexTask(CreateMediaComplexTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMediaComplexTaskWithOptions(request, runtime);
        }

        public async Task<CreateMediaComplexTaskResponse> CreateMediaComplexTaskAsync(CreateMediaComplexTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMediaComplexTaskWithOptionsAsync(request, runtime);
        }

        public CreateMergeFaceGroupsJobResponse CreateMergeFaceGroupsJobWithOptions(CreateMergeFaceGroupsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMergeFaceGroupsJobResponse>(DoRPCRequest("CreateMergeFaceGroupsJob", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMergeFaceGroupsJobResponse> CreateMergeFaceGroupsJobWithOptionsAsync(CreateMergeFaceGroupsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMergeFaceGroupsJobResponse>(await DoRPCRequestAsync("CreateMergeFaceGroupsJob", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMergeFaceGroupsJobResponse CreateMergeFaceGroupsJob(CreateMergeFaceGroupsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMergeFaceGroupsJobWithOptions(request, runtime);
        }

        public async Task<CreateMergeFaceGroupsJobResponse> CreateMergeFaceGroupsJobAsync(CreateMergeFaceGroupsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMergeFaceGroupsJobWithOptionsAsync(request, runtime);
        }

        public CreateOfficeConversionTaskResponse CreateOfficeConversionTaskWithOptions(CreateOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateOfficeConversionTaskResponse>(DoRPCRequest("CreateOfficeConversionTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateOfficeConversionTaskResponse> CreateOfficeConversionTaskWithOptionsAsync(CreateOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateOfficeConversionTaskResponse>(await DoRPCRequestAsync("CreateOfficeConversionTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateOfficeConversionTaskResponse CreateOfficeConversionTask(CreateOfficeConversionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOfficeConversionTaskWithOptions(request, runtime);
        }

        public async Task<CreateOfficeConversionTaskResponse> CreateOfficeConversionTaskAsync(CreateOfficeConversionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOfficeConversionTaskWithOptionsAsync(request, runtime);
        }

        public CreateSetResponse CreateSetWithOptions(CreateSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSetResponse>(DoRPCRequest("CreateSet", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSetResponse> CreateSetWithOptionsAsync(CreateSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSetResponse>(await DoRPCRequestAsync("CreateSet", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSetResponse CreateSet(CreateSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSetWithOptions(request, runtime);
        }

        public async Task<CreateSetResponse> CreateSetAsync(CreateSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSetWithOptionsAsync(request, runtime);
        }

        public CreateVideoAbstractTaskResponse CreateVideoAbstractTaskWithOptions(CreateVideoAbstractTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVideoAbstractTaskResponse>(DoRPCRequest("CreateVideoAbstractTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVideoAbstractTaskResponse> CreateVideoAbstractTaskWithOptionsAsync(CreateVideoAbstractTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVideoAbstractTaskResponse>(await DoRPCRequestAsync("CreateVideoAbstractTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVideoAbstractTaskResponse CreateVideoAbstractTask(CreateVideoAbstractTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVideoAbstractTaskWithOptions(request, runtime);
        }

        public async Task<CreateVideoAbstractTaskResponse> CreateVideoAbstractTaskAsync(CreateVideoAbstractTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVideoAbstractTaskWithOptionsAsync(request, runtime);
        }

        public CreateVideoAnalyseTaskResponse CreateVideoAnalyseTaskWithOptions(CreateVideoAnalyseTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVideoAnalyseTaskResponse>(DoRPCRequest("CreateVideoAnalyseTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVideoAnalyseTaskResponse> CreateVideoAnalyseTaskWithOptionsAsync(CreateVideoAnalyseTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVideoAnalyseTaskResponse>(await DoRPCRequestAsync("CreateVideoAnalyseTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVideoAnalyseTaskResponse CreateVideoAnalyseTask(CreateVideoAnalyseTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVideoAnalyseTaskWithOptions(request, runtime);
        }

        public async Task<CreateVideoAnalyseTaskResponse> CreateVideoAnalyseTaskAsync(CreateVideoAnalyseTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVideoAnalyseTaskWithOptionsAsync(request, runtime);
        }

        public CreateVideoCompressTaskResponse CreateVideoCompressTaskWithOptions(CreateVideoCompressTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVideoCompressTaskResponse>(DoRPCRequest("CreateVideoCompressTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVideoCompressTaskResponse> CreateVideoCompressTaskWithOptionsAsync(CreateVideoCompressTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVideoCompressTaskResponse>(await DoRPCRequestAsync("CreateVideoCompressTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVideoCompressTaskResponse CreateVideoCompressTask(CreateVideoCompressTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVideoCompressTaskWithOptions(request, runtime);
        }

        public async Task<CreateVideoCompressTaskResponse> CreateVideoCompressTaskAsync(CreateVideoCompressTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVideoCompressTaskWithOptionsAsync(request, runtime);
        }

        public CreateVideoProduceTaskResponse CreateVideoProduceTaskWithOptions(CreateVideoProduceTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVideoProduceTaskResponse>(DoRPCRequest("CreateVideoProduceTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVideoProduceTaskResponse> CreateVideoProduceTaskWithOptionsAsync(CreateVideoProduceTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVideoProduceTaskResponse>(await DoRPCRequestAsync("CreateVideoProduceTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVideoProduceTaskResponse CreateVideoProduceTask(CreateVideoProduceTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVideoProduceTaskWithOptions(request, runtime);
        }

        public async Task<CreateVideoProduceTaskResponse> CreateVideoProduceTaskAsync(CreateVideoProduceTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVideoProduceTaskWithOptionsAsync(request, runtime);
        }

        public DecodeBlindWatermarkResponse DecodeBlindWatermarkWithOptions(DecodeBlindWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DecodeBlindWatermarkResponse>(DoRPCRequest("DecodeBlindWatermark", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DecodeBlindWatermarkResponse> DecodeBlindWatermarkWithOptionsAsync(DecodeBlindWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DecodeBlindWatermarkResponse>(await DoRPCRequestAsync("DecodeBlindWatermark", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DecodeBlindWatermarkResponse DecodeBlindWatermark(DecodeBlindWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DecodeBlindWatermarkWithOptions(request, runtime);
        }

        public async Task<DecodeBlindWatermarkResponse> DecodeBlindWatermarkAsync(DecodeBlindWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DecodeBlindWatermarkWithOptionsAsync(request, runtime);
        }

        public DeleteImageResponse DeleteImageWithOptions(DeleteImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteImageResponse>(DoRPCRequest("DeleteImage", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteImageResponse> DeleteImageWithOptionsAsync(DeleteImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteImageResponse>(await DoRPCRequestAsync("DeleteImage", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteImageResponse DeleteImage(DeleteImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteImageWithOptions(request, runtime);
        }

        public async Task<DeleteImageResponse> DeleteImageAsync(DeleteImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteImageWithOptionsAsync(request, runtime);
        }

        public DeleteImageJobResponse DeleteImageJobWithOptions(DeleteImageJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteImageJobResponse>(DoRPCRequest("DeleteImageJob", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteImageJobResponse> DeleteImageJobWithOptionsAsync(DeleteImageJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteImageJobResponse>(await DoRPCRequestAsync("DeleteImageJob", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteImageJobResponse DeleteImageJob(DeleteImageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteImageJobWithOptions(request, runtime);
        }

        public async Task<DeleteImageJobResponse> DeleteImageJobAsync(DeleteImageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteImageJobWithOptionsAsync(request, runtime);
        }

        public DeleteOfficeConversionTaskResponse DeleteOfficeConversionTaskWithOptions(DeleteOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteOfficeConversionTaskResponse>(DoRPCRequest("DeleteOfficeConversionTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteOfficeConversionTaskResponse> DeleteOfficeConversionTaskWithOptionsAsync(DeleteOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteOfficeConversionTaskResponse>(await DoRPCRequestAsync("DeleteOfficeConversionTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteOfficeConversionTaskResponse DeleteOfficeConversionTask(DeleteOfficeConversionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOfficeConversionTaskWithOptions(request, runtime);
        }

        public async Task<DeleteOfficeConversionTaskResponse> DeleteOfficeConversionTaskAsync(DeleteOfficeConversionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOfficeConversionTaskWithOptionsAsync(request, runtime);
        }

        public DeleteProjectResponse DeleteProjectWithOptions(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProjectResponse>(DoRPCRequest("DeleteProject", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteProjectResponse> DeleteProjectWithOptionsAsync(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProjectResponse>(await DoRPCRequestAsync("DeleteProject", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteSetResponse DeleteSetWithOptions(DeleteSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSetResponse>(DoRPCRequest("DeleteSet", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSetResponse> DeleteSetWithOptionsAsync(DeleteSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSetResponse>(await DoRPCRequestAsync("DeleteSet", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSetResponse DeleteSet(DeleteSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSetWithOptions(request, runtime);
        }

        public async Task<DeleteSetResponse> DeleteSetAsync(DeleteSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSetWithOptionsAsync(request, runtime);
        }

        public DeleteVideoResponse DeleteVideoWithOptions(DeleteVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVideoResponse>(DoRPCRequest("DeleteVideo", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVideoResponse> DeleteVideoWithOptionsAsync(DeleteVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVideoResponse>(await DoRPCRequestAsync("DeleteVideo", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVideoResponse DeleteVideo(DeleteVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVideoWithOptions(request, runtime);
        }

        public async Task<DeleteVideoResponse> DeleteVideoAsync(DeleteVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVideoWithOptionsAsync(request, runtime);
        }

        public DeleteVideoTaskResponse DeleteVideoTaskWithOptions(DeleteVideoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVideoTaskResponse>(DoRPCRequest("DeleteVideoTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVideoTaskResponse> DeleteVideoTaskWithOptionsAsync(DeleteVideoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVideoTaskResponse>(await DoRPCRequestAsync("DeleteVideoTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVideoTaskResponse DeleteVideoTask(DeleteVideoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVideoTaskWithOptions(request, runtime);
        }

        public async Task<DeleteVideoTaskResponse> DeleteVideoTaskAsync(DeleteVideoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVideoTaskWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DetectImageBodiesResponse DetectImageBodiesWithOptions(DetectImageBodiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectImageBodiesResponse>(DoRPCRequest("DetectImageBodies", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetectImageBodiesResponse> DetectImageBodiesWithOptionsAsync(DetectImageBodiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectImageBodiesResponse>(await DoRPCRequestAsync("DetectImageBodies", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetectImageBodiesResponse DetectImageBodies(DetectImageBodiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageBodiesWithOptions(request, runtime);
        }

        public async Task<DetectImageBodiesResponse> DetectImageBodiesAsync(DetectImageBodiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageBodiesWithOptionsAsync(request, runtime);
        }

        public DetectImageFacesResponse DetectImageFacesWithOptions(DetectImageFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectImageFacesResponse>(DoRPCRequest("DetectImageFaces", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetectImageFacesResponse> DetectImageFacesWithOptionsAsync(DetectImageFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectImageFacesResponse>(await DoRPCRequestAsync("DetectImageFaces", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetectImageFacesResponse DetectImageFaces(DetectImageFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageFacesWithOptions(request, runtime);
        }

        public async Task<DetectImageFacesResponse> DetectImageFacesAsync(DetectImageFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageFacesWithOptionsAsync(request, runtime);
        }

        public DetectImageQRCodesResponse DetectImageQRCodesWithOptions(DetectImageQRCodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectImageQRCodesResponse>(DoRPCRequest("DetectImageQRCodes", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetectImageQRCodesResponse> DetectImageQRCodesWithOptionsAsync(DetectImageQRCodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectImageQRCodesResponse>(await DoRPCRequestAsync("DetectImageQRCodes", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetectImageQRCodesResponse DetectImageQRCodes(DetectImageQRCodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageQRCodesWithOptions(request, runtime);
        }

        public async Task<DetectImageQRCodesResponse> DetectImageQRCodesAsync(DetectImageQRCodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageQRCodesWithOptionsAsync(request, runtime);
        }

        public DetectImageTagsResponse DetectImageTagsWithOptions(DetectImageTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectImageTagsResponse>(DoRPCRequest("DetectImageTags", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetectImageTagsResponse> DetectImageTagsWithOptionsAsync(DetectImageTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectImageTagsResponse>(await DoRPCRequestAsync("DetectImageTags", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetectImageTagsResponse DetectImageTags(DetectImageTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageTagsWithOptions(request, runtime);
        }

        public async Task<DetectImageTagsResponse> DetectImageTagsAsync(DetectImageTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageTagsWithOptionsAsync(request, runtime);
        }

        public DetectQRCodesResponse DetectQRCodesWithOptions(DetectQRCodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectQRCodesResponse>(DoRPCRequest("DetectQRCodes", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetectQRCodesResponse> DetectQRCodesWithOptionsAsync(DetectQRCodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectQRCodesResponse>(await DoRPCRequestAsync("DetectQRCodes", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetectQRCodesResponse DetectQRCodes(DetectQRCodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectQRCodesWithOptions(request, runtime);
        }

        public async Task<DetectQRCodesResponse> DetectQRCodesAsync(DetectQRCodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectQRCodesWithOptionsAsync(request, runtime);
        }

        public EncodeBlindWatermarkResponse EncodeBlindWatermarkWithOptions(EncodeBlindWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EncodeBlindWatermarkResponse>(DoRPCRequest("EncodeBlindWatermark", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EncodeBlindWatermarkResponse> EncodeBlindWatermarkWithOptionsAsync(EncodeBlindWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EncodeBlindWatermarkResponse>(await DoRPCRequestAsync("EncodeBlindWatermark", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EncodeBlindWatermarkResponse EncodeBlindWatermark(EncodeBlindWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EncodeBlindWatermarkWithOptions(request, runtime);
        }

        public async Task<EncodeBlindWatermarkResponse> EncodeBlindWatermarkAsync(EncodeBlindWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EncodeBlindWatermarkWithOptionsAsync(request, runtime);
        }

        public FindImagesResponse FindImagesWithOptions(FindImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindImagesResponse>(DoRPCRequest("FindImages", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FindImagesResponse> FindImagesWithOptionsAsync(FindImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindImagesResponse>(await DoRPCRequestAsync("FindImages", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FindImagesResponse FindImages(FindImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindImagesWithOptions(request, runtime);
        }

        public async Task<FindImagesResponse> FindImagesAsync(FindImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindImagesWithOptionsAsync(request, runtime);
        }

        public FindSimilarFacesResponse FindSimilarFacesWithOptions(FindSimilarFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindSimilarFacesResponse>(DoRPCRequest("FindSimilarFaces", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FindSimilarFacesResponse> FindSimilarFacesWithOptionsAsync(FindSimilarFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FindSimilarFacesResponse>(await DoRPCRequestAsync("FindSimilarFaces", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FindSimilarFacesResponse FindSimilarFaces(FindSimilarFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindSimilarFacesWithOptions(request, runtime);
        }

        public async Task<FindSimilarFacesResponse> FindSimilarFacesAsync(FindSimilarFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindSimilarFacesWithOptionsAsync(request, runtime);
        }

        public GetContentKeyResponse GetContentKeyWithOptions(GetContentKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetContentKeyResponse>(DoRPCRequest("GetContentKey", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetContentKeyResponse> GetContentKeyWithOptionsAsync(GetContentKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetContentKeyResponse>(await DoRPCRequestAsync("GetContentKey", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetContentKeyResponse GetContentKey(GetContentKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetContentKeyWithOptions(request, runtime);
        }

        public async Task<GetContentKeyResponse> GetContentKeyAsync(GetContentKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetContentKeyWithOptionsAsync(request, runtime);
        }

        public GetDRMLicenseResponse GetDRMLicenseWithOptions(GetDRMLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDRMLicenseResponse>(DoRPCRequest("GetDRMLicense", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDRMLicenseResponse> GetDRMLicenseWithOptionsAsync(GetDRMLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDRMLicenseResponse>(await DoRPCRequestAsync("GetDRMLicense", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDRMLicenseResponse GetDRMLicense(GetDRMLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDRMLicenseWithOptions(request, runtime);
        }

        public async Task<GetDRMLicenseResponse> GetDRMLicenseAsync(GetDRMLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDRMLicenseWithOptionsAsync(request, runtime);
        }

        public GetImageResponse GetImageWithOptions(GetImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetImageResponse>(DoRPCRequest("GetImage", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetImageResponse> GetImageWithOptionsAsync(GetImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetImageResponse>(await DoRPCRequestAsync("GetImage", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetImageResponse GetImage(GetImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageWithOptions(request, runtime);
        }

        public async Task<GetImageResponse> GetImageAsync(GetImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageWithOptionsAsync(request, runtime);
        }

        public GetImageCroppingSuggestionsResponse GetImageCroppingSuggestionsWithOptions(GetImageCroppingSuggestionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetImageCroppingSuggestionsResponse>(DoRPCRequest("GetImageCroppingSuggestions", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetImageCroppingSuggestionsResponse> GetImageCroppingSuggestionsWithOptionsAsync(GetImageCroppingSuggestionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetImageCroppingSuggestionsResponse>(await DoRPCRequestAsync("GetImageCroppingSuggestions", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetImageCroppingSuggestionsResponse GetImageCroppingSuggestions(GetImageCroppingSuggestionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageCroppingSuggestionsWithOptions(request, runtime);
        }

        public async Task<GetImageCroppingSuggestionsResponse> GetImageCroppingSuggestionsAsync(GetImageCroppingSuggestionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageCroppingSuggestionsWithOptionsAsync(request, runtime);
        }

        public GetImageQualityResponse GetImageQualityWithOptions(GetImageQualityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetImageQualityResponse>(DoRPCRequest("GetImageQuality", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetImageQualityResponse> GetImageQualityWithOptionsAsync(GetImageQualityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetImageQualityResponse>(await DoRPCRequestAsync("GetImageQuality", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetImageQualityResponse GetImageQuality(GetImageQualityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageQualityWithOptions(request, runtime);
        }

        public async Task<GetImageQualityResponse> GetImageQualityAsync(GetImageQualityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageQualityWithOptionsAsync(request, runtime);
        }

        public GetMediaMetaResponse GetMediaMetaWithOptions(GetMediaMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMediaMetaResponse>(DoRPCRequest("GetMediaMeta", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMediaMetaResponse> GetMediaMetaWithOptionsAsync(GetMediaMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMediaMetaResponse>(await DoRPCRequestAsync("GetMediaMeta", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMediaMetaResponse GetMediaMeta(GetMediaMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaMetaWithOptions(request, runtime);
        }

        public async Task<GetMediaMetaResponse> GetMediaMetaAsync(GetMediaMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaMetaWithOptionsAsync(request, runtime);
        }

        public GetOfficeConversionTaskResponse GetOfficeConversionTaskWithOptions(GetOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOfficeConversionTaskResponse>(DoRPCRequest("GetOfficeConversionTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetOfficeConversionTaskResponse> GetOfficeConversionTaskWithOptionsAsync(GetOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOfficeConversionTaskResponse>(await DoRPCRequestAsync("GetOfficeConversionTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetOfficeConversionTaskResponse GetOfficeConversionTask(GetOfficeConversionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOfficeConversionTaskWithOptions(request, runtime);
        }

        public async Task<GetOfficeConversionTaskResponse> GetOfficeConversionTaskAsync(GetOfficeConversionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOfficeConversionTaskWithOptionsAsync(request, runtime);
        }

        public GetOfficeEditURLResponse GetOfficeEditURLWithOptions(GetOfficeEditURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOfficeEditURLResponse>(DoRPCRequest("GetOfficeEditURL", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetOfficeEditURLResponse> GetOfficeEditURLWithOptionsAsync(GetOfficeEditURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOfficeEditURLResponse>(await DoRPCRequestAsync("GetOfficeEditURL", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetOfficeEditURLResponse GetOfficeEditURL(GetOfficeEditURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOfficeEditURLWithOptions(request, runtime);
        }

        public async Task<GetOfficeEditURLResponse> GetOfficeEditURLAsync(GetOfficeEditURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOfficeEditURLWithOptionsAsync(request, runtime);
        }

        public GetOfficePreviewURLResponse GetOfficePreviewURLWithOptions(GetOfficePreviewURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOfficePreviewURLResponse>(DoRPCRequest("GetOfficePreviewURL", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetOfficePreviewURLResponse> GetOfficePreviewURLWithOptionsAsync(GetOfficePreviewURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOfficePreviewURLResponse>(await DoRPCRequestAsync("GetOfficePreviewURL", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetOfficePreviewURLResponse GetOfficePreviewURL(GetOfficePreviewURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOfficePreviewURLWithOptions(request, runtime);
        }

        public async Task<GetOfficePreviewURLResponse> GetOfficePreviewURLAsync(GetOfficePreviewURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOfficePreviewURLWithOptionsAsync(request, runtime);
        }

        public GetProjectResponse GetProjectWithOptions(GetProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProjectResponse>(DoRPCRequest("GetProject", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetProjectResponse> GetProjectWithOptionsAsync(GetProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProjectResponse>(await DoRPCRequestAsync("GetProject", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetSetResponse GetSetWithOptions(GetSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSetResponse>(DoRPCRequest("GetSet", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSetResponse> GetSetWithOptionsAsync(GetSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSetResponse>(await DoRPCRequestAsync("GetSet", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSetResponse GetSet(GetSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSetWithOptions(request, runtime);
        }

        public async Task<GetSetResponse> GetSetAsync(GetSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSetWithOptionsAsync(request, runtime);
        }

        public GetVideoResponse GetVideoWithOptions(GetVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetVideoResponse>(DoRPCRequest("GetVideo", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetVideoResponse> GetVideoWithOptionsAsync(GetVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetVideoResponse>(await DoRPCRequestAsync("GetVideo", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetVideoResponse GetVideo(GetVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoWithOptions(request, runtime);
        }

        public async Task<GetVideoResponse> GetVideoAsync(GetVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoWithOptionsAsync(request, runtime);
        }

        public GetVideoTaskResponse GetVideoTaskWithOptions(GetVideoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetVideoTaskResponse>(DoRPCRequest("GetVideoTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetVideoTaskResponse> GetVideoTaskWithOptionsAsync(GetVideoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetVideoTaskResponse>(await DoRPCRequestAsync("GetVideoTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetVideoTaskResponse GetVideoTask(GetVideoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoTaskWithOptions(request, runtime);
        }

        public async Task<GetVideoTaskResponse> GetVideoTaskAsync(GetVideoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoTaskWithOptionsAsync(request, runtime);
        }

        public GetWebofficeURLResponse GetWebofficeURLWithOptions(GetWebofficeURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetWebofficeURLResponse>(DoRPCRequest("GetWebofficeURL", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetWebofficeURLResponse> GetWebofficeURLWithOptionsAsync(GetWebofficeURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetWebofficeURLResponse>(await DoRPCRequestAsync("GetWebofficeURL", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetWebofficeURLResponse GetWebofficeURL(GetWebofficeURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWebofficeURLWithOptions(request, runtime);
        }

        public async Task<GetWebofficeURLResponse> GetWebofficeURLAsync(GetWebofficeURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWebofficeURLWithOptionsAsync(request, runtime);
        }

        public IndexImageResponse IndexImageWithOptions(IndexImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<IndexImageResponse>(DoRPCRequest("IndexImage", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<IndexImageResponse> IndexImageWithOptionsAsync(IndexImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<IndexImageResponse>(await DoRPCRequestAsync("IndexImage", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public IndexImageResponse IndexImage(IndexImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IndexImageWithOptions(request, runtime);
        }

        public async Task<IndexImageResponse> IndexImageAsync(IndexImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IndexImageWithOptionsAsync(request, runtime);
        }

        public IndexVideoResponse IndexVideoWithOptions(IndexVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<IndexVideoResponse>(DoRPCRequest("IndexVideo", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<IndexVideoResponse> IndexVideoWithOptionsAsync(IndexVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<IndexVideoResponse>(await DoRPCRequestAsync("IndexVideo", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public IndexVideoResponse IndexVideo(IndexVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IndexVideoWithOptions(request, runtime);
        }

        public async Task<IndexVideoResponse> IndexVideoAsync(IndexVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IndexVideoWithOptionsAsync(request, runtime);
        }

        public ListFaceGroupsResponse ListFaceGroupsWithOptions(ListFaceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFaceGroupsResponse>(DoRPCRequest("ListFaceGroups", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFaceGroupsResponse> ListFaceGroupsWithOptionsAsync(ListFaceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFaceGroupsResponse>(await DoRPCRequestAsync("ListFaceGroups", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListImagesResponse ListImagesWithOptions(ListImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListImagesResponse>(DoRPCRequest("ListImages", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListImagesResponse> ListImagesWithOptionsAsync(ListImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListImagesResponse>(await DoRPCRequestAsync("ListImages", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListImagesResponse ListImages(ListImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListImagesWithOptions(request, runtime);
        }

        public async Task<ListImagesResponse> ListImagesAsync(ListImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListImagesWithOptionsAsync(request, runtime);
        }

        public ListOfficeConversionTaskResponse ListOfficeConversionTaskWithOptions(ListOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOfficeConversionTaskResponse>(DoRPCRequest("ListOfficeConversionTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOfficeConversionTaskResponse> ListOfficeConversionTaskWithOptionsAsync(ListOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOfficeConversionTaskResponse>(await DoRPCRequestAsync("ListOfficeConversionTask", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOfficeConversionTaskResponse ListOfficeConversionTask(ListOfficeConversionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOfficeConversionTaskWithOptions(request, runtime);
        }

        public async Task<ListOfficeConversionTaskResponse> ListOfficeConversionTaskAsync(ListOfficeConversionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOfficeConversionTaskWithOptionsAsync(request, runtime);
        }

        public ListProjectAPIsResponse ListProjectAPIsWithOptions(ListProjectAPIsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectAPIsResponse>(DoRPCRequest("ListProjectAPIs", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListProjectAPIsResponse> ListProjectAPIsWithOptionsAsync(ListProjectAPIsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectAPIsResponse>(await DoRPCRequestAsync("ListProjectAPIs", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListProjectAPIsResponse ListProjectAPIs(ListProjectAPIsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectAPIsWithOptions(request, runtime);
        }

        public async Task<ListProjectAPIsResponse> ListProjectAPIsAsync(ListProjectAPIsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectAPIsWithOptionsAsync(request, runtime);
        }

        public ListProjectsResponse ListProjectsWithOptions(ListProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectsResponse>(DoRPCRequest("ListProjects", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListProjectsResponse> ListProjectsWithOptionsAsync(ListProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectsResponse>(await DoRPCRequestAsync("ListProjects", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListSetTagsResponse ListSetTagsWithOptions(ListSetTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSetTagsResponse>(DoRPCRequest("ListSetTags", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSetTagsResponse> ListSetTagsWithOptionsAsync(ListSetTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSetTagsResponse>(await DoRPCRequestAsync("ListSetTags", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSetTagsResponse ListSetTags(ListSetTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSetTagsWithOptions(request, runtime);
        }

        public async Task<ListSetTagsResponse> ListSetTagsAsync(ListSetTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSetTagsWithOptionsAsync(request, runtime);
        }

        public ListSetsResponse ListSetsWithOptions(ListSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSetsResponse>(DoRPCRequest("ListSets", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSetsResponse> ListSetsWithOptionsAsync(ListSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSetsResponse>(await DoRPCRequestAsync("ListSets", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSetsResponse ListSets(ListSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSetsWithOptions(request, runtime);
        }

        public async Task<ListSetsResponse> ListSetsAsync(ListSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSetsWithOptionsAsync(request, runtime);
        }

        public ListVideoAudiosResponse ListVideoAudiosWithOptions(ListVideoAudiosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVideoAudiosResponse>(DoRPCRequest("ListVideoAudios", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListVideoAudiosResponse> ListVideoAudiosWithOptionsAsync(ListVideoAudiosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVideoAudiosResponse>(await DoRPCRequestAsync("ListVideoAudios", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListVideoAudiosResponse ListVideoAudios(ListVideoAudiosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVideoAudiosWithOptions(request, runtime);
        }

        public async Task<ListVideoAudiosResponse> ListVideoAudiosAsync(ListVideoAudiosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVideoAudiosWithOptionsAsync(request, runtime);
        }

        public ListVideoFramesResponse ListVideoFramesWithOptions(ListVideoFramesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVideoFramesResponse>(DoRPCRequest("ListVideoFrames", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListVideoFramesResponse> ListVideoFramesWithOptionsAsync(ListVideoFramesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVideoFramesResponse>(await DoRPCRequestAsync("ListVideoFrames", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListVideoFramesResponse ListVideoFrames(ListVideoFramesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVideoFramesWithOptions(request, runtime);
        }

        public async Task<ListVideoFramesResponse> ListVideoFramesAsync(ListVideoFramesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVideoFramesWithOptionsAsync(request, runtime);
        }

        public ListVideoTasksResponse ListVideoTasksWithOptions(ListVideoTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVideoTasksResponse>(DoRPCRequest("ListVideoTasks", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListVideoTasksResponse> ListVideoTasksWithOptionsAsync(ListVideoTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVideoTasksResponse>(await DoRPCRequestAsync("ListVideoTasks", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListVideoTasksResponse ListVideoTasks(ListVideoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVideoTasksWithOptions(request, runtime);
        }

        public async Task<ListVideoTasksResponse> ListVideoTasksAsync(ListVideoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVideoTasksWithOptionsAsync(request, runtime);
        }

        public ListVideosResponse ListVideosWithOptions(ListVideosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVideosResponse>(DoRPCRequest("ListVideos", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListVideosResponse> ListVideosWithOptionsAsync(ListVideosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVideosResponse>(await DoRPCRequestAsync("ListVideos", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListVideosResponse ListVideos(ListVideosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVideosWithOptions(request, runtime);
        }

        public async Task<ListVideosResponse> ListVideosAsync(ListVideosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVideosWithOptionsAsync(request, runtime);
        }

        public OpenImmServiceResponse OpenImmServiceWithOptions(OpenImmServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenImmServiceResponse>(DoRPCRequest("OpenImmService", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenImmServiceResponse> OpenImmServiceWithOptionsAsync(OpenImmServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenImmServiceResponse>(await DoRPCRequestAsync("OpenImmService", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpenImmServiceResponse OpenImmService(OpenImmServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenImmServiceWithOptions(request, runtime);
        }

        public async Task<OpenImmServiceResponse> OpenImmServiceAsync(OpenImmServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenImmServiceWithOptionsAsync(request, runtime);
        }

        public PutProjectResponse PutProjectWithOptions(PutProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutProjectResponse>(DoRPCRequest("PutProject", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutProjectResponse> PutProjectWithOptionsAsync(PutProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutProjectResponse>(await DoRPCRequestAsync("PutProject", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutProjectResponse PutProject(PutProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutProjectWithOptions(request, runtime);
        }

        public async Task<PutProjectResponse> PutProjectAsync(PutProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutProjectWithOptionsAsync(request, runtime);
        }

        public RefreshOfficeEditTokenResponse RefreshOfficeEditTokenWithOptions(RefreshOfficeEditTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshOfficeEditTokenResponse>(DoRPCRequest("RefreshOfficeEditToken", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RefreshOfficeEditTokenResponse> RefreshOfficeEditTokenWithOptionsAsync(RefreshOfficeEditTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshOfficeEditTokenResponse>(await DoRPCRequestAsync("RefreshOfficeEditToken", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RefreshOfficeEditTokenResponse RefreshOfficeEditToken(RefreshOfficeEditTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshOfficeEditTokenWithOptions(request, runtime);
        }

        public async Task<RefreshOfficeEditTokenResponse> RefreshOfficeEditTokenAsync(RefreshOfficeEditTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshOfficeEditTokenWithOptionsAsync(request, runtime);
        }

        public RefreshOfficePreviewTokenResponse RefreshOfficePreviewTokenWithOptions(RefreshOfficePreviewTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshOfficePreviewTokenResponse>(DoRPCRequest("RefreshOfficePreviewToken", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RefreshOfficePreviewTokenResponse> RefreshOfficePreviewTokenWithOptionsAsync(RefreshOfficePreviewTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshOfficePreviewTokenResponse>(await DoRPCRequestAsync("RefreshOfficePreviewToken", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RefreshOfficePreviewTokenResponse RefreshOfficePreviewToken(RefreshOfficePreviewTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshOfficePreviewTokenWithOptions(request, runtime);
        }

        public async Task<RefreshOfficePreviewTokenResponse> RefreshOfficePreviewTokenAsync(RefreshOfficePreviewTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshOfficePreviewTokenWithOptionsAsync(request, runtime);
        }

        public RefreshWebofficeTokenResponse RefreshWebofficeTokenWithOptions(RefreshWebofficeTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshWebofficeTokenResponse>(DoRPCRequest("RefreshWebofficeToken", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RefreshWebofficeTokenResponse> RefreshWebofficeTokenWithOptionsAsync(RefreshWebofficeTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshWebofficeTokenResponse>(await DoRPCRequestAsync("RefreshWebofficeToken", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RefreshWebofficeTokenResponse RefreshWebofficeToken(RefreshWebofficeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshWebofficeTokenWithOptions(request, runtime);
        }

        public async Task<RefreshWebofficeTokenResponse> RefreshWebofficeTokenAsync(RefreshWebofficeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshWebofficeTokenWithOptionsAsync(request, runtime);
        }

        public UpdateFaceGroupResponse UpdateFaceGroupWithOptions(UpdateFaceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFaceGroupResponse>(DoRPCRequest("UpdateFaceGroup", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateFaceGroupResponse> UpdateFaceGroupWithOptionsAsync(UpdateFaceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFaceGroupResponse>(await DoRPCRequestAsync("UpdateFaceGroup", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateFaceGroupResponse UpdateFaceGroup(UpdateFaceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFaceGroupWithOptions(request, runtime);
        }

        public async Task<UpdateFaceGroupResponse> UpdateFaceGroupAsync(UpdateFaceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFaceGroupWithOptionsAsync(request, runtime);
        }

        public UpdateImageResponse UpdateImageWithOptions(UpdateImageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateImageShrinkRequest request = new UpdateImageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Faces))
            {
                request.FacesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Faces, "Faces", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateImageResponse>(DoRPCRequest("UpdateImage", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateImageResponse> UpdateImageWithOptionsAsync(UpdateImageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateImageShrinkRequest request = new UpdateImageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Faces))
            {
                request.FacesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Faces, "Faces", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateImageResponse>(await DoRPCRequestAsync("UpdateImage", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateImageResponse UpdateImage(UpdateImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateImageWithOptions(request, runtime);
        }

        public async Task<UpdateImageResponse> UpdateImageAsync(UpdateImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateImageWithOptionsAsync(request, runtime);
        }

        public UpdateProjectResponse UpdateProjectWithOptions(UpdateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProjectResponse>(DoRPCRequest("UpdateProject", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateProjectResponse> UpdateProjectWithOptionsAsync(UpdateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProjectResponse>(await DoRPCRequestAsync("UpdateProject", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProjectWithOptions(request, runtime);
        }

        public async Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProjectWithOptionsAsync(request, runtime);
        }

        public UpdateSetResponse UpdateSetWithOptions(UpdateSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSetResponse>(DoRPCRequest("UpdateSet", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateSetResponse> UpdateSetWithOptionsAsync(UpdateSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSetResponse>(await DoRPCRequestAsync("UpdateSet", "2017-09-06", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateSetResponse UpdateSet(UpdateSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSetWithOptions(request, runtime);
        }

        public async Task<UpdateSetResponse> UpdateSetAsync(UpdateSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSetWithOptionsAsync(request, runtime);
        }

    }
}
