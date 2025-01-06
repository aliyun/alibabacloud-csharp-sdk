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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityLimit))
            {
                query["cityLimit"] = request.CityLimit;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityLimit))
            {
                query["cityLimit"] = request.CityLimit;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityLimit))
            {
                query["cityLimit"] = request.CityLimit;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityLimit))
            {
                query["cityLimit"] = request.CityLimit;
            }
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
