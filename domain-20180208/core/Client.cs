// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Domain20180208.Models;

namespace AlibabaCloud.SDK.Domain20180208
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("domain", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @param request AcceptDemandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AcceptDemandResponse
         */
        public AcceptDemandResponse AcceptDemandWithOptions(AcceptDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcceptDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptDemandResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request AcceptDemandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AcceptDemandResponse
         */
        public async Task<AcceptDemandResponse> AcceptDemandWithOptionsAsync(AcceptDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcceptDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptDemandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request AcceptDemandRequest
         * @return AcceptDemandResponse
         */
        public AcceptDemandResponse AcceptDemand(AcceptDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AcceptDemandWithOptions(request, runtime);
        }

        /**
         * @param request AcceptDemandRequest
         * @return AcceptDemandResponse
         */
        public async Task<AcceptDemandResponse> AcceptDemandAsync(AcceptDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AcceptDemandWithOptionsAsync(request, runtime);
        }

        /**
         * @param request BidDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BidDomainResponse
         */
        public BidDomainResponse BidDomainWithOptions(BidDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionId))
            {
                body["AuctionId"] = request.AuctionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxBid))
            {
                body["MaxBid"] = request.MaxBid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BidDomain",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BidDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request BidDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BidDomainResponse
         */
        public async Task<BidDomainResponse> BidDomainWithOptionsAsync(BidDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionId))
            {
                body["AuctionId"] = request.AuctionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxBid))
            {
                body["MaxBid"] = request.MaxBid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BidDomain",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BidDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request BidDomainRequest
         * @return BidDomainResponse
         */
        public BidDomainResponse BidDomain(BidDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BidDomainWithOptions(request, runtime);
        }

        /**
         * @param request BidDomainRequest
         * @return BidDomainResponse
         */
        public async Task<BidDomainResponse> BidDomainAsync(BidDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BidDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ChangeAuctionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeAuctionResponse
         */
        public ChangeAuctionResponse ChangeAuctionWithOptions(ChangeAuctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionList))
            {
                body["AuctionList"] = request.AuctionList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeAuction",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeAuctionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ChangeAuctionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeAuctionResponse
         */
        public async Task<ChangeAuctionResponse> ChangeAuctionWithOptionsAsync(ChangeAuctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionList))
            {
                body["AuctionList"] = request.AuctionList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeAuction",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeAuctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ChangeAuctionRequest
         * @return ChangeAuctionResponse
         */
        public ChangeAuctionResponse ChangeAuction(ChangeAuctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeAuctionWithOptions(request, runtime);
        }

        /**
         * @param request ChangeAuctionRequest
         * @return ChangeAuctionResponse
         */
        public async Task<ChangeAuctionResponse> ChangeAuctionAsync(ChangeAuctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeAuctionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 校验域名在售状态
         *
         * @param request CheckDomainStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckDomainStatusResponse
         */
        public CheckDomainStatusResponse CheckDomainStatusWithOptions(CheckDomainStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDomainStatus",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDomainStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 校验域名在售状态
         *
         * @param request CheckDomainStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckDomainStatusResponse
         */
        public async Task<CheckDomainStatusResponse> CheckDomainStatusWithOptionsAsync(CheckDomainStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDomainStatus",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDomainStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 校验域名在售状态
         *
         * @param request CheckDomainStatusRequest
         * @return CheckDomainStatusResponse
         */
        public CheckDomainStatusResponse CheckDomainStatus(CheckDomainStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDomainStatusWithOptions(request, runtime);
        }

        /**
         * @summary 校验域名在售状态
         *
         * @param request CheckDomainStatusRequest
         * @return CheckDomainStatusResponse
         */
        public async Task<CheckDomainStatusResponse> CheckDomainStatusAsync(CheckDomainStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDomainStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 一口价严选询价接口
         *
         * @param request CheckSelectedDomainStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckSelectedDomainStatusResponse
         */
        public CheckSelectedDomainStatusResponse CheckSelectedDomainStatusWithOptions(CheckSelectedDomainStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckSelectedDomainStatus",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSelectedDomainStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 一口价严选询价接口
         *
         * @param request CheckSelectedDomainStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckSelectedDomainStatusResponse
         */
        public async Task<CheckSelectedDomainStatusResponse> CheckSelectedDomainStatusWithOptionsAsync(CheckSelectedDomainStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckSelectedDomainStatus",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSelectedDomainStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 一口价严选询价接口
         *
         * @param request CheckSelectedDomainStatusRequest
         * @return CheckSelectedDomainStatusResponse
         */
        public CheckSelectedDomainStatusResponse CheckSelectedDomainStatus(CheckSelectedDomainStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckSelectedDomainStatusWithOptions(request, runtime);
        }

        /**
         * @summary 一口价严选询价接口
         *
         * @param request CheckSelectedDomainStatusRequest
         * @return CheckSelectedDomainStatusResponse
         */
        public async Task<CheckSelectedDomainStatusResponse> CheckSelectedDomainStatusAsync(CheckSelectedDomainStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckSelectedDomainStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建一口价需求单
         *
         * @param request CreateFixedPriceDemandOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFixedPriceDemandOrderResponse
         */
        public CreateFixedPriceDemandOrderResponse CreateFixedPriceDemandOrderWithOptions(CreateFixedPriceDemandOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFixedPriceDemandOrder",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFixedPriceDemandOrderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建一口价需求单
         *
         * @param request CreateFixedPriceDemandOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFixedPriceDemandOrderResponse
         */
        public async Task<CreateFixedPriceDemandOrderResponse> CreateFixedPriceDemandOrderWithOptionsAsync(CreateFixedPriceDemandOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFixedPriceDemandOrder",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFixedPriceDemandOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建一口价需求单
         *
         * @param request CreateFixedPriceDemandOrderRequest
         * @return CreateFixedPriceDemandOrderResponse
         */
        public CreateFixedPriceDemandOrderResponse CreateFixedPriceDemandOrder(CreateFixedPriceDemandOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFixedPriceDemandOrderWithOptions(request, runtime);
        }

        /**
         * @summary 创建一口价需求单
         *
         * @param request CreateFixedPriceDemandOrderRequest
         * @return CreateFixedPriceDemandOrderResponse
         */
        public async Task<CreateFixedPriceDemandOrderResponse> CreateFixedPriceDemandOrderAsync(CreateFixedPriceDemandOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFixedPriceDemandOrderWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 一口价严选下单购买接口，阿里云账户余额直接扣费
         *
         * @param request CreateFixedPriceSelectedOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFixedPriceSelectedOrderResponse
         */
        public CreateFixedPriceSelectedOrderResponse CreateFixedPriceSelectedOrderWithOptions(CreateFixedPriceSelectedOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectedPrice))
            {
                query["ExpectedPrice"] = request.ExpectedPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFixedPriceSelectedOrder",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFixedPriceSelectedOrderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 一口价严选下单购买接口，阿里云账户余额直接扣费
         *
         * @param request CreateFixedPriceSelectedOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFixedPriceSelectedOrderResponse
         */
        public async Task<CreateFixedPriceSelectedOrderResponse> CreateFixedPriceSelectedOrderWithOptionsAsync(CreateFixedPriceSelectedOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectedPrice))
            {
                query["ExpectedPrice"] = request.ExpectedPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFixedPriceSelectedOrder",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFixedPriceSelectedOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 一口价严选下单购买接口，阿里云账户余额直接扣费
         *
         * @param request CreateFixedPriceSelectedOrderRequest
         * @return CreateFixedPriceSelectedOrderResponse
         */
        public CreateFixedPriceSelectedOrderResponse CreateFixedPriceSelectedOrder(CreateFixedPriceSelectedOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFixedPriceSelectedOrderWithOptions(request, runtime);
        }

        /**
         * @summary 一口价严选下单购买接口，阿里云账户余额直接扣费
         *
         * @param request CreateFixedPriceSelectedOrderRequest
         * @return CreateFixedPriceSelectedOrderResponse
         */
        public async Task<CreateFixedPriceSelectedOrderResponse> CreateFixedPriceSelectedOrderAsync(CreateFixedPriceSelectedOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFixedPriceSelectedOrderWithOptionsAsync(request, runtime);
        }

        /**
         * @param request FailDemandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FailDemandResponse
         */
        public FailDemandResponse FailDemandWithOptions(FailDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FailDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FailDemandResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request FailDemandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FailDemandResponse
         */
        public async Task<FailDemandResponse> FailDemandWithOptionsAsync(FailDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FailDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FailDemandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request FailDemandRequest
         * @return FailDemandResponse
         */
        public FailDemandResponse FailDemand(FailDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FailDemandWithOptions(request, runtime);
        }

        /**
         * @param request FailDemandRequest
         * @return FailDemandResponse
         */
        public async Task<FailDemandResponse> FailDemandAsync(FailDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FailDemandWithOptionsAsync(request, runtime);
        }

        /**
         * @param request FinishDemandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FinishDemandResponse
         */
        public FinishDemandResponse FinishDemandWithOptions(FinishDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FinishDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinishDemandResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request FinishDemandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FinishDemandResponse
         */
        public async Task<FinishDemandResponse> FinishDemandWithOptionsAsync(FinishDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FinishDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinishDemandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request FinishDemandRequest
         * @return FinishDemandResponse
         */
        public FinishDemandResponse FinishDemand(FinishDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FinishDemandWithOptions(request, runtime);
        }

        /**
         * @param request FinishDemandRequest
         * @return FinishDemandResponse
         */
        public async Task<FinishDemandResponse> FinishDemandAsync(FinishDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FinishDemandWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetIntlDomainDownloadUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIntlDomainDownloadUrlResponse
         */
        public GetIntlDomainDownloadUrlResponse GetIntlDomainDownloadUrlWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIntlDomainDownloadUrl",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIntlDomainDownloadUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetIntlDomainDownloadUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIntlDomainDownloadUrlResponse
         */
        public async Task<GetIntlDomainDownloadUrlResponse> GetIntlDomainDownloadUrlWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIntlDomainDownloadUrl",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIntlDomainDownloadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return GetIntlDomainDownloadUrlResponse
         */
        public GetIntlDomainDownloadUrlResponse GetIntlDomainDownloadUrl()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIntlDomainDownloadUrlWithOptions(runtime);
        }

        /**
         * @return GetIntlDomainDownloadUrlResponse
         */
        public async Task<GetIntlDomainDownloadUrlResponse> GetIntlDomainDownloadUrlAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIntlDomainDownloadUrlWithOptionsAsync(runtime);
        }

        /**
         * @param request GetReserveDomainUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetReserveDomainUrlResponse
         */
        public GetReserveDomainUrlResponse GetReserveDomainUrlWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReserveDomainUrl",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReserveDomainUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetReserveDomainUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetReserveDomainUrlResponse
         */
        public async Task<GetReserveDomainUrlResponse> GetReserveDomainUrlWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReserveDomainUrl",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReserveDomainUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return GetReserveDomainUrlResponse
         */
        public GetReserveDomainUrlResponse GetReserveDomainUrl()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetReserveDomainUrlWithOptions(runtime);
        }

        /**
         * @return GetReserveDomainUrlResponse
         */
        public async Task<GetReserveDomainUrlResponse> GetReserveDomainUrlAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetReserveDomainUrlWithOptionsAsync(runtime);
        }

        /**
         * @summary 购买国际站预释放域名
         *
         * @param request PurchaseIntlDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PurchaseIntlDomainResponse
         */
        public PurchaseIntlDomainResponse PurchaseIntlDomainWithOptions(PurchaseIntlDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionId))
            {
                body["AuctionId"] = request.AuctionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Price))
            {
                body["Price"] = request.Price;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PurchaseIntlDomain",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PurchaseIntlDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 购买国际站预释放域名
         *
         * @param request PurchaseIntlDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PurchaseIntlDomainResponse
         */
        public async Task<PurchaseIntlDomainResponse> PurchaseIntlDomainWithOptionsAsync(PurchaseIntlDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionId))
            {
                body["AuctionId"] = request.AuctionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Price))
            {
                body["Price"] = request.Price;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PurchaseIntlDomain",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PurchaseIntlDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 购买国际站预释放域名
         *
         * @param request PurchaseIntlDomainRequest
         * @return PurchaseIntlDomainResponse
         */
        public PurchaseIntlDomainResponse PurchaseIntlDomain(PurchaseIntlDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PurchaseIntlDomainWithOptions(request, runtime);
        }

        /**
         * @summary 购买国际站预释放域名
         *
         * @param request PurchaseIntlDomainRequest
         * @return PurchaseIntlDomainResponse
         */
        public async Task<PurchaseIntlDomainResponse> PurchaseIntlDomainAsync(PurchaseIntlDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PurchaseIntlDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryAuctionDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAuctionDetailResponse
         */
        public QueryAuctionDetailResponse QueryAuctionDetailWithOptions(QueryAuctionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionId))
            {
                body["AuctionId"] = request.AuctionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAuctionDetail",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAuctionDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryAuctionDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAuctionDetailResponse
         */
        public async Task<QueryAuctionDetailResponse> QueryAuctionDetailWithOptionsAsync(QueryAuctionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionId))
            {
                body["AuctionId"] = request.AuctionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAuctionDetail",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAuctionDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryAuctionDetailRequest
         * @return QueryAuctionDetailResponse
         */
        public QueryAuctionDetailResponse QueryAuctionDetail(QueryAuctionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAuctionDetailWithOptions(request, runtime);
        }

        /**
         * @param request QueryAuctionDetailRequest
         * @return QueryAuctionDetailResponse
         */
        public async Task<QueryAuctionDetailResponse> QueryAuctionDetailAsync(QueryAuctionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAuctionDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryAuctionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAuctionsResponse
         */
        public QueryAuctionsResponse QueryAuctionsWithOptions(QueryAuctionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionEndTimeOrder))
            {
                body["AuctionEndTimeOrder"] = request.AuctionEndTimeOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statuses))
            {
                body["Statuses"] = request.Statuses;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAuctions",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAuctionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryAuctionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAuctionsResponse
         */
        public async Task<QueryAuctionsResponse> QueryAuctionsWithOptionsAsync(QueryAuctionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionEndTimeOrder))
            {
                body["AuctionEndTimeOrder"] = request.AuctionEndTimeOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statuses))
            {
                body["Statuses"] = request.Statuses;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAuctions",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAuctionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryAuctionsRequest
         * @return QueryAuctionsResponse
         */
        public QueryAuctionsResponse QueryAuctions(QueryAuctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAuctionsWithOptions(request, runtime);
        }

        /**
         * @param request QueryAuctionsRequest
         * @return QueryAuctionsResponse
         */
        public async Task<QueryAuctionsResponse> QueryAuctionsAsync(QueryAuctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAuctionsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryBidRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBidRecordsResponse
         */
        public QueryBidRecordsResponse QueryBidRecordsWithOptions(QueryBidRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionId))
            {
                body["AuctionId"] = request.AuctionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBidRecords",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBidRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryBidRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBidRecordsResponse
         */
        public async Task<QueryBidRecordsResponse> QueryBidRecordsWithOptionsAsync(QueryBidRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionId))
            {
                body["AuctionId"] = request.AuctionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBidRecords",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBidRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryBidRecordsRequest
         * @return QueryBidRecordsResponse
         */
        public QueryBidRecordsResponse QueryBidRecords(QueryBidRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBidRecordsWithOptions(request, runtime);
        }

        /**
         * @param request QueryBidRecordsRequest
         * @return QueryBidRecordsResponse
         */
        public async Task<QueryBidRecordsResponse> QueryBidRecordsAsync(QueryBidRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBidRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryBookingDomainInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBookingDomainInfoResponse
         */
        public QueryBookingDomainInfoResponse QueryBookingDomainInfoWithOptions(QueryBookingDomainInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBookingDomainInfo",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBookingDomainInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryBookingDomainInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBookingDomainInfoResponse
         */
        public async Task<QueryBookingDomainInfoResponse> QueryBookingDomainInfoWithOptionsAsync(QueryBookingDomainInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBookingDomainInfo",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBookingDomainInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryBookingDomainInfoRequest
         * @return QueryBookingDomainInfoResponse
         */
        public QueryBookingDomainInfoResponse QueryBookingDomainInfo(QueryBookingDomainInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBookingDomainInfoWithOptions(request, runtime);
        }

        /**
         * @param request QueryBookingDomainInfoRequest
         * @return QueryBookingDomainInfoResponse
         */
        public async Task<QueryBookingDomainInfoResponse> QueryBookingDomainInfoAsync(QueryBookingDomainInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBookingDomainInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询回购订单列表
         *
         * @param request QueryBrokerDemandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBrokerDemandResponse
         */
        public QueryBrokerDemandResponse QueryBrokerDemandWithOptions(QueryBrokerDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBrokerDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBrokerDemandResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询回购订单列表
         *
         * @param request QueryBrokerDemandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBrokerDemandResponse
         */
        public async Task<QueryBrokerDemandResponse> QueryBrokerDemandWithOptionsAsync(QueryBrokerDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBrokerDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBrokerDemandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询回购订单列表
         *
         * @param request QueryBrokerDemandRequest
         * @return QueryBrokerDemandResponse
         */
        public QueryBrokerDemandResponse QueryBrokerDemand(QueryBrokerDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBrokerDemandWithOptions(request, runtime);
        }

        /**
         * @summary 查询回购订单列表
         *
         * @param request QueryBrokerDemandRequest
         * @return QueryBrokerDemandResponse
         */
        public async Task<QueryBrokerDemandResponse> QueryBrokerDemandAsync(QueryBrokerDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBrokerDemandWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryBrokerDemandRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBrokerDemandRecordResponse
         */
        public QueryBrokerDemandRecordResponse QueryBrokerDemandRecordWithOptions(QueryBrokerDemandRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBrokerDemandRecord",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBrokerDemandRecordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryBrokerDemandRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBrokerDemandRecordResponse
         */
        public async Task<QueryBrokerDemandRecordResponse> QueryBrokerDemandRecordWithOptionsAsync(QueryBrokerDemandRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBrokerDemandRecord",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBrokerDemandRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryBrokerDemandRecordRequest
         * @return QueryBrokerDemandRecordResponse
         */
        public QueryBrokerDemandRecordResponse QueryBrokerDemandRecord(QueryBrokerDemandRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBrokerDemandRecordWithOptions(request, runtime);
        }

        /**
         * @param request QueryBrokerDemandRecordRequest
         * @return QueryBrokerDemandRecordResponse
         */
        public async Task<QueryBrokerDemandRecordResponse> QueryBrokerDemandRecordAsync(QueryBrokerDemandRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBrokerDemandRecordWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryDomainTransferStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDomainTransferStatusResponse
         */
        public QueryDomainTransferStatusResponse QueryDomainTransferStatusWithOptions(QueryDomainTransferStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainTransferStatus",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainTransferStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryDomainTransferStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDomainTransferStatusResponse
         */
        public async Task<QueryDomainTransferStatusResponse> QueryDomainTransferStatusWithOptionsAsync(QueryDomainTransferStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainTransferStatus",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainTransferStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryDomainTransferStatusRequest
         * @return QueryDomainTransferStatusResponse
         */
        public QueryDomainTransferStatusResponse QueryDomainTransferStatus(QueryDomainTransferStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainTransferStatusWithOptions(request, runtime);
        }

        /**
         * @param request QueryDomainTransferStatusRequest
         * @return QueryDomainTransferStatusResponse
         */
        public async Task<QueryDomainTransferStatusResponse> QueryDomainTransferStatusAsync(QueryDomainTransferStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainTransferStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryPurchasedDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPurchasedDomainsResponse
         */
        public QueryPurchasedDomainsResponse QueryPurchasedDomainsWithOptions(QueryPurchasedDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndOperationTime))
            {
                body["EndOperationTime"] = request.EndOperationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTimeOrder))
            {
                body["OpTimeOrder"] = request.OpTimeOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationStatus))
            {
                body["OperationStatus"] = request.OperationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOperationTime))
            {
                body["StartOperationTime"] = request.StartOperationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTimeOrder))
            {
                body["UpdateTimeOrder"] = request.UpdateTimeOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPurchasedDomains",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPurchasedDomainsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryPurchasedDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPurchasedDomainsResponse
         */
        public async Task<QueryPurchasedDomainsResponse> QueryPurchasedDomainsWithOptionsAsync(QueryPurchasedDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndOperationTime))
            {
                body["EndOperationTime"] = request.EndOperationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTimeOrder))
            {
                body["OpTimeOrder"] = request.OpTimeOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationStatus))
            {
                body["OperationStatus"] = request.OperationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOperationTime))
            {
                body["StartOperationTime"] = request.StartOperationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTimeOrder))
            {
                body["UpdateTimeOrder"] = request.UpdateTimeOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPurchasedDomains",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPurchasedDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryPurchasedDomainsRequest
         * @return QueryPurchasedDomainsResponse
         */
        public QueryPurchasedDomainsResponse QueryPurchasedDomains(QueryPurchasedDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPurchasedDomainsWithOptions(request, runtime);
        }

        /**
         * @param request QueryPurchasedDomainsRequest
         * @return QueryPurchasedDomainsResponse
         */
        public async Task<QueryPurchasedDomainsResponse> QueryPurchasedDomainsAsync(QueryPurchasedDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPurchasedDomainsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RecordDemandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecordDemandResponse
         */
        public RecordDemandResponse RecordDemandWithOptions(RecordDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecordDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecordDemandResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request RecordDemandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecordDemandResponse
         */
        public async Task<RecordDemandResponse> RecordDemandWithOptionsAsync(RecordDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecordDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecordDemandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request RecordDemandRequest
         * @return RecordDemandResponse
         */
        public RecordDemandResponse RecordDemand(RecordDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecordDemandWithOptions(request, runtime);
        }

        /**
         * @param request RecordDemandRequest
         * @return RecordDemandResponse
         */
        public async Task<RecordDemandResponse> RecordDemandAsync(RecordDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecordDemandWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RefuseDemandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefuseDemandResponse
         */
        public RefuseDemandResponse RefuseDemandWithOptions(RefuseDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefuseDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefuseDemandResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request RefuseDemandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefuseDemandResponse
         */
        public async Task<RefuseDemandResponse> RefuseDemandWithOptionsAsync(RefuseDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefuseDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefuseDemandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request RefuseDemandRequest
         * @return RefuseDemandResponse
         */
        public RefuseDemandResponse RefuseDemand(RefuseDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefuseDemandWithOptions(request, runtime);
        }

        /**
         * @param request RefuseDemandRequest
         * @return RefuseDemandResponse
         */
        public async Task<RefuseDemandResponse> RefuseDemandAsync(RefuseDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefuseDemandWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RequestPayDemandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RequestPayDemandResponse
         */
        public RequestPayDemandResponse RequestPayDemandWithOptions(RequestPayDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Price))
            {
                query["Price"] = request.Price;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProduceType))
            {
                query["ProduceType"] = request.ProduceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RequestPayDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RequestPayDemandResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request RequestPayDemandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RequestPayDemandResponse
         */
        public async Task<RequestPayDemandResponse> RequestPayDemandWithOptionsAsync(RequestPayDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Price))
            {
                query["Price"] = request.Price;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProduceType))
            {
                query["ProduceType"] = request.ProduceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RequestPayDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RequestPayDemandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request RequestPayDemandRequest
         * @return RequestPayDemandResponse
         */
        public RequestPayDemandResponse RequestPayDemand(RequestPayDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RequestPayDemandWithOptions(request, runtime);
        }

        /**
         * @param request RequestPayDemandRequest
         * @return RequestPayDemandResponse
         */
        public async Task<RequestPayDemandResponse> RequestPayDemandAsync(RequestPayDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RequestPayDemandWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ReserveDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReserveDomainResponse
         */
        public ReserveDomainResponse ReserveDomainWithOptions(ReserveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channels))
            {
                body["Channels"] = request.Channels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReserveDomain",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReserveDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ReserveDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReserveDomainResponse
         */
        public async Task<ReserveDomainResponse> ReserveDomainWithOptionsAsync(ReserveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channels))
            {
                body["Channels"] = request.Channels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReserveDomain",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReserveDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ReserveDomainRequest
         * @return ReserveDomainResponse
         */
        public ReserveDomainResponse ReserveDomain(ReserveDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReserveDomainWithOptions(request, runtime);
        }

        /**
         * @param request ReserveDomainRequest
         * @return ReserveDomainResponse
         */
        public async Task<ReserveDomainResponse> ReserveDomainAsync(ReserveDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReserveDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ReserveIntlDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReserveIntlDomainResponse
         */
        public ReserveIntlDomainResponse ReserveIntlDomainWithOptions(ReserveIntlDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReserveIntlDomain",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReserveIntlDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ReserveIntlDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReserveIntlDomainResponse
         */
        public async Task<ReserveIntlDomainResponse> ReserveIntlDomainWithOptionsAsync(ReserveIntlDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReserveIntlDomain",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReserveIntlDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ReserveIntlDomainRequest
         * @return ReserveIntlDomainResponse
         */
        public ReserveIntlDomainResponse ReserveIntlDomain(ReserveIntlDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReserveIntlDomainWithOptions(request, runtime);
        }

        /**
         * @param request ReserveIntlDomainRequest
         * @return ReserveIntlDomainResponse
         */
        public async Task<ReserveIntlDomainResponse> ReserveIntlDomainAsync(ReserveIntlDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReserveIntlDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 严选列表导出，明日凌晨2点前生成文件，导出凌晨1点前所有在售严选域名
         *
         * @param request SelectedDomainListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SelectedDomainListResponse
         */
        public SelectedDomainListResponse SelectedDomainListWithOptions(SelectedDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListDate))
            {
                query["ListDate"] = request.ListDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SelectedDomainList",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SelectedDomainListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 严选列表导出，明日凌晨2点前生成文件，导出凌晨1点前所有在售严选域名
         *
         * @param request SelectedDomainListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SelectedDomainListResponse
         */
        public async Task<SelectedDomainListResponse> SelectedDomainListWithOptionsAsync(SelectedDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListDate))
            {
                query["ListDate"] = request.ListDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SelectedDomainList",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SelectedDomainListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 严选列表导出，明日凌晨2点前生成文件，导出凌晨1点前所有在售严选域名
         *
         * @param request SelectedDomainListRequest
         * @return SelectedDomainListResponse
         */
        public SelectedDomainListResponse SelectedDomainList(SelectedDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SelectedDomainListWithOptions(request, runtime);
        }

        /**
         * @summary 严选列表导出，明日凌晨2点前生成文件，导出凌晨1点前所有在售严选域名
         *
         * @param request SelectedDomainListRequest
         * @return SelectedDomainListResponse
         */
        public async Task<SelectedDomainListResponse> SelectedDomainListAsync(SelectedDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SelectedDomainListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交采购信息
         *
         * @param request SubmitPurchaseInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitPurchaseInfoResponse
         */
        public SubmitPurchaseInfoResponse SubmitPurchaseInfoWithOptions(SubmitPurchaseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaseCurrency))
            {
                body["PurchaseCurrency"] = request.PurchaseCurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchasePrice))
            {
                body["PurchasePrice"] = request.PurchasePrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaseProofs))
            {
                body["PurchaseProofs"] = request.PurchaseProofs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitPurchaseInfo",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitPurchaseInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交采购信息
         *
         * @param request SubmitPurchaseInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitPurchaseInfoResponse
         */
        public async Task<SubmitPurchaseInfoResponse> SubmitPurchaseInfoWithOptionsAsync(SubmitPurchaseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaseCurrency))
            {
                body["PurchaseCurrency"] = request.PurchaseCurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchasePrice))
            {
                body["PurchasePrice"] = request.PurchasePrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaseProofs))
            {
                body["PurchaseProofs"] = request.PurchaseProofs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitPurchaseInfo",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitPurchaseInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交采购信息
         *
         * @param request SubmitPurchaseInfoRequest
         * @return SubmitPurchaseInfoResponse
         */
        public SubmitPurchaseInfoResponse SubmitPurchaseInfo(SubmitPurchaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitPurchaseInfoWithOptions(request, runtime);
        }

        /**
         * @summary 提交采购信息
         *
         * @param request SubmitPurchaseInfoRequest
         * @return SubmitPurchaseInfoResponse
         */
        public async Task<SubmitPurchaseInfoResponse> SubmitPurchaseInfoAsync(SubmitPurchaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitPurchaseInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 合作方同步报价
         *
         * @param request UpdatePartnerReservePriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePartnerReservePriceResponse
         */
        public UpdatePartnerReservePriceResponse UpdatePartnerReservePriceWithOptions(UpdatePartnerReservePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BiddingId))
            {
                body["BiddingId"] = request.BiddingId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerType))
            {
                body["PartnerType"] = request.PartnerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservePrice))
            {
                body["ReservePrice"] = request.ReservePrice;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePartnerReservePrice",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePartnerReservePriceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 合作方同步报价
         *
         * @param request UpdatePartnerReservePriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePartnerReservePriceResponse
         */
        public async Task<UpdatePartnerReservePriceResponse> UpdatePartnerReservePriceWithOptionsAsync(UpdatePartnerReservePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BiddingId))
            {
                body["BiddingId"] = request.BiddingId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerType))
            {
                body["PartnerType"] = request.PartnerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservePrice))
            {
                body["ReservePrice"] = request.ReservePrice;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePartnerReservePrice",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePartnerReservePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 合作方同步报价
         *
         * @param request UpdatePartnerReservePriceRequest
         * @return UpdatePartnerReservePriceResponse
         */
        public UpdatePartnerReservePriceResponse UpdatePartnerReservePrice(UpdatePartnerReservePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePartnerReservePriceWithOptions(request, runtime);
        }

        /**
         * @summary 合作方同步报价
         *
         * @param request UpdatePartnerReservePriceRequest
         * @return UpdatePartnerReservePriceResponse
         */
        public async Task<UpdatePartnerReservePriceResponse> UpdatePartnerReservePriceAsync(UpdatePartnerReservePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePartnerReservePriceWithOptionsAsync(request, runtime);
        }

    }
}
