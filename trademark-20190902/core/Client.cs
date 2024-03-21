// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Trademark20190902.Models;

namespace AlibabaCloud.SDK.Trademark20190902
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("trademark", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public BindApplicantResponse BindApplicantWithOptions(BindApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantId))
            {
                query["ApplicantId"] = request.ApplicantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationOssKey))
            {
                query["AuthorizationOssKey"] = request.AuthorizationOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindApplicant",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindApplicantResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BindApplicantResponse> BindApplicantWithOptionsAsync(BindApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantId))
            {
                query["ApplicantId"] = request.ApplicantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationOssKey))
            {
                query["AuthorizationOssKey"] = request.AuthorizationOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindApplicant",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindApplicantResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BindApplicantResponse BindApplicant(BindApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindApplicantWithOptions(request, runtime);
        }

        public async Task<BindApplicantResponse> BindApplicantAsync(BindApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindApplicantWithOptionsAsync(request, runtime);
        }

        public CancelOrderResponse CancelOrderWithOptions(CancelOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelOrder",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelOrderResponse> CancelOrderWithOptionsAsync(CancelOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelOrder",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelOrderResponse CancelOrder(CancelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelOrderWithOptions(request, runtime);
        }

        public async Task<CancelOrderResponse> CancelOrderAsync(CancelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelOrderWithOptionsAsync(request, runtime);
        }

        public CheckAuthorizationLetterResponse CheckAuthorizationLetterWithOptions(CheckAuthorizationLetterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantType))
            {
                query["ApplicantType"] = request.ApplicantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Color))
            {
                query["Color"] = request.Color;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactZipcode))
            {
                query["ContactZipcode"] = request.ContactZipcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
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
                Action = "CheckAuthorizationLetter",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckAuthorizationLetterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckAuthorizationLetterResponse> CheckAuthorizationLetterWithOptionsAsync(CheckAuthorizationLetterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantType))
            {
                query["ApplicantType"] = request.ApplicantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Color))
            {
                query["Color"] = request.Color;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactZipcode))
            {
                query["ContactZipcode"] = request.ContactZipcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
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
                Action = "CheckAuthorizationLetter",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckAuthorizationLetterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckAuthorizationLetterResponse CheckAuthorizationLetter(CheckAuthorizationLetterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckAuthorizationLetterWithOptions(request, runtime);
        }

        public async Task<CheckAuthorizationLetterResponse> CheckAuthorizationLetterAsync(CheckAuthorizationLetterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckAuthorizationLetterWithOptionsAsync(request, runtime);
        }

        public CheckBizAvailableResponse CheckBizAvailableWithOptions(CheckBizAvailableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Biz))
            {
                query["Biz"] = request.Biz;
            }
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
                Action = "CheckBizAvailable",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckBizAvailableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckBizAvailableResponse> CheckBizAvailableWithOptionsAsync(CheckBizAvailableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Biz))
            {
                query["Biz"] = request.Biz;
            }
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
                Action = "CheckBizAvailable",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckBizAvailableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckBizAvailableResponse CheckBizAvailable(CheckBizAvailableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckBizAvailableWithOptions(request, runtime);
        }

        public async Task<CheckBizAvailableResponse> CheckBizAvailableAsync(CheckBizAvailableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckBizAvailableWithOptionsAsync(request, runtime);
        }

        public CheckDuplicateApplicantRiskResponse CheckDuplicateApplicantRiskWithOptions(CheckDuplicateApplicantRiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantName))
            {
                query["ApplicantName"] = request.ApplicantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSceneType))
            {
                query["EventSceneType"] = request.EventSceneType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDuplicateApplicantRisk",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDuplicateApplicantRiskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckDuplicateApplicantRiskResponse> CheckDuplicateApplicantRiskWithOptionsAsync(CheckDuplicateApplicantRiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantName))
            {
                query["ApplicantName"] = request.ApplicantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSceneType))
            {
                query["EventSceneType"] = request.EventSceneType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDuplicateApplicantRisk",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDuplicateApplicantRiskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckDuplicateApplicantRiskResponse CheckDuplicateApplicantRisk(CheckDuplicateApplicantRiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDuplicateApplicantRiskWithOptions(request, runtime);
        }

        public async Task<CheckDuplicateApplicantRiskResponse> CheckDuplicateApplicantRiskAsync(CheckDuplicateApplicantRiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDuplicateApplicantRiskWithOptionsAsync(request, runtime);
        }

        public CheckDuplicateClassificationResponse CheckDuplicateClassificationWithOptions(CheckDuplicateClassificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                query["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSceneType))
            {
                query["EventSceneType"] = request.EventSceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDuplicateClassification",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDuplicateClassificationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckDuplicateClassificationResponse> CheckDuplicateClassificationWithOptionsAsync(CheckDuplicateClassificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                query["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSceneType))
            {
                query["EventSceneType"] = request.EventSceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDuplicateClassification",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDuplicateClassificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckDuplicateClassificationResponse CheckDuplicateClassification(CheckDuplicateClassificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDuplicateClassificationWithOptions(request, runtime);
        }

        public async Task<CheckDuplicateClassificationResponse> CheckDuplicateClassificationAsync(CheckDuplicateClassificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDuplicateClassificationWithOptionsAsync(request, runtime);
        }

        public CheckDuplicateTrademarkResponse CheckDuplicateTrademarkWithOptions(CheckDuplicateTrademarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                query["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSceneType))
            {
                query["EventSceneType"] = request.EventSceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialName))
            {
                query["MaterialName"] = request.MaterialName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDuplicateTrademark",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDuplicateTrademarkResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckDuplicateTrademarkResponse> CheckDuplicateTrademarkWithOptionsAsync(CheckDuplicateTrademarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                query["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSceneType))
            {
                query["EventSceneType"] = request.EventSceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialName))
            {
                query["MaterialName"] = request.MaterialName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDuplicateTrademark",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDuplicateTrademarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckDuplicateTrademarkResponse CheckDuplicateTrademark(CheckDuplicateTrademarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDuplicateTrademarkWithOptions(request, runtime);
        }

        public async Task<CheckDuplicateTrademarkResponse> CheckDuplicateTrademarkAsync(CheckDuplicateTrademarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDuplicateTrademarkWithOptionsAsync(request, runtime);
        }

        public CheckMaterialValidityResponse CheckMaterialValidityWithOptions(CheckMaterialValidityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLicenseOssKey))
            {
                query["BusinessLicenseOssKey"] = request.BusinessLicenseOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNumber))
            {
                query["CardNumber"] = request.CardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardName))
            {
                query["IdCardName"] = request.IdCardName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardNumber))
            {
                query["IdCardNumber"] = request.IdCardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardOssKey))
            {
                query["IdCardOssKey"] = request.IdCardOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialId))
            {
                query["MaterialId"] = request.MaterialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialRegion))
            {
                query["MaterialRegion"] = request.MaterialRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialType))
            {
                query["MaterialType"] = request.MaterialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckMaterialValidity",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckMaterialValidityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckMaterialValidityResponse> CheckMaterialValidityWithOptionsAsync(CheckMaterialValidityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLicenseOssKey))
            {
                query["BusinessLicenseOssKey"] = request.BusinessLicenseOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNumber))
            {
                query["CardNumber"] = request.CardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardName))
            {
                query["IdCardName"] = request.IdCardName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardNumber))
            {
                query["IdCardNumber"] = request.IdCardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardOssKey))
            {
                query["IdCardOssKey"] = request.IdCardOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialId))
            {
                query["MaterialId"] = request.MaterialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialRegion))
            {
                query["MaterialRegion"] = request.MaterialRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialType))
            {
                query["MaterialType"] = request.MaterialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckMaterialValidity",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckMaterialValidityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckMaterialValidityResponse CheckMaterialValidity(CheckMaterialValidityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckMaterialValidityWithOptions(request, runtime);
        }

        public async Task<CheckMaterialValidityResponse> CheckMaterialValidityAsync(CheckMaterialValidityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckMaterialValidityWithOptionsAsync(request, runtime);
        }

        public CheckTrademarkNameResponse CheckTrademarkNameWithOptions(CheckTrademarkNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSceneType))
            {
                query["EventSceneType"] = request.EventSceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckTrademarkName",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckTrademarkNameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckTrademarkNameResponse> CheckTrademarkNameWithOptionsAsync(CheckTrademarkNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSceneType))
            {
                query["EventSceneType"] = request.EventSceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckTrademarkName",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckTrademarkNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckTrademarkNameResponse CheckTrademarkName(CheckTrademarkNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckTrademarkNameWithOptions(request, runtime);
        }

        public async Task<CheckTrademarkNameResponse> CheckTrademarkNameAsync(CheckTrademarkNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckTrademarkNameWithOptionsAsync(request, runtime);
        }

        public CloseTrademarkApplicationResponse CloseTrademarkApplicationWithOptions(CloseTrademarkApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseTrademarkApplication",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseTrademarkApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CloseTrademarkApplicationResponse> CloseTrademarkApplicationWithOptionsAsync(CloseTrademarkApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseTrademarkApplication",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseTrademarkApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CloseTrademarkApplicationResponse CloseTrademarkApplication(CloseTrademarkApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloseTrademarkApplicationWithOptions(request, runtime);
        }

        public async Task<CloseTrademarkApplicationResponse> CloseTrademarkApplicationAsync(CloseTrademarkApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloseTrademarkApplicationWithOptionsAsync(request, runtime);
        }

        public CombineAuthorizationLetterResponse CombineAuthorizationLetterWithOptions(CombineAuthorizationLetterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantType))
            {
                query["ApplicantType"] = request.ApplicantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPhone))
            {
                query["ContactPhone"] = request.ContactPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPostcode))
            {
                query["ContactPostcode"] = request.ContactPostcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialId))
            {
                query["MaterialId"] = request.MaterialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialName))
            {
                query["MaterialName"] = request.MaterialName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nationality))
            {
                query["Nationality"] = request.Nationality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmProduceType))
            {
                query["TmProduceType"] = request.TmProduceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CombineAuthorizationLetter",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CombineAuthorizationLetterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CombineAuthorizationLetterResponse> CombineAuthorizationLetterWithOptionsAsync(CombineAuthorizationLetterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantType))
            {
                query["ApplicantType"] = request.ApplicantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPhone))
            {
                query["ContactPhone"] = request.ContactPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPostcode))
            {
                query["ContactPostcode"] = request.ContactPostcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialId))
            {
                query["MaterialId"] = request.MaterialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialName))
            {
                query["MaterialName"] = request.MaterialName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nationality))
            {
                query["Nationality"] = request.Nationality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmProduceType))
            {
                query["TmProduceType"] = request.TmProduceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CombineAuthorizationLetter",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CombineAuthorizationLetterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CombineAuthorizationLetterResponse CombineAuthorizationLetter(CombineAuthorizationLetterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CombineAuthorizationLetterWithOptions(request, runtime);
        }

        public async Task<CombineAuthorizationLetterResponse> CombineAuthorizationLetterAsync(CombineAuthorizationLetterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CombineAuthorizationLetterWithOptionsAsync(request, runtime);
        }

        public ComplementTrademarkApplicationResponse ComplementTrademarkApplicationWithOptions(ComplementTrademarkApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementId))
            {
                query["AgreementId"] = request.AgreementId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationOssKey))
            {
                query["AuthorizationOssKey"] = request.AuthorizationOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsBlackIcon))
            {
                query["IsBlackIcon"] = request.IsBlackIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialId))
            {
                query["MaterialId"] = request.MaterialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderData))
            {
                query["OrderData"] = request.OrderData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkComment))
            {
                query["TrademarkComment"] = request.TrademarkComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkIconOssKey))
            {
                query["TrademarkIconOssKey"] = request.TrademarkIconOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkNameType))
            {
                query["TrademarkNameType"] = request.TrademarkNameType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkType))
            {
                query["TrademarkType"] = request.TrademarkType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ComplementTrademarkApplication",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ComplementTrademarkApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ComplementTrademarkApplicationResponse> ComplementTrademarkApplicationWithOptionsAsync(ComplementTrademarkApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementId))
            {
                query["AgreementId"] = request.AgreementId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationOssKey))
            {
                query["AuthorizationOssKey"] = request.AuthorizationOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsBlackIcon))
            {
                query["IsBlackIcon"] = request.IsBlackIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialId))
            {
                query["MaterialId"] = request.MaterialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderData))
            {
                query["OrderData"] = request.OrderData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkComment))
            {
                query["TrademarkComment"] = request.TrademarkComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkIconOssKey))
            {
                query["TrademarkIconOssKey"] = request.TrademarkIconOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkNameType))
            {
                query["TrademarkNameType"] = request.TrademarkNameType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkType))
            {
                query["TrademarkType"] = request.TrademarkType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ComplementTrademarkApplication",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ComplementTrademarkApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ComplementTrademarkApplicationResponse ComplementTrademarkApplication(ComplementTrademarkApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ComplementTrademarkApplicationWithOptions(request, runtime);
        }

        public async Task<ComplementTrademarkApplicationResponse> ComplementTrademarkApplicationAsync(ComplementTrademarkApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ComplementTrademarkApplicationWithOptionsAsync(request, runtime);
        }

        public ConfirmExpertSolutionResponse ConfirmExpertSolutionWithOptions(ConfirmExpertSolutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmExpertSolution",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmExpertSolutionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConfirmExpertSolutionResponse> ConfirmExpertSolutionWithOptionsAsync(ConfirmExpertSolutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmExpertSolution",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmExpertSolutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConfirmExpertSolutionResponse ConfirmExpertSolution(ConfirmExpertSolutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfirmExpertSolutionWithOptions(request, runtime);
        }

        public async Task<ConfirmExpertSolutionResponse> ConfirmExpertSolutionAsync(ConfirmExpertSolutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfirmExpertSolutionWithOptionsAsync(request, runtime);
        }

        public CreateApplicantResponse CreateApplicantWithOptions(CreateApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantName))
            {
                query["ApplicantName"] = request.ApplicantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantRegion))
            {
                query["ApplicantRegion"] = request.ApplicantRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantType))
            {
                query["ApplicantType"] = request.ApplicantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationOssKey))
            {
                query["AuthorizationOssKey"] = request.AuthorizationOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLicenceOssKey))
            {
                query["BusinessLicenceOssKey"] = request.BusinessLicenceOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNumber))
            {
                query["CardNumber"] = request.CardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddress))
            {
                query["ContactAddress"] = request.ContactAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCity))
            {
                query["ContactCity"] = request.ContactCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCounty))
            {
                query["ContactCounty"] = request.ContactCounty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactDistrict))
            {
                query["ContactDistrict"] = request.ContactDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                query["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactProvince))
            {
                query["ContactProvince"] = request.ContactProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactZipcode))
            {
                query["ContactZipcode"] = request.ContactZipcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EAddress))
            {
                query["EAddress"] = request.EAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EName))
            {
                query["EName"] = request.EName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardName))
            {
                query["IdCardName"] = request.IdCardName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardNumber))
            {
                query["IdCardNumber"] = request.IdCardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardOssKey))
            {
                query["IdCardOssKey"] = request.IdCardOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeOssKey))
            {
                query["LegalNoticeOssKey"] = request.LegalNoticeOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassportOssKey))
            {
                query["PassportOssKey"] = request.PassportOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplicant",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApplicantResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateApplicantResponse> CreateApplicantWithOptionsAsync(CreateApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantName))
            {
                query["ApplicantName"] = request.ApplicantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantRegion))
            {
                query["ApplicantRegion"] = request.ApplicantRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantType))
            {
                query["ApplicantType"] = request.ApplicantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationOssKey))
            {
                query["AuthorizationOssKey"] = request.AuthorizationOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLicenceOssKey))
            {
                query["BusinessLicenceOssKey"] = request.BusinessLicenceOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNumber))
            {
                query["CardNumber"] = request.CardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddress))
            {
                query["ContactAddress"] = request.ContactAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCity))
            {
                query["ContactCity"] = request.ContactCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCounty))
            {
                query["ContactCounty"] = request.ContactCounty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactDistrict))
            {
                query["ContactDistrict"] = request.ContactDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                query["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactProvince))
            {
                query["ContactProvince"] = request.ContactProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactZipcode))
            {
                query["ContactZipcode"] = request.ContactZipcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EAddress))
            {
                query["EAddress"] = request.EAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EName))
            {
                query["EName"] = request.EName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardName))
            {
                query["IdCardName"] = request.IdCardName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardNumber))
            {
                query["IdCardNumber"] = request.IdCardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardOssKey))
            {
                query["IdCardOssKey"] = request.IdCardOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeOssKey))
            {
                query["LegalNoticeOssKey"] = request.LegalNoticeOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassportOssKey))
            {
                query["PassportOssKey"] = request.PassportOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplicant",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApplicantResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateApplicantResponse CreateApplicant(CreateApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateApplicantWithOptions(request, runtime);
        }

        public async Task<CreateApplicantResponse> CreateApplicantAsync(CreateApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateApplicantWithOptionsAsync(request, runtime);
        }

        public CreateCommodityOrderResponse CreateCommodityOrderWithOptions(CreateCommodityOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCommodityOrderShrinkRequest request = new CreateCommodityOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Components))
            {
                request.ComponentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Components, "Components", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderParams))
            {
                request.OrderParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderParams, "OrderParams", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                query["CommodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentsShrink))
            {
                query["Components"] = request.ComponentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderParamsShrink))
            {
                query["OrderParams"] = request.OrderParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                query["Quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecCode))
            {
                query["SpecCode"] = request.SpecCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCommodityOrder",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCommodityOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCommodityOrderResponse> CreateCommodityOrderWithOptionsAsync(CreateCommodityOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCommodityOrderShrinkRequest request = new CreateCommodityOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Components))
            {
                request.ComponentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Components, "Components", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderParams))
            {
                request.OrderParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderParams, "OrderParams", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                query["CommodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentsShrink))
            {
                query["Components"] = request.ComponentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderParamsShrink))
            {
                query["OrderParams"] = request.OrderParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                query["Quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecCode))
            {
                query["SpecCode"] = request.SpecCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCommodityOrder",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCommodityOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCommodityOrderResponse CreateCommodityOrder(CreateCommodityOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCommodityOrderWithOptions(request, runtime);
        }

        public async Task<CreateCommodityOrderResponse> CreateCommodityOrderAsync(CreateCommodityOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCommodityOrderWithOptionsAsync(request, runtime);
        }

        public CreateOrderResponse CreateOrderWithOptions(CreateOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementId))
            {
                query["AgreementId"] = request.AgreementId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantId))
            {
                query["ApplicantId"] = request.ApplicantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationType))
            {
                query["ApplicationType"] = request.ApplicationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationOssKey))
            {
                query["AuthorizationOssKey"] = request.AuthorizationOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackAndWhiteIcon))
            {
                query["BlackAndWhiteIcon"] = request.BlackAndWhiteIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classifications))
            {
                query["Classifications"] = request.Classifications;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["IdempotentId"] = request.IdempotentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeKey))
            {
                query["LegalNoticeKey"] = request.LegalNoticeKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentCallback))
            {
                query["PaymentCallback"] = request.PaymentCallback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkComment))
            {
                query["TrademarkComment"] = request.TrademarkComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkIcon))
            {
                query["TrademarkIcon"] = request.TrademarkIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkNameType))
            {
                query["TrademarkNameType"] = request.TrademarkNameType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrder",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateOrderResponse> CreateOrderWithOptionsAsync(CreateOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementId))
            {
                query["AgreementId"] = request.AgreementId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantId))
            {
                query["ApplicantId"] = request.ApplicantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationType))
            {
                query["ApplicationType"] = request.ApplicationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationOssKey))
            {
                query["AuthorizationOssKey"] = request.AuthorizationOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackAndWhiteIcon))
            {
                query["BlackAndWhiteIcon"] = request.BlackAndWhiteIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classifications))
            {
                query["Classifications"] = request.Classifications;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["IdempotentId"] = request.IdempotentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeKey))
            {
                query["LegalNoticeKey"] = request.LegalNoticeKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentCallback))
            {
                query["PaymentCallback"] = request.PaymentCallback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkComment))
            {
                query["TrademarkComment"] = request.TrademarkComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkIcon))
            {
                query["TrademarkIcon"] = request.TrademarkIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkNameType))
            {
                query["TrademarkNameType"] = request.TrademarkNameType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrder",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateOrderResponse CreateOrder(CreateOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOrderWithOptions(request, runtime);
        }

        public async Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOrderWithOptionsAsync(request, runtime);
        }

        public CreateTrademarkApplicationResponse CreateTrademarkApplicationWithOptions(CreateTrademarkApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementId))
            {
                query["AgreementId"] = request.AgreementId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantId))
            {
                query["ApplicantId"] = request.ApplicantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationType))
            {
                query["ApplicationType"] = request.ApplicationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationOssKey))
            {
                query["AuthorizationOssKey"] = request.AuthorizationOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackAndWhiteIcon))
            {
                query["BlackAndWhiteIcon"] = request.BlackAndWhiteIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classifications))
            {
                query["Classifications"] = request.Classifications;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["IdempotentId"] = request.IdempotentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeKey))
            {
                query["LegalNoticeKey"] = request.LegalNoticeKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkComment))
            {
                query["TrademarkComment"] = request.TrademarkComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkIcon))
            {
                query["TrademarkIcon"] = request.TrademarkIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkNameType))
            {
                query["TrademarkNameType"] = request.TrademarkNameType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrademarkApplication",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrademarkApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTrademarkApplicationResponse> CreateTrademarkApplicationWithOptionsAsync(CreateTrademarkApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementId))
            {
                query["AgreementId"] = request.AgreementId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantId))
            {
                query["ApplicantId"] = request.ApplicantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationType))
            {
                query["ApplicationType"] = request.ApplicationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationOssKey))
            {
                query["AuthorizationOssKey"] = request.AuthorizationOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackAndWhiteIcon))
            {
                query["BlackAndWhiteIcon"] = request.BlackAndWhiteIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classifications))
            {
                query["Classifications"] = request.Classifications;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["IdempotentId"] = request.IdempotentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeKey))
            {
                query["LegalNoticeKey"] = request.LegalNoticeKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkComment))
            {
                query["TrademarkComment"] = request.TrademarkComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkIcon))
            {
                query["TrademarkIcon"] = request.TrademarkIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkNameType))
            {
                query["TrademarkNameType"] = request.TrademarkNameType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrademarkApplication",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrademarkApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTrademarkApplicationResponse CreateTrademarkApplication(CreateTrademarkApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTrademarkApplicationWithOptions(request, runtime);
        }

        public async Task<CreateTrademarkApplicationResponse> CreateTrademarkApplicationAsync(CreateTrademarkApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTrademarkApplicationWithOptionsAsync(request, runtime);
        }

        public DeleteSearchConditionResponse DeleteSearchConditionWithOptions(DeleteSearchConditionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConditionId))
            {
                query["ConditionId"] = request.ConditionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Umid))
            {
                query["Umid"] = request.Umid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSearchCondition",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSearchConditionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteSearchConditionResponse> DeleteSearchConditionWithOptionsAsync(DeleteSearchConditionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConditionId))
            {
                query["ConditionId"] = request.ConditionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Umid))
            {
                query["Umid"] = request.Umid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSearchCondition",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSearchConditionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteSearchConditionResponse DeleteSearchCondition(DeleteSearchConditionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSearchConditionWithOptions(request, runtime);
        }

        public async Task<DeleteSearchConditionResponse> DeleteSearchConditionAsync(DeleteSearchConditionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSearchConditionWithOptionsAsync(request, runtime);
        }

        public DescribeAdminTrademarkApplicationResponse DescribeAdminTrademarkApplicationWithOptions(DescribeAdminTrademarkApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAdminTrademarkApplication",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAdminTrademarkApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAdminTrademarkApplicationResponse> DescribeAdminTrademarkApplicationWithOptionsAsync(DescribeAdminTrademarkApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAdminTrademarkApplication",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAdminTrademarkApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAdminTrademarkApplicationResponse DescribeAdminTrademarkApplication(DescribeAdminTrademarkApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAdminTrademarkApplicationWithOptions(request, runtime);
        }

        public async Task<DescribeAdminTrademarkApplicationResponse> DescribeAdminTrademarkApplicationAsync(DescribeAdminTrademarkApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAdminTrademarkApplicationWithOptionsAsync(request, runtime);
        }

        public DescribeApplicantResponse DescribeApplicantWithOptions(DescribeApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantId))
            {
                query["ApplicantId"] = request.ApplicantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicant",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicantResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeApplicantResponse> DescribeApplicantWithOptionsAsync(DescribeApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantId))
            {
                query["ApplicantId"] = request.ApplicantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicant",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicantResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeApplicantResponse DescribeApplicant(DescribeApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApplicantWithOptions(request, runtime);
        }

        public async Task<DescribeApplicantResponse> DescribeApplicantAsync(DescribeApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApplicantWithOptionsAsync(request, runtime);
        }

        public DescribePartnerTrademarkApplicationResponse DescribePartnerTrademarkApplicationWithOptions(DescribePartnerTrademarkApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePartnerTrademarkApplication",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePartnerTrademarkApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePartnerTrademarkApplicationResponse> DescribePartnerTrademarkApplicationWithOptionsAsync(DescribePartnerTrademarkApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePartnerTrademarkApplication",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePartnerTrademarkApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePartnerTrademarkApplicationResponse DescribePartnerTrademarkApplication(DescribePartnerTrademarkApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePartnerTrademarkApplicationWithOptions(request, runtime);
        }

        public async Task<DescribePartnerTrademarkApplicationResponse> DescribePartnerTrademarkApplicationAsync(DescribePartnerTrademarkApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePartnerTrademarkApplicationWithOptionsAsync(request, runtime);
        }

        public DescribeQualificationStatusResponse DescribeQualificationStatusWithOptions(DescribeQualificationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUid))
            {
                query["TbUid"] = request.TbUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQualificationStatus",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQualificationStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeQualificationStatusResponse> DescribeQualificationStatusWithOptionsAsync(DescribeQualificationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUid))
            {
                query["TbUid"] = request.TbUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQualificationStatus",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQualificationStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeQualificationStatusResponse DescribeQualificationStatus(DescribeQualificationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeQualificationStatusWithOptions(request, runtime);
        }

        public async Task<DescribeQualificationStatusResponse> DescribeQualificationStatusAsync(DescribeQualificationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeQualificationStatusWithOptionsAsync(request, runtime);
        }

        /**
          * ****
          *
          * @param request DescribeSupplementRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeSupplementResponse
         */
        public DescribeSupplementResponse DescribeSupplementWithOptions(DescribeSupplementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplementId))
            {
                query["SupplementId"] = request.SupplementId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSupplement",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSupplementResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ****
          *
          * @param request DescribeSupplementRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeSupplementResponse
         */
        public async Task<DescribeSupplementResponse> DescribeSupplementWithOptionsAsync(DescribeSupplementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplementId))
            {
                query["SupplementId"] = request.SupplementId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSupplement",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSupplementResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ****
          *
          * @param request DescribeSupplementRequest
          * @return DescribeSupplementResponse
         */
        public DescribeSupplementResponse DescribeSupplement(DescribeSupplementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSupplementWithOptions(request, runtime);
        }

        /**
          * ****
          *
          * @param request DescribeSupplementRequest
          * @return DescribeSupplementResponse
         */
        public async Task<DescribeSupplementResponse> DescribeSupplementAsync(DescribeSupplementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSupplementWithOptionsAsync(request, runtime);
        }

        public DescribeTrademarkApplicationResponse DescribeTrademarkApplicationWithOptions(DescribeTrademarkApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTrademarkApplication",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTrademarkApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeTrademarkApplicationResponse> DescribeTrademarkApplicationWithOptionsAsync(DescribeTrademarkApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTrademarkApplication",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTrademarkApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeTrademarkApplicationResponse DescribeTrademarkApplication(DescribeTrademarkApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTrademarkApplicationWithOptions(request, runtime);
        }

        public async Task<DescribeTrademarkApplicationResponse> DescribeTrademarkApplicationAsync(DescribeTrademarkApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTrademarkApplicationWithOptionsAsync(request, runtime);
        }

        public DescribeTrademarkDetailForInnerResponse DescribeTrademarkDetailForInnerWithOptions(DescribeTrademarkDetailForInnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Umid))
            {
                query["Umid"] = request.Umid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTrademarkDetailForInner",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTrademarkDetailForInnerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeTrademarkDetailForInnerResponse> DescribeTrademarkDetailForInnerWithOptionsAsync(DescribeTrademarkDetailForInnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Umid))
            {
                query["Umid"] = request.Umid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTrademarkDetailForInner",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTrademarkDetailForInnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeTrademarkDetailForInnerResponse DescribeTrademarkDetailForInner(DescribeTrademarkDetailForInnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTrademarkDetailForInnerWithOptions(request, runtime);
        }

        public async Task<DescribeTrademarkDetailForInnerResponse> DescribeTrademarkDetailForInnerAsync(DescribeTrademarkDetailForInnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTrademarkDetailForInnerWithOptionsAsync(request, runtime);
        }

        public GenerateUploadFilePolicyResponse GenerateUploadFilePolicyWithOptions(GenerateUploadFilePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateUploadFilePolicy",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateUploadFilePolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateUploadFilePolicyResponse> GenerateUploadFilePolicyWithOptionsAsync(GenerateUploadFilePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateUploadFilePolicy",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateUploadFilePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateUploadFilePolicyResponse GenerateUploadFilePolicy(GenerateUploadFilePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateUploadFilePolicyWithOptions(request, runtime);
        }

        public async Task<GenerateUploadFilePolicyResponse> GenerateUploadFilePolicyAsync(GenerateUploadFilePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateUploadFilePolicyWithOptionsAsync(request, runtime);
        }

        public GetAlipayUrlResponse GetAlipayUrlWithOptions(GetAlipayUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlipayUrl",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlipayUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAlipayUrlResponse> GetAlipayUrlWithOptionsAsync(GetAlipayUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlipayUrl",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlipayUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAlipayUrlResponse GetAlipayUrl(GetAlipayUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAlipayUrlWithOptions(request, runtime);
        }

        public async Task<GetAlipayUrlResponse> GetAlipayUrlAsync(GetAlipayUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAlipayUrlWithOptionsAsync(request, runtime);
        }

        public GetOrderConfirmUrlResponse GetOrderConfirmUrlWithOptions(GetOrderConfirmUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Items))
            {
                query["Items"] = request.Items;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTraceCode))
            {
                query["OutTraceCode"] = request.OutTraceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTraceType))
            {
                query["OutTraceType"] = request.OutTraceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrderConfirmUrl",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrderConfirmUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetOrderConfirmUrlResponse> GetOrderConfirmUrlWithOptionsAsync(GetOrderConfirmUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Items))
            {
                query["Items"] = request.Items;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTraceCode))
            {
                query["OutTraceCode"] = request.OutTraceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTraceType))
            {
                query["OutTraceType"] = request.OutTraceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrderConfirmUrl",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrderConfirmUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetOrderConfirmUrlResponse GetOrderConfirmUrl(GetOrderConfirmUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOrderConfirmUrlWithOptions(request, runtime);
        }

        public async Task<GetOrderConfirmUrlResponse> GetOrderConfirmUrlAsync(GetOrderConfirmUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOrderConfirmUrlWithOptionsAsync(request, runtime);
        }

        public GetStsByTaobaoUidResponse GetStsByTaobaoUidWithOptions(GetStsByTaobaoUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunUid))
            {
                query["AliyunUid"] = request.AliyunUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUid))
            {
                query["TbUid"] = request.TbUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStsByTaobaoUid",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStsByTaobaoUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetStsByTaobaoUidResponse> GetStsByTaobaoUidWithOptionsAsync(GetStsByTaobaoUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunUid))
            {
                query["AliyunUid"] = request.AliyunUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUid))
            {
                query["TbUid"] = request.TbUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStsByTaobaoUid",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStsByTaobaoUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetStsByTaobaoUidResponse GetStsByTaobaoUid(GetStsByTaobaoUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStsByTaobaoUidWithOptions(request, runtime);
        }

        public async Task<GetStsByTaobaoUidResponse> GetStsByTaobaoUidAsync(GetStsByTaobaoUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStsByTaobaoUidWithOptionsAsync(request, runtime);
        }

        public ListAdminTrademarkApplicationLogsResponse ListAdminTrademarkApplicationLogsWithOptions(ListAdminTrademarkApplicationLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAdminTrademarkApplicationLogs",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAdminTrademarkApplicationLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAdminTrademarkApplicationLogsResponse> ListAdminTrademarkApplicationLogsWithOptionsAsync(ListAdminTrademarkApplicationLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAdminTrademarkApplicationLogs",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAdminTrademarkApplicationLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAdminTrademarkApplicationLogsResponse ListAdminTrademarkApplicationLogs(ListAdminTrademarkApplicationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAdminTrademarkApplicationLogsWithOptions(request, runtime);
        }

        public async Task<ListAdminTrademarkApplicationLogsResponse> ListAdminTrademarkApplicationLogsAsync(ListAdminTrademarkApplicationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAdminTrademarkApplicationLogsWithOptionsAsync(request, runtime);
        }

        public ListAdminTrademarkApplicationsResponse ListAdminTrademarkApplicationsWithOptions(ListAdminTrademarkApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantName))
            {
                query["ApplicantName"] = request.ApplicantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationStatus))
            {
                query["ApplicationStatus"] = request.ApplicationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationType))
            {
                query["ApplicationType"] = request.ApplicationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplementStatus))
            {
                query["SupplementStatus"] = request.SupplementStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkNumber))
            {
                query["TrademarkNumber"] = request.TrademarkNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAdminTrademarkApplications",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAdminTrademarkApplicationsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAdminTrademarkApplicationsResponse> ListAdminTrademarkApplicationsWithOptionsAsync(ListAdminTrademarkApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantName))
            {
                query["ApplicantName"] = request.ApplicantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationStatus))
            {
                query["ApplicationStatus"] = request.ApplicationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationType))
            {
                query["ApplicationType"] = request.ApplicationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplementStatus))
            {
                query["SupplementStatus"] = request.SupplementStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkNumber))
            {
                query["TrademarkNumber"] = request.TrademarkNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAdminTrademarkApplications",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAdminTrademarkApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAdminTrademarkApplicationsResponse ListAdminTrademarkApplications(ListAdminTrademarkApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAdminTrademarkApplicationsWithOptions(request, runtime);
        }

        public async Task<ListAdminTrademarkApplicationsResponse> ListAdminTrademarkApplicationsAsync(ListAdminTrademarkApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAdminTrademarkApplicationsWithOptionsAsync(request, runtime);
        }

        public ListApplicantsResponse ListApplicantsWithOptions(ListApplicantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantName))
            {
                query["ApplicantName"] = request.ApplicantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantRegion))
            {
                query["ApplicantRegion"] = request.ApplicantRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantType))
            {
                query["ApplicantType"] = request.ApplicantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantVersion))
            {
                query["ApplicantVersion"] = request.ApplicantVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNumber))
            {
                query["CardNumber"] = request.CardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemVersion))
            {
                query["SystemVersion"] = request.SystemVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplicants",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicantsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListApplicantsResponse> ListApplicantsWithOptionsAsync(ListApplicantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantName))
            {
                query["ApplicantName"] = request.ApplicantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantRegion))
            {
                query["ApplicantRegion"] = request.ApplicantRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantType))
            {
                query["ApplicantType"] = request.ApplicantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantVersion))
            {
                query["ApplicantVersion"] = request.ApplicantVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNumber))
            {
                query["CardNumber"] = request.CardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemVersion))
            {
                query["SystemVersion"] = request.SystemVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplicants",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicantsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListApplicantsResponse ListApplicants(ListApplicantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApplicantsWithOptions(request, runtime);
        }

        public async Task<ListApplicantsResponse> ListApplicantsAsync(ListApplicantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApplicantsWithOptionsAsync(request, runtime);
        }

        public ListAreasResponse ListAreasWithOptions(ListAreasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCode))
            {
                query["ParentCode"] = request.ParentCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAreas",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAreasResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAreasResponse> ListAreasWithOptionsAsync(ListAreasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCode))
            {
                query["ParentCode"] = request.ParentCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAreas",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAreasResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAreasResponse ListAreas(ListAreasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAreasWithOptions(request, runtime);
        }

        public async Task<ListAreasResponse> ListAreasAsync(ListAreasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAreasWithOptionsAsync(request, runtime);
        }

        public ListClassificationConditionsResponse ListClassificationConditionsWithOptions(ListClassificationConditionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
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
                Action = "ListClassificationConditions",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClassificationConditionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClassificationConditionsResponse> ListClassificationConditionsWithOptionsAsync(ListClassificationConditionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
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
                Action = "ListClassificationConditions",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClassificationConditionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClassificationConditionsResponse ListClassificationConditions(ListClassificationConditionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClassificationConditionsWithOptions(request, runtime);
        }

        public async Task<ListClassificationConditionsResponse> ListClassificationConditionsAsync(ListClassificationConditionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClassificationConditionsWithOptionsAsync(request, runtime);
        }

        public ListClassificationsResponse ListClassificationsWithOptions(ListClassificationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCode))
            {
                query["ParentCode"] = request.ParentCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClassifications",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClassificationsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClassificationsResponse> ListClassificationsWithOptionsAsync(ListClassificationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCode))
            {
                query["ParentCode"] = request.ParentCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClassifications",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClassificationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClassificationsResponse ListClassifications(ListClassificationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClassificationsWithOptions(request, runtime);
        }

        public async Task<ListClassificationsResponse> ListClassificationsAsync(ListClassificationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClassificationsWithOptionsAsync(request, runtime);
        }

        public ListTrademarkApplicationLogsResponse ListTrademarkApplicationLogsWithOptions(ListTrademarkApplicationLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrademarkApplicationLogs",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrademarkApplicationLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTrademarkApplicationLogsResponse> ListTrademarkApplicationLogsWithOptionsAsync(ListTrademarkApplicationLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrademarkApplicationLogs",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrademarkApplicationLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTrademarkApplicationLogsResponse ListTrademarkApplicationLogs(ListTrademarkApplicationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTrademarkApplicationLogsWithOptions(request, runtime);
        }

        public async Task<ListTrademarkApplicationLogsResponse> ListTrademarkApplicationLogsAsync(ListTrademarkApplicationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTrademarkApplicationLogsWithOptionsAsync(request, runtime);
        }

        public ListTrademarkApplicationsResponse ListTrademarkApplicationsWithOptions(ListTrademarkApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantName))
            {
                query["ApplicantName"] = request.ApplicantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationStatus))
            {
                query["ApplicationStatus"] = request.ApplicationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationType))
            {
                query["ApplicationType"] = request.ApplicationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeLeft))
            {
                query["CreateTimeLeft"] = request.CreateTimeLeft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeRight))
            {
                query["CreateTimeRight"] = request.CreateTimeRight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flag))
            {
                query["Flag"] = request.Flag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryVoucherOrderDoneFlag))
            {
                query["QueryVoucherOrderDoneFlag"] = request.QueryVoucherOrderDoneFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryVoucherOrderFlag))
            {
                query["QueryVoucherOrderFlag"] = request.QueryVoucherOrderFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFiled))
            {
                query["SortFiled"] = request.SortFiled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplementStatus))
            {
                query["SupplementStatus"] = request.SupplementStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkNumber))
            {
                query["TrademarkNumber"] = request.TrademarkNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrademarkApplications",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrademarkApplicationsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTrademarkApplicationsResponse> ListTrademarkApplicationsWithOptionsAsync(ListTrademarkApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantName))
            {
                query["ApplicantName"] = request.ApplicantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationStatus))
            {
                query["ApplicationStatus"] = request.ApplicationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationType))
            {
                query["ApplicationType"] = request.ApplicationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeLeft))
            {
                query["CreateTimeLeft"] = request.CreateTimeLeft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeRight))
            {
                query["CreateTimeRight"] = request.CreateTimeRight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flag))
            {
                query["Flag"] = request.Flag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryVoucherOrderDoneFlag))
            {
                query["QueryVoucherOrderDoneFlag"] = request.QueryVoucherOrderDoneFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryVoucherOrderFlag))
            {
                query["QueryVoucherOrderFlag"] = request.QueryVoucherOrderFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFiled))
            {
                query["SortFiled"] = request.SortFiled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplementStatus))
            {
                query["SupplementStatus"] = request.SupplementStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkNumber))
            {
                query["TrademarkNumber"] = request.TrademarkNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrademarkApplications",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrademarkApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTrademarkApplicationsResponse ListTrademarkApplications(ListTrademarkApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTrademarkApplicationsWithOptions(request, runtime);
        }

        public async Task<ListTrademarkApplicationsResponse> ListTrademarkApplicationsAsync(ListTrademarkApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTrademarkApplicationsWithOptionsAsync(request, runtime);
        }

        public ListTrademarkSearchForInnerResponse ListTrademarkSearchForInnerWithOptions(ListTrademarkSearchForInnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyBeginTime))
            {
                query["ApplyBeginTime"] = request.ApplyBeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyEndTime))
            {
                query["ApplyEndTime"] = request.ApplyEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                query["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfPrecision))
            {
                query["IfPrecision"] = request.IfPrecision;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchPreference))
            {
                query["SearchPreference"] = request.SearchPreference;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["SearchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Umid))
            {
                query["Umid"] = request.Umid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrademarkSearchForInner",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrademarkSearchForInnerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTrademarkSearchForInnerResponse> ListTrademarkSearchForInnerWithOptionsAsync(ListTrademarkSearchForInnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyBeginTime))
            {
                query["ApplyBeginTime"] = request.ApplyBeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyEndTime))
            {
                query["ApplyEndTime"] = request.ApplyEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                query["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfPrecision))
            {
                query["IfPrecision"] = request.IfPrecision;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchPreference))
            {
                query["SearchPreference"] = request.SearchPreference;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["SearchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Umid))
            {
                query["Umid"] = request.Umid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrademarkSearchForInner",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrademarkSearchForInnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTrademarkSearchForInnerResponse ListTrademarkSearchForInner(ListTrademarkSearchForInnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTrademarkSearchForInnerWithOptions(request, runtime);
        }

        public async Task<ListTrademarkSearchForInnerResponse> ListTrademarkSearchForInnerAsync(ListTrademarkSearchForInnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTrademarkSearchForInnerWithOptionsAsync(request, runtime);
        }

        public PutMeasureDataResponse PutMeasureDataWithOptions(PutMeasureDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                body["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutMeasureData",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutMeasureDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutMeasureDataResponse> PutMeasureDataWithOptionsAsync(PutMeasureDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                body["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutMeasureData",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutMeasureDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutMeasureDataResponse PutMeasureData(PutMeasureDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutMeasureDataWithOptions(request, runtime);
        }

        public async Task<PutMeasureDataResponse> PutMeasureDataAsync(PutMeasureDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutMeasureDataWithOptionsAsync(request, runtime);
        }

        public PutMeasureReadyFlagResponse PutMeasureReadyFlagWithOptions(PutMeasureReadyFlagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadyFlag))
            {
                query["ReadyFlag"] = request.ReadyFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutMeasureReadyFlag",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutMeasureReadyFlagResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutMeasureReadyFlagResponse> PutMeasureReadyFlagWithOptionsAsync(PutMeasureReadyFlagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadyFlag))
            {
                query["ReadyFlag"] = request.ReadyFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutMeasureReadyFlag",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutMeasureReadyFlagResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutMeasureReadyFlagResponse PutMeasureReadyFlag(PutMeasureReadyFlagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutMeasureReadyFlagWithOptions(request, runtime);
        }

        public async Task<PutMeasureReadyFlagResponse> PutMeasureReadyFlagAsync(PutMeasureReadyFlagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutMeasureReadyFlagWithOptionsAsync(request, runtime);
        }

        public QueryActivityItemsResponse QueryActivityItemsWithOptions(QueryActivityItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendInfo))
            {
                query["ExtendInfo"] = request.ExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FloorIndex))
            {
                query["FloorIndex"] = request.FloorIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mock))
            {
                query["Mock"] = request.Mock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Refresh))
            {
                query["Refresh"] = request.Refresh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UmId))
            {
                query["UmId"] = request.UmId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryActivityItems",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryActivityItemsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryActivityItemsResponse> QueryActivityItemsWithOptionsAsync(QueryActivityItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendInfo))
            {
                query["ExtendInfo"] = request.ExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FloorIndex))
            {
                query["FloorIndex"] = request.FloorIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mock))
            {
                query["Mock"] = request.Mock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Refresh))
            {
                query["Refresh"] = request.Refresh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UmId))
            {
                query["UmId"] = request.UmId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryActivityItems",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryActivityItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryActivityItemsResponse QueryActivityItems(QueryActivityItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryActivityItemsWithOptions(request, runtime);
        }

        public async Task<QueryActivityItemsResponse> QueryActivityItemsAsync(QueryActivityItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryActivityItemsWithOptionsAsync(request, runtime);
        }

        public QueryAliyunUidResponse QueryAliyunUidWithOptions(QueryAliyunUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUid))
            {
                query["TbUid"] = request.TbUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAliyunUid",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAliyunUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryAliyunUidResponse> QueryAliyunUidWithOptionsAsync(QueryAliyunUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUid))
            {
                query["TbUid"] = request.TbUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAliyunUid",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAliyunUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryAliyunUidResponse QueryAliyunUid(QueryAliyunUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAliyunUidWithOptions(request, runtime);
        }

        public async Task<QueryAliyunUidResponse> QueryAliyunUidAsync(QueryAliyunUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAliyunUidWithOptionsAsync(request, runtime);
        }

        public QueryDetailItemResponse QueryDetailItemWithOptions(QueryDetailItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailConvertType))
            {
                query["DetailConvertType"] = request.DetailConvertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailId))
            {
                query["DetailId"] = request.DetailId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailType))
            {
                query["DetailType"] = request.DetailType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mock))
            {
                query["Mock"] = request.Mock;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDetailItem",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDetailItemResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDetailItemResponse> QueryDetailItemWithOptionsAsync(QueryDetailItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailConvertType))
            {
                query["DetailConvertType"] = request.DetailConvertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailId))
            {
                query["DetailId"] = request.DetailId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailType))
            {
                query["DetailType"] = request.DetailType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mock))
            {
                query["Mock"] = request.Mock;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDetailItem",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDetailItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDetailItemResponse QueryDetailItem(QueryDetailItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDetailItemWithOptions(request, runtime);
        }

        public async Task<QueryDetailItemResponse> QueryDetailItemAsync(QueryDetailItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDetailItemWithOptionsAsync(request, runtime);
        }

        public QueryRemainResourcesResponse QueryRemainResourcesWithOptions(QueryRemainResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRemainResources",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRemainResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRemainResourcesResponse> QueryRemainResourcesWithOptionsAsync(QueryRemainResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRemainResources",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRemainResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRemainResourcesResponse QueryRemainResources(QueryRemainResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRemainResourcesWithOptions(request, runtime);
        }

        public async Task<QueryRemainResourcesResponse> QueryRemainResourcesAsync(QueryRemainResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRemainResourcesWithOptionsAsync(request, runtime);
        }

        public RefuseSupplementResponse RefuseSupplementWithOptions(RefuseSupplementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplementId))
            {
                query["SupplementId"] = request.SupplementId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefuseSupplement",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefuseSupplementResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RefuseSupplementResponse> RefuseSupplementWithOptionsAsync(RefuseSupplementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplementId))
            {
                query["SupplementId"] = request.SupplementId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefuseSupplement",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefuseSupplementResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RefuseSupplementResponse RefuseSupplement(RefuseSupplementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefuseSupplementWithOptions(request, runtime);
        }

        public async Task<RefuseSupplementResponse> RefuseSupplementAsync(RefuseSupplementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefuseSupplementWithOptionsAsync(request, runtime);
        }

        public RejectExpertSolutionResponse RejectExpertSolutionWithOptions(RejectExpertSolutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RejectExpertSolution",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RejectExpertSolutionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RejectExpertSolutionResponse> RejectExpertSolutionWithOptionsAsync(RejectExpertSolutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RejectExpertSolution",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RejectExpertSolutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RejectExpertSolutionResponse RejectExpertSolution(RejectExpertSolutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RejectExpertSolutionWithOptions(request, runtime);
        }

        public async Task<RejectExpertSolutionResponse> RejectExpertSolutionAsync(RejectExpertSolutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RejectExpertSolutionWithOptionsAsync(request, runtime);
        }

        public RemoveApplicantResponse RemoveApplicantWithOptions(RemoveApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantId))
            {
                query["ApplicantId"] = request.ApplicantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveApplicant",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveApplicantResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveApplicantResponse> RemoveApplicantWithOptionsAsync(RemoveApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantId))
            {
                query["ApplicantId"] = request.ApplicantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveApplicant",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveApplicantResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveApplicantResponse RemoveApplicant(RemoveApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveApplicantWithOptions(request, runtime);
        }

        public async Task<RemoveApplicantResponse> RemoveApplicantAsync(RemoveApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveApplicantWithOptionsAsync(request, runtime);
        }

        public SaveSearchConditionResponse SaveSearchConditionWithOptions(SaveSearchConditionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConditionContent))
            {
                body["ConditionContent"] = request.ConditionContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                body["TagName"] = request.TagName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Umid))
            {
                body["Umid"] = request.Umid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSearchCondition",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSearchConditionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSearchConditionResponse> SaveSearchConditionWithOptionsAsync(SaveSearchConditionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConditionContent))
            {
                body["ConditionContent"] = request.ConditionContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                body["TagName"] = request.TagName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Umid))
            {
                body["Umid"] = request.Umid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSearchCondition",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSearchConditionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSearchConditionResponse SaveSearchCondition(SaveSearchConditionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSearchConditionWithOptions(request, runtime);
        }

        public async Task<SaveSearchConditionResponse> SaveSearchConditionAsync(SaveSearchConditionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSearchConditionWithOptionsAsync(request, runtime);
        }

        public SaveTemporaryApplicantResponse SaveTemporaryApplicantWithOptions(SaveTemporaryApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantId))
            {
                query["ApplicantId"] = request.ApplicantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLicenceOssKey))
            {
                query["BusinessLicenceOssKey"] = request.BusinessLicenceOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNumber))
            {
                query["CardNumber"] = request.CardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompleteApplicant))
            {
                query["CompleteApplicant"] = request.CompleteApplicant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddress))
            {
                query["ContactAddress"] = request.ContactAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCity))
            {
                query["ContactCity"] = request.ContactCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCounty))
            {
                query["ContactCounty"] = request.ContactCounty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactDistrict))
            {
                query["ContactDistrict"] = request.ContactDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                query["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactProvince))
            {
                query["ContactProvince"] = request.ContactProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactZipCode))
            {
                query["ContactZipCode"] = request.ContactZipCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EAddress))
            {
                query["EAddress"] = request.EAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EName))
            {
                query["EName"] = request.EName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardOssKey))
            {
                query["IdCardOssKey"] = request.IdCardOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeOssKey))
            {
                query["LegalNoticeOssKey"] = request.LegalNoticeOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoaOssKey))
            {
                query["LoaOssKey"] = request.LoaOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassportOssKey))
            {
                query["PassportOssKey"] = request.PassportOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Town))
            {
                query["Town"] = request.Town;
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
                Action = "SaveTemporaryApplicant",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTemporaryApplicantResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveTemporaryApplicantResponse> SaveTemporaryApplicantWithOptionsAsync(SaveTemporaryApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantId))
            {
                query["ApplicantId"] = request.ApplicantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLicenceOssKey))
            {
                query["BusinessLicenceOssKey"] = request.BusinessLicenceOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNumber))
            {
                query["CardNumber"] = request.CardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompleteApplicant))
            {
                query["CompleteApplicant"] = request.CompleteApplicant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddress))
            {
                query["ContactAddress"] = request.ContactAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCity))
            {
                query["ContactCity"] = request.ContactCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCounty))
            {
                query["ContactCounty"] = request.ContactCounty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactDistrict))
            {
                query["ContactDistrict"] = request.ContactDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                query["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactProvince))
            {
                query["ContactProvince"] = request.ContactProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactZipCode))
            {
                query["ContactZipCode"] = request.ContactZipCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EAddress))
            {
                query["EAddress"] = request.EAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EName))
            {
                query["EName"] = request.EName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardOssKey))
            {
                query["IdCardOssKey"] = request.IdCardOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeOssKey))
            {
                query["LegalNoticeOssKey"] = request.LegalNoticeOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoaOssKey))
            {
                query["LoaOssKey"] = request.LoaOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassportOssKey))
            {
                query["PassportOssKey"] = request.PassportOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Town))
            {
                query["Town"] = request.Town;
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
                Action = "SaveTemporaryApplicant",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTemporaryApplicantResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveTemporaryApplicantResponse SaveTemporaryApplicant(SaveTemporaryApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTemporaryApplicantWithOptions(request, runtime);
        }

        public async Task<SaveTemporaryApplicantResponse> SaveTemporaryApplicantAsync(SaveTemporaryApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTemporaryApplicantWithOptionsAsync(request, runtime);
        }

        public SearchItemsResponse SearchItemsWithOptions(SearchItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludedTags))
            {
                query["ExcludedTags"] = request.ExcludedTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludedUids))
            {
                query["ExcludedUids"] = request.ExcludedUids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeedsType))
            {
                query["FeedsType"] = request.FeedsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntCls))
            {
                query["IntCls"] = request.IntCls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                query["Keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mock))
            {
                query["Mock"] = request.Mock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PriceLeft))
            {
                query["PriceLeft"] = request.PriceLeft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PriceRight))
            {
                query["PriceRight"] = request.PriceRight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Products))
            {
                query["Products"] = request.Products;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterNumber))
            {
                query["RegisterNumber"] = request.RegisterNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkNameLength))
            {
                query["TrademarkNameLength"] = request.TrademarkNameLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkNameType))
            {
                query["TrademarkNameType"] = request.TrademarkNameType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UmId))
            {
                query["UmId"] = request.UmId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchItems",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchItemsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SearchItemsResponse> SearchItemsWithOptionsAsync(SearchItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludedTags))
            {
                query["ExcludedTags"] = request.ExcludedTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludedUids))
            {
                query["ExcludedUids"] = request.ExcludedUids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeedsType))
            {
                query["FeedsType"] = request.FeedsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntCls))
            {
                query["IntCls"] = request.IntCls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                query["Keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mock))
            {
                query["Mock"] = request.Mock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PriceLeft))
            {
                query["PriceLeft"] = request.PriceLeft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PriceRight))
            {
                query["PriceRight"] = request.PriceRight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Products))
            {
                query["Products"] = request.Products;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterNumber))
            {
                query["RegisterNumber"] = request.RegisterNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkNameLength))
            {
                query["TrademarkNameLength"] = request.TrademarkNameLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkNameType))
            {
                query["TrademarkNameType"] = request.TrademarkNameType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UmId))
            {
                query["UmId"] = request.UmId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchItems",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SearchItemsResponse SearchItems(SearchItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchItemsWithOptions(request, runtime);
        }

        public async Task<SearchItemsResponse> SearchItemsAsync(SearchItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchItemsWithOptionsAsync(request, runtime);
        }

        public SearchSimilarityResponse SearchSimilarityWithOptions(SearchSimilarityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchSimilarityShrinkRequest request = new SearchSimilarityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Classifications))
            {
                request.ClassificationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Classifications, "Classifications", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SimilarGroups))
            {
                request.SimilarGroupsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SimilarGroups, "SimilarGroups", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassificationsShrink))
            {
                query["Classifications"] = request.ClassificationsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameUriList))
            {
                query["NameUriList"] = request.NameUriList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["SearchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDetail))
            {
                query["ShowDetail"] = request.ShowDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimilarGroupsShrink))
            {
                query["SimilarGroups"] = request.SimilarGroupsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sorter))
            {
                query["Sorter"] = request.Sorter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Umid))
            {
                query["Umid"] = request.Umid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchSimilarity",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchSimilarityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SearchSimilarityResponse> SearchSimilarityWithOptionsAsync(SearchSimilarityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchSimilarityShrinkRequest request = new SearchSimilarityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Classifications))
            {
                request.ClassificationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Classifications, "Classifications", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SimilarGroups))
            {
                request.SimilarGroupsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SimilarGroups, "SimilarGroups", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassificationsShrink))
            {
                query["Classifications"] = request.ClassificationsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameUriList))
            {
                query["NameUriList"] = request.NameUriList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["SearchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDetail))
            {
                query["ShowDetail"] = request.ShowDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimilarGroupsShrink))
            {
                query["SimilarGroups"] = request.SimilarGroupsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sorter))
            {
                query["Sorter"] = request.Sorter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Umid))
            {
                query["Umid"] = request.Umid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchSimilarity",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchSimilarityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SearchSimilarityResponse SearchSimilarity(SearchSimilarityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchSimilarityWithOptions(request, runtime);
        }

        public async Task<SearchSimilarityResponse> SearchSimilarityAsync(SearchSimilarityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchSimilarityWithOptionsAsync(request, runtime);
        }

        public SearchSimilarityListResponse SearchSimilarityListWithOptions(SearchSimilarityListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchSimilarityListShrinkRequest request = new SearchSimilarityListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Classifications))
            {
                request.ClassificationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Classifications, "Classifications", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SimilarGroups))
            {
                request.SimilarGroupsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SimilarGroups, "SimilarGroups", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassificationsShrink))
            {
                query["Classifications"] = request.ClassificationsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimilarGroupsShrink))
            {
                query["SimilarGroups"] = request.SimilarGroupsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuccessSearchType))
            {
                query["SuccessSearchType"] = request.SuccessSearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Umid))
            {
                query["Umid"] = request.Umid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                query["Uri"] = request.Uri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchSimilarityList",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchSimilarityListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SearchSimilarityListResponse> SearchSimilarityListWithOptionsAsync(SearchSimilarityListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchSimilarityListShrinkRequest request = new SearchSimilarityListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Classifications))
            {
                request.ClassificationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Classifications, "Classifications", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SimilarGroups))
            {
                request.SimilarGroupsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SimilarGroups, "SimilarGroups", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassificationsShrink))
            {
                query["Classifications"] = request.ClassificationsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimilarGroupsShrink))
            {
                query["SimilarGroups"] = request.SimilarGroupsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuccessSearchType))
            {
                query["SuccessSearchType"] = request.SuccessSearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Umid))
            {
                query["Umid"] = request.Umid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                query["Uri"] = request.Uri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchSimilarityList",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchSimilarityListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SearchSimilarityListResponse SearchSimilarityList(SearchSimilarityListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchSimilarityListWithOptions(request, runtime);
        }

        public async Task<SearchSimilarityListResponse> SearchSimilarityListAsync(SearchSimilarityListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchSimilarityListWithOptionsAsync(request, runtime);
        }

        public SendMessageToUserResponse SendMessageToUserWithOptions(SendMessageToUserRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendMessageToUserShrinkRequest request = new SendMessageToUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TemplateData))
            {
                request.TemplateDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TemplateData, "TemplateData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverNickName))
            {
                query["ReceiverNickName"] = request.ReceiverNickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderNickName))
            {
                query["SenderNickName"] = request.SenderNickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateDataShrink))
            {
                query["TemplateData"] = request.TemplateDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendMessageToUser",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMessageToUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SendMessageToUserResponse> SendMessageToUserWithOptionsAsync(SendMessageToUserRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendMessageToUserShrinkRequest request = new SendMessageToUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TemplateData))
            {
                request.TemplateDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TemplateData, "TemplateData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverNickName))
            {
                query["ReceiverNickName"] = request.ReceiverNickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderNickName))
            {
                query["SenderNickName"] = request.SenderNickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateDataShrink))
            {
                query["TemplateData"] = request.TemplateDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendMessageToUser",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMessageToUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SendMessageToUserResponse SendMessageToUser(SendMessageToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendMessageToUserWithOptions(request, runtime);
        }

        public async Task<SendMessageToUserResponse> SendMessageToUserAsync(SendMessageToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendMessageToUserWithOptionsAsync(request, runtime);
        }

        /**
          * ***
          *
          * @param tmpReq SubmitSupplementRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitSupplementResponse
         */
        public SubmitSupplementResponse SubmitSupplementWithOptions(SubmitSupplementRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitSupplementShrinkRequest request = new SubmitSupplementShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserFiles))
            {
                request.UserFilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserFiles, "UserFiles", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplementId))
            {
                query["SupplementId"] = request.SupplementId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFilesShrink))
            {
                query["UserFiles"] = request.UserFilesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSupplement",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSupplementResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ***
          *
          * @param tmpReq SubmitSupplementRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitSupplementResponse
         */
        public async Task<SubmitSupplementResponse> SubmitSupplementWithOptionsAsync(SubmitSupplementRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitSupplementShrinkRequest request = new SubmitSupplementShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserFiles))
            {
                request.UserFilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserFiles, "UserFiles", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplementId))
            {
                query["SupplementId"] = request.SupplementId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFilesShrink))
            {
                query["UserFiles"] = request.UserFilesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSupplement",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSupplementResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ***
          *
          * @param request SubmitSupplementRequest
          * @return SubmitSupplementResponse
         */
        public SubmitSupplementResponse SubmitSupplement(SubmitSupplementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSupplementWithOptions(request, runtime);
        }

        /**
          * ***
          *
          * @param request SubmitSupplementRequest
          * @return SubmitSupplementResponse
         */
        public async Task<SubmitSupplementResponse> SubmitSupplementAsync(SubmitSupplementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSupplementWithOptionsAsync(request, runtime);
        }

        public UpdateApplicantResponse UpdateApplicantWithOptions(UpdateApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantId))
            {
                query["ApplicantId"] = request.ApplicantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantName))
            {
                query["ApplicantName"] = request.ApplicantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationOssKey))
            {
                query["AuthorizationOssKey"] = request.AuthorizationOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLicenceOssKey))
            {
                query["BusinessLicenceOssKey"] = request.BusinessLicenceOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNumber))
            {
                query["CardNumber"] = request.CardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddress))
            {
                query["ContactAddress"] = request.ContactAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCity))
            {
                query["ContactCity"] = request.ContactCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCounty))
            {
                query["ContactCounty"] = request.ContactCounty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactDistrict))
            {
                query["ContactDistrict"] = request.ContactDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                query["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactProvince))
            {
                query["ContactProvince"] = request.ContactProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactZipcode))
            {
                query["ContactZipcode"] = request.ContactZipcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EAddress))
            {
                query["EAddress"] = request.EAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EName))
            {
                query["EName"] = request.EName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardName))
            {
                query["IdCardName"] = request.IdCardName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardNumber))
            {
                query["IdCardNumber"] = request.IdCardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardOssKey))
            {
                query["IdCardOssKey"] = request.IdCardOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeOssKey))
            {
                query["LegalNoticeOssKey"] = request.LegalNoticeOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassportOssKey))
            {
                query["PassportOssKey"] = request.PassportOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicant",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicantResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateApplicantResponse> UpdateApplicantWithOptionsAsync(UpdateApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantId))
            {
                query["ApplicantId"] = request.ApplicantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantName))
            {
                query["ApplicantName"] = request.ApplicantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationOssKey))
            {
                query["AuthorizationOssKey"] = request.AuthorizationOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLicenceOssKey))
            {
                query["BusinessLicenceOssKey"] = request.BusinessLicenceOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNumber))
            {
                query["CardNumber"] = request.CardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddress))
            {
                query["ContactAddress"] = request.ContactAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCity))
            {
                query["ContactCity"] = request.ContactCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCounty))
            {
                query["ContactCounty"] = request.ContactCounty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactDistrict))
            {
                query["ContactDistrict"] = request.ContactDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                query["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactProvince))
            {
                query["ContactProvince"] = request.ContactProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactZipcode))
            {
                query["ContactZipcode"] = request.ContactZipcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EAddress))
            {
                query["EAddress"] = request.EAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EName))
            {
                query["EName"] = request.EName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardName))
            {
                query["IdCardName"] = request.IdCardName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardNumber))
            {
                query["IdCardNumber"] = request.IdCardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardOssKey))
            {
                query["IdCardOssKey"] = request.IdCardOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeOssKey))
            {
                query["LegalNoticeOssKey"] = request.LegalNoticeOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassportOssKey))
            {
                query["PassportOssKey"] = request.PassportOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicant",
                Version = "2019-09-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicantResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateApplicantResponse UpdateApplicant(UpdateApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateApplicantWithOptions(request, runtime);
        }

        public async Task<UpdateApplicantResponse> UpdateApplicantAsync(UpdateApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateApplicantWithOptionsAsync(request, runtime);
        }

    }
}
