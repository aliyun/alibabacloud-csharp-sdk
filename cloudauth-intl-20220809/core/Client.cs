// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cloudauth_intl20220809.Models;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloudauth-intl", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CardOcr is deprecated, please use Cloudauth-intl::2022-08-09::DocOcr instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>证件OCR识别纯服务端接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CardOcrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CardOcrResponse
        /// </returns>
        [Obsolete("OpenAPI CardOcr is deprecated, please use Cloudauth-intl::2022-08-09::DocOcr instead.")]
        // Deprecated
        public CardOcrResponse CardOcrWithOptions(CardOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdFaceQuality))
            {
                query["IdFaceQuality"] = request.IdFaceQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureUrl))
            {
                query["IdOcrPictureUrl"] = request.IdOcrPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ocr))
            {
                query["Ocr"] = request.Ocr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spoof))
            {
                query["Spoof"] = request.Spoof;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureBase64))
            {
                body["IdOcrPictureBase64"] = request.IdOcrPictureBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CardOcr",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CardOcrResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CardOcr is deprecated, please use Cloudauth-intl::2022-08-09::DocOcr instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>证件OCR识别纯服务端接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CardOcrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CardOcrResponse
        /// </returns>
        [Obsolete("OpenAPI CardOcr is deprecated, please use Cloudauth-intl::2022-08-09::DocOcr instead.")]
        // Deprecated
        public async Task<CardOcrResponse> CardOcrWithOptionsAsync(CardOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdFaceQuality))
            {
                query["IdFaceQuality"] = request.IdFaceQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureUrl))
            {
                query["IdOcrPictureUrl"] = request.IdOcrPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ocr))
            {
                query["Ocr"] = request.Ocr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spoof))
            {
                query["Spoof"] = request.Spoof;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureBase64))
            {
                body["IdOcrPictureBase64"] = request.IdOcrPictureBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CardOcr",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CardOcrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CardOcr is deprecated, please use Cloudauth-intl::2022-08-09::DocOcr instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>证件OCR识别纯服务端接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CardOcrRequest
        /// </param>
        /// 
        /// <returns>
        /// CardOcrResponse
        /// </returns>
        [Obsolete("OpenAPI CardOcr is deprecated, please use Cloudauth-intl::2022-08-09::DocOcr instead.")]
        // Deprecated
        public CardOcrResponse CardOcr(CardOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CardOcrWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CardOcr is deprecated, please use Cloudauth-intl::2022-08-09::DocOcr instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>证件OCR识别纯服务端接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CardOcrRequest
        /// </param>
        /// 
        /// <returns>
        /// CardOcrResponse
        /// </returns>
        [Obsolete("OpenAPI CardOcr is deprecated, please use Cloudauth-intl::2022-08-09::DocOcr instead.")]
        // Deprecated
        public async Task<CardOcrResponse> CardOcrAsync(CardOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CardOcrWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckResultResponse
        /// </returns>
        public CheckResultResponse CheckResultWithOptions(CheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraImageControlList))
            {
                query["ExtraImageControlList"] = request.ExtraImageControlList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsReturnImage))
            {
                query["IsReturnImage"] = request.IsReturnImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnFiveCategorySpoofResult))
            {
                query["ReturnFiveCategorySpoofResult"] = request.ReturnFiveCategorySpoofResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionId))
            {
                query["TransactionId"] = request.TransactionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckResult",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckResultResponse
        /// </returns>
        public async Task<CheckResultResponse> CheckResultWithOptionsAsync(CheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraImageControlList))
            {
                query["ExtraImageControlList"] = request.ExtraImageControlList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsReturnImage))
            {
                query["IsReturnImage"] = request.IsReturnImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnFiveCategorySpoofResult))
            {
                query["ReturnFiveCategorySpoofResult"] = request.ReturnFiveCategorySpoofResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionId))
            {
                query["TransactionId"] = request.TransactionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckResult",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckResultRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckResultResponse
        /// </returns>
        public CheckResultResponse CheckResult(CheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckResultRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckResultResponse
        /// </returns>
        public async Task<CheckResultResponse> CheckResultAsync(CheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户认证记录结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVerifyResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVerifyResultResponse
        /// </returns>
        public DeleteVerifyResultResponse DeleteVerifyResultWithOptions(DeleteVerifyResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteAfterQuery))
            {
                query["DeleteAfterQuery"] = request.DeleteAfterQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteType))
            {
                query["DeleteType"] = request.DeleteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionId))
            {
                query["TransactionId"] = request.TransactionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVerifyResult",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVerifyResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户认证记录结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVerifyResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVerifyResultResponse
        /// </returns>
        public async Task<DeleteVerifyResultResponse> DeleteVerifyResultWithOptionsAsync(DeleteVerifyResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteAfterQuery))
            {
                query["DeleteAfterQuery"] = request.DeleteAfterQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteType))
            {
                query["DeleteType"] = request.DeleteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionId))
            {
                query["TransactionId"] = request.TransactionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVerifyResult",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVerifyResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户认证记录结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVerifyResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVerifyResultResponse
        /// </returns>
        public DeleteVerifyResultResponse DeleteVerifyResult(DeleteVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVerifyResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户认证记录结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVerifyResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVerifyResultResponse
        /// </returns>
        public async Task<DeleteVerifyResultResponse> DeleteVerifyResultAsync(DeleteVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVerifyResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>卡证ocr纯服务端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocOcrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocOcrResponse
        /// </returns>
        public DocOcrResponse DocOcrWithOptions(DocOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardSide))
            {
                query["CardSide"] = request.CardSide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdFaceQuality))
            {
                query["IdFaceQuality"] = request.IdFaceQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureUrl))
            {
                query["IdOcrPictureUrl"] = request.IdOcrPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdThreshold))
            {
                query["IdThreshold"] = request.IdThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ocr))
            {
                query["Ocr"] = request.Ocr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spoof))
            {
                query["Spoof"] = request.Spoof;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureBase64))
            {
                body["IdOcrPictureBase64"] = request.IdOcrPictureBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocOcr",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocOcrResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>卡证ocr纯服务端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocOcrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocOcrResponse
        /// </returns>
        public async Task<DocOcrResponse> DocOcrWithOptionsAsync(DocOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardSide))
            {
                query["CardSide"] = request.CardSide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdFaceQuality))
            {
                query["IdFaceQuality"] = request.IdFaceQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureUrl))
            {
                query["IdOcrPictureUrl"] = request.IdOcrPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdThreshold))
            {
                query["IdThreshold"] = request.IdThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ocr))
            {
                query["Ocr"] = request.Ocr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spoof))
            {
                query["Spoof"] = request.Spoof;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureBase64))
            {
                body["IdOcrPictureBase64"] = request.IdOcrPictureBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocOcr",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocOcrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>卡证ocr纯服务端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocOcrRequest
        /// </param>
        /// 
        /// <returns>
        /// DocOcrResponse
        /// </returns>
        public DocOcrResponse DocOcr(DocOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DocOcrWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>卡证ocr纯服务端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocOcrRequest
        /// </param>
        /// 
        /// <returns>
        /// DocOcrResponse
        /// </returns>
        public async Task<DocOcrResponse> DocOcrAsync(DocOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DocOcrWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ekyc纯服务端接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EkycVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EkycVerifyResponse
        /// </returns>
        public EkycVerifyResponse EkycVerifyWithOptions(EkycVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authorize))
            {
                query["Authorize"] = request.Authorize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                query["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocName))
            {
                query["DocName"] = request.DocName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocNo))
            {
                query["DocNo"] = request.DocNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureUrl))
            {
                query["FacePictureUrl"] = request.FacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureUrl))
            {
                query["IdOcrPictureUrl"] = request.IdOcrPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdThreshold))
            {
                query["IdThreshold"] = request.IdThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureBase64))
            {
                body["FacePictureBase64"] = request.FacePictureBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureBase64))
            {
                body["IdOcrPictureBase64"] = request.IdOcrPictureBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EkycVerify",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EkycVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ekyc纯服务端接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EkycVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EkycVerifyResponse
        /// </returns>
        public async Task<EkycVerifyResponse> EkycVerifyWithOptionsAsync(EkycVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authorize))
            {
                query["Authorize"] = request.Authorize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                query["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocName))
            {
                query["DocName"] = request.DocName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocNo))
            {
                query["DocNo"] = request.DocNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureUrl))
            {
                query["FacePictureUrl"] = request.FacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureUrl))
            {
                query["IdOcrPictureUrl"] = request.IdOcrPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdThreshold))
            {
                query["IdThreshold"] = request.IdThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureBase64))
            {
                body["FacePictureBase64"] = request.FacePictureBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureBase64))
            {
                body["IdOcrPictureBase64"] = request.IdOcrPictureBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EkycVerify",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EkycVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ekyc纯服务端接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EkycVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// EkycVerifyResponse
        /// </returns>
        public EkycVerifyResponse EkycVerify(EkycVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EkycVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ekyc纯服务端接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EkycVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// EkycVerifyResponse
        /// </returns>
        public async Task<EkycVerifyResponse> EkycVerifyAsync(EkycVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EkycVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人脸比对</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceCompareRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FaceCompareResponse
        /// </returns>
        public FaceCompareResponse FaceCompareWithOptions(FaceCompareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFacePictureUrl))
            {
                query["SourceFacePictureUrl"] = request.SourceFacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFacePictureUrl))
            {
                query["TargetFacePictureUrl"] = request.TargetFacePictureUrl;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFacePicture))
            {
                body["SourceFacePicture"] = request.SourceFacePicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFacePicture))
            {
                body["TargetFacePicture"] = request.TargetFacePicture;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FaceCompare",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FaceCompareResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人脸比对</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceCompareRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FaceCompareResponse
        /// </returns>
        public async Task<FaceCompareResponse> FaceCompareWithOptionsAsync(FaceCompareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFacePictureUrl))
            {
                query["SourceFacePictureUrl"] = request.SourceFacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFacePictureUrl))
            {
                query["TargetFacePictureUrl"] = request.TargetFacePictureUrl;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFacePicture))
            {
                body["SourceFacePicture"] = request.SourceFacePicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFacePicture))
            {
                body["TargetFacePicture"] = request.TargetFacePicture;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FaceCompare",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FaceCompareResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人脸比对</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceCompareRequest
        /// </param>
        /// 
        /// <returns>
        /// FaceCompareResponse
        /// </returns>
        public FaceCompareResponse FaceCompare(FaceCompareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FaceCompareWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人脸比对</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceCompareRequest
        /// </param>
        /// 
        /// <returns>
        /// FaceCompareResponse
        /// </returns>
        public async Task<FaceCompareResponse> FaceCompareAsync(FaceCompareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FaceCompareWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>国际人脸保镖纯服务端接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceGuardRiskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FaceGuardRiskResponse
        /// </returns>
        public FaceGuardRiskResponse FaceGuardRiskWithOptions(FaceGuardRiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceToken))
            {
                query["DeviceToken"] = request.DeviceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FaceGuardRisk",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FaceGuardRiskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>国际人脸保镖纯服务端接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceGuardRiskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FaceGuardRiskResponse
        /// </returns>
        public async Task<FaceGuardRiskResponse> FaceGuardRiskWithOptionsAsync(FaceGuardRiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceToken))
            {
                query["DeviceToken"] = request.DeviceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FaceGuardRisk",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FaceGuardRiskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>国际人脸保镖纯服务端接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceGuardRiskRequest
        /// </param>
        /// 
        /// <returns>
        /// FaceGuardRiskResponse
        /// </returns>
        public FaceGuardRiskResponse FaceGuardRisk(FaceGuardRiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FaceGuardRiskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>国际人脸保镖纯服务端接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceGuardRiskRequest
        /// </param>
        /// 
        /// <returns>
        /// FaceGuardRiskResponse
        /// </returns>
        public async Task<FaceGuardRiskResponse> FaceGuardRiskAsync(FaceGuardRiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FaceGuardRiskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>静默活体API 纯服务端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceLivenessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FaceLivenessResponse
        /// </returns>
        public FaceLivenessResponse FaceLivenessWithOptions(FaceLivenessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                query["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureUrl))
            {
                query["FacePictureUrl"] = request.FacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceQuality))
            {
                query["FaceQuality"] = request.FaceQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Occlusion))
            {
                query["Occlusion"] = request.Occlusion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureBase64))
            {
                body["FacePictureBase64"] = request.FacePictureBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FaceLiveness",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FaceLivenessResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>静默活体API 纯服务端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceLivenessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FaceLivenessResponse
        /// </returns>
        public async Task<FaceLivenessResponse> FaceLivenessWithOptionsAsync(FaceLivenessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                query["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureUrl))
            {
                query["FacePictureUrl"] = request.FacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceQuality))
            {
                query["FaceQuality"] = request.FaceQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Occlusion))
            {
                query["Occlusion"] = request.Occlusion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureBase64))
            {
                body["FacePictureBase64"] = request.FacePictureBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FaceLiveness",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FaceLivenessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>静默活体API 纯服务端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceLivenessRequest
        /// </param>
        /// 
        /// <returns>
        /// FaceLivenessResponse
        /// </returns>
        public FaceLivenessResponse FaceLiveness(FaceLivenessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FaceLivenessWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>静默活体API 纯服务端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceLivenessRequest
        /// </param>
        /// 
        /// <returns>
        /// FaceLivenessResponse
        /// </returns>
        public async Task<FaceLivenessResponse> FaceLivenessAsync(FaceLivenessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FaceLivenessWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>防伪回调接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FraudResultCallBackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FraudResultCallBackResponse
        /// </returns>
        public FraudResultCallBackResponse FraudResultCallBackWithOptions(FraudResultCallBackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                query["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtParams))
            {
                query["ExtParams"] = request.ExtParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultCode))
            {
                query["ResultCode"] = request.ResultCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyDeployEnv))
            {
                query["VerifyDeployEnv"] = request.VerifyDeployEnv;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FraudResultCallBack",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FraudResultCallBackResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>防伪回调接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FraudResultCallBackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FraudResultCallBackResponse
        /// </returns>
        public async Task<FraudResultCallBackResponse> FraudResultCallBackWithOptionsAsync(FraudResultCallBackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                query["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtParams))
            {
                query["ExtParams"] = request.ExtParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultCode))
            {
                query["ResultCode"] = request.ResultCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyDeployEnv))
            {
                query["VerifyDeployEnv"] = request.VerifyDeployEnv;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FraudResultCallBack",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FraudResultCallBackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>防伪回调接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FraudResultCallBackRequest
        /// </param>
        /// 
        /// <returns>
        /// FraudResultCallBackResponse
        /// </returns>
        public FraudResultCallBackResponse FraudResultCallBack(FraudResultCallBackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FraudResultCallBackWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>防伪回调接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FraudResultCallBackRequest
        /// </param>
        /// 
        /// <returns>
        /// FraudResultCallBackResponse
        /// </returns>
        public async Task<FraudResultCallBackResponse> FraudResultCallBackAsync(FraudResultCallBackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FraudResultCallBackWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>身份二要素国际版接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Id2MetaVerifyIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaVerifyIntlResponse
        /// </returns>
        public Id2MetaVerifyIntlResponse Id2MetaVerifyIntlWithOptions(Id2MetaVerifyIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Id2MetaVerifyIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Id2MetaVerifyIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>身份二要素国际版接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Id2MetaVerifyIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaVerifyIntlResponse
        /// </returns>
        public async Task<Id2MetaVerifyIntlResponse> Id2MetaVerifyIntlWithOptionsAsync(Id2MetaVerifyIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Id2MetaVerifyIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Id2MetaVerifyIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>身份二要素国际版接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Id2MetaVerifyIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaVerifyIntlResponse
        /// </returns>
        public Id2MetaVerifyIntlResponse Id2MetaVerifyIntl(Id2MetaVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Id2MetaVerifyIntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>身份二要素国际版接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Id2MetaVerifyIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaVerifyIntlResponse
        /// </returns>
        public async Task<Id2MetaVerifyIntlResponse> Id2MetaVerifyIntlAsync(Id2MetaVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Id2MetaVerifyIntlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>认证初始化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitializeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitializeResponse
        /// </returns>
        public InitializeResponse InitializeWithOptions(InitializeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppQualityCheck))
            {
                query["AppQualityCheck"] = request.AppQualityCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authorize))
            {
                query["Authorize"] = request.Authorize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackToken))
            {
                query["CallbackToken"] = request.CallbackToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                query["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocScanMode))
            {
                query["DocScanMode"] = request.DocScanMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocVideo))
            {
                query["DocVideo"] = request.DocVideo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperienceCode))
            {
                query["ExperienceCode"] = request.ExperienceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureUrl))
            {
                query["FacePictureUrl"] = request.FacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdFaceQuality))
            {
                query["IdFaceQuality"] = request.IdFaceQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdSpoof))
            {
                query["IdSpoof"] = request.IdSpoof;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdThreshold))
            {
                query["IdThreshold"] = request.IdThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageConfig))
            {
                query["LanguageConfig"] = request.LanguageConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaInfo))
            {
                query["MetaInfo"] = request.MetaInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ocr))
            {
                query["Ocr"] = request.Ocr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcedurePriority))
            {
                query["ProcedurePriority"] = request.ProcedurePriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductFlow))
            {
                query["ProductFlow"] = request.ProductFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnUrl))
            {
                query["ReturnUrl"] = request.ReturnUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityLevel))
            {
                query["SecurityLevel"] = request.SecurityLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowAlbumIcon))
            {
                query["ShowAlbumIcon"] = request.ShowAlbumIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowGuidePage))
            {
                query["ShowGuidePage"] = request.ShowGuidePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowOcrResult))
            {
                query["ShowOcrResult"] = request.ShowOcrResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleConfig))
            {
                query["StyleConfig"] = request.StyleConfig;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureBase64))
            {
                body["FacePictureBase64"] = request.FacePictureBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Initialize",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitializeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>认证初始化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitializeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitializeResponse
        /// </returns>
        public async Task<InitializeResponse> InitializeWithOptionsAsync(InitializeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppQualityCheck))
            {
                query["AppQualityCheck"] = request.AppQualityCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authorize))
            {
                query["Authorize"] = request.Authorize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackToken))
            {
                query["CallbackToken"] = request.CallbackToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                query["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocScanMode))
            {
                query["DocScanMode"] = request.DocScanMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocVideo))
            {
                query["DocVideo"] = request.DocVideo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperienceCode))
            {
                query["ExperienceCode"] = request.ExperienceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureUrl))
            {
                query["FacePictureUrl"] = request.FacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdFaceQuality))
            {
                query["IdFaceQuality"] = request.IdFaceQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdSpoof))
            {
                query["IdSpoof"] = request.IdSpoof;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdThreshold))
            {
                query["IdThreshold"] = request.IdThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageConfig))
            {
                query["LanguageConfig"] = request.LanguageConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaInfo))
            {
                query["MetaInfo"] = request.MetaInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ocr))
            {
                query["Ocr"] = request.Ocr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcedurePriority))
            {
                query["ProcedurePriority"] = request.ProcedurePriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductFlow))
            {
                query["ProductFlow"] = request.ProductFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnUrl))
            {
                query["ReturnUrl"] = request.ReturnUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityLevel))
            {
                query["SecurityLevel"] = request.SecurityLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowAlbumIcon))
            {
                query["ShowAlbumIcon"] = request.ShowAlbumIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowGuidePage))
            {
                query["ShowGuidePage"] = request.ShowGuidePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowOcrResult))
            {
                query["ShowOcrResult"] = request.ShowOcrResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleConfig))
            {
                query["StyleConfig"] = request.StyleConfig;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureBase64))
            {
                body["FacePictureBase64"] = request.FacePictureBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Initialize",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitializeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>认证初始化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitializeRequest
        /// </param>
        /// 
        /// <returns>
        /// InitializeResponse
        /// </returns>
        public InitializeResponse Initialize(InitializeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitializeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>认证初始化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitializeRequest
        /// </param>
        /// 
        /// <returns>
        /// InitializeResponse
        /// </returns>
        public async Task<InitializeResponse> InitializeAsync(InitializeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitializeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>手机号三要素国际版接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Mobile3MetaVerifyIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaVerifyIntlResponse
        /// </returns>
        public Mobile3MetaVerifyIntlResponse Mobile3MetaVerifyIntlWithOptions(Mobile3MetaVerifyIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Mobile3MetaVerifyIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Mobile3MetaVerifyIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>手机号三要素国际版接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Mobile3MetaVerifyIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaVerifyIntlResponse
        /// </returns>
        public async Task<Mobile3MetaVerifyIntlResponse> Mobile3MetaVerifyIntlWithOptionsAsync(Mobile3MetaVerifyIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Mobile3MetaVerifyIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Mobile3MetaVerifyIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>手机号三要素国际版接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Mobile3MetaVerifyIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaVerifyIntlResponse
        /// </returns>
        public Mobile3MetaVerifyIntlResponse Mobile3MetaVerifyIntl(Mobile3MetaVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Mobile3MetaVerifyIntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>手机号三要素国际版接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Mobile3MetaVerifyIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaVerifyIntlResponse
        /// </returns>
        public async Task<Mobile3MetaVerifyIntlResponse> Mobile3MetaVerifyIntlAsync(Mobile3MetaVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Mobile3MetaVerifyIntlWithOptionsAsync(request, runtime);
        }

    }
}
