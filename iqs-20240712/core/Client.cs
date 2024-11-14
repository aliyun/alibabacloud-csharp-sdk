// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.IQS20240712.Models;

namespace AlibabaCloud.SDK.IQS20240712
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("iqs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>根据起终点坐标检索符合条件的骑行路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BicyclingDirectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BicyclingDirectionResponse
        /// </returns>
        public BicyclingDirectionResponse BicyclingDirectionWithOptions(BicyclingDirectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLatitude))
            {
                query["destinationLatitude"] = request.DestinationLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLongitude))
            {
                query["destinationLongitude"] = request.DestinationLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLatitude))
            {
                query["originLatitude"] = request.OriginLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLongitude))
            {
                query["originLongitude"] = request.OriginLongitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BicyclingDirection",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/direction/bicycling",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BicyclingDirectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的骑行路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BicyclingDirectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BicyclingDirectionResponse
        /// </returns>
        public async Task<BicyclingDirectionResponse> BicyclingDirectionWithOptionsAsync(BicyclingDirectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLatitude))
            {
                query["destinationLatitude"] = request.DestinationLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLongitude))
            {
                query["destinationLongitude"] = request.DestinationLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLatitude))
            {
                query["originLatitude"] = request.OriginLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLongitude))
            {
                query["originLongitude"] = request.OriginLongitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BicyclingDirection",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/direction/bicycling",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BicyclingDirectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的骑行路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BicyclingDirectionRequest
        /// </param>
        /// 
        /// <returns>
        /// BicyclingDirectionResponse
        /// </returns>
        public BicyclingDirectionResponse BicyclingDirection(BicyclingDirectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BicyclingDirectionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的骑行路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BicyclingDirectionRequest
        /// </param>
        /// 
        /// <returns>
        /// BicyclingDirectionResponse
        /// </returns>
        public async Task<BicyclingDirectionResponse> BicyclingDirectionAsync(BicyclingDirectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BicyclingDirectionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的骑行路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BicyclingDirectionNovaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BicyclingDirectionNovaResponse
        /// </returns>
        public BicyclingDirectionNovaResponse BicyclingDirectionNovaWithOptions(BicyclingDirectionNovaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLatitude))
            {
                query["destinationLatitude"] = request.DestinationLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLongitude))
            {
                query["destinationLongitude"] = request.DestinationLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLatitude))
            {
                query["originLatitude"] = request.OriginLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLongitude))
            {
                query["originLongitude"] = request.OriginLongitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BicyclingDirectionNova",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v2/direction/bicycling",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BicyclingDirectionNovaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的骑行路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BicyclingDirectionNovaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BicyclingDirectionNovaResponse
        /// </returns>
        public async Task<BicyclingDirectionNovaResponse> BicyclingDirectionNovaWithOptionsAsync(BicyclingDirectionNovaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLatitude))
            {
                query["destinationLatitude"] = request.DestinationLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLongitude))
            {
                query["destinationLongitude"] = request.DestinationLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLatitude))
            {
                query["originLatitude"] = request.OriginLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLongitude))
            {
                query["originLongitude"] = request.OriginLongitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BicyclingDirectionNova",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v2/direction/bicycling",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BicyclingDirectionNovaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的骑行路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BicyclingDirectionNovaRequest
        /// </param>
        /// 
        /// <returns>
        /// BicyclingDirectionNovaResponse
        /// </returns>
        public BicyclingDirectionNovaResponse BicyclingDirectionNova(BicyclingDirectionNovaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BicyclingDirectionNovaWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的骑行路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BicyclingDirectionNovaRequest
        /// </param>
        /// 
        /// <returns>
        /// BicyclingDirectionNovaResponse
        /// </returns>
        public async Task<BicyclingDirectionNovaResponse> BicyclingDirectionNovaAsync(BicyclingDirectionNovaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BicyclingDirectionNovaWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时查询圆形区域内的交通信息查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CircleTrafficStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CircleTrafficStatusResponse
        /// </returns>
        public CircleTrafficStatusResponse CircleTrafficStatusWithOptions(CircleTrafficStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Latitude))
            {
                query["latitude"] = request.Latitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Longitude))
            {
                query["longitude"] = request.Longitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Radius))
            {
                query["radius"] = request.Radius;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoadLevel))
            {
                query["roadLevel"] = request.RoadLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CircleTrafficStatus",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/traffic/status/circle",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CircleTrafficStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时查询圆形区域内的交通信息查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CircleTrafficStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CircleTrafficStatusResponse
        /// </returns>
        public async Task<CircleTrafficStatusResponse> CircleTrafficStatusWithOptionsAsync(CircleTrafficStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Latitude))
            {
                query["latitude"] = request.Latitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Longitude))
            {
                query["longitude"] = request.Longitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Radius))
            {
                query["radius"] = request.Radius;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoadLevel))
            {
                query["roadLevel"] = request.RoadLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CircleTrafficStatus",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/traffic/status/circle",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CircleTrafficStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时查询圆形区域内的交通信息查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CircleTrafficStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// CircleTrafficStatusResponse
        /// </returns>
        public CircleTrafficStatusResponse CircleTrafficStatus(CircleTrafficStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CircleTrafficStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时查询圆形区域内的交通信息查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CircleTrafficStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// CircleTrafficStatusResponse
        /// </returns>
        public async Task<CircleTrafficStatusResponse> CircleTrafficStatusAsync(CircleTrafficStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CircleTrafficStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自然语言通用查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CommonQueryBySceneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CommonQueryBySceneResponse
        /// </returns>
        public CommonQueryBySceneResponse CommonQueryBySceneWithOptions(CommonQueryBySceneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommonQueryByScene",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/amap-function-call-agent/iqs-agent-service/v2/nl/common",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommonQueryBySceneResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自然语言通用查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CommonQueryBySceneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CommonQueryBySceneResponse
        /// </returns>
        public async Task<CommonQueryBySceneResponse> CommonQueryBySceneWithOptionsAsync(CommonQueryBySceneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommonQueryByScene",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/amap-function-call-agent/iqs-agent-service/v2/nl/common",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommonQueryBySceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自然语言通用查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CommonQueryBySceneRequest
        /// </param>
        /// 
        /// <returns>
        /// CommonQueryBySceneResponse
        /// </returns>
        public CommonQueryBySceneResponse CommonQueryByScene(CommonQueryBySceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CommonQueryBySceneWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自然语言通用查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CommonQueryBySceneRequest
        /// </param>
        /// 
        /// <returns>
        /// CommonQueryBySceneResponse
        /// </returns>
        public async Task<CommonQueryBySceneResponse> CommonQueryBySceneAsync(CommonQueryBySceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CommonQueryBySceneWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的驾车路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DrivingDirectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DrivingDirectionResponse
        /// </returns>
        public DrivingDirectionResponse DrivingDirectionWithOptions(DrivingDirectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLatitude))
            {
                query["destinationLatitude"] = request.DestinationLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLongitude))
            {
                query["destinationLongitude"] = request.DestinationLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLatitude))
            {
                query["originLatitude"] = request.OriginLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLongitude))
            {
                query["originLongitude"] = request.OriginLongitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DrivingDirection",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/direction/driving",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DrivingDirectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的驾车路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DrivingDirectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DrivingDirectionResponse
        /// </returns>
        public async Task<DrivingDirectionResponse> DrivingDirectionWithOptionsAsync(DrivingDirectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLatitude))
            {
                query["destinationLatitude"] = request.DestinationLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLongitude))
            {
                query["destinationLongitude"] = request.DestinationLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLatitude))
            {
                query["originLatitude"] = request.OriginLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLongitude))
            {
                query["originLongitude"] = request.OriginLongitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DrivingDirection",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/direction/driving",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DrivingDirectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的驾车路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DrivingDirectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DrivingDirectionResponse
        /// </returns>
        public DrivingDirectionResponse DrivingDirection(DrivingDirectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DrivingDirectionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的驾车路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DrivingDirectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DrivingDirectionResponse
        /// </returns>
        public async Task<DrivingDirectionResponse> DrivingDirectionAsync(DrivingDirectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DrivingDirectionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的驾车路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DrivingDirectionNovaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DrivingDirectionNovaResponse
        /// </returns>
        public DrivingDirectionNovaResponse DrivingDirectionNovaWithOptions(DrivingDirectionNovaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CarType))
            {
                query["carType"] = request.CarType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLatitude))
            {
                query["destinationLatitude"] = request.DestinationLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLongitude))
            {
                query["destinationLongitude"] = request.DestinationLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLatitude))
            {
                query["originLatitude"] = request.OriginLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLongitude))
            {
                query["originLongitude"] = request.OriginLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Plate))
            {
                query["plate"] = request.Plate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DrivingDirectionNova",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v2/direction/driving",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DrivingDirectionNovaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的驾车路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DrivingDirectionNovaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DrivingDirectionNovaResponse
        /// </returns>
        public async Task<DrivingDirectionNovaResponse> DrivingDirectionNovaWithOptionsAsync(DrivingDirectionNovaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CarType))
            {
                query["carType"] = request.CarType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLatitude))
            {
                query["destinationLatitude"] = request.DestinationLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLongitude))
            {
                query["destinationLongitude"] = request.DestinationLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLatitude))
            {
                query["originLatitude"] = request.OriginLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLongitude))
            {
                query["originLongitude"] = request.OriginLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Plate))
            {
                query["plate"] = request.Plate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DrivingDirectionNova",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v2/direction/driving",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DrivingDirectionNovaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的驾车路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DrivingDirectionNovaRequest
        /// </param>
        /// 
        /// <returns>
        /// DrivingDirectionNovaResponse
        /// </returns>
        public DrivingDirectionNovaResponse DrivingDirectionNova(DrivingDirectionNovaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DrivingDirectionNovaWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的驾车路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DrivingDirectionNovaRequest
        /// </param>
        /// 
        /// <returns>
        /// DrivingDirectionNovaResponse
        /// </returns>
        public async Task<DrivingDirectionNovaResponse> DrivingDirectionNovaAsync(DrivingDirectionNovaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DrivingDirectionNovaWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的电动车路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ElectrobikeDirectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ElectrobikeDirectionResponse
        /// </returns>
        public ElectrobikeDirectionResponse ElectrobikeDirectionWithOptions(ElectrobikeDirectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLatitude))
            {
                query["destinationLatitude"] = request.DestinationLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLongitude))
            {
                query["destinationLongitude"] = request.DestinationLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLatitude))
            {
                query["originLatitude"] = request.OriginLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLongitude))
            {
                query["originLongitude"] = request.OriginLongitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ElectrobikeDirection",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/direction/electrobike",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ElectrobikeDirectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的电动车路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ElectrobikeDirectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ElectrobikeDirectionResponse
        /// </returns>
        public async Task<ElectrobikeDirectionResponse> ElectrobikeDirectionWithOptionsAsync(ElectrobikeDirectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLatitude))
            {
                query["destinationLatitude"] = request.DestinationLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLongitude))
            {
                query["destinationLongitude"] = request.DestinationLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLatitude))
            {
                query["originLatitude"] = request.OriginLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLongitude))
            {
                query["originLongitude"] = request.OriginLongitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ElectrobikeDirection",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/direction/electrobike",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ElectrobikeDirectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的电动车路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ElectrobikeDirectionRequest
        /// </param>
        /// 
        /// <returns>
        /// ElectrobikeDirectionResponse
        /// </returns>
        public ElectrobikeDirectionResponse ElectrobikeDirection(ElectrobikeDirectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ElectrobikeDirectionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的电动车路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ElectrobikeDirectionRequest
        /// </param>
        /// 
        /// <returns>
        /// ElectrobikeDirectionResponse
        /// </returns>
        public async Task<ElectrobikeDirectionResponse> ElectrobikeDirectionAsync(ElectrobikeDirectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ElectrobikeDirectionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>电动车路线规划方案V2</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ElectrobikeDirectionNovaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ElectrobikeDirectionNovaResponse
        /// </returns>
        public ElectrobikeDirectionNovaResponse ElectrobikeDirectionNovaWithOptions(ElectrobikeDirectionNovaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLatitude))
            {
                query["destinationLatitude"] = request.DestinationLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLongitude))
            {
                query["destinationLongitude"] = request.DestinationLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLatitude))
            {
                query["originLatitude"] = request.OriginLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLongitude))
            {
                query["originLongitude"] = request.OriginLongitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ElectrobikeDirectionNova",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v2/direction/electrobike",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ElectrobikeDirectionNovaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>电动车路线规划方案V2</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ElectrobikeDirectionNovaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ElectrobikeDirectionNovaResponse
        /// </returns>
        public async Task<ElectrobikeDirectionNovaResponse> ElectrobikeDirectionNovaWithOptionsAsync(ElectrobikeDirectionNovaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLatitude))
            {
                query["destinationLatitude"] = request.DestinationLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLongitude))
            {
                query["destinationLongitude"] = request.DestinationLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLatitude))
            {
                query["originLatitude"] = request.OriginLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLongitude))
            {
                query["originLongitude"] = request.OriginLongitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ElectrobikeDirectionNova",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v2/direction/electrobike",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ElectrobikeDirectionNovaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>电动车路线规划方案V2</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ElectrobikeDirectionNovaRequest
        /// </param>
        /// 
        /// <returns>
        /// ElectrobikeDirectionNovaResponse
        /// </returns>
        public ElectrobikeDirectionNovaResponse ElectrobikeDirectionNova(ElectrobikeDirectionNovaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ElectrobikeDirectionNovaWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>电动车路线规划方案V2</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ElectrobikeDirectionNovaRequest
        /// </param>
        /// 
        /// <returns>
        /// ElectrobikeDirectionNovaResponse
        /// </returns>
        public async Task<ElectrobikeDirectionNovaResponse> ElectrobikeDirectionNovaAsync(ElectrobikeDirectionNovaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ElectrobikeDirectionNovaWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>地理编码，将详细的结构化地址转换为高德经纬度坐标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GeoCodeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GeoCodeResponse
        /// </returns>
        public GeoCodeResponse GeoCodeWithOptions(GeoCodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["city"] = request.City;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GeoCode",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/geocode/geo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GeoCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>地理编码，将详细的结构化地址转换为高德经纬度坐标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GeoCodeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GeoCodeResponse
        /// </returns>
        public async Task<GeoCodeResponse> GeoCodeWithOptionsAsync(GeoCodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["city"] = request.City;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GeoCode",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/geocode/geo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GeoCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>地理编码，将详细的结构化地址转换为高德经纬度坐标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GeoCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GeoCodeResponse
        /// </returns>
        public GeoCodeResponse GeoCode(GeoCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GeoCodeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>地理编码，将详细的结构化地址转换为高德经纬度坐标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GeoCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GeoCodeResponse
        /// </returns>
        public async Task<GeoCodeResponse> GeoCodeAsync(GeoCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GeoCodeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过经纬度查询附近的地点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NearbySearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NearbySearchResponse
        /// </returns>
        public NearbySearchResponse NearbySearchWithOptions(NearbySearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                query["keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Latitude))
            {
                query["latitude"] = request.Latitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Longitude))
            {
                query["longitude"] = request.Longitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Radius))
            {
                query["radius"] = request.Radius;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NearbySearch",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/pois/nearby",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<NearbySearchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过经纬度查询附近的地点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NearbySearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NearbySearchResponse
        /// </returns>
        public async Task<NearbySearchResponse> NearbySearchWithOptionsAsync(NearbySearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                query["keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Latitude))
            {
                query["latitude"] = request.Latitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Longitude))
            {
                query["longitude"] = request.Longitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Radius))
            {
                query["radius"] = request.Radius;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NearbySearch",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/pois/nearby",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<NearbySearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过经纬度查询附近的地点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NearbySearchRequest
        /// </param>
        /// 
        /// <returns>
        /// NearbySearchResponse
        /// </returns>
        public NearbySearchResponse NearbySearch(NearbySearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return NearbySearchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过经纬度查询附近的地点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NearbySearchRequest
        /// </param>
        /// 
        /// <returns>
        /// NearbySearchResponse
        /// </returns>
        public async Task<NearbySearchResponse> NearbySearchAsync(NearbySearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await NearbySearchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过经纬度查询附近的地点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NearbySearchNovaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NearbySearchNovaResponse
        /// </returns>
        public NearbySearchNovaResponse NearbySearchNovaWithOptions(NearbySearchNovaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                query["keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Latitude))
            {
                query["latitude"] = request.Latitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Longitude))
            {
                query["longitude"] = request.Longitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Radius))
            {
                query["radius"] = request.Radius;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NearbySearchNova",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v2/pois/nearby",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<NearbySearchNovaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过经纬度查询附近的地点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NearbySearchNovaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NearbySearchNovaResponse
        /// </returns>
        public async Task<NearbySearchNovaResponse> NearbySearchNovaWithOptionsAsync(NearbySearchNovaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                query["keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Latitude))
            {
                query["latitude"] = request.Latitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Longitude))
            {
                query["longitude"] = request.Longitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Radius))
            {
                query["radius"] = request.Radius;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NearbySearchNova",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v2/pois/nearby",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<NearbySearchNovaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过经纬度查询附近的地点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NearbySearchNovaRequest
        /// </param>
        /// 
        /// <returns>
        /// NearbySearchNovaResponse
        /// </returns>
        public NearbySearchNovaResponse NearbySearchNova(NearbySearchNovaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return NearbySearchNovaWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过经纬度查询附近的地点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NearbySearchNovaRequest
        /// </param>
        /// 
        /// <returns>
        /// NearbySearchNovaResponse
        /// </returns>
        public async Task<NearbySearchNovaResponse> NearbySearchNovaAsync(NearbySearchNovaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await NearbySearchNovaWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过关键词搜索地点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PlaceSearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PlaceSearchResponse
        /// </returns>
        public PlaceSearchResponse PlaceSearchWithOptions(PlaceSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                query["keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PlaceSearch",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/pois/place",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PlaceSearchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过关键词搜索地点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PlaceSearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PlaceSearchResponse
        /// </returns>
        public async Task<PlaceSearchResponse> PlaceSearchWithOptionsAsync(PlaceSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                query["keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PlaceSearch",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/pois/place",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PlaceSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过关键词搜索地点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PlaceSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// PlaceSearchResponse
        /// </returns>
        public PlaceSearchResponse PlaceSearch(PlaceSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PlaceSearchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过关键词搜索地点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PlaceSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// PlaceSearchResponse
        /// </returns>
        public async Task<PlaceSearchResponse> PlaceSearchAsync(PlaceSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PlaceSearchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过关键词搜索地点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PlaceSearchNovaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PlaceSearchNovaResponse
        /// </returns>
        public PlaceSearchNovaResponse PlaceSearchNovaWithOptions(PlaceSearchNovaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                query["keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PlaceSearchNova",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v2/pois/place",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PlaceSearchNovaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过关键词搜索地点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PlaceSearchNovaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PlaceSearchNovaResponse
        /// </returns>
        public async Task<PlaceSearchNovaResponse> PlaceSearchNovaWithOptionsAsync(PlaceSearchNovaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                query["keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PlaceSearchNova",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v2/pois/place",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PlaceSearchNovaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过关键词搜索地点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PlaceSearchNovaRequest
        /// </param>
        /// 
        /// <returns>
        /// PlaceSearchNovaResponse
        /// </returns>
        public PlaceSearchNovaResponse PlaceSearchNova(PlaceSearchNovaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PlaceSearchNovaWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过关键词搜索地点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PlaceSearchNovaRequest
        /// </param>
        /// 
        /// <returns>
        /// PlaceSearchNovaResponse
        /// </returns>
        public async Task<PlaceSearchNovaResponse> PlaceSearchNovaAsync(PlaceSearchNovaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PlaceSearchNovaWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>景点查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAttractionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAttractionsResponse
        /// </returns>
        public QueryAttractionsResponse QueryAttractionsWithOptions(QueryAttractionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAttractions",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/amap-function-call-agent/iqs-agent-service/v1/nl/attractions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAttractionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>景点查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAttractionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAttractionsResponse
        /// </returns>
        public async Task<QueryAttractionsResponse> QueryAttractionsWithOptionsAsync(QueryAttractionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAttractions",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/amap-function-call-agent/iqs-agent-service/v1/nl/attractions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAttractionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>景点查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAttractionsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAttractionsResponse
        /// </returns>
        public QueryAttractionsResponse QueryAttractions(QueryAttractionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryAttractionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>景点查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAttractionsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAttractionsResponse
        /// </returns>
        public async Task<QueryAttractionsResponse> QueryAttractionsAsync(QueryAttractionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryAttractionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHotelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryHotelsResponse
        /// </returns>
        public QueryHotelsResponse QueryHotelsWithOptions(QueryHotelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryHotels",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/amap-function-call-agent/iqs-agent-service/v1/nl/hotels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHotelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHotelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryHotelsResponse
        /// </returns>
        public async Task<QueryHotelsResponse> QueryHotelsWithOptionsAsync(QueryHotelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryHotels",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/amap-function-call-agent/iqs-agent-service/v1/nl/hotels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHotelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHotelsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryHotelsResponse
        /// </returns>
        public QueryHotelsResponse QueryHotels(QueryHotelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryHotelsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHotelsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryHotelsResponse
        /// </returns>
        public async Task<QueryHotelsResponse> QueryHotelsAsync(QueryHotelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryHotelsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>餐厅查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRestaurantsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRestaurantsResponse
        /// </returns>
        public QueryRestaurantsResponse QueryRestaurantsWithOptions(QueryRestaurantsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRestaurants",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/amap-function-call-agent/iqs-agent-service/v1/nl/restaurants",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRestaurantsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>餐厅查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRestaurantsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRestaurantsResponse
        /// </returns>
        public async Task<QueryRestaurantsResponse> QueryRestaurantsWithOptionsAsync(QueryRestaurantsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRestaurants",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/amap-function-call-agent/iqs-agent-service/v1/nl/restaurants",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRestaurantsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>餐厅查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRestaurantsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRestaurantsResponse
        /// </returns>
        public QueryRestaurantsResponse QueryRestaurants(QueryRestaurantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryRestaurantsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>餐厅查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRestaurantsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRestaurantsResponse
        /// </returns>
        public async Task<QueryRestaurantsResponse> QueryRestaurantsAsync(QueryRestaurantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryRestaurantsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时查询矩形区域内的交通信息查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RectangleTrafficStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RectangleTrafficStatusResponse
        /// </returns>
        public RectangleTrafficStatusResponse RectangleTrafficStatusWithOptions(RectangleTrafficStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LowerLeftLatitude))
            {
                query["lowerLeftLatitude"] = request.LowerLeftLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LowerLeftLongitude))
            {
                query["lowerLeftLongitude"] = request.LowerLeftLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoadLevel))
            {
                query["roadLevel"] = request.RoadLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpperRightLatitude))
            {
                query["upperRightLatitude"] = request.UpperRightLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpperRightLongitude))
            {
                query["upperRightLongitude"] = request.UpperRightLongitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RectangleTrafficStatus",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/traffic/status/rectangle",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RectangleTrafficStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时查询矩形区域内的交通信息查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RectangleTrafficStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RectangleTrafficStatusResponse
        /// </returns>
        public async Task<RectangleTrafficStatusResponse> RectangleTrafficStatusWithOptionsAsync(RectangleTrafficStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LowerLeftLatitude))
            {
                query["lowerLeftLatitude"] = request.LowerLeftLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LowerLeftLongitude))
            {
                query["lowerLeftLongitude"] = request.LowerLeftLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoadLevel))
            {
                query["roadLevel"] = request.RoadLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpperRightLatitude))
            {
                query["upperRightLatitude"] = request.UpperRightLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpperRightLongitude))
            {
                query["upperRightLongitude"] = request.UpperRightLongitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RectangleTrafficStatus",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/traffic/status/rectangle",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RectangleTrafficStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时查询矩形区域内的交通信息查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RectangleTrafficStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// RectangleTrafficStatusResponse
        /// </returns>
        public RectangleTrafficStatusResponse RectangleTrafficStatus(RectangleTrafficStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RectangleTrafficStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时查询矩形区域内的交通信息查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RectangleTrafficStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// RectangleTrafficStatusResponse
        /// </returns>
        public async Task<RectangleTrafficStatusResponse> RectangleTrafficStatusAsync(RectangleTrafficStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RectangleTrafficStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>逆地理编码，将经纬度转换为详细结构化的地址信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RgeoCodeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RgeoCodeResponse
        /// </returns>
        public RgeoCodeResponse RgeoCodeWithOptions(RgeoCodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Latitude))
            {
                query["latitude"] = request.Latitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Longitude))
            {
                query["longitude"] = request.Longitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RgeoCode",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/geocode/regeo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RgeoCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>逆地理编码，将经纬度转换为详细结构化的地址信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RgeoCodeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RgeoCodeResponse
        /// </returns>
        public async Task<RgeoCodeResponse> RgeoCodeWithOptionsAsync(RgeoCodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Latitude))
            {
                query["latitude"] = request.Latitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Longitude))
            {
                query["longitude"] = request.Longitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RgeoCode",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/geocode/regeo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RgeoCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>逆地理编码，将经纬度转换为详细结构化的地址信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RgeoCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// RgeoCodeResponse
        /// </returns>
        public RgeoCodeResponse RgeoCode(RgeoCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RgeoCodeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>逆地理编码，将经纬度转换为详细结构化的地址信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RgeoCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// RgeoCodeResponse
        /// </returns>
        public async Task<RgeoCodeResponse> RgeoCodeAsync(RgeoCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RgeoCodeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时查询指定线路的交通信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RoadTrafficStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RoadTrafficStatusResponse
        /// </returns>
        public RoadTrafficStatusResponse RoadTrafficStatusWithOptions(RoadTrafficStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["city"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoadLevel))
            {
                query["roadLevel"] = request.RoadLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoadName))
            {
                query["roadName"] = request.RoadName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RoadTrafficStatus",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/traffic/status/road",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RoadTrafficStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时查询指定线路的交通信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RoadTrafficStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RoadTrafficStatusResponse
        /// </returns>
        public async Task<RoadTrafficStatusResponse> RoadTrafficStatusWithOptionsAsync(RoadTrafficStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["city"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoadLevel))
            {
                query["roadLevel"] = request.RoadLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoadName))
            {
                query["roadName"] = request.RoadName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RoadTrafficStatus",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/traffic/status/road",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RoadTrafficStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时查询指定线路的交通信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RoadTrafficStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// RoadTrafficStatusResponse
        /// </returns>
        public RoadTrafficStatusResponse RoadTrafficStatus(RoadTrafficStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RoadTrafficStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时查询指定线路的交通信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RoadTrafficStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// RoadTrafficStatusResponse
        /// </returns>
        public async Task<RoadTrafficStatusResponse> RoadTrafficStatusAsync(RoadTrafficStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RoadTrafficStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>公共交通路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransitIntegratedDirectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransitIntegratedDirectionResponse
        /// </returns>
        public TransitIntegratedDirectionResponse TransitIntegratedDirectionWithOptions(TransitIntegratedDirectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCity))
            {
                query["destinationCity"] = request.DestinationCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLatitude))
            {
                query["destinationLatitude"] = request.DestinationLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLongitude))
            {
                query["destinationLongitude"] = request.DestinationLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginCity))
            {
                query["originCity"] = request.OriginCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLatitude))
            {
                query["originLatitude"] = request.OriginLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLongitude))
            {
                query["originLongitude"] = request.OriginLongitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransitIntegratedDirection",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v2/direction/transit/integrated",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransitIntegratedDirectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>公共交通路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransitIntegratedDirectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransitIntegratedDirectionResponse
        /// </returns>
        public async Task<TransitIntegratedDirectionResponse> TransitIntegratedDirectionWithOptionsAsync(TransitIntegratedDirectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCity))
            {
                query["destinationCity"] = request.DestinationCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLatitude))
            {
                query["destinationLatitude"] = request.DestinationLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLongitude))
            {
                query["destinationLongitude"] = request.DestinationLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginCity))
            {
                query["originCity"] = request.OriginCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLatitude))
            {
                query["originLatitude"] = request.OriginLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLongitude))
            {
                query["originLongitude"] = request.OriginLongitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransitIntegratedDirection",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v2/direction/transit/integrated",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransitIntegratedDirectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>公共交通路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransitIntegratedDirectionRequest
        /// </param>
        /// 
        /// <returns>
        /// TransitIntegratedDirectionResponse
        /// </returns>
        public TransitIntegratedDirectionResponse TransitIntegratedDirection(TransitIntegratedDirectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TransitIntegratedDirectionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>公共交通路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransitIntegratedDirectionRequest
        /// </param>
        /// 
        /// <returns>
        /// TransitIntegratedDirectionResponse
        /// </returns>
        public async Task<TransitIntegratedDirectionResponse> TransitIntegratedDirectionAsync(TransitIntegratedDirectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TransitIntegratedDirectionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的公共交通路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransitIntegratedDirectionOldRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransitIntegratedDirectionOldResponse
        /// </returns>
        public TransitIntegratedDirectionOldResponse TransitIntegratedDirectionOldWithOptions(TransitIntegratedDirectionOldRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCity))
            {
                query["destinationCity"] = request.DestinationCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLatitude))
            {
                query["destinationLatitude"] = request.DestinationLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLongitude))
            {
                query["destinationLongitude"] = request.DestinationLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginCity))
            {
                query["originCity"] = request.OriginCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLatitude))
            {
                query["originLatitude"] = request.OriginLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLongitude))
            {
                query["originLongitude"] = request.OriginLongitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransitIntegratedDirectionOld",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/direction/transit/integrated",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransitIntegratedDirectionOldResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的公共交通路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransitIntegratedDirectionOldRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransitIntegratedDirectionOldResponse
        /// </returns>
        public async Task<TransitIntegratedDirectionOldResponse> TransitIntegratedDirectionOldWithOptionsAsync(TransitIntegratedDirectionOldRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCity))
            {
                query["destinationCity"] = request.DestinationCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLatitude))
            {
                query["destinationLatitude"] = request.DestinationLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLongitude))
            {
                query["destinationLongitude"] = request.DestinationLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginCity))
            {
                query["originCity"] = request.OriginCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLatitude))
            {
                query["originLatitude"] = request.OriginLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLongitude))
            {
                query["originLongitude"] = request.OriginLongitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransitIntegratedDirectionOld",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/direction/transit/integrated",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransitIntegratedDirectionOldResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的公共交通路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransitIntegratedDirectionOldRequest
        /// </param>
        /// 
        /// <returns>
        /// TransitIntegratedDirectionOldResponse
        /// </returns>
        public TransitIntegratedDirectionOldResponse TransitIntegratedDirectionOld(TransitIntegratedDirectionOldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TransitIntegratedDirectionOldWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的公共交通路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransitIntegratedDirectionOldRequest
        /// </param>
        /// 
        /// <returns>
        /// TransitIntegratedDirectionOldResponse
        /// </returns>
        public async Task<TransitIntegratedDirectionOldResponse> TransitIntegratedDirectionOldAsync(TransitIntegratedDirectionOldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TransitIntegratedDirectionOldWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的步行路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WalkingDirectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WalkingDirectionResponse
        /// </returns>
        public WalkingDirectionResponse WalkingDirectionWithOptions(WalkingDirectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLatitude))
            {
                query["destinationLatitude"] = request.DestinationLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLongitude))
            {
                query["destinationLongitude"] = request.DestinationLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLatitude))
            {
                query["originLatitude"] = request.OriginLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLongitude))
            {
                query["originLongitude"] = request.OriginLongitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WalkingDirection",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/direction/walking",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WalkingDirectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的步行路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WalkingDirectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WalkingDirectionResponse
        /// </returns>
        public async Task<WalkingDirectionResponse> WalkingDirectionWithOptionsAsync(WalkingDirectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLatitude))
            {
                query["destinationLatitude"] = request.DestinationLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLongitude))
            {
                query["destinationLongitude"] = request.DestinationLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLatitude))
            {
                query["originLatitude"] = request.OriginLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLongitude))
            {
                query["originLongitude"] = request.OriginLongitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WalkingDirection",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v1/direction/walking",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WalkingDirectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的步行路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WalkingDirectionRequest
        /// </param>
        /// 
        /// <returns>
        /// WalkingDirectionResponse
        /// </returns>
        public WalkingDirectionResponse WalkingDirection(WalkingDirectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return WalkingDirectionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的步行路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WalkingDirectionRequest
        /// </param>
        /// 
        /// <returns>
        /// WalkingDirectionResponse
        /// </returns>
        public async Task<WalkingDirectionResponse> WalkingDirectionAsync(WalkingDirectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await WalkingDirectionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的步行路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WalkingDirectionNovaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WalkingDirectionNovaResponse
        /// </returns>
        public WalkingDirectionNovaResponse WalkingDirectionNovaWithOptions(WalkingDirectionNovaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLatitude))
            {
                query["destinationLatitude"] = request.DestinationLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLongitude))
            {
                query["destinationLongitude"] = request.DestinationLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLatitude))
            {
                query["originLatitude"] = request.OriginLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLongitude))
            {
                query["originLongitude"] = request.OriginLongitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WalkingDirectionNova",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v2/direction/walking",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WalkingDirectionNovaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的步行路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WalkingDirectionNovaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WalkingDirectionNovaResponse
        /// </returns>
        public async Task<WalkingDirectionNovaResponse> WalkingDirectionNovaWithOptionsAsync(WalkingDirectionNovaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLatitude))
            {
                query["destinationLatitude"] = request.DestinationLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationLongitude))
            {
                query["destinationLongitude"] = request.DestinationLongitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLatitude))
            {
                query["originLatitude"] = request.OriginLatitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginLongitude))
            {
                query["originLongitude"] = request.OriginLongitude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WalkingDirectionNova",
                Version = "2024-07-12",
                Protocol = "HTTPS",
                Pathname = "/ipaas/v2/direction/walking",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WalkingDirectionNovaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的步行路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WalkingDirectionNovaRequest
        /// </param>
        /// 
        /// <returns>
        /// WalkingDirectionNovaResponse
        /// </returns>
        public WalkingDirectionNovaResponse WalkingDirectionNova(WalkingDirectionNovaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return WalkingDirectionNovaWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起终点坐标检索符合条件的步行路线规划方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WalkingDirectionNovaRequest
        /// </param>
        /// 
        /// <returns>
        /// WalkingDirectionNovaResponse
        /// </returns>
        public async Task<WalkingDirectionNovaResponse> WalkingDirectionNovaAsync(WalkingDirectionNovaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await WalkingDirectionNovaWithOptionsAsync(request, headers, runtime);
        }

    }
}
