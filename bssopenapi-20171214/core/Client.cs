// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.BssOpenApi20171214.Models;

namespace AlibabaCloud.SDK.BssOpenApi20171214
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "business.ap-southeast-1.aliyuncs.com"},
                {"ap-northeast-2-pop", "business.ap-southeast-1.aliyuncs.com"},
                {"ap-south-1", "business.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-1", "business.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "business.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-3", "business.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "business.ap-southeast-1.aliyuncs.com"},
                {"cn-beijing", "business.aliyuncs.com"},
                {"cn-beijing-finance-1", "business.aliyuncs.com"},
                {"cn-beijing-finance-pop", "business.aliyuncs.com"},
                {"cn-beijing-gov-1", "business.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "business.aliyuncs.com"},
                {"cn-chengdu", "business.aliyuncs.com"},
                {"cn-edge-1", "business.aliyuncs.com"},
                {"cn-fujian", "business.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "business.aliyuncs.com"},
                {"cn-hangzhou", "business.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "business.aliyuncs.com"},
                {"cn-hangzhou-finance", "business.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "business.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "business.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "business.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "business.aliyuncs.com"},
                {"cn-hangzhou-test-306", "business.aliyuncs.com"},
                {"cn-hongkong", "business.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "business.aliyuncs.com"},
                {"cn-huhehaote", "business.aliyuncs.com"},
                {"cn-north-2-gov-1", "business.aliyuncs.com"},
                {"cn-qingdao", "business.aliyuncs.com"},
                {"cn-qingdao-nebula", "business.aliyuncs.com"},
                {"cn-shanghai", "business.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "business.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "business.aliyuncs.com"},
                {"cn-shanghai-finance-1", "business.aliyuncs.com"},
                {"cn-shanghai-inner", "business.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "business.aliyuncs.com"},
                {"cn-shenzhen", "business.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "business.aliyuncs.com"},
                {"cn-shenzhen-inner", "business.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "business.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "business.aliyuncs.com"},
                {"cn-wuhan", "business.aliyuncs.com"},
                {"cn-yushanfang", "business.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "business.aliyuncs.com"},
                {"cn-zhangjiakou", "business.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "business.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "business.aliyuncs.com"},
                {"eu-central-1", "business.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1", "business.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1-oxs", "business.ap-southeast-1.aliyuncs.com"},
                {"me-east-1", "business.ap-southeast-1.aliyuncs.com"},
                {"rus-west-1-pop", "business.ap-southeast-1.aliyuncs.com"},
                {"us-east-1", "business.ap-southeast-1.aliyuncs.com"},
                {"us-west-1", "business.ap-southeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("bssopenapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AllocateCostUnitResourceResponse AllocateCostUnitResourceWithOptions(AllocateCostUnitResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateCostUnitResourceResponse>(DoRPCRequest("AllocateCostUnitResource", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AllocateCostUnitResourceResponse> AllocateCostUnitResourceWithOptionsAsync(AllocateCostUnitResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateCostUnitResourceResponse>(await DoRPCRequestAsync("AllocateCostUnitResource", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AllocateCostUnitResourceResponse AllocateCostUnitResource(AllocateCostUnitResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateCostUnitResourceWithOptions(request, runtime);
        }

        public async Task<AllocateCostUnitResourceResponse> AllocateCostUnitResourceAsync(AllocateCostUnitResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateCostUnitResourceWithOptionsAsync(request, runtime);
        }

        public ApplyInvoiceResponse ApplyInvoiceWithOptions(ApplyInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplyInvoiceResponse>(DoRPCRequest("ApplyInvoice", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ApplyInvoiceResponse> ApplyInvoiceWithOptionsAsync(ApplyInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplyInvoiceResponse>(await DoRPCRequestAsync("ApplyInvoice", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ApplyInvoiceResponse ApplyInvoice(ApplyInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyInvoiceWithOptions(request, runtime);
        }

        public async Task<ApplyInvoiceResponse> ApplyInvoiceAsync(ApplyInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyInvoiceWithOptionsAsync(request, runtime);
        }

        public CancelOrderResponse CancelOrderWithOptions(CancelOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelOrderResponse>(DoRPCRequest("CancelOrder", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelOrderResponse> CancelOrderWithOptionsAsync(CancelOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelOrderResponse>(await DoRPCRequestAsync("CancelOrder", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ChangeResellerConsumeAmountResponse ChangeResellerConsumeAmountWithOptions(ChangeResellerConsumeAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeResellerConsumeAmountResponse>(DoRPCRequest("ChangeResellerConsumeAmount", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ChangeResellerConsumeAmountResponse> ChangeResellerConsumeAmountWithOptionsAsync(ChangeResellerConsumeAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeResellerConsumeAmountResponse>(await DoRPCRequestAsync("ChangeResellerConsumeAmount", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ChangeResellerConsumeAmountResponse ChangeResellerConsumeAmount(ChangeResellerConsumeAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResellerConsumeAmountWithOptions(request, runtime);
        }

        public async Task<ChangeResellerConsumeAmountResponse> ChangeResellerConsumeAmountAsync(ChangeResellerConsumeAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResellerConsumeAmountWithOptionsAsync(request, runtime);
        }

        public ConvertChargeTypeResponse ConvertChargeTypeWithOptions(ConvertChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConvertChargeTypeResponse>(DoRPCRequest("ConvertChargeType", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConvertChargeTypeResponse> ConvertChargeTypeWithOptionsAsync(ConvertChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConvertChargeTypeResponse>(await DoRPCRequestAsync("ConvertChargeType", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConvertChargeTypeResponse ConvertChargeType(ConvertChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConvertChargeTypeWithOptions(request, runtime);
        }

        public async Task<ConvertChargeTypeResponse> ConvertChargeTypeAsync(ConvertChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConvertChargeTypeWithOptionsAsync(request, runtime);
        }

        public CreateAgAccountResponse CreateAgAccountWithOptions(CreateAgAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAgAccountResponse>(DoRPCRequest("CreateAgAccount", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAgAccountResponse> CreateAgAccountWithOptionsAsync(CreateAgAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAgAccountResponse>(await DoRPCRequestAsync("CreateAgAccount", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAgAccountResponse CreateAgAccount(CreateAgAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAgAccountWithOptions(request, runtime);
        }

        public async Task<CreateAgAccountResponse> CreateAgAccountAsync(CreateAgAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAgAccountWithOptionsAsync(request, runtime);
        }

        public CreateCostUnitResponse CreateCostUnitWithOptions(CreateCostUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCostUnitResponse>(DoRPCRequest("CreateCostUnit", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCostUnitResponse> CreateCostUnitWithOptionsAsync(CreateCostUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCostUnitResponse>(await DoRPCRequestAsync("CreateCostUnit", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCostUnitResponse CreateCostUnit(CreateCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCostUnitWithOptions(request, runtime);
        }

        public async Task<CreateCostUnitResponse> CreateCostUnitAsync(CreateCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCostUnitWithOptionsAsync(request, runtime);
        }

        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceResponse>(DoRPCRequest("CreateInstance", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await DoRPCRequestAsync("CreateInstance", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        public CreateResellerUserQuotaResponse CreateResellerUserQuotaWithOptions(CreateResellerUserQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateResellerUserQuotaResponse>(DoRPCRequest("CreateResellerUserQuota", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateResellerUserQuotaResponse> CreateResellerUserQuotaWithOptionsAsync(CreateResellerUserQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateResellerUserQuotaResponse>(await DoRPCRequestAsync("CreateResellerUserQuota", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateResellerUserQuotaResponse CreateResellerUserQuota(CreateResellerUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateResellerUserQuotaWithOptions(request, runtime);
        }

        public async Task<CreateResellerUserQuotaResponse> CreateResellerUserQuotaAsync(CreateResellerUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateResellerUserQuotaWithOptionsAsync(request, runtime);
        }

        public CreateResourcePackageResponse CreateResourcePackageWithOptions(CreateResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateResourcePackageResponse>(DoRPCRequest("CreateResourcePackage", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateResourcePackageResponse> CreateResourcePackageWithOptionsAsync(CreateResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateResourcePackageResponse>(await DoRPCRequestAsync("CreateResourcePackage", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateResourcePackageResponse CreateResourcePackage(CreateResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateResourcePackageWithOptions(request, runtime);
        }

        public async Task<CreateResourcePackageResponse> CreateResourcePackageAsync(CreateResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateResourcePackageWithOptionsAsync(request, runtime);
        }

        public DeleteCostUnitResponse DeleteCostUnitWithOptions(DeleteCostUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCostUnitResponse>(DoRPCRequest("DeleteCostUnit", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCostUnitResponse> DeleteCostUnitWithOptionsAsync(DeleteCostUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCostUnitResponse>(await DoRPCRequestAsync("DeleteCostUnit", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCostUnitResponse DeleteCostUnit(DeleteCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCostUnitWithOptions(request, runtime);
        }

        public async Task<DeleteCostUnitResponse> DeleteCostUnitAsync(DeleteCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCostUnitWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceBillResponse DescribeInstanceBillWithOptions(DescribeInstanceBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceBillResponse>(DoRPCRequest("DescribeInstanceBill", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceBillResponse> DescribeInstanceBillWithOptionsAsync(DescribeInstanceBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceBillResponse>(await DoRPCRequestAsync("DescribeInstanceBill", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceBillResponse DescribeInstanceBill(DescribeInstanceBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceBillWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceBillResponse> DescribeInstanceBillAsync(DescribeInstanceBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceBillWithOptionsAsync(request, runtime);
        }

        public DescribeResourcePackageProductResponse DescribeResourcePackageProductWithOptions(DescribeResourcePackageProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeResourcePackageProductResponse>(DoRPCRequest("DescribeResourcePackageProduct", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeResourcePackageProductResponse> DescribeResourcePackageProductWithOptionsAsync(DescribeResourcePackageProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeResourcePackageProductResponse>(await DoRPCRequestAsync("DescribeResourcePackageProduct", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeResourcePackageProductResponse DescribeResourcePackageProduct(DescribeResourcePackageProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourcePackageProductWithOptions(request, runtime);
        }

        public async Task<DescribeResourcePackageProductResponse> DescribeResourcePackageProductAsync(DescribeResourcePackageProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourcePackageProductWithOptionsAsync(request, runtime);
        }

        public DescribeSplitItemBillResponse DescribeSplitItemBillWithOptions(DescribeSplitItemBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSplitItemBillResponse>(DoRPCRequest("DescribeSplitItemBill", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSplitItemBillResponse> DescribeSplitItemBillWithOptionsAsync(DescribeSplitItemBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSplitItemBillResponse>(await DoRPCRequestAsync("DescribeSplitItemBill", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSplitItemBillResponse DescribeSplitItemBill(DescribeSplitItemBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSplitItemBillWithOptions(request, runtime);
        }

        public async Task<DescribeSplitItemBillResponse> DescribeSplitItemBillAsync(DescribeSplitItemBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSplitItemBillWithOptionsAsync(request, runtime);
        }

        public EnableBillGenerationResponse EnableBillGenerationWithOptions(EnableBillGenerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableBillGenerationResponse>(DoRPCRequest("EnableBillGeneration", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableBillGenerationResponse> EnableBillGenerationWithOptionsAsync(EnableBillGenerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableBillGenerationResponse>(await DoRPCRequestAsync("EnableBillGeneration", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableBillGenerationResponse EnableBillGeneration(EnableBillGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableBillGenerationWithOptions(request, runtime);
        }

        public async Task<EnableBillGenerationResponse> EnableBillGenerationAsync(EnableBillGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableBillGenerationWithOptionsAsync(request, runtime);
        }

        public GetCustomerAccountInfoResponse GetCustomerAccountInfoWithOptions(GetCustomerAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCustomerAccountInfoResponse>(DoRPCRequest("GetCustomerAccountInfo", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetCustomerAccountInfoResponse> GetCustomerAccountInfoWithOptionsAsync(GetCustomerAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCustomerAccountInfoResponse>(await DoRPCRequestAsync("GetCustomerAccountInfo", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetCustomerAccountInfoResponse GetCustomerAccountInfo(GetCustomerAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomerAccountInfoWithOptions(request, runtime);
        }

        public async Task<GetCustomerAccountInfoResponse> GetCustomerAccountInfoAsync(GetCustomerAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomerAccountInfoWithOptionsAsync(request, runtime);
        }

        public GetCustomerListResponse GetCustomerListWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetCustomerListResponse>(DoRPCRequest("GetCustomerList", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetCustomerListResponse> GetCustomerListWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetCustomerListResponse>(await DoRPCRequestAsync("GetCustomerList", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetCustomerListResponse GetCustomerList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomerListWithOptions(runtime);
        }

        public async Task<GetCustomerListResponse> GetCustomerListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomerListWithOptionsAsync(runtime);
        }

        public GetOrderDetailResponse GetOrderDetailWithOptions(GetOrderDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOrderDetailResponse>(DoRPCRequest("GetOrderDetail", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetOrderDetailResponse> GetOrderDetailWithOptionsAsync(GetOrderDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOrderDetailResponse>(await DoRPCRequestAsync("GetOrderDetail", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetOrderDetailResponse GetOrderDetail(GetOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOrderDetailWithOptions(request, runtime);
        }

        public async Task<GetOrderDetailResponse> GetOrderDetailAsync(GetOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOrderDetailWithOptionsAsync(request, runtime);
        }

        public GetPayAsYouGoPriceResponse GetPayAsYouGoPriceWithOptions(GetPayAsYouGoPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPayAsYouGoPriceResponse>(DoRPCRequest("GetPayAsYouGoPrice", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPayAsYouGoPriceResponse> GetPayAsYouGoPriceWithOptionsAsync(GetPayAsYouGoPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPayAsYouGoPriceResponse>(await DoRPCRequestAsync("GetPayAsYouGoPrice", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPayAsYouGoPriceResponse GetPayAsYouGoPrice(GetPayAsYouGoPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPayAsYouGoPriceWithOptions(request, runtime);
        }

        public async Task<GetPayAsYouGoPriceResponse> GetPayAsYouGoPriceAsync(GetPayAsYouGoPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPayAsYouGoPriceWithOptionsAsync(request, runtime);
        }

        public GetResourcePackagePriceResponse GetResourcePackagePriceWithOptions(GetResourcePackagePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetResourcePackagePriceResponse>(DoRPCRequest("GetResourcePackagePrice", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetResourcePackagePriceResponse> GetResourcePackagePriceWithOptionsAsync(GetResourcePackagePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetResourcePackagePriceResponse>(await DoRPCRequestAsync("GetResourcePackagePrice", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetResourcePackagePriceResponse GetResourcePackagePrice(GetResourcePackagePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourcePackagePriceWithOptions(request, runtime);
        }

        public async Task<GetResourcePackagePriceResponse> GetResourcePackagePriceAsync(GetResourcePackagePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourcePackagePriceWithOptionsAsync(request, runtime);
        }

        public GetSubscriptionPriceResponse GetSubscriptionPriceWithOptions(GetSubscriptionPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSubscriptionPriceResponse>(DoRPCRequest("GetSubscriptionPrice", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSubscriptionPriceResponse> GetSubscriptionPriceWithOptionsAsync(GetSubscriptionPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSubscriptionPriceResponse>(await DoRPCRequestAsync("GetSubscriptionPrice", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSubscriptionPriceResponse GetSubscriptionPrice(GetSubscriptionPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSubscriptionPriceWithOptions(request, runtime);
        }

        public async Task<GetSubscriptionPriceResponse> GetSubscriptionPriceAsync(GetSubscriptionPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSubscriptionPriceWithOptionsAsync(request, runtime);
        }

        public ModifyCostUnitResponse ModifyCostUnitWithOptions(ModifyCostUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCostUnitResponse>(DoRPCRequest("ModifyCostUnit", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCostUnitResponse> ModifyCostUnitWithOptionsAsync(ModifyCostUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCostUnitResponse>(await DoRPCRequestAsync("ModifyCostUnit", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCostUnitResponse ModifyCostUnit(ModifyCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCostUnitWithOptions(request, runtime);
        }

        public async Task<ModifyCostUnitResponse> ModifyCostUnitAsync(ModifyCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCostUnitWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceResponse ModifyInstanceWithOptions(ModifyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceResponse>(DoRPCRequest("ModifyInstance", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceResponse> ModifyInstanceWithOptionsAsync(ModifyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceResponse>(await DoRPCRequestAsync("ModifyInstance", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceResponse ModifyInstance(ModifyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceResponse> ModifyInstanceAsync(ModifyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceWithOptionsAsync(request, runtime);
        }

        public QueryAccountBalanceResponse QueryAccountBalanceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<QueryAccountBalanceResponse>(DoRPCRequest("QueryAccountBalance", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAccountBalanceResponse> QueryAccountBalanceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<QueryAccountBalanceResponse>(await DoRPCRequestAsync("QueryAccountBalance", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAccountBalanceResponse QueryAccountBalance()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountBalanceWithOptions(runtime);
        }

        public async Task<QueryAccountBalanceResponse> QueryAccountBalanceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountBalanceWithOptionsAsync(runtime);
        }

        public QueryAccountBillResponse QueryAccountBillWithOptions(QueryAccountBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAccountBillResponse>(DoRPCRequest("QueryAccountBill", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAccountBillResponse> QueryAccountBillWithOptionsAsync(QueryAccountBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAccountBillResponse>(await DoRPCRequestAsync("QueryAccountBill", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAccountBillResponse QueryAccountBill(QueryAccountBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountBillWithOptions(request, runtime);
        }

        public async Task<QueryAccountBillResponse> QueryAccountBillAsync(QueryAccountBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountBillWithOptionsAsync(request, runtime);
        }

        public QueryAccountTransactionDetailsResponse QueryAccountTransactionDetailsWithOptions(QueryAccountTransactionDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAccountTransactionDetailsResponse>(DoRPCRequest("QueryAccountTransactionDetails", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAccountTransactionDetailsResponse> QueryAccountTransactionDetailsWithOptionsAsync(QueryAccountTransactionDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAccountTransactionDetailsResponse>(await DoRPCRequestAsync("QueryAccountTransactionDetails", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAccountTransactionDetailsResponse QueryAccountTransactionDetails(QueryAccountTransactionDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountTransactionDetailsWithOptions(request, runtime);
        }

        public async Task<QueryAccountTransactionDetailsResponse> QueryAccountTransactionDetailsAsync(QueryAccountTransactionDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountTransactionDetailsWithOptionsAsync(request, runtime);
        }

        public QueryAccountTransactionsResponse QueryAccountTransactionsWithOptions(QueryAccountTransactionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAccountTransactionsResponse>(DoRPCRequest("QueryAccountTransactions", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAccountTransactionsResponse> QueryAccountTransactionsWithOptionsAsync(QueryAccountTransactionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAccountTransactionsResponse>(await DoRPCRequestAsync("QueryAccountTransactions", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAccountTransactionsResponse QueryAccountTransactions(QueryAccountTransactionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountTransactionsWithOptions(request, runtime);
        }

        public async Task<QueryAccountTransactionsResponse> QueryAccountTransactionsAsync(QueryAccountTransactionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountTransactionsWithOptionsAsync(request, runtime);
        }

        public QueryAvailableInstancesResponse QueryAvailableInstancesWithOptions(QueryAvailableInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAvailableInstancesResponse>(DoRPCRequest("QueryAvailableInstances", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAvailableInstancesResponse> QueryAvailableInstancesWithOptionsAsync(QueryAvailableInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAvailableInstancesResponse>(await DoRPCRequestAsync("QueryAvailableInstances", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAvailableInstancesResponse QueryAvailableInstances(QueryAvailableInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAvailableInstancesWithOptions(request, runtime);
        }

        public async Task<QueryAvailableInstancesResponse> QueryAvailableInstancesAsync(QueryAvailableInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAvailableInstancesWithOptionsAsync(request, runtime);
        }

        public QueryBillResponse QueryBillWithOptions(QueryBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryBillResponse>(DoRPCRequest("QueryBill", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryBillResponse> QueryBillWithOptionsAsync(QueryBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryBillResponse>(await DoRPCRequestAsync("QueryBill", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryBillResponse QueryBill(QueryBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBillWithOptions(request, runtime);
        }

        public async Task<QueryBillResponse> QueryBillAsync(QueryBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBillWithOptionsAsync(request, runtime);
        }

        public QueryBillOverviewResponse QueryBillOverviewWithOptions(QueryBillOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryBillOverviewResponse>(DoRPCRequest("QueryBillOverview", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryBillOverviewResponse> QueryBillOverviewWithOptionsAsync(QueryBillOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryBillOverviewResponse>(await DoRPCRequestAsync("QueryBillOverview", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryBillOverviewResponse QueryBillOverview(QueryBillOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBillOverviewWithOptions(request, runtime);
        }

        public async Task<QueryBillOverviewResponse> QueryBillOverviewAsync(QueryBillOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBillOverviewWithOptionsAsync(request, runtime);
        }

        public QueryBillToOSSSubscriptionResponse QueryBillToOSSSubscriptionWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<QueryBillToOSSSubscriptionResponse>(DoRPCRequest("QueryBillToOSSSubscription", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryBillToOSSSubscriptionResponse> QueryBillToOSSSubscriptionWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<QueryBillToOSSSubscriptionResponse>(await DoRPCRequestAsync("QueryBillToOSSSubscription", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryBillToOSSSubscriptionResponse QueryBillToOSSSubscription()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBillToOSSSubscriptionWithOptions(runtime);
        }

        public async Task<QueryBillToOSSSubscriptionResponse> QueryBillToOSSSubscriptionAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBillToOSSSubscriptionWithOptionsAsync(runtime);
        }

        public QueryCashCouponsResponse QueryCashCouponsWithOptions(QueryCashCouponsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCashCouponsResponse>(DoRPCRequest("QueryCashCoupons", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCashCouponsResponse> QueryCashCouponsWithOptionsAsync(QueryCashCouponsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCashCouponsResponse>(await DoRPCRequestAsync("QueryCashCoupons", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCashCouponsResponse QueryCashCoupons(QueryCashCouponsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCashCouponsWithOptions(request, runtime);
        }

        public async Task<QueryCashCouponsResponse> QueryCashCouponsAsync(QueryCashCouponsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCashCouponsWithOptionsAsync(request, runtime);
        }

        public QueryCostUnitResponse QueryCostUnitWithOptions(QueryCostUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCostUnitResponse>(DoRPCRequest("QueryCostUnit", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCostUnitResponse> QueryCostUnitWithOptionsAsync(QueryCostUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCostUnitResponse>(await DoRPCRequestAsync("QueryCostUnit", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCostUnitResponse QueryCostUnit(QueryCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCostUnitWithOptions(request, runtime);
        }

        public async Task<QueryCostUnitResponse> QueryCostUnitAsync(QueryCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCostUnitWithOptionsAsync(request, runtime);
        }

        public QueryCostUnitResourceResponse QueryCostUnitResourceWithOptions(QueryCostUnitResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCostUnitResourceResponse>(DoRPCRequest("QueryCostUnitResource", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCostUnitResourceResponse> QueryCostUnitResourceWithOptionsAsync(QueryCostUnitResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCostUnitResourceResponse>(await DoRPCRequestAsync("QueryCostUnitResource", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCostUnitResourceResponse QueryCostUnitResource(QueryCostUnitResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCostUnitResourceWithOptions(request, runtime);
        }

        public async Task<QueryCostUnitResourceResponse> QueryCostUnitResourceAsync(QueryCostUnitResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCostUnitResourceWithOptionsAsync(request, runtime);
        }

        public QueryCustomerAddressListResponse QueryCustomerAddressListWithOptions(QueryCustomerAddressListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCustomerAddressListResponse>(DoRPCRequest("QueryCustomerAddressList", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCustomerAddressListResponse> QueryCustomerAddressListWithOptionsAsync(QueryCustomerAddressListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCustomerAddressListResponse>(await DoRPCRequestAsync("QueryCustomerAddressList", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCustomerAddressListResponse QueryCustomerAddressList(QueryCustomerAddressListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCustomerAddressListWithOptions(request, runtime);
        }

        public async Task<QueryCustomerAddressListResponse> QueryCustomerAddressListAsync(QueryCustomerAddressListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCustomerAddressListWithOptionsAsync(request, runtime);
        }

        public QueryEvaluateListResponse QueryEvaluateListWithOptions(QueryEvaluateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryEvaluateListResponse>(DoRPCRequest("QueryEvaluateList", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryEvaluateListResponse> QueryEvaluateListWithOptionsAsync(QueryEvaluateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryEvaluateListResponse>(await DoRPCRequestAsync("QueryEvaluateList", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryEvaluateListResponse QueryEvaluateList(QueryEvaluateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEvaluateListWithOptions(request, runtime);
        }

        public async Task<QueryEvaluateListResponse> QueryEvaluateListAsync(QueryEvaluateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEvaluateListWithOptionsAsync(request, runtime);
        }

        public QueryFinancialAccountInfoResponse QueryFinancialAccountInfoWithOptions(QueryFinancialAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFinancialAccountInfoResponse>(DoRPCRequest("QueryFinancialAccountInfo", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryFinancialAccountInfoResponse> QueryFinancialAccountInfoWithOptionsAsync(QueryFinancialAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFinancialAccountInfoResponse>(await DoRPCRequestAsync("QueryFinancialAccountInfo", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryFinancialAccountInfoResponse QueryFinancialAccountInfo(QueryFinancialAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFinancialAccountInfoWithOptions(request, runtime);
        }

        public async Task<QueryFinancialAccountInfoResponse> QueryFinancialAccountInfoAsync(QueryFinancialAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFinancialAccountInfoWithOptionsAsync(request, runtime);
        }

        public QueryInstanceBillResponse QueryInstanceBillWithOptions(QueryInstanceBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryInstanceBillResponse>(DoRPCRequest("QueryInstanceBill", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryInstanceBillResponse> QueryInstanceBillWithOptionsAsync(QueryInstanceBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryInstanceBillResponse>(await DoRPCRequestAsync("QueryInstanceBill", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryInstanceBillResponse QueryInstanceBill(QueryInstanceBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInstanceBillWithOptions(request, runtime);
        }

        public async Task<QueryInstanceBillResponse> QueryInstanceBillAsync(QueryInstanceBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInstanceBillWithOptionsAsync(request, runtime);
        }

        public QueryInstanceByTagResponse QueryInstanceByTagWithOptions(QueryInstanceByTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryInstanceByTagResponse>(DoRPCRequest("QueryInstanceByTag", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryInstanceByTagResponse> QueryInstanceByTagWithOptionsAsync(QueryInstanceByTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryInstanceByTagResponse>(await DoRPCRequestAsync("QueryInstanceByTag", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryInstanceByTagResponse QueryInstanceByTag(QueryInstanceByTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInstanceByTagWithOptions(request, runtime);
        }

        public async Task<QueryInstanceByTagResponse> QueryInstanceByTagAsync(QueryInstanceByTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInstanceByTagWithOptionsAsync(request, runtime);
        }

        public QueryInstanceGaapCostResponse QueryInstanceGaapCostWithOptions(QueryInstanceGaapCostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryInstanceGaapCostResponse>(DoRPCRequest("QueryInstanceGaapCost", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryInstanceGaapCostResponse> QueryInstanceGaapCostWithOptionsAsync(QueryInstanceGaapCostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryInstanceGaapCostResponse>(await DoRPCRequestAsync("QueryInstanceGaapCost", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryInstanceGaapCostResponse QueryInstanceGaapCost(QueryInstanceGaapCostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInstanceGaapCostWithOptions(request, runtime);
        }

        public async Task<QueryInstanceGaapCostResponse> QueryInstanceGaapCostAsync(QueryInstanceGaapCostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInstanceGaapCostWithOptionsAsync(request, runtime);
        }

        public QueryInvoicingCustomerListResponse QueryInvoicingCustomerListWithOptions(QueryInvoicingCustomerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryInvoicingCustomerListResponse>(DoRPCRequest("QueryInvoicingCustomerList", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryInvoicingCustomerListResponse> QueryInvoicingCustomerListWithOptionsAsync(QueryInvoicingCustomerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryInvoicingCustomerListResponse>(await DoRPCRequestAsync("QueryInvoicingCustomerList", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryInvoicingCustomerListResponse QueryInvoicingCustomerList(QueryInvoicingCustomerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInvoicingCustomerListWithOptions(request, runtime);
        }

        public async Task<QueryInvoicingCustomerListResponse> QueryInvoicingCustomerListAsync(QueryInvoicingCustomerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInvoicingCustomerListWithOptionsAsync(request, runtime);
        }

        public QueryMonthlyBillResponse QueryMonthlyBillWithOptions(QueryMonthlyBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMonthlyBillResponse>(DoRPCRequest("QueryMonthlyBill", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMonthlyBillResponse> QueryMonthlyBillWithOptionsAsync(QueryMonthlyBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMonthlyBillResponse>(await DoRPCRequestAsync("QueryMonthlyBill", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMonthlyBillResponse QueryMonthlyBill(QueryMonthlyBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMonthlyBillWithOptions(request, runtime);
        }

        public async Task<QueryMonthlyBillResponse> QueryMonthlyBillAsync(QueryMonthlyBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMonthlyBillWithOptionsAsync(request, runtime);
        }

        public QueryMonthlyInstanceConsumptionResponse QueryMonthlyInstanceConsumptionWithOptions(QueryMonthlyInstanceConsumptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMonthlyInstanceConsumptionResponse>(DoRPCRequest("QueryMonthlyInstanceConsumption", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMonthlyInstanceConsumptionResponse> QueryMonthlyInstanceConsumptionWithOptionsAsync(QueryMonthlyInstanceConsumptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMonthlyInstanceConsumptionResponse>(await DoRPCRequestAsync("QueryMonthlyInstanceConsumption", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMonthlyInstanceConsumptionResponse QueryMonthlyInstanceConsumption(QueryMonthlyInstanceConsumptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMonthlyInstanceConsumptionWithOptions(request, runtime);
        }

        public async Task<QueryMonthlyInstanceConsumptionResponse> QueryMonthlyInstanceConsumptionAsync(QueryMonthlyInstanceConsumptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMonthlyInstanceConsumptionWithOptionsAsync(request, runtime);
        }

        public QueryOrdersResponse QueryOrdersWithOptions(QueryOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOrdersResponse>(DoRPCRequest("QueryOrders", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryOrdersResponse> QueryOrdersWithOptionsAsync(QueryOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOrdersResponse>(await DoRPCRequestAsync("QueryOrders", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryOrdersResponse QueryOrders(QueryOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOrdersWithOptions(request, runtime);
        }

        public async Task<QueryOrdersResponse> QueryOrdersAsync(QueryOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOrdersWithOptionsAsync(request, runtime);
        }

        public QueryPermissionListResponse QueryPermissionListWithOptions(QueryPermissionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPermissionListResponse>(DoRPCRequest("QueryPermissionList", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryPermissionListResponse> QueryPermissionListWithOptionsAsync(QueryPermissionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPermissionListResponse>(await DoRPCRequestAsync("QueryPermissionList", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryPermissionListResponse QueryPermissionList(QueryPermissionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPermissionListWithOptions(request, runtime);
        }

        public async Task<QueryPermissionListResponse> QueryPermissionListAsync(QueryPermissionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPermissionListWithOptionsAsync(request, runtime);
        }

        public QueryPrepaidCardsResponse QueryPrepaidCardsWithOptions(QueryPrepaidCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPrepaidCardsResponse>(DoRPCRequest("QueryPrepaidCards", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryPrepaidCardsResponse> QueryPrepaidCardsWithOptionsAsync(QueryPrepaidCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPrepaidCardsResponse>(await DoRPCRequestAsync("QueryPrepaidCards", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryPrepaidCardsResponse QueryPrepaidCards(QueryPrepaidCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPrepaidCardsWithOptions(request, runtime);
        }

        public async Task<QueryPrepaidCardsResponse> QueryPrepaidCardsAsync(QueryPrepaidCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPrepaidCardsWithOptionsAsync(request, runtime);
        }

        public QueryProductListResponse QueryProductListWithOptions(QueryProductListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryProductListResponse>(DoRPCRequest("QueryProductList", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryProductListResponse> QueryProductListWithOptionsAsync(QueryProductListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryProductListResponse>(await DoRPCRequestAsync("QueryProductList", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryProductListResponse QueryProductList(QueryProductListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryProductListWithOptions(request, runtime);
        }

        public async Task<QueryProductListResponse> QueryProductListAsync(QueryProductListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryProductListWithOptionsAsync(request, runtime);
        }

        public QueryRedeemResponse QueryRedeemWithOptions(QueryRedeemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<QueryRedeemResponse>(DoRPCRequest("QueryRedeem", "2017-12-14", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<QueryRedeemResponse> QueryRedeemWithOptionsAsync(QueryRedeemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<QueryRedeemResponse>(await DoRPCRequestAsync("QueryRedeem", "2017-12-14", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public QueryRedeemResponse QueryRedeem(QueryRedeemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRedeemWithOptions(request, runtime);
        }

        public async Task<QueryRedeemResponse> QueryRedeemAsync(QueryRedeemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRedeemWithOptionsAsync(request, runtime);
        }

        public QueryRelationListResponse QueryRelationListWithOptions(QueryRelationListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRelationListResponse>(DoRPCRequest("QueryRelationList", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryRelationListResponse> QueryRelationListWithOptionsAsync(QueryRelationListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRelationListResponse>(await DoRPCRequestAsync("QueryRelationList", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryRelationListResponse QueryRelationList(QueryRelationListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRelationListWithOptions(request, runtime);
        }

        public async Task<QueryRelationListResponse> QueryRelationListAsync(QueryRelationListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRelationListWithOptionsAsync(request, runtime);
        }

        public QueryResellerAvailableQuotaResponse QueryResellerAvailableQuotaWithOptions(QueryResellerAvailableQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryResellerAvailableQuotaResponse>(DoRPCRequest("QueryResellerAvailableQuota", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryResellerAvailableQuotaResponse> QueryResellerAvailableQuotaWithOptionsAsync(QueryResellerAvailableQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryResellerAvailableQuotaResponse>(await DoRPCRequestAsync("QueryResellerAvailableQuota", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryResellerAvailableQuotaResponse QueryResellerAvailableQuota(QueryResellerAvailableQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryResellerAvailableQuotaWithOptions(request, runtime);
        }

        public async Task<QueryResellerAvailableQuotaResponse> QueryResellerAvailableQuotaAsync(QueryResellerAvailableQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryResellerAvailableQuotaWithOptionsAsync(request, runtime);
        }

        public QueryRIUtilizationDetailResponse QueryRIUtilizationDetailWithOptions(QueryRIUtilizationDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRIUtilizationDetailResponse>(DoRPCRequest("QueryRIUtilizationDetail", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryRIUtilizationDetailResponse> QueryRIUtilizationDetailWithOptionsAsync(QueryRIUtilizationDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRIUtilizationDetailResponse>(await DoRPCRequestAsync("QueryRIUtilizationDetail", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryRIUtilizationDetailResponse QueryRIUtilizationDetail(QueryRIUtilizationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRIUtilizationDetailWithOptions(request, runtime);
        }

        public async Task<QueryRIUtilizationDetailResponse> QueryRIUtilizationDetailAsync(QueryRIUtilizationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRIUtilizationDetailWithOptionsAsync(request, runtime);
        }

        public QuerySavingsPlansDeductLogResponse QuerySavingsPlansDeductLogWithOptions(QuerySavingsPlansDeductLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySavingsPlansDeductLogResponse>(DoRPCRequest("QuerySavingsPlansDeductLog", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QuerySavingsPlansDeductLogResponse> QuerySavingsPlansDeductLogWithOptionsAsync(QuerySavingsPlansDeductLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySavingsPlansDeductLogResponse>(await DoRPCRequestAsync("QuerySavingsPlansDeductLog", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QuerySavingsPlansDeductLogResponse QuerySavingsPlansDeductLog(QuerySavingsPlansDeductLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySavingsPlansDeductLogWithOptions(request, runtime);
        }

        public async Task<QuerySavingsPlansDeductLogResponse> QuerySavingsPlansDeductLogAsync(QuerySavingsPlansDeductLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySavingsPlansDeductLogWithOptionsAsync(request, runtime);
        }

        public QuerySavingsPlansInstanceResponse QuerySavingsPlansInstanceWithOptions(QuerySavingsPlansInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySavingsPlansInstanceResponse>(DoRPCRequest("QuerySavingsPlansInstance", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QuerySavingsPlansInstanceResponse> QuerySavingsPlansInstanceWithOptionsAsync(QuerySavingsPlansInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySavingsPlansInstanceResponse>(await DoRPCRequestAsync("QuerySavingsPlansInstance", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QuerySavingsPlansInstanceResponse QuerySavingsPlansInstance(QuerySavingsPlansInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySavingsPlansInstanceWithOptions(request, runtime);
        }

        public async Task<QuerySavingsPlansInstanceResponse> QuerySavingsPlansInstanceAsync(QuerySavingsPlansInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySavingsPlansInstanceWithOptionsAsync(request, runtime);
        }

        public QuerySettleBillResponse QuerySettleBillWithOptions(QuerySettleBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySettleBillResponse>(DoRPCRequest("QuerySettleBill", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QuerySettleBillResponse> QuerySettleBillWithOptionsAsync(QuerySettleBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySettleBillResponse>(await DoRPCRequestAsync("QuerySettleBill", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QuerySettleBillResponse QuerySettleBill(QuerySettleBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySettleBillWithOptions(request, runtime);
        }

        public async Task<QuerySettleBillResponse> QuerySettleBillAsync(QuerySettleBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySettleBillWithOptionsAsync(request, runtime);
        }

        public QuerySettlementBillResponse QuerySettlementBillWithOptions(QuerySettlementBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySettlementBillResponse>(DoRPCRequest("QuerySettlementBill", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QuerySettlementBillResponse> QuerySettlementBillWithOptionsAsync(QuerySettlementBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySettlementBillResponse>(await DoRPCRequestAsync("QuerySettlementBill", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QuerySettlementBillResponse QuerySettlementBill(QuerySettlementBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySettlementBillWithOptions(request, runtime);
        }

        public async Task<QuerySettlementBillResponse> QuerySettlementBillAsync(QuerySettlementBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySettlementBillWithOptionsAsync(request, runtime);
        }

        public QuerySplitItemBillResponse QuerySplitItemBillWithOptions(QuerySplitItemBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySplitItemBillResponse>(DoRPCRequest("QuerySplitItemBill", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QuerySplitItemBillResponse> QuerySplitItemBillWithOptionsAsync(QuerySplitItemBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySplitItemBillResponse>(await DoRPCRequestAsync("QuerySplitItemBill", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QuerySplitItemBillResponse QuerySplitItemBill(QuerySplitItemBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySplitItemBillWithOptions(request, runtime);
        }

        public async Task<QuerySplitItemBillResponse> QuerySplitItemBillAsync(QuerySplitItemBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySplitItemBillWithOptionsAsync(request, runtime);
        }

        public QueryUserOmsDataResponse QueryUserOmsDataWithOptions(QueryUserOmsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryUserOmsDataResponse>(DoRPCRequest("QueryUserOmsData", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryUserOmsDataResponse> QueryUserOmsDataWithOptionsAsync(QueryUserOmsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryUserOmsDataResponse>(await DoRPCRequestAsync("QueryUserOmsData", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryUserOmsDataResponse QueryUserOmsData(QueryUserOmsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUserOmsDataWithOptions(request, runtime);
        }

        public async Task<QueryUserOmsDataResponse> QueryUserOmsDataAsync(QueryUserOmsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUserOmsDataWithOptionsAsync(request, runtime);
        }

        public RenewInstanceResponse RenewInstanceWithOptions(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewInstanceResponse>(DoRPCRequest("RenewInstance", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenewInstanceResponse> RenewInstanceWithOptionsAsync(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewInstanceResponse>(await DoRPCRequestAsync("RenewInstance", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RenewInstanceResponse RenewInstance(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewInstanceWithOptions(request, runtime);
        }

        public async Task<RenewInstanceResponse> RenewInstanceAsync(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewInstanceWithOptionsAsync(request, runtime);
        }

        public RenewResourcePackageResponse RenewResourcePackageWithOptions(RenewResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewResourcePackageResponse>(DoRPCRequest("RenewResourcePackage", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenewResourcePackageResponse> RenewResourcePackageWithOptionsAsync(RenewResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewResourcePackageResponse>(await DoRPCRequestAsync("RenewResourcePackage", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RenewResourcePackageResponse RenewResourcePackage(RenewResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewResourcePackageWithOptions(request, runtime);
        }

        public async Task<RenewResourcePackageResponse> RenewResourcePackageAsync(RenewResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewResourcePackageWithOptionsAsync(request, runtime);
        }

        public SaveUserCreditResponse SaveUserCreditWithOptions(SaveUserCreditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveUserCreditResponse>(DoRPCRequest("SaveUserCredit", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveUserCreditResponse> SaveUserCreditWithOptionsAsync(SaveUserCreditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveUserCreditResponse>(await DoRPCRequestAsync("SaveUserCredit", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveUserCreditResponse SaveUserCredit(SaveUserCreditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveUserCreditWithOptions(request, runtime);
        }

        public async Task<SaveUserCreditResponse> SaveUserCreditAsync(SaveUserCreditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveUserCreditWithOptionsAsync(request, runtime);
        }

        public SetCreditLabelActionResponse SetCreditLabelActionWithOptions(SetCreditLabelActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetCreditLabelActionResponse>(DoRPCRequest("SetCreditLabelAction", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetCreditLabelActionResponse> SetCreditLabelActionWithOptionsAsync(SetCreditLabelActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetCreditLabelActionResponse>(await DoRPCRequestAsync("SetCreditLabelAction", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetCreditLabelActionResponse SetCreditLabelAction(SetCreditLabelActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCreditLabelActionWithOptions(request, runtime);
        }

        public async Task<SetCreditLabelActionResponse> SetCreditLabelActionAsync(SetCreditLabelActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCreditLabelActionWithOptionsAsync(request, runtime);
        }

        public SetRenewalResponse SetRenewalWithOptions(SetRenewalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetRenewalResponse>(DoRPCRequest("SetRenewal", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetRenewalResponse> SetRenewalWithOptionsAsync(SetRenewalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetRenewalResponse>(await DoRPCRequestAsync("SetRenewal", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetRenewalResponse SetRenewal(SetRenewalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetRenewalWithOptions(request, runtime);
        }

        public async Task<SetRenewalResponse> SetRenewalAsync(SetRenewalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetRenewalWithOptionsAsync(request, runtime);
        }

        public SetResellerUserAlarmThresholdResponse SetResellerUserAlarmThresholdWithOptions(SetResellerUserAlarmThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetResellerUserAlarmThresholdResponse>(DoRPCRequest("SetResellerUserAlarmThreshold", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetResellerUserAlarmThresholdResponse> SetResellerUserAlarmThresholdWithOptionsAsync(SetResellerUserAlarmThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetResellerUserAlarmThresholdResponse>(await DoRPCRequestAsync("SetResellerUserAlarmThreshold", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetResellerUserAlarmThresholdResponse SetResellerUserAlarmThreshold(SetResellerUserAlarmThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetResellerUserAlarmThresholdWithOptions(request, runtime);
        }

        public async Task<SetResellerUserAlarmThresholdResponse> SetResellerUserAlarmThresholdAsync(SetResellerUserAlarmThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetResellerUserAlarmThresholdWithOptionsAsync(request, runtime);
        }

        public SetResellerUserQuotaResponse SetResellerUserQuotaWithOptions(SetResellerUserQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetResellerUserQuotaResponse>(DoRPCRequest("SetResellerUserQuota", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetResellerUserQuotaResponse> SetResellerUserQuotaWithOptionsAsync(SetResellerUserQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetResellerUserQuotaResponse>(await DoRPCRequestAsync("SetResellerUserQuota", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetResellerUserQuotaResponse SetResellerUserQuota(SetResellerUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetResellerUserQuotaWithOptions(request, runtime);
        }

        public async Task<SetResellerUserQuotaResponse> SetResellerUserQuotaAsync(SetResellerUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetResellerUserQuotaWithOptionsAsync(request, runtime);
        }

        public SetResellerUserStatusResponse SetResellerUserStatusWithOptions(SetResellerUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetResellerUserStatusResponse>(DoRPCRequest("SetResellerUserStatus", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetResellerUserStatusResponse> SetResellerUserStatusWithOptionsAsync(SetResellerUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetResellerUserStatusResponse>(await DoRPCRequestAsync("SetResellerUserStatus", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetResellerUserStatusResponse SetResellerUserStatus(SetResellerUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetResellerUserStatusWithOptions(request, runtime);
        }

        public async Task<SetResellerUserStatusResponse> SetResellerUserStatusAsync(SetResellerUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetResellerUserStatusWithOptionsAsync(request, runtime);
        }

        public SubscribeBillToOSSResponse SubscribeBillToOSSWithOptions(SubscribeBillToOSSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubscribeBillToOSSResponse>(DoRPCRequest("SubscribeBillToOSS", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubscribeBillToOSSResponse> SubscribeBillToOSSWithOptionsAsync(SubscribeBillToOSSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubscribeBillToOSSResponse>(await DoRPCRequestAsync("SubscribeBillToOSS", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubscribeBillToOSSResponse SubscribeBillToOSS(SubscribeBillToOSSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubscribeBillToOSSWithOptions(request, runtime);
        }

        public async Task<SubscribeBillToOSSResponse> SubscribeBillToOSSAsync(SubscribeBillToOSSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubscribeBillToOSSWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        public UnsubscribeBillToOSSResponse UnsubscribeBillToOSSWithOptions(UnsubscribeBillToOSSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnsubscribeBillToOSSResponse>(DoRPCRequest("UnsubscribeBillToOSS", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnsubscribeBillToOSSResponse> UnsubscribeBillToOSSWithOptionsAsync(UnsubscribeBillToOSSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnsubscribeBillToOSSResponse>(await DoRPCRequestAsync("UnsubscribeBillToOSS", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnsubscribeBillToOSSResponse UnsubscribeBillToOSS(UnsubscribeBillToOSSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnsubscribeBillToOSSWithOptions(request, runtime);
        }

        public async Task<UnsubscribeBillToOSSResponse> UnsubscribeBillToOSSAsync(UnsubscribeBillToOSSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnsubscribeBillToOSSWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        public UpgradeResourcePackageResponse UpgradeResourcePackageWithOptions(UpgradeResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeResourcePackageResponse>(DoRPCRequest("UpgradeResourcePackage", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeResourcePackageResponse> UpgradeResourcePackageWithOptionsAsync(UpgradeResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeResourcePackageResponse>(await DoRPCRequestAsync("UpgradeResourcePackage", "2017-12-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeResourcePackageResponse UpgradeResourcePackage(UpgradeResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeResourcePackageWithOptions(request, runtime);
        }

        public async Task<UpgradeResourcePackageResponse> UpgradeResourcePackageAsync(UpgradeResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeResourcePackageWithOptionsAsync(request, runtime);
        }

    }
}
