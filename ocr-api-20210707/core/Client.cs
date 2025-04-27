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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>全文识别高精版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeAdvancedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeAdvancedResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>全文识别高精版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeAdvancedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeAdvancedResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>全文识别高精版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeAdvancedRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeAdvancedResponse
        /// </returns>
        public RecognizeAdvancedResponse RecognizeAdvanced(RecognizeAdvancedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeAdvancedWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>全文识别高精版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeAdvancedRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeAdvancedResponse
        /// </returns>
        public async Task<RecognizeAdvancedResponse> RecognizeAdvancedAsync(RecognizeAdvancedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeAdvancedWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>航空行程单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeAirItineraryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeAirItineraryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>航空行程单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeAirItineraryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeAirItineraryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>航空行程单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeAirItineraryRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeAirItineraryResponse
        /// </returns>
        public RecognizeAirItineraryResponse RecognizeAirItinerary(RecognizeAirItineraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeAirItineraryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>航空行程单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeAirItineraryRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeAirItineraryResponse
        /// </returns>
        public async Task<RecognizeAirItineraryResponse> RecognizeAirItineraryAsync(RecognizeAirItineraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeAirItineraryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>统一Api</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RecognizeAllTextRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeAllTextResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>统一Api</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RecognizeAllTextRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeAllTextResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>统一Api</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeAllTextRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeAllTextResponse
        /// </returns>
        public RecognizeAllTextResponse RecognizeAllText(RecognizeAllTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeAllTextWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>统一Api</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeAllTextRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeAllTextResponse
        /// </returns>
        public async Task<RecognizeAllTextResponse> RecognizeAllTextAsync(RecognizeAllTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeAllTextWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>银承汇票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBankAcceptanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBankAcceptanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>银承汇票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBankAcceptanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBankAcceptanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>银承汇票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBankAcceptanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBankAcceptanceResponse
        /// </returns>
        public RecognizeBankAcceptanceResponse RecognizeBankAcceptance(RecognizeBankAcceptanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBankAcceptanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>银承汇票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBankAcceptanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBankAcceptanceResponse
        /// </returns>
        public async Task<RecognizeBankAcceptanceResponse> RecognizeBankAcceptanceAsync(RecognizeBankAcceptanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBankAcceptanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>银行开户许可证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBankAccountLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBankAccountLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>银行开户许可证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBankAccountLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBankAccountLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>银行开户许可证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBankAccountLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBankAccountLicenseResponse
        /// </returns>
        public RecognizeBankAccountLicenseResponse RecognizeBankAccountLicense(RecognizeBankAccountLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBankAccountLicenseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>银行开户许可证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBankAccountLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBankAccountLicenseResponse
        /// </returns>
        public async Task<RecognizeBankAccountLicenseResponse> RecognizeBankAccountLicenseAsync(RecognizeBankAccountLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBankAccountLicenseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>银行卡识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBankCardRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBankCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>银行卡识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBankCardRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBankCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>银行卡识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBankCardRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBankCardResponse
        /// </returns>
        public RecognizeBankCardResponse RecognizeBankCard(RecognizeBankCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBankCardWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>银行卡识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBankCardRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBankCardResponse
        /// </returns>
        public async Task<RecognizeBankCardResponse> RecognizeBankCardAsync(RecognizeBankCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBankCardWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>电商图片文字识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBasicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBasicResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>电商图片文字识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBasicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBasicResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>电商图片文字识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBasicRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBasicResponse
        /// </returns>
        public RecognizeBasicResponse RecognizeBasic(RecognizeBasicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBasicWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>电商图片文字识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBasicRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBasicResponse
        /// </returns>
        public async Task<RecognizeBasicResponse> RecognizeBasicAsync(RecognizeBasicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBasicWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出生证明</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBirthCertificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBirthCertificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出生证明</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBirthCertificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBirthCertificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出生证明</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBirthCertificationRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBirthCertificationResponse
        /// </returns>
        public RecognizeBirthCertificationResponse RecognizeBirthCertification(RecognizeBirthCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBirthCertificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出生证明</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBirthCertificationRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBirthCertificationResponse
        /// </returns>
        public async Task<RecognizeBirthCertificationResponse> RecognizeBirthCertificationAsync(RecognizeBirthCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBirthCertificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客运车船票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBusShipTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBusShipTicketResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客运车船票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBusShipTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBusShipTicketResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客运车船票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBusShipTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBusShipTicketResponse
        /// </returns>
        public RecognizeBusShipTicketResponse RecognizeBusShipTicket(RecognizeBusShipTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBusShipTicketWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客运车船票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBusShipTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBusShipTicketResponse
        /// </returns>
        public async Task<RecognizeBusShipTicketResponse> RecognizeBusShipTicketAsync(RecognizeBusShipTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBusShipTicketWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营业执照识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBusinessLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBusinessLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营业执照识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBusinessLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBusinessLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营业执照识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBusinessLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBusinessLicenseResponse
        /// </returns>
        public RecognizeBusinessLicenseResponse RecognizeBusinessLicense(RecognizeBusinessLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBusinessLicenseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营业执照识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeBusinessLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeBusinessLicenseResponse
        /// </returns>
        public async Task<RecognizeBusinessLicenseResponse> RecognizeBusinessLicenseAsync(RecognizeBusinessLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBusinessLicenseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机动车销售发票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCarInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCarInvoiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机动车销售发票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCarInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCarInvoiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机动车销售发票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCarInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCarInvoiceResponse
        /// </returns>
        public RecognizeCarInvoiceResponse RecognizeCarInvoice(RecognizeCarInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCarInvoiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机动车销售发票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCarInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCarInvoiceResponse
        /// </returns>
        public async Task<RecognizeCarInvoiceResponse> RecognizeCarInvoiceAsync(RecognizeCarInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCarInvoiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>车牌识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCarNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCarNumberResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>车牌识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCarNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCarNumberResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>车牌识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCarNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCarNumberResponse
        /// </returns>
        public RecognizeCarNumberResponse RecognizeCarNumber(RecognizeCarNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCarNumberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>车牌识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCarNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCarNumberResponse
        /// </returns>
        public async Task<RecognizeCarNumberResponse> RecognizeCarNumberAsync(RecognizeCarNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCarNumberWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>车辆vin码识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCarVinCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCarVinCodeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>车辆vin码识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCarVinCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCarVinCodeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>车辆vin码识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCarVinCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCarVinCodeResponse
        /// </returns>
        public RecognizeCarVinCodeResponse RecognizeCarVinCode(RecognizeCarVinCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCarVinCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>车辆vin码识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCarVinCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCarVinCodeResponse
        /// </returns>
        public async Task<RecognizeCarVinCodeResponse> RecognizeCarVinCodeAsync(RecognizeCarVinCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCarVinCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中国护照识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeChinesePassportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeChinesePassportResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中国护照识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeChinesePassportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeChinesePassportResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中国护照识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeChinesePassportRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeChinesePassportResponse
        /// </returns>
        public RecognizeChinesePassportResponse RecognizeChinesePassport(RecognizeChinesePassportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeChinesePassportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中国护照识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeChinesePassportRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeChinesePassportResponse
        /// </returns>
        public async Task<RecognizeChinesePassportResponse> RecognizeChinesePassportAsync(RecognizeChinesePassportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeChinesePassportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用机打发票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCommonPrintedInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCommonPrintedInvoiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用机打发票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCommonPrintedInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCommonPrintedInvoiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用机打发票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCommonPrintedInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCommonPrintedInvoiceResponse
        /// </returns>
        public RecognizeCommonPrintedInvoiceResponse RecognizeCommonPrintedInvoice(RecognizeCommonPrintedInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCommonPrintedInvoiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用机打发票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCommonPrintedInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCommonPrintedInvoiceResponse
        /// </returns>
        public async Task<RecognizeCommonPrintedInvoiceResponse> RecognizeCommonPrintedInvoiceAsync(RecognizeCommonPrintedInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCommonPrintedInvoiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>化妆品生产许可证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCosmeticProduceLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCosmeticProduceLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>化妆品生产许可证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCosmeticProduceLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCosmeticProduceLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>化妆品生产许可证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCosmeticProduceLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCosmeticProduceLicenseResponse
        /// </returns>
        public RecognizeCosmeticProduceLicenseResponse RecognizeCosmeticProduceLicense(RecognizeCosmeticProduceLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCosmeticProduceLicenseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>化妆品生产许可证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCosmeticProduceLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCosmeticProduceLicenseResponse
        /// </returns>
        public async Task<RecognizeCosmeticProduceLicenseResponse> RecognizeCosmeticProduceLicenseAsync(RecognizeCosmeticProduceLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCosmeticProduceLicenseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>核算检测报告识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCovidTestReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCovidTestReportResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>核算检测报告识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCovidTestReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCovidTestReportResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>核算检测报告识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCovidTestReportRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCovidTestReportResponse
        /// </returns>
        public RecognizeCovidTestReportResponse RecognizeCovidTestReport(RecognizeCovidTestReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCovidTestReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>核算检测报告识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCovidTestReportRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCovidTestReportResponse
        /// </returns>
        public async Task<RecognizeCovidTestReportResponse> RecognizeCovidTestReportAsync(RecognizeCovidTestReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCovidTestReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>第二类医疗器械经营备案凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCtwoMedicalDeviceManageLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCtwoMedicalDeviceManageLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>第二类医疗器械经营备案凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCtwoMedicalDeviceManageLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCtwoMedicalDeviceManageLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>第二类医疗器械经营备案凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCtwoMedicalDeviceManageLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCtwoMedicalDeviceManageLicenseResponse
        /// </returns>
        public RecognizeCtwoMedicalDeviceManageLicenseResponse RecognizeCtwoMedicalDeviceManageLicense(RecognizeCtwoMedicalDeviceManageLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCtwoMedicalDeviceManageLicenseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>第二类医疗器械经营备案凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeCtwoMedicalDeviceManageLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeCtwoMedicalDeviceManageLicenseResponse
        /// </returns>
        public async Task<RecognizeCtwoMedicalDeviceManageLicenseResponse> RecognizeCtwoMedicalDeviceManageLicenseAsync(RecognizeCtwoMedicalDeviceManageLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCtwoMedicalDeviceManageLicenseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档结构化识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeDocumentStructureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeDocumentStructureResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档结构化识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeDocumentStructureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeDocumentStructureResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档结构化识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeDocumentStructureRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeDocumentStructureResponse
        /// </returns>
        public RecognizeDocumentStructureResponse RecognizeDocumentStructure(RecognizeDocumentStructureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeDocumentStructureWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档结构化识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeDocumentStructureRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeDocumentStructureResponse
        /// </returns>
        public async Task<RecognizeDocumentStructureResponse> RecognizeDocumentStructureAsync(RecognizeDocumentStructureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeDocumentStructureWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>驾驶证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeDrivingLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeDrivingLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>驾驶证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeDrivingLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeDrivingLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>驾驶证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeDrivingLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeDrivingLicenseResponse
        /// </returns>
        public RecognizeDrivingLicenseResponse RecognizeDrivingLicense(RecognizeDrivingLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeDrivingLicenseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>驾驶证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeDrivingLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeDrivingLicenseResponse
        /// </returns>
        public async Task<RecognizeDrivingLicenseResponse> RecognizeDrivingLicenseAsync(RecognizeDrivingLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeDrivingLicenseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>印刷体数学公式识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduFormulaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduFormulaResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>印刷体数学公式识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduFormulaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduFormulaResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>印刷体数学公式识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduFormulaRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduFormulaResponse
        /// </returns>
        public RecognizeEduFormulaResponse RecognizeEduFormula(RecognizeEduFormulaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEduFormulaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>印刷体数学公式识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduFormulaRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduFormulaResponse
        /// </returns>
        public async Task<RecognizeEduFormulaResponse> RecognizeEduFormulaAsync(RecognizeEduFormulaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEduFormulaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>口算判题</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduOralCalculationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduOralCalculationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>口算判题</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduOralCalculationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduOralCalculationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>口算判题</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduOralCalculationRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduOralCalculationResponse
        /// </returns>
        public RecognizeEduOralCalculationResponse RecognizeEduOralCalculation(RecognizeEduOralCalculationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEduOralCalculationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>口算判题</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduOralCalculationRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduOralCalculationResponse
        /// </returns>
        public async Task<RecognizeEduOralCalculationResponse> RecognizeEduOralCalculationAsync(RecognizeEduOralCalculationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEduOralCalculationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>试卷切题识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduPaperCutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduPaperCutResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>试卷切题识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduPaperCutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduPaperCutResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>试卷切题识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduPaperCutRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduPaperCutResponse
        /// </returns>
        public RecognizeEduPaperCutResponse RecognizeEduPaperCut(RecognizeEduPaperCutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEduPaperCutWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>试卷切题识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduPaperCutRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduPaperCutResponse
        /// </returns>
        public async Task<RecognizeEduPaperCutResponse> RecognizeEduPaperCutAsync(RecognizeEduPaperCutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEduPaperCutWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>整页试卷识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduPaperOcrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduPaperOcrResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>整页试卷识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduPaperOcrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduPaperOcrResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>整页试卷识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduPaperOcrRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduPaperOcrResponse
        /// </returns>
        public RecognizeEduPaperOcrResponse RecognizeEduPaperOcr(RecognizeEduPaperOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEduPaperOcrWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>整页试卷识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduPaperOcrRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduPaperOcrResponse
        /// </returns>
        public async Task<RecognizeEduPaperOcrResponse> RecognizeEduPaperOcrAsync(RecognizeEduPaperOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEduPaperOcrWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>精细版结构化切题</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduPaperStructedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduPaperStructedResponse
        /// </returns>
        public RecognizeEduPaperStructedResponse RecognizeEduPaperStructedWithOptions(RecognizeEduPaperStructedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>精细版结构化切题</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduPaperStructedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduPaperStructedResponse
        /// </returns>
        public async Task<RecognizeEduPaperStructedResponse> RecognizeEduPaperStructedWithOptionsAsync(RecognizeEduPaperStructedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>精细版结构化切题</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduPaperStructedRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduPaperStructedResponse
        /// </returns>
        public RecognizeEduPaperStructedResponse RecognizeEduPaperStructed(RecognizeEduPaperStructedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEduPaperStructedWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>精细版结构化切题</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduPaperStructedRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduPaperStructedResponse
        /// </returns>
        public async Task<RecognizeEduPaperStructedResponse> RecognizeEduPaperStructedAsync(RecognizeEduPaperStructedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEduPaperStructedWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>题目识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduQuestionOcrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduQuestionOcrResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>题目识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduQuestionOcrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduQuestionOcrResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>题目识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduQuestionOcrRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduQuestionOcrResponse
        /// </returns>
        public RecognizeEduQuestionOcrResponse RecognizeEduQuestionOcr(RecognizeEduQuestionOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEduQuestionOcrWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>题目识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEduQuestionOcrRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEduQuestionOcrResponse
        /// </returns>
        public async Task<RecognizeEduQuestionOcrResponse> RecognizeEduQuestionOcrAsync(RecognizeEduQuestionOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEduQuestionOcrWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>英语专项识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEnglishRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEnglishResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>英语专项识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEnglishRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEnglishResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>英语专项识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEnglishRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEnglishResponse
        /// </returns>
        public RecognizeEnglishResponse RecognizeEnglish(RecognizeEnglishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEnglishWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>英语专项识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEnglishRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEnglishResponse
        /// </returns>
        public async Task<RecognizeEnglishResponse> RecognizeEnglishAsync(RecognizeEnglishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEnglishWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>不动产权证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEstateCertificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEstateCertificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>不动产权证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEstateCertificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEstateCertificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>不动产权证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEstateCertificationRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEstateCertificationResponse
        /// </returns>
        public RecognizeEstateCertificationResponse RecognizeEstateCertification(RecognizeEstateCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEstateCertificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>不动产权证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeEstateCertificationRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeEstateCertificationResponse
        /// </returns>
        public async Task<RecognizeEstateCertificationResponse> RecognizeEstateCertificationAsync(RecognizeEstateCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEstateCertificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>来往港澳台通行证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeExitEntryPermitToHKRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeExitEntryPermitToHKResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>来往港澳台通行证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeExitEntryPermitToHKRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeExitEntryPermitToHKResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>来往港澳台通行证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeExitEntryPermitToHKRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeExitEntryPermitToHKResponse
        /// </returns>
        public RecognizeExitEntryPermitToHKResponse RecognizeExitEntryPermitToHK(RecognizeExitEntryPermitToHKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeExitEntryPermitToHKWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>来往港澳台通行证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeExitEntryPermitToHKRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeExitEntryPermitToHKResponse
        /// </returns>
        public async Task<RecognizeExitEntryPermitToHKResponse> RecognizeExitEntryPermitToHKAsync(RecognizeExitEntryPermitToHKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeExitEntryPermitToHKWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>来往大陆(内地)通行证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeExitEntryPermitToMainlandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeExitEntryPermitToMainlandResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>来往大陆(内地)通行证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeExitEntryPermitToMainlandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeExitEntryPermitToMainlandResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>来往大陆(内地)通行证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeExitEntryPermitToMainlandRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeExitEntryPermitToMainlandResponse
        /// </returns>
        public RecognizeExitEntryPermitToMainlandResponse RecognizeExitEntryPermitToMainland(RecognizeExitEntryPermitToMainlandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeExitEntryPermitToMainlandWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>来往大陆(内地)通行证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeExitEntryPermitToMainlandRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeExitEntryPermitToMainlandResponse
        /// </returns>
        public async Task<RecognizeExitEntryPermitToMainlandResponse> RecognizeExitEntryPermitToMainlandAsync(RecognizeExitEntryPermitToMainlandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeExitEntryPermitToMainlandWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>食品经营许可证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeFoodManageLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeFoodManageLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>食品经营许可证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeFoodManageLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeFoodManageLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>食品经营许可证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeFoodManageLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeFoodManageLicenseResponse
        /// </returns>
        public RecognizeFoodManageLicenseResponse RecognizeFoodManageLicense(RecognizeFoodManageLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeFoodManageLicenseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>食品经营许可证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeFoodManageLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeFoodManageLicenseResponse
        /// </returns>
        public async Task<RecognizeFoodManageLicenseResponse> RecognizeFoodManageLicenseAsync(RecognizeFoodManageLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeFoodManageLicenseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>食品生产许可证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeFoodProduceLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeFoodProduceLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>食品生产许可证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeFoodProduceLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeFoodProduceLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>食品生产许可证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeFoodProduceLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeFoodProduceLicenseResponse
        /// </returns>
        public RecognizeFoodProduceLicenseResponse RecognizeFoodProduceLicense(RecognizeFoodProduceLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeFoodProduceLicenseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>食品生产许可证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeFoodProduceLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeFoodProduceLicenseResponse
        /// </returns>
        public async Task<RecognizeFoodProduceLicenseResponse> RecognizeFoodProduceLicenseAsync(RecognizeFoodProduceLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeFoodProduceLicenseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用文字识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeGeneralRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeGeneralResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用文字识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeGeneralRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeGeneralResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用文字识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeGeneralRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeGeneralResponse
        /// </returns>
        public RecognizeGeneralResponse RecognizeGeneral(RecognizeGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeGeneralWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用文字识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeGeneralRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeGeneralResponse
        /// </returns>
        public async Task<RecognizeGeneralResponse> RecognizeGeneralAsync(RecognizeGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeGeneralWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DocMaster</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RecognizeGeneralStructureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeGeneralStructureResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DocMaster</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RecognizeGeneralStructureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeGeneralStructureResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DocMaster</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeGeneralStructureRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeGeneralStructureResponse
        /// </returns>
        public RecognizeGeneralStructureResponse RecognizeGeneralStructure(RecognizeGeneralStructureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeGeneralStructureWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DocMaster</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeGeneralStructureRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeGeneralStructureResponse
        /// </returns>
        public async Task<RecognizeGeneralStructureResponse> RecognizeGeneralStructureAsync(RecognizeGeneralStructureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeGeneralStructureWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>香港身份证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeHKIdcardRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeHKIdcardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>香港身份证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeHKIdcardRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeHKIdcardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>香港身份证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeHKIdcardRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeHKIdcardResponse
        /// </returns>
        public RecognizeHKIdcardResponse RecognizeHKIdcard(RecognizeHKIdcardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeHKIdcardWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>香港身份证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeHKIdcardRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeHKIdcardResponse
        /// </returns>
        public async Task<RecognizeHKIdcardResponse> RecognizeHKIdcardAsync(RecognizeHKIdcardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeHKIdcardWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用手写体识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeHandwritingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeHandwritingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用手写体识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeHandwritingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeHandwritingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用手写体识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeHandwritingRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeHandwritingResponse
        /// </returns>
        public RecognizeHandwritingResponse RecognizeHandwriting(RecognizeHandwritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeHandwritingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用手写体识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeHandwritingRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeHandwritingResponse
        /// </returns>
        public async Task<RecognizeHandwritingResponse> RecognizeHandwritingAsync(RecognizeHandwritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeHandwritingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>防疫健康码识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeHealthCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeHealthCodeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>防疫健康码识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeHealthCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeHealthCodeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>防疫健康码识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeHealthCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeHealthCodeResponse
        /// </returns>
        public RecognizeHealthCodeResponse RecognizeHealthCode(RecognizeHealthCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeHealthCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>防疫健康码识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeHealthCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeHealthCodeResponse
        /// </returns>
        public async Task<RecognizeHealthCodeResponse> RecognizeHealthCodeAsync(RecognizeHealthCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeHealthCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店流水识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeHotelConsumeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeHotelConsumeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店流水识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeHotelConsumeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeHotelConsumeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店流水识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeHotelConsumeRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeHotelConsumeResponse
        /// </returns>
        public RecognizeHotelConsumeResponse RecognizeHotelConsume(RecognizeHotelConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeHotelConsumeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店流水识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeHotelConsumeRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeHotelConsumeResponse
        /// </returns>
        public async Task<RecognizeHotelConsumeResponse> RecognizeHotelConsumeAsync(RecognizeHotelConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeHotelConsumeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>户口本识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeHouseholdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeHouseholdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>户口本识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeHouseholdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeHouseholdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>户口本识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeHouseholdRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeHouseholdResponse
        /// </returns>
        public RecognizeHouseholdResponse RecognizeHousehold(RecognizeHouseholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeHouseholdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>户口本识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeHouseholdRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeHouseholdResponse
        /// </returns>
        public async Task<RecognizeHouseholdResponse> RecognizeHouseholdAsync(RecognizeHouseholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeHouseholdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>身份证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeIdcardRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeIdcardResponse
        /// </returns>
        public RecognizeIdcardResponse RecognizeIdcardWithOptions(RecognizeIdcardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmRec))
            {
                query["Llm_rec"] = request.LlmRec;
            }
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>身份证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeIdcardRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeIdcardResponse
        /// </returns>
        public async Task<RecognizeIdcardResponse> RecognizeIdcardWithOptionsAsync(RecognizeIdcardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmRec))
            {
                query["Llm_rec"] = request.LlmRec;
            }
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>身份证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeIdcardRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeIdcardResponse
        /// </returns>
        public RecognizeIdcardResponse RecognizeIdcard(RecognizeIdcardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeIdcardWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>身份证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeIdcardRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeIdcardResponse
        /// </returns>
        public async Task<RecognizeIdcardResponse> RecognizeIdcardAsync(RecognizeIdcardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeIdcardWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>国际营业执照识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeInternationalBusinessLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeInternationalBusinessLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>国际营业执照识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeInternationalBusinessLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeInternationalBusinessLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>国际营业执照识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeInternationalBusinessLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeInternationalBusinessLicenseResponse
        /// </returns>
        public RecognizeInternationalBusinessLicenseResponse RecognizeInternationalBusinessLicense(RecognizeInternationalBusinessLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeInternationalBusinessLicenseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>国际营业执照识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeInternationalBusinessLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeInternationalBusinessLicenseResponse
        /// </returns>
        public async Task<RecognizeInternationalBusinessLicenseResponse> RecognizeInternationalBusinessLicenseAsync(RecognizeInternationalBusinessLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeInternationalBusinessLicenseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>国际身份证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeInternationalIdcardRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeInternationalIdcardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>国际身份证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeInternationalIdcardRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeInternationalIdcardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>国际身份证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeInternationalIdcardRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeInternationalIdcardResponse
        /// </returns>
        public RecognizeInternationalIdcardResponse RecognizeInternationalIdcard(RecognizeInternationalIdcardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeInternationalIdcardWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>国际身份证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeInternationalIdcardRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeInternationalIdcardResponse
        /// </returns>
        public async Task<RecognizeInternationalIdcardResponse> RecognizeInternationalIdcardAsync(RecognizeInternationalIdcardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeInternationalIdcardWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增值税发票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeInvoiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增值税发票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeInvoiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增值税发票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeInvoiceResponse
        /// </returns>
        public RecognizeInvoiceResponse RecognizeInvoice(RecognizeInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeInvoiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增值税发票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeInvoiceResponse
        /// </returns>
        public async Task<RecognizeInvoiceResponse> RecognizeInvoiceAsync(RecognizeInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeInvoiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>日语识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeJanpaneseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeJanpaneseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>日语识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeJanpaneseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeJanpaneseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>日语识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeJanpaneseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeJanpaneseResponse
        /// </returns>
        public RecognizeJanpaneseResponse RecognizeJanpanese(RecognizeJanpaneseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeJanpaneseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>日语识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeJanpaneseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeJanpaneseResponse
        /// </returns>
        public async Task<RecognizeJanpaneseResponse> RecognizeJanpaneseAsync(RecognizeJanpaneseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeJanpaneseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>韩语识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeKoreanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeKoreanResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>韩语识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeKoreanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeKoreanResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>韩语识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeKoreanRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeKoreanResponse
        /// </returns>
        public RecognizeKoreanResponse RecognizeKorean(RecognizeKoreanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeKoreanWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>韩语识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeKoreanRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeKoreanResponse
        /// </returns>
        public async Task<RecognizeKoreanResponse> RecognizeKoreanAsync(RecognizeKoreanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeKoreanWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉丁语识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeLatinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeLatinResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉丁语识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeLatinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeLatinResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉丁语识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeLatinRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeLatinResponse
        /// </returns>
        public RecognizeLatinResponse RecognizeLatin(RecognizeLatinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeLatinWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉丁语识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeLatinRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeLatinResponse
        /// </returns>
        public async Task<RecognizeLatinResponse> RecognizeLatinAsync(RecognizeLatinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeLatinWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>医疗器械经营许可证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeMedicalDeviceManageLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeMedicalDeviceManageLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>医疗器械经营许可证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeMedicalDeviceManageLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeMedicalDeviceManageLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>医疗器械经营许可证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeMedicalDeviceManageLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeMedicalDeviceManageLicenseResponse
        /// </returns>
        public RecognizeMedicalDeviceManageLicenseResponse RecognizeMedicalDeviceManageLicense(RecognizeMedicalDeviceManageLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeMedicalDeviceManageLicenseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>医疗器械经营许可证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeMedicalDeviceManageLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeMedicalDeviceManageLicenseResponse
        /// </returns>
        public async Task<RecognizeMedicalDeviceManageLicenseResponse> RecognizeMedicalDeviceManageLicenseAsync(RecognizeMedicalDeviceManageLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeMedicalDeviceManageLicenseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>医疗器械生产许可证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeMedicalDeviceProduceLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeMedicalDeviceProduceLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>医疗器械生产许可证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeMedicalDeviceProduceLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeMedicalDeviceProduceLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>医疗器械生产许可证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeMedicalDeviceProduceLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeMedicalDeviceProduceLicenseResponse
        /// </returns>
        public RecognizeMedicalDeviceProduceLicenseResponse RecognizeMedicalDeviceProduceLicense(RecognizeMedicalDeviceProduceLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeMedicalDeviceProduceLicenseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>医疗器械生产许可证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeMedicalDeviceProduceLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeMedicalDeviceProduceLicenseResponse
        /// </returns>
        public async Task<RecognizeMedicalDeviceProduceLicenseResponse> RecognizeMedicalDeviceProduceLicenseAsync(RecognizeMedicalDeviceProduceLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeMedicalDeviceProduceLicenseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>混贴发票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeMixedInvoicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeMixedInvoicesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>混贴发票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeMixedInvoicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeMixedInvoicesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>混贴发票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeMixedInvoicesRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeMixedInvoicesResponse
        /// </returns>
        public RecognizeMixedInvoicesResponse RecognizeMixedInvoices(RecognizeMixedInvoicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeMixedInvoicesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>混贴发票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeMixedInvoicesRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeMixedInvoicesResponse
        /// </returns>
        public async Task<RecognizeMixedInvoicesResponse> RecognizeMixedInvoicesAsync(RecognizeMixedInvoicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeMixedInvoicesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用多语言识别</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RecognizeMultiLanguageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeMultiLanguageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用多语言识别</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RecognizeMultiLanguageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeMultiLanguageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用多语言识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeMultiLanguageRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeMultiLanguageResponse
        /// </returns>
        public RecognizeMultiLanguageResponse RecognizeMultiLanguage(RecognizeMultiLanguageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeMultiLanguageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用多语言识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeMultiLanguageRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeMultiLanguageResponse
        /// </returns>
        public async Task<RecognizeMultiLanguageResponse> RecognizeMultiLanguageAsync(RecognizeMultiLanguageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeMultiLanguageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>非税收入票据识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeNonTaxInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeNonTaxInvoiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>非税收入票据识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeNonTaxInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeNonTaxInvoiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>非税收入票据识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeNonTaxInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeNonTaxInvoiceResponse
        /// </returns>
        public RecognizeNonTaxInvoiceResponse RecognizeNonTaxInvoice(RecognizeNonTaxInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeNonTaxInvoiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>非税收入票据识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeNonTaxInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeNonTaxInvoiceResponse
        /// </returns>
        public async Task<RecognizeNonTaxInvoiceResponse> RecognizeNonTaxInvoiceAsync(RecognizeNonTaxInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeNonTaxInvoiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>护照识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizePassportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizePassportResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>护照识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizePassportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizePassportResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>护照识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizePassportRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizePassportResponse
        /// </returns>
        public RecognizePassportResponse RecognizePassport(RecognizePassportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizePassportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>护照识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizePassportRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizePassportResponse
        /// </returns>
        public async Task<RecognizePassportResponse> RecognizePassportAsync(RecognizePassportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizePassportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>支付详情页识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizePaymentRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizePaymentRecordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>支付详情页识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizePaymentRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizePaymentRecordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>支付详情页识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizePaymentRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizePaymentRecordResponse
        /// </returns>
        public RecognizePaymentRecordResponse RecognizePaymentRecord(RecognizePaymentRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizePaymentRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>支付详情页识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizePaymentRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizePaymentRecordResponse
        /// </returns>
        public async Task<RecognizePaymentRecordResponse> RecognizePaymentRecordAsync(RecognizePaymentRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizePaymentRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>电商订单页识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizePurchaseRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizePurchaseRecordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>电商订单页识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizePurchaseRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizePurchaseRecordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>电商订单页识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizePurchaseRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizePurchaseRecordResponse
        /// </returns>
        public RecognizePurchaseRecordResponse RecognizePurchaseRecord(RecognizePurchaseRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizePurchaseRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>电商订单页识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizePurchaseRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizePurchaseRecordResponse
        /// </returns>
        public async Task<RecognizePurchaseRecordResponse> RecognizePurchaseRecordAsync(RecognizePurchaseRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizePurchaseRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>定额发票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeQuotaInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeQuotaInvoiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>定额发票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeQuotaInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeQuotaInvoiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>定额发票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeQuotaInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeQuotaInvoiceResponse
        /// </returns>
        public RecognizeQuotaInvoiceResponse RecognizeQuotaInvoice(RecognizeQuotaInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeQuotaInvoiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>定额发票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeQuotaInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeQuotaInvoiceResponse
        /// </returns>
        public async Task<RecognizeQuotaInvoiceResponse> RecognizeQuotaInvoiceAsync(RecognizeQuotaInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeQuotaInvoiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>网约车行程单识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeRideHailingItineraryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeRideHailingItineraryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>网约车行程单识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeRideHailingItineraryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeRideHailingItineraryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>网约车行程单识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeRideHailingItineraryRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeRideHailingItineraryResponse
        /// </returns>
        public RecognizeRideHailingItineraryResponse RecognizeRideHailingItinerary(RecognizeRideHailingItineraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeRideHailingItineraryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>网约车行程单识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeRideHailingItineraryRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeRideHailingItineraryResponse
        /// </returns>
        public async Task<RecognizeRideHailingItineraryResponse> RecognizeRideHailingItineraryAsync(RecognizeRideHailingItineraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeRideHailingItineraryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增值税发票卷票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeRollTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeRollTicketResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增值税发票卷票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeRollTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeRollTicketResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增值税发票卷票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeRollTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeRollTicketResponse
        /// </returns>
        public RecognizeRollTicketResponse RecognizeRollTicket(RecognizeRollTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeRollTicketWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增值税发票卷票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeRollTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeRollTicketResponse
        /// </returns>
        public async Task<RecognizeRollTicketResponse> RecognizeRollTicketAsync(RecognizeRollTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeRollTicketWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>俄语识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeRussianRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeRussianResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>俄语识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeRussianRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeRussianResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>俄语识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeRussianRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeRussianResponse
        /// </returns>
        public RecognizeRussianResponse RecognizeRussian(RecognizeRussianRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeRussianWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>俄语识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeRussianRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeRussianResponse
        /// </returns>
        public async Task<RecognizeRussianResponse> RecognizeRussianAsync(RecognizeRussianRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeRussianWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>购物小票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeShoppingReceiptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeShoppingReceiptResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>购物小票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeShoppingReceiptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeShoppingReceiptResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>购物小票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeShoppingReceiptRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeShoppingReceiptResponse
        /// </returns>
        public RecognizeShoppingReceiptResponse RecognizeShoppingReceipt(RecognizeShoppingReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeShoppingReceiptWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>购物小票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeShoppingReceiptRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeShoppingReceiptResponse
        /// </returns>
        public async Task<RecognizeShoppingReceiptResponse> RecognizeShoppingReceiptAsync(RecognizeShoppingReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeShoppingReceiptWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>社会保障卡识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeSocialSecurityCardRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeSocialSecurityCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>社会保障卡识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeSocialSecurityCardRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeSocialSecurityCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>社会保障卡识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeSocialSecurityCardRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeSocialSecurityCardResponse
        /// </returns>
        public RecognizeSocialSecurityCardResponse RecognizeSocialSecurityCard(RecognizeSocialSecurityCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeSocialSecurityCardWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>社会保障卡识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeSocialSecurityCardRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeSocialSecurityCardResponse
        /// </returns>
        public async Task<RecognizeSocialSecurityCardResponse> RecognizeSocialSecurityCardAsync(RecognizeSocialSecurityCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeSocialSecurityCardWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>社保卡识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeSocialSecurityCardVersionIIRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeSocialSecurityCardVersionIIResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>社保卡识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeSocialSecurityCardVersionIIRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeSocialSecurityCardVersionIIResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>社保卡识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeSocialSecurityCardVersionIIRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeSocialSecurityCardVersionIIResponse
        /// </returns>
        public RecognizeSocialSecurityCardVersionIIResponse RecognizeSocialSecurityCardVersionII(RecognizeSocialSecurityCardVersionIIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeSocialSecurityCardVersionIIWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>社保卡识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeSocialSecurityCardVersionIIRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeSocialSecurityCardVersionIIResponse
        /// </returns>
        public async Task<RecognizeSocialSecurityCardVersionIIResponse> RecognizeSocialSecurityCardVersionIIAsync(RecognizeSocialSecurityCardVersionIIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeSocialSecurityCardVersionIIWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>表格识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTableOcrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTableOcrResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>表格识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTableOcrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTableOcrResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>表格识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTableOcrRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTableOcrResponse
        /// </returns>
        public RecognizeTableOcrResponse RecognizeTableOcr(RecognizeTableOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTableOcrWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>表格识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTableOcrRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTableOcrResponse
        /// </returns>
        public async Task<RecognizeTableOcrResponse> RecognizeTableOcrAsync(RecognizeTableOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTableOcrWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>税收完税证明识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTaxClearanceCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTaxClearanceCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>税收完税证明识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTaxClearanceCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTaxClearanceCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>税收完税证明识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTaxClearanceCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTaxClearanceCertificateResponse
        /// </returns>
        public RecognizeTaxClearanceCertificateResponse RecognizeTaxClearanceCertificate(RecognizeTaxClearanceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTaxClearanceCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>税收完税证明识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTaxClearanceCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTaxClearanceCertificateResponse
        /// </returns>
        public async Task<RecognizeTaxClearanceCertificateResponse> RecognizeTaxClearanceCertificateAsync(RecognizeTaxClearanceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTaxClearanceCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出租车发票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTaxiInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTaxiInvoiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出租车发票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTaxiInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTaxiInvoiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出租车发票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTaxiInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTaxiInvoiceResponse
        /// </returns>
        public RecognizeTaxiInvoiceResponse RecognizeTaxiInvoice(RecognizeTaxiInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTaxiInvoiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出租车发票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTaxiInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTaxiInvoiceResponse
        /// </returns>
        public async Task<RecognizeTaxiInvoiceResponse> RecognizeTaxiInvoiceAsync(RecognizeTaxiInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTaxiInvoiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>泰语识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeThaiRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeThaiResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>泰语识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeThaiRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeThaiResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>泰语识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeThaiRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeThaiResponse
        /// </returns>
        public RecognizeThaiResponse RecognizeThai(RecognizeThaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeThaiWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>泰语识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeThaiRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeThaiResponse
        /// </returns>
        public async Task<RecognizeThaiResponse> RecognizeThaiAsync(RecognizeThaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeThaiWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>过路过桥费发票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTollInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTollInvoiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>过路过桥费发票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTollInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTollInvoiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>过路过桥费发票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTollInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTollInvoiceResponse
        /// </returns>
        public RecognizeTollInvoiceResponse RecognizeTollInvoice(RecognizeTollInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTollInvoiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>过路过桥费发票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTollInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTollInvoiceResponse
        /// </returns>
        public async Task<RecognizeTollInvoiceResponse> RecognizeTollInvoiceAsync(RecognizeTollInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTollInvoiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商标注册证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTradeMarkCertificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTradeMarkCertificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商标注册证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTradeMarkCertificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTradeMarkCertificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商标注册证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTradeMarkCertificationRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTradeMarkCertificationResponse
        /// </returns>
        public RecognizeTradeMarkCertificationResponse RecognizeTradeMarkCertification(RecognizeTradeMarkCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTradeMarkCertificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商标注册证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTradeMarkCertificationRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTradeMarkCertificationResponse
        /// </returns>
        public async Task<RecognizeTradeMarkCertificationResponse> RecognizeTradeMarkCertificationAsync(RecognizeTradeMarkCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTradeMarkCertificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>火车票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTrainInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTrainInvoiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>火车票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTrainInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTrainInvoiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>火车票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTrainInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTrainInvoiceResponse
        /// </returns>
        public RecognizeTrainInvoiceResponse RecognizeTrainInvoice(RecognizeTrainInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTrainInvoiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>火车票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeTrainInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeTrainInvoiceResponse
        /// </returns>
        public async Task<RecognizeTrainInvoiceResponse> RecognizeTrainInvoiceAsync(RecognizeTrainInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTrainInvoiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>二手车统一销售发票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeUsedCarInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeUsedCarInvoiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>二手车统一销售发票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeUsedCarInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeUsedCarInvoiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>二手车统一销售发票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeUsedCarInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeUsedCarInvoiceResponse
        /// </returns>
        public RecognizeUsedCarInvoiceResponse RecognizeUsedCarInvoice(RecognizeUsedCarInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeUsedCarInvoiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>二手车统一销售发票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeUsedCarInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeUsedCarInvoiceResponse
        /// </returns>
        public async Task<RecognizeUsedCarInvoiceResponse> RecognizeUsedCarInvoiceAsync(RecognizeUsedCarInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeUsedCarInvoiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>车辆合格证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeVehicleCertificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeVehicleCertificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>车辆合格证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeVehicleCertificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeVehicleCertificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>车辆合格证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeVehicleCertificationRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeVehicleCertificationResponse
        /// </returns>
        public RecognizeVehicleCertificationResponse RecognizeVehicleCertification(RecognizeVehicleCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeVehicleCertificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>车辆合格证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeVehicleCertificationRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeVehicleCertificationResponse
        /// </returns>
        public async Task<RecognizeVehicleCertificationResponse> RecognizeVehicleCertificationAsync(RecognizeVehicleCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeVehicleCertificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>行驶证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeVehicleLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeVehicleLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>行驶证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeVehicleLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeVehicleLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>行驶证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeVehicleLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeVehicleLicenseResponse
        /// </returns>
        public RecognizeVehicleLicenseResponse RecognizeVehicleLicense(RecognizeVehicleLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeVehicleLicenseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>行驶证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeVehicleLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeVehicleLicenseResponse
        /// </returns>
        public async Task<RecognizeVehicleLicenseResponse> RecognizeVehicleLicenseAsync(RecognizeVehicleLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeVehicleLicenseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机动车注册登记证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeVehicleRegistrationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeVehicleRegistrationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机动车注册登记证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeVehicleRegistrationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeVehicleRegistrationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机动车注册登记证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeVehicleRegistrationRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeVehicleRegistrationResponse
        /// </returns>
        public RecognizeVehicleRegistrationResponse RecognizeVehicleRegistration(RecognizeVehicleRegistrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeVehicleRegistrationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机动车注册登记证识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeVehicleRegistrationRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeVehicleRegistrationResponse
        /// </returns>
        public async Task<RecognizeVehicleRegistrationResponse> RecognizeVehicleRegistrationAsync(RecognizeVehicleRegistrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeVehicleRegistrationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>电子面单识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeWaybillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeWaybillResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>电子面单识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeWaybillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeWaybillResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>电子面单识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeWaybillRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeWaybillResponse
        /// </returns>
        public RecognizeWaybillResponse RecognizeWaybill(RecognizeWaybillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeWaybillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>电子面单识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeWaybillRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeWaybillResponse
        /// </returns>
        public async Task<RecognizeWaybillResponse> RecognizeWaybillAsync(RecognizeWaybillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeWaybillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营业执照核验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyBusinessLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyBusinessLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营业执照核验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyBusinessLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyBusinessLicenseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营业执照核验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyBusinessLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyBusinessLicenseResponse
        /// </returns>
        public VerifyBusinessLicenseResponse VerifyBusinessLicense(VerifyBusinessLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyBusinessLicenseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营业执照核验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyBusinessLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyBusinessLicenseResponse
        /// </returns>
        public async Task<VerifyBusinessLicenseResponse> VerifyBusinessLicenseAsync(VerifyBusinessLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyBusinessLicenseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增值税发票核验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyVATInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyVATInvoiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增值税发票核验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyVATInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyVATInvoiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增值税发票核验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyVATInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyVATInvoiceResponse
        /// </returns>
        public VerifyVATInvoiceResponse VerifyVATInvoice(VerifyVATInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyVATInvoiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增值税发票核验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyVATInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyVATInvoiceResponse
        /// </returns>
        public async Task<VerifyVATInvoiceResponse> VerifyVATInvoiceAsync(VerifyVATInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyVATInvoiceWithOptionsAsync(request, runtime);
        }

    }
}
