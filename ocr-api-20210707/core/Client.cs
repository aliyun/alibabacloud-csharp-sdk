// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ocr_api20210707.Models;

namespace AlibabaCloud.SDK.Ocr_api20210707
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ocr-api", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /**
         * @summary 全文识别高精版
         *
         * @param request RecognizeAdvancedRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeAdvancedResponse
         */
        public RecognizeAdvancedResponse RecognizeAdvancedWithOptions(RecognizeAdvancedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSortPage))
            {
                query["NeedSortPage"] = request.NeedSortPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoStamp))
            {
                query["NoStamp"] = request.NoStamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Paragraph))
            {
                query["Paragraph"] = request.Paragraph;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                query["Row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeAdvanced",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeAdvancedResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 全文识别高精版
         *
         * @param request RecognizeAdvancedRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeAdvancedResponse
         */
        public async Task<RecognizeAdvancedResponse> RecognizeAdvancedWithOptionsAsync(RecognizeAdvancedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSortPage))
            {
                query["NeedSortPage"] = request.NeedSortPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoStamp))
            {
                query["NoStamp"] = request.NoStamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Paragraph))
            {
                query["Paragraph"] = request.Paragraph;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                query["Row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeAdvanced",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeAdvancedResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 全文识别高精版
         *
         * @param request RecognizeAdvancedRequest
         * @return RecognizeAdvancedResponse
         */
        public RecognizeAdvancedResponse RecognizeAdvanced(RecognizeAdvancedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeAdvancedWithOptions(request, runtime);
        }

        /**
         * @summary 全文识别高精版
         *
         * @param request RecognizeAdvancedRequest
         * @return RecognizeAdvancedResponse
         */
        public async Task<RecognizeAdvancedResponse> RecognizeAdvancedAsync(RecognizeAdvancedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeAdvancedWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 航空行程单
         *
         * @param request RecognizeAirItineraryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeAirItineraryResponse
         */
        public RecognizeAirItineraryResponse RecognizeAirItineraryWithOptions(RecognizeAirItineraryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeAirItinerary",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeAirItineraryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 航空行程单
         *
         * @param request RecognizeAirItineraryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeAirItineraryResponse
         */
        public async Task<RecognizeAirItineraryResponse> RecognizeAirItineraryWithOptionsAsync(RecognizeAirItineraryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeAirItinerary",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeAirItineraryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 航空行程单
         *
         * @param request RecognizeAirItineraryRequest
         * @return RecognizeAirItineraryResponse
         */
        public RecognizeAirItineraryResponse RecognizeAirItinerary(RecognizeAirItineraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeAirItineraryWithOptions(request, runtime);
        }

        /**
         * @summary 航空行程单
         *
         * @param request RecognizeAirItineraryRequest
         * @return RecognizeAirItineraryResponse
         */
        public async Task<RecognizeAirItineraryResponse> RecognizeAirItineraryAsync(RecognizeAirItineraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeAirItineraryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 统一Api
         *
         * @param tmpReq RecognizeAllTextRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeAllTextResponse
         */
        public RecognizeAllTextResponse RecognizeAllTextWithOptions(RecognizeAllTextRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RecognizeAllTextShrinkRequest request = new RecognizeAllTextShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdvancedConfig))
            {
                request.AdvancedConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdvancedConfig, "AdvancedConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IdCardConfig))
            {
                request.IdCardConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IdCardConfig, "IdCardConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InternationalBusinessLicenseConfig))
            {
                request.InternationalBusinessLicenseConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InternationalBusinessLicenseConfig, "InternationalBusinessLicenseConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InternationalIdCardConfig))
            {
                request.InternationalIdCardConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InternationalIdCardConfig, "InternationalIdCardConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MultiLanConfig))
            {
                request.MultiLanConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MultiLanConfig, "MultiLanConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TableConfig))
            {
                request.TableConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TableConfig, "TableConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvancedConfigShrink))
            {
                query["AdvancedConfig"] = request.AdvancedConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardConfigShrink))
            {
                query["IdCardConfig"] = request.IdCardConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternationalBusinessLicenseConfigShrink))
            {
                query["InternationalBusinessLicenseConfig"] = request.InternationalBusinessLicenseConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternationalIdCardConfigShrink))
            {
                query["InternationalIdCardConfig"] = request.InternationalIdCardConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiLanConfigShrink))
            {
                query["MultiLanConfig"] = request.MultiLanConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputBarCode))
            {
                query["OutputBarCode"] = request.OutputBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCoordinate))
            {
                query["OutputCoordinate"] = request.OutputCoordinate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputKVExcel))
            {
                query["OutputKVExcel"] = request.OutputKVExcel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputOricoord))
            {
                query["OutputOricoord"] = request.OutputOricoord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputQrcode))
            {
                query["OutputQrcode"] = request.OutputQrcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputStamp))
            {
                query["OutputStamp"] = request.OutputStamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableConfigShrink))
            {
                query["TableConfig"] = request.TableConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = tmpReq.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeAllText",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeAllTextResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 统一Api
         *
         * @param tmpReq RecognizeAllTextRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeAllTextResponse
         */
        public async Task<RecognizeAllTextResponse> RecognizeAllTextWithOptionsAsync(RecognizeAllTextRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RecognizeAllTextShrinkRequest request = new RecognizeAllTextShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdvancedConfig))
            {
                request.AdvancedConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdvancedConfig, "AdvancedConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IdCardConfig))
            {
                request.IdCardConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IdCardConfig, "IdCardConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InternationalBusinessLicenseConfig))
            {
                request.InternationalBusinessLicenseConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InternationalBusinessLicenseConfig, "InternationalBusinessLicenseConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InternationalIdCardConfig))
            {
                request.InternationalIdCardConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InternationalIdCardConfig, "InternationalIdCardConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MultiLanConfig))
            {
                request.MultiLanConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MultiLanConfig, "MultiLanConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TableConfig))
            {
                request.TableConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TableConfig, "TableConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvancedConfigShrink))
            {
                query["AdvancedConfig"] = request.AdvancedConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardConfigShrink))
            {
                query["IdCardConfig"] = request.IdCardConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternationalBusinessLicenseConfigShrink))
            {
                query["InternationalBusinessLicenseConfig"] = request.InternationalBusinessLicenseConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternationalIdCardConfigShrink))
            {
                query["InternationalIdCardConfig"] = request.InternationalIdCardConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiLanConfigShrink))
            {
                query["MultiLanConfig"] = request.MultiLanConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputBarCode))
            {
                query["OutputBarCode"] = request.OutputBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCoordinate))
            {
                query["OutputCoordinate"] = request.OutputCoordinate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputKVExcel))
            {
                query["OutputKVExcel"] = request.OutputKVExcel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputOricoord))
            {
                query["OutputOricoord"] = request.OutputOricoord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputQrcode))
            {
                query["OutputQrcode"] = request.OutputQrcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputStamp))
            {
                query["OutputStamp"] = request.OutputStamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableConfigShrink))
            {
                query["TableConfig"] = request.TableConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = tmpReq.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeAllText",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeAllTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 统一Api
         *
         * @param request RecognizeAllTextRequest
         * @return RecognizeAllTextResponse
         */
        public RecognizeAllTextResponse RecognizeAllText(RecognizeAllTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeAllTextWithOptions(request, runtime);
        }

        /**
         * @summary 统一Api
         *
         * @param request RecognizeAllTextRequest
         * @return RecognizeAllTextResponse
         */
        public async Task<RecognizeAllTextResponse> RecognizeAllTextAsync(RecognizeAllTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeAllTextWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 银承汇票识别
         *
         * @param request RecognizeBankAcceptanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeBankAcceptanceResponse
         */
        public RecognizeBankAcceptanceResponse RecognizeBankAcceptanceWithOptions(RecognizeBankAcceptanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBankAcceptance",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBankAcceptanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 银承汇票识别
         *
         * @param request RecognizeBankAcceptanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeBankAcceptanceResponse
         */
        public async Task<RecognizeBankAcceptanceResponse> RecognizeBankAcceptanceWithOptionsAsync(RecognizeBankAcceptanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBankAcceptance",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBankAcceptanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 银承汇票识别
         *
         * @param request RecognizeBankAcceptanceRequest
         * @return RecognizeBankAcceptanceResponse
         */
        public RecognizeBankAcceptanceResponse RecognizeBankAcceptance(RecognizeBankAcceptanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBankAcceptanceWithOptions(request, runtime);
        }

        /**
         * @summary 银承汇票识别
         *
         * @param request RecognizeBankAcceptanceRequest
         * @return RecognizeBankAcceptanceResponse
         */
        public async Task<RecognizeBankAcceptanceResponse> RecognizeBankAcceptanceAsync(RecognizeBankAcceptanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBankAcceptanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 银行开户许可证识别
         *
         * @param request RecognizeBankAccountLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeBankAccountLicenseResponse
         */
        public RecognizeBankAccountLicenseResponse RecognizeBankAccountLicenseWithOptions(RecognizeBankAccountLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBankAccountLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBankAccountLicenseResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 银行开户许可证识别
         *
         * @param request RecognizeBankAccountLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeBankAccountLicenseResponse
         */
        public async Task<RecognizeBankAccountLicenseResponse> RecognizeBankAccountLicenseWithOptionsAsync(RecognizeBankAccountLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBankAccountLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBankAccountLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 银行开户许可证识别
         *
         * @param request RecognizeBankAccountLicenseRequest
         * @return RecognizeBankAccountLicenseResponse
         */
        public RecognizeBankAccountLicenseResponse RecognizeBankAccountLicense(RecognizeBankAccountLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBankAccountLicenseWithOptions(request, runtime);
        }

        /**
         * @summary 银行开户许可证识别
         *
         * @param request RecognizeBankAccountLicenseRequest
         * @return RecognizeBankAccountLicenseResponse
         */
        public async Task<RecognizeBankAccountLicenseResponse> RecognizeBankAccountLicenseAsync(RecognizeBankAccountLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBankAccountLicenseWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 银行卡识别
         *
         * @param request RecognizeBankCardRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeBankCardResponse
         */
        public RecognizeBankCardResponse RecognizeBankCardWithOptions(RecognizeBankCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBankCard",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBankCardResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 银行卡识别
         *
         * @param request RecognizeBankCardRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeBankCardResponse
         */
        public async Task<RecognizeBankCardResponse> RecognizeBankCardWithOptionsAsync(RecognizeBankCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBankCard",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBankCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 银行卡识别
         *
         * @param request RecognizeBankCardRequest
         * @return RecognizeBankCardResponse
         */
        public RecognizeBankCardResponse RecognizeBankCard(RecognizeBankCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBankCardWithOptions(request, runtime);
        }

        /**
         * @summary 银行卡识别
         *
         * @param request RecognizeBankCardRequest
         * @return RecognizeBankCardResponse
         */
        public async Task<RecognizeBankCardResponse> RecognizeBankCardAsync(RecognizeBankCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBankCardWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 电商图片文字识别
         *
         * @param request RecognizeBasicRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeBasicResponse
         */
        public RecognizeBasicResponse RecognizeBasicWithOptions(RecognizeBasicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBasic",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBasicResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 电商图片文字识别
         *
         * @param request RecognizeBasicRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeBasicResponse
         */
        public async Task<RecognizeBasicResponse> RecognizeBasicWithOptionsAsync(RecognizeBasicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBasic",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBasicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 电商图片文字识别
         *
         * @param request RecognizeBasicRequest
         * @return RecognizeBasicResponse
         */
        public RecognizeBasicResponse RecognizeBasic(RecognizeBasicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBasicWithOptions(request, runtime);
        }

        /**
         * @summary 电商图片文字识别
         *
         * @param request RecognizeBasicRequest
         * @return RecognizeBasicResponse
         */
        public async Task<RecognizeBasicResponse> RecognizeBasicAsync(RecognizeBasicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBasicWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 出生证明
         *
         * @param request RecognizeBirthCertificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeBirthCertificationResponse
         */
        public RecognizeBirthCertificationResponse RecognizeBirthCertificationWithOptions(RecognizeBirthCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBirthCertification",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBirthCertificationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 出生证明
         *
         * @param request RecognizeBirthCertificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeBirthCertificationResponse
         */
        public async Task<RecognizeBirthCertificationResponse> RecognizeBirthCertificationWithOptionsAsync(RecognizeBirthCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBirthCertification",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBirthCertificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 出生证明
         *
         * @param request RecognizeBirthCertificationRequest
         * @return RecognizeBirthCertificationResponse
         */
        public RecognizeBirthCertificationResponse RecognizeBirthCertification(RecognizeBirthCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBirthCertificationWithOptions(request, runtime);
        }

        /**
         * @summary 出生证明
         *
         * @param request RecognizeBirthCertificationRequest
         * @return RecognizeBirthCertificationResponse
         */
        public async Task<RecognizeBirthCertificationResponse> RecognizeBirthCertificationAsync(RecognizeBirthCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBirthCertificationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 客运车船票识别
         *
         * @param request RecognizeBusShipTicketRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeBusShipTicketResponse
         */
        public RecognizeBusShipTicketResponse RecognizeBusShipTicketWithOptions(RecognizeBusShipTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBusShipTicket",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBusShipTicketResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 客运车船票识别
         *
         * @param request RecognizeBusShipTicketRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeBusShipTicketResponse
         */
        public async Task<RecognizeBusShipTicketResponse> RecognizeBusShipTicketWithOptionsAsync(RecognizeBusShipTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBusShipTicket",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBusShipTicketResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 客运车船票识别
         *
         * @param request RecognizeBusShipTicketRequest
         * @return RecognizeBusShipTicketResponse
         */
        public RecognizeBusShipTicketResponse RecognizeBusShipTicket(RecognizeBusShipTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBusShipTicketWithOptions(request, runtime);
        }

        /**
         * @summary 客运车船票识别
         *
         * @param request RecognizeBusShipTicketRequest
         * @return RecognizeBusShipTicketResponse
         */
        public async Task<RecognizeBusShipTicketResponse> RecognizeBusShipTicketAsync(RecognizeBusShipTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBusShipTicketWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 营业执照识别
         *
         * @param request RecognizeBusinessLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeBusinessLicenseResponse
         */
        public RecognizeBusinessLicenseResponse RecognizeBusinessLicenseWithOptions(RecognizeBusinessLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBusinessLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBusinessLicenseResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 营业执照识别
         *
         * @param request RecognizeBusinessLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeBusinessLicenseResponse
         */
        public async Task<RecognizeBusinessLicenseResponse> RecognizeBusinessLicenseWithOptionsAsync(RecognizeBusinessLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBusinessLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBusinessLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 营业执照识别
         *
         * @param request RecognizeBusinessLicenseRequest
         * @return RecognizeBusinessLicenseResponse
         */
        public RecognizeBusinessLicenseResponse RecognizeBusinessLicense(RecognizeBusinessLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBusinessLicenseWithOptions(request, runtime);
        }

        /**
         * @summary 营业执照识别
         *
         * @param request RecognizeBusinessLicenseRequest
         * @return RecognizeBusinessLicenseResponse
         */
        public async Task<RecognizeBusinessLicenseResponse> RecognizeBusinessLicenseAsync(RecognizeBusinessLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBusinessLicenseWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 机动车销售发票
         *
         * @param request RecognizeCarInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeCarInvoiceResponse
         */
        public RecognizeCarInvoiceResponse RecognizeCarInvoiceWithOptions(RecognizeCarInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCarInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCarInvoiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 机动车销售发票
         *
         * @param request RecognizeCarInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeCarInvoiceResponse
         */
        public async Task<RecognizeCarInvoiceResponse> RecognizeCarInvoiceWithOptionsAsync(RecognizeCarInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCarInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCarInvoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 机动车销售发票
         *
         * @param request RecognizeCarInvoiceRequest
         * @return RecognizeCarInvoiceResponse
         */
        public RecognizeCarInvoiceResponse RecognizeCarInvoice(RecognizeCarInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCarInvoiceWithOptions(request, runtime);
        }

        /**
         * @summary 机动车销售发票
         *
         * @param request RecognizeCarInvoiceRequest
         * @return RecognizeCarInvoiceResponse
         */
        public async Task<RecognizeCarInvoiceResponse> RecognizeCarInvoiceAsync(RecognizeCarInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCarInvoiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 车牌识别
         *
         * @param request RecognizeCarNumberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeCarNumberResponse
         */
        public RecognizeCarNumberResponse RecognizeCarNumberWithOptions(RecognizeCarNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCarNumber",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCarNumberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 车牌识别
         *
         * @param request RecognizeCarNumberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeCarNumberResponse
         */
        public async Task<RecognizeCarNumberResponse> RecognizeCarNumberWithOptionsAsync(RecognizeCarNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCarNumber",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCarNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 车牌识别
         *
         * @param request RecognizeCarNumberRequest
         * @return RecognizeCarNumberResponse
         */
        public RecognizeCarNumberResponse RecognizeCarNumber(RecognizeCarNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCarNumberWithOptions(request, runtime);
        }

        /**
         * @summary 车牌识别
         *
         * @param request RecognizeCarNumberRequest
         * @return RecognizeCarNumberResponse
         */
        public async Task<RecognizeCarNumberResponse> RecognizeCarNumberAsync(RecognizeCarNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCarNumberWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 车辆vin码识别
         *
         * @param request RecognizeCarVinCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeCarVinCodeResponse
         */
        public RecognizeCarVinCodeResponse RecognizeCarVinCodeWithOptions(RecognizeCarVinCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCarVinCode",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCarVinCodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 车辆vin码识别
         *
         * @param request RecognizeCarVinCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeCarVinCodeResponse
         */
        public async Task<RecognizeCarVinCodeResponse> RecognizeCarVinCodeWithOptionsAsync(RecognizeCarVinCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCarVinCode",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCarVinCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 车辆vin码识别
         *
         * @param request RecognizeCarVinCodeRequest
         * @return RecognizeCarVinCodeResponse
         */
        public RecognizeCarVinCodeResponse RecognizeCarVinCode(RecognizeCarVinCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCarVinCodeWithOptions(request, runtime);
        }

        /**
         * @summary 车辆vin码识别
         *
         * @param request RecognizeCarVinCodeRequest
         * @return RecognizeCarVinCodeResponse
         */
        public async Task<RecognizeCarVinCodeResponse> RecognizeCarVinCodeAsync(RecognizeCarVinCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCarVinCodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 中国护照识别
         *
         * @param request RecognizeChinesePassportRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeChinesePassportResponse
         */
        public RecognizeChinesePassportResponse RecognizeChinesePassportWithOptions(RecognizeChinesePassportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeChinesePassport",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeChinesePassportResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 中国护照识别
         *
         * @param request RecognizeChinesePassportRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeChinesePassportResponse
         */
        public async Task<RecognizeChinesePassportResponse> RecognizeChinesePassportWithOptionsAsync(RecognizeChinesePassportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeChinesePassport",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeChinesePassportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 中国护照识别
         *
         * @param request RecognizeChinesePassportRequest
         * @return RecognizeChinesePassportResponse
         */
        public RecognizeChinesePassportResponse RecognizeChinesePassport(RecognizeChinesePassportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeChinesePassportWithOptions(request, runtime);
        }

        /**
         * @summary 中国护照识别
         *
         * @param request RecognizeChinesePassportRequest
         * @return RecognizeChinesePassportResponse
         */
        public async Task<RecognizeChinesePassportResponse> RecognizeChinesePassportAsync(RecognizeChinesePassportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeChinesePassportWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 通用机打发票识别
         *
         * @param request RecognizeCommonPrintedInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeCommonPrintedInvoiceResponse
         */
        public RecognizeCommonPrintedInvoiceResponse RecognizeCommonPrintedInvoiceWithOptions(RecognizeCommonPrintedInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCommonPrintedInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCommonPrintedInvoiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 通用机打发票识别
         *
         * @param request RecognizeCommonPrintedInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeCommonPrintedInvoiceResponse
         */
        public async Task<RecognizeCommonPrintedInvoiceResponse> RecognizeCommonPrintedInvoiceWithOptionsAsync(RecognizeCommonPrintedInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCommonPrintedInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCommonPrintedInvoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 通用机打发票识别
         *
         * @param request RecognizeCommonPrintedInvoiceRequest
         * @return RecognizeCommonPrintedInvoiceResponse
         */
        public RecognizeCommonPrintedInvoiceResponse RecognizeCommonPrintedInvoice(RecognizeCommonPrintedInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCommonPrintedInvoiceWithOptions(request, runtime);
        }

        /**
         * @summary 通用机打发票识别
         *
         * @param request RecognizeCommonPrintedInvoiceRequest
         * @return RecognizeCommonPrintedInvoiceResponse
         */
        public async Task<RecognizeCommonPrintedInvoiceResponse> RecognizeCommonPrintedInvoiceAsync(RecognizeCommonPrintedInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCommonPrintedInvoiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 化妆品生产许可证识别
         *
         * @param request RecognizeCosmeticProduceLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeCosmeticProduceLicenseResponse
         */
        public RecognizeCosmeticProduceLicenseResponse RecognizeCosmeticProduceLicenseWithOptions(RecognizeCosmeticProduceLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCosmeticProduceLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCosmeticProduceLicenseResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 化妆品生产许可证识别
         *
         * @param request RecognizeCosmeticProduceLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeCosmeticProduceLicenseResponse
         */
        public async Task<RecognizeCosmeticProduceLicenseResponse> RecognizeCosmeticProduceLicenseWithOptionsAsync(RecognizeCosmeticProduceLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCosmeticProduceLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCosmeticProduceLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 化妆品生产许可证识别
         *
         * @param request RecognizeCosmeticProduceLicenseRequest
         * @return RecognizeCosmeticProduceLicenseResponse
         */
        public RecognizeCosmeticProduceLicenseResponse RecognizeCosmeticProduceLicense(RecognizeCosmeticProduceLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCosmeticProduceLicenseWithOptions(request, runtime);
        }

        /**
         * @summary 化妆品生产许可证识别
         *
         * @param request RecognizeCosmeticProduceLicenseRequest
         * @return RecognizeCosmeticProduceLicenseResponse
         */
        public async Task<RecognizeCosmeticProduceLicenseResponse> RecognizeCosmeticProduceLicenseAsync(RecognizeCosmeticProduceLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCosmeticProduceLicenseWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 核算检测报告识别
         *
         * @param request RecognizeCovidTestReportRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeCovidTestReportResponse
         */
        public RecognizeCovidTestReportResponse RecognizeCovidTestReportWithOptions(RecognizeCovidTestReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultipleResult))
            {
                query["MultipleResult"] = request.MultipleResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCovidTestReport",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCovidTestReportResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 核算检测报告识别
         *
         * @param request RecognizeCovidTestReportRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeCovidTestReportResponse
         */
        public async Task<RecognizeCovidTestReportResponse> RecognizeCovidTestReportWithOptionsAsync(RecognizeCovidTestReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultipleResult))
            {
                query["MultipleResult"] = request.MultipleResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCovidTestReport",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCovidTestReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 核算检测报告识别
         *
         * @param request RecognizeCovidTestReportRequest
         * @return RecognizeCovidTestReportResponse
         */
        public RecognizeCovidTestReportResponse RecognizeCovidTestReport(RecognizeCovidTestReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCovidTestReportWithOptions(request, runtime);
        }

        /**
         * @summary 核算检测报告识别
         *
         * @param request RecognizeCovidTestReportRequest
         * @return RecognizeCovidTestReportResponse
         */
        public async Task<RecognizeCovidTestReportResponse> RecognizeCovidTestReportAsync(RecognizeCovidTestReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCovidTestReportWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 第二类医疗器械经营备案凭证
         *
         * @param request RecognizeCtwoMedicalDeviceManageLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeCtwoMedicalDeviceManageLicenseResponse
         */
        public RecognizeCtwoMedicalDeviceManageLicenseResponse RecognizeCtwoMedicalDeviceManageLicenseWithOptions(RecognizeCtwoMedicalDeviceManageLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCtwoMedicalDeviceManageLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCtwoMedicalDeviceManageLicenseResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 第二类医疗器械经营备案凭证
         *
         * @param request RecognizeCtwoMedicalDeviceManageLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeCtwoMedicalDeviceManageLicenseResponse
         */
        public async Task<RecognizeCtwoMedicalDeviceManageLicenseResponse> RecognizeCtwoMedicalDeviceManageLicenseWithOptionsAsync(RecognizeCtwoMedicalDeviceManageLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCtwoMedicalDeviceManageLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCtwoMedicalDeviceManageLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 第二类医疗器械经营备案凭证
         *
         * @param request RecognizeCtwoMedicalDeviceManageLicenseRequest
         * @return RecognizeCtwoMedicalDeviceManageLicenseResponse
         */
        public RecognizeCtwoMedicalDeviceManageLicenseResponse RecognizeCtwoMedicalDeviceManageLicense(RecognizeCtwoMedicalDeviceManageLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCtwoMedicalDeviceManageLicenseWithOptions(request, runtime);
        }

        /**
         * @summary 第二类医疗器械经营备案凭证
         *
         * @param request RecognizeCtwoMedicalDeviceManageLicenseRequest
         * @return RecognizeCtwoMedicalDeviceManageLicenseResponse
         */
        public async Task<RecognizeCtwoMedicalDeviceManageLicenseResponse> RecognizeCtwoMedicalDeviceManageLicenseAsync(RecognizeCtwoMedicalDeviceManageLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCtwoMedicalDeviceManageLicenseWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 文档结构化识别
         *
         * @param request RecognizeDocumentStructureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeDocumentStructureResponse
         */
        public RecognizeDocumentStructureResponse RecognizeDocumentStructureWithOptions(RecognizeDocumentStructureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSortPage))
            {
                query["NeedSortPage"] = request.NeedSortPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoStamp))
            {
                query["NoStamp"] = request.NoStamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Paragraph))
            {
                query["Paragraph"] = request.Paragraph;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                query["Row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseNewStyleOutput))
            {
                query["UseNewStyleOutput"] = request.UseNewStyleOutput;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeDocumentStructure",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeDocumentStructureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 文档结构化识别
         *
         * @param request RecognizeDocumentStructureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeDocumentStructureResponse
         */
        public async Task<RecognizeDocumentStructureResponse> RecognizeDocumentStructureWithOptionsAsync(RecognizeDocumentStructureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSortPage))
            {
                query["NeedSortPage"] = request.NeedSortPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoStamp))
            {
                query["NoStamp"] = request.NoStamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Paragraph))
            {
                query["Paragraph"] = request.Paragraph;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                query["Row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseNewStyleOutput))
            {
                query["UseNewStyleOutput"] = request.UseNewStyleOutput;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeDocumentStructure",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeDocumentStructureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 文档结构化识别
         *
         * @param request RecognizeDocumentStructureRequest
         * @return RecognizeDocumentStructureResponse
         */
        public RecognizeDocumentStructureResponse RecognizeDocumentStructure(RecognizeDocumentStructureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeDocumentStructureWithOptions(request, runtime);
        }

        /**
         * @summary 文档结构化识别
         *
         * @param request RecognizeDocumentStructureRequest
         * @return RecognizeDocumentStructureResponse
         */
        public async Task<RecognizeDocumentStructureResponse> RecognizeDocumentStructureAsync(RecognizeDocumentStructureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeDocumentStructureWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 驾驶证识别
         *
         * @param request RecognizeDrivingLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeDrivingLicenseResponse
         */
        public RecognizeDrivingLicenseResponse RecognizeDrivingLicenseWithOptions(RecognizeDrivingLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeDrivingLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeDrivingLicenseResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 驾驶证识别
         *
         * @param request RecognizeDrivingLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeDrivingLicenseResponse
         */
        public async Task<RecognizeDrivingLicenseResponse> RecognizeDrivingLicenseWithOptionsAsync(RecognizeDrivingLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeDrivingLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeDrivingLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 驾驶证识别
         *
         * @param request RecognizeDrivingLicenseRequest
         * @return RecognizeDrivingLicenseResponse
         */
        public RecognizeDrivingLicenseResponse RecognizeDrivingLicense(RecognizeDrivingLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeDrivingLicenseWithOptions(request, runtime);
        }

        /**
         * @summary 驾驶证识别
         *
         * @param request RecognizeDrivingLicenseRequest
         * @return RecognizeDrivingLicenseResponse
         */
        public async Task<RecognizeDrivingLicenseResponse> RecognizeDrivingLicenseAsync(RecognizeDrivingLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeDrivingLicenseWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 印刷体数学公式识别
         *
         * @param request RecognizeEduFormulaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeEduFormulaResponse
         */
        public RecognizeEduFormulaResponse RecognizeEduFormulaWithOptions(RecognizeEduFormulaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduFormula",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduFormulaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 印刷体数学公式识别
         *
         * @param request RecognizeEduFormulaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeEduFormulaResponse
         */
        public async Task<RecognizeEduFormulaResponse> RecognizeEduFormulaWithOptionsAsync(RecognizeEduFormulaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduFormula",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduFormulaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 印刷体数学公式识别
         *
         * @param request RecognizeEduFormulaRequest
         * @return RecognizeEduFormulaResponse
         */
        public RecognizeEduFormulaResponse RecognizeEduFormula(RecognizeEduFormulaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEduFormulaWithOptions(request, runtime);
        }

        /**
         * @summary 印刷体数学公式识别
         *
         * @param request RecognizeEduFormulaRequest
         * @return RecognizeEduFormulaResponse
         */
        public async Task<RecognizeEduFormulaResponse> RecognizeEduFormulaAsync(RecognizeEduFormulaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEduFormulaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 口算判题
         *
         * @param request RecognizeEduOralCalculationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeEduOralCalculationResponse
         */
        public RecognizeEduOralCalculationResponse RecognizeEduOralCalculationWithOptions(RecognizeEduOralCalculationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduOralCalculation",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduOralCalculationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 口算判题
         *
         * @param request RecognizeEduOralCalculationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeEduOralCalculationResponse
         */
        public async Task<RecognizeEduOralCalculationResponse> RecognizeEduOralCalculationWithOptionsAsync(RecognizeEduOralCalculationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduOralCalculation",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduOralCalculationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 口算判题
         *
         * @param request RecognizeEduOralCalculationRequest
         * @return RecognizeEduOralCalculationResponse
         */
        public RecognizeEduOralCalculationResponse RecognizeEduOralCalculation(RecognizeEduOralCalculationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEduOralCalculationWithOptions(request, runtime);
        }

        /**
         * @summary 口算判题
         *
         * @param request RecognizeEduOralCalculationRequest
         * @return RecognizeEduOralCalculationResponse
         */
        public async Task<RecognizeEduOralCalculationResponse> RecognizeEduOralCalculationAsync(RecognizeEduOralCalculationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEduOralCalculationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 试卷切题识别
         *
         * @param request RecognizeEduPaperCutRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeEduPaperCutResponse
         */
        public RecognizeEduPaperCutResponse RecognizeEduPaperCutWithOptions(RecognizeEduPaperCutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CutType))
            {
                query["CutType"] = request.CutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                query["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                query["Subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduPaperCut",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduPaperCutResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 试卷切题识别
         *
         * @param request RecognizeEduPaperCutRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeEduPaperCutResponse
         */
        public async Task<RecognizeEduPaperCutResponse> RecognizeEduPaperCutWithOptionsAsync(RecognizeEduPaperCutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CutType))
            {
                query["CutType"] = request.CutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                query["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                query["Subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduPaperCut",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduPaperCutResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 试卷切题识别
         *
         * @param request RecognizeEduPaperCutRequest
         * @return RecognizeEduPaperCutResponse
         */
        public RecognizeEduPaperCutResponse RecognizeEduPaperCut(RecognizeEduPaperCutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEduPaperCutWithOptions(request, runtime);
        }

        /**
         * @summary 试卷切题识别
         *
         * @param request RecognizeEduPaperCutRequest
         * @return RecognizeEduPaperCutResponse
         */
        public async Task<RecognizeEduPaperCutResponse> RecognizeEduPaperCutAsync(RecognizeEduPaperCutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEduPaperCutWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 整页试卷识别
         *
         * @param request RecognizeEduPaperOcrRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeEduPaperOcrResponse
         */
        public RecognizeEduPaperOcrResponse RecognizeEduPaperOcrWithOptions(RecognizeEduPaperOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                query["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputOricoord))
            {
                query["OutputOricoord"] = request.OutputOricoord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                query["Subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduPaperOcr",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduPaperOcrResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 整页试卷识别
         *
         * @param request RecognizeEduPaperOcrRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeEduPaperOcrResponse
         */
        public async Task<RecognizeEduPaperOcrResponse> RecognizeEduPaperOcrWithOptionsAsync(RecognizeEduPaperOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                query["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputOricoord))
            {
                query["OutputOricoord"] = request.OutputOricoord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                query["Subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduPaperOcr",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduPaperOcrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 整页试卷识别
         *
         * @param request RecognizeEduPaperOcrRequest
         * @return RecognizeEduPaperOcrResponse
         */
        public RecognizeEduPaperOcrResponse RecognizeEduPaperOcr(RecognizeEduPaperOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEduPaperOcrWithOptions(request, runtime);
        }

        /**
         * @summary 整页试卷识别
         *
         * @param request RecognizeEduPaperOcrRequest
         * @return RecognizeEduPaperOcrResponse
         */
        public async Task<RecognizeEduPaperOcrResponse> RecognizeEduPaperOcrAsync(RecognizeEduPaperOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEduPaperOcrWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 精细版结构化切题
         *
         * @param request RecognizeEduPaperStructedRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeEduPaperStructedResponse
         */
        public RecognizeEduPaperStructedResponse RecognizeEduPaperStructedWithOptions(RecognizeEduPaperStructedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                query["Subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduPaperStructed",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduPaperStructedResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 精细版结构化切题
         *
         * @param request RecognizeEduPaperStructedRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeEduPaperStructedResponse
         */
        public async Task<RecognizeEduPaperStructedResponse> RecognizeEduPaperStructedWithOptionsAsync(RecognizeEduPaperStructedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                query["Subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduPaperStructed",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduPaperStructedResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 精细版结构化切题
         *
         * @param request RecognizeEduPaperStructedRequest
         * @return RecognizeEduPaperStructedResponse
         */
        public RecognizeEduPaperStructedResponse RecognizeEduPaperStructed(RecognizeEduPaperStructedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEduPaperStructedWithOptions(request, runtime);
        }

        /**
         * @summary 精细版结构化切题
         *
         * @param request RecognizeEduPaperStructedRequest
         * @return RecognizeEduPaperStructedResponse
         */
        public async Task<RecognizeEduPaperStructedResponse> RecognizeEduPaperStructedAsync(RecognizeEduPaperStructedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEduPaperStructedWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 题目识别
         *
         * @param request RecognizeEduQuestionOcrRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeEduQuestionOcrResponse
         */
        public RecognizeEduQuestionOcrResponse RecognizeEduQuestionOcrWithOptions(RecognizeEduQuestionOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduQuestionOcr",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduQuestionOcrResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 题目识别
         *
         * @param request RecognizeEduQuestionOcrRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeEduQuestionOcrResponse
         */
        public async Task<RecognizeEduQuestionOcrResponse> RecognizeEduQuestionOcrWithOptionsAsync(RecognizeEduQuestionOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduQuestionOcr",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduQuestionOcrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 题目识别
         *
         * @param request RecognizeEduQuestionOcrRequest
         * @return RecognizeEduQuestionOcrResponse
         */
        public RecognizeEduQuestionOcrResponse RecognizeEduQuestionOcr(RecognizeEduQuestionOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEduQuestionOcrWithOptions(request, runtime);
        }

        /**
         * @summary 题目识别
         *
         * @param request RecognizeEduQuestionOcrRequest
         * @return RecognizeEduQuestionOcrResponse
         */
        public async Task<RecognizeEduQuestionOcrResponse> RecognizeEduQuestionOcrAsync(RecognizeEduQuestionOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEduQuestionOcrWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 英语专项识别
         *
         * @param request RecognizeEnglishRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeEnglishResponse
         */
        public RecognizeEnglishResponse RecognizeEnglishWithOptions(RecognizeEnglishRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEnglish",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEnglishResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 英语专项识别
         *
         * @param request RecognizeEnglishRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeEnglishResponse
         */
        public async Task<RecognizeEnglishResponse> RecognizeEnglishWithOptionsAsync(RecognizeEnglishRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEnglish",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEnglishResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 英语专项识别
         *
         * @param request RecognizeEnglishRequest
         * @return RecognizeEnglishResponse
         */
        public RecognizeEnglishResponse RecognizeEnglish(RecognizeEnglishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEnglishWithOptions(request, runtime);
        }

        /**
         * @summary 英语专项识别
         *
         * @param request RecognizeEnglishRequest
         * @return RecognizeEnglishResponse
         */
        public async Task<RecognizeEnglishResponse> RecognizeEnglishAsync(RecognizeEnglishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEnglishWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 不动产权证
         *
         * @param request RecognizeEstateCertificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeEstateCertificationResponse
         */
        public RecognizeEstateCertificationResponse RecognizeEstateCertificationWithOptions(RecognizeEstateCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEstateCertification",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEstateCertificationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 不动产权证
         *
         * @param request RecognizeEstateCertificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeEstateCertificationResponse
         */
        public async Task<RecognizeEstateCertificationResponse> RecognizeEstateCertificationWithOptionsAsync(RecognizeEstateCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEstateCertification",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEstateCertificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 不动产权证
         *
         * @param request RecognizeEstateCertificationRequest
         * @return RecognizeEstateCertificationResponse
         */
        public RecognizeEstateCertificationResponse RecognizeEstateCertification(RecognizeEstateCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEstateCertificationWithOptions(request, runtime);
        }

        /**
         * @summary 不动产权证
         *
         * @param request RecognizeEstateCertificationRequest
         * @return RecognizeEstateCertificationResponse
         */
        public async Task<RecognizeEstateCertificationResponse> RecognizeEstateCertificationAsync(RecognizeEstateCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEstateCertificationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 来往港澳台通行证识别
         *
         * @param request RecognizeExitEntryPermitToHKRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeExitEntryPermitToHKResponse
         */
        public RecognizeExitEntryPermitToHKResponse RecognizeExitEntryPermitToHKWithOptions(RecognizeExitEntryPermitToHKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeExitEntryPermitToHK",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeExitEntryPermitToHKResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 来往港澳台通行证识别
         *
         * @param request RecognizeExitEntryPermitToHKRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeExitEntryPermitToHKResponse
         */
        public async Task<RecognizeExitEntryPermitToHKResponse> RecognizeExitEntryPermitToHKWithOptionsAsync(RecognizeExitEntryPermitToHKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeExitEntryPermitToHK",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeExitEntryPermitToHKResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 来往港澳台通行证识别
         *
         * @param request RecognizeExitEntryPermitToHKRequest
         * @return RecognizeExitEntryPermitToHKResponse
         */
        public RecognizeExitEntryPermitToHKResponse RecognizeExitEntryPermitToHK(RecognizeExitEntryPermitToHKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeExitEntryPermitToHKWithOptions(request, runtime);
        }

        /**
         * @summary 来往港澳台通行证识别
         *
         * @param request RecognizeExitEntryPermitToHKRequest
         * @return RecognizeExitEntryPermitToHKResponse
         */
        public async Task<RecognizeExitEntryPermitToHKResponse> RecognizeExitEntryPermitToHKAsync(RecognizeExitEntryPermitToHKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeExitEntryPermitToHKWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 来往大陆(内地)通行证识别
         *
         * @param request RecognizeExitEntryPermitToMainlandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeExitEntryPermitToMainlandResponse
         */
        public RecognizeExitEntryPermitToMainlandResponse RecognizeExitEntryPermitToMainlandWithOptions(RecognizeExitEntryPermitToMainlandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeExitEntryPermitToMainland",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeExitEntryPermitToMainlandResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 来往大陆(内地)通行证识别
         *
         * @param request RecognizeExitEntryPermitToMainlandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeExitEntryPermitToMainlandResponse
         */
        public async Task<RecognizeExitEntryPermitToMainlandResponse> RecognizeExitEntryPermitToMainlandWithOptionsAsync(RecognizeExitEntryPermitToMainlandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeExitEntryPermitToMainland",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeExitEntryPermitToMainlandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 来往大陆(内地)通行证识别
         *
         * @param request RecognizeExitEntryPermitToMainlandRequest
         * @return RecognizeExitEntryPermitToMainlandResponse
         */
        public RecognizeExitEntryPermitToMainlandResponse RecognizeExitEntryPermitToMainland(RecognizeExitEntryPermitToMainlandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeExitEntryPermitToMainlandWithOptions(request, runtime);
        }

        /**
         * @summary 来往大陆(内地)通行证识别
         *
         * @param request RecognizeExitEntryPermitToMainlandRequest
         * @return RecognizeExitEntryPermitToMainlandResponse
         */
        public async Task<RecognizeExitEntryPermitToMainlandResponse> RecognizeExitEntryPermitToMainlandAsync(RecognizeExitEntryPermitToMainlandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeExitEntryPermitToMainlandWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 食品经营许可证
         *
         * @param request RecognizeFoodManageLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeFoodManageLicenseResponse
         */
        public RecognizeFoodManageLicenseResponse RecognizeFoodManageLicenseWithOptions(RecognizeFoodManageLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeFoodManageLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeFoodManageLicenseResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 食品经营许可证
         *
         * @param request RecognizeFoodManageLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeFoodManageLicenseResponse
         */
        public async Task<RecognizeFoodManageLicenseResponse> RecognizeFoodManageLicenseWithOptionsAsync(RecognizeFoodManageLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeFoodManageLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeFoodManageLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 食品经营许可证
         *
         * @param request RecognizeFoodManageLicenseRequest
         * @return RecognizeFoodManageLicenseResponse
         */
        public RecognizeFoodManageLicenseResponse RecognizeFoodManageLicense(RecognizeFoodManageLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeFoodManageLicenseWithOptions(request, runtime);
        }

        /**
         * @summary 食品经营许可证
         *
         * @param request RecognizeFoodManageLicenseRequest
         * @return RecognizeFoodManageLicenseResponse
         */
        public async Task<RecognizeFoodManageLicenseResponse> RecognizeFoodManageLicenseAsync(RecognizeFoodManageLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeFoodManageLicenseWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 食品生产许可证
         *
         * @param request RecognizeFoodProduceLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeFoodProduceLicenseResponse
         */
        public RecognizeFoodProduceLicenseResponse RecognizeFoodProduceLicenseWithOptions(RecognizeFoodProduceLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeFoodProduceLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeFoodProduceLicenseResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 食品生产许可证
         *
         * @param request RecognizeFoodProduceLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeFoodProduceLicenseResponse
         */
        public async Task<RecognizeFoodProduceLicenseResponse> RecognizeFoodProduceLicenseWithOptionsAsync(RecognizeFoodProduceLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeFoodProduceLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeFoodProduceLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 食品生产许可证
         *
         * @param request RecognizeFoodProduceLicenseRequest
         * @return RecognizeFoodProduceLicenseResponse
         */
        public RecognizeFoodProduceLicenseResponse RecognizeFoodProduceLicense(RecognizeFoodProduceLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeFoodProduceLicenseWithOptions(request, runtime);
        }

        /**
         * @summary 食品生产许可证
         *
         * @param request RecognizeFoodProduceLicenseRequest
         * @return RecognizeFoodProduceLicenseResponse
         */
        public async Task<RecognizeFoodProduceLicenseResponse> RecognizeFoodProduceLicenseAsync(RecognizeFoodProduceLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeFoodProduceLicenseWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 通用文字识别
         *
         * @param request RecognizeGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeGeneralResponse
         */
        public RecognizeGeneralResponse RecognizeGeneralWithOptions(RecognizeGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeGeneral",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeGeneralResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 通用文字识别
         *
         * @param request RecognizeGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeGeneralResponse
         */
        public async Task<RecognizeGeneralResponse> RecognizeGeneralWithOptionsAsync(RecognizeGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeGeneral",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeGeneralResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 通用文字识别
         *
         * @param request RecognizeGeneralRequest
         * @return RecognizeGeneralResponse
         */
        public RecognizeGeneralResponse RecognizeGeneral(RecognizeGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeGeneralWithOptions(request, runtime);
        }

        /**
         * @summary 通用文字识别
         *
         * @param request RecognizeGeneralRequest
         * @return RecognizeGeneralResponse
         */
        public async Task<RecognizeGeneralResponse> RecognizeGeneralAsync(RecognizeGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeGeneralWithOptionsAsync(request, runtime);
        }

        /**
         * @summary DocMaster
         *
         * @param tmpReq RecognizeGeneralStructureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeGeneralStructureResponse
         */
        public RecognizeGeneralStructureResponse RecognizeGeneralStructureWithOptions(RecognizeGeneralStructureRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RecognizeGeneralStructureShrinkRequest request = new RecognizeGeneralStructureShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keys))
            {
                request.KeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keys, "Keys", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeysShrink))
            {
                query["Keys"] = request.KeysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = tmpReq.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeGeneralStructure",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeGeneralStructureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary DocMaster
         *
         * @param tmpReq RecognizeGeneralStructureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeGeneralStructureResponse
         */
        public async Task<RecognizeGeneralStructureResponse> RecognizeGeneralStructureWithOptionsAsync(RecognizeGeneralStructureRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RecognizeGeneralStructureShrinkRequest request = new RecognizeGeneralStructureShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keys))
            {
                request.KeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keys, "Keys", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeysShrink))
            {
                query["Keys"] = request.KeysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = tmpReq.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeGeneralStructure",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeGeneralStructureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary DocMaster
         *
         * @param request RecognizeGeneralStructureRequest
         * @return RecognizeGeneralStructureResponse
         */
        public RecognizeGeneralStructureResponse RecognizeGeneralStructure(RecognizeGeneralStructureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeGeneralStructureWithOptions(request, runtime);
        }

        /**
         * @summary DocMaster
         *
         * @param request RecognizeGeneralStructureRequest
         * @return RecognizeGeneralStructureResponse
         */
        public async Task<RecognizeGeneralStructureResponse> RecognizeGeneralStructureAsync(RecognizeGeneralStructureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeGeneralStructureWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 香港身份证识别
         *
         * @param request RecognizeHKIdcardRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeHKIdcardResponse
         */
        public RecognizeHKIdcardResponse RecognizeHKIdcardWithOptions(RecognizeHKIdcardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeHKIdcard",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeHKIdcardResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 香港身份证识别
         *
         * @param request RecognizeHKIdcardRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeHKIdcardResponse
         */
        public async Task<RecognizeHKIdcardResponse> RecognizeHKIdcardWithOptionsAsync(RecognizeHKIdcardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeHKIdcard",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeHKIdcardResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 香港身份证识别
         *
         * @param request RecognizeHKIdcardRequest
         * @return RecognizeHKIdcardResponse
         */
        public RecognizeHKIdcardResponse RecognizeHKIdcard(RecognizeHKIdcardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeHKIdcardWithOptions(request, runtime);
        }

        /**
         * @summary 香港身份证识别
         *
         * @param request RecognizeHKIdcardRequest
         * @return RecognizeHKIdcardResponse
         */
        public async Task<RecognizeHKIdcardResponse> RecognizeHKIdcardAsync(RecognizeHKIdcardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeHKIdcardWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 通用手写体识别
         *
         * @param request RecognizeHandwritingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeHandwritingResponse
         */
        public RecognizeHandwritingResponse RecognizeHandwritingWithOptions(RecognizeHandwritingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSortPage))
            {
                query["NeedSortPage"] = request.NeedSortPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Paragraph))
            {
                query["Paragraph"] = request.Paragraph;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeHandwriting",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeHandwritingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 通用手写体识别
         *
         * @param request RecognizeHandwritingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeHandwritingResponse
         */
        public async Task<RecognizeHandwritingResponse> RecognizeHandwritingWithOptionsAsync(RecognizeHandwritingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSortPage))
            {
                query["NeedSortPage"] = request.NeedSortPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Paragraph))
            {
                query["Paragraph"] = request.Paragraph;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeHandwriting",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeHandwritingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 通用手写体识别
         *
         * @param request RecognizeHandwritingRequest
         * @return RecognizeHandwritingResponse
         */
        public RecognizeHandwritingResponse RecognizeHandwriting(RecognizeHandwritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeHandwritingWithOptions(request, runtime);
        }

        /**
         * @summary 通用手写体识别
         *
         * @param request RecognizeHandwritingRequest
         * @return RecognizeHandwritingResponse
         */
        public async Task<RecognizeHandwritingResponse> RecognizeHandwritingAsync(RecognizeHandwritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeHandwritingWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 防疫健康码识别
         *
         * @param request RecognizeHealthCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeHealthCodeResponse
         */
        public RecognizeHealthCodeResponse RecognizeHealthCodeWithOptions(RecognizeHealthCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeHealthCode",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeHealthCodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 防疫健康码识别
         *
         * @param request RecognizeHealthCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeHealthCodeResponse
         */
        public async Task<RecognizeHealthCodeResponse> RecognizeHealthCodeWithOptionsAsync(RecognizeHealthCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeHealthCode",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeHealthCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 防疫健康码识别
         *
         * @param request RecognizeHealthCodeRequest
         * @return RecognizeHealthCodeResponse
         */
        public RecognizeHealthCodeResponse RecognizeHealthCode(RecognizeHealthCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeHealthCodeWithOptions(request, runtime);
        }

        /**
         * @summary 防疫健康码识别
         *
         * @param request RecognizeHealthCodeRequest
         * @return RecognizeHealthCodeResponse
         */
        public async Task<RecognizeHealthCodeResponse> RecognizeHealthCodeAsync(RecognizeHealthCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeHealthCodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 酒店流水识别
         *
         * @param request RecognizeHotelConsumeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeHotelConsumeResponse
         */
        public RecognizeHotelConsumeResponse RecognizeHotelConsumeWithOptions(RecognizeHotelConsumeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeHotelConsume",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeHotelConsumeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 酒店流水识别
         *
         * @param request RecognizeHotelConsumeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeHotelConsumeResponse
         */
        public async Task<RecognizeHotelConsumeResponse> RecognizeHotelConsumeWithOptionsAsync(RecognizeHotelConsumeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeHotelConsume",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeHotelConsumeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 酒店流水识别
         *
         * @param request RecognizeHotelConsumeRequest
         * @return RecognizeHotelConsumeResponse
         */
        public RecognizeHotelConsumeResponse RecognizeHotelConsume(RecognizeHotelConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeHotelConsumeWithOptions(request, runtime);
        }

        /**
         * @summary 酒店流水识别
         *
         * @param request RecognizeHotelConsumeRequest
         * @return RecognizeHotelConsumeResponse
         */
        public async Task<RecognizeHotelConsumeResponse> RecognizeHotelConsumeAsync(RecognizeHotelConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeHotelConsumeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 户口本识别
         *
         * @param request RecognizeHouseholdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeHouseholdResponse
         */
        public RecognizeHouseholdResponse RecognizeHouseholdWithOptions(RecognizeHouseholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsResidentPage))
            {
                query["IsResidentPage"] = request.IsResidentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeHousehold",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeHouseholdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 户口本识别
         *
         * @param request RecognizeHouseholdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeHouseholdResponse
         */
        public async Task<RecognizeHouseholdResponse> RecognizeHouseholdWithOptionsAsync(RecognizeHouseholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsResidentPage))
            {
                query["IsResidentPage"] = request.IsResidentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeHousehold",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeHouseholdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 户口本识别
         *
         * @param request RecognizeHouseholdRequest
         * @return RecognizeHouseholdResponse
         */
        public RecognizeHouseholdResponse RecognizeHousehold(RecognizeHouseholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeHouseholdWithOptions(request, runtime);
        }

        /**
         * @summary 户口本识别
         *
         * @param request RecognizeHouseholdRequest
         * @return RecognizeHouseholdResponse
         */
        public async Task<RecognizeHouseholdResponse> RecognizeHouseholdAsync(RecognizeHouseholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeHouseholdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 身份证识别
         *
         * @param request RecognizeIdcardRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeIdcardResponse
         */
        public RecognizeIdcardResponse RecognizeIdcardWithOptions(RecognizeIdcardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputQualityInfo))
            {
                query["OutputQualityInfo"] = request.OutputQualityInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeIdcard",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeIdcardResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 身份证识别
         *
         * @param request RecognizeIdcardRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeIdcardResponse
         */
        public async Task<RecognizeIdcardResponse> RecognizeIdcardWithOptionsAsync(RecognizeIdcardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputQualityInfo))
            {
                query["OutputQualityInfo"] = request.OutputQualityInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeIdcard",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeIdcardResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 身份证识别
         *
         * @param request RecognizeIdcardRequest
         * @return RecognizeIdcardResponse
         */
        public RecognizeIdcardResponse RecognizeIdcard(RecognizeIdcardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeIdcardWithOptions(request, runtime);
        }

        /**
         * @summary 身份证识别
         *
         * @param request RecognizeIdcardRequest
         * @return RecognizeIdcardResponse
         */
        public async Task<RecognizeIdcardResponse> RecognizeIdcardAsync(RecognizeIdcardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeIdcardWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 国际营业执照识别
         *
         * @param request RecognizeInternationalBusinessLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeInternationalBusinessLicenseResponse
         */
        public RecognizeInternationalBusinessLicenseResponse RecognizeInternationalBusinessLicenseWithOptions(RecognizeInternationalBusinessLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeInternationalBusinessLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeInternationalBusinessLicenseResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 国际营业执照识别
         *
         * @param request RecognizeInternationalBusinessLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeInternationalBusinessLicenseResponse
         */
        public async Task<RecognizeInternationalBusinessLicenseResponse> RecognizeInternationalBusinessLicenseWithOptionsAsync(RecognizeInternationalBusinessLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeInternationalBusinessLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeInternationalBusinessLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 国际营业执照识别
         *
         * @param request RecognizeInternationalBusinessLicenseRequest
         * @return RecognizeInternationalBusinessLicenseResponse
         */
        public RecognizeInternationalBusinessLicenseResponse RecognizeInternationalBusinessLicense(RecognizeInternationalBusinessLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeInternationalBusinessLicenseWithOptions(request, runtime);
        }

        /**
         * @summary 国际营业执照识别
         *
         * @param request RecognizeInternationalBusinessLicenseRequest
         * @return RecognizeInternationalBusinessLicenseResponse
         */
        public async Task<RecognizeInternationalBusinessLicenseResponse> RecognizeInternationalBusinessLicenseAsync(RecognizeInternationalBusinessLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeInternationalBusinessLicenseWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 国际身份证识别
         *
         * @param request RecognizeInternationalIdcardRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeInternationalIdcardResponse
         */
        public RecognizeInternationalIdcardResponse RecognizeInternationalIdcardWithOptions(RecognizeInternationalIdcardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeInternationalIdcard",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeInternationalIdcardResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 国际身份证识别
         *
         * @param request RecognizeInternationalIdcardRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeInternationalIdcardResponse
         */
        public async Task<RecognizeInternationalIdcardResponse> RecognizeInternationalIdcardWithOptionsAsync(RecognizeInternationalIdcardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeInternationalIdcard",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeInternationalIdcardResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 国际身份证识别
         *
         * @param request RecognizeInternationalIdcardRequest
         * @return RecognizeInternationalIdcardResponse
         */
        public RecognizeInternationalIdcardResponse RecognizeInternationalIdcard(RecognizeInternationalIdcardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeInternationalIdcardWithOptions(request, runtime);
        }

        /**
         * @summary 国际身份证识别
         *
         * @param request RecognizeInternationalIdcardRequest
         * @return RecognizeInternationalIdcardResponse
         */
        public async Task<RecognizeInternationalIdcardResponse> RecognizeInternationalIdcardAsync(RecognizeInternationalIdcardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeInternationalIdcardWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 增值税发票识别
         *
         * @param request RecognizeInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeInvoiceResponse
         */
        public RecognizeInvoiceResponse RecognizeInvoiceWithOptions(RecognizeInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeInvoiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 增值税发票识别
         *
         * @param request RecognizeInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeInvoiceResponse
         */
        public async Task<RecognizeInvoiceResponse> RecognizeInvoiceWithOptionsAsync(RecognizeInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeInvoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 增值税发票识别
         *
         * @param request RecognizeInvoiceRequest
         * @return RecognizeInvoiceResponse
         */
        public RecognizeInvoiceResponse RecognizeInvoice(RecognizeInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeInvoiceWithOptions(request, runtime);
        }

        /**
         * @summary 增值税发票识别
         *
         * @param request RecognizeInvoiceRequest
         * @return RecognizeInvoiceResponse
         */
        public async Task<RecognizeInvoiceResponse> RecognizeInvoiceAsync(RecognizeInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeInvoiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 日语识别
         *
         * @param request RecognizeJanpaneseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeJanpaneseResponse
         */
        public RecognizeJanpaneseResponse RecognizeJanpaneseWithOptions(RecognizeJanpaneseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeJanpanese",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeJanpaneseResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 日语识别
         *
         * @param request RecognizeJanpaneseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeJanpaneseResponse
         */
        public async Task<RecognizeJanpaneseResponse> RecognizeJanpaneseWithOptionsAsync(RecognizeJanpaneseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeJanpanese",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeJanpaneseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 日语识别
         *
         * @param request RecognizeJanpaneseRequest
         * @return RecognizeJanpaneseResponse
         */
        public RecognizeJanpaneseResponse RecognizeJanpanese(RecognizeJanpaneseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeJanpaneseWithOptions(request, runtime);
        }

        /**
         * @summary 日语识别
         *
         * @param request RecognizeJanpaneseRequest
         * @return RecognizeJanpaneseResponse
         */
        public async Task<RecognizeJanpaneseResponse> RecognizeJanpaneseAsync(RecognizeJanpaneseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeJanpaneseWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 韩语识别
         *
         * @param request RecognizeKoreanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeKoreanResponse
         */
        public RecognizeKoreanResponse RecognizeKoreanWithOptions(RecognizeKoreanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeKorean",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeKoreanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 韩语识别
         *
         * @param request RecognizeKoreanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeKoreanResponse
         */
        public async Task<RecognizeKoreanResponse> RecognizeKoreanWithOptionsAsync(RecognizeKoreanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeKorean",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeKoreanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 韩语识别
         *
         * @param request RecognizeKoreanRequest
         * @return RecognizeKoreanResponse
         */
        public RecognizeKoreanResponse RecognizeKorean(RecognizeKoreanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeKoreanWithOptions(request, runtime);
        }

        /**
         * @summary 韩语识别
         *
         * @param request RecognizeKoreanRequest
         * @return RecognizeKoreanResponse
         */
        public async Task<RecognizeKoreanResponse> RecognizeKoreanAsync(RecognizeKoreanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeKoreanWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 拉丁语识别
         *
         * @param request RecognizeLatinRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeLatinResponse
         */
        public RecognizeLatinResponse RecognizeLatinWithOptions(RecognizeLatinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeLatin",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeLatinResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 拉丁语识别
         *
         * @param request RecognizeLatinRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeLatinResponse
         */
        public async Task<RecognizeLatinResponse> RecognizeLatinWithOptionsAsync(RecognizeLatinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeLatin",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeLatinResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 拉丁语识别
         *
         * @param request RecognizeLatinRequest
         * @return RecognizeLatinResponse
         */
        public RecognizeLatinResponse RecognizeLatin(RecognizeLatinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeLatinWithOptions(request, runtime);
        }

        /**
         * @summary 拉丁语识别
         *
         * @param request RecognizeLatinRequest
         * @return RecognizeLatinResponse
         */
        public async Task<RecognizeLatinResponse> RecognizeLatinAsync(RecognizeLatinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeLatinWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 医疗器械经营许可证
         *
         * @param request RecognizeMedicalDeviceManageLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeMedicalDeviceManageLicenseResponse
         */
        public RecognizeMedicalDeviceManageLicenseResponse RecognizeMedicalDeviceManageLicenseWithOptions(RecognizeMedicalDeviceManageLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeMedicalDeviceManageLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeMedicalDeviceManageLicenseResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 医疗器械经营许可证
         *
         * @param request RecognizeMedicalDeviceManageLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeMedicalDeviceManageLicenseResponse
         */
        public async Task<RecognizeMedicalDeviceManageLicenseResponse> RecognizeMedicalDeviceManageLicenseWithOptionsAsync(RecognizeMedicalDeviceManageLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeMedicalDeviceManageLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeMedicalDeviceManageLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 医疗器械经营许可证
         *
         * @param request RecognizeMedicalDeviceManageLicenseRequest
         * @return RecognizeMedicalDeviceManageLicenseResponse
         */
        public RecognizeMedicalDeviceManageLicenseResponse RecognizeMedicalDeviceManageLicense(RecognizeMedicalDeviceManageLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeMedicalDeviceManageLicenseWithOptions(request, runtime);
        }

        /**
         * @summary 医疗器械经营许可证
         *
         * @param request RecognizeMedicalDeviceManageLicenseRequest
         * @return RecognizeMedicalDeviceManageLicenseResponse
         */
        public async Task<RecognizeMedicalDeviceManageLicenseResponse> RecognizeMedicalDeviceManageLicenseAsync(RecognizeMedicalDeviceManageLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeMedicalDeviceManageLicenseWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 医疗器械生产许可证
         *
         * @param request RecognizeMedicalDeviceProduceLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeMedicalDeviceProduceLicenseResponse
         */
        public RecognizeMedicalDeviceProduceLicenseResponse RecognizeMedicalDeviceProduceLicenseWithOptions(RecognizeMedicalDeviceProduceLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeMedicalDeviceProduceLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeMedicalDeviceProduceLicenseResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 医疗器械生产许可证
         *
         * @param request RecognizeMedicalDeviceProduceLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeMedicalDeviceProduceLicenseResponse
         */
        public async Task<RecognizeMedicalDeviceProduceLicenseResponse> RecognizeMedicalDeviceProduceLicenseWithOptionsAsync(RecognizeMedicalDeviceProduceLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeMedicalDeviceProduceLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeMedicalDeviceProduceLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 医疗器械生产许可证
         *
         * @param request RecognizeMedicalDeviceProduceLicenseRequest
         * @return RecognizeMedicalDeviceProduceLicenseResponse
         */
        public RecognizeMedicalDeviceProduceLicenseResponse RecognizeMedicalDeviceProduceLicense(RecognizeMedicalDeviceProduceLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeMedicalDeviceProduceLicenseWithOptions(request, runtime);
        }

        /**
         * @summary 医疗器械生产许可证
         *
         * @param request RecognizeMedicalDeviceProduceLicenseRequest
         * @return RecognizeMedicalDeviceProduceLicenseResponse
         */
        public async Task<RecognizeMedicalDeviceProduceLicenseResponse> RecognizeMedicalDeviceProduceLicenseAsync(RecognizeMedicalDeviceProduceLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeMedicalDeviceProduceLicenseWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 混贴发票识别
         *
         * @param request RecognizeMixedInvoicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeMixedInvoicesResponse
         */
        public RecognizeMixedInvoicesResponse RecognizeMixedInvoicesWithOptions(RecognizeMixedInvoicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergePdfPages))
            {
                query["MergePdfPages"] = request.MergePdfPages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeMixedInvoices",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeMixedInvoicesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 混贴发票识别
         *
         * @param request RecognizeMixedInvoicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeMixedInvoicesResponse
         */
        public async Task<RecognizeMixedInvoicesResponse> RecognizeMixedInvoicesWithOptionsAsync(RecognizeMixedInvoicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergePdfPages))
            {
                query["MergePdfPages"] = request.MergePdfPages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeMixedInvoices",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeMixedInvoicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 混贴发票识别
         *
         * @param request RecognizeMixedInvoicesRequest
         * @return RecognizeMixedInvoicesResponse
         */
        public RecognizeMixedInvoicesResponse RecognizeMixedInvoices(RecognizeMixedInvoicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeMixedInvoicesWithOptions(request, runtime);
        }

        /**
         * @summary 混贴发票识别
         *
         * @param request RecognizeMixedInvoicesRequest
         * @return RecognizeMixedInvoicesResponse
         */
        public async Task<RecognizeMixedInvoicesResponse> RecognizeMixedInvoicesAsync(RecognizeMixedInvoicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeMixedInvoicesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 通用多语言识别
         *
         * @param tmpReq RecognizeMultiLanguageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeMultiLanguageResponse
         */
        public RecognizeMultiLanguageResponse RecognizeMultiLanguageWithOptions(RecognizeMultiLanguageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RecognizeMultiLanguageShrinkRequest request = new RecognizeMultiLanguageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Languages))
            {
                request.LanguagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Languages, "Languages", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguagesShrink))
            {
                query["Languages"] = request.LanguagesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSortPage))
            {
                query["NeedSortPage"] = request.NeedSortPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = tmpReq.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeMultiLanguage",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeMultiLanguageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 通用多语言识别
         *
         * @param tmpReq RecognizeMultiLanguageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeMultiLanguageResponse
         */
        public async Task<RecognizeMultiLanguageResponse> RecognizeMultiLanguageWithOptionsAsync(RecognizeMultiLanguageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RecognizeMultiLanguageShrinkRequest request = new RecognizeMultiLanguageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Languages))
            {
                request.LanguagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Languages, "Languages", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguagesShrink))
            {
                query["Languages"] = request.LanguagesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSortPage))
            {
                query["NeedSortPage"] = request.NeedSortPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = tmpReq.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeMultiLanguage",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeMultiLanguageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 通用多语言识别
         *
         * @param request RecognizeMultiLanguageRequest
         * @return RecognizeMultiLanguageResponse
         */
        public RecognizeMultiLanguageResponse RecognizeMultiLanguage(RecognizeMultiLanguageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeMultiLanguageWithOptions(request, runtime);
        }

        /**
         * @summary 通用多语言识别
         *
         * @param request RecognizeMultiLanguageRequest
         * @return RecognizeMultiLanguageResponse
         */
        public async Task<RecognizeMultiLanguageResponse> RecognizeMultiLanguageAsync(RecognizeMultiLanguageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeMultiLanguageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 非税收入票据识别
         *
         * @param request RecognizeNonTaxInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeNonTaxInvoiceResponse
         */
        public RecognizeNonTaxInvoiceResponse RecognizeNonTaxInvoiceWithOptions(RecognizeNonTaxInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeNonTaxInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeNonTaxInvoiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 非税收入票据识别
         *
         * @param request RecognizeNonTaxInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeNonTaxInvoiceResponse
         */
        public async Task<RecognizeNonTaxInvoiceResponse> RecognizeNonTaxInvoiceWithOptionsAsync(RecognizeNonTaxInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeNonTaxInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeNonTaxInvoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 非税收入票据识别
         *
         * @param request RecognizeNonTaxInvoiceRequest
         * @return RecognizeNonTaxInvoiceResponse
         */
        public RecognizeNonTaxInvoiceResponse RecognizeNonTaxInvoice(RecognizeNonTaxInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeNonTaxInvoiceWithOptions(request, runtime);
        }

        /**
         * @summary 非税收入票据识别
         *
         * @param request RecognizeNonTaxInvoiceRequest
         * @return RecognizeNonTaxInvoiceResponse
         */
        public async Task<RecognizeNonTaxInvoiceResponse> RecognizeNonTaxInvoiceAsync(RecognizeNonTaxInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeNonTaxInvoiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 护照识别
         *
         * @param request RecognizePassportRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizePassportResponse
         */
        public RecognizePassportResponse RecognizePassportWithOptions(RecognizePassportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizePassport",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizePassportResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 护照识别
         *
         * @param request RecognizePassportRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizePassportResponse
         */
        public async Task<RecognizePassportResponse> RecognizePassportWithOptionsAsync(RecognizePassportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizePassport",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizePassportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 护照识别
         *
         * @param request RecognizePassportRequest
         * @return RecognizePassportResponse
         */
        public RecognizePassportResponse RecognizePassport(RecognizePassportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizePassportWithOptions(request, runtime);
        }

        /**
         * @summary 护照识别
         *
         * @param request RecognizePassportRequest
         * @return RecognizePassportResponse
         */
        public async Task<RecognizePassportResponse> RecognizePassportAsync(RecognizePassportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizePassportWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 支付详情页识别
         *
         * @param request RecognizePaymentRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizePaymentRecordResponse
         */
        public RecognizePaymentRecordResponse RecognizePaymentRecordWithOptions(RecognizePaymentRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizePaymentRecord",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizePaymentRecordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 支付详情页识别
         *
         * @param request RecognizePaymentRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizePaymentRecordResponse
         */
        public async Task<RecognizePaymentRecordResponse> RecognizePaymentRecordWithOptionsAsync(RecognizePaymentRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizePaymentRecord",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizePaymentRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 支付详情页识别
         *
         * @param request RecognizePaymentRecordRequest
         * @return RecognizePaymentRecordResponse
         */
        public RecognizePaymentRecordResponse RecognizePaymentRecord(RecognizePaymentRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizePaymentRecordWithOptions(request, runtime);
        }

        /**
         * @summary 支付详情页识别
         *
         * @param request RecognizePaymentRecordRequest
         * @return RecognizePaymentRecordResponse
         */
        public async Task<RecognizePaymentRecordResponse> RecognizePaymentRecordAsync(RecognizePaymentRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizePaymentRecordWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 电商订单页识别
         *
         * @param request RecognizePurchaseRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizePurchaseRecordResponse
         */
        public RecognizePurchaseRecordResponse RecognizePurchaseRecordWithOptions(RecognizePurchaseRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputMultiOrders))
            {
                query["OutputMultiOrders"] = request.OutputMultiOrders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizePurchaseRecord",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizePurchaseRecordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 电商订单页识别
         *
         * @param request RecognizePurchaseRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizePurchaseRecordResponse
         */
        public async Task<RecognizePurchaseRecordResponse> RecognizePurchaseRecordWithOptionsAsync(RecognizePurchaseRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputMultiOrders))
            {
                query["OutputMultiOrders"] = request.OutputMultiOrders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizePurchaseRecord",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizePurchaseRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 电商订单页识别
         *
         * @param request RecognizePurchaseRecordRequest
         * @return RecognizePurchaseRecordResponse
         */
        public RecognizePurchaseRecordResponse RecognizePurchaseRecord(RecognizePurchaseRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizePurchaseRecordWithOptions(request, runtime);
        }

        /**
         * @summary 电商订单页识别
         *
         * @param request RecognizePurchaseRecordRequest
         * @return RecognizePurchaseRecordResponse
         */
        public async Task<RecognizePurchaseRecordResponse> RecognizePurchaseRecordAsync(RecognizePurchaseRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizePurchaseRecordWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 定额发票
         *
         * @param request RecognizeQuotaInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeQuotaInvoiceResponse
         */
        public RecognizeQuotaInvoiceResponse RecognizeQuotaInvoiceWithOptions(RecognizeQuotaInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeQuotaInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeQuotaInvoiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 定额发票
         *
         * @param request RecognizeQuotaInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeQuotaInvoiceResponse
         */
        public async Task<RecognizeQuotaInvoiceResponse> RecognizeQuotaInvoiceWithOptionsAsync(RecognizeQuotaInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeQuotaInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeQuotaInvoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 定额发票
         *
         * @param request RecognizeQuotaInvoiceRequest
         * @return RecognizeQuotaInvoiceResponse
         */
        public RecognizeQuotaInvoiceResponse RecognizeQuotaInvoice(RecognizeQuotaInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeQuotaInvoiceWithOptions(request, runtime);
        }

        /**
         * @summary 定额发票
         *
         * @param request RecognizeQuotaInvoiceRequest
         * @return RecognizeQuotaInvoiceResponse
         */
        public async Task<RecognizeQuotaInvoiceResponse> RecognizeQuotaInvoiceAsync(RecognizeQuotaInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeQuotaInvoiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 网约车行程单识别
         *
         * @param request RecognizeRideHailingItineraryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeRideHailingItineraryResponse
         */
        public RecognizeRideHailingItineraryResponse RecognizeRideHailingItineraryWithOptions(RecognizeRideHailingItineraryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeRideHailingItinerary",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeRideHailingItineraryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 网约车行程单识别
         *
         * @param request RecognizeRideHailingItineraryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeRideHailingItineraryResponse
         */
        public async Task<RecognizeRideHailingItineraryResponse> RecognizeRideHailingItineraryWithOptionsAsync(RecognizeRideHailingItineraryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeRideHailingItinerary",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeRideHailingItineraryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 网约车行程单识别
         *
         * @param request RecognizeRideHailingItineraryRequest
         * @return RecognizeRideHailingItineraryResponse
         */
        public RecognizeRideHailingItineraryResponse RecognizeRideHailingItinerary(RecognizeRideHailingItineraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeRideHailingItineraryWithOptions(request, runtime);
        }

        /**
         * @summary 网约车行程单识别
         *
         * @param request RecognizeRideHailingItineraryRequest
         * @return RecognizeRideHailingItineraryResponse
         */
        public async Task<RecognizeRideHailingItineraryResponse> RecognizeRideHailingItineraryAsync(RecognizeRideHailingItineraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeRideHailingItineraryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 增值税发票卷票
         *
         * @param request RecognizeRollTicketRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeRollTicketResponse
         */
        public RecognizeRollTicketResponse RecognizeRollTicketWithOptions(RecognizeRollTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeRollTicket",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeRollTicketResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 增值税发票卷票
         *
         * @param request RecognizeRollTicketRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeRollTicketResponse
         */
        public async Task<RecognizeRollTicketResponse> RecognizeRollTicketWithOptionsAsync(RecognizeRollTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeRollTicket",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeRollTicketResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 增值税发票卷票
         *
         * @param request RecognizeRollTicketRequest
         * @return RecognizeRollTicketResponse
         */
        public RecognizeRollTicketResponse RecognizeRollTicket(RecognizeRollTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeRollTicketWithOptions(request, runtime);
        }

        /**
         * @summary 增值税发票卷票
         *
         * @param request RecognizeRollTicketRequest
         * @return RecognizeRollTicketResponse
         */
        public async Task<RecognizeRollTicketResponse> RecognizeRollTicketAsync(RecognizeRollTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeRollTicketWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 俄语识别
         *
         * @param request RecognizeRussianRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeRussianResponse
         */
        public RecognizeRussianResponse RecognizeRussianWithOptions(RecognizeRussianRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeRussian",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeRussianResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 俄语识别
         *
         * @param request RecognizeRussianRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeRussianResponse
         */
        public async Task<RecognizeRussianResponse> RecognizeRussianWithOptionsAsync(RecognizeRussianRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeRussian",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeRussianResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 俄语识别
         *
         * @param request RecognizeRussianRequest
         * @return RecognizeRussianResponse
         */
        public RecognizeRussianResponse RecognizeRussian(RecognizeRussianRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeRussianWithOptions(request, runtime);
        }

        /**
         * @summary 俄语识别
         *
         * @param request RecognizeRussianRequest
         * @return RecognizeRussianResponse
         */
        public async Task<RecognizeRussianResponse> RecognizeRussianAsync(RecognizeRussianRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeRussianWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 购物小票识别
         *
         * @param request RecognizeShoppingReceiptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeShoppingReceiptResponse
         */
        public RecognizeShoppingReceiptResponse RecognizeShoppingReceiptWithOptions(RecognizeShoppingReceiptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeShoppingReceipt",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeShoppingReceiptResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 购物小票识别
         *
         * @param request RecognizeShoppingReceiptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeShoppingReceiptResponse
         */
        public async Task<RecognizeShoppingReceiptResponse> RecognizeShoppingReceiptWithOptionsAsync(RecognizeShoppingReceiptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeShoppingReceipt",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeShoppingReceiptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 购物小票识别
         *
         * @param request RecognizeShoppingReceiptRequest
         * @return RecognizeShoppingReceiptResponse
         */
        public RecognizeShoppingReceiptResponse RecognizeShoppingReceipt(RecognizeShoppingReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeShoppingReceiptWithOptions(request, runtime);
        }

        /**
         * @summary 购物小票识别
         *
         * @param request RecognizeShoppingReceiptRequest
         * @return RecognizeShoppingReceiptResponse
         */
        public async Task<RecognizeShoppingReceiptResponse> RecognizeShoppingReceiptAsync(RecognizeShoppingReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeShoppingReceiptWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 社会保障卡识别
         *
         * @param request RecognizeSocialSecurityCardRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeSocialSecurityCardResponse
         */
        public RecognizeSocialSecurityCardResponse RecognizeSocialSecurityCardWithOptions(RecognizeSocialSecurityCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeSocialSecurityCard",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeSocialSecurityCardResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 社会保障卡识别
         *
         * @param request RecognizeSocialSecurityCardRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeSocialSecurityCardResponse
         */
        public async Task<RecognizeSocialSecurityCardResponse> RecognizeSocialSecurityCardWithOptionsAsync(RecognizeSocialSecurityCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeSocialSecurityCard",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeSocialSecurityCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 社会保障卡识别
         *
         * @param request RecognizeSocialSecurityCardRequest
         * @return RecognizeSocialSecurityCardResponse
         */
        public RecognizeSocialSecurityCardResponse RecognizeSocialSecurityCard(RecognizeSocialSecurityCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeSocialSecurityCardWithOptions(request, runtime);
        }

        /**
         * @summary 社会保障卡识别
         *
         * @param request RecognizeSocialSecurityCardRequest
         * @return RecognizeSocialSecurityCardResponse
         */
        public async Task<RecognizeSocialSecurityCardResponse> RecognizeSocialSecurityCardAsync(RecognizeSocialSecurityCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeSocialSecurityCardWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 社保卡识别
         *
         * @param request RecognizeSocialSecurityCardVersionIIRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeSocialSecurityCardVersionIIResponse
         */
        public RecognizeSocialSecurityCardVersionIIResponse RecognizeSocialSecurityCardVersionIIWithOptions(RecognizeSocialSecurityCardVersionIIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeSocialSecurityCardVersionII",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeSocialSecurityCardVersionIIResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 社保卡识别
         *
         * @param request RecognizeSocialSecurityCardVersionIIRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeSocialSecurityCardVersionIIResponse
         */
        public async Task<RecognizeSocialSecurityCardVersionIIResponse> RecognizeSocialSecurityCardVersionIIWithOptionsAsync(RecognizeSocialSecurityCardVersionIIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeSocialSecurityCardVersionII",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeSocialSecurityCardVersionIIResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 社保卡识别
         *
         * @param request RecognizeSocialSecurityCardVersionIIRequest
         * @return RecognizeSocialSecurityCardVersionIIResponse
         */
        public RecognizeSocialSecurityCardVersionIIResponse RecognizeSocialSecurityCardVersionII(RecognizeSocialSecurityCardVersionIIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeSocialSecurityCardVersionIIWithOptions(request, runtime);
        }

        /**
         * @summary 社保卡识别
         *
         * @param request RecognizeSocialSecurityCardVersionIIRequest
         * @return RecognizeSocialSecurityCardVersionIIResponse
         */
        public async Task<RecognizeSocialSecurityCardVersionIIResponse> RecognizeSocialSecurityCardVersionIIAsync(RecognizeSocialSecurityCardVersionIIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeSocialSecurityCardVersionIIWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 表格识别
         *
         * @param request RecognizeTableOcrRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeTableOcrResponse
         */
        public RecognizeTableOcrResponse RecognizeTableOcrWithOptions(RecognizeTableOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsHandWriting))
            {
                query["IsHandWriting"] = request.IsHandWriting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LineLess))
            {
                query["LineLess"] = request.LineLess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipDetection))
            {
                query["SkipDetection"] = request.SkipDetection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTableOcr",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTableOcrResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 表格识别
         *
         * @param request RecognizeTableOcrRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeTableOcrResponse
         */
        public async Task<RecognizeTableOcrResponse> RecognizeTableOcrWithOptionsAsync(RecognizeTableOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsHandWriting))
            {
                query["IsHandWriting"] = request.IsHandWriting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LineLess))
            {
                query["LineLess"] = request.LineLess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipDetection))
            {
                query["SkipDetection"] = request.SkipDetection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTableOcr",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTableOcrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 表格识别
         *
         * @param request RecognizeTableOcrRequest
         * @return RecognizeTableOcrResponse
         */
        public RecognizeTableOcrResponse RecognizeTableOcr(RecognizeTableOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTableOcrWithOptions(request, runtime);
        }

        /**
         * @summary 表格识别
         *
         * @param request RecognizeTableOcrRequest
         * @return RecognizeTableOcrResponse
         */
        public async Task<RecognizeTableOcrResponse> RecognizeTableOcrAsync(RecognizeTableOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTableOcrWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 税收完税证明识别
         *
         * @param request RecognizeTaxClearanceCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeTaxClearanceCertificateResponse
         */
        public RecognizeTaxClearanceCertificateResponse RecognizeTaxClearanceCertificateWithOptions(RecognizeTaxClearanceCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTaxClearanceCertificate",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTaxClearanceCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 税收完税证明识别
         *
         * @param request RecognizeTaxClearanceCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeTaxClearanceCertificateResponse
         */
        public async Task<RecognizeTaxClearanceCertificateResponse> RecognizeTaxClearanceCertificateWithOptionsAsync(RecognizeTaxClearanceCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTaxClearanceCertificate",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTaxClearanceCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 税收完税证明识别
         *
         * @param request RecognizeTaxClearanceCertificateRequest
         * @return RecognizeTaxClearanceCertificateResponse
         */
        public RecognizeTaxClearanceCertificateResponse RecognizeTaxClearanceCertificate(RecognizeTaxClearanceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTaxClearanceCertificateWithOptions(request, runtime);
        }

        /**
         * @summary 税收完税证明识别
         *
         * @param request RecognizeTaxClearanceCertificateRequest
         * @return RecognizeTaxClearanceCertificateResponse
         */
        public async Task<RecognizeTaxClearanceCertificateResponse> RecognizeTaxClearanceCertificateAsync(RecognizeTaxClearanceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTaxClearanceCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 出租车发票
         *
         * @param request RecognizeTaxiInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeTaxiInvoiceResponse
         */
        public RecognizeTaxiInvoiceResponse RecognizeTaxiInvoiceWithOptions(RecognizeTaxiInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTaxiInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTaxiInvoiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 出租车发票
         *
         * @param request RecognizeTaxiInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeTaxiInvoiceResponse
         */
        public async Task<RecognizeTaxiInvoiceResponse> RecognizeTaxiInvoiceWithOptionsAsync(RecognizeTaxiInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTaxiInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTaxiInvoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 出租车发票
         *
         * @param request RecognizeTaxiInvoiceRequest
         * @return RecognizeTaxiInvoiceResponse
         */
        public RecognizeTaxiInvoiceResponse RecognizeTaxiInvoice(RecognizeTaxiInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTaxiInvoiceWithOptions(request, runtime);
        }

        /**
         * @summary 出租车发票
         *
         * @param request RecognizeTaxiInvoiceRequest
         * @return RecognizeTaxiInvoiceResponse
         */
        public async Task<RecognizeTaxiInvoiceResponse> RecognizeTaxiInvoiceAsync(RecognizeTaxiInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTaxiInvoiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 泰语识别
         *
         * @param request RecognizeThaiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeThaiResponse
         */
        public RecognizeThaiResponse RecognizeThaiWithOptions(RecognizeThaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeThai",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeThaiResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 泰语识别
         *
         * @param request RecognizeThaiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeThaiResponse
         */
        public async Task<RecognizeThaiResponse> RecognizeThaiWithOptionsAsync(RecognizeThaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeThai",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeThaiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 泰语识别
         *
         * @param request RecognizeThaiRequest
         * @return RecognizeThaiResponse
         */
        public RecognizeThaiResponse RecognizeThai(RecognizeThaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeThaiWithOptions(request, runtime);
        }

        /**
         * @summary 泰语识别
         *
         * @param request RecognizeThaiRequest
         * @return RecognizeThaiResponse
         */
        public async Task<RecognizeThaiResponse> RecognizeThaiAsync(RecognizeThaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeThaiWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 过路过桥费发票识别
         *
         * @param request RecognizeTollInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeTollInvoiceResponse
         */
        public RecognizeTollInvoiceResponse RecognizeTollInvoiceWithOptions(RecognizeTollInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTollInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTollInvoiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 过路过桥费发票识别
         *
         * @param request RecognizeTollInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeTollInvoiceResponse
         */
        public async Task<RecognizeTollInvoiceResponse> RecognizeTollInvoiceWithOptionsAsync(RecognizeTollInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTollInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTollInvoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 过路过桥费发票识别
         *
         * @param request RecognizeTollInvoiceRequest
         * @return RecognizeTollInvoiceResponse
         */
        public RecognizeTollInvoiceResponse RecognizeTollInvoice(RecognizeTollInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTollInvoiceWithOptions(request, runtime);
        }

        /**
         * @summary 过路过桥费发票识别
         *
         * @param request RecognizeTollInvoiceRequest
         * @return RecognizeTollInvoiceResponse
         */
        public async Task<RecognizeTollInvoiceResponse> RecognizeTollInvoiceAsync(RecognizeTollInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTollInvoiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 商标注册证
         *
         * @param request RecognizeTradeMarkCertificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeTradeMarkCertificationResponse
         */
        public RecognizeTradeMarkCertificationResponse RecognizeTradeMarkCertificationWithOptions(RecognizeTradeMarkCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTradeMarkCertification",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTradeMarkCertificationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 商标注册证
         *
         * @param request RecognizeTradeMarkCertificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeTradeMarkCertificationResponse
         */
        public async Task<RecognizeTradeMarkCertificationResponse> RecognizeTradeMarkCertificationWithOptionsAsync(RecognizeTradeMarkCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTradeMarkCertification",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTradeMarkCertificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 商标注册证
         *
         * @param request RecognizeTradeMarkCertificationRequest
         * @return RecognizeTradeMarkCertificationResponse
         */
        public RecognizeTradeMarkCertificationResponse RecognizeTradeMarkCertification(RecognizeTradeMarkCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTradeMarkCertificationWithOptions(request, runtime);
        }

        /**
         * @summary 商标注册证
         *
         * @param request RecognizeTradeMarkCertificationRequest
         * @return RecognizeTradeMarkCertificationResponse
         */
        public async Task<RecognizeTradeMarkCertificationResponse> RecognizeTradeMarkCertificationAsync(RecognizeTradeMarkCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTradeMarkCertificationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 火车票
         *
         * @param request RecognizeTrainInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeTrainInvoiceResponse
         */
        public RecognizeTrainInvoiceResponse RecognizeTrainInvoiceWithOptions(RecognizeTrainInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTrainInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTrainInvoiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 火车票
         *
         * @param request RecognizeTrainInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeTrainInvoiceResponse
         */
        public async Task<RecognizeTrainInvoiceResponse> RecognizeTrainInvoiceWithOptionsAsync(RecognizeTrainInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTrainInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTrainInvoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 火车票
         *
         * @param request RecognizeTrainInvoiceRequest
         * @return RecognizeTrainInvoiceResponse
         */
        public RecognizeTrainInvoiceResponse RecognizeTrainInvoice(RecognizeTrainInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTrainInvoiceWithOptions(request, runtime);
        }

        /**
         * @summary 火车票
         *
         * @param request RecognizeTrainInvoiceRequest
         * @return RecognizeTrainInvoiceResponse
         */
        public async Task<RecognizeTrainInvoiceResponse> RecognizeTrainInvoiceAsync(RecognizeTrainInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTrainInvoiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 二手车统一销售发票识别
         *
         * @param request RecognizeUsedCarInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeUsedCarInvoiceResponse
         */
        public RecognizeUsedCarInvoiceResponse RecognizeUsedCarInvoiceWithOptions(RecognizeUsedCarInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeUsedCarInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeUsedCarInvoiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 二手车统一销售发票识别
         *
         * @param request RecognizeUsedCarInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeUsedCarInvoiceResponse
         */
        public async Task<RecognizeUsedCarInvoiceResponse> RecognizeUsedCarInvoiceWithOptionsAsync(RecognizeUsedCarInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeUsedCarInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeUsedCarInvoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 二手车统一销售发票识别
         *
         * @param request RecognizeUsedCarInvoiceRequest
         * @return RecognizeUsedCarInvoiceResponse
         */
        public RecognizeUsedCarInvoiceResponse RecognizeUsedCarInvoice(RecognizeUsedCarInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeUsedCarInvoiceWithOptions(request, runtime);
        }

        /**
         * @summary 二手车统一销售发票识别
         *
         * @param request RecognizeUsedCarInvoiceRequest
         * @return RecognizeUsedCarInvoiceResponse
         */
        public async Task<RecognizeUsedCarInvoiceResponse> RecognizeUsedCarInvoiceAsync(RecognizeUsedCarInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeUsedCarInvoiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 车辆合格证识别
         *
         * @param request RecognizeVehicleCertificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeVehicleCertificationResponse
         */
        public RecognizeVehicleCertificationResponse RecognizeVehicleCertificationWithOptions(RecognizeVehicleCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVehicleCertification",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVehicleCertificationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 车辆合格证识别
         *
         * @param request RecognizeVehicleCertificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeVehicleCertificationResponse
         */
        public async Task<RecognizeVehicleCertificationResponse> RecognizeVehicleCertificationWithOptionsAsync(RecognizeVehicleCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVehicleCertification",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVehicleCertificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 车辆合格证识别
         *
         * @param request RecognizeVehicleCertificationRequest
         * @return RecognizeVehicleCertificationResponse
         */
        public RecognizeVehicleCertificationResponse RecognizeVehicleCertification(RecognizeVehicleCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeVehicleCertificationWithOptions(request, runtime);
        }

        /**
         * @summary 车辆合格证识别
         *
         * @param request RecognizeVehicleCertificationRequest
         * @return RecognizeVehicleCertificationResponse
         */
        public async Task<RecognizeVehicleCertificationResponse> RecognizeVehicleCertificationAsync(RecognizeVehicleCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeVehicleCertificationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 行驶证识别
         *
         * @param request RecognizeVehicleLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeVehicleLicenseResponse
         */
        public RecognizeVehicleLicenseResponse RecognizeVehicleLicenseWithOptions(RecognizeVehicleLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVehicleLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVehicleLicenseResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 行驶证识别
         *
         * @param request RecognizeVehicleLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeVehicleLicenseResponse
         */
        public async Task<RecognizeVehicleLicenseResponse> RecognizeVehicleLicenseWithOptionsAsync(RecognizeVehicleLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVehicleLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVehicleLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 行驶证识别
         *
         * @param request RecognizeVehicleLicenseRequest
         * @return RecognizeVehicleLicenseResponse
         */
        public RecognizeVehicleLicenseResponse RecognizeVehicleLicense(RecognizeVehicleLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeVehicleLicenseWithOptions(request, runtime);
        }

        /**
         * @summary 行驶证识别
         *
         * @param request RecognizeVehicleLicenseRequest
         * @return RecognizeVehicleLicenseResponse
         */
        public async Task<RecognizeVehicleLicenseResponse> RecognizeVehicleLicenseAsync(RecognizeVehicleLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeVehicleLicenseWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 机动车注册登记证识别
         *
         * @param request RecognizeVehicleRegistrationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeVehicleRegistrationResponse
         */
        public RecognizeVehicleRegistrationResponse RecognizeVehicleRegistrationWithOptions(RecognizeVehicleRegistrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVehicleRegistration",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVehicleRegistrationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 机动车注册登记证识别
         *
         * @param request RecognizeVehicleRegistrationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeVehicleRegistrationResponse
         */
        public async Task<RecognizeVehicleRegistrationResponse> RecognizeVehicleRegistrationWithOptionsAsync(RecognizeVehicleRegistrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVehicleRegistration",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVehicleRegistrationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 机动车注册登记证识别
         *
         * @param request RecognizeVehicleRegistrationRequest
         * @return RecognizeVehicleRegistrationResponse
         */
        public RecognizeVehicleRegistrationResponse RecognizeVehicleRegistration(RecognizeVehicleRegistrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeVehicleRegistrationWithOptions(request, runtime);
        }

        /**
         * @summary 机动车注册登记证识别
         *
         * @param request RecognizeVehicleRegistrationRequest
         * @return RecognizeVehicleRegistrationResponse
         */
        public async Task<RecognizeVehicleRegistrationResponse> RecognizeVehicleRegistrationAsync(RecognizeVehicleRegistrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeVehicleRegistrationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 电子面单识别
         *
         * @param request RecognizeWaybillRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeWaybillResponse
         */
        public RecognizeWaybillResponse RecognizeWaybillWithOptions(RecognizeWaybillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeWaybill",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeWaybillResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 电子面单识别
         *
         * @param request RecognizeWaybillRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecognizeWaybillResponse
         */
        public async Task<RecognizeWaybillResponse> RecognizeWaybillWithOptionsAsync(RecognizeWaybillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeWaybill",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeWaybillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 电子面单识别
         *
         * @param request RecognizeWaybillRequest
         * @return RecognizeWaybillResponse
         */
        public RecognizeWaybillResponse RecognizeWaybill(RecognizeWaybillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeWaybillWithOptions(request, runtime);
        }

        /**
         * @summary 电子面单识别
         *
         * @param request RecognizeWaybillRequest
         * @return RecognizeWaybillResponse
         */
        public async Task<RecognizeWaybillResponse> RecognizeWaybillAsync(RecognizeWaybillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeWaybillWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 营业执照核验
         *
         * @param request VerifyBusinessLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyBusinessLicenseResponse
         */
        public VerifyBusinessLicenseResponse VerifyBusinessLicenseWithOptions(VerifyBusinessLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyName))
            {
                query["CompanyName"] = request.CompanyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditCode))
            {
                query["CreditCode"] = request.CreditCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPerson))
            {
                query["LegalPerson"] = request.LegalPerson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyBusinessLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyBusinessLicenseResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 营业执照核验
         *
         * @param request VerifyBusinessLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyBusinessLicenseResponse
         */
        public async Task<VerifyBusinessLicenseResponse> VerifyBusinessLicenseWithOptionsAsync(VerifyBusinessLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyName))
            {
                query["CompanyName"] = request.CompanyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditCode))
            {
                query["CreditCode"] = request.CreditCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPerson))
            {
                query["LegalPerson"] = request.LegalPerson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyBusinessLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyBusinessLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 营业执照核验
         *
         * @param request VerifyBusinessLicenseRequest
         * @return VerifyBusinessLicenseResponse
         */
        public VerifyBusinessLicenseResponse VerifyBusinessLicense(VerifyBusinessLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyBusinessLicenseWithOptions(request, runtime);
        }

        /**
         * @summary 营业执照核验
         *
         * @param request VerifyBusinessLicenseRequest
         * @return VerifyBusinessLicenseResponse
         */
        public async Task<VerifyBusinessLicenseResponse> VerifyBusinessLicenseAsync(VerifyBusinessLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyBusinessLicenseWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 增值税发票核验
         *
         * @param request VerifyVATInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyVATInvoiceResponse
         */
        public VerifyVATInvoiceResponse VerifyVATInvoiceWithOptions(VerifyVATInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceCode))
            {
                query["InvoiceCode"] = request.InvoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceDate))
            {
                query["InvoiceDate"] = request.InvoiceDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceKind))
            {
                query["InvoiceKind"] = request.InvoiceKind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceNo))
            {
                query["InvoiceNo"] = request.InvoiceNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceSum))
            {
                query["InvoiceSum"] = request.InvoiceSum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyCode))
            {
                query["VerifyCode"] = request.VerifyCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyVATInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyVATInvoiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 增值税发票核验
         *
         * @param request VerifyVATInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyVATInvoiceResponse
         */
        public async Task<VerifyVATInvoiceResponse> VerifyVATInvoiceWithOptionsAsync(VerifyVATInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceCode))
            {
                query["InvoiceCode"] = request.InvoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceDate))
            {
                query["InvoiceDate"] = request.InvoiceDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceKind))
            {
                query["InvoiceKind"] = request.InvoiceKind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceNo))
            {
                query["InvoiceNo"] = request.InvoiceNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceSum))
            {
                query["InvoiceSum"] = request.InvoiceSum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyCode))
            {
                query["VerifyCode"] = request.VerifyCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyVATInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyVATInvoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 增值税发票核验
         *
         * @param request VerifyVATInvoiceRequest
         * @return VerifyVATInvoiceResponse
         */
        public VerifyVATInvoiceResponse VerifyVATInvoice(VerifyVATInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyVATInvoiceWithOptions(request, runtime);
        }

        /**
         * @summary 增值税发票核验
         *
         * @param request VerifyVATInvoiceRequest
         * @return VerifyVATInvoiceResponse
         */
        public async Task<VerifyVATInvoiceResponse> VerifyVATInvoiceAsync(VerifyVATInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyVATInvoiceWithOptionsAsync(request, runtime);
        }

    }
}
