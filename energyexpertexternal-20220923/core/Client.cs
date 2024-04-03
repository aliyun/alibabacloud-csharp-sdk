// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.EnergyExpertExternal20220923.Models;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("energyexpertexternal", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public GenerateResultResponse GenerateResultWithOptions(GenerateResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateResult",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/generate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateResultResponse> GenerateResultWithOptionsAsync(GenerateResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateResult",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/generate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateResultResponse GenerateResult(GenerateResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateResultWithOptions(request, headers, runtime);
        }

        public async Task<GenerateResultResponse> GenerateResultAsync(GenerateResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateResultWithOptionsAsync(request, headers, runtime);
        }

        public GetAreaElecConstituteResponse GetAreaElecConstituteWithOptions(GetAreaElecConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAreaElecConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/elec/area",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAreaElecConstituteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAreaElecConstituteResponse> GetAreaElecConstituteWithOptionsAsync(GetAreaElecConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAreaElecConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/elec/area",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAreaElecConstituteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAreaElecConstituteResponse GetAreaElecConstitute(GetAreaElecConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAreaElecConstituteWithOptions(request, headers, runtime);
        }

        public async Task<GetAreaElecConstituteResponse> GetAreaElecConstituteAsync(GetAreaElecConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAreaElecConstituteWithOptionsAsync(request, headers, runtime);
        }

        public GetCarbonEmissionTrendResponse GetCarbonEmissionTrendWithOptions(GetCarbonEmissionTrendRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleCode))
            {
                body["moduleCode"] = request.ModuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                body["moduleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrendType))
            {
                body["trendType"] = request.TrendType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YearList))
            {
                body["yearList"] = request.YearList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCarbonEmissionTrend",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/trend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCarbonEmissionTrendResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCarbonEmissionTrendResponse> GetCarbonEmissionTrendWithOptionsAsync(GetCarbonEmissionTrendRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleCode))
            {
                body["moduleCode"] = request.ModuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                body["moduleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrendType))
            {
                body["trendType"] = request.TrendType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YearList))
            {
                body["yearList"] = request.YearList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCarbonEmissionTrend",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/trend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCarbonEmissionTrendResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCarbonEmissionTrendResponse GetCarbonEmissionTrend(GetCarbonEmissionTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCarbonEmissionTrendWithOptions(request, headers, runtime);
        }

        public async Task<GetCarbonEmissionTrendResponse> GetCarbonEmissionTrendAsync(GetCarbonEmissionTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCarbonEmissionTrendWithOptionsAsync(request, headers, runtime);
        }

        public GetDataItemListResponse GetDataItemListWithOptions(GetDataItemListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataItemList",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/data/item/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataItemListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDataItemListResponse> GetDataItemListWithOptionsAsync(GetDataItemListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataItemList",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/data/item/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataItemListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDataItemListResponse GetDataItemList(GetDataItemListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDataItemListWithOptions(request, headers, runtime);
        }

        public async Task<GetDataItemListResponse> GetDataItemListAsync(GetDataItemListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDataItemListWithOptionsAsync(request, headers, runtime);
        }

        public GetDataQualityAnalysisResponse GetDataQualityAnalysisWithOptions(GetDataQualityAnalysisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataQualityEvaluationType))
            {
                body["dataQualityEvaluationType"] = request.DataQualityEvaluationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataQualityAnalysis",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/data/quality/analysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataQualityAnalysisResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDataQualityAnalysisResponse> GetDataQualityAnalysisWithOptionsAsync(GetDataQualityAnalysisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataQualityEvaluationType))
            {
                body["dataQualityEvaluationType"] = request.DataQualityEvaluationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataQualityAnalysis",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/data/quality/analysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataQualityAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDataQualityAnalysisResponse GetDataQualityAnalysis(GetDataQualityAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDataQualityAnalysisWithOptions(request, headers, runtime);
        }

        public async Task<GetDataQualityAnalysisResponse> GetDataQualityAnalysisAsync(GetDataQualityAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDataQualityAnalysisWithOptionsAsync(request, headers, runtime);
        }

        /**
          * *   You can call this operation to query the parameters of a data collection device based on the device ID. If the verification is passed, the device parameters are returned. If the verification fails, a null value is returned.
          * *   You can query the parameters of a single device by day. If data of the device does not exist, a null value is returned.
          *
          * @param request GetDeviceInfoRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDeviceInfoResponse
         */
        public GetDeviceInfoResponse GetDeviceInfoWithOptions(GetDeviceInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ds))
            {
                query["ds"] = request.Ds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactoryId))
            {
                query["factoryId"] = request.FactoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceInfo",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/external/getDeviceInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can call this operation to query the parameters of a data collection device based on the device ID. If the verification is passed, the device parameters are returned. If the verification fails, a null value is returned.
          * *   You can query the parameters of a single device by day. If data of the device does not exist, a null value is returned.
          *
          * @param request GetDeviceInfoRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDeviceInfoResponse
         */
        public async Task<GetDeviceInfoResponse> GetDeviceInfoWithOptionsAsync(GetDeviceInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ds))
            {
                query["ds"] = request.Ds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactoryId))
            {
                query["factoryId"] = request.FactoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceInfo",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/external/getDeviceInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can call this operation to query the parameters of a data collection device based on the device ID. If the verification is passed, the device parameters are returned. If the verification fails, a null value is returned.
          * *   You can query the parameters of a single device by day. If data of the device does not exist, a null value is returned.
          *
          * @param request GetDeviceInfoRequest
          * @return GetDeviceInfoResponse
         */
        public GetDeviceInfoResponse GetDeviceInfo(GetDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDeviceInfoWithOptions(request, headers, runtime);
        }

        /**
          * *   You can call this operation to query the parameters of a data collection device based on the device ID. If the verification is passed, the device parameters are returned. If the verification fails, a null value is returned.
          * *   You can query the parameters of a single device by day. If data of the device does not exist, a null value is returned.
          *
          * @param request GetDeviceInfoRequest
          * @return GetDeviceInfoResponse
         */
        public async Task<GetDeviceInfoResponse> GetDeviceInfoAsync(GetDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDeviceInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
          * *   You can query the information about data collection devices of a site based on the ID of the site. If the verification is passed, the information about the devices of the site is returned. If the verification fails, a null value is returned.
          * *   Virtual meters at the site are not returned.
          *
          * @param request GetDeviceListRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDeviceListResponse
         */
        public GetDeviceListResponse GetDeviceListWithOptions(GetDeviceListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactoryId))
            {
                query["factoryId"] = request.FactoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceList",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/external/getDeviceList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can query the information about data collection devices of a site based on the ID of the site. If the verification is passed, the information about the devices of the site is returned. If the verification fails, a null value is returned.
          * *   Virtual meters at the site are not returned.
          *
          * @param request GetDeviceListRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDeviceListResponse
         */
        public async Task<GetDeviceListResponse> GetDeviceListWithOptionsAsync(GetDeviceListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactoryId))
            {
                query["factoryId"] = request.FactoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceList",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/external/getDeviceList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can query the information about data collection devices of a site based on the ID of the site. If the verification is passed, the information about the devices of the site is returned. If the verification fails, a null value is returned.
          * *   Virtual meters at the site are not returned.
          *
          * @param request GetDeviceListRequest
          * @return GetDeviceListResponse
         */
        public GetDeviceListResponse GetDeviceList(GetDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDeviceListWithOptions(request, headers, runtime);
        }

        /**
          * *   You can query the information about data collection devices of a site based on the ID of the site. If the verification is passed, the information about the devices of the site is returned. If the verification fails, a null value is returned.
          * *   Virtual meters at the site are not returned.
          *
          * @param request GetDeviceListRequest
          * @return GetDeviceListResponse
         */
        public async Task<GetDeviceListResponse> GetDeviceListAsync(GetDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDeviceListWithOptionsAsync(request, headers, runtime);
        }

        public GetElecConstituteResponse GetElecConstituteWithOptions(GetElecConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetElecConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/elec/constitute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetElecConstituteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetElecConstituteResponse> GetElecConstituteWithOptionsAsync(GetElecConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetElecConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/elec/constitute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetElecConstituteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetElecConstituteResponse GetElecConstitute(GetElecConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetElecConstituteWithOptions(request, headers, runtime);
        }

        public async Task<GetElecConstituteResponse> GetElecConstituteAsync(GetElecConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetElecConstituteWithOptionsAsync(request, headers, runtime);
        }

        public GetElecTrendResponse GetElecTrendWithOptions(GetElecTrendRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YearList))
            {
                body["yearList"] = request.YearList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetElecTrend",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/elec/trend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetElecTrendResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetElecTrendResponse> GetElecTrendWithOptionsAsync(GetElecTrendRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YearList))
            {
                body["yearList"] = request.YearList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetElecTrend",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/elec/trend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetElecTrendResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetElecTrendResponse GetElecTrend(GetElecTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetElecTrendWithOptions(request, headers, runtime);
        }

        public async Task<GetElecTrendResponse> GetElecTrendAsync(GetElecTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetElecTrendWithOptionsAsync(request, headers, runtime);
        }

        public GetEmissionSourceConstituteResponse GetEmissionSourceConstituteWithOptions(GetEmissionSourceConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleCode))
            {
                body["moduleCode"] = request.ModuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                body["moduleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEmissionSourceConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/constitute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmissionSourceConstituteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetEmissionSourceConstituteResponse> GetEmissionSourceConstituteWithOptionsAsync(GetEmissionSourceConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleCode))
            {
                body["moduleCode"] = request.ModuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                body["moduleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEmissionSourceConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/constitute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmissionSourceConstituteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetEmissionSourceConstituteResponse GetEmissionSourceConstitute(GetEmissionSourceConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEmissionSourceConstituteWithOptions(request, headers, runtime);
        }

        public async Task<GetEmissionSourceConstituteResponse> GetEmissionSourceConstituteAsync(GetEmissionSourceConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEmissionSourceConstituteWithOptionsAsync(request, headers, runtime);
        }

        public GetEmissionSummaryResponse GetEmissionSummaryWithOptions(GetEmissionSummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleCode))
            {
                body["moduleCode"] = request.ModuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                body["moduleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEmissionSummary",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmissionSummaryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetEmissionSummaryResponse> GetEmissionSummaryWithOptionsAsync(GetEmissionSummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleCode))
            {
                body["moduleCode"] = request.ModuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                body["moduleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEmissionSummary",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmissionSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetEmissionSummaryResponse GetEmissionSummary(GetEmissionSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEmissionSummaryWithOptions(request, headers, runtime);
        }

        public async Task<GetEmissionSummaryResponse> GetEmissionSummaryAsync(GetEmissionSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEmissionSummaryWithOptionsAsync(request, headers, runtime);
        }

        public GetEpdInventoryConstituteResponse GetEpdInventoryConstituteWithOptions(GetEpdInventoryConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEpdInventoryConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/epd/inventory/constitute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEpdInventoryConstituteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetEpdInventoryConstituteResponse> GetEpdInventoryConstituteWithOptionsAsync(GetEpdInventoryConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEpdInventoryConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/epd/inventory/constitute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEpdInventoryConstituteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetEpdInventoryConstituteResponse GetEpdInventoryConstitute(GetEpdInventoryConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEpdInventoryConstituteWithOptions(request, headers, runtime);
        }

        public async Task<GetEpdInventoryConstituteResponse> GetEpdInventoryConstituteAsync(GetEpdInventoryConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEpdInventoryConstituteWithOptionsAsync(request, headers, runtime);
        }

        public GetEpdSummaryResponse GetEpdSummaryWithOptions(GetEpdSummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEpdSummary",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/epd/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEpdSummaryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetEpdSummaryResponse> GetEpdSummaryWithOptionsAsync(GetEpdSummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEpdSummary",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/epd/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEpdSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetEpdSummaryResponse GetEpdSummary(GetEpdSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEpdSummaryWithOptions(request, headers, runtime);
        }

        public async Task<GetEpdSummaryResponse> GetEpdSummaryAsync(GetEpdSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEpdSummaryWithOptionsAsync(request, headers, runtime);
        }

        public GetFootprintListResponse GetFootprintListWithOptions(GetFootprintListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["currentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFootprintList",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/product/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFootprintListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFootprintListResponse> GetFootprintListWithOptionsAsync(GetFootprintListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["currentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFootprintList",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/product/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFootprintListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFootprintListResponse GetFootprintList(GetFootprintListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFootprintListWithOptions(request, headers, runtime);
        }

        public async Task<GetFootprintListResponse> GetFootprintListAsync(GetFootprintListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFootprintListWithOptionsAsync(request, headers, runtime);
        }

        public GetGasConstituteResponse GetGasConstituteWithOptions(GetGasConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleCode))
            {
                body["moduleCode"] = request.ModuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                body["moduleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGasConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/gas/constitute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGasConstituteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetGasConstituteResponse> GetGasConstituteWithOptionsAsync(GetGasConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleCode))
            {
                body["moduleCode"] = request.ModuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                body["moduleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGasConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/gas/constitute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGasConstituteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetGasConstituteResponse GetGasConstitute(GetGasConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGasConstituteWithOptions(request, headers, runtime);
        }

        public async Task<GetGasConstituteResponse> GetGasConstituteAsync(GetGasConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGasConstituteWithOptionsAsync(request, headers, runtime);
        }

        public GetGwpBenchmarkListResponse GetGwpBenchmarkListWithOptions(GetGwpBenchmarkListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGwpBenchmarkList",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/gwp/benchmark/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGwpBenchmarkListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetGwpBenchmarkListResponse> GetGwpBenchmarkListWithOptionsAsync(GetGwpBenchmarkListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGwpBenchmarkList",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/gwp/benchmark/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGwpBenchmarkListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetGwpBenchmarkListResponse GetGwpBenchmarkList(GetGwpBenchmarkListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGwpBenchmarkListWithOptions(request, headers, runtime);
        }

        public async Task<GetGwpBenchmarkListResponse> GetGwpBenchmarkListAsync(GetGwpBenchmarkListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGwpBenchmarkListWithOptionsAsync(request, headers, runtime);
        }

        public GetGwpBenchmarkSummaryResponse GetGwpBenchmarkSummaryWithOptions(GetGwpBenchmarkSummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGwpBenchmarkSummary",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/gwp/benchmark/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGwpBenchmarkSummaryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetGwpBenchmarkSummaryResponse> GetGwpBenchmarkSummaryWithOptionsAsync(GetGwpBenchmarkSummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGwpBenchmarkSummary",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/gwp/benchmark/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGwpBenchmarkSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetGwpBenchmarkSummaryResponse GetGwpBenchmarkSummary(GetGwpBenchmarkSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGwpBenchmarkSummaryWithOptions(request, headers, runtime);
        }

        public async Task<GetGwpBenchmarkSummaryResponse> GetGwpBenchmarkSummaryAsync(GetGwpBenchmarkSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGwpBenchmarkSummaryWithOptionsAsync(request, headers, runtime);
        }

        public GetGwpInventoryConstituteResponse GetGwpInventoryConstituteWithOptions(GetGwpInventoryConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGwpInventoryConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/gwp/inventory/constitute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGwpInventoryConstituteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetGwpInventoryConstituteResponse> GetGwpInventoryConstituteWithOptionsAsync(GetGwpInventoryConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGwpInventoryConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/gwp/inventory/constitute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGwpInventoryConstituteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetGwpInventoryConstituteResponse GetGwpInventoryConstitute(GetGwpInventoryConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGwpInventoryConstituteWithOptions(request, headers, runtime);
        }

        public async Task<GetGwpInventoryConstituteResponse> GetGwpInventoryConstituteAsync(GetGwpInventoryConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGwpInventoryConstituteWithOptionsAsync(request, headers, runtime);
        }

        public GetGwpInventorySummaryResponse GetGwpInventorySummaryWithOptions(GetGwpInventorySummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGwpInventorySummary",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/gwp/inventory/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGwpInventorySummaryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetGwpInventorySummaryResponse> GetGwpInventorySummaryWithOptionsAsync(GetGwpInventorySummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGwpInventorySummary",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/gwp/inventory/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGwpInventorySummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetGwpInventorySummaryResponse GetGwpInventorySummary(GetGwpInventorySummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGwpInventorySummaryWithOptions(request, headers, runtime);
        }

        public async Task<GetGwpInventorySummaryResponse> GetGwpInventorySummaryAsync(GetGwpInventorySummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGwpInventorySummaryWithOptionsAsync(request, headers, runtime);
        }

        public GetInventoryListResponse GetInventoryListWithOptions(GetInventoryListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmissionType))
            {
                body["emissionType"] = request.EmissionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                body["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MethodType))
            {
                body["methodType"] = request.MethodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInventoryList",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/inventory/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInventoryListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetInventoryListResponse> GetInventoryListWithOptionsAsync(GetInventoryListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmissionType))
            {
                body["emissionType"] = request.EmissionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                body["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MethodType))
            {
                body["methodType"] = request.MethodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInventoryList",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/inventory/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInventoryListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetInventoryListResponse GetInventoryList(GetInventoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInventoryListWithOptions(request, headers, runtime);
        }

        public async Task<GetInventoryListResponse> GetInventoryListAsync(GetInventoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInventoryListWithOptionsAsync(request, headers, runtime);
        }

        /**
          * *   You can set multiple request parameters to filter query results. Specified parameters have logical AND relations. Parameters without assigned values are not used as filtering conditions.
          * *   The x-acs-caller-uid header is used to check whether the activated service plan is the required service plan. If the verification is passed, the information about the organizations and sites that are activated by using the Alibaba Cloud account is returned. If the verification fails, a null value is returned.
          * *   If activated organizations and sites exist, the data of the organizations and sites is returned. If no organization or site data exists, a null value is returned.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetOrgAndFactoryResponse
         */
        public GetOrgAndFactoryResponse GetOrgAndFactoryWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrgAndFactory",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/external/getOrgAndFactory",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrgAndFactoryResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can set multiple request parameters to filter query results. Specified parameters have logical AND relations. Parameters without assigned values are not used as filtering conditions.
          * *   The x-acs-caller-uid header is used to check whether the activated service plan is the required service plan. If the verification is passed, the information about the organizations and sites that are activated by using the Alibaba Cloud account is returned. If the verification fails, a null value is returned.
          * *   If activated organizations and sites exist, the data of the organizations and sites is returned. If no organization or site data exists, a null value is returned.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetOrgAndFactoryResponse
         */
        public async Task<GetOrgAndFactoryResponse> GetOrgAndFactoryWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrgAndFactory",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/external/getOrgAndFactory",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrgAndFactoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can set multiple request parameters to filter query results. Specified parameters have logical AND relations. Parameters without assigned values are not used as filtering conditions.
          * *   The x-acs-caller-uid header is used to check whether the activated service plan is the required service plan. If the verification is passed, the information about the organizations and sites that are activated by using the Alibaba Cloud account is returned. If the verification fails, a null value is returned.
          * *   If activated organizations and sites exist, the data of the organizations and sites is returned. If no organization or site data exists, a null value is returned.
          *
          * @return GetOrgAndFactoryResponse
         */
        public GetOrgAndFactoryResponse GetOrgAndFactory()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOrgAndFactoryWithOptions(headers, runtime);
        }

        /**
          * *   You can set multiple request parameters to filter query results. Specified parameters have logical AND relations. Parameters without assigned values are not used as filtering conditions.
          * *   The x-acs-caller-uid header is used to check whether the activated service plan is the required service plan. If the verification is passed, the information about the organizations and sites that are activated by using the Alibaba Cloud account is returned. If the verification fails, a null value is returned.
          * *   If activated organizations and sites exist, the data of the organizations and sites is returned. If no organization or site data exists, a null value is returned.
          *
          * @return GetOrgAndFactoryResponse
         */
        public async Task<GetOrgAndFactoryResponse> GetOrgAndFactoryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOrgAndFactoryWithOptionsAsync(headers, runtime);
        }

        public GetOrgConstituteResponse GetOrgConstituteWithOptions(GetOrgConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleCode))
            {
                body["moduleCode"] = request.ModuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                body["moduleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrgConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/org",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrgConstituteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetOrgConstituteResponse> GetOrgConstituteWithOptionsAsync(GetOrgConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleCode))
            {
                body["moduleCode"] = request.ModuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                body["moduleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrgConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/org",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrgConstituteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetOrgConstituteResponse GetOrgConstitute(GetOrgConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOrgConstituteWithOptions(request, headers, runtime);
        }

        public async Task<GetOrgConstituteResponse> GetOrgConstituteAsync(GetOrgConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOrgConstituteWithOptionsAsync(request, headers, runtime);
        }

        public GetPcrInfoResponse GetPcrInfoWithOptions(GetPcrInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPcrInfo",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/pcr/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPcrInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPcrInfoResponse> GetPcrInfoWithOptionsAsync(GetPcrInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPcrInfo",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/pcr/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPcrInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPcrInfoResponse GetPcrInfo(GetPcrInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPcrInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetPcrInfoResponse> GetPcrInfoAsync(GetPcrInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPcrInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetReductionProposalResponse GetReductionProposalWithOptions(GetReductionProposalRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataQualityEvaluationType))
            {
                body["dataQualityEvaluationType"] = request.DataQualityEvaluationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReductionProposal",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/reduction/proposal",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReductionProposalResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetReductionProposalResponse> GetReductionProposalWithOptionsAsync(GetReductionProposalRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataQualityEvaluationType))
            {
                body["dataQualityEvaluationType"] = request.DataQualityEvaluationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReductionProposal",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/reduction/proposal",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReductionProposalResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetReductionProposalResponse GetReductionProposal(GetReductionProposalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetReductionProposalWithOptions(request, headers, runtime);
        }

        public async Task<GetReductionProposalResponse> GetReductionProposalAsync(GetReductionProposalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetReductionProposalWithOptionsAsync(request, headers, runtime);
        }

        public IsCompletedResponse IsCompletedWithOptions(IsCompletedRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IsCompleted",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/completed",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<IsCompletedResponse>(CallApi(params_, req, runtime));
        }

        public async Task<IsCompletedResponse> IsCompletedWithOptionsAsync(IsCompletedRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IsCompleted",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/completed",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<IsCompletedResponse>(await CallApiAsync(params_, req, runtime));
        }

        public IsCompletedResponse IsCompleted(IsCompletedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return IsCompletedWithOptions(request, headers, runtime);
        }

        public async Task<IsCompletedResponse> IsCompletedAsync(IsCompletedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await IsCompletedWithOptionsAsync(request, headers, runtime);
        }

        public PushDeviceDataResponse PushDeviceDataWithOptions(PushDeviceDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["deviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Devices))
            {
                body["devices"] = request.Devices;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushDeviceData",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/data/increment/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushDeviceDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PushDeviceDataResponse> PushDeviceDataWithOptionsAsync(PushDeviceDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["deviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Devices))
            {
                body["devices"] = request.Devices;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushDeviceData",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/data/increment/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushDeviceDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PushDeviceDataResponse PushDeviceData(PushDeviceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushDeviceDataWithOptions(request, headers, runtime);
        }

        public async Task<PushDeviceDataResponse> PushDeviceDataAsync(PushDeviceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushDeviceDataWithOptionsAsync(request, headers, runtime);
        }

        /**
          * N/A.
          *
          * @param request PushItemDataRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return PushItemDataResponse
         */
        public PushItemDataResponse PushItemDataWithOptions(PushItemDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Items))
            {
                body["items"] = request.Items;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushItemData",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/data/item/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushItemDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * N/A.
          *
          * @param request PushItemDataRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return PushItemDataResponse
         */
        public async Task<PushItemDataResponse> PushItemDataWithOptionsAsync(PushItemDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Items))
            {
                body["items"] = request.Items;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushItemData",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/data/item/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushItemDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * N/A.
          *
          * @param request PushItemDataRequest
          * @return PushItemDataResponse
         */
        public PushItemDataResponse PushItemData(PushItemDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushItemDataWithOptions(request, headers, runtime);
        }

        /**
          * N/A.
          *
          * @param request PushItemDataRequest
          * @return PushItemDataResponse
         */
        public async Task<PushItemDataResponse> PushItemDataAsync(PushItemDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushItemDataWithOptionsAsync(request, headers, runtime);
        }

        public RecalculateCarbonEmissionResponse RecalculateCarbonEmissionWithOptions(RecalculateCarbonEmissionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecalculateCarbonEmission",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/data/item/recalculate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecalculateCarbonEmissionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecalculateCarbonEmissionResponse> RecalculateCarbonEmissionWithOptionsAsync(RecalculateCarbonEmissionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecalculateCarbonEmission",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/data/item/recalculate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecalculateCarbonEmissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecalculateCarbonEmissionResponse RecalculateCarbonEmission(RecalculateCarbonEmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RecalculateCarbonEmissionWithOptions(request, headers, runtime);
        }

        public async Task<RecalculateCarbonEmissionResponse> RecalculateCarbonEmissionAsync(RecalculateCarbonEmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RecalculateCarbonEmissionWithOptionsAsync(request, headers, runtime);
        }

    }
}
