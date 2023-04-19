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

        public AdjustJMeterSceneSpeedResponse AdjustJMeterSceneSpeedWithOptions(AdjustJMeterSceneSpeedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Speed))
            {
                query["Speed"] = request.Speed;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AdjustJMeterSceneSpeed",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AdjustJMeterSceneSpeedResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AdjustJMeterSceneSpeedResponse> AdjustJMeterSceneSpeedWithOptionsAsync(AdjustJMeterSceneSpeedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Speed))
            {
                query["Speed"] = request.Speed;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AdjustJMeterSceneSpeed",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AdjustJMeterSceneSpeedResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AdjustJMeterSceneSpeedResponse AdjustJMeterSceneSpeed(AdjustJMeterSceneSpeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AdjustJMeterSceneSpeedWithOptions(request, runtime);
        }

        public async Task<AdjustJMeterSceneSpeedResponse> AdjustJMeterSceneSpeedAsync(AdjustJMeterSceneSpeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AdjustJMeterSceneSpeedWithOptionsAsync(request, runtime);
        }

        public AdjustPtsSceneSpeedResponse AdjustPtsSceneSpeedWithOptions(AdjustPtsSceneSpeedRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AdjustPtsSceneSpeedShrinkRequest request = new AdjustPtsSceneSpeedShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApiSpeedList))
            {
                request.ApiSpeedListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApiSpeedList, "ApiSpeedList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiSpeedListShrink))
            {
                query["ApiSpeedList"] = request.ApiSpeedListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AdjustPtsSceneSpeed",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AdjustPtsSceneSpeedResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AdjustPtsSceneSpeedResponse> AdjustPtsSceneSpeedWithOptionsAsync(AdjustPtsSceneSpeedRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AdjustPtsSceneSpeedShrinkRequest request = new AdjustPtsSceneSpeedShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApiSpeedList))
            {
                request.ApiSpeedListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApiSpeedList, "ApiSpeedList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiSpeedListShrink))
            {
                query["ApiSpeedList"] = request.ApiSpeedListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AdjustPtsSceneSpeed",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AdjustPtsSceneSpeedResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AdjustPtsSceneSpeedResponse AdjustPtsSceneSpeed(AdjustPtsSceneSpeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AdjustPtsSceneSpeedWithOptions(request, runtime);
        }

        public async Task<AdjustPtsSceneSpeedResponse> AdjustPtsSceneSpeedAsync(AdjustPtsSceneSpeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AdjustPtsSceneSpeedWithOptionsAsync(request, runtime);
        }

        public CreatePtsSceneResponse CreatePtsSceneWithOptions(CreatePtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["Scene"] = request.Scene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePtsScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePtsSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreatePtsSceneResponse> CreatePtsSceneWithOptionsAsync(CreatePtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["Scene"] = request.Scene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePtsScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePtsSceneResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePtsSceneBaseLineFromReport",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePtsSceneBaseLineFromReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreatePtsSceneBaseLineFromReportResponse> CreatePtsSceneBaseLineFromReportWithOptionsAsync(CreatePtsSceneBaseLineFromReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePtsSceneBaseLineFromReport",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePtsSceneBaseLineFromReportResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePtsScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePtsSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeletePtsSceneResponse> DeletePtsSceneWithOptionsAsync(DeletePtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePtsScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePtsSceneResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePtsSceneBaseLine",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePtsSceneBaseLineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeletePtsSceneBaseLineResponse> DeletePtsSceneBaseLineWithOptionsAsync(DeletePtsSceneBaseLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePtsSceneBaseLine",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePtsSceneBaseLineResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneIdsShrink))
            {
                query["SceneIds"] = request.SceneIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePtsScenes",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePtsScenesResponse>(CallApi(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneIdsShrink))
            {
                query["SceneIds"] = request.SceneIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePtsScenes",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePtsScenesResponse>(await CallApiAsync(params_, req, runtime));
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

        public GetAllRegionsResponse GetAllRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAllRegions",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAllRegionsResponse> GetAllRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAllRegions",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAllRegionsResponse GetAllRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAllRegionsWithOptions(runtime);
        }

        public async Task<GetAllRegionsResponse> GetAllRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAllRegionsWithOptionsAsync(runtime);
        }

        public GetJMeterLogsResponse GetJMeterLogsWithOptions(GetJMeterLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentIndex))
            {
                query["AgentIndex"] = request.AgentIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Thread))
            {
                query["Thread"] = request.Thread;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJMeterLogs",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJMeterLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetJMeterLogsResponse> GetJMeterLogsWithOptionsAsync(GetJMeterLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentIndex))
            {
                query["AgentIndex"] = request.AgentIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Thread))
            {
                query["Thread"] = request.Thread;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJMeterLogs",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJMeterLogsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplerId))
            {
                query["SamplerId"] = request.SamplerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJMeterSampleMetrics",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJMeterSampleMetricsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetJMeterSampleMetricsResponse> GetJMeterSampleMetricsWithOptionsAsync(GetJMeterSampleMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplerId))
            {
                query["SamplerId"] = request.SamplerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJMeterSampleMetrics",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJMeterSampleMetricsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRT))
            {
                query["MaxRT"] = request.MaxRT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinRT))
            {
                query["MinRT"] = request.MinRT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseCode))
            {
                query["ResponseCode"] = request.ResponseCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplerId))
            {
                query["SamplerId"] = request.SamplerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Success))
            {
                query["Success"] = request.Success;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Thread))
            {
                query["Thread"] = request.Thread;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJMeterSamplingLogs",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJMeterSamplingLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetJMeterSamplingLogsResponse> GetJMeterSamplingLogsWithOptionsAsync(GetJMeterSamplingLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRT))
            {
                query["MaxRT"] = request.MaxRT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinRT))
            {
                query["MinRT"] = request.MinRT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseCode))
            {
                query["ResponseCode"] = request.ResponseCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplerId))
            {
                query["SamplerId"] = request.SamplerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Success))
            {
                query["Success"] = request.Success;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Thread))
            {
                query["Thread"] = request.Thread;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJMeterSamplingLogs",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJMeterSamplingLogsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJMeterSceneRunningData",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJMeterSceneRunningDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetJMeterSceneRunningDataResponse> GetJMeterSceneRunningDataWithOptionsAsync(GetJMeterSceneRunningDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJMeterSceneRunningData",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJMeterSceneRunningDataResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOpenJMeterScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOpenJMeterSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetOpenJMeterSceneResponse> GetOpenJMeterSceneWithOptionsAsync(GetOpenJMeterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOpenJMeterScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOpenJMeterSceneResponse>(await CallApiAsync(params_, req, runtime));
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

        public GetPtsDebugSampleLogsResponse GetPtsDebugSampleLogsWithOptions(GetPtsDebugSampleLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPtsDebugSampleLogs",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPtsDebugSampleLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPtsDebugSampleLogsResponse> GetPtsDebugSampleLogsWithOptionsAsync(GetPtsDebugSampleLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPtsDebugSampleLogs",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPtsDebugSampleLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPtsDebugSampleLogsResponse GetPtsDebugSampleLogs(GetPtsDebugSampleLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPtsDebugSampleLogsWithOptions(request, runtime);
        }

        public async Task<GetPtsDebugSampleLogsResponse> GetPtsDebugSampleLogsAsync(GetPtsDebugSampleLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPtsDebugSampleLogsWithOptionsAsync(request, runtime);
        }

        public GetPtsReportDetailsResponse GetPtsReportDetailsWithOptions(GetPtsReportDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPtsReportDetails",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPtsReportDetailsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPtsReportDetailsResponse> GetPtsReportDetailsWithOptionsAsync(GetPtsReportDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPtsReportDetails",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPtsReportDetailsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPtsReportsBySceneId",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPtsReportsBySceneIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPtsReportsBySceneIdResponse> GetPtsReportsBySceneIdWithOptionsAsync(GetPtsReportsBySceneIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPtsReportsBySceneId",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPtsReportsBySceneIdResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPtsScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPtsSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPtsSceneResponse> GetPtsSceneWithOptionsAsync(GetPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPtsScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPtsSceneResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPtsSceneBaseLine",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPtsSceneBaseLineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPtsSceneBaseLineResponse> GetPtsSceneBaseLineWithOptionsAsync(GetPtsSceneBaseLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPtsSceneBaseLine",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPtsSceneBaseLineResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPtsSceneRunningData",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPtsSceneRunningDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPtsSceneRunningDataResponse> GetPtsSceneRunningDataWithOptionsAsync(GetPtsSceneRunningDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPtsSceneRunningData",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPtsSceneRunningDataResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPtsSceneRunningStatus",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPtsSceneRunningStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPtsSceneRunningStatusResponse> GetPtsSceneRunningStatusWithOptionsAsync(GetPtsSceneRunningStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPtsSceneRunningStatus",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPtsSceneRunningStatusResponse>(await CallApiAsync(params_, req, runtime));
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

        public GetUserVpcSecurityGroupResponse GetUserVpcSecurityGroupWithOptions(GetUserVpcSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserVpcSecurityGroup",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserVpcSecurityGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserVpcSecurityGroupResponse> GetUserVpcSecurityGroupWithOptionsAsync(GetUserVpcSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserVpcSecurityGroup",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserVpcSecurityGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUserVpcSecurityGroupResponse GetUserVpcSecurityGroup(GetUserVpcSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserVpcSecurityGroupWithOptions(request, runtime);
        }

        public async Task<GetUserVpcSecurityGroupResponse> GetUserVpcSecurityGroupAsync(GetUserVpcSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserVpcSecurityGroupWithOptionsAsync(request, runtime);
        }

        public GetUserVpcVSwitchResponse GetUserVpcVSwitchWithOptions(GetUserVpcVSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserVpcVSwitch",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserVpcVSwitchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserVpcVSwitchResponse> GetUserVpcVSwitchWithOptionsAsync(GetUserVpcVSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserVpcVSwitch",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserVpcVSwitchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUserVpcVSwitchResponse GetUserVpcVSwitch(GetUserVpcVSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserVpcVSwitchWithOptions(request, runtime);
        }

        public async Task<GetUserVpcVSwitchResponse> GetUserVpcVSwitchAsync(GetUserVpcVSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserVpcVSwitchWithOptionsAsync(request, runtime);
        }

        public GetUserVpcsResponse GetUserVpcsWithOptions(GetUserVpcsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserVpcs",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserVpcsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserVpcsResponse> GetUserVpcsWithOptionsAsync(GetUserVpcsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserVpcs",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserVpcsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUserVpcsResponse GetUserVpcs(GetUserVpcsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserVpcsWithOptions(request, runtime);
        }

        public async Task<GetUserVpcsResponse> GetUserVpcsAsync(GetUserVpcsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserVpcsWithOptionsAsync(request, runtime);
        }

        public ListEnvsResponse ListEnvsWithOptions(ListEnvsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvName))
            {
                query["EnvName"] = request.EnvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnvs",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnvsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListEnvsResponse> ListEnvsWithOptionsAsync(ListEnvsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvName))
            {
                query["EnvName"] = request.EnvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnvs",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnvsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJMeterReports",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJMeterReportsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListJMeterReportsResponse> ListJMeterReportsWithOptionsAsync(ListJMeterReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJMeterReports",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJMeterReportsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneName))
            {
                query["SceneName"] = request.SceneName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOpenJMeterScenes",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOpenJMeterScenesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListOpenJMeterScenesResponse> ListOpenJMeterScenesWithOptionsAsync(ListOpenJMeterScenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneName))
            {
                query["SceneName"] = request.SceneName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOpenJMeterScenes",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOpenJMeterScenesResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPtsScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPtsSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPtsSceneResponse> ListPtsSceneWithOptionsAsync(ListPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPtsScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPtsSceneResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["Scene"] = request.Scene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPtsScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPtsSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyPtsSceneResponse> ModifyPtsSceneWithOptionsAsync(ModifyPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["Scene"] = request.Scene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPtsScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPtsSceneResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveEnv",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveEnvResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveEnvResponse> RemoveEnvWithOptionsAsync(RemoveEnvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveEnv",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveEnvResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveOpenJMeterScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveOpenJMeterSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveOpenJMeterSceneResponse> RemoveOpenJMeterSceneWithOptionsAsync(RemoveOpenJMeterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveOpenJMeterScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveOpenJMeterSceneResponse>(await CallApiAsync(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Env))
            {
                request.EnvShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Env, "Env", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvShrink))
            {
                query["Env"] = request.EnvShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveEnv",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveEnvResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveEnvResponse> SaveEnvWithOptionsAsync(SaveEnvRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveEnvShrinkRequest request = new SaveEnvShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Env))
            {
                request.EnvShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Env, "Env", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvShrink))
            {
                query["Env"] = request.EnvShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveEnv",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveEnvResponse>(await CallApiAsync(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenJMeterScene))
            {
                request.OpenJMeterSceneShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenJMeterScene, "OpenJMeterScene", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenJMeterSceneShrink))
            {
                query["OpenJMeterScene"] = request.OpenJMeterSceneShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveOpenJMeterScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveOpenJMeterSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveOpenJMeterSceneResponse> SaveOpenJMeterSceneWithOptionsAsync(SaveOpenJMeterSceneRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveOpenJMeterSceneShrinkRequest request = new SaveOpenJMeterSceneShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenJMeterScene))
            {
                request.OpenJMeterSceneShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenJMeterScene, "OpenJMeterScene", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenJMeterSceneShrink))
            {
                query["OpenJMeterScene"] = request.OpenJMeterSceneShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveOpenJMeterScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveOpenJMeterSceneResponse>(await CallApiAsync(params_, req, runtime));
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

        public SavePtsSceneResponse SavePtsSceneWithOptions(SavePtsSceneRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SavePtsSceneShrinkRequest request = new SavePtsSceneShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Scene))
            {
                request.SceneShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Scene, "Scene", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneShrink))
            {
                query["Scene"] = request.SceneShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SavePtsScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SavePtsSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SavePtsSceneResponse> SavePtsSceneWithOptionsAsync(SavePtsSceneRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SavePtsSceneShrinkRequest request = new SavePtsSceneShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Scene))
            {
                request.SceneShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Scene, "Scene", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneShrink))
            {
                query["Scene"] = request.SceneShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SavePtsScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SavePtsSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SavePtsSceneResponse SavePtsScene(SavePtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SavePtsSceneWithOptions(request, runtime);
        }

        public async Task<SavePtsSceneResponse> SavePtsSceneAsync(SavePtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SavePtsSceneWithOptionsAsync(request, runtime);
        }

        public StartDebugPtsSceneResponse StartDebugPtsSceneWithOptions(StartDebugPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDebugPtsScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDebugPtsSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartDebugPtsSceneResponse> StartDebugPtsSceneWithOptionsAsync(StartDebugPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDebugPtsScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDebugPtsSceneResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDebuggingJMeterScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDebuggingJMeterSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartDebuggingJMeterSceneResponse> StartDebuggingJMeterSceneWithOptionsAsync(StartDebuggingJMeterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDebuggingJMeterScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDebuggingJMeterSceneResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartPtsScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartPtsSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartPtsSceneResponse> StartPtsSceneWithOptionsAsync(StartPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartPtsScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartPtsSceneResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartTestingJMeterScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartTestingJMeterSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartTestingJMeterSceneResponse> StartTestingJMeterSceneWithOptionsAsync(StartTestingJMeterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartTestingJMeterScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartTestingJMeterSceneResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDebugPtsScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDebugPtsSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopDebugPtsSceneResponse> StopDebugPtsSceneWithOptionsAsync(StopDebugPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDebugPtsScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDebugPtsSceneResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDebuggingJMeterScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDebuggingJMeterSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopDebuggingJMeterSceneResponse> StopDebuggingJMeterSceneWithOptionsAsync(StopDebuggingJMeterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDebuggingJMeterScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDebuggingJMeterSceneResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopPtsScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopPtsSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopPtsSceneResponse> StopPtsSceneWithOptionsAsync(StopPtsSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopPtsScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopPtsSceneResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopTestingJMeterScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopTestingJMeterSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopTestingJMeterSceneResponse> StopTestingJMeterSceneWithOptionsAsync(StopTestingJMeterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopTestingJMeterScene",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopTestingJMeterSceneResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiBaselinesShrink))
            {
                query["ApiBaselines"] = request.ApiBaselinesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneBaselineShrink))
            {
                query["SceneBaseline"] = request.SceneBaselineShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePtsSceneBaseLine",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePtsSceneBaseLineResponse>(CallApi(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiBaselinesShrink))
            {
                query["ApiBaselines"] = request.ApiBaselinesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneBaselineShrink))
            {
                query["SceneBaseline"] = request.SceneBaselineShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePtsSceneBaseLine",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePtsSceneBaseLineResponse>(await CallApiAsync(params_, req, runtime));
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
