// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Agency20221216.Models;

namespace AlibabaCloud.SDK.Agency20221216
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "agency.aliyuncs.com"},
                {"ap-northeast-2-pop", "agency.aliyuncs.com"},
                {"ap-south-1", "agency.aliyuncs.com"},
                {"ap-southeast-2", "agency.aliyuncs.com"},
                {"ap-southeast-3", "agency.aliyuncs.com"},
                {"ap-southeast-5", "agency.aliyuncs.com"},
                {"cn-beijing", "agency.aliyuncs.com"},
                {"cn-beijing-finance-1", "agency.aliyuncs.com"},
                {"cn-beijing-finance-pop", "agency.aliyuncs.com"},
                {"cn-beijing-gov-1", "agency.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "agency.aliyuncs.com"},
                {"cn-chengdu", "agency.aliyuncs.com"},
                {"cn-edge-1", "agency.aliyuncs.com"},
                {"cn-fujian", "agency.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "agency.aliyuncs.com"},
                {"cn-hangzhou", "agency.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "agency.aliyuncs.com"},
                {"cn-hangzhou-finance", "agency.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "agency.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "agency.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "agency.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "agency.aliyuncs.com"},
                {"cn-hangzhou-test-306", "agency.aliyuncs.com"},
                {"cn-hongkong", "agency.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "agency.aliyuncs.com"},
                {"cn-huhehaote", "agency.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "agency.aliyuncs.com"},
                {"cn-north-2-gov-1", "agency.aliyuncs.com"},
                {"cn-qingdao", "agency.aliyuncs.com"},
                {"cn-qingdao-nebula", "agency.aliyuncs.com"},
                {"cn-shanghai", "agency.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "agency.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "agency.aliyuncs.com"},
                {"cn-shanghai-finance-1", "agency.aliyuncs.com"},
                {"cn-shanghai-inner", "agency.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "agency.aliyuncs.com"},
                {"cn-shenzhen", "agency.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "agency.aliyuncs.com"},
                {"cn-shenzhen-inner", "agency.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "agency.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "agency.aliyuncs.com"},
                {"cn-wuhan", "agency.aliyuncs.com"},
                {"cn-wulanchabu", "agency.aliyuncs.com"},
                {"cn-yushanfang", "agency.aliyuncs.com"},
                {"cn-zhangbei", "agency.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "agency.aliyuncs.com"},
                {"cn-zhangjiakou", "agency.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "agency.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "agency.aliyuncs.com"},
                {"eu-central-1", "agency.aliyuncs.com"},
                {"eu-west-1", "agency.aliyuncs.com"},
                {"eu-west-1-oxs", "agency.aliyuncs.com"},
                {"me-east-1", "agency.aliyuncs.com"},
                {"rus-west-1-pop", "agency.aliyuncs.com"},
                {"us-east-1", "agency.aliyuncs.com"},
                {"us-west-1", "agency.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("agency", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Cancels the subscription to multi-level bills as an Alibaba Cloud eco-partner.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Make sure that you are a distributor of the Alibaba Cloud international ecosystem.
        /// You can call this operation to cancel the subscription to only one type of bill at a time.
        /// After the subscription to a type of bill is canceled, bills of this type are no longer pushed to the specified Object Storage Service (OSS) bucket.
        /// **This topic is published only on the international site (alibabacloud.com).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelSubscriptionBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelSubscriptionBillResponse
        /// </returns>
        public CancelSubscriptionBillResponse CancelSubscriptionBillWithOptions(CancelSubscriptionBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscribeType))
            {
                query["SubscribeType"] = request.SubscribeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelSubscriptionBill",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelSubscriptionBillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the subscription to multi-level bills as an Alibaba Cloud eco-partner.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Make sure that you are a distributor of the Alibaba Cloud international ecosystem.
        /// You can call this operation to cancel the subscription to only one type of bill at a time.
        /// After the subscription to a type of bill is canceled, bills of this type are no longer pushed to the specified Object Storage Service (OSS) bucket.
        /// **This topic is published only on the international site (alibabacloud.com).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelSubscriptionBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelSubscriptionBillResponse
        /// </returns>
        public async Task<CancelSubscriptionBillResponse> CancelSubscriptionBillWithOptionsAsync(CancelSubscriptionBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscribeType))
            {
                query["SubscribeType"] = request.SubscribeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelSubscriptionBill",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelSubscriptionBillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the subscription to multi-level bills as an Alibaba Cloud eco-partner.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Make sure that you are a distributor of the Alibaba Cloud international ecosystem.
        /// You can call this operation to cancel the subscription to only one type of bill at a time.
        /// After the subscription to a type of bill is canceled, bills of this type are no longer pushed to the specified Object Storage Service (OSS) bucket.
        /// **This topic is published only on the international site (alibabacloud.com).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelSubscriptionBillRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelSubscriptionBillResponse
        /// </returns>
        public CancelSubscriptionBillResponse CancelSubscriptionBill(CancelSubscriptionBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelSubscriptionBillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the subscription to multi-level bills as an Alibaba Cloud eco-partner.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Make sure that you are a distributor of the Alibaba Cloud international ecosystem.
        /// You can call this operation to cancel the subscription to only one type of bill at a time.
        /// After the subscription to a type of bill is canceled, bills of this type are no longer pushed to the specified Object Storage Service (OSS) bucket.
        /// **This topic is published only on the international site (alibabacloud.com).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelSubscriptionBillRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelSubscriptionBillResponse
        /// </returns>
        public async Task<CancelSubscriptionBillResponse> CancelSubscriptionBillAsync(CancelSubscriptionBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelSubscriptionBillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建优惠券模板</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateCouponTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCouponTemplateResponse
        /// </returns>
        public CreateCouponTemplateResponse CreateCouponTemplateWithOptions(CreateCouponTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCouponTemplateShrinkRequest request = new CreateCouponTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProductType))
            {
                request.ProductTypeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProductType, "ProductType", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicableProducts))
            {
                query["ApplicableProducts"] = request.ApplicableProducts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostBearer))
            {
                query["CostBearer"] = request.CostBearer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponDescription))
            {
                query["CouponDescription"] = request.CouponDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expireddate))
            {
                query["Expireddate"] = request.Expireddate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitPerPerson))
            {
                query["LimitPerPerson"] = request.LimitPerPerson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductTypeShrink))
            {
                query["ProductType"] = request.ProductTypeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaseType))
            {
                query["PurchaseType"] = request.PurchaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonForApplication))
            {
                query["ReasonForApplication"] = request.ReasonForApplication;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vailddate))
            {
                query["Vailddate"] = request.Vailddate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vaildperioddays))
            {
                query["Vaildperioddays"] = request.Vaildperioddays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidUntil))
            {
                query["ValidUntil"] = request.ValidUntil;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCouponTemplate",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCouponTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建优惠券模板</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateCouponTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCouponTemplateResponse
        /// </returns>
        public async Task<CreateCouponTemplateResponse> CreateCouponTemplateWithOptionsAsync(CreateCouponTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCouponTemplateShrinkRequest request = new CreateCouponTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProductType))
            {
                request.ProductTypeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProductType, "ProductType", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicableProducts))
            {
                query["ApplicableProducts"] = request.ApplicableProducts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostBearer))
            {
                query["CostBearer"] = request.CostBearer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponDescription))
            {
                query["CouponDescription"] = request.CouponDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expireddate))
            {
                query["Expireddate"] = request.Expireddate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitPerPerson))
            {
                query["LimitPerPerson"] = request.LimitPerPerson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductTypeShrink))
            {
                query["ProductType"] = request.ProductTypeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaseType))
            {
                query["PurchaseType"] = request.PurchaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonForApplication))
            {
                query["ReasonForApplication"] = request.ReasonForApplication;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vailddate))
            {
                query["Vailddate"] = request.Vailddate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vaildperioddays))
            {
                query["Vaildperioddays"] = request.Vaildperioddays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidUntil))
            {
                query["ValidUntil"] = request.ValidUntil;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCouponTemplate",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCouponTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建优惠券模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCouponTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCouponTemplateResponse
        /// </returns>
        public CreateCouponTemplateResponse CreateCouponTemplate(CreateCouponTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCouponTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建优惠券模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCouponTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCouponTemplateResponse
        /// </returns>
        public async Task<CreateCouponTemplateResponse> CreateCouponTemplateAsync(CreateCouponTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCouponTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This function is designed for create a customer who is to be invited.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerResponse
        /// </returns>
        public CreateCustomerResponse CreateCustomerWithOptions(CreateCustomerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerName))
            {
                query["CustomerName"] = request.CustomerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerSource))
            {
                query["CustomerSource"] = request.CustomerSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerSubTrade))
            {
                query["CustomerSubTrade"] = request.CustomerSubTrade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerTrade))
            {
                query["CustomerTrade"] = request.CustomerTrade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nation))
            {
                query["Nation"] = request.Nation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomer",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This function is designed for create a customer who is to be invited.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerResponse
        /// </returns>
        public async Task<CreateCustomerResponse> CreateCustomerWithOptionsAsync(CreateCustomerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerName))
            {
                query["CustomerName"] = request.CustomerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerSource))
            {
                query["CustomerSource"] = request.CustomerSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerSubTrade))
            {
                query["CustomerSubTrade"] = request.CustomerSubTrade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerTrade))
            {
                query["CustomerTrade"] = request.CustomerTrade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nation))
            {
                query["Nation"] = request.Nation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomer",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This function is designed for create a customer who is to be invited.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerResponse
        /// </returns>
        public CreateCustomerResponse CreateCustomer(CreateCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This function is designed for create a customer who is to be invited.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerResponse
        /// </returns>
        public async Task<CreateCustomerResponse> CreateCustomerAsync(CreateCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query quota adjustment list of Distribution Customer from International Site. Not available on Domestic Site.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CustomerQuotaRecordListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CustomerQuotaRecordListResponse
        /// </returns>
        public CustomerQuotaRecordListResponse CustomerQuotaRecordListWithOptions(CustomerQuotaRecordListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CustomerQuotaRecordList",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomerQuotaRecordListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query quota adjustment list of Distribution Customer from International Site. Not available on Domestic Site.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CustomerQuotaRecordListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CustomerQuotaRecordListResponse
        /// </returns>
        public async Task<CustomerQuotaRecordListResponse> CustomerQuotaRecordListWithOptionsAsync(CustomerQuotaRecordListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CustomerQuotaRecordList",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomerQuotaRecordListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query quota adjustment list of Distribution Customer from International Site. Not available on Domestic Site.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CustomerQuotaRecordListRequest
        /// </param>
        /// 
        /// <returns>
        /// CustomerQuotaRecordListResponse
        /// </returns>
        public CustomerQuotaRecordListResponse CustomerQuotaRecordList(CustomerQuotaRecordListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CustomerQuotaRecordListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query quota adjustment list of Distribution Customer from International Site. Not available on Domestic Site.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CustomerQuotaRecordListRequest
        /// </param>
        /// 
        /// <returns>
        /// CustomerQuotaRecordListResponse
        /// </returns>
        public async Task<CustomerQuotaRecordListResponse> CustomerQuotaRecordListAsync(CustomerQuotaRecordListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CustomerQuotaRecordListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API is used to offset the Deducted Credit of a Distribution Customer. For example, if the current Deducted Credit is 500 and the Available Credit is 1000, by offsetting 300, the Deducted Credit will then become 200, and the Available Credit becomes 1300.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Note that sometimes you may find that the customer\&quot;s Used Credit is negative. This indicates that there is no need to restore the Used Credit, and its ready for customer\&quot;s usage. This phenomenon occurs because a refund is generated while the customer\&quot;s credit is full, thereby triggered additional increasing on the customer\&quot;s credit.
        /// For example, if the customer\&quot;s maximum Available Credit is 1000 with no usage, and a refund of 300 occurs, the Used Credit will become -300.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeductOutstandingBalanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeductOutstandingBalanceResponse
        /// </returns>
        public DeductOutstandingBalanceResponse DeductOutstandingBalanceWithOptions(DeductOutstandingBalanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductAmount))
            {
                query["DeductAmount"] = request.DeductAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeductOutstandingBalance",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeductOutstandingBalanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API is used to offset the Deducted Credit of a Distribution Customer. For example, if the current Deducted Credit is 500 and the Available Credit is 1000, by offsetting 300, the Deducted Credit will then become 200, and the Available Credit becomes 1300.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Note that sometimes you may find that the customer\&quot;s Used Credit is negative. This indicates that there is no need to restore the Used Credit, and its ready for customer\&quot;s usage. This phenomenon occurs because a refund is generated while the customer\&quot;s credit is full, thereby triggered additional increasing on the customer\&quot;s credit.
        /// For example, if the customer\&quot;s maximum Available Credit is 1000 with no usage, and a refund of 300 occurs, the Used Credit will become -300.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeductOutstandingBalanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeductOutstandingBalanceResponse
        /// </returns>
        public async Task<DeductOutstandingBalanceResponse> DeductOutstandingBalanceWithOptionsAsync(DeductOutstandingBalanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductAmount))
            {
                query["DeductAmount"] = request.DeductAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeductOutstandingBalance",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeductOutstandingBalanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API is used to offset the Deducted Credit of a Distribution Customer. For example, if the current Deducted Credit is 500 and the Available Credit is 1000, by offsetting 300, the Deducted Credit will then become 200, and the Available Credit becomes 1300.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Note that sometimes you may find that the customer\&quot;s Used Credit is negative. This indicates that there is no need to restore the Used Credit, and its ready for customer\&quot;s usage. This phenomenon occurs because a refund is generated while the customer\&quot;s credit is full, thereby triggered additional increasing on the customer\&quot;s credit.
        /// For example, if the customer\&quot;s maximum Available Credit is 1000 with no usage, and a refund of 300 occurs, the Used Credit will become -300.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeductOutstandingBalanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeductOutstandingBalanceResponse
        /// </returns>
        public DeductOutstandingBalanceResponse DeductOutstandingBalance(DeductOutstandingBalanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeductOutstandingBalanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API is used to offset the Deducted Credit of a Distribution Customer. For example, if the current Deducted Credit is 500 and the Available Credit is 1000, by offsetting 300, the Deducted Credit will then become 200, and the Available Credit becomes 1300.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Note that sometimes you may find that the customer\&quot;s Used Credit is negative. This indicates that there is no need to restore the Used Credit, and its ready for customer\&quot;s usage. This phenomenon occurs because a refund is generated while the customer\&quot;s credit is full, thereby triggered additional increasing on the customer\&quot;s credit.
        /// For example, if the customer\&quot;s maximum Available Credit is 1000 with no usage, and a refund of 300 occurs, the Used Credit will become -300.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeductOutstandingBalanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeductOutstandingBalanceResponse
        /// </returns>
        public async Task<DeductOutstandingBalanceResponse> DeductOutstandingBalanceAsync(DeductOutstandingBalanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeductOutstandingBalanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Set the after-shutdown instance status for post-pay End Users as a Reseller.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
        /// **This content is only published on the international site. **</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EditEndUserStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditEndUserStatusResponse
        /// </returns>
        public EditEndUserStatusResponse EditEndUserStatusWithOptions(EditEndUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditEndUserStatus",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditEndUserStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Set the after-shutdown instance status for post-pay End Users as a Reseller.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
        /// **This content is only published on the international site. **</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EditEndUserStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditEndUserStatusResponse
        /// </returns>
        public async Task<EditEndUserStatusResponse> EditEndUserStatusWithOptionsAsync(EditEndUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditEndUserStatus",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditEndUserStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Set the after-shutdown instance status for post-pay End Users as a Reseller.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
        /// **This content is only published on the international site. **</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EditEndUserStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// EditEndUserStatusResponse
        /// </returns>
        public EditEndUserStatusResponse EditEndUserStatus(EditEndUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditEndUserStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Set the after-shutdown instance status for post-pay End Users as a Reseller.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
        /// **This content is only published on the international site. **</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EditEndUserStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// EditEndUserStatusResponse
        /// </returns>
        public async Task<EditEndUserStatusResponse> EditEndUserStatusAsync(EditEndUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditEndUserStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Set the New Buy status for Sub-Customer as a Partner.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
        /// **This content is only published on the international site. **</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EditNewBuyStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditNewBuyStatusResponse
        /// </returns>
        public EditNewBuyStatusResponse EditNewBuyStatusWithOptions(EditNewBuyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewBuyStatus))
            {
                query["NewBuyStatus"] = request.NewBuyStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditNewBuyStatus",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditNewBuyStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Set the New Buy status for Sub-Customer as a Partner.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
        /// **This content is only published on the international site. **</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EditNewBuyStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditNewBuyStatusResponse
        /// </returns>
        public async Task<EditNewBuyStatusResponse> EditNewBuyStatusWithOptionsAsync(EditNewBuyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewBuyStatus))
            {
                query["NewBuyStatus"] = request.NewBuyStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditNewBuyStatus",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditNewBuyStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Set the New Buy status for Sub-Customer as a Partner.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
        /// **This content is only published on the international site. **</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EditNewBuyStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// EditNewBuyStatusResponse
        /// </returns>
        public EditNewBuyStatusResponse EditNewBuyStatus(EditNewBuyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditNewBuyStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Set the New Buy status for Sub-Customer as a Partner.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
        /// **This content is only published on the international site. **</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EditNewBuyStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// EditNewBuyStatusResponse
        /// </returns>
        public async Task<EditNewBuyStatusResponse> EditNewBuyStatusAsync(EditNewBuyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditNewBuyStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify the End User\&quot;s Shutdown Policy as a Reseller.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
        /// **This content is only published on the international site. **</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EditZeroCreditShutdownRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditZeroCreditShutdownResponse
        /// </returns>
        public EditZeroCreditShutdownResponse EditZeroCreditShutdownWithOptions(EditZeroCreditShutdownRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShutdownPolicy))
            {
                query["ShutdownPolicy"] = request.ShutdownPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditZeroCreditShutdown",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditZeroCreditShutdownResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify the End User\&quot;s Shutdown Policy as a Reseller.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
        /// **This content is only published on the international site. **</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EditZeroCreditShutdownRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditZeroCreditShutdownResponse
        /// </returns>
        public async Task<EditZeroCreditShutdownResponse> EditZeroCreditShutdownWithOptionsAsync(EditZeroCreditShutdownRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShutdownPolicy))
            {
                query["ShutdownPolicy"] = request.ShutdownPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditZeroCreditShutdown",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditZeroCreditShutdownResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify the End User\&quot;s Shutdown Policy as a Reseller.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
        /// **This content is only published on the international site. **</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EditZeroCreditShutdownRequest
        /// </param>
        /// 
        /// <returns>
        /// EditZeroCreditShutdownResponse
        /// </returns>
        public EditZeroCreditShutdownResponse EditZeroCreditShutdown(EditZeroCreditShutdownRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditZeroCreditShutdownWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify the End User\&quot;s Shutdown Policy as a Reseller.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
        /// **This content is only published on the international site. **</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EditZeroCreditShutdownRequest
        /// </param>
        /// 
        /// <returns>
        /// EditZeroCreditShutdownResponse
        /// </returns>
        public async Task<EditZeroCreditShutdownResponse> EditZeroCreditShutdownAsync(EditZeroCreditShutdownRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditZeroCreditShutdownWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Export quota amount adjustment history as a Distribution Customer from International Site. Only available on International Site.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Caller must be a Partner from International Site, either Distribution or Reseller will do.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExportCustomerQuotaRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportCustomerQuotaRecordResponse
        /// </returns>
        public ExportCustomerQuotaRecordResponse ExportCustomerQuotaRecordWithOptions(ExportCustomerQuotaRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserPk))
            {
                query["EndUserPk"] = request.EndUserPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["OperationType"] = request.OperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportCustomerQuotaRecord",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportCustomerQuotaRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Export quota amount adjustment history as a Distribution Customer from International Site. Only available on International Site.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Caller must be a Partner from International Site, either Distribution or Reseller will do.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExportCustomerQuotaRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportCustomerQuotaRecordResponse
        /// </returns>
        public async Task<ExportCustomerQuotaRecordResponse> ExportCustomerQuotaRecordWithOptionsAsync(ExportCustomerQuotaRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserPk))
            {
                query["EndUserPk"] = request.EndUserPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["OperationType"] = request.OperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportCustomerQuotaRecord",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportCustomerQuotaRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Export quota amount adjustment history as a Distribution Customer from International Site. Only available on International Site.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Caller must be a Partner from International Site, either Distribution or Reseller will do.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExportCustomerQuotaRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportCustomerQuotaRecordResponse
        /// </returns>
        public ExportCustomerQuotaRecordResponse ExportCustomerQuotaRecord(ExportCustomerQuotaRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportCustomerQuotaRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Export quota amount adjustment history as a Distribution Customer from International Site. Only available on International Site.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Caller must be a Partner from International Site, either Distribution or Reseller will do.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExportCustomerQuotaRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportCustomerQuotaRecordResponse
        /// </returns>
        public async Task<ExportCustomerQuotaRecordResponse> ExportCustomerQuotaRecordAsync(ExportCustomerQuotaRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportCustomerQuotaRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Return Distribution Customer\&quot;s account information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccountInfoResponse
        /// </returns>
        public GetAccountInfoResponse GetAccountInfoWithOptions(GetAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountInfo",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Return Distribution Customer\&quot;s account information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccountInfoResponse
        /// </returns>
        public async Task<GetAccountInfoResponse> GetAccountInfoWithOptionsAsync(GetAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountInfo",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Return Distribution Customer\&quot;s account information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccountInfoResponse
        /// </returns>
        public GetAccountInfoResponse GetAccountInfo(GetAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccountInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Return Distribution Customer\&quot;s account information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccountInfoResponse
        /// </returns>
        public async Task<GetAccountInfoResponse> GetAccountInfoAsync(GetAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccountInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>国际渠道分销优惠券可抵扣产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCoupondeductProductCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCoupondeductProductCodeResponse
        /// </returns>
        public GetCoupondeductProductCodeResponse GetCoupondeductProductCodeWithOptions(GetCoupondeductProductCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCoupondeductProductCode",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCoupondeductProductCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>国际渠道分销优惠券可抵扣产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCoupondeductProductCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCoupondeductProductCodeResponse
        /// </returns>
        public async Task<GetCoupondeductProductCodeResponse> GetCoupondeductProductCodeWithOptionsAsync(GetCoupondeductProductCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCoupondeductProductCode",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCoupondeductProductCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>国际渠道分销优惠券可抵扣产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCoupondeductProductCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCoupondeductProductCodeResponse
        /// </returns>
        public GetCoupondeductProductCodeResponse GetCoupondeductProductCode(GetCoupondeductProductCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCoupondeductProductCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>国际渠道分销优惠券可抵扣产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCoupondeductProductCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCoupondeductProductCodeResponse
        /// </returns>
        public async Task<GetCoupondeductProductCodeResponse> GetCoupondeductProductCodeAsync(GetCoupondeductProductCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCoupondeductProductCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Credit Control information of Distribution Customers. The PopCreditInfoJson in the Return Parameter will be empty if the Distribution Customer is an Agency. This function is only available for Resellers and Distributors.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCreditInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCreditInfoResponse
        /// </returns>
        public GetCreditInfoResponse GetCreditInfoWithOptions(GetCreditInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCreditInfo",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCreditInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Credit Control information of Distribution Customers. The PopCreditInfoJson in the Return Parameter will be empty if the Distribution Customer is an Agency. This function is only available for Resellers and Distributors.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCreditInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCreditInfoResponse
        /// </returns>
        public async Task<GetCreditInfoResponse> GetCreditInfoWithOptionsAsync(GetCreditInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCreditInfo",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCreditInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Credit Control information of Distribution Customers. The PopCreditInfoJson in the Return Parameter will be empty if the Distribution Customer is an Agency. This function is only available for Resellers and Distributors.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCreditInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCreditInfoResponse
        /// </returns>
        public GetCreditInfoResponse GetCreditInfo(GetCreditInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCreditInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query Credit Control information of Distribution Customers. The PopCreditInfoJson in the Return Parameter will be empty if the Distribution Customer is an Agency. This function is only available for Resellers and Distributors.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCreditInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCreditInfoResponse
        /// </returns>
        public async Task<GetCreditInfoResponse> GetCreditInfoAsync(GetCreditInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCreditInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户订单查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerOrdersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerOrdersResponse
        /// </returns>
        public GetCustomerOrdersResponse GetCustomerOrdersWithOptions(GetCustomerOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomerOrders",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerOrdersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户订单查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerOrdersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerOrdersResponse
        /// </returns>
        public async Task<GetCustomerOrdersResponse> GetCustomerOrdersWithOptionsAsync(GetCustomerOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomerOrders",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerOrdersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户订单查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerOrdersResponse
        /// </returns>
        public GetCustomerOrdersResponse GetCustomerOrders(GetCustomerOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomerOrdersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户订单查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerOrdersResponse
        /// </returns>
        public async Task<GetCustomerOrdersResponse> GetCustomerOrdersAsync(GetCustomerOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomerOrdersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issue Distributor\&quot;s daily Bill. This function is only available for Resellers and Distributors.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDailyBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDailyBillResponse
        /// </returns>
        public GetDailyBillResponse GetDailyBillWithOptions(GetDailyBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwner))
            {
                query["BillOwner"] = request.BillOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillType))
            {
                query["BillType"] = request.BillType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["Date"] = request.Date;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDailyBill",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDailyBillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issue Distributor\&quot;s daily Bill. This function is only available for Resellers and Distributors.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDailyBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDailyBillResponse
        /// </returns>
        public async Task<GetDailyBillResponse> GetDailyBillWithOptionsAsync(GetDailyBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwner))
            {
                query["BillOwner"] = request.BillOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillType))
            {
                query["BillType"] = request.BillType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["Date"] = request.Date;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDailyBill",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDailyBillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issue Distributor\&quot;s daily Bill. This function is only available for Resellers and Distributors.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDailyBillRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDailyBillResponse
        /// </returns>
        public GetDailyBillResponse GetDailyBill(GetDailyBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDailyBillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issue Distributor\&quot;s daily Bill. This function is only available for Resellers and Distributors.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDailyBillRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDailyBillResponse
        /// </returns>
        public async Task<GetDailyBillResponse> GetDailyBillAsync(GetDailyBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDailyBillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query invitation status of customer who have been created and invited.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInviteStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInviteStatusResponse
        /// </returns>
        public GetInviteStatusResponse GetInviteStatusWithOptions(GetInviteStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteStatusList))
            {
                query["InviteStatusList"] = request.InviteStatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInviteStatus",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInviteStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query invitation status of customer who have been created and invited.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInviteStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInviteStatusResponse
        /// </returns>
        public async Task<GetInviteStatusResponse> GetInviteStatusWithOptionsAsync(GetInviteStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteStatusList))
            {
                query["InviteStatusList"] = request.InviteStatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInviteStatus",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInviteStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query invitation status of customer who have been created and invited.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInviteStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInviteStatusResponse
        /// </returns>
        public GetInviteStatusResponse GetInviteStatus(GetInviteStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInviteStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query invitation status of customer who have been created and invited.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInviteStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInviteStatusResponse
        /// </returns>
        public async Task<GetInviteStatusResponse> GetInviteStatusAsync(GetInviteStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInviteStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issue Distributor\&quot;s Monthly Bill. This function is only available for Resellers and Distributors.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMonthlyBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMonthlyBillResponse
        /// </returns>
        public GetMonthlyBillResponse GetMonthlyBillWithOptions(GetMonthlyBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwner))
            {
                query["BillOwner"] = request.BillOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillType))
            {
                query["BillType"] = request.BillType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Month))
            {
                query["Month"] = request.Month;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMonthlyBill",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMonthlyBillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issue Distributor\&quot;s Monthly Bill. This function is only available for Resellers and Distributors.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMonthlyBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMonthlyBillResponse
        /// </returns>
        public async Task<GetMonthlyBillResponse> GetMonthlyBillWithOptionsAsync(GetMonthlyBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwner))
            {
                query["BillOwner"] = request.BillOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillType))
            {
                query["BillType"] = request.BillType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Month))
            {
                query["Month"] = request.Month;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMonthlyBill",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMonthlyBillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issue Distributor\&quot;s Monthly Bill. This function is only available for Resellers and Distributors.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMonthlyBillRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMonthlyBillResponse
        /// </returns>
        public GetMonthlyBillResponse GetMonthlyBill(GetMonthlyBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMonthlyBillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issue Distributor\&quot;s Monthly Bill. This function is only available for Resellers and Distributors.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMonthlyBillRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMonthlyBillResponse
        /// </returns>
        public async Task<GetMonthlyBillResponse> GetMonthlyBillAsync(GetMonthlyBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMonthlyBillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query all the Unassociated Customer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUnassociatedCustomerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUnassociatedCustomerResponse
        /// </returns>
        public GetUnassociatedCustomerResponse GetUnassociatedCustomerWithOptions(GetUnassociatedCustomerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUnassociatedCustomer",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUnassociatedCustomerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query all the Unassociated Customer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUnassociatedCustomerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUnassociatedCustomerResponse
        /// </returns>
        public async Task<GetUnassociatedCustomerResponse> GetUnassociatedCustomerWithOptionsAsync(GetUnassociatedCustomerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUnassociatedCustomer",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUnassociatedCustomerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query all the Unassociated Customer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUnassociatedCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUnassociatedCustomerResponse
        /// </returns>
        public GetUnassociatedCustomerResponse GetUnassociatedCustomer(GetUnassociatedCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUnassociatedCustomerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query all the Unassociated Customer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUnassociatedCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUnassociatedCustomerResponse
        /// </returns>
        public async Task<GetUnassociatedCustomerResponse> GetUnassociatedCustomerAsync(GetUnassociatedCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUnassociatedCustomerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiate the Partner registration invitation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The current API request rate for the Cloud Product has not been disclosed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InviteSubAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InviteSubAccountResponse
        /// </returns>
        public InviteSubAccountResponse InviteSubAccountWithOptions(InviteSubAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountInfoList))
            {
                query["AccountInfoList"] = request.AccountInfoList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InviteSubAccount",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InviteSubAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiate the Partner registration invitation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The current API request rate for the Cloud Product has not been disclosed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InviteSubAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InviteSubAccountResponse
        /// </returns>
        public async Task<InviteSubAccountResponse> InviteSubAccountWithOptionsAsync(InviteSubAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountInfoList))
            {
                query["AccountInfoList"] = request.AccountInfoList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InviteSubAccount",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InviteSubAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiate the Partner registration invitation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The current API request rate for the Cloud Product has not been disclosed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InviteSubAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// InviteSubAccountResponse
        /// </returns>
        public InviteSubAccountResponse InviteSubAccount(InviteSubAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InviteSubAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiate the Partner registration invitation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The current API request rate for the Cloud Product has not been disclosed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InviteSubAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// InviteSubAccountResponse
        /// </returns>
        public async Task<InviteSubAccountResponse> InviteSubAccountAsync(InviteSubAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InviteSubAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发放优惠券</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IssueCouponForCustomerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IssueCouponForCustomerResponse
        /// </returns>
        public IssueCouponForCustomerResponse IssueCouponForCustomerWithOptions(IssueCouponForCustomerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponTemplateId))
            {
                query["CouponTemplateId"] = request.CouponTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uidlist))
            {
                query["Uidlist"] = request.Uidlist;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IssueCouponForCustomer",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IssueCouponForCustomerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发放优惠券</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IssueCouponForCustomerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IssueCouponForCustomerResponse
        /// </returns>
        public async Task<IssueCouponForCustomerResponse> IssueCouponForCustomerWithOptionsAsync(IssueCouponForCustomerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponTemplateId))
            {
                query["CouponTemplateId"] = request.CouponTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uidlist))
            {
                query["Uidlist"] = request.Uidlist;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IssueCouponForCustomer",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IssueCouponForCustomerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发放优惠券</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IssueCouponForCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// IssueCouponForCustomerResponse
        /// </returns>
        public IssueCouponForCustomerResponse IssueCouponForCustomer(IssueCouponForCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IssueCouponForCustomerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发放优惠券</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IssueCouponForCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// IssueCouponForCustomerResponse
        /// </returns>
        public async Task<IssueCouponForCustomerResponse> IssueCouponForCustomerAsync(IssueCouponForCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IssueCouponForCustomerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This function is available for all Distributors. It displays the corresponding region code information based on the operable countries as agreed in the Distributor\&quot;s contract.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The current API request rate for cloud products has not been disclosed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCountriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCountriesResponse
        /// </returns>
        public ListCountriesResponse ListCountriesWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCountries",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCountriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This function is available for all Distributors. It displays the corresponding region code information based on the operable countries as agreed in the Distributor\&quot;s contract.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The current API request rate for cloud products has not been disclosed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCountriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCountriesResponse
        /// </returns>
        public async Task<ListCountriesResponse> ListCountriesWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCountries",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCountriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This function is available for all Distributors. It displays the corresponding region code information based on the operable countries as agreed in the Distributor\&quot;s contract.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The current API request rate for cloud products has not been disclosed.</para>
        /// </description>
        /// 
        /// <returns>
        /// ListCountriesResponse
        /// </returns>
        public ListCountriesResponse ListCountries()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCountriesWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This function is available for all Distributors. It displays the corresponding region code information based on the operable countries as agreed in the Distributor\&quot;s contract.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The current API request rate for cloud products has not been disclosed.</para>
        /// </description>
        /// 
        /// <returns>
        /// ListCountriesResponse
        /// </returns>
        public async Task<ListCountriesResponse> ListCountriesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCountriesWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>优惠券使用量列表查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCouponUsageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCouponUsageResponse
        /// </returns>
        public ListCouponUsageResponse ListCouponUsageWithOptions(ListCouponUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                query["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponTemplateId))
            {
                query["CouponTemplateId"] = request.CouponTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCouponUsage",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCouponUsageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>优惠券使用量列表查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCouponUsageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCouponUsageResponse
        /// </returns>
        public async Task<ListCouponUsageResponse> ListCouponUsageWithOptionsAsync(ListCouponUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                query["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponTemplateId))
            {
                query["CouponTemplateId"] = request.CouponTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCouponUsage",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCouponUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>优惠券使用量列表查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCouponUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCouponUsageResponse
        /// </returns>
        public ListCouponUsageResponse ListCouponUsage(ListCouponUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCouponUsageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>优惠券使用量列表查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCouponUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCouponUsageResponse
        /// </returns>
        public async Task<ListCouponUsageResponse> ListCouponUsageAsync(ListCouponUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCouponUsageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Check the result of export quota list as a Distribution Customer from International Site. Only available on International Site.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Caller must be a Partner from International Site, either Distribution or Reseller will do.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuotaListExportPagedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuotaListExportPagedResponse
        /// </returns>
        public QuotaListExportPagedResponse QuotaListExportPagedWithOptions(QuotaListExportPagedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuotaListExportPaged",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuotaListExportPagedResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Check the result of export quota list as a Distribution Customer from International Site. Only available on International Site.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Caller must be a Partner from International Site, either Distribution or Reseller will do.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuotaListExportPagedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuotaListExportPagedResponse
        /// </returns>
        public async Task<QuotaListExportPagedResponse> QuotaListExportPagedWithOptionsAsync(QuotaListExportPagedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuotaListExportPaged",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuotaListExportPagedResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Check the result of export quota list as a Distribution Customer from International Site. Only available on International Site.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Caller must be a Partner from International Site, either Distribution or Reseller will do.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuotaListExportPagedRequest
        /// </param>
        /// 
        /// <returns>
        /// QuotaListExportPagedResponse
        /// </returns>
        public QuotaListExportPagedResponse QuotaListExportPaged(QuotaListExportPagedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuotaListExportPagedWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Check the result of export quota list as a Distribution Customer from International Site. Only available on International Site.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Caller must be a Partner from International Site, either Distribution or Reseller will do.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuotaListExportPagedRequest
        /// </param>
        /// 
        /// <returns>
        /// QuotaListExportPagedResponse
        /// </returns>
        public async Task<QuotaListExportPagedResponse> QuotaListExportPagedAsync(QuotaListExportPagedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuotaListExportPagedWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resend invitation email.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResendEmailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResendEmailResponse
        /// </returns>
        public ResendEmailResponse ResendEmailWithOptions(ResendEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteId))
            {
                query["InviteId"] = request.InviteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResendEmail",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResendEmailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resend invitation email.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResendEmailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResendEmailResponse
        /// </returns>
        public async Task<ResendEmailResponse> ResendEmailWithOptionsAsync(ResendEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteId))
            {
                query["InviteId"] = request.InviteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResendEmail",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResendEmailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resend invitation email.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResendEmailRequest
        /// </param>
        /// 
        /// <returns>
        /// ResendEmailResponse
        /// </returns>
        public ResendEmailResponse ResendEmail(ResendEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResendEmailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resend invitation email.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResendEmailRequest
        /// </param>
        /// 
        /// <returns>
        /// ResendEmailResponse
        /// </returns>
        public async Task<ResendEmailResponse> ResendEmailAsync(ResendEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResendEmailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This function is designed for Sub Account information maintenance, including Nickname and Remark.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetAccountInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetAccountInfoResponse
        /// </returns>
        public SetAccountInfoResponse SetAccountInfoWithOptions(SetAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNickname))
            {
                query["AccountNickname"] = request.AccountNickname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerBd))
            {
                query["CustomerBd"] = request.CustomerBd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetAccountInfo",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAccountInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This function is designed for Sub Account information maintenance, including Nickname and Remark.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetAccountInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetAccountInfoResponse
        /// </returns>
        public async Task<SetAccountInfoResponse> SetAccountInfoWithOptionsAsync(SetAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNickname))
            {
                query["AccountNickname"] = request.AccountNickname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerBd))
            {
                query["CustomerBd"] = request.CustomerBd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetAccountInfo",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAccountInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This function is designed for Sub Account information maintenance, including Nickname and Remark.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetAccountInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SetAccountInfoResponse
        /// </returns>
        public SetAccountInfoResponse SetAccountInfo(SetAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAccountInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This function is designed for Sub Account information maintenance, including Nickname and Remark.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetAccountInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SetAccountInfoResponse
        /// </returns>
        public async Task<SetAccountInfoResponse> SetAccountInfoAsync(SetAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAccountInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Set Credit Line for Distribution Customers. This function is only available for Resellers and Distributors.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetCreditLineRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetCreditLineResponse
        /// </returns>
        public SetCreditLineResponse SetCreditLineWithOptions(SetCreditLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditLine))
            {
                query["CreditLine"] = request.CreditLine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetCreditLine",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCreditLineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Set Credit Line for Distribution Customers. This function is only available for Resellers and Distributors.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetCreditLineRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetCreditLineResponse
        /// </returns>
        public async Task<SetCreditLineResponse> SetCreditLineWithOptionsAsync(SetCreditLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditLine))
            {
                query["CreditLine"] = request.CreditLine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetCreditLine",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCreditLineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Set Credit Line for Distribution Customers. This function is only available for Resellers and Distributors.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetCreditLineRequest
        /// </param>
        /// 
        /// <returns>
        /// SetCreditLineResponse
        /// </returns>
        public SetCreditLineResponse SetCreditLine(SetCreditLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCreditLineWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Set Credit Line for Distribution Customers. This function is only available for Resellers and Distributors.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetCreditLineRequest
        /// </param>
        /// 
        /// <returns>
        /// SetCreditLineResponse
        /// </returns>
        public async Task<SetCreditLineResponse> SetCreditLineAsync(SetCreditLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCreditLineWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can use this API to set the threshold for the use of credit control. When the customer credit control reaches below the threshold, it will pass through the notification email distributor. This feature is for Reseller and Distributor only.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetWarningThresholdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetWarningThresholdResponse
        /// </returns>
        public SetWarningThresholdResponse SetWarningThresholdWithOptions(SetWarningThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarningValue))
            {
                query["WarningValue"] = request.WarningValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetWarningThreshold",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetWarningThresholdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can use this API to set the threshold for the use of credit control. When the customer credit control reaches below the threshold, it will pass through the notification email distributor. This feature is for Reseller and Distributor only.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetWarningThresholdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetWarningThresholdResponse
        /// </returns>
        public async Task<SetWarningThresholdResponse> SetWarningThresholdWithOptionsAsync(SetWarningThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarningValue))
            {
                query["WarningValue"] = request.WarningValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetWarningThreshold",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetWarningThresholdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can use this API to set the threshold for the use of credit control. When the customer credit control reaches below the threshold, it will pass through the notification email distributor. This feature is for Reseller and Distributor only.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetWarningThresholdRequest
        /// </param>
        /// 
        /// <returns>
        /// SetWarningThresholdResponse
        /// </returns>
        public SetWarningThresholdResponse SetWarningThreshold(SetWarningThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetWarningThresholdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can use this API to set the threshold for the use of credit control. When the customer credit control reaches below the threshold, it will pass through the notification email distributor. This feature is for Reseller and Distributor only.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetWarningThresholdRequest
        /// </param>
        /// 
        /// <returns>
        /// SetWarningThresholdResponse
        /// </returns>
        public async Task<SetWarningThresholdResponse> SetWarningThresholdAsync(SetWarningThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetWarningThresholdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates the subscription to multi-level bills as an Alibaba Cloud eco-partner.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Make sure that you are a distributor of the Alibaba Cloud international ecosystem.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation to subscribe to only one type of bill at a time.</description></item>
        /// <item><description>After the subscription to a type of bill is generated, the bill for the previous day is pushed on a daily basis from the next day. On the fifth day of each month, the full-data bill for the previous month is pushed.</description></item>
        /// <item><description>A daily bill may be delayed. The delayed bill is pushed the next day after it is generated. The delayed bill may contain the bill data that is delayed until the previous day. We recommend that you query the full-data bill for the previous month at the beginning of each month.</description></item>
        /// <item><description>Your account must be granted the <a href="https://ram.console.aliyun.com/?spm=api-workbench.API%20Document.0.0.68c71e0fhmTSJp#/role/authorize?request=%7B%22Requests%22:%20%7B%22request1%22:%20%7B%22RoleName%22:%20%22AliyunConsumeDump2OSSRole%22,%20%22TemplateId%22:%20%22Dump2OSSRole%22%7D%7D,%20%22ReturnUrl%22:%20%22https:%2F%2Fusercenter2.aliyun.com%22,%20%22Service%22:%20%22Consume%22%7D">AliyunConsumeDump2OSSRole</a> permission.</description></item>
        /// <item><description>The following file name formats are supported for bills:</description></item>
        /// </list>
        /// <pre><c>BillingItemDetailForBillingPeriod
        ///   
        /// File name format of a daily bill: UID_PartnerBillingItemDetail_YYYYMMDD_SquenceNo_fileNo. Example: 169**_BillingItemDetail_20190310_0001_01. 
        ///   
        /// File name format of a monthly full-data bill: UID_PartnerBillingItemDetail_YYYYMM_SquenceNo_fileNo. Example: 169**_BillingItemDetail_201903_0001_01. 
        /// InstanceDetailForBillingPeriod
        ///  
        ///  File name format of a daily bill: UID_PartnerInstanceDetail_YYYYMMDD_SquenceNo_fileNo. Example: 169**_InstanceDetail_20190310_0001_01. 
        ///   
        /// File name format of a monthly full-data bill: UID_PartnerInstanceDetail_YYYYMM_SquenceNo_fileNo. Example: 169**_InstanceDetail_201903_1999-0001_01. 
        /// BillingItemDetailMonthly
        ///   
        /// File name format of a daily bill: UID_PartnerBillingItemDetailMonthly_YYYYMM_SquenceNo_fileNo. Example: 169**_BillingItemDetailMonthly_201903_0001_01. This bill contains the bill data that is generated from the beginning of the current month to the fifth day of the next month. 
        /// InstanceDetailMonthly
        ///   
        /// File name format of a daily bill: UID_PartnerInstanceDetailMonthly_YYYYMM_SquenceNo_fileNo. Example: 169**_InstanceDetailMonthly_201903_0001_01. This bill contains the bill data that is generated from the beginning of the current month to the fifth day of the next month. 
        /// The fileNo field exists only when the number of bill rows reaches the maximum rows in a single bill file and the bill is split into multiple files.
        /// </c></pre>
        /// <para>**This topic is published only on the international site (alibabacloud.com).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubscriptionBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubscriptionBillResponse
        /// </returns>
        public SubscriptionBillResponse SubscriptionBillWithOptions(SubscriptionBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginBillingCycle))
            {
                query["BeginBillingCycle"] = request.BeginBillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillFormat))
            {
                query["BillFormat"] = request.BillFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketOwnerId))
            {
                query["BucketOwnerId"] = request.BucketOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscribeBucket))
            {
                query["SubscribeBucket"] = request.SubscribeBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscribeSegmentSize))
            {
                query["SubscribeSegmentSize"] = request.SubscribeSegmentSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscribeType))
            {
                query["SubscribeType"] = request.SubscribeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubscriptionBill",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubscriptionBillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates the subscription to multi-level bills as an Alibaba Cloud eco-partner.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Make sure that you are a distributor of the Alibaba Cloud international ecosystem.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation to subscribe to only one type of bill at a time.</description></item>
        /// <item><description>After the subscription to a type of bill is generated, the bill for the previous day is pushed on a daily basis from the next day. On the fifth day of each month, the full-data bill for the previous month is pushed.</description></item>
        /// <item><description>A daily bill may be delayed. The delayed bill is pushed the next day after it is generated. The delayed bill may contain the bill data that is delayed until the previous day. We recommend that you query the full-data bill for the previous month at the beginning of each month.</description></item>
        /// <item><description>Your account must be granted the <a href="https://ram.console.aliyun.com/?spm=api-workbench.API%20Document.0.0.68c71e0fhmTSJp#/role/authorize?request=%7B%22Requests%22:%20%7B%22request1%22:%20%7B%22RoleName%22:%20%22AliyunConsumeDump2OSSRole%22,%20%22TemplateId%22:%20%22Dump2OSSRole%22%7D%7D,%20%22ReturnUrl%22:%20%22https:%2F%2Fusercenter2.aliyun.com%22,%20%22Service%22:%20%22Consume%22%7D">AliyunConsumeDump2OSSRole</a> permission.</description></item>
        /// <item><description>The following file name formats are supported for bills:</description></item>
        /// </list>
        /// <pre><c>BillingItemDetailForBillingPeriod
        ///   
        /// File name format of a daily bill: UID_PartnerBillingItemDetail_YYYYMMDD_SquenceNo_fileNo. Example: 169**_BillingItemDetail_20190310_0001_01. 
        ///   
        /// File name format of a monthly full-data bill: UID_PartnerBillingItemDetail_YYYYMM_SquenceNo_fileNo. Example: 169**_BillingItemDetail_201903_0001_01. 
        /// InstanceDetailForBillingPeriod
        ///  
        ///  File name format of a daily bill: UID_PartnerInstanceDetail_YYYYMMDD_SquenceNo_fileNo. Example: 169**_InstanceDetail_20190310_0001_01. 
        ///   
        /// File name format of a monthly full-data bill: UID_PartnerInstanceDetail_YYYYMM_SquenceNo_fileNo. Example: 169**_InstanceDetail_201903_1999-0001_01. 
        /// BillingItemDetailMonthly
        ///   
        /// File name format of a daily bill: UID_PartnerBillingItemDetailMonthly_YYYYMM_SquenceNo_fileNo. Example: 169**_BillingItemDetailMonthly_201903_0001_01. This bill contains the bill data that is generated from the beginning of the current month to the fifth day of the next month. 
        /// InstanceDetailMonthly
        ///   
        /// File name format of a daily bill: UID_PartnerInstanceDetailMonthly_YYYYMM_SquenceNo_fileNo. Example: 169**_InstanceDetailMonthly_201903_0001_01. This bill contains the bill data that is generated from the beginning of the current month to the fifth day of the next month. 
        /// The fileNo field exists only when the number of bill rows reaches the maximum rows in a single bill file and the bill is split into multiple files.
        /// </c></pre>
        /// <para>**This topic is published only on the international site (alibabacloud.com).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubscriptionBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubscriptionBillResponse
        /// </returns>
        public async Task<SubscriptionBillResponse> SubscriptionBillWithOptionsAsync(SubscriptionBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginBillingCycle))
            {
                query["BeginBillingCycle"] = request.BeginBillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillFormat))
            {
                query["BillFormat"] = request.BillFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketOwnerId))
            {
                query["BucketOwnerId"] = request.BucketOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscribeBucket))
            {
                query["SubscribeBucket"] = request.SubscribeBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscribeSegmentSize))
            {
                query["SubscribeSegmentSize"] = request.SubscribeSegmentSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscribeType))
            {
                query["SubscribeType"] = request.SubscribeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubscriptionBill",
                Version = "2022-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubscriptionBillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates the subscription to multi-level bills as an Alibaba Cloud eco-partner.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Make sure that you are a distributor of the Alibaba Cloud international ecosystem.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation to subscribe to only one type of bill at a time.</description></item>
        /// <item><description>After the subscription to a type of bill is generated, the bill for the previous day is pushed on a daily basis from the next day. On the fifth day of each month, the full-data bill for the previous month is pushed.</description></item>
        /// <item><description>A daily bill may be delayed. The delayed bill is pushed the next day after it is generated. The delayed bill may contain the bill data that is delayed until the previous day. We recommend that you query the full-data bill for the previous month at the beginning of each month.</description></item>
        /// <item><description>Your account must be granted the <a href="https://ram.console.aliyun.com/?spm=api-workbench.API%20Document.0.0.68c71e0fhmTSJp#/role/authorize?request=%7B%22Requests%22:%20%7B%22request1%22:%20%7B%22RoleName%22:%20%22AliyunConsumeDump2OSSRole%22,%20%22TemplateId%22:%20%22Dump2OSSRole%22%7D%7D,%20%22ReturnUrl%22:%20%22https:%2F%2Fusercenter2.aliyun.com%22,%20%22Service%22:%20%22Consume%22%7D">AliyunConsumeDump2OSSRole</a> permission.</description></item>
        /// <item><description>The following file name formats are supported for bills:</description></item>
        /// </list>
        /// <pre><c>BillingItemDetailForBillingPeriod
        ///   
        /// File name format of a daily bill: UID_PartnerBillingItemDetail_YYYYMMDD_SquenceNo_fileNo. Example: 169**_BillingItemDetail_20190310_0001_01. 
        ///   
        /// File name format of a monthly full-data bill: UID_PartnerBillingItemDetail_YYYYMM_SquenceNo_fileNo. Example: 169**_BillingItemDetail_201903_0001_01. 
        /// InstanceDetailForBillingPeriod
        ///  
        ///  File name format of a daily bill: UID_PartnerInstanceDetail_YYYYMMDD_SquenceNo_fileNo. Example: 169**_InstanceDetail_20190310_0001_01. 
        ///   
        /// File name format of a monthly full-data bill: UID_PartnerInstanceDetail_YYYYMM_SquenceNo_fileNo. Example: 169**_InstanceDetail_201903_1999-0001_01. 
        /// BillingItemDetailMonthly
        ///   
        /// File name format of a daily bill: UID_PartnerBillingItemDetailMonthly_YYYYMM_SquenceNo_fileNo. Example: 169**_BillingItemDetailMonthly_201903_0001_01. This bill contains the bill data that is generated from the beginning of the current month to the fifth day of the next month. 
        /// InstanceDetailMonthly
        ///   
        /// File name format of a daily bill: UID_PartnerInstanceDetailMonthly_YYYYMM_SquenceNo_fileNo. Example: 169**_InstanceDetailMonthly_201903_0001_01. This bill contains the bill data that is generated from the beginning of the current month to the fifth day of the next month. 
        /// The fileNo field exists only when the number of bill rows reaches the maximum rows in a single bill file and the bill is split into multiple files.
        /// </c></pre>
        /// <para>**This topic is published only on the international site (alibabacloud.com).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubscriptionBillRequest
        /// </param>
        /// 
        /// <returns>
        /// SubscriptionBillResponse
        /// </returns>
        public SubscriptionBillResponse SubscriptionBill(SubscriptionBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubscriptionBillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates the subscription to multi-level bills as an Alibaba Cloud eco-partner.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Make sure that you are a distributor of the Alibaba Cloud international ecosystem.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation to subscribe to only one type of bill at a time.</description></item>
        /// <item><description>After the subscription to a type of bill is generated, the bill for the previous day is pushed on a daily basis from the next day. On the fifth day of each month, the full-data bill for the previous month is pushed.</description></item>
        /// <item><description>A daily bill may be delayed. The delayed bill is pushed the next day after it is generated. The delayed bill may contain the bill data that is delayed until the previous day. We recommend that you query the full-data bill for the previous month at the beginning of each month.</description></item>
        /// <item><description>Your account must be granted the <a href="https://ram.console.aliyun.com/?spm=api-workbench.API%20Document.0.0.68c71e0fhmTSJp#/role/authorize?request=%7B%22Requests%22:%20%7B%22request1%22:%20%7B%22RoleName%22:%20%22AliyunConsumeDump2OSSRole%22,%20%22TemplateId%22:%20%22Dump2OSSRole%22%7D%7D,%20%22ReturnUrl%22:%20%22https:%2F%2Fusercenter2.aliyun.com%22,%20%22Service%22:%20%22Consume%22%7D">AliyunConsumeDump2OSSRole</a> permission.</description></item>
        /// <item><description>The following file name formats are supported for bills:</description></item>
        /// </list>
        /// <pre><c>BillingItemDetailForBillingPeriod
        ///   
        /// File name format of a daily bill: UID_PartnerBillingItemDetail_YYYYMMDD_SquenceNo_fileNo. Example: 169**_BillingItemDetail_20190310_0001_01. 
        ///   
        /// File name format of a monthly full-data bill: UID_PartnerBillingItemDetail_YYYYMM_SquenceNo_fileNo. Example: 169**_BillingItemDetail_201903_0001_01. 
        /// InstanceDetailForBillingPeriod
        ///  
        ///  File name format of a daily bill: UID_PartnerInstanceDetail_YYYYMMDD_SquenceNo_fileNo. Example: 169**_InstanceDetail_20190310_0001_01. 
        ///   
        /// File name format of a monthly full-data bill: UID_PartnerInstanceDetail_YYYYMM_SquenceNo_fileNo. Example: 169**_InstanceDetail_201903_1999-0001_01. 
        /// BillingItemDetailMonthly
        ///   
        /// File name format of a daily bill: UID_PartnerBillingItemDetailMonthly_YYYYMM_SquenceNo_fileNo. Example: 169**_BillingItemDetailMonthly_201903_0001_01. This bill contains the bill data that is generated from the beginning of the current month to the fifth day of the next month. 
        /// InstanceDetailMonthly
        ///   
        /// File name format of a daily bill: UID_PartnerInstanceDetailMonthly_YYYYMM_SquenceNo_fileNo. Example: 169**_InstanceDetailMonthly_201903_0001_01. This bill contains the bill data that is generated from the beginning of the current month to the fifth day of the next month. 
        /// The fileNo field exists only when the number of bill rows reaches the maximum rows in a single bill file and the bill is split into multiple files.
        /// </c></pre>
        /// <para>**This topic is published only on the international site (alibabacloud.com).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubscriptionBillRequest
        /// </param>
        /// 
        /// <returns>
        /// SubscriptionBillResponse
        /// </returns>
        public async Task<SubscriptionBillResponse> SubscriptionBillAsync(SubscriptionBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubscriptionBillWithOptionsAsync(request, runtime);
        }

    }
}
