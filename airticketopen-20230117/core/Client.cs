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
            this._endpointRule = "regional";
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the account fund flow list.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AccountFlowListRequest
        /// </param>
        /// <param name="headers">
        /// AccountFlowListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AccountFlowListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the account fund flow list.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AccountFlowListRequest
        /// </param>
        /// <param name="headers">
        /// AccountFlowListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AccountFlowListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the account fund flow list.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AccountFlowListRequest
        /// </param>
        /// 
        /// <returns>
        /// AccountFlowListResponse
        /// </returns>
        public AccountFlowListResponse AccountFlowList(AccountFlowListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AccountFlowListHeaders headers = new AccountFlowListHeaders();
            return AccountFlowListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the account fund flow list.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AccountFlowListRequest
        /// </param>
        /// 
        /// <returns>
        /// AccountFlowListResponse
        /// </returns>
        public async Task<AccountFlowListResponse> AccountFlowListAsync(AccountFlowListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AccountFlowListHeaders headers = new AccountFlowListHeaders();
            return await AccountFlowListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Recommends ancillary products.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AncillarySuggestRequest
        /// </param>
        /// <param name="headers">
        /// AncillarySuggestHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AncillarySuggestResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Recommends ancillary products.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AncillarySuggestRequest
        /// </param>
        /// <param name="headers">
        /// AncillarySuggestHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AncillarySuggestResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Recommends ancillary products.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AncillarySuggestRequest
        /// </param>
        /// 
        /// <returns>
        /// AncillarySuggestResponse
        /// </returns>
        public AncillarySuggestResponse AncillarySuggest(AncillarySuggestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AncillarySuggestHeaders headers = new AncillarySuggestHeaders();
            return AncillarySuggestWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Recommends ancillary products.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AncillarySuggestRequest
        /// </param>
        /// 
        /// <returns>
        /// AncillarySuggestResponse
        /// </returns>
        public async Task<AncillarySuggestResponse> AncillarySuggestAsync(AncillarySuggestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AncillarySuggestHeaders headers = new AncillarySuggestHeaders();
            return await AncillarySuggestWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a booking order.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BookRequest
        /// </param>
        /// <param name="headers">
        /// BookHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BookResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a booking order.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BookRequest
        /// </param>
        /// <param name="headers">
        /// BookHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BookResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a booking order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BookRequest
        /// </param>
        /// 
        /// <returns>
        /// BookResponse
        /// </returns>
        public BookResponse Book(BookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BookHeaders headers = new BookHeaders();
            return BookWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a booking order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BookRequest
        /// </param>
        /// 
        /// <returns>
        /// BookResponse
        /// </returns>
        public async Task<BookResponse> BookAsync(BookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BookHeaders headers = new BookHeaders();
            return await BookWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an unpaid order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelRequest
        /// </param>
        /// <param name="headers">
        /// CancelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an unpaid order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelRequest
        /// </param>
        /// <param name="headers">
        /// CancelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an unpaid order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelResponse
        /// </returns>
        public CancelResponse Cancel(CancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelHeaders headers = new CancelHeaders();
            return CancelWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an unpaid order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelResponse
        /// </returns>
        public async Task<CancelResponse> CancelAsync(CancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelHeaders headers = new CancelHeaders();
            return await CancelWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a change application.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ChangeApplyRequest
        /// </param>
        /// <param name="headers">
        /// ChangeApplyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeApplyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a change application.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ChangeApplyRequest
        /// </param>
        /// <param name="headers">
        /// ChangeApplyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeApplyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a change application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeApplyResponse
        /// </returns>
        public ChangeApplyResponse ChangeApply(ChangeApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeApplyHeaders headers = new ChangeApplyHeaders();
            return ChangeApplyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a change application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeApplyResponse
        /// </returns>
        public async Task<ChangeApplyResponse> ChangeApplyAsync(ChangeApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeApplyHeaders headers = new ChangeApplyHeaders();
            return await ChangeApplyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancel the change order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeCancelRequest
        /// </param>
        /// <param name="headers">
        /// ChangeCancelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeCancelResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancel the change order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeCancelRequest
        /// </param>
        /// <param name="headers">
        /// ChangeCancelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeCancelResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancel the change order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeCancelRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeCancelResponse
        /// </returns>
        public ChangeCancelResponse ChangeCancel(ChangeCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeCancelHeaders headers = new ChangeCancelHeaders();
            return ChangeCancelWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancel the change order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeCancelRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeCancelResponse
        /// </returns>
        public async Task<ChangeCancelResponse> ChangeCancelAsync(ChangeCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeCancelHeaders headers = new ChangeCancelHeaders();
            return await ChangeCancelWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Confirms a flight change order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeConfirmRequest
        /// </param>
        /// <param name="headers">
        /// ChangeConfirmHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeConfirmResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Confirms a flight change order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeConfirmRequest
        /// </param>
        /// <param name="headers">
        /// ChangeConfirmHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeConfirmResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Confirms a flight change order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeConfirmRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeConfirmResponse
        /// </returns>
        public ChangeConfirmResponse ChangeConfirm(ChangeConfirmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeConfirmHeaders headers = new ChangeConfirmHeaders();
            return ChangeConfirmWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Confirms a flight change order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeConfirmRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeConfirmResponse
        /// </returns>
        public async Task<ChangeConfirmResponse> ChangeConfirmAsync(ChangeConfirmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeConfirmHeaders headers = new ChangeConfirmHeaders();
            return await ChangeConfirmWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a flight change order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeDetailRequest
        /// </param>
        /// <param name="headers">
        /// ChangeDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a flight change order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeDetailRequest
        /// </param>
        /// <param name="headers">
        /// ChangeDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a flight change order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeDetailResponse
        /// </returns>
        public ChangeDetailResponse ChangeDetail(ChangeDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeDetailHeaders headers = new ChangeDetailHeaders();
            return ChangeDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a flight change order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeDetailResponse
        /// </returns>
        public async Task<ChangeDetailResponse> ChangeDetailAsync(ChangeDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeDetailHeaders headers = new ChangeDetailHeaders();
            return await ChangeDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a paging list of change order summaries by buyer account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeDetailListOfBuyerRequest
        /// </param>
        /// <param name="headers">
        /// ChangeDetailListOfBuyerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeDetailListOfBuyerResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a paging list of change order summaries by buyer account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeDetailListOfBuyerRequest
        /// </param>
        /// <param name="headers">
        /// ChangeDetailListOfBuyerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeDetailListOfBuyerResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a paging list of change order summaries by buyer account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeDetailListOfBuyerRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeDetailListOfBuyerResponse
        /// </returns>
        public ChangeDetailListOfBuyerResponse ChangeDetailListOfBuyer(ChangeDetailListOfBuyerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeDetailListOfBuyerHeaders headers = new ChangeDetailListOfBuyerHeaders();
            return ChangeDetailListOfBuyerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a paging list of change order summaries by buyer account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeDetailListOfBuyerRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeDetailListOfBuyerResponse
        /// </returns>
        public async Task<ChangeDetailListOfBuyerResponse> ChangeDetailListOfBuyerAsync(ChangeDetailListOfBuyerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeDetailListOfBuyerHeaders headers = new ChangeDetailListOfBuyerHeaders();
            return await ChangeDetailListOfBuyerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of change orders by the original order number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeDetailListOfOrderNumRequest
        /// </param>
        /// <param name="headers">
        /// ChangeDetailListOfOrderNumHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeDetailListOfOrderNumResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of change orders by the original order number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeDetailListOfOrderNumRequest
        /// </param>
        /// <param name="headers">
        /// ChangeDetailListOfOrderNumHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeDetailListOfOrderNumResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of change orders by the original order number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeDetailListOfOrderNumRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeDetailListOfOrderNumResponse
        /// </returns>
        public ChangeDetailListOfOrderNumResponse ChangeDetailListOfOrderNum(ChangeDetailListOfOrderNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeDetailListOfOrderNumHeaders headers = new ChangeDetailListOfOrderNumHeaders();
            return ChangeDetailListOfOrderNumWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of change orders by the original order number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeDetailListOfOrderNumRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeDetailListOfOrderNumResponse
        /// </returns>
        public async Task<ChangeDetailListOfOrderNumResponse> ChangeDetailListOfOrderNumAsync(ChangeDetailListOfOrderNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeDetailListOfOrderNumHeaders headers = new ChangeDetailListOfOrderNumHeaders();
            return await ChangeDetailListOfOrderNumWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Collects lowest-price flight information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Collects lowest-price flight information.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CollectFlightLowestPriceRequest
        /// </param>
        /// <param name="headers">
        /// CollectFlightLowestPriceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CollectFlightLowestPriceResponse
        /// </returns>
        public CollectFlightLowestPriceResponse CollectFlightLowestPriceWithOptions(CollectFlightLowestPriceRequest tmpReq, CollectFlightLowestPriceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CollectFlightLowestPriceShrinkRequest request = new CollectFlightLowestPriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LowestPriceFlightInfoList))
            {
                request.LowestPriceFlightInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LowestPriceFlightInfoList, "lowest_price_flight_info_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LowestPriceFlightInfoListShrink))
            {
                body["lowest_price_flight_info_list"] = request.LowestPriceFlightInfoListShrink;
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
                Action = "CollectFlightLowestPrice",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/data-collect/flight-lowest-price",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollectFlightLowestPriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Collects lowest-price flight information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Collects lowest-price flight information.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CollectFlightLowestPriceRequest
        /// </param>
        /// <param name="headers">
        /// CollectFlightLowestPriceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CollectFlightLowestPriceResponse
        /// </returns>
        public async Task<CollectFlightLowestPriceResponse> CollectFlightLowestPriceWithOptionsAsync(CollectFlightLowestPriceRequest tmpReq, CollectFlightLowestPriceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CollectFlightLowestPriceShrinkRequest request = new CollectFlightLowestPriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LowestPriceFlightInfoList))
            {
                request.LowestPriceFlightInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LowestPriceFlightInfoList, "lowest_price_flight_info_list", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LowestPriceFlightInfoListShrink))
            {
                body["lowest_price_flight_info_list"] = request.LowestPriceFlightInfoListShrink;
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
                Action = "CollectFlightLowestPrice",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/data-collect/flight-lowest-price",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollectFlightLowestPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Collects lowest-price flight information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Collects lowest-price flight information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CollectFlightLowestPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// CollectFlightLowestPriceResponse
        /// </returns>
        public CollectFlightLowestPriceResponse CollectFlightLowestPrice(CollectFlightLowestPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollectFlightLowestPriceHeaders headers = new CollectFlightLowestPriceHeaders();
            return CollectFlightLowestPriceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Collects lowest-price flight information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Collects lowest-price flight information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CollectFlightLowestPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// CollectFlightLowestPriceResponse
        /// </returns>
        public async Task<CollectFlightLowestPriceResponse> CollectFlightLowestPriceAsync(CollectFlightLowestPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollectFlightLowestPriceHeaders headers = new CollectFlightLowestPriceHeaders();
            return await CollectFlightLowestPriceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Find richer quote information for the itinerary, including free baggage allowance, refund and change rules, and baggage through-check rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In the input parameters, choose either solution_id or journey_param_list. solution_id must be obtained from the Search API.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// EnrichRequest
        /// </param>
        /// <param name="headers">
        /// EnrichHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnrichResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Find richer quote information for the itinerary, including free baggage allowance, refund and change rules, and baggage through-check rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In the input parameters, choose either solution_id or journey_param_list. solution_id must be obtained from the Search API.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// EnrichRequest
        /// </param>
        /// <param name="headers">
        /// EnrichHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnrichResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Find richer quote information for the itinerary, including free baggage allowance, refund and change rules, and baggage through-check rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In the input parameters, choose either solution_id or journey_param_list. solution_id must be obtained from the Search API.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnrichRequest
        /// </param>
        /// 
        /// <returns>
        /// EnrichResponse
        /// </returns>
        public EnrichResponse Enrich(EnrichRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EnrichHeaders headers = new EnrichHeaders();
            return EnrichWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Find richer quote information for the itinerary, including free baggage allowance, refund and change rules, and baggage through-check rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In the input parameters, choose either solution_id or journey_param_list. solution_id must be obtained from the Search API.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnrichRequest
        /// </param>
        /// 
        /// <returns>
        /// EnrichResponse
        /// </returns>
        public async Task<EnrichResponse> EnrichAsync(EnrichRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EnrichHeaders headers = new EnrichHeaders();
            return await EnrichWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a file as an attachment image. The file size is limited to 300 KB or less.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileUploadRequest
        /// </param>
        /// <param name="headers">
        /// FileUploadHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FileUploadResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a file as an attachment image. The file size is limited to 300 KB or less.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileUploadRequest
        /// </param>
        /// <param name="headers">
        /// FileUploadHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FileUploadResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a file as an attachment image. The file size is limited to 300 KB or less.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileUploadRequest
        /// </param>
        /// 
        /// <returns>
        /// FileUploadResponse
        /// </returns>
        public FileUploadResponse FileUpload(FileUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileUploadHeaders headers = new FileUploadHeaders();
            return FileUploadWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a file as an attachment image. The file size is limited to 300 KB or less.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileUploadRequest
        /// </param>
        /// 
        /// <returns>
        /// FileUploadResponse
        /// </returns>
        public async Task<FileUploadResponse> FileUploadAsync(FileUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileUploadHeaders headers = new FileUploadHeaders();
            return await FileUploadWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries flight change information by order number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FlightChangeOfOrderRequest
        /// </param>
        /// <param name="headers">
        /// FlightChangeOfOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FlightChangeOfOrderResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries flight change information by order number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FlightChangeOfOrderRequest
        /// </param>
        /// <param name="headers">
        /// FlightChangeOfOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FlightChangeOfOrderResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries flight change information by order number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FlightChangeOfOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// FlightChangeOfOrderResponse
        /// </returns>
        public FlightChangeOfOrderResponse FlightChangeOfOrder(FlightChangeOfOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightChangeOfOrderHeaders headers = new FlightChangeOfOrderHeaders();
            return FlightChangeOfOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries flight change information by order number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FlightChangeOfOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// FlightChangeOfOrderResponse
        /// </returns>
        public async Task<FlightChangeOfOrderResponse> FlightChangeOfOrderAsync(FlightChangeOfOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlightChangeOfOrderHeaders headers = new FlightChangeOfOrderHeaders();
            return await FlightChangeOfOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a token for API calls. The token is valid for 2 hours.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a token for API calls. The token is valid for 2 hours.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a token for API calls. The token is valid for 2 hours.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenResponse
        /// </returns>
        public GetTokenResponse GetToken(GetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a token for API calls. The token is valid for 2 hours.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenResponse
        /// </returns>
        public async Task<GetTokenResponse> GetTokenAsync(GetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTokenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries luggage through-check information for an itinerary.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries luggage through-check information for an itinerary. Provide itinerary information as input, and the API returns whether luggage through-check is supported for the itinerary. Luggage through-check applies to transfer and stopover scenarios.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// LuggageDirectRequest
        /// </param>
        /// <param name="headers">
        /// LuggageDirectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LuggageDirectResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries luggage through-check information for an itinerary.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries luggage through-check information for an itinerary. Provide itinerary information as input, and the API returns whether luggage through-check is supported for the itinerary. Luggage through-check applies to transfer and stopover scenarios.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// LuggageDirectRequest
        /// </param>
        /// <param name="headers">
        /// LuggageDirectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LuggageDirectResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries luggage through-check information for an itinerary.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries luggage through-check information for an itinerary. Provide itinerary information as input, and the API returns whether luggage through-check is supported for the itinerary. Luggage through-check applies to transfer and stopover scenarios.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LuggageDirectRequest
        /// </param>
        /// 
        /// <returns>
        /// LuggageDirectResponse
        /// </returns>
        public LuggageDirectResponse LuggageDirect(LuggageDirectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LuggageDirectHeaders headers = new LuggageDirectHeaders();
            return LuggageDirectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries luggage through-check information for an itinerary.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries luggage through-check information for an itinerary. Provide itinerary information as input, and the API returns whether luggage through-check is supported for the itinerary. Luggage through-check applies to transfer and stopover scenarios.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LuggageDirectRequest
        /// </param>
        /// 
        /// <returns>
        /// LuggageDirectResponse
        /// </returns>
        public async Task<LuggageDirectResponse> LuggageDirectAsync(LuggageDirectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LuggageDirectHeaders headers = new LuggageDirectHeaders();
            return await LuggageDirectWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries order details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrderDetailRequest
        /// </param>
        /// <param name="headers">
        /// OrderDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OrderDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries order details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrderDetailRequest
        /// </param>
        /// <param name="headers">
        /// OrderDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OrderDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries order details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrderDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// OrderDetailResponse
        /// </returns>
        public OrderDetailResponse OrderDetail(OrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrderDetailHeaders headers = new OrderDetailHeaders();
            return OrderDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries order details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrderDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// OrderDetailResponse
        /// </returns>
        public async Task<OrderDetailResponse> OrderDetailAsync(OrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrderDetailHeaders headers = new OrderDetailHeaders();
            return await OrderDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the order list.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrderListRequest
        /// </param>
        /// <param name="headers">
        /// OrderListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OrderListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the order list.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrderListRequest
        /// </param>
        /// <param name="headers">
        /// OrderListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OrderListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the order list.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrderListRequest
        /// </param>
        /// 
        /// <returns>
        /// OrderListResponse
        /// </returns>
        public OrderListResponse OrderList(OrderListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrderListHeaders headers = new OrderListHeaders();
            return OrderListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the order list.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrderListRequest
        /// </param>
        /// 
        /// <returns>
        /// OrderListResponse
        /// </returns>
        public async Task<OrderListResponse> OrderListAsync(OrderListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrderListHeaders headers = new OrderListHeaders();
            return await OrderListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies seat availability and pricing. If the price has changed, the developer can proceed with Book at the updated price. If the price has not changed, the order is placed at the original price.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PricingRequest
        /// </param>
        /// <param name="headers">
        /// PricingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PricingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies seat availability and pricing. If the price has changed, the developer can proceed with Book at the updated price. If the price has not changed, the order is placed at the original price.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PricingRequest
        /// </param>
        /// <param name="headers">
        /// PricingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PricingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies seat availability and pricing. If the price has changed, the developer can proceed with Book at the updated price. If the price has not changed, the order is placed at the original price.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PricingRequest
        /// </param>
        /// 
        /// <returns>
        /// PricingResponse
        /// </returns>
        public PricingResponse Pricing(PricingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PricingHeaders headers = new PricingHeaders();
            return PricingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies seat availability and pricing. If the price has changed, the developer can proceed with Book at the updated price. If the price has not changed, the order is placed at the original price.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PricingRequest
        /// </param>
        /// 
        /// <returns>
        /// PricingResponse
        /// </returns>
        public async Task<PricingResponse> PricingAsync(PricingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PricingHeaders headers = new PricingHeaders();
            return await PricingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a refund application for an air ticket.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RefundApplyRequest
        /// </param>
        /// <param name="headers">
        /// RefundApplyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefundApplyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a refund application for an air ticket.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RefundApplyRequest
        /// </param>
        /// <param name="headers">
        /// RefundApplyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefundApplyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a refund application for an air ticket.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefundApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// RefundApplyResponse
        /// </returns>
        public RefundApplyResponse RefundApply(RefundApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RefundApplyHeaders headers = new RefundApplyHeaders();
            return RefundApplyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a refund application for an air ticket.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefundApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// RefundApplyResponse
        /// </returns>
        public async Task<RefundApplyResponse> RefundApplyAsync(RefundApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RefundApplyHeaders headers = new RefundApplyHeaders();
            return await RefundApplyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a refund order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefundDetailRequest
        /// </param>
        /// <param name="headers">
        /// RefundDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefundDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a refund order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefundDetailRequest
        /// </param>
        /// <param name="headers">
        /// RefundDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefundDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a refund order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefundDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// RefundDetailResponse
        /// </returns>
        public RefundDetailResponse RefundDetail(RefundDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RefundDetailHeaders headers = new RefundDetailHeaders();
            return RefundDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a refund order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefundDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// RefundDetailResponse
        /// </returns>
        public async Task<RefundDetailResponse> RefundDetailAsync(RefundDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RefundDetailHeaders headers = new RefundDetailHeaders();
            return await RefundDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of refund orders.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefundDetailListRequest
        /// </param>
        /// <param name="headers">
        /// RefundDetailListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefundDetailListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of refund orders.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefundDetailListRequest
        /// </param>
        /// <param name="headers">
        /// RefundDetailListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefundDetailListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of refund orders.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefundDetailListRequest
        /// </param>
        /// 
        /// <returns>
        /// RefundDetailListResponse
        /// </returns>
        public RefundDetailListResponse RefundDetailList(RefundDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RefundDetailListHeaders headers = new RefundDetailListHeaders();
            return RefundDetailListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of refund orders.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefundDetailListRequest
        /// </param>
        /// 
        /// <returns>
        /// RefundDetailListResponse
        /// </returns>
        public async Task<RefundDetailListResponse> RefundDetailListAsync(RefundDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RefundDetailListHeaders headers = new RefundDetailListHeaders();
            return await RefundDetailListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Searches for flight quotes and returns the lowest price across multiple flights. Note that the response of this operation does not include refund and change rules, free baggage allowance, or baggage through-check rules.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SearchRequest
        /// </param>
        /// <param name="headers">
        /// SearchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Searches for flight quotes and returns the lowest price across multiple flights. Note that the response of this operation does not include refund and change rules, free baggage allowance, or baggage through-check rules.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SearchRequest
        /// </param>
        /// <param name="headers">
        /// SearchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Searches for flight quotes and returns the lowest price across multiple flights. Note that the response of this operation does not include refund and change rules, free baggage allowance, or baggage through-check rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchResponse
        /// </returns>
        public SearchResponse Search(SearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchHeaders headers = new SearchHeaders();
            return SearchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Searches for flight quotes and returns the lowest price across multiple flights. Note that the response of this operation does not include refund and change rules, free baggage allowance, or baggage through-check rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchResponse
        /// </returns>
        public async Task<SearchResponse> SearchAsync(SearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchHeaders headers = new SearchHeaders();
            return await SearchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Search and quote prices, currently providing the lowest price across multiple flights. Note that this API response includes refund/change rules, free baggage allowance, and baggage through-check rules.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// StandardSearchRequest
        /// </param>
        /// <param name="headers">
        /// StandardSearchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StandardSearchResponse
        /// </returns>
        public StandardSearchResponse StandardSearchWithOptions(StandardSearchRequest tmpReq, StandardSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StandardSearchShrinkRequest request = new StandardSearchShrinkRequest();
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
                Action = "StandardSearch",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/trade/action-standardsearch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StandardSearchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Search and quote prices, currently providing the lowest price across multiple flights. Note that this API response includes refund/change rules, free baggage allowance, and baggage through-check rules.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// StandardSearchRequest
        /// </param>
        /// <param name="headers">
        /// StandardSearchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StandardSearchResponse
        /// </returns>
        public async Task<StandardSearchResponse> StandardSearchWithOptionsAsync(StandardSearchRequest tmpReq, StandardSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StandardSearchShrinkRequest request = new StandardSearchShrinkRequest();
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
                Action = "StandardSearch",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/airticket/v1/trade/action-standardsearch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StandardSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Search and quote prices, currently providing the lowest price across multiple flights. Note that this API response includes refund/change rules, free baggage allowance, and baggage through-check rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StandardSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// StandardSearchResponse
        /// </returns>
        public StandardSearchResponse StandardSearch(StandardSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StandardSearchHeaders headers = new StandardSearchHeaders();
            return StandardSearchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Search and quote prices, currently providing the lowest price across multiple flights. Note that this API response includes refund/change rules, free baggage allowance, and baggage through-check rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StandardSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// StandardSearchResponse
        /// </returns>
        public async Task<StandardSearchResponse> StandardSearchAsync(StandardSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StandardSearchHeaders headers = new StandardSearchHeaders();
            return await StandardSearchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请退款。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketApplyRefundRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketApplyRefundResponse
        /// </returns>
        public TicketApplyRefundResponse TicketApplyRefundWithOptions(TicketApplyRefundRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorOrderId))
            {
                body["DistributorOrderId"] = request.DistributorOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundReason))
            {
                body["RefundReason"] = request.RefundReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundRemark))
            {
                body["RefundRemark"] = request.RefundRemark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketApplyRefund",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketApplyRefund",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketApplyRefundResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请退款。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketApplyRefundRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketApplyRefundResponse
        /// </returns>
        public async Task<TicketApplyRefundResponse> TicketApplyRefundWithOptionsAsync(TicketApplyRefundRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorOrderId))
            {
                body["DistributorOrderId"] = request.DistributorOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundReason))
            {
                body["RefundReason"] = request.RefundReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundRemark))
            {
                body["RefundRemark"] = request.RefundRemark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketApplyRefund",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketApplyRefund",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketApplyRefundResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请退款。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketApplyRefundRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketApplyRefundResponse
        /// </returns>
        public TicketApplyRefundResponse TicketApplyRefund(TicketApplyRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TicketApplyRefundWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请退款。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketApplyRefundRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketApplyRefundResponse
        /// </returns>
        public async Task<TicketApplyRefundResponse> TicketApplyRefundAsync(TicketApplyRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TicketApplyRefundWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消订单。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketCancelOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketCancelOrderResponse
        /// </returns>
        public TicketCancelOrderResponse TicketCancelOrderWithOptions(TicketCancelOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorOrderId))
            {
                body["DistributorOrderId"] = request.DistributorOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketCancelOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketCancelOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketCancelOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消订单。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketCancelOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketCancelOrderResponse
        /// </returns>
        public async Task<TicketCancelOrderResponse> TicketCancelOrderWithOptionsAsync(TicketCancelOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorOrderId))
            {
                body["DistributorOrderId"] = request.DistributorOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketCancelOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketCancelOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketCancelOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消订单。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketCancelOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketCancelOrderResponse
        /// </returns>
        public TicketCancelOrderResponse TicketCancelOrder(TicketCancelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TicketCancelOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消订单。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketCancelOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketCancelOrderResponse
        /// </returns>
        public async Task<TicketCancelOrderResponse> TicketCancelOrderAsync(TicketCancelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TicketCancelOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查退款。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketCheckRefundRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketCheckRefundResponse
        /// </returns>
        public TicketCheckRefundResponse TicketCheckRefundWithOptions(TicketCheckRefundRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorOrderId))
            {
                body["DistributorOrderId"] = request.DistributorOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundReason))
            {
                body["RefundReason"] = request.RefundReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundRemark))
            {
                body["RefundRemark"] = request.RefundRemark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketCheckRefund",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketCheckRefund",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketCheckRefundResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查退款。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketCheckRefundRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketCheckRefundResponse
        /// </returns>
        public async Task<TicketCheckRefundResponse> TicketCheckRefundWithOptionsAsync(TicketCheckRefundRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorOrderId))
            {
                body["DistributorOrderId"] = request.DistributorOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundReason))
            {
                body["RefundReason"] = request.RefundReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundRemark))
            {
                body["RefundRemark"] = request.RefundRemark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketCheckRefund",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketCheckRefund",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketCheckRefundResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查退款。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketCheckRefundRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketCheckRefundResponse
        /// </returns>
        public TicketCheckRefundResponse TicketCheckRefund(TicketCheckRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TicketCheckRefundWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查退款。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketCheckRefundRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketCheckRefundResponse
        /// </returns>
        public async Task<TicketCheckRefundResponse> TicketCheckRefundAsync(TicketCheckRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TicketCheckRefundWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建订单。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// TicketCreateOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketCreateOrderResponse
        /// </returns>
        public TicketCreateOrderResponse TicketCreateOrderWithOptions(TicketCreateOrderRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TicketCreateOrderShrinkRequest request = new TicketCreateOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contact))
            {
                request.ContactShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contact, "Contact", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderProduct))
            {
                request.OrderProductShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderProduct, "OrderProduct", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TotalDistributionPrice))
            {
                request.TotalDistributionPriceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TotalDistributionPrice, "TotalDistributionPrice", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Travelers))
            {
                request.TravelersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Travelers, "Travelers", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactShrink))
            {
                body["Contact"] = request.ContactShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorOrderId))
            {
                body["DistributorOrderId"] = request.DistributorOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderProductShrink))
            {
                body["OrderProduct"] = request.OrderProductShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                body["Quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalDistributionPriceShrink))
            {
                body["TotalDistributionPrice"] = request.TotalDistributionPriceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TravelersShrink))
            {
                body["Travelers"] = request.TravelersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketCreateOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketCreateOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketCreateOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建订单。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// TicketCreateOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketCreateOrderResponse
        /// </returns>
        public async Task<TicketCreateOrderResponse> TicketCreateOrderWithOptionsAsync(TicketCreateOrderRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TicketCreateOrderShrinkRequest request = new TicketCreateOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contact))
            {
                request.ContactShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contact, "Contact", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderProduct))
            {
                request.OrderProductShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderProduct, "OrderProduct", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TotalDistributionPrice))
            {
                request.TotalDistributionPriceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TotalDistributionPrice, "TotalDistributionPrice", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Travelers))
            {
                request.TravelersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Travelers, "Travelers", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactShrink))
            {
                body["Contact"] = request.ContactShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorOrderId))
            {
                body["DistributorOrderId"] = request.DistributorOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderProductShrink))
            {
                body["OrderProduct"] = request.OrderProductShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                body["Quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalDistributionPriceShrink))
            {
                body["TotalDistributionPrice"] = request.TotalDistributionPriceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TravelersShrink))
            {
                body["Travelers"] = request.TravelersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketCreateOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketCreateOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketCreateOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建订单。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketCreateOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketCreateOrderResponse
        /// </returns>
        public TicketCreateOrderResponse TicketCreateOrder(TicketCreateOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TicketCreateOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建订单。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketCreateOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketCreateOrderResponse
        /// </returns>
        public async Task<TicketCreateOrderResponse> TicketCreateOrderAsync(TicketCreateOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TicketCreateOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询门票产品。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketPageQueryProductRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketPageQueryProductResponse
        /// </returns>
        public TicketPageQueryProductResponse TicketPageQueryProductWithOptions(TicketPageQueryProductRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenicId))
            {
                body["ScenicId"] = request.ScenicId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketPageQueryProduct",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketPageQueryProduct",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketPageQueryProductResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询门票产品。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketPageQueryProductRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketPageQueryProductResponse
        /// </returns>
        public async Task<TicketPageQueryProductResponse> TicketPageQueryProductWithOptionsAsync(TicketPageQueryProductRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenicId))
            {
                body["ScenicId"] = request.ScenicId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketPageQueryProduct",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketPageQueryProduct",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketPageQueryProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询门票产品。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketPageQueryProductRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketPageQueryProductResponse
        /// </returns>
        public TicketPageQueryProductResponse TicketPageQueryProduct(TicketPageQueryProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TicketPageQueryProductWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询门票产品。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketPageQueryProductRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketPageQueryProductResponse
        /// </returns>
        public async Task<TicketPageQueryProductResponse> TicketPageQueryProductAsync(TicketPageQueryProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TicketPageQueryProductWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询景区。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketPageQueryScenicRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketPageQueryScenicResponse
        /// </returns>
        public TicketPageQueryScenicResponse TicketPageQueryScenicWithOptions(TicketPageQueryScenicRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketPageQueryScenic",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketPageQueryScenic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketPageQueryScenicResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询景区。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketPageQueryScenicRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketPageQueryScenicResponse
        /// </returns>
        public async Task<TicketPageQueryScenicResponse> TicketPageQueryScenicWithOptionsAsync(TicketPageQueryScenicRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketPageQueryScenic",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketPageQueryScenic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketPageQueryScenicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询景区。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketPageQueryScenicRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketPageQueryScenicResponse
        /// </returns>
        public TicketPageQueryScenicResponse TicketPageQueryScenic(TicketPageQueryScenicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TicketPageQueryScenicWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询景区。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketPageQueryScenicRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketPageQueryScenicResponse
        /// </returns>
        public async Task<TicketPageQueryScenicResponse> TicketPageQueryScenicAsync(TicketPageQueryScenicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TicketPageQueryScenicWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>支付订单。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketPayOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketPayOrderResponse
        /// </returns>
        public TicketPayOrderResponse TicketPayOrderWithOptions(TicketPayOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorOrderId))
            {
                body["DistributorOrderId"] = request.DistributorOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketPayOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketPayOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketPayOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>支付订单。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketPayOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketPayOrderResponse
        /// </returns>
        public async Task<TicketPayOrderResponse> TicketPayOrderWithOptionsAsync(TicketPayOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorOrderId))
            {
                body["DistributorOrderId"] = request.DistributorOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketPayOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketPayOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketPayOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>支付订单。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketPayOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketPayOrderResponse
        /// </returns>
        public TicketPayOrderResponse TicketPayOrder(TicketPayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TicketPayOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>支付订单。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketPayOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketPayOrderResponse
        /// </returns>
        public async Task<TicketPayOrderResponse> TicketPayOrderAsync(TicketPayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TicketPayOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询订单。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryOrderResponse
        /// </returns>
        public TicketQueryOrderResponse TicketQueryOrderWithOptions(TicketQueryOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorOrderId))
            {
                body["DistributorOrderId"] = request.DistributorOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketQueryOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketQueryOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketQueryOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询订单。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryOrderResponse
        /// </returns>
        public async Task<TicketQueryOrderResponse> TicketQueryOrderWithOptionsAsync(TicketQueryOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorOrderId))
            {
                body["DistributorOrderId"] = request.DistributorOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketQueryOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketQueryOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketQueryOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询订单。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryOrderResponse
        /// </returns>
        public TicketQueryOrderResponse TicketQueryOrder(TicketQueryOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TicketQueryOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询订单。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryOrderResponse
        /// </returns>
        public async Task<TicketQueryOrderResponse> TicketQueryOrderAsync(TicketQueryOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TicketQueryOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询门票价库。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryPriceStockRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryPriceStockResponse
        /// </returns>
        public TicketQueryPriceStockResponse TicketQueryPriceStockWithOptions(TicketQueryPriceStockRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketQueryPriceStock",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketQueryPriceStock",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketQueryPriceStockResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询门票价库。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryPriceStockRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryPriceStockResponse
        /// </returns>
        public async Task<TicketQueryPriceStockResponse> TicketQueryPriceStockWithOptionsAsync(TicketQueryPriceStockRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketQueryPriceStock",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketQueryPriceStock",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketQueryPriceStockResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询门票价库。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryPriceStockRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryPriceStockResponse
        /// </returns>
        public TicketQueryPriceStockResponse TicketQueryPriceStock(TicketQueryPriceStockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TicketQueryPriceStockWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询门票价库。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryPriceStockRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryPriceStockResponse
        /// </returns>
        public async Task<TicketQueryPriceStockResponse> TicketQueryPriceStockAsync(TicketQueryPriceStockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TicketQueryPriceStockWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询门票产品。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryProductRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryProductResponse
        /// </returns>
        public TicketQueryProductResponse TicketQueryProductWithOptions(TicketQueryProductRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketQueryProduct",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketQueryProduct",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketQueryProductResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询门票产品。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryProductRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryProductResponse
        /// </returns>
        public async Task<TicketQueryProductResponse> TicketQueryProductWithOptionsAsync(TicketQueryProductRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketQueryProduct",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketQueryProduct",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketQueryProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询门票产品。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryProductRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryProductResponse
        /// </returns>
        public TicketQueryProductResponse TicketQueryProduct(TicketQueryProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TicketQueryProductWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询门票产品。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryProductRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryProductResponse
        /// </returns>
        public async Task<TicketQueryProductResponse> TicketQueryProductAsync(TicketQueryProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TicketQueryProductWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询退款单。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryRefundOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryRefundOrderResponse
        /// </returns>
        public TicketQueryRefundOrderResponse TicketQueryRefundOrderWithOptions(TicketQueryRefundOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorOrderId))
            {
                body["DistributorOrderId"] = request.DistributorOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketQueryRefundOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketQueryRefundOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketQueryRefundOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询退款单。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryRefundOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryRefundOrderResponse
        /// </returns>
        public async Task<TicketQueryRefundOrderResponse> TicketQueryRefundOrderWithOptionsAsync(TicketQueryRefundOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorOrderId))
            {
                body["DistributorOrderId"] = request.DistributorOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketQueryRefundOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketQueryRefundOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketQueryRefundOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询退款单。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryRefundOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryRefundOrderResponse
        /// </returns>
        public TicketQueryRefundOrderResponse TicketQueryRefundOrder(TicketQueryRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TicketQueryRefundOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询退款单。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryRefundOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryRefundOrderResponse
        /// </returns>
        public async Task<TicketQueryRefundOrderResponse> TicketQueryRefundOrderAsync(TicketQueryRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TicketQueryRefundOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询门票景区。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryScenicRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryScenicResponse
        /// </returns>
        public TicketQueryScenicResponse TicketQueryScenicWithOptions(TicketQueryScenicRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenicId))
            {
                body["ScenicId"] = request.ScenicId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketQueryScenic",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketQueryScenic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketQueryScenicResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询门票景区。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryScenicRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryScenicResponse
        /// </returns>
        public async Task<TicketQueryScenicResponse> TicketQueryScenicWithOptionsAsync(TicketQueryScenicRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenicId))
            {
                body["ScenicId"] = request.ScenicId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketQueryScenic",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketQueryScenic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketQueryScenicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询门票景区。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryScenicRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryScenicResponse
        /// </returns>
        public TicketQueryScenicResponse TicketQueryScenic(TicketQueryScenicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TicketQueryScenicWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询门票景区。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryScenicRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryScenicResponse
        /// </returns>
        public async Task<TicketQueryScenicResponse> TicketQueryScenicAsync(TicketQueryScenicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TicketQueryScenicWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询货架。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryShelfRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryShelfResponse
        /// </returns>
        public TicketQueryShelfResponse TicketQueryShelfWithOptions(TicketQueryShelfRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenicId))
            {
                body["ScenicId"] = request.ScenicId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketQueryShelf",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketQueryShelf",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketQueryShelfResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询货架。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryShelfRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryShelfResponse
        /// </returns>
        public async Task<TicketQueryShelfResponse> TicketQueryShelfWithOptionsAsync(TicketQueryShelfRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenicId))
            {
                body["ScenicId"] = request.ScenicId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketQueryShelf",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/TicketQueryShelf",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketQueryShelfResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询货架。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryShelfRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryShelfResponse
        /// </returns>
        public TicketQueryShelfResponse TicketQueryShelf(TicketQueryShelfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TicketQueryShelfWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询货架。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketQueryShelfRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketQueryShelfResponse
        /// </returns>
        public async Task<TicketQueryShelfResponse> TicketQueryShelfAsync(TicketQueryShelfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TicketQueryShelfWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pays for and issues a ticket.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketingRequest
        /// </param>
        /// <param name="headers">
        /// TicketingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pays for and issues a ticket.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketingRequest
        /// </param>
        /// <param name="headers">
        /// TicketingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pays for and issues a ticket.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketingRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketingResponse
        /// </returns>
        public TicketingResponse Ticketing(TicketingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TicketingHeaders headers = new TicketingHeaders();
            return TicketingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pays for and issues a ticket.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TicketingRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketingResponse
        /// </returns>
        public async Task<TicketingResponse> TicketingAsync(TicketingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TicketingHeaders headers = new TicketingHeaders();
            return await TicketingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a pre-ticketing check. This operation is optional.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a pre-ticketing check. This operation is optional.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TicketingCheckRequest
        /// </param>
        /// <param name="headers">
        /// TicketingCheckHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketingCheckResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a pre-ticketing check. This operation is optional.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a pre-ticketing check. This operation is optional.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TicketingCheckRequest
        /// </param>
        /// <param name="headers">
        /// TicketingCheckHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketingCheckResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a pre-ticketing check. This operation is optional.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a pre-ticketing check. This operation is optional.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TicketingCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketingCheckResponse
        /// </returns>
        public TicketingCheckResponse TicketingCheck(TicketingCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TicketingCheckHeaders headers = new TicketingCheckHeaders();
            return TicketingCheckWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a pre-ticketing check. This operation is optional.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a pre-ticketing check. This operation is optional.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TicketingCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketingCheckResponse
        /// </returns>
        public async Task<TicketingCheckResponse> TicketingCheckAsync(TicketingCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TicketingCheckHeaders headers = new TicketingCheckHeaders();
            return await TicketingCheckWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries transit visa requirements for a flight itinerary. You provide flight information, and the API returns whether a transit visa is required for the itinerary. Only transfer or stopover segments are valid input parameters (transfers or stopovers passing through a third country). The supported passenger type defaults to Chinese mainland travelers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries transit visa requirements for a flight itinerary. You provide flight information, and the API returns whether a transit visa is required for the itinerary. Only transfer or stopover segments are valid input parameters (transfers or stopovers passing through a third country). The supported passenger type defaults to Chinese mainland travelers.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// TransitVisaRequest
        /// </param>
        /// <param name="headers">
        /// TransitVisaHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransitVisaResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries transit visa requirements for a flight itinerary. You provide flight information, and the API returns whether a transit visa is required for the itinerary. Only transfer or stopover segments are valid input parameters (transfers or stopovers passing through a third country). The supported passenger type defaults to Chinese mainland travelers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries transit visa requirements for a flight itinerary. You provide flight information, and the API returns whether a transit visa is required for the itinerary. Only transfer or stopover segments are valid input parameters (transfers or stopovers passing through a third country). The supported passenger type defaults to Chinese mainland travelers.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// TransitVisaRequest
        /// </param>
        /// <param name="headers">
        /// TransitVisaHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransitVisaResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries transit visa requirements for a flight itinerary. You provide flight information, and the API returns whether a transit visa is required for the itinerary. Only transfer or stopover segments are valid input parameters (transfers or stopovers passing through a third country). The supported passenger type defaults to Chinese mainland travelers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries transit visa requirements for a flight itinerary. You provide flight information, and the API returns whether a transit visa is required for the itinerary. Only transfer or stopover segments are valid input parameters (transfers or stopovers passing through a third country). The supported passenger type defaults to Chinese mainland travelers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TransitVisaRequest
        /// </param>
        /// 
        /// <returns>
        /// TransitVisaResponse
        /// </returns>
        public TransitVisaResponse TransitVisa(TransitVisaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TransitVisaHeaders headers = new TransitVisaHeaders();
            return TransitVisaWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries transit visa requirements for a flight itinerary. You provide flight information, and the API returns whether a transit visa is required for the itinerary. Only transfer or stopover segments are valid input parameters (transfers or stopovers passing through a third country). The supported passenger type defaults to Chinese mainland travelers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries transit visa requirements for a flight itinerary. You provide flight information, and the API returns whether a transit visa is required for the itinerary. Only transfer or stopover segments are valid input parameters (transfers or stopovers passing through a third country). The supported passenger type defaults to Chinese mainland travelers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TransitVisaRequest
        /// </param>
        /// 
        /// <returns>
        /// TransitVisaResponse
        /// </returns>
        public async Task<TransitVisaResponse> TransitVisaAsync(TransitVisaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TransitVisaHeaders headers = new TransitVisaHeaders();
            return await TransitVisaWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请退款</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyRefundRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyRefundResponse
        /// </returns>
        public ApplyRefundResponse ApplyRefundWithOptions(ApplyRefundRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundReason))
            {
                body["RefundReason"] = request.RefundReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "applyRefund",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/applyRefund",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyRefundResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请退款</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyRefundRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyRefundResponse
        /// </returns>
        public async Task<ApplyRefundResponse> ApplyRefundWithOptionsAsync(ApplyRefundRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundReason))
            {
                body["RefundReason"] = request.RefundReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "applyRefund",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/applyRefund",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyRefundResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请退款</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyRefundRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyRefundResponse
        /// </returns>
        public ApplyRefundResponse ApplyRefund(ApplyRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ApplyRefundWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请退款</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyRefundRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyRefundResponse
        /// </returns>
        public async Task<ApplyRefundResponse> ApplyRefundAsync(ApplyRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ApplyRefundWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询酒店详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchGetHotelDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetHotelDetailResponse
        /// </returns>
        public BatchGetHotelDetailResponse BatchGetHotelDetailWithOptions(BatchGetHotelDetailRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchGetHotelDetailShrinkRequest request = new BatchGetHotelDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StandardHotelIds))
            {
                request.StandardHotelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StandardHotelIds, "StandardHotelIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardHotelIdsShrink))
            {
                body["StandardHotelIds"] = request.StandardHotelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "batchGetHotelDetail",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/batchGetHotelDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetHotelDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询酒店详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchGetHotelDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetHotelDetailResponse
        /// </returns>
        public async Task<BatchGetHotelDetailResponse> BatchGetHotelDetailWithOptionsAsync(BatchGetHotelDetailRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchGetHotelDetailShrinkRequest request = new BatchGetHotelDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StandardHotelIds))
            {
                request.StandardHotelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StandardHotelIds, "StandardHotelIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardHotelIdsShrink))
            {
                body["StandardHotelIds"] = request.StandardHotelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "batchGetHotelDetail",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/batchGetHotelDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetHotelDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询酒店详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetHotelDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetHotelDetailResponse
        /// </returns>
        public BatchGetHotelDetailResponse BatchGetHotelDetail(BatchGetHotelDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchGetHotelDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询酒店详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetHotelDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetHotelDetailResponse
        /// </returns>
        public async Task<BatchGetHotelDetailResponse> BatchGetHotelDetailAsync(BatchGetHotelDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchGetHotelDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消或退款</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelOrRefundRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelOrRefundResponse
        /// </returns>
        public CancelOrRefundResponse CancelOrRefundWithOptions(CancelOrRefundRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "cancelOrRefund",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/cancelOrRefund",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOrRefundResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消或退款</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelOrRefundRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelOrRefundResponse
        /// </returns>
        public async Task<CancelOrRefundResponse> CancelOrRefundWithOptionsAsync(CancelOrRefundRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "cancelOrRefund",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/cancelOrRefund",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOrRefundResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消或退款</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelOrRefundRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelOrRefundResponse
        /// </returns>
        public CancelOrRefundResponse CancelOrRefund(CancelOrRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelOrRefundWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消或退款</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelOrRefundRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelOrRefundResponse
        /// </returns>
        public async Task<CancelOrRefundResponse> CancelOrRefundAsync(CancelOrRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelOrRefundWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelOrderResponse
        /// </returns>
        public CancelOrderResponse CancelOrderWithOptions(CancelOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "cancelOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/cancelOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelOrderResponse
        /// </returns>
        public async Task<CancelOrderResponse> CancelOrderWithOptionsAsync(CancelOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "cancelOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/cancelOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelOrderResponse
        /// </returns>
        public CancelOrderResponse CancelOrder(CancelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelOrderResponse
        /// </returns>
        public async Task<CancelOrderResponse> CancelOrderAsync(CancelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创单并支付</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAndPayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAndPayResponse
        /// </returns>
        public CreateAndPayResponse CreateAndPayWithOptions(CreateAndPayRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAndPayShrinkRequest request = new CreateAndPayShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contact))
            {
                request.ContactShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contact, "Contact", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Guests))
            {
                request.GuestsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Guests, "Guests", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactShrink))
            {
                body["Contact"] = request.ContactShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalOrderNo))
            {
                body["ExternalOrderNo"] = request.ExternalOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestsShrink))
            {
                body["Guests"] = request.GuestsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemOfferId))
            {
                body["ItemOfferId"] = request.ItemOfferId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCount))
            {
                body["RoomCount"] = request.RoomCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "createAndPay",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/createAndPay",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndPayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创单并支付</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAndPayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAndPayResponse
        /// </returns>
        public async Task<CreateAndPayResponse> CreateAndPayWithOptionsAsync(CreateAndPayRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAndPayShrinkRequest request = new CreateAndPayShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contact))
            {
                request.ContactShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contact, "Contact", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Guests))
            {
                request.GuestsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Guests, "Guests", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactShrink))
            {
                body["Contact"] = request.ContactShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalOrderNo))
            {
                body["ExternalOrderNo"] = request.ExternalOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestsShrink))
            {
                body["Guests"] = request.GuestsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemOfferId))
            {
                body["ItemOfferId"] = request.ItemOfferId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCount))
            {
                body["RoomCount"] = request.RoomCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "createAndPay",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/createAndPay",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndPayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创单并支付</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAndPayRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAndPayResponse
        /// </returns>
        public CreateAndPayResponse CreateAndPay(CreateAndPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAndPayWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创单并支付</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAndPayRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAndPayResponse
        /// </returns>
        public async Task<CreateAndPayResponse> CreateAndPayAsync(CreateAndPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAndPayWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建订单</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOrderResponse
        /// </returns>
        public CreateOrderResponse CreateOrderWithOptions(CreateOrderRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateOrderShrinkRequest request = new CreateOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contact))
            {
                request.ContactShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contact, "Contact", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Guests))
            {
                request.GuestsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Guests, "Guests", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactShrink))
            {
                body["Contact"] = request.ContactShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalOrderNo))
            {
                body["ExternalOrderNo"] = request.ExternalOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestsShrink))
            {
                body["Guests"] = request.GuestsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemOfferId))
            {
                body["ItemOfferId"] = request.ItemOfferId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCount))
            {
                body["RoomCount"] = request.RoomCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "createOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/createOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建订单</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOrderResponse
        /// </returns>
        public async Task<CreateOrderResponse> CreateOrderWithOptionsAsync(CreateOrderRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateOrderShrinkRequest request = new CreateOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contact))
            {
                request.ContactShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contact, "Contact", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Guests))
            {
                request.GuestsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Guests, "Guests", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactShrink))
            {
                body["Contact"] = request.ContactShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalOrderNo))
            {
                body["ExternalOrderNo"] = request.ExternalOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestsShrink))
            {
                body["Guests"] = request.GuestsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemOfferId))
            {
                body["ItemOfferId"] = request.ItemOfferId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCount))
            {
                body["RoomCount"] = request.RoomCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "createOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/createOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOrderResponse
        /// </returns>
        public CreateOrderResponse CreateOrder(CreateOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOrderResponse
        /// </returns>
        public async Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies for a refund.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelApplyRefundRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelApplyRefundResponse
        /// </returns>
        public GlobalHotelApplyRefundResponse GlobalHotelApplyRefundWithOptions(GlobalHotelApplyRefundRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundReason))
            {
                body["RefundReason"] = request.RefundReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelApplyRefund",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelApplyRefund",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelApplyRefundResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies for a refund.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelApplyRefundRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelApplyRefundResponse
        /// </returns>
        public async Task<GlobalHotelApplyRefundResponse> GlobalHotelApplyRefundWithOptionsAsync(GlobalHotelApplyRefundRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundReason))
            {
                body["RefundReason"] = request.RefundReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelApplyRefund",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelApplyRefund",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelApplyRefundResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies for a refund.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelApplyRefundRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelApplyRefundResponse
        /// </returns>
        public GlobalHotelApplyRefundResponse GlobalHotelApplyRefund(GlobalHotelApplyRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GlobalHotelApplyRefundWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies for a refund.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelApplyRefundRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelApplyRefundResponse
        /// </returns>
        public async Task<GlobalHotelApplyRefundResponse> GlobalHotelApplyRefundAsync(GlobalHotelApplyRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GlobalHotelApplyRefundWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries hotel details in batches.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GlobalHotelBatchGetHotelDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelBatchGetHotelDetailResponse
        /// </returns>
        public GlobalHotelBatchGetHotelDetailResponse GlobalHotelBatchGetHotelDetailWithOptions(GlobalHotelBatchGetHotelDetailRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GlobalHotelBatchGetHotelDetailShrinkRequest request = new GlobalHotelBatchGetHotelDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StandardHotelIds))
            {
                request.StandardHotelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StandardHotelIds, "StandardHotelIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardHotelIdsShrink))
            {
                body["StandardHotelIds"] = request.StandardHotelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelBatchGetHotelDetail",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelBatchGetHotelDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelBatchGetHotelDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries hotel details in batches.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GlobalHotelBatchGetHotelDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelBatchGetHotelDetailResponse
        /// </returns>
        public async Task<GlobalHotelBatchGetHotelDetailResponse> GlobalHotelBatchGetHotelDetailWithOptionsAsync(GlobalHotelBatchGetHotelDetailRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GlobalHotelBatchGetHotelDetailShrinkRequest request = new GlobalHotelBatchGetHotelDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StandardHotelIds))
            {
                request.StandardHotelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StandardHotelIds, "StandardHotelIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardHotelIdsShrink))
            {
                body["StandardHotelIds"] = request.StandardHotelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelBatchGetHotelDetail",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelBatchGetHotelDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelBatchGetHotelDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries hotel details in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelBatchGetHotelDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelBatchGetHotelDetailResponse
        /// </returns>
        public GlobalHotelBatchGetHotelDetailResponse GlobalHotelBatchGetHotelDetail(GlobalHotelBatchGetHotelDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GlobalHotelBatchGetHotelDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries hotel details in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelBatchGetHotelDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelBatchGetHotelDetailResponse
        /// </returns>
        public async Task<GlobalHotelBatchGetHotelDetailResponse> GlobalHotelBatchGetHotelDetailAsync(GlobalHotelBatchGetHotelDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GlobalHotelBatchGetHotelDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels or refunds an order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelCancelOrRefundRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelCancelOrRefundResponse
        /// </returns>
        public GlobalHotelCancelOrRefundResponse GlobalHotelCancelOrRefundWithOptions(GlobalHotelCancelOrRefundRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelCancelOrRefund",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelCancelOrRefund",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelCancelOrRefundResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels or refunds an order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelCancelOrRefundRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelCancelOrRefundResponse
        /// </returns>
        public async Task<GlobalHotelCancelOrRefundResponse> GlobalHotelCancelOrRefundWithOptionsAsync(GlobalHotelCancelOrRefundRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelCancelOrRefund",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelCancelOrRefund",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelCancelOrRefundResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels or refunds an order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelCancelOrRefundRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelCancelOrRefundResponse
        /// </returns>
        public GlobalHotelCancelOrRefundResponse GlobalHotelCancelOrRefund(GlobalHotelCancelOrRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GlobalHotelCancelOrRefundWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels or refunds an order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelCancelOrRefundRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelCancelOrRefundResponse
        /// </returns>
        public async Task<GlobalHotelCancelOrRefundResponse> GlobalHotelCancelOrRefundAsync(GlobalHotelCancelOrRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GlobalHotelCancelOrRefundWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelCancelOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelCancelOrderResponse
        /// </returns>
        public GlobalHotelCancelOrderResponse GlobalHotelCancelOrderWithOptions(GlobalHotelCancelOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelCancelOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelCancelOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelCancelOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelCancelOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelCancelOrderResponse
        /// </returns>
        public async Task<GlobalHotelCancelOrderResponse> GlobalHotelCancelOrderWithOptionsAsync(GlobalHotelCancelOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelCancelOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelCancelOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelCancelOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelCancelOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelCancelOrderResponse
        /// </returns>
        public GlobalHotelCancelOrderResponse GlobalHotelCancelOrder(GlobalHotelCancelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GlobalHotelCancelOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelCancelOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelCancelOrderResponse
        /// </returns>
        public async Task<GlobalHotelCancelOrderResponse> GlobalHotelCancelOrderAsync(GlobalHotelCancelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GlobalHotelCancelOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an order and processes the payment.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GlobalHotelCreateAndPayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelCreateAndPayResponse
        /// </returns>
        public GlobalHotelCreateAndPayResponse GlobalHotelCreateAndPayWithOptions(GlobalHotelCreateAndPayRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GlobalHotelCreateAndPayShrinkRequest request = new GlobalHotelCreateAndPayShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contact))
            {
                request.ContactShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contact, "Contact", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Guests))
            {
                request.GuestsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Guests, "Guests", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactShrink))
            {
                body["Contact"] = request.ContactShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalOrderNo))
            {
                body["ExternalOrderNo"] = request.ExternalOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestsShrink))
            {
                body["Guests"] = request.GuestsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemOfferId))
            {
                body["ItemOfferId"] = request.ItemOfferId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCount))
            {
                body["RoomCount"] = request.RoomCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelCreateAndPay",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelCreateAndPay",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelCreateAndPayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an order and processes the payment.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GlobalHotelCreateAndPayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelCreateAndPayResponse
        /// </returns>
        public async Task<GlobalHotelCreateAndPayResponse> GlobalHotelCreateAndPayWithOptionsAsync(GlobalHotelCreateAndPayRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GlobalHotelCreateAndPayShrinkRequest request = new GlobalHotelCreateAndPayShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contact))
            {
                request.ContactShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contact, "Contact", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Guests))
            {
                request.GuestsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Guests, "Guests", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactShrink))
            {
                body["Contact"] = request.ContactShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalOrderNo))
            {
                body["ExternalOrderNo"] = request.ExternalOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestsShrink))
            {
                body["Guests"] = request.GuestsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemOfferId))
            {
                body["ItemOfferId"] = request.ItemOfferId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCount))
            {
                body["RoomCount"] = request.RoomCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelCreateAndPay",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelCreateAndPay",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelCreateAndPayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an order and processes the payment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelCreateAndPayRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelCreateAndPayResponse
        /// </returns>
        public GlobalHotelCreateAndPayResponse GlobalHotelCreateAndPay(GlobalHotelCreateAndPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GlobalHotelCreateAndPayWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an order and processes the payment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelCreateAndPayRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelCreateAndPayResponse
        /// </returns>
        public async Task<GlobalHotelCreateAndPayResponse> GlobalHotelCreateAndPayAsync(GlobalHotelCreateAndPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GlobalHotelCreateAndPayWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an order.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GlobalHotelCreateOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelCreateOrderResponse
        /// </returns>
        public GlobalHotelCreateOrderResponse GlobalHotelCreateOrderWithOptions(GlobalHotelCreateOrderRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GlobalHotelCreateOrderShrinkRequest request = new GlobalHotelCreateOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contact))
            {
                request.ContactShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contact, "Contact", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Guests))
            {
                request.GuestsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Guests, "Guests", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactShrink))
            {
                body["Contact"] = request.ContactShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalOrderNo))
            {
                body["ExternalOrderNo"] = request.ExternalOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestsShrink))
            {
                body["Guests"] = request.GuestsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemOfferId))
            {
                body["ItemOfferId"] = request.ItemOfferId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCount))
            {
                body["RoomCount"] = request.RoomCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelCreateOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelCreateOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelCreateOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an order.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GlobalHotelCreateOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelCreateOrderResponse
        /// </returns>
        public async Task<GlobalHotelCreateOrderResponse> GlobalHotelCreateOrderWithOptionsAsync(GlobalHotelCreateOrderRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GlobalHotelCreateOrderShrinkRequest request = new GlobalHotelCreateOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contact))
            {
                request.ContactShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contact, "Contact", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Guests))
            {
                request.GuestsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Guests, "Guests", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactShrink))
            {
                body["Contact"] = request.ContactShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalOrderNo))
            {
                body["ExternalOrderNo"] = request.ExternalOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestsShrink))
            {
                body["Guests"] = request.GuestsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemOfferId))
            {
                body["ItemOfferId"] = request.ItemOfferId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCount))
            {
                body["RoomCount"] = request.RoomCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelCreateOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelCreateOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelCreateOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelCreateOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelCreateOrderResponse
        /// </returns>
        public GlobalHotelCreateOrderResponse GlobalHotelCreateOrder(GlobalHotelCreateOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GlobalHotelCreateOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelCreateOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelCreateOrderResponse
        /// </returns>
        public async Task<GlobalHotelCreateOrderResponse> GlobalHotelCreateOrderAsync(GlobalHotelCreateOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GlobalHotelCreateOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Processes a distribution payment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelPayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelPayResponse
        /// </returns>
        public GlobalHotelPayResponse GlobalHotelPayWithOptions(GlobalHotelPayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelPay",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelPay",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelPayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Processes a distribution payment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelPayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelPayResponse
        /// </returns>
        public async Task<GlobalHotelPayResponse> GlobalHotelPayWithOptionsAsync(GlobalHotelPayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelPay",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelPay",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelPayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Processes a distribution payment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelPayRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelPayResponse
        /// </returns>
        public GlobalHotelPayResponse GlobalHotelPay(GlobalHotelPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GlobalHotelPayWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Processes a distribution payment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelPayRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelPayResponse
        /// </returns>
        public async Task<GlobalHotelPayResponse> GlobalHotelPayAsync(GlobalHotelPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GlobalHotelPayWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the availability of hotel rate plans.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GlobalHotelQueryAvailabilityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelQueryAvailabilityResponse
        /// </returns>
        public GlobalHotelQueryAvailabilityResponse GlobalHotelQueryAvailabilityWithOptions(GlobalHotelQueryAvailabilityRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GlobalHotelQueryAvailabilityShrinkRequest request = new GlobalHotelQueryAvailabilityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChildrenAges))
            {
                request.ChildrenAgesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChildrenAges, "ChildrenAges", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StandardHotelIds))
            {
                request.StandardHotelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StandardHotelIds, "StandardHotelIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdultCount))
            {
                body["AdultCount"] = request.AdultCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckInDate))
            {
                body["CheckInDate"] = request.CheckInDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckOutDate))
            {
                body["CheckOutDate"] = request.CheckOutDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildCount))
            {
                body["ChildCount"] = request.ChildCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildrenAgesShrink))
            {
                body["ChildrenAges"] = request.ChildrenAgesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCount))
            {
                body["RoomCount"] = request.RoomCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardHotelIdsShrink))
            {
                body["StandardHotelIds"] = request.StandardHotelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelQueryAvailability",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelQueryAvailability",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelQueryAvailabilityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the availability of hotel rate plans.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GlobalHotelQueryAvailabilityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelQueryAvailabilityResponse
        /// </returns>
        public async Task<GlobalHotelQueryAvailabilityResponse> GlobalHotelQueryAvailabilityWithOptionsAsync(GlobalHotelQueryAvailabilityRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GlobalHotelQueryAvailabilityShrinkRequest request = new GlobalHotelQueryAvailabilityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChildrenAges))
            {
                request.ChildrenAgesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChildrenAges, "ChildrenAges", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StandardHotelIds))
            {
                request.StandardHotelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StandardHotelIds, "StandardHotelIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdultCount))
            {
                body["AdultCount"] = request.AdultCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckInDate))
            {
                body["CheckInDate"] = request.CheckInDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckOutDate))
            {
                body["CheckOutDate"] = request.CheckOutDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildCount))
            {
                body["ChildCount"] = request.ChildCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildrenAgesShrink))
            {
                body["ChildrenAges"] = request.ChildrenAgesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCount))
            {
                body["RoomCount"] = request.RoomCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardHotelIdsShrink))
            {
                body["StandardHotelIds"] = request.StandardHotelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelQueryAvailability",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelQueryAvailability",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelQueryAvailabilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the availability of hotel rate plans.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelQueryAvailabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelQueryAvailabilityResponse
        /// </returns>
        public GlobalHotelQueryAvailabilityResponse GlobalHotelQueryAvailability(GlobalHotelQueryAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GlobalHotelQueryAvailabilityWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the availability of hotel rate plans.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelQueryAvailabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelQueryAvailabilityResponse
        /// </returns>
        public async Task<GlobalHotelQueryAvailabilityResponse> GlobalHotelQueryAvailabilityAsync(GlobalHotelQueryAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GlobalHotelQueryAvailabilityWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries calendar-based rate availability for hotels in batch.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GlobalHotelQueryCalendarAvailabilityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelQueryCalendarAvailabilityResponse
        /// </returns>
        public GlobalHotelQueryCalendarAvailabilityResponse GlobalHotelQueryCalendarAvailabilityWithOptions(GlobalHotelQueryCalendarAvailabilityRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GlobalHotelQueryCalendarAvailabilityShrinkRequest request = new GlobalHotelQueryCalendarAvailabilityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChildrenAges))
            {
                request.ChildrenAgesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChildrenAges, "ChildrenAges", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StandardHotelIds))
            {
                request.StandardHotelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StandardHotelIds, "StandardHotelIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdultCount))
            {
                body["AdultCount"] = request.AdultCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckInDateEnd))
            {
                body["CheckInDateEnd"] = request.CheckInDateEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckInDateStart))
            {
                body["CheckInDateStart"] = request.CheckInDateStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildCount))
            {
                body["ChildCount"] = request.ChildCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildrenAgesShrink))
            {
                body["ChildrenAges"] = request.ChildrenAgesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCount))
            {
                body["RoomCount"] = request.RoomCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardHotelIdsShrink))
            {
                body["StandardHotelIds"] = request.StandardHotelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelQueryCalendarAvailability",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelQueryCalendarAvailability",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelQueryCalendarAvailabilityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries calendar-based rate availability for hotels in batch.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GlobalHotelQueryCalendarAvailabilityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelQueryCalendarAvailabilityResponse
        /// </returns>
        public async Task<GlobalHotelQueryCalendarAvailabilityResponse> GlobalHotelQueryCalendarAvailabilityWithOptionsAsync(GlobalHotelQueryCalendarAvailabilityRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GlobalHotelQueryCalendarAvailabilityShrinkRequest request = new GlobalHotelQueryCalendarAvailabilityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChildrenAges))
            {
                request.ChildrenAgesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChildrenAges, "ChildrenAges", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StandardHotelIds))
            {
                request.StandardHotelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StandardHotelIds, "StandardHotelIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdultCount))
            {
                body["AdultCount"] = request.AdultCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckInDateEnd))
            {
                body["CheckInDateEnd"] = request.CheckInDateEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckInDateStart))
            {
                body["CheckInDateStart"] = request.CheckInDateStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildCount))
            {
                body["ChildCount"] = request.ChildCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildrenAgesShrink))
            {
                body["ChildrenAges"] = request.ChildrenAgesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCount))
            {
                body["RoomCount"] = request.RoomCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardHotelIdsShrink))
            {
                body["StandardHotelIds"] = request.StandardHotelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelQueryCalendarAvailability",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelQueryCalendarAvailability",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelQueryCalendarAvailabilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries calendar-based rate availability for hotels in batch.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelQueryCalendarAvailabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelQueryCalendarAvailabilityResponse
        /// </returns>
        public GlobalHotelQueryCalendarAvailabilityResponse GlobalHotelQueryCalendarAvailability(GlobalHotelQueryCalendarAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GlobalHotelQueryCalendarAvailabilityWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries calendar-based rate availability for hotels in batch.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelQueryCalendarAvailabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelQueryCalendarAvailabilityResponse
        /// </returns>
        public async Task<GlobalHotelQueryCalendarAvailabilityResponse> GlobalHotelQueryCalendarAvailabilityAsync(GlobalHotelQueryCalendarAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GlobalHotelQueryCalendarAvailabilityWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelQueryOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelQueryOrderResponse
        /// </returns>
        public GlobalHotelQueryOrderResponse GlobalHotelQueryOrderWithOptions(GlobalHotelQueryOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalOrderNo))
            {
                body["ExternalOrderNo"] = request.ExternalOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelQueryOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelQueryOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelQueryOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelQueryOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelQueryOrderResponse
        /// </returns>
        public async Task<GlobalHotelQueryOrderResponse> GlobalHotelQueryOrderWithOptionsAsync(GlobalHotelQueryOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalOrderNo))
            {
                body["ExternalOrderNo"] = request.ExternalOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelQueryOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelQueryOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelQueryOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelQueryOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelQueryOrderResponse
        /// </returns>
        public GlobalHotelQueryOrderResponse GlobalHotelQueryOrder(GlobalHotelQueryOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GlobalHotelQueryOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelQueryOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelQueryOrderResponse
        /// </returns>
        public async Task<GlobalHotelQueryOrderResponse> GlobalHotelQueryOrderAsync(GlobalHotelQueryOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GlobalHotelQueryOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries city administrative divisions (in Chinese and English) by paging.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelSearchCityPageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelSearchCityPageResponse
        /// </returns>
        public GlobalHotelSearchCityPageResponse GlobalHotelSearchCityPageWithOptions(GlobalHotelSearchCityPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                body["Count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCode))
            {
                body["CountryCode"] = request.CountryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelSearchCityPage",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelSearchCityPage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelSearchCityPageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries city administrative divisions (in Chinese and English) by paging.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelSearchCityPageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelSearchCityPageResponse
        /// </returns>
        public async Task<GlobalHotelSearchCityPageResponse> GlobalHotelSearchCityPageWithOptionsAsync(GlobalHotelSearchCityPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                body["Count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCode))
            {
                body["CountryCode"] = request.CountryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelSearchCityPage",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelSearchCityPage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelSearchCityPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries city administrative divisions (in Chinese and English) by paging.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelSearchCityPageRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelSearchCityPageResponse
        /// </returns>
        public GlobalHotelSearchCityPageResponse GlobalHotelSearchCityPage(GlobalHotelSearchCityPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GlobalHotelSearchCityPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries city administrative divisions (in Chinese and English) by paging.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelSearchCityPageRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelSearchCityPageResponse
        /// </returns>
        public async Task<GlobalHotelSearchCityPageResponse> GlobalHotelSearchCityPageAsync(GlobalHotelSearchCityPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GlobalHotelSearchCityPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paged query of the hotel list by city with paging support.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelSearchHotelListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelSearchHotelListResponse
        /// </returns>
        public GlobalHotelSearchHotelListResponse GlobalHotelSearchHotelListWithOptions(GlobalHotelSearchHotelListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                body["CityCode"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelSearchHotelList",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelSearchHotelList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelSearchHotelListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paged query of the hotel list by city with paging support.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelSearchHotelListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelSearchHotelListResponse
        /// </returns>
        public async Task<GlobalHotelSearchHotelListResponse> GlobalHotelSearchHotelListWithOptionsAsync(GlobalHotelSearchHotelListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                body["CityCode"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelSearchHotelList",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelSearchHotelList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelSearchHotelListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paged query of the hotel list by city with paging support.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelSearchHotelListRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelSearchHotelListResponse
        /// </returns>
        public GlobalHotelSearchHotelListResponse GlobalHotelSearchHotelList(GlobalHotelSearchHotelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GlobalHotelSearchHotelListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paged query of the hotel list by city with paging support.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelSearchHotelListRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelSearchHotelListResponse
        /// </returns>
        public async Task<GlobalHotelSearchHotelListResponse> GlobalHotelSearchHotelListAsync(GlobalHotelSearchHotelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GlobalHotelSearchHotelListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates the price of a hotel offer.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GlobalHotelValidatePriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelValidatePriceResponse
        /// </returns>
        public GlobalHotelValidatePriceResponse GlobalHotelValidatePriceWithOptions(GlobalHotelValidatePriceRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GlobalHotelValidatePriceShrinkRequest request = new GlobalHotelValidatePriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChildrenAges))
            {
                request.ChildrenAgesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChildrenAges, "ChildrenAges", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Adults))
            {
                body["Adults"] = request.Adults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Children))
            {
                body["Children"] = request.Children;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildrenAgesShrink))
            {
                body["ChildrenAges"] = request.ChildrenAgesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemOfferKey))
            {
                body["ItemOfferKey"] = request.ItemOfferKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCount))
            {
                body["RoomCount"] = request.RoomCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelValidatePrice",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelValidatePrice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelValidatePriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates the price of a hotel offer.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GlobalHotelValidatePriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelValidatePriceResponse
        /// </returns>
        public async Task<GlobalHotelValidatePriceResponse> GlobalHotelValidatePriceWithOptionsAsync(GlobalHotelValidatePriceRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GlobalHotelValidatePriceShrinkRequest request = new GlobalHotelValidatePriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChildrenAges))
            {
                request.ChildrenAgesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChildrenAges, "ChildrenAges", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Adults))
            {
                body["Adults"] = request.Adults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Children))
            {
                body["Children"] = request.Children;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildrenAgesShrink))
            {
                body["ChildrenAges"] = request.ChildrenAgesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemOfferKey))
            {
                body["ItemOfferKey"] = request.ItemOfferKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCount))
            {
                body["RoomCount"] = request.RoomCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "globalHotelValidatePrice",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotelValidatePrice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalHotelValidatePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates the price of a hotel offer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelValidatePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelValidatePriceResponse
        /// </returns>
        public GlobalHotelValidatePriceResponse GlobalHotelValidatePrice(GlobalHotelValidatePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GlobalHotelValidatePriceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates the price of a hotel offer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GlobalHotelValidatePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalHotelValidatePriceResponse
        /// </returns>
        public async Task<GlobalHotelValidatePriceResponse> GlobalHotelValidatePriceAsync(GlobalHotelValidatePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GlobalHotelValidatePriceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分销支付</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PayResponse
        /// </returns>
        public PayResponse PayWithOptions(PayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "pay",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/pay",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分销支付</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PayResponse
        /// </returns>
        public async Task<PayResponse> PayWithOptionsAsync(PayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "pay",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/pay",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分销支付</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PayRequest
        /// </param>
        /// 
        /// <returns>
        /// PayResponse
        /// </returns>
        public PayResponse Pay(PayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PayWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分销支付</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PayRequest
        /// </param>
        /// 
        /// <returns>
        /// PayResponse
        /// </returns>
        public async Task<PayResponse> PayAsync(PayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PayWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询酒店报价可用性</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryAvailabilityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAvailabilityResponse
        /// </returns>
        public QueryAvailabilityResponse QueryAvailabilityWithOptions(QueryAvailabilityRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryAvailabilityShrinkRequest request = new QueryAvailabilityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChildrenAges))
            {
                request.ChildrenAgesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChildrenAges, "ChildrenAges", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StandardHotelIds))
            {
                request.StandardHotelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StandardHotelIds, "StandardHotelIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdultCount))
            {
                body["AdultCount"] = request.AdultCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckInDate))
            {
                body["CheckInDate"] = request.CheckInDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckOutDate))
            {
                body["CheckOutDate"] = request.CheckOutDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildCount))
            {
                body["ChildCount"] = request.ChildCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildrenAgesShrink))
            {
                body["ChildrenAges"] = request.ChildrenAgesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCount))
            {
                body["RoomCount"] = request.RoomCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardHotelIdsShrink))
            {
                body["StandardHotelIds"] = request.StandardHotelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "queryAvailability",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/queryAvailability",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAvailabilityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询酒店报价可用性</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryAvailabilityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAvailabilityResponse
        /// </returns>
        public async Task<QueryAvailabilityResponse> QueryAvailabilityWithOptionsAsync(QueryAvailabilityRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryAvailabilityShrinkRequest request = new QueryAvailabilityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChildrenAges))
            {
                request.ChildrenAgesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChildrenAges, "ChildrenAges", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StandardHotelIds))
            {
                request.StandardHotelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StandardHotelIds, "StandardHotelIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdultCount))
            {
                body["AdultCount"] = request.AdultCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckInDate))
            {
                body["CheckInDate"] = request.CheckInDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckOutDate))
            {
                body["CheckOutDate"] = request.CheckOutDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildCount))
            {
                body["ChildCount"] = request.ChildCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildrenAgesShrink))
            {
                body["ChildrenAges"] = request.ChildrenAgesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCount))
            {
                body["RoomCount"] = request.RoomCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardHotelIdsShrink))
            {
                body["StandardHotelIds"] = request.StandardHotelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "queryAvailability",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/queryAvailability",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAvailabilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询酒店报价可用性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvailabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAvailabilityResponse
        /// </returns>
        public QueryAvailabilityResponse QueryAvailability(QueryAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryAvailabilityWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询酒店报价可用性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvailabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAvailabilityResponse
        /// </returns>
        public async Task<QueryAvailabilityResponse> QueryAvailabilityAsync(QueryAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryAvailabilityWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量日历报价查询</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryCalendarAvailabilityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCalendarAvailabilityResponse
        /// </returns>
        public QueryCalendarAvailabilityResponse QueryCalendarAvailabilityWithOptions(QueryCalendarAvailabilityRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryCalendarAvailabilityShrinkRequest request = new QueryCalendarAvailabilityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChildrenAges))
            {
                request.ChildrenAgesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChildrenAges, "ChildrenAges", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StandardHotelIds))
            {
                request.StandardHotelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StandardHotelIds, "StandardHotelIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdultCount))
            {
                body["AdultCount"] = request.AdultCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckInDateEnd))
            {
                body["CheckInDateEnd"] = request.CheckInDateEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckInDateStart))
            {
                body["CheckInDateStart"] = request.CheckInDateStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildCount))
            {
                body["ChildCount"] = request.ChildCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildrenAgesShrink))
            {
                body["ChildrenAges"] = request.ChildrenAgesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCount))
            {
                body["RoomCount"] = request.RoomCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardHotelIdsShrink))
            {
                body["StandardHotelIds"] = request.StandardHotelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "queryCalendarAvailability",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/queryCalendarAvailability",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCalendarAvailabilityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量日历报价查询</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryCalendarAvailabilityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCalendarAvailabilityResponse
        /// </returns>
        public async Task<QueryCalendarAvailabilityResponse> QueryCalendarAvailabilityWithOptionsAsync(QueryCalendarAvailabilityRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryCalendarAvailabilityShrinkRequest request = new QueryCalendarAvailabilityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChildrenAges))
            {
                request.ChildrenAgesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChildrenAges, "ChildrenAges", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StandardHotelIds))
            {
                request.StandardHotelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StandardHotelIds, "StandardHotelIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdultCount))
            {
                body["AdultCount"] = request.AdultCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckInDateEnd))
            {
                body["CheckInDateEnd"] = request.CheckInDateEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckInDateStart))
            {
                body["CheckInDateStart"] = request.CheckInDateStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildCount))
            {
                body["ChildCount"] = request.ChildCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildrenAgesShrink))
            {
                body["ChildrenAges"] = request.ChildrenAgesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCount))
            {
                body["RoomCount"] = request.RoomCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardHotelIdsShrink))
            {
                body["StandardHotelIds"] = request.StandardHotelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "queryCalendarAvailability",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/queryCalendarAvailability",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCalendarAvailabilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量日历报价查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCalendarAvailabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCalendarAvailabilityResponse
        /// </returns>
        public QueryCalendarAvailabilityResponse QueryCalendarAvailability(QueryCalendarAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryCalendarAvailabilityWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量日历报价查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCalendarAvailabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCalendarAvailabilityResponse
        /// </returns>
        public async Task<QueryCalendarAvailabilityResponse> QueryCalendarAvailabilityAsync(QueryCalendarAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryCalendarAvailabilityWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOrderResponse
        /// </returns>
        public QueryOrderResponse QueryOrderWithOptions(QueryOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalOrderNo))
            {
                body["ExternalOrderNo"] = request.ExternalOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "queryOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/queryOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOrderResponse
        /// </returns>
        public async Task<QueryOrderResponse> QueryOrderWithOptionsAsync(QueryOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalOrderNo))
            {
                body["ExternalOrderNo"] = request.ExternalOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "queryOrder",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/queryOrder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOrderResponse
        /// </returns>
        public QueryOrderResponse QueryOrder(QueryOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOrderResponse
        /// </returns>
        public async Task<QueryOrderResponse> QueryOrderAsync(QueryOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询城市行政区划（中英文）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchCityPageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchCityPageResponse
        /// </returns>
        public SearchCityPageResponse SearchCityPageWithOptions(SearchCityPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                body["Count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCode))
            {
                body["CountryCode"] = request.CountryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "searchCityPage",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/searchCityPage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchCityPageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询城市行政区划（中英文）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchCityPageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchCityPageResponse
        /// </returns>
        public async Task<SearchCityPageResponse> SearchCityPageWithOptionsAsync(SearchCityPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                body["Count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCode))
            {
                body["CountryCode"] = request.CountryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "searchCityPage",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/searchCityPage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchCityPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询城市行政区划（中英文）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchCityPageRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchCityPageResponse
        /// </returns>
        public SearchCityPageResponse SearchCityPage(SearchCityPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchCityPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询城市行政区划（中英文）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchCityPageRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchCityPageResponse
        /// </returns>
        public async Task<SearchCityPageResponse> SearchCityPageAsync(SearchCityPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchCityPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按城市分页查询酒店列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchHotelListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchHotelListResponse
        /// </returns>
        public SearchHotelListResponse SearchHotelListWithOptions(SearchHotelListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                body["CityCode"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "searchHotelList",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotel/searchHotelList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchHotelListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按城市分页查询酒店列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchHotelListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchHotelListResponse
        /// </returns>
        public async Task<SearchHotelListResponse> SearchHotelListWithOptionsAsync(SearchHotelListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                body["CityCode"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "searchHotelList",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/globalHotel/searchHotelList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchHotelListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按城市分页查询酒店列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchHotelListRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchHotelListResponse
        /// </returns>
        public SearchHotelListResponse SearchHotelList(SearchHotelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchHotelListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按城市分页查询酒店列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchHotelListRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchHotelListResponse
        /// </returns>
        public async Task<SearchHotelListResponse> SearchHotelListAsync(SearchHotelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchHotelListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>验价</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ValidatePriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidatePriceResponse
        /// </returns>
        public ValidatePriceResponse ValidatePriceWithOptions(ValidatePriceRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ValidatePriceShrinkRequest request = new ValidatePriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChildrenAges))
            {
                request.ChildrenAgesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChildrenAges, "ChildrenAges", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Adults))
            {
                body["Adults"] = request.Adults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Children))
            {
                body["Children"] = request.Children;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildrenAgesShrink))
            {
                body["ChildrenAges"] = request.ChildrenAgesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemOfferKey))
            {
                body["ItemOfferKey"] = request.ItemOfferKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCount))
            {
                body["RoomCount"] = request.RoomCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "validatePrice",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/validatePrice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidatePriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>验价</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ValidatePriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidatePriceResponse
        /// </returns>
        public async Task<ValidatePriceResponse> ValidatePriceWithOptionsAsync(ValidatePriceRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ValidatePriceShrinkRequest request = new ValidatePriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChildrenAges))
            {
                request.ChildrenAgesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChildrenAges, "ChildrenAges", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Adults))
            {
                body["Adults"] = request.Adults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Children))
            {
                body["Children"] = request.Children;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildrenAgesShrink))
            {
                body["ChildrenAges"] = request.ChildrenAgesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemOfferKey))
            {
                body["ItemOfferKey"] = request.ItemOfferKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCount))
            {
                body["RoomCount"] = request.RoomCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracerId))
            {
                body["TracerId"] = request.TracerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "validatePrice",
                Version = "2023-01-17",
                Protocol = "HTTPS",
                Pathname = "/validatePrice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidatePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>验价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidatePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidatePriceResponse
        /// </returns>
        public ValidatePriceResponse ValidatePrice(ValidatePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ValidatePriceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>验价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidatePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidatePriceResponse
        /// </returns>
        public async Task<ValidatePriceResponse> ValidatePriceAsync(ValidatePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ValidatePriceWithOptionsAsync(request, headers, runtime);
        }

    }
}
