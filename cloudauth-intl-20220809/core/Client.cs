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

        /**
          * @deprecated : CardOcr is deprecated, please use Cloudauth-intl::2022-08-09::DocOcr instead.
          *
          * @param request CardOcrRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CardOcrResponse
         */
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

        /**
          * @deprecated : CardOcr is deprecated, please use Cloudauth-intl::2022-08-09::DocOcr instead.
          *
          * @param request CardOcrRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CardOcrResponse
         */
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

        /**
          * @deprecated : CardOcr is deprecated, please use Cloudauth-intl::2022-08-09::DocOcr instead.
          *
          * @param request CardOcrRequest
          * @return CardOcrResponse
         */
        // Deprecated
        public CardOcrResponse CardOcr(CardOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CardOcrWithOptions(request, runtime);
        }

        /**
          * @deprecated : CardOcr is deprecated, please use Cloudauth-intl::2022-08-09::DocOcr instead.
          *
          * @param request CardOcrRequest
          * @return CardOcrResponse
         */
        // Deprecated
        public async Task<CardOcrResponse> CardOcrAsync(CardOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CardOcrWithOptionsAsync(request, runtime);
        }

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

        public CheckResultResponse CheckResult(CheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckResultWithOptions(request, runtime);
        }

        public async Task<CheckResultResponse> CheckResultAsync(CheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckResultWithOptionsAsync(request, runtime);
        }

        public DeletePictureResponse DeletePictureWithOptions(DeletePictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletePicAfterQuery))
            {
                query["DeletePicAfterQuery"] = request.DeletePicAfterQuery;
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
                Action = "DeletePicture",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePictureResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeletePictureResponse> DeletePictureWithOptionsAsync(DeletePictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletePicAfterQuery))
            {
                query["DeletePicAfterQuery"] = request.DeletePicAfterQuery;
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
                Action = "DeletePicture",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePictureResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeletePictureResponse DeletePicture(DeletePictureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePictureWithOptions(request, runtime);
        }

        public async Task<DeletePictureResponse> DeletePictureAsync(DeletePictureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePictureWithOptionsAsync(request, runtime);
        }

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

        public DeleteVerifyResultResponse DeleteVerifyResult(DeleteVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVerifyResultWithOptions(request, runtime);
        }

        public async Task<DeleteVerifyResultResponse> DeleteVerifyResultAsync(DeleteVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVerifyResultWithOptionsAsync(request, runtime);
        }

        public DescribeAddressLabelsResponse DescribeAddressLabelsWithOptions(DescribeAddressLabelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Coin))
            {
                query["Coin"] = request.Coin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAddressLabels",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAddressLabelsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAddressLabelsResponse> DescribeAddressLabelsWithOptionsAsync(DescribeAddressLabelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Coin))
            {
                query["Coin"] = request.Coin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAddressLabels",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAddressLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAddressLabelsResponse DescribeAddressLabels(DescribeAddressLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAddressLabelsWithOptions(request, runtime);
        }

        public async Task<DescribeAddressLabelsResponse> DescribeAddressLabelsAsync(DescribeAddressLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAddressLabelsWithOptionsAsync(request, runtime);
        }

        public DescribeAddressOverviewResponse DescribeAddressOverviewWithOptions(DescribeAddressOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Coin))
            {
                query["Coin"] = request.Coin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAddressOverview",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAddressOverviewResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAddressOverviewResponse> DescribeAddressOverviewWithOptionsAsync(DescribeAddressOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Coin))
            {
                query["Coin"] = request.Coin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAddressOverview",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAddressOverviewResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAddressOverviewResponse DescribeAddressOverview(DescribeAddressOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAddressOverviewWithOptions(request, runtime);
        }

        public async Task<DescribeAddressOverviewResponse> DescribeAddressOverviewAsync(DescribeAddressOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAddressOverviewWithOptionsAsync(request, runtime);
        }

        public DescribeMaliciousAddressResponse DescribeMaliciousAddressWithOptions(DescribeMaliciousAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Coin))
            {
                query["Coin"] = request.Coin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMaliciousAddress",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMaliciousAddressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMaliciousAddressResponse> DescribeMaliciousAddressWithOptionsAsync(DescribeMaliciousAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Coin))
            {
                query["Coin"] = request.Coin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMaliciousAddress",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMaliciousAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMaliciousAddressResponse DescribeMaliciousAddress(DescribeMaliciousAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMaliciousAddressWithOptions(request, runtime);
        }

        public async Task<DescribeMaliciousAddressResponse> DescribeMaliciousAddressAsync(DescribeMaliciousAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMaliciousAddressWithOptionsAsync(request, runtime);
        }

        public DescribeRiskScoreResponse DescribeRiskScoreWithOptions(DescribeRiskScoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Coin))
            {
                query["Coin"] = request.Coin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRiskScore",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRiskScoreResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRiskScoreResponse> DescribeRiskScoreWithOptionsAsync(DescribeRiskScoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Coin))
            {
                query["Coin"] = request.Coin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRiskScore",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRiskScoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRiskScoreResponse DescribeRiskScore(DescribeRiskScoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRiskScoreWithOptions(request, runtime);
        }

        public async Task<DescribeRiskScoreResponse> DescribeRiskScoreAsync(DescribeRiskScoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRiskScoreWithOptionsAsync(request, runtime);
        }

        public DescribeTransactionsListResponse DescribeTransactionsListWithOptions(DescribeTransactionsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Coin))
            {
                query["Coin"] = request.Coin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTransactionsList",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTransactionsListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeTransactionsListResponse> DescribeTransactionsListWithOptionsAsync(DescribeTransactionsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Coin))
            {
                query["Coin"] = request.Coin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTransactionsList",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTransactionsListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeTransactionsListResponse DescribeTransactionsList(DescribeTransactionsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTransactionsListWithOptions(request, runtime);
        }

        public async Task<DescribeTransactionsListResponse> DescribeTransactionsListAsync(DescribeTransactionsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTransactionsListWithOptionsAsync(request, runtime);
        }

        public DescribeWeb3AddressLabelsResponse DescribeWeb3AddressLabelsWithOptions(DescribeWeb3AddressLabelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChainShortName))
            {
                query["ChainShortName"] = request.ChainShortName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWeb3AddressLabels",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWeb3AddressLabelsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeWeb3AddressLabelsResponse> DescribeWeb3AddressLabelsWithOptionsAsync(DescribeWeb3AddressLabelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChainShortName))
            {
                query["ChainShortName"] = request.ChainShortName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWeb3AddressLabels",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWeb3AddressLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeWeb3AddressLabelsResponse DescribeWeb3AddressLabels(DescribeWeb3AddressLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWeb3AddressLabelsWithOptions(request, runtime);
        }

        public async Task<DescribeWeb3AddressLabelsResponse> DescribeWeb3AddressLabelsAsync(DescribeWeb3AddressLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWeb3AddressLabelsWithOptionsAsync(request, runtime);
        }

        public DescribeWeb3RiskScoreResponse DescribeWeb3RiskScoreWithOptions(DescribeWeb3RiskScoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChainShortName))
            {
                query["ChainShortName"] = request.ChainShortName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Depth))
            {
                query["Depth"] = request.Depth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                query["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["ObjectType"] = request.ObjectType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWeb3RiskScore",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWeb3RiskScoreResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeWeb3RiskScoreResponse> DescribeWeb3RiskScoreWithOptionsAsync(DescribeWeb3RiskScoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChainShortName))
            {
                query["ChainShortName"] = request.ChainShortName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Depth))
            {
                query["Depth"] = request.Depth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                query["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["ObjectType"] = request.ObjectType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWeb3RiskScore",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWeb3RiskScoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeWeb3RiskScoreResponse DescribeWeb3RiskScore(DescribeWeb3RiskScoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWeb3RiskScoreWithOptions(request, runtime);
        }

        public async Task<DescribeWeb3RiskScoreResponse> DescribeWeb3RiskScoreAsync(DescribeWeb3RiskScoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWeb3RiskScoreWithOptionsAsync(request, runtime);
        }

        public DescribeWeb3TransactionLabelsResponse DescribeWeb3TransactionLabelsWithOptions(DescribeWeb3TransactionLabelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChainShortName))
            {
                query["ChainShortName"] = request.ChainShortName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Transaction))
            {
                query["Transaction"] = request.Transaction;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWeb3TransactionLabels",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWeb3TransactionLabelsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeWeb3TransactionLabelsResponse> DescribeWeb3TransactionLabelsWithOptionsAsync(DescribeWeb3TransactionLabelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChainShortName))
            {
                query["ChainShortName"] = request.ChainShortName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Transaction))
            {
                query["Transaction"] = request.Transaction;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWeb3TransactionLabels",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWeb3TransactionLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeWeb3TransactionLabelsResponse DescribeWeb3TransactionLabels(DescribeWeb3TransactionLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWeb3TransactionLabelsWithOptions(request, runtime);
        }

        public async Task<DescribeWeb3TransactionLabelsResponse> DescribeWeb3TransactionLabelsAsync(DescribeWeb3TransactionLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWeb3TransactionLabelsWithOptionsAsync(request, runtime);
        }

        public DocOcrResponse DocOcrWithOptions(DocOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        public async Task<DocOcrResponse> DocOcrWithOptionsAsync(DocOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        public DocOcrResponse DocOcr(DocOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DocOcrWithOptions(request, runtime);
        }

        public async Task<DocOcrResponse> DocOcrAsync(DocOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DocOcrWithOptionsAsync(request, runtime);
        }

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

        public EkycVerifyResponse EkycVerify(EkycVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EkycVerifyWithOptions(request, runtime);
        }

        public async Task<EkycVerifyResponse> EkycVerifyAsync(EkycVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EkycVerifyWithOptionsAsync(request, runtime);
        }

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

        public FaceCompareResponse FaceCompare(FaceCompareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FaceCompareWithOptions(request, runtime);
        }

        public async Task<FaceCompareResponse> FaceCompareAsync(FaceCompareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FaceCompareWithOptionsAsync(request, runtime);
        }

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

        public FaceLivenessResponse FaceLiveness(FaceLivenessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FaceLivenessWithOptions(request, runtime);
        }

        public async Task<FaceLivenessResponse> FaceLivenessAsync(FaceLivenessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FaceLivenessWithOptionsAsync(request, runtime);
        }

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

        public FraudResultCallBackResponse FraudResultCallBack(FraudResultCallBackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FraudResultCallBackWithOptions(request, runtime);
        }

        public async Task<FraudResultCallBackResponse> FraudResultCallBackAsync(FraudResultCallBackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FraudResultCallBackWithOptionsAsync(request, runtime);
        }

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

        public Id2MetaVerifyIntlResponse Id2MetaVerifyIntl(Id2MetaVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Id2MetaVerifyIntlWithOptions(request, runtime);
        }

        public async Task<Id2MetaVerifyIntlResponse> Id2MetaVerifyIntlAsync(Id2MetaVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Id2MetaVerifyIntlWithOptionsAsync(request, runtime);
        }

        public InitializeResponse InitializeWithOptions(InitializeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureUrl))
            {
                query["FacePictureUrl"] = request.FacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowType))
            {
                query["FlowType"] = request.FlowType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdFaceQuality))
            {
                query["IdFaceQuality"] = request.IdFaceQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdSpoof))
            {
                query["IdSpoof"] = request.IdSpoof;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ocr))
            {
                query["Ocr"] = request.Ocr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationMode))
            {
                query["OperationMode"] = request.OperationMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pages))
            {
                query["Pages"] = request.Pages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductConfig))
            {
                query["ProductConfig"] = request.ProductConfig;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLevel))
            {
                query["ServiceLevel"] = request.ServiceLevel;
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

        public async Task<InitializeResponse> InitializeWithOptionsAsync(InitializeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureUrl))
            {
                query["FacePictureUrl"] = request.FacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowType))
            {
                query["FlowType"] = request.FlowType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdFaceQuality))
            {
                query["IdFaceQuality"] = request.IdFaceQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdSpoof))
            {
                query["IdSpoof"] = request.IdSpoof;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ocr))
            {
                query["Ocr"] = request.Ocr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationMode))
            {
                query["OperationMode"] = request.OperationMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pages))
            {
                query["Pages"] = request.Pages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductConfig))
            {
                query["ProductConfig"] = request.ProductConfig;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLevel))
            {
                query["ServiceLevel"] = request.ServiceLevel;
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

        public InitializeResponse Initialize(InitializeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitializeWithOptions(request, runtime);
        }

        public async Task<InitializeResponse> InitializeAsync(InitializeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitializeWithOptionsAsync(request, runtime);
        }

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

        public Mobile3MetaVerifyIntlResponse Mobile3MetaVerifyIntl(Mobile3MetaVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Mobile3MetaVerifyIntlWithOptions(request, runtime);
        }

        public async Task<Mobile3MetaVerifyIntlResponse> Mobile3MetaVerifyIntlAsync(Mobile3MetaVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Mobile3MetaVerifyIntlWithOptionsAsync(request, runtime);
        }

    }
}
