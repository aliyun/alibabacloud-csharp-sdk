// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AirticketOpen20230117.Models;

namespace AlibabaCloud.SDK.AirticketOpen20230117
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("airticketopen", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 账号资金流水
         *
         * @param request AccountFlowListRequest
         * @param headers AccountFlowListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AccountFlowListResponse
         */
        public AccountFlowListResponse AccountFlowListWithOptions(AccountFlowListRequest request, AccountFlowListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DayNum))
            {
                query["day_num"] = request.DayNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["page_index"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UtcBeginTime))
            {
                query["utc_begin_time"] = request.UtcBeginTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AccountFlowList",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/account/flow-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AccountFlowListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 账号资金流水
         *
         * @param request AccountFlowListRequest
         * @param headers AccountFlowListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AccountFlowListResponse
         */
        public async Task<AccountFlowListResponse> AccountFlowListWithOptionsAsync(AccountFlowListRequest request, AccountFlowListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DayNum))
            {
                query["day_num"] = request.DayNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["page_index"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UtcBeginTime))
            {
                query["utc_begin_time"] = request.UtcBeginTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AccountFlowList",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/account/flow-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AccountFlowListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 账号资金流水
         *
         * @param request AccountFlowListRequest
         * @return AccountFlowListResponse
         */
        public AccountFlowListResponse AccountFlowList(AccountFlowListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AccountFlowListHeaders headers = new AccountFlowListHeaders();
            return AccountFlowListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 账号资金流水
         *
         * @param request AccountFlowListRequest
         * @return AccountFlowListResponse
         */
        public async Task<AccountFlowListResponse> AccountFlowListAsync(AccountFlowListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AccountFlowListHeaders headers = new AccountFlowListHeaders();
            return await AccountFlowListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 辅营-推荐
         *
         * @param request AncillarySuggestRequest
         * @param headers AncillarySuggestHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AncillarySuggestResponse
         */
        public AncillarySuggestResponse AncillarySuggestWithOptions(AncillarySuggestRequest request, AncillarySuggestHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionId))
            {
                body["solution_id"] = request.SolutionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AncillarySuggest",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/ancillary/action-suggest",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AncillarySuggestResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 辅营-推荐
         *
         * @param request AncillarySuggestRequest
         * @param headers AncillarySuggestHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AncillarySuggestResponse
         */
        public async Task<AncillarySuggestResponse> AncillarySuggestWithOptionsAsync(AncillarySuggestRequest request, AncillarySuggestHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionId))
            {
                body["solution_id"] = request.SolutionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AncillarySuggest",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/ancillary/action-suggest",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AncillarySuggestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 辅营-推荐
         *
         * @param request AncillarySuggestRequest
         * @return AncillarySuggestResponse
         */
        public AncillarySuggestResponse AncillarySuggest(AncillarySuggestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AncillarySuggestHeaders headers = new AncillarySuggestHeaders();
            return AncillarySuggestWithOptions(request, headers, runtime);
        }

        /**
         * @summary 辅营-推荐
         *
         * @param request AncillarySuggestRequest
         * @return AncillarySuggestResponse
         */
        public async Task<AncillarySuggestResponse> AncillarySuggestAsync(AncillarySuggestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AncillarySuggestHeaders headers = new AncillarySuggestHeaders();
            return await AncillarySuggestWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 交易-预定
         *
         * @param tmpReq BookRequest
         * @param headers BookHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BookResponse
         */
        public BookResponse BookWithOptions(BookRequest tmpReq, BookHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BookShrinkRequest request = new BookShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contact))
            {
                request.ContactShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contact, "contact", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PassengerAncillaryPurchaseMapList))
            {
                request.PassengerAncillaryPurchaseMapListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PassengerAncillaryPurchaseMapList, "passenger_ancillary_purchase_map_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PassengerList))
            {
                request.PassengerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PassengerList, "passenger_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactShrink))
            {
                body["contact"] = request.ContactShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderNum))
            {
                body["out_order_num"] = request.OutOrderNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassengerAncillaryPurchaseMapListShrink))
            {
                body["passenger_ancillary_purchase_map_list"] = request.PassengerAncillaryPurchaseMapListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassengerListShrink))
            {
                body["passenger_list"] = request.PassengerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionId))
            {
                body["solution_id"] = request.SolutionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Book",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/trade/action-book",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BookResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 交易-预定
         *
         * @param tmpReq BookRequest
         * @param headers BookHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BookResponse
         */
        public async Task<BookResponse> BookWithOptionsAsync(BookRequest tmpReq, BookHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BookShrinkRequest request = new BookShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contact))
            {
                request.ContactShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contact, "contact", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PassengerAncillaryPurchaseMapList))
            {
                request.PassengerAncillaryPurchaseMapListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PassengerAncillaryPurchaseMapList, "passenger_ancillary_purchase_map_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PassengerList))
            {
                request.PassengerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PassengerList, "passenger_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactShrink))
            {
                body["contact"] = request.ContactShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderNum))
            {
                body["out_order_num"] = request.OutOrderNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassengerAncillaryPurchaseMapListShrink))
            {
                body["passenger_ancillary_purchase_map_list"] = request.PassengerAncillaryPurchaseMapListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassengerListShrink))
            {
                body["passenger_list"] = request.PassengerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionId))
            {
                body["solution_id"] = request.SolutionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Book",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/trade/action-book",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 交易-预定
         *
         * @param request BookRequest
         * @return BookResponse
         */
        public BookResponse Book(BookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BookHeaders headers = new BookHeaders();
            return BookWithOptions(request, headers, runtime);
        }

        /**
         * @summary 交易-预定
         *
         * @param request BookRequest
         * @return BookResponse
         */
        public async Task<BookResponse> BookAsync(BookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BookHeaders headers = new BookHeaders();
            return await BookWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 交易-未支付取消
         *
         * @param request CancelRequest
         * @param headers CancelHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelResponse
         */
        public CancelResponse CancelWithOptions(CancelRequest request, CancelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNum))
            {
                body["order_num"] = request.OrderNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Cancel",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/trade/action-cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 交易-未支付取消
         *
         * @param request CancelRequest
         * @param headers CancelHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelResponse
         */
        public async Task<CancelResponse> CancelWithOptionsAsync(CancelRequest request, CancelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNum))
            {
                body["order_num"] = request.OrderNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Cancel",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/trade/action-cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 交易-未支付取消
         *
         * @param request CancelRequest
         * @return CancelResponse
         */
        public CancelResponse Cancel(CancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelHeaders headers = new CancelHeaders();
            return CancelWithOptions(request, headers, runtime);
        }

        /**
         * @summary 交易-未支付取消
         *
         * @param request CancelRequest
         * @return CancelResponse
         */
        public async Task<CancelResponse> CancelAsync(CancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelHeaders headers = new CancelHeaders();
            return await CancelWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 改签-Apply
         *
         * @param tmpReq ChangeApplyRequest
         * @param headers ChangeApplyHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeApplyResponse
         */
        public ChangeApplyResponse ChangeApplyWithOptions(ChangeApplyRequest tmpReq, ChangeApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ChangeApplyShrinkRequest request = new ChangeApplyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChangePassengerList))
            {
                request.ChangePassengerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChangePassengerList, "change_passenger_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChangedJourneys))
            {
                request.ChangedJourneysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChangedJourneys, "changed_journeys", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contact))
            {
                request.ContactShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contact, "contact", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangePassengerListShrink))
            {
                body["change_passenger_list"] = request.ChangePassengerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangedJourneysShrink))
            {
                body["changed_journeys"] = request.ChangedJourneysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactShrink))
            {
                body["contact"] = request.ContactShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNum))
            {
                body["order_num"] = request.OrderNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeApply",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/change/action-apply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeApplyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 改签-Apply
         *
         * @param tmpReq ChangeApplyRequest
         * @param headers ChangeApplyHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeApplyResponse
         */
        public async Task<ChangeApplyResponse> ChangeApplyWithOptionsAsync(ChangeApplyRequest tmpReq, ChangeApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ChangeApplyShrinkRequest request = new ChangeApplyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChangePassengerList))
            {
                request.ChangePassengerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChangePassengerList, "change_passenger_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChangedJourneys))
            {
                request.ChangedJourneysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChangedJourneys, "changed_journeys", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contact))
            {
                request.ContactShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contact, "contact", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangePassengerListShrink))
            {
                body["change_passenger_list"] = request.ChangePassengerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangedJourneysShrink))
            {
                body["changed_journeys"] = request.ChangedJourneysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactShrink))
            {
                body["contact"] = request.ContactShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNum))
            {
                body["order_num"] = request.OrderNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeApply",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/change/action-apply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeApplyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 改签-Apply
         *
         * @param request ChangeApplyRequest
         * @return ChangeApplyResponse
         */
        public ChangeApplyResponse ChangeApply(ChangeApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeApplyHeaders headers = new ChangeApplyHeaders();
            return ChangeApplyWithOptions(request, headers, runtime);
        }

        /**
         * @summary 改签-Apply
         *
         * @param request ChangeApplyRequest
         * @return ChangeApplyResponse
         */
        public async Task<ChangeApplyResponse> ChangeApplyAsync(ChangeApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeApplyHeaders headers = new ChangeApplyHeaders();
            return await ChangeApplyWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 改签-取消
         *
         * @param request ChangeCancelRequest
         * @param headers ChangeCancelHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeCancelResponse
         */
        public ChangeCancelResponse ChangeCancelWithOptions(ChangeCancelRequest request, ChangeCancelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderNum))
            {
                body["change_order_num"] = request.ChangeOrderNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeCancel",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/change/action-cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeCancelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 改签-取消
         *
         * @param request ChangeCancelRequest
         * @param headers ChangeCancelHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeCancelResponse
         */
        public async Task<ChangeCancelResponse> ChangeCancelWithOptionsAsync(ChangeCancelRequest request, ChangeCancelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderNum))
            {
                body["change_order_num"] = request.ChangeOrderNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeCancel",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/change/action-cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeCancelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 改签-取消
         *
         * @param request ChangeCancelRequest
         * @return ChangeCancelResponse
         */
        public ChangeCancelResponse ChangeCancel(ChangeCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeCancelHeaders headers = new ChangeCancelHeaders();
            return ChangeCancelWithOptions(request, headers, runtime);
        }

        /**
         * @summary 改签-取消
         *
         * @param request ChangeCancelRequest
         * @return ChangeCancelResponse
         */
        public async Task<ChangeCancelResponse> ChangeCancelAsync(ChangeCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeCancelHeaders headers = new ChangeCancelHeaders();
            return await ChangeCancelWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 改签-确认
         *
         * @param request ChangeConfirmRequest
         * @param headers ChangeConfirmHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeConfirmResponse
         */
        public ChangeConfirmResponse ChangeConfirmWithOptions(ChangeConfirmRequest request, ChangeConfirmHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderNum))
            {
                body["change_order_num"] = request.ChangeOrderNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeConfirm",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/change/action-confirm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeConfirmResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 改签-确认
         *
         * @param request ChangeConfirmRequest
         * @param headers ChangeConfirmHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeConfirmResponse
         */
        public async Task<ChangeConfirmResponse> ChangeConfirmWithOptionsAsync(ChangeConfirmRequest request, ChangeConfirmHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderNum))
            {
                body["change_order_num"] = request.ChangeOrderNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeConfirm",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/change/action-confirm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeConfirmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 改签-确认
         *
         * @param request ChangeConfirmRequest
         * @return ChangeConfirmResponse
         */
        public ChangeConfirmResponse ChangeConfirm(ChangeConfirmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeConfirmHeaders headers = new ChangeConfirmHeaders();
            return ChangeConfirmWithOptions(request, headers, runtime);
        }

        /**
         * @summary 改签-确认
         *
         * @param request ChangeConfirmRequest
         * @return ChangeConfirmResponse
         */
        public async Task<ChangeConfirmResponse> ChangeConfirmAsync(ChangeConfirmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeConfirmHeaders headers = new ChangeConfirmHeaders();
            return await ChangeConfirmWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 改签-Detail
         *
         * @param request ChangeDetailRequest
         * @param headers ChangeDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeDetailResponse
         */
        public ChangeDetailResponse ChangeDetailWithOptions(ChangeDetailRequest request, ChangeDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderNum))
            {
                query["change_order_num"] = request.ChangeOrderNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeDetail",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/change/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 改签-Detail
         *
         * @param request ChangeDetailRequest
         * @param headers ChangeDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeDetailResponse
         */
        public async Task<ChangeDetailResponse> ChangeDetailWithOptionsAsync(ChangeDetailRequest request, ChangeDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderNum))
            {
                query["change_order_num"] = request.ChangeOrderNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeDetail",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/change/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 改签-Detail
         *
         * @param request ChangeDetailRequest
         * @return ChangeDetailResponse
         */
        public ChangeDetailResponse ChangeDetail(ChangeDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeDetailHeaders headers = new ChangeDetailHeaders();
            return ChangeDetailWithOptions(request, headers, runtime);
        }

        /**
         * @summary 改签-Detail
         *
         * @param request ChangeDetailRequest
         * @return ChangeDetailResponse
         */
        public async Task<ChangeDetailResponse> ChangeDetailAsync(ChangeDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeDetailHeaders headers = new ChangeDetailHeaders();
            return await ChangeDetailWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 改签单列表-关于买家账号
         *
         * @param request ChangeDetailListOfBuyerRequest
         * @param headers ChangeDetailListOfBuyerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeDetailListOfBuyerResponse
         */
        public ChangeDetailListOfBuyerResponse ChangeDetailListOfBuyerWithOptions(ChangeDetailListOfBuyerRequest request, ChangeDetailListOfBuyerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["page_index"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UtcCreateBegin))
            {
                query["utc_create_begin"] = request.UtcCreateBegin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UtcCreateEnd))
            {
                query["utc_create_end"] = request.UtcCreateEnd;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeDetailListOfBuyer",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/change/buyer/detail-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeDetailListOfBuyerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 改签单列表-关于买家账号
         *
         * @param request ChangeDetailListOfBuyerRequest
         * @param headers ChangeDetailListOfBuyerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeDetailListOfBuyerResponse
         */
        public async Task<ChangeDetailListOfBuyerResponse> ChangeDetailListOfBuyerWithOptionsAsync(ChangeDetailListOfBuyerRequest request, ChangeDetailListOfBuyerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["page_index"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UtcCreateBegin))
            {
                query["utc_create_begin"] = request.UtcCreateBegin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UtcCreateEnd))
            {
                query["utc_create_end"] = request.UtcCreateEnd;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeDetailListOfBuyer",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/change/buyer/detail-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeDetailListOfBuyerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 改签单列表-关于买家账号
         *
         * @param request ChangeDetailListOfBuyerRequest
         * @return ChangeDetailListOfBuyerResponse
         */
        public ChangeDetailListOfBuyerResponse ChangeDetailListOfBuyer(ChangeDetailListOfBuyerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeDetailListOfBuyerHeaders headers = new ChangeDetailListOfBuyerHeaders();
            return ChangeDetailListOfBuyerWithOptions(request, headers, runtime);
        }

        /**
         * @summary 改签单列表-关于买家账号
         *
         * @param request ChangeDetailListOfBuyerRequest
         * @return ChangeDetailListOfBuyerResponse
         */
        public async Task<ChangeDetailListOfBuyerResponse> ChangeDetailListOfBuyerAsync(ChangeDetailListOfBuyerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeDetailListOfBuyerHeaders headers = new ChangeDetailListOfBuyerHeaders();
            return await ChangeDetailListOfBuyerWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 改签单列表-关于正向订单
         *
         * @param request ChangeDetailListOfOrderNumRequest
         * @param headers ChangeDetailListOfOrderNumHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeDetailListOfOrderNumResponse
         */
        public ChangeDetailListOfOrderNumResponse ChangeDetailListOfOrderNumWithOptions(ChangeDetailListOfOrderNumRequest request, ChangeDetailListOfOrderNumHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNum))
            {
                query["order_num"] = request.OrderNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["page_index"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeDetailListOfOrderNum",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/change/order-num/detail-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeDetailListOfOrderNumResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 改签单列表-关于正向订单
         *
         * @param request ChangeDetailListOfOrderNumRequest
         * @param headers ChangeDetailListOfOrderNumHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeDetailListOfOrderNumResponse
         */
        public async Task<ChangeDetailListOfOrderNumResponse> ChangeDetailListOfOrderNumWithOptionsAsync(ChangeDetailListOfOrderNumRequest request, ChangeDetailListOfOrderNumHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNum))
            {
                query["order_num"] = request.OrderNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["page_index"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeDetailListOfOrderNum",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/change/order-num/detail-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeDetailListOfOrderNumResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 改签单列表-关于正向订单
         *
         * @param request ChangeDetailListOfOrderNumRequest
         * @return ChangeDetailListOfOrderNumResponse
         */
        public ChangeDetailListOfOrderNumResponse ChangeDetailListOfOrderNum(ChangeDetailListOfOrderNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeDetailListOfOrderNumHeaders headers = new ChangeDetailListOfOrderNumHeaders();
            return ChangeDetailListOfOrderNumWithOptions(request, headers, runtime);
        }

        /**
         * @summary 改签单列表-关于正向订单
         *
         * @param request ChangeDetailListOfOrderNumRequest
         * @return ChangeDetailListOfOrderNumResponse
         */
        public async Task<ChangeDetailListOfOrderNumResponse> ChangeDetailListOfOrderNumAsync(ChangeDetailListOfOrderNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeDetailListOfOrderNumHeaders headers = new ChangeDetailListOfOrderNumHeaders();
            return await ChangeDetailListOfOrderNumWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 搜索-Enrich
         *
         * @param tmpReq EnrichRequest
         * @param headers EnrichHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnrichResponse
         */
        public EnrichResponse EnrichWithOptions(EnrichRequest tmpReq, EnrichHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EnrichShrinkRequest request = new EnrichShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JourneyParamList))
            {
                request.JourneyParamListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JourneyParamList, "journey_param_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Adults))
            {
                body["adults"] = request.Adults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinClass))
            {
                body["cabin_class"] = request.CabinClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Children))
            {
                body["children"] = request.Children;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Infants))
            {
                body["infants"] = request.Infants;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JourneyParamListShrink))
            {
                body["journey_param_list"] = request.JourneyParamListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionId))
            {
                body["solution_id"] = request.SolutionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Enrich",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/trade/action-enrich",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnrichResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 搜索-Enrich
         *
         * @param tmpReq EnrichRequest
         * @param headers EnrichHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnrichResponse
         */
        public async Task<EnrichResponse> EnrichWithOptionsAsync(EnrichRequest tmpReq, EnrichHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EnrichShrinkRequest request = new EnrichShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JourneyParamList))
            {
                request.JourneyParamListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JourneyParamList, "journey_param_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Adults))
            {
                body["adults"] = request.Adults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinClass))
            {
                body["cabin_class"] = request.CabinClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Children))
            {
                body["children"] = request.Children;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Infants))
            {
                body["infants"] = request.Infants;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JourneyParamListShrink))
            {
                body["journey_param_list"] = request.JourneyParamListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionId))
            {
                body["solution_id"] = request.SolutionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Enrich",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/trade/action-enrich",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnrichResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 搜索-Enrich
         *
         * @param request EnrichRequest
         * @return EnrichResponse
         */
        public EnrichResponse Enrich(EnrichRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EnrichHeaders headers = new EnrichHeaders();
            return EnrichWithOptions(request, headers, runtime);
        }

        /**
         * @summary 搜索-Enrich
         *
         * @param request EnrichRequest
         * @return EnrichResponse
         */
        public async Task<EnrichResponse> EnrichAsync(EnrichRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EnrichHeaders headers = new EnrichHeaders();
            return await EnrichWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 附件上传
         *
         * @param request FileUploadRequest
         * @param headers FileUploadHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileUploadResponse
         */
        public FileUploadResponse FileUploadWithOptions(FileUploadRequest request, FileUploadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileContent))
            {
                body["file_content"] = request.FileContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNum))
            {
                body["order_num"] = request.OrderNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FileUpload",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/attachment/action-upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileUploadResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 附件上传
         *
         * @param request FileUploadRequest
         * @param headers FileUploadHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileUploadResponse
         */
        public async Task<FileUploadResponse> FileUploadWithOptionsAsync(FileUploadRequest request, FileUploadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileContent))
            {
                body["file_content"] = request.FileContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNum))
            {
                body["order_num"] = request.OrderNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FileUpload",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/attachment/action-upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileUploadResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 附件上传
         *
         * @param request FileUploadRequest
         * @return FileUploadResponse
         */
        public FileUploadResponse FileUpload(FileUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileUploadHeaders headers = new FileUploadHeaders();
            return FileUploadWithOptions(request, headers, runtime);
        }

        /**
         * @summary 附件上传
         *
         * @param request FileUploadRequest
         * @return FileUploadResponse
         */
        public async Task<FileUploadResponse> FileUploadAsync(FileUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileUploadHeaders headers = new FileUploadHeaders();
            return await FileUploadWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 航变信息-关于订单
         *
         * @param request FlightChangeOfOrderRequest
         * @param headers FlightChangeOfOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FlightChangeOfOrderResponse
         */
        public FlightChangeOfOrderResponse FlightChangeOfOrderWithOptions(FlightChangeOfOrderRequest request, FlightChangeOfOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNum))
            {
                query["order_num"] = request.OrderNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightChangeOfOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/flightchange/of-order",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightChangeOfOrderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 航变信息-关于订单
         *
         * @param request FlightChangeOfOrderRequest
         * @param headers FlightChangeOfOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FlightChangeOfOrderResponse
         */
        public async Task<FlightChangeOfOrderResponse> FlightChangeOfOrderWithOptionsAsync(FlightChangeOfOrderRequest request, FlightChangeOfOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNum))
            {
                query["order_num"] = request.OrderNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlightChangeOfOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/flightchange/of-order",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlightChangeOfOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 航变信息-关于订单
         *
         * @param request FlightChangeOfOrderRequest
         * @return FlightChangeOfOrderResponse
         */
        public FlightChangeOfOrderResponse FlightChangeOfOrder(FlightChangeOfOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightChangeOfOrderHeaders headers = new FlightChangeOfOrderHeaders();
            return FlightChangeOfOrderWithOptions(request, headers, runtime);
        }

        /**
         * @summary 航变信息-关于订单
         *
         * @param request FlightChangeOfOrderRequest
         * @return FlightChangeOfOrderResponse
         */
        public async Task<FlightChangeOfOrderResponse> FlightChangeOfOrderAsync(FlightChangeOfOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightChangeOfOrderHeaders headers = new FlightChangeOfOrderHeaders();
            return await FlightChangeOfOrderWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取token
         *
         * @param request GetTokenRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTokenResponse
         */
        public GetTokenResponse GetTokenWithOptions(GetTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["app_key"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecret))
            {
                query["app_secret"] = request.AppSecret;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetToken",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/token",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取token
         *
         * @param request GetTokenRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTokenResponse
         */
        public async Task<GetTokenResponse> GetTokenWithOptionsAsync(GetTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["app_key"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecret))
            {
                query["app_secret"] = request.AppSecret;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetToken",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/token",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取token
         *
         * @param request GetTokenRequest
         * @return GetTokenResponse
         */
        public GetTokenResponse GetToken(GetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTokenWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取token
         *
         * @param request GetTokenRequest
         * @return GetTokenResponse
         */
        public async Task<GetTokenResponse> GetTokenAsync(GetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTokenWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 航程行李直挂
         *
         * @param tmpReq LuggageDirectRequest
         * @param headers LuggageDirectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return LuggageDirectResponse
         */
        public LuggageDirectResponse LuggageDirectWithOptions(LuggageDirectRequest tmpReq, LuggageDirectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            LuggageDirectShrinkRequest request = new LuggageDirectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FlightSegmentParamList))
            {
                request.FlightSegmentParamListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FlightSegmentParamList, "flight_segment_param_list", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlightSegmentParamListShrink))
            {
                query["flight_segment_param_list"] = request.FlightSegmentParamListShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LuggageDirect",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/flight-data/luggage-direct",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<LuggageDirectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 航程行李直挂
         *
         * @param tmpReq LuggageDirectRequest
         * @param headers LuggageDirectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return LuggageDirectResponse
         */
        public async Task<LuggageDirectResponse> LuggageDirectWithOptionsAsync(LuggageDirectRequest tmpReq, LuggageDirectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            LuggageDirectShrinkRequest request = new LuggageDirectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FlightSegmentParamList))
            {
                request.FlightSegmentParamListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FlightSegmentParamList, "flight_segment_param_list", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlightSegmentParamListShrink))
            {
                query["flight_segment_param_list"] = request.FlightSegmentParamListShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LuggageDirect",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/flight-data/luggage-direct",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<LuggageDirectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 航程行李直挂
         *
         * @param request LuggageDirectRequest
         * @return LuggageDirectResponse
         */
        public LuggageDirectResponse LuggageDirect(LuggageDirectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LuggageDirectHeaders headers = new LuggageDirectHeaders();
            return LuggageDirectWithOptions(request, headers, runtime);
        }

        /**
         * @summary 航程行李直挂
         *
         * @param request LuggageDirectRequest
         * @return LuggageDirectResponse
         */
        public async Task<LuggageDirectResponse> LuggageDirectAsync(LuggageDirectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LuggageDirectHeaders headers = new LuggageDirectHeaders();
            return await LuggageDirectWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 交易-订单详情
         *
         * @param request OrderDetailRequest
         * @param headers OrderDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return OrderDetailResponse
         */
        public OrderDetailResponse OrderDetailWithOptions(OrderDetailRequest request, OrderDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNum))
            {
                query["order_num"] = request.OrderNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderNum))
            {
                query["out_order_num"] = request.OutOrderNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OrderDetail",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/trade/order-detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OrderDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 交易-订单详情
         *
         * @param request OrderDetailRequest
         * @param headers OrderDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return OrderDetailResponse
         */
        public async Task<OrderDetailResponse> OrderDetailWithOptionsAsync(OrderDetailRequest request, OrderDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNum))
            {
                query["order_num"] = request.OrderNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderNum))
            {
                query["out_order_num"] = request.OutOrderNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OrderDetail",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/trade/order-detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OrderDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 交易-订单详情
         *
         * @param request OrderDetailRequest
         * @return OrderDetailResponse
         */
        public OrderDetailResponse OrderDetail(OrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrderDetailHeaders headers = new OrderDetailHeaders();
            return OrderDetailWithOptions(request, headers, runtime);
        }

        /**
         * @summary 交易-订单详情
         *
         * @param request OrderDetailRequest
         * @return OrderDetailResponse
         */
        public async Task<OrderDetailResponse> OrderDetailAsync(OrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrderDetailHeaders headers = new OrderDetailHeaders();
            return await OrderDetailWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 交易-订单列表
         *
         * @param request OrderListRequest
         * @param headers OrderListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return OrderListResponse
         */
        public OrderListResponse OrderListWithOptions(OrderListRequest request, OrderListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BookTimeEnd))
            {
                query["book_time_end"] = request.BookTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BookTimeStart))
            {
                query["book_time_start"] = request.BookTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["page_index"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OrderList",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/trade/order-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OrderListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 交易-订单列表
         *
         * @param request OrderListRequest
         * @param headers OrderListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return OrderListResponse
         */
        public async Task<OrderListResponse> OrderListWithOptionsAsync(OrderListRequest request, OrderListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BookTimeEnd))
            {
                query["book_time_end"] = request.BookTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BookTimeStart))
            {
                query["book_time_start"] = request.BookTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["page_index"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OrderList",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/trade/order-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OrderListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 交易-订单列表
         *
         * @param request OrderListRequest
         * @return OrderListResponse
         */
        public OrderListResponse OrderList(OrderListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrderListHeaders headers = new OrderListHeaders();
            return OrderListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 交易-订单列表
         *
         * @param request OrderListRequest
         * @return OrderListResponse
         */
        public async Task<OrderListResponse> OrderListAsync(OrderListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrderListHeaders headers = new OrderListHeaders();
            return await OrderListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Pricing
         *
         * @param request PricingRequest
         * @param headers PricingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PricingResponse
         */
        public PricingResponse PricingWithOptions(PricingRequest request, PricingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionId))
            {
                body["solution_id"] = request.SolutionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Pricing",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/trade/action-pricing",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PricingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Pricing
         *
         * @param request PricingRequest
         * @param headers PricingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PricingResponse
         */
        public async Task<PricingResponse> PricingWithOptionsAsync(PricingRequest request, PricingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionId))
            {
                body["solution_id"] = request.SolutionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Pricing",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/trade/action-pricing",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PricingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Pricing
         *
         * @param request PricingRequest
         * @return PricingResponse
         */
        public PricingResponse Pricing(PricingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PricingHeaders headers = new PricingHeaders();
            return PricingWithOptions(request, headers, runtime);
        }

        /**
         * @summary Pricing
         *
         * @param request PricingRequest
         * @return PricingResponse
         */
        public async Task<PricingResponse> PricingAsync(PricingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PricingHeaders headers = new PricingHeaders();
            return await PricingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 退票-申请
         *
         * @param tmpReq RefundApplyRequest
         * @param headers RefundApplyHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefundApplyResponse
         */
        public RefundApplyResponse RefundApplyWithOptions(RefundApplyRequest tmpReq, RefundApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RefundApplyShrinkRequest request = new RefundApplyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RefundJourneys))
            {
                request.RefundJourneysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RefundJourneys, "refund_journeys", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RefundPassengerList))
            {
                request.RefundPassengerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RefundPassengerList, "refund_passenger_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RefundType))
            {
                request.RefundTypeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RefundType, "refund_type", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNum))
            {
                body["order_num"] = request.OrderNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundJourneysShrink))
            {
                body["refund_journeys"] = request.RefundJourneysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundPassengerListShrink))
            {
                body["refund_passenger_list"] = request.RefundPassengerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundTypeShrink))
            {
                body["refund_type"] = request.RefundTypeShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefundApply",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/refund/action-apply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefundApplyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 退票-申请
         *
         * @param tmpReq RefundApplyRequest
         * @param headers RefundApplyHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefundApplyResponse
         */
        public async Task<RefundApplyResponse> RefundApplyWithOptionsAsync(RefundApplyRequest tmpReq, RefundApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RefundApplyShrinkRequest request = new RefundApplyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RefundJourneys))
            {
                request.RefundJourneysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RefundJourneys, "refund_journeys", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RefundPassengerList))
            {
                request.RefundPassengerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RefundPassengerList, "refund_passenger_list", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RefundType))
            {
                request.RefundTypeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RefundType, "refund_type", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNum))
            {
                body["order_num"] = request.OrderNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundJourneysShrink))
            {
                body["refund_journeys"] = request.RefundJourneysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundPassengerListShrink))
            {
                body["refund_passenger_list"] = request.RefundPassengerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundTypeShrink))
            {
                body["refund_type"] = request.RefundTypeShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefundApply",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/refund/action-apply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefundApplyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 退票-申请
         *
         * @param request RefundApplyRequest
         * @return RefundApplyResponse
         */
        public RefundApplyResponse RefundApply(RefundApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RefundApplyHeaders headers = new RefundApplyHeaders();
            return RefundApplyWithOptions(request, headers, runtime);
        }

        /**
         * @summary 退票-申请
         *
         * @param request RefundApplyRequest
         * @return RefundApplyResponse
         */
        public async Task<RefundApplyResponse> RefundApplyAsync(RefundApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RefundApplyHeaders headers = new RefundApplyHeaders();
            return await RefundApplyWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 退票-Detail
         *
         * @param request RefundDetailRequest
         * @param headers RefundDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefundDetailResponse
         */
        public RefundDetailResponse RefundDetailWithOptions(RefundDetailRequest request, RefundDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundOrderNum))
            {
                query["refund_order_num"] = request.RefundOrderNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefundDetail",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/refund/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefundDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 退票-Detail
         *
         * @param request RefundDetailRequest
         * @param headers RefundDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefundDetailResponse
         */
        public async Task<RefundDetailResponse> RefundDetailWithOptionsAsync(RefundDetailRequest request, RefundDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundOrderNum))
            {
                query["refund_order_num"] = request.RefundOrderNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefundDetail",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/refund/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefundDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 退票-Detail
         *
         * @param request RefundDetailRequest
         * @return RefundDetailResponse
         */
        public RefundDetailResponse RefundDetail(RefundDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RefundDetailHeaders headers = new RefundDetailHeaders();
            return RefundDetailWithOptions(request, headers, runtime);
        }

        /**
         * @summary 退票-Detail
         *
         * @param request RefundDetailRequest
         * @return RefundDetailResponse
         */
        public async Task<RefundDetailResponse> RefundDetailAsync(RefundDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RefundDetailHeaders headers = new RefundDetailHeaders();
            return await RefundDetailWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 退票-DetailList
         *
         * @param request RefundDetailListRequest
         * @param headers RefundDetailListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefundDetailListResponse
         */
        public RefundDetailListResponse RefundDetailListWithOptions(RefundDetailListRequest request, RefundDetailListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNum))
            {
                query["order_num"] = request.OrderNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["page_index"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundCreateBeginTime))
            {
                query["refund_create_begin_time"] = request.RefundCreateBeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundCreateEndTime))
            {
                query["refund_create_end_time"] = request.RefundCreateEndTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefundDetailList",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/refund/detail-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefundDetailListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 退票-DetailList
         *
         * @param request RefundDetailListRequest
         * @param headers RefundDetailListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefundDetailListResponse
         */
        public async Task<RefundDetailListResponse> RefundDetailListWithOptionsAsync(RefundDetailListRequest request, RefundDetailListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNum))
            {
                query["order_num"] = request.OrderNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["page_index"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundCreateBeginTime))
            {
                query["refund_create_begin_time"] = request.RefundCreateBeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundCreateEndTime))
            {
                query["refund_create_end_time"] = request.RefundCreateEndTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefundDetailList",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/refund/detail-list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefundDetailListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 退票-DetailList
         *
         * @param request RefundDetailListRequest
         * @return RefundDetailListResponse
         */
        public RefundDetailListResponse RefundDetailList(RefundDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RefundDetailListHeaders headers = new RefundDetailListHeaders();
            return RefundDetailListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 退票-DetailList
         *
         * @param request RefundDetailListRequest
         * @return RefundDetailListResponse
         */
        public async Task<RefundDetailListResponse> RefundDetailListAsync(RefundDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RefundDetailListHeaders headers = new RefundDetailListHeaders();
            return await RefundDetailListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 搜索
         *
         * @param tmpReq SearchRequest
         * @param headers SearchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchResponse
         */
        public SearchResponse SearchWithOptions(SearchRequest tmpReq, SearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchShrinkRequest request = new SearchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AirLegs))
            {
                request.AirLegsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AirLegs, "air_legs", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchControlOptions))
            {
                request.SearchControlOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchControlOptions, "search_control_options", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Adults))
            {
                body["adults"] = request.Adults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirLegsShrink))
            {
                body["air_legs"] = request.AirLegsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinClass))
            {
                body["cabin_class"] = request.CabinClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Children))
            {
                body["children"] = request.Children;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Infants))
            {
                body["infants"] = request.Infants;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchControlOptionsShrink))
            {
                body["search_control_options"] = request.SearchControlOptionsShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Search",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/trade/action-search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 搜索
         *
         * @param tmpReq SearchRequest
         * @param headers SearchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchResponse
         */
        public async Task<SearchResponse> SearchWithOptionsAsync(SearchRequest tmpReq, SearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchShrinkRequest request = new SearchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AirLegs))
            {
                request.AirLegsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AirLegs, "air_legs", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchControlOptions))
            {
                request.SearchControlOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchControlOptions, "search_control_options", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Adults))
            {
                body["adults"] = request.Adults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirLegsShrink))
            {
                body["air_legs"] = request.AirLegsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CabinClass))
            {
                body["cabin_class"] = request.CabinClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Children))
            {
                body["children"] = request.Children;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Infants))
            {
                body["infants"] = request.Infants;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchControlOptionsShrink))
            {
                body["search_control_options"] = request.SearchControlOptionsShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Search",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/trade/action-search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 搜索
         *
         * @param request SearchRequest
         * @return SearchResponse
         */
        public SearchResponse Search(SearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchHeaders headers = new SearchHeaders();
            return SearchWithOptions(request, headers, runtime);
        }

        /**
         * @summary 搜索
         *
         * @param request SearchRequest
         * @return SearchResponse
         */
        public async Task<SearchResponse> SearchAsync(SearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchHeaders headers = new SearchHeaders();
            return await SearchWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 交易-支付出票
         *
         * @param request TicketingRequest
         * @param headers TicketingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TicketingResponse
         */
        public TicketingResponse TicketingWithOptions(TicketingRequest request, TicketingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNum))
            {
                body["order_num"] = request.OrderNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Ticketing",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/trade/action-ticketing",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 交易-支付出票
         *
         * @param request TicketingRequest
         * @param headers TicketingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TicketingResponse
         */
        public async Task<TicketingResponse> TicketingWithOptionsAsync(TicketingRequest request, TicketingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNum))
            {
                body["order_num"] = request.OrderNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Ticketing",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/trade/action-ticketing",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 交易-支付出票
         *
         * @param request TicketingRequest
         * @return TicketingResponse
         */
        public TicketingResponse Ticketing(TicketingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TicketingHeaders headers = new TicketingHeaders();
            return TicketingWithOptions(request, headers, runtime);
        }

        /**
         * @summary 交易-支付出票
         *
         * @param request TicketingRequest
         * @return TicketingResponse
         */
        public async Task<TicketingResponse> TicketingAsync(TicketingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TicketingHeaders headers = new TicketingHeaders();
            return await TicketingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 交易-支付前校验
         *
         * @param request TicketingCheckRequest
         * @param headers TicketingCheckHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TicketingCheckResponse
         */
        public TicketingCheckResponse TicketingCheckWithOptions(TicketingCheckRequest request, TicketingCheckHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNum))
            {
                body["order_num"] = request.OrderNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketingCheck",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/trade/action-ticketing-check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketingCheckResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 交易-支付前校验
         *
         * @param request TicketingCheckRequest
         * @param headers TicketingCheckHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TicketingCheckResponse
         */
        public async Task<TicketingCheckResponse> TicketingCheckWithOptionsAsync(TicketingCheckRequest request, TicketingCheckHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNum))
            {
                body["order_num"] = request.OrderNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketingCheck",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/trade/action-ticketing-check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketingCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 交易-支付前校验
         *
         * @param request TicketingCheckRequest
         * @return TicketingCheckResponse
         */
        public TicketingCheckResponse TicketingCheck(TicketingCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TicketingCheckHeaders headers = new TicketingCheckHeaders();
            return TicketingCheckWithOptions(request, headers, runtime);
        }

        /**
         * @summary 交易-支付前校验
         *
         * @param request TicketingCheckRequest
         * @return TicketingCheckResponse
         */
        public async Task<TicketingCheckResponse> TicketingCheckAsync(TicketingCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TicketingCheckHeaders headers = new TicketingCheckHeaders();
            return await TicketingCheckWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 航程过境签
         *
         * @param tmpReq TransitVisaRequest
         * @param headers TransitVisaHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TransitVisaResponse
         */
        public TransitVisaResponse TransitVisaWithOptions(TransitVisaRequest tmpReq, TransitVisaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TransitVisaShrinkRequest request = new TransitVisaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FlightSegmentParamList))
            {
                request.FlightSegmentParamListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FlightSegmentParamList, "flight_segment_param_list", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlightSegmentParamListShrink))
            {
                query["flight_segment_param_list"] = request.FlightSegmentParamListShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransitVisa",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/flight-data/transit-visa",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransitVisaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 航程过境签
         *
         * @param tmpReq TransitVisaRequest
         * @param headers TransitVisaHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TransitVisaResponse
         */
        public async Task<TransitVisaResponse> TransitVisaWithOptionsAsync(TransitVisaRequest tmpReq, TransitVisaHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TransitVisaShrinkRequest request = new TransitVisaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FlightSegmentParamList))
            {
                request.FlightSegmentParamListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FlightSegmentParamList, "flight_segment_param_list", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlightSegmentParamListShrink))
            {
                query["flight_segment_param_list"] = request.FlightSegmentParamListShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["x-acs-airticket-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["x-acs-airticket-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransitVisa",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/flight-data/transit-visa",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransitVisaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 航程过境签
         *
         * @param request TransitVisaRequest
         * @return TransitVisaResponse
         */
        public TransitVisaResponse TransitVisa(TransitVisaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TransitVisaHeaders headers = new TransitVisaHeaders();
            return TransitVisaWithOptions(request, headers, runtime);
        }

        /**
         * @summary 航程过境签
         *
         * @param request TransitVisaRequest
         * @return TransitVisaResponse
         */
        public async Task<TransitVisaResponse> TransitVisaAsync(TransitVisaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TransitVisaHeaders headers = new TransitVisaHeaders();
            return await TransitVisaWithOptionsAsync(request, headers, runtime);
        }

    }
}
