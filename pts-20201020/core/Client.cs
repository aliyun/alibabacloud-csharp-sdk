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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adjusts the JMeter load.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AdjustJMeterSceneSpeedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AdjustJMeterSceneSpeedResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adjusts the JMeter load.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AdjustJMeterSceneSpeedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AdjustJMeterSceneSpeedResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adjusts the JMeter load.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AdjustJMeterSceneSpeedRequest
        /// </param>
        /// 
        /// <returns>
        /// AdjustJMeterSceneSpeedResponse
        /// </returns>
        public AdjustJMeterSceneSpeedResponse AdjustJMeterSceneSpeed(AdjustJMeterSceneSpeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AdjustJMeterSceneSpeedWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adjusts the JMeter load.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AdjustJMeterSceneSpeedRequest
        /// </param>
        /// 
        /// <returns>
        /// AdjustJMeterSceneSpeedResponse
        /// </returns>
        public async Task<AdjustJMeterSceneSpeedResponse> AdjustJMeterSceneSpeedAsync(AdjustJMeterSceneSpeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AdjustJMeterSceneSpeedWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adjusts the stress in a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In concurrency mode, only the concurrency of the first API is passed as that of a session.
        /// In requests per second (RPS) mode, the RPS of each API can be adjusted. Make sure that the RPS decreases in the API order in the same session.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AdjustPtsSceneSpeedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AdjustPtsSceneSpeedResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adjusts the stress in a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In concurrency mode, only the concurrency of the first API is passed as that of a session.
        /// In requests per second (RPS) mode, the RPS of each API can be adjusted. Make sure that the RPS decreases in the API order in the same session.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AdjustPtsSceneSpeedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AdjustPtsSceneSpeedResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adjusts the stress in a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In concurrency mode, only the concurrency of the first API is passed as that of a session.
        /// In requests per second (RPS) mode, the RPS of each API can be adjusted. Make sure that the RPS decreases in the API order in the same session.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AdjustPtsSceneSpeedRequest
        /// </param>
        /// 
        /// <returns>
        /// AdjustPtsSceneSpeedResponse
        /// </returns>
        public AdjustPtsSceneSpeedResponse AdjustPtsSceneSpeed(AdjustPtsSceneSpeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AdjustPtsSceneSpeedWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adjusts the stress in a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In concurrency mode, only the concurrency of the first API is passed as that of a session.
        /// In requests per second (RPS) mode, the RPS of each API can be adjusted. Make sure that the RPS decreases in the API order in the same session.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AdjustPtsSceneSpeedRequest
        /// </param>
        /// 
        /// <returns>
        /// AdjustPtsSceneSpeedResponse
        /// </returns>
        public async Task<AdjustPtsSceneSpeedResponse> AdjustPtsSceneSpeedAsync(AdjustPtsSceneSpeedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AdjustPtsSceneSpeedWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a stress testing scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePtsSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePtsSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a stress testing scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePtsSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePtsSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a stress testing scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePtsSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePtsSceneResponse
        /// </returns>
        public CreatePtsSceneResponse CreatePtsScene(CreatePtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePtsSceneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a stress testing scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePtsSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePtsSceneResponse
        /// </returns>
        public async Task<CreatePtsSceneResponse> CreatePtsSceneAsync(CreatePtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePtsSceneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>null</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePtsSceneBaseLineFromReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePtsSceneBaseLineFromReportResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>null</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePtsSceneBaseLineFromReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePtsSceneBaseLineFromReportResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>null</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePtsSceneBaseLineFromReportRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePtsSceneBaseLineFromReportResponse
        /// </returns>
        public CreatePtsSceneBaseLineFromReportResponse CreatePtsSceneBaseLineFromReport(CreatePtsSceneBaseLineFromReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePtsSceneBaseLineFromReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>null</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePtsSceneBaseLineFromReportRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePtsSceneBaseLineFromReportResponse
        /// </returns>
        public async Task<CreatePtsSceneBaseLineFromReportResponse> CreatePtsSceneBaseLineFromReportAsync(CreatePtsSceneBaseLineFromReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePtsSceneBaseLineFromReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePtsSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePtsSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePtsSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePtsSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePtsSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePtsSceneResponse
        /// </returns>
        public DeletePtsSceneResponse DeletePtsScene(DeletePtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePtsSceneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePtsSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePtsSceneResponse
        /// </returns>
        public async Task<DeletePtsSceneResponse> DeletePtsSceneAsync(DeletePtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePtsSceneWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeletePtsSceneBaseLineRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePtsSceneBaseLineResponse
        /// </returns>
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

        /// <param name="request">
        /// DeletePtsSceneBaseLineRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePtsSceneBaseLineResponse
        /// </returns>
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

        /// <param name="request">
        /// DeletePtsSceneBaseLineRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePtsSceneBaseLineResponse
        /// </returns>
        public DeletePtsSceneBaseLineResponse DeletePtsSceneBaseLine(DeletePtsSceneBaseLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePtsSceneBaseLineWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeletePtsSceneBaseLineRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePtsSceneBaseLineResponse
        /// </returns>
        public async Task<DeletePtsSceneBaseLineResponse> DeletePtsSceneBaseLineAsync(DeletePtsSceneBaseLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePtsSceneBaseLineWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// DeletePtsScenesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePtsScenesResponse
        /// </returns>
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

        /// <param name="tmpReq">
        /// DeletePtsScenesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePtsScenesResponse
        /// </returns>
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

        /// <param name="request">
        /// DeletePtsScenesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePtsScenesResponse
        /// </returns>
        public DeletePtsScenesResponse DeletePtsScenes(DeletePtsScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePtsScenesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeletePtsScenesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePtsScenesResponse
        /// </returns>
        public async Task<DeletePtsScenesResponse> DeletePtsScenesAsync(DeletePtsScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePtsScenesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all supported regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllRegionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all supported regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllRegionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all supported regions.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAllRegionsResponse
        /// </returns>
        public GetAllRegionsResponse GetAllRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAllRegionsWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all supported regions.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAllRegionsResponse
        /// </returns>
        public async Task<GetAllRegionsResponse> GetAllRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAllRegionsWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the operational logs of JMeter stress testers. By default, the operational logs of the stress tester identified as number 0 are queried and the total number of stress testers is returned.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJMeterLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJMeterLogsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the operational logs of JMeter stress testers. By default, the operational logs of the stress tester identified as number 0 are queried and the total number of stress testers is returned.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJMeterLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJMeterLogsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the operational logs of JMeter stress testers. By default, the operational logs of the stress tester identified as number 0 are queried and the total number of stress testers is returned.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJMeterLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJMeterLogsResponse
        /// </returns>
        public GetJMeterLogsResponse GetJMeterLogs(GetJMeterLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJMeterLogsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the operational logs of JMeter stress testers. By default, the operational logs of the stress tester identified as number 0 are queried and the total number of stress testers is returned.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJMeterLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJMeterLogsResponse
        /// </returns>
        public async Task<GetJMeterLogsResponse> GetJMeterLogsAsync(GetJMeterLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJMeterLogsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a JMeter report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJMeterReportDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJMeterReportDetailsResponse
        /// </returns>
        public GetJMeterReportDetailsResponse GetJMeterReportDetailsWithOptions(GetJMeterReportDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJMeterReportDetails",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJMeterReportDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a JMeter report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJMeterReportDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJMeterReportDetailsResponse
        /// </returns>
        public async Task<GetJMeterReportDetailsResponse> GetJMeterReportDetailsWithOptionsAsync(GetJMeterReportDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJMeterReportDetails",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJMeterReportDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a JMeter report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJMeterReportDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJMeterReportDetailsResponse
        /// </returns>
        public GetJMeterReportDetailsResponse GetJMeterReportDetails(GetJMeterReportDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJMeterReportDetailsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a JMeter report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJMeterReportDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJMeterReportDetailsResponse
        /// </returns>
        public async Task<GetJMeterReportDetailsResponse> GetJMeterReportDetailsAsync(GetJMeterReportDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJMeterReportDetailsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metrics of JMeter samplers based on specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJMeterSampleMetricsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJMeterSampleMetricsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metrics of JMeter samplers based on specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJMeterSampleMetricsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJMeterSampleMetricsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metrics of JMeter samplers based on specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJMeterSampleMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJMeterSampleMetricsResponse
        /// </returns>
        public GetJMeterSampleMetricsResponse GetJMeterSampleMetrics(GetJMeterSampleMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJMeterSampleMetricsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metrics of JMeter samplers based on specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJMeterSampleMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJMeterSampleMetricsResponse
        /// </returns>
        public async Task<GetJMeterSampleMetricsResponse> GetJMeterSampleMetricsAsync(GetJMeterSampleMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJMeterSampleMetricsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the sampling logs of a JMeter sampler.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJMeterSamplingLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJMeterSamplingLogsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the sampling logs of a JMeter sampler.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJMeterSamplingLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJMeterSamplingLogsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the sampling logs of a JMeter sampler.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJMeterSamplingLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJMeterSamplingLogsResponse
        /// </returns>
        public GetJMeterSamplingLogsResponse GetJMeterSamplingLogs(GetJMeterSamplingLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJMeterSamplingLogsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the sampling logs of a JMeter sampler.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJMeterSamplingLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJMeterSamplingLogsResponse
        /// </returns>
        public async Task<GetJMeterSamplingLogsResponse> GetJMeterSamplingLogsAsync(GetJMeterSamplingLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJMeterSamplingLogsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries data that is generated during the stress testing of a JMeter scenario based on the ID of the scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJMeterSceneRunningDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJMeterSceneRunningDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries data that is generated during the stress testing of a JMeter scenario based on the ID of the scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJMeterSceneRunningDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJMeterSceneRunningDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries data that is generated during the stress testing of a JMeter scenario based on the ID of the scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJMeterSceneRunningDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJMeterSceneRunningDataResponse
        /// </returns>
        public GetJMeterSceneRunningDataResponse GetJMeterSceneRunningData(GetJMeterSceneRunningDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJMeterSceneRunningDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries data that is generated during the stress testing of a JMeter scenario based on the ID of the scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJMeterSceneRunningDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJMeterSceneRunningDataResponse
        /// </returns>
        public async Task<GetJMeterSceneRunningDataResponse> GetJMeterSceneRunningDataAsync(GetJMeterSceneRunningDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJMeterSceneRunningDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOpenJMeterSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOpenJMeterSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOpenJMeterSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOpenJMeterSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOpenJMeterSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOpenJMeterSceneResponse
        /// </returns>
        public GetOpenJMeterSceneResponse GetOpenJMeterScene(GetOpenJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOpenJMeterSceneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOpenJMeterSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOpenJMeterSceneResponse
        /// </returns>
        public async Task<GetOpenJMeterSceneResponse> GetOpenJMeterSceneAsync(GetOpenJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOpenJMeterSceneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the sampling logs for a Performance Testing Service (PTS) debugging task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsDebugSampleLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPtsDebugSampleLogsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the sampling logs for a Performance Testing Service (PTS) debugging task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsDebugSampleLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPtsDebugSampleLogsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the sampling logs for a Performance Testing Service (PTS) debugging task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsDebugSampleLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPtsDebugSampleLogsResponse
        /// </returns>
        public GetPtsDebugSampleLogsResponse GetPtsDebugSampleLogs(GetPtsDebugSampleLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPtsDebugSampleLogsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the sampling logs for a Performance Testing Service (PTS) debugging task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsDebugSampleLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPtsDebugSampleLogsResponse
        /// </returns>
        public async Task<GetPtsDebugSampleLogsResponse> GetPtsDebugSampleLogsAsync(GetPtsDebugSampleLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPtsDebugSampleLogsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a report for a performance testing task in a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsReportDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPtsReportDetailsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a report for a performance testing task in a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsReportDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPtsReportDetailsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a report for a performance testing task in a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsReportDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPtsReportDetailsResponse
        /// </returns>
        public GetPtsReportDetailsResponse GetPtsReportDetails(GetPtsReportDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPtsReportDetailsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a report for a performance testing task in a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsReportDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPtsReportDetailsResponse
        /// </returns>
        public async Task<GetPtsReportDetailsResponse> GetPtsReportDetailsAsync(GetPtsReportDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPtsReportDetailsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all reports of multiple scenarios that are generated during the stress testing in batch.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsReportsBySceneIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPtsReportsBySceneIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all reports of multiple scenarios that are generated during the stress testing in batch.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsReportsBySceneIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPtsReportsBySceneIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all reports of multiple scenarios that are generated during the stress testing in batch.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsReportsBySceneIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPtsReportsBySceneIdResponse
        /// </returns>
        public GetPtsReportsBySceneIdResponse GetPtsReportsBySceneId(GetPtsReportsBySceneIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPtsReportsBySceneIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all reports of multiple scenarios that are generated during the stress testing in batch.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsReportsBySceneIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPtsReportsBySceneIdResponse
        /// </returns>
        public async Task<GetPtsReportsBySceneIdResponse> GetPtsReportsBySceneIdAsync(GetPtsReportsBySceneIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPtsReportsBySceneIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the structure and load settings of a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPtsSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the structure and load settings of a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPtsSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the structure and load settings of a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPtsSceneResponse
        /// </returns>
        public GetPtsSceneResponse GetPtsScene(GetPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPtsSceneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the structure and load settings of a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPtsSceneResponse
        /// </returns>
        public async Task<GetPtsSceneResponse> GetPtsSceneAsync(GetPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPtsSceneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>null</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsSceneBaseLineRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPtsSceneBaseLineResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>null</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsSceneBaseLineRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPtsSceneBaseLineResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>null</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsSceneBaseLineRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPtsSceneBaseLineResponse
        /// </returns>
        public GetPtsSceneBaseLineResponse GetPtsSceneBaseLine(GetPtsSceneBaseLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPtsSceneBaseLineWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>null</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsSceneBaseLineRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPtsSceneBaseLineResponse
        /// </returns>
        public async Task<GetPtsSceneBaseLineResponse> GetPtsSceneBaseLineAsync(GetPtsSceneBaseLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPtsSceneBaseLineWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the runtime data of a stress testing or debugging scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsSceneRunningDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPtsSceneRunningDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the runtime data of a stress testing or debugging scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsSceneRunningDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPtsSceneRunningDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the runtime data of a stress testing or debugging scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsSceneRunningDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPtsSceneRunningDataResponse
        /// </returns>
        public GetPtsSceneRunningDataResponse GetPtsSceneRunningData(GetPtsSceneRunningDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPtsSceneRunningDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the runtime data of a stress testing or debugging scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsSceneRunningDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPtsSceneRunningDataResponse
        /// </returns>
        public async Task<GetPtsSceneRunningDataResponse> GetPtsSceneRunningDataAsync(GetPtsSceneRunningDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPtsSceneRunningDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the runtime status of a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsSceneRunningStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPtsSceneRunningStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the runtime status of a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsSceneRunningStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPtsSceneRunningStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the runtime status of a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsSceneRunningStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPtsSceneRunningStatusResponse
        /// </returns>
        public GetPtsSceneRunningStatusResponse GetPtsSceneRunningStatus(GetPtsSceneRunningStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPtsSceneRunningStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the runtime status of a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPtsSceneRunningStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPtsSceneRunningStatusResponse
        /// </returns>
        public async Task<GetPtsSceneRunningStatusResponse> GetPtsSceneRunningStatusAsync(GetPtsSceneRunningStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPtsSceneRunningStatusWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetUserVpcSecurityGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserVpcSecurityGroupResponse
        /// </returns>
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

        /// <param name="request">
        /// GetUserVpcSecurityGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserVpcSecurityGroupResponse
        /// </returns>
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

        /// <param name="request">
        /// GetUserVpcSecurityGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserVpcSecurityGroupResponse
        /// </returns>
        public GetUserVpcSecurityGroupResponse GetUserVpcSecurityGroup(GetUserVpcSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserVpcSecurityGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetUserVpcSecurityGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserVpcSecurityGroupResponse
        /// </returns>
        public async Task<GetUserVpcSecurityGroupResponse> GetUserVpcSecurityGroupAsync(GetUserVpcSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserVpcSecurityGroupWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetUserVpcVSwitchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserVpcVSwitchResponse
        /// </returns>
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

        /// <param name="request">
        /// GetUserVpcVSwitchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserVpcVSwitchResponse
        /// </returns>
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

        /// <param name="request">
        /// GetUserVpcVSwitchRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserVpcVSwitchResponse
        /// </returns>
        public GetUserVpcVSwitchResponse GetUserVpcVSwitch(GetUserVpcVSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserVpcVSwitchWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetUserVpcVSwitchRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserVpcVSwitchResponse
        /// </returns>
        public async Task<GetUserVpcVSwitchResponse> GetUserVpcVSwitchAsync(GetUserVpcVSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserVpcVSwitchWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetUserVpcsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserVpcsResponse
        /// </returns>
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

        /// <param name="request">
        /// GetUserVpcsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserVpcsResponse
        /// </returns>
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

        /// <param name="request">
        /// GetUserVpcsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserVpcsResponse
        /// </returns>
        public GetUserVpcsResponse GetUserVpcs(GetUserVpcsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserVpcsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetUserVpcsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserVpcsResponse
        /// </returns>
        public async Task<GetUserVpcsResponse> GetUserVpcsAsync(GetUserVpcsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserVpcsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about JMeter environments.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnvsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEnvsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about JMeter environments.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnvsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEnvsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about JMeter environments.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnvsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEnvsResponse
        /// </returns>
        public ListEnvsResponse ListEnvs(ListEnvsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEnvsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about JMeter environments.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnvsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEnvsResponse
        /// </returns>
        public async Task<ListEnvsResponse> ListEnvsAsync(ListEnvsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEnvsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries JMeter reports based on specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJMeterReportsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJMeterReportsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries JMeter reports based on specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJMeterReportsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJMeterReportsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries JMeter reports based on specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJMeterReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJMeterReportsResponse
        /// </returns>
        public ListJMeterReportsResponse ListJMeterReports(ListJMeterReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJMeterReportsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries JMeter reports based on specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJMeterReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJMeterReportsResponse
        /// </returns>
        public async Task<ListJMeterReportsResponse> ListJMeterReportsAsync(ListJMeterReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJMeterReportsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries JMeter scenarios based on a specified condition.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOpenJMeterScenesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOpenJMeterScenesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries JMeter scenarios based on a specified condition.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOpenJMeterScenesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOpenJMeterScenesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries JMeter scenarios based on a specified condition.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOpenJMeterScenesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOpenJMeterScenesResponse
        /// </returns>
        public ListOpenJMeterScenesResponse ListOpenJMeterScenes(ListOpenJMeterScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOpenJMeterScenesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries JMeter scenarios based on a specified condition.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOpenJMeterScenesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOpenJMeterScenesResponse
        /// </returns>
        public async Task<ListOpenJMeterScenesResponse> ListOpenJMeterScenesAsync(ListOpenJMeterScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOpenJMeterScenesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Performance Testing Service (PTS) reports based on specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPtsReportsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPtsReportsResponse
        /// </returns>
        public ListPtsReportsResponse ListPtsReportsWithOptions(ListPtsReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                body["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                body["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPtsReports",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPtsReportsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Performance Testing Service (PTS) reports based on specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPtsReportsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPtsReportsResponse
        /// </returns>
        public async Task<ListPtsReportsResponse> ListPtsReportsWithOptionsAsync(ListPtsReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                body["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                body["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPtsReports",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPtsReportsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Performance Testing Service (PTS) reports based on specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPtsReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPtsReportsResponse
        /// </returns>
        public ListPtsReportsResponse ListPtsReports(ListPtsReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPtsReportsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Performance Testing Service (PTS) reports based on specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPtsReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPtsReportsResponse
        /// </returns>
        public async Task<ListPtsReportsResponse> ListPtsReportsAsync(ListPtsReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPtsReportsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Performance Testing Service (PTS) scenarios by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPtsSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPtsSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Performance Testing Service (PTS) scenarios by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPtsSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPtsSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Performance Testing Service (PTS) scenarios by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPtsSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPtsSceneResponse
        /// </returns>
        public ListPtsSceneResponse ListPtsScene(ListPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPtsSceneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Performance Testing Service (PTS) scenarios by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPtsSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPtsSceneResponse
        /// </returns>
        public async Task<ListPtsSceneResponse> ListPtsSceneAsync(ListPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPtsSceneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取vpc配置信息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcConfigsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcConfigsResponse
        /// </returns>
        public ListVpcConfigsResponse ListVpcConfigsWithOptions(ListVpcConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                query["ConfigId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigName))
            {
                query["ConfigName"] = request.ConfigName;
            }
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
                Action = "ListVpcConfigs",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcConfigsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取vpc配置信息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcConfigsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcConfigsResponse
        /// </returns>
        public async Task<ListVpcConfigsResponse> ListVpcConfigsWithOptionsAsync(ListVpcConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                query["ConfigId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigName))
            {
                query["ConfigName"] = request.ConfigName;
            }
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
                Action = "ListVpcConfigs",
                Version = "2020-10-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取vpc配置信息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcConfigsResponse
        /// </returns>
        public ListVpcConfigsResponse ListVpcConfigs(ListVpcConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVpcConfigsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取vpc配置信息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcConfigsResponse
        /// </returns>
        public async Task<ListVpcConfigsResponse> ListVpcConfigsAsync(ListVpcConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVpcConfigsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>null</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPtsSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPtsSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>null</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPtsSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPtsSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>null</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPtsSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPtsSceneResponse
        /// </returns>
        public ModifyPtsSceneResponse ModifyPtsScene(ModifyPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPtsSceneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>null</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPtsSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPtsSceneResponse
        /// </returns>
        public async Task<ModifyPtsSceneResponse> ModifyPtsSceneAsync(ModifyPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPtsSceneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes the JMeter environment that corresponds to a specific JMeter environment ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveEnvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveEnvResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes the JMeter environment that corresponds to a specific JMeter environment ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveEnvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveEnvResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes the JMeter environment that corresponds to a specific JMeter environment ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveEnvRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveEnvResponse
        /// </returns>
        public RemoveEnvResponse RemoveEnv(RemoveEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveEnvWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes the JMeter environment that corresponds to a specific JMeter environment ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveEnvRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveEnvResponse
        /// </returns>
        public async Task<RemoveEnvResponse> RemoveEnvAsync(RemoveEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveEnvWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveOpenJMeterSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveOpenJMeterSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveOpenJMeterSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveOpenJMeterSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveOpenJMeterSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveOpenJMeterSceneResponse
        /// </returns>
        public RemoveOpenJMeterSceneResponse RemoveOpenJMeterScene(RemoveOpenJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveOpenJMeterSceneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveOpenJMeterSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveOpenJMeterSceneResponse
        /// </returns>
        public async Task<RemoveOpenJMeterSceneResponse> RemoveOpenJMeterSceneAsync(RemoveOpenJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveOpenJMeterSceneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates a JMeter environment.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SaveEnvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveEnvResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates a JMeter environment.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SaveEnvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveEnvResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates a JMeter environment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveEnvRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveEnvResponse
        /// </returns>
        public SaveEnvResponse SaveEnv(SaveEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveEnvWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates a JMeter environment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveEnvRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveEnvResponse
        /// </returns>
        public async Task<SaveEnvResponse> SaveEnvAsync(SaveEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveEnvWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SaveOpenJMeterSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveOpenJMeterSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SaveOpenJMeterSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveOpenJMeterSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveOpenJMeterSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveOpenJMeterSceneResponse
        /// </returns>
        public SaveOpenJMeterSceneResponse SaveOpenJMeterScene(SaveOpenJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveOpenJMeterSceneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveOpenJMeterSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveOpenJMeterSceneResponse
        /// </returns>
        public async Task<SaveOpenJMeterSceneResponse> SaveOpenJMeterSceneAsync(SaveOpenJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveOpenJMeterSceneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves or modifies a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SavePtsSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SavePtsSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves or modifies a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SavePtsSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SavePtsSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves or modifies a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SavePtsSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// SavePtsSceneResponse
        /// </returns>
        public SavePtsSceneResponse SavePtsScene(SavePtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SavePtsSceneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves or modifies a Performance Testing Service (PTS) scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SavePtsSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// SavePtsSceneResponse
        /// </returns>
        public async Task<SavePtsSceneResponse> SavePtsSceneAsync(SavePtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SavePtsSceneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts the debugging of a scenario to check whether the settings of the scenario take effect.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartDebugPtsSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartDebugPtsSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts the debugging of a scenario to check whether the settings of the scenario take effect.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartDebugPtsSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartDebugPtsSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts the debugging of a scenario to check whether the settings of the scenario take effect.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartDebugPtsSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// StartDebugPtsSceneResponse
        /// </returns>
        public StartDebugPtsSceneResponse StartDebugPtsScene(StartDebugPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDebugPtsSceneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts the debugging of a scenario to check whether the settings of the scenario take effect.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartDebugPtsSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// StartDebugPtsSceneResponse
        /// </returns>
        public async Task<StartDebugPtsSceneResponse> StartDebugPtsSceneAsync(StartDebugPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDebugPtsSceneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Debugs a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartDebuggingJMeterSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartDebuggingJMeterSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Debugs a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartDebuggingJMeterSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartDebuggingJMeterSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Debugs a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartDebuggingJMeterSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// StartDebuggingJMeterSceneResponse
        /// </returns>
        public StartDebuggingJMeterSceneResponse StartDebuggingJMeterScene(StartDebuggingJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDebuggingJMeterSceneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Debugs a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartDebuggingJMeterSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// StartDebuggingJMeterSceneResponse
        /// </returns>
        public async Task<StartDebuggingJMeterSceneResponse> StartDebuggingJMeterSceneAsync(StartDebuggingJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDebuggingJMeterSceneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a scenario by using its ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartPtsSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartPtsSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a scenario by using its ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartPtsSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartPtsSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a scenario by using its ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartPtsSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// StartPtsSceneResponse
        /// </returns>
        public StartPtsSceneResponse StartPtsScene(StartPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartPtsSceneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a scenario by using its ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartPtsSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// StartPtsSceneResponse
        /// </returns>
        public async Task<StartPtsSceneResponse> StartPtsSceneAsync(StartPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartPtsSceneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts performance testing in a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTestingJMeterSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartTestingJMeterSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts performance testing in a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTestingJMeterSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartTestingJMeterSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts performance testing in a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTestingJMeterSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// StartTestingJMeterSceneResponse
        /// </returns>
        public StartTestingJMeterSceneResponse StartTestingJMeterScene(StartTestingJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartTestingJMeterSceneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts performance testing in a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTestingJMeterSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// StartTestingJMeterSceneResponse
        /// </returns>
        public async Task<StartTestingJMeterSceneResponse> StartTestingJMeterSceneAsync(StartTestingJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartTestingJMeterSceneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the scenario that is in debugging.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopDebugPtsSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopDebugPtsSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the scenario that is in debugging.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopDebugPtsSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopDebugPtsSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the scenario that is in debugging.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopDebugPtsSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// StopDebugPtsSceneResponse
        /// </returns>
        public StopDebugPtsSceneResponse StopDebugPtsScene(StopDebugPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDebugPtsSceneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the scenario that is in debugging.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopDebugPtsSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// StopDebugPtsSceneResponse
        /// </returns>
        public async Task<StopDebugPtsSceneResponse> StopDebugPtsSceneAsync(StopDebugPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDebugPtsSceneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the debugging of a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopDebuggingJMeterSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopDebuggingJMeterSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the debugging of a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopDebuggingJMeterSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopDebuggingJMeterSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the debugging of a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopDebuggingJMeterSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// StopDebuggingJMeterSceneResponse
        /// </returns>
        public StopDebuggingJMeterSceneResponse StopDebuggingJMeterScene(StopDebuggingJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDebuggingJMeterSceneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the debugging of a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopDebuggingJMeterSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// StopDebuggingJMeterSceneResponse
        /// </returns>
        public async Task<StopDebuggingJMeterSceneResponse> StopDebuggingJMeterSceneAsync(StopDebuggingJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDebuggingJMeterSceneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a scenario by using its ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopPtsSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopPtsSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a scenario by using its ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopPtsSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopPtsSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a scenario by using its ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopPtsSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// StopPtsSceneResponse
        /// </returns>
        public StopPtsSceneResponse StopPtsScene(StopPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopPtsSceneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a scenario by using its ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopPtsSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// StopPtsSceneResponse
        /// </returns>
        public async Task<StopPtsSceneResponse> StopPtsSceneAsync(StopPtsSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopPtsSceneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops performance testing by using a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopTestingJMeterSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopTestingJMeterSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops performance testing by using a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopTestingJMeterSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopTestingJMeterSceneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops performance testing by using a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopTestingJMeterSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// StopTestingJMeterSceneResponse
        /// </returns>
        public StopTestingJMeterSceneResponse StopTestingJMeterScene(StopTestingJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopTestingJMeterSceneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops performance testing by using a JMeter scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopTestingJMeterSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// StopTestingJMeterSceneResponse
        /// </returns>
        public async Task<StopTestingJMeterSceneResponse> StopTestingJMeterSceneAsync(StopTestingJMeterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopTestingJMeterSceneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>null</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdatePtsSceneBaseLineRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePtsSceneBaseLineResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>null</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdatePtsSceneBaseLineRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePtsSceneBaseLineResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>null</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePtsSceneBaseLineRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePtsSceneBaseLineResponse
        /// </returns>
        public UpdatePtsSceneBaseLineResponse UpdatePtsSceneBaseLine(UpdatePtsSceneBaseLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePtsSceneBaseLineWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>null</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePtsSceneBaseLineRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePtsSceneBaseLineResponse
        /// </returns>
        public async Task<UpdatePtsSceneBaseLineResponse> UpdatePtsSceneBaseLineAsync(UpdatePtsSceneBaseLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePtsSceneBaseLineWithOptionsAsync(request, runtime);
        }

    }
}
