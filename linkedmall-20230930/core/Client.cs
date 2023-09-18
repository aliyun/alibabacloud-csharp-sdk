// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Linkedmall20230930.Models;

namespace AlibabaCloud.SDK.Linkedmall20230930
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hangzhou", "linkedmall.aliyuncs.com"},
                {"cn-shanghai", "linkedmall.aliyuncs.com"},
                {"ap-northeast-1", "linkedmall.aliyuncs.com"},
                {"ap-northeast-2-pop", "linkedmall.aliyuncs.com"},
                {"ap-south-1", "linkedmall.aliyuncs.com"},
                {"ap-southeast-1", "linkedmall.aliyuncs.com"},
                {"ap-southeast-2", "linkedmall.aliyuncs.com"},
                {"ap-southeast-3", "linkedmall.aliyuncs.com"},
                {"ap-southeast-5", "linkedmall.aliyuncs.com"},
                {"cn-beijing", "linkedmall.aliyuncs.com"},
                {"cn-beijing-finance-1", "linkedmall.aliyuncs.com"},
                {"cn-beijing-finance-pop", "linkedmall.aliyuncs.com"},
                {"cn-beijing-gov-1", "linkedmall.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "linkedmall.aliyuncs.com"},
                {"cn-chengdu", "linkedmall.aliyuncs.com"},
                {"cn-edge-1", "linkedmall.aliyuncs.com"},
                {"cn-fujian", "linkedmall.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "linkedmall.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "linkedmall.aliyuncs.com"},
                {"cn-hangzhou-finance", "linkedmall.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "linkedmall.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "linkedmall.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "linkedmall.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "linkedmall.aliyuncs.com"},
                {"cn-hangzhou-test-306", "linkedmall.aliyuncs.com"},
                {"cn-hongkong", "linkedmall.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "linkedmall.aliyuncs.com"},
                {"cn-huhehaote", "linkedmall.aliyuncs.com"},
                {"cn-north-2-gov-1", "linkedmall.aliyuncs.com"},
                {"cn-qingdao", "linkedmall.aliyuncs.com"},
                {"cn-qingdao-nebula", "linkedmall.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "linkedmall.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "linkedmall.aliyuncs.com"},
                {"cn-shanghai-finance-1", "linkedmall.aliyuncs.com"},
                {"cn-shanghai-inner", "linkedmall.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "linkedmall.aliyuncs.com"},
                {"cn-shenzhen", "linkedmall.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "linkedmall.aliyuncs.com"},
                {"cn-shenzhen-inner", "linkedmall.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "linkedmall.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "linkedmall.aliyuncs.com"},
                {"cn-wuhan", "linkedmall.aliyuncs.com"},
                {"cn-yushanfang", "linkedmall.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "linkedmall.aliyuncs.com"},
                {"cn-zhangjiakou", "linkedmall.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "linkedmall.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "linkedmall.aliyuncs.com"},
                {"eu-central-1", "linkedmall.aliyuncs.com"},
                {"eu-west-1", "linkedmall.aliyuncs.com"},
                {"eu-west-1-oxs", "linkedmall.aliyuncs.com"},
                {"me-east-1", "linkedmall.aliyuncs.com"},
                {"rus-west-1-pop", "linkedmall.aliyuncs.com"},
                {"us-east-1", "linkedmall.aliyuncs.com"},
                {"us-west-1", "linkedmall.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("linkedmall", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CancelRefundOrderResponse CancelRefundOrderWithOptions(string disputeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRefundOrder",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/refunds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(disputeId) + "/commands/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRefundOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelRefundOrderResponse> CancelRefundOrderWithOptionsAsync(string disputeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRefundOrder",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/refunds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(disputeId) + "/commands/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRefundOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelRefundOrderResponse CancelRefundOrder(string disputeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelRefundOrderWithOptions(disputeId, headers, runtime);
        }

        public async Task<CancelRefundOrderResponse> CancelRefundOrderAsync(string disputeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelRefundOrderWithOptionsAsync(disputeId, headers, runtime);
        }

        public ConfirmDisburseResponse ConfirmDisburseWithOptions(ConfirmDisburseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmDisburse",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/orders/commands/confirmDisburse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmDisburseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConfirmDisburseResponse> ConfirmDisburseWithOptionsAsync(ConfirmDisburseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmDisburse",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/orders/commands/confirmDisburse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmDisburseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConfirmDisburseResponse ConfirmDisburse(ConfirmDisburseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ConfirmDisburseWithOptions(request, headers, runtime);
        }

        public async Task<ConfirmDisburseResponse> ConfirmDisburseAsync(ConfirmDisburseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ConfirmDisburseWithOptionsAsync(request, headers, runtime);
        }

        public CreateGoodsShippingNoticeResponse CreateGoodsShippingNoticeWithOptions(CreateGoodsShippingNoticeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGoodsShippingNotice",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/refunds/command/createGoodsShippingNotice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGoodsShippingNoticeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateGoodsShippingNoticeResponse> CreateGoodsShippingNoticeWithOptionsAsync(CreateGoodsShippingNoticeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGoodsShippingNotice",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/refunds/command/createGoodsShippingNotice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGoodsShippingNoticeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateGoodsShippingNoticeResponse CreateGoodsShippingNotice(CreateGoodsShippingNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateGoodsShippingNoticeWithOptions(request, headers, runtime);
        }

        public async Task<CreateGoodsShippingNoticeResponse> CreateGoodsShippingNoticeAsync(CreateGoodsShippingNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateGoodsShippingNoticeWithOptionsAsync(request, headers, runtime);
        }

        public CreatePurchaseOrderResponse CreatePurchaseOrderWithOptions(CreatePurchaseOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePurchaseOrder",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/purchaseOrders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePurchaseOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreatePurchaseOrderResponse> CreatePurchaseOrderWithOptionsAsync(CreatePurchaseOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePurchaseOrder",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/purchaseOrders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePurchaseOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreatePurchaseOrderResponse CreatePurchaseOrder(CreatePurchaseOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePurchaseOrderWithOptions(request, headers, runtime);
        }

        public async Task<CreatePurchaseOrderResponse> CreatePurchaseOrderAsync(CreatePurchaseOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePurchaseOrderWithOptionsAsync(request, headers, runtime);
        }

        public CreateRefundOrderResponse CreateRefundOrderWithOptions(CreateRefundOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRefundOrder",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/refunds",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRefundOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateRefundOrderResponse> CreateRefundOrderWithOptionsAsync(CreateRefundOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRefundOrder",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/refunds",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRefundOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateRefundOrderResponse CreateRefundOrder(CreateRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRefundOrderWithOptions(request, headers, runtime);
        }

        public async Task<CreateRefundOrderResponse> CreateRefundOrderAsync(CreateRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRefundOrderWithOptionsAsync(request, headers, runtime);
        }

        public GetOrderResponse GetOrderWithOptions(string orderId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrder",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/orders/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(orderId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetOrderResponse> GetOrderWithOptionsAsync(string orderId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrder",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/orders/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(orderId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetOrderResponse GetOrder(string orderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOrderWithOptions(orderId, headers, runtime);
        }

        public async Task<GetOrderResponse> GetOrderAsync(string orderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOrderWithOptionsAsync(orderId, headers, runtime);
        }

        public GetPurchaseOrderStatusResponse GetPurchaseOrderStatusWithOptions(string purchaseOrderId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPurchaseOrderStatus",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/purchaseOrders/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(purchaseOrderId) + "/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPurchaseOrderStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPurchaseOrderStatusResponse> GetPurchaseOrderStatusWithOptionsAsync(string purchaseOrderId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPurchaseOrderStatus",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/purchaseOrders/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(purchaseOrderId) + "/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPurchaseOrderStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPurchaseOrderStatusResponse GetPurchaseOrderStatus(string purchaseOrderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPurchaseOrderStatusWithOptions(purchaseOrderId, headers, runtime);
        }

        public async Task<GetPurchaseOrderStatusResponse> GetPurchaseOrderStatusAsync(string purchaseOrderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPurchaseOrderStatusWithOptionsAsync(purchaseOrderId, headers, runtime);
        }

        public GetPurchaserShopResponse GetPurchaserShopWithOptions(string purchaserId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPurchaserShop",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/purchaserShops/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(purchaserId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPurchaserShopResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPurchaserShopResponse> GetPurchaserShopWithOptionsAsync(string purchaserId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPurchaserShop",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/purchaserShops/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(purchaserId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPurchaserShopResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPurchaserShopResponse GetPurchaserShop(string purchaserId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPurchaserShopWithOptions(purchaserId, headers, runtime);
        }

        public async Task<GetPurchaserShopResponse> GetPurchaserShopAsync(string purchaserId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPurchaserShopWithOptionsAsync(purchaserId, headers, runtime);
        }

        public GetRefundOrderResponse GetRefundOrderWithOptions(string disputeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRefundOrder",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/refunds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(disputeId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRefundOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRefundOrderResponse> GetRefundOrderWithOptionsAsync(string disputeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRefundOrder",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/refunds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(disputeId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRefundOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRefundOrderResponse GetRefundOrder(string disputeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRefundOrderWithOptions(disputeId, headers, runtime);
        }

        public async Task<GetRefundOrderResponse> GetRefundOrderAsync(string disputeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRefundOrderWithOptionsAsync(disputeId, headers, runtime);
        }

        public GetSelectionProductResponse GetSelectionProductWithOptions(string productId, GetSelectionProductRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DivisionCode))
            {
                query["divisionCode"] = request.DivisionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserId))
            {
                query["purchaserId"] = request.PurchaserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSelectionProduct",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/selectionPool/products/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(productId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSelectionProductResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSelectionProductResponse> GetSelectionProductWithOptionsAsync(string productId, GetSelectionProductRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DivisionCode))
            {
                query["divisionCode"] = request.DivisionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserId))
            {
                query["purchaserId"] = request.PurchaserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSelectionProduct",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/selectionPool/products/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(productId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSelectionProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetSelectionProductResponse GetSelectionProduct(string productId, GetSelectionProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSelectionProductWithOptions(productId, request, headers, runtime);
        }

        public async Task<GetSelectionProductResponse> GetSelectionProductAsync(string productId, GetSelectionProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSelectionProductWithOptionsAsync(productId, request, headers, runtime);
        }

        public GetSelectionProductSaleInfoResponse GetSelectionProductSaleInfoWithOptions(string productId, GetSelectionProductSaleInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DivisionCode))
            {
                query["divisionCode"] = request.DivisionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserId))
            {
                query["purchaserId"] = request.PurchaserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSelectionProductSaleInfo",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/selectionPool/products/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(productId) + "/saleInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSelectionProductSaleInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSelectionProductSaleInfoResponse> GetSelectionProductSaleInfoWithOptionsAsync(string productId, GetSelectionProductSaleInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DivisionCode))
            {
                query["divisionCode"] = request.DivisionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserId))
            {
                query["purchaserId"] = request.PurchaserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSelectionProductSaleInfo",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/selectionPool/products/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(productId) + "/saleInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSelectionProductSaleInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetSelectionProductSaleInfoResponse GetSelectionProductSaleInfo(string productId, GetSelectionProductSaleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSelectionProductSaleInfoWithOptions(productId, request, headers, runtime);
        }

        public async Task<GetSelectionProductSaleInfoResponse> GetSelectionProductSaleInfoAsync(string productId, GetSelectionProductSaleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSelectionProductSaleInfoWithOptionsAsync(productId, request, headers, runtime);
        }

        public ListLogisticsOrdersResponse ListLogisticsOrdersWithOptions(string orderId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLogisticsOrders",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/orders/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(orderId) + "/logisticsOrders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogisticsOrdersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListLogisticsOrdersResponse> ListLogisticsOrdersWithOptionsAsync(string orderId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLogisticsOrders",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/orders/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(orderId) + "/logisticsOrders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogisticsOrdersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListLogisticsOrdersResponse ListLogisticsOrders(string orderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLogisticsOrdersWithOptions(orderId, headers, runtime);
        }

        public async Task<ListLogisticsOrdersResponse> ListLogisticsOrdersAsync(string orderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLogisticsOrdersWithOptionsAsync(orderId, headers, runtime);
        }

        public ListPurchaserShopsResponse ListPurchaserShopsWithOptions(ListPurchaserShopsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPurchaserShops",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/purchaserShops",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPurchaserShopsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPurchaserShopsResponse> ListPurchaserShopsWithOptionsAsync(ListPurchaserShopsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPurchaserShops",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/purchaserShops",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPurchaserShopsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPurchaserShopsResponse ListPurchaserShops(ListPurchaserShopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPurchaserShopsWithOptions(request, headers, runtime);
        }

        public async Task<ListPurchaserShopsResponse> ListPurchaserShopsAsync(ListPurchaserShopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPurchaserShopsWithOptionsAsync(request, headers, runtime);
        }

        public ListSelectionProductSaleInfosResponse ListSelectionProductSaleInfosWithOptions(ListSelectionProductSaleInfosRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSelectionProductSaleInfos",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/selectionPool/products/saleInfo/commands/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSelectionProductSaleInfosResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSelectionProductSaleInfosResponse> ListSelectionProductSaleInfosWithOptionsAsync(ListSelectionProductSaleInfosRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSelectionProductSaleInfos",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/selectionPool/products/saleInfo/commands/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSelectionProductSaleInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSelectionProductSaleInfosResponse ListSelectionProductSaleInfos(ListSelectionProductSaleInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSelectionProductSaleInfosWithOptions(request, headers, runtime);
        }

        public async Task<ListSelectionProductSaleInfosResponse> ListSelectionProductSaleInfosAsync(ListSelectionProductSaleInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSelectionProductSaleInfosWithOptionsAsync(request, headers, runtime);
        }

        public ListSelectionProductsResponse ListSelectionProductsWithOptions(ListSelectionProductsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserId))
            {
                query["purchaserId"] = request.PurchaserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSelectionProducts",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/selectionPool/products",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSelectionProductsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSelectionProductsResponse> ListSelectionProductsWithOptionsAsync(ListSelectionProductsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserId))
            {
                query["purchaserId"] = request.PurchaserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSelectionProducts",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/selectionPool/products",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSelectionProductsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSelectionProductsResponse ListSelectionProducts(ListSelectionProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSelectionProductsWithOptions(request, headers, runtime);
        }

        public async Task<ListSelectionProductsResponse> ListSelectionProductsAsync(ListSelectionProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSelectionProductsWithOptionsAsync(request, headers, runtime);
        }

        public ListSelectionSkuSaleInfosResponse ListSelectionSkuSaleInfosWithOptions(ListSelectionSkuSaleInfosRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSelectionSkuSaleInfos",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/selectionPool/skus/saleInfo/commands/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSelectionSkuSaleInfosResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSelectionSkuSaleInfosResponse> ListSelectionSkuSaleInfosWithOptionsAsync(ListSelectionSkuSaleInfosRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSelectionSkuSaleInfos",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/selectionPool/skus/saleInfo/commands/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSelectionSkuSaleInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSelectionSkuSaleInfosResponse ListSelectionSkuSaleInfos(ListSelectionSkuSaleInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSelectionSkuSaleInfosWithOptions(request, headers, runtime);
        }

        public async Task<ListSelectionSkuSaleInfosResponse> ListSelectionSkuSaleInfosAsync(ListSelectionSkuSaleInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSelectionSkuSaleInfosWithOptionsAsync(request, headers, runtime);
        }

        public QueryChildDivisionCodeResponse QueryChildDivisionCodeWithOptions(QueryChildDivisionCodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryChildDivisionCode",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/division/commands/queryChildDivisionCode",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChildDivisionCodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryChildDivisionCodeResponse> QueryChildDivisionCodeWithOptionsAsync(QueryChildDivisionCodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryChildDivisionCode",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/division/commands/queryChildDivisionCode",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChildDivisionCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryChildDivisionCodeResponse QueryChildDivisionCode(QueryChildDivisionCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryChildDivisionCodeWithOptions(request, headers, runtime);
        }

        public async Task<QueryChildDivisionCodeResponse> QueryChildDivisionCodeAsync(QueryChildDivisionCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryChildDivisionCodeWithOptionsAsync(request, headers, runtime);
        }

        public QueryOrdersResponse QueryOrdersWithOptions(QueryOrdersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrders",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/orders/commands/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrdersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryOrdersResponse> QueryOrdersWithOptionsAsync(QueryOrdersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrders",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/orders/commands/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrdersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryOrdersResponse QueryOrders(QueryOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryOrdersWithOptions(request, headers, runtime);
        }

        public async Task<QueryOrdersResponse> QueryOrdersAsync(QueryOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryOrdersWithOptionsAsync(request, headers, runtime);
        }

        public RenderPurchaseOrderResponse RenderPurchaseOrderWithOptions(RenderPurchaseOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenderPurchaseOrder",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/purchaseOrders/commands/render",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenderPurchaseOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RenderPurchaseOrderResponse> RenderPurchaseOrderWithOptionsAsync(RenderPurchaseOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenderPurchaseOrder",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/purchaseOrders/commands/render",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenderPurchaseOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RenderPurchaseOrderResponse RenderPurchaseOrder(RenderPurchaseOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RenderPurchaseOrderWithOptions(request, headers, runtime);
        }

        public async Task<RenderPurchaseOrderResponse> RenderPurchaseOrderAsync(RenderPurchaseOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RenderPurchaseOrderWithOptionsAsync(request, headers, runtime);
        }

        public RenderRefundOrderResponse RenderRefundOrderWithOptions(RenderRefundOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenderRefundOrder",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/refunds/commands/render",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenderRefundOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RenderRefundOrderResponse> RenderRefundOrderWithOptionsAsync(RenderRefundOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenderRefundOrder",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/refunds/commands/render",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenderRefundOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RenderRefundOrderResponse RenderRefundOrder(RenderRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RenderRefundOrderWithOptions(request, headers, runtime);
        }

        public async Task<RenderRefundOrderResponse> RenderRefundOrderAsync(RenderRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RenderRefundOrderWithOptionsAsync(request, headers, runtime);
        }

    }
}
