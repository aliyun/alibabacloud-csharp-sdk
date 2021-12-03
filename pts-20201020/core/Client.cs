// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.PTS20201020.Models;

namespace AlibabaCloud.SDK.PTS20201020
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("pts", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreatePtsSceneResponse CreatePtsSceneWithOptions(CreatePtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePtsSceneResponse>(DoRPCRequest("CreatePtsScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreatePtsSceneResponse> CreatePtsSceneWithOptionsAsync(CreatePtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePtsSceneResponse>(await DoRPCRequestAsync("CreatePtsScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreatePtsSceneResponse CreatePtsScene(CreatePtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePtsSceneWithOptions(request, runtime);
        }

        public async Task<CreatePtsSceneResponse> CreatePtsSceneAsync(CreatePtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePtsSceneWithOptionsAsync(request, runtime);
        }

        public CreatePtsSceneBaseLineFromReportResponse CreatePtsSceneBaseLineFromReportWithOptions(CreatePtsSceneBaseLineFromReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePtsSceneBaseLineFromReportResponse>(DoRPCRequest("CreatePtsSceneBaseLineFromReport", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreatePtsSceneBaseLineFromReportResponse> CreatePtsSceneBaseLineFromReportWithOptionsAsync(CreatePtsSceneBaseLineFromReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePtsSceneBaseLineFromReportResponse>(await DoRPCRequestAsync("CreatePtsSceneBaseLineFromReport", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreatePtsSceneBaseLineFromReportResponse CreatePtsSceneBaseLineFromReport(CreatePtsSceneBaseLineFromReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePtsSceneBaseLineFromReportWithOptions(request, runtime);
        }

        public async Task<CreatePtsSceneBaseLineFromReportResponse> CreatePtsSceneBaseLineFromReportAsync(CreatePtsSceneBaseLineFromReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePtsSceneBaseLineFromReportWithOptionsAsync(request, runtime);
        }

        public DeletePtsSceneResponse DeletePtsSceneWithOptions(DeletePtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePtsSceneResponse>(DoRPCRequest("DeletePtsScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeletePtsSceneResponse> DeletePtsSceneWithOptionsAsync(DeletePtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePtsSceneResponse>(await DoRPCRequestAsync("DeletePtsScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeletePtsSceneResponse DeletePtsScene(DeletePtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePtsSceneWithOptions(request, runtime);
        }

        public async Task<DeletePtsSceneResponse> DeletePtsSceneAsync(DeletePtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePtsSceneWithOptionsAsync(request, runtime);
        }

        public DeletePtsSceneBaseLineResponse DeletePtsSceneBaseLineWithOptions(DeletePtsSceneBaseLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePtsSceneBaseLineResponse>(DoRPCRequest("DeletePtsSceneBaseLine", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeletePtsSceneBaseLineResponse> DeletePtsSceneBaseLineWithOptionsAsync(DeletePtsSceneBaseLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePtsSceneBaseLineResponse>(await DoRPCRequestAsync("DeletePtsSceneBaseLine", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeletePtsSceneBaseLineResponse DeletePtsSceneBaseLine(DeletePtsSceneBaseLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePtsSceneBaseLineWithOptions(request, runtime);
        }

        public async Task<DeletePtsSceneBaseLineResponse> DeletePtsSceneBaseLineAsync(DeletePtsSceneBaseLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePtsSceneBaseLineWithOptionsAsync(request, runtime);
        }

        public DeletePtsScenesResponse DeletePtsScenesWithOptions(DeletePtsScenesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeletePtsScenesShrinkRequest request = new DeletePtsScenesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SceneIds))
            {
                request.SceneIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SceneIds, "SceneIds", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePtsScenesResponse>(DoRPCRequest("DeletePtsScenes", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeletePtsScenesResponse> DeletePtsScenesWithOptionsAsync(DeletePtsScenesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeletePtsScenesShrinkRequest request = new DeletePtsScenesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SceneIds))
            {
                request.SceneIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SceneIds, "SceneIds", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePtsScenesResponse>(await DoRPCRequestAsync("DeletePtsScenes", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeletePtsScenesResponse DeletePtsScenes(DeletePtsScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePtsScenesWithOptions(request, runtime);
        }

        public async Task<DeletePtsScenesResponse> DeletePtsScenesAsync(DeletePtsScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePtsScenesWithOptionsAsync(request, runtime);
        }

        public GetJMeterLogsResponse GetJMeterLogsWithOptions(GetJMeterLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJMeterLogsResponse>(DoRPCRequest("GetJMeterLogs", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetJMeterLogsResponse> GetJMeterLogsWithOptionsAsync(GetJMeterLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJMeterLogsResponse>(await DoRPCRequestAsync("GetJMeterLogs", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetJMeterLogsResponse GetJMeterLogs(GetJMeterLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJMeterLogsWithOptions(request, runtime);
        }

        public async Task<GetJMeterLogsResponse> GetJMeterLogsAsync(GetJMeterLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJMeterLogsWithOptionsAsync(request, runtime);
        }

        public GetJMeterSampleMetricsResponse GetJMeterSampleMetricsWithOptions(GetJMeterSampleMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJMeterSampleMetricsResponse>(DoRPCRequest("GetJMeterSampleMetrics", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetJMeterSampleMetricsResponse> GetJMeterSampleMetricsWithOptionsAsync(GetJMeterSampleMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJMeterSampleMetricsResponse>(await DoRPCRequestAsync("GetJMeterSampleMetrics", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetJMeterSampleMetricsResponse GetJMeterSampleMetrics(GetJMeterSampleMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJMeterSampleMetricsWithOptions(request, runtime);
        }

        public async Task<GetJMeterSampleMetricsResponse> GetJMeterSampleMetricsAsync(GetJMeterSampleMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJMeterSampleMetricsWithOptionsAsync(request, runtime);
        }

        public GetJMeterSamplingLogsResponse GetJMeterSamplingLogsWithOptions(GetJMeterSamplingLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJMeterSamplingLogsResponse>(DoRPCRequest("GetJMeterSamplingLogs", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetJMeterSamplingLogsResponse> GetJMeterSamplingLogsWithOptionsAsync(GetJMeterSamplingLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJMeterSamplingLogsResponse>(await DoRPCRequestAsync("GetJMeterSamplingLogs", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetJMeterSamplingLogsResponse GetJMeterSamplingLogs(GetJMeterSamplingLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJMeterSamplingLogsWithOptions(request, runtime);
        }

        public async Task<GetJMeterSamplingLogsResponse> GetJMeterSamplingLogsAsync(GetJMeterSamplingLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJMeterSamplingLogsWithOptionsAsync(request, runtime);
        }

        public GetJMeterSceneRunningDataResponse GetJMeterSceneRunningDataWithOptions(GetJMeterSceneRunningDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJMeterSceneRunningDataResponse>(DoRPCRequest("GetJMeterSceneRunningData", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetJMeterSceneRunningDataResponse> GetJMeterSceneRunningDataWithOptionsAsync(GetJMeterSceneRunningDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJMeterSceneRunningDataResponse>(await DoRPCRequestAsync("GetJMeterSceneRunningData", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetJMeterSceneRunningDataResponse GetJMeterSceneRunningData(GetJMeterSceneRunningDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJMeterSceneRunningDataWithOptions(request, runtime);
        }

        public async Task<GetJMeterSceneRunningDataResponse> GetJMeterSceneRunningDataAsync(GetJMeterSceneRunningDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJMeterSceneRunningDataWithOptionsAsync(request, runtime);
        }

        public GetOpenJMeterSceneResponse GetOpenJMeterSceneWithOptions(GetOpenJMeterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOpenJMeterSceneResponse>(DoRPCRequest("GetOpenJMeterScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetOpenJMeterSceneResponse> GetOpenJMeterSceneWithOptionsAsync(GetOpenJMeterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOpenJMeterSceneResponse>(await DoRPCRequestAsync("GetOpenJMeterScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetOpenJMeterSceneResponse GetOpenJMeterScene(GetOpenJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOpenJMeterSceneWithOptions(request, runtime);
        }

        public async Task<GetOpenJMeterSceneResponse> GetOpenJMeterSceneAsync(GetOpenJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOpenJMeterSceneWithOptionsAsync(request, runtime);
        }

        public GetPtsReportDetailsResponse GetPtsReportDetailsWithOptions(GetPtsReportDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPtsReportDetailsResponse>(DoRPCRequest("GetPtsReportDetails", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPtsReportDetailsResponse> GetPtsReportDetailsWithOptionsAsync(GetPtsReportDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPtsReportDetailsResponse>(await DoRPCRequestAsync("GetPtsReportDetails", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPtsReportDetailsResponse GetPtsReportDetails(GetPtsReportDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPtsReportDetailsWithOptions(request, runtime);
        }

        public async Task<GetPtsReportDetailsResponse> GetPtsReportDetailsAsync(GetPtsReportDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPtsReportDetailsWithOptionsAsync(request, runtime);
        }

        public GetPtsReportsBySceneIdResponse GetPtsReportsBySceneIdWithOptions(GetPtsReportsBySceneIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPtsReportsBySceneIdResponse>(DoRPCRequest("GetPtsReportsBySceneId", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPtsReportsBySceneIdResponse> GetPtsReportsBySceneIdWithOptionsAsync(GetPtsReportsBySceneIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPtsReportsBySceneIdResponse>(await DoRPCRequestAsync("GetPtsReportsBySceneId", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPtsReportsBySceneIdResponse GetPtsReportsBySceneId(GetPtsReportsBySceneIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPtsReportsBySceneIdWithOptions(request, runtime);
        }

        public async Task<GetPtsReportsBySceneIdResponse> GetPtsReportsBySceneIdAsync(GetPtsReportsBySceneIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPtsReportsBySceneIdWithOptionsAsync(request, runtime);
        }

        public GetPtsSceneResponse GetPtsSceneWithOptions(GetPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPtsSceneResponse>(DoRPCRequest("GetPtsScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPtsSceneResponse> GetPtsSceneWithOptionsAsync(GetPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPtsSceneResponse>(await DoRPCRequestAsync("GetPtsScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPtsSceneResponse GetPtsScene(GetPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPtsSceneWithOptions(request, runtime);
        }

        public async Task<GetPtsSceneResponse> GetPtsSceneAsync(GetPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPtsSceneWithOptionsAsync(request, runtime);
        }

        public GetPtsSceneBaseLineResponse GetPtsSceneBaseLineWithOptions(GetPtsSceneBaseLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPtsSceneBaseLineResponse>(DoRPCRequest("GetPtsSceneBaseLine", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPtsSceneBaseLineResponse> GetPtsSceneBaseLineWithOptionsAsync(GetPtsSceneBaseLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPtsSceneBaseLineResponse>(await DoRPCRequestAsync("GetPtsSceneBaseLine", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPtsSceneBaseLineResponse GetPtsSceneBaseLine(GetPtsSceneBaseLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPtsSceneBaseLineWithOptions(request, runtime);
        }

        public async Task<GetPtsSceneBaseLineResponse> GetPtsSceneBaseLineAsync(GetPtsSceneBaseLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPtsSceneBaseLineWithOptionsAsync(request, runtime);
        }

        public GetPtsSceneRunningDataResponse GetPtsSceneRunningDataWithOptions(GetPtsSceneRunningDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPtsSceneRunningDataResponse>(DoRPCRequest("GetPtsSceneRunningData", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPtsSceneRunningDataResponse> GetPtsSceneRunningDataWithOptionsAsync(GetPtsSceneRunningDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPtsSceneRunningDataResponse>(await DoRPCRequestAsync("GetPtsSceneRunningData", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPtsSceneRunningDataResponse GetPtsSceneRunningData(GetPtsSceneRunningDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPtsSceneRunningDataWithOptions(request, runtime);
        }

        public async Task<GetPtsSceneRunningDataResponse> GetPtsSceneRunningDataAsync(GetPtsSceneRunningDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPtsSceneRunningDataWithOptionsAsync(request, runtime);
        }

        public GetPtsSceneRunningStatusResponse GetPtsSceneRunningStatusWithOptions(GetPtsSceneRunningStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPtsSceneRunningStatusResponse>(DoRPCRequest("GetPtsSceneRunningStatus", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPtsSceneRunningStatusResponse> GetPtsSceneRunningStatusWithOptionsAsync(GetPtsSceneRunningStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPtsSceneRunningStatusResponse>(await DoRPCRequestAsync("GetPtsSceneRunningStatus", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPtsSceneRunningStatusResponse GetPtsSceneRunningStatus(GetPtsSceneRunningStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPtsSceneRunningStatusWithOptions(request, runtime);
        }

        public async Task<GetPtsSceneRunningStatusResponse> GetPtsSceneRunningStatusAsync(GetPtsSceneRunningStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPtsSceneRunningStatusWithOptionsAsync(request, runtime);
        }

        public ListEnvsResponse ListEnvsWithOptions(ListEnvsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEnvsResponse>(DoRPCRequest("ListEnvs", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListEnvsResponse> ListEnvsWithOptionsAsync(ListEnvsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEnvsResponse>(await DoRPCRequestAsync("ListEnvs", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListEnvsResponse ListEnvs(ListEnvsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEnvsWithOptions(request, runtime);
        }

        public async Task<ListEnvsResponse> ListEnvsAsync(ListEnvsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEnvsWithOptionsAsync(request, runtime);
        }

        public ListJMeterReportsResponse ListJMeterReportsWithOptions(ListJMeterReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListJMeterReportsResponse>(DoRPCRequest("ListJMeterReports", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListJMeterReportsResponse> ListJMeterReportsWithOptionsAsync(ListJMeterReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListJMeterReportsResponse>(await DoRPCRequestAsync("ListJMeterReports", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListJMeterReportsResponse ListJMeterReports(ListJMeterReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJMeterReportsWithOptions(request, runtime);
        }

        public async Task<ListJMeterReportsResponse> ListJMeterReportsAsync(ListJMeterReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJMeterReportsWithOptionsAsync(request, runtime);
        }

        public ListOpenJMeterScenesResponse ListOpenJMeterScenesWithOptions(ListOpenJMeterScenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOpenJMeterScenesResponse>(DoRPCRequest("ListOpenJMeterScenes", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOpenJMeterScenesResponse> ListOpenJMeterScenesWithOptionsAsync(ListOpenJMeterScenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOpenJMeterScenesResponse>(await DoRPCRequestAsync("ListOpenJMeterScenes", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOpenJMeterScenesResponse ListOpenJMeterScenes(ListOpenJMeterScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOpenJMeterScenesWithOptions(request, runtime);
        }

        public async Task<ListOpenJMeterScenesResponse> ListOpenJMeterScenesAsync(ListOpenJMeterScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOpenJMeterScenesWithOptionsAsync(request, runtime);
        }

        public ListPtsSceneResponse ListPtsSceneWithOptions(ListPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPtsSceneResponse>(DoRPCRequest("ListPtsScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPtsSceneResponse> ListPtsSceneWithOptionsAsync(ListPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPtsSceneResponse>(await DoRPCRequestAsync("ListPtsScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPtsSceneResponse ListPtsScene(ListPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPtsSceneWithOptions(request, runtime);
        }

        public async Task<ListPtsSceneResponse> ListPtsSceneAsync(ListPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPtsSceneWithOptionsAsync(request, runtime);
        }

        public ModifyPtsSceneResponse ModifyPtsSceneWithOptions(ModifyPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPtsSceneResponse>(DoRPCRequest("ModifyPtsScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyPtsSceneResponse> ModifyPtsSceneWithOptionsAsync(ModifyPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPtsSceneResponse>(await DoRPCRequestAsync("ModifyPtsScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyPtsSceneResponse ModifyPtsScene(ModifyPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPtsSceneWithOptions(request, runtime);
        }

        public async Task<ModifyPtsSceneResponse> ModifyPtsSceneAsync(ModifyPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPtsSceneWithOptionsAsync(request, runtime);
        }

        public RemoveEnvResponse RemoveEnvWithOptions(RemoveEnvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveEnvResponse>(DoRPCRequest("RemoveEnv", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveEnvResponse> RemoveEnvWithOptionsAsync(RemoveEnvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveEnvResponse>(await DoRPCRequestAsync("RemoveEnv", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveEnvResponse RemoveEnv(RemoveEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveEnvWithOptions(request, runtime);
        }

        public async Task<RemoveEnvResponse> RemoveEnvAsync(RemoveEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveEnvWithOptionsAsync(request, runtime);
        }

        public RemoveOpenJMeterSceneResponse RemoveOpenJMeterSceneWithOptions(RemoveOpenJMeterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveOpenJMeterSceneResponse>(DoRPCRequest("RemoveOpenJMeterScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveOpenJMeterSceneResponse> RemoveOpenJMeterSceneWithOptionsAsync(RemoveOpenJMeterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveOpenJMeterSceneResponse>(await DoRPCRequestAsync("RemoveOpenJMeterScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveOpenJMeterSceneResponse RemoveOpenJMeterScene(RemoveOpenJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveOpenJMeterSceneWithOptions(request, runtime);
        }

        public async Task<RemoveOpenJMeterSceneResponse> RemoveOpenJMeterSceneAsync(RemoveOpenJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveOpenJMeterSceneWithOptionsAsync(request, runtime);
        }

        public SaveEnvResponse SaveEnvWithOptions(SaveEnvRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveEnvShrinkRequest request = new SaveEnvShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Env.ToMap()))
            {
                request.EnvShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Env.ToMap(), "Env", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveEnvResponse>(DoRPCRequest("SaveEnv", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveEnvResponse> SaveEnvWithOptionsAsync(SaveEnvRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveEnvShrinkRequest request = new SaveEnvShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Env.ToMap()))
            {
                request.EnvShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Env.ToMap(), "Env", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveEnvResponse>(await DoRPCRequestAsync("SaveEnv", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveEnvResponse SaveEnv(SaveEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveEnvWithOptions(request, runtime);
        }

        public async Task<SaveEnvResponse> SaveEnvAsync(SaveEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveEnvWithOptionsAsync(request, runtime);
        }

        public SaveOpenJMeterSceneResponse SaveOpenJMeterSceneWithOptions(SaveOpenJMeterSceneRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveOpenJMeterSceneShrinkRequest request = new SaveOpenJMeterSceneShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenJMeterScene.ToMap()))
            {
                request.OpenJMeterSceneShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenJMeterScene.ToMap(), "OpenJMeterScene", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveOpenJMeterSceneResponse>(DoRPCRequest("SaveOpenJMeterScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveOpenJMeterSceneResponse> SaveOpenJMeterSceneWithOptionsAsync(SaveOpenJMeterSceneRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveOpenJMeterSceneShrinkRequest request = new SaveOpenJMeterSceneShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenJMeterScene.ToMap()))
            {
                request.OpenJMeterSceneShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenJMeterScene.ToMap(), "OpenJMeterScene", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveOpenJMeterSceneResponse>(await DoRPCRequestAsync("SaveOpenJMeterScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveOpenJMeterSceneResponse SaveOpenJMeterScene(SaveOpenJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveOpenJMeterSceneWithOptions(request, runtime);
        }

        public async Task<SaveOpenJMeterSceneResponse> SaveOpenJMeterSceneAsync(SaveOpenJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveOpenJMeterSceneWithOptionsAsync(request, runtime);
        }

        public StartDebugPtsSceneResponse StartDebugPtsSceneWithOptions(StartDebugPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartDebugPtsSceneResponse>(DoRPCRequest("StartDebugPtsScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartDebugPtsSceneResponse> StartDebugPtsSceneWithOptionsAsync(StartDebugPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartDebugPtsSceneResponse>(await DoRPCRequestAsync("StartDebugPtsScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartDebugPtsSceneResponse StartDebugPtsScene(StartDebugPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDebugPtsSceneWithOptions(request, runtime);
        }

        public async Task<StartDebugPtsSceneResponse> StartDebugPtsSceneAsync(StartDebugPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDebugPtsSceneWithOptionsAsync(request, runtime);
        }

        public StartDebuggingJMeterSceneResponse StartDebuggingJMeterSceneWithOptions(StartDebuggingJMeterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartDebuggingJMeterSceneResponse>(DoRPCRequest("StartDebuggingJMeterScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartDebuggingJMeterSceneResponse> StartDebuggingJMeterSceneWithOptionsAsync(StartDebuggingJMeterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartDebuggingJMeterSceneResponse>(await DoRPCRequestAsync("StartDebuggingJMeterScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartDebuggingJMeterSceneResponse StartDebuggingJMeterScene(StartDebuggingJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDebuggingJMeterSceneWithOptions(request, runtime);
        }

        public async Task<StartDebuggingJMeterSceneResponse> StartDebuggingJMeterSceneAsync(StartDebuggingJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDebuggingJMeterSceneWithOptionsAsync(request, runtime);
        }

        public StartPtsSceneResponse StartPtsSceneWithOptions(StartPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartPtsSceneResponse>(DoRPCRequest("StartPtsScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartPtsSceneResponse> StartPtsSceneWithOptionsAsync(StartPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartPtsSceneResponse>(await DoRPCRequestAsync("StartPtsScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartPtsSceneResponse StartPtsScene(StartPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartPtsSceneWithOptions(request, runtime);
        }

        public async Task<StartPtsSceneResponse> StartPtsSceneAsync(StartPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartPtsSceneWithOptionsAsync(request, runtime);
        }

        public StartTestingJMeterSceneResponse StartTestingJMeterSceneWithOptions(StartTestingJMeterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartTestingJMeterSceneResponse>(DoRPCRequest("StartTestingJMeterScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartTestingJMeterSceneResponse> StartTestingJMeterSceneWithOptionsAsync(StartTestingJMeterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartTestingJMeterSceneResponse>(await DoRPCRequestAsync("StartTestingJMeterScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartTestingJMeterSceneResponse StartTestingJMeterScene(StartTestingJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartTestingJMeterSceneWithOptions(request, runtime);
        }

        public async Task<StartTestingJMeterSceneResponse> StartTestingJMeterSceneAsync(StartTestingJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartTestingJMeterSceneWithOptionsAsync(request, runtime);
        }

        public StopDebugPtsSceneResponse StopDebugPtsSceneWithOptions(StopDebugPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDebugPtsSceneResponse>(DoRPCRequest("StopDebugPtsScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopDebugPtsSceneResponse> StopDebugPtsSceneWithOptionsAsync(StopDebugPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDebugPtsSceneResponse>(await DoRPCRequestAsync("StopDebugPtsScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopDebugPtsSceneResponse StopDebugPtsScene(StopDebugPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDebugPtsSceneWithOptions(request, runtime);
        }

        public async Task<StopDebugPtsSceneResponse> StopDebugPtsSceneAsync(StopDebugPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDebugPtsSceneWithOptionsAsync(request, runtime);
        }

        public StopDebuggingJMeterSceneResponse StopDebuggingJMeterSceneWithOptions(StopDebuggingJMeterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDebuggingJMeterSceneResponse>(DoRPCRequest("StopDebuggingJMeterScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopDebuggingJMeterSceneResponse> StopDebuggingJMeterSceneWithOptionsAsync(StopDebuggingJMeterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDebuggingJMeterSceneResponse>(await DoRPCRequestAsync("StopDebuggingJMeterScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopDebuggingJMeterSceneResponse StopDebuggingJMeterScene(StopDebuggingJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDebuggingJMeterSceneWithOptions(request, runtime);
        }

        public async Task<StopDebuggingJMeterSceneResponse> StopDebuggingJMeterSceneAsync(StopDebuggingJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDebuggingJMeterSceneWithOptionsAsync(request, runtime);
        }

        public StopPtsSceneResponse StopPtsSceneWithOptions(StopPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopPtsSceneResponse>(DoRPCRequest("StopPtsScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopPtsSceneResponse> StopPtsSceneWithOptionsAsync(StopPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopPtsSceneResponse>(await DoRPCRequestAsync("StopPtsScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopPtsSceneResponse StopPtsScene(StopPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopPtsSceneWithOptions(request, runtime);
        }

        public async Task<StopPtsSceneResponse> StopPtsSceneAsync(StopPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopPtsSceneWithOptionsAsync(request, runtime);
        }

        public StopTestingJMeterSceneResponse StopTestingJMeterSceneWithOptions(StopTestingJMeterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopTestingJMeterSceneResponse>(DoRPCRequest("StopTestingJMeterScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopTestingJMeterSceneResponse> StopTestingJMeterSceneWithOptionsAsync(StopTestingJMeterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopTestingJMeterSceneResponse>(await DoRPCRequestAsync("StopTestingJMeterScene", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopTestingJMeterSceneResponse StopTestingJMeterScene(StopTestingJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopTestingJMeterSceneWithOptions(request, runtime);
        }

        public async Task<StopTestingJMeterSceneResponse> StopTestingJMeterSceneAsync(StopTestingJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopTestingJMeterSceneWithOptionsAsync(request, runtime);
        }

        public UpdatePtsSceneBaseLineResponse UpdatePtsSceneBaseLineWithOptions(UpdatePtsSceneBaseLineRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdatePtsSceneBaseLineShrinkRequest request = new UpdatePtsSceneBaseLineShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApiBaselines))
            {
                request.ApiBaselinesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApiBaselines, "ApiBaselines", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SceneBaseline))
            {
                request.SceneBaselineShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SceneBaseline, "SceneBaseline", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePtsSceneBaseLineResponse>(DoRPCRequest("UpdatePtsSceneBaseLine", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdatePtsSceneBaseLineResponse> UpdatePtsSceneBaseLineWithOptionsAsync(UpdatePtsSceneBaseLineRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdatePtsSceneBaseLineShrinkRequest request = new UpdatePtsSceneBaseLineShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApiBaselines))
            {
                request.ApiBaselinesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApiBaselines, "ApiBaselines", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SceneBaseline))
            {
                request.SceneBaselineShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SceneBaseline, "SceneBaseline", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePtsSceneBaseLineResponse>(await DoRPCRequestAsync("UpdatePtsSceneBaseLine", "2020-10-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdatePtsSceneBaseLineResponse UpdatePtsSceneBaseLine(UpdatePtsSceneBaseLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePtsSceneBaseLineWithOptions(request, runtime);
        }

        public async Task<UpdatePtsSceneBaseLineResponse> UpdatePtsSceneBaseLineAsync(UpdatePtsSceneBaseLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePtsSceneBaseLineWithOptionsAsync(request, runtime);
        }

    }
}
