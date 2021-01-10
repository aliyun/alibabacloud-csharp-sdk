// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Linkedmall20180116.Models;

namespace AlibabaCloud.SDK.Linkedmall20180116
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

        public AddAddressResponse AddAddressWithOptions(AddAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAddressResponse>(DoRPCRequest("AddAddress", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddAddressResponse> AddAddressWithOptionsAsync(AddAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAddressResponse>(await DoRPCRequestAsync("AddAddress", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddAddressResponse AddAddress(AddAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAddressWithOptions(request, runtime);
        }

        public async Task<AddAddressResponse> AddAddressAsync(AddAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAddressWithOptionsAsync(request, runtime);
        }

        public AddItemLimitRuleResponse AddItemLimitRuleWithOptions(AddItemLimitRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddItemLimitRuleResponse>(DoRPCRequest("AddItemLimitRule", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddItemLimitRuleResponse> AddItemLimitRuleWithOptionsAsync(AddItemLimitRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddItemLimitRuleResponse>(await DoRPCRequestAsync("AddItemLimitRule", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddItemLimitRuleResponse AddItemLimitRule(AddItemLimitRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddItemLimitRuleWithOptions(request, runtime);
        }

        public async Task<AddItemLimitRuleResponse> AddItemLimitRuleAsync(AddItemLimitRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddItemLimitRuleWithOptionsAsync(request, runtime);
        }

        public AddSupplierNewItemsResponse AddSupplierNewItemsWithOptions(AddSupplierNewItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSupplierNewItemsResponse>(DoRPCRequest("AddSupplierNewItems", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddSupplierNewItemsResponse> AddSupplierNewItemsWithOptionsAsync(AddSupplierNewItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSupplierNewItemsResponse>(await DoRPCRequestAsync("AddSupplierNewItems", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddSupplierNewItemsResponse AddSupplierNewItems(AddSupplierNewItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSupplierNewItemsWithOptions(request, runtime);
        }

        public async Task<AddSupplierNewItemsResponse> AddSupplierNewItemsAsync(AddSupplierNewItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSupplierNewItemsWithOptionsAsync(request, runtime);
        }

        public ApplyRefundResponse ApplyRefundWithOptions(ApplyRefundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplyRefundResponse>(DoRPCRequest("ApplyRefund", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ApplyRefundResponse> ApplyRefundWithOptionsAsync(ApplyRefundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplyRefundResponse>(await DoRPCRequestAsync("ApplyRefund", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ApplyRefundResponse ApplyRefund(ApplyRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyRefundWithOptions(request, runtime);
        }

        public async Task<ApplyRefundResponse> ApplyRefundAsync(ApplyRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyRefundWithOptionsAsync(request, runtime);
        }

        public BatchRegistAnonymousTbAccountResponse BatchRegistAnonymousTbAccountWithOptions(BatchRegistAnonymousTbAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchRegistAnonymousTbAccountResponse>(DoRPCRequest("BatchRegistAnonymousTbAccount", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchRegistAnonymousTbAccountResponse> BatchRegistAnonymousTbAccountWithOptionsAsync(BatchRegistAnonymousTbAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchRegistAnonymousTbAccountResponse>(await DoRPCRequestAsync("BatchRegistAnonymousTbAccount", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchRegistAnonymousTbAccountResponse BatchRegistAnonymousTbAccount(BatchRegistAnonymousTbAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchRegistAnonymousTbAccountWithOptions(request, runtime);
        }

        public async Task<BatchRegistAnonymousTbAccountResponse> BatchRegistAnonymousTbAccountAsync(BatchRegistAnonymousTbAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchRegistAnonymousTbAccountWithOptionsAsync(request, runtime);
        }

        public CancelOrderResponse CancelOrderWithOptions(CancelOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelOrderResponse>(DoRPCRequest("CancelOrder", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelOrderResponse> CancelOrderWithOptionsAsync(CancelOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelOrderResponse>(await DoRPCRequestAsync("CancelOrder", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CancelRefundResponse CancelRefundWithOptions(CancelRefundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelRefundResponse>(DoRPCRequest("CancelRefund", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelRefundResponse> CancelRefundWithOptionsAsync(CancelRefundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelRefundResponse>(await DoRPCRequestAsync("CancelRefund", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelRefundResponse CancelRefund(CancelRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelRefundWithOptions(request, runtime);
        }

        public async Task<CancelRefundResponse> CancelRefundAsync(CancelRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelRefundWithOptionsAsync(request, runtime);
        }

        public ConfirmDisburseResponse ConfirmDisburseWithOptions(ConfirmDisburseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfirmDisburseResponse>(DoRPCRequest("ConfirmDisburse", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfirmDisburseResponse> ConfirmDisburseWithOptionsAsync(ConfirmDisburseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfirmDisburseResponse>(await DoRPCRequestAsync("ConfirmDisburse", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConfirmDisburseResponse ConfirmDisburse(ConfirmDisburseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfirmDisburseWithOptions(request, runtime);
        }

        public async Task<ConfirmDisburseResponse> ConfirmDisburseAsync(ConfirmDisburseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfirmDisburseWithOptionsAsync(request, runtime);
        }

        public CreateMovieTicketOrderResponse CreateMovieTicketOrderWithOptions(CreateMovieTicketOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateMovieTicketOrderResponse>(DoRPCRequest("CreateMovieTicketOrder", "2018-01-16", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<CreateMovieTicketOrderResponse> CreateMovieTicketOrderWithOptionsAsync(CreateMovieTicketOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateMovieTicketOrderResponse>(await DoRPCRequestAsync("CreateMovieTicketOrder", "2018-01-16", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public CreateMovieTicketOrderResponse CreateMovieTicketOrder(CreateMovieTicketOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMovieTicketOrderWithOptions(request, runtime);
        }

        public async Task<CreateMovieTicketOrderResponse> CreateMovieTicketOrderAsync(CreateMovieTicketOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMovieTicketOrderWithOptionsAsync(request, runtime);
        }

        public CreateOrderResponse CreateOrderWithOptions(CreateOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateOrderResponse>(DoRPCRequest("CreateOrder", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateOrderResponse> CreateOrderWithOptionsAsync(CreateOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateOrderResponse>(await DoRPCRequestAsync("CreateOrder", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateOrderV2Response CreateOrderV2WithOptions(CreateOrderV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateOrderV2Response>(DoRPCRequest("CreateOrderV2", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateOrderV2Response> CreateOrderV2WithOptionsAsync(CreateOrderV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateOrderV2Response>(await DoRPCRequestAsync("CreateOrderV2", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateOrderV2Response CreateOrderV2(CreateOrderV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOrderV2WithOptions(request, runtime);
        }

        public async Task<CreateOrderV2Response> CreateOrderV2Async(CreateOrderV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOrderV2WithOptionsAsync(request, runtime);
        }

        public CreatePayUrlResponse CreatePayUrlWithOptions(CreatePayUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePayUrlResponse>(DoRPCRequest("CreatePayUrl", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreatePayUrlResponse> CreatePayUrlWithOptionsAsync(CreatePayUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePayUrlResponse>(await DoRPCRequestAsync("CreatePayUrl", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreatePayUrlResponse CreatePayUrl(CreatePayUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePayUrlWithOptions(request, runtime);
        }

        public async Task<CreatePayUrlResponse> CreatePayUrlAsync(CreatePayUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePayUrlWithOptionsAsync(request, runtime);
        }

        public CreateVirtualProductOrderResponse CreateVirtualProductOrderWithOptions(CreateVirtualProductOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVirtualProductOrderResponse>(DoRPCRequest("CreateVirtualProductOrder", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVirtualProductOrderResponse> CreateVirtualProductOrderWithOptionsAsync(CreateVirtualProductOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVirtualProductOrderResponse>(await DoRPCRequestAsync("CreateVirtualProductOrder", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVirtualProductOrderResponse CreateVirtualProductOrder(CreateVirtualProductOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVirtualProductOrderWithOptions(request, runtime);
        }

        public async Task<CreateVirtualProductOrderResponse> CreateVirtualProductOrderAsync(CreateVirtualProductOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVirtualProductOrderWithOptionsAsync(request, runtime);
        }

        public CreateWithholdTradeResponse CreateWithholdTradeWithOptions(CreateWithholdTradeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateWithholdTradeResponse>(DoRPCRequest("CreateWithholdTrade", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateWithholdTradeResponse> CreateWithholdTradeWithOptionsAsync(CreateWithholdTradeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateWithholdTradeResponse>(await DoRPCRequestAsync("CreateWithholdTrade", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateWithholdTradeResponse CreateWithholdTrade(CreateWithholdTradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWithholdTradeWithOptions(request, runtime);
        }

        public async Task<CreateWithholdTradeResponse> CreateWithholdTradeAsync(CreateWithholdTradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWithholdTradeWithOptionsAsync(request, runtime);
        }

        public DeleteBizItemsResponse DeleteBizItemsWithOptions(DeleteBizItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBizItemsResponse>(DoRPCRequest("DeleteBizItems", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteBizItemsResponse> DeleteBizItemsWithOptionsAsync(DeleteBizItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBizItemsResponse>(await DoRPCRequestAsync("DeleteBizItems", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteBizItemsResponse DeleteBizItems(DeleteBizItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBizItemsWithOptions(request, runtime);
        }

        public async Task<DeleteBizItemsResponse> DeleteBizItemsAsync(DeleteBizItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBizItemsWithOptionsAsync(request, runtime);
        }

        public DeleteItemLimitRuleResponse DeleteItemLimitRuleWithOptions(DeleteItemLimitRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteItemLimitRuleResponse>(DoRPCRequest("DeleteItemLimitRule", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteItemLimitRuleResponse> DeleteItemLimitRuleWithOptionsAsync(DeleteItemLimitRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteItemLimitRuleResponse>(await DoRPCRequestAsync("DeleteItemLimitRule", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteItemLimitRuleResponse DeleteItemLimitRule(DeleteItemLimitRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteItemLimitRuleWithOptions(request, runtime);
        }

        public async Task<DeleteItemLimitRuleResponse> DeleteItemLimitRuleAsync(DeleteItemLimitRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteItemLimitRuleWithOptionsAsync(request, runtime);
        }

        public EnableOrderResponse EnableOrderWithOptions(EnableOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableOrderResponse>(DoRPCRequest("EnableOrder", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableOrderResponse> EnableOrderWithOptionsAsync(EnableOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableOrderResponse>(await DoRPCRequestAsync("EnableOrder", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableOrderResponse EnableOrder(EnableOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableOrderWithOptions(request, runtime);
        }

        public async Task<EnableOrderResponse> EnableOrderAsync(EnableOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableOrderWithOptionsAsync(request, runtime);
        }

        public GetCategoryChainResponse GetCategoryChainWithOptions(GetCategoryChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCategoryChainResponse>(DoRPCRequest("GetCategoryChain", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetCategoryChainResponse> GetCategoryChainWithOptionsAsync(GetCategoryChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCategoryChainResponse>(await DoRPCRequestAsync("GetCategoryChain", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetCategoryChainResponse GetCategoryChain(GetCategoryChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCategoryChainWithOptions(request, runtime);
        }

        public async Task<GetCategoryChainResponse> GetCategoryChainAsync(GetCategoryChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCategoryChainWithOptionsAsync(request, runtime);
        }

        public GetCategoryListResponse GetCategoryListWithOptions(GetCategoryListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCategoryListResponse>(DoRPCRequest("GetCategoryList", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetCategoryListResponse> GetCategoryListWithOptionsAsync(GetCategoryListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCategoryListResponse>(await DoRPCRequestAsync("GetCategoryList", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetCategoryListResponse GetCategoryList(GetCategoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCategoryListWithOptions(request, runtime);
        }

        public async Task<GetCategoryListResponse> GetCategoryListAsync(GetCategoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCategoryListWithOptionsAsync(request, runtime);
        }

        public GetCustomServiceUrlResponse GetCustomServiceUrlWithOptions(GetCustomServiceUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCustomServiceUrlResponse>(DoRPCRequest("GetCustomServiceUrl", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetCustomServiceUrlResponse> GetCustomServiceUrlWithOptionsAsync(GetCustomServiceUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCustomServiceUrlResponse>(await DoRPCRequestAsync("GetCustomServiceUrl", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetCustomServiceUrlResponse GetCustomServiceUrl(GetCustomServiceUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomServiceUrlWithOptions(request, runtime);
        }

        public async Task<GetCustomServiceUrlResponse> GetCustomServiceUrlAsync(GetCustomServiceUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomServiceUrlWithOptionsAsync(request, runtime);
        }

        public GetGuidePageResponse GetGuidePageWithOptions(GetGuidePageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetGuidePageResponse>(DoRPCRequest("GetGuidePage", "2018-01-16", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetGuidePageResponse> GetGuidePageWithOptionsAsync(GetGuidePageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetGuidePageResponse>(await DoRPCRequestAsync("GetGuidePage", "2018-01-16", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetGuidePageResponse GetGuidePage(GetGuidePageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGuidePageWithOptions(request, runtime);
        }

        public async Task<GetGuidePageResponse> GetGuidePageAsync(GetGuidePageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGuidePageWithOptionsAsync(request, runtime);
        }

        public GetItemPromotionResponse GetItemPromotionWithOptions(GetItemPromotionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetItemPromotionResponse>(DoRPCRequest("GetItemPromotion", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetItemPromotionResponse> GetItemPromotionWithOptionsAsync(GetItemPromotionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetItemPromotionResponse>(await DoRPCRequestAsync("GetItemPromotion", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetItemPromotionResponse GetItemPromotion(GetItemPromotionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetItemPromotionWithOptions(request, runtime);
        }

        public async Task<GetItemPromotionResponse> GetItemPromotionAsync(GetItemPromotionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetItemPromotionWithOptionsAsync(request, runtime);
        }

        public GetLoginPageResponse GetLoginPageWithOptions(GetLoginPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLoginPageResponse>(DoRPCRequest("GetLoginPage", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLoginPageResponse> GetLoginPageWithOptionsAsync(GetLoginPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLoginPageResponse>(await DoRPCRequestAsync("GetLoginPage", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLoginPageResponse GetLoginPage(GetLoginPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLoginPageWithOptions(request, runtime);
        }

        public async Task<GetLoginPageResponse> GetLoginPageAsync(GetLoginPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLoginPageWithOptionsAsync(request, runtime);
        }

        public GetSwitchUrlResponse GetSwitchUrlWithOptions(GetSwitchUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSwitchUrlResponse>(DoRPCRequest("GetSwitchUrl", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSwitchUrlResponse> GetSwitchUrlWithOptionsAsync(GetSwitchUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSwitchUrlResponse>(await DoRPCRequestAsync("GetSwitchUrl", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSwitchUrlResponse GetSwitchUrl(GetSwitchUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSwitchUrlWithOptions(request, runtime);
        }

        public async Task<GetSwitchUrlResponse> GetSwitchUrlAsync(GetSwitchUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSwitchUrlWithOptionsAsync(request, runtime);
        }

        public GetUserInfoResponse GetUserInfoWithOptions(GetUserInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserInfoResponse>(DoRPCRequest("GetUserInfo", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserInfoResponse> GetUserInfoWithOptionsAsync(GetUserInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserInfoResponse>(await DoRPCRequestAsync("GetUserInfo", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserInfoResponse GetUserInfo(GetUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserInfoWithOptions(request, runtime);
        }

        public async Task<GetUserInfoResponse> GetUserInfoAsync(GetUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserInfoWithOptionsAsync(request, runtime);
        }

        public GetWithholdSignPageUrlResponse GetWithholdSignPageUrlWithOptions(GetWithholdSignPageUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetWithholdSignPageUrlResponse>(DoRPCRequest("GetWithholdSignPageUrl", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetWithholdSignPageUrlResponse> GetWithholdSignPageUrlWithOptionsAsync(GetWithholdSignPageUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetWithholdSignPageUrlResponse>(await DoRPCRequestAsync("GetWithholdSignPageUrl", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetWithholdSignPageUrlResponse GetWithholdSignPageUrl(GetWithholdSignPageUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWithholdSignPageUrlWithOptions(request, runtime);
        }

        public async Task<GetWithholdSignPageUrlResponse> GetWithholdSignPageUrlAsync(GetWithholdSignPageUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWithholdSignPageUrlWithOptionsAsync(request, runtime);
        }

        public InitApplyRefundResponse InitApplyRefundWithOptions(InitApplyRefundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InitApplyRefundResponse>(DoRPCRequest("InitApplyRefund", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InitApplyRefundResponse> InitApplyRefundWithOptionsAsync(InitApplyRefundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InitApplyRefundResponse>(await DoRPCRequestAsync("InitApplyRefund", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InitApplyRefundResponse InitApplyRefund(InitApplyRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitApplyRefundWithOptions(request, runtime);
        }

        public async Task<InitApplyRefundResponse> InitApplyRefundAsync(InitApplyRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitApplyRefundWithOptionsAsync(request, runtime);
        }

        public ListItemActivitiesResponse ListItemActivitiesWithOptions(ListItemActivitiesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListItemActivitiesShrinkRequest request = new ListItemActivitiesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListItemActivitiesResponse>(DoRPCRequest("ListItemActivities", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListItemActivitiesResponse> ListItemActivitiesWithOptionsAsync(ListItemActivitiesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListItemActivitiesShrinkRequest request = new ListItemActivitiesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListItemActivitiesResponse>(await DoRPCRequestAsync("ListItemActivities", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListItemActivitiesResponse ListItemActivities(ListItemActivitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListItemActivitiesWithOptions(request, runtime);
        }

        public async Task<ListItemActivitiesResponse> ListItemActivitiesAsync(ListItemActivitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListItemActivitiesWithOptionsAsync(request, runtime);
        }

        public ModifyBasicAndBizItemsResponse ModifyBasicAndBizItemsWithOptions(ModifyBasicAndBizItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBasicAndBizItemsResponse>(DoRPCRequest("ModifyBasicAndBizItems", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBasicAndBizItemsResponse> ModifyBasicAndBizItemsWithOptionsAsync(ModifyBasicAndBizItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBasicAndBizItemsResponse>(await DoRPCRequestAsync("ModifyBasicAndBizItems", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyBasicAndBizItemsResponse ModifyBasicAndBizItems(ModifyBasicAndBizItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBasicAndBizItemsWithOptions(request, runtime);
        }

        public async Task<ModifyBasicAndBizItemsResponse> ModifyBasicAndBizItemsAsync(ModifyBasicAndBizItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBasicAndBizItemsWithOptionsAsync(request, runtime);
        }

        public ModifyBizItemsResponse ModifyBizItemsWithOptions(ModifyBizItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBizItemsResponse>(DoRPCRequest("ModifyBizItems", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBizItemsResponse> ModifyBizItemsWithOptionsAsync(ModifyBizItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBizItemsResponse>(await DoRPCRequestAsync("ModifyBizItems", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyBizItemsResponse ModifyBizItems(ModifyBizItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBizItemsWithOptions(request, runtime);
        }

        public async Task<ModifyBizItemsResponse> ModifyBizItemsAsync(ModifyBizItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBizItemsWithOptionsAsync(request, runtime);
        }

        public ModifyItemLimitRuleResponse ModifyItemLimitRuleWithOptions(ModifyItemLimitRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyItemLimitRuleResponse>(DoRPCRequest("ModifyItemLimitRule", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyItemLimitRuleResponse> ModifyItemLimitRuleWithOptionsAsync(ModifyItemLimitRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyItemLimitRuleResponse>(await DoRPCRequestAsync("ModifyItemLimitRule", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyItemLimitRuleResponse ModifyItemLimitRule(ModifyItemLimitRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyItemLimitRuleWithOptions(request, runtime);
        }

        public async Task<ModifyItemLimitRuleResponse> ModifyItemLimitRuleAsync(ModifyItemLimitRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyItemLimitRuleWithOptionsAsync(request, runtime);
        }

        public NotifyPayOrderStatusResponse NotifyPayOrderStatusWithOptions(NotifyPayOrderStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<NotifyPayOrderStatusResponse>(DoRPCRequest("NotifyPayOrderStatus", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<NotifyPayOrderStatusResponse> NotifyPayOrderStatusWithOptionsAsync(NotifyPayOrderStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<NotifyPayOrderStatusResponse>(await DoRPCRequestAsync("NotifyPayOrderStatus", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public NotifyPayOrderStatusResponse NotifyPayOrderStatus(NotifyPayOrderStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return NotifyPayOrderStatusWithOptions(request, runtime);
        }

        public async Task<NotifyPayOrderStatusResponse> NotifyPayOrderStatusAsync(NotifyPayOrderStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await NotifyPayOrderStatusWithOptionsAsync(request, runtime);
        }

        public NotifyWithholdFundResponse NotifyWithholdFundWithOptions(NotifyWithholdFundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<NotifyWithholdFundResponse>(DoRPCRequest("NotifyWithholdFund", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<NotifyWithholdFundResponse> NotifyWithholdFundWithOptionsAsync(NotifyWithholdFundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<NotifyWithholdFundResponse>(await DoRPCRequestAsync("NotifyWithholdFund", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public NotifyWithholdFundResponse NotifyWithholdFund(NotifyWithholdFundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return NotifyWithholdFundWithOptions(request, runtime);
        }

        public async Task<NotifyWithholdFundResponse> NotifyWithholdFundAsync(NotifyWithholdFundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await NotifyWithholdFundWithOptionsAsync(request, runtime);
        }

        public QueryActivityItemsResponse QueryActivityItemsWithOptions(QueryActivityItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryActivityItemsResponse>(DoRPCRequest("QueryActivityItems", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryActivityItemsResponse> QueryActivityItemsWithOptionsAsync(QueryActivityItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryActivityItemsResponse>(await DoRPCRequestAsync("QueryActivityItems", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryAddressResponse QueryAddressWithOptions(QueryAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAddressResponse>(DoRPCRequest("QueryAddress", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAddressResponse> QueryAddressWithOptionsAsync(QueryAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAddressResponse>(await DoRPCRequestAsync("QueryAddress", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAddressResponse QueryAddress(QueryAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAddressWithOptions(request, runtime);
        }

        public async Task<QueryAddressResponse> QueryAddressAsync(QueryAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAddressWithOptionsAsync(request, runtime);
        }

        public QueryAddressDetailResponse QueryAddressDetailWithOptions(QueryAddressDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAddressDetailResponse>(DoRPCRequest("QueryAddressDetail", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAddressDetailResponse> QueryAddressDetailWithOptionsAsync(QueryAddressDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAddressDetailResponse>(await DoRPCRequestAsync("QueryAddressDetail", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAddressDetailResponse QueryAddressDetail(QueryAddressDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAddressDetailWithOptions(request, runtime);
        }

        public async Task<QueryAddressDetailResponse> QueryAddressDetailAsync(QueryAddressDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAddressDetailWithOptionsAsync(request, runtime);
        }

        public QueryAddressListResponse QueryAddressListWithOptions(QueryAddressListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAddressListResponse>(DoRPCRequest("QueryAddressList", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAddressListResponse> QueryAddressListWithOptionsAsync(QueryAddressListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAddressListResponse>(await DoRPCRequestAsync("QueryAddressList", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAddressListResponse QueryAddressList(QueryAddressListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAddressListWithOptions(request, runtime);
        }

        public async Task<QueryAddressListResponse> QueryAddressListAsync(QueryAddressListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAddressListWithOptionsAsync(request, runtime);
        }

        public QueryAgreementResponse QueryAgreementWithOptions(QueryAgreementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAgreementResponse>(DoRPCRequest("QueryAgreement", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAgreementResponse> QueryAgreementWithOptionsAsync(QueryAgreementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAgreementResponse>(await DoRPCRequestAsync("QueryAgreement", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAgreementResponse QueryAgreement(QueryAgreementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAgreementWithOptions(request, runtime);
        }

        public async Task<QueryAgreementResponse> QueryAgreementAsync(QueryAgreementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAgreementWithOptionsAsync(request, runtime);
        }

        public QueryAllCinemasResponse QueryAllCinemasWithOptions(QueryAllCinemasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAllCinemasResponse>(DoRPCRequest("QueryAllCinemas", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAllCinemasResponse> QueryAllCinemasWithOptionsAsync(QueryAllCinemasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAllCinemasResponse>(await DoRPCRequestAsync("QueryAllCinemas", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAllCinemasResponse QueryAllCinemas(QueryAllCinemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAllCinemasWithOptions(request, runtime);
        }

        public async Task<QueryAllCinemasResponse> QueryAllCinemasAsync(QueryAllCinemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAllCinemasWithOptionsAsync(request, runtime);
        }

        public QueryAllCitiesResponse QueryAllCitiesWithOptions(QueryAllCitiesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryAllCitiesShrinkRequest request = new QueryAllCitiesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtJson))
            {
                request.ExtJsonShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtJson, "ExtJson", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAllCitiesResponse>(DoRPCRequest("QueryAllCities", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAllCitiesResponse> QueryAllCitiesWithOptionsAsync(QueryAllCitiesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryAllCitiesShrinkRequest request = new QueryAllCitiesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtJson))
            {
                request.ExtJsonShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtJson, "ExtJson", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAllCitiesResponse>(await DoRPCRequestAsync("QueryAllCities", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAllCitiesResponse QueryAllCities(QueryAllCitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAllCitiesWithOptions(request, runtime);
        }

        public async Task<QueryAllCitiesResponse> QueryAllCitiesAsync(QueryAllCitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAllCitiesWithOptionsAsync(request, runtime);
        }

        public QueryBatchRegistAnonymousTbAccountResultResponse QueryBatchRegistAnonymousTbAccountResultWithOptions(QueryBatchRegistAnonymousTbAccountResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryBatchRegistAnonymousTbAccountResultResponse>(DoRPCRequest("QueryBatchRegistAnonymousTbAccountResult", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryBatchRegistAnonymousTbAccountResultResponse> QueryBatchRegistAnonymousTbAccountResultWithOptionsAsync(QueryBatchRegistAnonymousTbAccountResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryBatchRegistAnonymousTbAccountResultResponse>(await DoRPCRequestAsync("QueryBatchRegistAnonymousTbAccountResult", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryBatchRegistAnonymousTbAccountResultResponse QueryBatchRegistAnonymousTbAccountResult(QueryBatchRegistAnonymousTbAccountResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBatchRegistAnonymousTbAccountResultWithOptions(request, runtime);
        }

        public async Task<QueryBatchRegistAnonymousTbAccountResultResponse> QueryBatchRegistAnonymousTbAccountResultAsync(QueryBatchRegistAnonymousTbAccountResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBatchRegistAnonymousTbAccountResultWithOptionsAsync(request, runtime);
        }

        public QueryBestSession4ItemsResponse QueryBestSession4ItemsWithOptions(QueryBestSession4ItemsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryBestSession4ItemsShrinkRequest request = new QueryBestSession4ItemsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryBestSession4ItemsResponse>(DoRPCRequest("QueryBestSession4Items", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryBestSession4ItemsResponse> QueryBestSession4ItemsWithOptionsAsync(QueryBestSession4ItemsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryBestSession4ItemsShrinkRequest request = new QueryBestSession4ItemsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryBestSession4ItemsResponse>(await DoRPCRequestAsync("QueryBestSession4Items", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryBestSession4ItemsResponse QueryBestSession4Items(QueryBestSession4ItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBestSession4ItemsWithOptions(request, runtime);
        }

        public async Task<QueryBestSession4ItemsResponse> QueryBestSession4ItemsAsync(QueryBestSession4ItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBestSession4ItemsWithOptionsAsync(request, runtime);
        }

        public QueryBizItemListResponse QueryBizItemListWithOptions(QueryBizItemListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryBizItemListShrinkRequest request = new QueryBizItemListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryBizItemListResponse>(DoRPCRequest("QueryBizItemList", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryBizItemListResponse> QueryBizItemListWithOptionsAsync(QueryBizItemListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryBizItemListShrinkRequest request = new QueryBizItemListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryBizItemListResponse>(await DoRPCRequestAsync("QueryBizItemList", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryBizItemListResponse QueryBizItemList(QueryBizItemListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBizItemListWithOptions(request, runtime);
        }

        public async Task<QueryBizItemListResponse> QueryBizItemListAsync(QueryBizItemListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBizItemListWithOptionsAsync(request, runtime);
        }

        public QueryBizItemsResponse QueryBizItemsWithOptions(QueryBizItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryBizItemsResponse>(DoRPCRequest("QueryBizItems", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryBizItemsResponse> QueryBizItemsWithOptionsAsync(QueryBizItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryBizItemsResponse>(await DoRPCRequestAsync("QueryBizItems", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryBizItemsResponse QueryBizItems(QueryBizItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBizItemsWithOptions(request, runtime);
        }

        public async Task<QueryBizItemsResponse> QueryBizItemsAsync(QueryBizItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBizItemsWithOptionsAsync(request, runtime);
        }

        public QueryBizItemsWithActivityResponse QueryBizItemsWithActivityWithOptions(QueryBizItemsWithActivityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryBizItemsWithActivityShrinkRequest request = new QueryBizItemsWithActivityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<QueryBizItemsWithActivityResponse>(DoRPCRequest("QueryBizItemsWithActivity", "2018-01-16", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<QueryBizItemsWithActivityResponse> QueryBizItemsWithActivityWithOptionsAsync(QueryBizItemsWithActivityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryBizItemsWithActivityShrinkRequest request = new QueryBizItemsWithActivityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<QueryBizItemsWithActivityResponse>(await DoRPCRequestAsync("QueryBizItemsWithActivity", "2018-01-16", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public QueryBizItemsWithActivityResponse QueryBizItemsWithActivity(QueryBizItemsWithActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBizItemsWithActivityWithOptions(request, runtime);
        }

        public async Task<QueryBizItemsWithActivityResponse> QueryBizItemsWithActivityAsync(QueryBizItemsWithActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBizItemsWithActivityWithOptionsAsync(request, runtime);
        }

        public QueryGuideItemGroupResponse QueryGuideItemGroupWithOptions(QueryGuideItemGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryGuideItemGroupResponse>(DoRPCRequest("QueryGuideItemGroup", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryGuideItemGroupResponse> QueryGuideItemGroupWithOptionsAsync(QueryGuideItemGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryGuideItemGroupResponse>(await DoRPCRequestAsync("QueryGuideItemGroup", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryGuideItemGroupResponse QueryGuideItemGroup(QueryGuideItemGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryGuideItemGroupWithOptions(request, runtime);
        }

        public async Task<QueryGuideItemGroupResponse> QueryGuideItemGroupAsync(QueryGuideItemGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryGuideItemGroupWithOptionsAsync(request, runtime);
        }

        public QueryHotMoviesResponse QueryHotMoviesWithOptions(QueryHotMoviesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryHotMoviesResponse>(DoRPCRequest("QueryHotMovies", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryHotMoviesResponse> QueryHotMoviesWithOptionsAsync(QueryHotMoviesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryHotMoviesResponse>(await DoRPCRequestAsync("QueryHotMovies", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryHotMoviesResponse QueryHotMovies(QueryHotMoviesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryHotMoviesWithOptions(request, runtime);
        }

        public async Task<QueryHotMoviesResponse> QueryHotMoviesAsync(QueryHotMoviesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryHotMoviesWithOptionsAsync(request, runtime);
        }

        public QueryItemDetailResponse QueryItemDetailWithOptions(QueryItemDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryItemDetailResponse>(DoRPCRequest("QueryItemDetail", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryItemDetailResponse> QueryItemDetailWithOptionsAsync(QueryItemDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryItemDetailResponse>(await DoRPCRequestAsync("QueryItemDetail", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryItemDetailResponse QueryItemDetail(QueryItemDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryItemDetailWithOptions(request, runtime);
        }

        public async Task<QueryItemDetailResponse> QueryItemDetailAsync(QueryItemDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryItemDetailWithOptionsAsync(request, runtime);
        }

        public QueryItemDetailInnerResponse QueryItemDetailInnerWithOptions(QueryItemDetailInnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryItemDetailInnerResponse>(DoRPCRequest("QueryItemDetailInner", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryItemDetailInnerResponse> QueryItemDetailInnerWithOptionsAsync(QueryItemDetailInnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryItemDetailInnerResponse>(await DoRPCRequestAsync("QueryItemDetailInner", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryItemDetailInnerResponse QueryItemDetailInner(QueryItemDetailInnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryItemDetailInnerWithOptions(request, runtime);
        }

        public async Task<QueryItemDetailInnerResponse> QueryItemDetailInnerAsync(QueryItemDetailInnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryItemDetailInnerWithOptionsAsync(request, runtime);
        }

        public QueryItemInventoryResponse QueryItemInventoryWithOptions(QueryItemInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryItemInventoryResponse>(DoRPCRequest("QueryItemInventory", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryItemInventoryResponse> QueryItemInventoryWithOptionsAsync(QueryItemInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryItemInventoryResponse>(await DoRPCRequestAsync("QueryItemInventory", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryItemInventoryResponse QueryItemInventory(QueryItemInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryItemInventoryWithOptions(request, runtime);
        }

        public async Task<QueryItemInventoryResponse> QueryItemInventoryAsync(QueryItemInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryItemInventoryWithOptionsAsync(request, runtime);
        }

        public QueryLogisticsResponse QueryLogisticsWithOptions(QueryLogisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryLogisticsResponse>(DoRPCRequest("QueryLogistics", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryLogisticsResponse> QueryLogisticsWithOptionsAsync(QueryLogisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryLogisticsResponse>(await DoRPCRequestAsync("QueryLogistics", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryLogisticsResponse QueryLogistics(QueryLogisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryLogisticsWithOptions(request, runtime);
        }

        public async Task<QueryLogisticsResponse> QueryLogisticsAsync(QueryLogisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryLogisticsWithOptionsAsync(request, runtime);
        }

        public QueryMessagesResponse QueryMessagesWithOptions(QueryMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMessagesResponse>(DoRPCRequest("QueryMessages", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMessagesResponse> QueryMessagesWithOptionsAsync(QueryMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMessagesResponse>(await DoRPCRequestAsync("QueryMessages", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMessagesResponse QueryMessages(QueryMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMessagesWithOptions(request, runtime);
        }

        public async Task<QueryMessagesResponse> QueryMessagesAsync(QueryMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMessagesWithOptionsAsync(request, runtime);
        }

        public QueryMovieCommentsResponse QueryMovieCommentsWithOptions(QueryMovieCommentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMovieCommentsResponse>(DoRPCRequest("QueryMovieComments", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMovieCommentsResponse> QueryMovieCommentsWithOptionsAsync(QueryMovieCommentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMovieCommentsResponse>(await DoRPCRequestAsync("QueryMovieComments", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMovieCommentsResponse QueryMovieComments(QueryMovieCommentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMovieCommentsWithOptions(request, runtime);
        }

        public async Task<QueryMovieCommentsResponse> QueryMovieCommentsAsync(QueryMovieCommentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMovieCommentsWithOptionsAsync(request, runtime);
        }

        public QueryMovieSchedulesResponse QueryMovieSchedulesWithOptions(QueryMovieSchedulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMovieSchedulesResponse>(DoRPCRequest("QueryMovieSchedules", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMovieSchedulesResponse> QueryMovieSchedulesWithOptionsAsync(QueryMovieSchedulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMovieSchedulesResponse>(await DoRPCRequestAsync("QueryMovieSchedules", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMovieSchedulesResponse QueryMovieSchedules(QueryMovieSchedulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMovieSchedulesWithOptions(request, runtime);
        }

        public async Task<QueryMovieSchedulesResponse> QueryMovieSchedulesAsync(QueryMovieSchedulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMovieSchedulesWithOptionsAsync(request, runtime);
        }

        public QueryMovieSeatsResponse QueryMovieSeatsWithOptions(QueryMovieSeatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMovieSeatsResponse>(DoRPCRequest("QueryMovieSeats", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMovieSeatsResponse> QueryMovieSeatsWithOptionsAsync(QueryMovieSeatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMovieSeatsResponse>(await DoRPCRequestAsync("QueryMovieSeats", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMovieSeatsResponse QueryMovieSeats(QueryMovieSeatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMovieSeatsWithOptions(request, runtime);
        }

        public async Task<QueryMovieSeatsResponse> QueryMovieSeatsAsync(QueryMovieSeatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMovieSeatsWithOptionsAsync(request, runtime);
        }

        public QueryMovieTicketsResponse QueryMovieTicketsWithOptions(QueryMovieTicketsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<QueryMovieTicketsResponse>(DoRPCRequest("QueryMovieTickets", "2018-01-16", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<QueryMovieTicketsResponse> QueryMovieTicketsWithOptionsAsync(QueryMovieTicketsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<QueryMovieTicketsResponse>(await DoRPCRequestAsync("QueryMovieTickets", "2018-01-16", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public QueryMovieTicketsResponse QueryMovieTickets(QueryMovieTicketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMovieTicketsWithOptions(request, runtime);
        }

        public async Task<QueryMovieTicketsResponse> QueryMovieTicketsAsync(QueryMovieTicketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMovieTicketsWithOptionsAsync(request, runtime);
        }

        public QueryOrderAndPaymentListResponse QueryOrderAndPaymentListWithOptions(QueryOrderAndPaymentListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOrderAndPaymentListResponse>(DoRPCRequest("QueryOrderAndPaymentList", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryOrderAndPaymentListResponse> QueryOrderAndPaymentListWithOptionsAsync(QueryOrderAndPaymentListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOrderAndPaymentListResponse>(await DoRPCRequestAsync("QueryOrderAndPaymentList", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryOrderAndPaymentListResponse QueryOrderAndPaymentList(QueryOrderAndPaymentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOrderAndPaymentListWithOptions(request, runtime);
        }

        public async Task<QueryOrderAndPaymentListResponse> QueryOrderAndPaymentListAsync(QueryOrderAndPaymentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOrderAndPaymentListWithOptionsAsync(request, runtime);
        }

        public QueryOrderCommissionRateResponse QueryOrderCommissionRateWithOptions(QueryOrderCommissionRateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOrderCommissionRateResponse>(DoRPCRequest("QueryOrderCommissionRate", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryOrderCommissionRateResponse> QueryOrderCommissionRateWithOptionsAsync(QueryOrderCommissionRateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOrderCommissionRateResponse>(await DoRPCRequestAsync("QueryOrderCommissionRate", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryOrderCommissionRateResponse QueryOrderCommissionRate(QueryOrderCommissionRateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOrderCommissionRateWithOptions(request, runtime);
        }

        public async Task<QueryOrderCommissionRateResponse> QueryOrderCommissionRateAsync(QueryOrderCommissionRateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOrderCommissionRateWithOptionsAsync(request, runtime);
        }

        public QueryOrderDetailInnerResponse QueryOrderDetailInnerWithOptions(QueryOrderDetailInnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOrderDetailInnerResponse>(DoRPCRequest("QueryOrderDetailInner", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryOrderDetailInnerResponse> QueryOrderDetailInnerWithOptionsAsync(QueryOrderDetailInnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOrderDetailInnerResponse>(await DoRPCRequestAsync("QueryOrderDetailInner", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryOrderDetailInnerResponse QueryOrderDetailInner(QueryOrderDetailInnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOrderDetailInnerWithOptions(request, runtime);
        }

        public async Task<QueryOrderDetailInnerResponse> QueryOrderDetailInnerAsync(QueryOrderDetailInnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOrderDetailInnerWithOptionsAsync(request, runtime);
        }

        public QueryOrderIdByPayIdResponse QueryOrderIdByPayIdWithOptions(QueryOrderIdByPayIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOrderIdByPayIdResponse>(DoRPCRequest("QueryOrderIdByPayId", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryOrderIdByPayIdResponse> QueryOrderIdByPayIdWithOptionsAsync(QueryOrderIdByPayIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOrderIdByPayIdResponse>(await DoRPCRequestAsync("QueryOrderIdByPayId", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryOrderIdByPayIdResponse QueryOrderIdByPayId(QueryOrderIdByPayIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOrderIdByPayIdWithOptions(request, runtime);
        }

        public async Task<QueryOrderIdByPayIdResponse> QueryOrderIdByPayIdAsync(QueryOrderIdByPayIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOrderIdByPayIdWithOptionsAsync(request, runtime);
        }

        public QueryOrderInfoAfterSaleResponse QueryOrderInfoAfterSaleWithOptions(QueryOrderInfoAfterSaleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<QueryOrderInfoAfterSaleResponse>(DoRPCRequest("QueryOrderInfoAfterSale", "2018-01-16", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<QueryOrderInfoAfterSaleResponse> QueryOrderInfoAfterSaleWithOptionsAsync(QueryOrderInfoAfterSaleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<QueryOrderInfoAfterSaleResponse>(await DoRPCRequestAsync("QueryOrderInfoAfterSale", "2018-01-16", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public QueryOrderInfoAfterSaleResponse QueryOrderInfoAfterSale(QueryOrderInfoAfterSaleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOrderInfoAfterSaleWithOptions(request, runtime);
        }

        public async Task<QueryOrderInfoAfterSaleResponse> QueryOrderInfoAfterSaleAsync(QueryOrderInfoAfterSaleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOrderInfoAfterSaleWithOptionsAsync(request, runtime);
        }

        public QueryOrderItemInfoByPaymentIdForAiZhanYouResponse QueryOrderItemInfoByPaymentIdForAiZhanYouWithOptions(QueryOrderItemInfoByPaymentIdForAiZhanYouRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOrderItemInfoByPaymentIdForAiZhanYouResponse>(DoRPCRequest("QueryOrderItemInfoByPaymentIdForAiZhanYou", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryOrderItemInfoByPaymentIdForAiZhanYouResponse> QueryOrderItemInfoByPaymentIdForAiZhanYouWithOptionsAsync(QueryOrderItemInfoByPaymentIdForAiZhanYouRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOrderItemInfoByPaymentIdForAiZhanYouResponse>(await DoRPCRequestAsync("QueryOrderItemInfoByPaymentIdForAiZhanYou", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryOrderItemInfoByPaymentIdForAiZhanYouResponse QueryOrderItemInfoByPaymentIdForAiZhanYou(QueryOrderItemInfoByPaymentIdForAiZhanYouRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOrderItemInfoByPaymentIdForAiZhanYouWithOptions(request, runtime);
        }

        public async Task<QueryOrderItemInfoByPaymentIdForAiZhanYouResponse> QueryOrderItemInfoByPaymentIdForAiZhanYouAsync(QueryOrderItemInfoByPaymentIdForAiZhanYouRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOrderItemInfoByPaymentIdForAiZhanYouWithOptionsAsync(request, runtime);
        }

        public QueryOrderListResponse QueryOrderListWithOptions(QueryOrderListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOrderListResponse>(DoRPCRequest("QueryOrderList", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryOrderListResponse> QueryOrderListWithOptionsAsync(QueryOrderListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOrderListResponse>(await DoRPCRequestAsync("QueryOrderList", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryOrderListResponse QueryOrderList(QueryOrderListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOrderListWithOptions(request, runtime);
        }

        public async Task<QueryOrderListResponse> QueryOrderListAsync(QueryOrderListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOrderListWithOptionsAsync(request, runtime);
        }

        public QueryOrderLogisticsResponse QueryOrderLogisticsWithOptions(QueryOrderLogisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOrderLogisticsResponse>(DoRPCRequest("QueryOrderLogistics", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryOrderLogisticsResponse> QueryOrderLogisticsWithOptionsAsync(QueryOrderLogisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOrderLogisticsResponse>(await DoRPCRequestAsync("QueryOrderLogistics", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryOrderLogisticsResponse QueryOrderLogistics(QueryOrderLogisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOrderLogisticsWithOptions(request, runtime);
        }

        public async Task<QueryOrderLogisticsResponse> QueryOrderLogisticsAsync(QueryOrderLogisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOrderLogisticsWithOptionsAsync(request, runtime);
        }

        public QueryRefundApplicationDetailResponse QueryRefundApplicationDetailWithOptions(QueryRefundApplicationDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRefundApplicationDetailResponse>(DoRPCRequest("QueryRefundApplicationDetail", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryRefundApplicationDetailResponse> QueryRefundApplicationDetailWithOptionsAsync(QueryRefundApplicationDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRefundApplicationDetailResponse>(await DoRPCRequestAsync("QueryRefundApplicationDetail", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryRefundApplicationDetailResponse QueryRefundApplicationDetail(QueryRefundApplicationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRefundApplicationDetailWithOptions(request, runtime);
        }

        public async Task<QueryRefundApplicationDetailResponse> QueryRefundApplicationDetailAsync(QueryRefundApplicationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRefundApplicationDetailWithOptionsAsync(request, runtime);
        }

        public QueryUnfinishedActivitiesResponse QueryUnfinishedActivitiesWithOptions(QueryUnfinishedActivitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryUnfinishedActivitiesResponse>(DoRPCRequest("QueryUnfinishedActivities", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryUnfinishedActivitiesResponse> QueryUnfinishedActivitiesWithOptionsAsync(QueryUnfinishedActivitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryUnfinishedActivitiesResponse>(await DoRPCRequestAsync("QueryUnfinishedActivities", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryUnfinishedActivitiesResponse QueryUnfinishedActivities(QueryUnfinishedActivitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUnfinishedActivitiesWithOptions(request, runtime);
        }

        public async Task<QueryUnfinishedActivitiesResponse> QueryUnfinishedActivitiesAsync(QueryUnfinishedActivitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUnfinishedActivitiesWithOptionsAsync(request, runtime);
        }

        public QueryUnfinishedSessionsResponse QueryUnfinishedSessionsWithOptions(QueryUnfinishedSessionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryUnfinishedSessionsResponse>(DoRPCRequest("QueryUnfinishedSessions", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryUnfinishedSessionsResponse> QueryUnfinishedSessionsWithOptionsAsync(QueryUnfinishedSessionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryUnfinishedSessionsResponse>(await DoRPCRequestAsync("QueryUnfinishedSessions", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryUnfinishedSessionsResponse QueryUnfinishedSessions(QueryUnfinishedSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUnfinishedSessionsWithOptions(request, runtime);
        }

        public async Task<QueryUnfinishedSessionsResponse> QueryUnfinishedSessionsAsync(QueryUnfinishedSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUnfinishedSessionsWithOptionsAsync(request, runtime);
        }

        public QueryUnfinishedSessions4ItemsResponse QueryUnfinishedSessions4ItemsWithOptions(QueryUnfinishedSessions4ItemsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryUnfinishedSessions4ItemsShrinkRequest request = new QueryUnfinishedSessions4ItemsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryUnfinishedSessions4ItemsResponse>(DoRPCRequest("QueryUnfinishedSessions4Items", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryUnfinishedSessions4ItemsResponse> QueryUnfinishedSessions4ItemsWithOptionsAsync(QueryUnfinishedSessions4ItemsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryUnfinishedSessions4ItemsShrinkRequest request = new QueryUnfinishedSessions4ItemsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryUnfinishedSessions4ItemsResponse>(await DoRPCRequestAsync("QueryUnfinishedSessions4Items", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryUnfinishedSessions4ItemsResponse QueryUnfinishedSessions4Items(QueryUnfinishedSessions4ItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUnfinishedSessions4ItemsWithOptions(request, runtime);
        }

        public async Task<QueryUnfinishedSessions4ItemsResponse> QueryUnfinishedSessions4ItemsAsync(QueryUnfinishedSessions4ItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUnfinishedSessions4ItemsWithOptionsAsync(request, runtime);
        }

        public QueryUpcomingMoviesResponse QueryUpcomingMoviesWithOptions(QueryUpcomingMoviesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryUpcomingMoviesShrinkRequest request = new QueryUpcomingMoviesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtJson))
            {
                request.ExtJsonShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtJson, "ExtJson", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryUpcomingMoviesResponse>(DoRPCRequest("QueryUpcomingMovies", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryUpcomingMoviesResponse> QueryUpcomingMoviesWithOptionsAsync(QueryUpcomingMoviesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryUpcomingMoviesShrinkRequest request = new QueryUpcomingMoviesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtJson))
            {
                request.ExtJsonShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtJson, "ExtJson", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryUpcomingMoviesResponse>(await DoRPCRequestAsync("QueryUpcomingMovies", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryUpcomingMoviesResponse QueryUpcomingMovies(QueryUpcomingMoviesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUpcomingMoviesWithOptions(request, runtime);
        }

        public async Task<QueryUpcomingMoviesResponse> QueryUpcomingMoviesAsync(QueryUpcomingMoviesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUpcomingMoviesWithOptionsAsync(request, runtime);
        }

        public QueryWithholdTradeResponse QueryWithholdTradeWithOptions(QueryWithholdTradeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryWithholdTradeResponse>(DoRPCRequest("QueryWithholdTrade", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryWithholdTradeResponse> QueryWithholdTradeWithOptionsAsync(QueryWithholdTradeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryWithholdTradeResponse>(await DoRPCRequestAsync("QueryWithholdTrade", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryWithholdTradeResponse QueryWithholdTrade(QueryWithholdTradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryWithholdTradeWithOptions(request, runtime);
        }

        public async Task<QueryWithholdTradeResponse> QueryWithholdTradeAsync(QueryWithholdTradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryWithholdTradeWithOptionsAsync(request, runtime);
        }

        public RefundOrderResponse RefundOrderWithOptions(RefundOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefundOrderResponse>(DoRPCRequest("RefundOrder", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RefundOrderResponse> RefundOrderWithOptionsAsync(RefundOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefundOrderResponse>(await DoRPCRequestAsync("RefundOrder", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RefundOrderResponse RefundOrder(RefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefundOrderWithOptions(request, runtime);
        }

        public async Task<RefundOrderResponse> RefundOrderAsync(RefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefundOrderWithOptionsAsync(request, runtime);
        }

        public RefundPointResponse RefundPointWithOptions(RefundPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefundPointResponse>(DoRPCRequest("RefundPoint", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RefundPointResponse> RefundPointWithOptionsAsync(RefundPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefundPointResponse>(await DoRPCRequestAsync("RefundPoint", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RefundPointResponse RefundPoint(RefundPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefundPointWithOptions(request, runtime);
        }

        public async Task<RefundPointResponse> RefundPointAsync(RefundPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefundPointWithOptionsAsync(request, runtime);
        }

        public RefuseMerchantSyncTaskResponse RefuseMerchantSyncTaskWithOptions(RefuseMerchantSyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefuseMerchantSyncTaskResponse>(DoRPCRequest("RefuseMerchantSyncTask", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RefuseMerchantSyncTaskResponse> RefuseMerchantSyncTaskWithOptionsAsync(RefuseMerchantSyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefuseMerchantSyncTaskResponse>(await DoRPCRequestAsync("RefuseMerchantSyncTask", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RefuseMerchantSyncTaskResponse RefuseMerchantSyncTask(RefuseMerchantSyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefuseMerchantSyncTaskWithOptions(request, runtime);
        }

        public async Task<RefuseMerchantSyncTaskResponse> RefuseMerchantSyncTaskAsync(RefuseMerchantSyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefuseMerchantSyncTaskWithOptionsAsync(request, runtime);
        }

        public RegistAnonymousTbAccountResponse RegistAnonymousTbAccountWithOptions(RegistAnonymousTbAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegistAnonymousTbAccountResponse>(DoRPCRequest("RegistAnonymousTbAccount", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RegistAnonymousTbAccountResponse> RegistAnonymousTbAccountWithOptionsAsync(RegistAnonymousTbAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegistAnonymousTbAccountResponse>(await DoRPCRequestAsync("RegistAnonymousTbAccount", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RegistAnonymousTbAccountResponse RegistAnonymousTbAccount(RegistAnonymousTbAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegistAnonymousTbAccountWithOptions(request, runtime);
        }

        public async Task<RegistAnonymousTbAccountResponse> RegistAnonymousTbAccountAsync(RegistAnonymousTbAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegistAnonymousTbAccountWithOptionsAsync(request, runtime);
        }

        public ReleaseMovieSeatResponse ReleaseMovieSeatWithOptions(ReleaseMovieSeatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseMovieSeatResponse>(DoRPCRequest("ReleaseMovieSeat", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseMovieSeatResponse> ReleaseMovieSeatWithOptionsAsync(ReleaseMovieSeatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseMovieSeatResponse>(await DoRPCRequestAsync("ReleaseMovieSeat", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleaseMovieSeatResponse ReleaseMovieSeat(ReleaseMovieSeatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseMovieSeatWithOptions(request, runtime);
        }

        public async Task<ReleaseMovieSeatResponse> ReleaseMovieSeatAsync(ReleaseMovieSeatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseMovieSeatWithOptionsAsync(request, runtime);
        }

        public RemoveAddressResponse RemoveAddressWithOptions(RemoveAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveAddressResponse>(DoRPCRequest("RemoveAddress", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveAddressResponse> RemoveAddressWithOptionsAsync(RemoveAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveAddressResponse>(await DoRPCRequestAsync("RemoveAddress", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveAddressResponse RemoveAddress(RemoveAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveAddressWithOptions(request, runtime);
        }

        public async Task<RemoveAddressResponse> RemoveAddressAsync(RemoveAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveAddressWithOptionsAsync(request, runtime);
        }

        public RemoveMessagesResponse RemoveMessagesWithOptions(RemoveMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveMessagesResponse>(DoRPCRequest("RemoveMessages", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveMessagesResponse> RemoveMessagesWithOptionsAsync(RemoveMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveMessagesResponse>(await DoRPCRequestAsync("RemoveMessages", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveMessagesResponse RemoveMessages(RemoveMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveMessagesWithOptions(request, runtime);
        }

        public async Task<RemoveMessagesResponse> RemoveMessagesAsync(RemoveMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveMessagesWithOptionsAsync(request, runtime);
        }

        public RenderH5OrderResponse RenderH5OrderWithOptions(RenderH5OrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenderH5OrderResponse>(DoRPCRequest("RenderH5Order", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenderH5OrderResponse> RenderH5OrderWithOptionsAsync(RenderH5OrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenderH5OrderResponse>(await DoRPCRequestAsync("RenderH5Order", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RenderH5OrderResponse RenderH5Order(RenderH5OrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenderH5OrderWithOptions(request, runtime);
        }

        public async Task<RenderH5OrderResponse> RenderH5OrderAsync(RenderH5OrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenderH5OrderWithOptionsAsync(request, runtime);
        }

        public RenderOrderResponse RenderOrderWithOptions(RenderOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenderOrderResponse>(DoRPCRequest("RenderOrder", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenderOrderResponse> RenderOrderWithOptionsAsync(RenderOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenderOrderResponse>(await DoRPCRequestAsync("RenderOrder", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RenderOrderResponse RenderOrder(RenderOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenderOrderWithOptions(request, runtime);
        }

        public async Task<RenderOrderResponse> RenderOrderAsync(RenderOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenderOrderWithOptionsAsync(request, runtime);
        }

        public RepayForPayUrlResponse RepayForPayUrlWithOptions(RepayForPayUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RepayForPayUrlResponse>(DoRPCRequest("RepayForPayUrl", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RepayForPayUrlResponse> RepayForPayUrlWithOptionsAsync(RepayForPayUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RepayForPayUrlResponse>(await DoRPCRequestAsync("RepayForPayUrl", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RepayForPayUrlResponse RepayForPayUrl(RepayForPayUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RepayForPayUrlWithOptions(request, runtime);
        }

        public async Task<RepayForPayUrlResponse> RepayForPayUrlAsync(RepayForPayUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RepayForPayUrlWithOptionsAsync(request, runtime);
        }

        public RepayOrderResponse RepayOrderWithOptions(RepayOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RepayOrderResponse>(DoRPCRequest("RepayOrder", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RepayOrderResponse> RepayOrderWithOptionsAsync(RepayOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RepayOrderResponse>(await DoRPCRequestAsync("RepayOrder", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RepayOrderResponse RepayOrder(RepayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RepayOrderWithOptions(request, runtime);
        }

        public async Task<RepayOrderResponse> RepayOrderAsync(RepayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RepayOrderWithOptionsAsync(request, runtime);
        }

        public ReserveMovieSeatResponse ReserveMovieSeatWithOptions(ReserveMovieSeatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReserveMovieSeatResponse>(DoRPCRequest("ReserveMovieSeat", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReserveMovieSeatResponse> ReserveMovieSeatWithOptionsAsync(ReserveMovieSeatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReserveMovieSeatResponse>(await DoRPCRequestAsync("ReserveMovieSeat", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReserveMovieSeatResponse ReserveMovieSeat(ReserveMovieSeatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReserveMovieSeatWithOptions(request, runtime);
        }

        public async Task<ReserveMovieSeatResponse> ReserveMovieSeatAsync(ReserveMovieSeatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReserveMovieSeatWithOptionsAsync(request, runtime);
        }

        public SettleOrderResponse SettleOrderWithOptions(SettleOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SettleOrderResponse>(DoRPCRequest("SettleOrder", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SettleOrderResponse> SettleOrderWithOptionsAsync(SettleOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SettleOrderResponse>(await DoRPCRequestAsync("SettleOrder", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SettleOrderResponse SettleOrder(SettleOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SettleOrderWithOptions(request, runtime);
        }

        public async Task<SettleOrderResponse> SettleOrderAsync(SettleOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SettleOrderWithOptionsAsync(request, runtime);
        }

        public SubmitReturnGoodLogisticsResponse SubmitReturnGoodLogisticsWithOptions(SubmitReturnGoodLogisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitReturnGoodLogisticsResponse>(DoRPCRequest("SubmitReturnGoodLogistics", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitReturnGoodLogisticsResponse> SubmitReturnGoodLogisticsWithOptionsAsync(SubmitReturnGoodLogisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitReturnGoodLogisticsResponse>(await DoRPCRequestAsync("SubmitReturnGoodLogistics", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitReturnGoodLogisticsResponse SubmitReturnGoodLogistics(SubmitReturnGoodLogisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitReturnGoodLogisticsWithOptions(request, runtime);
        }

        public async Task<SubmitReturnGoodLogisticsResponse> SubmitReturnGoodLogisticsAsync(SubmitReturnGoodLogisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitReturnGoodLogisticsWithOptionsAsync(request, runtime);
        }

        public SyncMerchantInfoResponse SyncMerchantInfoWithOptions(SyncMerchantInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SyncMerchantInfoResponse>(DoRPCRequest("SyncMerchantInfo", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SyncMerchantInfoResponse> SyncMerchantInfoWithOptionsAsync(SyncMerchantInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SyncMerchantInfoResponse>(await DoRPCRequestAsync("SyncMerchantInfo", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SyncMerchantInfoResponse SyncMerchantInfo(SyncMerchantInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncMerchantInfoWithOptions(request, runtime);
        }

        public async Task<SyncMerchantInfoResponse> SyncMerchantInfoAsync(SyncMerchantInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncMerchantInfoWithOptionsAsync(request, runtime);
        }

        public UnsignWithholdAgreementResponse UnsignWithholdAgreementWithOptions(UnsignWithholdAgreementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnsignWithholdAgreementResponse>(DoRPCRequest("UnsignWithholdAgreement", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnsignWithholdAgreementResponse> UnsignWithholdAgreementWithOptionsAsync(UnsignWithholdAgreementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnsignWithholdAgreementResponse>(await DoRPCRequestAsync("UnsignWithholdAgreement", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnsignWithholdAgreementResponse UnsignWithholdAgreement(UnsignWithholdAgreementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnsignWithholdAgreementWithOptions(request, runtime);
        }

        public async Task<UnsignWithholdAgreementResponse> UnsignWithholdAgreementAsync(UnsignWithholdAgreementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnsignWithholdAgreementWithOptionsAsync(request, runtime);
        }

        public UpdateAddressResponse UpdateAddressWithOptions(UpdateAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAddressResponse>(DoRPCRequest("UpdateAddress", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAddressResponse> UpdateAddressWithOptionsAsync(UpdateAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAddressResponse>(await DoRPCRequestAsync("UpdateAddress", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAddressResponse UpdateAddress(UpdateAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAddressWithOptions(request, runtime);
        }

        public async Task<UpdateAddressResponse> UpdateAddressAsync(UpdateAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAddressWithOptionsAsync(request, runtime);
        }

        public ValidateTaobaoAccountResponse ValidateTaobaoAccountWithOptions(ValidateTaobaoAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ValidateTaobaoAccountResponse>(DoRPCRequest("ValidateTaobaoAccount", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ValidateTaobaoAccountResponse> ValidateTaobaoAccountWithOptionsAsync(ValidateTaobaoAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ValidateTaobaoAccountResponse>(await DoRPCRequestAsync("ValidateTaobaoAccount", "2018-01-16", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ValidateTaobaoAccountResponse ValidateTaobaoAccount(ValidateTaobaoAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidateTaobaoAccountWithOptions(request, runtime);
        }

        public async Task<ValidateTaobaoAccountResponse> ValidateTaobaoAccountAsync(ValidateTaobaoAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidateTaobaoAccountWithOptionsAsync(request, runtime);
        }

    }
}
