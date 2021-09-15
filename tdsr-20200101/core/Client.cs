// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Tdsr20200101.Models;

namespace AlibabaCloud.SDK.Tdsr20200101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hangzhou", "lyj.cn-hangzhou.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("tdsr", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public GetSingleConnDataResponse GetSingleConnDataWithOptions(GetSingleConnDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSingleConnDataResponse>(DoRPCRequest("GetSingleConnData", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSingleConnDataResponse> GetSingleConnDataWithOptionsAsync(GetSingleConnDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSingleConnDataResponse>(await DoRPCRequestAsync("GetSingleConnData", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSingleConnDataResponse GetSingleConnData(GetSingleConnDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSingleConnDataWithOptions(request, runtime);
        }

        public async Task<GetSingleConnDataResponse> GetSingleConnDataAsync(GetSingleConnDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSingleConnDataWithOptionsAsync(request, runtime);
        }

        public GetTaskStatusResponse GetTaskStatusWithOptions(GetTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTaskStatusResponse>(DoRPCRequest("GetTaskStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTaskStatusResponse> GetTaskStatusWithOptionsAsync(GetTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTaskStatusResponse>(await DoRPCRequestAsync("GetTaskStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public LinkImageResponse LinkImageWithOptions(LinkImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LinkImageResponse>(DoRPCRequest("LinkImage", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<LinkImageResponse> LinkImageWithOptionsAsync(LinkImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LinkImageResponse>(await DoRPCRequestAsync("LinkImage", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public LinkImageResponse LinkImage(LinkImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LinkImageWithOptions(request, runtime);
        }

        public async Task<LinkImageResponse> LinkImageAsync(LinkImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LinkImageWithOptionsAsync(request, runtime);
        }

        public AddSceneResponse AddSceneWithOptions(AddSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSceneResponse>(DoRPCRequest("AddScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddSceneResponse> AddSceneWithOptionsAsync(AddSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSceneResponse>(await DoRPCRequestAsync("AddScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddSceneResponse AddScene(AddSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSceneWithOptions(request, runtime);
        }

        public async Task<AddSceneResponse> AddSceneAsync(AddSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSceneWithOptionsAsync(request, runtime);
        }

        public UpdateConnDataResponse UpdateConnDataWithOptions(UpdateConnDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateConnDataResponse>(DoRPCRequest("UpdateConnData", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateConnDataResponse> UpdateConnDataWithOptionsAsync(UpdateConnDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateConnDataResponse>(await DoRPCRequestAsync("UpdateConnData", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateConnDataResponse UpdateConnData(UpdateConnDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateConnDataWithOptions(request, runtime);
        }

        public async Task<UpdateConnDataResponse> UpdateConnDataAsync(UpdateConnDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateConnDataWithOptionsAsync(request, runtime);
        }

        public RectifyImageResponse RectifyImageWithOptions(RectifyImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RectifyImageResponse>(DoRPCRequest("RectifyImage", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RectifyImageResponse> RectifyImageWithOptionsAsync(RectifyImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RectifyImageResponse>(await DoRPCRequestAsync("RectifyImage", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RectifyImageResponse RectifyImage(RectifyImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RectifyImageWithOptions(request, runtime);
        }

        public async Task<RectifyImageResponse> RectifyImageAsync(RectifyImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RectifyImageWithOptionsAsync(request, runtime);
        }

        public LabelBuildResponse LabelBuildWithOptions(LabelBuildRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LabelBuildResponse>(DoRPCRequest("LabelBuild", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<LabelBuildResponse> LabelBuildWithOptionsAsync(LabelBuildRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LabelBuildResponse>(await DoRPCRequestAsync("LabelBuild", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public LabelBuildResponse LabelBuild(LabelBuildRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LabelBuildWithOptions(request, runtime);
        }

        public async Task<LabelBuildResponse> LabelBuildAsync(LabelBuildRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LabelBuildWithOptionsAsync(request, runtime);
        }

        public DropSceneResponse DropSceneWithOptions(DropSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DropSceneResponse>(DoRPCRequest("DropScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DropSceneResponse> DropSceneWithOptionsAsync(DropSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DropSceneResponse>(await DoRPCRequestAsync("DropScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DropSceneResponse DropScene(DropSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DropSceneWithOptions(request, runtime);
        }

        public async Task<DropSceneResponse> DropSceneAsync(DropSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DropSceneWithOptionsAsync(request, runtime);
        }

        public OptimizeRightAngleResponse OptimizeRightAngleWithOptions(OptimizeRightAngleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OptimizeRightAngleResponse>(DoRPCRequest("OptimizeRightAngle", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OptimizeRightAngleResponse> OptimizeRightAngleWithOptionsAsync(OptimizeRightAngleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OptimizeRightAngleResponse>(await DoRPCRequestAsync("OptimizeRightAngle", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OptimizeRightAngleResponse OptimizeRightAngle(OptimizeRightAngleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OptimizeRightAngleWithOptions(request, runtime);
        }

        public async Task<OptimizeRightAngleResponse> OptimizeRightAngleAsync(OptimizeRightAngleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OptimizeRightAngleWithOptionsAsync(request, runtime);
        }

        public AddRelativePositionResponse AddRelativePositionWithOptions(AddRelativePositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddRelativePositionResponse>(DoRPCRequest("AddRelativePosition", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddRelativePositionResponse> AddRelativePositionWithOptionsAsync(AddRelativePositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddRelativePositionResponse>(await DoRPCRequestAsync("AddRelativePosition", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddRelativePositionResponse AddRelativePosition(AddRelativePositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddRelativePositionWithOptions(request, runtime);
        }

        public async Task<AddRelativePositionResponse> AddRelativePositionAsync(AddRelativePositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddRelativePositionWithOptionsAsync(request, runtime);
        }

        public DetailSceneResponse DetailSceneWithOptions(DetailSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetailSceneResponse>(DoRPCRequest("DetailScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetailSceneResponse> DetailSceneWithOptionsAsync(DetailSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetailSceneResponse>(await DoRPCRequestAsync("DetailScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetailSceneResponse DetailScene(DetailSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetailSceneWithOptions(request, runtime);
        }

        public async Task<DetailSceneResponse> DetailSceneAsync(DetailSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetailSceneWithOptionsAsync(request, runtime);
        }

        public CreateSceneResponse CreateSceneWithOptions(CreateSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSceneResponse>(DoRPCRequest("CreateScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSceneResponse> CreateSceneWithOptionsAsync(CreateSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSceneResponse>(await DoRPCRequestAsync("CreateScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSceneResponse CreateScene(CreateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSceneWithOptions(request, runtime);
        }

        public async Task<CreateSceneResponse> CreateSceneAsync(CreateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSceneWithOptionsAsync(request, runtime);
        }

        public DeleteFileResponse DeleteFileWithOptions(DeleteFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFileResponse>(DoRPCRequest("DeleteFile", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFileResponse> DeleteFileWithOptionsAsync(DeleteFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFileResponse>(await DoRPCRequestAsync("DeleteFile", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CheckResourceResponse CheckResourceWithOptions(CheckResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckResourceResponse>(DoRPCRequest("CheckResource", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckResourceResponse> CheckResourceWithOptionsAsync(CheckResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckResourceResponse>(await DoRPCRequestAsync("CheckResource", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckResourceResponse CheckResource(CheckResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckResourceWithOptions(request, runtime);
        }

        public async Task<CheckResourceResponse> CheckResourceAsync(CheckResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckResourceWithOptionsAsync(request, runtime);
        }

        public ListSceneResponse ListSceneWithOptions(ListSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSceneResponse>(DoRPCRequest("ListScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSceneResponse> ListSceneWithOptionsAsync(ListSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSceneResponse>(await DoRPCRequestAsync("ListScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSceneResponse ListScene(ListSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSceneWithOptions(request, runtime);
        }

        public async Task<ListSceneResponse> ListSceneAsync(ListSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSceneWithOptionsAsync(request, runtime);
        }

        public PublishHotspotResponse PublishHotspotWithOptions(PublishHotspotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishHotspotResponse>(DoRPCRequest("PublishHotspot", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PublishHotspotResponse> PublishHotspotWithOptionsAsync(PublishHotspotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishHotspotResponse>(await DoRPCRequestAsync("PublishHotspot", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PublishHotspotResponse PublishHotspot(PublishHotspotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishHotspotWithOptions(request, runtime);
        }

        public async Task<PublishHotspotResponse> PublishHotspotAsync(PublishHotspotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishHotspotWithOptionsAsync(request, runtime);
        }

        public UpdateSceneResponse UpdateSceneWithOptions(UpdateSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSceneResponse>(DoRPCRequest("UpdateScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateSceneResponse> UpdateSceneWithOptionsAsync(UpdateSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSceneResponse>(await DoRPCRequestAsync("UpdateScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateSceneResponse UpdateScene(UpdateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSceneWithOptions(request, runtime);
        }

        public async Task<UpdateSceneResponse> UpdateSceneAsync(UpdateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSceneWithOptionsAsync(request, runtime);
        }

        public UpdateLayoutDataResponse UpdateLayoutDataWithOptions(UpdateLayoutDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLayoutDataResponse>(DoRPCRequest("UpdateLayoutData", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateLayoutDataResponse> UpdateLayoutDataWithOptionsAsync(UpdateLayoutDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLayoutDataResponse>(await DoRPCRequestAsync("UpdateLayoutData", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateLayoutDataResponse UpdateLayoutData(UpdateLayoutDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLayoutDataWithOptions(request, runtime);
        }

        public async Task<UpdateLayoutDataResponse> UpdateLayoutDataAsync(UpdateLayoutDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLayoutDataWithOptionsAsync(request, runtime);
        }

        public SaveHotspotTagResponse SaveHotspotTagWithOptions(SaveHotspotTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveHotspotTagResponse>(DoRPCRequest("SaveHotspotTag", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveHotspotTagResponse> SaveHotspotTagWithOptionsAsync(SaveHotspotTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveHotspotTagResponse>(await DoRPCRequestAsync("SaveHotspotTag", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveHotspotTagResponse SaveHotspotTag(SaveHotspotTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveHotspotTagWithOptions(request, runtime);
        }

        public async Task<SaveHotspotTagResponse> SaveHotspotTagAsync(SaveHotspotTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveHotspotTagWithOptionsAsync(request, runtime);
        }

        public DeleteProjectResponse DeleteProjectWithOptions(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProjectResponse>(DoRPCRequest("DeleteProject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteProjectResponse> DeleteProjectWithOptionsAsync(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProjectResponse>(await DoRPCRequestAsync("DeleteProject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public RectVerticalResponse RectVerticalWithOptions(RectVerticalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RectVerticalResponse>(DoRPCRequest("RectVertical", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RectVerticalResponse> RectVerticalWithOptionsAsync(RectVerticalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RectVerticalResponse>(await DoRPCRequestAsync("RectVertical", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RectVerticalResponse RectVertical(RectVerticalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RectVerticalWithOptions(request, runtime);
        }

        public async Task<RectVerticalResponse> RectVerticalAsync(RectVerticalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RectVerticalWithOptionsAsync(request, runtime);
        }

        public PredImageResponse PredImageWithOptions(PredImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PredImageResponse>(DoRPCRequest("PredImage", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PredImageResponse> PredImageWithOptionsAsync(PredImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PredImageResponse>(await DoRPCRequestAsync("PredImage", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PredImageResponse PredImage(PredImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PredImageWithOptions(request, runtime);
        }

        public async Task<PredImageResponse> PredImageAsync(PredImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PredImageWithOptionsAsync(request, runtime);
        }

        public GetOssPolicyResponse GetOssPolicyWithOptions(GetOssPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOssPolicyResponse>(DoRPCRequest("GetOssPolicy", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetOssPolicyResponse> GetOssPolicyWithOptionsAsync(GetOssPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOssPolicyResponse>(await DoRPCRequestAsync("GetOssPolicy", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetOssPolicyResponse GetOssPolicy(GetOssPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOssPolicyWithOptions(request, runtime);
        }

        public async Task<GetOssPolicyResponse> GetOssPolicyAsync(GetOssPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOssPolicyWithOptionsAsync(request, runtime);
        }

        public GetConnDataResponse GetConnDataWithOptions(GetConnDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetConnDataResponse>(DoRPCRequest("GetConnData", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetConnDataResponse> GetConnDataWithOptionsAsync(GetConnDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetConnDataResponse>(await DoRPCRequestAsync("GetConnData", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetConnDataResponse GetConnData(GetConnDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConnDataWithOptions(request, runtime);
        }

        public async Task<GetConnDataResponse> GetConnDataAsync(GetConnDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConnDataWithOptionsAsync(request, runtime);
        }

        public TempPreviewStatusResponse TempPreviewStatusWithOptions(TempPreviewStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TempPreviewStatusResponse>(DoRPCRequest("TempPreviewStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TempPreviewStatusResponse> TempPreviewStatusWithOptionsAsync(TempPreviewStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TempPreviewStatusResponse>(await DoRPCRequestAsync("TempPreviewStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TempPreviewStatusResponse TempPreviewStatus(TempPreviewStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TempPreviewStatusWithOptions(request, runtime);
        }

        public async Task<TempPreviewStatusResponse> TempPreviewStatusAsync(TempPreviewStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TempPreviewStatusWithOptionsAsync(request, runtime);
        }

        public AddProjectResponse AddProjectWithOptions(AddProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddProjectResponse>(DoRPCRequest("AddProject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddProjectResponse> AddProjectWithOptionsAsync(AddProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddProjectResponse>(await DoRPCRequestAsync("AddProject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddProjectResponse AddProject(AddProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddProjectWithOptions(request, runtime);
        }

        public async Task<AddProjectResponse> AddProjectAsync(AddProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddProjectWithOptionsAsync(request, runtime);
        }

        public DetailSubSceneResponse DetailSubSceneWithOptions(DetailSubSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetailSubSceneResponse>(DoRPCRequest("DetailSubScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetailSubSceneResponse> DetailSubSceneWithOptionsAsync(DetailSubSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetailSubSceneResponse>(await DoRPCRequestAsync("DetailSubScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetailSubSceneResponse DetailSubScene(DetailSubSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetailSubSceneWithOptions(request, runtime);
        }

        public async Task<DetailSubSceneResponse> DetailSubSceneAsync(DetailSubSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetailSubSceneWithOptionsAsync(request, runtime);
        }

        public ListSubSceneResponse ListSubSceneWithOptions(ListSubSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSubSceneResponse>(DoRPCRequest("ListSubScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSubSceneResponse> ListSubSceneWithOptionsAsync(ListSubSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSubSceneResponse>(await DoRPCRequestAsync("ListSubScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSubSceneResponse ListSubScene(ListSubSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSubSceneWithOptions(request, runtime);
        }

        public async Task<ListSubSceneResponse> ListSubSceneAsync(ListSubSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSubSceneWithOptionsAsync(request, runtime);
        }

        public UpdateSubSceneResponse UpdateSubSceneWithOptions(UpdateSubSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSubSceneResponse>(DoRPCRequest("UpdateSubScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateSubSceneResponse> UpdateSubSceneWithOptionsAsync(UpdateSubSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSubSceneResponse>(await DoRPCRequestAsync("UpdateSubScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateSubSceneResponse UpdateSubScene(UpdateSubSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSubSceneWithOptions(request, runtime);
        }

        public async Task<UpdateSubSceneResponse> UpdateSubSceneAsync(UpdateSubSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSubSceneWithOptionsAsync(request, runtime);
        }

        public GetJobResponse GetJobWithOptions(GetJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobResponse>(DoRPCRequest("GetJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetJobResponse> GetJobWithOptionsAsync(GetJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobResponse>(await DoRPCRequestAsync("GetJob", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetJobResponse GetJob(GetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobWithOptions(request, runtime);
        }

        public async Task<GetJobResponse> GetJobAsync(GetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobWithOptionsAsync(request, runtime);
        }

        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectResponse>(DoRPCRequest("CreateProject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectResponse>(await DoRPCRequestAsync("CreateProject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SaveHotspotConfigResponse SaveHotspotConfigWithOptions(SaveHotspotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveHotspotConfigResponse>(DoRPCRequest("SaveHotspotConfig", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveHotspotConfigResponse> SaveHotspotConfigWithOptionsAsync(SaveHotspotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveHotspotConfigResponse>(await DoRPCRequestAsync("SaveHotspotConfig", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveHotspotConfigResponse SaveHotspotConfig(SaveHotspotConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveHotspotConfigWithOptions(request, runtime);
        }

        public async Task<SaveHotspotConfigResponse> SaveHotspotConfigAsync(SaveHotspotConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveHotspotConfigWithOptionsAsync(request, runtime);
        }

        public GetWindowConfigResponse GetWindowConfigWithOptions(GetWindowConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetWindowConfigResponse>(DoRPCRequest("GetWindowConfig", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetWindowConfigResponse> GetWindowConfigWithOptionsAsync(GetWindowConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetWindowConfigResponse>(await DoRPCRequestAsync("GetWindowConfig", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetWindowConfigResponse GetWindowConfig(GetWindowConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWindowConfigWithOptions(request, runtime);
        }

        public async Task<GetWindowConfigResponse> GetWindowConfigAsync(GetWindowConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWindowConfigWithOptionsAsync(request, runtime);
        }

        public GetHotspotConfigResponse GetHotspotConfigWithOptions(GetHotspotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHotspotConfigResponse>(DoRPCRequest("GetHotspotConfig", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetHotspotConfigResponse> GetHotspotConfigWithOptionsAsync(GetHotspotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHotspotConfigResponse>(await DoRPCRequestAsync("GetHotspotConfig", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetHotspotConfigResponse GetHotspotConfig(GetHotspotConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotspotConfigWithOptions(request, runtime);
        }

        public async Task<GetHotspotConfigResponse> GetHotspotConfigAsync(GetHotspotConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotspotConfigWithOptionsAsync(request, runtime);
        }

        public GetSceneBuildTaskStatusResponse GetSceneBuildTaskStatusWithOptions(GetSceneBuildTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSceneBuildTaskStatusResponse>(DoRPCRequest("GetSceneBuildTaskStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSceneBuildTaskStatusResponse> GetSceneBuildTaskStatusWithOptionsAsync(GetSceneBuildTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSceneBuildTaskStatusResponse>(await DoRPCRequestAsync("GetSceneBuildTaskStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSceneBuildTaskStatusResponse GetSceneBuildTaskStatus(GetSceneBuildTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSceneBuildTaskStatusWithOptions(request, runtime);
        }

        public async Task<GetSceneBuildTaskStatusResponse> GetSceneBuildTaskStatusAsync(GetSceneBuildTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSceneBuildTaskStatusWithOptionsAsync(request, runtime);
        }

        public TempPreviewResponse TempPreviewWithOptions(TempPreviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TempPreviewResponse>(DoRPCRequest("TempPreview", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TempPreviewResponse> TempPreviewWithOptionsAsync(TempPreviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TempPreviewResponse>(await DoRPCRequestAsync("TempPreview", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TempPreviewResponse TempPreview(TempPreviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TempPreviewWithOptions(request, runtime);
        }

        public async Task<TempPreviewResponse> TempPreviewAsync(TempPreviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TempPreviewWithOptionsAsync(request, runtime);
        }

        public DetailProjectResponse DetailProjectWithOptions(DetailProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetailProjectResponse>(DoRPCRequest("DetailProject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetailProjectResponse> DetailProjectWithOptionsAsync(DetailProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetailProjectResponse>(await DoRPCRequestAsync("DetailProject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetailProjectResponse DetailProject(DetailProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetailProjectWithOptions(request, runtime);
        }

        public async Task<DetailProjectResponse> DetailProjectAsync(DetailProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetailProjectWithOptionsAsync(request, runtime);
        }

        public ListScenesResponse ListScenesWithOptions(ListScenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListScenesResponse>(DoRPCRequest("ListScenes", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListScenesResponse> ListScenesWithOptionsAsync(ListScenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListScenesResponse>(await DoRPCRequestAsync("ListScenes", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListScenesResponse ListScenes(ListScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScenesWithOptions(request, runtime);
        }

        public async Task<ListScenesResponse> ListScenesAsync(ListScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScenesWithOptionsAsync(request, runtime);
        }

        public DropSubSceneResponse DropSubSceneWithOptions(DropSubSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DropSubSceneResponse>(DoRPCRequest("DropSubScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DropSubSceneResponse> DropSubSceneWithOptionsAsync(DropSubSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DropSubSceneResponse>(await DoRPCRequestAsync("DropSubScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DropSubSceneResponse DropSubScene(DropSubSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DropSubSceneWithOptions(request, runtime);
        }

        public async Task<DropSubSceneResponse> DropSubSceneAsync(DropSubSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DropSubSceneWithOptionsAsync(request, runtime);
        }

        public GetHotspotTagResponse GetHotspotTagWithOptions(GetHotspotTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHotspotTagResponse>(DoRPCRequest("GetHotspotTag", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetHotspotTagResponse> GetHotspotTagWithOptionsAsync(GetHotspotTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHotspotTagResponse>(await DoRPCRequestAsync("GetHotspotTag", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetHotspotTagResponse GetHotspotTag(GetHotspotTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotspotTagWithOptions(request, runtime);
        }

        public async Task<GetHotspotTagResponse> GetHotspotTagAsync(GetHotspotTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotspotTagWithOptionsAsync(request, runtime);
        }

        public DropProjectResponse DropProjectWithOptions(DropProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DropProjectResponse>(DoRPCRequest("DropProject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DropProjectResponse> DropProjectWithOptionsAsync(DropProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DropProjectResponse>(await DoRPCRequestAsync("DropProject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DropProjectResponse DropProject(DropProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DropProjectWithOptions(request, runtime);
        }

        public async Task<DropProjectResponse> DropProjectAsync(DropProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DropProjectWithOptionsAsync(request, runtime);
        }

        public ListProjectResponse ListProjectWithOptions(ListProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectResponse>(DoRPCRequest("ListProject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListProjectResponse> ListProjectWithOptionsAsync(ListProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProjectResponse>(await DoRPCRequestAsync("ListProject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListProjectResponse ListProject(ListProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectWithOptions(request, runtime);
        }

        public async Task<ListProjectResponse> ListProjectAsync(ListProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectWithOptionsAsync(request, runtime);
        }

        public GetOriginLayoutDataResponse GetOriginLayoutDataWithOptions(GetOriginLayoutDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOriginLayoutDataResponse>(DoRPCRequest("GetOriginLayoutData", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetOriginLayoutDataResponse> GetOriginLayoutDataWithOptionsAsync(GetOriginLayoutDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOriginLayoutDataResponse>(await DoRPCRequestAsync("GetOriginLayoutData", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetOriginLayoutDataResponse GetOriginLayoutData(GetOriginLayoutDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOriginLayoutDataWithOptions(request, runtime);
        }

        public async Task<GetOriginLayoutDataResponse> GetOriginLayoutDataAsync(GetOriginLayoutDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOriginLayoutDataWithOptionsAsync(request, runtime);
        }

        public GetHotspotSceneDataResponse GetHotspotSceneDataWithOptions(GetHotspotSceneDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHotspotSceneDataResponse>(DoRPCRequest("GetHotspotSceneData", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetHotspotSceneDataResponse> GetHotspotSceneDataWithOptionsAsync(GetHotspotSceneDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHotspotSceneDataResponse>(await DoRPCRequestAsync("GetHotspotSceneData", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetHotspotSceneDataResponse GetHotspotSceneData(GetHotspotSceneDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotspotSceneDataWithOptions(request, runtime);
        }

        public async Task<GetHotspotSceneDataResponse> GetHotspotSceneDataAsync(GetHotspotSceneDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotspotSceneDataWithOptionsAsync(request, runtime);
        }

        public ScenePublishResponse ScenePublishWithOptions(ScenePublishRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ScenePublishResponse>(DoRPCRequest("ScenePublish", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ScenePublishResponse> ScenePublishWithOptionsAsync(ScenePublishRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ScenePublishResponse>(await DoRPCRequestAsync("ScenePublish", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ScenePublishResponse ScenePublish(ScenePublishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ScenePublishWithOptions(request, runtime);
        }

        public async Task<ScenePublishResponse> ScenePublishAsync(ScenePublishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ScenePublishWithOptionsAsync(request, runtime);
        }

        public GetRectifyImageResponse GetRectifyImageWithOptions(GetRectifyImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRectifyImageResponse>(DoRPCRequest("GetRectifyImage", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRectifyImageResponse> GetRectifyImageWithOptionsAsync(GetRectifyImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRectifyImageResponse>(await DoRPCRequestAsync("GetRectifyImage", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRectifyImageResponse GetRectifyImage(GetRectifyImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRectifyImageWithOptions(request, runtime);
        }

        public async Task<GetRectifyImageResponse> GetRectifyImageAsync(GetRectifyImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRectifyImageWithOptionsAsync(request, runtime);
        }

        public UpdateProjectResponse UpdateProjectWithOptions(UpdateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProjectResponse>(DoRPCRequest("UpdateProject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateProjectResponse> UpdateProjectWithOptionsAsync(UpdateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProjectResponse>(await DoRPCRequestAsync("UpdateProject", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetSubSceneTaskStatusResponse GetSubSceneTaskStatusWithOptions(GetSubSceneTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSubSceneTaskStatusResponse>(DoRPCRequest("GetSubSceneTaskStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSubSceneTaskStatusResponse> GetSubSceneTaskStatusWithOptionsAsync(GetSubSceneTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSubSceneTaskStatusResponse>(await DoRPCRequestAsync("GetSubSceneTaskStatus", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSubSceneTaskStatusResponse GetSubSceneTaskStatus(GetSubSceneTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSubSceneTaskStatusWithOptions(request, runtime);
        }

        public async Task<GetSubSceneTaskStatusResponse> GetSubSceneTaskStatusAsync(GetSubSceneTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSubSceneTaskStatusWithOptionsAsync(request, runtime);
        }

        public PredictionWallLineResponse PredictionWallLineWithOptions(PredictionWallLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PredictionWallLineResponse>(DoRPCRequest("PredictionWallLine", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PredictionWallLineResponse> PredictionWallLineWithOptionsAsync(PredictionWallLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PredictionWallLineResponse>(await DoRPCRequestAsync("PredictionWallLine", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PredictionWallLineResponse PredictionWallLine(PredictionWallLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PredictionWallLineWithOptions(request, runtime);
        }

        public async Task<PredictionWallLineResponse> PredictionWallLineAsync(PredictionWallLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PredictionWallLineWithOptionsAsync(request, runtime);
        }

        public GetScenePreviewInfoResponse GetScenePreviewInfoWithOptions(GetScenePreviewInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetScenePreviewInfoResponse>(DoRPCRequest("GetScenePreviewInfo", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetScenePreviewInfoResponse> GetScenePreviewInfoWithOptionsAsync(GetScenePreviewInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetScenePreviewInfoResponse>(await DoRPCRequestAsync("GetScenePreviewInfo", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetScenePreviewInfoResponse GetScenePreviewInfo(GetScenePreviewInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetScenePreviewInfoWithOptions(request, runtime);
        }

        public async Task<GetScenePreviewInfoResponse> GetScenePreviewInfoAsync(GetScenePreviewInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetScenePreviewInfoWithOptionsAsync(request, runtime);
        }

        public GetPolicyResponse GetPolicyWithOptions(GetPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPolicyResponse>(DoRPCRequest("GetPolicy", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPolicyResponse> GetPolicyWithOptionsAsync(GetPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPolicyResponse>(await DoRPCRequestAsync("GetPolicy", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPolicyWithOptions(request, runtime);
        }

        public async Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPolicyWithOptionsAsync(request, runtime);
        }

        public AddSubSceneResponse AddSubSceneWithOptions(AddSubSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSubSceneResponse>(DoRPCRequest("AddSubScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddSubSceneResponse> AddSubSceneWithOptionsAsync(AddSubSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSubSceneResponse>(await DoRPCRequestAsync("AddSubScene", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddSubSceneResponse AddSubScene(AddSubSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSubSceneWithOptions(request, runtime);
        }

        public async Task<AddSubSceneResponse> AddSubSceneAsync(AddSubSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSubSceneWithOptionsAsync(request, runtime);
        }

        public GetLayoutDataResponse GetLayoutDataWithOptions(GetLayoutDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLayoutDataResponse>(DoRPCRequest("GetLayoutData", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLayoutDataResponse> GetLayoutDataWithOptionsAsync(GetLayoutDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLayoutDataResponse>(await DoRPCRequestAsync("GetLayoutData", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLayoutDataResponse GetLayoutData(GetLayoutDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLayoutDataWithOptions(request, runtime);
        }

        public async Task<GetLayoutDataResponse> GetLayoutDataAsync(GetLayoutDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLayoutDataWithOptionsAsync(request, runtime);
        }

    }
}
