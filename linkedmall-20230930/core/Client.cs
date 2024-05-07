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

        /**
         * @summary 取消逆向单
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelRefundOrderResponse
         */
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

        /**
         * @summary 取消逆向单
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelRefundOrderResponse
         */
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

        /**
         * @summary 取消逆向单
         *
         * @return CancelRefundOrderResponse
         */
        public CancelRefundOrderResponse CancelRefundOrder(string disputeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelRefundOrderWithOptions(disputeId, headers, runtime);
        }

        /**
         * @summary 取消逆向单
         *
         * @return CancelRefundOrderResponse
         */
        public async Task<CancelRefundOrderResponse> CancelRefundOrderAsync(string disputeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelRefundOrderWithOptionsAsync(disputeId, headers, runtime);
        }

        /**
         * @summary 确认收货（订单）
         *
         * @param request ConfirmDisburseRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConfirmDisburseResponse
         */
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

        /**
         * @summary 确认收货（订单）
         *
         * @param request ConfirmDisburseRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConfirmDisburseResponse
         */
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

        /**
         * @summary 确认收货（订单）
         *
         * @param request ConfirmDisburseRequest
         * @return ConfirmDisburseResponse
         */
        public ConfirmDisburseResponse ConfirmDisburse(ConfirmDisburseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ConfirmDisburseWithOptions(request, headers, runtime);
        }

        /**
         * @summary 确认收货（订单）
         *
         * @param request ConfirmDisburseRequest
         * @return ConfirmDisburseResponse
         */
        public async Task<ConfirmDisburseResponse> ConfirmDisburseAsync(ConfirmDisburseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ConfirmDisburseWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 提交运单信息
         *
         * @param request CreateGoodsShippingNoticeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGoodsShippingNoticeResponse
         */
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

        /**
         * @summary 提交运单信息
         *
         * @param request CreateGoodsShippingNoticeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGoodsShippingNoticeResponse
         */
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

        /**
         * @summary 提交运单信息
         *
         * @param request CreateGoodsShippingNoticeRequest
         * @return CreateGoodsShippingNoticeResponse
         */
        public CreateGoodsShippingNoticeResponse CreateGoodsShippingNotice(CreateGoodsShippingNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateGoodsShippingNoticeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 提交运单信息
         *
         * @param request CreateGoodsShippingNoticeRequest
         * @return CreateGoodsShippingNoticeResponse
         */
        public async Task<CreateGoodsShippingNoticeResponse> CreateGoodsShippingNoticeAsync(CreateGoodsShippingNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateGoodsShippingNoticeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建采购单
         *
         * @param request CreatePurchaseOrderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePurchaseOrderResponse
         */
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

        /**
         * @summary 创建采购单
         *
         * @param request CreatePurchaseOrderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePurchaseOrderResponse
         */
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

        /**
         * @summary 创建采购单
         *
         * @param request CreatePurchaseOrderRequest
         * @return CreatePurchaseOrderResponse
         */
        public CreatePurchaseOrderResponse CreatePurchaseOrder(CreatePurchaseOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePurchaseOrderWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建采购单
         *
         * @param request CreatePurchaseOrderRequest
         * @return CreatePurchaseOrderResponse
         */
        public async Task<CreatePurchaseOrderResponse> CreatePurchaseOrderAsync(CreatePurchaseOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePurchaseOrderWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建逆向单
         *
         * @param request CreateRefundOrderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRefundOrderResponse
         */
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

        /**
         * @summary 创建逆向单
         *
         * @param request CreateRefundOrderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRefundOrderResponse
         */
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

        /**
         * @summary 创建逆向单
         *
         * @param request CreateRefundOrderRequest
         * @return CreateRefundOrderResponse
         */
        public CreateRefundOrderResponse CreateRefundOrder(CreateRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRefundOrderWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建逆向单
         *
         * @param request CreateRefundOrderRequest
         * @return CreateRefundOrderResponse
         */
        public async Task<CreateRefundOrderResponse> CreateRefundOrderAsync(CreateRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRefundOrderWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询主单详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOrderResponse
         */
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

        /**
         * @summary 查询主单详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOrderResponse
         */
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

        /**
         * @summary 查询主单详情
         *
         * @return GetOrderResponse
         */
        public GetOrderResponse GetOrder(string orderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOrderWithOptions(orderId, headers, runtime);
        }

        /**
         * @summary 查询主单详情
         *
         * @return GetOrderResponse
         */
        public async Task<GetOrderResponse> GetOrderAsync(string orderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOrderWithOptionsAsync(orderId, headers, runtime);
        }

        /**
         * @summary 查询采购单状态
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPurchaseOrderStatusResponse
         */
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

        /**
         * @summary 查询采购单状态
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPurchaseOrderStatusResponse
         */
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

        /**
         * @summary 查询采购单状态
         *
         * @return GetPurchaseOrderStatusResponse
         */
        public GetPurchaseOrderStatusResponse GetPurchaseOrderStatus(string purchaseOrderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPurchaseOrderStatusWithOptions(purchaseOrderId, headers, runtime);
        }

        /**
         * @summary 查询采购单状态
         *
         * @return GetPurchaseOrderStatusResponse
         */
        public async Task<GetPurchaseOrderStatusResponse> GetPurchaseOrderStatusAsync(string purchaseOrderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPurchaseOrderStatusWithOptionsAsync(purchaseOrderId, headers, runtime);
        }

        /**
         * @summary 查询分销商店铺
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPurchaserShopResponse
         */
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

        /**
         * @summary 查询分销商店铺
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPurchaserShopResponse
         */
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

        /**
         * @summary 查询分销商店铺
         *
         * @return GetPurchaserShopResponse
         */
        public GetPurchaserShopResponse GetPurchaserShop(string purchaserId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPurchaserShopWithOptions(purchaserId, headers, runtime);
        }

        /**
         * @summary 查询分销商店铺
         *
         * @return GetPurchaserShopResponse
         */
        public async Task<GetPurchaserShopResponse> GetPurchaserShopAsync(string purchaserId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPurchaserShopWithOptionsAsync(purchaserId, headers, runtime);
        }

        /**
         * @summary 查询逆向单详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRefundOrderResponse
         */
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

        /**
         * @summary 查询逆向单详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRefundOrderResponse
         */
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

        /**
         * @summary 查询逆向单详情
         *
         * @return GetRefundOrderResponse
         */
        public GetRefundOrderResponse GetRefundOrder(string disputeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRefundOrderWithOptions(disputeId, headers, runtime);
        }

        /**
         * @summary 查询逆向单详情
         *
         * @return GetRefundOrderResponse
         */
        public async Task<GetRefundOrderResponse> GetRefundOrderAsync(string disputeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRefundOrderWithOptionsAsync(disputeId, headers, runtime);
        }

        /**
         * @summary 查询选品池商品详情
         *
         * @param request GetSelectionProductRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSelectionProductResponse
         */
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

        /**
         * @summary 查询选品池商品详情
         *
         * @param request GetSelectionProductRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSelectionProductResponse
         */
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

        /**
         * @summary 查询选品池商品详情
         *
         * @param request GetSelectionProductRequest
         * @return GetSelectionProductResponse
         */
        public GetSelectionProductResponse GetSelectionProduct(string productId, GetSelectionProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSelectionProductWithOptions(productId, request, headers, runtime);
        }

        /**
         * @summary 查询选品池商品详情
         *
         * @param request GetSelectionProductRequest
         * @return GetSelectionProductResponse
         */
        public async Task<GetSelectionProductResponse> GetSelectionProductAsync(string productId, GetSelectionProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSelectionProductWithOptionsAsync(productId, request, headers, runtime);
        }

        /**
         * @summary 查询选品池商品库存
         *
         * @param request GetSelectionProductSaleInfoRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSelectionProductSaleInfoResponse
         */
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

        /**
         * @summary 查询选品池商品库存
         *
         * @param request GetSelectionProductSaleInfoRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSelectionProductSaleInfoResponse
         */
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

        /**
         * @summary 查询选品池商品库存
         *
         * @param request GetSelectionProductSaleInfoRequest
         * @return GetSelectionProductSaleInfoResponse
         */
        public GetSelectionProductSaleInfoResponse GetSelectionProductSaleInfo(string productId, GetSelectionProductSaleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSelectionProductSaleInfoWithOptions(productId, request, headers, runtime);
        }

        /**
         * @summary 查询选品池商品库存
         *
         * @param request GetSelectionProductSaleInfoRequest
         * @return GetSelectionProductSaleInfoResponse
         */
        public async Task<GetSelectionProductSaleInfoResponse> GetSelectionProductSaleInfoAsync(string productId, GetSelectionProductSaleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSelectionProductSaleInfoWithOptionsAsync(productId, request, headers, runtime);
        }

        /**
         * @summary 查询类目
         *
         * @param request ListCategoriesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCategoriesResponse
         */
        public ListCategoriesResponse ListCategoriesWithOptions(ListCategoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCategories",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/categories/commands/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCategoriesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询类目
         *
         * @param request ListCategoriesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCategoriesResponse
         */
        public async Task<ListCategoriesResponse> ListCategoriesWithOptionsAsync(ListCategoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCategories",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/categories/commands/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCategoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询类目
         *
         * @param request ListCategoriesRequest
         * @return ListCategoriesResponse
         */
        public ListCategoriesResponse ListCategories(ListCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCategoriesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询类目
         *
         * @param request ListCategoriesRequest
         * @return ListCategoriesResponse
         */
        public async Task<ListCategoriesResponse> ListCategoriesAsync(ListCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCategoriesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询物流信息（订单）
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLogisticsOrdersResponse
         */
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

        /**
         * @summary 查询物流信息（订单）
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLogisticsOrdersResponse
         */
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

        /**
         * @summary 查询物流信息（订单）
         *
         * @return ListLogisticsOrdersResponse
         */
        public ListLogisticsOrdersResponse ListLogisticsOrders(string orderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLogisticsOrdersWithOptions(orderId, headers, runtime);
        }

        /**
         * @summary 查询物流信息（订单）
         *
         * @return ListLogisticsOrdersResponse
         */
        public async Task<ListLogisticsOrdersResponse> ListLogisticsOrdersAsync(string orderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLogisticsOrdersWithOptionsAsync(orderId, headers, runtime);
        }

        /**
         * @summary 采购方店铺列表查询
         *
         * @param request ListPurchaserShopsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPurchaserShopsResponse
         */
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

        /**
         * @summary 采购方店铺列表查询
         *
         * @param request ListPurchaserShopsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPurchaserShopsResponse
         */
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

        /**
         * @summary 采购方店铺列表查询
         *
         * @param request ListPurchaserShopsRequest
         * @return ListPurchaserShopsResponse
         */
        public ListPurchaserShopsResponse ListPurchaserShops(ListPurchaserShopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPurchaserShopsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 采购方店铺列表查询
         *
         * @param request ListPurchaserShopsRequest
         * @return ListPurchaserShopsResponse
         */
        public async Task<ListPurchaserShopsResponse> ListPurchaserShopsAsync(ListPurchaserShopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPurchaserShopsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量查询选品池商品库存
         *
         * @param request ListSelectionProductSaleInfosRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSelectionProductSaleInfosResponse
         */
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

        /**
         * @summary 批量查询选品池商品库存
         *
         * @param request ListSelectionProductSaleInfosRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSelectionProductSaleInfosResponse
         */
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

        /**
         * @summary 批量查询选品池商品库存
         *
         * @param request ListSelectionProductSaleInfosRequest
         * @return ListSelectionProductSaleInfosResponse
         */
        public ListSelectionProductSaleInfosResponse ListSelectionProductSaleInfos(ListSelectionProductSaleInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSelectionProductSaleInfosWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询选品池商品库存
         *
         * @param request ListSelectionProductSaleInfosRequest
         * @return ListSelectionProductSaleInfosResponse
         */
        public async Task<ListSelectionProductSaleInfosResponse> ListSelectionProductSaleInfosAsync(ListSelectionProductSaleInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSelectionProductSaleInfosWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询商品列表
         *
         * @param request ListSelectionProductsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSelectionProductsResponse
         */
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

        /**
         * @summary 查询商品列表
         *
         * @param request ListSelectionProductsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSelectionProductsResponse
         */
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

        /**
         * @summary 查询商品列表
         *
         * @param request ListSelectionProductsRequest
         * @return ListSelectionProductsResponse
         */
        public ListSelectionProductsResponse ListSelectionProducts(ListSelectionProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSelectionProductsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询商品列表
         *
         * @param request ListSelectionProductsRequest
         * @return ListSelectionProductsResponse
         */
        public async Task<ListSelectionProductsResponse> ListSelectionProductsAsync(ListSelectionProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSelectionProductsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量查询选品池商品SKU库存
         *
         * @param request ListSelectionSkuSaleInfosRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSelectionSkuSaleInfosResponse
         */
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

        /**
         * @summary 批量查询选品池商品SKU库存
         *
         * @param request ListSelectionSkuSaleInfosRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSelectionSkuSaleInfosResponse
         */
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

        /**
         * @summary 批量查询选品池商品SKU库存
         *
         * @param request ListSelectionSkuSaleInfosRequest
         * @return ListSelectionSkuSaleInfosResponse
         */
        public ListSelectionSkuSaleInfosResponse ListSelectionSkuSaleInfos(ListSelectionSkuSaleInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSelectionSkuSaleInfosWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询选品池商品SKU库存
         *
         * @param request ListSelectionSkuSaleInfosRequest
         * @return ListSelectionSkuSaleInfosResponse
         */
        public async Task<ListSelectionSkuSaleInfosResponse> ListSelectionSkuSaleInfosAsync(ListSelectionSkuSaleInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSelectionSkuSaleInfosWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询地址divisionCode
         *
         * @param request QueryChildDivisionCodeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryChildDivisionCodeResponse
         */
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

        /**
         * @summary 查询地址divisionCode
         *
         * @param request QueryChildDivisionCodeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryChildDivisionCodeResponse
         */
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

        /**
         * @summary 查询地址divisionCode
         *
         * @param request QueryChildDivisionCodeRequest
         * @return QueryChildDivisionCodeResponse
         */
        public QueryChildDivisionCodeResponse QueryChildDivisionCode(QueryChildDivisionCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryChildDivisionCodeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询地址divisionCode
         *
         * @param request QueryChildDivisionCodeRequest
         * @return QueryChildDivisionCodeResponse
         */
        public async Task<QueryChildDivisionCodeResponse> QueryChildDivisionCodeAsync(QueryChildDivisionCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryChildDivisionCodeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询主单列表
         *
         * @param request QueryOrdersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOrdersResponse
         */
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

        /**
         * @summary 查询主单列表
         *
         * @param request QueryOrdersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOrdersResponse
         */
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

        /**
         * @summary 查询主单列表
         *
         * @param request QueryOrdersRequest
         * @return QueryOrdersResponse
         */
        public QueryOrdersResponse QueryOrders(QueryOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryOrdersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询主单列表
         *
         * @param request QueryOrdersRequest
         * @return QueryOrdersResponse
         */
        public async Task<QueryOrdersResponse> QueryOrdersAsync(QueryOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryOrdersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 渲染采购单
         *
         * @param request RenderPurchaseOrderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenderPurchaseOrderResponse
         */
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

        /**
         * @summary 渲染采购单
         *
         * @param request RenderPurchaseOrderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenderPurchaseOrderResponse
         */
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

        /**
         * @summary 渲染采购单
         *
         * @param request RenderPurchaseOrderRequest
         * @return RenderPurchaseOrderResponse
         */
        public RenderPurchaseOrderResponse RenderPurchaseOrder(RenderPurchaseOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RenderPurchaseOrderWithOptions(request, headers, runtime);
        }

        /**
         * @summary 渲染采购单
         *
         * @param request RenderPurchaseOrderRequest
         * @return RenderPurchaseOrderResponse
         */
        public async Task<RenderPurchaseOrderResponse> RenderPurchaseOrderAsync(RenderPurchaseOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RenderPurchaseOrderWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 逆向单渲染
         *
         * @param request RenderRefundOrderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenderRefundOrderResponse
         */
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

        /**
         * @summary 逆向单渲染
         *
         * @param request RenderRefundOrderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenderRefundOrderResponse
         */
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

        /**
         * @summary 逆向单渲染
         *
         * @param request RenderRefundOrderRequest
         * @return RenderRefundOrderResponse
         */
        public RenderRefundOrderResponse RenderRefundOrder(RenderRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RenderRefundOrderWithOptions(request, headers, runtime);
        }

        /**
         * @summary 逆向单渲染
         *
         * @param request RenderRefundOrderRequest
         * @return RenderRefundOrderResponse
         */
        public async Task<RenderRefundOrderResponse> RenderRefundOrderAsync(RenderRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RenderRefundOrderWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 渲染拆分采购单
         *
         * @param request SplitPurchaseOrderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SplitPurchaseOrderResponse
         */
        public SplitPurchaseOrderResponse SplitPurchaseOrderWithOptions(SplitPurchaseOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SplitPurchaseOrder",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/purchaseOrders/commands/split",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SplitPurchaseOrderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 渲染拆分采购单
         *
         * @param request SplitPurchaseOrderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SplitPurchaseOrderResponse
         */
        public async Task<SplitPurchaseOrderResponse> SplitPurchaseOrderWithOptionsAsync(SplitPurchaseOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SplitPurchaseOrder",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/purchaseOrders/commands/split",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SplitPurchaseOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 渲染拆分采购单
         *
         * @param request SplitPurchaseOrderRequest
         * @return SplitPurchaseOrderResponse
         */
        public SplitPurchaseOrderResponse SplitPurchaseOrder(SplitPurchaseOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SplitPurchaseOrderWithOptions(request, headers, runtime);
        }

        /**
         * @summary 渲染拆分采购单
         *
         * @param request SplitPurchaseOrderRequest
         * @return SplitPurchaseOrderResponse
         */
        public async Task<SplitPurchaseOrderResponse> SplitPurchaseOrderAsync(SplitPurchaseOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SplitPurchaseOrderWithOptionsAsync(request, headers, runtime);
        }

    }
}
