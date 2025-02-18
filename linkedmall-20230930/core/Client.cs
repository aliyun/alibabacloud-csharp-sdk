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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消逆向单</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelRefundOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CancelRefundOrderResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CancelRefundOrderResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消逆向单</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelRefundOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CancelRefundOrderResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CancelRefundOrderResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消逆向单</para>
        /// </summary>
        /// 
        /// <returns>
        /// CancelRefundOrderResponse
        /// </returns>
        public CancelRefundOrderResponse CancelRefundOrder(string disputeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelRefundOrderWithOptions(disputeId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消逆向单</para>
        /// </summary>
        /// 
        /// <returns>
        /// CancelRefundOrderResponse
        /// </returns>
        public async Task<CancelRefundOrderResponse> CancelRefundOrderAsync(string disputeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelRefundOrderWithOptionsAsync(disputeId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认收货（订单）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfirmDisburseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfirmDisburseResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ConfirmDisburseResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConfirmDisburseResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认收货（订单）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfirmDisburseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfirmDisburseResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ConfirmDisburseResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConfirmDisburseResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认收货（订单）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfirmDisburseRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfirmDisburseResponse
        /// </returns>
        public ConfirmDisburseResponse ConfirmDisburse(ConfirmDisburseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ConfirmDisburseWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认收货（订单）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfirmDisburseRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfirmDisburseResponse
        /// </returns>
        public async Task<ConfirmDisburseResponse> ConfirmDisburseAsync(ConfirmDisburseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ConfirmDisburseWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交运单信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGoodsShippingNoticeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGoodsShippingNoticeResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateGoodsShippingNoticeResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateGoodsShippingNoticeResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交运单信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGoodsShippingNoticeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGoodsShippingNoticeResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateGoodsShippingNoticeResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateGoodsShippingNoticeResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交运单信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGoodsShippingNoticeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGoodsShippingNoticeResponse
        /// </returns>
        public CreateGoodsShippingNoticeResponse CreateGoodsShippingNotice(CreateGoodsShippingNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateGoodsShippingNoticeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交运单信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGoodsShippingNoticeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGoodsShippingNoticeResponse
        /// </returns>
        public async Task<CreateGoodsShippingNoticeResponse> CreateGoodsShippingNoticeAsync(CreateGoodsShippingNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateGoodsShippingNoticeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建采购单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePurchaseOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePurchaseOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreatePurchaseOrderResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreatePurchaseOrderResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建采购单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePurchaseOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePurchaseOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreatePurchaseOrderResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreatePurchaseOrderResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建采购单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePurchaseOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePurchaseOrderResponse
        /// </returns>
        public CreatePurchaseOrderResponse CreatePurchaseOrder(CreatePurchaseOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePurchaseOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建采购单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePurchaseOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePurchaseOrderResponse
        /// </returns>
        public async Task<CreatePurchaseOrderResponse> CreatePurchaseOrderAsync(CreatePurchaseOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePurchaseOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建逆向单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRefundOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRefundOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateRefundOrderResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateRefundOrderResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建逆向单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRefundOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRefundOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateRefundOrderResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateRefundOrderResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建逆向单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRefundOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRefundOrderResponse
        /// </returns>
        public CreateRefundOrderResponse CreateRefundOrder(CreateRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRefundOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建逆向单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRefundOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRefundOrderResponse
        /// </returns>
        public async Task<CreateRefundOrderResponse> CreateRefundOrderAsync(CreateRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRefundOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询主单详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetOrderResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetOrderResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询主单详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetOrderResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetOrderResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询主单详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetOrderResponse
        /// </returns>
        public GetOrderResponse GetOrder(string orderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOrderWithOptions(orderId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询主单详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetOrderResponse
        /// </returns>
        public async Task<GetOrderResponse> GetOrderAsync(string orderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOrderWithOptionsAsync(orderId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询采购单状态</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPurchaseOrderStatusResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetPurchaseOrderStatusResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetPurchaseOrderStatusResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询采购单状态</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPurchaseOrderStatusResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetPurchaseOrderStatusResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetPurchaseOrderStatusResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询采购单状态</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPurchaseOrderStatusResponse
        /// </returns>
        public GetPurchaseOrderStatusResponse GetPurchaseOrderStatus(string purchaseOrderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPurchaseOrderStatusWithOptions(purchaseOrderId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询采购单状态</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPurchaseOrderStatusResponse
        /// </returns>
        public async Task<GetPurchaseOrderStatusResponse> GetPurchaseOrderStatusAsync(string purchaseOrderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPurchaseOrderStatusWithOptionsAsync(purchaseOrderId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分销商店铺</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPurchaserShopResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetPurchaserShopResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetPurchaserShopResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分销商店铺</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPurchaserShopResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetPurchaserShopResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetPurchaserShopResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分销商店铺</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPurchaserShopResponse
        /// </returns>
        public GetPurchaserShopResponse GetPurchaserShop(string purchaserId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPurchaserShopWithOptions(purchaserId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分销商店铺</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPurchaserShopResponse
        /// </returns>
        public async Task<GetPurchaserShopResponse> GetPurchaserShopAsync(string purchaserId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPurchaserShopWithOptionsAsync(purchaserId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询逆向单详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRefundOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetRefundOrderResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetRefundOrderResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询逆向单详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRefundOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetRefundOrderResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetRefundOrderResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询逆向单详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRefundOrderResponse
        /// </returns>
        public GetRefundOrderResponse GetRefundOrder(string disputeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRefundOrderWithOptions(disputeId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询逆向单详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRefundOrderResponse
        /// </returns>
        public async Task<GetRefundOrderResponse> GetRefundOrderAsync(string disputeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRefundOrderWithOptionsAsync(disputeId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询选品池商品详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSelectionProductRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSelectionProductResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetSelectionProductResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetSelectionProductResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询选品池商品详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSelectionProductRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSelectionProductResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetSelectionProductResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetSelectionProductResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询选品池商品详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSelectionProductRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSelectionProductResponse
        /// </returns>
        public GetSelectionProductResponse GetSelectionProduct(string productId, GetSelectionProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSelectionProductWithOptions(productId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询选品池商品详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSelectionProductRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSelectionProductResponse
        /// </returns>
        public async Task<GetSelectionProductResponse> GetSelectionProductAsync(string productId, GetSelectionProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSelectionProductWithOptionsAsync(productId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询选品池商品库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSelectionProductSaleInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSelectionProductSaleInfoResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetSelectionProductSaleInfoResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetSelectionProductSaleInfoResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询选品池商品库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSelectionProductSaleInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSelectionProductSaleInfoResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetSelectionProductSaleInfoResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetSelectionProductSaleInfoResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询选品池商品库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSelectionProductSaleInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSelectionProductSaleInfoResponse
        /// </returns>
        public GetSelectionProductSaleInfoResponse GetSelectionProductSaleInfo(string productId, GetSelectionProductSaleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSelectionProductSaleInfoWithOptions(productId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询选品池商品库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSelectionProductSaleInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSelectionProductSaleInfoResponse
        /// </returns>
        public async Task<GetSelectionProductSaleInfoResponse> GetSelectionProductSaleInfoAsync(string productId, GetSelectionProductSaleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSelectionProductSaleInfoWithOptionsAsync(productId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询类目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCategoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCategoriesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListCategoriesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListCategoriesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询类目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCategoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCategoriesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListCategoriesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListCategoriesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询类目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCategoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCategoriesResponse
        /// </returns>
        public ListCategoriesResponse ListCategories(ListCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCategoriesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询类目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCategoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCategoriesResponse
        /// </returns>
        public async Task<ListCategoriesResponse> ListCategoriesAsync(ListCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCategoriesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询物流信息（订单）</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLogisticsOrdersResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListLogisticsOrdersResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListLogisticsOrdersResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询物流信息（订单）</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLogisticsOrdersResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListLogisticsOrdersResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListLogisticsOrdersResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询物流信息（订单）</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListLogisticsOrdersResponse
        /// </returns>
        public ListLogisticsOrdersResponse ListLogisticsOrders(string orderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLogisticsOrdersWithOptions(orderId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询物流信息（订单）</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListLogisticsOrdersResponse
        /// </returns>
        public async Task<ListLogisticsOrdersResponse> ListLogisticsOrdersAsync(string orderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLogisticsOrdersWithOptionsAsync(orderId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>采购方店铺列表查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPurchaserShopsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPurchaserShopsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListPurchaserShopsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListPurchaserShopsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>采购方店铺列表查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPurchaserShopsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPurchaserShopsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListPurchaserShopsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListPurchaserShopsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>采购方店铺列表查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPurchaserShopsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPurchaserShopsResponse
        /// </returns>
        public ListPurchaserShopsResponse ListPurchaserShops(ListPurchaserShopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPurchaserShopsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>采购方店铺列表查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPurchaserShopsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPurchaserShopsResponse
        /// </returns>
        public async Task<ListPurchaserShopsResponse> ListPurchaserShopsAsync(ListPurchaserShopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPurchaserShopsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询选品池商品库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSelectionProductSaleInfosRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSelectionProductSaleInfosResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListSelectionProductSaleInfosResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListSelectionProductSaleInfosResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询选品池商品库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSelectionProductSaleInfosRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSelectionProductSaleInfosResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListSelectionProductSaleInfosResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListSelectionProductSaleInfosResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询选品池商品库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSelectionProductSaleInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSelectionProductSaleInfosResponse
        /// </returns>
        public ListSelectionProductSaleInfosResponse ListSelectionProductSaleInfos(ListSelectionProductSaleInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSelectionProductSaleInfosWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询选品池商品库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSelectionProductSaleInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSelectionProductSaleInfosResponse
        /// </returns>
        public async Task<ListSelectionProductSaleInfosResponse> ListSelectionProductSaleInfosAsync(ListSelectionProductSaleInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSelectionProductSaleInfosWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询商品列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSelectionProductsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSelectionProductsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListSelectionProductsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListSelectionProductsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询商品列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSelectionProductsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSelectionProductsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListSelectionProductsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListSelectionProductsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询商品列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSelectionProductsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSelectionProductsResponse
        /// </returns>
        public ListSelectionProductsResponse ListSelectionProducts(ListSelectionProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSelectionProductsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询商品列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSelectionProductsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSelectionProductsResponse
        /// </returns>
        public async Task<ListSelectionProductsResponse> ListSelectionProductsAsync(ListSelectionProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSelectionProductsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询选品池商品SKU库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSelectionSkuSaleInfosRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSelectionSkuSaleInfosResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListSelectionSkuSaleInfosResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListSelectionSkuSaleInfosResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询选品池商品SKU库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSelectionSkuSaleInfosRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSelectionSkuSaleInfosResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListSelectionSkuSaleInfosResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListSelectionSkuSaleInfosResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询选品池商品SKU库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSelectionSkuSaleInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSelectionSkuSaleInfosResponse
        /// </returns>
        public ListSelectionSkuSaleInfosResponse ListSelectionSkuSaleInfos(ListSelectionSkuSaleInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSelectionSkuSaleInfosWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询选品池商品SKU库存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSelectionSkuSaleInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSelectionSkuSaleInfosResponse
        /// </returns>
        public async Task<ListSelectionSkuSaleInfosResponse> ListSelectionSkuSaleInfosAsync(ListSelectionSkuSaleInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSelectionSkuSaleInfosWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询地址divisionCode</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChildDivisionCodeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryChildDivisionCodeResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryChildDivisionCodeResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryChildDivisionCodeResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询地址divisionCode</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChildDivisionCodeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryChildDivisionCodeResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryChildDivisionCodeResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryChildDivisionCodeResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询地址divisionCode</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChildDivisionCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryChildDivisionCodeResponse
        /// </returns>
        public QueryChildDivisionCodeResponse QueryChildDivisionCode(QueryChildDivisionCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryChildDivisionCodeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询地址divisionCode</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChildDivisionCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryChildDivisionCodeResponse
        /// </returns>
        public async Task<QueryChildDivisionCodeResponse> QueryChildDivisionCodeAsync(QueryChildDivisionCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryChildDivisionCodeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询主单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrdersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOrdersResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryOrdersResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryOrdersResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询主单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrdersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOrdersResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryOrdersResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryOrdersResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询主单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOrdersResponse
        /// </returns>
        public QueryOrdersResponse QueryOrders(QueryOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryOrdersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询主单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOrdersResponse
        /// </returns>
        public async Task<QueryOrdersResponse> QueryOrdersAsync(QueryOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryOrdersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>渲染采购单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenderPurchaseOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenderPurchaseOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RenderPurchaseOrderResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RenderPurchaseOrderResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>渲染采购单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenderPurchaseOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenderPurchaseOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RenderPurchaseOrderResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RenderPurchaseOrderResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>渲染采购单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenderPurchaseOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// RenderPurchaseOrderResponse
        /// </returns>
        public RenderPurchaseOrderResponse RenderPurchaseOrder(RenderPurchaseOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RenderPurchaseOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>渲染采购单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenderPurchaseOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// RenderPurchaseOrderResponse
        /// </returns>
        public async Task<RenderPurchaseOrderResponse> RenderPurchaseOrderAsync(RenderPurchaseOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RenderPurchaseOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>逆向单渲染</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenderRefundOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenderRefundOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RenderRefundOrderResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RenderRefundOrderResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>逆向单渲染</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenderRefundOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenderRefundOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RenderRefundOrderResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RenderRefundOrderResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>逆向单渲染</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenderRefundOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// RenderRefundOrderResponse
        /// </returns>
        public RenderRefundOrderResponse RenderRefundOrder(RenderRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RenderRefundOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>逆向单渲染</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenderRefundOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// RenderRefundOrderResponse
        /// </returns>
        public async Task<RenderRefundOrderResponse> RenderRefundOrderAsync(RenderRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RenderRefundOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索商品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchProductsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchProductsResponse
        /// </returns>
        public SearchProductsResponse SearchProductsWithOptions(SearchProductsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandName))
            {
                body["brandName"] = request.BrandName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryIds))
            {
                body["categoryIds"] = request.CategoryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                body["createEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                body["createStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionHighPrice))
            {
                body["distributionHighPrice"] = request.DistributionHighPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionHighPriceRatio))
            {
                body["distributionHighPriceRatio"] = request.DistributionHighPriceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionLowPrice))
            {
                body["distributionLowPrice"] = request.DistributionLowPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionLowPriceRatio))
            {
                body["distributionLowPriceRatio"] = request.DistributionLowPriceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighMarkPrice))
            {
                body["highMarkPrice"] = request.HighMarkPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighPrice))
            {
                body["highPrice"] = request.HighPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InGroup))
            {
                body["inGroup"] = request.InGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InGroupEndTime))
            {
                body["inGroupEndTime"] = request.InGroupEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InGroupStartTime))
            {
                body["inGroupStartTime"] = request.InGroupStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InventoryRiskLevel))
            {
                body["inventoryRiskLevel"] = request.InventoryRiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                body["lmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LowMarkPrice))
            {
                body["lowMarkPrice"] = request.LowMarkPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LowPrice))
            {
                body["lowPrice"] = request.LowPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyEndTime))
            {
                body["modifyEndTime"] = request.ModifyEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyStartTime))
            {
                body["modifyStartTime"] = request.ModifyStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                body["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductStatus))
            {
                body["productStatus"] = request.ProductStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserId))
            {
                body["purchaserId"] = request.PurchaserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxRate))
            {
                body["taxRate"] = request.TaxRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeModeAndCredit))
            {
                body["tradeModeAndCredit"] = request.TradeModeAndCredit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchProducts",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/selectionPool/selection-group/product/command/searchProduct",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SearchProductsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SearchProductsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索商品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchProductsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchProductsResponse
        /// </returns>
        public async Task<SearchProductsResponse> SearchProductsWithOptionsAsync(SearchProductsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandName))
            {
                body["brandName"] = request.BrandName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryIds))
            {
                body["categoryIds"] = request.CategoryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                body["createEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                body["createStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionHighPrice))
            {
                body["distributionHighPrice"] = request.DistributionHighPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionHighPriceRatio))
            {
                body["distributionHighPriceRatio"] = request.DistributionHighPriceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionLowPrice))
            {
                body["distributionLowPrice"] = request.DistributionLowPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionLowPriceRatio))
            {
                body["distributionLowPriceRatio"] = request.DistributionLowPriceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighMarkPrice))
            {
                body["highMarkPrice"] = request.HighMarkPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighPrice))
            {
                body["highPrice"] = request.HighPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InGroup))
            {
                body["inGroup"] = request.InGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InGroupEndTime))
            {
                body["inGroupEndTime"] = request.InGroupEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InGroupStartTime))
            {
                body["inGroupStartTime"] = request.InGroupStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InventoryRiskLevel))
            {
                body["inventoryRiskLevel"] = request.InventoryRiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                body["lmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LowMarkPrice))
            {
                body["lowMarkPrice"] = request.LowMarkPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LowPrice))
            {
                body["lowPrice"] = request.LowPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyEndTime))
            {
                body["modifyEndTime"] = request.ModifyEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyStartTime))
            {
                body["modifyStartTime"] = request.ModifyStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                body["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductStatus))
            {
                body["productStatus"] = request.ProductStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserId))
            {
                body["purchaserId"] = request.PurchaserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxRate))
            {
                body["taxRate"] = request.TaxRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeModeAndCredit))
            {
                body["tradeModeAndCredit"] = request.TradeModeAndCredit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchProducts",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/selectionPool/selection-group/product/command/searchProduct",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SearchProductsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SearchProductsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索商品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchProductsRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchProductsResponse
        /// </returns>
        public SearchProductsResponse SearchProducts(SearchProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchProductsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索商品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchProductsRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchProductsResponse
        /// </returns>
        public async Task<SearchProductsResponse> SearchProductsAsync(SearchProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchProductsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>入库操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SelectionGroupAddProductRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SelectionGroupAddProductResponse
        /// </returns>
        public SelectionGroupAddProductResponse SelectionGroupAddProductWithOptions(SelectionGroupAddProductRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductIds))
            {
                body["productIds"] = request.ProductIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserId))
            {
                body["purchaserId"] = request.PurchaserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SelectionGroupAddProduct",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/selectionPool/selection-group/product/command/addProduct",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SelectionGroupAddProductResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SelectionGroupAddProductResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>入库操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SelectionGroupAddProductRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SelectionGroupAddProductResponse
        /// </returns>
        public async Task<SelectionGroupAddProductResponse> SelectionGroupAddProductWithOptionsAsync(SelectionGroupAddProductRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductIds))
            {
                body["productIds"] = request.ProductIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserId))
            {
                body["purchaserId"] = request.PurchaserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SelectionGroupAddProduct",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/selectionPool/selection-group/product/command/addProduct",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SelectionGroupAddProductResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SelectionGroupAddProductResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>入库操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SelectionGroupAddProductRequest
        /// </param>
        /// 
        /// <returns>
        /// SelectionGroupAddProductResponse
        /// </returns>
        public SelectionGroupAddProductResponse SelectionGroupAddProduct(SelectionGroupAddProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SelectionGroupAddProductWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>入库操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SelectionGroupAddProductRequest
        /// </param>
        /// 
        /// <returns>
        /// SelectionGroupAddProductResponse
        /// </returns>
        public async Task<SelectionGroupAddProductResponse> SelectionGroupAddProductAsync(SelectionGroupAddProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SelectionGroupAddProductWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出库操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SelectionGroupRemoveProductRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SelectionGroupRemoveProductResponse
        /// </returns>
        public SelectionGroupRemoveProductResponse SelectionGroupRemoveProductWithOptions(SelectionGroupRemoveProductRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductIds))
            {
                body["productIds"] = request.ProductIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserId))
            {
                body["purchaserId"] = request.PurchaserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SelectionGroupRemoveProduct",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/selectionPool/selection-group/product/command/removeProduct",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SelectionGroupRemoveProductResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SelectionGroupRemoveProductResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出库操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SelectionGroupRemoveProductRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SelectionGroupRemoveProductResponse
        /// </returns>
        public async Task<SelectionGroupRemoveProductResponse> SelectionGroupRemoveProductWithOptionsAsync(SelectionGroupRemoveProductRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductIds))
            {
                body["productIds"] = request.ProductIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserId))
            {
                body["purchaserId"] = request.PurchaserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SelectionGroupRemoveProduct",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/opensaas-s2b/opensaas-s2b-biz-trade/v2/selectionPool/selection-group/product/command/removeProduct",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SelectionGroupRemoveProductResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SelectionGroupRemoveProductResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出库操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SelectionGroupRemoveProductRequest
        /// </param>
        /// 
        /// <returns>
        /// SelectionGroupRemoveProductResponse
        /// </returns>
        public SelectionGroupRemoveProductResponse SelectionGroupRemoveProduct(SelectionGroupRemoveProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SelectionGroupRemoveProductWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出库操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SelectionGroupRemoveProductRequest
        /// </param>
        /// 
        /// <returns>
        /// SelectionGroupRemoveProductResponse
        /// </returns>
        public async Task<SelectionGroupRemoveProductResponse> SelectionGroupRemoveProductAsync(SelectionGroupRemoveProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SelectionGroupRemoveProductWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>渲染拆分采购单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SplitPurchaseOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SplitPurchaseOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SplitPurchaseOrderResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SplitPurchaseOrderResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>渲染拆分采购单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SplitPurchaseOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SplitPurchaseOrderResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SplitPurchaseOrderResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SplitPurchaseOrderResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>渲染拆分采购单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SplitPurchaseOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// SplitPurchaseOrderResponse
        /// </returns>
        public SplitPurchaseOrderResponse SplitPurchaseOrder(SplitPurchaseOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SplitPurchaseOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>渲染拆分采购单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SplitPurchaseOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// SplitPurchaseOrderResponse
        /// </returns>
        public async Task<SplitPurchaseOrderResponse> SplitPurchaseOrderAsync(SplitPurchaseOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SplitPurchaseOrderWithOptionsAsync(request, headers, runtime);
        }

    }
}
